using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal class r_Block
{
	[FieldOffset(0)]
	public long NextNodePtr;

	[FieldOffset(8)]
	public long ArrayStart;

	[FieldOffset(24)]
	public int Limit;

	[FieldOffset(28)]
	public int ElementSize;

	[FieldOffset(32)]
	public int ElementCount;

	[FieldOffset(44)]
	public int FreeCount;

	[FieldOffset(56)]
	public long PtrFreeSpaceBitmap;

	[FieldOffset(68)]
	public int GoodFood;

	public const int SizeOf = 72;
}
