using System.Globalization;

namespace Plugins.Default;

public class InventoryFreeSpace : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator RedDecorator { get; set; }
	public TopLabelDecorator YellowDecorator { get; set; }
	public TopLabelDecorator GreenDecorator { get; set; }

	public InventoryFreeSpace()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		RedDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 100, 100, true, false, 255, 0, 0, 0, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = () => (Assistant.Game.LocalPlayer.InventorySpaceTotal - Assistant.Game.InventorySpaceUsed).ToString("D", CultureInfo.InvariantCulture),
			HintFunc = () => "free space in inventory",
		};

		YellowDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 255, 200, 205, 50, true, false, false),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = () => (Assistant.Game.LocalPlayer.InventorySpaceTotal - Assistant.Game.InventorySpaceUsed).ToString("D", CultureInfo.InvariantCulture),
			HintFunc = () => "free space in inventory",
		};

		GreenDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 255, 100, 130, 100, false, false, false),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 1.0f,
			TextFunc = () => (Assistant.Game.LocalPlayer.InventorySpaceTotal - Assistant.Game.InventorySpaceUsed).ToString("D", CultureInfo.InvariantCulture),
			HintFunc = () => "free space in inventory",
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

		var freeSpace = Assistant.Game.LocalPlayer.InventorySpaceTotal - Assistant.Game.InventorySpaceUsed;

		var decorator = freeSpace < 2 ? RedDecorator : freeSpace < 20 ? YellowDecorator : GreenDecorator;
		decorator.Paint(uiRect.Left + (uiRect.Width * 0.645f), uiRect.Top + (uiRect.Height * 0.88f), uiRect.Width * 0.019f, uiRect.Height * 0.12f, HorizontalAlign.Center);
	}
}
