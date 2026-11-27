using System;
using System.Globalization;
using System.Linq;

namespace Plugins.Default;

public class Rift : BasePlugin, IInGameTopPainter
{
	public bool NephalemRiftPercentEnabled { get; set; }
	public IFont NephalemRiftPercentFont { get; set; }

	public bool GreaterRiftPercentEnabled { get; set; }
	public IFont GreaterRiftPercentFont { get; set; }

	public bool GreaterRiftTimerEnabled { get; set; }
	public IFont GreaterRiftTimerFont { get; set; }

	public bool ChallengeRiftPercentEnabled { get; set; }
	public IFont ChallengeRiftPercentFont { get; set; }

	public bool ChallengeRiftTimerEnabled { get; set; }
	public IFont ChallengeRiftTimerFont { get; set; }

	public bool NearMonsterProgressionEnabled { get; set; }
	public IFont NearMonsterProgressionFont { get; set; }
	public int NearMonsterProgressionRange { get; set; }

	public Rift()
	{
		Enabled = true;
		Order = 30000;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		NephalemRiftPercentEnabled = true;
		NephalemRiftPercentFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 210, 150, true, false, 160, 0, 0, 0, true);

		GreaterRiftPercentEnabled = true;
		GreaterRiftPercentFont = Assistant.Render.CreateFont("Arial", 7, 255, 200, 100, 200, true, false, 160, 0, 0, 0, true);

		GreaterRiftTimerEnabled = true;
		GreaterRiftTimerFont = Assistant.Render.CreateFont("Arial", 7, 255, 180, 147, 109, true, false, 160, 0, 0, 0, true);

		ChallengeRiftPercentEnabled = true;
		ChallengeRiftPercentFont = Assistant.Render.CreateFont("Arial", 7, 255, 5, 171, 170, true, false, 160, 0, 0, 0, true);

		ChallengeRiftTimerEnabled = true;
		ChallengeRiftTimerFont = Assistant.Render.CreateFont("Arial", 7, 255, 180, 147, 109, true, false, 160, 0, 0, 0, true);

