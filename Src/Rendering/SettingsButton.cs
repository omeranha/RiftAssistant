using System;
using SharpDX;

namespace RiftAssistant.Rendering;

internal sealed class SettingsButton
{
	private const string Label = "Settings";

	public bool Visible => Core.Settings.Overlay.ShowSettingsButton && !CoreCollector.IsLoading;

	public void Draw()
	{
		if (!Visible) return;

		var bounds = GetBounds();
		var window = GameWindowManager.Window;
		bool hovered = Contains(window.CursorX, window.CursorY);
		bool active = Core.SettingsMenu.ShowMenu;
		(hovered ? MenuStyle.HoverFill : active ? MenuStyle.ActiveFill : MenuStyle.Fill).DrawRectangle(bounds);
		MenuStyle.Outline.DrawRectangle(bounds);

		var layout = MenuStyle.CenterFont.GetTextLayout(Label);
		MenuStyle.CenterFont.DrawText(layout, bounds.Left + (bounds.Width - layout.Metrics.Width) / 2f, bounds.Top + (bounds.Height - layout.Metrics.Height) / 2f);
	}

	// Coordinates are relative to the game window, like the overlay's own drawing.
	public bool HandleClick(int x, int y)
	{
		if (!Visible || !Contains(x, y)) return false;

		Core.SettingsMenu.ShowMenu = !Core.SettingsMenu.ShowMenu;
		return true;
	}

	private static RectangleF GetBounds()
	{
		var size = GameWindowManager.Window.Size;
		int height = Math.Max(18, Convert.ToInt32(size.Height * 0.022f));
		int width = height * 4;
		int margin = Math.Max(4, Convert.ToInt32(size.Height * 0.008f));
		return new RectangleF(size.Width - width - margin, size.Height - height - margin, width, height);
	}

	private static bool Contains(int x, int y)
	{
		var bounds = GetBounds();
		return x >= bounds.Left && x <= bounds.Right && y >= bounds.Top && y <= bounds.Bottom;
	}
}
