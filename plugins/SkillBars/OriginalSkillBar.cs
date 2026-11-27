using System;
using SharpDX;

namespace Plugins.Default;

public class OriginalSkillBar : BasePlugin, IInGameTopPainter
{
	public SkillPainter SkillPainter { get; set; }

	public OriginalSkillBar()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		SkillPainter = new SkillPainter(Assistant, true) {
			TextureOpacity = 0.0f,
			EnableSkillDpsBar = true,
			EnableDetailedDpsHint = true,
		};
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.BeforeClip)
			return;
		if ((Assistant.Game.MapMode == MapMode.WaypointMap) || (Assistant.Game.MapMode == MapMode.ActMap) || (Assistant.Game.MapMode == MapMode.Map))
			return;

		var uiSkill1 = Assistant.Render.GetPlayerSkillUiElement(ActionKey.Skill1);

		foreach (var skill in Assistant.Game.LocalPlayer.Powers.CurrentSkills) {
			var ui = Assistant.Render.GetPlayerSkillUiElement(skill.Key);

			var rect = new RectangleF((float)Math.Round(ui.Rectangle.X) + 0.5f, (float)Math.Round(uiSkill1.Rectangle.Y) + 0.5f, (float)Math.Round(ui.Rectangle.Width), (float)Math.Round(uiSkill1.Rectangle.Height));

			SkillPainter.Paint(skill, rect);
		}
	}
}