		NearMonsterProgressionEnabled = true;
		NearMonsterProgressionFont = Assistant.Render.CreateFont("Arial", 7, 255, 180, 147, 109, true, false, 160, 0, 0, 0, true);
		NearMonsterProgressionRange = 40;
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.BeforeClip)
			return;
		if ((Assistant.Game.SpecialArea != SpecialArea.Rift) && (Assistant.Game.SpecialArea != SpecialArea.GreaterRift) && (Assistant.Game.SpecialArea != SpecialArea.ChallengeRift))
			return;
		if ((Assistant.Game.MapMode == MapMode.WaypointMap) || (Assistant.Game.MapMode == MapMode.ActMap) || (Assistant.Game.MapMode == MapMode.Map))
			return;

		if (Assistant.Game.SpecialArea == SpecialArea.Rift) {
			DrawRift();
		}

		if (Assistant.Game.SpecialArea == SpecialArea.GreaterRift) {
			DrawGreaterRift();
		}

		if (Assistant.Game.SpecialArea == SpecialArea.ChallengeRift) {
			DrawChallengeRift();
		}
	}

	private void DrawRift()
	{
		var ui = Assistant.Render.NephalemRiftBarUiElement;
		if (!ui.Visible)
			return;

		if (NephalemRiftPercentEnabled) {
			var percent = Assistant.Game.RiftPercentage;
			var text = percent.ToString("F1", CultureInfo.InvariantCulture) + "%";
			var textLayout = NephalemRiftPercentFont.GetTextLayout(text);
			var x = (float)(ui.Rectangle.Left + (ui.Rectangle.Width / 100.0f * percent)) - (textLayout.Metrics.Width / 2);
			var y = ui.Rectangle.Top - (ui.Rectangle.Height * 0.2f) - textLayout.Metrics.Height;
			NephalemRiftPercentFont.DrawText(textLayout, x, y);
		}

		if (NearMonsterProgressionEnabled && (Assistant.Game.CurrentQuestProgress < Assistant.Game.MaxQuestProgress)) {
			var total = CalculateNearMonsterProgression(NearMonsterProgressionRange) / Assistant.Game.MaxQuestProgress * 100d;
			var text = total.ToString("F2", CultureInfo.InvariantCulture) + "% in " + NearMonsterProgressionRange.ToString("F0") + " yards";
			var textLayout = NearMonsterProgressionFont.GetTextLayout(text);
			var x = ui.Rectangle.Left + ((ui.Rectangle.Width - textLayout.Metrics.Width) / 2);
			var y = ui.Rectangle.Top + ((ui.Rectangle.Height - textLayout.Metrics.Height) / 2) + 1;
			NearMonsterProgressionFont.DrawText(textLayout, x, y);
		}
	}

	private void DrawGreaterRift()
	{
		var ui = Assistant.Render.GreaterRiftBarUiElement;
		if (!ui.Visible)
			return;

		if (GreaterRiftTimerEnabled) {
			var secondsLeft = (Assistant.Game.CurrentTimedEventEndTick - Assistant.Game.CurrentTimedEventEndTickMod - (double)Assistant.Game.CurrentGameTick) / 60.0d;
			if (secondsLeft > 0) {
				var text = ValueToString((long)(Assistant.Game.CurrentTimedEventEndTick - Assistant.Game.CurrentTimedEventEndTickMod - Assistant.Game.CurrentGameTick) * 1000 * TimeSpan.TicksPerMillisecond / 60, ValueFormat.LongTime);
				var textLayout = GreaterRiftTimerFont.GetTextLayout(text);
				GreaterRiftTimerFont.DrawText(textLayout, ui.Rectangle.Right - (float)(ui.Rectangle.Width / 900.0f * secondsLeft) - (textLayout.Metrics.Width / 2), ui.Rectangle.Bottom + (ui.Rectangle.Height * 0.7f));
			}
		}

		if (GreaterRiftPercentEnabled) {
			var percent = Assistant.Game.RiftPercentage;
			var text = percent.ToString("F1", CultureInfo.InvariantCulture) + "%";
			var textLayout = GreaterRiftPercentFont.GetTextLayout(text);
			var x = (float)(ui.Rectangle.Left + (ui.Rectangle.Width / 100.0f * percent)) - (textLayout.Metrics.Width / 2);
			var y = ui.Rectangle.Top - (ui.Rectangle.Height * 0.7f) - textLayout.Metrics.Height;
			GreaterRiftPercentFont.DrawText(textLayout, x, y);
		}

		if (NearMonsterProgressionEnabled && (Assistant.Game.CurrentQuestProgress < Assistant.Game.MaxQuestProgress)) {
			var total = CalculateNearMonsterProgression(NearMonsterProgressionRange) / Assistant.Game.MaxQuestProgress * 100d;
			var text = total.ToString("F2", CultureInfo.InvariantCulture) + "% in " + NearMonsterProgressionRange.ToString("F0") + " yards";
			var textLayout = NearMonsterProgressionFont.GetTextLayout(text);
			var x = ui.Rectangle.Left + ((ui.Rectangle.Width - textLayout.Metrics.Width) / 2);
			var y = ui.Rectangle.Top + ((ui.Rectangle.Height - textLayout.Metrics.Height) / 2) + 1;
			NearMonsterProgressionFont.DrawText(textLayout, x, y);
		}
	}

	private void DrawChallengeRift()
	{
		var ui = Assistant.Render.ChallengeRiftBarUiElement;
		if (!ui.Visible)
			return;

		if (ChallengeRiftTimerEnabled) {
			var secondsLeft = (Assistant.Game.CurrentTimedEventEndTick - Assistant.Game.CurrentTimedEventEndTickMod - (double)Assistant.Game.CurrentGameTick) / 60.0d;
			if (secondsLeft > 0) {
				var text = ValueToString((long)(Assistant.Game.CurrentTimedEventEndTick - Assistant.Game.CurrentTimedEventEndTickMod - Assistant.Game.CurrentGameTick) * 1000 * TimeSpan.TicksPerMillisecond / 60, ValueFormat.LongTime);
				var textLayout = ChallengeRiftTimerFont.GetTextLayout(text);
				if (!Assistant.Render.ChallengeRiftAheadPanelUiElement.Visible) {
					ChallengeRiftTimerFont.DrawText(textLayout, ui.Rectangle.Left + ((ui.Rectangle.Width - textLayout.Metrics.Width) / 2), ui.Rectangle.Bottom + (ui.Rectangle.Height * 0.4f));
				} else {
					ChallengeRiftTimerFont.DrawText(textLayout, ui.Rectangle.Left + ((ui.Rectangle.Width - textLayout.Metrics.Width) / 2), Assistant.Render.ChallengeRiftAheadPanelUiElement.Rectangle.Bottom - (ui.Rectangle.Height * 0.7f));
				}
			}
		}

		if (ChallengeRiftPercentEnabled) {
			var percent = Assistant.Game.RiftPercentage;
			var text = percent.ToString("F1", CultureInfo.InvariantCulture) + "%";
			var textLayout = ChallengeRiftPercentFont.GetTextLayout(text);
			var x = (float)(ui.Rectangle.Left + (ui.Rectangle.Width / 100.0f * percent)) - (textLayout.Metrics.Width / 2);
			var y = ui.Rectangle.Top - (ui.Rectangle.Height * 0.7f) - textLayout.Metrics.Height;
			ChallengeRiftPercentFont.DrawText(textLayout, x, y);
		}

		if (NearMonsterProgressionEnabled && (Assistant.Game.CurrentQuestProgress < Assistant.Game.MaxQuestProgress)) {
			var total = CalculateNearMonsterProgression(NearMonsterProgressionRange) / Assistant.Game.MaxQuestProgress * 100d;
			var text = total.ToString("F2", CultureInfo.InvariantCulture) + "% in " + NearMonsterProgressionRange.ToString("F0") + " yards";
			var textLayout = NearMonsterProgressionFont.GetTextLayout(text);
			var x = ui.Rectangle.Left + ((ui.Rectangle.Width - textLayout.Metrics.Width) / 2);
			var y = ui.Rectangle.Top + ((ui.Rectangle.Height - textLayout.Metrics.Height) / 2) + 1;
			NearMonsterProgressionFont.DrawText(textLayout, x, y);
		}
	}

	private float CalculateNearMonsterProgression(int range)
	{
		var monsters = Assistant.Game.AliveMonsters.Where(x => (x.SnoMonster != null) && (x.NormalizedXyDistanceToMe <= range) && !((x.SummonerAcdDynamicId != 0) && (x.Rarity == ActorRarity.RareMinion)));
		return monsters.Sum(x => x.SnoMonster.RiftProgression);
	}
}
