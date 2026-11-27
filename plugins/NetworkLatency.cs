using System.Globalization;

namespace Plugins.Default;

public class NetworkLatency : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator AverageDecoratorNormal { get; set; }
	public TopLabelDecorator CurrentDecoratorNormal { get; set; }
	public TopLabelDecorator AverageDecoratorHigh { get; set; }
	public TopLabelDecorator CurrentDecoratorHigh { get; set; }
	public int HighLimit { get; set; } = 50;

	public NetworkLatency()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		AverageDecoratorNormal = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 160, 150, 200, 150, false, false, false),
			TextFunc = () => Assistant.Game.AverageLatency.ToString("F0", CultureInfo.InvariantCulture),
			HintFunc = () => "average latency"
		};

		CurrentDecoratorNormal = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 160, 150, 200, 150, false, false, false),
			TextFunc = () => Assistant.Game.CurrentLatency.ToString("F0", CultureInfo.InvariantCulture),
			HintFunc = () => "current latency"
		};

		AverageDecoratorHigh = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 200, 175, 150, false, false, false),
			TextFunc = () => Assistant.Game.AverageLatency.ToString("F0", CultureInfo.InvariantCulture),
			HintFunc = () => "average latency"
		};

		CurrentDecoratorHigh = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 200, 175, 150, false, false, false),
			TextFunc = () => Assistant.Game.CurrentLatency.ToString("F0", CultureInfo.InvariantCulture),
			HintFunc = () => "current latency"
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

		var uiRect = Assistant.Render.GetUiElement("Root.NormalLayer.game_dialog_backgroundScreenPC.latency_meter").Rectangle;

		var avg = Assistant.Game.AverageLatency;
		var cur = Assistant.Game.CurrentLatency;

		(avg >= HighLimit ? AverageDecoratorHigh : AverageDecoratorNormal).Paint(uiRect.Left + (uiRect.Width * 0.5f), uiRect.Top + (uiRect.Height * 0.62f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Left);
		(cur >= HighLimit ? CurrentDecoratorHigh : CurrentDecoratorNormal).Paint(uiRect.Left + (uiRect.Width * 0.5f), uiRect.Top + (uiRect.Height * 0.80f), uiRect.Width, uiRect.Height * 0.15f, HorizontalAlign.Left);
	}
}
