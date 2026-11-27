using System.Globalization;

namespace Plugins.Default;

public class ExperienceOverBar : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator BlueThisLevelValueDecorator { get; set; }
	public TopLabelDecorator OrangeThisLevelValueDecorator { get; set; }
	public TopLabelDecorator BlueNextLevelValueDecorator { get; set; }
	public TopLabelDecorator OrangeNextLevelValueDecorator { get; set; }
	public TopLabelDecorator BonusValueDecorator { get; set; }

	public ExperienceOverBar()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		BlueThisLevelValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 5.5f, 255, 140, 140, 180, false, false, 160, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.ParagonExpInThisLevel.ToString("#,0", CultureInfo.InvariantCulture),
			HintFunc = () => "experience gained in this level",
		};

		OrangeThisLevelValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 5.5f, 255, 200, 160, 140, false, false, 160, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.ParagonExpInThisLevel.ToString("#,0", CultureInfo.InvariantCulture),
			HintFunc = () => "experience gained in this level",
		};

		BlueNextLevelValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 5.5f, 255, 140, 140, 180, false, false, 160, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.ParagonExpToNextLevel.ToString("#,0", CultureInfo.InvariantCulture),
			HintFunc = () => "experience to reach next level",
		};

		OrangeNextLevelValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 5.5f, 255, 200, 160, 140, false, false, 160, 0, 0, 0, true),
			TextFunc = () => Assistant.Game.LocalPlayer.ParagonExpToNextLevel.ToString("#,0", CultureInfo.InvariantCulture),
			HintFunc = () => "experience to reach next level",
		};

		BonusValueDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 5.5f, 255, 200, 160, 140, false, false, 160, 0, 0, 0, true),
			TextFunc = () => (Assistant.Game.LocalPlayer.BonusPoolRemaining * 5).ToString("#,0", CultureInfo.InvariantCulture),
			HintFunc = () => "bonus pool * 5",
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

		var uiRect = Assistant.Render.InGameBottomHudUiElement.Rectangle;

		var bonusRemaining = Assistant.Game.LocalPlayer.BonusPoolRemaining;

		(bonusRemaining > 0 ? OrangeThisLevelValueDecorator : BlueThisLevelValueDecorator).Paint(uiRect.Left + (uiRect.Width * 0.42f), uiRect.Top + (uiRect.Height * 0.470f), uiRect.Width * 0.075f, uiRect.Height * 0.07f, HorizontalAlign.Right);
		(bonusRemaining > 0 ? OrangeNextLevelValueDecorator : BlueNextLevelValueDecorator).Paint(uiRect.Left + (uiRect.Width * 0.505f), uiRect.Top + (uiRect.Height * 0.470f), uiRect.Width * 0.075f, uiRect.Height * 0.07f, HorizontalAlign.Left);

		if (bonusRemaining > 0) {
			BonusValueDecorator.Paint(uiRect.Left + (uiRect.Width * 0.651f), uiRect.Top + (uiRect.Height * 0.470f), uiRect.Width * 0.075f, uiRect.Height * 0.07f, HorizontalAlign.Right);
		}
	}
}
