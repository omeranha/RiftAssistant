#nullable enable annotations
#nullable disable warnings
#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RiftAssistant.Collectors;

internal static class CoreCollector
{
	public static readonly uint Magic_600DF00D;

	public static bool GameStateValid { get; private set; }

	public static bool IsGameReady { get; private set; }

	public static readonly Stopwatch stopwatch0 = new();

	public static Stopwatch stopwatch_1 { get; private set; } = new();

	public static long CurrentRealTimeTicks { get; private set; }

	public static Player LocalPlayer;

	public static bool IsLoading { get; private set; }

	public static bool IsInTown { get; private set; }

	public static string? BattleTag;

	public static GameDifficulty Unknown { get; private set; }

	private static int int_0;

	private const long ScanRetryMilliseconds = 1000;

	private static long nextScanAttempt;

	private static string? lastScanError;

	private static bool hasConnected;

	private static SnoArea? LastSnoArea;

	public static SpecialArea CurrentSpecialArea { get; private set; }

	public static string? GameServerIP { get; private set; }

	public static readonly D3Memory D3Memory;

	public static readonly List<StatTracker> Trackers = [];

	public static readonly StatTracker Session;

	public static readonly StatTracker SessionAlwaysRunning;

	public static StatTracker? AccountTotal { get; private set; }

	public static StatTracker? AccountYesterday { get; private set; }

	public static StatTracker? AccountToday { get; private set; }

	public static StatTracker? CurrentHeroTotal { get; private set; }

	public static StatTracker? CurrentHeroYesterday { get; private set; }

	public static StatTracker? CurrentHeroToday { get; private set; }

	public static StatTracker? CurrentAccountTotalOnCurrentDifficulty { get; private set; }

	public static StatTracker? CurrentAccountYesterdayOnCurrentDifficulty { get; private set; }

	public static StatTracker? CurrentAccountTodayOnCurrentDifficulty { get; private set; }

	public static StatTracker? CurrentHeroTotalOnCurrentDifficulty { get; private set; }

	public static StatTracker? CurrentHeroYesterdayOnCurrentDifficulty { get; private set; }

	public static StatTracker? CurrentHeroTodayOnCurrentDifficulty { get; private set; }

	public static RunTracker? RunTracker { get; private set; }

	public static Controller Controller { get; set; }

	public static EventHandler<Skill> OnTrueCooldown { get; set; }

	public static EventHandler<Skill> OnCooldown { get; set; }

	public static EventHandler OnNewArea { get; set; }

	public static EventHandler GameStateReset { get; set; }

	public static EventHandler<SnoArea> OnFalseNewArea { get; set; }

	public static UiElements UiElements { get; }

	public static FloatingNumberManager FloatingNumberManager { get; }

	public static QuestManager QuestManager { get; }

	public static MarkerCollector MarkerCollector { get; }

	public static HeroCollector HeroCollector { get; }

	public static ItemCollector ItemCollector { get; }

	public static SceneCollector SceneCollector { get; }

	public static ACDCollector ACDCollector { get; }

	public static ActorCollector ActorCollector { get; }

	public static PlayerCollector PlayerCollector { get; }

	public static GameSettingsManager GameSettingsManager { get; set; }

	internal static DAF DAF { get; private set; }

	public static WaypointManager WaypointManager { get; } = new();

	public static Portal[] portalsSnapshot { get; private set; }
	public static IClickableActor[] NormalChestsSnapshot { get; private set; }
	public static IClickableActor[] ResplendentChestsSnapshot { get; private set; }
	public static Actor[] actorsSnapshot { get; private set; }

	static CoreCollector()
	{
		Magic_600DF00D = 1611526157u;
		Unknown = GameDifficulty.unknown;
		UiElements = new UiElements();
		FloatingNumberManager = new FloatingNumberManager();
		QuestManager = new QuestManager();
		MarkerCollector = new MarkerCollector();
		HeroCollector = new HeroCollector();
		ItemCollector = new ItemCollector();
		SceneCollector = new SceneCollector();
		ACDCollector = new ACDCollector();
		ActorCollector = new ActorCollector();
		PlayerCollector = new PlayerCollector();
		GameSettingsManager = new GameSettingsManager();
		UiElements.SetupUiElements();
		LocalPlayer = new Player(0);
		GameWindowManager.Update();
		Session = new StatTracker("session", false, "SESSION");
		SessionAlwaysRunning = new StatTracker("session_abs", true, "SESSION (abs)") {
			AlwaysRunning = true
		};
		D3Memory = new D3Memory();
	}

