using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;

namespace RiftAssistant.Engine;

internal class D3Memory
{

	private int int_44;

	private Stopwatch stopwatch = new();

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

	public static int ObjectManager_SizeOf { get; } = 2976;

	public static int Offset_ObjectManager_RenderTick { get; } = 84;

	public static int Offset_ObjectManager_InGameFlag { get; } = 132;

	public static int Offset_ObjectManager_GameServerAddress { get; } = 196;

	public static int SizeOf_GameState { get; } = 384;

	public static int Offset_GameState_Validation3 { get; } = 28;

	public static int Offset_GameState_LoadingScreenEnabled { get; } = 108;

	public static int Offset_GameState_RiftProgressAccumulated { get; } = 260;

	public static int Offset_GameState_Validation1 { get; } = 280;

	public static int Offset_GameState_Validation2 { get; } = 288;

	public static int Offset_GameState_IsGamePaused { get; } = 348;

	public static int Offset_ObjectManager_Storage { get; } = 1976;

	public static int Offset_Storage_GameDifficulty { get; } = 4;

	public static int Offset_Storage_GameTick { get; } = 288;

	public static int Offset_PlayerDataManager_Elements { get; } = 96;

	public static int Offset_Storage_FastAttrib { get; } = 384;

	public static int Offset_FastAttrib_FastAttribGroups { get; } = 144;

	public static int Offset_Storage_QuestManager { get; } = 440;

	public static int Offset_Storage_WaypointManager { get; } = 528;

	public static int Offset_ObjectManager_Actors { get; } = 2592;

	public static int Offset_ObjectManager_Scenes { get; } = 2720;

	public static int Offset_ObjectManager_UIManager { get; } = 2824;

	public static int Offset_UIManager_SelectedActor1 { get; } = 9912;

	public static int Offset_UIManager_SelectedActor2 { get; } = 3680;

	public static int Offset_ObjectManager_Worlds { get; } = 2840;

	public static int Offset_Player_LocalPlayerIndex { get; } = 0;

	public static int Offset_Player_FloatingNumbers { get; } = 41496;

	public static int FloatingNumAllocatorOffset2 { get; } = 32;

	public static int Offset_CircularBuffer_Free { get; } = 41800;

	public static int Offset_CircularBuffer_Head { get; } = 41808;

	public static int Offset_CircularBuffer_Tail { get; } = 41816;

	public static int Offset_CircularBuffer_Used { get; } = 41824;

	public static int Offset_CircularBuffer_Buffer { get; } = 41832;

	public static int Offset_ObjectManager_TimedEvents { get; } = 2936;

	public static int Unused { get; } = 12;

	public long ObjectManagerStorageAddress { get; private set; }

	public long UIManagerAddress { get; private set; }

	public long QuestManagerAddress { get; private set; }

	public long WaypointManagerAddress { get; private set; }

	public bool ObjectManager_GameState_HasValue { get; private set; }

	public bool GameState_Value_IsChallengeRiftGame { get; private set; }

	public int GameState_LoadingScreenEnabled_Value { get; private set; }

	public int GameState_Paused_Value { get; private set; }

	public float GameState_RiftProgressAccumulated_Value { get; private set; }

	public float MaxQuestProgress { get; } = 650f;

	public int CurrentTimedEventStartTick { get; private set; }

	public int CurrentTimedEventEndTick { get; private set; }

	public int CurrentTimedEventEndTickMod { get; private set; }

	public bool IsUiHidden { get; private set; }

	public int RenderTick { get; private set; }

	public int GameTick { get; private set; }

	public int LocalPlayerIndex { get; private set; }

	public GameDifficulty GameDifficulty { get; private set; }

	public BountyAct ActMapCurrentAct { get; private set; }

	public double AverageLatency { get; private set; }

	public double CurrentLatency { get; private set; }

	public uint SelectedActor1_AcdId { get; private set; }

	public uint SelectedActor2_AcdId { get; private set; }

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
				if (int_44 == num5 && stopwatch != null) {
					GameTick = num5 + (int)Math.Floor((double)stopwatch.ElapsedMilliseconds * 60.0 / 1000.0);
				} else {
					stopwatch.Restart();
					GameTick = num5;
				}
				int_44 = num5;
			} else {
				GameTick = num5;
				int_44 = num5;
				stopwatch.Restart();
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
