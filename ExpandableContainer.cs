using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using structs;


internal class ExpandableContainer
{
	private readonly r_ExpandableContainer[] buffer = new r_ExpandableContainer[1];

	[CompilerGenerated]
	private short short_0;

	[CompilerGenerated]
	private readonly int int_0;

	public readonly short _maxAllowedIndex;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private long[] long_0 = new long[0];

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	public short MaxIndex
	{
		[CompilerGenerated]
		get
		{
			return short_0;
		}
		[CompilerGenerated]
		private set
		{
			short_0 = value;
		}
	}

	public int ItemSize
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public bool IsValid
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public long[] BlockPointers
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		private set
		{
			long_0 = value;
		}
	}

	public int BlocksItemCapacity
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	public int BlockCount
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		private set
		{
			int_2 = value;
		}
	}

	public ExpandableContainer(short short_2, int int_3)
	{
		_maxAllowedIndex = short_2;
		int_0 = int_3;
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

	public long ElementAt(int int_3)
	{
		try
		{
			return BlockPointers[int_3 / BlocksItemCapacity] + ItemSize * (int_3 % BlocksItemCapacity);
		}
		catch (Exception)
		{
			throw new Exception("container error: Index=" + int_3 + ", MaxItemsInArray=" + BlocksItemCapacity + ", ArrayCount=" + BlockCount);
		}
	}
}
