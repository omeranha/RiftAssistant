using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoItemAffix
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly uint uint_1;

	[CompilerGenerated]
	private readonly SnoItemAffixGroup isnoItemAffixGroup_0;

	[CompilerGenerated]
	private readonly SnoItemAffixGroup isnoItemAffixGroup_1;

	[CompilerGenerated]
	private SnoItemMod[] isnoItemMod_0;

	[CompilerGenerated]
	private readonly HeroClass heroClass_0;

	[CompilerGenerated]
	private bool bool_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public uint BaseAffixId
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
	}

	public SnoItemAffixGroup SnoAffixGroup1
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_0;
		}
	}

	public SnoItemAffixGroup SnoAffixGroup2
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_1;
		}
	}

	public SnoItemMod[] Mods
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

	public HeroClass HeroClass
	{
		[CompilerGenerated]
		get
		{
			return heroClass_0;
		}
	}

	public bool Minor
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

	internal SnoItemAffix(uint uint_2, string string_2, string string_3, uint uint_3, SnoItemAffixGroup isnoItemAffixGroup_2, SnoItemAffixGroup isnoItemAffixGroup_3, HeroClass heroClass_1, bool bool_1)
	{
		uint_0 = uint_2;
		string_0 = string_2;
		string_1 = string_3;
		uint_1 = uint_3;
		isnoItemAffixGroup_0 = isnoItemAffixGroup_2;
		isnoItemAffixGroup_1 = isnoItemAffixGroup_3;
		heroClass_0 = heroClass_1;
		Minor = bool_1;
	}

	public override string ToString()
	{
		string text = NameLocalized;
		SnoItemMod[] mods = Mods;
		foreach (SnoItemMod snoItemMod in mods)
		{
			text = text + " & " + snoItemMod.ToString();
		}
		return text;
	}
}
