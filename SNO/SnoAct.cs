using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoAct : ISnoAct
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly List<ISnoQuest> list_0 = new List<ISnoQuest>();

	[CompilerGenerated]
	private readonly List<ISnoQuest> list_1 = new List<ISnoQuest>();

	[CompilerGenerated]
	private readonly List<SnoActWaypoint> list_2 = new List<SnoActWaypoint>();

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public List<ISnoQuest> MainQuests
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public List<ISnoQuest> Bounties
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
	}

	public List<SnoActWaypoint> Waypoints
	{
		[CompilerGenerated]
		get
		{
			return list_2;
		}
	}

	internal SnoAct(uint uint_1, int int_1)
	{
		uint_0 = uint_1;
		int_0 = int_1;
	}
}
