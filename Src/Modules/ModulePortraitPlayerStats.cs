using System;

namespace RiftAssistant.Modules;

internal class ModulePortraitPlayerStats : Module
{
	private readonly bool showInfo;

	private readonly bool ehp;

	private readonly bool showRealDPS;

	private readonly bool showRunDPS;

	private readonly bool showTotalDPS;

	private readonly RenderFont renderFont = new(255, 255, 255, 255, "Arial", false, false, 7f, Alignment.Center, true, false);

	private readonly RenderBrush renderBrush;

	private readonly RenderBrush renderBrush1;

	private readonly RenderBrush renderBrush2;

	private readonly RenderBrush renderBrush3 = new RenderBrush(192, 0, 0, 0, 0f);

	public ModulePortraitPlayerStats(Settings settings) : base(true)
	{
		Show = settings.Overlay.PortraitPlayerStats.Enabled;
		showRealDPS = settings.Overlay.PortraitPlayerStats.ShowRealDPS;
		showRunDPS = settings.Overlay.PortraitPlayerStats.ShowRunDPS;
		showTotalDPS = settings.Overlay.PortraitPlayerStats.ShowTotalDPS;
		showInfo = settings.Overlay.PortraitPlayerStats.ShowInfo;
		renderBrush = new RenderBrush(255, 0, 0, 0, 0f);
		ehp = settings.Overlay.PortraitPlayerStats.EHP;
		renderBrush1 = new RenderBrush(160, 0, 170, 0, 0f);
		renderBrush2 = new RenderBrush(160, 100, 100, 100, 0f);
		SetTransparentComponents(renderBrush, renderBrush3, renderBrush2, renderBrush1, renderFont);
	}

