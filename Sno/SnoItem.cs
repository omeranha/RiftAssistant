using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Sno;

public sealed class SnoItem
{
	[CompilerGenerated]
	private readonly uint sno;

	[CompilerGenerated]
	private readonly SnoActor snoActor;

	[CompilerGenerated]
	private readonly ItemKind kind;

	[CompilerGenerated]
	private readonly uint prefixStringSno;

	[CompilerGenerated]
	private readonly uint suffixStringSno;

	[CompilerGenerated]
	private readonly int level;

	[CompilerGenerated]
	private readonly int itemWidth;

	[CompilerGenerated]
	private readonly int itemHeight;

	[CompilerGenerated]
	private readonly string code;

	[CompilerGenerated]
	private readonly string nameLocalized;

	[CompilerGenerated]
	private readonly string nameEnglish;

	[CompilerGenerated]
	private readonly string mainGroupCode;

	[CompilerGenerated]
	private readonly string[] groupCodes;

	[CompilerGenerated]
	private readonly ItemLocation usedLocation1 = ItemLocation.Floor;

	[CompilerGenerated]
	private readonly ItemLocation usedLocation2 = ItemLocation.Floor;

	[CompilerGenerated]
	private readonly SnoItemType snoItemType;

	[CompilerGenerated]
	private readonly int stackSize;

	[CompilerGenerated]
	private readonly int goldPrice;

	[CompilerGenerated]
	private readonly int unsocketPrice;

	[CompilerGenerated]
	private readonly int requiredLevel;

	[CompilerGenerated]
	private readonly uint baseItemSno;

	[CompilerGenerated]
	private readonly uint setItemBonusesSno;

	[CompilerGenerated]
	private readonly ItemCraftQuality craftQuality;

	[CompilerGenerated]
	private SnoItemMod[] isnoItemMod_0;

	[CompilerGenerated]
	private SnoItemAffixGroupLink[] isnoItemAffixGroupLink_0;

	[CompilerGenerated]
	private List<SnoSocketedEffect> socketedEffects;

	[CompilerGenerated]
	private bool canKanaiCube;

	[CompilerGenerated]
	private readonly int dropWeight;

	[CompilerGenerated]
	private readonly int dropSmartDemonHunter;

	[CompilerGenerated]
	private readonly int dropSmartBarbarian;

	[CompilerGenerated]
	private readonly int dropSmartWizard;

	[CompilerGenerated]
	private readonly int dropSmartWitchDoctor;

	[CompilerGenerated]
	private readonly int dropSmartMonk;

	[CompilerGenerated]
	private readonly int dropSmartCrusader;

