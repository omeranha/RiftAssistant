using System;

namespace Plugins.Default;

public class GameInfo : BasePlugin, IInGameTopPainter
{
	public TopLabelDecorator GameClockDecorator { get; set; }
	public TopLabelDecorator ServerIpAddressDecorator { get; set; }

	public GameInfo()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		GameClockDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 235, 170, false, false, true),
			TextFunc = () => new TimeSpan(Convert.ToInt64(Assistant.Game.CurrentGameTick / 60.0f * 10000000)).ToString(@"hh\:mm\:ss"),
		};

		ServerIpAddressDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 170, 150, 120, false, false, true),
			TextFunc = () => Assistant.Game.ServerIpAddress,
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

		var uiRect = Assistant.Render.GetUiElement("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper.BoostsDifficultyStackPanel.clock").Rectangle;

		GameClockDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 1.15f), uiRect.Width, uiRect.Height * 0.7f, HorizontalAlign.Right);

		if (Assistant.Game.IsInTown) {
			ServerIpAddressDecorator.Paint(uiRect.Left, uiRect.Top + (uiRect.Height * 1.85f), uiRect.Width, uiRect.Height * 0.7f, HorizontalAlign.Right);
		}
	}
}
