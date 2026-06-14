using System.Diagnostics;

namespace Plugins;

public interface IPortal : IActor
{
	ISnoArea TargetArea { get; }

	uint TargetWorldId { get; }

	bool ActorAvailable { get; }

	Stopwatch ActorLastAvailable { get; }
}
