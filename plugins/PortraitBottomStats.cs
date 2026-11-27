namespace Plugins.Default;

public class PortraitBottomStats : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator MonsterHpDecreaseDecorator { get; set; }

	public PortraitBottomStats()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		MonsterHpDecreaseDecorator = new TopLabelDecorator(Assistant) {
			BackgroundTexture1 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity1 = 1.0f,
			TextFont = Assistant.Render.CreateFont("tahoma", 6, 255, 200, 180, 100, true, false, 255, 0, 0, 0, true),
			TextFunc = () => ValueToString(Assistant.Stat.MonsterHitpointDecreasePerfCounter.LastValue, ValueFormat.LongNumber),
			HintFunc = () => "DPS dealt to monsters",
		};
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.BeforeClip)
			return;
		if (Assistant.Game.NumberOfPlayersInGame <= 1)
			return;
		if ((Assistant.Game.MapMode == MapMode.WaypointMap) || (Assistant.Game.MapMode == MapMode.ActMap) || (Assistant.Game.MapMode == MapMode.Map))
			return;

		var uiRect = Assistant.Render.GetUiElement("*portrait-bottom").Rectangle;

		MonsterHpDecreaseDecorator.Paint(uiRect.Left + (uiRect.Width * 0.14f), uiRect.Top + (uiRect.Height * 1.03f), uiRect.Width * 0.72f, uiRect.Height * 0.1f, HorizontalAlign.Center);
	}
}
