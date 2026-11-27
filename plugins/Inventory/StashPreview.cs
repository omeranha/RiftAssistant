namespace Plugins.Default;

public class StashPreview : BasePlugin, IInGameTopPainter
{
	public IItemRenderer ItemRenderer { get; set; }

	public StashPreview()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);
		ItemRenderer = new StandardItemRenderer(Assistant);
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (Assistant.Render.UiHidden)
			return;
		if (clipState != ClipState.Inventory)
			return;

		var uiElement = Assistant.Inventory.StashMainUiElement;
		if (!uiElement.Visible)
			return;

		var selectedPage = Assistant.Inventory.SelectedStashPageIndex;
		var hoveredTab = Assistant.Inventory.HoveredStashTabIndex;
		if (hoveredTab == -1)
			return;

		hoveredTab += selectedPage * Assistant.Inventory.MaxStashTabCountPerPage;

		var offsetX = uiElement.Rectangle.Left + (uiElement.Rectangle.Width * 0.95f);
		var offsetY = 0.0f;

		var slotTexture = Assistant.Texture.InventorySlotTexture;
		for (var row = 0; row < 10; row++) {
			for (var col = 0; col < 7; col++) {
				var rect = Assistant.Inventory.GetRectInStash(col, row, 1, 1);
				slotTexture.Draw(rect.X + offsetX, rect.Y + offsetY, rect.Width, rect.Height);
			}
		}

		foreach (var item in Assistant.Inventory.ItemsInStash) {
			var tabIndex = item.InventoryY / 10;
			if (tabIndex != hoveredTab)
				continue;

			var rect = Assistant.Inventory.GetItemRect(item);
			rect.Offset(offsetX, offsetY);

			ItemRenderer.RenderItem(item, rect);
		}
	}
}
