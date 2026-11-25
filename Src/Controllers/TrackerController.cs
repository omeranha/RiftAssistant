namespace RiftAssistant.Controllers;

public class TrackerController
{
	public IStatTracker Session => CoreCollector.Session;

	public IStatTracker SessionAlwaysRunning => CoreCollector.SessionAlwaysRunning;

	public IStatTracker? CurrentAccountTotal
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.currentAccountTotal;
			}
			return CoreCollector.AccountTotal;
		}
	}

	public IStatTracker? CurrentAccountLastMonth
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.currentAccountLastMonth;
			}
			return null;
		}
	}

	public IStatTracker? CurrentAccountLastWeek
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.currentAccountLastWeek;
			}
			return null;
		}
	}

	public IStatTracker? CurrentAccountYesterday
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.currentAccountYesterday;
			}
			return CoreCollector.AccountYesterday;
		}
	}

	public IStatTracker? CurrentAccountToday
	{
		get
		{
			if (!CoreCollector.IsGameReady)
			{
				return Overlay.Instance.lobbyHeroesModule.currentAccountToday;
			}
			return CoreCollector.AccountToday;
		}
	}
}
