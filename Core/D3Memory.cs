using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using structs;
using Plugins;
using SNO;

namespace work;

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
	private static readonly int int_16;

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

	public static int Offset_FastAttrib_BucketAllocator1
	{
		[CompilerGenerated]
		get {
			return int_16;
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
		string text = MR.Instance.ReadString(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_GameServerAddress, 128, Encoding.ASCII, bool_0: true);
		if (!text.Contains(":")) {
			return text;
		}
		return text.Split(':')[0];
	}

	public void Update()
	{
		int num = MR.Instance.ReadInt32_x64(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_InGameFlag);
		ObjectManager_GameState_HasValue = num == 1 || num == 6;
		GameState_Value_IsChallengeRiftGame = num == 6;
		IsUiHidden = (MR.Instance.ReadInt32_x64(AddressList.UiIsHiddenFlagAddress, bool_0: true) & 0x400000) != 0;
		RenderTick = MR.Instance.ReadInt32_x64(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_RenderTick);
		if (!isOnPTR.HasValue) {
			CheckIsOnPTR(MR.Instance.Process);
		}
		if (string.IsNullOrEmpty(ServerGateway)) {
			ReadGameServerIP();
			if (CoreCollector.DAF.RealmAddress != 0L) {
				ServerGateway = MR.Instance.ReadString(CoreCollector.DAF.RealmAddress + CoreCollector.DAF.Offset_Realm_ServerGateway, 65, Encoding.UTF8, bool_0: true);
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
			GameState_LoadingScreenEnabled_Value = MR.Instance.ReadInt32_x64(CoreCollector.DAF.GameStateAddress + Offset_GameState_LoadingScreenEnabled);
			GameState_Paused_Value = MR.Instance.ReadInt32_x64(CoreCollector.DAF.GameStateAddress + Offset_GameState_IsGamePaused);
			GameState_RiftProgressAccumulated_Value = MR.Instance.ReadFloat(CoreCollector.DAF.GameStateAddress + Offset_GameState_RiftProgressAccumulated);
			if (float.IsNaN(GameState_RiftProgressAccumulated_Value)) {
				GameState_RiftProgressAccumulated_Value = 0f;
			}
			if (GameState_RiftProgressAccumulated_Value > MaxQuestProgress) {
				GameState_RiftProgressAccumulated_Value = MaxQuestProgress;
			}
			long num2 = MR.Instance.ReadAddress(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_TimedEvents);
			long num3 = MR.Instance.ReadAddress(num2);
			int num4 = 0;
			while (num3 != 0L && num3 != uint.MaxValue && num4 < 1000) {
				if (MR.Instance.ReadInt32_x64(num3) != 382698) {
					num4++;
					num3 = MR.Instance.ReadAddress(num3 + 16);
					continue;
				}
				CurrentTimedEventStartTick = MR.Instance.ReadInt32_x64(num3 + 4);
				CurrentTimedEventEndTick = MR.Instance.ReadInt32_x64(num3 + 8);
				CurrentTimedEventEndTickMod = MR.Instance.ReadInt32_x64(num3 + 12);
				break;
			}
		}
		ObjectManagerStorageAddress = CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Storage;
		LocalPlayerIndex = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_Player_LocalPlayerIndex);
		if (ObjectManager_GameState_HasValue) {
			ActMapCurrentAct = (BountyAct)MR.Instance.ReadInt32_x64(AddressList.SelectedActOnMap, bool_0: true);
			GameDifficulty = (GameDifficulty)MR.Instance.ReadInt32_x64(ObjectManagerStorageAddress + Offset_Storage_GameDifficulty);
			int num5 = MR.Instance.ReadInt32_x64(ObjectManagerStorageAddress + Offset_Storage_GameTick);
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
			int num6 = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Free);
			int num7 = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Head);
			int num8 = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Tail);
			int num9 = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Used);
			if (num9 > 0 && (int_45 != num7 || int_46 != num8)) {
				int_45 = num7;
				int_46 = num8;
				AverageLatency = 0.0;
				int num10 = int_45;
				int num11 = 0;
				while (num10 != int_46 && num11 < 100) {
					num11++;
					int num12 = MR.Instance.ReadInt32_x64(CoreCollector.DAF.PlayerAddress + Offset_CircularBuffer_Buffer + num10 * 4);
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
		long num13 = MR.Instance.ReadAddress(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Actors);
		long num14 = MR.Instance.ReadAddress(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Worlds);
		long num15 = MR.Instance.ReadAddress(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_Scenes);
		long num16 = MR.Instance.ReadAddress(ObjectManagerStorageAddress + Offset_Storage_FastAttrib);
		long num17 = MR.Instance.ReadAddress(num16 + Offset_FastAttrib_FastAttribGroups);
		AttribAllocator.Snapshot(num16 + Offset_FastAttrib_BucketAllocator1);
		long num18 = MR.Instance.ReadAddress(CoreCollector.DAF.AcdManagerAddress + CoreCollector.DAF.AcdManager_ACDs_Offset);
		ACDContainer.Snapshot(num18);
		ActorContainer.Snapshot(num13);
		FastAttribGroupContainer.Snapshot(num17);
		WorldContainer.Snapshot(num14);
		SceneContainer.Snapshot(num15);
		UIManagerAddress = MR.Instance.ReadAddress(CoreCollector.DAF.ObjectManagerAddress + Offset_ObjectManager_UIManager);
		QuestManagerAddress = MR.Instance.ReadAddress(ObjectManagerStorageAddress + Offset_Storage_QuestManager);
		WaypointManagerAddress = MR.Instance.ReadAddress(ObjectManagerStorageAddress + Offset_Storage_WaypointManager);
		SelectedActor1_AcdId = MR.Instance.ReadUInt(UIManagerAddress + Offset_UIManager_SelectedActor1);
		SelectedActor2_AcdId = MR.Instance.ReadUInt(UIManagerAddress + Offset_UIManager_SelectedActor2);
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

	private IEnumerable<T> method_4<T>(T[] gparam_0, int int_47)
	{
		for (int i = 0; i <= int_47; i++) {
			yield return gparam_0[i];
		}
	}

	private string method_5(IPlayer iplayer_0)
	{
		string[] obj = new string[12]
		{
			"\tMe=",
			iplayer_0.IsMe ? "1" : "0",
			"\tDecryptedAcdId=0x",
			iplayer_0.AcdId.ToString("X8"),
			", AnnId=0x",
			iplayer_0.AnnId.ToString("X8"),
			", WorldId=0x",
			iplayer_0.WorldId.ToString("X8"),
			", HeroClass=",
			iplayer_0.HeroClassDefinition.HeroClass.ToString(),
			", Area=",
			null
		};
		ISnoArea snoArea = iplayer_0.SnoArea;
		object obj2;
		if (snoArea == null) {
			obj2 = null;
		} else {
			obj2 = snoArea.NameEnglish;
			if (obj2 != null) {
				goto IL_00cc;
			}
		}
		obj2 = "-";
		goto IL_00cc;
	IL_00cc:
		obj[11] = (string)obj2;
		return string.Concat(obj);
	}

	private string method_6(r_World struct38_0)
	{
		return "\tSno=0x" + struct38_0.WorldSno.ToString("X8") + "\tWorldId=0x" + struct38_0.SWorldID.ToString("X8");
	}

	private string method_7(r_Scene struct22_0)
	{
		string[] obj = new string[12]
		{
			"\tId=0x",
			struct22_0.Id.ToString("X8"),
			"\tSno=0x",
			struct22_0.SceneSno.ToString("X8"),
			"\tNavMeshId=0x",
			struct22_0.SSceneID.ToString("X8"),
			", WorldId=0x",
			struct22_0.SWorldID.ToString("X8"),
			", AreaSno=0x",
			struct22_0.LevelAreaSNO.ToString("X8"),
			", AreaName=",
			null
		};
		ISnoArea snoArea = SnoData.Areas.GetSnoArea(struct22_0.LevelAreaSNO);
		object obj2;
		if (snoArea == null) {
			obj2 = null;
		} else {
			obj2 = snoArea.NameEnglish;
			if (obj2 != null) {
				goto IL_00c5;
			}
		}
		obj2 = "-";
		goto IL_00c5;
	IL_00c5:
		obj[11] = (string)obj2;
		return string.Concat(obj);
	}

	private string method_8(r_ACD struct7_0)
	{
		uint actorSnoEncrypted = struct7_0.ActorSnoEncrypted;
		string[] obj = new string[18]
		{
			"\tAcdId=0x",
			struct7_0.AcdId.ToString("X8"),
			", ActorSno=0x",
			struct7_0.ActorSnoEncrypted.ToString("X8"),
			", DecryptedActorSno=0x",
			actorSnoEncrypted.ToString("X8"),
			", AttributeGroupIdShort=0x",
			struct7_0.FastAttribGroupID.ToString("X8"),
			", Name=",
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		SnoActor actor = SnoData.Actors.GetActor((ActorSnoEnum)actorSnoEncrypted);
		string text2 = actor?.NameEnglish;
		if (string.IsNullOrEmpty(text2)) {
			text2 = actor?.Code;
		}
		if (string.IsNullOrEmpty(text2)) {
			text2 = "-";
		}
		obj[9] = text2;
		obj[10] = ", Location: ";
		ItemLocation itemLocation = (ItemLocation)struct7_0.ItemLocation;
		obj[11] = itemLocation.ToString();
		obj[12] = ", ItemX: ";
		obj[13] = struct7_0.ItemSlotX.ToString();
		obj[14] = ", ItemY: ";
		obj[15] = struct7_0.ItemSlotY.ToString();
		obj[16] = ", Hitpoints: ";
		obj[17] = Math.Round(struct7_0.HitPoints, 3).ToString();
		string text = string.Concat(obj);
		if (struct7_0.AcdId == uint.MaxValue) {
			return text;
		}
		if (CoreCollector.ACDCollector.SetIndexFromAcdId(struct7_0.AcdId)) {
			List<r_AttributeEntry> list = new List<r_AttributeEntry>();
			CoreCollector.ACDCollector.method_12(list);
			text = text + ", AttributeMap.Valid=" + CoreCollector.ACDCollector.AttributeMap.bool_0 + ", Address=" + CoreCollector.ACDCollector.AttributeMap.Int64_0 + (CoreCollector.ACDCollector.AttributeMap.bool_0 ? (", AttributeMapFlag: " + CoreCollector.ACDCollector.AttributeMapFlags) : "");
			text = text + ", AttributeMap.BucketAddressList=" + string.Join(", ", from long_0 in method_4(CoreCollector.ACDCollector.AttributeMap.long_2, CoreCollector.ACDCollector.AttributeMap.Int32_0)
																				  where long_0 != 0
																				  select long_0);
			return text + "\tAttributes=" + string.Join(", ", from string_0 in list.Select(delegate (r_AttributeEntry struct8_0)
			{
				int num = (int)(struct8_0.uint_0 & 0xFFF);
				if (num > 0 && num < SnoData.Attributes.ByIndex.Count) {
					AcdAttribute acdAttribute = SnoData.Attributes.ByIndex[num];
					if (acdAttribute != null) {
						return acdAttribute.Code;
					}
				}
				return (string)null;
			})
															  where string_0 != null
															  select string_0);
		}
		return text + "\tno acd data???";
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_AttributeEntry struct8_0, int int_47, int int_48);

	private string method_9(r_ACD struct7_0)
	{
		if (struct7_0.AcdId == uint.MaxValue) {
			return null;
		}
		uint actorSnoEncrypted = struct7_0.ActorSnoEncrypted;
		string[] obj = new string[10]
		{
			"\tAcdId=0x",
			struct7_0.AcdId.ToString("X8"),
			", ActorSno=0x",
			struct7_0.ActorSnoEncrypted.ToString("X8"),
			", DecryptedActorSno=0x",
			actorSnoEncrypted.ToString("X8"),
			", Name=",
			null,
			null,
			null
		};
		SnoActor actor = SnoData.Actors.GetActor((ActorSnoEnum)actorSnoEncrypted);
		string text2 = actor?.NameEnglish;
		if (string.IsNullOrEmpty(text2)) {
			text2 = actor?.Code;
		}
		if (string.IsNullOrEmpty(text2)) {
			text2 = "-";
		}
		obj[7] = text2;
		obj[8] = ", Hitpoints: ";
		obj[9] = struct7_0.HitPoints.ToString();
		string text = string.Concat(obj);
		text = text + "\n\t\tAttributeGroupIdShort=0x" + struct7_0.FastAttribGroupID.ToString("X8");
		if (CoreCollector.ACDCollector.SetIndexFromAcdId(struct7_0.AcdId)) {
			CoreCollector.ACDCollector.method_5();
			text = text + ", AttributeMap.Valid=" + CoreCollector.ACDCollector.AttributeMap.bool_0 + ", Address=" + CoreCollector.ACDCollector.AttributeMap.Int64_0 + (CoreCollector.ACDCollector.AttributeMap.bool_0 ? (", AttributeMapFlag: " + CoreCollector.ACDCollector.AttributeMapFlags) : "");
			text = text + "\n\t\tAttributeMap.BucketAddressList=" + string.Join(", ", from num5 in method_4(CoreCollector.ACDCollector.AttributeMap.long_2, CoreCollector.ACDCollector.AttributeMap.Int32_0)
																					  where num5 != 0
																					  select num5);
			if (CoreCollector.ACDCollector.AttributeMap.bool_0) {
				int int32_ = CoreCollector.ACDCollector.AttributeMap.Int32_0;
				for (int num = 0; num <= int32_; num++) {
					long long_0 = CoreCollector.ACDCollector.AttributeMap.long_2[num];
					int num2 = 0;
					while (long_0 != 0L && long_0 - 1 != uint.MaxValue && num2 < 20) {
						AllocatedBlock<r_AttributeEntry> @class = method_4(CoreCollector.ACDCollector.AttributeAllocationCache.class354_0, CoreCollector.ACDCollector.AttributeAllocationCache.int_1 - 1).FirstOrDefault((AllocatedBlock<r_AttributeEntry> class354_0) => long_0 >= class354_0.StartAddress && long_0 <= class354_0.LastElementAddress);
						if (@class != null) {
							long num3 = (long_0 - @class.StartAddress) / 16;
							if (!@class.IsAllocated((int)num3)) {
								num2++;
								r_AttributeEntry r_AttributeEntry2 = @class.Elements[num3];
								int num4 = (int)(r_AttributeEntry2.uint_0 & 0xFFF);
								if (num4 > 0 && num4 < SnoData.Attributes.ByIndex.Count) {
									AcdAttribute acdAttribute = SnoData.Attributes.ByIndex[num4];
									text = text + "\n\t\t" + num + "\t" + long_0 + "=" + @class.StartAddress + "[" + num3 + "]\t" + acdAttribute.Code + ((r_AttributeEntry2.long_0 == 0L || r_AttributeEntry2.long_0 - 1 == uint.MaxValue) ? "" : "\t->");
								} else {
									text = text + "\n\t\t" + num + "\t" + long_0 + "=" + @class.StartAddress + "[" + num3 + "]\tunknown attribute: " + num4;
								}
								long_0 = r_AttributeEntry2.long_0;
								continue;
							}
							text = text + "\n\t\t" + num + "\t" + long_0 + "=" + @class.StartAddress + "[" + num3 + "]\tfree in array";
							break;
						}
						text = text + "\n\t\t" + num + "\t" + long_0 + "\tcan't find array";
						break;
					}
				}
			}
			return text;
		}
		return text + "\tno acd data???";
	}

	private string method_10(r_Actor struct6_0)
	{
		uint acdIdEncrypted = struct6_0.AcdIdEncrypted;
		if (acdIdEncrypted != uint.MaxValue) {
			if (CoreCollector.ACDCollector.SetIndexFromAcdId(acdIdEncrypted)) {
				return "\tAcdId=0x" + struct6_0.AcdIdEncrypted.ToString("X8") + ", DecryptedAcdId=0x" + acdIdEncrypted.ToString("X8") + ", ActorId=0x" + struct6_0.ActorId.ToString("X8");
			}
			return "\tAcdId=0x" + struct6_0.AcdIdEncrypted.ToString("X8") + ", DecryptedAcdId=0x" + acdIdEncrypted.ToString("X8") + ", ActorId=0x" + struct6_0.ActorId.ToString("X8") + ", invalid acd id";
		}
		return "\tAcdId=0x" + struct6_0.AcdIdEncrypted.ToString("X8") + ", DecryptedAcdId=0x" + acdIdEncrypted.ToString("X8") + ", ActorId=0x" + struct6_0.ActorId.ToString("X8");
	}

	private string method_11<T>(AllocationCache<T> class352_0) where T : struct
	{
		string text = "\tArrayCount=" + class352_0.int_1 + ";";
		if (class352_0.class354_0 != null) {
			text = text + "\n\tArrays=\n" + string.Join(",\n", class352_0.class354_0.Select((AllocatedBlock<T> class354_0) => "\t\tFirstAddress=" + class354_0.StartAddress + "\n\t\tLastAddress=" + class354_0.LastElementAddress + "\n\t\t" + method_12(class354_0.Block)));
		}
		return text;
	}

	private string method_12(r_Block class64_0)
	{
		return "\tLimit=" + class64_0.Limit + "\n\t\t\tElementSize=" + class64_0.ElementSize + "\n\t\t\tElementCount=" + class64_0.ElementCount + "\n\t\t\tFreeCount=" + class64_0.FreeCount + "\n\t\t\tValid=" + (class64_0.GoodFood == CoreCollector.Magic_600DF00D);
	}

	private string method_13(Allocator class351_2)
	{
		return "\tElementSize=" + class351_2.RawAllocator.ElementSize + "\n\tLinkedListCount=" + class351_2.RawAllocator.LinkedListCount + "\n\tValid=" + (class351_2.RawAllocator.GoodFood == CoreCollector.Magic_600DF00D) + "\n\tBlocks=\n" + string.Join("\n", class351_2.RawBlocks.Select((r_Block class64_0) => "\t" + method_12(class64_0)));
	}

	private string method_14(Container class355_2)
	{
		return "\tMaxIndex=" + class355_2.MaxIndex + "\n\tValid=" + class355_2.IsValid + "\n\tAddress=" + class355_2.DataAddress;
	}

	private string method_15(ExpandableContainer class356_3)
	{
		return "\tMaxIndex=" + class356_3.MaxIndex + "\n\tValid=" + class356_3.IsValid + "\n\tBlockCount=" + class356_3.BlockCount + "\n\tBlockAddressList=" + string.Join(", ", class356_3.BlockPointers);
	}

	[CompilerGenerated]
	private string method_16<T>(AllocatedBlock<T> class354_0) where T : struct
	{
		return "\t\tFirstAddress=" + class354_0.StartAddress + "\n\t\tLastAddress=" + class354_0.LastElementAddress + "\n\t\t" + method_12(class354_0.Block);
	}

	[CompilerGenerated]
	private string method_17(r_Block class64_0)
	{
		return "\t" + method_12(class64_0);
	}

	// decompiler artifacts removed: D3Memory is not a SnoActor
}
