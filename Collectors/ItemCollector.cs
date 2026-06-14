#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using structs;
using Plugins;
using SNO;
using work;

namespace collectors;

internal class ItemCollector
{
	public readonly Class112<uint, IItem> class112_0 = new Class112<uint, IItem>();

	public readonly List<IItem> list_0 = new List<IItem>();

	public readonly List<IItem> list_1 = new List<IItem>();

	public IWorldCoordinate iworldCoordinate_0;

	public IItem iitem_0;

	public double double_0;

	public double double_1;

	public readonly List<IItem> list_2 = new List<IItem>();

	public IItem iitem_1;

	public IItem iitem_2;

	public readonly List<IItem> list_3 = new List<IItem>();

	public int int_0;

	public bool bool_0;

	public int[] int_1 = new int[20];

	private readonly Class112<uint, Item> class112_1 = new Class112<uint, Item>(1000);

	private readonly List<Item> list_4 = new List<Item>();

	private readonly List<Item> list_5 = new List<Item>();

	private readonly Class112<uint, Item> class112_2 = new Class112<uint, Item>();

	private Stopwatch stopwatch_0 = new();

	private static readonly List<r_AttributeEntry> list_6 = new List<r_AttributeEntry>();

	public EventHandler<IItem> OnItemIdentified { get; set; }

	public EventHandler<EventArgs5> OnItemLocationChanged { get; set; }

	public EventHandler<EventArgs6> OnItemPicked { get; set; }

	public EventHandler<LootGenerated> OnLootGenerated {  get; set; }

	internal void method_0(bool bool_1)
	{
		if (bool_1) {
			class112_1.Clear();
		}
		class112_0.Clear();
		iitem_1 = null;
		iitem_2 = null;
		list_0.Clear();
		list_1.Clear();
		iworldCoordinate_0 = null;
		iitem_0 = null;
		double_0 = 0.0;
		double_1 = 0.0;
		list_2.Clear();
		list_3.Clear();
		int_0 = 0;
		Array.Clear(int_1, 0, int_1.Length);
	}

