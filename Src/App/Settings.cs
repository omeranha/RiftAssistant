using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;

namespace RiftAssistant;

internal static class SettingsManager
{
	private static readonly string FilePath = Path.Combine(Program.SettingsFolder, "settings.json");
	private static readonly TimeSpan SaveDelay = TimeSpan.FromMilliseconds(500);
	private static readonly TimeSpan PollInterval = TimeSpan.FromSeconds(1);
	private static readonly JsonSerializerOptions JsonOptions = new() {
		WriteIndented = true,
		ReadCommentHandling = JsonCommentHandling.Skip,
		AllowTrailingCommas = true
	};

	private static volatile bool changeRequested;
	private static volatile bool saveRequested;
	private static long lastChange;
	private static long lastPoll = Stopwatch.GetTimestamp();
	private static DateTime lastWriteUtc;

	public static Settings Current { get; private set; } = new();

	public static event Action Changed;

	public static Settings Load()
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);
			if (!File.Exists(FilePath)) {
				Current = new Settings();
				Save(Current);
				return Current;
			}

			lastWriteUtc = File.GetLastWriteTimeUtc(FilePath);
			Current = Parse(File.ReadAllText(FilePath, Encoding.UTF8));
			return Current;
		} catch (Exception ex) {
			Logger.LogException($"[settings] could not read settings.json, using the defaults: {ex.Message}");
			BackUpInvalidFile();
			Current = new Settings();
			Save(Current);
			return Current;
		}
	}

	public static void Save(Settings settings = null)
	{
		settings ??= Current;
		Directory.CreateDirectory(Program.SettingsFolder);
		string temporaryPath = FilePath + ".tmp";
		File.WriteAllText(temporaryPath, JsonSerializer.Serialize(settings, JsonOptions), Encoding.UTF8);
		File.Move(temporaryPath, FilePath, true);
		lastWriteUtc = File.GetLastWriteTimeUtc(FilePath);
	}

	public static void Reset()
	{
		Current = new Settings();
		NotifyChanged();
	}

	public static void NotifyChanged()
	{
		lastChange = Stopwatch.GetTimestamp();
		saveRequested = true;
		changeRequested = true;
	}

	public static void Tick()
	{
		if (changeRequested) {
			changeRequested = false;
			Changed?.Invoke();
		}

		if (saveRequested) {
			if (Stopwatch.GetElapsedTime(lastChange) >= SaveDelay) Flush();
			return;
		}

		if (Stopwatch.GetElapsedTime(lastPoll) < PollInterval) return;

		lastPoll = Stopwatch.GetTimestamp();
		ReloadIfFileChanged();
	}

	public static void Flush()
	{
		if (!saveRequested) return;

		saveRequested = false;
		try {
			Save();
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[settings] could not save settings.json: {ex.Message}");
		}
	}

	private static Settings Parse(string json)
	{
		return JsonSerializer.Deserialize<Settings>(json, JsonOptions) ?? new Settings();
	}

	private static void ReloadIfFileChanged()
	{
		try {
			if (!File.Exists(FilePath)) {
				Save();
				return;
			}

			DateTime stamp = File.GetLastWriteTimeUtc(FilePath);
			if (stamp == lastWriteUtc) return;

			string json = File.ReadAllText(FilePath, Encoding.UTF8);
			lastWriteUtc = stamp;
			try {
				Current = Parse(json);
			} catch (JsonException ex) {
				Logger.LogException($"[settings] settings.json is invalid, keeping the previous settings: {ex.Message}");
				return;
			}

			Changed?.Invoke();
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			return;
		}
	}

	private static void BackUpInvalidFile()
	{
		try {
			if (File.Exists(FilePath)) File.Copy(FilePath, FilePath + ".invalid", true);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
		}
	}
}
public sealed class Settings
{
	public string DiabloWindowTitle { get; set; } = "Diablo III";
	public string Language { get; set; } = "enUS";
	public bool AutoTerminate { get; set; } = false;
	public int OverlayFps { get; set; } = 60;
	public bool BatchedMemoryReads { get; set; } = true;
	public bool VerifyBatchedReads { get; set; } = false;
	public OverlaySettings Overlay { get; set; } = new();
	public InventoryLockSettings InventoryLock { get; set; } = new();
}

public sealed class InventoryLockSettings
{
	public int LeftColumn { get; set; } = -1;
	public int TopRow { get; set; } = -1;
	public int RightColumn { get; set; } = -1;
	public int BottomRow { get; set; } = -1;
}

public sealed class OverlaySettings
{
	public bool EnableLobbyHeroes { get; set; } = true;

	public bool ShowHealthBar { get; set; } = true;

	public bool ShowResourcesBar { get; set; } = true;

	public bool ShowSettingsButton { get; set; } = true;

	public SkillCooldowns SkillCooldowns { get; set; } = new();

	public PortraitPlayerStats PortraitPlayerStats { get; set; } = new();

	public StatTrackerSettings StatTracker { get; set; } = new();
}

public sealed class SkillCooldowns
{
	public bool Enabled { get; set; } = true;

	public bool ShowSkillIcon { get; set; } = true;

	public bool EnableFade { get; set; } = true;
}

internal sealed class Conditions
{
	public bool Enabled { get; set; } = true;
	public bool OnlyOutTown { get; set; }
	public bool OnlyInTown { get; set; }
	public bool OnlyAtMaxLevel { get; set; }
	public bool OnlyIdle { get; set; }
	public string ActiveBuffs { get; set; } = "";
}

public sealed class PortraitPlayerStats
{
	public bool Enabled { get; set; } = true;

	public bool ShowRealDPS { get; set; } = true;

	public bool ShowRunDPS { get; set; } = true;

	public bool ShowTotalDPS { get; set; } = true;

	public bool EHP { get; set; } = true;

	public bool ShowInfo { get; set; } = true;
}

public sealed class StatTrackerSettings
{
	public bool Enabled { get; set; } = true;

	public int ScaleWidth { get; set; } = 100;

	public StatColumns Columns { get; set; } = new();
}

public sealed class StatColumns
{
	public bool Experience { get; set; } = true;

	public bool GoldPickup { get; set; } = true;

	public bool GoldDrop { get; set; } = true;

	public bool KillTotal { get; set; } = true;

	public bool KillElite { get; set; } = true;

	public bool DropAll { get; set; } = true;

	public bool DropWhite { get; set; } = true;

	public bool DropMagic { get; set; } = true;

	public bool DropRare { get; set; } = true;

	public bool DropLegendary { get; set; } = true;

	public bool DropBloodShard { get; set; } = true;

	public bool Death { get; set; } = true;

	public bool DamageDealtAll { get; set; } = true;

	public bool DamageDealtCrit { get; set; } = true;

	public bool DamageTaken { get; set; } = true;

	public bool Healing { get; set; }
}
