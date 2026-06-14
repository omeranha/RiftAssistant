using System.Runtime.InteropServices;

namespace work;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal class r_LocalHeap
{
	[FieldOffset(8)]
	public long FirstNodeAddress;

	[FieldOffset(16)]
	public uint TotalSize;

	[FieldOffset(32)]
	public uint NodeCount;

	[FieldOffset(104)]
	public long LastNodeAddress;

	public const int int_0 = 112;
}
