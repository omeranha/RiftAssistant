using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ActiveSkillSavedData
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public int int_0;

	[FieldOffset(8)]
	public int int_1;

	[FieldOffset(12)]
	public int int_2;
}
