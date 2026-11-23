using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace RiftAssistant.Engine;

internal static class Pickit
{
	private static readonly char[] OperatorChars = ['+', '=', '<'];

	private static PickitRule[] softcoreRules = [];
	private static PickitRule[] hardcoreRules = [];

	private abstract record Condition;

	private sealed record StatCondition(string Code, char Operator, double Number, string Text) : Condition;

	private sealed record AtLeastCondition(int Required, Condition[] Conditions) : Condition;

	private sealed record PickitRule(string Group, ItemKeepDecision Decision, Condition[] Conditions);

	public static void Load()
	{
		softcoreRules = LoadRules("sc");
		hardcoreRules = LoadRules("hc");

		if (CoreCollector.ItemCollector == null) return;

		foreach (var item in CoreCollector.ItemCollector.Items.Values) {
			item.KeepDecision = CoreCollector.ItemCollector.DecideKeep(item);
		}
	}

	public static ItemKeepDecision Evaluate(Item item)
	{
		if (item.Unidentified || item.SnoItem.SnoActor.Sno == ActorSnoEnum._demontrebuchetkey) return ItemKeepDecision.LooksGood;

		var rules = CoreCollector.LocalPlayer?.HeroIsHardcore == true ? hardcoreRules : softcoreRules;
		foreach (var rule in rules) {
			if (rule.Group != "all" && item.SnoItem.MainGroupCode != rule.Group && !item.SnoItem.HasGroupCode(rule.Group)) continue;
			if (rule.Conditions.All(condition => Matches(item, condition))) return rule.Decision;
		}

		return ItemKeepDecision.Irrelevant;
	}

	private static PickitRule[] LoadRules(string mode)
	{
		string directory = Path.Combine(Program.AppDir, "config");
		string path = Path.Combine(directory, $"pickit_{mode}_override.ini");
		if (!File.Exists(path)) path = Path.Combine(directory, $"pickit_{mode}_70.ini");
		if (!File.Exists(path)) return [];

		var rules = new List<PickitRule>();
		var definitions = new Dictionary<string, string>();
		string[] lines = File.ReadAllLines(path);

		for (int i = 0; i < lines.Length; i++) {
			string line = lines[i];
			int commentStart = line.IndexOf(';');
			if (commentStart >= 0) line = line[..commentStart];

			line = line.Trim().ToLowerInvariant();
			int separator = line.IndexOf('=');
			if (separator < 0) continue;

			string left = line[..separator].Trim();
			string right = line[(separator + 1)..].Trim();

			if (left.StartsWith('[')) {
				definitions[left.Trim('[', ']', ' ')] = right;
				continue;
			}

			foreach (var definition in definitions) {
				right = right.Replace($"*{definition.Key}*", definition.Value);
			}

			var decision = ItemKeepDecision.LooksGood;
			if (left.StartsWith('-')) {
				decision = ItemKeepDecision.DefinitelyBad;
				left = left[1..];
			} else if (left.StartsWith('+')) {
				left = left[1..];
			}

			try {
				rules.Add(new PickitRule(left, decision, [.. right.Split('&').Select(part => ParseCondition(part.Trim()))]));
			} catch (FormatException ex) {
				Logger.LogException($"[pickit {Path.GetFileName(path)}, line {i + 1}] {ex.Message}");
			}
		}

		return [.. rules];
	}

	private static Condition ParseCondition(string text)
	{
		if (!text.StartsWith("at_least[", StringComparison.Ordinal)) return ParseStat(text);

		string[] parts = text["at_least[".Length..].TrimEnd(']').Split(',');
		return new AtLeastCondition(int.Parse(parts[0], CultureInfo.InvariantCulture), [.. parts.Skip(1).Select(part => ParseStat(part.Trim()))]);
	}

	private static StatCondition ParseStat(string text)
	{
		string[] parts = text.Split(OperatorChars);
		if (parts.Length != 2) throw new FormatException($"invalid condition '{text}'");

		var processor = SnoData.Attributes.GetAttributeProcessor(parts[0]) ?? throw new FormatException($"unknown attribute '{parts[0]}'");
		char op = text[parts[0].Length];
		return double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double number)
			? new StatCondition(processor.Code, op, number, null)
			: new StatCondition(processor.Code, op, 0, parts[1]);
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