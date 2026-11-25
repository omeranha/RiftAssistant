#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SharpDX;
using SharpDX.DirectWrite;

namespace RiftAssistant.Modules;

internal class ModuleLobbyHeroes : Module
{
	public Hero? hero0;

	internal StatTracker? currentAccountTotal;

	internal StatTracker? currentAccountLastMonth;

	internal StatTracker? currentAccountLastWeek;

	internal StatTracker? currentAccountYesterday;

	internal StatTracker? currentAccountToday;

	internal StatTracker? tracker;

	internal StatTracker? statTracker6;

	internal StatTracker? statTracker7;

	internal StatTracker? statTracker8;

	internal StatTracker? statTracker9;

	private readonly RenderBrush renderBrush;

	private readonly RenderBrush renderBrush1;

	private readonly RenderFont renderFont;

	private readonly RenderFont renderFont1;

	private readonly RenderFont renderFont2;

	private readonly RenderFont renderFont3;

	private readonly RenderFont renderFont4;

	private readonly RenderFont renderFont5;

	public ModuleLobbyHeroes(Settings settings) : base(true)
	{
		Show = settings.Overlay.EnableLobbyHeroes;
		renderBrush = new RenderBrush(192, 1, 1, 1, 0f);
		renderBrush1 = new RenderBrush(96, 1, 1, 1, 0f);
		renderFont = new RenderFont(255, 205, 205, 205, "Arial", true, false, 6f, Alignment.Left, false, true);
		renderFont1 = new RenderFont(255, 255, 100, 100, "Arial", true, false, 6f, Alignment.Left, false, true);
		renderFont2 = new RenderFont(255, 200, 255, 200, "Arial", true, false, 6f, Alignment.Left, false, true);
		renderFont3 = new RenderFont(255, 255, 255, 255, "Arial", true, false, 6f, Alignment.Left, false, false);
		renderFont4 = new RenderFont(255, 200, 200, 200, "Arial", false, false, 6f, Alignment.Left, false, true)
		{
			HeavyShadow = true
		};
		renderFont5 = new RenderFont(255, 107, 187, 255, "Arial", false, false, 6f, Alignment.Left, false, true)
		{
			HeavyShadow = true
		};
		SetTransparentComponents(renderBrush, renderBrush1, renderFont, renderFont1, renderFont2, renderFont3, renderFont4, renderFont5);
	}

	protected void Dispose(bool disposing)
	{
		Overlay.Instance.DisposeRenders(renderBrush, renderBrush1, renderFont, renderFont1, renderFont2, renderFont3, renderFont4, renderFont5);
		base.Dispose();
	}

