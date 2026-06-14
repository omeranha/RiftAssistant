using System;
using System.Collections.Generic;
using SharpDX.DirectWrite;
using work;

sealed class StatColumn
{
	public bool Enabled;
	public string Header;
	public string Unit;

	public RenderFont HeaderFont;
	public RenderBrush HeaderBrush;

	public Func<StatTracker, string> TotalValue;
	public Func<StatTracker, string> RateValue;
}

internal class ModuleStatTracker : Module
{
	private readonly RenderBrush class219_0 = new RenderBrush(192, 0, 0, 0, 0f);

	private readonly RenderBrush class219_1 = new RenderBrush(255, 16, 16, 16, 3f);

	private readonly RenderBrush class219_2 = new RenderBrush(255, 0, 0, 0, 1f);

	private readonly RenderBrush class219_3 = new RenderBrush(255, 0, 64, 0, 3f);

	private readonly RenderBrush class219_4 = new RenderBrush(255, 255, 255, 255, 0f);

	private readonly RenderBrush class219_5 = new RenderBrush(220, 107, 157, 255, 0f);

	private readonly RenderBrush class219_6 = new RenderBrush(220, 255, 148, 20, 0f);

	private readonly RenderBrush class219_7 = new RenderBrush(220, 211, 120, 67, 0f);

	private readonly RenderBrush class219_8 = new RenderBrush(220, 230, 230, 230, 0f);

	private readonly RenderBrush class219_9 = new RenderBrush(220, 87, 87, 87, 0f);

	private readonly RenderFont class221_0 = new RenderFont(255, 180, 255, 180, "arial", true, false, 7f, Alignment.Left, false, false);

	private readonly RenderFont class221_1 = new RenderFont(255, 180, 255, 180, "Arial", false, false, 6f, Alignment.Left, false, false);

	private readonly RenderFont blackText = new RenderFont(255, 0, 0, 0, "Arial", false, false, 6f, Alignment.Left, false, false);

	private readonly RenderFont class221_3 = new RenderFont(255, 0, 0, 0, "Arial", true, false, 6f, Alignment.Left, false, false);

	private readonly RenderFont whiteText = new RenderFont(255, 255, 255, 255, "Arial", false, false, 6f, Alignment.Left, false, false);

	private readonly bool showExperience;

	private readonly bool showGoldPickup;

	private readonly bool showTotalKills;

	private readonly bool showEliteKills;

	private readonly bool ShowDropAll;

	private readonly bool bool_10;

	private readonly bool bool_11;

	private readonly bool bool_12;

	private readonly bool bool_13;

	private readonly bool bool_14;

	private readonly bool bool_15;

	private readonly bool showDamageDealt;

	private readonly bool showDamageTaken;

	private readonly bool showHealing;

	private readonly float widthScale = 100f;

	private readonly List<StatTracker> trackers = [];

	private readonly List<StatColumn> columns = [];

	private int currentColumnX;

	private int currentRowY;

	private int cellPadding;

	private int[] columnWidths;

	public ModuleStatTracker(StatTrackerSettings statTracker) : base(statTracker.Enabled) {
		Show = false;
		method_0(class219_0, class219_1, class219_2, class219_3, class219_4, class219_5, class219_6, class219_7, class219_8, class219_9, class221_0, class221_1, blackText, class221_3, whiteText);
		widthScale = statTracker.ScaleWidth / 100f;

		showExperience = statTracker.Columns.Experience;
		showGoldPickup = statTracker.Columns.GoldPickup;
		showTotalKills = statTracker.Columns.KillTotal;
		showEliteKills = statTracker.Columns.KillElite;
		ShowDropAll = statTracker.Columns.DropAll;
		bool_10 = statTracker.Columns.DropWhite;
		bool_11 = statTracker.Columns.DropMagic;
		bool_12 = statTracker.Columns.DropRare;
		bool_13 = statTracker.Columns.DropLegendary;
		bool_14 = statTracker.Columns.DropBloodShard;
		bool_15 = statTracker.Columns.Death;
		showDamageDealt = statTracker.Columns.DamageDealtAll;
		showDamageTaken = statTracker.Columns.DamageTaken;
		showHealing = statTracker.Columns.Healing;

		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.Experience,
			Header = "Experience",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.GoldPickup,
			Header = "Gold Pickup",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.KillTotal,
			Header = "Total Kills",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.KillElite,
			Header = "Elite Kills",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropAll,
			Header = "Drop All",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropWhite,
			Header = "Drop White",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropMagic,
			Header = "Drop Magic",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropRare,
			Header = "Drop Rare",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropLegendary,
			Header = "Drop Legendary",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DropBloodShard,
			Header = "Drop Blood Shard",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.Death,
			Header = "Death",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DamageDealtAll,
			Header = "Damage Dealt",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.DamageTaken,
			Header = "Damage Taken",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
		columns.Add(new StatColumn {
			Enabled = statTracker.Columns.Healing,
			Header = "Healing",
			HeaderFont = whiteText,
			HeaderBrush = class219_7,
			TotalValue = t => Formatting.VtoS(
		t.DropLegendary,
		ValueFormat.NormalNumber)
		});
	}

