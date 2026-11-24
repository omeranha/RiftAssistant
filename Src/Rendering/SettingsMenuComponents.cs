using System;
using System.Collections.Generic;
using System.Diagnostics;
using SharpDX;

namespace RiftAssistant.Rendering;

internal interface ICompactMenuOption : IMenuOption
{
}

internal static class MenuStyle
{
	public const int RowWidth = 260;
	public const int RowHeight = 20;

	public static readonly RenderFont Font = new(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, false);
	public static readonly RenderFont CenterFont = new(255, 255, 255, 255, "Arial", false, false, 8f, Alignment.Center, false, false);
	public static readonly RenderFont HintFont = new(255, 160, 160, 160, "Arial", false, false, 7f, Alignment.Left, false, false);
	public static readonly RenderBrush Fill = new(255, 64, 64, 64, 0f);
	public static readonly RenderBrush ActiveFill = new(255, 40, 70, 110, 0f);
	public static readonly RenderBrush Outline = new(255, 128, 128, 128, 1f);

	public static void DrawBox(RectangleF rectangle, string text, bool active = false)
	{
		(active ? ActiveFill : Fill).DrawRectangle(rectangle);
		Outline.DrawRectangle(rectangle);
		var layout = CenterFont.GetTextLayout(text);
		CenterFont.DrawText(layout, rectangle.Left + (rectangle.Width - layout.Metrics.Width) / 2f, rectangle.Top + (rectangle.Height - layout.Metrics.Height) / 2f);
	}

	public static void DrawLabel(string text, float x, float y, float height)
	{
		var layout = Font.GetTextLayout(text);
		Font.DrawText(layout, x, y + (height - layout.Metrics.Height) / 2f);
	}
}

internal abstract class MenuRow : IUIComponent
{
	protected int MenuX { get; private set; }
	protected int MenuY { get; private set; }

	public RectangleF Bounds { get; set; } = new(0, 0, MenuStyle.RowWidth, MenuStyle.RowHeight);

	public void Draw(int menuX, int menuY)
	{
		MenuX = menuX;
		MenuY = menuY;
		DrawRow(menuX + Bounds.Left, menuY + Bounds.Top);
	}

	public abstract bool HandleInput(int mouseX, int mouseY, bool isMouseClicked);

	protected abstract void DrawRow(float x, float y);

	protected RectangleF Slot(float offsetX, float width)
	{
		return new RectangleF(MenuX + Bounds.Left + offsetX, MenuY + Bounds.Top, width, Bounds.Height);
	}

	protected static bool Contains(RectangleF rectangle, int mouseX, int mouseY)
	{
		return mouseX >= rectangle.Left && mouseX <= rectangle.Right && mouseY >= rectangle.Top && mouseY <= rectangle.Bottom;
	}
}

internal sealed class MenuSectionHeader(string title, Func<bool> isExpanded, Action onClick) : MenuRow
{
	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawBox(new RectangleF(x, y, Bounds.Width, Bounds.Height), (isExpanded() ? "[-] " : "[+] ") + title);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		onClick();
		return true;
	}
}

internal sealed class BoundCheckbox : IUIComponent
{
	private readonly MenuCheckbox inner;
	private readonly Func<bool> get;

	public BoundCheckbox(string label, Func<bool> get, Action<bool> set)
	{
		this.get = get;
		inner = new MenuCheckbox(label, get(), MenuStyle.RowWidth, MenuStyle.RowHeight) {
			OnToggled = set
		};
	}

	public RectangleF Bounds
	{
		get => inner.Bounds;
		set => inner.Bounds = value;
	}

	public void Draw(int menuX, int menuY)
	{
		inner.IsChecked = get();
		inner.Draw(menuX, menuY);
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		return inner.HandleInput(mouseX, mouseY, isMouseClicked);
	}
}

