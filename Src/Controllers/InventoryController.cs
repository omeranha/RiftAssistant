using System.Drawing;

namespace RiftAssistant.Controllers;

public class InventoryController
{
	public Rectangle InventoryLockArea {
		get {
			var lockArea = Core.Settings.InventoryLock;
			if (lockArea.LeftColumn < 0 || lockArea.TopRow < 0 || lockArea.RightColumn < lockArea.LeftColumn || lockArea.BottomRow < lockArea.TopRow) return Rectangle.Empty;

			return new Rectangle(lockArea.LeftColumn, lockArea.TopRow, lockArea.RightColumn - lockArea.LeftColumn + 1, lockArea.BottomRow - lockArea.TopRow + 1);
		}
	}

	public int MaxStashPageCount => CoreCollector.UiElements.StashPages.Length;

	public int MaxStashTabCountPerPage => CoreCollector.UiElements.StashTabs.Length;

	public int SelectedStashPageIndex => CoreCollector.UiElements.GetSelectedStashPage();

	public int SelectedStashTabIndex => CoreCollector.UiElements.GetActiveStashTab();

	public int HoveredStashTabIndex => CoreCollector.UiElements.GetInactiveStashTab();

	public Item[] ItemsInStash => [.. CoreCollector.ItemCollector.ItemsInStash];

	public Item[] ItemsInInventory => [.. CoreCollector.ItemCollector.ItemsInInventory];

	public UiElement StashMainUiElement => CoreCollector.UiElements.StashMainUiElement;

	public UiElement InventoryMainUiElement => CoreCollector.UiElements.InventoryMainUiElement;

	public UiElement InventoryItemsUiElement => CoreCollector.UiElements.InventoryItemsUiElement;

	public UiElement FollowerMainUiElement => CoreCollector.UiElements.FollowerMainUiElement;

	public Item HoveredItem
	{
		get
		{
			if (!CoreCollector.UiElements.Item2Stack.Visible)
			{
				return null;
			}
			return CoreCollector.ItemCollector.Items.TryGetValue(CoreCollector.UiElements.Tooltip2.AcdId, out var value) ? value : null;
		}
	}

	public int GetStashTabUsedSpace(int pageIndex, int tabIndex)
	{
		return CoreCollector.ItemCollector.int_1[tabIndex + pageIndex * MaxStashTabCountPerPage];
	}

	public UiElement GetStashPageUiElement(int index)
	{
		return CoreCollector.UiElements.StashPages[index];
	}

	public UiElement GetStashTabUiElement(int index)
	{
		return CoreCollector.UiElements.StashTabs[index];
	}

	public UiElement GetEquippedItemUiElement(ItemLocation location)
	{
		return location switch
		{
			ItemLocation.Head => CoreCollector.UiElements.InventoryButtonHead, 
			ItemLocation.Torso => CoreCollector.UiElements.InventoryButtonTorso, 
			ItemLocation.RightHand => CoreCollector.UiElements.InventoryButtonArmRight, 
			ItemLocation.LeftHand => CoreCollector.UiElements.InventoryButtonArmLeft, 
			ItemLocation.Hands => CoreCollector.UiElements.InventoryButtonHands, 
			ItemLocation.Waist => CoreCollector.UiElements.InventoryButtonWaist, 
			ItemLocation.Feet => CoreCollector.UiElements.InventoryButtonFeet, 
			ItemLocation.Shoulders => CoreCollector.UiElements.InventoryButtonShoulders, 
			ItemLocation.Legs => CoreCollector.UiElements.InventoryButtonLegs, 
			ItemLocation.Bracers => CoreCollector.UiElements.InventoryButtonBracers, 
			ItemLocation.LeftRing => CoreCollector.UiElements.InventoryButtonFingerRight, 
			ItemLocation.RightRing => CoreCollector.UiElements.InventoryButtonFingerLeft, 
			ItemLocation.Neck => CoreCollector.UiElements.InventoryButtonNeck, 
			ItemLocation.PetRightHand => CoreCollector.UiElements.HirelingSlotOffhand, 
			ItemLocation.PetLeftHand => CoreCollector.UiElements.HirelingSlotMainhand, 
			ItemLocation.PetSpecial => CoreCollector.UiElements.HirelingSlotSpecial, 
			ItemLocation.PetNeck => CoreCollector.UiElements.HirelingSlotNeck, 
			ItemLocation.PetRightRing => CoreCollector.UiElements.HirelingSlotRightFinger, 
			ItemLocation.PetLeftRing => CoreCollector.UiElements.HirelingSlotLeftFinger, 
			ItemLocation.PetHead => CoreCollector.UiElements.HirelingSlotHead, 
			ItemLocation.PetTorso => CoreCollector.UiElements.HirelingSlotTorso, 
			ItemLocation.PetHands => CoreCollector.UiElements.HirelingSlotHands, 
			ItemLocation.PetWaist => CoreCollector.UiElements.HirelingSlotWaist, 
			ItemLocation.PetFeet => CoreCollector.UiElements.HirelingSlotFeet, 
			ItemLocation.PetShoulders => CoreCollector.UiElements.HirelingSlotShoulders, 
			ItemLocation.PetLegs => CoreCollector.UiElements.HirelingSlotLegs, 
			ItemLocation.PetBracers => CoreCollector.UiElements.HirelingSlotBracers, 
			_ => null, 
		};
	}

	internal bool IsLocked(Item item)
	{
		var lockArea = InventoryLockArea;
		if (item.Location != ItemLocation.Inventory || lockArea.IsEmpty) return false;

		var itemArea = new Rectangle(item.InventoryX, item.InventoryY, item.SnoItem.ItemWidth, item.SnoItem.ItemHeight);
		return lockArea.IntersectsWith(itemArea);
	}

	public RectangleF GetItemRect(Item item)
	{
		return item.GetUIRectangle();
	}

	public RectangleF GetRectInStash(int x, int y, int width, int height)
	{
		return ItemUIExtensions.CalculateStashSlotRect(x, y, width, height);
	}

	public RectangleF GetRectInInventory(int x, int y, int width, int height)
	{
		return ItemUIExtensions.CalculateInventorySlotRect(x, y, width, height);
	}

	public SnoItem GetSnoItem(uint sno)
	{
		return SnoData.Items.GetBySno(sno);
	}

	public UiElement GetHoveredItemMainUiElement()
	{
		return CoreCollector.UiElements.Item2Stack;
	}

	public UiElement GetHoveredItemTopUiElement()
	{
		return CoreCollector.UiElements.TopWrapperStack;
	}
}
