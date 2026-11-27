using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Plugins.Default;

public class BountyTable : BasePlugin, ITransparentCollection, ITransparent, IKeyEventHandler, INewAreaHandler, IInGameTopPainter
{
	public bool TurnedOn { get; set; }
	public bool TurnOffWhenNewGameStarts { get; set; } = true;
	public List<BountyType> BountyTypes { get; set; } = new List<BountyType> { BountyType.CompleteEvent, BountyType.ClearDungeon, BountyType.KillUnique, BountyType.KillBoss, BountyType.SpecialEvent };
	public IFader Fader { get; set; }

	public IFont BountyNameFont { get; set; }
	public IFont BountyNameCompletedFont { get; set; }
	public IFont BountyNameHighlightedFont { get; set; }
	public IFont BountyWaypointAreaFont { get; set; }
	public IFont BountyTypeFont { get; set; }
	public IFont InprogressTimerFont { get; set; }

	public float Opacity { get; set; }

	public BountyTable()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Order = 30000;
		BountyNameFont = Assistant.Render.CreateFont("Arial", 7.5f, 230, 255, 230, 200, false, false, 160, 0, 0, 0, true);
		BountyNameCompletedFont = Assistant.Render.CreateFont("Arial", 7.5f, 64, 255, 255, 255, false, false, false);
		BountyNameHighlightedFont = Assistant.Render.CreateFont("Arial", 7.5f, 255, 255, 255, 0, false, false, false);
		BountyWaypointAreaFont = Assistant.Render.CreateFont("Arial", 7.0f, 170, 255, 255, 255, false, false, false);
		BountyTypeFont = Assistant.Render.CreateFont("Arial", 6.5f, 96, 255, 255, 255, false, false, false);
		InprogressTimerFont = Assistant.Render.CreateFont("Arial", 7.5f, 230, 170, 215, 255, true, false, true);

