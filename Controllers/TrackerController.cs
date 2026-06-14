using Plugins;
using work;

internal class TrackerController : ITrackerController
{
	public IStatTracker Session => CoreCollector.class340_0;

	public IStatTracker SessionAlwaysRunning => CoreCollector.class340_1;

	public IStatTracker CurrentAccountTotal
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.class209_0.class340_0;
			}
			return CoreCollector.class340_2;
		}
	}

	public IStatTracker CurrentAccountLastMonth
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.class209_0.class340_1;
			}
			return null;
		}
	}

	public IStatTracker CurrentAccountLastWeek
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.class209_0.class340_2;
			}
			return null;
		}
	}

	public IStatTracker CurrentAccountYesterday
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.class209_0.class340_3;
			}
			return CoreCollector.class340_3;
		}
	}

	public IStatTracker CurrentAccountToday
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.class209_0.class340_4;
			}
			return CoreCollector.class340_4;
		}
	}
}
