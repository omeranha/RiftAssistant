using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Waypoint
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(12)]
	public uint uint_1;

	[FieldOffset(36)]
	public int int_0;

	[FieldOffset(40)]
	public int int_1;

	public static int int_2 = 44;
}
