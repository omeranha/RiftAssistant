using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RiftAssistant.Rendering;

internal static class SettingsMenuOptions
{
	private static readonly TimeSpan ResetConfirmWindow = TimeSpan.FromSeconds(4);
	private static readonly Dictionary<string, string> HotkeyLabels = new() {
		["openSettings"] = "Open settings",
		["hideOverlay"] = "Hide overlay",
		["statTracker"] = "Toggle stat tracker",
		["resetSession"] = "Reset session",
		["exit"] = "Exit"
	};

	private static readonly List<SettingsSection> Sections = [];
	private static SettingsMenu menu;
	private static long resetArmedAt = -1;
	private static string hotkeyMessage = "";

	private static Settings Current => SettingsManager.Current;

	public static void Register(SettingsMenu settingsMenu)
	{
		menu = settingsMenu;

		AddSection("General", [
			new MenuChoice("Language (restart)", () => Current.Language, value => Update(s => s.Language = value), InstalledLanguages),
			new MenuTextBox("Window title", () => Current.DiabloWindowTitle, value => {
				if (value.Length > 0) Update(s => s.DiabloWindowTitle = value);
			})
		]);

		AddSection("Performance", [
			Number("Overlay FPS", s => s.OverlayFps, (s, v) => s.OverlayFps = v, 10, 240, 5),
			Toggle("Batched memory reads", s => s.BatchedMemoryReads, (s, v) => s.BatchedMemoryReads = v),
			Toggle("Verify batched reads", s => s.VerifyBatchedReads, (s, v) => s.VerifyBatchedReads = v)
		]);

		AddSection("Overlay", [
			Toggle("Lobby heroes", s => s.Overlay.EnableLobbyHeroes, (s, v) => s.Overlay.EnableLobbyHeroes = v),
			Toggle("Health bar", s => s.Overlay.ShowHealthBar, (s, v) => s.Overlay.ShowHealthBar = v),
			Toggle("Resources bar", s => s.Overlay.ShowResourcesBar, (s, v) => s.Overlay.ShowResourcesBar = v)
		]);

		AddSection("Skill cooldowns", [
			Toggle("Enabled", s => s.Overlay.SkillCooldowns.Enabled, (s, v) => s.Overlay.SkillCooldowns.Enabled = v),
			Toggle("Skill icons", s => s.Overlay.SkillCooldowns.ShowSkillIcon, (s, v) => s.Overlay.SkillCooldowns.ShowSkillIcon = v),
			Toggle("Fade", s => s.Overlay.SkillCooldowns.EnableFade, (s, v) => s.Overlay.SkillCooldowns.EnableFade = v)
		]);

		AddSection("Portrait stats", [
			Toggle("Enabled", s => s.Overlay.PortraitPlayerStats.Enabled, (s, v) => s.Overlay.PortraitPlayerStats.Enabled = v),
			Toggle("Real DPS", s => s.Overlay.PortraitPlayerStats.ShowRealDPS, (s, v) => s.Overlay.PortraitPlayerStats.ShowRealDPS = v),
			Toggle("Run DPS", s => s.Overlay.PortraitPlayerStats.ShowRunDPS, (s, v) => s.Overlay.PortraitPlayerStats.ShowRunDPS = v),
			Toggle("Total DPS", s => s.Overlay.PortraitPlayerStats.ShowTotalDPS, (s, v) => s.Overlay.PortraitPlayerStats.ShowTotalDPS = v),
			Toggle("EHP", s => s.Overlay.PortraitPlayerStats.EHP, (s, v) => s.Overlay.PortraitPlayerStats.EHP = v),
			Toggle("Info", s => s.Overlay.PortraitPlayerStats.ShowInfo, (s, v) => s.Overlay.PortraitPlayerStats.ShowInfo = v)
		]);

		AddSection("Stat tracker", [
			Toggle("Enabled", s => s.Overlay.StatTracker.Enabled, (s, v) => s.Overlay.StatTracker.Enabled = v),
			Number("Width (%)", s => s.Overlay.StatTracker.ScaleWidth, (s, v) => s.Overlay.StatTracker.ScaleWidth = v, 50, 300, 10)
		]);

		AddSection("Stat tracker columns", [
			Toggle("Experience", s => s.Overlay.StatTracker.Columns.Experience, (s, v) => s.Overlay.StatTracker.Columns.Experience = v),
			Toggle("Gold picked up", s => s.Overlay.StatTracker.Columns.GoldPickup, (s, v) => s.Overlay.StatTracker.Columns.GoldPickup = v),
			Toggle("Gold dropped", s => s.Overlay.StatTracker.Columns.GoldDrop, (s, v) => s.Overlay.StatTracker.Columns.GoldDrop = v),
			Toggle("Kills", s => s.Overlay.StatTracker.Columns.KillTotal, (s, v) => s.Overlay.StatTracker.Columns.KillTotal = v),
			Toggle("Elite kills", s => s.Overlay.StatTracker.Columns.KillElite, (s, v) => s.Overlay.StatTracker.Columns.KillElite = v),
			Toggle("Drops: all", s => s.Overlay.StatTracker.Columns.DropAll, (s, v) => s.Overlay.StatTracker.Columns.DropAll = v),
			Toggle("Drops: white", s => s.Overlay.StatTracker.Columns.DropWhite, (s, v) => s.Overlay.StatTracker.Columns.DropWhite = v),
			Toggle("Drops: magic", s => s.Overlay.StatTracker.Columns.DropMagic, (s, v) => s.Overlay.StatTracker.Columns.DropMagic = v),
			Toggle("Drops: rare", s => s.Overlay.StatTracker.Columns.DropRare, (s, v) => s.Overlay.StatTracker.Columns.DropRare = v),
			Toggle("Drops: legendary", s => s.Overlay.StatTracker.Columns.DropLegendary, (s, v) => s.Overlay.StatTracker.Columns.DropLegendary = v),
			Toggle("Drops: blood shards", s => s.Overlay.StatTracker.Columns.DropBloodShard, (s, v) => s.Overlay.StatTracker.Columns.DropBloodShard = v),
			Toggle("Deaths", s => s.Overlay.StatTracker.Columns.Death, (s, v) => s.Overlay.StatTracker.Columns.Death = v),
			Toggle("Damage dealt", s => s.Overlay.StatTracker.Columns.DamageDealtAll, (s, v) => s.Overlay.StatTracker.Columns.DamageDealtAll = v),
			Toggle("Crit damage dealt", s => s.Overlay.StatTracker.Columns.DamageDealtCrit, (s, v) => s.Overlay.StatTracker.Columns.DamageDealtCrit = v),
			Toggle("Damage taken", s => s.Overlay.StatTracker.Columns.DamageTaken, (s, v) => s.Overlay.StatTracker.Columns.DamageTaken = v),
			Toggle("Healing", s => s.Overlay.StatTracker.Columns.Healing, (s, v) => s.Overlay.StatTracker.Columns.Healing = v)
		]);

		AddSection("Inventory lock", [
			new MenuHint("Columns 0-9, rows 0-5. -1 turns the lock off."),
			Number("Left column", s => s.InventoryLock.LeftColumn, (s, v) => s.InventoryLock.LeftColumn = v, -1, 9, 1),
			Number("Top row", s => s.InventoryLock.TopRow, (s, v) => s.InventoryLock.TopRow = v, -1, 5, 1),
			Number("Right column", s => s.InventoryLock.RightColumn, (s, v) => s.InventoryLock.RightColumn = v, -1, 9, 1),
			Number("Bottom row", s => s.InventoryLock.BottomRow, (s, v) => s.InventoryLock.BottomRow = v, -1, 5, 1)
		]);

		AddSection("Hotkeys", [
			.. Core.HotkeyList.Select(hotkey => (IUIComponent)new MenuHotkeyRow(HotkeyLabels.GetValueOrDefault(hotkey.Name, hotkey.Name), () => Hotkeys.Describe(hotkey), key => AssignHotkey(hotkey, key))),
			new MenuHint(() => hotkeyMessage),
			new MenuActionButton(() => "Reset hotkeys", ResetHotkeys)
		]);

		AddSection("Files", [
			new MenuActionButton(() => "Open settings folder", OpenSettingsFolder),
			new MenuActionButton(() => IsResetArmed() ? "Click again to reset all settings" : "Reset all settings", ResetSettings)
		]);
	}

