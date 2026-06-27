using System.Drawing;
using Plugins;
using work;

internal static class ItemUIExtensions
{
	public static RectangleF GetUIRectangle(this Item item)
	{
		return item.Location switch
		{
			ItemLocation.Inventory => item.GetInventoryRectangle(), 
			ItemLocation.Head => CoreCollector.UiElements.class341_19.rectangleF_0, 
			ItemLocation.Torso => CoreCollector.UiElements.class341_24.rectangleF_0, 
			ItemLocation.RightHand => CoreCollector.UiElements.class341_31.rectangleF_0, 
			ItemLocation.LeftHand => CoreCollector.UiElements.class341_30.rectangleF_0, 
			ItemLocation.Hands => CoreCollector.UiElements.class341_22.rectangleF_0, 
			ItemLocation.Waist => CoreCollector.UiElements.class341_25.rectangleF_0, 
			ItemLocation.Feet => CoreCollector.UiElements.class341_27.rectangleF_0, 
			ItemLocation.Shoulders => CoreCollector.UiElements.class341_20.rectangleF_0, 
			ItemLocation.Legs => CoreCollector.UiElements.class341_26.rectangleF_0, 
			ItemLocation.Bracers => CoreCollector.UiElements.class341_23.rectangleF_0, 
			ItemLocation.LeftRing => CoreCollector.UiElements.class341_29.rectangleF_0, 
			ItemLocation.RightRing => CoreCollector.UiElements.class341_28.rectangleF_0, 
			ItemLocation.Neck => CoreCollector.UiElements.class341_21.rectangleF_0, 
			ItemLocation.Stash => item.GetStashRectangle(), 
			ItemLocation.PetRightHand => CoreCollector.UiElements.class341_44.rectangleF_0, 
			ItemLocation.PetLeftHand => CoreCollector.UiElements.class341_43.rectangleF_0, 
			ItemLocation.PetSpecial => CoreCollector.UiElements.class341_45.rectangleF_0, 
			ItemLocation.PetNeck => CoreCollector.UiElements.class341_34.rectangleF_0, 
			ItemLocation.PetRightRing => CoreCollector.UiElements.class341_41.rectangleF_0, 
			ItemLocation.PetLeftRing => CoreCollector.UiElements.class341_42.rectangleF_0, 
			ItemLocation.PetHead => CoreCollector.UiElements.class341_32.rectangleF_0, 
			ItemLocation.PetTorso => CoreCollector.UiElements.class341_37.rectangleF_0, 
			ItemLocation.PetHands => CoreCollector.UiElements.class341_35.rectangleF_0, 
			ItemLocation.PetWaist => CoreCollector.UiElements.class341_38.rectangleF_0, 
			ItemLocation.PetFeet => CoreCollector.UiElements.class341_40.rectangleF_0, 
			ItemLocation.PetShoulders => CoreCollector.UiElements.class341_33.rectangleF_0, 
			ItemLocation.PetLegs => CoreCollector.UiElements.class341_39.rectangleF_0, 
			ItemLocation.PetBracers => CoreCollector.UiElements.class341_36.rectangleF_0, 
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
		RectangleF baseRect = CoreCollector.UiElements.class341_13.rectangleF_0;
		float cellWidth = baseRect.Width / 10f;
		float cellHeight = baseRect.Height / 6f;
		return new RectangleF(baseRect.Left + (x * cellWidth), baseRect.Top + (y * cellHeight), cellWidth * width, cellHeight * height);
	}

	public static RectangleF CalculateStashSlotRect(int x, int y, int width, int height)
	{
		RectangleF baseRect = CoreCollector.UiElements.class341_10.rectangleF_0;
		float cellWidth = baseRect.Width / 7f;
		float cellHeight = baseRect.Height / 10f;
		return new RectangleF(baseRect.Left + (x * cellWidth), baseRect.Top + ((y % 10) * cellHeight), cellWidth * width, cellHeight * height);
	}
}
