using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal class r_Allocator
{
	[FieldOffset(0)]
	public int ElementSize;

	[FieldOffset(4)]
	public int Limit;

	[FieldOffset(8)]
	public int LinkedListCount;

	[FieldOffset(16)]
	public long LinkedListFirstNodePtr;

	[FieldOffset(24)]
	public int Flags;

	public const int ofs_GoodFood = 40;

	[FieldOffset(40)]
	public uint GoodFood;

	public const int SizeOf = 48;
}
