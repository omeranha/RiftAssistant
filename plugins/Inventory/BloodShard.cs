using System.Globalization;

namespace Plugins.Default;

public class BloodShard : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator RedDecorator { get; set; }
	public TopLabelDecorator YellowDecorator { get; set; }
	public TopLabelDecorator GreenDecorator { get; set; }
	public bool ShowRemaining { get; set; }

	public BloodShard()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		string textFunc() => (ShowRemaining
			? 500 + (Assistant.Game.LocalPlayer.HighestSoloRiftLevel * 10) - Assistant.Game.LocalPlayer.Materials.BloodShard
			: Assistant.Game.LocalPlayer.Materials.BloodShard).ToString("D", CultureInfo.InvariantCulture);

		string hintFunc() => ShowRemaining
			? "amount of blood shards remaining"
			: "amount of blood shards";

		RedDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 100, 100, true, false, 255, 0, 0, 0, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = textFunc,
			HintFunc = hintFunc,
		};

		YellowDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 255, 200, 205, 50, true, false, false),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = textFunc,
			HintFunc = hintFunc,
		};

		GreenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 255, 100, 130, 100, false, false, false),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = textFunc,
			HintFunc = hintFunc,
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

		var remaining = 500 + (Assistant.Game.LocalPlayer.HighestSoloRiftLevel * 10) - Assistant.Game.LocalPlayer.Materials.BloodShard;

		var decorator = remaining < 100 ? RedDecorator : (remaining < 200 ? YellowDecorator : GreenDecorator);
		decorator.Paint(uiRect.Left + (uiRect.Width * 0.664f), uiRect.Top + (uiRect.Height * 0.88f), uiRect.Width * 0.038f, uiRect.Height * 0.12f, HorizontalAlign.Center);
	}
}
