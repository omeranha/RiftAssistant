#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RiftAssistant.Engine;

internal static class ItemFilter
{
	private const string DefaultResourceName = "item_filter_default.json";
	private static readonly TimeSpan PollInterval = TimeSpan.FromSeconds(1);
	private static readonly char[] OperatorChars = ['+', '=', '<'];
	private static readonly JsonSerializerOptions JsonOptions = new() {
		PropertyNameCaseInsensitive = true,
		ReadCommentHandling = JsonCommentHandling.Skip,
		AllowTrailingCommas = true,
		UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
		Converters = { new JsonStringEnumConverter(null, false) }
	};

	private static readonly RuleFile softcore = new("sc");
	private static readonly RuleFile hardcore = new("hc");
	private static long lastPoll = Stopwatch.GetTimestamp();

	internal abstract record Condition;

	internal sealed record StatCondition(string Code, char Operator, double Number, string? Text) : Condition;

	internal sealed record AtLeastCondition(int Required, Condition[] Conditions) : Condition;

	internal sealed record ItemFilterRule(string Group, ItemKeepDecision Decision, Condition[] Conditions);

	private sealed class RuleFile(string mode)
	{
		public readonly string FilePath = Path.Combine(Program.SettingsFolder, $"item_filter_{mode}.json");
		public ItemFilterRule[] Rules = [];
		public bool Loaded;
		public DateTime LastWriteUtc;
	}

	public static void Load()
	{
		Reload(softcore);
		Reload(hardcore);
		ReevaluateItems();
	}

	public static void ReloadIfChanged()
	{
		if (Stopwatch.GetElapsedTime(lastPoll) < PollInterval) return;

		lastPoll = Stopwatch.GetTimestamp();
		bool softcoreChanged = HasChanged(softcore);
		bool hardcoreChanged = HasChanged(hardcore);
		if (softcoreChanged) Reload(softcore);
		if (hardcoreChanged) Reload(hardcore);
		if (softcoreChanged || hardcoreChanged) ReevaluateItems();
	}

	public static ItemKeepDecision Evaluate(Item item)
	{
		if (item.Unidentified || item.SnoItem.SnoActor.Sno == ActorSnoEnum._demontrebuchetkey) return ItemKeepDecision.LooksGood;

		var rules = CoreCollector.LocalPlayer?.HeroIsHardcore == true ? hardcore.Rules : softcore.Rules;
		foreach (var rule in rules) {
			if (rule.Group != "all" && item.SnoItem.MainGroupCode != rule.Group && !item.SnoItem.HasGroupCode(rule.Group)) continue;
			if (rule.Conditions.All(condition => Matches(item, condition))) return rule.Decision;
		}

		return ItemKeepDecision.Irrelevant;
	}

	internal static string ReadDefaultText()
	{
		using var stream = typeof(ItemFilter).Assembly.GetManifestResourceStream(DefaultResourceName) ?? throw new InvalidOperationException($"missing embedded resource {DefaultResourceName}");
		using var reader = new StreamReader(stream, Encoding.UTF8);
		return reader.ReadToEnd();
	}

	internal static ItemFilterConfig Deserialize(string json)
	{
		return JsonSerializer.Deserialize<ItemFilterConfig>(json, JsonOptions) ?? new ItemFilterConfig();
	}

	internal static ItemFilterRule[] Compile(ItemFilterConfig config, Func<string, string> resolveAttribute, Action<string> reportError)
	{
		var definitions = (config.Definitions ?? []).Select(pair => (Name: pair.Key.Trim().ToLowerInvariant(), Value: (pair.Value ?? "").ToLowerInvariant())).ToArray();
		var entries = config.Rules ?? [];
		var rules = new List<ItemFilterRule>();

		for (int i = 0; i < entries.Count; i++) {
			var entry = entries[i];
			if (entry == null || !entry.Enabled) continue;

			try {
				string group = (entry.Group ?? "").Trim().ToLowerInvariant();
				if (group.Length == 0) throw new FormatException("missing group");

				string text = string.Join(" & ", entry.Conditions ?? []).ToLowerInvariant();
				foreach (var (name, value) in definitions) {
					text = text.Replace($"*{name}*", value);
				}

				var decision = entry.Decision == ItemFilterDecision.Sell ? ItemKeepDecision.DefinitelyBad : ItemKeepDecision.LooksGood;
				rules.Add(new ItemFilterRule(group, decision, [.. text.Split('&').Select(part => ParseCondition(part.Trim(), resolveAttribute))]));
			} catch (FormatException ex) {
				reportError($"rule {i + 1}: {ex.Message}");
			}
		}

		return [.. rules];
	}

