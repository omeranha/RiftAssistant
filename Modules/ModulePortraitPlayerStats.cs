using System;
using SharpDX.DirectWrite;
using work;
using Plugins;

internal class ModulePortraitPlayerStats : Module
{
	private readonly bool bool_4;

	private readonly bool bool_5;

	private readonly bool bool_6;

	private readonly bool bool_7;

	private readonly bool bool_8;

	private readonly RenderFont renderFont = new(255, 255, 255, 255, "Arial", false, false, 7f, Alignment.Center, true, false);

	private readonly RenderBrush class219_0;

	private readonly RenderBrush class219_1;

	private readonly RenderBrush class219_2;

	private readonly RenderBrush class219_3 = new RenderBrush(192, 0, 0, 0, 0f);

	public ModulePortraitPlayerStats(PortraitPlayerStats portraitPlayerStats) : base(portraitPlayerStats.Enabled)
	{
		bool_1 = false;
		bool_6 = portraitPlayerStats.ShowRealDPS;
		bool_7 = portraitPlayerStats.ShowRunDPS;
		bool_8 = portraitPlayerStats.ShowTotalDPS;
		bool_4 = portraitPlayerStats.ShowInfo;
		class219_0 = new RenderBrush(255, 0, 0, 0, 0f);
		bool_5 = portraitPlayerStats.EHP;
		class219_1 = new RenderBrush(160, 0, 170, 0, 0f);
		class219_2 = new RenderBrush(160, 100, 100, 100, 0f);
		method_0(class219_0, class219_3, class219_2, class219_1, renderFont);
	}

