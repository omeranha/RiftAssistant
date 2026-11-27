namespace Plugins.Default;

public class InventoryKanaiCubedItems : BasePlugin, IInGameTopPainter
{
	public InventoryKanaiCubedItems()
	{
		Enabled = true;
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.Inventory || !Assistant.Inventory.InventoryMainUiElement.Visible)
			return;

		if (Assistant.Game.LocalPlayer.CubeSnoItem1 != null)
			DrawKanaiItem(Assistant.Game.LocalPlayer.CubeSnoItem1, 0);

		if (Assistant.Game.LocalPlayer.CubeSnoItem2 != null)
			DrawKanaiItem(Assistant.Game.LocalPlayer.CubeSnoItem2, 1);

		if (Assistant.Game.LocalPlayer.CubeSnoItem3 != null)
			DrawKanaiItem(Assistant.Game.LocalPlayer.CubeSnoItem3, 2);

		if (Assistant.Game.LocalPlayer.CubeSnoItem4 != null)
			DrawKanaiItem(Assistant.Game.LocalPlayer.CubeSnoItem4, 3);
	}

	private void DrawKanaiItem(SnoItem snoItem, int index)
	{
		var inventoryRect = Assistant.Inventory.InventoryMainUiElement.Rectangle;

		var itemRect = Assistant.Inventory.GetRectInInventory(0, 0, snoItem.ItemWidth, snoItem.ItemHeight);
		itemRect.Offset((index * inventoryRect.Width * 0.095f) + (inventoryRect.Width * 0.023f), -inventoryRect.Height * 0.502f);
		if (snoItem.ItemHeight == 1)
			itemRect.Offset(0, itemRect.Height * 0.5f);

		var slotTexture = Assistant.Texture.InventorySlotTexture;
		slotTexture.Draw(itemRect.X, itemRect.Y, itemRect.Width, itemRect.Height);

		if (Assistant.Window.CursorInsideRect(itemRect.X, itemRect.Y, itemRect.Width, itemRect.Height)) {
			var description = snoItem.NameLocalized;

			var power = snoItem.LegendaryPower;
			if (power != null) {
				description += "\n\n" + power.DescriptionLocalized;
			}

			Assistant.Render.SetHint(description);
		}

		var backgroundTexture = snoItem.ItemHeight == 2 ? Assistant.Texture.InventoryLegendaryBackgroundLarge : Assistant.Texture.InventoryLegendaryBackgroundSmall;
		backgroundTexture.Draw(itemRect.X, itemRect.Y, itemRect.Width, itemRect.Height);

		var itemTexture = Assistant.Texture.GetItemTexture(snoItem);
		itemTexture?.Draw(itemRect.X, itemRect.Y, itemRect.Width, itemRect.Height);
	}
}
