using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_SceneRevealInfo
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public uint uint_1;

	[FieldOffset(8)]
	public uint uint_2;

	[FieldOffset(12)]
	public uint uint_3;

	[FieldOffset(16)]
	public float float_0;

	[FieldOffset(20)]
	public float float_1;

	[FieldOffset(24)]
	public float float_2;

	[FieldOffset(28)]
	public float float_3;

	[FieldOffset(32)]
	public uint uint_4;

	[FieldOffset(36)]
	public long long_0;

	[FieldOffset(72)]
	public long long_1;

	[FieldOffset(80)]
	public long long_2;

	public const int int_0 = 88;
}