internal sealed class MenuStepper(string label, Func<int> get, Action<int> set, int min, int max, int step) : MenuRow
{
	private const float ButtonWidth = 20f;
	private const float ValueWidth = 40f;

	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawLabel(label, x, y, Bounds.Height);
		MenuStyle.DrawBox(MinusSlot(), "-");
		MenuStyle.DrawBox(ValueSlot(), get().ToString());
		MenuStyle.DrawBox(PlusSlot(), "+");
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		int current = get();
		if (Contains(MinusSlot(), mouseX, mouseY)) {
			set(Math.Max(min, current - step));
			return true;
		}

		if (Contains(PlusSlot(), mouseX, mouseY)) {
			set(Math.Min(max, current + step));
			return true;
		}

		return false;
	}

	private RectangleF MinusSlot() => Slot(Bounds.Width - 2 * ButtonWidth - ValueWidth, ButtonWidth);

	private RectangleF ValueSlot() => Slot(Bounds.Width - ButtonWidth - ValueWidth, ValueWidth);

	private RectangleF PlusSlot() => Slot(Bounds.Width - ButtonWidth, ButtonWidth);
}

internal sealed class MenuChoice(string label, Func<string> get, Action<string> set, Func<IReadOnlyList<string>> choices) : MenuRow
{
	private const float ValueWidth = 70f;

	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawLabel(label, x, y, Bounds.Height);
		MenuStyle.DrawBox(ValueSlot(), get());
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked || !Contains(ValueSlot(), mouseX, mouseY)) return false;

		var options = choices();
		if (options.Count == 0) return true;

		int index = -1;
		string current = get();
		for (int i = 0; i < options.Count; i++) {
			if (string.Equals(options[i], current, StringComparison.OrdinalIgnoreCase)) {
				index = i;
				break;
			}
		}

		set(options[(index + 1) % options.Count]);
		return true;
	}

	private RectangleF ValueSlot() => Slot(Bounds.Width - ValueWidth, ValueWidth);
}

internal sealed class MenuTextBox(string label, Func<string> get, Action<string> commit, int maxLength = 60) : MenuRow
{
	private const float BoxOffset = 90f;
	private const int VisibleCharacters = 24;

	private volatile string buffer = "";
	private bool editing;
	private int captureId;

	protected override void DrawRow(float x, float y)
	{
		if (editing && !KeyboardCapture.IsCurrent(captureId)) editing = false;

		MenuStyle.DrawLabel(label, x, y, Bounds.Height);
		string text = editing ? buffer + (Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 2) % 2 == 0 ? "|" : " ") : get();
		if (text.Length > VisibleCharacters) text = text[^VisibleCharacters..];
		MenuStyle.DrawBox(BoxSlot(), text, editing);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked || !Contains(BoxSlot(), mouseX, mouseY)) return false;

		buffer = get();
		captureId = KeyboardCapture.Begin(OnKey);
		editing = true;
		return true;
	}

	private bool OnKey(CapturedKey key)
	{
		switch (key.Key) {
			case Vk.RETURN:
				commit(buffer.Trim());
				return true;
			case Vk.ESCAPE:
				return true;
			case Vk.BACK:
				if (buffer.Length > 0) buffer = buffer[..^1];
				return false;
		}

		if (key.Character != '\0' && buffer.Length < maxLength) buffer += key.Character;
		return false;
	}

	private RectangleF BoxSlot() => Slot(BoxOffset, Bounds.Width - BoxOffset);
}

internal sealed class MenuActionButton(Func<string> label, Action onClick) : MenuRow
{
	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawBox(new RectangleF(x, y, Bounds.Width, Bounds.Height), label());
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

internal sealed class SettingsSection : ICompactMenuOption
{
	private readonly MenuSectionHeader header;
	private readonly IUIComponent[] expandedComponents;
	private readonly IUIComponent[] collapsedComponents;

	public SettingsSection(string name, IEnumerable<IUIComponent> items, Action<SettingsSection> onToggle)
	{
		Name = name;
		header = new MenuSectionHeader(name, () => Expanded, () => onToggle(this));
		collapsedComponents = [header];
		expandedComponents = [header, .. items];
	}

	public string Name { get; }

	public bool Expanded { get; set; }

	public IReadOnlyList<IUIComponent> GetComponents()
	{
		return Expanded ? expandedComponents : collapsedComponents;
	}
}
