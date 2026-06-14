using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace work;

internal class LocalHeapCache
{
	private readonly r_MemoryManager memoryManager = new r_MemoryManager();

	private readonly r_LocalHeap localHeap = new r_LocalHeap();

	private readonly Dictionary<long, int> blockAddr_2_Size = new Dictionary<long, int>(500000);

	private long smallblocksnode_address;

	private int smallblocksnode_size;

	private long[] smallblocksnode_data;

	private readonly Dictionary<int, List<long>> smallBlocksBySize = new Dictionary<int, List<long>>(100);

	private readonly List<MainBlock> mainBlocks = new List<MainBlock>(30000);

	public int MainBlocksCount => mainBlocks.Count;

	public int SmallBlocksCount => smallBlocksBySize.Sum((KeyValuePair<int, List<long>> keyValuePair_0) => keyValuePair_0.Value.Count);

	public void ClearSmallBlocksCache()
	{
		smallblocksnode_data = null;
	}

	public void Init(long long_2)
	{
		blockAddr_2_Size.Clear();
		smallBlocksBySize.Clear();
		mainBlocks.Clear();
		long long_3 = MR.Instance.ReadAddress(long_2, bool_0: true);
		MR.Instance.ReadMem(long_3, memoryManager, 104);
		if (memoryManager.IsInitialized != 1)
		{
			throw new Exception("validation failed: memory manager");
		}
		MR.Instance.ReadMem(memoryManager.PtrLocalHeap, localHeap, 112);
		if (localHeap.FirstNodeAddress + localHeap.TotalSize != localHeap.LastNodeAddress)
		{
			throw new Exception("validation failed: local heap");
		}
		long num = localHeap.FirstNodeAddress;
		int num2 = 0;
		uint uint_ = 0u;
		int num3;
		for (; num <= localHeap.LastNodeAddress; num += 32 + num3)
		{
			Win32.ReadProcessMemoryUInt(MR.Instance.ProcessHandle, (IntPtr)(num + 24), ref uint_, 4, 0);
			num3 = (int)(uint_ >> 1);
			if ((uint_ & 1) == 1)
			{
				long num4 = num + 32;
				if (num2 == 0)
				{
					smallblocksnode_address = num4;
					smallblocksnode_size = num3;
					smallblocksnode_data = new long[num3 / 8];
					MR.Instance.ReadPointerArray_x64(num4, smallblocksnode_data, 0, num3 / 8);
					int num7;
					for (long num5 = 0L; num5 < num3; num5 += 32 + num7)
					{
						int num6 = (int)smallblocksnode_data[(int)(IntPtr)((num5 + 24) / 8)];
						num7 = num6 >>> 1;
						if ((num6 & 1) == 1)
						{
							long num8 = num4 + num5 + 32;
							if (!smallBlocksBySize.TryGetValue(num7, out var value))
							{
								List<long> list = (smallBlocksBySize[num7] = new List<long>());
								value = list;
							}
							value.Add(num8);
							blockAddr_2_Size[num8] = num7;
						}
					}
				}
				else
				{
					MainBlock mainBlock = new MainBlock
					{
						DataAddress = num4,
						Size = num3
					};
					mainBlocks.Add(mainBlock);
					blockAddr_2_Size[mainBlock.DataAddress] = num3;
				}
			}
			num2++;
		}
	}

	public IEnumerable<long> GetSmallBlocksWithSize(int int_1)
	{
		if (!smallBlocksBySize.TryGetValue(int_1, out var value))
		{
			return Enumerable.Empty<long>();
		}
		return value;
	}

	public IEnumerable<long> GetSmallBlocksWithSize_OrPlus0x20(int int_1)
	{
		return GetSmallBlocksWithSize(int_1).Concat(GetSmallBlocksWithSize(int_1 + 32));
	}

	public IEnumerable<long> GetMainBlocksWithSize(int int_1)
	{
		return from class331_0 in mainBlocks
			where class331_0.Size == int_1 || class331_0.Size == int_1 + 32
			select class331_0.DataAddress;
	}

	public int GetSizeOfBlock(long long_2)
	{
		if (!blockAddr_2_Size.TryGetValue(long_2, out var value))
		{
			return 0;
		}
		return value;
	}

	public int ReadInt32(long long_2, long long_3)
	{
		if (smallblocksnode_data != null && long_2 >= smallblocksnode_address && long_2 <= smallblocksnode_address + smallblocksnode_size)
		{
			long num = long_2 - smallblocksnode_address + long_3;
			if (num % 8 == 0L)
			{
				return (int)smallblocksnode_data[num / 8];
			}
		}
		return MR.Instance.ReadInt32_x64(long_2 + long_3);
	}

	public uint ReadUInt32(long long_2, long long_3)
	{
		if (smallblocksnode_data != null && long_2 >= smallblocksnode_address && long_2 <= smallblocksnode_address + smallblocksnode_size)
		{
			long num = long_2 - smallblocksnode_address + long_3;
			if (num % 8 == 0L)
			{
				return (uint)smallblocksnode_data[num / 8];
			}
		}
		return MR.Instance.ReadUInt(long_2 + long_3);
	}

	public long ReadInt64(long long_2, long long_3)
	{
		if (smallblocksnode_data != null && long_2 >= smallblocksnode_address && long_2 <= smallblocksnode_address + smallblocksnode_size)
		{
			long num = long_2 - smallblocksnode_address + long_3;
			if (num % 8 == 0L)
			{
				return smallblocksnode_data[num / 8];
			}
		}
		return MR.Instance.ReadAddress(long_2 + long_3);
	}

	public long[] ReadBlockPointers(long long_2, int int_1)
	{
		long[] array = new long[int_1 / 8];
		MR.Instance.ReadMem(long_2, array, int_1);
		return array;
	}

	public byte[] ReadToByteArray(long long_2, int int_1, int int_2 = 0)
	{
		if (smallblocksnode_data != null && long_2 >= smallblocksnode_address && long_2 <= smallblocksnode_address + smallblocksnode_size)
		{
			byte[] array = new byte[int_1];
			long num = long_2 - smallblocksnode_address + int_2;
			if (int_2 % 8 == 0)
			{
				Buffer.BlockCopy(smallblocksnode_data, (int)num, array, 0, array.Length);
				return array;
			}
		}
		return MR.Instance.method_30(long_2 + int_2, int_1);
	}

	public bool IsBlockSizeEqual_OrPlus0x20(int int_1, int int_2)
	{
		if (int_1 != int_2)
		{
			return int_1 == int_2 + 32;
		}
		return true;
	}

	public bool VerifyBlock(long long_2, int int_1)
	{
		uint num = MR.Instance.ReadUInt(long_2 - 8);
		if (int_1 == (int)(num >> 1))
		{
			return (num & 1) == 1;
		}
		return false;
	}
}
