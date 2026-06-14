using System.Collections.Generic;

namespace Plugins;

public interface IItem : IActor
{
	int AncientRank { get; }

	int CaldesannRank { get; }

	int JewelRank { get; }

	bool AccountBound { get; }

	bool BoundToMyAccount { get; }

	bool VendorBought { get; }

	ISnoItem SnoItem { get; }

	string FullNameLocalized { get; }

	string FullNameEnglish { get; }

	int InventoryX { get; }

	int InventoryY { get; }

	bool IsNormal { get; }

	bool IsMagic { get; }

	bool IsRare { get; }

	bool IsLegendary { get; }

	uint SetSno { get; }

	ItemLocation Location { get; }

	bool SeenInInventory { get; }

	ItemQuality Quality { get; }

	long Quantity { get; }

	string RareName { get; }

	int Seed { get; }

	int SocketCount { get; }

	IItem SocketedInto { get; }

	bool Unidentified { get; }

	ISnoItemAffix[] Affixes { get; }

	IItem[] ItemsInSocket { get; }

	IEnumerable<IItemStat> StatList { get; }

	uint EnchantedAffixOriginal { get; }

	uint EnchantedAffixNew { get; }

	int EnchantedAffixCounter { get; }

	string ItemUniqueId { get; }

	int CountsIntoSet(uint setId);

	ISnoSocketedEffect GetSocketedEffect();
}
