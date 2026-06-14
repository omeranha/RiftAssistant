using SNO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

public sealed class Areas
{
	[CompilerGenerated]
	private readonly ISnoAct[] isnoAct_0 = new ISnoAct[5];

	private readonly Dictionary<uint, ISnoArea> dictionary_0 = new Dictionary<uint, ISnoArea>(500);

	public ISnoAct[] AllActs
	{
		[CompilerGenerated]
		get
		{
			return isnoAct_0;
		}
	}

	public IEnumerable<ISnoArea> AllAreas => dictionary_0.Values;

	public ISnoArea GetSnoArea(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	internal Areas()
	{
		using (DataReader @class = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "acts.bin"))))
		{
			while (@class.Stream.Position < @class.Stream.Length)
			{
				uint uint_ = @class.method_8();
				int num = @class.method_11();
				int num2 = @class.method_11();
				SnoAct snoAct = new SnoAct(uint_, num);
				AllActs[num - 1] = snoAct;
				for (int i = 0; i < num2; i++)
				{
					uint uint_2 = @class.method_8();
					uint uint_3 = @class.method_8();
					snoAct.Waypoints.Add(new SnoActWaypoint(uint_2, uint_3));
				}
			}
		}
		string[] array = SnoResourceHelper.GetLevelAreas().Split('\n');
		foreach (string text in array)
		{
			if (text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) || string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array2 = text.Split('\t');
			uint num3 = uint.Parse(array2[0], CultureInfo.InvariantCulture);
			int int_ = int.Parse(array2[1]);
			string text2 = array2[2];
			string text3 = SnoData.Strings.GetStringByCode(StringListSnoEnum._levelareanames, text2);
			string string_ = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._levelareanames, text2);
			if (text3 != null)
			{
				if (text2 == "A4_dun_Hell_Portal_01" || text2 == "A4_dun_Hell_Portal_02")
				{
					text3 = SnoData.Strings.GetStringByCode(text2 + "_OpenWorld");
					string_ = SnoData.Strings.GetStringByCodeEnglish(text2 + "_OpenWorld");
				}
				if (text2.StartsWith("X1_LR_Level_"))
				{
					text3 = text2.Replace("X1_LR_Level_", "Rift Level ");
					string_ = text2.Replace("X1_LR_Level_", "Rift Level ");
				}
			}
			AreaType areaType_ = (AreaType)Enum.Parse(typeof(AreaType), array2[3], ignoreCase: true);
			bool bool_ = array2[4] == "true";
			string string_2 = array2[5];
			bool bool_2 = array2[6] == "true";
			uint uint_4 = uint.Parse(array2[7], CultureInfo.InvariantCulture);
			SnoArea value = new SnoArea(num3, text2.ToLower(CultureInfo.InvariantCulture), int_, text3, string_, areaType_, bool_, string_2, bool_2, uint_4);
			dictionary_0.Add(num3, value);
		}
	}
}
