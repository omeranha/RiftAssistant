using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace RiftAssistant.Engine;

internal static class ItemFilterStore
{
	private static readonly TimeSpan SaveDelay = TimeSpan.FromMilliseconds(500);
	private static readonly JsonSerializerOptions JsonOptions = new() {
		WriteIndented = true,
		Converters = { new JsonStringEnumConverter(null, false) }
	};
	private static readonly Lock Gate = new();

	private static string filePath = Path.Combine(Program.SettingsFolder, "item_filters.json");
	private static List<ItemFilterEntry> entries = [];
	private static volatile ItemFilterEntry[] snapshot = [];
	private static bool loaded;
	private static volatile bool saveRequested;
	private static volatile bool changed;
	private static long lastChange;

	public static ItemFilterEntry[] Snapshot
	{
		get {
			EnsureLoaded();
			return snapshot;
		}
	}

	public static int Count => Snapshot.Length;

	public static int Version { get; private set; }

	internal static void UseFile(string path)
	{
		lock (Gate) {
			filePath = path;
			entries = [];
			snapshot = [];
			loaded = false;
			saveRequested = false;
			changed = false;
		}
	}

	public static bool TakeChanged()
	{
		bool value = changed;
		changed = false;
		return value;
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
		lock (Gate) {
			json = JsonSerializer.Serialize(new ItemFilterFile { Filters = entries }, JsonOptions);
		}

		try {
			Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
			string temporaryPath = filePath + ".tmp";
			File.WriteAllText(temporaryPath, json, new UTF8Encoding(false));
			File.Move(temporaryPath, filePath, true);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[item filters] could not save {Path.GetFileName(filePath)}: {ex.Message}");
		}
	}

	public static ItemFilterEntry Add()
	{
		var entry = new ItemFilterEntry();
		Edit(list => list.Add(entry));
		return entry;
	}

	public static void Remove(ItemFilterEntry entry)
	{
		Edit(list => list.Remove(entry));
	}

	public static void Move(ItemFilterEntry entry, int offset)
	{
		Edit(list => {
			int index = list.IndexOf(entry);
			int target = index + offset;
			if (index < 0 || target < 0 || target >= list.Count) return;

			list.RemoveAt(index);
			list.Insert(target, entry);
		});
	}

	// Call after changing a property of an entry in place.
	public static void Touch()
	{
		Edit(_ => { });
	}

	private static void Edit(Action<List<ItemFilterEntry>> change)
	{
		lock (Gate) {
			EnsureLoadedLocked();
			change(entries);
			snapshot = [.. entries];
			Version++;
			lastChange = Stopwatch.GetTimestamp();
			saveRequested = true;
			changed = true;
		}
	}

	private static void EnsureLoaded()
	{
		if (loaded) return;

		lock (Gate) {
			EnsureLoadedLocked();
		}
	}

	private static void EnsureLoadedLocked()
	{
		if (loaded) return;

		loaded = true;
		Read();
	}

	private static void Read()
	{
		try {
			if (!File.Exists(filePath)) return;

			var file = JsonSerializer.Deserialize<ItemFilterFile>(File.ReadAllText(filePath, Encoding.UTF8), JsonOptions) ?? new ItemFilterFile();
			entries = [.. file.Filters.Where(entry => entry != null).Select(Normalize)];
			snapshot = [.. entries];
		} catch (Exception ex) when (ex is JsonException or IOException or UnauthorizedAccessException) {
			Logger.LogException($"[item filters] could not read {Path.GetFileName(filePath)}, starting with no filters: {ex.Message}");
			try {
				File.Copy(filePath, filePath + ".invalid", true);
			} catch (Exception copyEx) when (copyEx is IOException or UnauthorizedAccessException) {
			}
		}
	}

	private static ItemFilterEntry Normalize(ItemFilterEntry entry)
	{
		entry.Item = (entry.Item ?? "").Trim();
		entry.Stats = [.. (entry.Stats ?? []).Where(stat => stat != null && !string.IsNullOrWhiteSpace(stat.Stat)).Select(stat => new ItemFilterStatEntry { Stat = stat.Stat.Trim().ToLowerInvariant(), Measure = stat.Measure, Min = stat.Min })];
		return entry;
	}
}
