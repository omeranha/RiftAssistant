using System.Collections.Generic;
using System.Drawing;

namespace Plugins;

public interface IInventoryController
{
	int MaxStashPageCount { get; }

	int MaxStashTabCountPerPage { get; }

	int SelectedStashPageIndex { get; }

	int SelectedStashTabIndex { get; }

	int HoveredStashTabIndex { get; }

	IEnumerable<IItem> ItemsInStash { get; }

	IEnumerable<IItem> ItemsInInventory { get; }

	IUiElement StashMainUiElement { get; }

	IUiElement InventoryMainUiElement { get; }

	IUiElement InventoryItemsUiElement { get; }

	IUiElement FollowerMainUiElement { get; }

	IItem HoveredItem { get; }

	int GetStashTabUsedSpace(int pageIndex, int tabIndex);

	IUiElement GetStashPageUiElement(int index);

	IUiElement GetStashTabUiElement(int index);

	IUiElement GetEquippedItemUiElement(ItemLocation location);

	RectangleF GetItemRect(IItem item);

	RectangleF GetRectInStash(int x, int y, int width, int height);

	RectangleF GetRectInInventory(int x, int y, int width, int height);

	ISnoItem GetSnoItem(uint sno);

	IUiElement GetHoveredItemMainUiElement();

	IUiElement GetHoveredItemTopUiElement();
}
