using System.Diagnostics;

namespace Plugins;

public interface IBuff
{
	IPlayer Player { get; }

	ISnoPower SnoPower { get; }

	Stopwatch FirstActive { get; }

	Stopwatch LastActive { get; }

	bool Active { get; }

	int[] IconCounts { get; }

	double[] TimeElapsedSeconds { get; }

	double[] TimeLeftSeconds { get; }
}