	internal void method_1()
	{
		method_0(bool_1: false);
		bool flag = false;
		if (stopwatch_0.ElapsedMilliseconds >= 1000) {
			flag = true;
			stopwatch_0.Restart();
		}
		list_4.Clear();
		list_5.Clear();
		class112_2.Clear();
		bool_0 = false;
		for (int i = 0; i <= CoreCollector.D3Memory.ACDContainer.MaxIndex; i++) {
			CoreCollector.ACDCollector.SetIndex(i);
			r_ACD struct7_ = CoreCollector.ACDCollector.Buffer_ACDs[CoreCollector.ACDCollector.AcdIndexCur];
			uint annId = struct7_.AnnId;
			if (struct7_.GameBalanceType != 2 || struct7_.ActorRarity != -1) {
				continue;
			}
			uint acdId = struct7_.AcdId;
			if (acdId == uint.MaxValue) {
				continue;
			}
			ItemLocation itemLocation = (ItemLocation)struct7_.ItemLocation;
			if (itemLocation == ItemLocation.MerchantBuyback || itemLocation >= ItemLocation.VendorToken || (itemLocation == ItemLocation.Floor && struct7_.SWorldID_Encrypted == 0)) {
				continue;
			}
			Item item = class112_1[annId];
			ISnoItem snoItem = ((item == null) ? SnoData.Items.GetBySno(struct7_.GBID) : item.SnoItem);
			if (snoItem == null || (itemLocation == ItemLocation.Floor && struct7_.PositionX == 0f && double.IsNaN(struct7_.PositionY))) {
				continue;
			}
			bool flag2 = item != null;
			if (snoItem.Kind == ItemKind.potion && itemLocation == ItemLocation.Inventory) {
				bool_0 = true;
			}
			bool flag4 = struct7_.Unidentified == 1;
			if (item != null && item.Unidentified && !flag4) {
				if (struct7_.affix_list_ptr == 0L) {
					continue;
				}
				if (!CoreCollector.ACDCollector.method_5() || !method_2(struct7_, item, snoItem, bool_1: true, itemLocation)) {
					continue;
				}
				list_4.Add(item);
			}
			if (item == null) {
				item = new Item(acdId, annId, snoItem) {
					Unidentified = flag4
				};
				list_4.Add(item);
				if (!CoreCollector.ACDCollector.method_5() || !method_2(struct7_, item, snoItem, bool_1: false, itemLocation)) {
					continue;
				}
			} else {
				if (item.AcdId != acdId) {
					item.method_26(acdId);
				}
				if (flag && ((item.Location >= ItemLocation.Inventory && item.Location <= ItemLocation.Neck) || (CoreCollector.ActorCollector.IActor_1 != null && item.SnoItem.MainGroupCode == "gems_unique"))) {
					if (!CoreCollector.ACDCollector.method_5() || !method_2(struct7_, item, snoItem, bool_1: true, itemLocation)) {
						continue;
					}
					list_4.Add(item);
				}
			}
			bool flag5 = flag2 && item.Unidentified;
			ItemLocation itemLocation2 = (flag2 ? item.Location : ItemLocation.Inventory);
			item.Location = itemLocation;
			if (itemLocation == ItemLocation.Inventory) {
				item.SeenInInventory = true;
			}
			if (item.Quality == ItemQuality.Legendary && item.SnoItem.MainGroupCode == "gems_unique" && !flag4) {
				flag4 = item.method_47("unidentified") == 1;
			}
			item.Unidentified = flag4;
			if (flag2 && (itemLocation != itemLocation2 || flag4 != flag5)) {
				class112_2[item.AcdId] = item;
			}
			if (itemLocation == ItemLocation.Floor) {
				item.InventoryX = -1;
				item.InventoryY = -1;
				item.method_24(struct7_.PositionX, struct7_.PositionY, struct7_.PositionZ);
				uint sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
				uint sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
				ActorCollector.smethod_1(item, sWorldID_Encrypted, sSceneID_Encrypted);
				if (sWorldID_Encrypted == 0) {
					continue;
				}
				if (item.SnoItem != null && (item.SnoItem.Sno == 483403932 || item.SnoItem.Sno == 3087229753u || item.SnoItem.Sno == 2050794135 || item.SnoItem.Sno == 113551449)) {
					iitem_1 = item;
				}
				if (item.SnoItem != null && (item.SnoItem.Sno == 1102953247 || item.SnoItem.Sno == 2029265596 || item.SnoItem.Sno == 2670343450u || item.SnoItem.Sno == 3336787100u)) {
					iitem_2 = item;
				}
			} else {
				if (flag2 && (item.InventoryX != struct7_.ItemSlotX || item.InventoryY != struct7_.ItemSlotY)) {
					class112_2[item.AcdId] = item;
				}
				item.InventoryX = struct7_.ItemSlotX;
				item.InventoryY = struct7_.ItemSlotY;
			}
			uint uInt32_ = item.UInt32_0;
			item.UInt32_0 = struct7_.SocketHostAcdId;
			if (flag2 && uInt32_ != item.UInt32_0) {
				IItem item2 = class112_0[uInt32_];
				if (item2 != null && !list_5.Contains(item2)) {
					list_5.Add(item2 as Item);
				}
				IItem item3 = class112_0[item.UInt32_0];
				if (item3 != null && !list_5.Contains(item3)) {
					list_5.Add(item3 as Item);
				}
			}
			class112_0.Set(acdId, item);
			if (itemLocation == ItemLocation.Inventory) {
				int_0 += item.SnoItem.ItemWidth * item.SnoItem.ItemHeight;
			}
			if (snoItem.Kind == ItemKind.loot || snoItem.Kind == ItemKind.uberstuff || snoItem.Kind == ItemKind.gem || snoItem.Kind == ItemKind.craft || snoItem.Kind == ItemKind.healthglobe || snoItem.Kind == ItemKind.powerglobe || snoItem.Kind == ItemKind.rift_orb || snoItem.Kind == ItemKind.potion || snoItem.Kind == ItemKind.book) {
				switch (itemLocation) {
					case ItemLocation.Inventory:
						list_2.Add(item);
						break;
					case ItemLocation.Stash: {
							list_0.Add(item);
							int num = item.InventoryY / 10;
							if (num < int_1.Length) {
								int_1[num] += item.SnoItem.ItemWidth * item.SnoItem.ItemHeight;
							}
							break;
						}
					case ItemLocation.Floor:
						list_1.Add(item);
						break;
					case ItemLocation.MerchantAvaibleItemsForPurchase:
					case ItemLocation.Merchant:
						list_3.Add(item);
						break;
				}
			}
			if (itemLocation == ItemLocation.Floor && !(item.CentralXyDistanceToMe < 200.0)) {
				continue;
			}
			if (flag2) {
				if (flag5 && !flag4 && itemLocation == ItemLocation.Inventory) {
					OnItemIdentified?.Invoke(this, item);
				}
				if (itemLocation2 == itemLocation) {
					continue;
				}
				if (itemLocation2 == ItemLocation.Floor && itemLocation == ItemLocation.Inventory) {
					item.bool_10 = true;
					try {
						OnItemPicked?.Invoke(this, new EventArgs6 {
							iitem_0 = item
						});
					} catch (Exception exception_2) {
						Logger.LogException(exception_2.Message);
					}
					continue;
				}
				try {
					OnItemLocationChanged?.Invoke(this, new EventArgs5 {
						iitem_0 = item,
						itemLocation_0 = itemLocation2,
						itemLocation_1 = itemLocation
					});
				} catch (Exception exception_3) {
					Logger.LogException(exception_3.Message);
				}
				continue;
			}
			class112_1[annId] = item;
			if (itemLocation == ItemLocation.Inventory && CoreCollector.IsInTown && CoreCollector.UiElements.class341_47.Visible) {
				string text = CoreCollector.UiElements.class341_48.ReadText();
				if (text != null && text.Contains("{icon:x1_shard}")) {
					int num2 = item.method_47("picked_up_time", -1);
					if (num2 > -1 && num2 > CoreCollector.D3Memory.GameTick - 240) {
						item.Boolean_1 = true;
						try {
							OnLootGenerated?.Invoke(this, new LootGenerated {
								item = item,
								gambled = true
							});
						} catch (Exception exception_4) {
							Logger.LogException(exception_4.Message);
						}
					}
				}
			}
			if (itemLocation == ItemLocation.Floor && !CoreCollector.IsInTown && (item.Unidentified || (int)item.Quality < 9)) {
				try {
					OnLootGenerated?.Invoke(this, new LootGenerated {
						item = item,
						gambled = false
					});
				} catch (Exception exception_5) {
					Logger.LogException(exception_5.Message);
				}
			}
		}
		foreach (IItem item5 in list_1.Where((IItem iitem_0) => iitem_0.Quality == ItemQuality.Legendary && iitem_0.SnoItem.Sno != 2603730171u)) {
			if (iworldCoordinate_0 == null || item5.CentralXyDistanceToMe < double_0) {
				iworldCoordinate_0 = item5.FloorCoordinate;
				double_0 = item5.CentralXyDistanceToMe;
				double_1 = item5.ZDistanceToMeAbsolute;
				iitem_0 = item5;
			}
		}
		foreach (Item item6 in list_4.Concat(list_5)) {
			class112_2[item6.AcdId] = item6;
		}
		if (class112_2.Int32_0 > 0) {
			foreach (Item item9 in class112_2.IEnumerable_0) {
				item9.method_45();
			}
		}
		foreach (IItem item10 in class112_0.IEnumerable_0) {
			if (item10.Location != ItemLocation.Floor && item10.Location != ItemLocation.Merchant && item10.Location != ItemLocation.MerchantAvaibleItemsForPurchase && item10.Location != ItemLocation.MerchantBuyback) {
				Item obj = item10 as Item;
				if (obj != null && !obj.bool_12) {
					(item10 as Item)?.method_45();
				}
			}
		}
	}

