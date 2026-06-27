using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Map
{
	[FieldOffset(0)]
	public int Mask;

	public const int Offset_PtrBucketAllocator = 8;

	[FieldOffset(8)]
	public long PtrBucketAllocator;

	[FieldOffset(24)]
	public int MaxIndex;

	public const int Offset_Buckets = 28;

	public const int Size = 32;
}
