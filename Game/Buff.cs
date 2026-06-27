using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

public class Buff
{
	[CompilerGenerated]
	private readonly Player iplayer_0;

	[CompilerGenerated]
	private readonly SnoPower SnoPower_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private readonly int[] int_0 = new int[32];

	[CompilerGenerated]
	private readonly double[] double_0 = new double[32];

	[CompilerGenerated]
	private readonly double[] double_1 = new double[32];

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
			return SnoPower_0;
		}
	}

	public Stopwatch FirstActive { get; } = new Stopwatch();

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool Active
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

	public int[] IconCounts
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public double[] TimeElapsedSeconds
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
	}

	public double[] TimeLeftSeconds
	{
		[CompilerGenerated]
		get
		{
			return double_1;
		}
	}

	public Buff(Player iplayer_1, SnoPower SnoPower_1)
	{
		iplayer_0 = iplayer_1;
		SnoPower_0 = SnoPower_1;
	}
}