	public void method_1()
	{
		bool flag = Core.Controller.Game.Me.SnoArea != null && Overlay.Instance.mapMode_0 != MapMode.Map && !CoreCollector.D3Memory.IsUiHidden;
		if (Overlay.Instance.mapMode_0 == MapMode.WaypointMap || Overlay.Instance.mapMode_0 == MapMode.ActMap) {
			flag = false;
		}
		if (!vmethod_0(flag)) {
			return;
		}
		int num = 0;
		UiElement @class = CoreCollector.UiElements.class341_145[0];
		if ((float)GameWindowManager.Window.CursorX >= @class.rectangleF_0.Left && (float)GameWindowManager.Window.CursorX <= @class.rectangleF_0.Right && (float)GameWindowManager.Window.CursorY >= @class.rectangleF_0.Top && (float)GameWindowManager.Window.CursorY <= @class.rectangleF_0.Bottom) {
			method_2();
		}
		float num2 = 0f;
		foreach (Player item in CoreCollector.PlayerCollector.PlayersInGame) {
			_ = item.Damage.CurrentDps;
			if (item.HasValidActor && item.Defense.EhpMax > num2) {
				num2 = item.Defense.EhpMax;
			}
		}
		_ = GameWindowManager.Window.Size.Height / 400;
		foreach (Player item2 in CoreCollector.PlayerCollector.PlayersInGame) {
			if (!item2.IsMe) {
				num++;
			}
			int num3 = ((!item2.IsMe) ? num : 0);
			UiElement class2 = CoreCollector.UiElements.class341_145[num3];
			if (bool_5 && CoreCollector.PlayerCollector.NumberOfPlayersInGame > 1) {
				float num4 = class2.rectangleF_0.Width * 0.05f;
				float num5 = class2.rectangleF_0.Height * 0.73f;
				float left = class2.rectangleF_0.Left;
				float num6 = class2.rectangleF_0.Top + class2.rectangleF_0.Height * 0.1f;
				left -= num4 + 2f;
				left -= num4 + 2f;
				if (bool_5 && item2.HasValidActor) {
					class219_2.DrawRectangle(left, num6, num4, num5);
					float num7 = num5 / num2 * item2.Defense.EhpMax;
					class219_1.DrawRectangle(left, num6 + num5 - num7, num4, num7);
				}
			}
			if ((bool_8 || bool_7 || bool_6) && item2.IsMe) {
				float num8 = class2.rectangleF_0.Right - class2.rectangleF_0.Width * 0.18f;
				float num9 = class2.rectangleF_0.Top + class2.rectangleF_0.Height * 0.72f;
				double currentDps = item2.Damage.CurrentDps;
				double runDps = item2.Damage.RunDps;
				TextLayout textLayout = renderFont.GetTextLayout(Formatting.VtoS(item2.Damage.TotalDamage, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (bool_8) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
				textLayout = renderFont.GetTextLayout(Formatting.VtoS(runDps, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (bool_7) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
				textLayout = renderFont.GetTextLayout(Formatting.VtoS(currentDps, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (bool_6) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
			}
			if (num3 == 0 && (float)GameWindowManager.Window.CursorX >= class2.rectangleF_0.Left && (float)GameWindowManager.Window.CursorX <= class2.rectangleF_0.Right && (float)GameWindowManager.Window.CursorY >= class2.rectangleF_0.Top && (float)GameWindowManager.Window.CursorY <= class2.rectangleF_0.Bottom) {
				method_2();
			}
			if (!bool_4) {
				continue;
			}
			string text = null;
			if (!item2.HasValidActor) {
				if (item2.SnoArea != Core.Controller.Game.Me.SnoArea) {
					if (item2.SnoArea != null) {
						text = "[" + item2.SnoArea.NameLocalized + "]";
					}
				} else if (!item2.CoordinateKnown) {
					text = "too far";
				}
			} else {
				if (item2.Powers.BuffIsActive(191590u)) {
					text = "Returning to town";
				} else if (item2.Powers.BuffIsActive(293981u)) {
					text = "Using Book of Cain";
				}
			}
			if (item2.IsDeadSafeCheck) {
				text = "Dead";
				if (item2.SnoArea != null && item2.SnoArea != Core.Controller.Game.Me.SnoArea) {
					text = text + " [" + item2.SnoArea.NameLocalized + "]";
				}
			}
			if (text != null) {
				TextLayout textLayout2 = renderFont.GetTextLayout(text);
				float num10 = class2.rectangleF_0.Right + 2f + 1f;
				float num11 = class2.rectangleF_0.Top + class2.rectangleF_0.Height * 0.71f;
				class219_0.DrawRectangle(num10 - 3f, num11 - 2f, textLayout2.Metrics.Width + 6f, textLayout2.Metrics.Height + 5f);
				renderFont.DrawText(textLayout2, num10, num11);
			}
		}
	}

	private void method_2()
	{
		TextLayout[,] array = new TextLayout[CoreCollector.PlayerCollector.NumberOfPlayersInGame + 1, 11];
		array[0, 0] = renderFont.GetTextLayout("player");
		array[0, 1] = renderFont.GetTextLayout("EHP");
		array[0, 2] = renderFont.GetTextLayout("sheet DPS");
		array[0, 3] = renderFont.GetTextLayout("elem. DPS");
		array[0, 4] = renderFont.GetTextLayout("elite DPS");
		array[0, 5] = renderFont.GetTextLayout("max DPS");
		array[0, 6] = renderFont.GetTextLayout("run DPS");
		array[0, 7] = renderFont.GetTextLayout("total DMG");
		array[0, 8] = renderFont.GetTextLayout("CDR");
		array[0, 9] = renderFont.GetTextLayout("RCR");
		array[0, 10] = renderFont.GetTextLayout("Area");
		int num = 0;
		foreach (Player item in CoreCollector.PlayerCollector.PlayersInGame) {
			if (!item.IsMe) {
				num++;
			}
			int num2 = ((!item.IsMe) ? num : 0);
			double runDps = item.Damage.RunDps;
			double maximumDps = item.Damage.MaximumDps;
			array[num2 + 1, 0] = renderFont.GetTextLayout(item.BattleTagAbovePortrait);
			array[num2 + 1, 1] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.VtoS(item.Defense.EhpMax, ValueFormat.LongNumber) : "?");
			array[num2 + 1, 2] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.VtoS(item.Offense.SheetDps, ValueFormat.LongNumber) : "?");
			array[num2 + 1, 3] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.VtoS(item.Offense.SheetDps * (1f + item.Offense.HighestElementalDamageBonus), ValueFormat.LongNumber) : "?");
			array[num2 + 1, 4] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.VtoS(item.Offense.SheetDps * (1f + item.Offense.HighestElementalDamageBonus) * (1f + item.Offense.BonusToElitesBase), ValueFormat.LongNumber) : "?");
			array[num2 + 1, 5] = renderFont.GetTextLayout(item.IsMe ? Formatting.VtoS(maximumDps, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 6] = renderFont.GetTextLayout(item.IsMe ? Formatting.VtoS(runDps, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 7] = renderFont.GetTextLayout(item.IsMe ? Formatting.VtoS(item.Damage.TotalDamage, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 8] = renderFont.GetTextLayout(Formatting.VtoS(item.Stats.CooldownReduction * 100f, ValueFormat.NormalNumberNoDecimal) + "%");
			array[num2 + 1, 9] = renderFont.GetTextLayout(Formatting.VtoS(item.Stats.ResourceCostReduction * 100f, ValueFormat.NormalNumberNoDecimal) + "%");
			array[num2 + 1, 10] = renderFont.GetTextLayout(Formatting.VtoS(item.Offense.AreaDamageBonus, ValueFormat.NormalNumberNoDecimal) + "%");
		}
		float num3 = (float)GameWindowManager.Window.Size.Height * 0.01f;
		float num4 = (float)GameWindowManager.Window.Size.Height * 0.01f;
		float num5 = renderFont.GetTextLayout("Q").Metrics.Height + num4;
		float num6 = num3;
		float num7 = num5 * (float)array.GetLength(0);
		for (int i = 0; i < array.GetLength(1); i++) {
			float num8 = 0f;
			for (int j = 0; j < array.GetLength(0); j++) {
				TextLayout textLayout = array[j, i];
				if (textLayout != null) {
					float num9 = textLayout.Metrics.Width + num3;
					if (num9 > num8) {
						num8 = num9;
					}
				}
			}
			num6 += num8;
		}
		float num10 = ((float)GameWindowManager.Window.Size.Width - num6) / 2f;
		float num11 = (float)GameWindowManager.Window.Size.Height * 0.03f;
		float num12 = num10;
		float y = num11;
		class219_3.DrawRectangle(num12, y, num6, num7);
		num12 += num3;
		for (int k = 0; k < array.GetLength(1); k++) {
			float num13 = 0f;
			for (int l = 0; l < array.GetLength(0); l++) {
				TextLayout textLayout2 = array[l, k];
				if (textLayout2 != null) {
					float num14 = textLayout2.Metrics.Width + num3;
					if (num14 > num13) {
						num13 = num14;
					}
				}
			}
			y = num11;
			for (int m = 0; m < array.GetLength(0); m++) {
				TextLayout textLayout3 = array[m, k];
				if (textLayout3 != null) {
					float num15 = textLayout3.Metrics.Width + num3;
					renderFont.DrawText(textLayout3, num12 + num13 - num15, y + (num5 - textLayout3.Metrics.Height) / 2f);
					y += num5;
				}
			}
			num12 += num13;
		}
	}

	public new virtual void Dispose()
	{
		Overlay.Instance.DisposeRenders(renderFont, class219_0, class219_3, renderFont, class219_2, class219_1);
		base.Dispose();
	}
}
