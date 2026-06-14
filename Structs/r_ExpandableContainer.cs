using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ExpandableContainer
{
	public const int int_0 = 0;

	public const int int_1 = 255;

	public const int int_2 = 256;

	[FieldOffset(256)]
	public int Capacity;

	[FieldOffset(264)]
	public int MaxIndex;

	public const int int_5 = 288;

	[FieldOffset(288)]
	public long _Allocator_PtrItems;

	public const int int_6 = 296;

	[FieldOffset(296)]
	public int _Allocator_BlockAllocations;

	public const int int_8 = 328;

	[FieldOffset(328)]
	public uint _Allocator_GoodFood;

	[FieldOffset(360)]
	public int Bits;

	public const int sizeOf = 364;
}
