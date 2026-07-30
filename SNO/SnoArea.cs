using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;


namespace SNO;

public class SnoArea
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
	private readonly AreaType areaType_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_3 = "";

	[CompilerGenerated]
	private SnoWorld isnoWorld_0;

	[CompilerGenerated]
	private readonly uint uint_1;

	public uint Sno
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

	public AreaType Type
	{
		[CompilerGenerated]
		get
		{
			return areaType_0;
		}
	}

	public bool IsRandom
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public bool IsTown
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	public int Act
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string AreaGroupInWorld
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public SnoWorld SnoWorld
	{
		[CompilerGenerated]
		get
		{
			return isnoWorld_0;
		}
		[CompilerGenerated]
		set
		{
			isnoWorld_0 = value;
		}
	}

	public uint HostAreaSno
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
	}

	public SnoArea HostSnoArea => null;

	internal SnoArea(uint uint_2, string string_4, int int_1, string string_5, string string_6, AreaType areaType_1, bool bool_2, string string_7, bool bool_3, uint uint_3)
	{
		uint_0 = uint_2;
		string_0 = string_4;
		int_0 = int_1;
		string_1 = string_5;
		string_2 = string_6;
		areaType_0 = areaType_1;
		bool_0 = bool_2;
		string_3 = string_7;
		bool_1 = bool_3;
		uint_1 = uint_3;
	}
}
