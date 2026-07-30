using System.Collections.Generic;
using System.Diagnostics;


internal class Allocator
{
	public string Name;

	public r_Allocator RawAllocator = new r_Allocator();

	public readonly List<r_Block> RawBlocks = new List<r_Block>();

	public readonly int MaxAllowedBlockCount;

	public Allocator(int int_1, string string_1)
	{
		MaxAllowedBlockCount = int_1;
		Name = string_1;
	}

	public void Snapshot(long address)
	{
		RawAllocator = GameWindowManager.Read<r_Allocator>(address);
		RawBlocks.Clear();
		if (RawAllocator.GoodFood != CoreCollector.Magic_600DF00D || RawAllocator.LinkedListCount <= 0 || RawAllocator.LinkedListCount > MaxAllowedBlockCount)
		{
			return;
		}
		r_Block r_Block2 = GameWindowManager.Read<r_Block>(RawAllocator.LinkedListFirstNodePtr);
		RawBlocks.Add(r_Block2);
		for (int i = 1; i < RawAllocator.LinkedListCount; i++)
		{
			long nextNodePtr = r_Block2.NextNodePtr;
			if (nextNodePtr != 0L)
			{
				r_Block2 = GameWindowManager.Read<r_Block>(nextNodePtr);
				RawBlocks.Add(r_Block2);
				continue;
			}
			break;
		}
	}

	public int GetTotalElementCount()
	{
		int num = 0;
		for (int i = 0; i < RawBlocks.Count; i++)
		{
			num += RawBlocks[i].ElementCount;
		}
		return num;
	}
}
