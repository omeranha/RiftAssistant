#nullable enable annotations
#nullable disable warnings
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

	public string[]? GroupCodes { get; }

	public ItemLocation UsedLocation1 { get; } = ItemLocation.Floor;

	public ItemLocation UsedLocation2 { get; } = ItemLocation.Floor;

	public SnoItemType? SnoItemType { get; }

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

	public SnoPower? LegendaryPower
	{
		get {
			if (Mods != null) {
				SnoItemMod? snoItemMod = Array.Find(Mods, (SnoItemMod snoItemMod0) => snoItemMod0.Attribute?.Code == "Item_Power_Passive");
				if (snoItemMod != null) {
					return SnoData.Powers.GetBySno(snoItemMod.Modifier);
				}
			}
			return null;
		}
	}

	public bool IsEthereal => Code.StartsWith("P71_Ethereal");

	internal SnoItem(uint sno, uint baseItemSno, uint setItemBonusesSno, SnoActor snoActor2, uint prefixStringSno, uint suffixStringSno, int level, SnoItemType? snoItemType2, int stackSize, int goldPrice, int unsocketPrice, int requiredLevel, int itemWidth, int itemHeight, string code, string nameLocalized, string nameEnglish, string mainGroupCode, string[]? groupCodes, ItemLocation itemLocation, ItemLocation itemLocation2, int dropWeight, int dropSmartDemonHunter, int dropSmartBarbarian, int dropSmartWizard, int dropSmartWitchDoctor, int dropSmartMonk, int dropSmartCrusader, ItemCraftQuality itemCraftQuality)
	{
		Sno = sno;
		BaseItemSno = baseItemSno;
		SetItemBonusesSno = setItemBonusesSno;
		SnoActor = snoActor2;
		PrefixStringSno = prefixStringSno;
		SuffixStringSno = suffixStringSno;
		Level = level;
		ItemWidth = itemWidth;
		ItemHeight = itemHeight;
		Code = code;
		NameLocalized = nameLocalized;
		NameEnglish = nameEnglish;
		MainGroupCode = mainGroupCode;
		GroupCodes = groupCodes;
		SnoItemType = snoItemType2;
		StackSize = stackSize;
		GoldPrice = goldPrice;
		UnsocketPrice = unsocketPrice;
		RequiredLevel = requiredLevel;
		UsedLocation1 = itemLocation;
		UsedLocation2 = itemLocation2;
		DropWeight = dropWeight;
		DropSmartDemonHunter = dropSmartDemonHunter;
		DropSmartBarbarian = dropSmartBarbarian;
		DropSmartWizard = dropSmartWizard;
		DropSmartWitchDoctor = dropSmartWitchDoctor;
		DropSmartMonk = dropSmartMonk;
		DropSmartCrusader = dropSmartCrusader;
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
