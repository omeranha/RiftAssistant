using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_CurrencyData
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(8)]
	public long long_0;

	[FieldOffset(16)]
	public int int_0;

	[FieldOffset(20)]
	public int int_1;
}
