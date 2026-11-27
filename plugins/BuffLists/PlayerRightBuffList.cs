namespace Plugins.Default;

public class PlayerRightBuffList : BasePlugin, IInGameTopPainter
{
	public BuffPainter BuffPainter { get; set; }
	public BuffRuleCalculator RuleCalculator { get; private set; }
	public float PositionOffsetX { get; set; } = 0.14f;
	public float PositionOffsetH { get; set; } = 0.875f;

	public PlayerRightBuffList()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		BuffPainter = new BuffPainter(Assistant, true) {
			Opacity = 0.75f,
			ShowTimeLeftNumbers = false,
			ShowTooltips = false,
			TimeLeftFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 255, 255, false, false, 255, 0, 0, 0, true),
			StackFont = Assistant.Render.CreateFont("Arial", 6, 255, 255, 255, 255, false, false, 255, 0, 0, 0, true),
		};

		RuleCalculator = new BuffRuleCalculator(Assistant) {
			SizeMultiplier = 0.75f
		};
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.BeforeClip)
			return;

		RuleCalculator.CalculatePaintInfo(Assistant.Game.LocalPlayer);
		if (RuleCalculator.PaintInfoList.Count == 0)
			return;

		var x = (Assistant.Window.Size.Width * 0.5f) + (Assistant.Window.Size.Height * PositionOffsetX) - (RuleCalculator.StandardIconSize / 2);
		var h = Assistant.Window.Size.Height * PositionOffsetH;
		BuffPainter.PaintVerticalCenter(RuleCalculator.PaintInfoList, x, 0, h, RuleCalculator.StandardIconSize, RuleCalculator.StandardIconSpacing);
	}
}
