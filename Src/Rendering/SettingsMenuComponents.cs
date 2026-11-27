using System;
using System.Collections.Generic;
using System.Diagnostics;
using RectangleF = System.Drawing.RectangleF;

namespace RiftAssistant.Rendering;

internal static class MenuStyle
{
	public const int RowWidth = 260;
	public const int RowHeight = 20;
	public const int ControlHeight = 24;

	private static readonly Dictionary<int, RenderFont> ColorFonts = [];
	private static readonly Dictionary<int, RenderBrush> ColorFills = [];
	private static readonly Dictionary<int, RenderBrush> ColorOutlines = [];

	private static object? lastTarget;
	private static RenderFont? font;
	private static RenderFont? centerFont;
	private static RenderFont? hintFont;
	private static RenderFont? headingFont;
	private static RenderFont? titleFont;
	private static RenderBrush? fill;
	private static RenderBrush? activeFill;
	private static RenderBrush? hoverFill;
	private static RenderBrush? outline;

	public static RenderFont Font => font ??= new RenderFont(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, false);

	public static RenderFont CenterFont => centerFont ??= new RenderFont(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Center, false, false);

	public static RenderFont HintFont => hintFont ??= new RenderFont(255, 160, 160, 160, "Arial", false, false, 7f, Alignment.Left, false, false);

	public static RenderFont HeadingFont => headingFont ??= new RenderFont(255, 255, 255, 255, "Arial", true, false, 9f, Alignment.Left, false, false);

	public static RenderFont TitleFont => titleFont ??= new RenderFont(255, 255, 255, 255, "Arial", false, false, 12f, Alignment.Left, false, false);

	public static RenderBrush Fill => fill ??= new RenderBrush(255, 64, 64, 64, 0f);

	public static RenderBrush ActiveFill => activeFill ??= new RenderBrush(255, 40, 70, 110, 0f);

	public static RenderBrush HoverFill => hoverFill ??= new RenderBrush(255, 90, 90, 90, 0f);

	public static RenderBrush Outline => outline ??= new RenderBrush(255, 128, 128, 128, 1f);

	// Fonts and brushes belong to the render target, which the overlay recreates when the game window is resized.
	public static void BeginFrame()
	{
		object? target = Overlay.Instance.renderTarget;
		if (target == null || ReferenceEquals(target, lastTarget)) return;

		lastTarget = target;
		foreach (var item in ColorFonts.Values) item.Dispose();
		foreach (var item in ColorFills.Values) item.Dispose();
		foreach (var item in ColorOutlines.Values) item.Dispose();
		ColorFonts.Clear();
		ColorFills.Clear();
		ColorOutlines.Clear();
		foreach (var item in new IDisposable?[] { font, centerFont, hintFont, headingFont, titleFont, fill, activeFill, hoverFill, outline }) item?.Dispose();
		font = centerFont = hintFont = headingFont = titleFont = null;
		fill = activeFill = hoverFill = outline = null;
	}

	public static RenderFont FontOf(MenuColor color, bool bold = false, bool small = false)
	{
		int key = color.Key | (bold ? 1 << 24 : 0) | (small ? 1 << 25 : 0);
		if (!ColorFonts.TryGetValue(key, out var colorFont)) {
			colorFont = new RenderFont(255, color.R, color.G, color.B, "Arial", bold, false, small ? 7f : 8f, Alignment.Left, false, false);
			ColorFonts[key] = colorFont;
		}

		return colorFont;
	}

	public static RenderBrush FillOf(MenuColor color, int alpha = 255)
	{
		int key = color.Key | (alpha << 24);
		if (!ColorFills.TryGetValue(key, out var brush)) {
			brush = new RenderBrush(alpha, color.R, color.G, color.B, 0f);
			ColorFills[key] = brush;
		}

		return brush;
	}

	public static RenderBrush OutlineOf(MenuColor color)
	{
		if (!ColorOutlines.TryGetValue(color.Key, out var brush)) {
			brush = new RenderBrush(255, color.R, color.G, color.B, 1f);
			ColorOutlines[color.Key] = brush;
		}

		return brush;
	}

	public static float MeasureWidth(RenderFont textFont, string text)
	{
		return textFont.GetTextLayout(text).Metrics.Width;
	}

