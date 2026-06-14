using System;
using System.IO;
using System.Text;
using System.Text.Json;
using work;

internal static class SettingsManager
{
	private static readonly string FilePath = Path.Combine(Program.SettingsFolder, "settings.json");

	public static Settings Current { get; private set; } = new();

	public static Settings Load()
	{
		try {
			Directory.CreateDirectory(Program.SettingsFolder);

			if (!File.Exists(FilePath)) {
				Save(Current);
				return Current;
			}

			string json = File.ReadAllText(FilePath, Encoding.UTF8);

			using JsonDocument doc = JsonDocument.Parse(json);

			JsonElement root = doc.RootElement;

			var settings = new Settings();

			ReadGeneralSettings(root, settings);
			//ReadUiSettings(root, settings);

			Current = settings;
			return settings;
		} catch {
			Current = new Settings();

			Save(Current);

			return Current;
		}
	}

	private static void ReadGeneralSettings(JsonElement root, Settings settings)
	{
		if (root.TryGetProperty("diabloWindowTitle", out JsonElement value))
			settings.DiabloWindowTitle = value.GetString() ?? "Diablo III";

		if (root.TryGetProperty("autoTerminate", out value))
			settings.AutoTerminate = value.GetBoolean();

		if (root.TryGetProperty("overlayFps", out value))
			settings.OverlayFps = value.GetInt32();
	}

	private static void ReadStatTracker(JsonElement element, StatTrackerSettings statTracker)
	{
		ReadBoolean(element, "enabled", v => statTracker.Enabled = v);

		ReadInt(element, "scaleWidth", v => statTracker.ScaleWidth = v);

		if (!element.TryGetProperty("columns", out JsonElement columns))
			return;

		ReadBoolean(columns, "experience", v => statTracker.Columns.Experience = v);
		ReadBoolean(columns, "goldPickup", v => statTracker.Columns.GoldPickup = v);
		ReadBoolean(columns, "goldDrop", v => statTracker.Columns.GoldDrop = v);
		ReadBoolean(columns, "killTotal", v => statTracker.Columns.KillTotal = v);
		ReadBoolean(columns, "killElite", v => statTracker.Columns.KillElite = v);
		ReadBoolean(columns, "dropAll", v => statTracker.Columns.DropAll = v);
		ReadBoolean(columns, "dropWhite", v => statTracker.Columns.DropWhite = v);
		ReadBoolean(columns, "dropMagic", v => statTracker.Columns.DropMagic = v);
		ReadBoolean(columns, "dropRare", v => statTracker.Columns.DropRare = v);
		ReadBoolean(columns, "dropLegendary", v => statTracker.Columns.DropLegendary = v);
		ReadBoolean(columns, "dropBloodShard", v => statTracker.Columns.DropBloodShard = v);
		ReadBoolean(columns, "death", v => statTracker.Columns.Death = v);
		ReadBoolean(columns, "damageDealtAll", v => statTracker.Columns.DamageDealtAll = v);
		ReadBoolean(columns, "damageDealtCrit", v => statTracker.Columns.DamageDealtCrit = v);
		ReadBoolean(columns, "damageTaken", v => statTracker.Columns.DamageTaken = v);
		ReadBoolean(columns, "healing", v => statTracker.Columns.Healing = v);
	}

	private static void ReadBoolean(JsonElement element, string name, Action<bool> setter)
	{
		if (element.TryGetProperty(name, out JsonElement value))
			setter(value.GetBoolean());
	}

	private static void ReadString(JsonElement element, string name, Action<string> setter)
	{
		if (element.TryGetProperty(name, out JsonElement value))
			setter(value.GetString() ?? "");
	}

	private static void ReadInt(JsonElement element, string name, Action<int> setter)
	{
		if (element.TryGetProperty(name, out JsonElement value))
			setter(value.GetInt32());
	}

	public static void Save(Settings settings = null)
	{
		settings ??= Current;

		Directory.CreateDirectory(Program.SettingsFolder);

		using FileStream fs = File.Create(FilePath);

		using var writer = new Utf8JsonWriter(fs, new JsonWriterOptions {
			Indented = true
		});

		writer.WriteStartObject();

		writer.WriteString("diabloWindowTitle", settings.DiabloWindowTitle);
		writer.WriteBoolean("autoTerminate", settings.AutoTerminate);
		writer.WriteNumber("overlayFps", settings.OverlayFps);

		writer.WriteStartObject("overlay");
		//WritePersonal(writer, settings.Overlay.Personal);
		//WritePortraits(writer, settings.Overlay.Portraits);
		WriteStatTracker(writer, settings.Overlay.StatTracker);
		writer.WriteEndObject();

		writer.WriteEndObject();
		writer.Flush();
	}

	private static void WriteStatTracker(Utf8JsonWriter writer, StatTrackerSettings statTracker)
	{
		writer.WriteStartObject("statTracker");

		writer.WriteBoolean("enabled", statTracker.Enabled);
		writer.WriteNumber("scaleWidth", statTracker.ScaleWidth);

		writer.WriteStartObject("columns");

		writer.WriteBoolean("experience", statTracker.Columns.Experience);
		writer.WriteBoolean("goldPickup", statTracker.Columns.GoldPickup);
		writer.WriteBoolean("goldDrop", statTracker.Columns.GoldDrop);
		writer.WriteBoolean("killTotal", statTracker.Columns.KillTotal);
		writer.WriteBoolean("killElite", statTracker.Columns.KillElite);
		writer.WriteBoolean("dropAll", statTracker.Columns.DropAll);
		writer.WriteBoolean("dropWhite", statTracker.Columns.DropWhite);
		writer.WriteBoolean("dropMagic", statTracker.Columns.DropMagic);
		writer.WriteBoolean("dropRare", statTracker.Columns.DropRare);
		writer.WriteBoolean("dropLegendary", statTracker.Columns.DropLegendary);
		writer.WriteBoolean("dropBloodShard", statTracker.Columns.DropBloodShard);
		writer.WriteBoolean("death", statTracker.Columns.Death);
		writer.WriteBoolean("damageDealtAll", statTracker.Columns.DamageDealtAll);
		writer.WriteBoolean("damageDealtCrit", statTracker.Columns.DamageDealtCrit);
		writer.WriteBoolean("damageTaken", statTracker.Columns.DamageTaken);
		writer.WriteBoolean("healing", statTracker.Columns.Healing);

		writer.WriteEndObject();

		writer.WriteEndObject();
	}
}

public sealed class Settings
{
	public string DiabloWindowTitle { get; set; } = "Diablo III";
	public bool AutoTerminate { get; set; } = false;
	public int OverlayFps { get; set; } = 30;
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
	public bool Enabled { get; set; } = false;

	public bool ShowImage { get; set; } = false;

	public bool EnableFade { get; set; } = true;
}

public sealed class Conditions
{
	public bool Enabled { get; set; } = false;
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
	public bool Enabled { get; set; } = false;

	public bool ShowRealDPS { get; set; } = false;

	public bool ShowRunDPS { get; set; } = false;

	public bool ShowTotalDPS { get; set; } = false;

	public bool EHP { get; set; } = false;

	public bool ShowInfo { get; set; } = true;
}

public sealed class StatTrackerSettings
{
	public bool Enabled { get; set; }

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
