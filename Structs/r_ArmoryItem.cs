using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ArmoryItem
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(16)]
	public uint uint_1;

	[FieldOffset(20)]
	public uint uint_2;

	[FieldOffset(24)]
	public uint uint_3;

	[FieldOffset(28)]
	public int int_0;

	[FieldOffset(32)]
	public int int_1;

	[FieldOffset(36)]
	public int int_2;

	public const int int_3 = 48;
}
