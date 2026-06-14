using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoItem : ISnoItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class4
	{
		public static readonly Class4 class4_0;

		//public static Predicate<ISnoItemMod> predicate_0;

		static Class4()
		{
			class4_0 = new Class4();
		}

		internal bool method_0(ISnoItemMod isnoItemMod_0)
		{
			return isnoItemMod_0.Attribute?.Code == "Item_Power_Passive";
		}
	}

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly ISnoActor isnoActor_0;

	[CompilerGenerated]
	private readonly ItemKind itemKind_0;

	[CompilerGenerated]
	private readonly uint uint_1;

	[CompilerGenerated]
	private readonly uint uint_2;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly int int_2;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string[] string_4;

	[CompilerGenerated]
	private readonly ItemLocation itemLocation_0 = ItemLocation.Floor;

	[CompilerGenerated]
	private readonly ItemLocation itemLocation_1 = ItemLocation.Floor;

	[CompilerGenerated]
	private readonly ISnoItemType isnoItemType_0;

	[CompilerGenerated]
	private readonly int int_3;

	[CompilerGenerated]
	private readonly int int_4;

	[CompilerGenerated]
	private readonly int int_5;

	[CompilerGenerated]
	private readonly int int_6;

	[CompilerGenerated]
	private readonly uint uint_3;

	[CompilerGenerated]
	private readonly uint uint_4;

	[CompilerGenerated]
	private readonly ItemCraftQuality itemCraftQuality_0;

	[CompilerGenerated]
	private ISnoItemMod[] isnoItemMod_0;

	[CompilerGenerated]
	private ISnoItemAffixGroupLink[] isnoItemAffixGroupLink_0;

	[CompilerGenerated]
	private List<ISnoSocketedEffect> list_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private readonly int int_7;

	[CompilerGenerated]
	private readonly int int_8;

	[CompilerGenerated]
	private readonly int int_9;

	[CompilerGenerated]
	private readonly int int_10;

	[CompilerGenerated]
	private readonly int int_11;

	[CompilerGenerated]
	private readonly int int_12;

	[CompilerGenerated]
	private readonly int int_13;

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public ISnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return isnoActor_0;
		}
	}

	public ItemKind Kind
	{ 
		[CompilerGenerated]
		get
		{
			return itemKind_0;
		}
	}

	public uint PrefixStringSno
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
	}

	public uint SuffixStringSno
	{
		[CompilerGenerated]
		get
		{
			return uint_2;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public int ItemWidth
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	public int ItemHeight
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string MainGroupCode
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string[] GroupCodes
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	public ItemLocation UsedLocation1
	{
		[CompilerGenerated]
		get
		{
			return itemLocation_0;
		}
	}

	public ItemLocation UsedLocation2
	{
		[CompilerGenerated]
		get
		{
			return itemLocation_1;
		}
	}

	public ISnoItemType SnoItemType
	{
		[CompilerGenerated]
		get
		{
			return isnoItemType_0;
		}
	}

	public int StackSize
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
	}

	public int GoldPrice
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
	}

	public int UnsocketPrice
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
	}

	public int RequiredLevel
	{
		[CompilerGenerated]
		get
		{
			return int_6;
		}
	}

	public uint BaseItemSno
	{
		[CompilerGenerated]
		get
		{
			return uint_3;
		}
	}

	public uint SetItemBonusesSno
	{
		[CompilerGenerated]
		get
		{
			return uint_4;
		}
	}

	public ItemCraftQuality CraftQuality
	{
		[CompilerGenerated]
		get
		{
			return itemCraftQuality_0;
		}
	}

	public ISnoItemMod[] Mods
	{
		[CompilerGenerated]
		get
		{
			return isnoItemMod_0;
		}
		[CompilerGenerated]
		set
		{
			isnoItemMod_0 = value;
		}
	}

	public ISnoItemAffixGroupLink[] AffixGroups
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroupLink_0;
		}
		[CompilerGenerated]
		set
		{
			isnoItemAffixGroupLink_0 = value;
		}
	}

	public List<ISnoSocketedEffect> SocketedEffects
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public bool CanKanaiCube
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public int DropWeight
	{
		[CompilerGenerated]
		get
		{
			return int_7;
		}
	}

	public int DropSmartDemonHunter
	{
		[CompilerGenerated]
		get
		{
			return int_8;
		}
	}

	public int DropSmartBarbarian
	{
		[CompilerGenerated]
		get
		{
			return int_9;
		}
	}

	public int DropSmartWizard
	{
		[CompilerGenerated]
		get
		{
			return int_10;
		}
	}

	public int DropSmartWitchDoctor
	{
		[CompilerGenerated]
		get
		{
			return int_11;
		}
	}

	public int DropSmartMonk
	{
		[CompilerGenerated]
		get
		{
			return int_12;
		}
	}

	public int DropSmartCrusader
	{
		[CompilerGenerated]
		get
		{
			return int_13;
		}
	}

	public ISnoPower LegendaryPower
	{
		get
		{
			if (Mods != null)
			{
				ISnoItemMod snoItemMod = Array.Find(Mods, (ISnoItemMod isnoItemMod_0) => isnoItemMod_0.Attribute?.Code == "Item_Power_Passive");
				if (snoItemMod != null)
				{
					return SnoData.Powers.GetBySno(snoItemMod.Modifier);
				}
			}
			return null;
		}
	}

	public bool IsEthereal => Code.StartsWith("P71_Ethereal");

	internal SnoItem(uint uint_5, uint uint_6, uint uint_7, ISnoActor isnoActor_1, uint uint_8, uint uint_9, int int_14, ISnoItemType isnoItemType_1, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, string string_5, string string_6, string string_7, string string_8, string[] string_9, ItemLocation itemLocation_2, ItemLocation itemLocation_3, int int_21, int int_22, int int_23, int int_24, int int_25, int int_26, int int_27, ItemCraftQuality itemCraftQuality_1)
	{
		uint_0 = uint_5;
		uint_3 = uint_6;
		uint_4 = uint_7;
		isnoActor_0 = isnoActor_1;
		uint_1 = uint_8;
		uint_2 = uint_9;
		int_0 = int_14;
		int_1 = int_19;
		int_2 = int_20;
		string_0 = string_5;
		string_1 = string_6;
		string_2 = string_7;
		string_3 = string_8;
		string_4 = string_9;
		isnoItemType_0 = isnoItemType_1;
		int_3 = int_15;
		int_4 = int_16;
		int_5 = int_17;
		int_6 = int_18;
		itemLocation_0 = itemLocation_2;
		itemLocation_1 = itemLocation_3;
		int_7 = int_21;
		int_8 = int_22;
		int_9 = int_23;
		int_10 = int_24;
		int_11 = int_25;
		int_12 = int_26;
		int_13 = int_27;
		itemCraftQuality_0 = itemCraftQuality_1;
		itemKind_0 = ItemKind.loot;
		switch (Sno)
		{
		case 126259831u:
			itemKind_0 = ItemKind.goldcoin;
			break;
		case 2603730171u:
			itemKind_0 = ItemKind.loot;
			break;
		default:
			if (MainGroupCode != null)
			{
				if (MainGroupCode == "potion")
				{
					itemKind_0 = ItemKind.potion;
				}
				if (MainGroupCode == "uber")
				{
					itemKind_0 = ItemKind.uberstuff;
				}
				if (MainGroupCode == "gems")
				{
					itemKind_0 = ItemKind.gem;
				}
				if (MainGroupCode == "consumable")
				{
					itemKind_0 = ItemKind.craft;
				}
				if (MainGroupCode == "craftmats")
				{
					itemKind_0 = ItemKind.craft;
				}
				if (MainGroupCode == "crafttomes")
				{
					itemKind_0 = ItemKind.craft;
				}
				if (MainGroupCode == "craftpages")
				{
					itemKind_0 = ItemKind.craft;
				}
				if (MainGroupCode == "plans")
				{
					itemKind_0 = ItemKind.craft;
				}
				if (MainGroupCode == "gold")
				{
					itemKind_0 = ItemKind.goldcoin;
				}
				if (MainGroupCode == "healthglobe")
				{
					itemKind_0 = ItemKind.healthglobe;
				}
				if (MainGroupCode == "powerglobe")
				{
					itemKind_0 = ItemKind.powerglobe;
				}
				if (MainGroupCode == "rift_orb")
				{
					itemKind_0 = ItemKind.rift_orb;
				}
			}
			break;
		}
		if (SnoItemType.Code == "Book")
		{
			itemKind_0 = ItemKind.book;
		}
	}

	public bool HasGroupCode(string code)
	{
		if (GroupCodes != null)
		{
			return Array.BinarySearch(GroupCodes, code) >= 0;
		}
		return false;
	}

	bool ISnoItem.HasGroupCode(string code)
	{
		//ILSpy generated this explicit interface implementation from .override directive in HasGroupCode
		return this.HasGroupCode(code);
	}

	public override string ToString()
	{
		return Sno.ToString("D", CultureInfo.InvariantCulture) + " " + Code + "(" + Level.ToString("D", CultureInfo.InvariantCulture) + ") " + SnoItemType.ToString() + "[" + NameLocalized + "]";
	}
}
