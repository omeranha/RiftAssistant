using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using RectangleF = System.Drawing.RectangleF;

namespace RiftAssistant.Rendering;

internal sealed class SettingToggleRow(string label, Func<bool> get, Action<bool> set) : MenuRow(MenuStyle.ControlHeight)
{
	private const float SwitchWidth = 44f;

	protected override void DrawRow(float x, float y)
	{
		bool on = get();
		DrawBackground(x, y);
		MenuStyle.DrawText(MenuStyle.Font, label, x + 8, y, Bounds.Height, Bounds.Width - SwitchWidth - 24);
		MenuStyle.DrawColoredBox(SwitchSlot(), on ? "on" : "off", MenuColor.Positive, on);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		set(!get());
		return true;
	}

	private RectangleF SwitchSlot() => Slot(Bounds.Width - SwitchWidth - 4, SwitchWidth, 3);
}

internal sealed class SettingStepperRow(string label, Func<int> get, Action<int> set, int min, int max, int step) : MenuRow(MenuStyle.ControlHeight)
{
	private const float ButtonWidth = 22f;
	private const float ValueWidth = 66f;

	private volatile string buffer = "";
	private bool editing;
	private int captureId;

	protected override void DrawRow(float x, float y)
	{
		if (editing && !KeyboardCapture.IsCurrent(captureId)) editing = false;

		DrawBackground(x, y);
		MenuStyle.DrawText(MenuStyle.Font, label, x + 8, y, Bounds.Height, Bounds.Width - 2 * ButtonWidth - ValueWidth - 24);
		MenuStyle.DrawBox(MinusSlot(), "-");
		string text = editing ? buffer + (Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 2) % 2 == 0 ? "|" : " ") : get().ToString(CultureInfo.InvariantCulture);
		MenuStyle.DrawBox(ValueSlot(), text, editing);
		MenuStyle.DrawBox(PlusSlot(), "+");
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		if (Contains(MinusSlot(), mouseX, mouseY)) {
			set(Math.Max(min, get() - step));
			return true;
		}

		if (Contains(PlusSlot(), mouseX, mouseY)) {
			set(Math.Min(max, get() + step));
			return true;
		}

		if (!Contains(ValueSlot(), mouseX, mouseY)) return false;

		buffer = get().ToString(CultureInfo.InvariantCulture);
		captureId = KeyboardCapture.Begin(OnKey);
		editing = true;
		return true;
	}

	private bool OnKey(CapturedKey key)
	{
		switch (key.Key) {
			case Vk.RETURN:
				if (int.TryParse(buffer, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out int value)) set(Math.Clamp(value, min, max));
				return true;
			case Vk.ESCAPE:
				return true;
			case Vk.BACK:
				if (buffer.Length > 0) buffer = buffer[..^1];
				return false;
		}

		bool sign = key.Character == '-' && buffer.Length == 0 && min < 0;
		if (buffer.Length < 9 && (char.IsAsciiDigit(key.Character) || sign)) buffer += key.Character;
		return false;
	}

	private RectangleF MinusSlot() => Slot(Bounds.Width - 2 * ButtonWidth - ValueWidth - 8, ButtonWidth, 3);

	private RectangleF ValueSlot() => Slot(Bounds.Width - ButtonWidth - ValueWidth - 6, ValueWidth, 3);

	private RectangleF PlusSlot() => Slot(Bounds.Width - ButtonWidth - 4, ButtonWidth, 3);
}

internal sealed class SettingChoiceRow(string label, Func<string> get, Action<string> set, Func<IReadOnlyList<string>> choices) : MenuRow(MenuStyle.ControlHeight)
{
	private const float ButtonWidth = 22f;
	private const float ValueWidth = 110f;

	protected override void DrawRow(float x, float y)
	{
		DrawBackground(x, y);
		MenuStyle.DrawText(MenuStyle.Font, label, x + 8, y, Bounds.Height, Bounds.Width - 2 * ButtonWidth - ValueWidth - 24);
		MenuStyle.DrawBox(PreviousSlot(), "<");
		MenuStyle.DrawColoredBox(ValueSlot(), get(), MenuColor.Blue, true);
		MenuStyle.DrawBox(NextSlot(), ">");
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		int direction = Contains(PreviousSlot(), mouseX, mouseY) ? -1 : Contains(NextSlot(), mouseX, mouseY) || Contains(ValueSlot(), mouseX, mouseY) ? 1 : 0;
		if (direction == 0) return false;

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

		set(options[(index + direction + options.Count) % options.Count]);
		return true;
	}

	private RectangleF PreviousSlot() => Slot(Bounds.Width - 2 * ButtonWidth - ValueWidth - 8, ButtonWidth, 3);

	private RectangleF ValueSlot() => Slot(Bounds.Width - ButtonWidth - ValueWidth - 6, ValueWidth, 3);

	private RectangleF NextSlot() => Slot(Bounds.Width - ButtonWidth - 4, ButtonWidth, 3);
}

internal sealed class SettingTextRow(string label, Func<string> get, Action<string> commit, int maxLength = 60) : MenuRow(MenuStyle.ControlHeight)
{
	private const float BoxWidth = 200f;
	private const int VisibleCharacters = 26;

	private volatile string buffer = "";
	private bool editing;
	private int captureId;

	protected override void DrawRow(float x, float y)
	{
		if (editing && !KeyboardCapture.IsCurrent(captureId)) editing = false;

		DrawBackground(x, y);
		MenuStyle.DrawText(MenuStyle.Font, label, x + 8, y, Bounds.Height, Bounds.Width - BoxWidth - 24);
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

		if (key.Character != '\0' && !char.IsControl(key.Character) && buffer.Length < maxLength) buffer += key.Character;
		return false;
	}

