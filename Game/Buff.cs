using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

internal class Buff : IBuff
{
	[CompilerGenerated]
	private readonly IPlayer iplayer_0;

	[CompilerGenerated]
	private readonly ISnoPower isnoPower_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private readonly int[] int_0 = new int[32];

	[CompilerGenerated]
	private readonly double[] double_0 = new double[32];

	[CompilerGenerated]
	private readonly double[] double_1 = new double[32];

	public IPlayer Player
	{
		[CompilerGenerated]
		get
		{
			return iplayer_0;
		}
	}

	public ISnoPower SnoPower
	{
		[CompilerGenerated]
		get
		{
			return isnoPower_0;
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

	public Buff(IPlayer iplayer_1, ISnoPower isnoPower_1)
	{
		iplayer_0 = iplayer_1;
		isnoPower_0 = isnoPower_1;
	}
}
