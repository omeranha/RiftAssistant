using System;
using Plugins;

internal class ItemLocationChanged : EventArgs
{
	public Item Item;

	public ItemLocation From;

	public ItemLocation To;
}
