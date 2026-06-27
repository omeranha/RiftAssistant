using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;
using work;

public class Item : Actor
{
	[CompilerGenerated]
	private readonly SnoItem isnoItem_0;

	[CompilerGenerated]
	private ItemQuality itemQuality_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private ItemLocation itemLocation_0;

	[CompilerGenerated]
	private bool bool_8;

	[CompilerGenerated]
	private uint uint_7;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private bool bool_9;

	public bool bool_10;

	[CompilerGenerated]
	private SnoItemAffix[] isnoItemAffix_0;

	[CompilerGenerated]
	private Item[] iitem_0;

	[CompilerGenerated]
	private double double_3;

	[CompilerGenerated]
	private bool bool_11;

	[CompilerGenerated]
	private string string_0;

	public bool bool_12;

	[CompilerGenerated]
	private string string_1;

	public readonly Class112<string, ItemStat> class112_0 = new Class112<string, ItemStat>();

	[CompilerGenerated]
	private uint uint_8;

	[CompilerGenerated]
	private uint uint_9;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private long long_0 = 1L;

	public SnoItem SnoItem
	{
		[CompilerGenerated]
		get
		{
			return isnoItem_0;
		}
	}

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

	public ItemQuality Quality
	{
		[CompilerGenerated]
		get
		{
			return itemQuality_0;
		}
		[CompilerGenerated]
		set
		{
			itemQuality_0 = value;
		}
	}

	public int Seed
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public ItemLocation Location
	{
		[CompilerGenerated]
		get
		{
			return itemLocation_0;
		}
		[CompilerGenerated]
		set
		{
			itemLocation_0 = value;
		}
	}

	public bool SeenInInventory
	{
		[CompilerGenerated]
		get
		{
			return bool_8;
		}
		[CompilerGenerated]
		set
		{
			bool_8 = value;
		}
	}

	public uint UInt32_0
	{
		[CompilerGenerated]
		get
		{
			return uint_7;
		}
		[CompilerGenerated]
		set
		{
			uint_7 = value;
		}
	}

	public Item SocketedInto => CoreCollector.ItemCollector.class112_0[UInt32_0];

	public int InventoryX
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int InventoryY
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public bool Unidentified
	{
		[CompilerGenerated]
		get
		{
			return bool_9;
		}
		[CompilerGenerated]
		set
		{
			bool_9 = value;
		}
	}

	public SnoItemAffix[] Affixes
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffix_0;
		}
		[CompilerGenerated]
		set
		{
			isnoItemAffix_0 = value;
		}
	}

	public Item[] ItemsInSocket
	{
		[CompilerGenerated]
		get
		{
			return iitem_0;
		}
		[CompilerGenerated]
		set
		{
			iitem_0 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_11;
		}
		[CompilerGenerated]
		set
		{
			bool_11 = value;
		}
	}

	public string ItemUniqueId
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string RareName
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public IEnumerable<ItemStat> StatList => class112_0.IEnumerable_0;

	public uint EnchantedAffixOriginal
	{
		[CompilerGenerated]
		get
		{
			return uint_8;
		}
		[CompilerGenerated]
		set
		{
			uint_8 = value;
		}
	}

	public uint EnchantedAffixNew
	{
		[CompilerGenerated]
		get
		{
			return uint_9;
		}
		[CompilerGenerated]
		set
		{
			uint_9 = value;
		}
	}

	public int EnchantedAffixCounter
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	public long Quantity
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

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

	public int CaldesannRank => method_47("cube_enchanted_gem_rank");

	public int AncientRank => method_47("ancient_rank");

	public bool AccountBound => method_47("bound_to_account") == 1;

	public bool BoundToMyAccount
	{
		get
		{
			if (method_47("bound_to_account") == 1)
			{
				return method_48("bound_to_acdid") == CoreCollector.LocalPlayer.SummonerId;
			}
			return false;
		}
	}

	public bool VendorBought => method_47("vendor_bought") == 1;

	public int JewelRank => method_47("jewel_rank", -1);

	public int SocketCount => method_47("sock");

	public Item(uint uint_10, uint uint_11, SnoItem isnoItem_1)
		: base(uint_10, uint_11, isnoItem_1.SnoActor)
	{
		isnoItem_0 = isnoItem_1;
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
		return class112_0["Set_Item_Count#" + setId.ToString("D", CultureInfo.InvariantCulture)]?.IntegerValue.Value ?? 0;
	}

	public void method_46(ItemStat iitemStat_0)
	{
		class112_0.Set(iitemStat_0.Id, iitemStat_0);
	}

	public int method_47(string string_2, int int_5 = 0)
	{
		ItemStat itemStat = class112_0[string_2];
		if (itemStat == null)
		{
			return int_5;
		}
		return (itemStat as ItemStat).IntegerValue.GetValueOrDefault();
	}

	public uint method_48(string string_2, uint uint_10 = 0u)
	{
		ItemStat itemStat = class112_0[string_2];
		if (itemStat == null)
		{
			return uint_10;
		}
		return (uint)(itemStat as ItemStat).IntegerValue.GetValueOrDefault();
	}
}
