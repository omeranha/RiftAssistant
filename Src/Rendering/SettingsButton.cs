using System;
using System.Drawing.Drawing2D;
using RectangleF = System.Drawing.RectangleF;
using Vortice;
using Vortice.Direct2D1;

namespace RiftAssistant.Rendering;

internal sealed class SettingsButton
{
	private const int IconPadding = 2;

	private ID2D1Bitmap? iconBitmap;
	private ID2D1RenderTarget? iconRenderTarget;
	private int iconSize;
	private bool iconFailed;

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

		int size = (int)bounds.Height - 2 * IconPadding;
		var icon = GetIcon(size);
		if (icon != null) {
			float left = bounds.Left + (bounds.Width - size) / 2f;
			float top = bounds.Top + IconPadding;
			Overlay.Instance.renderTarget?.DrawBitmap(icon, new RawRectF(left, top, left + size, top + size), 1f, BitmapInterpolationMode.Linear, null);
			return;
		}

		var layout = MenuStyle.CenterFont.GetTextLayout("Settings");
		MenuStyle.CenterFont.DrawText(layout, bounds.Left + (bounds.Width - layout.Metrics.Width) / 2f, bounds.Top + (bounds.Height - layout.Metrics.Height) / 2f);
	}

	// Coordinates are relative to the game window, like the overlay's own drawing.
	public bool HandleClick(int x, int y)
	{
		if (!Visible || !Contains(x, y)) return false;

		Core.SettingsMenu.ShowMenu = !Core.SettingsMenu.ShowMenu;
		return true;
	}

	internal static RectangleF GetBounds()
	{
		var size = GameWindowManager.Window.Size;
		int height = Math.Max(18, Convert.ToInt32(size.Height * 0.022f));
		int margin = Math.Max(4, Convert.ToInt32(size.Height * 0.008f));
		return new RectangleF(size.Width - height - margin, size.Height - height - margin, height, height);
	}

	private ID2D1Bitmap? GetIcon(int size)
	{
		var renderTarget = Overlay.Instance.renderTarget;
		if (iconFailed || renderTarget == null || size < 1) return null;

		// A Direct2D bitmap only works with the render target that created it, and the overlay recreates that target on resize.
		if (iconBitmap != null && ReferenceEquals(iconRenderTarget, renderTarget) && iconSize == size) return iconBitmap;

		iconBitmap?.Dispose();
		iconBitmap = null;
		try {
			using var source = AppResources.Icon ?? throw new InvalidOperationException("the application icon is missing");
			using var original = source.ToBitmap();
			using var scaled = new System.Drawing.Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			using (var graphics = System.Drawing.Graphics.FromImage(scaled)) {
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.Clear(System.Drawing.Color.Transparent);
				graphics.DrawImage(original, 0, 0, size, size);
			}

			iconBitmap = Overlay.Instance.ToDirect2DBitmap(scaled);
			iconRenderTarget = renderTarget;
			iconSize = size;
		} catch (Exception ex) {
			iconFailed = true;
			Logger.LogException($"[settings button] could not create the icon, showing the text label instead: {ex.Message}");
		}

		return iconBitmap;
	}

	private static bool Contains(int x, int y)
	{
		var bounds = GetBounds();
		return x >= bounds.Left && x <= bounds.Right && y >= bounds.Top && y <= bounds.Bottom;
	}
}
