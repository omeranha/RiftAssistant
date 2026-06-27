using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct VideoSettings
{
	[FieldOffset(0)]
	public bool bool_0;

	[FieldOffset(4)]
	public int int_0;

	[FieldOffset(8)]
	public int int_1;

	[FieldOffset(12)]
	public int int_2;

	[FieldOffset(16)]
	public WindowMode windowMode_0;

	[FieldOffset(20)]
	public int int_3;

	[FieldOffset(24)]
	public int int_4;

	[FieldOffset(28)]
	public int int_5;

	[FieldOffset(32)]
	public int int_6;

	[FieldOffset(36)]
	public int int_7;

	[FieldOffset(40)]
	public int int_8;

	[FieldOffset(44)]
	public int int_9;

	[FieldOffset(48)]
	public int int_10;

	[FieldOffset(52)]
	public int int_11;

	[FieldOffset(56)]
	public int int_12;

	[FieldOffset(60)]
	public int int_13;

	[FieldOffset(64)]
	public float float_0;

	[FieldOffset(68)]
	public int int_14;

	[FieldOffset(72)]
	public int int_15;

	[FieldOffset(76)]
	public int int_16;

	[FieldOffset(80)]
	public bool bool_1;

	[FieldOffset(84)]
	public bool bool_2;

	[FieldOffset(88)]
	public bool bool_3;

	[FieldOffset(92)]
	public bool bool_4;

	[FieldOffset(96)]
	public bool bool_5;

	[FieldOffset(100)]
	public bool bool_6;

	[FieldOffset(104)]
	public int int_17;

	[FieldOffset(108)]
	public int int_18;

	[FieldOffset(112)]
	public bool bool_7;

	[FieldOffset(116)]
	public int MaxForegroundFps;

	[FieldOffset(120)]
	public bool bool_8;

	[FieldOffset(124)]
	public int MaxBackgroundFps;

	[FieldOffset(128)]
	public int int_21;

	[FieldOffset(132)]
	public bool bool_9;

	[FieldOffset(136)]
	public bool bool_10;

	[FieldOffset(140)]
	public float float_1;

	[FieldOffset(144)]
	public int int_22;

	[FieldOffset(148)]
	public int int_23;

	[FieldOffset(152)]
	public int int_24;

	[FieldOffset(156)]
	public float float_2;

	public static int Size = 160;
}
