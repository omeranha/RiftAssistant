using System.Drawing;


internal static class ItemUIExtensions
{
	public static RectangleF GetUIRectangle(this Item item)
	{
		return item.Location switch
		{
			ItemLocation.Inventory => item.GetInventoryRectangle(), 
			ItemLocation.Head => CoreCollector.UiElements.InventoryButtonHead.rectangle, 
			ItemLocation.Torso => CoreCollector.UiElements.InventoryButtonTorso.rectangle, 
			ItemLocation.RightHand => CoreCollector.UiElements.InventoryButtonArmRight.rectangle, 
			ItemLocation.LeftHand => CoreCollector.UiElements.InventoryButtonArmLeft.rectangle, 
			ItemLocation.Hands => CoreCollector.UiElements.InventoryButtonHands.rectangle, 
			ItemLocation.Waist => CoreCollector.UiElements.InventoryButtonWaist.rectangle, 
			ItemLocation.Feet => CoreCollector.UiElements.InventoryButtonFeet.rectangle, 
			ItemLocation.Shoulders => CoreCollector.UiElements.InventoryButtonShoulders.rectangle, 
			ItemLocation.Legs => CoreCollector.UiElements.InventoryButtonLegs.rectangle, 
			ItemLocation.Bracers => CoreCollector.UiElements.InventoryButtonBracers.rectangle, 
			ItemLocation.LeftRing => CoreCollector.UiElements.InventoryButtonFingerRight.rectangle, 
			ItemLocation.RightRing => CoreCollector.UiElements.InventoryButtonFingerLeft.rectangle, 
			ItemLocation.Neck => CoreCollector.UiElements.InventoryButtonNeck.rectangle, 
			ItemLocation.Stash => item.GetStashRectangle(), 
			ItemLocation.PetRightHand => CoreCollector.UiElements.HirelingSlotOffhand.rectangle, 
			ItemLocation.PetLeftHand => CoreCollector.UiElements.HirelingSlotMainhand.rectangle, 
			ItemLocation.PetSpecial => CoreCollector.UiElements.HirelingSlotSpecial.rectangle, 
			ItemLocation.PetNeck => CoreCollector.UiElements.HirelingSlotNeck.rectangle, 
			ItemLocation.PetRightRing => CoreCollector.UiElements.HirelingSlotRightFinger.rectangle, 
			ItemLocation.PetLeftRing => CoreCollector.UiElements.HirelingSlotLeftFinger.rectangle, 
			ItemLocation.PetHead => CoreCollector.UiElements.HirelingSlotHead.rectangle, 
			ItemLocation.PetTorso => CoreCollector.UiElements.HirelingSlotTorso.rectangle, 
			ItemLocation.PetHands => CoreCollector.UiElements.HirelingSlotHands.rectangle, 
			ItemLocation.PetWaist => CoreCollector.UiElements.HirelingSlotWaist.rectangle, 
			ItemLocation.PetFeet => CoreCollector.UiElements.HirelingSlotFeet.rectangle, 
			ItemLocation.PetShoulders => CoreCollector.UiElements.HirelingSlotShoulders.rectangle, 
			ItemLocation.PetLegs => CoreCollector.UiElements.HirelingSlotLegs.rectangle, 
			ItemLocation.PetBracers => CoreCollector.UiElements.HirelingSlotBracers.rectangle, 
			_ => RectangleF.Empty, 
		};
	}

	public static RectangleF GetInventoryRectangle(this Item item)
	{
		return CalculateInventorySlotRect(item.InventoryX, item.InventoryY, item.SnoItem.ItemWidth, item.SnoItem.ItemHeight);
	}

	public static RectangleF GetStashRectangle(this Item item)
	{
		return CalculateStashSlotRect(item.InventoryX, item.InventoryY, item.SnoItem.ItemWidth, item.SnoItem.ItemHeight);
	}

	public static RectangleF CalculateInventorySlotRect(int x, int y, int width, int height)
	{
		RectangleF baseRect = CoreCollector.UiElements.InventoryItemsUiElement.rectangle;
		float cellWidth = baseRect.Width / 10f;
		float cellHeight = baseRect.Height / 6f;
		return new RectangleF(baseRect.Left + (x * cellWidth), baseRect.Top + (y * cellHeight), cellWidth * width, cellHeight * height);
	}

	public static RectangleF CalculateStashSlotRect(int x, int y, int width, int height)
	{
		RectangleF baseRect = CoreCollector.UiElements.ButtonStash.rectangle;
		float cellWidth = baseRect.Width / 7f;
		float cellHeight = baseRect.Height / 10f;
		return new RectangleF(baseRect.Left + (x * cellWidth), baseRect.Top + ((y % 10) * cellHeight), cellWidth * width, cellHeight * height);
	}
}
