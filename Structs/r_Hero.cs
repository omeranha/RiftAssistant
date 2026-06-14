using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Hero
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public long long_1;

	[FieldOffset(16)]
	public ulong ulong_0;

	[FieldOffset(180)]
	public ulong ulong_1;

	[FieldOffset(184)]
	public ulong ulong_2;

	[FieldOffset(200)]
	public long long_2;

	[FieldOffset(216)]
	public uint uint_0;

	[FieldOffset(232)]
	public long long_3;

	[FieldOffset(256)]
	public uint uint_1;

	[FieldOffset(264)]
	public int int_0;

	[FieldOffset(268)]
	public int int_1;

	[FieldOffset(292)]
	public int season;

	[FieldOffset(336)]
	public int int_3;

	[FieldOffset(360)]
	public uint uint_2;

	[FieldOffset(364)]
	public uint uint_3;

	[FieldOffset(368)]
	public int int_4;

	[FieldOffset(376)]
	public long long_4;

	[FieldOffset(384)]
	public long long_5;

	public const int SizeOf = 392;
}
