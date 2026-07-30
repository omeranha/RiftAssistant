using SharpDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class PluginListMenu()
{
	private readonly string pluginSettings = Path.Combine(Program.SettingsFolder, "plugins_states.json");

	public bool ShowPluginList { get; set; } = false;

	private readonly RenderBrush pluginsBackground = new(200, 0, 0, 0, 0f);

	public List<MenuCheckbox> pluginCheckboxes = [];

	public RectangleF pluginMenuBackgroundRect;

	private int x;
	private int y;

	public void DrawPluginList(int x, int y)
	{
		if (!ShowPluginList || pluginCheckboxes.Count == 0)
			return;

		this.x = x;
		this.y = y;
		int itemsPerColumn = 20;
		int itemHeight = 25;
		int maxColumns = 4;
		int columnWidth = pluginCheckboxes.Max(x => x.Label.Length * 8);
		int rowCount = Math.Min(pluginCheckboxes.Count, itemsPerColumn);
		int columnCount = Math.Min((int)Math.Ceiling(pluginCheckboxes.Count / (float)itemsPerColumn), maxColumns);
		float backgroundWidth = (columnCount * columnWidth) + 10;
		float backgroundHeight = (rowCount * itemHeight) + 40;
		pluginMenuBackgroundRect = new RectangleF(x, y, backgroundWidth, backgroundHeight);
		pluginsBackground.DrawRectangle(pluginMenuBackgroundRect);
		for (int i = 0; i < pluginCheckboxes.Count; i++) {
			int column = i / itemsPerColumn;
			int row = i % itemsPerColumn;
			if (column >= maxColumns) break;

			pluginCheckboxes[i].Bounds = new RectangleF(10 + (column * columnWidth), 20 + (row * itemHeight), columnWidth, itemHeight);
			pluginCheckboxes[i].Draw(x, y);
		}
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!ShowPluginList || !isMouseClicked) return false;

		foreach (var checkbox in pluginCheckboxes) {
			RectangleF clickRect = checkbox.GetBoxRect(x, y);
			if (clickRect.Contains(mouseX, mouseY)) return checkbox.HandleInput(mouseX, mouseY, true);
		}

		return false;
	}

	public void Save()
	{
		using FileStream fs = File.Create(pluginSettings);
		using var writer = new Utf8JsonWriter(fs, new JsonWriterOptions {
			Indented = true
		});

		writer.WriteStartObject();
		foreach (var checkbox in pluginCheckboxes) {
			writer.WriteBoolean(checkbox.Label, checkbox.IsChecked);
		}
		writer.WriteEndObject();
	}

	public void LoadEnabledPlugins()
	{
		if (!File.Exists(pluginSettings)) return;

		string json = File.ReadAllText(pluginSettings);
		using JsonDocument doc = JsonDocument.Parse(json);
		foreach (var checkbox in pluginCheckboxes) {
			if (doc.RootElement.TryGetProperty(checkbox.Label, out var property)) {
				checkbox.IsChecked = property.GetBoolean();
				Core.PluginHandler.Plugins.Find(p => p.GetType().Name == checkbox.Label).Enabled = checkbox.IsChecked;
			}
		}
	}

	public void Reload()
	{
		pluginCheckboxes.Clear();
		foreach (var plugin in Core.PluginHandler.Plugins) {
			pluginCheckboxes.Add(new MenuCheckbox(plugin.GetType().Name, plugin.Enabled) {
				OnToggled = (isChecked) => {
					plugin.Enabled = isChecked;
					Save();
				}
			});
		}
		LoadEnabledPlugins();
	}
}