		Fader = new StandardFader(Assistant, this);
	}

	public void OnNewArea(bool newGame, SnoArea area)
	{
		if (newGame) {
			if (TurnOffWhenNewGameStarts)
				TurnedOn = false;
		}
	}

	public void OnKeyEvent(InputEvent keyEvent)
	{
		if (keyEvent.Is(Vk.F6, true)) {
			TurnedOn = !TurnedOn;
		}
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.AfterClip)
			return;

		var visible = TurnedOn && Assistant.Game.Quests.Any(quest => quest.SnoQuest.Type == QuestType.Bounty);
		if (!Fader.TestVisiblity(visible))
			return;

		var w = Assistant.Window.Size.Height / 3f * 4f * 0.9f;
		var h = Assistant.Window.Size.Height * 0.7f;
		var x = (Assistant.Window.Size.Width - w) / 2;
		var y = (Assistant.Window.Size.Height - h) / 2;

		var backgroundTexture = Assistant.Texture.GetTexture("BattleNetContextMenu_Title");
		var backgroundTextureBottom = Assistant.Texture.GetTexture("BattleNetContextMenu_Bottom");
		var bountyCompleteTexture = Assistant.Texture.GetTexture("WaypointMap_MarkerBountyComplete");

		var sizeH = h / 8.0f;
		var sizeW = w / 5.0f;

		var bountyCompleteH = bountyCompleteTexture.Height / 1200.0f * Assistant.Window.Size.Height;
		var bountyCompleteW = bountyCompleteTexture.Width / (bountyCompleteTexture.Height / bountyCompleteH);

		for (var act = 1; act <= 5; act++) {
			var ax = x + (sizeW * (act - 1));
			var ay = y + (Assistant.Window.Size.Height * 0.032f);

			var completedCount = 0;
			foreach (var bountyType in BountyTypes) {
				foreach (var quest in Assistant.Game.Quests.Where(quest => quest.SnoQuest.Type == QuestType.Bounty)) {
					if ((quest.SnoQuest.SnoAct == null) || (quest.SnoQuest.SnoAct.Index != act))
						continue;
					if (quest.SnoQuest.BountyType != bountyType)
						continue;
					if (quest.State == QuestState.completed)
						completedCount++;
					backgroundTexture.Draw(ax, ay, sizeW, sizeH, Opacity);

					var ty = ay + (sizeH * 0.22f);

					var tf = quest.State != QuestState.completed ? BountyNameFont : BountyNameCompletedFont;
					var textLayout = tf.GetTextLayout(quest.SnoQuest.NameLocalized);
					tf.DrawText(textLayout, ax + ((sizeW - textLayout.Metrics.Width) / 2), ty);

					switch (quest.State) {
						case QuestState.none: {
								textLayout = BountyWaypointAreaFont.GetTextLayout(quest.SnoQuest.BountySnoArea.NameLocalized);
								BountyWaypointAreaFont.DrawText(textLayout, ax + ((sizeW - textLayout.Metrics.Width) / 2), ay + (sizeH * 0.65f) - textLayout.Metrics.Height);
							}

							break;
						case QuestState.started: {
								if (quest.StartedOn != null) {
									var elapsed = quest.StartedOn.ElapsedMilliseconds;
									var text = ValueToString(elapsed * TimeSpan.TicksPerMillisecond, ValueFormat.LongTime);
									textLayout = InprogressTimerFont.GetTextLayout(text);
									InprogressTimerFont.DrawText(textLayout, ax + ((sizeW - textLayout.Metrics.Width) / 2), ay + (sizeH * 0.65f) - textLayout.Metrics.Height);
								}
							}

							break;
						case QuestState.completed: {
								long elapsed = 0;
								if (quest.StartedOn != null) {
									elapsed = quest.StartedOn.ElapsedMilliseconds;
									if (quest.CompletedOn != null)
										elapsed -= quest.CompletedOn.ElapsedMilliseconds;
								}

								if (elapsed > 0) {
									var text = ValueToString(elapsed * TimeSpan.TicksPerMillisecond, ValueFormat.LongTime);
									textLayout = tf.GetTextLayout(text);

									var tx = ax + ((sizeW - (bountyCompleteW * 0.75f) - textLayout.Metrics.Width) / 2) - (bountyCompleteW * 0.25f);
									bountyCompleteTexture.Draw(tx, ay + ((sizeH - bountyCompleteH) * 0.7f), bountyCompleteW, bountyCompleteH, Opacity * 0.5f);

									tf.DrawText(textLayout, tx + (bountyCompleteW * 0.75f), ay + (sizeH * 0.65f) - textLayout.Metrics.Height);
								} else {
									var tx = ax + ((sizeW - bountyCompleteW) / 2);
									bountyCompleteTexture.Draw(tx, ay + ((sizeH - bountyCompleteH) * 0.7f), bountyCompleteW, bountyCompleteH, Opacity * 0.5f);
								}
							}

							break;
					}

					ay += sizeH * 0.75f;

					var bottomSizeH = backgroundTextureBottom.Height / backgroundTextureBottom.Width * sizeW;
					backgroundTextureBottom.Draw(ax, ay, sizeW, bottomSizeH, Opacity);
					ay += bottomSizeH / 2;
				}
			}

			var actHeaderTexture = Assistant.Texture.GetTexture("WaypointMap_ButtonAct" + act.ToString("D", CultureInfo.InvariantCulture) + (act == Assistant.Game.CurrentAct ? "Over" : "Up"));
			var th = actHeaderTexture.Height / 1200.0f * Assistant.Window.Size.Height;
			var tw = actHeaderTexture.Width / (actHeaderTexture.Height / th);
			actHeaderTexture.Draw(ax + ((sizeW - tw) / 2), y - (Assistant.Window.Size.Height * 0.048f), tw, th, Opacity * (completedCount == 5 ? 0.5f : 1.0f));

			if (completedCount == 5) {
				bountyCompleteTexture.Draw(ax + ((sizeW - bountyCompleteW) / 2), y - (Assistant.Window.Size.Height * 0.042f), bountyCompleteW, bountyCompleteH, Opacity);
			}
		}
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return BountyNameFont;
		yield return BountyNameCompletedFont;
		yield return BountyNameHighlightedFont;
		yield return BountyWaypointAreaFont;
		yield return BountyTypeFont;
		yield return InprogressTimerFont;
		yield return this;
	}
}
