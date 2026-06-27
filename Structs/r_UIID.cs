using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_UIID
{
	[StructLayout(LayoutKind.Sequential, Size = 512)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct24
	{
		public sbyte sbyte_0;
	}

	[FieldOffset(0)]
	public ulong ulong_0;

	[FieldOffset(8)]
	public unsafe fixed sbyte struct24_0[512];

	[FieldOffset(520)]
	public long long_0;

	[FieldOffset(528)]
	public long long_1;

	public const int Size = 536;

	public const int int_1 = 520;
}
