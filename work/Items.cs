#define TRACE
using SNO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using Plugins;

namespace work;

public sealed class Items
{
	private readonly Dictionary<uint, ISnoItem> dictionary_0 = new Dictionary<uint, ISnoItem>(3000);

	private readonly Dictionary<uint, ISnoItemType> dictionary_1 = new Dictionary<uint, ISnoItemType>(200);

	private readonly Dictionary<string, ISnoItemType> dictionary_2 = new Dictionary<string, ISnoItemType>(200);

	private readonly Dictionary<uint, ISnoItemAffix> dictionary_3 = new Dictionary<uint, ISnoItemAffix>(6000);

	private readonly Dictionary<uint, ISnoItemAffixGroup> dictionary_4 = new Dictionary<uint, ISnoItemAffixGroup>(500);

	public IEnumerable<ISnoItem> All => dictionary_0.Values;

	public ISnoItem GetBySno(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	public ISnoItemType GetSnoItemType(uint sno)
	{
		dictionary_1.TryGetValue(sno, out var value);
		return value;
	}

	public ISnoItemAffix GetSnoItemAffix(uint sno)
	{
		dictionary_3.TryGetValue(sno, out var value);
		return value;
	}

	public ISnoItemAffixGroup GetSnoItemAffixGroup(uint sno)
	{
		dictionary_4.TryGetValue(sno, out var value);
		return value;
	}

	public bool SnoExits(uint sno)
	{
		return dictionary_0.ContainsKey(sno);
	}

	internal Items()
	{
		using (DataReader @class = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_item_types.bin"))))
		{
			while (@class.Stream.Position < @class.Stream.Length)
			{
				uint num = @class.method_8();
				string text = @class.method_1();
				string stringByCode = SnoData.Strings.GetStringByCode(StringListSnoEnum._itemtypenames, text);
				string stringByCodeEnglish = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._itemtypenames, text);
				uint num2 = @class.method_8();
				ISnoItemType isnoItemType_ = ((num2 == 0) ? null : GetSnoItemType(num2));
				SnoItemType value = new SnoItemType(num, text, stringByCode, stringByCodeEnglish, isnoItemType_);
				dictionary_1.Add(num, value);
				dictionary_2.Add(text, value);
			}
		}
		using (DataReader class2 = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_item_affixes.bin"))))
		{
			while (class2.Stream.Position < class2.Stream.Length)
			{
				uint num3 = class2.method_8();
				string code = string.Intern(class2.method_1());
				string stringByCode2 = SnoData.Strings.GetStringByCode(StringListSnoEnum._affixes, code);
				string stringByCodeEnglish2 = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._affixes, code);
				uint uint_ = class2.method_8();
				uint num4 = class2.method_8();
				uint num5 = class2.method_8();
				ISnoItemAffixGroup snoItemAffixGroup = null;
				ISnoItemAffixGroup snoItemAffixGroup2 = null;
				if (num4 != 0)
				{
					snoItemAffixGroup = GetSnoItemAffixGroup(num4);
					if (snoItemAffixGroup == null)
					{
						snoItemAffixGroup = new SnoItemAffixGroup(num4);
						dictionary_4.Add(num4, snoItemAffixGroup);
					}
				}
				if (num5 != 0)
				{
					snoItemAffixGroup2 = GetSnoItemAffixGroup(num5);
					if (snoItemAffixGroup2 == null)
					{
						snoItemAffixGroup2 = new SnoItemAffixGroup(num5);
						dictionary_4.Add(num5, snoItemAffixGroup2);
					}
				}
				HeroClass heroClass_ = (HeroClass)class2.method_8();
				bool bool_ = class2.method_18();
				SnoItemAffix snoItemAffix = new SnoItemAffix(num3, stringByCode2, stringByCodeEnglish2, uint_, snoItemAffixGroup, snoItemAffixGroup2, heroClass_, bool_);
				dictionary_3.Add(num3, snoItemAffix);
				snoItemAffixGroup?.AddAffix(snoItemAffix);
				snoItemAffixGroup2?.AddAffix(snoItemAffix);
				byte b = class2.method_6();
				SnoItemMod[] array = new SnoItemMod[b];
				for (int i = 0; i < b; i++)
				{
					AcdAttribute iattribute_ = SnoData.Attributes.ByIndex[class2.method_11()];
					uint uint_2 = class2.method_8();
					float float_ = class2.method_14();
					float float_2 = class2.method_14();
					array[i] = new SnoItemMod(iattribute_, uint_2, float_, float_2, snoItemAffix);
				}
				ISnoItemMod[] mods = array;
				snoItemAffix.Mods = mods;
			}
		}
		string[] array2 = SnoResourceHelper.GetItems().Split('\n');
		int num6 = 0;
		while (num6 < array2.Length)
		{
			string text2 = array2[num6];
			num6++;
			if (text2.StartsWith(" //", ignoreCase: false, CultureInfo.InvariantCulture))
			{
				text2 = text2.Replace(" // ", "");
			}
			int num7 = text2.IndexOf(";");
			if (num7 >= 0)
			{
				if (num7 == 0)
				{
					continue;
				}
				text2 = text2.Substring(0, num7);
			}
			if (string.IsNullOrEmpty(text2))
			{
				continue;
			}
			if (text2.EndsWith("\r"))
			{
				text2 = text2.Substring(0, text2.Length - 1);
			}
			string[] array3 = text2.Split('\t');
			uint uint_3 = uint.Parse(array3[0], CultureInfo.InvariantCulture);
			ActorSnoEnum actorSnoEnum = (ActorSnoEnum)uint.Parse(array3[1], CultureInfo.InvariantCulture);
			int int_ = int.Parse(array3[2], CultureInfo.InvariantCulture);
			dictionary_2.TryGetValue(array3[3], out var value2);
			uint uint_4 = uint.Parse(array3[4], CultureInfo.InvariantCulture);
			uint uint_5 = uint.Parse(array3[5], CultureInfo.InvariantCulture);
			uint uint_6 = uint.Parse(array3[6], CultureInfo.InvariantCulture);
			uint uint_7 = uint.Parse(array3[7], CultureInfo.InvariantCulture);
			int int_2 = int.Parse(array3[8], CultureInfo.InvariantCulture);
			int int_3 = int.Parse(array3[9], CultureInfo.InvariantCulture);
			int int_4 = int.Parse(array3[10], CultureInfo.InvariantCulture);
			int int_5 = int.Parse(array3[11], CultureInfo.InvariantCulture);
			int int_6 = int.Parse(array3[13], CultureInfo.InvariantCulture);
			int int_7 = int.Parse(array3[14], CultureInfo.InvariantCulture);
			string text3 = array3[15];
			string text4 = SnoData.Strings.GetStringByCode(StringListSnoEnum._items, text3) ?? text3;
			if (text4.Contains("’"))
			{
				text4 = text4.Replace("’", "'");
			}
			string string_ = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._items, text3) ?? text3;
			string string_2 = array3[17].ToLower(CultureInfo.InvariantCulture);
			ItemLocation itemLocation_ = ((array3[18] != "-" && array3[18] != "") ? ((ItemLocation)Enum.Parse(typeof(ItemLocation), array3[18], ignoreCase: true)) : ItemLocation.Floor);
			ItemLocation itemLocation_2 = ((array3[19] != "-" && array3[19] != "") ? ((ItemLocation)Enum.Parse(typeof(ItemLocation), array3[19], ignoreCase: true)) : ItemLocation.Floor);
			string[] array4 = array3[20].ToLower(CultureInfo.InvariantCulture).Split('|');
			if (array4 != null && array4.Length > 1)
			{
				Array.Sort(array4);
			}
			int num8 = int.Parse(array3[21], CultureInfo.InvariantCulture);
			int num9 = int.Parse(array3[22], CultureInfo.InvariantCulture);
			int int_8 = int.Parse(array3[23], CultureInfo.InvariantCulture);
			int int_9 = int.Parse(array3[24], CultureInfo.InvariantCulture);
			int int_10 = int.Parse(array3[25], CultureInfo.InvariantCulture);
			int int_11 = int.Parse(array3[26], CultureInfo.InvariantCulture);
			int int_12 = int.Parse(array3[27], CultureInfo.InvariantCulture);
			int int_13 = int.Parse(array3[28], CultureInfo.InvariantCulture);
			int int_14 = int.Parse(array3[29], CultureInfo.InvariantCulture);
			ItemCraftQuality itemCraftQuality_ = (ItemCraftQuality)Enum.Parse(typeof(ItemCraftQuality), array3[30], ignoreCase: true);
			SnoActor snoActor = SnoData.Actors.GetActor(actorSnoEnum);
			if (snoActor == null)
			{
				snoActor = new SnoActor(actorSnoEnum, ActorType.Invalid, ActorKind.None, bool_1: false, "dummyactor-" + text3, "dummyactor-" + text3, "dummyactor-" + text3);
				SnoData.Actors.dictionary_0.Add(actorSnoEnum, snoActor);
			}
			SnoItem snoItem = new SnoItem(uint_3, uint_4, uint_5, snoActor, uint_6, uint_7, int_, value2, int_2, int_3, int_4, int_5, int_6, int_7, text3, text4, string_, string_2, array4, itemLocation_, itemLocation_2, int_8, int_9, int_10, int_11, int_12, int_13, int_14, itemCraftQuality_);
			dictionary_0.Add(snoItem.Sno, snoItem);
			if (num8 > 0)
			{
				ISnoItemAffixGroupLink[] affixGroups = new SnoItemAffixGroupLink[num8];
				snoItem.AffixGroups = affixGroups;
				for (int j = 0; j < num8; j++)
				{
					text2 = array2[num6];
					num6++;
					if (text2.EndsWith("\r"))
					{
						text2 = text2.Substring(0, text2.Length - 1);
					}
					array3 = text2.Split('\t');
					uint sno = uint.Parse(array3[1], CultureInfo.InvariantCulture);
					ISnoItemAffixGroup snoItemAffixGroup3 = GetSnoItemAffixGroup(sno);
					int int_15 = int.Parse(array3[2], CultureInfo.InvariantCulture);
					int int_16 = int.Parse(array3[3], CultureInfo.InvariantCulture);
					snoItem.AffixGroups[j] = new SnoItemAffixGroupLink(snoItemAffixGroup3, int_15, int_16);
				}
			}
			if (num9 <= 0)
			{
				continue;
			}
			ISnoItemMod[] mods = new SnoItemMod[num9];
			snoItem.Mods = mods;
			for (int k = 0; k < num9; k++)
			{
				text2 = array2[num6];
				num6++;
				if (text2.EndsWith("\r"))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				array3 = text2.Split('\t');
				string code2 = array3[1];
				AcdAttribute attributeByCode = SnoData.Attributes.GetAttributeByCode(code2);
				uint uint_8 = uint.Parse(array3[2], CultureInfo.InvariantCulture);
				float float_3 = float.Parse(array3[3], CultureInfo.InvariantCulture);
				float float_4 = float.Parse(array3[4], CultureInfo.InvariantCulture);
				snoItem.Mods[k] = new SnoItemMod(attributeByCode, uint_8, float_3, float_4, null);
			}
		}
		array2 = SnoResourceHelper.GetKanaiItems().Split('\n');
		num6 = 0;
		while (num6 < array2.Length)
		{
			string text5 = array2[num6].Trim();
			num6++;
			if (string.IsNullOrWhiteSpace(text5))
			{
				continue;
			}
			if (text5.EndsWith("\r"))
			{
				text5 = text5.Substring(0, text5.Length - 1);
			}
			if (string.IsNullOrWhiteSpace(text5) || text5.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture))
			{
				continue;
			}
			bool flag = false;
			foreach (ISnoItem value3 in dictionary_0.Values)
			{
				if (value3.NameEnglish.Equals(text5, StringComparison.InvariantCultureIgnoreCase))
				{
					_ = (value3 as SnoItem).CanKanaiCube;
					(value3 as SnoItem).CanKanaiCube = true;
					flag = true;
				}
			}
			if (!flag)
			{
				Trace.WriteLine("unknown item for kanai db: " + text5);
			}
		}
		using DataReader class3 = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_item_socketed_effects.bin")));
		while (class3.Stream.Position < class3.Stream.Length)
		{
			uint sno2 = class3.method_8();
			uint sno3 = class3.method_8();
			int num10 = class3.method_11();
			ISnoItem bySno = GetBySno(sno2);
			if (bySno.SocketedEffects == null)
			{
				bySno.SocketedEffects = new List<ISnoSocketedEffect>();
			}
			ISnoItemMod[] array5 = new ISnoItemMod[num10];
			for (int l = 0; l < num10; l++)
			{
				int index = class3.method_11();
				AcdAttribute iattribute_2 = SnoData.Attributes.ByIndex[index];
				uint uint_9 = class3.method_8();
				float float_5 = class3.method_14();
				float float_6 = class3.method_14();
				array5[l] = new SnoItemMod(iattribute_2, uint_9, float_5, float_6, null);
			}
			SnoSocketedEffect item = new SnoSocketedEffect(GetSnoItemType(sno3), array5);
			bySno.SocketedEffects.Add(item);
		}
	}
}
