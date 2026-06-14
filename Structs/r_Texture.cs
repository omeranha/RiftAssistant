using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Texture
{
	[FieldOffset(0)]
	public uint TextureSno;

	[FieldOffset(4)]
	public int FrameIndex;

	public const int int_1 = 8;
}