	private bool method_2(r_ACD struct7_0, Item class309_0, ISnoItem isnoItem_0, bool bool_1, ItemLocation itemLocation_0)
	{
		if (!method_3(class309_0, isnoItem_0)) {
			Logger.LogException("can't read item stats");
			return false;
		}
		method_4(class309_0, bool_1, itemLocation_0);
		if ((int)class309_0.Quality >= 6 && (int)class309_0.Quality <= 8) {
			if (struct7_0.rare_item_stringlist_id != uint.MaxValue && (class309_0.RareName == null || bool_1)) {
				string text = null;
				string text2 = null;
				if (struct7_0.rare_item_prefix_or_suffix == 0) {
					text = SnoData.Strings.GetStringByIndex(struct7_0.rare_item_stringlist_id, struct7_0.rare_item_stringlist_index);
					if (isnoItem_0.SuffixStringSno != 0) {
						text2 = SnoData.Strings.GetStringByIndex(isnoItem_0.SuffixStringSno, struct7_0.rare_item_otherlist_index);
					}
				} else {
					text2 = SnoData.Strings.GetStringByIndex(struct7_0.rare_item_stringlist_id, struct7_0.rare_item_stringlist_index);
					if (isnoItem_0.PrefixStringSno != 0) {
						text = SnoData.Strings.GetStringByIndex(isnoItem_0.PrefixStringSno, struct7_0.rare_item_otherlist_index);
					}
				}
				class309_0.RareName = (text + " " + text2).Trim();
			}
		} else if ((int)class309_0.Quality >= 3 && (int)class309_0.Quality <= 5 && class309_0.Affixes != null && (class309_0.RareName == null || bool_1)) {
			if (class309_0.Affixes.Length == 1) {
				ISnoItemAffix snoItemAffix = class309_0.Affixes[0];
				if (snoItemAffix.BaseAffixId != uint.MaxValue) {
					snoItemAffix = SnoData.Items.GetSnoItemAffix(snoItemAffix.BaseAffixId);
				}
				if (snoItemAffix != null && snoItemAffix.NameLocalized != null) {
					class309_0.RareName = (snoItemAffix.NameEnglish.StartsWith("of", ignoreCase: false, CultureInfo.InvariantCulture) ? (isnoItem_0.NameLocalized + " " + snoItemAffix.NameLocalized) : (snoItemAffix.NameLocalized + " " + isnoItem_0.NameLocalized));
				} else {
					Trace.WriteLine("???");
				}
			}
			if (class309_0.Affixes.Length == 2) {
				ISnoItemAffix snoItemAffix2 = class309_0.Affixes[0];
				if (snoItemAffix2.BaseAffixId != uint.MaxValue) {
					snoItemAffix2 = SnoData.Items.GetSnoItemAffix(snoItemAffix2.BaseAffixId);
				}
				ISnoItemAffix snoItemAffix3 = class309_0.Affixes[1];
				if (snoItemAffix3.BaseAffixId != uint.MaxValue) {
					snoItemAffix3 = SnoData.Items.GetSnoItemAffix(snoItemAffix3.BaseAffixId);
				}
				if (snoItemAffix2 != null && snoItemAffix3 != null && snoItemAffix2.NameLocalized != null && snoItemAffix3.NameLocalized != null) {
					class309_0.RareName = (snoItemAffix3.NameEnglish.StartsWith("of", ignoreCase: false, CultureInfo.InvariantCulture) ? (snoItemAffix2.NameLocalized + " " + isnoItem_0.NameLocalized + " " + snoItemAffix3.NameLocalized) : (snoItemAffix3.NameLocalized + " " + isnoItem_0.NameLocalized + " " + snoItemAffix2.NameLocalized));
				} else {
					Trace.WriteLine("???");
				}
			}
			if (class309_0.Affixes.Length == 0 || class309_0.Affixes.Length > 2) {
				Trace.WriteLine("???");
			}
		}
		return true;
	}

