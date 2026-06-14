using Plugins;
using SharpDX;
using System;
using System.Collections.Generic;
using work;

public class SettingsMenu
{
	public bool ShowMenu { get; set; } = false;

	private readonly RenderBrush background = new(200, 0, 0, 0, 0f);

	private readonly Settings settings;
	private bool layoutNeedsUpdate = true;

	public int Width { get; private set; } = 300;
	public int Height { get; private set; } = 100;

	public readonly int X = 100;
	public readonly int Y = 150;

	public readonly RenderFont titleFont = new(255, 255, 255, 255, "Arial", false, false, 12f, Alignment.Left, false, false);
	public readonly RenderFont optionsNameFont = new(255, 255, 255, 255, "Arial", false, false, 9f, Alignment.Left, false, false);
	public readonly RenderFont defaultFont = new(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, false);

	public List<IMenuOption> MenuOptions = [];

	private MenuButton closeButton;
	private MenuButton showPluginsButton;
	private MenuButton reloadPluginsButton;

	private const int ROW_PADDING = 15;

	public SettingsMenu(Settings settings)
	{
		this.settings = settings;

		closeButton = new MenuButton("X") {
			OnClick = () => ShowMenu = false
		};

		showPluginsButton = new MenuButton("Show Plugins") {
			OnClick = () => Core.PluginListMenu.ShowPluginList = !Core.PluginListMenu.ShowPluginList
		};

		reloadPluginsButton = new MenuButton("Reload Plugins") {
			OnClick = () => {
				Core.PluginHandler.LoadPlugins(true);
				Core.PluginListMenu.Reload();
			}
		};
	}

	public void AddOption(IMenuOption option)
	{
		MenuOptions.Add(option);
		layoutNeedsUpdate = true;
	}

	public void RecalculateLayout()
	{
		if (!layoutNeedsUpdate) return;
		layoutNeedsUpdate = false;

		int currentYOffset = 40;
		int maxWidth = 300;
		foreach (var option in MenuOptions) {
			int currentXOffset = 10;

			currentYOffset += ROW_PADDING;

			foreach (var component in option.GetComponents()) {
				component.Bounds = new RectangleF(currentXOffset, currentYOffset, component.Bounds.Width,component.Bounds.Height);

				maxWidth = (int)Math.Max(maxWidth, currentXOffset + component.Bounds.Width + 20);
				currentYOffset += (int)(component.Bounds.Height + 5);
			}

			currentYOffset += 15;
		}

		Width = maxWidth;
		Height = currentYOffset + 10;
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!ShowMenu) return false;

		RecalculateLayout();
		bool inputHandled = false;

		if ((mouseX >= X && mouseX <= X + Width && mouseY >= Y && mouseY <= Y + Height) || (Core.PluginListMenu.ShowPluginList && Core.PluginListMenu.pluginMenuBackgroundRect.Contains(mouseX, mouseY))) {
			inputHandled = true;
		}

		if (isMouseClicked) {
			float closeX = X + Width - closeButton.Bounds.Width - 5;
			float closeY = Y + 5;
			if (mouseX >= closeX && mouseX <= closeX + closeButton.Bounds.Width &&
				mouseY >= closeY && mouseY <= closeY + closeButton.Bounds.Height) {
				return closeButton.HandleInput(mouseX, mouseY, isMouseClicked);
			}

			float showPluginsX = X + Width - showPluginsButton.Bounds.Width - 5;
			float showPluginsY = Y + 25;
			if (mouseX >= showPluginsX && mouseX <= showPluginsX + showPluginsButton.Bounds.Width &&
				mouseY >= showPluginsY && mouseY <= showPluginsY + showPluginsButton.Bounds.Height) {
				return showPluginsButton.HandleInput(mouseX, mouseY, isMouseClicked);
			}

			float reloadPluginsX = X + Width - reloadPluginsButton.Bounds.Width - 5;
			float reloadPluginsY = Y + 45;
			if (mouseX >= reloadPluginsX && mouseX <= reloadPluginsX + reloadPluginsButton.Bounds.Width &&
				mouseY >= reloadPluginsY && mouseY <= reloadPluginsY + reloadPluginsButton.Bounds.Height) {
				return reloadPluginsButton.HandleInput(mouseX, mouseY, isMouseClicked);
			}

			if (Core.PluginListMenu.HandleInput(mouseX, mouseY, isMouseClicked)) return true;

			foreach (var option in MenuOptions) {
				foreach (var component in option.GetComponents()) {

					float worldX = X + component.Bounds.Left;
					float worldY = Y + component.Bounds.Top;
					if (mouseX >= worldX && mouseX <= worldX + component.Bounds.Width &&
						mouseY >= worldY && mouseY <= worldY + component.Bounds.Height) {
						if (component.HandleInput(mouseX, mouseY, isMouseClicked)) {
							return true;
						}
					}
				}
			}
		}

