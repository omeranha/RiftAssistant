using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public class Buff
{
	[CompilerGenerated]
	private readonly Player iplayer_0;

	[CompilerGenerated]
	private readonly SnoPower snoPower;

	[CompilerGenerated]
	private bool active;

	[CompilerGenerated]
	private readonly int[] iconCounts = new int[32];

	[CompilerGenerated]
	private readonly double[] timeElapsedSeconds = new double[32];

	[CompilerGenerated]
	private readonly double[] timeLeftSeconds = new double[32];

	public Player Player
	{
		[CompilerGenerated]
		get
		{
			return iplayer_0;
		}
	}

	public SnoPower SnoPower
	{
		[CompilerGenerated]
		get
		{
			return snoPower;
		}
	}

	public Stopwatch FirstActive { get; } = new Stopwatch();

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool Active
	{
		[CompilerGenerated]
		get
		{
			return active;
		}
		[CompilerGenerated]
		set
		{
			active = value;
		}
	}

	public int[] IconCounts
	{
		[CompilerGenerated]
		get
		{
			return iconCounts;
		}
	}

	public double[] TimeElapsedSeconds
	{
		[CompilerGenerated]
		get
		{
			return timeElapsedSeconds;
		}
	}

	public double[] TimeLeftSeconds
	{
		[CompilerGenerated]
		get
		{
			return timeLeftSeconds;
		}
	}

	public Buff(Player iplayer_1, SnoPower bySno)
	{
		iplayer_0 = iplayer_1;
		snoPower = bySno;
	}
}