	private bool method_3(Item class309_0, ISnoItem isnoItem_0)
	{
		if (class309_0 == null) {
			return false;
		}
		class309_0.class112_0.Clear();
		class309_0.method_46(new ItemStat("name", isnoItem_0.NameLocalized));
		class309_0.method_46(new ItemStat("ilvl", isnoItem_0.Level, isnoItem_0.Level));
		double num = -1.0;
		double num2 = -1.0;
		double num3 = -1.0;
		double num4 = -1.0;
		double num5 = -1.0;
		double val = -1.0;
		double num6 = -1.0;
		double num7 = -1.0;
		double num8 = -1.0;
		double num9 = -1.0;
		class309_0.Quantity = -1L;
		list_6.Clear();
		if (!CoreCollector.ACDCollector.method_12(list_6)) {
			return false;
		}
		for (int i = 0; i < list_6.Count; i++) {
			r_AttributeEntry r_AttributeEntry2 = list_6[i];
			int num10 = (int)(r_AttributeEntry2.uint_0 & 0xFFF);
			if (num10 <= 0 || num10 >= SnoData.Attributes.ByIndex.Count) {
				continue;
			}
			AcdAttribute acdAttribute = SnoData.Attributes.ByIndex[num10];
			if (acdAttribute == null) {
				Logger.LogException("itemstats read error, unknown attribute id: " + num10);
				continue;
			}
			uint uint_0 = r_AttributeEntry2.uint_0 >> 12;
			bool flag = false;
			foreach (IAttributeProcessor item in acdAttribute.Processors.Where((IAttributeProcessor iattributeProcessor_0) => iattributeProcessor_0.Modifier == uint.MaxValue || iattributeProcessor_0.Modifier == uint_0)) {
				flag = true;
				double val2 = ((acdAttribute.ValueType == AttributeValueType._int) ? ((double)r_AttributeEntry2.int_0) : ((double)r_AttributeEntry2.float_0));
				double num11 = Math.Min(2147483647.0, Math.Max(-2147483648.0, val2));
				class309_0.method_46(new ItemStat(acdAttribute, uint_0, num11, r_AttributeEntry2.int_0));
				if (acdAttribute.ValueType == AttributeValueType._int) {
					int val3 = item.ProcessInt(r_AttributeEntry2.int_0);
					val2 = Math.Min(int.MaxValue, Math.Max(int.MinValue, val3));
					class309_0.method_46(new ItemStat(item, val2, val3));
				} else {
					double val4 = item.ProcessDouble(r_AttributeEntry2.float_0);
					val2 = Math.Min(2147483647.0, Math.Max(-2147483648.0, val4));
					class309_0.method_46(new ItemStat(item, val2, 0));
				}
				string code = item.Code;
				switch (code) {
					case "dmg_hi":
						num2 = val2;
						break;
					case "anyres":
						num8 = val2;
						break;
					case "e_armor":
						num9 = val2;
						break;
					case "dmg_lo":
						num = val2;
						break;
					case "quantity_lo":
						class309_0.Quantity = r_AttributeEntry2.int_0;
						break;
					case "offh_dmg_add":
						num5 = val2;
						break;
					case "offh_dmg_lo":
						num4 = val2;
						break;
					case "allres":
						num7 = val2;
						break;
					case "vita":
						val = val2;
						break;
					case "as_weap":
						num3 = val2;
						break;
					case "int":
					case "str":
					case "dex":
						// no specific logic performed for these in the original code, but they were explicitly checked.
						break;
				}
				if (num6 == -1.0 || val2 > num6) {
					num6 = val2;
				}
			}
			if (!flag) {
				if (acdAttribute.ValueType == AttributeValueType._int) {
					class309_0.method_46(new ItemStat(acdAttribute, uint_0, r_AttributeEntry2.int_0, r_AttributeEntry2.int_0));
				} else {
					float num13 = Math.Min(2.1474836E+09f, Math.Max(-2.1474836E+09f, r_AttributeEntry2.float_0));
					class309_0.method_46(new ItemStat(acdAttribute, uint_0, num13));
				}
				switch (acdAttribute.Code) {
					case "EnchantedAffixCount":
						class309_0.EnchantedAffixCounter = r_AttributeEntry2.int_0;
						break;
					case "EnchantedAffixNew":
						class309_0.EnchantedAffixNew = (uint)r_AttributeEntry2.int_0;
						break;
					case "EnchantedAffixOld":
						class309_0.EnchantedAffixOriginal = (uint)r_AttributeEntry2.int_0;
						break;
				}
			}
		}
		if (num > 0.0 && num2 > 0.0 && num3 > -1.0) {
			double num14 = Math.Round((num + num2) * num3 / 2.0, MidpointRounding.AwayFromZero);
			class309_0.method_46(new ItemStat("dps", num14));
		}
		if (num4 > -1.0 || num5 > -1.0) {
			double num15 = Math.Round(((num4 == -1.0) ? 0.0 : num4) + ((num5 == -1.0) ? 0.0 : num5) / 2.0, MidpointRounding.AwayFromZero);
			class309_0.method_46(new ItemStat("dps", num15));
		}
		if (num6 > 0.0) {
			class309_0.method_46(new ItemStat("main_stat", num6));
			class309_0.method_46(new ItemStat("main_stat_vita", num6 + Math.Max(0.0, val)));
		}
		if (num7 > 0.0 || num9 > 0.0) {
			double num16 = 0.0;
			if (num7 > 0.0) {
				num16 += num7;
			}
			if (num9 > 0.0) {
				num16 += (double)Convert.ToInt32(Math.Round(num9 / 10.0, MidpointRounding.AwayFromZero));
			}
			class309_0.method_46(new ItemStat("allres_armor", num16));
		}
		if (num7 > 0.0 || num9 > 0.0 || num8 > 0.0) {
			double num17 = 0.0;
			if (num7 > 0.0) {
				num17 += num7;
			}
			if (num9 > 0.0) {
				num17 += (double)Convert.ToInt32(Math.Round(num9 / 10.0, MidpointRounding.AwayFromZero));
			}
			if (num8 > 0.0) {
				num17 += num8;
			}
			class309_0.method_46(new ItemStat("allres_anyres", num17));
		}
		class309_0.Seed = class309_0.method_47("seed");
		class309_0.Quality = (ItemQuality)class309_0.method_47("quality");
		return true;
	}

