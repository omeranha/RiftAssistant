using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MarkerEntry
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public uint uint_0;

	[FieldOffset(12)]
	public r_Marker struct17_0;

	public const int int_0 = 88;
}
