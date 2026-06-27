using System;
using System.IO;
using System.Text;
using System.Text.Json;

internal static class SettingsManager
{
	private static readonly string FilePath = Path.Combine(Program.SettingsFolder, "settings.json");
	private static readonly JsonSerializerOptions JsonOptions = new() {
		WriteIndented = true
	};
	public static Settings Current { get; private set; } = new();

	public static Settings Load()
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);
			if (!File.Exists(FilePath)) {
				Current = new Settings();
				Save(Current);
				return Current;
			}

			string json = File.ReadAllText(FilePath, Encoding.UTF8);
			Current = JsonSerializer.Deserialize<Settings>(json, JsonOptions) ?? new Settings();
			return Current;
		} catch {
			Current = new Settings();
			Save(Current);
			return Current;
		}
	}

	public static void Save(Settings settings = null)
	{
		settings ??= Current;
		Directory.CreateDirectory(Program.SettingsFolder);
		string json = JsonSerializer.Serialize(settings, JsonOptions);
		File.WriteAllText(FilePath, json, Encoding.UTF8);
	}
}

public sealed class Settings
{
	public string DiabloWindowTitle { get; set; } = "Diablo III";
	public bool AutoTerminate { get; set; } = false;
	public int OverlayFps { get; set; } = 60;
	public OverlaySettings Overlay { get; set; } = new();
}

public sealed class OverlaySettings
{
	public bool EnableLobbyHeroes { get; set; } = true;

	public bool ShowHealthBar { get; set; } = true;

	public bool ShowResourcesBar { get; set; } = true;

	public SkillCooldowns SkillCooldowns { get; set; } = new();

	public PortraitPlayerStats PortraitPlayerStats { get; set; } = new();

	public StatTrackerSettings StatTracker { get; set; } = new();
}

public sealed class SkillCooldowns
{
	public bool Enabled { get; set; } = true;

	public bool ShowImage { get; set; } = true;

	public bool EnableFade { get; set; } = true;
}

public sealed class Conditions
{
	public bool Enabled { get; set; } = true;
	public bool OnlyOutTown { get; set; }
	public bool OnlyInTown { get; set; }
	public bool OnlyAtMaxLevel { get; set; }
	public bool OnlyIdle { get; set; }
	public string MouseNear { get; set; } = "";
	public string MouseFar { get; set; } = "";
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
