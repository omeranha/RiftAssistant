using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Marker
{
	[FieldOffset(0)]
	public r_WorldPlace struct37_0;

	[FieldOffset(16)]
	public r_Texture struct15_0;

	[FieldOffset(24)]
	public uint uint_0;

	[FieldOffset(28)]
	public uint uint_1;

	[FieldOffset(32)]
	public uint uint_2;

	[FieldOffset(36)]
	public uint uint_3;

	[FieldOffset(72)]
	public uint uint_4;

	[FieldOffset(72)]
	public float float_0;

	[FieldOffset(72)]
	public int int_0;

	public const int int_1 = 76;
}
