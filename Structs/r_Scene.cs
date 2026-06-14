using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Scene
{
	[FieldOffset(0)]
	public uint Id;

	[FieldOffset(8)]
	public uint SSceneID;

	[FieldOffset(12)]
	public uint SWorldID;

	[FieldOffset(28)]
	public uint LevelAreaSNO;

	[FieldOffset(68)]
	public uint MusicSno;

	[FieldOffset(72)]
	public uint AmbientSno;

	[FieldOffset(76)]
	public uint ReverbSno;

	[FieldOffset(80)]
	public uint WeatherSno;

	[FieldOffset(160)]
	public int SquareCountX;

	[FieldOffset(164)]
	public int SquareCountY;

	[FieldOffset(236)]
	public uint SceneSno;

	[FieldOffset(256)]
	public float mesh_min_x;

	[FieldOffset(260)]
	public float mesh_min_y;

	[FieldOffset(264)]
	public float mesh_min_z;

	[FieldOffset(376)]
	public float mesh_max_x;

	[FieldOffset(380)]
	public float mesh_max_y;

	[FieldOffset(392)]
	public float mesh_max_z;

	public const int int_2 = 1976;

	[FieldOffset(1972)]
	public int dummy;
}
