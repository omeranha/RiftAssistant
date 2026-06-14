using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Trickle
{
	[FieldOffset(0)]
	public uint AnnId;

	[FieldOffset(4)]
	public uint ActorSno;

	[FieldOffset(8)]
	public r_WorldPlace WorldPlace;

	[FieldOffset(24)]
	public uint PlayerIndex;

	[FieldOffset(28)]
	public uint LevelAreaSno;

	[FieldOffset(32)]
	public float HealthPercent;

	[FieldOffset(36)]
	public uint TrickleInfoType;

	[FieldOffset(40)]
	public uint TrickleFlags;

	[FieldOffset(44)]
	public r_Texture ImageTextureFrame;

	[FieldOffset(52)]
	public uint StringListSno;

	[FieldOffset(56)]
	public uint StringLabelHandle;

	public const int int_0 = 128;

	[FieldOffset(124)]
	public int dummy;
}
