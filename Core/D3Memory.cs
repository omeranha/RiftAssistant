using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;

internal class D3Memory
{
	[CompilerGenerated]
	private static readonly int int_0 = 2976;

	[CompilerGenerated]
	private static readonly int int_1 = 84;

	[CompilerGenerated]
	private static readonly int int_2 = 132;

	[CompilerGenerated]
	private static readonly int int_3 = 196;

	[CompilerGenerated]
	private static readonly int int_4 = 384;

	[CompilerGenerated]
	private static readonly int int_5 = 28;

	[CompilerGenerated]
	private static readonly int int_6 = 108;

	[CompilerGenerated]
	private static readonly int int_7 = 260;

	[CompilerGenerated]
	private static readonly int int_8 = 280;

	[CompilerGenerated]
	private static readonly int int_9 = 288;

	[CompilerGenerated]
	private static readonly int int_10 = 348;

	[CompilerGenerated]
	private static readonly int int_11 = 1976;

	[CompilerGenerated]
	private static readonly int int_12 = 4;

	[CompilerGenerated]
	private static readonly int int_13 = 288;

	[CompilerGenerated]
	private static readonly int int_14 = 96;

	[CompilerGenerated]
	private static readonly int int_15 = 384;

	[CompilerGenerated]
	private static readonly int int_17 = 144;

	[CompilerGenerated]
	private static readonly int int_18 = 440;

	[CompilerGenerated]
	private static readonly int int_19 = 528;

	[CompilerGenerated]
	private static readonly int int_20 = 2592;

	[CompilerGenerated]
	private static readonly int int_21 = 2720;

	[CompilerGenerated]
	private static readonly int int_22 = 2824;

	[CompilerGenerated]
	private static readonly int int_23 = 9912;

	[CompilerGenerated]
	private static readonly int int_24 = 3680;

	[CompilerGenerated]
	private static readonly int int_25 = 2840;

	[CompilerGenerated]
	private static readonly int int_26 = 0;

	[CompilerGenerated]
	private static readonly int int_27 = 41496;

	[CompilerGenerated]
	private static readonly int int_28 = 32;

	[CompilerGenerated]
	private static readonly int int_29 = 41800;

	[CompilerGenerated]
	private static readonly int int_30 = 41808;

	[CompilerGenerated]
	private static readonly int int_31 = 41816;

	[CompilerGenerated]
	private static readonly int int_32 = 41824;

	[CompilerGenerated]
	private static readonly int int_33 = 41832;

	[CompilerGenerated]
	private static readonly int int_34 = 2936;

	[CompilerGenerated]
	private static readonly int int_35 = 12;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private long long_2;

	[CompilerGenerated]
	private long long_3;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private int int_36;

	[CompilerGenerated]
	private int int_37;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private readonly float float_1 = 650f;

	[CompilerGenerated]
	private int int_38;

	[CompilerGenerated]
	private int int_39;

	[CompilerGenerated]
	private int int_40;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int int_41;

	[CompilerGenerated]
	private int int_42;

	[CompilerGenerated]
	private int int_43;

	private int int_44;

	private Stopwatch stopwatch_0 = new();

	[CompilerGenerated]
	private GameDifficulty gameDifficulty_0;

	[CompilerGenerated]
	private BountyAct bountyAct_0;

	[CompilerGenerated]
	private double double_0;

