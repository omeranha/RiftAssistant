using System.Globalization;

namespace Plugins.Default;

public class ResourceOverGlobe : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator HealthDecorator { get; set; }
	public TopLabelDecorator HealingPosDecorator { get; set; }
	public TopLabelDecorator HealingNegDecorator { get; set; }
	public TopLabelDecorator ShieldDecorator { get; set; }

	public TopLabelDecorator ArcaneValueDecorator { get; set; }
	public TopLabelDecorator ArcaneRegenDecorator { get; set; }
	public TopLabelDecorator ManaValueDecorator { get; set; }
	public TopLabelDecorator ManaRegenDecorator { get; set; }
	public TopLabelDecorator SpiritValueDecorator { get; set; }
	public TopLabelDecorator SpiritRegenDecorator { get; set; }
	public TopLabelDecorator FuryValueDecorator { get; set; }
	public TopLabelDecorator FuryRegenDecorator { get; set; }
	public TopLabelDecorator HatredValueDecorator { get; set; }
	public TopLabelDecorator HatredRegenDecorator { get; set; }
	public TopLabelDecorator DisciplineValueDecorator { get; set; }
	public TopLabelDecorator DisciplineRegenDecorator { get; set; }
	public TopLabelDecorator WrathValueDecorator { get; set; }
	public TopLabelDecorator WrathRegenDecorator { get; set; }
	public TopLabelDecorator EssenceValueDecorator { get; set; }
	public TopLabelDecorator EssenceRegenDecorator { get; set; }

	public ResourceOverGlobe()
	{
		Enabled = true; // .NET Framework does not contains CompilerServices for C# 6
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		HealthDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 10, 255, 255, 180, 144, true, false, 96, 255, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Defense.HealthCur.ToString("#,0", CultureInfo.InvariantCulture),
		};

		HealingPosDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 110, 205, 110, true, false, 255, 100, 0, 0, true),
			TextFunc = () => (Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent > 0 ? "+" : "") + Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent.ToString("#,0", CultureInfo.InvariantCulture) + "%",
		};

		HealingNegDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 130, 130, true, false, 255, 100, 0, 0, true),
			TextFunc = () => (Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent > 0 ? "+" : "") + Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent.ToString("#,0", CultureInfo.InvariantCulture) + "%",
		};

		ShieldDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 160, 160, 215, true, false, 255, 100, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Defense.CurShield.ToString("#,0", CultureInfo.InvariantCulture),
		};

		ArcaneValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 200, 120, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurArcane.ToString("F0", CultureInfo.InvariantCulture),
		};

		ArcaneRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 200, 120, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegArcane <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegArcane.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		ManaValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 160, 160, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurMana.ToString("F0", CultureInfo.InvariantCulture),
		};

		ManaRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 160, 160, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegMana <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegMana.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		SpiritValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 255, 255, 160, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurSpirit.ToString("F0", CultureInfo.InvariantCulture),
		};

		SpiritRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 255, 160, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegSpirit <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegSpirit.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		FuryValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 255, 220, 60, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurFury.ToString("F0", CultureInfo.InvariantCulture),
		};

		FuryRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 220, 60, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegFury <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegFury.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		HatredValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 255, 160, 160, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurHatred.ToString("F0", CultureInfo.InvariantCulture),
		};

		HatredRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 160, 160, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegHatred <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegHatred.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		DisciplineValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 160, 160, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurDiscipline.ToString("F0", CultureInfo.InvariantCulture),
		};

		DisciplineRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 160, 160, 255, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegDiscipline <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegDiscipline.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		WrathValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 255, 220, 60, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurWrath.ToString("F0", CultureInfo.InvariantCulture),
		};

		WrathRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 220, 60, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegWrath <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegWrath.ToString("F0", CultureInfo.InvariantCulture) + "/s",
		};

		EssenceValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 12, 255, 175, 238, 238, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceCurEssence.ToString("F0", CultureInfo.InvariantCulture),
		};

		EssenceRegenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 175, 238, 238, true, false, 128, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Stats.ResourceRegEssence <= 0 ? null : "+" + Assistant.Game.LocalPlayer.Stats.ResourceRegEssence.ToString("F0", CultureInfo.InvariantCulture) + "/s",
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

		var uiRect = Assistant.Render.GetUiElement("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_healthBall").Rectangle;

		var glowTexture = Assistant.Texture.GetTexture(1981524232);
		glowTexture.Draw(uiRect.Left + (uiRect.Width * 0.6f) - (uiRect.Height * 0.4f), uiRect.Top + (uiRect.Height * 0.32f) - (uiRect.Height * 0.4f), uiRect.Height * 0.8f, uiRect.Height * 0.8f, opacityMultiplier: 0.7f);

		HealthDecorator.Paint(uiRect.Left + (uiRect.Width * 0.2f), uiRect.Top + (uiRect.Height * 0.26f), uiRect.Width * 0.8f, uiRect.Height * 0.15f, HorizontalAlign.Center);

		if (Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent != 0) {
			(Assistant.Game.LocalPlayer.Defense.CurrentEffectiveHealingPercent > 0 ? HealingPosDecorator : HealingNegDecorator).Paint(uiRect.Left + (uiRect.Width * 0.2f), uiRect.Top + (uiRect.Height * 0.42f), uiRect.Width * 0.8f, uiRect.Height * 0.1f, HorizontalAlign.Center);
		}

		if (Assistant.Game.LocalPlayer.Defense.CurShield > 0) {
			ShieldDecorator.Paint(uiRect.Left + (uiRect.Width * 0.2f), uiRect.Top + (uiRect.Height * 0.66f), uiRect.Width * 0.63f, uiRect.Height * 0.12f, HorizontalAlign.Right);
		}

		uiRect = Assistant.Render.GetUiElement("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_manaBall").Rectangle;

		switch (Assistant.Game.LocalPlayer.HeroClassDefinition.HeroClass) {
			case HeroClass.Barbarian:
				FuryValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				FuryRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.Crusader:
				WrathValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				WrathRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.DemonHunter:
				HatredValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width * 0.5f, uiRect.Height * 0.15f, HorizontalAlign.Center);
				DisciplineValueDecorator.Paint(uiRect.Left + (uiRect.Width * 0.5f), uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width * 0.5f, uiRect.Height * 0.15f, HorizontalAlign.Center);
				HatredRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width * 0.5f, uiRect.Height * 0.15f, HorizontalAlign.Center);
				DisciplineRegenDecorator.Paint(uiRect.Left + (uiRect.Width * 0.5f), uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width * 0.5f, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.Monk:
				SpiritValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				SpiritRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.Necromancer:
				EssenceValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				EssenceRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.WitchDoctor:
				ManaValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				ManaRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
			case HeroClass.Wizard:
				ArcaneValueDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.30f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				ArcaneRegenDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 0.43f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Center);
				break;
		}
	}
}
