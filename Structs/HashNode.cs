using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal sealed class HashNode
{
	[FieldOffset(0)]
	public long Next;

	[FieldOffset(8)]
	public ulong Key;

	[FieldOffset(8)]
	public int KeyLow;

	[FieldOffset(12)]
	public int KeyHigh;

	[FieldOffset(16)]
	public long Value;

	public const int Size = 24;
}
