using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RectangleF = System.Drawing.RectangleF;

namespace RiftAssistant.Rendering;

internal sealed class PluginSection(string name, Func<IReadOnlyList<IUIComponent>> components)
{
	public string Name { get; } = name;

	public IReadOnlyList<IUIComponent> Components => components();
}

public class SettingsMenu
{
	public const int X = 100;

	private readonly Lock pluginGate = new();
	private readonly SettingsWindow window;
	private readonly MenuWindow[] sideWindows;
	private volatile PluginSection[] pluginSections = [];

	internal SettingsMenu()
	{
		ItemFilterMenu = new ItemFilterMenu();
		PluginList = new PluginListMenu();
		sideWindows = [ItemFilterMenu, PluginList];
		window = new SettingsWindow(this, SettingsMenuOptions.CreatePages());
	}

	public bool ShowMenu
	{
		get => window.Visible;
		set => window.Visible = value;
	}

	internal ItemFilterMenu ItemFilterMenu { get; }

	internal PluginListMenu PluginList { get; }

	internal PluginSection[] PluginSections => pluginSections;

	public void AddOption(IMenuOption option)
	{
		AddPluginSection(new PluginSection(option.Name, option.GetComponents));
	}

	public void AddSection(string name, IEnumerable<IUIComponent> components)
	{
		var list = components.ToArray();
		AddPluginSection(new PluginSection(name, () => list));
	}

	internal void ClearPluginSections()
	{
		lock (pluginGate) {
			pluginSections = [];
		}

		window.Refresh();
	}

	internal void ToggleSideWindow(MenuWindow side)
	{
		bool open = !side.Visible;
		foreach (var other in sideWindows) {
			other.Visible = false;
		}

		side.Visible = open;
	}

	internal bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!ShowMenu) return false;
		if (!isMouseClicked) return false;

		KeyboardCapture.End();
		if (window.HandleInput(mouseX, mouseY, true)) return true;

		foreach (var side in sideWindows) {
			if (side.HandleInput(mouseX, mouseY, true)) return true;
		}

		return false;
	}

	internal bool HandleWheel(int mouseX, int mouseY, int delta)
	{
		if (!ShowMenu) return false;

		return window.HandleWheel(mouseX, mouseY, delta) || sideWindows.Any(side => side.HandleWheel(mouseX, mouseY, delta));
	}

	internal void Draw()
	{
		if (!ShowMenu) {
			foreach (var side in sideWindows) {
				side.Visible = false;
			}

			return;
		}

		if (CoreCollector.IsLoading) {
			ShowMenu = false;
			return;
		}

		int windowHeight = GameWindowManager.Window.Size.Height;
		int y = windowHeight > 0 ? Math.Clamp(windowHeight - window.Height - 10, 10, 150) : 150;
		window.Draw(X, y);
		foreach (var side in sideWindows) {
			side.Draw(X + window.Width + 10, y);
		}

		KeyboardCapture.EndIfStale();
	}

	private void AddPluginSection(PluginSection section)
	{
		lock (pluginGate) {
			pluginSections = [.. pluginSections, section];
		}

		window.Refresh();
	}
}

internal sealed class SettingsWindow : MenuWindow
{
	private readonly SettingsMenu owner;
	private readonly IReadOnlyList<SettingsPage> pages;

	private int pageIndex;
	private PluginSection? expandedSection;

	public SettingsWindow(SettingsMenu owner, IReadOnlyList<SettingsPage> pages) : base(390, 140, 380, 380)
	{
		this.owner = owner;
		this.pages = pages;
	}

	protected override string Title => "Settings";

	protected override string Subtitle => pageIndex < pages.Count ? pages[pageIndex].Name : "Plugin settings";

	public void Refresh()
	{
		Invalidate();
	}

	protected override void BuildSidebar(List<IUIComponent> rows)
	{
		for (int i = 0; i < pages.Count; i++) {
			int index = i;
			rows.Add(new NavRow(pages[i].Name, pages[i].Accent, () => pageIndex == index, () => SelectPage(index)));
		}

		rows.Add(new NavRow("Plugin settings", MenuColor.Positive, () => pageIndex == pages.Count, () => SelectPage(pages.Count)));
		rows.Add(new MenuHeading("Menus", 22));
		rows.Add(new NavRow("Item filter", ItemFilterPalette.Legendary, () => owner.ItemFilterMenu.Visible, () => owner.ToggleSideWindow(owner.ItemFilterMenu), ">"));
		rows.Add(new NavRow("Plugins", new MenuColor(240, 120, 200), () => owner.PluginList.Visible, () => owner.ToggleSideWindow(owner.PluginList), ">"));
	}

	protected override void BuildContent(List<IUIComponent> rows)
	{
		if (pageIndex < pages.Count) {
			rows.AddRange(pages[pageIndex].Rows);
			return;
		}

		var sections = owner.PluginSections;
		if (sections.Length == 0) {
			rows.Add(new MenuHint("No plugin has settings."));
			rows.Add(new MenuHint("A plugin property marked [PluginSetting] shows up here."));
			return;
		}

		foreach (var section in sections) {
			var current = section;
			rows.Add(new SectionHeaderRow(current.Name, () => current == expandedSection, () => ToggleSection(current), MenuColor.Positive));
			if (current == expandedSection) rows.AddRange(current.Components);
		}
	}

	private void SelectPage(int index)
	{
		KeyboardCapture.End();
		pageIndex = index;
		ScrollToTop();
	}

	private void ToggleSection(PluginSection section)
	{
		expandedSection = expandedSection == section ? null : section;
		Invalidate();
	}
}

public class MenuCheckbox(string label, bool initialState, int width = 200, int height = 20) : IUIComponent
{
	private const int BoxSize = 16;

	public RectangleF Bounds { get; set; } = new(0, 0, width, height);
	public string Label { get; set; } = label;
	public bool IsChecked { get; set; } = initialState;
	public Action<bool> OnToggled { get; set; } = null!;

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
