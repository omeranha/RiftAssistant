namespace RiftAssistant.Controllers;

public class TrackerController
{
	public IStatTracker Session => CoreCollector.Session;

	public IStatTracker SessionAlwaysRunning => CoreCollector.SessionAlwaysRunning;

	public IStatTracker CurrentAccountTotal
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

	public IStatTracker CurrentAccountLastMonth
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

	public IStatTracker CurrentAccountLastWeek
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

	public IStatTracker CurrentAccountYesterday
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

	public IStatTracker CurrentAccountToday
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
