using System;
using System.Collections.Generic;
using System.Linq;

namespace Plugins.Default;

public class WaypointQuests : BasePlugin, ITransparentCollection, ITransparent, IInGameTopPainter
{
	public IFont BountyNameNormalFont { get; set; }
	public IFont BountyNameHighlightedFont { get; set; }

	public List<SnoQuest> BountiesToHighlight { get; } = new List<SnoQuest>();

	public float Opacity { get; set; }

	public WaypointQuests()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Order = 30000;

		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_KillTheDataminer_347095);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_KillCaptainClegg_361354);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_KillRadnoj_361352);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_ClearTheCryptOfTheAncients_345517);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_ClearWarriorsRest_345520);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_CarrionFarm_345500);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_EternalWar_345505);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_LastStandOfTheAncients_345502);
		BountiesToHighlight.Add(Assistant.Sno.SnoQuests.Bounty_TheCursedCellar_369944);

		BountyNameNormalFont = Assistant.Render.CreateFont("Arial", 7f, 255, 80, 180, 255, true, true, 160, 0, 0, 0, true);
		BountyNameHighlightedFont = Assistant.Render.CreateFont("Arial", 7f, 255, 255, 255, 0, true, true, 160, 0, 0, 0, true);
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.AfterClip)
			return;
		if (!Assistant.Render.WorldMapUiElement.Visible || Assistant.Render.ActMapUiElement.Visible)
			return;

		var mapCurrentAct = Assistant.Game.ActMapCurrentAct;
		if (mapCurrentAct == BountyAct.None)
			return;

		var w = 220 * Assistant.Window.HeightUiRatio;
		var h = 100 * Assistant.Window.HeightUiRatio;

		foreach (var waypoint in Assistant.Game.ActMapWaypoints.Where(x => x.BountyAct == mapCurrentAct)) {
			var quest = Assistant.Game.Bounties.FirstOrDefault(x => x.SnoQuest.BountySnoArea == waypoint.TargetSnoArea);
			if ((quest != null) && quest.State != QuestState.completed) {
				var x = Assistant.Render.WorldMapUiElement.Rectangle.X + (waypoint.CoordinateOnMapUiElement.X * Assistant.Window.HeightUiRatio);
				var y = Assistant.Render.WorldMapUiElement.Rectangle.Y + (waypoint.CoordinateOnMapUiElement.Y * Assistant.Window.HeightUiRatio);

				var font = BountiesToHighlight.Contains(quest.SnoQuest) ? BountyNameHighlightedFont : BountyNameNormalFont;

				var layout = font.GetTextLayout(quest.SnoQuest.NameLocalized);
				font.DrawText(layout, x + ((w - layout.Metrics.Width) / 2), y + (float)Math.Ceiling(h * 0.32f));
			}
		}
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return BountyNameNormalFont;
		yield return BountyNameHighlightedFont;
		yield return this;
	}
}
