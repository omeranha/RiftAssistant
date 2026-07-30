using System.Linq;
using Plugins;
using SNO;

public class GameController
{
	public GameDifficulty GameDifficulty => CoreCollector.gameDifficulty_0;

	public long CurrentRealTimeMilliseconds => CoreCollector.CurrentRealTimeTicks / 10000;

	public int CurrentGameTick => CoreCollector.D3Memory.GameTick;

	public bool IsLoading => CoreCollector.IsLoading;

	public bool IsPaused => CoreCollector.D3Memory.GameState_Paused_Value != 0;

	public bool IsInGame => CoreCollector.IsGameReady;

	public bool IsInTown => CoreCollector.IsInTown;

	public MapMode MapMode => Overlay.Instance.mapMode_0;

	public string ServerIpAddress => CoreCollector.GameServerIP;

	public SpecialArea SpecialArea => CoreCollector.specialArea_0;

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

	public Quest[] Quests => [.. CoreCollector.Class376_0.class112_1.IEnumerable_0];

	public Quest[] Bounties => [.. CoreCollector.Class376_0.class112_2.IEnumerable_0];

	public Item[] Items => [.. CoreCollector.ItemCollector.Items.Values];

	public Player[] Players => [.. CoreCollector.PlayerCollector.PlayersInGame];

	public HeadStone[] HeadStones => [.. CoreCollector.ActorCollector.List_1.Where((HeadStone iheadStone_0) => iheadStone_0.Player != null)];

	public int NumberOfPlayersInGame => CoreCollector.PlayerCollector.NumberOfPlayersInGame;

	public bool IsEliteOnScreen => CoreCollector.ActorCollector.Boolean_2;

	public bool IsEliteNearby => CoreCollector.ActorCollector.Boolean_1;

	public bool IsGoblinOnScreen => CoreCollector.ActorCollector.Boolean_3;

	public MonsterPriority MaxPriorityOnScreen => CoreCollector.ActorCollector.MonsterPriority_0;

	public Actor[] Actors => CoreCollector.actorsSnapshot;

	public Monster[] Monsters => [.. CoreCollector.ActorCollector.list_0];

	public Monster[] AliveMonsters => [.. CoreCollector.ActorCollector.list_1];

	public MonsterPack[] MonsterPacks => [.. CoreCollector.ActorCollector.list_2];

	public Shrine[] Shrines => [.. CoreCollector.ActorCollector.List_0];

	public Portal[] Portals => CoreCollector.portalsSnapshot;

	public IClickableActor[] NormalChests => CoreCollector.NormalChestsSnapshot;

	public IClickableActor[] ResplendentChests => CoreCollector.ResplendentChestsSnapshot;

	public IClickableActor[] Doors => [.. CoreCollector.ActorCollector.List_2];

	public SceneHint[] SceneHints => [.. CoreCollector.SceneCollector.list_0];

	public Banner[] Banners => [.. CoreCollector.Class412_0.list_2];

	public Marker[] Markers => [.. CoreCollector.Class412_0.list_0];

	public Waypoint[] ActMapWaypoints => [.. CoreCollector.WaypointManager.MapWaypoints.Values];

	public BountyAct ActMapCurrentAct => CoreCollector.D3Memory.ActMapCurrentAct;

	public int InventorySpaceUsed => CoreCollector.ItemCollector.int_0;

	public double ExperiencePerHourToday => CoreCollector.class340_7.GainedExperiencePerHourPlay;

	public Monster SelectedMonster1 => CoreCollector.ActorCollector.IMonster_0;

	public Monster SelectedMonster2 => CoreCollector.ActorCollector.IMonster_1;

	public Actor SelectedActor => CoreCollector.ActorCollector.IActor_0;

	public StatTracker CurrentAccountTotalOnCurrentDifficulty => CoreCollector.class340_8;

	public StatTracker CurrentAccountYesterdayOnCurrentDifficulty => CoreCollector.class340_9;

	public StatTracker CurrentAccountTodayOnCurrentDifficulty => CoreCollector.class340_10;

	public StatTracker CurrentHeroTotal => CoreCollector.class340_5;

	public StatTracker CurrentHeroYesterday => CoreCollector.class340_6;

	public StatTracker CurrentHeroToday => CoreCollector.class340_7;

	public StatTracker CurrentHeroTotalOnCurrentDifficulty => CoreCollector.class340_11;

	public StatTracker CurrentHeroYesterdayOnCurrentDifficulty => CoreCollector.class340_12;

	public StatTracker CurrentHeroTodayOnCurrentDifficulty => CoreCollector.class340_13;

	public GameController()
	{
	}
}
