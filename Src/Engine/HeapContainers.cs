using System;
using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal class Container
{
	private readonly r_Container[] buffer = new r_Container[1];

	public readonly short _maxAllowedIndex;

	public short MaxIndex { get; private set; }

	public bool IsValid { get; private set; }

	public long DataAddress { get; private set; }

	public Container(short short_2)
	{
		_maxAllowedIndex = short_2;
	}

	public void Snapshot(long long_1)
	{
		buffer[0] = GameWindowManager.Read<r_Container>(long_1);
		DataAddress = buffer[0].DataAddress;
		MaxIndex = (short)buffer[0].MaxIndex;
		if (MaxIndex == short.MaxValue)
		{
			MaxIndex = -1;
		}
		if (MaxIndex > _maxAllowedIndex)
		{
			MaxIndex = _maxAllowedIndex;
		}
		int capacity = buffer[0].Capacity;
		if (DataAddress > 0 && capacity > 0)
		{
			IsValid = true;
		}
		else
		{
			IsValid = false;
		}
	}
}

internal class AllocatedBlock<T>(Allocator allocator)
{
	public readonly Allocator Allocator = allocator;

	internal byte[] bitMask;

	public T[] Elements { get; set; }

	public r_Block Block { get; set; }

	public long StartAddress => Block.ArrayStart;

	public long LastElementAddress => Block.ArrayStart + Block.ElementSize * (Block.ElementCount - 1);

	public int Capacity => Block.ElementCount;

	public bool IsAllocated(int int_0)
	{
		return ((bitMask[int_0 / 8] >> int_0 % 8) & 1) == 1;
	}
}

internal class AllocationCache<T> where T : unmanaged
{
	private readonly int elementSize;

	public AllocatedBlock<T>[] class354_0;

	public int int_1;

	public IEnumerable<T> GetItems()
	{
		for (int i = 0; i < int_1; i++)
		{
			AllocatedBlock<T> @class = class354_0[i];
			for (int j = 0; j < @class.Capacity; j++)
			{
				if (!@class.IsAllocated(j))
				{
					yield return @class.Elements[j];
				}
			}
		}
	}

	public T? FindElement(long bucketAddress)
	{
		int num = 0;
		AllocatedBlock<T> @class;
		while (true)
		{
			if (num < int_1)
			{
				@class = class354_0[num];
				if (bucketAddress >= @class.StartAddress && bucketAddress <= @class.LastElementAddress)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return @class.Elements[(bucketAddress - @class.StartAddress) / elementSize];
	}

	public AllocationCache(int elementSize)
	{
		this.elementSize = elementSize;
	}

	public void Snapshot(Allocator allocator)
	{
		int_1 = allocator.RawBlocks.Count;
		if (class354_0 == null || class354_0.Length != int_1)
		{
			class354_0 = new AllocatedBlock<T>[int_1];
		}
		for (int i = 0; i < int_1; i++)
		{
			r_Block r_Block2 = allocator.RawBlocks[i];
			int elementCount = r_Block2.ElementCount;
			AllocatedBlock<T> @class = class354_0[i] ?? (class354_0[i] = new AllocatedBlock<T>(allocator));
			@class.Block = r_Block2;
			if (@class.Elements == null || @class.Elements.Length < elementCount)
			{
				@class.Elements = new T[elementCount];
			}
			if (elementCount > 0)
			{
				//delegate8_0(GameWindowManager.ProcessHandle, (IntPtr)r_Block2.ArrayStart, ref @class.Elements[0], int_0 * elementCount, 0);
				@class.Elements = GameWindowManager.ReadArray<T>(r_Block2.ArrayStart, elementCount);
				int num = (r_Block2.Limit + 7) / 8;
				if (@class.bitMask == null || @class.bitMask.Length < num)
				{
					@class.bitMask = new byte[num];
				}
				@class.bitMask = GameWindowManager.ReadBytes(r_Block2.PtrFreeSpaceBitmap, num);
			}
		}
	}
}

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

internal class MainBlock
{

	public long DataAddress { get; set; }

	public int Size { get; set; }
}

internal class ExpandableContainer
{
	private readonly r_ExpandableContainer[] buffer = new r_ExpandableContainer[1];

	public readonly short _maxAllowedIndex;

	public short MaxIndex { get; private set; }

	public int ItemSize { get; }

	public bool IsValid { get; private set; }

	public long[] BlockPointers { get; private set; } = new long[0];

	public int BlocksItemCapacity { get; private set; }

	public int BlockCount { get; private set; }

	public ExpandableContainer(short short_2, int int_3)
	{
		_maxAllowedIndex = short_2;
		ItemSize = int_3;
	}

	public void Snapshot(long long_1)
	{
		buffer[0] = GameWindowManager.Read<r_ExpandableContainer>(long_1);
		long allocator_PtrItems = buffer[0]._Allocator_PtrItems;
		MaxIndex = (short)buffer[0].MaxIndex;
		if (MaxIndex == short.MaxValue)
		{
			MaxIndex = -1;
		}
		if (MaxIndex > _maxAllowedIndex)
		{
			MaxIndex = _maxAllowedIndex;
		}
		if (buffer[0]._Allocator_GoodFood == CoreCollector.Magic_600DF00D && MaxIndex >= -2)
		{
			int bits = buffer[0].Bits;
			BlocksItemCapacity = 1 << bits;
			BlockCount = (MaxIndex - 1) / BlocksItemCapacity + 1;
			if (MaxIndex < 0)
			{
				IsValid = false;
				return;
			}
			_ = BlockCount;
			if (BlockPointers.Length != BlockCount)
			{
				BlockPointers = new long[BlockCount];
			}
			BlockPointers = GameWindowManager.ReadArray<long>(allocator_PtrItems, BlockCount);
			IsValid = true;
		}
		else
		{
			MaxIndex = -1;
			IsValid = false;
		}
	}

	public long ElementAt(int fastAttribGroupID)
	{
		try
		{
			return BlockPointers[fastAttribGroupID / BlocksItemCapacity] + ItemSize * (fastAttribGroupID % BlocksItemCapacity);
		}
		catch (Exception)
		{
			throw new Exception("container error: Index=" + fastAttribGroupID + ", MaxItemsInArray=" + BlocksItemCapacity + ", ArrayCount=" + BlockCount);
		}
	}
}
