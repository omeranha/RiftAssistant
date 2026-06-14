using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_WorldPlace
{
	[FieldOffset(0)]
	public float X;

	[FieldOffset(4)]
	public float Y;

	[FieldOffset(8)]
	public float Z;

	[FieldOffset(12)]
	public uint WorldId;

	public const int int_0 = 16;
}