	public uint Sno
	{
		[CompilerGenerated]
		get {
			return sno;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get {
			return snoActor;
		}
	}

	public ItemKind Kind
	{
		[CompilerGenerated]
		get {
			return kind;
		}
	}

	public uint PrefixStringSno
	{
		[CompilerGenerated]
		get {
			return prefixStringSno;
		}
	}

	public uint SuffixStringSno
	{
		[CompilerGenerated]
		get {
			return suffixStringSno;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get {
			return level;
		}
	}

	public int ItemWidth
	{
		[CompilerGenerated]
		get {
			return itemWidth;
		}
	}

	public int ItemHeight
	{
		[CompilerGenerated]
		get {
			return itemHeight;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get {
			return code;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get {
			return nameLocalized;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get {
			return nameEnglish;
		}
	}

	public string MainGroupCode
	{
		[CompilerGenerated]
		get {
			return mainGroupCode;
		}
	}

	public string[] GroupCodes
	{
		[CompilerGenerated]
		get {
			return groupCodes;
		}
	}

	public ItemLocation UsedLocation1
	{
		[CompilerGenerated]
		get {
			return usedLocation1;
		}
	}

	public ItemLocation UsedLocation2
	{
		[CompilerGenerated]
		get {
			return usedLocation2;
		}
	}

	public SnoItemType SnoItemType
	{
		[CompilerGenerated]
		get {
			return snoItemType;
		}
	}

	public int StackSize
	{
		[CompilerGenerated]
		get {
			return stackSize;
		}
	}

	public int GoldPrice
	{
		[CompilerGenerated]
		get {
			return goldPrice;
		}
	}

	public int UnsocketPrice
	{
		[CompilerGenerated]
		get {
			return unsocketPrice;
		}
	}

	public int RequiredLevel
	{
		[CompilerGenerated]
		get {
			return requiredLevel;
		}
	}

	public uint BaseItemSno
	{
		[CompilerGenerated]
		get {
			return baseItemSno;
		}
	}

	public uint SetItemBonusesSno
	{
		[CompilerGenerated]
		get {
			return setItemBonusesSno;
		}
	}

	public ItemCraftQuality CraftQuality
	{
		[CompilerGenerated]
		get {
			return craftQuality;
		}
	}

	public SnoItemMod[] Mods
	{
		[CompilerGenerated]
		get {
			return isnoItemMod_0;
		}
		[CompilerGenerated]
		set {
			isnoItemMod_0 = value;
		}
	}

	public SnoItemAffixGroupLink[] AffixGroups
	{
		[CompilerGenerated]
		get {
			return isnoItemAffixGroupLink_0;
		}
		[CompilerGenerated]
		set {
			isnoItemAffixGroupLink_0 = value;
		}
	}

	public List<SnoSocketedEffect> SocketedEffects
	{
		[CompilerGenerated]
		get {
			return socketedEffects;
		}
		[CompilerGenerated]
		set {
			socketedEffects = value;
		}
	}

	public bool CanKanaiCube
	{
		[CompilerGenerated]
		get {
			return canKanaiCube;
		}
		[CompilerGenerated]
		set {
			canKanaiCube = value;
		}
	}

	public int DropWeight
	{
		[CompilerGenerated]
		get {
			return dropWeight;
		}
	}

	public int DropSmartDemonHunter
	{
		[CompilerGenerated]
		get {
			return dropSmartDemonHunter;
		}
	}

	public int DropSmartBarbarian
	{
		[CompilerGenerated]
		get {
			return dropSmartBarbarian;
		}
	}

	public int DropSmartWizard
	{
		[CompilerGenerated]
		get {
			return dropSmartWizard;
		}
	}

	public int DropSmartWitchDoctor
	{
		[CompilerGenerated]
		get {
			return dropSmartWitchDoctor;
		}
	}

	public int DropSmartMonk
	{
		[CompilerGenerated]
		get {
			return dropSmartMonk;
		}
	}

	public int DropSmartCrusader
	{
		[CompilerGenerated]
		get {
			return dropSmartCrusader;
		}
	}

	public SnoPower LegendaryPower
	{
		get {
			if (Mods != null) {
				SnoItemMod snoItemMod = Array.Find(Mods, (SnoItemMod isnoItemMod_0) => isnoItemMod_0.Attribute?.Code == "Item_Power_Passive");
				if (snoItemMod != null) {
					return SnoData.Powers.GetBySno(snoItemMod.Modifier);
				}
			}
			return null;
		}
	}

	public bool IsEthereal => Code.StartsWith("P71_Ethereal");

	internal SnoItem(uint uint_5, uint uint_6, uint uint_7, SnoActor snoActor2, uint uint_8, uint uint_9, int int_14, SnoItemType snoItemType2, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, string string_5, string string_6, string string_7, string string_8, string[] string_9, ItemLocation itemLocation, ItemLocation itemLocation2, int int_21, int int_22, int int_23, int int_24, int int_25, int int_26, int int_27, ItemCraftQuality itemCraftQuality)
	{
		sno = uint_5;
		baseItemSno = uint_6;
		setItemBonusesSno = uint_7;
		snoActor = snoActor2;
		prefixStringSno = uint_8;
		suffixStringSno = uint_9;
		level = int_14;
		itemWidth = int_19;
		itemHeight = int_20;
		code = string_5;
		nameLocalized = string_6;
		nameEnglish = string_7;
		mainGroupCode = string_8;
		groupCodes = string_9;
		snoItemType = snoItemType2;
		stackSize = int_15;
		goldPrice = int_16;
		unsocketPrice = int_17;
		requiredLevel = int_18;
		usedLocation1 = itemLocation;
		usedLocation2 = itemLocation2;
		dropWeight = int_21;
		dropSmartDemonHunter = int_22;
		dropSmartBarbarian = int_23;
		dropSmartWizard = int_24;
		dropSmartWitchDoctor = int_25;
		dropSmartMonk = int_26;
		dropSmartCrusader = int_27;
		craftQuality = itemCraftQuality;
		kind = ItemKind.loot;
		switch (Sno) {
			case 126259831u:
				kind = ItemKind.goldcoin;
				break;
			case 2603730171u:
				kind = ItemKind.loot;
				break;
			default:
				if (MainGroupCode != null) {
					if (MainGroupCode == "potion") {
						kind = ItemKind.potion;
					}
					if (MainGroupCode == "uber") {
						kind = ItemKind.uberstuff;
					}
					if (MainGroupCode == "gems") {
						kind = ItemKind.gem;
					}
					if (MainGroupCode == "consumable") {
						kind = ItemKind.craft;
					}
					if (MainGroupCode == "craftmats") {
						kind = ItemKind.craft;
					}
					if (MainGroupCode == "crafttomes") {
						kind = ItemKind.craft;
					}
					if (MainGroupCode == "craftpages") {
						kind = ItemKind.craft;
					}
					if (MainGroupCode == "plans") {
						kind = ItemKind.craft;
					}
					if (MainGroupCode == "gold") {
						kind = ItemKind.goldcoin;
					}
					if (MainGroupCode == "healthglobe") {
						kind = ItemKind.healthglobe;
					}
					if (MainGroupCode == "powerglobe") {
						kind = ItemKind.powerglobe;
					}
					if (MainGroupCode == "rift_orb") {
						kind = ItemKind.rift_orb;
					}
				}
				break;
		}
		if (SnoItemType.Code == "Book") {
			kind = ItemKind.book;
		}
	}

	public bool HasGroupCode(string code)
	{
		if (GroupCodes != null) {
			return Array.BinarySearch(GroupCodes, code) >= 0;
		}
		return false;
	}

	public override string ToString()
	{
		return Sno.ToString("D", CultureInfo.InvariantCulture) + " " + Code + "(" + Level.ToString("D", CultureInfo.InvariantCulture) + ") " + SnoItemType.ToString() + "[" + NameLocalized + "]";
	}
}
