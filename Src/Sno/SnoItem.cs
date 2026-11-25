using System;
using System.Collections.Generic;
using System.Globalization;

namespace RiftAssistant.Sno;

public sealed class SnoItem
{

	public uint Sno { get; }

	public SnoActor SnoActor { get; }

	public ItemKind Kind { get; }

	public uint PrefixStringSno { get; }

	public uint SuffixStringSno { get; }

	public int Level { get; }

	public int ItemWidth { get; }

	public int ItemHeight { get; }

	public string Code { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public string MainGroupCode { get; }

	public string[] GroupCodes { get; }

	public ItemLocation UsedLocation1 { get; } = ItemLocation.Floor;

	public ItemLocation UsedLocation2 { get; } = ItemLocation.Floor;

	public SnoItemType SnoItemType { get; }

	public int StackSize { get; }

	public int GoldPrice { get; }

	public int UnsocketPrice { get; }

	public int RequiredLevel { get; }

	public uint BaseItemSno { get; }

	public uint SetItemBonusesSno { get; }

	public ItemCraftQuality CraftQuality { get; }

	public SnoItemMod[] Mods { get; set; }

	public SnoItemAffixGroupLink[] AffixGroups { get; set; }

	public List<SnoSocketedEffect> SocketedEffects { get; set; }

	public bool CanKanaiCube { get; set; }

	public int DropWeight { get; }

	public int DropSmartDemonHunter { get; }

	public int DropSmartBarbarian { get; }

	public int DropSmartWizard { get; }

	public int DropSmartWitchDoctor { get; }

	public int DropSmartMonk { get; }

	public int DropSmartCrusader { get; }

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
		Sno = uint_5;
		BaseItemSno = uint_6;
		SetItemBonusesSno = uint_7;
		SnoActor = snoActor2;
		PrefixStringSno = uint_8;
		SuffixStringSno = uint_9;
		Level = int_14;
		ItemWidth = int_19;
		ItemHeight = int_20;
		Code = string_5;
		NameLocalized = string_6;
		NameEnglish = string_7;
		MainGroupCode = string_8;
		GroupCodes = string_9;
		SnoItemType = snoItemType2;
		StackSize = int_15;
		GoldPrice = int_16;
		UnsocketPrice = int_17;
		RequiredLevel = int_18;
		UsedLocation1 = itemLocation;
		UsedLocation2 = itemLocation2;
		DropWeight = int_21;
		DropSmartDemonHunter = int_22;
		DropSmartBarbarian = int_23;
		DropSmartWizard = int_24;
		DropSmartWitchDoctor = int_25;
		DropSmartMonk = int_26;
		DropSmartCrusader = int_27;
		CraftQuality = itemCraftQuality;
		Kind = ItemKind.loot;
		switch (Sno) {
			case 126259831u:
				Kind = ItemKind.goldcoin;
				break;
			case 2603730171u:
				Kind = ItemKind.loot;
				break;
			default:
				if (MainGroupCode != null) {
					if (MainGroupCode == "potion") {
						Kind = ItemKind.potion;
					}
					if (MainGroupCode == "uber") {
						Kind = ItemKind.uberstuff;
					}
					if (MainGroupCode == "gems") {
						Kind = ItemKind.gem;
					}
					if (MainGroupCode == "consumable") {
						Kind = ItemKind.craft;
					}
					if (MainGroupCode == "craftmats") {
						Kind = ItemKind.craft;
					}
					if (MainGroupCode == "crafttomes") {
						Kind = ItemKind.craft;
					}
					if (MainGroupCode == "craftpages") {
						Kind = ItemKind.craft;
					}
					if (MainGroupCode == "plans") {
						Kind = ItemKind.craft;
					}
					if (MainGroupCode == "gold") {
						Kind = ItemKind.goldcoin;
					}
					if (MainGroupCode == "healthglobe") {
						Kind = ItemKind.healthglobe;
					}
					if (MainGroupCode == "powerglobe") {
						Kind = ItemKind.powerglobe;
					}
					if (MainGroupCode == "rift_orb") {
						Kind = ItemKind.rift_orb;
					}
				}
				break;
		}
		if (SnoItemType.Code == "Book") {
			Kind = ItemKind.book;
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
