using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Container
{
	public const int int_0 = 256;

	[FieldOffset(256)]
	public int Capacity;

	[FieldOffset(264)]
	public int MaxIndex;

	public const int int_3 = 288;

	[FieldOffset(288)]
	public long DataAddress;

	public const int int_4 = 304;
}
