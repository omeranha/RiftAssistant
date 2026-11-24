using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace RiftAssistant.Input;

public sealed class Hotkey(string name, string key, string[] modifiers = null)
{
	public string Name = name;
	public string[] Modifiers = modifiers ?? Array.Empty<string>();
	public Vk Key = Enum.TryParse(key, true, out Vk result) ? result : Vk.None;
}

internal static class Hotkeys
{
	private static readonly string FilePath = Path.Combine(Program.SettingsFolder, "hotkeys.json");
	private static List<Hotkey> CreateDefaults()
	{
		return [
			new("exit", Vk.END.ToString(), ["ctrl"]),
			new("hideOverlay", Vk.F9.ToString()),
			new("statTracker", Vk.F10.ToString()),
			new("resetSession", Vk.R.ToString(), ["ctrl", "alt"]),
			new("openSettings", Vk.F12.ToString())
		];
	}

	public static IReadOnlyList<Hotkey> Load()
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);

			if (!File.Exists(FilePath)) {
				var defaults = CreateDefaults();
				Save(defaults);
				return defaults;
			}

			string json = File.ReadAllText(FilePath,Encoding.UTF8);
			using JsonDocument doc = JsonDocument.Parse(json);
			if (doc.RootElement.ValueKind != JsonValueKind.Array) return CreateDefaults();

			List<Hotkey> hotkeys = [];
			foreach (JsonElement element in doc.RootElement.EnumerateArray()) {
				string name = element.TryGetProperty("name", out var n) ? n.GetString() ?? "" : "";
				string key = element.TryGetProperty("key", out var k) ? k.GetString() ?? "" : "";
				string[] modifiers = element.TryGetProperty("modifiers", out var m) && m.ValueKind == JsonValueKind.Array
					? m.EnumerateArray().Select(mod => mod.GetString() ?? "").Where(mod => !string.IsNullOrEmpty(mod)).ToArray()
					: [];
				hotkeys.Add(new Hotkey(name, key, modifiers));
			}

			return hotkeys.Count > 0 ? hotkeys : CreateDefaults();
		} catch (Exception ex) {
			Logger.Info($"Error loading hotkeys: {ex}");
			return CreateDefaults();
		}
	}

	public static string Describe(Hotkey hotkey)
	{
		if (hotkey.Key == Vk.None) return "none";

		string[] order = ["ctrl", "alt", "shift"];
		var parts = order.Where(modifier => hotkey.Modifiers.Contains(modifier)).Select(modifier => char.ToUpperInvariant(modifier[0]) + modifier[1..]).ToList();
		string keyName = hotkey.Key.ToString();
		bool isFunctionKey = keyName.Length > 1 && keyName[0] == 'F' && char.IsDigit(keyName[1]);
		parts.Add(keyName.Length > 1 && !isFunctionKey ? keyName[0] + keyName[1..].ToLowerInvariant() : keyName);
		return string.Join("+", parts);
	}

	public static void ResetToDefaults(IReadOnlyList<Hotkey> hotkeys)
	{
		foreach (var defaults in CreateDefaults()) {
			var target = hotkeys.FirstOrDefault(hotkey => hotkey.Name == defaults.Name);
			if (target == null) continue;

			target.Key = defaults.Key;
			target.Modifiers = defaults.Modifiers;
		}
	}

	public static void Save(IReadOnlyList<Hotkey> hotkeys)
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);
			using FileStream fs = File.Create(FilePath);
			using Utf8JsonWriter w = new(fs,
				new JsonWriterOptions {
					Indented = true
				}
			);

			w.WriteStartArray();
			foreach (Hotkey hotkey in hotkeys) {
				w.WriteStartObject();
				w.WriteString("name", hotkey.Name);
				w.WriteStartArray("modifiers");
				foreach (string modifier in hotkey.Modifiers) {
					w.WriteStringValue(modifier);
				}
				w.WriteEndArray();
				w.WriteString("key", hotkey.Key.ToString());
				w.WriteEndObject();
			}
			w.WriteEndArray();
			w.Flush();
		} catch (Exception ex) {
			Logger.Info($"Error saving hotkeys: {ex}");
		}
	}
}
