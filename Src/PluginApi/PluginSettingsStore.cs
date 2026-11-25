using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using Plugins;

namespace RiftAssistant.PluginHost;

internal static class PluginSettingsStore
{
	private static readonly TimeSpan SaveDelay = TimeSpan.FromMilliseconds(500);
	private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
	private static readonly Lock Gate = new();

	private static Dictionary<string, Dictionary<string, JsonElement>> data = [];
	private static string filePath = Path.Combine(Program.SettingsFolder, "plugin_settings.json");
	private static bool loaded;
	private static volatile bool saveRequested;
	private static long lastChange;

	internal static void UseFile(string path)
	{
		lock (Gate) {
			filePath = path;
			data = [];
			loaded = false;
			saveRequested = false;
		}
	}

	public static IPluginSettings For(string pluginName)
	{
		return new Scope(pluginName);
	}

	public static void Tick()
	{
		if (saveRequested && Stopwatch.GetElapsedTime(lastChange) >= SaveDelay) Flush();
	}

	public static void Flush()
	{
		if (!saveRequested) return;

		saveRequested = false;
		string json;
		string path;
		lock (Gate) {
			json = JsonSerializer.Serialize(data, JsonOptions);
			path = filePath;
		}

		try {
			Directory.CreateDirectory(Path.GetDirectoryName(path)!);
			string temporaryPath = path + ".tmp";
			File.WriteAllText(temporaryPath, json, Encoding.UTF8);
			File.Move(temporaryPath, path, true);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[plugin settings] could not save {Path.GetFileName(path)}: {ex.Message}");
		}
	}

	private static void EnsureLoaded()
	{
		if (loaded) return;

		loaded = true;
		try {
			if (!File.Exists(filePath)) return;

			data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, JsonElement>>>(File.ReadAllText(filePath, Encoding.UTF8), JsonOptions) ?? [];
		} catch (Exception ex) when (ex is JsonException or IOException or UnauthorizedAccessException) {
			Logger.LogException($"[plugin settings] could not read {Path.GetFileName(filePath)}, using the defaults: {ex.Message}");
			data = [];
			try {
				File.Copy(filePath, filePath + ".invalid", true);
			} catch (Exception copyEx) when (copyEx is IOException or UnauthorizedAccessException) {
			}
		}
	}

	private static bool TryGet(string plugin, string key, out JsonElement value)
	{
		lock (Gate) {
			EnsureLoaded();
			if (data.TryGetValue(plugin, out var values) && values.TryGetValue(key, out value)) return true;
		}

		value = default;
		return false;
	}

	private static void Write(string plugin, string key, JsonElement value)
	{
		lock (Gate) {
			EnsureLoaded();
			if (!data.TryGetValue(plugin, out var values)) data[plugin] = values = [];
			values[key] = value;
			lastChange = Stopwatch.GetTimestamp();
			saveRequested = true;
		}
	}

	private sealed class Scope(string plugin) : IPluginSettings
	{
		public bool GetBool(string key, bool defaultValue)
		{
			if (TryGet(plugin, key, out var value) && value.ValueKind is JsonValueKind.True or JsonValueKind.False) return value.GetBoolean();

			return defaultValue;
		}

		public int GetInt(string key, int defaultValue)
		{
			if (TryGet(plugin, key, out var value) && value.ValueKind == JsonValueKind.Number && value.TryGetInt32(out int result)) return result;

			return defaultValue;
		}

		public string GetString(string key, string defaultValue)
		{
			if (TryGet(plugin, key, out var value) && value.ValueKind == JsonValueKind.String) return value.GetString() ?? defaultValue;

			return defaultValue;
		}

		public void Set(string key, bool value) => Write(plugin, key, JsonSerializer.SerializeToElement(value));

		public void Set(string key, int value) => Write(plugin, key, JsonSerializer.SerializeToElement(value));

		public void Set(string key, string value) => Write(plugin, key, JsonSerializer.SerializeToElement(value));
	}
}
