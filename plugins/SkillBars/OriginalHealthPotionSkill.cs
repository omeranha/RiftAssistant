using System;
using SharpDX;

namespace Plugins.Default;

public class OriginalHealthPotionSkill : BasePlugin, IInGameTopPainter
{
	public SkillPainter SkillPainter { get; set; }

	public OriginalHealthPotionSkill()
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

		var ui = Assistant.Render.GetPlayerSkillUiElement(ActionKey.Heal);
		var rect = new RectangleF((float)Math.Round(ui.Rectangle.X) + 0.5f, (float)Math.Round(ui.Rectangle.Y) + 0.5f, (float)Math.Round(ui.Rectangle.Width), (float)Math.Round(ui.Rectangle.Height));

		SkillPainter.Paint(Assistant.Game.LocalPlayer.Powers.HealthPotionSkill, rect);
	}
}