	private void method_4(Item class309_0, bool bool_1, ItemLocation itemLocation_0)
	{
		if (class309_0.Unidentified && !bool_1) {
			return;
		}
		List<ISnoItemAffix> list = null;
		for (long num = CoreCollector.ACDCollector.Buffer_ACDs[CoreCollector.ACDCollector.AcdIndexCur].affix_list_ptr; num != 0L; num = MR.Instance.ReadAddress(num + IntPtr.Size * 2)) {
			uint num2 = MR.Instance.ReadUInt(num);
			if (class309_0.EnchantedAffixOriginal != 0 && class309_0.EnchantedAffixOriginal == num2) {
				num2 = class309_0.EnchantedAffixNew;
			}
			ISnoItemAffix snoItemAffix = SnoData.Items.GetSnoItemAffix(num2);
			if (snoItemAffix != null) {
				(list ?? (list = new List<ISnoItemAffix>())).Add(snoItemAffix);
				for (int i = 0; i < snoItemAffix.Mods.Length; i++) {
					ISnoItemMod isnoItemMod_0 = snoItemAffix.Mods[i];
				}
			}
		}
		if (class309_0.SnoItem.Mods != null) {
			ISnoItemMod[] mods = class309_0.SnoItem.Mods;
			foreach (ISnoItemMod isnoItemMod_1 in mods) {
			}
		}
		class309_0.Affixes = list?.ToArray();
	}

	public void method_6(IItem iitem_3)
	{
		if (!(iitem_3 is Item item)) {
			return;
		}
		CoreCollector.ACDCollector.SetIndexFromAcdId(iitem_3.AcdId);
		int num = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__JewelRank, 1048575u, 0);
		if (num != 0) {
			IItemStat itemStat = item.class112_0["jewel_rank"];
			if (itemStat == null || itemStat.IntegerValue != num) {
				item.class112_0["jewel_rank"] = new ItemStat("jewel_rank", num, num);
			}
		}
	}

	public IItem method_7(ISnoItem isnoItem_0, ItemQuality itemQuality_0, ItemLocation itemLocation_0, long long_0)
	{
		return new Item(0u, 0u, isnoItem_0) {
			Quality = itemQuality_0,
			Location = itemLocation_0,
			Quantity = long_0
		};
	}
}