		return inputHandled && isMouseClicked;
	}

	public void Draw()
	{
		if (!ShowMenu) return;

		if (CoreCollector.IsLoading) {
			ShowMenu = false;
		}

		RecalculateLayout();
		background.DrawRectangle(new RectangleF(X, Y, Width, Height));

		closeButton.Draw((int)(X + Width - closeButton.Bounds.Width - 5), Y + 5);
		showPluginsButton.Draw((int)(X + Width - showPluginsButton.Bounds.Width - 5), Y + 30);
		reloadPluginsButton.Draw((int)(X + Width - reloadPluginsButton.Bounds.Width - 5), Y + 55);

		titleFont.DrawText("Settings", X + 10, Y + 10);
		foreach (var option in MenuOptions) {
			var components = option.GetComponents();
			if (components.Count > 0) {
				float categoryY = Y + components[0].Bounds.Top - ROW_PADDING;
				defaultFont.DrawText(option.Name, X + 10, categoryY);
			}

			foreach (var comp in components) {
				comp.Draw(X, Y);
			}
		}

		if (Core.PluginListMenu.ShowPluginList) {
			Core.PluginListMenu.DrawPluginList(X + Width + 10, Y);
		}
	}
}

public class MenuCheckbox(string label, bool initialState, int width = 200, int height = 20) : IUIComponent
{
	private const int BoxSize = 16;

	public RectangleF Bounds { get; set; } = new(0, 0, width, height);
	public string Label { get; set; } = label;
	public bool IsChecked { get; set; } = initialState;
	public Action<bool> OnToggled { get; set; }

	private readonly RenderFont font = new(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, false);
	private readonly RenderFont checkFont = new(255, 255, 255, 255, "Arial", true, false, 8f, Alignment.Center, false, false);
	private readonly RenderBrush borderBrush = new(100, 60, 60, 60, 0f);
	private readonly RenderBrush fillBrushUnchecked = new(255, 30, 30, 30, 1f);
	private readonly RenderBrush fillBrushChecked = new(255, 128, 128, 128, 1f);

	public RectangleF GetBoxRect(float menuX, float menuY)
	{
		float worldX = menuX + Bounds.Left;
		float worldY = menuY + Bounds.Top;

		return new RectangleF(worldX, worldY + (Bounds.Height - BoxSize) / 2f, BoxSize, BoxSize);
	}

	public void Draw(int menuX, int menuY)
	{
		RectangleF boxRect = GetBoxRect(menuX, menuY);
		var fill = IsChecked ? fillBrushChecked : fillBrushUnchecked;
		fill.DrawRectangle(boxRect);
		borderBrush.DrawRectangle(boxRect);
		if (IsChecked) {
			var checkLayout = checkFont.GetTextLayout("X");
			checkFont.DrawText(checkLayout, boxRect.Left + (boxRect.Width - checkLayout.Metrics.Width) / 2f, boxRect.Top + (boxRect.Height - checkLayout.Metrics.Height) / 2f);
		}

		float worldX = menuX + Bounds.Left;
		float worldY = menuY + Bounds.Top;
		var layout = font.GetTextLayout(Label);
		font.DrawText(layout, worldX + BoxSize + 8, worldY + (Bounds.Height - layout.Metrics.Height) / 2f);
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		IsChecked = !IsChecked;
		OnToggled?.Invoke(IsChecked);
		return true;
	}
}

public class MenuButton : IUIComponent
{
	public RectangleF Bounds { get; set; }
	public string Label { get; set; }
	public Action OnClick { get; set; }

	private readonly RenderFont font = new(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Center, false, false);
	private readonly RenderBrush borderBrush = new(255, 128, 128, 128, 0f);
	private readonly RenderBrush fillBrush = new(255, 64, 64, 64, 1f);

	public MenuButton(string label, int overriddenWidth = 0, int overriddenHeight = 0)
	{
		Label = label;
		if (overriddenWidth == 0 || overriddenHeight == 0) {
			var autoLayout = font.GetTextLayout(label);
			float calculatedWidth = overriddenWidth > 0 ? overriddenWidth : autoLayout.Metrics.Width + 12f;
			float calculatedHeight = overriddenHeight > 0 ? overriddenHeight : autoLayout.Metrics.Height + 6f;

			Bounds = new RectangleF(0, 0, calculatedWidth, calculatedHeight);
		} else {
			Bounds = new RectangleF(0, 0, overriddenWidth, overriddenHeight);
		}
	}

	public void Draw(int menuX, int menuY)
	{
		float worldX = menuX + Bounds.Left;
		float worldY = menuY + Bounds.Top;

		fillBrush.DrawRectangle(new RectangleF(worldX, worldY, Bounds.Width, Bounds.Height));
		borderBrush.DrawRectangle(new RectangleF(worldX, worldY, Bounds.Width, Bounds.Height));

		var layout = font.GetTextLayout(Label);
		float textX = worldX + (Bounds.Width / 2f) - (layout.Metrics.Width / 2f);
		float textY = worldY + (Bounds.Height / 2f) - (layout.Metrics.Height / 2f);
		font.DrawText(layout, textX, textY);
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (isMouseClicked) {
			OnClick?.Invoke();
			return true;
		}
		return false;
	}
}