using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using structs;
using SNO;

internal class DAF
{
	internal LocalHeapCache localHeapCache;

	private readonly Dictionary<string, Func<bool>> blockValidateFuncs = [];

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
		foreach (uint item in ienumerable_0) {
			foreach (uint item2 in hashSet) {
				uint num = item ^ item2;
				if (!dictionary.ContainsKey(num)) {
					bool value = CrossReferenceActorsWithACDs(list_, hashSet, num);
					dictionary.Add(num, value);
				} else if (dictionary[num] && !CrossReferenceActorsWithACDs(list_, hashSet, num)) {
					dictionary[num] = false;
				}
			}
		}
		return dictionary.FirstOrDefault((KeyValuePair<uint, bool> keyValuePair_0) => keyValuePair_0.Value).Key;
	}

	private static bool CrossReferenceActorsWithACDs(List<uint> list_0, HashSet<uint> hashSet_0, uint uint_8)
	{
		foreach (uint item in list_0) {
			uint num = item ^ uint_8;
			if (num != uint.MaxValue && num != 0 && !hashSet_0.Contains(num)) {
				return false;
			}
		}
		return true;
	}

	public bool IsScanRequired()
	{
		int num = 0;
		foreach (var blockValidateFunc in blockValidateFuncs) {
			if (!blockValidateFunc.Value()) {
				num++;
			}
		}
		return num > 0;
	}

	public void Scan()
	{
		if (GameWindowManager.Window.Handle == IntPtr.Zero) return;

		localHeapCache ??= new LocalHeapCache();
		localHeapCache.Init(AddressList.PtrMemoryManager);
		blockValidateFuncs.Clear();

		if (!ScanObjectManager()) return;

		int num = GameWindowManager.Read<int>(ObjectManagerAddress + D3Memory.Offset_ObjectManager_InGameFlag);
		if (num != 0) {
			ScanLevelArea();
		} else {
			LevelAreaAddress = 0L;
		}
		long long_ = FindContainerByItemSize(localHeapCache, "acd", Constants.ACD_SizeOf);
		ScanACDManager(long_);
		ScanPlayer();
		ScanPlayerDataManager();
		ScanTrickleManager();
		ScanBattleNetClient();
		ScanGameState();
		ScanRealm();
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

	private void ScanRealm()
	{
		int size = AlignedSize(448, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(size).Where(method_9).FirstOrDefault();
		if (num != 0) {
			if (num != RealmAddress) {
				RealmAddress = num;
			}
			int blockSize = localHeapCache.GetSizeOfBlock(RealmAddress);
			blockValidateFuncs["RealmAddress"] = () => method_9(RealmAddress) && localHeapCache.VerifyBlock(RealmAddress, blockSize);
			return;
		}
		RealmAddress = 0L;
		Logger.Info("[ERROR] can't find realm.");
	}

	private bool method_9(long long_10)
	{
		string text = GameWindowManager.ReadString(long_10 + Offset_Realm_ServerGateway, 128, Encoding.UTF8, true);
		if (!string.IsNullOrEmpty(text)) {
			return text.Contains("actual.battle.net");
		}
		return false;
	}

	private void ScanACDManager(long long_10)
	{
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(24800);
		long num = 0L;
		int int_ = 0;
		foreach (long item in mainBlocksWithSize) {
			if (method_23(item, long_10, out int_)) {
				num = item;
				break;
			}
		}
		if (num != 0L) {
			if (num != AcdManagerAddress) {
				AcdManagerAddress = num;
			}
			AcdManager_ACDs_Offset = int_;
			int int_2 = localHeapCache.GetSizeOfBlock(AcdManagerAddress);
			blockValidateFuncs["AcdManagerAddress"] = () => localHeapCache.VerifyBlock(AcdManagerAddress, int_2);
			return;
		}
		AcdManagerAddress = 0L;

	}

	private void ScanPlayerDataManager()
	{
		int int_ = AlignedSize(8 * Constants.PlayerData_SizeOf + D3Memory.Offset_PlayerDataManager_Elements, 32);
		int localPlayerIndex = GameWindowManager.Read<int>(PlayerAddress + D3Memory.Offset_Player_LocalPlayerIndex);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		long num = mainBlocksWithSize.Where(delegate (long long_0) {
			if (localHeapCache.ReadUInt32(long_0, 40L) != CoreCollector.Magic_600DF00D) {
				return false;
			}
			long num2 = long_0 + D3Memory.Offset_PlayerDataManager_Elements + Constants.PlayerData_SizeOf * localPlayerIndex;
			struct32_0 = GameWindowManager.Read<r_PlayerData>(num2, size: Constants.PlayerData_SizeOf);
			return (struct32_0.UsedKanaiItemSno1 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno1)) && (struct32_0.UsedKanaiItemSno2 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno2)) && (struct32_0.UsedKanaiItemSno3 == uint.MaxValue || SnoData.Items.SnoExits(struct32_0.UsedKanaiItemSno3));
		}).FirstOrDefault();
		if (num != 0L) {
			if (num != PlayerDataManagerAddress) {
				PlayerDataManagerAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(PlayerDataManagerAddress);
			blockValidateFuncs["PlayerDataManagerAddress"] = () => localHeapCache.ReadUInt32(PlayerDataManagerAddress, 40L) == CoreCollector.Magic_600DF00D && localHeapCache.VerifyBlock(PlayerDataManagerAddress, int_2);
			return;
		}
		PlayerDataManagerAddress = 0L;
	}

	private void ScanPlayer()
	{
		int int_ = AlignedSize(41952, 32);
		long num = localHeapCache.GetMainBlocksWithSize(int_).Where(method_13).FirstOrDefault();
		if (num != 0L) {
			if (num != PlayerAddress) {
				PlayerAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(PlayerAddress);
			blockValidateFuncs["PlayerAddress"] = () => method_13(PlayerAddress) && localHeapCache.VerifyBlock(PlayerAddress, int_2);
			return;
		}
		PlayerAddress = 0L;
	}

	private bool method_13(long long_10)
	{
		long long_11 = long_10 + D3Memory.Offset_Player_FloatingNumbers + D3Memory.FloatingNumAllocatorOffset2;
		return localHeapCache.ReadUInt32(long_11, 40L) == CoreCollector.Magic_600DF00D;
	}

	private bool ScanObjectManager()
	{
		int int_ = AlignedSize(D3Memory.ObjectManager_SizeOf, 32);
		int int_2 = AlignedSize(304, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		long num = mainBlocksWithSize.Where(delegate (long long_0) {
			long long_1 = localHeapCache.ReadInt64(long_0, D3Memory.Offset_ObjectManager_Worlds);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock == 0 || !localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2)) {
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
		if (num != 0L) {
			if (num != ObjectManagerAddress) {
				ObjectManagerAddress = num;
			}
			int int_3 = localHeapCache.GetSizeOfBlock(ObjectManagerAddress);
			blockValidateFuncs["ObjectManagerAddress"] = () => localHeapCache.VerifyBlock(ObjectManagerAddress, int_3);
			return true;
		}
		ObjectManagerAddress = 0L;
		return false;
	}

	public int method_15(long long_10)
	{
		return localHeapCache.GetSizeOfBlock(long_10);
	}

	private void ScanGameState()
	{
		int int_ = AlignedSize(D3Memory.SizeOf_GameState, 32);
		long long_0 = GameWindowManager.MainModuleHandle.ToInt64();
		long num = (from long_1 in localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_)
					where method_17(long_1, long_0)
					select long_1).FirstOrDefault();
		if (num != 0L) {
			if (num != GameStateAddress) {
				GameStateAddress = num;
			}
			blockValidateFuncs["GameStateAddress"] = () => method_17(GameStateAddress, long_0);
			return;
		}
		GameStateAddress = 0L;
	}

	internal bool method_17(long long_10, long long_11)
	{
		long num = localHeapCache.ReadInt64(long_10, D3Memory.Offset_GameState_Validation1);
		long num2 = localHeapCache.ReadInt64(long_10, D3Memory.Offset_GameState_Validation2);
		if (num <= long_11 || num2 <= long_11) {
			return false;
		}
		if (num != num2 - 40) {
			return false;
		}
		if (localHeapCache.ReadInt32(long_10, D3Memory.Offset_GameState_Validation3) != 0)
		{
			return false;
		}
		int num3 = GameWindowManager.Read<int>(long_10 + D3Memory.Offset_GameState_LoadingScreenEnabled);
		if (num3 != 0 && num3 != 1) {
			return false;
		}
		int num4 = GameWindowManager.Read<int>(long_10 + D3Memory.Offset_GameState_IsGamePaused);
		if (num4 != 0) {
			return num4 == 1;
		}
		return true;
	}

	private void ScanBattleNetClient()
	{
		int num = AlignedSize(3648, 32);
		long num2 = localHeapCache.GetMainBlocksWithSize(num).Concat(localHeapCache.GetMainBlocksWithSize(num + 32)).Where(delegate (long long_10) {
			long num3 = localHeapCache.ReadInt64(long_10, 312L);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(num3);
			if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, 832)) {
				long long_11 = localHeapCache.ReadInt64(long_10, 320L);
				int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(long_11);
				if (sizeOfBlock2 != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock2, 384)) {
					int num4 = GameWindowManager.Read<int>(num3 + 88);
					int num5 = GameWindowManager.Read<int>(num3 + 104);
					if (num5 >= 0 && num4 >= 0 && num5 <= num4) {
						return true;
					}
				}
			}
			return false;
		})
			.FirstOrDefault();
		if (num2 != 0L) {
			if (num2 != BattleNetClientAddress) {
				BattleNetClientAddress = num2;
			}
			int int_0 = localHeapCache.GetSizeOfBlock(BattleNetClientAddress);
			blockValidateFuncs["BattleNetClientAddress"] = () => localHeapCache.VerifyBlock(BattleNetClientAddress, int_0);
			return;
		}
		BattleNetClientAddress = 0L;
	}

	private void ScanLevelArea()
	{
		int int_ = AlignedSize(2432, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		AreaContainer class66_0 = new();
		long num = mainBlocksWithSize.Where(delegate (long long_0) {
			class66_0 = GameWindowManager.Read<AreaContainer>(long_0);
			if (localHeapCache.GetSizeOfBlock(class66_0.PrimaryAreaPtr) == 0) {
				return false;
			}
			if (localHeapCache.GetSizeOfBlock(class66_0.SecondaryAreaPtr) == 0) {
				return false;
			}
			long num2 = GameWindowManager.Read<long>(class66_0.PrimaryAreaPtr + 8);
			if (GameWindowManager.Read<uint>(num2 + 40) != CoreCollector.Magic_600DF00D) {
				return false;
			}
			long num3 = GameWindowManager.Read<long>(class66_0.SecondaryAreaPtr + 8);
			return GameWindowManager.Read<uint>(num3 + 40) == CoreCollector.Magic_600DF00D;
		}).FirstOrDefault();
		if (num != 0L) {
			if (num != LevelAreaAddress) {
				LevelAreaAddress = num;
			}
			int int_2 = localHeapCache.GetSizeOfBlock(LevelAreaAddress);
			blockValidateFuncs["LevelAreaAddress"] = () => localHeapCache.VerifyBlock(LevelAreaAddress, int_2);
		} else {
			LevelAreaAddress = 0L;
		}
	}

	private void ScanTrickleManager()
	{
		int int_ = AlignedSize(16, 32);
		int int_2 = AlignedSize(48, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_).Where(delegate (long long_0) {
			long long_1 = localHeapCache.ReadInt64(long_0, AddressList.long_13);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D) {
				long long_2 = localHeapCache.ReadInt64(long_0, AddressList.long_14);
				if (localHeapCache.GetSizeOfBlock(long_2) != 0) {
					long_1 = localHeapCache.ReadInt64(long_2, AddressList.long_15);
					sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
					if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, int_2) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D) {
						return true;
					}
				}
			}
			return false;
		}).FirstOrDefault();
		if (num != 0L) {
			if (num != TrickleManagerAddress) {
				TrickleManagerAddress = num;
			}
			int int_3 = localHeapCache.GetSizeOfBlock(TrickleManagerAddress);
			blockValidateFuncs["TrickleManagerAddress"] = () => localHeapCache.VerifyBlock(TrickleManagerAddress, int_3);
			return;
		}
		TrickleManagerAddress = 0L;
	}

	private long FindContainerByItemSize(LocalHeapCache class332_1, string string_0, int int_1)
{
    int int_2 = AlignedSize(364, 64);

    var candidates = class332_1.GetSmallBlocksWithSize_OrPlus0x20(int_2);

    long result = 0L;
    int expectedSize = int_1;

    foreach (long addr in candidates)
    {
        if (class332_1.ReadUInt32(addr, 328L) != CoreCollector.Magic_600DF00D)
            continue;

        int num2 = class332_1.ReadInt32(addr, 256L);
        if (num2 <= 0)
            continue;

        long long_1 = class332_1.ReadInt64(addr, 288L);
        long long_2 = class332_1.ReadInt64(long_1, 0L);

        int sizeOfBlock = class332_1.GetSizeOfBlock(long_2);
        int num3 = class332_1.ReadInt32(addr, 296L);

        int actual = sizeOfBlock * num3;
        int expected = expectedSize * num2;

        if (class332_1.IsBlockSizeEqual_OrPlus0x20(actual, expected))
        {
            result = addr;
            break;
        }
    }

    if (result == 0L)
    {
        // optional: still avoid multiple enumeration
        int count = 0;
        foreach (var _ in candidates) count++;

        Logger.Info("[ERROR] '" + string_0 + "' container candidate count: " + count + ", struct size: " + int_1);

        method_22(candidates, int_1);

        throw new Exception("can't find '" + string_0 + "' container");
    }

    return result;
}

	private void method_22(IEnumerable<long> ienumerable_0, int int_1)
	{
		foreach (long item in ienumerable_0) {
			if (localHeapCache.ReadUInt32(item, 328L) == CoreCollector.Magic_600DF00D) {
				int num = localHeapCache.ReadInt32(item, 256L);
				if (num > 0) {
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
		if (num != -1) {
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
		if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, 832)) {
			long long_11 = localHeapCache.ReadInt64(long_10, 320L);
			int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(long_11);
			if (sizeOfBlock2 != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock2, 384)) {
				int num2 = GameWindowManager.Read<int>(num + 88);
				int num3 = GameWindowManager.Read<int>(num + 104);
				if (num3 >= 0 && num2 >= 0 && num3 <= num2) {
					return true;
				}
			}
		}
		return false;
	}
}
