using System.Linq;

namespace RiftAssistant.Controllers;

public class GameController
{
	public GameDifficulty GameDifficulty => CoreCollector.Unknown;

	public long CurrentRealTimeMilliseconds => CoreCollector.CurrentRealTimeTicks / 10000;

	public int CurrentGameTick => CoreCollector.D3Memory.GameTick;

	public bool IsLoading => CoreCollector.IsLoading;

	public bool IsPaused => CoreCollector.D3Memory.GameState_Paused_Value != 0;

	public bool IsInGame => CoreCollector.IsGameReady;

	public bool IsInTown => CoreCollector.IsInTown;

	public MapMode MapMode => Overlay.Instance.ActiveMapMode;

	public string ServerIpAddress => CoreCollector.GameServerIP;

	public SpecialArea SpecialArea => CoreCollector.CurrentSpecialArea;

	public double RiftPercentage => (double)(CoreCollector.D3Memory.GameState_RiftProgressAccumulated_Value / CoreCollector.D3Memory.MaxQuestProgress) * 100.0;

	public double CurrentQuestProgress => CoreCollector.D3Memory.GameState_RiftProgressAccumulated_Value;

	public double MaxQuestProgress => CoreCollector.D3Memory.MaxQuestProgress;

	public int CurrentTimedEventStartTick => CoreCollector.D3Memory.CurrentTimedEventStartTick;

	public int CurrentTimedEventEndTick => CoreCollector.D3Memory.CurrentTimedEventEndTick;

	public int CurrentTimedEventEndTickMod => CoreCollector.D3Memory.CurrentTimedEventEndTickMod;

	public double AverageLatency => CoreCollector.D3Memory.AverageLatency;

	public double CurrentLatency => CoreCollector.D3Memory.CurrentLatency;

	public int CurrentAct => (CoreCollector.LocalPlayer?.SnoArea?.Act).GetValueOrDefault();

	public Player Me => CoreCollector.LocalPlayer;

	public Quest[] Quests => [.. CoreCollector.QuestManager.Quests.Values];

	public Quest[] Bounties => [.. CoreCollector.QuestManager.Bounties.Values];

	public Item[] Items => [.. CoreCollector.ItemCollector.Items.Values];

	public Player[] Players => [.. CoreCollector.PlayerCollector.PlayersInGame];

	public HeadStone[] HeadStones => [.. CoreCollector.ActorCollector.HeadStones.Where((HeadStone iheadStone_0) => iheadStone_0.Player != null)];

	public int NumberOfPlayersInGame => CoreCollector.PlayerCollector.NumberOfPlayersInGame;

	public bool IsEliteOnScreen => CoreCollector.ActorCollector.IsEliteOnScreen;

	public bool IsEliteNearby => CoreCollector.ActorCollector.IsEliteNearby;

	public bool IsGoblinOnScreen => CoreCollector.ActorCollector.IsGoblinOnScreen;

	public MonsterPriority MaxPriorityOnScreen => CoreCollector.ActorCollector.MonsterPriority_0;

	public Actor[] Actors => CoreCollector.actorsSnapshot;

	public Monster[] Monsters => [.. CoreCollector.ActorCollector.Monsters];

	public Monster[] AliveMonsters => [.. CoreCollector.ActorCollector.AliveMonsters];

	public MonsterPack[] MonsterPacks => [.. CoreCollector.ActorCollector.MonsterPacks];

	public Shrine[] Shrines => [.. CoreCollector.ActorCollector.Shrines];

	public Portal[] Portals => CoreCollector.portalsSnapshot;

	public IClickableActor[] NormalChests => CoreCollector.NormalChestsSnapshot;

	public IClickableActor[] ResplendentChests => CoreCollector.ResplendentChestsSnapshot;

	public IClickableActor[] Doors => [.. CoreCollector.ActorCollector.Doors];

	public SceneHint[] SceneHints => [.. CoreCollector.SceneCollector.SceneHints];

	public Banner[] Banners => [.. CoreCollector.MarkerCollector.Banners];

	public Marker[] Markers => [.. CoreCollector.MarkerCollector.Markers];

	public Waypoint[] ActMapWaypoints => [.. CoreCollector.WaypointManager.MapWaypoints.Values];

	public BountyAct ActMapCurrentAct => CoreCollector.D3Memory.ActMapCurrentAct;

	public int InventorySpaceUsed => CoreCollector.ItemCollector.InventorySpaceUsed;

	public double ExperiencePerHourToday => CoreCollector.CurrentHeroToday.GainedExperiencePerHourPlay;

	public Monster SelectedMonster1 => CoreCollector.ActorCollector.IMonster_0;

	public Monster SelectedMonster2 => CoreCollector.ActorCollector.IMonster_1;

	public Actor SelectedActor => CoreCollector.ActorCollector.IActor_0;

	public IStatTracker CurrentAccountTotalOnCurrentDifficulty => CoreCollector.CurrentAccountTotalOnCurrentDifficulty;

	public IStatTracker CurrentAccountYesterdayOnCurrentDifficulty => CoreCollector.CurrentAccountYesterdayOnCurrentDifficulty;

	public IStatTracker CurrentAccountTodayOnCurrentDifficulty => CoreCollector.CurrentAccountTodayOnCurrentDifficulty;

	public IStatTracker CurrentHeroTotal => CoreCollector.CurrentHeroTotal;

	public IStatTracker CurrentHeroYesterday => CoreCollector.CurrentHeroYesterday;

	public IStatTracker CurrentHeroToday => CoreCollector.CurrentHeroToday;

	public IStatTracker CurrentHeroTotalOnCurrentDifficulty => CoreCollector.CurrentHeroTotalOnCurrentDifficulty;

	public IStatTracker CurrentHeroYesterdayOnCurrentDifficulty => CoreCollector.CurrentHeroYesterdayOnCurrentDifficulty;

	public IStatTracker CurrentHeroTodayOnCurrentDifficulty => CoreCollector.CurrentHeroTodayOnCurrentDifficulty;

	public GameController()
	{
	}
}
