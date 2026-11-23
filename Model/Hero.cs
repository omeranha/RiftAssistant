using System;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public class Hero
{
	[CompilerGenerated]
	private readonly uint id;

	[CompilerGenerated]
	private readonly string name;

	[CompilerGenerated]
	private readonly string battleTag;

	[CompilerGenerated]
	private readonly HeroClassDefinition iheroClassDefinition_0;

	[CompilerGenerated]
	private readonly ulong accountIdHi;

	[CompilerGenerated]
	private readonly ulong accountIdLo;

	[CompilerGenerated]
	private int flags;

	[CompilerGenerated]
	private int level;

	[CompilerGenerated]
	private int paragonLevel;

	[CompilerGenerated]
	private int playedSeconds;

	[CompilerGenerated]
	private readonly bool hardcore;

	[CompilerGenerated]
	private readonly bool isMale;

	[CompilerGenerated]
	private readonly int season;

	[CompilerGenerated]
	private readonly bool seasonal;

	[CompilerGenerated]
	private readonly DateTime createdDT;

	[CompilerGenerated]
	private long lastPlayed;

	[CompilerGenerated]
	private DateTime lastPlayedDT = DateTime.MinValue;

	[CompilerGenerated]
	private SnoQuestStep isnoQuestStep_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return id;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return name;
		}
	}

	public string BattleTag
	{
		[CompilerGenerated]
		get
		{
			return battleTag;
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
			return accountIdHi;
		}
	}

	public ulong AccountIdLo
	{
		[CompilerGenerated]
		get
		{
			return accountIdLo;
		}
	}

	public int Flags
	{
		[CompilerGenerated]
		get
		{
			return flags;
		}
		[CompilerGenerated]
		set
		{
			flags = value;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return level;
		}
		[CompilerGenerated]
		set
		{
			level = value;
		}
	}

	public int ParagonLevel
	{
		[CompilerGenerated]
		get
		{
			return paragonLevel;
		}
		[CompilerGenerated]
		set
		{
			paragonLevel = value;
		}
	}

	public int PlayedSeconds
	{
		[CompilerGenerated]
		get
		{
			return playedSeconds;
		}
		[CompilerGenerated]
		set
		{
			playedSeconds = value;
		}
	}

	public bool Hardcore
	{
		[CompilerGenerated]
		get
		{
			return hardcore;
		}
	}

	public bool IsMale
	{
		[CompilerGenerated]
		get
		{
			return isMale;
		}
	}

	public int Season
	{
		[CompilerGenerated]
		get
		{
			return season;
		}
	}

	public bool Seasonal
	{
		[CompilerGenerated]
		get
		{
			return seasonal;
		}
	}

	public DateTime CreatedDT
	{
		[CompilerGenerated]
		get
		{
			return createdDT;
		}
	}

	public long LastPlayed
	{
		[CompilerGenerated]
		get
		{
			return lastPlayed;
		}
		[CompilerGenerated]
		set
		{
			lastPlayed = value;
		}
	}

	public DateTime LastPlayedDT
	{
		[CompilerGenerated]
		get
		{
			return lastPlayedDT;
		}
		[CompilerGenerated]
		set
		{
			lastPlayedDT = value;
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

	public Hero(uint uint_1, string string_2, string string_3, uint uint_2, long long_1, bool bool_3, bool bool_4, int season2, bool bool_5, ulong ulong_2, ulong ulong_3)
	{
		id = uint_1;
		name = string_2;
		battleTag = string_3;
		iheroClassDefinition_0 = SnoData.Classes.GetHeroClassByInternalIndex(uint_2);
		createdDT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(long_1 / 1000).ToLocalTime();
		hardcore = bool_3;
		isMale = bool_4;
		season = season2;
		seasonal = bool_5;
		accountIdHi = ulong_2;
		accountIdLo = ulong_3;
	}
}