	public void Update()
	{
		bool flag = Core.Controller.Game.LocalPlayer.SnoArea != null && Overlay.Instance.ActiveMapMode != MapMode.Map && !CoreCollector.D3Memory.IsUiHidden;
		if (Overlay.Instance.ActiveMapMode == MapMode.WaypointMap || Overlay.Instance.ActiveMapMode == MapMode.ActMap) {
			flag = false;
		}
		if (!vmethod_0(flag)) {
			return;
		}
		int num = 0;
		UiElement uiElement = CoreCollector.UiElements.uiElements145[0];
		if ((float)GameWindowManager.Window.CursorX >= uiElement.rectangle.Left && (float)GameWindowManager.Window.CursorX <= uiElement.rectangle.Right && (float)GameWindowManager.Window.CursorY >= uiElement.rectangle.Top && (float)GameWindowManager.Window.CursorY <= uiElement.rectangle.Bottom) {
			DrawStats();
		}
		float ehpMax = 0f;
		foreach (Player item in CoreCollector.PlayerCollector.PlayersInGame) {
			_ = item.Damage.CurrentDps;
			if (item.HasValidActor && item.Defense.EhpMax > ehpMax) {
				ehpMax = item.Defense.EhpMax;
			}
		}
		_ = GameWindowManager.Window.Size.Height / 400;
		foreach (Player item2 in CoreCollector.PlayerCollector.PlayersInGame) {
			if (!item2.IsMe) {
				num++;
			}
			int num3 = ((!item2.IsMe) ? num : 0);
			UiElement uiElement2 = CoreCollector.UiElements.uiElements145[num3];
			if (ehp && CoreCollector.PlayerCollector.NumberOfPlayersInGame > 1) {
				float num4 = uiElement2.rectangle.Width * 0.05f;
				float num5 = uiElement2.rectangle.Height * 0.73f;
				float left = uiElement2.rectangle.Left;
				float num6 = uiElement2.rectangle.Top + uiElement2.rectangle.Height * 0.1f;
				left -= num4 + 2f;
				left -= num4 + 2f;
				if (ehp && item2.HasValidActor) {
					renderBrush2.DrawRectangle(left, num6, num4, num5);
					float num7 = num5 / ehpMax * item2.Defense.EhpMax;
					renderBrush1.DrawRectangle(left, num6 + num5 - num7, num4, num7);
				}
			}
			if ((showTotalDPS || showRunDPS || showRealDPS) && item2.IsMe) {
				float num8 = uiElement2.rectangle.Right - uiElement2.rectangle.Width * 0.18f;
				float num9 = uiElement2.rectangle.Top + uiElement2.rectangle.Height * 0.72f;
				double currentDps = item2.Damage.CurrentDps;
				double runDps = item2.Damage.RunDps;
				TextLayout textLayout = renderFont.GetTextLayout(Formatting.ValueToString(item2.Damage.TotalDamage, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (showTotalDPS) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
				textLayout = renderFont.GetTextLayout(Formatting.ValueToString(runDps, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (showRunDPS) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
				textLayout = renderFont.GetTextLayout(Formatting.ValueToString(currentDps, ValueFormat.LongNumber));
				num9 -= textLayout.Metrics.Height;
				if (showRealDPS) {
					renderFont.DrawText(textLayout, num8 - (float)Math.Floor(textLayout.Metrics.Width), num9);
				}
			}
			if (num3 == 0 && (float)GameWindowManager.Window.CursorX >= uiElement2.rectangle.Left && (float)GameWindowManager.Window.CursorX <= uiElement2.rectangle.Right && (float)GameWindowManager.Window.CursorY >= uiElement2.rectangle.Top && (float)GameWindowManager.Window.CursorY <= uiElement2.rectangle.Bottom) {
				DrawStats();
			}
			if (!showInfo) {
				continue;
			}
			string? text = null;
			if (!item2.HasValidActor) {
				if (item2.SnoArea != Core.Controller.Game.LocalPlayer.SnoArea) {
					if (item2.SnoArea != null) {
						text = "[" + item2.SnoArea.NameLocalized + "]";
					}
				} else if (!item2.CoordinateKnown) {
					text = "too far";
				}
			} else {
				if (item2.Powers.BuffIsActive(191590u)) {
					text = "returning to town";
				} else if (item2.Powers.BuffIsActive(293981u)) {
					text = "using Book of Cain";
				}
			}
			if (item2.IsDeadSafeCheck) {
				text = "dead";
				if (item2.SnoArea != null && item2.SnoArea != Core.Controller.Game.LocalPlayer.SnoArea) {
					text = text + " [" + item2.SnoArea.NameLocalized + "]";
				}
			}
			if (text != null) {
				TextLayout textLayout2 = renderFont.GetTextLayout(text);
				float num10 = uiElement2.rectangle.Right + 2f + 1f;
				float num11 = uiElement2.rectangle.Top + uiElement2.rectangle.Height * 0.71f;
				renderBrush.DrawRectangle(num10 - 3f, num11 - 2f, textLayout2.Metrics.Width + 6f, textLayout2.Metrics.Height + 5f);
				renderFont.DrawText(textLayout2, num10, num11);
			}
		}
	}

	private void DrawStats()
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
			array[num2 + 1, 1] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.ValueToString(item.Defense.EhpMax, ValueFormat.LongNumber) : "?");
			array[num2 + 1, 2] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.ValueToString(item.Offense.SheetDps, ValueFormat.LongNumber) : "?");
			array[num2 + 1, 3] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.ValueToString(item.Offense.SheetDps * (1f + item.Offense.HighestElementalDamageBonus), ValueFormat.LongNumber) : "?");
			array[num2 + 1, 4] = renderFont.GetTextLayout(item.HasValidActor ? Formatting.ValueToString(item.Offense.SheetDps * (1f + item.Offense.HighestElementalDamageBonus) * (1f + item.Offense.BonusToElitesBase), ValueFormat.LongNumber) : "?");
			array[num2 + 1, 5] = renderFont.GetTextLayout(item.IsMe ? Formatting.ValueToString(maximumDps, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 6] = renderFont.GetTextLayout(item.IsMe ? Formatting.ValueToString(runDps, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 7] = renderFont.GetTextLayout(item.IsMe ? Formatting.ValueToString(item.Damage.TotalDamage, ValueFormat.LongNumber) : "n/a");
			array[num2 + 1, 8] = renderFont.GetTextLayout(Formatting.ValueToString(item.Stats.CooldownReduction * 100f, ValueFormat.NormalNumberNoDecimal) + "%");
			array[num2 + 1, 9] = renderFont.GetTextLayout(Formatting.ValueToString(item.Stats.ResourceCostReduction * 100f, ValueFormat.NormalNumberNoDecimal) + "%");
			array[num2 + 1, 10] = renderFont.GetTextLayout(Formatting.ValueToString(item.Offense.AreaDamageBonus, ValueFormat.NormalNumberNoDecimal) + "%");
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
		renderBrush3.DrawRectangle(num12, y, num6, num7);
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
		Overlay.Instance.DisposeRenders(renderFont, renderBrush, renderBrush3, renderFont, renderBrush2, renderBrush1);
		base.Dispose();
	}
}
