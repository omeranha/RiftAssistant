using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using RectangleF = System.Drawing.RectangleF;

namespace RiftAssistant.Rendering;

internal static class ItemFilterPalette
{
	public static readonly MenuColor Legendary = new(235, 130, 60);
	public static readonly MenuColor Set = new(80, 220, 90);
	public static readonly MenuColor Ancient = new(240, 200, 90);
	public static readonly MenuColor Keep = new(90, 210, 100);
	public static readonly MenuColor Sell = new(225, 85, 85);
	public static readonly MenuColor Number = new(120, 170, 255);
	public static readonly MenuColor Percent = new(255, 200, 90);
	public static readonly MenuColor Roll = new(190, 140, 255);

	public static MenuColor OfItem(ItemCatalogEntry? entry)
	{
		return entry == null ? MenuColor.Muted : entry.IsSet ? Set : Legendary;
	}

	public static MenuColor OfDecision(ItemFilterDecision decision)
	{
		return decision == ItemFilterDecision.Sell ? Sell : Keep;
	}

	public static MenuColor OfUnit(ItemFilterStatInfo? info)
	{
		return info == null ? MenuColor.Muted : info.IsPercent ? Percent : Number;
	}

	public static MenuColor OfCategory(ItemFilterStatCategory category)
	{
		return category switch {
			ItemFilterStatCategory.Primary => new MenuColor(255, 170, 60),
			ItemFilterStatCategory.Offense => new MenuColor(240, 100, 100),
			ItemFilterStatCategory.Defense => new MenuColor(100, 190, 240),
			ItemFilterStatCategory.Resource => new MenuColor(160, 130, 240),
			_ => new MenuColor(150, 210, 150)
		};
	}
}

internal sealed class FilterListRow(ItemFilterEntry entry, Action select, Action toggleEnabled, Action up, Action down) : MenuRow(36)
{
	private const float IconSize = 30f;
	private const float ButtonWidth = 20f;
	private const float SwitchWidth = 34f;

	protected override void DrawRow(float x, float y)
	{
		var catalog = ItemCatalog.Find(entry.Item);
		var color = entry.Enabled ? ItemFilterPalette.OfItem(catalog) : MenuColor.Gray;
		DrawBackground(x, y);
		MenuStyle.DrawItemIcon(catalog?.Item, x + 3, y + 3, IconSize, color, entry.Enabled ? 1f : 0.4f);

		float textX = x + IconSize + 10;
		float textWidth = SwitchSlot().Left - textX - 6;
		string name = entry.Item.Length == 0 ? "(choose an item)" : entry.Item;
		MenuStyle.DrawText(MenuStyle.FontOf(color, bold: true), name, textX, y + 2, 18, textWidth);

		var decisionColor = entry.Enabled ? ItemFilterPalette.OfDecision(entry.Decision) : MenuColor.Gray;
		var segments = new List<(string, MenuColor)> { (entry.Decision == ItemFilterDecision.Sell ? "Sell" : "Keep", decisionColor) };
		if (entry.AncientOnly) segments.Add(("Ancient+", entry.Enabled ? ItemFilterPalette.Ancient : MenuColor.Gray));
		segments.Add((entry.Stats.Count == 0 ? "no stats" : entry.Stats.Count == 1 ? "1 stat" : $"{entry.Stats.Count} stats", MenuColor.Muted));
		DrawSegments(textX, y + 18, 16, [.. segments]);

		MenuStyle.DrawColoredBox(SwitchSlot(), entry.Enabled ? "on" : "off", ItemFilterPalette.Keep, entry.Enabled);
		MenuStyle.DrawBox(UpSlot(), "^");
		MenuStyle.DrawBox(DownSlot(), "v");
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		if (Contains(SwitchSlot(), mouseX, mouseY)) {
			toggleEnabled();
			return true;
		}

		if (Contains(UpSlot(), mouseX, mouseY)) {
			up();
			return true;
		}

		if (Contains(DownSlot(), mouseX, mouseY)) {
			down();
			return true;
		}

		select();
		return true;
	}

	private RectangleF SwitchSlot() => Slot(Bounds.Width - 2 * ButtonWidth - SwitchWidth - 10, SwitchWidth, 6);

	private RectangleF UpSlot() => Slot(Bounds.Width - 2 * ButtonWidth - 7, ButtonWidth, 6);

