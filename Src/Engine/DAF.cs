using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiftAssistant.Engine;

internal class DAF
{
	internal LocalHeapCache localHeapCache = null!;

	private readonly Dictionary<string, Func<bool>> blockValidateFuncs = [];

	private r_PlayerData playerData;

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

	public void Reset()
	{
		blockValidateFuncs.Clear();
		ObjectManagerAddress = 0L;
		AcdManagerAddress = 0L;
		AcdManager_ACDs_Offset = 0L;
		PlayerDataManagerAddress = 0L;
		PlayerAddress = 0L;
		LevelAreaAddress = 0L;
		TrickleManagerAddress = 0L;
		BattleNetClientAddress = 0L;
		GameStateAddress = 0L;
		RealmAddress = 0L;
	}

	public uint DetermineCryptoKey_ActorACDID(IEnumerable<uint> ienumerable_0, IEnumerable<uint> collection)
	{
		Dictionary<uint, bool> dictionary = new Dictionary<uint, bool>();
		List<uint> list_ = ienumerable_0.ToList();
		HashSet<uint> hashSet = new HashSet<uint>(collection);
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

	private static bool CrossReferenceActorsWithACDs(List<uint> list_0, HashSet<uint> hashSet, uint uint_8)
	{
		foreach (uint item in list_0) {
			uint num = item ^ uint_8;
			if (num != uint.MaxValue && num != 0 && !hashSet.Contains(num)) {
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

	private void ScanRealm()
	{
		int size = AlignedSize(448, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(size).Where(IsRealmAddress).FirstOrDefault();
		if (num != 0) {
			if (num != RealmAddress) {
				RealmAddress = num;
			}
			int blockSize = localHeapCache.GetSizeOfBlock(RealmAddress);
			blockValidateFuncs["RealmAddress"] = () => IsRealmAddress(RealmAddress) && localHeapCache.VerifyBlock(RealmAddress, blockSize);
			return;
		}
		RealmAddress = 0L;
		Logger.Info("[ERROR] can't find realm.");
	}

	private bool IsRealmAddress(long realmAddress)
	{
		string text = GameWindowManager.ReadString(realmAddress + Offset_Realm_ServerGateway, 128, Encoding.UTF8, true);
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
			if (TryFindAcdBlockOffset(item, long_10, out int_)) {
				num = item;
				break;
			}
		}
		if (num != 0L) {
			if (num != AcdManagerAddress) {
				AcdManagerAddress = num;
			}
			AcdManager_ACDs_Offset = int_;
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(AcdManagerAddress);
			blockValidateFuncs["AcdManagerAddress"] = () => localHeapCache.VerifyBlock(AcdManagerAddress, sizeOfBlock);
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
			playerData = GameWindowManager.Read<r_PlayerData>(num2, size: Constants.PlayerData_SizeOf);
			return (playerData.UsedKanaiItemSno1 == uint.MaxValue || SnoData.Items.SnoExits(playerData.UsedKanaiItemSno1)) && (playerData.UsedKanaiItemSno2 == uint.MaxValue || SnoData.Items.SnoExits(playerData.UsedKanaiItemSno2)) && (playerData.UsedKanaiItemSno3 == uint.MaxValue || SnoData.Items.SnoExits(playerData.UsedKanaiItemSno3));
		}).FirstOrDefault();
		if (num != 0L) {
			if (num != PlayerDataManagerAddress) {
				PlayerDataManagerAddress = num;
			}
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(PlayerDataManagerAddress);
			blockValidateFuncs["PlayerDataManagerAddress"] = () => localHeapCache.ReadUInt32(PlayerDataManagerAddress, 40L) == CoreCollector.Magic_600DF00D && localHeapCache.VerifyBlock(PlayerDataManagerAddress, sizeOfBlock);
			return;
		}
		PlayerDataManagerAddress = 0L;
	}

	private void ScanPlayer()
	{
		int int_ = AlignedSize(41952, 32);
		long num = localHeapCache.GetMainBlocksWithSize(int_).Where(HasFloatingNumberAllocator).FirstOrDefault();
		if (num != 0L) {
			if (num != PlayerAddress) {
				PlayerAddress = num;
			}
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(PlayerAddress);
			blockValidateFuncs["PlayerAddress"] = () => HasFloatingNumberAllocator(PlayerAddress) && localHeapCache.VerifyBlock(PlayerAddress, sizeOfBlock);
			return;
		}
		PlayerAddress = 0L;
	}

	private bool HasFloatingNumberAllocator(long playerAddress)
	{
		long long_11 = playerAddress + D3Memory.Offset_Player_FloatingNumbers + D3Memory.FloatingNumAllocatorOffset2;
		return localHeapCache.ReadUInt32(long_11, 40L) == CoreCollector.Magic_600DF00D;
	}

	private bool ScanObjectManager()
	{
		int int_ = AlignedSize(D3Memory.ObjectManager_SizeOf, 32);
		int alignedSize = AlignedSize(304, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		long num = mainBlocksWithSize.Where(delegate (long long_0) {
			long long_1 = localHeapCache.ReadInt64(long_0, D3Memory.Offset_ObjectManager_Worlds);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock == 0 || !localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, alignedSize)) {
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
			int sizeOfBlock3 = localHeapCache.GetSizeOfBlock(ObjectManagerAddress);
			blockValidateFuncs["ObjectManagerAddress"] = () => localHeapCache.VerifyBlock(ObjectManagerAddress, sizeOfBlock3);
			return true;
		}
		ObjectManagerAddress = 0L;
		return false;
	}

	private void ScanGameState()
	{
		int int_ = AlignedSize(D3Memory.SizeOf_GameState, 32);
		long long_0 = GameWindowManager.MainModuleHandle.ToInt64();
		long num = (from long_1 in localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_)
					where IsValidGameState(long_1, long_0)
					select long_1).FirstOrDefault();
		if (num != 0L) {
			if (num != GameStateAddress) {
				GameStateAddress = num;
			}
			blockValidateFuncs["GameStateAddress"] = () => IsValidGameState(GameStateAddress, long_0);
			return;
		}
		GameStateAddress = 0L;
	}

	internal bool IsValidGameState(long gameStateAddress, long long_11)
	{
		long num = localHeapCache.ReadInt64(gameStateAddress, D3Memory.Offset_GameState_Validation1);
		long num2 = localHeapCache.ReadInt64(gameStateAddress, D3Memory.Offset_GameState_Validation2);
		if (num <= long_11 || num2 <= long_11) {
			return false;
		}
		if (num != num2 - 40) {
			return false;
		}
		if (localHeapCache.ReadInt32(gameStateAddress, D3Memory.Offset_GameState_Validation3) != 0)
		{
			return false;
		}
		int num3 = GameWindowManager.Read<int>(gameStateAddress + D3Memory.Offset_GameState_LoadingScreenEnabled);
		if (num3 != 0 && num3 != 1) {
			return false;
		}
		int num4 = GameWindowManager.Read<int>(gameStateAddress + D3Memory.Offset_GameState_IsGamePaused);
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
			int sizeOfBlock3 = localHeapCache.GetSizeOfBlock(BattleNetClientAddress);
			blockValidateFuncs["BattleNetClientAddress"] = () => localHeapCache.VerifyBlock(BattleNetClientAddress, sizeOfBlock3);
			return;
		}
		BattleNetClientAddress = 0L;
	}

	private void ScanLevelArea()
	{
		int int_ = AlignedSize(2432, 32);
		IEnumerable<long> mainBlocksWithSize = localHeapCache.GetMainBlocksWithSize(int_);
		AreaContainer areaContainer = new();
		long num = mainBlocksWithSize.Where(delegate (long long_0) {
			areaContainer = GameWindowManager.Read<AreaContainer>(long_0);
			if (localHeapCache.GetSizeOfBlock(areaContainer.PrimaryAreaPtr) == 0) {
				return false;
			}
			if (localHeapCache.GetSizeOfBlock(areaContainer.SecondaryAreaPtr) == 0) {
				return false;
			}
			long num2 = GameWindowManager.Read<long>(areaContainer.PrimaryAreaPtr + 8);
			if (GameWindowManager.Read<uint>(num2 + 40) != CoreCollector.Magic_600DF00D) {
				return false;
			}
			long num3 = GameWindowManager.Read<long>(areaContainer.SecondaryAreaPtr + 8);
			return GameWindowManager.Read<uint>(num3 + 40) == CoreCollector.Magic_600DF00D;
		}).FirstOrDefault();
		if (num != 0L) {
			if (num != LevelAreaAddress) {
				LevelAreaAddress = num;
			}
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(LevelAreaAddress);
			blockValidateFuncs["LevelAreaAddress"] = () => localHeapCache.VerifyBlock(LevelAreaAddress, sizeOfBlock);
		} else {
			LevelAreaAddress = 0L;
		}
	}

	private void ScanTrickleManager()
	{
		int int_ = AlignedSize(16, 32);
		int alignedSize = AlignedSize(48, 32);
		long num = localHeapCache.GetSmallBlocksWithSize_OrPlus0x20(int_).Where(delegate (long long_0) {
			long long_1 = localHeapCache.ReadInt64(long_0, AddressList.Offset_Trickle_Block0);
			int sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
			if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, alignedSize) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D) {
				long long_2 = localHeapCache.ReadInt64(long_0, AddressList.Offset_Trickle_Ptr8);
				if (localHeapCache.GetSizeOfBlock(long_2) != 0) {
					long_1 = localHeapCache.ReadInt64(long_2, AddressList.Offset_Trickle_Ptr24);
					sizeOfBlock = localHeapCache.GetSizeOfBlock(long_1);
					if (sizeOfBlock != 0 && localHeapCache.IsBlockSizeEqual_OrPlus0x20(sizeOfBlock, alignedSize) && localHeapCache.ReadUInt32(long_1, 40L) == CoreCollector.Magic_600DF00D) {
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
			int sizeOfBlock2 = localHeapCache.GetSizeOfBlock(TrickleManagerAddress);
			blockValidateFuncs["TrickleManagerAddress"] = () => localHeapCache.VerifyBlock(TrickleManagerAddress, sizeOfBlock2);
			return;
		}
		TrickleManagerAddress = 0L;
	}

	private long FindContainerByItemSize(LocalHeapCache heapCache, string containerName, int itemSize)
	{
		var candidates = heapCache.GetSmallBlocksWithSize_OrPlus0x20(AlignedSize(364, 64));
		int candidateCount = 0;

		foreach (long address in candidates) {
			candidateCount++;
			if (heapCache.ReadUInt32(address, 328L) != CoreCollector.Magic_600DF00D) continue;

			int itemCount = heapCache.ReadInt32(address, 256L);
			if (itemCount <= 0) continue;

			long blockTable = heapCache.ReadInt64(address, 288L);
			long firstBlock = heapCache.ReadInt64(blockTable, 0L);
			int actualSize = heapCache.GetSizeOfBlock(firstBlock) * heapCache.ReadInt32(address, 296L);

			if (heapCache.IsBlockSizeEqual_OrPlus0x20(actualSize, itemSize * itemCount)) return address;
		}

		Logger.Info("[ERROR] '" + containerName + "' container candidate count: " + candidateCount + ", struct size: " + itemSize);
		throw new Exception("can't find '" + containerName + "' container");
	}
	public static int AlignedSize(int int_1, int int_2)
	{
		return (int_1 + (int_2 - 1)) / int_2 * int_2;
	}

	public bool TryFindAcdBlockOffset(long long_10, long long_11, out int int_1)
	{
		int num = Array.IndexOf(localHeapCache.ReadBlockPointers(long_10, localHeapCache.GetSizeOfBlock(long_10)), long_11);
		if (num != -1) {
			int_1 = num * 8;
			return true;
		}
		int_1 = 0;
		return false;
	}

}
