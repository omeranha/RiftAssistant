using System.Globalization;

namespace Plugins.Default;

public class NotifyAtRiftPercentage : BasePlugin, IInGameTopPainter
{
	public TopLabelWithTitleDecorator LabelDecorator { get; set; }
	public int DisplayLimit { get; set; } = 90;

	public NotifyAtRiftPercentage()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		LabelDecorator = new TopLabelWithTitleDecorator(Assistant) {
			BorderBrush = Assistant.Render.CreateBrush(255, 180, 147, 109, -1),
			BackgroundBrush = Assistant.Render.CreateBrush(128, 0, 0, 0, 0),
			TextFont = Assistant.Render.CreateFont("Arial", 9, 255, 255, 210, 150, true, false, false),
			TitleFont = Assistant.Render.CreateFont("Arial", 6, 255, 180, 147, 109, true, false, false),
		};
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.AfterClip)
			return;
		if ((Assistant.Game.SpecialArea != SpecialArea.Rift) && (Assistant.Game.SpecialArea != SpecialArea.GreaterRift))
			return;
		if (Assistant.Game.RiftPercentage < DisplayLimit)
			return;
		if (Assistant.Game.RiftPercentage >= 100)
			return;

		var text = Assistant.Game.RiftPercentage.ToString("F1", CultureInfo.InvariantCulture) + "%";
		var title = "Rift Completion";

		var w = Assistant.Window.Size.Height * 0.1f;
		var h = Assistant.Window.Size.Height * 0.04f;

		LabelDecorator.Paint((Assistant.Window.Size.Width * 0.5f) - (w / 2), (Assistant.Window.Size.Height * 0.18f) - (h / 2), w, h, text, title);
	}
}
