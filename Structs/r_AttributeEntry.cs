using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_AttributeEntry
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public uint uint_0;

	[FieldOffset(12)]
	public int int_0;

	[FieldOffset(12)]
	public float float_0;

	public const int int_1 = 16;

	public static readonly r_AttributeEntry struct8_0;
}