	public static void ClearAllCaches()
	{
		SceneCollector.Clear();
		QuestManager.Clear();
		MarkerCollector.ClearMarkers(bool_0: true);
		ActorCollector.ClearActors();
		ItemCollector.ClearItems(bool_1: true);
		ActorCollector.ResetCollections(bool_4: true);
		ActorCollector.ClearMonsters();
		foreach (UiElement value in UiElements.All.Values) {
			value.long_0 = 0L;
		}
	}

	private static DateTime trackerDay;

	private static void ResetStatTrackers(bool bool_7, bool bool_8)
	{
		if (bool_7) {
			foreach (StatTracker item in Trackers) {
				item.Stop();
			}
			foreach (StatTracker item2 in Trackers) {
				item2.Save();
			}
		}
		if (bool_8) {
			DateTime now = DateTime.Now;
			trackerDay = now.Date;
			AccountTotal = new StatTracker(BattleTag, startRunning: true, "ACCOUNT TOTAL", "total");
			AccountYesterday = new StatTracker(BattleTag, startRunning: false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			AccountToday = new StatTracker(BattleTag, startRunning: true, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentHeroTotal = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: true, "HERO TOTAL", "total");
			CurrentHeroYesterday = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentHeroToday = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: true, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentAccountTotalOnCurrentDifficulty = new StatTracker(BattleTag, startRunning: true, "ACCOUNT TOTAL", "total_" + Unknown);
			CurrentAccountYesterdayOnCurrentDifficulty = new StatTracker(BattleTag, startRunning: false, "yesterday", "total_" + Unknown.ToString() + "_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentAccountTodayOnCurrentDifficulty = new StatTracker(BattleTag, startRunning: true, "today", "total_" + Unknown.ToString() + "_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentHeroTotalOnCurrentDifficulty = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: true, "HERO TOTAL", "total_" + Unknown);
			CurrentHeroYesterdayOnCurrentDifficulty = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: false, "yesterday", "total_" + Unknown.ToString() + "_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			CurrentHeroTodayOnCurrentDifficulty = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), startRunning: true, "today", "total_" + Unknown.ToString() + "_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			SnoArea? currentSnoArea = LocalPlayer.SnoArea?.HostSnoArea ?? LocalPlayer.SnoArea;
			if (RunTracker == null) {
				RunTracker = new RunTracker(currentSnoArea);
			} else {
				RunTracker.UpdateCurrentArea(currentSnoArea);
			}
			Trackers.Clear();
			Trackers.Add(Session);
			Trackers.Add(SessionAlwaysRunning);
			Trackers.Add(RunTracker.RunStatTracker);
			Trackers.Add(RunTracker.CurrentArea.AreaStats);
			Trackers.Add(AccountTotal);
			Trackers.Add(AccountToday);
			Trackers.Add(CurrentHeroTotal);
			Trackers.Add(CurrentHeroToday);
			Trackers.Add(RunTracker.CurrentArea.AreaTotalStats);
			Trackers.Add(CurrentAccountTotalOnCurrentDifficulty);
			Trackers.Add(CurrentAccountTodayOnCurrentDifficulty);
			Trackers.Add(CurrentHeroTotalOnCurrentDifficulty);
			Trackers.Add(CurrentHeroTodayOnCurrentDifficulty);
			Trackers.Add(RunTracker.CurrentArea.AreaTotalDifficultyStats);
			return;
		}
		AccountTotal = null;
		AccountYesterday = null;
		AccountToday = null;
		CurrentHeroTotal = null;
		CurrentHeroYesterday = null;
		CurrentHeroToday = null;
		CurrentAccountTotalOnCurrentDifficulty = null;
		CurrentAccountYesterdayOnCurrentDifficulty = null;
		CurrentAccountTodayOnCurrentDifficulty = null;
		CurrentHeroTotalOnCurrentDifficulty = null;
		CurrentHeroYesterdayOnCurrentDifficulty = null;
		CurrentHeroTodayOnCurrentDifficulty = null;
		if (RunTracker != null) {
			ResetGameState();
		}
		Trackers.Clear();
	}

	internal static void ResetGameConnection()
	{
		if (!hasConnected) return;

		hasConnected = false;
		GameStateValid = false;
		IsLoading = false;
		BattleTag = null;
		nextScanAttempt = 0;
		lastScanError = null;
		D3Memory.Reset();
		DAF?.Reset();
		HeroCollector.ClearHeroes();
		FloatingNumberManager.Clear(LocalPlayer as Player);
		ClearGameServerContext(leftGame: true);
		StatTrackerStorage.Flush();
	}

	internal static void ClearGameServerContext()
	{
		Stopwatch stopwatch = stopwatch_1;
		ClearGameServerContext(stopwatch != null && stopwatch.ElapsedMilliseconds >= 2000 && !D3Memory.ObjectManager_GameState_HasValue);
	}

	private static void ClearGameServerContext(bool leftGame)
	{
		IsGameReady = false;
		int_0 = 0;
		if (!D3Memory.ObjectManager_GameState_HasValue) {
			ClearAllCaches();
		}
		bool bool_ = leftGame;
		if (bool_) {
			stopwatch_1 = new();
			ResetStatTrackers(bool_7: true, bool_8: false);
			GameServerIP = null;
			LastSnoArea = null;
		}
		PlayerCollector.ResetPlayers();
		WaypointManager.Clear();
		IsGameReady = false;
		(LocalPlayer as Player).SnoArea = null;
		IsInTown = false;
		ActorCollector.ResetCollections(bool_);
	}

	public static void ResetGameState()
	{
		for (int i = 0; i < ActorCollector.Boolean_0.Length; i++) {
			ActorCollector.Boolean_0[i] = false;
		}
		GameStateReset?.Invoke(null, EventArgs.Empty);
		RunTracker = null;
	}

	public static void Update()
	{
		if (GameWindowManager.Window.Handle == IntPtr.Zero) return;

		Controller?.Stat.MemoryReads.Add(GameWindowManager.TakeReadCalls());
		CurrentRealTimeTicks = DateTime.Now.Ticks;
		try {
			GameWindowManager.Window.CursorX = Cursor.Position.X - ((GameWindowManager.Window.Handle != IntPtr.Zero) ? GameWindowManager.Window.Offset.X : 0);
			GameWindowManager.Window.CursorY = Cursor.Position.Y - ((GameWindowManager.Window.Handle != IntPtr.Zero) ? GameWindowManager.Window.Offset.Y : 0);
			bool memoryValid = false;
			if (GameWindowManager.Window.Handle != IntPtr.Zero && GameWindowManager.IsProcessValid()) {
				DAF ??= new DAF();
				bool needsScan = DAF.ObjectManagerAddress == 0 || DAF.IsScanRequired();

				if (needsScan && Environment.TickCount64 >= nextScanAttempt) {
					try {
						DAF.Scan();
					} catch (Exception ex) {
						DAF.ClearObjectManagerAddr();
						if (ex.Message != lastScanError) {
							lastScanError = ex.Message;
							Logger.Info("[ERROR] force daf scan due to exception: " + ex.Message);
						}
					}

					if (DAF.ObjectManagerAddress == 0) {
						nextScanAttempt = Environment.TickCount64 + ScanRetryMilliseconds;
					}
				}

				if (memoryValid = DAF.ObjectManagerAddress != 0) {
					hasConnected = true;
					lastScanError = null;
					D3Memory.Update();
				}
			}

			if (!memoryValid) {
				GameStateValid = false;
				D3Memory.CommandLineArgs = null;
				D3Memory.isOnPTR = null;
				D3Memory.ServerGateway = null;
				ClearAllCaches();
				ClearGameServerContext();
				return;
			}

			try {
				HeroCollector.Collect();
				UiElements.Refresh(memoryValid);
				GameSettingsManager.Refresh();
			} catch (Exception ex) {
				Logger.LogException(ex.ToString());
			}

			Hero? hero = HeroCollector.HeroList.FirstOrDefault();
			if (hero != null) {
				BattleTag ??= hero.BattleTag;
			} else {
				BattleTag = null;
			}

			if (GameSettingsManager.WindowMode == WindowMode.FullScreen) {
				Core.Delay(500);
				GameSettingsManager.Refresh();
				if (GameSettingsManager.WindowMode == WindowMode.FullScreen) {
					string text = "Unable to draw the overlay content if Diablo 3 is running in 'fullscreen' mode. Only 'fullscreen windowed' and 'windowed' modes are supported.\n\nTerminating...";
					Logger.LogException(text);
					MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Core.Exit();
					return;
				}
			}

			GameStateValid = D3Memory.ObjectManager_GameState_HasValue;
			IsLoading = D3Memory.GameState_LoadingScreenEnabled_Value != 0;
			if (!GameStateValid) {
				FloatingNumberManager.Clear(LocalPlayer as Player);
				ClearGameServerContext();
				return;
			}
			if (IsLoading || D3Memory.ActorContainer.MaxIndex == -1) {
				ClearGameServerContext();
				return;
			}
			bool boolean_;
			if (D3Memory.ActorContainer.MaxIndex != -1 && D3Memory.ActorContainer.MaxIndex <= 5000 && D3Memory.ACDContainer.MaxIndex != -1 && D3Memory.ACDContainer.MaxIndex <= 5000 && D3Memory.SceneContainer.MaxIndex != -1 && D3Memory.SceneContainer.MaxIndex <= 5000 && D3Memory.WorldContainer.MaxIndex != -1 && D3Memory.WorldContainer.MaxIndex <= 5000 && D3Memory.FastAttribGroupContainer.MaxIndex != -1 && D3Memory.AttribAllocator.RawAllocator.GoodFood == Magic_600DF00D) {
				if (D3Memory.AttribAllocator.RawAllocator.ElementSize != 16) {
					Logger.Info("[ERROR] force daf scan due to attrib struct size mismatch");
					DAF.ClearObjectManagerAddr();
					ClearGameServerContext();
					return;
				}
				if (IsGameReady && !UiElements.Clock.Visible && !UiElements.Cutscene.Visible && !UiElements.ScriptedSequence.Visible) {
					ClearGameServerContext();
					return;
				}

				try {
					if (!SceneCollector.Collect()) {
						ClearGameServerContext();
						return;
					}
					if (!PlayerCollector.Collect(memoryValid)) {
						ClearGameServerContext();
						return;
					}

					ACDCollector.Collect();

					if (!ActorCollector.Collect()) {
						return;
					}

					var player = CoreCollector.LocalPlayer;
					var playerArea = player?.SnoArea;
					var playerWorldId = player?.WorldId ?? 0;
					var dict = CoreCollector.ActorCollector.PortalsByAnnId;
					var temp = new List<Portal>();
					bool isRift = playerArea != null && playerArea.Code.StartsWith("x1_lr_level_", StringComparison.InvariantCulture);
					foreach (var kvp in dict) {
						var portal = kvp.Value;
						if (portal == null)
							continue;

						if (playerArea == null || portal.TargetArea == null)
							continue;

						if (portal.WorldId != playerWorldId)
							continue;

						if (portal.ActorAvailable || !isRift)
							temp.Add(portal);
					}

					portalsSnapshot = [.. temp];

					var source = CoreCollector.ActorCollector.AllActors;
					var normals = new IClickableActor[source.Count];
					var resplandecents = new IClickableActor[source.Count];
					int normalsidx = 0;
					int resplandecentsidx = 0;

					for (int i = 0; i < source.Count; i++) {
						var actor = source[i];

						if (actor.SnoActor.Kind == ActorKind.ChestNormal) {
							normals[normalsidx++] = (IClickableActor)actor;
						} else if (actor.SnoActor.Kind == ActorKind.Chest) {
							resplandecents[resplandecentsidx++] = (IClickableActor)actor;
						}
					}

					Array.Resize(ref normals, normalsidx);
					Array.Resize(ref resplandecents, resplandecentsidx);
					NormalChestsSnapshot = normals;
					ResplendentChestsSnapshot = resplandecents;

					actorsSnapshot = new Actor[source.Count];
					for (int i = 0; i < source.Count; i++) {
						var actor = source[i];
						actorsSnapshot[i] = actor;
					}
				} catch (Exception ex) {
					Logger.LogException(ex.ToString());
				}

				if (LocalPlayer.SnoArea == null) {
					ClearGameServerContext();
					return;
				}

				SceneCollector.GenerateSceneHints();
				SnoArea snoArea = LocalPlayer.SnoArea;
				bool flag3 = !IsGameReady && stopwatch0.ElapsedMilliseconds >= 3000;
				if (int_0 != HeroCollector.Int32_0) {
					if (int_0 != 0) {
						flag3 = true;
						Logger.Info("[ERROR] force daf scan due to game jump without leaving to the menu");
						DAF.ClearObjectManagerAddr();
						FloatingNumberManager.Clear(LocalPlayer as Player);
						RunTracker = null;
					}
					int_0 = HeroCollector.Int32_0;
				}
				IsGameReady = true;
				try {
					MarkerCollector.Collect();
				} catch (Exception exception) {
					Logger.LogException(exception.ToString());
				}
				try {
					FloatingNumberManager.Update(LocalPlayer as Player);
				} catch (Exception exception2) {
					Logger.LogException(exception2.ToString());
				}
				try {
					WaypointManager.Update();
				} catch (Exception exception3) {
					Logger.LogException(exception3.ToString());
				}
				try {
					QuestManager.Refresh();
				} catch (Exception exception4) {
					Logger.LogException(exception4.ToString());
				}
				IsInTown = snoArea?.IsTown ?? false;
				if (flag3 || Unknown == GameDifficulty.unknown || RunTracker == null) {
					Unknown = D3Memory.GameDifficulty;
				}
				string? gameServerIP = GameServerIP;
				if (gameServerIP == null || !gameServerIP.Contains(".")) {
					GameServerIP = D3Memory.ReadGameServerIP();
				}
				if (RunTracker == null) {
					LastSnoArea = snoArea;
					SceneCollector.Clear();
					try {
						SceneCollector.Collect();
					} catch (Exception exception5) {
						Logger.LogException(exception5.ToString());
					}
					ActorCollector.stopwatch = null;
					ActorCollector.Act = 0;
					try {
						OnNewArea?.Invoke(null, EventArgs.Empty);
					} catch (Exception exception6) {
						Logger.LogException(exception6.ToString());
					}
					Player[] iPlayer_ = PlayerCollector.PlayerSlots;
					for (int i = 0; i < iPlayer_.Length; i++) {
						Player player2 = (Player)iPlayer_[i];
						player2.ParagonTotalExp2 = 0L;
						player2.ParagonTotalExp = 0L;
						player2.class362_0.ForceSet(0L);
						player2.Gold = 0L;
					}
					ResetStatTrackers(bool_7: false, bool_8: true);
				}
				if (!IsLoading && snoArea != null && (LastSnoArea == null || (LastSnoArea != snoArea && LastSnoArea.NameLocalized != snoArea.NameLocalized))) {
					LastSnoArea = snoArea;
					OnFalseNewArea?.Invoke(null, LastSnoArea);
					ResetStatTrackers(bool_7: true, bool_8: true);
				}
				// The today trackers are named after the day they were created, so a session running past midnight must start new ones.
				if (!IsLoading && snoArea != null && RunTracker != null && DateTime.Now.Date != trackerDay) {
					ResetStatTrackers(bool_7: true, bool_8: true);
				}
				UpdateSpecialArea();
				Player gameLocalPlayer = LocalPlayer;
				if (!IsGameReady) {
					boolean_ = false;
				} else if (D3Memory.GameDifficulty < GameDifficulty.t1 && CurrentSpecialArea == SpecialArea.None && (gameLocalPlayer == null || gameLocalPlayer.SnoArea?.Sno != 288482)) {
					boolean_ = gameLocalPlayer != null && gameLocalPlayer.SnoArea?.HostAreaSno == 288482;
				} else {
					boolean_ = true;
				}
			} else {
				Logger.Info("[ERROR] force daf scan due to invalid containers [" + D3Memory.ActorContainer.MaxIndex + ", " + D3Memory.ACDContainer.MaxIndex + ", " + D3Memory.SceneContainer.MaxIndex + ", " + D3Memory.WorldContainer.MaxIndex + ", " + D3Memory.FastAttribGroupContainer.MaxIndex + ", " + (D3Memory.AttribAllocator.RawAllocator.GoodFood == Magic_600DF00D) + "]");
				DAF.ClearObjectManagerAddr();
				ClearGameServerContext();
				return;
			}
			stopwatch0.Restart();
			stopwatch_1.Restart();
			try {
				ItemCollector.Collect();
			} catch (Exception exception7) {
				Logger.LogException(exception7.ToString());
			}
			Player[] playerSlots = PlayerCollector.PlayerSlots;
			for (int j = 0; j < playerSlots.Length; j++) {
				Player player3 = (Player)playerSlots[j];
				if (player3.IsDeadSafeCheck && player3.CoordinateKnown) {
					HeadStone? headStone = ActorCollector.HeadStones.Find((HeadStone headStone0) => headStone0.PlayerActorAnnId == player3.AnnId) as HeadStone;
					if (headStone != null) {
						player3.HeadStone = headStone;
					}
					if (headStone != null) {
						continue;
					}
					if (player3.HeadStone == null) {
						headStone = new HeadStone(0u, 0u, SnoData.Actors.GetActor(ActorSnoEnum._playerheadstone), player3.AnnId, player3);
						headStone.SetPosition(player3.FloorCoordinate.X, player3.FloorCoordinate.Y, player3.FloorCoordinate.Z);
						player3.HeadStone = headStone;
						continue;
					}
					headStone = player3.HeadStone as HeadStone;
					ActorCollector.HeadStones.Add(headStone);
					if (headStone.PlayerActorAnnId == 0) {
						headStone.PlayerActorAnnId = player3.AnnId;
						headStone.Player = player3;
					}
				} else {
					player3.HeadStone = null;
				}
			}
			if (!UiElements.GamemenuBkgrnd.Visible && !UiElements.BattleNetProfileMainLayoutRootOverlayContainer.Visible && !UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible && !UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible) {
				SnoArea snoArea2 = LocalPlayer.SnoArea;
				if (snoArea2 != null && snoArea2.Type == AreaType.Normal && LocalPlayer.SnoArea.Sno != 405915) {
					foreach (StatTracker item in Trackers) {
						item.StartIfStopped();
					}
					{
						foreach (StatTracker item2 in Trackers) {
							item2.UpdateTownState(IsInTown);
						}
						return;
					}
				}
			}

			foreach (StatTracker item3 in Trackers) {
				item3.Stop();
			}
		} catch (Exception exception8) {
			Logger.LogException(exception8.ToString());
		}
	}

	private static void UpdateSpecialArea()
	{
		if (LocalPlayer.SnoArea.Sno != 288482 && LocalPlayer.SnoArea.HostAreaSno != 288482) {
			if (D3Memory.GameState_Value_IsChallengeRiftGame && LocalPlayer.SnoArea.Sno == 415369) {
				CurrentSpecialArea = SpecialArea.ChallengeRiftHub;
			} else if (D3Memory.GameState_Value_IsChallengeRiftGame) {
				CurrentSpecialArea = SpecialArea.ChallengeRift;
			} else if (LocalPlayer.SnoArea.Sno == 257116) {
				CurrentSpecialArea = SpecialArea.UberPortals;
			} else if (LocalPlayer.SnoArea.Sno != 256767 && LocalPlayer.SnoArea.Sno != 256106 && LocalPlayer.SnoArea.Sno != 256742 && LocalPlayer.SnoArea.Sno != 374239) {
				if (LocalPlayer.SnoArea.Type == AreaType.PvP) {
					CurrentSpecialArea = SpecialArea.PvP;
				} else {
					CurrentSpecialArea = SpecialArea.None;
				}
			} else {
				CurrentSpecialArea = SpecialArea.UberFight;
			}
		} else {
			Quest? quest = QuestManager.Quests.GetValueOrDefault(337492u);
			if (quest != null && quest.State == QuestState.started && (quest.QuestStepId == 13 || quest.QuestStepId == 16 || quest.QuestStepId == 34)) {
				CurrentSpecialArea = SpecialArea.GreaterRift;
			}
			if (quest != null && quest.State == QuestState.started && (quest.QuestStepId == 1 || quest.QuestStepId == 3 || quest.QuestStepId == 10)) {
				CurrentSpecialArea = SpecialArea.Rift;
			} else if (UiElements.NephalemRiftBarUiElement.Visible) {
				CurrentSpecialArea = SpecialArea.Rift;
			} else if (UiElements.GreaterRiftBarUiElement.Visible) {
				CurrentSpecialArea = SpecialArea.GreaterRift;
			} else {
				CurrentSpecialArea = SpecialArea.None;
			}
		}
	}

	public unsafe static PointF EvaluatePowerFormula(byte[] formulaData, int int_1, int int_2, SnoPower? snoPower = null, Player? player = null)
	{
		if (int_2 == 0) {
			return new PointF(0f, 0f);
		}
		int num = int_1 + int_2;
		fixed (byte* ptr = formulaData) {
			Stack<PointF> stack = new Stack<PointF>();
			while (int_1 < num) {
				byte b = ptr[int_1];
				switch (b) {
					case 0:
						int_1 = num;
						break;
					case 1:
						int_1 += 4;
						b = ptr[int_1];
						switch (b) {
							default:
								Trace.WriteLine("unknown d = 1 operator: " + b);
								break;
							case 0:
								Trace.WriteLine("NotImplemented: minimum operator 2 values");
								break;
							case 1:
								Trace.WriteLine("NotImplemented: maximum operator 2 values");
								break;
							case 2:
								Trace.WriteLine("NotImplemented: pin operator 2 values");
								break;
							case 3: {
									PointF pointF4 = stack.Pop();
									PointF pointF5 = stack.Pop();
									stack.Push(new PointF(pointF5.X, pointF5.X + pointF4.X));
									break;
								}
							case 4: {
									PointF pointF3 = stack.Pop();
									stack.Push(new PointF(stack.Pop().X, pointF3.X));
									break;
								}
							case 5:
								Trace.WriteLine("NotImplemented: floor operator 1 value");
								break;
							case 6:
								Trace.WriteLine("NotImplemented: dim operator 3 values");
								break;
							case 7:
								Trace.WriteLine("NotImplemented: pow operator 2 values");
								break;
							case 8:
								Trace.WriteLine("NotImplemented: log operator 1 value");
								break;
							case 9:
								Trace.WriteLine("NotImplemented: in theory the same as operator#3");
								break;
							case 10:
								Trace.WriteLine("NotImplemented: in theory the same as operator#4");
								break;
							case 11: {
									int num2 = Convert.ToInt32(stack.Pop().X);
									int num3 = Convert.ToInt32(stack.Pop().X);
									int index = ((num3 < 102) ? (num3 - 87) : (num3 - 88));
									float num4 = SnoData.Powers.GetFormulaTable(index)[num2 + 1];
									stack.Push(new PointF(num4, num4));
									break;
								}
						}
						break;
					case 5: {
							int_1 += 4;
							int num5 = *(int*)(ptr + int_1);
							int_1 += 4;
							int index2 = *(int*)(ptr + int_1);
							int_1 += 4;
							int num6 = *(int*)(ptr + int_1);
							int_1 += 4;
							switch (num5) {
								case 0: {
										float num7 = 0f;
										AcdAttribute acdAttribute = SnoData.Attributes.ByIndex[index2];
										if (acdAttribute != null && player != null) {
											ACDCollector.SetIndexFromAcdId(player.AcdId);
											uint uint_ = 1048575u;
											if (acdAttribute.Code.StartsWith("Rune_")) {
												uint_ = snoPower.Sno;
											}
											if (acdAttribute.Code.StartsWith("Buff_Icon_")) {
												uint_ = snoPower.Sno;
											}
											num7 = ACDCollector.ReadFloatAttribute(acdAttribute, uint_);
										} else {
											Trace.WriteLine("can't evaluate this");
										}
										stack.Push(new PointF(num7, num7));
										break;
									}
								case 2:
									stack.Push(new PointF(70f, 70f));
									break;
								case 22:
									Trace.WriteLine("NotImplemented: evaluate Power #" + index2 + "'s formula #" + num6);
									break;
								case 23:
								case 24:
								case 25:
								case 26:
								case 27:
								case 28:
								case 29:
								case 30:
								case 31:
								case 32:
								case 33:
								case 34:
								case 35:
								case 36:
								case 37:
								case 38:
								case 39:
								case 40:
								case 41:
								case 42:
								case 43:
								case 44:
								case 45:
								case 46:
								case 47:
								case 48:
								case 49:
								case 50:
								case 51:
								case 52:
								case 53:
								case 54:
								case 55:
								case 56:
								case 57:
								case 58:
								case 59:
								case 60:
								case 61:
								case 62:
								case 63:
								case 64:
								case 65:
								case 66:
								case 67:
								case 68:
								case 69:
								case 70:
								case 71:
								case 72:
								case 73:
								case 74:
								case 75:
								case 76:
								case 77:
								case 78:
								case 79:
								case 80:
								case 81:
								case 82:
								case 83:
								case 84:
								case 85:
								case 86:
									stack.Push(new PointF(0f, 0f));
									break;
								default:
									if (num5 >= 88) {
										stack.Push(new PointF(num5, num5));
									} else {
										Trace.WriteLine("fuck");
									}
									break;
							}
							break;
						}
					case 6: {
							int_1 += 4;
							float num8 = *(float*)(ptr + int_1);
							stack.Push(new PointF(num8, num8));
							break;
						}
					case 8: {
							PointF pointF14 = stack.Pop();
							PointF pointF15 = stack.Pop();
							PointF item5 = new PointF((pointF15.X > pointF14.X) ? 1 : 0, (pointF15.X > pointF14.X) ? 1 : 0);
							stack.Push(item5);
							break;
						}
					case 11: {
							PointF pointF12 = stack.Pop();
							PointF pointF13 = stack.Pop();
							PointF item4 = new PointF(pointF13.X + pointF12.X, pointF13.Y + pointF12.Y);
							stack.Push(item4);
							break;
						}
					case 12: {
							PointF pointF10 = stack.Pop();
							PointF pointF11 = stack.Pop();
							PointF item3 = new PointF(pointF11.X - pointF10.X, pointF11.Y - pointF10.Y);
							stack.Push(item3);
							break;
						}
					case 13: {
							PointF pointF8 = stack.Pop();
							PointF pointF9 = stack.Pop();
							PointF item2 = new PointF(pointF9.X * pointF8.X, pointF9.Y * pointF8.Y);
							stack.Push(item2);
							break;
						}
					case 14: {
							PointF pointF6 = stack.Pop();
							PointF pointF7 = stack.Pop();
							PointF item = new PointF(pointF7.X / pointF6.X, pointF7.Y / pointF6.Y);
							stack.Push(item);
							break;
						}
					case 17: {
							PointF pointF = stack.Pop();
							PointF pointF2 = stack.Pop();
							if (stack.Pop().X == 1f) {
								stack.Push(new PointF(pointF2.X, pointF2.Y));
							} else {
								stack.Push(new PointF(pointF.X, pointF.Y));
							}
							break;
						}
					default:
						Trace.WriteLine("unknown op: " + b);
						return PointF.Empty;
				}
				int_1 += 4;
			}
			PointF result = stack.Pop();
			if (stack.Count > 0) {
				Trace.WriteLine("?");
			}
			return result;
		}
	}
}
