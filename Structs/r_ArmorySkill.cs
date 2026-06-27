using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct r_ArmorySkill
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public uint uint_1;
}
