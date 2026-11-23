using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;

internal class D3Memory
{
	[CompilerGenerated]
	private static readonly int objectManagerSizeOf = 2976;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerRenderTick = 84;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerInGameFlag = 132;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerGameServerAddress = 196;

	[CompilerGenerated]
	private static readonly int sizeOfGameState = 384;

	[CompilerGenerated]
	private static readonly int offsetGameStateValidation3 = 28;

	[CompilerGenerated]
	private static readonly int offsetGameStateLoadingScreenEnabled = 108;

	[CompilerGenerated]
	private static readonly int offsetGameStateRiftProgressAccumulated = 260;

	[CompilerGenerated]
	private static readonly int offsetGameStateValidation1 = 280;

	[CompilerGenerated]
	private static readonly int offsetGameStateValidation2 = 288;

	[CompilerGenerated]
	private static readonly int offsetGameStateIsGamePaused = 348;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerStorage = 1976;

	[CompilerGenerated]
	private static readonly int offsetStorageGameDifficulty = 4;

	[CompilerGenerated]
	private static readonly int offsetStorageGameTick = 288;

	[CompilerGenerated]
	private static readonly int offsetPlayerDataManagerElements = 96;

	[CompilerGenerated]
	private static readonly int offsetStorageFastAttrib = 384;

	[CompilerGenerated]
	private static readonly int offsetFastAttribFastAttribGroups = 144;

	[CompilerGenerated]
	private static readonly int offsetStorageQuestManager = 440;

	[CompilerGenerated]
	private static readonly int offsetStorageWaypointManager = 528;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerActors = 2592;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerScenes = 2720;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerUIManager = 2824;

	[CompilerGenerated]
	private static readonly int offsetUIManagerSelectedActor1 = 9912;

	[CompilerGenerated]
	private static readonly int offsetUIManagerSelectedActor2 = 3680;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerWorlds = 2840;

	[CompilerGenerated]
	private static readonly int offsetPlayerLocalPlayerIndex = 0;

	[CompilerGenerated]
	private static readonly int offsetPlayerFloatingNumbers = 41496;

	[CompilerGenerated]
	private static readonly int floatingNumAllocatorOffset2 = 32;

	[CompilerGenerated]
	private static readonly int offsetCircularBufferFree = 41800;

	[CompilerGenerated]
	private static readonly int offsetCircularBufferHead = 41808;

	[CompilerGenerated]
	private static readonly int offsetCircularBufferTail = 41816;

	[CompilerGenerated]
	private static readonly int offsetCircularBufferUsed = 41824;

	[CompilerGenerated]
	private static readonly int offsetCircularBufferBuffer = 41832;

	[CompilerGenerated]
	private static readonly int offsetObjectManagerTimedEvents = 2936;

	[CompilerGenerated]
	private static readonly int unused = 12;

	[CompilerGenerated]
	private long objectManagerStorageAddress;

	[CompilerGenerated]
	private long uIManagerAddress;

	[CompilerGenerated]
	private long questManagerAddress;

	[CompilerGenerated]
	private long waypointManagerAddress;

	[CompilerGenerated]
	private bool objectManagerGameStateHasValue;

	[CompilerGenerated]
	private bool gameStateValueIsChallengeRiftGame;

	[CompilerGenerated]
	private int gameStateLoadingScreenEnabledValue;

	[CompilerGenerated]
	private int gameStatePausedValue;

	[CompilerGenerated]
	private float gameStateRiftProgressAccumulatedValue;

	[CompilerGenerated]
	private readonly float maxQuestProgress = 650f;

	[CompilerGenerated]
	private int currentTimedEventStartTick;

	[CompilerGenerated]
	private int currentTimedEventEndTick;

	[CompilerGenerated]
	private int currentTimedEventEndTickMod;

	[CompilerGenerated]
	private bool isUiHidden;

	[CompilerGenerated]
	private int renderTick;

	[CompilerGenerated]
	private int gameTick;

	[CompilerGenerated]
	private int localPlayerIndex;

	private int int_44;

	private Stopwatch stopwatch_0 = new();

	[CompilerGenerated]
	private GameDifficulty gameDifficulty;

	[CompilerGenerated]
	private BountyAct actMapCurrentAct;

	[CompilerGenerated]
	private double averageLatency;

	[CompilerGenerated]
	private double currentLatency;

	[CompilerGenerated]
	private uint selectedActor1AcdId;

	[CompilerGenerated]
	private uint selectedActor2AcdId;

	internal ExpandableContainer ACDContainer;

