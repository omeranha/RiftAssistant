using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using structs;
using work;

internal class Map
{
	public readonly int int_0;

	[CompilerGenerated]
	private long long_0;

	private long long_1;

	internal long[] long_2;

	private int int_1;

	public bool bool_0;

	[CompilerGenerated]
	private int int_2;

	private readonly r_Map[] struct16_0 = new r_Map[1];

	public readonly Allocator class351_0;

	public long Int64_0
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

	public int Int32_0
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

	public Map(int int_3, bool bool_1 = true)
	{
		int_0 = int_3;
		if (bool_1)
		{
			class351_0 = new Allocator(int_3, "EntryAllocator");
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_Map struct16_1, int int_3, int int_4);

	public void method_0(long long_3)
	{
		Int64_0 = long_3;
		bool_0 = long_3 != 0;
		long_1 = long_3 + 28;
		if (bool_0)
		{
			ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)long_3, ref struct16_0[0], 32, 0);
			Int32_0 = struct16_0[0].MaxIndex;
			int_1 = struct16_0[0].Mask;
			if (Int32_0 < -1 || Int32_0 > int_0)
			{
				Int32_0 = int_0;
			}
		}
		else
		{
			Int32_0 = -1;
		}
		if (class351_0 != null)
		{
			class351_0.Snapshot(struct16_0[0].PtrBucketAllocator);
			return;
		}
		if (long_2 == null || long_2.Length < Int32_0 + 1 || Int32_0 == 0)
		{
			long_2 = new long[Int32_0 + 1];
		}
		if (Int32_0 > -1)
		{
			MR.Instance.ReadMem(long_1, long_2, (Int32_0 + 1) * 8);
		}
	}

	public long method_1(uint uint_0)
	{
		uint num = uint_0 ^ (uint_0 >> 12);
		int num2 = (int)(int_1 & num);
		if (long_2 != null && num2 > 0 && num2 <= Int32_0)
		{
			return long_2[num2];
		}
		return MR.Instance.ReadAddress(long_1 + num2 * 8);
	}
}
