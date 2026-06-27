using System.Collections.Generic;
using System.Drawing;
using Plugins;
using SNO;
using work;

public class InventoryController
{
	public int MaxStashPageCount => CoreCollector.UiElements.class341_8.Length;

	public int MaxStashTabCountPerPage => CoreCollector.UiElements.class341_7.Length;

	public int SelectedStashPageIndex => CoreCollector.UiElements.GetSelectedStashPage();

	public int SelectedStashTabIndex => CoreCollector.UiElements.GetActiveStashTab();

	public int HoveredStashTabIndex => CoreCollector.UiElements.GetInactiveStashTab();

	public Item[] ItemsInStash => [.. CoreCollector.ItemCollector.list_0];

	public Item[] ItemsInInventory => [.. CoreCollector.ItemCollector.list_2];

	public UiElement StashMainUiElement => CoreCollector.UiElements.class341_9;

	public UiElement InventoryMainUiElement => CoreCollector.UiElements.class341_11;

	public UiElement InventoryItemsUiElement => CoreCollector.UiElements.class341_13;

	public UiElement FollowerMainUiElement => CoreCollector.UiElements.class341_15;

	public Item HoveredItem
	{
		get
		{
			if (!CoreCollector.UiElements.class341_68.Visible)
			{
				return null;
			}
			return CoreCollector.ItemCollector.class112_0[CoreCollector.UiElements.class341_162.AcdId];
		}
	}

	public int GetStashTabUsedSpace(int pageIndex, int tabIndex)
	{
		return CoreCollector.ItemCollector.int_1[tabIndex + pageIndex * MaxStashTabCountPerPage];
	}

	public UiElement GetStashPageUiElement(int index)
	{
		return CoreCollector.UiElements.class341_8[index];
	}

	public UiElement GetStashTabUiElement(int index)
	{
		return CoreCollector.UiElements.class341_7[index];
	}

	public UiElement GetEquippedItemUiElement(ItemLocation location)
	{
		return location switch
		{
			ItemLocation.Head => CoreCollector.UiElements.class341_19, 
			ItemLocation.Torso => CoreCollector.UiElements.class341_24, 
			ItemLocation.RightHand => CoreCollector.UiElements.class341_31, 
			ItemLocation.LeftHand => CoreCollector.UiElements.class341_30, 
			ItemLocation.Hands => CoreCollector.UiElements.class341_22, 
			ItemLocation.Waist => CoreCollector.UiElements.class341_25, 
			ItemLocation.Feet => CoreCollector.UiElements.class341_27, 
			ItemLocation.Shoulders => CoreCollector.UiElements.class341_20, 
			ItemLocation.Legs => CoreCollector.UiElements.class341_26, 
			ItemLocation.Bracers => CoreCollector.UiElements.class341_23, 
			ItemLocation.LeftRing => CoreCollector.UiElements.class341_29, 
			ItemLocation.RightRing => CoreCollector.UiElements.class341_28, 
			ItemLocation.Neck => CoreCollector.UiElements.class341_21, 
			ItemLocation.PetRightHand => CoreCollector.UiElements.class341_44, 
			ItemLocation.PetLeftHand => CoreCollector.UiElements.class341_43, 
			ItemLocation.PetSpecial => CoreCollector.UiElements.class341_45, 
			ItemLocation.PetNeck => CoreCollector.UiElements.class341_34, 
			ItemLocation.PetRightRing => CoreCollector.UiElements.class341_41, 
			ItemLocation.PetLeftRing => CoreCollector.UiElements.class341_42, 
			ItemLocation.PetHead => CoreCollector.UiElements.class341_32, 
			ItemLocation.PetTorso => CoreCollector.UiElements.class341_37, 
			ItemLocation.PetHands => CoreCollector.UiElements.class341_35, 
			ItemLocation.PetWaist => CoreCollector.UiElements.class341_38, 
			ItemLocation.PetFeet => CoreCollector.UiElements.class341_40, 
			ItemLocation.PetShoulders => CoreCollector.UiElements.class341_33, 
			ItemLocation.PetLegs => CoreCollector.UiElements.class341_39, 
			ItemLocation.PetBracers => CoreCollector.UiElements.class341_36, 
			_ => null, 
		};
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
		return CoreCollector.UiElements.class341_68;
	}

	public UiElement GetHoveredItemTopUiElement()
	{
		return CoreCollector.UiElements.class341_69;
	}
}