	public static string Fit(RenderFont textFont, string text, float maxWidth)
	{
		if (maxWidth <= 0 || MeasureWidth(textFont, text) <= maxWidth) return text;

		int length = Math.Max(1, (int)(text.Length * maxWidth / MeasureWidth(textFont, text)) - 1);
		while (length > 1 && MeasureWidth(textFont, text[..length] + "~") > maxWidth) length--;
		return text[..length] + "~";
	}

	public static float DrawText(RenderFont textFont, string text, float x, float y, float height, float maxWidth = 0)
	{
		text = Fit(textFont, text, maxWidth);
		var layout = textFont.GetTextLayout(text);
		textFont.DrawText(layout, x, y + (height - layout.Metrics.Height) / 2f);
		return layout.Metrics.Width;
	}

	public static void DrawTextRight(RenderFont textFont, string text, float right, float y, float height)
	{
		var layout = textFont.GetTextLayout(text);
		textFont.DrawText(layout, right - layout.Metrics.Width, y + (height - layout.Metrics.Height) / 2f);
	}

	public static void DrawBox(RectangleF rectangle, string text, bool active = false)
	{
		(active ? ActiveFill : Fill).DrawRectangle(rectangle);
		Outline.DrawRectangle(rectangle);
		var layout = CenterFont.GetTextLayout(text);
		CenterFont.DrawText(layout, rectangle.Left + (rectangle.Width - layout.Metrics.Width) / 2f, rectangle.Top + (rectangle.Height - layout.Metrics.Height) / 2f);
	}

	public static void DrawColoredBox(RectangleF rectangle, string text, MenuColor color, bool active)
	{
		FillOf(active ? color.Scale(0.45f) : MenuColor.Dark).DrawRectangle(rectangle);
		OutlineOf(active ? color : MenuColor.Gray).DrawRectangle(rectangle);
		var textFont = FontOf(active ? MenuColor.White : MenuColor.Muted);
		var layout = textFont.GetTextLayout(text);
		textFont.DrawText(layout, rectangle.Left + (rectangle.Width - layout.Metrics.Width) / 2f, rectangle.Top + (rectangle.Height - layout.Metrics.Height) / 2f);
	}

	public static void DrawLabel(string text, float x, float y, float height)
	{
		var layout = Font.GetTextLayout(text);
		Font.DrawText(layout, x, y + (height - layout.Metrics.Height) / 2f);
	}

	public static void DrawItemIcon(SnoItem? item, float x, float y, float size, MenuColor border, float opacity = 1f)
	{
		var frame = new RectangleF(x, y, size, size);
		FillOf(MenuColor.Black, 200).DrawRectangle(frame);
		OutlineOf(border).DrawRectangle(frame);

		var texture = item == null ? null : TextureManager.GetItemTexture(item);
		if (texture == null || texture.Width <= 0 || texture.Height <= 0) return;

		float inner = size - 4;
		float scale = Math.Min(inner / texture.Width, inner / texture.Height);
		float width = texture.Width * scale;
		float height = texture.Height * scale;
		texture.Draw(x + (size - width) / 2f, y + (size - height) / 2f, width, height, opacity);
	}
}

internal abstract class MenuRow : IUIComponent
{
	protected MenuRow()
	{
	}

	protected MenuRow(float height)
	{
		Bounds = new RectangleF(0, 0, MenuStyle.RowWidth, height);
	}

	protected int MenuX { get; private set; }
	protected int MenuY { get; private set; }

	public RectangleF Bounds { get; set; } = new(0, 0, MenuStyle.RowWidth, MenuStyle.RowHeight);

	public void Draw(int menuX, int menuY)
	{
		SetOrigin(menuX, menuY);
		DrawRow(menuX + Bounds.Left, menuY + Bounds.Top);
	}

	// Rows hit-test against the menu position, which is set at layout time so a row that was rebuilt since the last frame still works.
	public void SetOrigin(int menuX, int menuY)
	{
		MenuX = menuX;
		MenuY = menuY;
	}

	public abstract bool HandleInput(int mouseX, int mouseY, bool isMouseClicked);

	protected abstract void DrawRow(float x, float y);

	protected RectangleF Slot(float offsetX, float width)
	{
		return new RectangleF(MenuX + Bounds.Left + offsetX, MenuY + Bounds.Top, width, Bounds.Height);
	}

	protected RectangleF Slot(float offsetX, float width, float insetY)
	{
		return new RectangleF(MenuX + Bounds.Left + offsetX, MenuY + Bounds.Top + insetY, width, Bounds.Height - 2 * insetY);
	}