	private RectangleF BoxSlot() => Slot(Bounds.Width - BoxWidth - 4, BoxWidth, 3);
}

internal sealed class SettingHotkeyRow(string label, Func<string> describe, Action<CapturedKey> assign) : MenuRow(MenuStyle.ControlHeight)
{
	private const float BoxWidth = 130f;

	private int captureId;
	private bool capturing;

	protected override void DrawRow(float x, float y)
	{
		if (capturing && !KeyboardCapture.IsCurrent(captureId)) capturing = false;

		DrawBackground(x, y);
		MenuStyle.DrawText(MenuStyle.Font, label, x + 8, y, Bounds.Height, Bounds.Width - BoxWidth - 24);
		MenuStyle.DrawColoredBox(BoxSlot(), capturing ? "press a key..." : describe(), MenuColor.Gold, true);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked || !Contains(BoxSlot(), mouseX, mouseY)) return false;

		captureId = KeyboardCapture.Begin(OnKey);
		capturing = true;
		return true;
	}

	private bool OnKey(CapturedKey key)
	{
		if (key.Key == Vk.ESCAPE) return true;

		assign(key);
		return true;
	}

	private RectangleF BoxSlot() => Slot(Bounds.Width - BoxWidth - 4, BoxWidth, 3);
}

internal sealed class SettingFlagsRow : MenuRow
{
	private const int Columns = 3;
	private const float ChipHeight = 22f;
	private const float ChipGap = 3f;
	private const float LabelHeight = 22f;

	private readonly string label;
	private readonly IReadOnlyList<string> names;
	private readonly Func<int, bool> isOn;
	private readonly Action<int, bool> toggle;

	public SettingFlagsRow(string label, IReadOnlyList<string> names, Func<int, bool> isOn, Action<int, bool> toggle)
	{
		this.label = label;
		this.names = names;
		this.isOn = isOn;
		this.toggle = toggle;
		int lines = (names.Count + Columns - 1) / Columns;
		Bounds = new RectangleF(0, 0, MenuStyle.RowWidth, LabelHeight + lines * (ChipHeight + ChipGap) + 2);
	}

	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawText(MenuStyle.FontOf(MenuColor.White, bold: true), label, x + 8, y, LabelHeight);
		int count = 0;
		for (int i = 0; i < names.Count; i++) {
			if (isOn(i)) count++;
		}

		MenuStyle.DrawTextRight(MenuStyle.FontOf(MenuColor.Muted, small: true), $"{count}/{names.Count}", x + Bounds.Width - 6, y, LabelHeight);
		for (int i = 0; i < names.Count; i++) {
			MenuStyle.DrawColoredBox(ChipSlot(i), names[i], MenuColor.Positive, isOn(i));
		}
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		for (int i = 0; i < names.Count; i++) {
			if (!Contains(ChipSlot(i), mouseX, mouseY)) continue;

			toggle(i, !isOn(i));
			return true;
		}

		return false;
	}

	private RectangleF ChipSlot(int index)
	{
		float width = (Bounds.Width - (Columns - 1) * ChipGap) / Columns;
		int column = index % Columns;
		int line = index / Columns;
		return new RectangleF(MenuX + Bounds.Left + column * (width + ChipGap), MenuY + Bounds.Top + LabelHeight + line * (ChipHeight + ChipGap), width, ChipHeight);
	}
}

internal sealed class NavRow(string label, MenuColor accent, Func<bool> isSelected, Action click, string trailing = "") : MenuRow(28)
{
	protected override void DrawRow(float x, float y)
	{
		bool selected = isSelected();
		DrawBackground(x, y, selected);
		MenuStyle.FillOf(accent).DrawRectangle(new RectangleF(x, y, 4, Bounds.Height));
		MenuStyle.DrawText(MenuStyle.FontOf(selected ? MenuColor.White : MenuColor.Muted, selected), label, x + 12, y, Bounds.Height, Bounds.Width - 36);
		if (trailing.Length > 0) MenuStyle.DrawTextRight(MenuStyle.FontOf(accent, true), trailing, x + Bounds.Width - 8, y, Bounds.Height);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		click();
		return true;
	}
}

internal sealed class SectionHeaderRow(string title, Func<bool> isExpanded, Action click, MenuColor accent) : MenuRow(MenuStyle.ControlHeight)
{
	protected override void DrawRow(float x, float y)
	{
		bool expanded = isExpanded();
		DrawBackground(x, y, expanded);
		MenuStyle.FillOf(accent).DrawRectangle(new RectangleF(x, y, 4, Bounds.Height));
		MenuStyle.DrawText(MenuStyle.FontOf(MenuColor.White, true), title, x + 12, y, Bounds.Height, Bounds.Width - 48);
		MenuStyle.DrawTextRight(MenuStyle.FontOf(accent, true), expanded ? "-" : "+", x + Bounds.Width - 10, y, Bounds.Height);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		click();
		return true;
	}
}

internal sealed class MenuTabRow(IReadOnlyList<string> labels, Func<int> selected, Action<int> select) : MenuRow(22)
{
	protected override void DrawRow(float x, float y)
	{
		float width = Bounds.Width / labels.Count;
		for (int i = 0; i < labels.Count; i++) {
			MenuStyle.DrawColoredBox(new RectangleF(x + i * width, y, width - 2, Bounds.Height), labels[i], MenuColor.Purple, i == selected());
		}
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		float width = Bounds.Width / labels.Count;
		for (int i = 0; i < labels.Count; i++) {
			if (!Contains(Slot(i * width, width - 2), mouseX, mouseY)) continue;

			select(i);
			return true;
		}

		return false;
	}
}
