using Plugins;


public class TrackerController
{
	public StatTracker Session => CoreCollector.class340_0;

	public StatTracker SessionAlwaysRunning => CoreCollector.class340_1;

	public StatTracker CurrentAccountTotal
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

	public StatTracker CurrentAccountLastMonth
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

	public StatTracker CurrentAccountLastWeek
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

	public StatTracker CurrentAccountYesterday
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

	public StatTracker CurrentAccountToday
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
