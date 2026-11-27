using System;
using System.Globalization;

namespace Plugins.Default;

public class DamageBonus : BasePlugin, IInGameTopPainter
{
	public bool ShowInTown { get; set; } = true;
	public bool ShowOutOfTown { get; set; } = false;
	public TopLabelDecorator PhysicalDecorator { get; set; }
	public TopLabelDecorator FireDecorator { get; set; }
	public TopLabelDecorator LightningDecorator { get; set; }
	public TopLabelDecorator ColdDecorator { get; set; }
	public TopLabelDecorator PoisonDecorator { get; set; }
	public TopLabelDecorator ArcaneDecorator { get; set; }
	public TopLabelDecorator HolyDecorator { get; set; }
	public TopLabelDecorator EliteDecorator { get; set; }

	public DamageBonus()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		PhysicalDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 155, 6, 0, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToPhysical > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToPhysical * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "physical damage %"
		};

		FireDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 183, 57, 7, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToFire > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToFire * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "fire damage %"
		};

		LightningDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 0, 38, 119, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToLightning > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToLightning * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "lightning damage %"
		};

		ColdDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 77, 102, 155, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToCold > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToCold * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "cold damage %"
		};

		PoisonDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 50, 106, 21, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToPoison > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToPoison * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "poison damage %"
		};

		ArcaneDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 138, 0, 94, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToArcane > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToArcane * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "arcane damage %"
		};

		HolyDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 190, 117, 0, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToHoly > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToHoly * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "holy damage %"
		};

		EliteDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(180, 255, 148, 20, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, true),
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.BonusToElites > 0 ? Convert.ToInt32(Assistant.Game.LocalPlayer.Offense.BonusToElites * 100).ToString("D", CultureInfo.InvariantCulture) : "",
			HintFunc = () => "elite damage %",
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

		if (!ShowInTown && Assistant.Game.IsInTown)
			return;
		if (!ShowOutOfTown && !Assistant.Game.IsInTown)
			return;

		var uiRect = Assistant.Render.InGameBottomHudUiElement.Rectangle;

		var w = Assistant.Window.Size.Height * 0.017f;
		var h = Assistant.Window.Size.Height * 0.014f;

		var x = uiRect.Left + (uiRect.Width * 0.09f);
		var y = uiRect.Bottom - h - (Assistant.Window.Size.Height / 600);

		EliteDecorator.Paint(x + (w * 0), y, w, h, HorizontalAlign.Center);
		PhysicalDecorator.Paint(x + (w * 1), y, w, h, HorizontalAlign.Center);
		FireDecorator.Paint(x + (w * 2), y, w, h, HorizontalAlign.Center);
		LightningDecorator.Paint(x + (w * 3), y, w, h, HorizontalAlign.Center);
		ColdDecorator.Paint(x + (w * 4), y, w, h, HorizontalAlign.Center);
		PoisonDecorator.Paint(x + (w * 5), y, w, h, HorizontalAlign.Center);
		ArcaneDecorator.Paint(x + (w * 6), y, w, h, HorizontalAlign.Center);
		HolyDecorator.Paint(x + (w * 7), y, w, h, HorizontalAlign.Center);
	}
}
