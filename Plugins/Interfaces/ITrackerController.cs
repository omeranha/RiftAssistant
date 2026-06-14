namespace Plugins;

public interface ITrackerController
{
	IStatTracker Session { get; }

	IStatTracker SessionAlwaysRunning { get; }

	IStatTracker CurrentAccountTotal { get; }

	IStatTracker CurrentAccountLastMonth { get; }

	IStatTracker CurrentAccountLastWeek { get; }

	IStatTracker CurrentAccountYesterday { get; }

	IStatTracker CurrentAccountToday { get; }
}