	private RectangleF DownSlot() => Slot(Bounds.Width - ButtonWidth - 4, ButtonWidth, 6);
}

internal sealed class ItemChoiceRow(ItemCatalogEntry entry, Action choose) : MenuRow(36)
{
	private const float IconSize = 30f;

	protected override void DrawRow(float x, float y)
	{
		var color = ItemFilterPalette.OfItem(entry);
		DrawBackground(x, y);
		MenuStyle.DrawItemIcon(entry.Item, x + 3, y + 3, IconSize, color);

		float textX = x + IconSize + 10;
		MenuStyle.DrawText(MenuStyle.FontOf(color, bold: true), entry.Name, textX, y + 2, 18, Bounds.Width - IconSize - 20);
		DrawSegments(textX, y + 18, 16, (entry.IsSet ? "Set" : "Legendary", color), (entry.TypeName, MenuColor.Muted));
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		choose();
		return true;
	}
}

internal sealed class StatChoiceRow(ItemFilterStatInfo info, Action choose) : MenuRow(24)
{
	protected override void DrawRow(float x, float y)
	{
		DrawBackground(x, y);
		MenuStyle.FillOf(ItemFilterPalette.OfCategory(info.Category)).DrawRectangle(new RectangleF(x, y, 4, Bounds.Height));

		string unit = !info.HasRoll ? "count" : info.IsPercent ? "%" : "number";
		var unitFont = MenuStyle.FontOf(ItemFilterPalette.OfUnit(info));
		MenuStyle.DrawTextRight(unitFont, unit, x + Bounds.Width - 8, y, Bounds.Height);
		MenuStyle.DrawText(MenuStyle.FontOf(MenuColor.White), info.Label, x + 12, y, Bounds.Height, Bounds.Width - 80);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		choose();
		return true;
	}
}

internal sealed class FilterTitleRow(ItemFilterEntry entry, Action changeItem) : MenuRow(46)
{
	private const float IconSize = 40f;

	protected override void DrawRow(float x, float y)
	{
		var catalog = ItemCatalog.Find(entry.Item);
		var color = ItemFilterPalette.OfItem(catalog);
		DrawBackground(x, y);
		MenuStyle.DrawItemIcon(catalog?.Item, x + 3, y + 3, IconSize, color);

		float textX = x + IconSize + 12;
		string name = entry.Item.Length == 0 ? "(choose an item)" : entry.Item;
		MenuStyle.DrawText(MenuStyle.FontOf(color, bold: true), name, textX, y + 4, 20, Bounds.Width - IconSize - 20);
		if (catalog != null) DrawSegments(textX, y + 24, 16, (catalog.IsSet ? "Set" : "Legendary", color), (catalog.TypeName, MenuColor.Muted));
		MenuStyle.DrawTextRight(MenuStyle.FontOf(MenuColor.Muted, small: true), "click to change item", x + Bounds.Width - 6, y + 26, 16);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		changeItem();
		return true;
	}
}

internal sealed class FilterDecisionRow(Func<ItemFilterDecision> get, Action<ItemFilterDecision> set) : MenuRow(24)
{
	private const float ButtonWidth = 80f;

	protected override void DrawRow(float x, float y)
	{
		MenuStyle.DrawLabel("Result", x, y, Bounds.Height);
		var current = get();
		MenuStyle.DrawColoredBox(KeepSlot(), "Keep", ItemFilterPalette.Keep, current == ItemFilterDecision.Keep);
		MenuStyle.DrawColoredBox(SellSlot(), "Sell", ItemFilterPalette.Sell, current == ItemFilterDecision.Sell);
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		if (Contains(KeepSlot(), mouseX, mouseY)) {
			set(ItemFilterDecision.Keep);
			return true;
		}

		if (Contains(SellSlot(), mouseX, mouseY)) {
			set(ItemFilterDecision.Sell);
			return true;
		}

		return false;
	}

	private RectangleF KeepSlot() => Slot(Bounds.Width - 2 * ButtonWidth - 4, ButtonWidth);

	private RectangleF SellSlot() => Slot(Bounds.Width - ButtonWidth, ButtonWidth);
}

