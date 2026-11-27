using System.Globalization;

namespace Plugins.Default;

public class StashUsedSpace : BasePlugin, IInGameTopPainter
{
	public IFont Font { get; set; }

	public StashUsedSpace()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Font = Assistant.Render.CreateFont("Arial", 7, 160, 255, 30, 30, true, false, 128, 0, 0, 0, true);
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.Inventory)
			return;

		var uiStash = Assistant.Inventory.StashMainUiElement;
		if (!uiStash.Visible)
			return;

		var selectedPage = Assistant.Inventory.SelectedStashPageIndex;
		var selectedTab = Assistant.Inventory.SelectedStashTabIndex;

		for (var tabIndex = 0; tabIndex < Assistant.Inventory.MaxStashTabCountPerPage; tabIndex++) {
			var tabUiElement = Assistant.Inventory.GetStashTabUiElement(tabIndex);
			if (!tabUiElement.Visible)
				continue;

			var usedSpace = Assistant.Inventory.GetStashTabUsedSpace(selectedPage, tabIndex);
			var text = usedSpace.ToString("D", CultureInfo.InvariantCulture);

			var layout = Font.GetTextLayout(text);

			var x = tabUiElement.Rectangle.Left + (((tabUiElement.Rectangle.Width * 0.94f) - layout.Metrics.Width) / 2);
			if (tabIndex != selectedTab)
				x -= tabUiElement.Rectangle.Width * 0.170f;

			Font.DrawText(layout, x, tabUiElement.Rectangle.Top + (tabUiElement.Rectangle.Height * 0.1f));
		}
	}
}