	public override void Dispose()
	{
		Overlay.Instance.DisposeRenders(class219_0, class219_1, class219_2, class219_3, class221_0, class221_1, blackText, class221_3, class219_4);
		Overlay.Instance.DisposeRenders(class219_5, class219_6, class219_7, class219_8, class219_9, whiteText);
		base.Dispose();
	}


	private void SetupTrackers()
	{
		trackers.Clear();
		if (CoreCollector.IsGameReady) {
			trackers.Add(CoreCollector.class340_2);
			trackers.Add(CoreCollector.class340_3);
			trackers.Add(CoreCollector.class340_4);
			trackers.Add(CoreCollector.class340_5);
			trackers.Add(CoreCollector.class340_6);
			trackers.Add(CoreCollector.class340_7);
			trackers.Add(CoreCollector.class340_0);
			trackers.Add(CoreCollector.class340_1);
			if (CoreCollector.class364_0 != null) {
				trackers.Add(CoreCollector.class364_0.RunStatTracker);
				for (int i = 0; i < CoreCollector.class364_0.VisitedAreas.Count; i++) {
					AreaTracker @class = CoreCollector.class364_0.VisitedAreas[i];
					if (!@class.SnoArea.IsTown) {
						StatTracker class340_ = @class.AreaStats;
						class340_.Title = @class.AreaNameLocalized;
						class340_.SnoArea = @class.SnoArea;
						trackers.Add(class340_);
						if (@class.AreaTotalStats != null) {
							class340_ = @class.AreaTotalStats;
							class340_.Title = "TOTAL - " + @class.AreaNameLocalized;
							class340_.SnoArea = @class.SnoArea;
							trackers.Add(class340_);
						}
					}
				}
			}
		} else {
			trackers.Add(Overlay.Instance.class209_0.class340_0);
			trackers.Add(Overlay.Instance.class209_0.class340_1);
			trackers.Add(Overlay.Instance.class209_0.class340_2);
			trackers.Add(Overlay.Instance.class209_0.class340_3);
			trackers.Add(Overlay.Instance.class209_0.class340_4);
			trackers.Add(CoreCollector.class340_0);
			trackers.Add(CoreCollector.class340_1);
			trackers.Add(Overlay.Instance.class209_0.class340_5);
			trackers.Add(Overlay.Instance.class209_0.class340_6);
			trackers.Add(Overlay.Instance.class209_0.class340_7);
			trackers.Add(Overlay.Instance.class209_0.class340_8);
			trackers.Add(Overlay.Instance.class209_0.class340_9);
		}
	}

