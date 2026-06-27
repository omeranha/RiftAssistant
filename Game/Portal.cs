using System.Diagnostics;
using Plugins;
using SNO;

public class Portal(uint uint_8, uint uint_9, SnoActor SnoActor_1, SnoArea isnoArea_1, uint uint_10) : Actor(uint_8, uint_9, SnoActor_1)
{
	public SnoArea TargetArea { get; set; } = isnoArea_1;

	public uint TargetWorldId { get; set; } = uint_10;

	public bool ActorAvailable { get; set; }

	public Stopwatch ActorLastAvailable { get; set; } = new();
}
