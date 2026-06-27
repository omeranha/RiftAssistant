using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoItemType
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private SnoItemType SnoItemType_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
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

	public SnoItemType ParentSnoType
	{
		[CompilerGenerated]
		get
		{
			return SnoItemType_0;
		}
		[CompilerGenerated]
		set
		{
			SnoItemType_0 = value;
		}
	}

	internal SnoItemType(uint uint_1, string string_3, string string_4, string string_5, SnoItemType SnoItemType_1)
	{
		uint_0 = uint_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
		ParentSnoType = SnoItemType_1;
	}

	public override string ToString()
	{
		return Code;
	}
}