internal sealed class FilterStatRow(ItemFilterStatEntry stat, Action change, Action<int> adjust, Action switchMeasure, Action<double> setValue, Action remove) : MenuRow(26)
{
	private const float ButtonWidth = 20f;
	private const float MeasureWidth = 58f;
	private const float ValueWidth = 72f;
	private const float Gap = 3f;

	private readonly ItemFilterStatInfo? info = ItemFilterStats.Find(stat.Stat);

	private volatile string buffer = "";
	private bool editing;
	private int captureId;

	protected override void DrawRow(float x, float y)
	{
		if (editing && !KeyboardCapture.IsCurrent(captureId)) editing = false;

		var category = info == null ? MenuColor.Muted : ItemFilterPalette.OfCategory(info.Category);
		MenuStyle.FillOf(category).DrawRectangle(new RectangleF(x, y, 4, Bounds.Height));
		MenuStyle.DrawText(MenuStyle.FontOf(MenuColor.White), ItemFilterStats.LabelOf(stat.Stat), x + 10, y, Bounds.Height, LabelSlot().Width - 10);

		bool roll = info != null && ItemFilterStats.UsesRoll(stat, info);
		var measureColor = roll ? ItemFilterPalette.Roll : ItemFilterPalette.OfUnit(info);
		MenuStyle.DrawColoredBox(MeasureSlot(), MeasureLabel(roll), measureColor, true);
		MenuStyle.DrawBox(MinusSlot(), "-");
		string text = editing ? buffer + (Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 2) % 2 == 0 ? "|" : " ") : ItemFilterStats.Describe(stat);
		MenuStyle.DrawBox(ValueSlot(), text, editing);
		MenuStyle.DrawBox(PlusSlot(), "+");
		MenuStyle.DrawBox(RemoveSlot(), "x");
	}

	public override bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!isMouseClicked) return false;

		if (Contains(MinusSlot(), mouseX, mouseY)) {
			adjust(-1);
			return true;
		}

		if (Contains(PlusSlot(), mouseX, mouseY)) {
			adjust(1);
			return true;
		}

		if (Contains(RemoveSlot(), mouseX, mouseY)) {
			remove();
			return true;
		}

		if (Contains(MeasureSlot(), mouseX, mouseY)) {
			if (info is { HasRoll: true }) switchMeasure();
			return true;
		}

		if (Contains(ValueSlot(), mouseX, mouseY)) {
			buffer = stat.Min.ToString("0.##", CultureInfo.InvariantCulture);
			captureId = KeyboardCapture.Begin(OnKey);
			editing = true;
			return true;
		}

		if (!Contains(LabelSlot(), mouseX, mouseY)) return false;

		change();
		return true;
	}

	private string MeasureLabel(bool roll)
	{
		if (info is { HasRoll: false }) return "count";

		return roll ? "roll %" : info is { IsPercent: true } ? "value %" : "number";
	}

	private bool OnKey(CapturedKey key)
	{
		switch (key.Key) {
			case Vk.RETURN:
				if (double.TryParse(buffer, NumberStyles.Float, CultureInfo.InvariantCulture, out double value)) setValue(value);
				return true;
			case Vk.ESCAPE:
				return true;
			case Vk.BACK:
				if (buffer.Length > 0) buffer = buffer[..^1];
				return false;
		}

		char character = key.Character == ',' ? '.' : key.Character;
		if (buffer.Length < 9 && (char.IsAsciiDigit(character) || (character == '.' && !buffer.Contains('.')))) buffer += character;
		return false;
	}

	private RectangleF LabelSlot() => Slot(0, Bounds.Width - MeasureWidth - 3 * ButtonWidth - ValueWidth - 5 * Gap);

	private RectangleF MeasureSlot() => Slot(Bounds.Width - MeasureWidth - 3 * ButtonWidth - ValueWidth - 4 * Gap, MeasureWidth);

	private RectangleF MinusSlot() => Slot(Bounds.Width - 3 * ButtonWidth - ValueWidth - 3 * Gap, ButtonWidth);

	private RectangleF ValueSlot() => Slot(Bounds.Width - 2 * ButtonWidth - ValueWidth - 2 * Gap, ValueWidth);

	private RectangleF PlusSlot() => Slot(Bounds.Width - 2 * ButtonWidth - Gap, ButtonWidth);

	private RectangleF RemoveSlot() => Slot(Bounds.Width - ButtonWidth, ButtonWidth);
}
