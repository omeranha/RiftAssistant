namespace Plugins.Default;

public class MiniMapLeftBuffList : BasePlugin, IInGameTopPainter
{
	public BuffPainter BuffPainter { get; set; }
	public BuffRuleCalculator RuleCalculator { get; private set; }

	public MiniMapLeftBuffList()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		BuffPainter = new BuffPainter(Assistant, true) {
			Opacity = 0.50f,
			TimeLeftFont = Assistant.Render.CreateFont("Arial", 5, 160, 255, 255, 255, true, false, 160, 0, 0, 0, true),
		};

		RuleCalculator = new BuffRuleCalculator(Assistant) {
			SizeMultiplier = 0.75f
		};

		RuleCalculator.Rules.Add(new BuffRule(263029) { MinimumIconCount = 1 }); // Conduit
		RuleCalculator.Rules.Add(new BuffRule(403404) { MinimumIconCount = 1 }); // Conduit in tiered rift
		RuleCalculator.Rules.Add(new BuffRule(278269) { MinimumIconCount = 1 }); // Enlightened
		RuleCalculator.Rules.Add(new BuffRule(030477) { MinimumIconCount = 1 }); // Enlightened
		RuleCalculator.Rules.Add(new BuffRule(278271) { MinimumIconCount = 1 }); // Frenzied
		RuleCalculator.Rules.Add(new BuffRule(030479) { MinimumIconCount = 1 }); // Frenzied
		RuleCalculator.Rules.Add(new BuffRule(278270) { MinimumIconCount = 1 }); // Fortune
		RuleCalculator.Rules.Add(new BuffRule(030478) { MinimumIconCount = 1 }); // Fortune
		RuleCalculator.Rules.Add(new BuffRule(278268) { MinimumIconCount = 1 }); // Blessed
		RuleCalculator.Rules.Add(new BuffRule(030476) { MinimumIconCount = 1 }); // Blessed
		RuleCalculator.Rules.Add(new BuffRule(266258) { MinimumIconCount = 1 }); // Channeling
		RuleCalculator.Rules.Add(new BuffRule(266254) { MinimumIconCount = 1 }); // Shield
		RuleCalculator.Rules.Add(new BuffRule(262935) { MinimumIconCount = 1 }); // Power
		RuleCalculator.Rules.Add(new BuffRule(266271) { MinimumIconCount = 1 }); // Speed
		RuleCalculator.Rules.Add(new BuffRule(260349) { MinimumIconCount = 1 }); // Empowered
		RuleCalculator.Rules.Add(new BuffRule(260348) { MinimumIconCount = 1 }); // Fleeting
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

		var uiMinimapRect = Assistant.Render.MinimapUiElement.Rectangle;

		var x = uiMinimapRect.Left - (RuleCalculator.StandardIconSize / 2);
		BuffPainter.PaintVerticalCenter(RuleCalculator.PaintInfoList, x, uiMinimapRect.Top, uiMinimapRect.Height, RuleCalculator.StandardIconSize, RuleCalculator.StandardIconSpacing);
	}
}
