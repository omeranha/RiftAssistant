namespace Plugins.Default;

public class TopRightBuffList : BasePlugin, IInGameTopPainter
{
	public BuffPainter BuffPainter { get; set; }
	public BuffRuleCalculator RuleCalculator { get; private set; }
	public float PositionX { get; set; } = 0.75f;
	public float PositionY { get; set; } = 0.001f;

	public TopRightBuffList()
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

		var w = Assistant.Window.Size.Width * 0.5f;
		var x = (Assistant.Window.Size.Width * PositionX) - (w / 2);
		var y = Assistant.Window.Size.Height * PositionY;
		BuffPainter.PaintHorizontalCenter(RuleCalculator.PaintInfoList, x, y, w, RuleCalculator.StandardIconSize, RuleCalculator.StandardIconSpacing);
	}
}