	protected static bool Contains(RectangleF rectangle, int mouseX, int mouseY)
	{
		return mouseX >= rectangle.Left && mouseX <= rectangle.Right && mouseY >= rectangle.Top && mouseY <= rectangle.Bottom;
	}

	protected bool IsHovered()
	{
		var window = GameWindowManager.Window;
		return Contains(Slot(0, Bounds.Width), window.CursorX, window.CursorY);
	}

	protected void DrawBackground(float x, float y, bool active = false)
	{
		var rectangle = new RectangleF(x, y, Bounds.Width, Bounds.Height);
		(IsHovered() ? MenuStyle.HoverFill : active ? MenuStyle.ActiveFill : MenuStyle.Fill).DrawRectangle(rectangle);
		MenuStyle.Outline.DrawRectangle(rectangle);
	}

	protected static void DrawSegments(float x, float y, float height, params (string Text, MenuColor Color)[] segments)
	{
		foreach (var (text, color) in segments) {
			x += MenuStyle.DrawText(MenuStyle.FontOf(color, small: true), text, x, y, height) + 4;
		}
	}
}

internal sealed class MenuSearchBox(string label, Func<string> get, Action<string> change, int maxLength = 30) : MenuRow(MenuStyle.ControlHeight)
{
	private const float BoxOffset = 70f;

	private int captureId;
	private bool editing;

	public void StartEditing()
	{
		captureId = KeyboardCapture.Begin(OnKey);
		editing = true;
	}

	protected override void DrawRow(float x, float y)
	{
		if (editing && !KeyboardCapture.IsCurrent(captureId)) editing = false;

		MenuStyle.DrawLabel(label, x + 2, y, Bounds.Height);
		string text = get() + (editing ? (Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 2) % 2 == 0 ? "|" : " ") : "");
		if (text.Length > 30) text = text[^30..];
		MenuStyle.DrawBox(BoxSlot(), text, editing);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked || !Contains(BoxSlot(), mouseX, mouseY)) return false;

		StartEditing();
		return true;
	}

	private bool OnKey(CapturedKey key)
	{
		switch (key.Key) {
			case Vk.RETURN:
			case Vk.ESCAPE:
				return true;
			case Vk.BACK:
				string current = get();
				if (current.Length > 0) change(current[..^1]);
				return false;
		}

		string text = get();
		if (key.Character != '\0' && !char.IsControl(key.Character) && text.Length < maxLength) change(text + key.Character);
		return false;
	}

	private RectangleF BoxSlot() => Slot(BoxOffset, Bounds.Width - BoxOffset);
}

internal sealed class MenuActionButton(Func<string> label, Action onClick, MenuColor? accent = null) : MenuRow(MenuStyle.ControlHeight)
{
	protected override void DrawRow(float x, float y)
	{
		var rectangle = new RectangleF(x, y, Bounds.Width, Bounds.Height);
		(IsHovered() ? MenuStyle.HoverFill : MenuStyle.Fill).DrawRectangle(rectangle);
		(accent == null ? MenuStyle.Outline : MenuStyle.OutlineOf(accent.Value)).DrawRectangle(rectangle);
		var textFont = accent == null ? MenuStyle.CenterFont : MenuStyle.FontOf(accent.Value);
		var layout = textFont.GetTextLayout(label());
		textFont.DrawText(layout, x + (Bounds.Width - layout.Metrics.Width) / 2f, y + (Bounds.Height - layout.Metrics.Height) / 2f);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		onClick();
		return true;
	}
}

internal sealed class MenuHint(Func<string> text) : MenuRow
{
	public MenuHint(string text) : this(() => text)
	{
	}

	protected override void DrawRow(float x, float y)
	{
		var layout = MenuStyle.HintFont.GetTextLayout(text());
		MenuStyle.HintFont.DrawText(layout, x, y + (Bounds.Height - layout.Metrics.Height) / 2f);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		return false;
	}
}

internal sealed class MenuHeading(string text, int height = 26) : MenuRow(height)
{
	protected override void DrawRow(float x, float y)
	{
		var layout = MenuStyle.HeadingFont.GetTextLayout(text);
		float textY = y + Bounds.Height - layout.Metrics.Height - 4;
		MenuStyle.HeadingFont.DrawText(layout, x + 2, textY);
		MenuStyle.Outline.DrawLine(x, y + Bounds.Height - 1, x + Bounds.Width, y + Bounds.Height - 1);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		return false;
	}
}
