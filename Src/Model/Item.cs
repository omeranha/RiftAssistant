using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace RiftAssistant.Model;

public class Item : Actor
{

	public bool bool_10;

	public bool bool_12;

	public readonly Dictionary<string, ItemStat> StatList2 = new Dictionary<string, ItemStat>();

	public SnoItem SnoItem { get; }

	public string FullNameLocalized
	{
		get
		{
			if (AncientRank != 2)
			{
				if (AncientRank != 1)
				{
					return SnoItem.NameLocalized;
				}
				return SnoData.Strings.GetStringByCode(StringListSnoEnum._itemquality, (SnoItem.SetItemBonusesSno == uint.MaxValue) ? "AncientLegendary" : "AncientSet") + " " + SnoItem.NameLocalized;
			}
			return SnoData.Strings.GetStringByCode(StringListSnoEnum._itemquality, (SnoItem.SetItemBonusesSno == uint.MaxValue) ? "PrimalAncientLegendary" : "PrimalAncientSet") + " " + SnoItem.NameLocalized;
		}
	}

	public string FullNameEnglish
	{
		get
		{
			if (AncientRank != 2)
			{
				if (AncientRank != 1)
				{
					return SnoItem.NameEnglish;
				}
				return SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._itemquality, (SnoItem.SetItemBonusesSno == uint.MaxValue) ? "AncientLegendary" : "AncientSet") + " " + SnoItem.NameEnglish;
			}
			return SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._itemquality, (SnoItem.SetItemBonusesSno == uint.MaxValue) ? "PrimalAncientLegendary" : "PrimalAncientSet") + " " + SnoItem.NameLocalized;
		}
	}

	public ItemQuality Quality { get; set; }

	public int Seed { get; set; }

	public ItemLocation Location { get; set; }

	public bool SeenInInventory { get; set; }

	public uint SocketHostAcdId { get; set; }

	public Item SocketedInto => CoreCollector.ItemCollector.Items.TryGetValue(SocketHostAcdId, out var value) ? value : null;

	public int InventoryX { get; set; }

	public int InventoryY { get; set; }

	public bool Unidentified { get; set; }

	public SnoItemAffix[] Affixes { get; set; }

	public Item[] ItemsInSocket { get; set; }

	public bool Boolean_1 { get; set; }

	public string ItemUniqueId { get; set; }

	public string RareName { get; set; }

	public IEnumerable<ItemStat> StatList => StatList2.Values;

	public ItemKeepDecision KeepDecision { get; internal set; }

	public Stopwatch LastSpeak { get; set; }

	public bool IsInventoryLocked => Core.Controller.Inventory.IsLocked(this);

	public uint EnchantedAffixOriginal { get; set; }

	public uint EnchantedAffixNew { get; set; }

	public int EnchantedAffixCounter { get; set; }

	public long Quantity { get; set; } = 1L;

	public bool IsNormal
	{
		get
		{
			if (SnoItem.Kind == ItemKind.craft)
			{
				if ((int)SnoItem.CraftQuality >= 0 && (int)SnoItem.CraftQuality <= 2)
				{
					return true;
				}
				return SnoItem.CraftQuality == ItemCraftQuality.None;
			}
			if ((int)Quality >= 0)
			{
				return (int)Quality <= 2;
			}
			return false;
		}
	}

	public bool IsMagic
	{
		get
		{
			if (SnoItem.Kind == ItemKind.craft)
			{
				if ((int)SnoItem.CraftQuality >= 3)
				{
					return (int)SnoItem.CraftQuality <= 5;
				}
				return false;
			}
			if ((int)Quality >= 3)
			{
				return (int)Quality <= 5;
			}
			return false;
		}
	}

	public bool IsRare
	{
		get
		{
			if (SnoItem.Kind == ItemKind.craft)
			{
				if ((int)SnoItem.CraftQuality >= 6)
				{
					return (int)SnoItem.CraftQuality <= 8;
				}
				return false;
			}
			if ((int)Quality >= 6)
			{
				return (int)Quality <= 8;
			}
			return false;
		}
	}

	public bool IsLegendary
	{
		get
		{
			if (SnoItem.Kind == ItemKind.craft)
			{
				return SnoItem.CraftQuality == ItemCraftQuality.Legendary;
			}
			return Quality == ItemQuality.Legendary;
		}
	}

	public uint SetSno
	{
		get
		{
			if (Quality != ItemQuality.Legendary)
			{
				return uint.MaxValue;
			}
			return SnoItem.SetItemBonusesSno;
		}
	}

	public int CaldesannRank => GetStatInt("cube_enchanted_gem_rank");

	public int AncientRank => GetStatInt("ancient_rank");

	public bool AccountBound => GetStatInt("bound_to_account") == 1;

	public bool BoundToMyAccount
	{
		get
		{
			if (GetStatInt("bound_to_account") == 1)
			{
				return GetStatUInt("bound_to_acdid") == CoreCollector.LocalPlayer.SummonerId;
			}
			return false;
		}
	}

	public bool VendorBought => GetStatInt("vendor_bought") == 1;

	public int JewelRank => GetStatInt("jewel_rank", -1);

	public int SocketCount => GetStatInt("sock");

	public Item(uint acdId2, uint annId2, SnoItem snoItem)
		: base(acdId2, annId2, snoItem.SnoActor)
	{
		SnoItem = snoItem;
	}

	public SnoSocketedEffect GetSocketedEffect()
	{
		if (SnoItem.SocketedEffects == null)
		{
			return null;
		}
		SnoSocketedEffect snoSocketedEffect = null;
		SnoSocketedEffect snoSocketedEffect2 = null;
		foreach (SnoSocketedEffect socketedEffect in SnoItem.SocketedEffects)
		{
			if (socketedEffect.SnoItemType == null)
			{
				snoSocketedEffect2 = socketedEffect;
			}
			else if (SocketedInto.SnoItem.SnoItemType == socketedEffect.SnoItemType)
			{
				snoSocketedEffect = socketedEffect;
			}
		}
		if (snoSocketedEffect == null)
		{
			snoSocketedEffect = snoSocketedEffect2;
		}
		return snoSocketedEffect;
	}

	public void method_45()
	{
		if (Location == ItemLocation.Floor || Location == ItemLocation.Merchant || Location == ItemLocation.MerchantAvaibleItemsForPurchase || Location == ItemLocation.MerchantBuyback)
		{
			return;
		}
		string[] obj = new string[7]
		{
			Location.ToString(),
			SnoItem.Sno.ToString("D", CultureInfo.InvariantCulture),
			InventoryX.ToString("D", CultureInfo.InvariantCulture),
			InventoryY.ToString("D", CultureInfo.InvariantCulture),
			Seed.ToString("D", CultureInfo.InvariantCulture),
			(Unidentified ? 1 : 0).ToString("D", CultureInfo.InvariantCulture),
			null
		};
		SnoItemAffix[] affixes = Affixes;
		obj[6] = ((affixes != null) ? affixes.Length : 0).ToString("D", CultureInfo.InvariantCulture);
		ItemUniqueId = string.Concat(obj);
		if (ItemsInSocket != null)
		{
			for (int i = 0; i < ItemsInSocket.Length; i++)
			{
				ItemUniqueId = ItemUniqueId + "sock" + ItemsInSocket[i].AcdId.ToString("D", CultureInfo.InvariantCulture);
			}
		}
		bool_12 = true;
	}

	public int CountsIntoSet(uint setId)
	{
		return StatList2.GetValueOrDefault("Set_Item_Count#" + setId.ToString("D", CultureInfo.InvariantCulture))?.IntegerValue.Value ?? 0;
	}

	public void AddStat(ItemStat itemStat)
	{
		StatList2[itemStat.Id] = itemStat;
	}

	public int GetStatInt(string string_2, int int_5 = 0)
	{
		ItemStat itemStat = StatList2.GetValueOrDefault(string_2);
		if (itemStat == null)
		{
			return int_5;
		}
		return (itemStat as ItemStat).IntegerValue.GetValueOrDefault();
	}

	public uint GetStatUInt(string string_2, uint uint_10 = 0u)
	{
		ItemStat itemStat = StatList2.GetValueOrDefault(string_2);
		if (itemStat == null)
		{
			return uint_10;
		}
		return (uint)(itemStat as ItemStat).IntegerValue.GetValueOrDefault();
	}
}
