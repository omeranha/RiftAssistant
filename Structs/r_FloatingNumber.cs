using System.Diagnostics;
using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_FloatingNumber
{
	[FieldOffset(0)]
	public Enum3 enum3_0;

	[FieldOffset(8)]
	public float float_0;

	[FieldOffset(12)]
	public float float_1;

	[FieldOffset(16)]
	public float float_2;

	[FieldOffset(20)]
	public uint uint_0;

	[FieldOffset(60)]
	public int int_0;

	[FieldOffset(64)]
	public int int_1;

	[FieldOffset(88)]
	public uint uint_1;

	[FieldOffset(92)]
	public float float_3;

	[FieldOffset(96)]
	public long long_0;

	[FieldOffset(104)]
	public long long_1;

	public const int int_2 = 112;
}
