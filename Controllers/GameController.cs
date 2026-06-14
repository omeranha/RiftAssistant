using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Plugins;
using work;

internal class GameController : IGameController
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

	public IPlayer Me => CoreCollector.LocalPlayer;

	public IEnumerable<IQuest> Quests => CoreCollector.Class376_0.class112_1.IEnumerable_0;

	public IEnumerable<IQuest> Bounties => CoreCollector.Class376_0.class112_2.IEnumerable_0;

	public IEnumerable<IItem> Items => CoreCollector.ItemCollector.class112_0.IEnumerable_0;

	public IEnumerable<IPlayer> Players => CoreCollector.PlayerCollector.PlayersInGame;

	public IEnumerable<IHeadStone> HeadStones => CoreCollector.ActorCollector.List_1.Where((IHeadStone iheadStone_0) => iheadStone_0.Player != null);

	public int NumberOfPlayersInGame => CoreCollector.PlayerCollector.NumberOfPlayersInGame;

	public bool IsEliteOnScreen => CoreCollector.ActorCollector.Boolean_2;

	public bool IsEliteNearby => CoreCollector.ActorCollector.Boolean_1;

	public bool IsGoblinOnScreen => CoreCollector.ActorCollector.Boolean_3;

	public MonsterPriority MaxPriorityOnScreen => CoreCollector.ActorCollector.MonsterPriority_0;

	public IEnumerable<IActor> Actors => CoreCollector.ActorCollector.list_3;

	public IEnumerable<IMonster> Monsters => CoreCollector.ActorCollector.list_0;

	public IEnumerable<IMonster> AliveMonsters => CoreCollector.ActorCollector.list_1;

	public IEnumerable<IMonsterPack> MonsterPacks => CoreCollector.ActorCollector.list_2;

	public IEnumerable<IShrine> Shrines => CoreCollector.ActorCollector.List_0;

	public IEnumerable<IPortal> Portals => CoreCollector.ActorCollector.Class112_1.IEnumerable_0.Where((IPortal iportal_0) => CoreCollector.LocalPlayer?.SnoArea != null && iportal_0.TargetArea != null && iportal_0.WorldId == CoreCollector.LocalPlayer.WorldId && (iportal_0.ActorAvailable || !CoreCollector.LocalPlayer.SnoArea.Code.StartsWith("x1_lr_level_", ignoreCase: false, CultureInfo.InvariantCulture)));

	public IEnumerable<IClickableActor> NormalChests => from iactor_0 in CoreCollector.ActorCollector.list_3
		where iactor_0.SnoActor.Kind == ActorKind.ChestNormal
		select iactor_0 as IClickableActor;

	public IEnumerable<IClickableActor> ResplendentChests => from iactor_0 in CoreCollector.ActorCollector.list_3
		where iactor_0.SnoActor.Kind == ActorKind.Chest
		select iactor_0 as IClickableActor;

	public IEnumerable<IClickableActor> Doors => CoreCollector.ActorCollector.List_2;

	public IEnumerable<ISceneHint> SceneHints => CoreCollector.SceneCollector.list_0;

	public IEnumerable<IBanner> Banners => CoreCollector.Class412_0.list_2;

	public IEnumerable<IMarker> Markers => CoreCollector.Class412_0.list_0;

	public IEnumerable<IWaypoint> ActMapWaypoints => CoreCollector.WaypointManager.MapWaypoints.Values;

	public BountyAct ActMapCurrentAct => CoreCollector.D3Memory.ActMapCurrentAct;

	public int InventorySpaceUsed => CoreCollector.ItemCollector.int_0;

	public double ExperiencePerHourToday => CoreCollector.class340_7.GainedExperiencePerHourPlay;

	public IMonster SelectedMonster1 => CoreCollector.ActorCollector.IMonster_0;

	public IMonster SelectedMonster2 => CoreCollector.ActorCollector.IMonster_1;

	public IActor SelectedActor => CoreCollector.ActorCollector.IActor_0;

	public IStatTracker CurrentAccountTotalOnCurrentDifficulty => CoreCollector.class340_8;

	public IStatTracker CurrentAccountYesterdayOnCurrentDifficulty => CoreCollector.class340_9;

	public IStatTracker CurrentAccountTodayOnCurrentDifficulty => CoreCollector.class340_10;

	public IStatTracker CurrentHeroTotal => CoreCollector.class340_5;

	public IStatTracker CurrentHeroYesterday => CoreCollector.class340_6;

	public IStatTracker CurrentHeroToday => CoreCollector.class340_7;

	public IStatTracker CurrentHeroTotalOnCurrentDifficulty => CoreCollector.class340_11;

	public IStatTracker CurrentHeroYesterdayOnCurrentDifficulty => CoreCollector.class340_12;

	public IStatTracker CurrentHeroTodayOnCurrentDifficulty => CoreCollector.class340_13;

	public GameController(IController icontroller_0)
	{
	}
}
