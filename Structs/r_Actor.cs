using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Actor
{
	[FieldOffset(0)]
	public uint ActorId;

	[FieldOffset(136)]
	public uint AcdIdEncrypted;

	[FieldOffset(192)]
	public float CollisionX;

	[FieldOffset(196)]
	public float CollisionY;

	[FieldOffset(200)]
	public float CollisionZ;

	[FieldOffset(204)]
	public float CollisionRadius;

	[FieldOffset(208)]
	public float BottomX;

	[FieldOffset(212)]
	public float BottomY;

	[FieldOffset(216)]
	public float BottomZ;

	[FieldOffset(224)]
	public float BottomRadius;

	[FieldOffset(740)]
	public uint IsSelected;

	[FieldOffset(1172)]
	public int CreationTick;

	[FieldOffset(1268)]
	public int dummy;
}
