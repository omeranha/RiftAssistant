using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoAct
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly List<SnoQuest> list_0 = new List<SnoQuest>();

	[CompilerGenerated]
	private readonly List<SnoQuest> list_1 = new List<SnoQuest>();

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

	public List<SnoQuest> MainQuests
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public List<SnoQuest> Bounties
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
