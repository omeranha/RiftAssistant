using System.Diagnostics;

namespace RiftAssistant.Model;

public class Buff
{

	public Player Player { get; }

	public SnoPower SnoPower { get; }

	public Stopwatch FirstActive { get; } = new Stopwatch();

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool Active { get; set; }

	public int[] IconCounts { get; } = new int[32];

	public double[] TimeElapsedSeconds { get; } = new double[32];

	public double[] TimeLeftSeconds { get; } = new double[32];

	public Buff(Player player, SnoPower bySno)
	{
		Player = player;
		SnoPower = bySno;
	}
}