	public void Draw()
	{
		if (CoreCollector.IsLoading) {
			Show = false;
		}

		int enabledColumns = 0;
		foreach (var column in columns) {
			if (column.Enabled)
				enabledColumns++;
		}

		int num = 2 + enabledColumns * 2;
		if (columnWidths == null || columnWidths.Length != num) {
			columnWidths = new int[num];
		}
		bool flag = Show;
		if (Overlay.Instance.class209_0 != null && Overlay.Instance.class209_0.ihero_0 != null) {
			Show = true;
		}
		if (!vmethod_0(bool_4: true)) {
			Show = flag;
			return;
		}
		Show = flag;
		if (!CoreCollector.IsGameReady && Overlay.Instance.class209_0 != null && Overlay.Instance.class209_0.ihero_0 == null) {
			return;
		}

		SetupTrackers();
		int num2 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * (CoreCollector.IsGameReady ? 0.021f : 0.098f));
		int num3 = Convert.ToInt32(Math.Max(0f, ((float)GameWindowManager.Window.Size.Width - (float)GameWindowManager.Window.Size.Height * 4f / 3f * widthScale) / 2f));
		int num4 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * 0.01f);
		int num5 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * 0.02f);
		int num6 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * 0.02f);
		int num7 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * ((trackers.Count < 30) ? 0.016f : 0.016f));
		cellPadding = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * 0.003f);
		float num8 = num5 + num6 + num7 * trackers.Count;
		float num9 = (float)Convert.ToInt32(num3) + 0.5f;
		float num10 = (float)Convert.ToInt32(num2) + 0.5f;
		float num11 = Convert.ToInt32(GameWindowManager.Window.Size.Width - num3 * 2);
		float h = Convert.ToInt32(Math.Min((float)(num4 * 2) + num8, GameWindowManager.Window.Size.Height - num2 * 2));
		int num12 = Convert.ToInt32(num9 + (float)num4);
		int num13 = Convert.ToInt32(num10 + (float)num4);
		int num14 = Convert.ToInt32((float)GameWindowManager.Window.Size.Height * 0.18f);
		float num15 = num11 - (float)(num4 * 2) - (float)num14;
		float num16 = (float)num14 + num15;
		int num17 = num12 + num14;
		int num18 = Convert.ToInt32(Math.Floor(num15 / ((float)num + 1f)));
		columnWidths[0] = Convert.ToInt32(Math.Floor((float)num18 * 1.4f));
		columnWidths[1] = Convert.ToInt32(Math.Floor((float)num18 * 1.6f));
		for (int j = 2; j < num; j++) {
			columnWidths[j] = ((j % 2 == 0) ? Convert.ToInt32((float)num18 * 1.1f) : Convert.ToInt32((float)num18 * 0.9f));
		}
		class219_0.DrawRectangle(num9, num10, num11, h);
		class219_1.DrawRectangle(num9, num10, num11, h);
		currentColumnX = num17;
		currentRowY = num13;
		int num19 = 0;
		num19 = 0 + 1;
		DrawCell(0 * 2, whiteText, "time", num5, null, Alignment.Center, 2, class219_9);

		currentColumnX = num17;
		currentRowY += num5;
		num19 = 0;
		num19 = 0 + 1;
		DrawCell(0, class221_3, "in town", num6, null, Alignment.Right, 1, null);
		num19 = 1 + 1;
		DrawCell(1, whiteText, "play", num6, null, Alignment.Right, 1, class219_9);

		foreach (var column in columns) {
			if (!column.Enabled) continue;
			DrawCell(num19++ * 2, column.HeaderFont, column.Header, num5, null, Alignment.Center, 2, column.HeaderBrush);
			DrawCell(num19++ * 2, class221_3, column.Unit, num5, null, Alignment.Center, 2, null);
		}
		currentRowY += num6;
		for (int k = 0; k < trackers.Count; k++) {
			StatTracker class2 = trackers[k];
			RenderFont obj = ((class2.Title == "ACCOUNT TOTAL" || class2.Title == "HERO TOTAL") ? class221_0 : class221_1);
			TextLayout textLayout = obj.GetTextLayout(class2.Title);
			obj.DrawText(textLayout, (float)num17 - textLayout.Metrics.Width - (float)cellPadding, (float)currentRowY + ((float)num7 - textLayout.Metrics.Height) / 2f);
			currentColumnX = num17;
			RenderBrush class219_ = null;
			if (GameWindowManager.Window.CursorX >= num12 && (float)GameWindowManager.Window.CursorX <= (float)num12 + num16 && GameWindowManager.Window.CursorY >= currentRowY && GameWindowManager.Window.CursorY < currentRowY + num7) {
				class219_ = class219_4;
			}
			num19 = 0;
			if (class2.SnoArea != null) {
				DrawCell(num19++, blackText, "", num7, class219_, Alignment.Right, 1, null);
			} else {
				DrawCell(num19++, blackText, class2.AlwaysRunning ? "-" : class2.method_26(), num7, class219_, Alignment.Right, 1, null);
			}
			DrawCell(num19++, whiteText, class2.method_27(), num7, class219_, Alignment.Right, 1, class219_9);

			foreach (var column in columns) {
				if (!column.Enabled) continue;

				DrawCell(num19++, column.HeaderFont, column.TotalValue(class2), num7, class219_, Alignment.Right, 1, null);
				DrawCell(num19++, column.HeaderFont, column.RateValue(class2), num7, class219_, Alignment.Right, 1, null);
			}
			currentRowY += num7;
		}
	}

	private void DrawCell(int columnIndex, RenderFont font, string text, float height, RenderBrush hoverBrush, Alignment alignment, int columnSpan, RenderBrush overrideBrush)
	{
		int width = columnWidths[columnIndex];
		while (--columnSpan > 0) {
			width += columnWidths[++columnIndex];
		}

		var layout = font.GetTextLayout(text);
		float x = currentColumnX + 0.5f;
		float y = currentRowY + 0.5f;
		(hoverBrush ?? class219_8).DrawRectangle(x, y, width, height);

		float textX;
		float textY = currentRowY + (height - layout.Metrics.Height) * 0.5f;
		switch (alignment) {
			case Alignment.Left:
				textX = x + cellPadding;
				break;
			case Alignment.Right:
				textX = x + width - layout.Metrics.Width - cellPadding;
				break;
			default:
				textX = x + (width - layout.Metrics.Width) * 0.5f;
				break;
		}

		font.DrawText(layout, textX, textY);
		class219_2.DrawRectangle(x, y, width, height);
		currentColumnX += width;
	}
}
