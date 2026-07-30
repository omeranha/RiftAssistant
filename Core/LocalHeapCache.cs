using System;
using System.Collections.Generic;
using System.Linq;

internal class LocalHeapCache
{
	// Helper structures
	private struct BlockEntry
	{
		public long Address;
		public int Size;
	}

	private class SmallBlockGroup
	{
		public int Size;
		public long[] Entries;
		public int Count;
	}

	private r_MemoryManager memoryManager = new();
	private r_LocalHeap localHeap = new();
	
	// Use arrays instead of dictionaries to reduce overhead
	private BlockEntry[] blockEntries = new BlockEntry[1000000]; // Pre-allocated array
	private int blockEntriesCount = 0;
	
	private long smallblocksnode_address;
	private int smallblocksnode_size;
	private long[] smallblocksnode_data;
	private long[] smallBlockBuffer = new long[1024];
	
	// Use arrays for small blocks by size instead of Dictionary<List<long>>
	private SmallBlockGroup[] smallBlocksBySize = new SmallBlockGroup[100]; // Pre-allocated
	private int smallBlocksBySizeCount = 0;

	private MainBlock[] mainBlocks = new MainBlock[30000];
	private int mainBlocksCount = 0;

	public int MainBlocksCount => mainBlocksCount;
	public int SmallBlocksCount => smallBlocksBySize.Take(smallBlocksBySizeCount).Sum(g => g.Count);

	public void ClearSmallBlocksCache()
	{
		smallblocksnode_data = null;
	}

	public void Init(long long_2)
	{
		// Reset arrays instead of clearing dictionaries
		blockEntriesCount = 0;
		mainBlocksCount = 0;
		smallBlocksBySizeCount = 0;
		
		long address = GameWindowManager.Read<long>(long_2, true);
		memoryManager = GameWindowManager.Read<r_MemoryManager>(address);
		if (memoryManager.IsInitialized != 1)
		{
			throw new Exception("validation failed: memory manager");
		}
		
		localHeap = GameWindowManager.Read<r_LocalHeap>(memoryManager.PtrLocalHeap);
		if (localHeap.FirstNodeAddress + localHeap.TotalSize != localHeap.LastNodeAddress)
		{
			throw new Exception("validation failed: local heap");
		}
		
		long num = localHeap.FirstNodeAddress;
		int num2 = 0;
		int num3;
		
		for (; num <= localHeap.LastNodeAddress; num += 32 + num3)
		{
			uint uint_ = GameWindowManager.Read<uint>(num + 24);
			num3 = (int)(uint_ >> 1);
			
			if ((uint_ & 1) == 1)
			{
				long num4 = num + 32;
				
				if (num2 == 0)
				{
					smallblocksnode_address = num4;
					smallblocksnode_size = num3;
					smallblocksnode_data = new long[num3 / 8];
					GameWindowManager.ReadIntoArray<long>(num4, smallblocksnode_data, 0, num3 / 8);
					
					int num7;
					for (long num5 = 0L; num5 < num3; num5 += 32 + num7)
					{
						int num6 = (int)smallblocksnode_data[(int)((num5 + 24) / 8)];
						num7 = num6 >>> 1;
						
						if ((num6 & 1) == 1)
						{
							long num8 = num4 + num5 + 32;
							
							// Find or create group for this size
							int groupIndex = FindOrCreateSmallBlockGroup(num7);
							SmallBlockGroup group = smallBlocksBySize[groupIndex];
							
							// Ensure capacity
							if (group.Entries.Length <= group.Count)
							{
								Array.Resize(ref group.Entries, Math.Max(group.Count + 1, group.Entries.Length * 2));
							}
							
							group.Entries[group.Count] = num8;
							group.Count++;
							
							// Add to block entries
							if (blockEntries.Length <= blockEntriesCount)
							{
								Array.Resize(ref blockEntries, Math.Max(blockEntriesCount + 1, blockEntries.Length * 2));
							}
							blockEntries[blockEntriesCount++] = new BlockEntry { Address = num8, Size = num7 };
						}
					}
				}
				else
				{
					// Add main block
					if (mainBlocks.Length <= mainBlocksCount)
					{
						Array.Resize(ref mainBlocks, Math.Max(mainBlocksCount + 1, mainBlocks.Length * 2));
					}
					
					MainBlock mainBlock = new MainBlock
					{
						DataAddress = num4,
						Size = num3
					};
					mainBlocks[mainBlocksCount++] = mainBlock;
					
					// Add to block entries
					if (blockEntries.Length <= blockEntriesCount)
					{
						Array.Resize(ref blockEntries, Math.Max(blockEntriesCount + 1, blockEntries.Length * 2));
					}
					blockEntries[blockEntriesCount++] = new BlockEntry { Address = num4, Size = num3 };
				}
			}
			num2++;
		}
	}

	private int FindOrCreateSmallBlockGroup(int size)
	{
		// Linear search for existing group
		for (int i = 0; i < smallBlocksBySizeCount; i++)
		{
			if (smallBlocksBySize[i].Size == size)
			{
				return i;
			}
		}
		
		// Create new group
		if (smallBlocksBySizeCount >= smallBlocksBySize.Length)
		{
			Array.Resize(ref smallBlocksBySize, Math.Max(smallBlocksBySizeCount + 1, smallBlocksBySize.Length * 2));
		}
		
		int newIndex = smallBlocksBySizeCount++;
		smallBlocksBySize[newIndex] = new SmallBlockGroup { Size = size, Entries = new long[8], Count = 0 };
		return newIndex;
	}

	public IEnumerable<long> GetSmallBlocksWithSize(int int_1)
	{
		for (int i = 0; i < smallBlocksBySizeCount; i++)
		{
			if (smallBlocksBySize[i].Size == int_1)
			{
				var group = smallBlocksBySize[i];
				for (int j = 0; j < group.Count; j++)
				{
					yield return group.Entries[j];
				}
				yield break;
			}
		}
		yield break;
	}

	public IEnumerable<long> GetSmallBlocksWithSize_OrPlus0x20(int int_1)
	{
		foreach (long addr in GetSmallBlocksWithSize(int_1))
		{
			yield return addr;
		}
		
		foreach (long addr in GetSmallBlocksWithSize(int_1 + 32))
		{
			yield return addr;
		}
	}

	public IEnumerable<long> GetMainBlocksWithSize(int int_1)
	{
		for (int i = 0; i < mainBlocksCount; i++)
		{
			MainBlock block = mainBlocks[i];
			if (block.Size == int_1 || block.Size == int_1 + 32)
			{
				yield return block.DataAddress;
			}
		}
	}

	public int GetSizeOfBlock(long long_2)
	{
		// Linear search through pre-allocated array
		for (int i = 0; i < blockEntriesCount; i++)
		{
			if (blockEntries[i].Address == long_2)
			{
				return blockEntries[i].Size;
			}
		}
		return 0;
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
		return GameWindowManager.Read<int>(long_2 + long_3);
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
		return GameWindowManager.Read<uint>(long_2 + long_3);
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
		return GameWindowManager.Read<long>(long_2 + long_3);
	}

	public long[] ReadBlockPointers(long address, int size)
	{
		return GameWindowManager.ReadArray<long>(address, size / sizeof(long));
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
		return GameWindowManager.ReadBytes(long_2 + int_2, int_1);
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
		uint num = GameWindowManager.Read<uint>(long_2 - 8);
		if (int_1 == (int)(num >> 1))
		{
			return (num & 1) == 1;
		}
		return false;
	}
}