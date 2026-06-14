#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using collectors;
using Plugins;
using SNO;

namespace work;

internal static class CoreCollector
{
	public static readonly uint Magic_600DF00D;

	[CompilerGenerated]
	private static EventHandler eventHandler_5;

	private static bool isGameWindowRunning;

	[CompilerGenerated]
	private static readonly UiElements uiElements;

	[CompilerGenerated]
	private static readonly FloatingNumberManager class335_0;

	[CompilerGenerated]
	private static readonly QuestManager class376_0;

	[CompilerGenerated]
	private static readonly MarkerCollector class412_0;

	[CompilerGenerated]
	private static readonly HeroCollector class420_0;

	[CompilerGenerated]
	private static readonly ItemCollector class414_0;

	[CompilerGenerated]
	private static readonly SceneCollector class374_0;

	[CompilerGenerated]
	private static readonly ACDCollector class430_0;

	[CompilerGenerated]
	private static readonly ActorCollector class422_0;

	[CompilerGenerated]
	private static readonly PlayerCollector class408_0;

	[CompilerGenerated]
	private static DAF class313_0;

	public static bool CanReadMemory;

	public static bool bool_1;

	public static bool GameStateValid;

	public static bool IsGameReady;

	public static Stopwatch stopwatch_0 = new();

	public static Stopwatch stopwatch_1 = new();

	public static long CurrentRealTimeTicks;

	public static IPlayer LocalPlayer;

	public static bool IsLoading;

	public static bool IsInTown;

	public static string BattleTag;

	public static GameDifficulty gameDifficulty_0;

	private static int int_0;

	private static ISnoArea LastSnoArea;

	public static SpecialArea specialArea_0;

	public static string GameServerIP;

	public static D3Memory D3Memory;

	public static List<StatTracker> Trackers = [];

	public static StatTracker class340_0;

	public static StatTracker class340_1;

	public static StatTracker class340_2;

	public static StatTracker class340_3;

	public static StatTracker class340_4;

	public static StatTracker class340_5;

	public static StatTracker class340_6;

	public static StatTracker class340_7;

	public static StatTracker class340_8;

	public static StatTracker class340_9;

	public static StatTracker class340_10;

	public static StatTracker class340_11;

	public static StatTracker class340_12;

	public static StatTracker class340_13;

	public static RunTracker class364_0;

	public static IController Controller { get; set; }

	public static EventHandler<IPlayerSkill> OnTrueCooldown { get; set; }

	public static EventHandler<IPlayerSkill> OnCooldown { get; set; }

	public static EventHandler OnNewArea { get; set; }

	public static EventHandler EventHandler_5
	{
		[CompilerGenerated]
		get {
			return eventHandler_5;
		}
		[CompilerGenerated]
		set {
			eventHandler_5 = value;
		}
	}

	public static EventHandler<ISnoArea> OnFalseNewArea { get; set; }

	public static UiElements UiElements
	{
		[CompilerGenerated]
		get {
			return uiElements;
		}
	}

	public static FloatingNumberManager Class335_0
	{
		[CompilerGenerated]
		get {
			return class335_0;
		}
	}

	public static QuestManager Class376_0
	{
		[CompilerGenerated]
		get {
			return class376_0;
		}
	}

	public static MarkerCollector Class412_0
	{
		[CompilerGenerated]
		get {
			return class412_0;
		}
	}

	public static HeroCollector HeroCollector
	{
		[CompilerGenerated]
		get {
			return class420_0;
		}
	}

	public static ItemCollector ItemCollector
	{
		[CompilerGenerated]
		get {
			return class414_0;
		}
	}

	public static SceneCollector SceneCollector
	{
		[CompilerGenerated]
		get {
			return class374_0;
		}
	}

	public static ACDCollector ACDCollector
	{
		[CompilerGenerated]
		get {
			return class430_0;
		}
	}

	public static ActorCollector ActorCollector
	{
		[CompilerGenerated]
		get {
			return class422_0;
		}
	}

	public static PlayerCollector PlayerCollector
	{
		[CompilerGenerated]
		get {
			return class408_0;
		}
	}

