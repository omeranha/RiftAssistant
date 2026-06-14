using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using collectors;
using structs;
using Plugins;
using SNO;

namespace work;

internal delegate bool Delegate7();

internal class DAF
{
	internal LocalHeapCache localHeapCache;

	private readonly Dictionary<string, Delegate7> blockValidateFuncs = new Dictionary<string, Delegate7>();

	private r_PlayerData struct32_0;

	public long ObjectManagerAddress { get; private set; }

	public long AcdManagerAddress { get; private set; }

	public long AcdManager_ACDs_Offset { get; private set; }

	public long PlayerDataManagerAddress { get; private set; }

	public long PlayerAddress { get; private set; }

	public long LevelAreaAddress { get; private set; }

	public long TrickleManagerAddress { get; private set; }

	public long BattleNetClientAddress { get; private set; }

	public long GameStateAddress { get; private set; }

	public long RealmAddress { get; private set; }

	public int Offset_Realm_ServerGateway { get; } = 32;

	public uint CryptoKey_Actor_AcdId { get; private set; }

	public uint CryptoKey_ACD_ActorSNO { get; private set; }

	public uint CryptoKey_ACD_SSceneID { get; private set; }

	public uint CryptoKey_ACD_SWorldID { get; private set; }

	public uint CryptoKey_PlayerData_AreaSno { get; private set; }

	public uint CryptoKey_PlayerData_ActorId { get; private set; }

	public uint CryptoKey_PlayerData_AcdId { get; private set; }

	public uint UInt32_7 { get; private set; }

	public uint CryptoKey_PlayerData_HostAreaSno { get; private set; }

	internal DAF()
	{
	}

	public void ClearObjectManagerAddr()
	{
		ObjectManagerAddress = 0L;
	}

	public uint DetermineCryptoKey_ActorACDID(IEnumerable<uint> ienumerable_0, IEnumerable<uint> ienumerable_1)
	{
		Dictionary<uint, bool> dictionary = new Dictionary<uint, bool>();
		List<uint> list_ = ienumerable_0.ToList();
		HashSet<uint> hashSet = new HashSet<uint>(ienumerable_1);
		foreach (uint item in ienumerable_0)
		{
			foreach (uint item2 in hashSet)
			{
				uint num = item ^ item2;
				if (!dictionary.ContainsKey(num))
				{
					bool value = CrossReferenceActorsWithACDs(list_, hashSet, num);
					dictionary.Add(num, value);
				}
				else if (dictionary[num] && !CrossReferenceActorsWithACDs(list_, hashSet, num))
				{
					dictionary[num] = false;
				}
			}
		}
		return dictionary.FirstOrDefault((KeyValuePair<uint, bool> keyValuePair_0) => keyValuePair_0.Value).Key;
	}

	private static bool CrossReferenceActorsWithACDs(List<uint> list_0, HashSet<uint> hashSet_0, uint uint_8)
	{
		foreach (uint item in list_0)
		{
			uint num = item ^ uint_8;
			if (num != uint.MaxValue && num != 0 && !hashSet_0.Contains(num))
			{
				return false;
			}
		}
		return true;
	}

	public bool IsScanRequired()
	{
		int num = 0;
		foreach (KeyValuePair<string, Delegate7> blockValidateFunc in blockValidateFuncs)
		{
			if (!blockValidateFunc.Value())
			{
				num++;
			}
		}
		return num > 0;
	}

