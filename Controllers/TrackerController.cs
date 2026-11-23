namespace RiftAssistant.Controllers;

public class TrackerController
{
	public StatTracker Session => CoreCollector.Session;

	public StatTracker SessionAlwaysRunning => CoreCollector.SessionAlwaysRunning;

	public StatTracker CurrentAccountTotal
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.class340_0;
			}
			return CoreCollector.AccountTotal;
		}
	}

	public StatTracker CurrentAccountLastMonth
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.class340_1;
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
				return Overlay.Instance.lobbyHeroesModule.class340_2;
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
				return Overlay.Instance.lobbyHeroesModule.class340_3;
			}
			return CoreCollector.AccountYesterday;
		}
	}

	public StatTracker CurrentAccountToday
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.class340_4;
			}
			return CoreCollector.AccountToday;
		}
	}
}
