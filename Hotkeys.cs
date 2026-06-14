using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

public sealed class Hotkey(string name, string key, string[] modifiers = null)
{
	public string Name = name;
	public string[] Modifiers = modifiers ?? Array.Empty<string>();
	public Vk Key = Enum.TryParse(key, true, out Vk result) ? result : Vk.None;
}

internal static class Hotkeys
{
	private static readonly string FilePath = Path.Combine(Program.SettingsFolder, "hotkeys.json");
	private static readonly List<Hotkey> DefaultHotkeys = [
		new("exit", Vk.END.ToString(), ["ctrl"]),
		new("hideOverlay", Vk.F9.ToString()),
		new("statTracker", Vk.F10.ToString()),
		new("resetSession", Vk.R.ToString(), ["ctrl", "alt"]),
		new("openSettings", Vk.F12.ToString())
	];

	public static IReadOnlyList<Hotkey> Load()
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);

			if (!File.Exists(FilePath)) {
				Save();
				return DefaultHotkeys;
			}

			string json = File.ReadAllText(FilePath,Encoding.UTF8);
			using JsonDocument doc = JsonDocument.Parse(json);
			if (doc.RootElement.ValueKind != JsonValueKind.Array) return DefaultHotkeys;

			List<Hotkey> hotkeys = [];
			foreach (JsonElement element in doc.RootElement.EnumerateArray()) {
				string name = element.TryGetProperty("name", out var n) ? n.GetString() ?? "" : "";
				string key = element.TryGetProperty("key", out var k) ? k.GetString() ?? "" : "";
				string[] modifiers = element.TryGetProperty("modifiers", out var m) && m.ValueKind == JsonValueKind.Array
					? m.EnumerateArray().Select(mod => mod.GetString() ?? "").Where(mod => !string.IsNullOrEmpty(mod)).ToArray()
					: [];
				hotkeys.Add(new Hotkey(name, key, modifiers));
			}

			return hotkeys.Count > 0 ? hotkeys : DefaultHotkeys;
		} catch (Exception ex) {
			Logger.Info($"Error loading hotkeys: {ex}");
			return DefaultHotkeys;
		}
	}

	public static void Save()
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
			foreach (Hotkey hotkey in DefaultHotkeys) {
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
