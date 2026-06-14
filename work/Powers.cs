using SNO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

public sealed class Powers
{
	[CompilerGenerated]
	private readonly byte[] byte_0;

	private readonly Dictionary<uint, ISnoPower> dictionary_0 = [];

	private readonly Dictionary<string, ISnoPower> dictionary_1 = [];

	private readonly Dictionary<ulong, (int, uint)>[] dictionary_2 =
	[
		[],
		[],
		[],
		[],
		[]
	];

	private readonly Dictionary<ulong, int>[] dictionary_3 =
	[
		[],
		[],
		[],
		[],
		[]
	];

	private readonly List<float[]> list_0 = [];

	private static readonly int[] int_0 = new int[6];

	private readonly int int_1 = "TAG_POWER_BUFF_".Length;

	public byte[] FormulaData
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	public IEnumerable<ISnoPower> All => dictionary_1.Values;

	public ISnoPower GetBySno(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	public ISnoPower GetByCode(string code)
	{
		dictionary_1.TryGetValue(code, out var value);
		return value;
	}

	public (int, uint)? GetTagValue(int index, ulong key)
	{
		if (dictionary_2[index].TryGetValue(key, out var value)) {
			return value;
		}
		return null;
	}

	public int? GetTagFormula(int index, ulong key)
	{
		if (dictionary_3[index].TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public float[] GetFormulaTable(int index)
	{
		return list_0[index];
	}

	public void ClearFormulaTable()
	{
		list_0.Clear();
	}

	public int FormulaTableCount()
	{
		return list_0.Count;
	}

	public void AddFormulaTable(float[] table)
	{
		list_0.Add(table);
	}

	internal Powers()
	{
		byte_0 = File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "power_formula_data.bin"));
		using (MemoryStream stream_ = new(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_power_formulas.bin"))))
		{
			DataReader @class = new(stream_);
			while (@class.Stream.Position < @class.Stream.Length)
			{
				@class.method_1();
				int num = @class.method_11();
				float[] array = new float[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = @class.method_14();
				}
				list_0.Add(array);
			}
		}
		List<SnoPower> list = [];
		using (DataReader class2 = new(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "powers.bin"))))
		{
			while (class2.Stream.Position < class2.Stream.Length)
			{
				uint num2 = class2.method_8();
				string text = class2.method_1();
				string text2 = SnoData.Strings.GetStringByCode(StringListSnoEnum._powers, text + "_name");
				if (string.IsNullOrEmpty(text2))
				{
					text2 = null;
				}
				string text3 = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._powers, text + "_name");
				if (string.IsNullOrEmpty(text3))
				{
				 text3 = null;
				}
				SnoPower class3 = Create(text, text2, text3, num2);
				for (int j = 0; j < 32; j++)
				{
					string text4 = text + "_" + j.ToString("D", CultureInfo.InvariantCulture);
					string stringByCode = SnoData.Strings.GetStringByCode(StringListSnoEnum._bufftooltips, text4);
					if (!string.IsNullOrEmpty(stringByCode))
					{
						stringByCode = SnoData.smethod_2(stringByCode);
						if (!string.IsNullOrEmpty(stringByCode))
						{
							class3.Icons[j].Exists = true;
							class3.Icons[j].TitleLocalized = stringByCode;
							class3.Icons[j].DescriptionLocalized = SnoData.smethod_2(SnoData.Strings.GetStringByCode(StringListSnoEnum._bufftooltips, text4 + "_desc"));
						}
					}
				}
				bool flag = true;
				for (int k = 0; k < 5; k++)
				{
					int num3 = class2.method_11();
					for (int l = 0; l < num3; l++)
					{
						int num4 = class2.method_6();
						uint num5 = class2.method_8();
						if (num4 != 4)
						{
							uint num6 = class2.method_8();
							if (flag)
							{
								dictionary_2[k].Add(((ulong)num2 << 32) + num5, (num4, num6));
							}
							if (num5 == 329472)
							{
								class3.NormalIconTextureId = num6;
							}
							if (num5 >= 270592 && num5 <= 270641 && num6 != 0)
							{
								class3.Icons[GetNumberFromTag(num5)].TextureId = num6;
							}
							if (num5 >= 271616 && num5 <= 271665)
							{
								class3.Icons[GetNumberFromTag(num5)].IsHidden = num6 == 0;
							}
							if (num5 >= 270848 && num5 <= 270897)
							{
								class3.Icons[GetNumberFromTag(num5)].Harmful = num6 == 1;
							}
							if (num5 >= 271104 && num5 <= 271153)
							{
								class3.Icons[GetNumberFromTag(num5)].ShowDuration = num6 == 1;
							}
							if (num5 >= 271360 && num5 <= 271409)
							{
								class3.Icons[GetNumberFromTag(num5)].UserCanCancel = num6 == 1;
							}
							if (num5 >= 271872 && num5 <= 271921)
							{
								class3.Icons[GetNumberFromTag(num5)].MergesTooltip = num6 == 1;
							}
							if (num5 >= 272128 && num5 <= 272177)
							{
								class3.Icons[GetNumberFromTag(num5)].MergesTooltipIndex = num6;
							}
							if (num5 >= 272640 && num5 <= 272671)
							{
								class3.Icons[GetNumberFromTag(num5)].ShowActiveOnSkillButton = num6 == 1;
							}
							if (num5 >= 274432 && num5 <= 274463)
							{
								class3.Icons[GetNumberFromTag(num5)].ShowInBuffHolder = num6 == 1;
							}
							if (num5 >= 274688 && num5 <= 274719)
							{
								class3.Icons[GetNumberFromTag(num5)].ShowDurationOnSkillButton = num6 == 1;
							}
							if (num5 >= 721264 && num5 <= 721269 && class3.ElementalDamageTypesByRune != null)
							{
								class3.ElementalDamageTypesByRune[num5 - 721264] = (int)num6;
							}
							if (num5 == 327764)
							{
								class3.sno = num6;
								list.Add(class3);
							}
						}
						else
						{
							int value = class2.method_11();
							if (flag)
							{
								dictionary_3[k].Add(((ulong)num2 << 32) + num5, value);
							}
						}
					}
				}
			}
		}
		foreach (SnoPower item in list)
		{
			item.SynergyPower = GetBySno(item.sno);
		}
		string[] array2 = SnoResourceHelper.GetPowerStats().Split('\n');
		int num7 = 0;
		while (num7 < array2.Length)
		{
			string text5 = array2[num7];
			num7++;
			if (!text5.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text5))
			{
				string[] array3 = text5.Split('\t');
				ISnoPower bySno = GetBySno(uint.Parse(array3[0]));
				if (bySno != null)
				{
					int num8 = int.Parse(array3[1]);
					(bySno as SnoPower).HasKnownRunesValues = true;
					bySno.WeaponDamageMultipliersByRune[num8] = int.Parse(array3[2]);
					bySno.DotSecondsByRune[num8] = int.Parse(array3[3]);
					bySno.ResourceCostsByRune[num8] = int.Parse(array3[4]);
					bySno.ResourceCostTypeByRune[num8] = Enum.Parse<PowerResourceCostType>(array3[5], ignoreCase: true);
					bySno.BaseCoolDownByRune[num8] = double.Parse(array3[6], CultureInfo.InvariantCulture);
				}
			}
		}
		array2 = SnoResourceHelper.GetPowerRuneIconOverrides().Split('\n');
		num7 = 0;
		while (num7 < array2.Length)
		{
			string text6 = array2[num7];
			num7++;
			if (!text6.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text6))
			{
				string[] array4 = text6.Split('\t');
				ISnoPower bySno2 = GetBySno(uint.Parse(array4[0]));
				int num9 = int.Parse(array4[1]);
				bySno2.IconIndexes[num9] = int.Parse(array4[2]);
			}
		}
	}

	private int GetNumberFromTag(uint key)
	{
		if (!SnoData.GeneralTagMapEntries.TryGetValue(key, out var value))
			throw new KeyNotFoundException($"Key {key} not found.");

		int endIndex = value.IndexOf('_', int_1);
		if (endIndex < 0)
			throw new FormatException($"Invalid format: {value}");

		var slice = value[int_1..endIndex];

		if (!int.TryParse(slice, out var result))
			throw new FormatException($"Invalid number: {slice}");

		return result;
	}

	private SnoPower Create(string code, string name, string category, uint snoId)
	{
		string localizedDesc =
			SnoData.smethod_2(SnoData.Strings.GetStringByCode(code + "_simple_desc")) ??
			SnoData.smethod_2(SnoData.Strings.GetStringByCode(code + "_desc")) ??
			SnoData.smethod_2(SnoData.Strings.GetStringByCode(code));

		string englishDesc =
			SnoData.smethod_2(SnoData.Strings.GetStringByCodeEnglish(code + "_simple_desc")) ??
			SnoData.smethod_2(SnoData.Strings.GetStringByCodeEnglish(code + "_desc")) ??
			SnoData.smethod_2(SnoData.Strings.GetStringByCodeEnglish(code));

		var power = new SnoPower(snoId, code, name, category, localizedDesc, englishDesc);
		dictionary_0[snoId] = power;
		dictionary_1[code] = power;

		var runeLetters = new[] { "A", "B", "C", "D", "E" };
		var localizedRunes = new string[5];
		var englishRunes = new string[5];
		bool hasAnyRune = false;
		for (int i = 0; i < runeLetters.Length; i++) {
			string key = $"NameRune_{runeLetters[i]}#{code}";
			localizedRunes[i] = SnoData.smethod_2(SnoData.Strings.GetStringByCode(key));
			englishRunes[i] = SnoData.Strings.GetStringByCodeEnglish(key);

			if (!string.IsNullOrEmpty(localizedRunes[i])) hasAnyRune = true;
		}

		if (!hasAnyRune) {
			power.IconIndexes = int_0;
			return power;
		}

		power.RuneNamesLocalized = localizedRunes;
		power.RuneNamesEnglish = englishRunes;
		power.IconIndexes = new int[6];
		power.ElementalDamageTypesByRune = new int[6];
		power.WeaponDamageMultipliersByRune = new int[6];
		power.DotSecondsByRune = new float[6];
		power.ResourceCostsByRune = new int[6];
		power.ResourceCostTypeByRune = new PowerResourceCostType[6];
		power.BaseCoolDownByRune = new double[6];
		for (int i = 0; i < 6; i++) {
			power.ElementalDamageTypesByRune[i] = -1;
			power.WeaponDamageMultipliersByRune[i] = -1;
			power.DotSecondsByRune[i] = -1f;
			power.ResourceCostsByRune[i] = -1;
			power.BaseCoolDownByRune[i] = -1.0;
		}

		switch (snoId) {
			case 135238:
				for (int i = 0; i < 6; i++) {
					power.ElementalDamageTypesByRune[i] = 5;
					power.WeaponDamageMultipliersByRune[i] = 779;
				}
				break;

			case 167355:
				for (int i = 0; i < 6; i++) {
					power.ElementalDamageTypesByRune[i] = 5;
					power.WeaponDamageMultipliersByRune[i] = 604;
				}
				break;

			case 135166:
				for (int i = 0; i < 6; i++) {
					power.ElementalDamageTypesByRune[i] = 5;
					power.WeaponDamageMultipliersByRune[i] = 790;
				}
				break;
		}
		return power;
	}
}
