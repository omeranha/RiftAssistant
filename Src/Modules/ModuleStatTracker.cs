using System;
using System.Collections.Generic;
using System.Diagnostics;
using SharpDX.DirectWrite;

namespace RiftAssistant.Modules;

internal sealed class ModuleStatTracker : Module
{
	private static readonly TimeSpan CellRefreshInterval = TimeSpan.FromMilliseconds(250);

	private static readonly ColumnDefinition[] AllColumns = [
		new("experience", "/h", c => c.Experience, t => t.GainedExperience, t => t.GainedExperiencePerHourPlay, ValueFormat.LongNumber, ValueFormat.LongNumber, Accent.Experience),
		new("gold pickup", "/h", c => c.GoldPickup, t => t.GainedGold, t => t.GainedGoldPerHour, ValueFormat.LongNumber, ValueFormat.LongNumber),
		new("gold drop", "/h", c => c.GoldDrop, t => t.DropGold, t => t.DropGoldPerHour, ValueFormat.LongNumber, ValueFormat.LongNumber),
		new("all kills", "/h", c => c.KillTotal, t => t.MonsterKill, t => t.MonsterKillPerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("elite kills", "/h", c => c.KillElite, t => t.EliteKill, t => t.EliteKillPerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal, Accent.Elite),
		new("all items", "/h", c => c.DropAll, t => t.DropAll, t => t.DropAllPerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("white", "/h", c => c.DropWhite, t => t.DropWhite, t => t.DropWhitePerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("magic", "/h", c => c.DropMagic, t => t.DropMagic, t => t.DropMagicPerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("rare", "/h", c => c.DropRare, t => t.DropRare, t => t.DropRarePerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("legendary", "/h", c => c.DropLegendary, t => t.DropLegendary, t => t.DropLegendaryPerHour, ValueFormat.NormalNumber, ValueFormat.NormalNumber, Accent.Legendary),
		new("b.shard", "/h", c => c.DropBloodShard, t => t.DropBloodShard, t => t.DropBloodShardPerHour, ValueFormat.NormalNumberNoDecimal, ValueFormat.NormalNumberNoDecimal),
		new("death", "/h", c => c.Death, t => t.Death, t => t.DeathPerHour, ValueFormat.NormalNumber, ValueFormat.NormalNumber),
		new("damage (all)", "/s", c => c.DamageDealtAll, t => t.DamageDealtAll, t => t.DamageDealtAllPerSecond, ValueFormat.LongNumber, ValueFormat.LongNumber),
		new("damage (crit)", "/s", c => c.DamageDealtCrit, t => t.DamageDealtCrit, t => t.DamageDealtCritPerSecond, ValueFormat.LongNumber, ValueFormat.LongNumber),
		new("damage taken", "/s", c => c.DamageTaken, t => t.DamageTaken, t => t.DamageTakenPerSecond, ValueFormat.LongNumber, ValueFormat.LongNumber),
		new("healing", "/s", c => c.Healing, t => t.Healing, t => t.HealingPerSecond, ValueFormat.LongNumber, ValueFormat.LongNumber)
	];

	private readonly RenderBrush panelFill = new(192, 0, 0, 0, 0f);
	private readonly RenderBrush panelBorder = new(255, 16, 16, 16, 3f);
	private readonly RenderBrush cellBorder = new(255, 0, 0, 0, 1f);
	private readonly RenderBrush hoverFill = new(255, 255, 255, 255, 0f);
	private readonly RenderBrush experienceFill = new(220, 107, 157, 255, 0f);
	private readonly RenderBrush eliteFill = new(220, 255, 148, 20, 0f);
	private readonly RenderBrush legendaryFill = new(220, 211, 120, 67, 0f);
	private readonly RenderBrush cellFill = new(220, 230, 230, 230, 0f);
	private readonly RenderBrush timeFill = new(220, 87, 87, 87, 0f);

	private readonly RenderFont totalTitleFont = new(255, 180, 255, 180, "arial", true, false, 7f, Alignment.Left, false, false);
	private readonly RenderFont titleFont = new(255, 180, 255, 180, "Arial", false, false, 6f, Alignment.Left, false, false);
	private readonly RenderFont blackText = new(255, 0, 0, 0, "Arial", false, false, 6f, Alignment.Left, false, false);
	private readonly RenderFont boldBlackText = new(255, 0, 0, 0, "Arial", true, false, 6f, Alignment.Left, false, false);
	private readonly RenderFont whiteText = new(255, 255, 255, 255, "Arial", false, false, 6f, Alignment.Left, false, false);

	private readonly float widthScale;
	private readonly ColumnDefinition[] columns;
	private readonly List<StatTracker> trackers = [];
	private readonly Dictionary<StatTracker, RowCells> rows = [];
	private readonly int[] columnWidths;

	private long lastCellRefresh;
	private int refreshGeneration;
	private int currentColumnX;
	private int currentRowY;
	private int cellPadding;

	public ModuleStatTracker(StatTrackerSettings settings) : base(settings.Enabled)
	{
		Show = false;
		SetTransparentComponents(panelFill, panelBorder, cellBorder, hoverFill, experienceFill, eliteFill, legendaryFill, cellFill, timeFill, totalTitleFont, titleFont, blackText, boldBlackText, whiteText);
		widthScale = settings.ScaleWidth / 100f;
		columns = [.. Array.FindAll(AllColumns, column => column.IsEnabled(settings.Columns))];
		columnWidths = new int[2 + columns.Length * 2];
	}

	public override void Dispose()
	{
		Overlay.Instance.DisposeRenders(panelFill, panelBorder, cellBorder, hoverFill, totalTitleFont, titleFont, blackText, boldBlackText);
		Overlay.Instance.DisposeRenders(experienceFill, eliteFill, legendaryFill, cellFill, timeFill, whiteText);
		base.Dispose();
	}

	public void Draw()
	{
		if (CoreCollector.IsLoading) Show = false;

		var lobby = Overlay.Instance.lobbyHeroesModule;
		bool wasShown = Show;
		if (lobby?.hero0 != null) Show = true;
		bool visible = vmethod_0(bool_4: true);
		Show = wasShown;
		if (!visible) return;
		if (!CoreCollector.IsGameReady && lobby != null && lobby.hero0 == null) return;

		CollectTrackers();
		bool refreshCells = Stopwatch.GetElapsedTime(lastCellRefresh) >= CellRefreshInterval;
		if (refreshCells) {
			lastCellRefresh = Stopwatch.GetTimestamp();
			refreshGeneration++;
		}

		var window = GameWindowManager.Window;
		int windowWidth = window.Size.Width;
		int windowHeight = window.Size.Height;
		int top = Round(windowHeight * (CoreCollector.IsGameReady ? 0.021f : 0.098f));
		int left = Round(Math.Max(0f, (windowWidth - windowHeight * 4f / 3f * widthScale) / 2f));
		int padding = Round(windowHeight * 0.01f);
		int headerHeight = Round(windowHeight * 0.02f);
		int unitHeight = Round(windowHeight * 0.02f);
		int rowHeight = Round(windowHeight * 0.016f);
		cellPadding = Round(windowHeight * 0.003f);

		float contentHeight = headerHeight + unitHeight + rowHeight * trackers.Count;
		float panelX = left + 0.5f;
		float panelY = top + 0.5f;
		float panelWidth = Round(windowWidth - left * 2);
		float panelHeight = Round(Math.Min(padding * 2 + contentHeight, windowHeight - top * 2));
		int contentX = Round(panelX + padding);
		int contentY = Round(panelY + padding);
		int titleWidth = Round(windowHeight * 0.18f);
		float tableWidth = panelWidth - padding * 2 - titleWidth;
		float rowWidth = titleWidth + tableWidth;
		int tableX = contentX + titleWidth;

		int unit = Round((float)Math.Floor(tableWidth / (columnWidths.Length + 1f)));
		columnWidths[0] = Round((float)Math.Floor(unit * 1.4f));
		columnWidths[1] = Round((float)Math.Floor(unit * 1.6f));
		for (int i = 2; i < columnWidths.Length; i++) {
			columnWidths[i] = Round(unit * (i % 2 == 0 ? 1.1f : 0.9f));
		}

		panelFill.DrawRectangle(panelX, panelY, panelWidth, panelHeight);
		panelBorder.DrawRectangle(panelX, panelY, panelWidth, panelHeight);

		currentColumnX = tableX;
		currentRowY = contentY;
		DrawCell(0, whiteText, "time", headerHeight, Alignment.Center, 2, timeFill);
		for (int i = 0; i < columns.Length; i++) {
			var accent = columns[i].Accent;
			DrawCell(2 + i * 2, accent == Accent.None ? boldBlackText : whiteText, columns[i].Header, headerHeight, Alignment.Center, 2, AccentFill(accent));
		}

		currentColumnX = tableX;
		currentRowY += headerHeight;
		DrawCell(0, boldBlackText, "in town", unitHeight, Alignment.Right, 1, null);
		DrawCell(1, whiteText, "play", unitHeight, Alignment.Right, 1, timeFill);
		for (int i = 0; i < columns.Length; i++) {
			var accent = columns[i].Accent;
			DrawCell(2 + i * 2, boldBlackText, "sum", unitHeight, Alignment.Right, 1, null);
			DrawCell(3 + i * 2, accent == Accent.None ? boldBlackText : whiteText, columns[i].RateUnit, unitHeight, Alignment.Right, 1, AccentFill(accent));
		}

		currentRowY += unitHeight;
		foreach (var tracker in trackers) {
			var cells = GetCells(tracker, refreshCells);
			var rowTitleFont = tracker.Title is "ACCOUNT TOTAL" or "HERO TOTAL" ? totalTitleFont : titleFont;
			var titleLayout = rowTitleFont.GetTextLayout(tracker.Title);
			rowTitleFont.DrawText(titleLayout, tableX - titleLayout.Metrics.Width - cellPadding, currentRowY + (rowHeight - titleLayout.Metrics.Height) / 2f);

			bool hovered = window.CursorX >= contentX && window.CursorX <= contentX + rowWidth && window.CursorY >= currentRowY && window.CursorY < currentRowY + rowHeight;
			var rowFill = hovered ? hoverFill : cellFill;

			currentColumnX = tableX;
			DrawCell(0, blackText, tracker.SnoArea != null ? "" : tracker.AlwaysRunning ? "-" : cells.TownTime, rowHeight, Alignment.Right, 1, rowFill);
			DrawCell(1, whiteText, cells.PlayTime, rowHeight, Alignment.Right, 1, timeFill);
			for (int i = 0; i < columns.Length; i++) {
				var accentFill = AccentFill(columns[i].Accent);
				DrawCell(2 + i * 2, blackText, cells.Totals[i], rowHeight, Alignment.Right, 1, rowFill);
				DrawCell(3 + i * 2, accentFill != null ? whiteText : blackText, cells.Rates[i], rowHeight, Alignment.Right, 1, accentFill ?? rowFill);
			}

			currentRowY += rowHeight;
		}

		if (refreshCells) DropStaleRows();
	}

	private static int Round(float value) => Convert.ToInt32(value);

	private RenderBrush AccentFill(Accent accent)
	{
		return accent switch {
			Accent.Experience => experienceFill,
			Accent.Elite => eliteFill,
			Accent.Legendary => legendaryFill,
			_ => null
		};
	}

	private RowCells GetCells(StatTracker tracker, bool refresh)
	{
		if (!rows.TryGetValue(tracker, out var cells)) {
			cells = new RowCells(columns.Length);
			rows[tracker] = cells;
			refresh = true;
		}

		cells.Generation = refreshGeneration;
		if (refresh) cells.Refresh(tracker, columns);
		return cells;
	}

	private void DropStaleRows()
	{
		List<StatTracker> stale = null;
		foreach (var pair in rows) {
			if (pair.Value.Generation != refreshGeneration) (stale ??= []).Add(pair.Key);
		}

		if (stale == null) return;

		foreach (var tracker in stale) {
			rows.Remove(tracker);
		}
	}

	private void CollectTrackers()
	{
		trackers.Clear();
		if (CoreCollector.IsGameReady) {
			AddTracker(CoreCollector.AccountTotal);
			AddTracker(CoreCollector.AccountYesterday);
			AddTracker(CoreCollector.AccountToday);
			AddTracker(CoreCollector.CurrentHeroTotal);
			AddTracker(CoreCollector.CurrentHeroYesterday);
			AddTracker(CoreCollector.CurrentHeroToday);
			AddTracker(CoreCollector.Session);
			AddTracker(CoreCollector.SessionAlwaysRunning);
			var run = CoreCollector.RunTracker;
			if (run == null) return;

			AddTracker(run.RunStatTracker);
			foreach (var area in run.VisitedAreas) {
				if (area.SnoArea.IsTown) continue;

				area.AreaStats.Title = area.AreaNameLocalized;
				area.AreaStats.SnoArea = area.SnoArea;
				AddTracker(area.AreaStats);
				if (area.AreaTotalStats == null) continue;

				area.AreaTotalStats.Title = "TOTAL - " + area.AreaNameLocalized;
				area.AreaTotalStats.SnoArea = area.SnoArea;
				AddTracker(area.AreaTotalStats);
			}

			return;
		}

		var lobby = Overlay.Instance.lobbyHeroesModule;
		AddTracker(lobby.currentAccountTotal);
		AddTracker(lobby.currentAccountLastMonth);
		AddTracker(lobby.currentAccountLastWeek);
		AddTracker(lobby.currentAccountYesterday);
		AddTracker(lobby.currentAccountToday);
		AddTracker(CoreCollector.Session);
		AddTracker(CoreCollector.SessionAlwaysRunning);
		AddTracker(lobby.tracker);
		AddTracker(lobby.statTracker6);
		AddTracker(lobby.statTracker7);
		AddTracker(lobby.statTracker8);
		AddTracker(lobby.statTracker9);
	}

	private void AddTracker(StatTracker tracker)
	{
		if (tracker != null) trackers.Add(tracker);
	}

	private void DrawCell(int columnIndex, RenderFont font, string text, float height, Alignment alignment, int columnSpan, RenderBrush fill)
	{
		int width = columnWidths[columnIndex];
		while (--columnSpan > 0) {
			width += columnWidths[++columnIndex];
		}

		var layout = font.GetTextLayout(text);
		float x = currentColumnX + 0.5f;
		float y = currentRowY + 0.5f;
		(fill ?? cellFill).DrawRectangle(x, y, width, height);

		float textX = alignment switch {
			Alignment.Left => x + cellPadding,
			Alignment.Right => x + width - layout.Metrics.Width - cellPadding,
			_ => x + (width - layout.Metrics.Width) * 0.5f
		};
		font.DrawText(layout, textX, currentRowY + (height - layout.Metrics.Height) * 0.5f);
		cellBorder.DrawRectangle(x, y, width, height);
		currentColumnX += width;
	}

	private enum Accent
	{
		None,
		Experience,
		Elite,
		Legendary
	}

	private sealed record ColumnDefinition(
		string Header,
		string RateUnit,
		Func<StatColumns, bool> IsEnabled,
		Func<StatTracker, double> Total,
		Func<StatTracker, double> Rate,
		ValueFormat TotalFormat,
		ValueFormat RateFormat,
		Accent Accent = Accent.None
	);

	private sealed class RowCells(int columnCount)
	{
		public readonly string[] Totals = new string[columnCount];
		public readonly string[] Rates = new string[columnCount];
		public string TownTime = "";
		public string PlayTime = "";
		public int Generation;

		public void Refresh(StatTracker tracker, ColumnDefinition[] columns)
		{
			TownTime = tracker.FormatTownTime();
			PlayTime = tracker.FormatPlayTime();
			for (int i = 0; i < columns.Length; i++) {
				Totals[i] = Formatting.ValueToString(columns[i].Total(tracker), columns[i].TotalFormat);
				Rates[i] = Formatting.ValueToString(columns[i].Rate(tracker), columns[i].RateFormat);
			}
		}
	}
}
