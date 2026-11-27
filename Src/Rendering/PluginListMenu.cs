using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RiftAssistant.Rendering;

internal sealed class PluginListMenu : MenuWindow
{
	private static readonly string[] StateLabels = ["All", "On", "Off"];

	private readonly string pluginSettings = Path.Combine(Program.SettingsFolder, "plugins_states.json");
	private readonly MenuSearchBox searchBox;

	private volatile PluginEntry[] entries = [];
	private string query = "";
	private int stateTab;
	private int enabledCount = -1;
	private int reloading;

	private sealed record PluginEntry(string Name, string DisplayName, IPlugin Plugin);

	public PluginListMenu() : base(360, 0, 0, 400)
	{
		searchBox = new MenuSearchBox("Search", () => query, value => {
			query = value;
			ScrollToTop();
		});
	}

	protected override string Title => "Plugins";

	protected override string Subtitle => entries.Length == 0 ? "none loaded" : $"{entries.Count(entry => entry.Plugin.Enabled)}/{entries.Length} enabled";

	protected override bool NeedsRebuild => enabledCount != entries.Count(entry => entry.Plugin.Enabled);

	protected override void OnVisibleChanged(bool isVisible)
	{
		if (!isVisible) return;

		query = "";
		stateTab = 0;
		searchBox.StartEditing();
	}

	protected override void BuildPinned(List<IUIComponent> rows)
	{
		rows.Add(searchBox);
		rows.Add(new MenuTabRow(StateLabels, () => stateTab, index => {
			stateTab = index;
			ScrollToTop();
		}));
		rows.Add(new MenuActionButton(() => reloading == 1 ? "Reloading plugins..." : "Reload plugins", ReloadPlugins, MenuColor.Gold));
	}

	protected override void BuildContent(List<IUIComponent> rows)
	{
		var snapshot = entries;
		enabledCount = snapshot.Count(entry => entry.Plugin.Enabled);
		var words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		bool any = false;
		foreach (var entry in snapshot) {
			bool enabled = entry.Plugin.Enabled;
			if ((stateTab == 1 && !enabled) || (stateTab == 2 && enabled)) continue;
			if (!words.All(word => entry.DisplayName.Contains(word, StringComparison.OrdinalIgnoreCase) || entry.Name.Contains(word, StringComparison.OrdinalIgnoreCase))) continue;

			var current = entry;
			rows.Add(new SettingToggleRow(current.DisplayName, () => current.Plugin.Enabled, value => {
				current.Plugin.Enabled = value;
				Save();
			}));
			any = true;
		}

		if (!any) rows.Add(new MenuHint(snapshot.Length == 0 ? "No plugins are loaded." : "No plugins match."));
	}

	public void ReloadPlugins()
	{
		if (Interlocked.Exchange(ref reloading, 1) == 1) return;

		Task.Run(() => {
			try {
				Core.PluginHandler.LoadPlugins(true);
				Reload();
			} catch (Exception ex) {
				Logger.LogException($"[plugins] reload failed: {ex}");
			} finally {
				reloading = 0;
			}
		});
	}

	public void Reload()
	{
		entries = [.. Core.PluginHandler.Plugins.Select(plugin => new PluginEntry(plugin.GetType().Name, PluginSettingsBinder.DisplayName(plugin.GetType().Name), plugin)).OrderBy(entry => entry.DisplayName, StringComparer.OrdinalIgnoreCase)];
		LoadEnabledPlugins();
		Invalidate();
	}

	public void Save()
	{
		try {
			Directory.CreateDirectory(Path.GetDirectoryName(pluginSettings)!);
			string temporaryPath = pluginSettings + ".tmp";
			using (FileStream fs = File.Create(temporaryPath))
			using (var writer = new Utf8JsonWriter(fs, new JsonWriterOptions { Indented = true })) {
				writer.WriteStartObject();
				foreach (var entry in entries) {
					writer.WriteBoolean(entry.Name, entry.Plugin.Enabled);
				}

				writer.WriteEndObject();
			}

			File.Move(temporaryPath, pluginSettings, true);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[plugins] could not save {Path.GetFileName(pluginSettings)}: {ex.Message}");
		}
	}

	private void LoadEnabledPlugins()
	{
		if (!File.Exists(pluginSettings)) return;

		try {
			using JsonDocument doc = JsonDocument.Parse(File.ReadAllText(pluginSettings));
			foreach (var entry in entries) {
				if (doc.RootElement.TryGetProperty(entry.Name, out var property) && property.ValueKind is JsonValueKind.True or JsonValueKind.False) entry.Plugin.Enabled = property.GetBoolean();
			}
		} catch (Exception ex) when (ex is JsonException or IOException or UnauthorizedAccessException) {
			Logger.LogException($"[plugins] could not read {Path.GetFileName(pluginSettings)}, the plugins keep their default state: {ex.Message}");
		}
	}
}