	[CompilerGenerated]
	private double double_1;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private uint uint_1;

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
			return int_0;
		}
	}

	public static int Offset_ObjectManager_RenderTick
	{
		[CompilerGenerated]
		get {
			return int_1;
		}
	}

	public static int Offset_ObjectManager_InGameFlag
	{
		[CompilerGenerated]
		get {
			return int_2;
		}
	}

	public static int Offset_ObjectManager_GameServerAddress
	{
		[CompilerGenerated]
		get {
			return int_3;
		}
	}

	public static int SizeOf_GameState
	{
		[CompilerGenerated]
		get {
			return int_4;
		}
	}

	public static int Offset_GameState_Validation3
	{
		[CompilerGenerated]
		get {
			return int_5;
		}
	}

	public static int Offset_GameState_LoadingScreenEnabled
	{
		[CompilerGenerated]
		get {
			return int_6;
		}
	}

	public static int Offset_GameState_RiftProgressAccumulated
	{
		[CompilerGenerated]
		get {
			return int_7;
		}
	}

	public static int Offset_GameState_Validation1
	{
		[CompilerGenerated]
		get {
			return int_8;
		}
	}

	public static int Offset_GameState_Validation2
	{
		[CompilerGenerated]
		get {
			return int_9;
		}
	}

	public static int Offset_GameState_IsGamePaused
	{
		[CompilerGenerated]
		get {
			return int_10;
		}
	}

	public static int Offset_ObjectManager_Storage
	{
		[CompilerGenerated]
		get {
			return int_11;
		}
	}

	public static int Offset_Storage_GameDifficulty
	{
		[CompilerGenerated]
		get {
			return int_12;
		}
	}

	public static int Offset_Storage_GameTick
	{
		[CompilerGenerated]
		get {
			return int_13;
		}
	}

	public static int Offset_PlayerDataManager_Elements
	{
		[CompilerGenerated]
		get {
			return int_14;
		}
	}

	public static int Offset_Storage_FastAttrib
	{
		[CompilerGenerated]
		get {
			return int_15;
		}
	}

	public static int Offset_FastAttrib_FastAttribGroups
	{
		[CompilerGenerated]
		get {
			return int_17;
		}
	}

	public static int Offset_Storage_QuestManager
	{
		[CompilerGenerated]
		get {
			return int_18;
		}
	}

	public static int Offset_Storage_WaypointManager
	{
		[CompilerGenerated]
		get {
			return int_19;
		}
	}

	public static int Offset_ObjectManager_Actors
	{
		[CompilerGenerated]
		get {
			return int_20;
		}
	}

	public static int Offset_ObjectManager_Scenes
	{
		[CompilerGenerated]
		get {
			return int_21;
		}
	}

	public static int Offset_ObjectManager_UIManager
	{
		[CompilerGenerated]
		get {
			return int_22;
		}
	}

	public static int Offset_UIManager_SelectedActor1
	{
		[CompilerGenerated]
		get {
			return int_23;
		}
	}

	public static int Offset_UIManager_SelectedActor2
	{
		[CompilerGenerated]
		get {
			return int_24;
		}
	}

	public static int Offset_ObjectManager_Worlds
	{
		[CompilerGenerated]
		get {
			return int_25;
		}
	}

	public static int Offset_Player_LocalPlayerIndex
	{
		[CompilerGenerated]
		get {
			return int_26;
		}
	}

	public static int Offset_Player_FloatingNumbers
	{
		[CompilerGenerated]
		get {
			return int_27;
		}
	}

	public static int FloatingNumAllocatorOffset2
	{
		[CompilerGenerated]
		get {
			return int_28;
		}
	}

	public static int Offset_CircularBuffer_Free
	{
		[CompilerGenerated]
		get {
			return int_29;
		}
	}

	public static int Offset_CircularBuffer_Head
	{
		[CompilerGenerated]
		get {
			return int_30;
		}
	}

	public static int Offset_CircularBuffer_Tail
	{
		[CompilerGenerated]
		get {
			return int_31;
		}
	}

	public static int Offset_CircularBuffer_Used
	{
		[CompilerGenerated]
		get {
			return int_32;
		}
	}

	public static int Offset_CircularBuffer_Buffer
	{
		[CompilerGenerated]
		get {
			return int_33;
		}
	}

	public static int Offset_ObjectManager_TimedEvents
	{
		[CompilerGenerated]
		get {
			return int_34;
		}
	}

	public static int Unused
	{
		[CompilerGenerated]
		get {
			return int_35;
		}
	}

	public long ObjectManagerStorageAddress
	{
		[CompilerGenerated]
		get {
			return long_0;
		}
		[CompilerGenerated]
		private set {
			long_0 = value;
		}
	}

	public long UIManagerAddress
	{
		[CompilerGenerated]
		get {
			return long_1;
		}
		[CompilerGenerated]
		private set {
			long_1 = value;
		}
	}

	public long QuestManagerAddress
	{
		[CompilerGenerated]
		get {
			return long_2;
		}
		[CompilerGenerated]
		private set {
			long_2 = value;
		}
	}

	public long WaypointManagerAddress
	{
		[CompilerGenerated]
		get {
			return long_3;
		}
		[CompilerGenerated]
		private set {
			long_3 = value;
		}
	}

	public bool ObjectManager_GameState_HasValue
	{
		[CompilerGenerated]
		get {
			return bool_0;
		}
		[CompilerGenerated]
		private set {
			bool_0 = value;
		}
	}

	public bool GameState_Value_IsChallengeRiftGame
	{
		[CompilerGenerated]
		get {
			return bool_1;
		}
		[CompilerGenerated]
		private set {
			bool_1 = value;
		}
	}

	public int GameState_LoadingScreenEnabled_Value
	{
		[CompilerGenerated]
		get {
			return int_36;
		}
		[CompilerGenerated]
		private set {
			int_36 = value;
		}
	}

	public int GameState_Paused_Value
	{
		[CompilerGenerated]
		get {
			return int_37;
		}
		[CompilerGenerated]
		private set {
			int_37 = value;
		}
	}

	public float GameState_RiftProgressAccumulated_Value
	{
		[CompilerGenerated]
		get {
			return float_0;
		}
		[CompilerGenerated]
		private set {
			float_0 = value;
		}
	}

	public float MaxQuestProgress
	{
		[CompilerGenerated]
		get {
			return float_1;
		}
	}

	public int CurrentTimedEventStartTick
	{
		[CompilerGenerated]
		get {
			return int_38;
		}
		[CompilerGenerated]
		private set {
			int_38 = value;
		}
	}

	public int CurrentTimedEventEndTick
	{
		[CompilerGenerated]
		get {
			return int_39;
		}
		[CompilerGenerated]
		private set {
			int_39 = value;
		}
	}

	public int CurrentTimedEventEndTickMod
	{
		[CompilerGenerated]
		get {
			return int_40;
		}
		[CompilerGenerated]
		private set {
			int_40 = value;
		}
	}

	public bool IsUiHidden
	{
		[CompilerGenerated]
		get {
			return bool_2;
		}
		[CompilerGenerated]
		private set {
			bool_2 = value;
		}
	}

	public int RenderTick
	{
		[CompilerGenerated]
		get {
			return int_41;
		}
		[CompilerGenerated]
		private set {
			int_41 = value;
		}
	}

	public int GameTick
	{
		[CompilerGenerated]
		get {
			return int_42;
		}
		[CompilerGenerated]
		private set {
			int_42 = value;
		}
	}

	public int LocalPlayerIndex
	{
		[CompilerGenerated]
		get {
			return int_43;
		}
		[CompilerGenerated]
		private set {
			int_43 = value;
		}
	}

	public GameDifficulty GameDifficulty
	{
		[CompilerGenerated]
		get {
			return gameDifficulty_0;
		}
		[CompilerGenerated]
		private set {
			gameDifficulty_0 = value;
		}
	}

	public BountyAct ActMapCurrentAct
	{
		[CompilerGenerated]
		get {
			return bountyAct_0;
		}
		[CompilerGenerated]
		private set {
			bountyAct_0 = value;
		}
	}

	public double AverageLatency
	{
		[CompilerGenerated]
		get {
			return double_0;
		}
		[CompilerGenerated]
		private set {
			double_0 = value;
		}
	}

	public double CurrentLatency
	{
		[CompilerGenerated]
		get {
			return double_1;
		}
		[CompilerGenerated]
		private set {
			double_1 = value;
		}
	}

	public uint SelectedActor1_AcdId
	{
		[CompilerGenerated]
		get {
			return uint_0;
		}
		[CompilerGenerated]
		private set {
			uint_0 = value;
		}
	}

	public uint SelectedActor2_AcdId
	{
		[CompilerGenerated]
		get {
			return uint_1;
		}
		[CompilerGenerated]
		private set {
			uint_1 = value;
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

	private void CheckIsOnPTR(Process process_0)
	{
		try {
			using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process_0.Id));
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