	public static GameSettingsManager GameSettingsManager { get; set; }

	internal static DAF DAF
	{
		[CompilerGenerated]
		get {
			return class313_0;
		}
		[CompilerGenerated]
		private set {
			class313_0 = value;
		}
	}

	public static WaypointManager WaypointManager { get; } = new();

	static CoreCollector()
	{
		Magic_600DF00D = 1611526157u;
		gameDifficulty_0 = GameDifficulty.unknown;
		Actor.IWindow_0 = GameWindowManager.Window;
		uiElements = new UiElements();
		class335_0 = new FloatingNumberManager();
		class376_0 = new QuestManager();
		class412_0 = new MarkerCollector();
		class420_0 = new HeroCollector();
		class414_0 = new ItemCollector();
		class374_0 = new SceneCollector();
		class430_0 = new ACDCollector();
		class422_0 = new ActorCollector();
		class408_0 = new PlayerCollector();
		GameSettingsManager = new GameSettingsManager();
		UiElements.SetupUiElements();
		LocalPlayer = new Player(0);
		GameWindowManager.Update();
		class340_0 = new StatTracker("session", false, "SESSION", (string)null);
		class340_1 = new StatTracker("session_abs", true, "SESSION (abs)", (string)null) {
			AlwaysRunning = true
		};
		D3Memory = new D3Memory();
	}

	public static void ClearAllCaches()
	{
		SceneCollector.method_4();
		Class376_0.method_1();
		Class412_0.method_1(bool_0: true);
		ActorCollector.method_0();
		ItemCollector.method_0(bool_1: true);
		ActorCollector.method_2(bool_4: true);
		ActorCollector.method_1();
		foreach (UiElement value in UiElements.All.Values) {
			value.long_0 = 0L;
		}
	}

