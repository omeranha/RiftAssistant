using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Engine;

public sealed class Attributes
{
	[CompilerGenerated]
	private readonly AttributeMap map;

	public readonly List<AcdAttribute> ByIndex = new List<AcdAttribute>();

	private readonly Dictionary<string, AcdAttribute> all = new Dictionary<string, AcdAttribute>();

	private readonly Dictionary<string, AttributeProcessor> dictionary_1 = new Dictionary<string, AttributeProcessor>();

	public AttributeMap Map
	{
		[CompilerGenerated]
		get
		{
			return map;
		}
	}

	public IEnumerable<AcdAttribute> All => all.Values;

	public AcdAttribute GetAttributeByIndex(int index)
	{
		return ByIndex[index];
	}

	public AcdAttribute GetAttributeByCode(string code)
	{
		all.TryGetValue(code, out var value);
		return value;
	}

	public AttributeProcessor GetAttributeProcessor(string code)
	{
		dictionary_1.TryGetValue(code, out var value);
		return value;
	}

	internal Attributes()
	{
		using (DataReader dataReader = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "actor_attributes.bin"))))
		{
			while (dataReader.Stream.Position < dataReader.Stream.Length)
			{
				uint uint_ = dataReader.ReadUInt32();
				string string_ = dataReader.ReadString();
				AttributeValueType attributeValueType_ = (AttributeValueType)dataReader.ReadByte();
				Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
				dataReader.ReadPackedInt32();
				int num = dataReader.ReadPackedInt32();
				for (int i = 0; i < num; i++)
				{
					int key = dataReader.ReadPackedInt32();
					string code = dataReader.ReadString();
					string stringByCode = SnoData.Strings.GetStringByCode(StringListSnoEnum._attributedescriptions, code);
					stringByCode = stringByCode.Replace("{value", "{VALUE").Replace("{Value", "{VALUE").Replace("*100}|1|", "*100|1|")
						.Replace("|+|}]", "|+|]")
						.Replace(" * 100", "*100")
						.Replace("|4time:times;", "times")
						.Replace("{c_magic}", "")
						.Replace("{/c_magic}", "")
						.Replace("{/c}", "")
						.Replace("{c_gold}", "")
						.Replace("{/c_gold}", "")
						.Replace("{c_green}", "")
						.Replace("{/c_green}", "");
					dictionary.Add((uint)key, stringByCode);
				}
				AcdAttribute acdAttribute = new AcdAttribute(string_, uint_, attributeValueType_, dictionary);
				ByIndex.Add(acdAttribute);
				if (!all.ContainsKey(acdAttribute.Code))
				{
					all.Add(acdAttribute.Code, acdAttribute);
				}
			}
		}
		using (DataReader dataReader2 = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "actor_attribute_order_pri.bin"))))
		{
			int num2 = 0;
			while (dataReader2.Stream.Position < dataReader2.Stream.Length)
			{
				int index = dataReader2.ReadInt32();
				int mod = dataReader2.ReadInt32();
				int num3 = dataReader2.ReadInt32();
				int mod2 = dataReader2.ReadInt32();
				num2++;
				AcdAttribute acdAttribute2 = ByIndex[index];
				int modLowestOrderIndex = acdAttribute2.GetModLowestOrderIndex(mod);
				if (modLowestOrderIndex == 0 || num2 < modLowestOrderIndex)
				{
					acdAttribute2.SetModLowestOrderIndex(mod, num2);
					acdAttribute2.OrderIndexPrimary = true;
				}
				if (num3 > -1)
				{
					num2++;
					acdAttribute2 = ByIndex[num3];
					modLowestOrderIndex = acdAttribute2.GetModLowestOrderIndex(mod2);
					if (modLowestOrderIndex == 0 || num2 < modLowestOrderIndex)
					{
						acdAttribute2.SetModLowestOrderIndex(mod2, num2);
						acdAttribute2.OrderIndexPrimary = true;
					}
				}
			}
		}
		using (DataReader dataReader3 = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "actor_attribute_order_sec.bin"))))
		{
			int num2 = 0;
			while (dataReader3.Stream.Position < dataReader3.Stream.Length)
			{
				int index2 = dataReader3.ReadInt32();
				int mod3 = dataReader3.ReadInt32();
				int num4 = dataReader3.ReadInt32();
				int mod4 = dataReader3.ReadInt32();
				num2++;
				AcdAttribute acdAttribute3 = ByIndex[index2];
				int modLowestOrderIndex2 = acdAttribute3.GetModLowestOrderIndex(mod3);
				if (modLowestOrderIndex2 == 0 || num2 < modLowestOrderIndex2)
				{
					acdAttribute3.SetModLowestOrderIndex(mod3, num2);
					acdAttribute3.OrderIndexPrimary = false;
				}
				if (num4 > -1)
				{
					num2++;
					acdAttribute3 = ByIndex[num4];
					modLowestOrderIndex2 = acdAttribute3.GetModLowestOrderIndex(mod4);
					if (modLowestOrderIndex2 == 0 || num2 < modLowestOrderIndex2)
					{
						acdAttribute3.SetModLowestOrderIndex(mod4, num2);
						acdAttribute3.OrderIndexPrimary = false;
					}
				}
			}
		}
		map = new AttributeMap(this);
		dictionary_1.Add("groups", new AttributeProcessor(0, "groups", null, 0u, 0.0, 0));
		dictionary_1.Add("name", new AttributeProcessor(1, "name", null, 0u, 0.0, 0));
		dictionary_1.Add("name_int", new AttributeProcessor(2, "name_int", null, 0u, 0.0, 0));
		dictionary_1.Add("ilvl", new AttributeProcessor(3, "ilvl", null, 0u, 0.0, 0));
		dictionary_1.Add("dps", new AttributeProcessor(4, "dps", null, 0u, 0.0, 0));
		dictionary_1.Add("main_stat", new AttributeProcessor(5, "main_stat", null, 0u, 0.0, 0));
		dictionary_1.Add("main_stat_vita", new AttributeProcessor(6, "main_stat_vita", null, 0u, 0.0, 0));
		dictionary_1.Add("allres_armor", new AttributeProcessor(7, "allres_armor", null, 0u, 0.0, 0));
		dictionary_1.Add("allres_anyres", new AttributeProcessor(8, "allres_anyres", null, 0u, 0.0, 0));
		dictionary_1.Add("cubed", new AttributeProcessor(9, "cubed", null, 0u, 0.0, 0));
		dictionary_1.Add("can_cubed", new AttributeProcessor(10, "can_cubed", null, 0u, 0.0, 0));
		AddProcessor(9, "str", "Strength_Item", uint.MaxValue, null, 0);
		AddProcessor(10, "dex", "Dexterity_Item", uint.MaxValue, null, 0);
		AddProcessor(11, "int", "Intelligence_Item", uint.MaxValue, null, 0);
		AddProcessor(12, "vita", "Vitality_Item", uint.MaxValue, null, 0);
		AddProcessor(13, "life", "Hitpoints_Max_Percent_Bonus_Item", uint.MaxValue, 100.0, 0);
		AddProcessor(14, "b_armor", "Armor_Item", uint.MaxValue, null, 0);
		AddProcessor(15, "e_armor", "Armor_Bonus_Item", uint.MaxValue, null, 0);
		AddProcessor(16, "t_armor", "Armor_Item_Total", uint.MaxValue, null, 0);
		AddProcessor(17, "dura", "Durability_Max", uint.MaxValue, 0.1, -2);
		AddProcessor(18, "gf", "Gold_Find", uint.MaxValue, 100.0, 0);
		AddProcessor(19, "mf", "Magic_Find", uint.MaxValue, 100.0, 0);
		AddProcessor(20, "quality", "Item_Quality_Level", uint.MaxValue, null, -1);
		AddProcessor(21, "gem_quality", "GemQuality", uint.MaxValue, null, -1);
		AddProcessor(22, "move", "Movement_Scalar", uint.MaxValue, 100.0, 0);
		AddProcessor(23, "hpglobe", "Health_Globe_Bonus_Health", uint.MaxValue, null, -1);
		AddProcessor(24, "hpreg", "Hitpoints_Regen_Per_Second", uint.MaxValue, null, -1);
		AddProcessor(25, "pickup", "Gold_PickUp_Radius", uint.MaxValue, null, 0);
		AddProcessor(26, "reg_mana", "Resource_Regen_Per_Second", 0u, null, 0);
		AddProcessor(27, "reg_ap", "Resource_Regen_Per_Second", 1u, null, 0);
		AddProcessor(28, "reg_fury", "Resource_Regen_Per_Second", 2u, null, 0);
		AddProcessor(29, "reg_spirit", "Resource_Regen_Per_Second", 3u, null, 2);
		AddProcessor(30, "reg_hatred", "Resource_Regen_Per_Second", 5u, null, 1);
		AddProcessor(31, "reg_disc", "Resource_Regen_Per_Second", 6u, null, 1);
		AddProcessor(32, "max_mana", "Resource_Max_Bonus", 0u, null, 0);
		AddProcessor(33, "max_ap", "Resource_Max_Bonus", 1u, null, 0);
		AddProcessor(34, "max_fury", "Resource_Max_Bonus", 2u, null, 0);
		AddProcessor(35, "max_spirit", "Resource_Max_Bonus", 3u, null, 0);
		AddProcessor(36, "max_hatred", "Resource_Max_Bonus", 5u, null, 0);
		AddProcessor(37, "max_disc", "Resource_Max_Bonus", 6u, null, 0);
		AddProcessor(38, "loh", "Hitpoints_On_Hit", uint.MaxValue, null, 0);
		AddProcessor(39, "lok", "Hitpoints_On_Kill", uint.MaxValue, null, 0);
		AddProcessor(40, "lsteal", "Steal_Health_Percent", uint.MaxValue, 100.0, 2);
		AddProcessor(41, "ias", "Attacks_Per_Second_Percent", uint.MaxValue, 100.0, 2);
		AddProcessor(42, "ccred", "CrowdControl_Reduction", uint.MaxValue, 100.0, 0);
		AddProcessor(43, "indest", "Item_Indestructible", uint.MaxValue, null, 0);
		AddProcessor(44, "allres", "Resistance_All", uint.MaxValue, null, 0);
		AddProcessor(45, "anyres", "Resistance", uint.MaxValue, null, 0);
		AddProcessor(46, "ph_res", "Resistance", 0u, null, 0);
		AddProcessor(47, "f_res", "Resistance", 1u, null, 0);
		AddProcessor(48, "l_res", "Resistance", 2u, null, 0);
		AddProcessor(49, "c_res", "Resistance", 3u, null, 0);
		AddProcessor(50, "p_res", "Resistance", 4u, null, 0);
		AddProcessor(51, "a_res", "Resistance", 5u, null, 0);
		AddProcessor(52, "dmg_lo", "Damage_Weapon_Min_Total_All", uint.MaxValue, null, 0);
		AddProcessor(53, "dmg_hi", "Damage_Weapon_Max_Total_All", uint.MaxValue, null, 0);
		AddProcessor(54, "as_weap", "Attacks_Per_Second_Item_Total", uint.MaxValue, null, 2);
		AddProcessor(55, "as_extr", "Attacks_Per_Second_Item_Percent", uint.MaxValue, 100.0, 0);
		AddProcessor(56, "crit", "Crit_Percent_Bonus_Capped", uint.MaxValue, 100.0, 1);
		AddProcessor(57, "critdmg", "Crit_Damage_Percent", uint.MaxValue, 100.0, 0);
		AddProcessor(58, "apoc", "Resource_On_Crit", 1u, null, 0);
		AddProcessor(59, "offh_dmg_lo", "Damage_Min_Total_All", uint.MaxValue, null, 0);
		AddProcessor(60, "offh_dmg_add", "Damage_Delta_Total_All", uint.MaxValue, null, 0);
		AddProcessor(61, "dmg_pbonus", "Damage_Weapon_Percent_All", uint.MaxValue, 100.0, 0);
		AddProcessor(62, "sock", "Sockets", uint.MaxValue, null, 0);
		AddProcessor(63, "thorns", "Thorns_Fixed", uint.MaxValue, null, 0);
		AddProcessor(64, "b_block", "Block_Chance_Item", uint.MaxValue, 100.0, 0);
		AddProcessor(65, "e_block", "Block_Chance_Bonus_Item", uint.MaxValue, 100.0, 0);
		AddProcessor(66, "t_block", "Block_Chance_Item_Total", uint.MaxValue, 100.0, 0);
		AddProcessor(67, "lvlreq", "Requirement", 65u, null, 0);
		AddProcessor(68, "lvlreqred", "Item_Level_Requirement_Reduction", uint.MaxValue, null, 0);
		AddProcessor(69, "expbonus", "Experience_Bonus", uint.MaxValue, null, 0);
		AddProcessor(70, "seed", "Seed", uint.MaxValue, null, 0);
		AddProcessor(71, "gemquality", "GemQuality", uint.MaxValue, null, 0);
		AddProcessor(72, "quantity_lo", "ItemStackQuantityLo", uint.MaxValue, null, 0);
		AddProcessor(73, "quantity_hi", "ItemStackQuantityHi", uint.MaxValue, null, 0);
		AddProcessor(74, "bound_to_account", "Item_Bound_To_ACD", uint.MaxValue, null, 0);
		AddProcessor(75, "bound_mode", "Item_Binding_Level_Override", uint.MaxValue, null, 0);
		AddProcessor(76, "crafted", "IsCrafted", uint.MaxValue, null, 0);
		AddProcessor(77, "gold", "Gold", uint.MaxValue, null, 0);
		AddProcessor(78, "hp_cur", "Hitpoints_Cur", uint.MaxValue, null, 0);
		AddProcessor(79, "hp_max", "Hitpoints_Max_Total", uint.MaxValue, null, 0);
		AddProcessor(80, "cblow", "Crushing_Blow_Proc_Chance", uint.MaxValue, 100.0, 1);
		AddProcessor(81, "skilldmg", "Power_Damage_Percent_Bonus", uint.MaxValue, 100.0, 0);
		AddProcessor(82, "areadmg", "Splash_Damage_Effect_Percent", uint.MaxValue, 100.0, 0);
		AddProcessor(83, "sdmg_any", "Damage_Dealt_Percent_Bonus", uint.MaxValue, 100.0, 0);
		AddProcessor(84, "sdmg_ph", "Damage_Dealt_Percent_Bonus", 0u, 100.0, 0);
		AddProcessor(85, "sdmg_f", "Damage_Dealt_Percent_Bonus", 1u, 100.0, 0);
		AddProcessor(86, "sdmg_l", "Damage_Dealt_Percent_Bonus", 2u, 100.0, 0);
		AddProcessor(87, "sdmg_c", "Damage_Dealt_Percent_Bonus", 3u, 100.0, 0);
		AddProcessor(88, "sdmg_p", "Damage_Dealt_Percent_Bonus", 4u, 100.0, 0);
		AddProcessor(89, "sdmg_a", "Damage_Dealt_Percent_Bonus", 5u, 100.0, 0);
		AddProcessor(90, "rescostred", "Resource_Cost_Reduction_Percent_All", uint.MaxValue, 100.0, 0);
		AddProcessor(91, "cdred", "Power_Cooldown_Reduction_Percent_All", uint.MaxValue, 100.0, 0);
		AddProcessor(92, "elitedamred", "Damage_Percent_Reduction_From_Elites", uint.MaxValue, 100.0, 0);
		AddProcessor(93, "elitedam", "Damage_Percent_Bonus_Vs_Elites", uint.MaxValue, 100.0, 0);
		AddProcessor(94, "sdmg_h", "Damage_Dealt_Percent_Bonus", 6u, 100.0, 0);
		AddProcessor(95, "reg_wrath", "Resource_Regen_Per_Second", 7u, null, 1);
		AddProcessor(96, "max_wrath", "Resource_Max_Bonus", 7u, null, 0);
		AddProcessor(97, "unidentified", "Unidentified", uint.MaxValue, null, 0);
		AddProcessor(98, "jewel_rank", "Jewel_Rank", uint.MaxValue, null, 0);
		AddProcessor(99, "picked_up_time", "Picked_Up_Time", uint.MaxValue, null, 0);
		AddProcessor(100, "ancient_rank", "Ancient_Rank", uint.MaxValue, null, 0);
		AddProcessor(101, "cube_enchanted_gem_rank", "CubeEnchantedGemRank", uint.MaxValue, null, 0);
		AddProcessor(102, "vendor_bought", "IsVendorBought", uint.MaxValue, null, 0);
		AddProcessor(103, "bound_to_acdid", "Item_Bound_To_ACD", uint.MaxValue, null, 0);
	}

	private void AddProcessor(byte byte_0, string string_0, string string_1, uint maxValue, double? nullable_0, int int_0)
	{
		AcdAttribute attributeByCode = GetAttributeByCode(string_1);
		if (attributeByCode != null)
		{
			AttributeProcessor attributeProcessor = new AttributeProcessor(byte_0, string_0, attributeByCode, maxValue, nullable_0, int_0);
			dictionary_1.Add(attributeProcessor.Code, attributeProcessor);
			attributeByCode.AddProcessor(attributeProcessor);
		}
	}
}