	private static void AddSection(string name, IEnumerable<IUIComponent> items)
	{
		var section = new SettingsSection(name, items, ToggleSection);
		Sections.Add(section);
		menu.AddBuiltInOption(section);
	}

	private static void ToggleSection(SettingsSection section)
	{
		bool expand = !section.Expanded;
		foreach (var other in Sections) {
			other.Expanded = false;
		}

		section.Expanded = expand;
		menu.InvalidateLayout();
	}

	private static IUIComponent Toggle(string label, Func<Settings, bool> get, Action<Settings, bool> set)
	{
		return new BoundCheckbox(label, () => get(Current), value => Update(s => set(s, value)));
	}

	private static IUIComponent Number(string label, Func<Settings, int> get, Action<Settings, int> set, int min, int max, int step)
	{
		return new MenuStepper(label, () => get(Current), value => Update(s => set(s, value)), min, max, step);
	}

	private static void Update(Action<Settings> change)
	{
		change(Current);
		SettingsManager.NotifyChanged();
	}

	private static IReadOnlyList<string> InstalledLanguages()
	{
		string folder = Path.Combine(Program.AppDir, "data");
		var languages = new SortedSet<string>(StringComparer.Ordinal) { Current.Language };
		if (Directory.Exists(folder)) {
			foreach (string file in Directory.GetFiles(folder, "strings_*.bin")) {
				languages.Add(Path.GetFileNameWithoutExtension(file)["strings_".Length..]);
			}
		}

		return [.. languages];
	}