	private static string? ResolveAttribute(string code)
	{
		return SnoData.Attributes.GetAttributeProcessor(code)?.Code;
	}

	private static bool HasChanged(RuleFile file)
	{
		return !File.Exists(file.FilePath) || File.GetLastWriteTimeUtc(file.FilePath) != file.LastWriteUtc;
	}

	private static void Reload(RuleFile file)
	{
		string fileName = Path.GetFileName(file.FilePath);
		string text;
		DateTime stamp;
		try {
			EnsureFileExists(file.FilePath);
			stamp = File.GetLastWriteTimeUtc(file.FilePath);
			text = File.ReadAllText(file.FilePath, Encoding.UTF8);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			if (file.Loaded) return;

			Logger.LogException($"[item filter {fileName}] {ex.Message}, using the default rules");
			Apply(file, ReadDefaultText(), fileName);
			return;
		}

		file.LastWriteUtc = stamp;
		try {
			Apply(file, text, fileName);
		} catch (JsonException ex) {
			Logger.LogException($"[item filter {fileName}] {ex.Message}" + (file.Loaded ? ", keeping the previous rules" : ", using the default rules"));
			if (!file.Loaded) Apply(file, ReadDefaultText(), fileName);
		}
	}

	private static void Apply(RuleFile file, string json, string fileName)
	{
		var config = Deserialize(json);
		file.Rules = Compile(config, ResolveAttribute, message => Logger.LogException($"[item filter {fileName}] {message}"));
		file.Loaded = true;
	}

	internal static void EnsureFileExists(string path)
	{
		if (File.Exists(path)) return;

		Directory.CreateDirectory(Path.GetDirectoryName(path));
		File.WriteAllText(path, ReadDefaultText(), new UTF8Encoding(false));
	}

	private static void ReevaluateItems()
	{
		if (CoreCollector.ItemCollector == null) return;

		foreach (var item in CoreCollector.ItemCollector.Items.Values) {
			item.KeepDecision = CoreCollector.ItemCollector.DecideKeep(item);
		}
	}

	private static Condition ParseCondition(string text, Func<string, string> resolveAttribute)
	{
		if (!text.StartsWith("at_least[", StringComparison.Ordinal)) return ParseStat(text, resolveAttribute);

		string[] parts = text["at_least[".Length..].TrimEnd(']').Split(',');
		return new AtLeastCondition(int.Parse(parts[0], CultureInfo.InvariantCulture), [.. parts.Skip(1).Select(part => ParseStat(part.Trim(), resolveAttribute))]);
	}

	private static StatCondition ParseStat(string text, Func<string, string> resolveAttribute)
	{
		string[] parts = text.Split(OperatorChars);
		if (parts.Length != 2) throw new FormatException($"invalid condition '{text}'");

		string code = resolveAttribute(parts[0]) ?? throw new FormatException($"unknown attribute '{parts[0]}'");
		char op = text[parts[0].Length];
		return double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double number)
			? new StatCondition(code, op, number, null)
			: new StatCondition(code, op, 0, parts[1]);
	}

	private static bool Matches(Item item, Condition condition)
	{
		return condition switch {
			AtLeastCondition atLeast => atLeast.Conditions.Count(inner => Matches(item, inner)) >= atLeast.Required,
			StatCondition stat => Matches(item, stat),
			_ => false
		};
	}

	private static bool Matches(Item item, StatCondition condition)
	{
		var stat = item.StatList2.GetValueOrDefault(condition.Code);
		if (stat == null) return condition.Operator == '=' && condition.Text == null && condition.Number == -1.0;

		return condition.Operator switch {
			'=' when condition.Text != null => string.Equals(stat.StringValue, condition.Text, StringComparison.OrdinalIgnoreCase),
			'=' => stat.DoubleValue == condition.Number,
			'+' => stat.DoubleValue >= condition.Number,
			'<' => stat.DoubleValue < condition.Number,
			_ => false
		};
	}
}
