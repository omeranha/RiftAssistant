using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;

namespace work;

public class Hero
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly HeroClassDefinition iheroClassDefinition_0;

	[CompilerGenerated]
	private readonly ulong ulong_0;

	[CompilerGenerated]
	private readonly ulong ulong_1;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly int int_4;

	[CompilerGenerated]
	private readonly bool bool_2;

	[CompilerGenerated]
	private readonly DateTime dateTime_0;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private DateTime dateTime_1 = DateTime.MinValue;

	[CompilerGenerated]
	private SnoQuestStep isnoQuestStep_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string BattleTag
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public HeroClassDefinition ClassDefinition
	{
		[CompilerGenerated]
		get
		{
			return iheroClassDefinition_0;
		}
	}

	public ulong AccountIdHi
	{
		[CompilerGenerated]
		get
		{
			return ulong_0;
		}
	}

	public ulong AccountIdLo
	{
		[CompilerGenerated]
		get
		{
			return ulong_1;
		}
	}

	public int Flags
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int ParagonLevel
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int PlayedSeconds
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public bool Hardcore
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public bool IsMale
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	public int Season
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
	}

	public bool Seasonal
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
	}

	public DateTime CreatedDT
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
	}

	public long LastPlayed
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

	public DateTime LastPlayedDT
	{
		[CompilerGenerated]
		get
		{
			return dateTime_1;
		}
		[CompilerGenerated]
		set
		{
			dateTime_1 = value;
		}
	}

	public SnoQuestStep QuestStep
	{
		[CompilerGenerated]
		get
		{
			return isnoQuestStep_0;
		}
		[CompilerGenerated]
		set
		{
			isnoQuestStep_0 = value;
		}
	}

	public Hero(uint uint_1, string string_2, string string_3, uint uint_2, long long_1, bool bool_3, bool bool_4, int int_5, bool bool_5, ulong ulong_2, ulong ulong_3)
	{
		uint_0 = uint_1;
		string_0 = string_2;
		string_1 = string_3;
		iheroClassDefinition_0 = SnoData.Classes.GetHeroClassByInternalIndex(uint_2);
		dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(long_1 / 1000).ToLocalTime();
		bool_0 = bool_3;
		bool_1 = bool_4;
		int_4 = int_5;
		bool_2 = bool_5;
		ulong_0 = ulong_2;
		ulong_1 = ulong_3;
	}
}