	internal ExpandableContainer ActorContainer;

	internal ExpandableContainer FastAttribGroupContainer;

	internal Container WorldContainer;

	internal Container SceneContainer;

	internal Allocator AttribAllocator;

	internal Allocator FloatingNumberAllocator;

	public string CommandLineArgs;

	public bool? isOnPTR;

	public string ServerGateway;

	private int int_45 = -1;

	private int int_46 = -1;

	public static int ObjectManager_SizeOf
	{
		[CompilerGenerated]
		get {
			return objectManagerSizeOf;
		}
	}

	public static int Offset_ObjectManager_RenderTick
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerRenderTick;
		}
	}

	public static int Offset_ObjectManager_InGameFlag
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerInGameFlag;
		}
	}

	public static int Offset_ObjectManager_GameServerAddress
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerGameServerAddress;
		}
	}

	public static int SizeOf_GameState
	{
		[CompilerGenerated]
		get {
			return sizeOfGameState;
		}
	}

	public static int Offset_GameState_Validation3
	{
		[CompilerGenerated]
		get {
			return offsetGameStateValidation3;
		}
	}

	public static int Offset_GameState_LoadingScreenEnabled
	{
		[CompilerGenerated]
		get {
			return offsetGameStateLoadingScreenEnabled;
		}
	}

	public static int Offset_GameState_RiftProgressAccumulated
	{
		[CompilerGenerated]
		get {
			return offsetGameStateRiftProgressAccumulated;
		}
	}

	public static int Offset_GameState_Validation1
	{
		[CompilerGenerated]
		get {
			return offsetGameStateValidation1;
		}
	}

	public static int Offset_GameState_Validation2
	{
		[CompilerGenerated]
		get {
			return offsetGameStateValidation2;
		}
	}

	public static int Offset_GameState_IsGamePaused
	{
		[CompilerGenerated]
		get {
			return offsetGameStateIsGamePaused;
		}
	}

	public static int Offset_ObjectManager_Storage
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerStorage;
		}
	}

	public static int Offset_Storage_GameDifficulty
	{
		[CompilerGenerated]
		get {
			return offsetStorageGameDifficulty;
		}
	}

	public static int Offset_Storage_GameTick
	{
		[CompilerGenerated]
		get {
			return offsetStorageGameTick;
		}
	}

	public static int Offset_PlayerDataManager_Elements
	{
		[CompilerGenerated]
		get {
			return offsetPlayerDataManagerElements;
		}
	}

	public static int Offset_Storage_FastAttrib
	{
		[CompilerGenerated]
		get {
			return offsetStorageFastAttrib;
		}
	}

	public static int Offset_FastAttrib_FastAttribGroups
	{
		[CompilerGenerated]
		get {
			return offsetFastAttribFastAttribGroups;
		}
	}

	public static int Offset_Storage_QuestManager
	{
		[CompilerGenerated]
		get {
			return offsetStorageQuestManager;
		}
	}

	public static int Offset_Storage_WaypointManager
	{
		[CompilerGenerated]
		get {
			return offsetStorageWaypointManager;
		}
	}

	public static int Offset_ObjectManager_Actors
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerActors;
		}
	}

	public static int Offset_ObjectManager_Scenes
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerScenes;
		}
	}

	public static int Offset_ObjectManager_UIManager
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerUIManager;
		}
	}

	public static int Offset_UIManager_SelectedActor1
	{
		[CompilerGenerated]
		get {
			return offsetUIManagerSelectedActor1;
		}
	}

	public static int Offset_UIManager_SelectedActor2
	{
		[CompilerGenerated]
		get {
			return offsetUIManagerSelectedActor2;
		}
	}

	public static int Offset_ObjectManager_Worlds
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerWorlds;
		}
	}

	public static int Offset_Player_LocalPlayerIndex
	{
		[CompilerGenerated]
		get {
			return offsetPlayerLocalPlayerIndex;
		}
	}

	public static int Offset_Player_FloatingNumbers
	{
		[CompilerGenerated]
		get {
			return offsetPlayerFloatingNumbers;
		}
	}

	public static int FloatingNumAllocatorOffset2
	{
		[CompilerGenerated]
		get {
			return floatingNumAllocatorOffset2;
		}
	}

	public static int Offset_CircularBuffer_Free
	{
		[CompilerGenerated]
		get {
			return offsetCircularBufferFree;
		}
	}

	public static int Offset_CircularBuffer_Head
	{
		[CompilerGenerated]
		get {
			return offsetCircularBufferHead;
		}
	}

	public static int Offset_CircularBuffer_Tail
	{
		[CompilerGenerated]
		get {
			return offsetCircularBufferTail;
		}
	}

	public static int Offset_CircularBuffer_Used
	{
		[CompilerGenerated]
		get {
			return offsetCircularBufferUsed;
		}
	}

	public static int Offset_CircularBuffer_Buffer
	{
		[CompilerGenerated]
		get {
			return offsetCircularBufferBuffer;
		}
	}

	public static int Offset_ObjectManager_TimedEvents
	{
		[CompilerGenerated]
		get {
			return offsetObjectManagerTimedEvents;
		}
	}

	public static int Unused
	{
		[CompilerGenerated]
		get {
			return unused;
		}
	}

	public long ObjectManagerStorageAddress
	{
		[CompilerGenerated]
		get {
			return objectManagerStorageAddress;
		}
		[CompilerGenerated]
		private set {
			objectManagerStorageAddress = value;
		}
	}

	public long UIManagerAddress
	{
		[CompilerGenerated]
		get {
			return uIManagerAddress;
		}
		[CompilerGenerated]
		private set {
			uIManagerAddress = value;
		}
	}

	public long QuestManagerAddress
	{
		[CompilerGenerated]
		get {
			return questManagerAddress;
		}
		[CompilerGenerated]
		private set {
			questManagerAddress = value;
		}
	}

	public long WaypointManagerAddress
	{
		[CompilerGenerated]
		get {
			return waypointManagerAddress;
		}
		[CompilerGenerated]
		private set {
			waypointManagerAddress = value;
		}
	}

	public bool ObjectManager_GameState_HasValue
	{
		[CompilerGenerated]
		get {
			return objectManagerGameStateHasValue;
		}
		[CompilerGenerated]
		private set {
			objectManagerGameStateHasValue = value;
		}
	}

	public bool GameState_Value_IsChallengeRiftGame
	{
		[CompilerGenerated]
		get {
			return gameStateValueIsChallengeRiftGame;
		}
		[CompilerGenerated]
		private set {
			gameStateValueIsChallengeRiftGame = value;
		}
	}

	public int GameState_LoadingScreenEnabled_Value
	{
		[CompilerGenerated]
		get {
			return gameStateLoadingScreenEnabledValue;
		}
		[CompilerGenerated]
		private set {
			gameStateLoadingScreenEnabledValue = value;
		}
	}

	public int GameState_Paused_Value
	{
		[CompilerGenerated]
		get {
			return gameStatePausedValue;
		}
		[CompilerGenerated]
		private set {
			gameStatePausedValue = value;
		}
	}

	public float GameState_RiftProgressAccumulated_Value
	{
		[CompilerGenerated]
		get {
			return gameStateRiftProgressAccumulatedValue;
		}
		[CompilerGenerated]
		private set {
			gameStateRiftProgressAccumulatedValue = value;
		}
	}

	public float MaxQuestProgress
	{
		[CompilerGenerated]
		get {
			return maxQuestProgress;
		}
	}

	public int CurrentTimedEventStartTick
	{
		[CompilerGenerated]
		get {
			return currentTimedEventStartTick;
		}
		[CompilerGenerated]
		private set {
			currentTimedEventStartTick = value;
		}
	}

	public int CurrentTimedEventEndTick
	{
		[CompilerGenerated]
		get {
			return currentTimedEventEndTick;
		}
		[CompilerGenerated]
		private set {
			currentTimedEventEndTick = value;
		}
	}

	public int CurrentTimedEventEndTickMod
	{
		[CompilerGenerated]
		get {
			return currentTimedEventEndTickMod;
		}
		[CompilerGenerated]
		private set {
			currentTimedEventEndTickMod = value;
		}
	}

	public bool IsUiHidden
	{
		[CompilerGenerated]
		get {
			return isUiHidden;
		}
		[CompilerGenerated]
		private set {
			isUiHidden = value;
		}
	}

	public int RenderTick
	{
		[CompilerGenerated]
		get {
			return renderTick;
		}
		[CompilerGenerated]
		private set {
			renderTick = value;
		}
	}

	public int GameTick
	{
		[CompilerGenerated]
		get {
			return gameTick;
		}
		[CompilerGenerated]
		private set {
			gameTick = value;
		}
	}

	public int LocalPlayerIndex
	{
		[CompilerGenerated]
		get {
			return localPlayerIndex;
		}
		[CompilerGenerated]
		private set {
			localPlayerIndex = value;
		}
	}

	public GameDifficulty GameDifficulty
	{
		[CompilerGenerated]
		get {
			return gameDifficulty;
		}
		[CompilerGenerated]
		private set {
			gameDifficulty = value;
		}
	}

	public BountyAct ActMapCurrentAct
	{
		[CompilerGenerated]
		get {
			return actMapCurrentAct;
		}
		[CompilerGenerated]
		private set {
			actMapCurrentAct = value;
		}
	}

	public double AverageLatency
	{
		[CompilerGenerated]
		get {
			return averageLatency;
		}
		[CompilerGenerated]
		private set {
			averageLatency = value;
		}
	}

	public double CurrentLatency
	{
		[CompilerGenerated]
		get {
			return currentLatency;
		}
		[CompilerGenerated]
		private set {
			currentLatency = value;
		}
	}

	public uint SelectedActor1_AcdId
	{
		[CompilerGenerated]
		get {
			return selectedActor1AcdId;
		}
		[CompilerGenerated]
		private set {
			selectedActor1AcdId = value;
		}
	}

	public uint SelectedActor2_AcdId
	{
		[CompilerGenerated]
		get {
			return selectedActor2AcdId;
		}
		[CompilerGenerated]
		private set {
			selectedActor2AcdId = value;
		}
	}

	public D3Memory()
	{
		ACDContainer = new ExpandableContainer(8192, Constants.ACD_SizeOf);
		ActorContainer = new ExpandableContainer(8192, Constants.Actor_SizeOf);
		FastAttribGroupContainer = new ExpandableContainer(8192, Constants.FastAttribGroup_SizeOf);
		WorldContainer = new Container(128);
		SceneContainer = new Container(1024);
		AttribAllocator = new Allocator(8192, "rAttribAllocator");
		FloatingNumberAllocator = new Allocator(8192, "rFloatingNumberAllocator");
	}

	public string ReadGameServerIP()
	{
		string text = GameWindowManager.ReadString(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_GameServerAddress, 128, Encoding.ASCII, true);
		if (!text.Contains(":")) {
			return text;
		}
		return text.Split(':')[0];
	}

	public void Update()
	{
		int num = GameWindowManager.Read<int>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_InGameFlag);
		ObjectManager_GameState_HasValue = num == 1 || num == 6;
		GameState_Value_IsChallengeRiftGame = num == 6;
		IsUiHidden = (GameWindowManager.Read<int>(AddressList.UiIsHiddenFlagAddress, true) & 0x400000) != 0;
		RenderTick = GameWindowManager.Read<int>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_RenderTick);
		if (!isOnPTR.HasValue) {
			CheckIsOnPTR(GameWindowManager.Process);
		}
		if (string.IsNullOrEmpty(ServerGateway)) {
			ReadGameServerIP();
			if (CoreCollector.DAF.RealmAddress != 0L) {
				ServerGateway = GameWindowManager.ReadString(CoreCollector.DAF.RealmAddress + CoreCollector.DAF.Offset_Realm_ServerGateway, 65, Encoding.UTF8, true);
				if (!ServerGateway.Contains(".")) {
					ServerGateway = null;
				} else if (!string.IsNullOrEmpty(ServerGateway)) {
					ServerGateway = ServerGateway.Split('.')[0];
				}
			} else {
				ServerGateway = null;
			}
		}
		if (ObjectManager_GameState_HasValue) {
			GameState_LoadingScreenEnabled_Value = GameWindowManager.Read<int>(CoreCollector.DAF.GameStateAddress + Offset_GameState_LoadingScreenEnabled);
			GameState_Paused_Value = GameWindowManager.Read<int>(CoreCollector.DAF.GameStateAddress + Offset_GameState_IsGamePaused);
			GameState_RiftProgressAccumulated_Value = GameWindowManager.Read<float>(CoreCollector.DAF.GameStateAddress + Offset_GameState_RiftProgressAccumulated);
			if (float.IsNaN(GameState_RiftProgressAccumulated_Value)) {
				GameState_RiftProgressAccumulated_Value = 0f;
			}
			if (GameState_RiftProgressAccumulated_Value > MaxQuestProgress) {
				GameState_RiftProgressAccumulated_Value = MaxQuestProgress;
			}
			long num2 = GameWindowManager.Read<long>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_TimedEvents);
			long num3 = GameWindowManager.Read<long>(num2);
			int num4 = 0;
			while (num3 != 0L && num3 != uint.MaxValue && num4 < 1000) {
				if (GameWindowManager.Read<int>(num3) != 382698) {
					num4++;
					num3 = GameWindowManager.Read<long>(num3 + 16);
					continue;
				}
				CurrentTimedEventStartTick = GameWindowManager.Read<int>(num3 + 4);
				CurrentTimedEventEndTick = GameWindowManager.Read<int>(num3 + 8);
				CurrentTimedEventEndTickMod = GameWindowManager.Read<int>(num3 + 12);
				break;
			}
		}
		ObjectManagerStorageAddress = CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Storage;
		LocalPlayerIndex = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_Player_LocalPlayerIndex);
		if (ObjectManager_GameState_HasValue) {
			ActMapCurrentAct = (BountyAct)GameWindowManager.Read<int>(AddressList.SelectedActOnMap, true);
			GameDifficulty = (GameDifficulty)GameWindowManager.Read<int>(ObjectManagerStorageAddress + Offset_Storage_GameDifficulty);
			int num5 = GameWindowManager.Read<int>(ObjectManagerStorageAddress + Offset_Storage_GameTick);
			if (GameState_Paused_Value == 0) {
				if (int_44 == num5 && stopwatch_0 != null) {
					GameTick = num5 + (int)Math.Floor((double)stopwatch_0.ElapsedMilliseconds * 60.0 / 1000.0);
				} else {
					stopwatch_0.Restart();
					GameTick = num5;
				}
				int_44 = num5;
			} else {
				GameTick = num5;
				int_44 = num5;
				stopwatch_0.Restart();
			}
			int num6 = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Free);
			int num7 = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Head);
			int num8 = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Tail);
			int num9 = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Used);
			if (num9 > 0 && (int_45 != num7 || int_46 != num8)) {
				int_45 = num7;
				int_46 = num8;
				AverageLatency = 0.0;
				int num10 = int_45;
				int num11 = 0;
				while (num10 != int_46 && num11 < 100) {
					num11++;
					int num12 = GameWindowManager.Read<int>(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Buffer + num10 * 4);
					AverageLatency += num12;
					num10 = (num10 + 1) % (num9 + num6);
					if (num10 == num8) {
						CurrentLatency = num12;
					}
				}
				AverageLatency = Math.Truncate(AverageLatency / (double)num9);
			}
			FloatingNumberAllocator.Snapshot(CoreCollector.DAF.PlayerAddress + Offset_Player_FloatingNumbers + FloatingNumAllocatorOffset2);
		} else {
			GameTick = 1;
			GameDifficulty = GameDifficulty.unknown;
		}
		long num13 = GameWindowManager.Read<long>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Actors);
		long num14 = GameWindowManager.Read<long>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Worlds);
		long num15 = GameWindowManager.Read<long>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Scenes);
		long num16 = GameWindowManager.Read<long>(ObjectManagerStorageAddress + Offset_Storage_FastAttrib);
		long num17 = GameWindowManager.Read<long>(num16 + Offset_FastAttrib_FastAttribGroups);
		AttribAllocator.Snapshot(num16); // Offset_FastAttrib_BucketAllocator1 == 0?
		long num18 = GameWindowManager.Read<long>(CoreCollector.DAF.AcdManagerAddress + CoreCollector.DAF.AcdManager_ACDs_Offset);
		ACDContainer.Snapshot(num18);
		ActorContainer.Snapshot(num13);
		FastAttribGroupContainer.Snapshot(num17);
		WorldContainer.Snapshot(num14);
		SceneContainer.Snapshot(num15);
		UIManagerAddress = GameWindowManager.Read<long>(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_UIManager);
		QuestManagerAddress = GameWindowManager.Read<long>(ObjectManagerStorageAddress + Offset_Storage_QuestManager);
		WaypointManagerAddress = GameWindowManager.Read<long>(ObjectManagerStorageAddress + Offset_Storage_WaypointManager);
		SelectedActor1_AcdId = GameWindowManager.Read<uint>(UIManagerAddress + Offset_UIManager_SelectedActor1);
		SelectedActor2_AcdId = GameWindowManager.Read<uint>(UIManagerAddress + Offset_UIManager_SelectedActor2);
	}

	private void CheckIsOnPTR(Process process)
	{
		try {
			using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id));
			ManagementObject managementObject = managementObjectSearcher.Get().Cast<ManagementObject>().FirstOrDefault();
			if (managementObject != null) {
				CommandLineArgs = (managementObject.Properties["CommandLine"].Value ?? "").ToString();
				isOnPTR = CommandLineArgs.Contains("OnlineService.PTR=true");
				return;
			}
		} catch (Exception) {
		}
		isOnPTR = null;
		CommandLineArgs = null;
	}
}
