using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ArmoryPotion
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(16)]
	public uint uint_1;
}