	private static void smethod_1(bool bool_7, bool bool_8)
	{
		if (bool_7) {
			foreach (StatTracker item in Trackers) {
				item.Stop();
			}
			foreach (StatTracker item2 in Trackers) {
				item2.method_24();
			}
		}
		object obj;
		if (bool_8) {
			DateTime now = DateTime.Now;
			class340_2 = new StatTracker(BattleTag, bool_1: true, "ACCOUNT TOTAL", "total");
			class340_3 = new StatTracker(BattleTag, bool_1: false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_4 = new StatTracker(BattleTag, bool_1: true, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_5 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "HERO TOTAL", "total");
			class340_6 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: false, "yesterday", "total_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_7 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "today", "total_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_8 = new StatTracker(BattleTag, bool_1: true, "ACCOUNT TOTAL", "total_" + gameDifficulty_0);
			class340_9 = new StatTracker(BattleTag, bool_1: false, "yesterday", "total_" + gameDifficulty_0.ToString() + "_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_10 = new StatTracker(BattleTag, bool_1: true, "today", "total_" + gameDifficulty_0.ToString() + "_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_11 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "HERO TOTAL", "total_" + gameDifficulty_0);
			class340_12 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: false, "yesterday", "total_" + gameDifficulty_0.ToString() + "_" + now.AddDays(-1.0).ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			class340_13 = new StatTracker(LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "today", "total_" + gameDifficulty_0.ToString() + "_" + now.ToString("yyyyMMdd", CultureInfo.InvariantCulture));
			ISnoArea snoArea = LocalPlayer.SnoArea;
			if (snoArea == null) {
				obj = null;
			} else {
				obj = snoArea.HostSnoArea;
				if (obj != null) {
					goto IL_03dd;
				}
			}
			obj = LocalPlayer.SnoArea;
			goto IL_03dd;
		}
		class340_2 = null;
		class340_3 = null;
		class340_4 = null;
		class340_5 = null;
		class340_6 = null;
		class340_7 = null;
		class340_8 = null;
		class340_9 = null;
		class340_10 = null;
		class340_11 = null;
		class340_12 = null;
		class340_13 = null;
		if (class364_0 != null) {
			smethod_3();
		}
		Trackers.Clear();
		return;
	IL_03dd:
		ISnoArea isnoArea_ = (ISnoArea)obj;
		if (class364_0 == null) {
			class364_0 = new RunTracker(isnoArea_);
		} else {
			class364_0.UpdateCurrentArea(isnoArea_);
		}
		Trackers.Clear();
		Trackers.Add(class340_0);
		Trackers.Add(class340_1);
		Trackers.Add(class364_0.RunStatTracker);
		Trackers.Add(class364_0.CurrentArea.AreaStats);
		Trackers.Add(class340_2);
		Trackers.Add(class340_4);
		Trackers.Add(class340_5);
		Trackers.Add(class340_7);
		Trackers.Add(class364_0.CurrentArea.AreaTotalStats);
		Trackers.Add(class340_8);
		Trackers.Add(class340_10);
		Trackers.Add(class340_11);
		Trackers.Add(class340_13);
		Trackers.Add(class364_0.CurrentArea.AreaTotalDifficultyStats);
	}

	internal static void ClearGameServerContext(string string_3)
	{
		bool_1 = true;
		IsGameReady = false;
		int_0 = 0;
		if (!D3Memory.ObjectManager_GameState_HasValue) {
			ClearAllCaches();
		}
		Stopwatch stopwatch = stopwatch_1;
		bool bool_;
		if (bool_ = stopwatch != null && stopwatch.ElapsedMilliseconds >= 2000 && !D3Memory.ObjectManager_GameState_HasValue) {
			stopwatch_1 = new();
			smethod_1(bool_7: true, bool_8: false);
			GameServerIP = null;
			LastSnoArea = null;
		}
		PlayerCollector.method_0();
		WaypointManager.Clear();
		IsGameReady = false;
		(LocalPlayer as Player).SnoArea = null;
		IsInTown = false;
		ActorCollector.method_2(bool_);
	}

	public static void smethod_3()
	{
		for (int i = 0; i < ActorCollector.Boolean_0.Length; i++) {
			ActorCollector.Boolean_0[i] = false;
		}
		EventHandler_5?.Invoke(null, EventArgs.Empty);
		class364_0 = null;
	}

	public static void Update()
	{
		CurrentRealTimeTicks = DateTime.Now.Ticks;
		try {
			bool dafRescanned = false;
			GameWindowManager.Window.CursorX = Cursor.Position.X - ((GameWindowManager.Window.Handle != IntPtr.Zero) ? GameWindowManager.Window.Offset.X : 0);
			GameWindowManager.Window.CursorY = Cursor.Position.Y - ((GameWindowManager.Window.Handle != IntPtr.Zero) ? GameWindowManager.Window.Offset.Y : 0);
			bool memoryValid = false;
			if (GameWindowManager.Window.Handle != IntPtr.Zero && MR.Instance.IsValid()) {
				DAF ??= new DAF();
				dafRescanned = DAF.ObjectManagerAddress == 0 || DAF.IsScanRequired();

				if (memoryValid) {
					try {
						DAF.Scan();
					} catch (Exception ex) {
						DAF.ClearObjectManagerAddr();
						Logger.Info("[ERROR] force daf scan due to exception: " + ex.Message);
					}
				}
				if (dafRescanned = DAF.ObjectManagerAddress != 0) {
					D3Memory.Update();
				}
			}

			if (!dafRescanned) {
				GameStateValid = false;
				CanReadMemory = false;
				D3Memory.CommandLineArgs = null;
				D3Memory.isOnPTR = null;
				D3Memory.ServerGateway = null;
				ClearAllCaches();
				ClearGameServerContext("client is not running");
				return;
			}

			CanReadMemory = true;
			try {
				HeroCollector.Collect();
				UiElements.Refresh(memoryValid);
				GameSettingsManager.Refresh();
			} catch (Exception ex) {
				Logger.LogException(ex.Message);
			}

			IHero hero = HeroCollector.HeroList.FirstOrDefault();
			if (hero != null) {
				BattleTag ??= hero.BattleTag;
			} else {
				BattleTag = null;
			}

			if (GameSettingsManager.WindowMode == WindowMode.FullScreen) {
				Thread.Sleep(500);
				GameSettingsManager.Refresh();
				if (GameSettingsManager.WindowMode == WindowMode.FullScreen) {
					string text = "Unable to draw the overlay content if Diablo 3 is running in 'fullscreen' mode. Only 'fullscreen windowed' and 'windowed' modes are supported.\n\nTerminating...";
					Logger.LogException(text);
					MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Core.Exit();
					Application.Exit();
					Environment.Exit(0);
				}
			}

			GameStateValid = D3Memory.ObjectManager_GameState_HasValue;
			IsLoading = D3Memory.GameState_LoadingScreenEnabled_Value != 0;
			if (!GameStateValid) {
				Class335_0.Clear(LocalPlayer as Player);
				ClearGameServerContext("!CurrentInGame");
				return;
			}
			if (IsLoading || D3Memory.ActorContainer.MaxIndex == -1) {
				ClearGameServerContext("loading");
				return;
			}
			bool boolean_;
			if (D3Memory.ActorContainer.MaxIndex != -1 && D3Memory.ActorContainer.MaxIndex <= 5000 && D3Memory.ACDContainer.MaxIndex != -1 && D3Memory.ACDContainer.MaxIndex <= 5000 && D3Memory.SceneContainer.MaxIndex != -1 && D3Memory.SceneContainer.MaxIndex <= 5000 && D3Memory.WorldContainer.MaxIndex != -1 && D3Memory.WorldContainer.MaxIndex <= 5000 && D3Memory.FastAttribGroupContainer.MaxIndex != -1 && D3Memory.AttribAllocator.RawAllocator.GoodFood == Magic_600DF00D) {
				if (D3Memory.AttribAllocator.RawAllocator.ElementSize != 16) {
					Logger.Info("[ERROR] force daf scan due to attrib struct size mismatch");
					DAF.ClearObjectManagerAddr();
					ClearGameServerContext("invalid attrib struct");
					return;
				}
				if (IsGameReady && !UiElements.class341_58.Visible && !UiElements.class341_62.Visible && !UiElements.class341_63.Visible) {
					ClearGameServerContext("no difficulty label");
					return;
				}

				try {
					if (!SceneCollector.Collect()) {
						ClearGameServerContext("scene collect exception");
						return;
					}
					if (!PlayerCollector.Collect(memoryValid)) {
						ClearGameServerContext("player collect exception");
						return;
					}

					ACDCollector.Collect();

					if (!ActorCollector.Collect()) {
						return;
					}
				} catch (Exception ex) {
					Logger.LogException(ex.Message);
				}

				if (LocalPlayer.SnoArea == null) {
					ClearGameServerContext("unknown area");
					return;
				}

				SceneCollector.GenerateSceneHints();
				ISnoArea snoArea = LocalPlayer.SnoArea;
				bool_1 = false;
				bool flag3 = !IsGameReady && stopwatch_0.ElapsedMilliseconds >= 3000;
				if (int_0 != HeroCollector.Int32_0) {
					if (int_0 != 0) {
						flag3 = true;
						Logger.Info("[ERROR] force daf scan due to game jump without leaving to the menu");
						DAF.ClearObjectManagerAddr();
						Class335_0.Clear(LocalPlayer as Player);
						class364_0 = null;
					}
					int_0 = HeroCollector.Int32_0;
				}
				IsGameReady = true;
				try {
					Class412_0.Collect();
				} catch (Exception exception_8) {
					Logger.LogException(exception_8.Message);
				}
				try {
					Class335_0.Update(LocalPlayer as Player);
				} catch (Exception exception_9) {
					Logger.LogException(exception_9.Message);
				}
				try {
					WaypointManager.Update();
				} catch (Exception exception_10) {
					Logger.LogException(exception_10.Message);
				}
				try {
					Class376_0.method_0();
				} catch (Exception exception_11) {
					Logger.LogException(exception_11.Message);
				}
				IsInTown = snoArea?.IsTown ?? false;
				if (flag3 || gameDifficulty_0 == GameDifficulty.unknown || class364_0 == null) {
					gameDifficulty_0 = D3Memory.GameDifficulty;
				}
				string gameServerIP = GameServerIP;
				if (gameServerIP == null || !gameServerIP.Contains(".")) {
					GameServerIP = D3Memory.ReadGameServerIP();
				}
				if (class364_0 == null) {
					LastSnoArea = snoArea;
					SceneCollector.method_4();
					try {
						SceneCollector.Collect();
					} catch (Exception exception_12) {
						Logger.LogException(exception_12.Message);
					}
					ActorCollector.stopwatch_0 = null;
					ActorCollector.Int32_0 = 0;
					try {
						OnNewArea?.Invoke(null, EventArgs.Empty);
					} catch (Exception exception_13) {
						Logger.LogException(exception_13.Message);
					}
					IPlayer[] iPlayer_ = PlayerCollector.PlayerSlots;
					for (int i = 0; i < iPlayer_.Length; i++) {
						Player obj = (Player)iPlayer_[i];
						obj.long_6 = 0L;
						obj.ParagonTotalExp = 0L;
						obj.class362_0.ForceSet(0L);
						obj.long_0 = 0L;
					}
					smethod_1(bool_7: false, bool_8: true);
				}
				if (!IsLoading && snoArea != null && (LastSnoArea == null || (LastSnoArea != snoArea && LastSnoArea.NameLocalized != snoArea.NameLocalized))) {
					LastSnoArea = snoArea;
					OnFalseNewArea?.Invoke(null, LastSnoArea);
					smethod_1(bool_7: true, bool_8: true);
				}
				smethod_6();
				if (IsGameReady) {
					if (D3Memory.GameDifficulty < GameDifficulty.t1 && specialArea_0 == SpecialArea.None) {
						IPlayer localPlayer = LocalPlayer;
						if (localPlayer == null || localPlayer.SnoArea?.Sno != 288482) {
							IPlayer localPlayer2 = LocalPlayer;
							boolean_ = localPlayer2 != null && localPlayer2.SnoArea?.HostAreaSno == 288482;
							goto IL_0bc6;
						}
					}
					boolean_ = true;
				} else {
					boolean_ = false;
				}
				goto IL_0bc6;
			}
			Logger.Info("[ERROR] force daf scan due to invalid containers [" + D3Memory.ActorContainer.MaxIndex + ", " + D3Memory.ACDContainer.MaxIndex + ", " + D3Memory.SceneContainer.MaxIndex + ", " + D3Memory.WorldContainer.MaxIndex + ", " + D3Memory.FastAttribGroupContainer.MaxIndex + ", " + (D3Memory.AttribAllocator.RawAllocator.GoodFood == Magic_600DF00D) + "]");
			DAF.ClearObjectManagerAddr();
			ClearGameServerContext("invalid containers");
			return;
		IL_0bc6:
			stopwatch_0.Restart();
			stopwatch_1.Restart();
			try {
				ItemCollector.method_1();
			} catch (Exception exception_14) {
				Logger.LogException(exception_14.Message);
			}
			IPlayer[] iPlayer_2 = PlayerCollector.PlayerSlots;
			for (int j = 0; j < iPlayer_2.Length; j++) {
				Player class310_0 = (Player)iPlayer_2[j];
				if (class310_0.IsDeadSafeCheck && class310_0.CoordinateKnown) {
					HeadStone @class = ActorCollector.List_1.Find((IHeadStone iheadStone_0) => iheadStone_0.PlayerActorAnnId == class310_0.AnnId) as HeadStone;
					if (@class != null) {
						class310_0.HeadStone = @class;
					}
					if (@class != null) {
						continue;
					}
					if (class310_0.HeadStone == null) {
						@class = new HeadStone(0u, 0u, SnoData.Actors.GetActor(ActorSnoEnum._playerheadstone), class310_0.AnnId, class310_0);
						@class.method_24(class310_0.FloorCoordinate.X, class310_0.FloorCoordinate.Y, class310_0.FloorCoordinate.Z);
						class310_0.HeadStone = @class;
						continue;
					}
					@class = class310_0.HeadStone as HeadStone;
					ActorCollector.List_1.Add(@class);
					if (@class.PlayerActorAnnId == 0) {
						@class.PlayerActorAnnId = class310_0.AnnId;
						@class.Player = class310_0;
					}
				} else {
					class310_0.HeadStone = null;
				}
			}
			if (!UiElements.class341_56.Visible && !UiElements.class341_148.Visible && !UiElements.class341_156.Visible && !UiElements.class341_77.Visible) {
				ISnoArea snoArea2 = LocalPlayer.SnoArea;
				if (snoArea2 != null && snoArea2.Type == AreaType.Normal && LocalPlayer.SnoArea.Sno != 405915) {
					foreach (StatTracker item in Trackers) {
						item.method_28();
					}
					{
						foreach (StatTracker item2 in Trackers) {
							item2.method_30(IsInTown);
						}
						return;
					}
				}
			}

			foreach (StatTracker item3 in Trackers) {
				item3.Stop();
			}
		} catch (Exception exception_15) {
			Logger.LogException(exception_15.Message);
		}
	}

	private static void smethod_6()
	{
		if (LocalPlayer.SnoArea.Sno != 288482 && LocalPlayer.SnoArea.HostAreaSno != 288482) {
			if (D3Memory.GameState_Value_IsChallengeRiftGame && LocalPlayer.SnoArea.Sno == 415369) {
				specialArea_0 = SpecialArea.ChallengeRiftHub;
			} else if (D3Memory.GameState_Value_IsChallengeRiftGame) {
				specialArea_0 = SpecialArea.ChallengeRift;
			} else if (LocalPlayer.SnoArea.Sno == 257116) {
				specialArea_0 = SpecialArea.UberPortals;
			} else if (LocalPlayer.SnoArea.Sno != 256767 && LocalPlayer.SnoArea.Sno != 256106 && LocalPlayer.SnoArea.Sno != 256742 && LocalPlayer.SnoArea.Sno != 374239) {
				if (LocalPlayer.SnoArea.Type == AreaType.PvP) {
					specialArea_0 = SpecialArea.PvP;
				} else {
					specialArea_0 = SpecialArea.None;
				}
			} else {
				specialArea_0 = SpecialArea.UberFight;
			}
		} else {
			IQuest quest = Class376_0.class112_1[337492u];
			if (quest != null && quest.State == QuestState.started && (quest.QuestStepId == 13 || quest.QuestStepId == 16 || quest.QuestStepId == 34)) {
				specialArea_0 = SpecialArea.GreaterRift;
			}
			if (quest != null && quest.State == QuestState.started && (quest.QuestStepId == 1 || quest.QuestStepId == 3 || quest.QuestStepId == 10)) {
				specialArea_0 = SpecialArea.Rift;
			} else if (UiElements.class341_172.Visible) {
				specialArea_0 = SpecialArea.Rift;
			} else if (UiElements.class341_173.Visible) {
				specialArea_0 = SpecialArea.GreaterRift;
			} else {
				specialArea_0 = SpecialArea.None;
			}
		}
	}

	public unsafe static PointF smethod_7(byte[] byte_0, int int_1, int int_2, ISnoPower isnoPower_0 = null, IPlayer iplayer_1 = null)
	{
		if (int_2 == 0) {
			return new PointF(0f, 0f);
		}
		int num = int_1 + int_2;
		fixed (byte* ptr = byte_0) {
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
										if (acdAttribute != null && iplayer_1 != null) {
											ACDCollector.SetIndexFromAcdId(iplayer_1.AcdId);
											uint uint_ = 1048575u;
											if (acdAttribute.Code.StartsWith("Rune_")) {
												uint_ = isnoPower_0.Sno;
											}
											if (acdAttribute.Code.StartsWith("Buff_Icon_")) {
												uint_ = isnoPower_0.Sno;
											}
											num7 = ACDCollector.method_7(acdAttribute, uint_);
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
