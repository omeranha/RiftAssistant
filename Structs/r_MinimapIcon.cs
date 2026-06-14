using System.Diagnostics;
using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MinimapIcon
{
	[FieldOffset(256)]
	public float float_0;

	[FieldOffset(260)]
	public float float_1;

	[FieldOffset(264)]
	public uint uint_0;

	[FieldOffset(268)]
	public uint uint_1;

	[FieldOffset(272)]
	public uint uint_2;

	public const int int_0 = 276;
}
