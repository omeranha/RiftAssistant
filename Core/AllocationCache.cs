using System;
using System.Collections.Generic;
using work;

internal class AllocationCache<T> where T : struct
{
	public delegate bool Delegate8(IntPtr ProcessHandle, IntPtr Address, ref T Into, int Length, int N);

	private readonly int int_0;

	private readonly Delegate8 delegate8_0;

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

	public T? method_1(long long_0)
	{
		int num = 0;
		AllocatedBlock<T> @class;
		while (true)
		{
			if (num < int_1)
			{
				@class = class354_0[num];
				if (long_0 >= @class.StartAddress && long_0 <= @class.LastElementAddress)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return @class.Elements[(long_0 - @class.StartAddress) / int_0];
	}

	public AllocationCache(Delegate8 delegate8_1, int int_2)
	{
		delegate8_0 = delegate8_1;
		int_0 = int_2;
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
				delegate8_0(MR.Instance.ProcessHandle, (IntPtr)r_Block2.ArrayStart, ref @class.Elements[0], int_0 * elementCount, 0);
				int num = (r_Block2.Limit + 7) / 8;
				if (@class.bitMask == null || @class.bitMask.Length < num)
				{
					@class.bitMask = new byte[num];
				}
				MR.Instance.ReadMem(r_Block2.PtrFreeSpaceBitmap, @class.bitMask, num);
			}
		}
	}
}