	public void Update()
	{
		bool bool_;
		if (!(bool_ = !CoreCollector.IsGameReady && CoreCollector.UiElements.QuestNameValue.Visible && !CoreCollector.UiElements.BattleNetProfileMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.BattleNetGameSettingsMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.GamemenuBkgrnd.Visible && CoreCollector.HeroCollector.HeroList.Any()))
		{
			hero0 = null;
			currentAccountTotal = null;
			currentAccountLastMonth = null;
			currentAccountLastWeek = null;
			currentAccountYesterday = null;
			currentAccountToday = null;
			tracker = null;
			statTracker6 = null;
			statTracker7 = null;
			statTracker8 = null;
			statTracker9 = null;
			return;
		}
		if (!vmethod_0(bool_))
		{
			hero0 = null;
			currentAccountTotal = null;
			currentAccountLastMonth = null;
			currentAccountLastWeek = null;
			currentAccountYesterday = null;
			currentAccountToday = null;
			tracker = null;
			statTracker6 = null;
			statTracker7 = null;
			statTracker8 = null;
			statTracker9 = null;
			return;
		}
		List<Hero> list = CoreCollector.HeroCollector.HeroList.OrderByDescending((Hero ihero_0) => ihero_0.PlayedSeconds).ToList();
		int num = GameWindowManager.Window.Size.Height / 20;
		int num2 = num;
		float num3 = (float)num * 1.289f;
		renderBrush1.DrawRectangle(0f, 0f, GameWindowManager.Window.Size.Width, num3);
		float num4 = 0f;
		TextLayout[] array = new TextLayout[list.Count];
		string[] array2 = new string[list.Count];
		for (int num5 = 0; num5 < list.Count; num5++)
		{
			Hero hero = list[num5];
			string text = hero.Name;
			if ((hero.Flags & 8) == 8)
			{
				text += " (dead)";
			}
			TextLayout textLayout = (array[num5] = renderFont.GetTextLayout(text));
			array2[num5] = text;
			num4 += textLayout.Metrics.Width;
		}
		float num6 = ((float)GameWindowManager.Window.Size.Width - num4) / (float)(list.Count + 1);
		float num7 = num6;
		float num8 = 2f;
		float num9 = (float)GameWindowManager.Window.Size.Height / 100f;
		Hero? hero2 = null;
		for (int num10 = 0; num10 < list.Count; num10++)
		{
			Hero hero3 = list[num10];
			RectangleF rectangle = new RectangleF(num7 + (array[num10].Metrics.Width - (float)num) / 2f, 0f, num, num);
			bool num11 = rectangle.Contains(GameWindowManager.Window.CursorX, GameWindowManager.Window.CursorY);
			if (num11)
			{
				hero2 = hero3;
			}
			RenderFont transparent = (num11 ? renderFont2 : (hero3.Hardcore ? renderFont1 : renderFont));
			TextLayout textLayout2 = ((transparent == renderFont) ? array[num10] : transparent.GetTextLayout(array2[num10]));
			int num12 = num2;
			transparent.DrawText(textLayout2, num7, num12);
			string text2 = hero3.ClassDefinition.Code.ToLowerInvariant();
			Texture? portraitTexture = TextureManager.GetTextureByName("Portrait_" + text2.Substring(0, 1).ToUpperInvariant() + text2.Substring(1) + (hero3.IsMale ? "_Male" : "_Female"));
			portraitTexture.Draw(rectangle);
			TextLayout textLayout3 = renderFont4.GetTextLayout(hero3.Level.ToString("D", CultureInfo.InvariantCulture));
			renderFont4.DrawText(textLayout3, rectangle.Left, rectangle.Top + (float)num * 0.1f);
			TextLayout textLayout4 = renderFont5.GetTextLayout(hero3.ParagonLevel.ToString("D", CultureInfo.InvariantCulture));
			renderFont5.DrawText(textLayout4, rectangle.Left, rectangle.Top + (float)num * 0.28f);
			if (hero3.Seasonal)
			{
				RectangleF rectangle2 = new RectangleF(rectangle.Left + (float)num * 0.6f, rectangle.Bottom - (float)num * 0.5f, (float)num * 0.6f, (float)num * 0.6f);
				Texture? seasonIcon = TextureManager.GetTextureByName("BattleNet_SeasonIcon");
				seasonIcon.Draw(rectangle2, 2f);
			}
			if (hero3.Hardcore)
			{
				RectangleF rectangle3 = new RectangleF(rectangle.Left, rectangle.Bottom - (float)num * 0.5f, (float)num * 0.6f, (float)num * 0.6f);
				Texture? hardcoreIcon = TextureManager.GetTextureByName("BattleNet_HardcoreIcon");
				hardcoreIcon.Draw(rectangle3, 2f);
			}
			num7 += array[num10].Metrics.Width + num6;
		}
		float num13 = (float)GameWindowManager.Window.Size.Height * 0.034f;
		if (hero2 != null)
		{
			int num14 = hero2.PlayedSeconds / 60 / 60;
			int num15 = (hero2.PlayedSeconds - num14 * 60 * 60) / 60;
			string text3 = SnoData.Strings.GetStringByCode(StringListSnoEnum._bnet_heroselect, "LastAct").Replace("{s1}", hero2.LastPlayedDT.ToString("yyyy.MM.dd HH:mm", CultureInfo.InvariantCulture)) + "  |  " + SnoData.Strings.GetStringByCode(StringListSnoEnum._bnet_heroselect, "TimePlayed").Replace("{s1}", num14.ToString("D", CultureInfo.InvariantCulture) + " h, " + num15.ToString("D", CultureInfo.InvariantCulture) + " m");
			string text4 = ((hero2.QuestStep != null) ? SnoData.Strings.GetStringByCode(StringListSnoEnum._bnet_tooltips, "QuestSelectorQuestLastPlayed").Replace("{s1}", hero2.QuestStep.SnoQuest.NameLocalized + " / " + hero2.QuestStep.BnetTitleLocalized) : "");
			TextLayout textLayout5 = renderFont3.GetTextLayout(text3);
			TextLayout textLayout6 = renderFont3.GetTextLayout(text4);
			float num16 = ((float)GameWindowManager.Window.Size.Width - textLayout5.Metrics.Width - num9 * 2f) / 2f;
			renderBrush.DrawRectangle(num16 - num9, num3, textLayout5.Metrics.Width + num9 * 2f, num13);
			float num17 = num3 + (num13 - textLayout5.Metrics.Height - textLayout6.Metrics.Height - num8) / 2f;
			renderFont3.DrawText(textLayout5, num16, num17 - num8 / 2f);
			num16 = ((float)GameWindowManager.Window.Size.Width - textLayout6.Metrics.Width - num9 * 2f) / 2f;
			renderFont3.DrawText(textLayout6, num16, num17 + textLayout5.Metrics.Height + num8);
			if (currentAccountTotal != null && !(currentAccountTotal.Id != CoreCollector.BattleTag) && tracker != null && !(tracker.Id != hero2.Id.ToString("D", CultureInfo.InvariantCulture)) && hero0 == hero2)
			{
				return;
			}
			hero0 = hero2;
			DateTime now = DateTime.Now;
			currentAccountTotal = new StatTracker(CoreCollector.BattleTag, false, "ACCOUNT TOTAL", "total");
			currentAccountYesterday = new StatTracker(CoreCollector.BattleTag, false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			currentAccountToday = new StatTracker(CoreCollector.BattleTag, false, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			tracker = new StatTracker(hero2.Id.ToString("D", CultureInfo.InvariantCulture), false, "HERO TOTAL", "total");
			statTracker8 = new StatTracker(hero2.Id.ToString("D", CultureInfo.InvariantCulture), false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			statTracker9 = new StatTracker(hero2.Id.ToString("D", CultureInfo.InvariantCulture), false, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			for (int num18 = 0; num18 < 30; num18++)
			{
				string item = "total_" + now.AddDays(-num18).ToString("yyyyMMdd", CultureInfo.InvariantCulture);
				list2.Add(item);
				if (num18 <= 6)
				{
					list3.Add(item);
				}
			}
			statTracker6 = new StatTracker(hero2.Id.ToString("D", CultureInfo.InvariantCulture), false, "last 30 days", list2);
			statTracker7 = new StatTracker(hero2.Id.ToString("D", CultureInfo.InvariantCulture), false, "last 7 days", list3);
			currentAccountLastMonth = new StatTracker(CoreCollector.BattleTag, false, "last 30 days", list2);
			currentAccountLastWeek = new StatTracker(CoreCollector.BattleTag, false, "last 7 days", list3);
		}
		else
		{
			hero0 = null;
			currentAccountTotal = null;
			currentAccountLastMonth = null;
			currentAccountLastWeek = null;
			currentAccountYesterday = null;
			currentAccountToday = null;
			tracker = null;
			statTracker6 = null;
			statTracker7 = null;
			statTracker8 = null;
			statTracker9 = null;
		}
	}
}
