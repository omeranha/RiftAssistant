using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_World
{
	[FieldOffset(8)]
	public uint WorldSno;

	[FieldOffset(16)]
	public uint SWorldID;

	public const int int_0 = 152;

	[FieldOffset(148)]
	public int dummy;
}