	public void Scan()
	{
		if (GameWindowManager.Window.Handle == IntPtr.Zero) return;

		if (localHeapCache == null)
		{
			localHeapCache = new LocalHeapCache();
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		localHeapCache.Init(AddressList.PtrMemoryManager);
		blockValidateFuncs.Clear();
		stopwatch = Stopwatch.StartNew();
		Scan4ObjectManager();
		int num = MR.Instance.ReadInt32_x64(ObjectManagerAddress + D3Memory.Offset_ObjectManager_InGameFlag);
		if (num != 0)
		{
			Scan4LevelArea();
		}
		else
		{
			LevelAreaAddress = 0L;
		}
		long long_ = FindContainerByItemSize(localHeapCache, "acd", Constants.ACD_SizeOf);
		Scan4ACDManager(long_);
		Scan4Player();
		Scan4PlayerDataManager();
		Scan4TrickleManager();
		Scan4BattleNetClient();
		Scan4GameState();
		Scan4Realm();
		localHeapCache.ClearSmallBlocksCache();
	}

	public static ulong smethod_1(ulong ulong_0, int int_1)
	{
		return (ulong_0 >> int_1) | (ulong_0 << 64 - int_1);
	}

	public static ulong smethod_2(ulong ulong_0, int int_1)
	{
		return (ulong_0 << int_1) | (ulong_0 >> 64 - int_1);
	}

	private bool GetMoreCryptoKeys()
	{
		CryptoKey_Actor_AcdId = 0u;
		CryptoKey_ACD_ActorSNO = 0u;
		CryptoKey_ACD_SSceneID = 0u;
		CryptoKey_ACD_SWorldID = 0u;
		long long_ = MR.Instance.ReadAddress(ObjectManagerAddress + D3Memory.Offset_ObjectManager_Worlds);
		long long_2 = MR.Instance.ReadAddress(ObjectManagerAddress + D3Memory.Offset_ObjectManager_Scenes);
		CoreCollector.D3Memory.WorldContainer.Snapshot(long_);
		CoreCollector.D3Memory.SceneContainer.Snapshot(long_2);
		if (CoreCollector.D3Memory.WorldContainer.MaxIndex < 0)
		{
			return false;
		}
		if (CoreCollector.D3Memory.SceneContainer.MaxIndex < 0)
		{
			return false;
		}
		CoreCollector.SceneCollector.Collect();
		if (CoreCollector.SceneCollector.Buffer_Scenes == null)
		{
			return false;
		}
		int num = MR.Instance.ReadInt32_x64(PlayerAddress + D3Memory.Offset_Player_LocalPlayerIndex);
		long num2 = PlayerDataManagerAddress + D3Memory.Offset_PlayerDataManager_Elements + num * Constants.PlayerData_SizeOf;
		uint num3 = MR.Instance.ReadUInt(num2 + Constants.PlayerData_ACDID_Offset) ^ CryptoKey_PlayerData_AcdId;
		uint num4 = MR.Instance.ReadUInt(num2 + Constants.PlayerData_AreaSno_Offset) ^ CryptoKey_PlayerData_AreaSno;
		uint uint_ = MR.Instance.ReadUInt(num2 + Constants.PlayerData_HeroId_Offset);
		if (num4 == 0) {
			return false;
		}
		CoreCollector.HeroCollector.Collect();
		IHero hero = CoreCollector.HeroCollector.method_0(uint_);
		if (hero == null)
		{
			Logger.Info("[ERROR] deduction - unknown hero: " + uint_);
			return false;
		}
		uint num5 = (uint)(hero.IsMale ? hero.ClassDefinition.MaleActorSno : hero.ClassDefinition.FemaleActorSno);
		ISnoArea snoArea = SnoData.Areas.GetSnoArea(num4);
		if (snoArea == null) {
			return false;
		}
		long long_3 = MR.Instance.ReadAddress(ObjectManagerAddress + D3Memory.Offset_ObjectManager_Actors);
		CoreCollector.D3Memory.ActorContainer.Snapshot(long_3);
		if (!CoreCollector.D3Memory.ActorContainer.IsValid)
		{
			return false;
		}
		long long_4 = MR.Instance.ReadAddress(AcdManagerAddress + AcdManager_ACDs_Offset);
		CoreCollector.D3Memory.ACDContainer.Snapshot(long_4);
		if (!CoreCollector.D3Memory.ACDContainer.IsValid)
		{
			return false;
		}
		int num6 = CoreCollector.D3Memory.ActorContainer.MaxIndex + 1;
		r_Actor[] array = new r_Actor[num6];
		int num7 = 0;
		for (int i = 0; i < CoreCollector.D3Memory.ActorContainer.BlockCount; i++)
		{
			long num8 = CoreCollector.D3Memory.ActorContainer.BlockPointers[i];
			int num9 = Math.Min(CoreCollector.D3Memory.ActorContainer.BlocksItemCapacity, num6);
			ActorCollector.ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)num8, ref array[num7], Constants.Actor_SizeOf * num9, 0);
			num6 -= num9;
			num7 += num9;
		}
		num6 = CoreCollector.D3Memory.ACDContainer.MaxIndex + 1;
		r_ACD[] array2 = new r_ACD[num6];
		num7 = 0;
		for (int j = 0; j < CoreCollector.D3Memory.ACDContainer.BlockCount; j++)
		{
			long num10 = CoreCollector.D3Memory.ACDContainer.BlockPointers[j];
			int num11 = Math.Min(CoreCollector.D3Memory.ACDContainer.BlocksItemCapacity, num6);
			ACDCollector.ReadProcessMemory_1(MR.Instance.ProcessHandle, (IntPtr)num10, ref array2[num7], Constants.ACD_SizeOf * num11, 0);
			num6 -= num11;
			num7 += num11;
		}
		Dictionary<uint, int> dictionary = new Dictionary<uint, int>();
		r_Actor[] array3 = array;
		for (int k = 0; k < array3.Length; k++)
		{
			r_Actor r_Actor2 = array3[k];
			dictionary.TryGetValue(r_Actor2.AcdIdEncrypted, out var value);
			dictionary[r_Actor2.AcdIdEncrypted] = value + 1;
		}
		KeyValuePair<uint, int> keyValuePair = dictionary.OrderByDescending((KeyValuePair<uint, int> keyValuePair_0) => keyValuePair_0.Value).FirstOrDefault();
		uint uInt32_ = ((keyValuePair.Value >= 2) ? (keyValuePair.Key ^ 0xFFFFFFFFu) : DetermineCryptoKey_ActorACDID(array.Select((r_Actor struct6_0) => struct6_0.AcdIdEncrypted), array2.Select((r_ACD struct7_0) => struct7_0.AcdId)));
		CryptoKey_Actor_AcdId = uInt32_;
		CryptoKey_ACD_ActorSNO = 0u;
		for (int num12 = 0; num12 < array2.Length; num12++)
		{
			if (array2[num12].AcdId != num3)
			{
				continue;
			}
			uint actorSnoEncrypted = array2[num12].ActorSnoEncrypted;
			uint sSceneID_Encrypted = array2[num12].SSceneID_Encrypted;
			uint sWorldID_Encrypted = array2[num12].SWorldID_Encrypted;
			CryptoKey_ACD_ActorSNO = actorSnoEncrypted ^ num5;
			r_Scene? r_Scene2 = null;
			int num13 = 0;
			for (int num14 = 0; num14 < CoreCollector.SceneCollector.Buffer_Scenes.Length; num14++)
			{
				r_Scene value2 = CoreCollector.SceneCollector.Buffer_Scenes[num14];
				if (value2.Id == uint.MaxValue || value2.LevelAreaSNO == uint.MaxValue)
				{
					continue;
				}
				if (value2.LevelAreaSNO == num4)
				{
					if (value2.mesh_min_x <= array2[num12].PositionX && value2.mesh_max_x >= array2[num12].PositionX && value2.mesh_min_y <= array2[num12].PositionY && value2.mesh_max_y >= array2[num12].PositionY)
					{
						int num15 = method_7(sSceneID_Encrypted ^ value2.SSceneID, sWorldID_Encrypted ^ value2.SWorldID, array2);
						if (num15 >= 2 && (!r_Scene2.HasValue || value2.SquareCountX * value2.SquareCountY < r_Scene2.Value.SquareCountX * r_Scene2.Value.SquareCountY || (value2.SquareCountX * value2.SquareCountY == r_Scene2.Value.SquareCountX * r_Scene2.Value.SquareCountY && num13 < num15)))
						{
							r_Scene2 = value2;
							num13 = num15;
						}
					}
					else
					{
					}
				}
				else
				{
				}
			}
			if (!r_Scene2.HasValue)
			{
				for (int num16 = 0; num16 <= CoreCollector.D3Memory.SceneContainer.MaxIndex; num16++)
				{
					r_Scene value3 = CoreCollector.SceneCollector.Buffer_Scenes[num16];
					if (value3.Id == uint.MaxValue || value3.LevelAreaSNO == uint.MaxValue)
					{
						continue;
					}
					if (SnoData.Areas.GetSnoArea(value3.LevelAreaSNO) != null)
					{
						if (value3.mesh_min_x <= array2[num12].PositionX && value3.mesh_max_x >= array2[num12].PositionX && value3.mesh_min_y <= array2[num12].PositionY && value3.mesh_max_y >= array2[num12].PositionY)
						{
							int num17 = method_7(sSceneID_Encrypted ^ value3.SSceneID, sWorldID_Encrypted ^ value3.SWorldID, array2);
							if (num17 >= 2 && (!r_Scene2.HasValue || value3.SquareCountX * value3.SquareCountY < r_Scene2.Value.SquareCountX * r_Scene2.Value.SquareCountY || (value3.SquareCountX * value3.SquareCountY == r_Scene2.Value.SquareCountX * r_Scene2.Value.SquareCountY && num13 < num17)))
							{
								r_Scene2 = value3;
								num13 = num17;
							}
						}
						else
						{
						}
					}
					else
					{
					}
				}
			}
			if (r_Scene2.HasValue)
			{
				CryptoKey_ACD_SSceneID = sSceneID_Encrypted ^ r_Scene2.Value.SSceneID;
				CryptoKey_ACD_SWorldID = sWorldID_Encrypted ^ r_Scene2.Value.SWorldID;
			}
			else
			{
				Thread.Sleep(500);
				CryptoKey_ACD_SSceneID = 0u;
				CryptoKey_ACD_SWorldID = 0u;
			}
		}
		if (CryptoKey_ACD_ActorSNO == 0)
		{
		}
		return CryptoKey_ACD_SWorldID != 0;
	}

	private int method_7(uint uint_8, uint uint_9, r_ACD[] struct7_0)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < struct7_0.Length; i++)
		{
			uint sSceneID_Encrypted = struct7_0[i].SSceneID_Encrypted;
			uint sWorldID_Encrypted = struct7_0[i].SWorldID_Encrypted;
			if (sSceneID_Encrypted != 0 && sWorldID_Encrypted != 0)
			{
				num++;
				uint uint_10 = sSceneID_Encrypted ^ uint_8;
				uint uint_11 = sWorldID_Encrypted ^ uint_9;
				if ((uint_10 == uint.MaxValue || CoreCollector.SceneCollector.Buffer_Scenes.Any((r_Scene struct22_0) => struct22_0.SSceneID == uint_10)) && (uint_11 == uint.MaxValue || CoreCollector.SceneCollector.Buffer_Worlds.Any((r_World struct38_0) => struct38_0.SWorldID == uint_11)))
				{
					num2++;
				}
			}
		}
		return num2;
	}

	private void Scan4Realm()
	{
		int int_ = AlignedSize(448, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_).Where(method_9).FirstOrDefault();
		if (num != 0L)
		{
			if (num != RealmAddress)
			{
				RealmAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(RealmAddress);
			blockValidateFuncs["RealmAddress"] = () => method_9(RealmAddress) && localHeapCache.VerifyBlock(RealmAddress, int_2);
			return;
		}
		RealmAddress = 0L;
		throw new Exception("can't find player");
	}

	private bool method_9(long long_10)
	{
		string text = MR.Instance.ReadString(long_10 + Offset_Realm_ServerGateway, 128, Encoding.UTF8, bool_0: true);
		if (!string.IsNullOrEmpty(text))
		{
			return text.Contains("actual.battle.net");
		}
		return false;
	}

	private void Scan4ACDManager(long long_10)
	{
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(24800);
		long num = 0L;
		int int_ = 0;
		foreach (long item in mainBlocksWithSize)
		{
			if (method_23(item, long_10, out int_))
			{
				num = item;
				break;
			}
		}
		if (num != 0L)
		{
			if (num != AcdManagerAddress)
			{
				AcdManagerAddress = num;
			}
			AcdManager_ACDs_Offset = int_;
			int int_2 = localHeapCache.GetSizeOfBlock(AcdManagerAddress);
			blockValidateFuncs["AcdManagerAddress"] = () => localHeapCache.VerifyBlock(AcdManagerAddress, int_2);
			return;
		}
		AcdManagerAddress = 0L;
		throw new Exception("can't find acd manager");
	}

	private void Scan4PlayerDataManager()
	{
		int int_ = AlignedSize(8 * Constants.PlayerData_SizeOf + D3Memory.Offset_PlayerDataManager_Elements, 32);
		int localPlayerIndex = MR.Instance.ReadInt32_x64(PlayerAddress + D3Memory.Offset_Player_LocalPlayerIndex);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		long num = mainBlocksWithSize.Where(delegate(long long_0)
		{
			if (localHeapCache.ReadUInt32(long_0, 40L) != CoreCollector.Magic_600DF00D)
			{
				return false;
			}
			long num2 = long_0 + D3Memory.Offset_PlayerDataManager_Elements + Constants.PlayerData_SizeOf * localPlayerIndex;
			PlayerCollector.ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)num2, ref struct32_0, Constants.PlayerData_SizeOf, 0);
			return (struct32_0.UsedKanaiItemSno1 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno1)) && (struct32_0.UsedKanaiItemSno2 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno2)) && (struct32_0.UsedKanaiItemSno3 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno3));
		}).FirstOrDefault();
		if (num != 0L)
		{
			if (num != PlayerDataManagerAddress)
			{
				PlayerDataManagerAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(PlayerDataManagerAddress);
			blockValidateFuncs["PlayerDataManagerAddress"] = () => localHeapCache.ReadUInt32(PlayerDataManagerAddress, 40L) == CoreCollector.Magic_600DF00D && localHeapCache.VerifyBlock(PlayerDataManagerAddress, int_2);
			return;
		}
		PlayerDataManagerAddress = 0L;
		throw new Exception("can't find player data manager. candidate count: " + mainBlocksWithSize.Count());
	}

	private void Scan4Player()
	{
		int int_ = AlignedSize(41952, 32);
		long num = localHeapCache.GetMainBlocksWithSize(int_).Where(method_13).FirstOrDefault();
		if (num != 0L)
		{
			if (num != PlayerAddress)
			{
				PlayerAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(PlayerAddress);
			blockValidateFuncs["PlayerAddress"] = () => method_13(PlayerAddress) && localHeapCache.VerifyBlock(PlayerAddress, int_2);
			return;
		}
		PlayerAddress = 0L;
		throw new Exception("can't find player");
	}

	private bool method_13(long long_10)
	{
		long long_11 = long_10 + D3Memory.Offset_Player_FloatingNumbers + D3Memory.FloatingNumAllocatorOffset2;
		return localHeapCache.ReadUInt32(long_11, 40L) == CoreCollector.Magic_600DF00D;
	}

	private void Scan4ObjectManager()
	{
		int int_ = AlignedSize(D3Memory.ObjectManager_SizeOf, 32);
		int int_2 = AlignedSize(304, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		long num = mainBlocksWithSize.Where(delegate(long long_0)
		{
			long long_1 = localHeapCache.ReadInt64(long_0, D3Memory.Offset_ObjectManager_Worlds);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock == 0 || !localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2))
			{
				return false;
			}
			int num2 = localHeapCache.ReadInt32(long_1, 256L);
			if (num2 <= 0)
			{
				return false;
			}
			long long_2 = localHeapCache.ReadInt64(long_1, 288L);
			int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(long_2);
			return sizeOfBlock2 != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock2, 152 * num2);
		}).FirstOrDefault();
		if (num != 0L)
		{
			if (num != ObjectManagerAddress)
			{
				ObjectManagerAddress = num;
			}
			int int_3 = localHeapCache.GetSizeOfBlock(ObjectManagerAddress);
			blockValidateFuncs["ObjectManagerAddress"] = () => localHeapCache.VerifyBlock(ObjectManagerAddress, int_3);
			return;
		}
		ObjectManagerAddress = 0L;
		throw new Exception("can't find object manager");
	}

	public int method_15(long long_10)
	{
		return localHeapCache.GetSizeOfBlock(long_10);
	}

	private void Scan4GameState()
	{
		int int_ = AlignedSize(D3Memory.SizeOf_GameState, 32);
		long long_0 = MR.Instance.MainModuleHandle.ToInt64();
		long num = (from long_1 in localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_)
			where method_17(long_1, long_0)
			select long_1).FirstOrDefault();
		if (num != 0L)
		{
			if (num != GameStateAddress)
			{
				GameStateAddress = num;
			}
			blockValidateFuncs["GameStateAddress"] = () => method_17(GameStateAddress, long_0);
			return;
		}
		GameStateAddress = 0L;
		throw new Exception("can't find game state");
	}

	internal bool method_17(long long_10, long long_11)
	{
		long num = localHeapCache.ReadInt64(long_10, D3Memory.Offset_GameState_Validation1);
		long num2 = localHeapCache.ReadInt64(long_10, D3Memory.Offset_GameState_Validation2);
		if (num <= long_11 || num2 <= long_11)
		{
			return false;
		}
		if (num != num2 - 40)
		{
			return false;
		}
		if (localHeapCache.ReadInt32(long_10, D3Memory.Offset_GameState_Validation3) != 0)
		{
			return false;
		}
		int num3 = MR.Instance.ReadInt32_x64(long_10 + D3Memory.Offset_GameState_LoadingScreenEnabled);
		if (num3 != 0 && num3 != 1)
		{
			return false;
		}
		int num4 = MR.Instance.ReadInt32_x64(long_10 + D3Memory.Offset_GameState_IsGamePaused);
		if (num4 != 0)
		{
			return num4 == 1;
		}
		return true;
	}

	private void Scan4BattleNetClient()
	{
		int num = AlignedSize(3648, 32);
		long num2 = localHeapCache.GetMainBlocksWithSize(num).Concat(localHeapCache.GetMainBlocksWithSize(num + 32)).Where(delegate(long long_10)
		{
			long num3 = localHeapCache.ReadInt64(long_10, 312L);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(num3);
			if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, 832))
			{
				long long_11 = localHeapCache.ReadInt64(long_10, 320L);
				int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(long_11);
				if (sizeOfBlock2 != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock2, 384))
				{
					int num4 = MR.Instance.ReadInt32_x64(num3 + 88);
					int num5 = MR.Instance.ReadInt32_x64(num3 + 104);
					if (num5 >= 0 && num4 >= 0 && num5 <= num4)
					{
						return true;
					}
				}
			}
			return false;
		})
			.FirstOrDefault();
		if (num2 != 0L)
		{
			if (num2 != BattleNetClientAddress)
			{
				BattleNetClientAddress = num2;
			}
			int int_0 = localHeapCache.GetSizeOfBlock(BattleNetClientAddress);
			blockValidateFuncs["BattleNetClientAddress"] = () => localHeapCache.VerifyBlock(BattleNetClientAddress, int_0);
			return;
		}
		BattleNetClientAddress = 0L;
		throw new Exception("can't find bnet client");
	}

	private void Scan4LevelArea()
	{
		int int_ = AlignedSize(2432, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		AreaContainer class66_0 = new AreaContainer();
		long num = mainBlocksWithSize.Where(delegate(long long_0)
		{
			MR.Instance.ReadMem(long_0, class66_0, 24);
			if (localHeapCache.GetSizeOfBlock(class66_0.PrimaryAreaPtr) == 0)
			{
				return false;
			}
			if (localHeapCache.GetSizeOfBlock(class66_0.SecondaryAreaPtr) == 0)
			{
				return false;
			}
			long num2 = MR.Instance.ReadAddress(class66_0.PrimaryAreaPtr + 8);
			if (MR.Instance.ReadUInt(num2 + 40) != CoreCollector.Magic_600DF00D)
			{
				return false;
			}
			long num3 = MR.Instance.ReadAddress(class66_0.SecondaryAreaPtr + 8);
			return MR.Instance.ReadUInt(num3 + 40) == CoreCollector.Magic_600DF00D;
		}).FirstOrDefault();
		if (num != 0L)
		{
			if (num != LevelAreaAddress)
			{
				LevelAreaAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(LevelAreaAddress);
			blockValidateFuncs["LevelAreaAddress"] = () => localHeapCache.VerifyBlock(LevelAreaAddress, int_2);
		}
		else
		{
			LevelAreaAddress = 0L;
		}
	}

	private void Scan4TrickleManager()
	{
		int int_ = AlignedSize(16, 32);
		int int_2 = AlignedSize(48, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_).Where(delegate(long long_0)
		{
			long long_1 = localHeapCache.ReadInt64(long_0, AddressList.long_13);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D)
			{
				long long_2 = localHeapCache.ReadInt64(long_0, AddressList.long_14);
				if (localHeapCache.GetSizeOfBlock(long_2) != 0)
				{
					long_1 = localHeapCache.ReadInt64(long_2, AddressList.long_15);
					sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
					if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D)
					{
						return true;
					}
				}
			}
			return false;
		}).FirstOrDefault();
		if (num != 0L)
		{
			if (num != TrickleManagerAddress)
			{
				TrickleManagerAddress = num;
			}
			int int_3 = localHeapCache.GetSizeOfBlock(TrickleManagerAddress);
			blockValidateFuncs["TrickleManagerAddress"] = () => localHeapCache.VerifyBlock(TrickleManagerAddress, int_3);
			return;
		}
		TrickleManagerAddress = 0L;
		throw new Exception("can't find trickle manager");
	}

	private long FindContainerByItemSize(LocalHeapCache class332_1, string string_0, int int_1)
	{
		int int_2 = AlignedSize(364, 64);
		IEnumerable<long> smallBlocksWithSize_OrPlus0x = class332_1.GetSmallBlocksWithSize_OrPlus0x20(int_2);
		long num = smallBlocksWithSize_OrPlus0x.Where(delegate(long long_0)
		{
			if (class332_1.ReadUInt32(long_0, 328L) != CoreCollector.Magic_600DF00D)
			{
				return false;
			}
			int num2 = class332_1.ReadInt32(long_0, 256L);
			if (num2 <= 0)
			{
				return false;
			}
			long long_1 = class332_1.ReadInt64(long_0, 288L);
			long long_2 = class332_1.ReadInt64(long_1, 0L);
			int sizeOfBlock = class332_1.GetSizeOfBlock(long_2);
			int num3 = class332_1.ReadInt32(long_0, 296L);
			int int_3 = sizeOfBlock * num3;
			return class332_1.IsBlockSizeEqual_OrPlus0x20(int_3, int_1 * num2);
		}).FirstOrDefault();
		if (num == 0L)
		{
			Logger.Info("[ERROR] '" + string_0 + "' container candidate count: " + smallBlocksWithSize_OrPlus0x.Count() + ", struct size: " + int_1);
			method_22(smallBlocksWithSize_OrPlus0x, int_1);
			throw new Exception("can't find '" + string_0 + "' container");
		}
		return num;
	}

	private void method_22(IEnumerable<long> ienumerable_0, int int_1)
	{
		foreach (long item in ienumerable_0)
		{
			if (localHeapCache.ReadUInt32(item, 328L) == CoreCollector.Magic_600DF00D)
			{
				int num = localHeapCache.ReadInt32(item, 256L);
				if (num > 0)
				{
					long long_ = localHeapCache.ReadInt64(item, 288L);
					long long_2 = localHeapCache.ReadInt64(long_, 0L);
					int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_2);
					int num2 = localHeapCache.ReadInt32(item, 296L);
					int num3 = sizeOfBlock * num2;
				}
			}
		}
	}

	internal static byte[] smethod_3(string string_0, Func<string, uint, byte[]> func_0, uint uint_8)
	{
		return func_0(string_0, uint_8 * 2 - (uint)Environment.MachineName.GetHashCode());
	}

	public static int AlignedSize(int int_1, int int_2)
	{
		return (int_1 + (int_2 - 1)) / int_2 * int_2;
	}

	public bool method_23(long long_10, long long_11, out int int_1)
	{
		int num = Array.IndexOf(localHeapCache.ReadBlockPointers(long_10, localHeapCache.GetSizeOfBlock(long_10)), long_11);
		if (num != -1)
		{
			int_1 = num * 8;
			return true;
		}
		int_1 = 0;
		return false;
	}

	[CompilerGenerated]
	private bool method_24(long long_10)
	{
		long num = localHeapCache.ReadInt64(long_10, 312L);
		int sizeOfBlock = localHeapCache.GetSizeOfBlock(num);
		if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, 832))
		{
			long long_11 = localHeapCache.ReadInt64(long_10, 320L);
			int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(long_11);
			if (sizeOfBlock2 != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock2, 384))
			{
				int num2 = MR.Instance.ReadInt32_x64(num + 88);
				int num3 = MR.Instance.ReadInt32_x64(num + 104);
				if (num3 >= 0 && num2 >= 0 && num3 <= num2)
				{
					return true;
				}
			}
		}
		return false;
	}
}
