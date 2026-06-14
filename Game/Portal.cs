using System.Diagnostics;
using Plugins;

internal class Portal(uint uint_8, uint uint_9, ISnoActor isnoActor_1, ISnoArea isnoArea_1, uint uint_10) : Actor(uint_8, uint_9, isnoActor_1), IActor, IPortal
{
	public ISnoArea TargetArea { get; set; } = isnoArea_1;

	public uint TargetWorldId { get; set; } = uint_10;

	public bool ActorAvailable { get; set; }

	public Stopwatch ActorLastAvailable { get; set; } = new();
}