	private static void AssignHotkey(Hotkey hotkey, CapturedKey key)
	{
		string[] modifiers = [.. new[] { (key.Ctrl, "ctrl"), (key.Alt, "alt"), (key.Shift, "shift") }.Where(modifier => modifier.Item1).Select(modifier => modifier.Item2)];
		var conflict = Core.HotkeyList.FirstOrDefault(other => other != hotkey && other.Key == key.Key && other.Modifiers.Order().SequenceEqual(modifiers.Order()));
		if (conflict != null) {
			hotkeyMessage = $"{Hotkeys.Describe(conflict)} is already used by {HotkeyLabels.GetValueOrDefault(conflict.Name, conflict.Name)}";
			return;
		}

		hotkey.Key = key.Key;
		hotkey.Modifiers = modifiers;
		hotkeyMessage = "";
		Hotkeys.Save(Core.HotkeyList);
	}

	private static void ResetHotkeys()
	{
		Hotkeys.ResetToDefaults(Core.HotkeyList);
		hotkeyMessage = "";
		Hotkeys.Save(Core.HotkeyList);
	}

	private static void OpenSettingsFolder()
	{
		Directory.CreateDirectory(Program.SettingsFolder);
		Process.Start(new ProcessStartInfo("explorer.exe", $"\"{Program.SettingsFolder}\""));
	}

	private static bool IsResetArmed()
	{
		return resetArmedAt >= 0 && Stopwatch.GetElapsedTime(resetArmedAt) < ResetConfirmWindow;
	}

	private static void ResetSettings()
	{
		if (!IsResetArmed()) {
			resetArmedAt = Stopwatch.GetTimestamp();
			return;
		}

		resetArmedAt = -1;
		SettingsManager.Reset();
	}
}
