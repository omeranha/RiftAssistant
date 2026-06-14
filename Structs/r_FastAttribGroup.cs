using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_FastAttribGroup
{
	public const int int_0 = 0;

	public const int int_1 = 4;

	public const int int_2 = 16;

	public const int int_3 = 24;

	public const int int_4 = 4840;

	[FieldOffset(4836)]
	public int int_5;
}
