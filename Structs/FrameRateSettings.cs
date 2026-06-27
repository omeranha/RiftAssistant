using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct FrameRateSettings
{
	[FieldOffset(0)]
	public bool ForegroundLimitEnabled;

	[FieldOffset(4)]
	public bool BackgroundLimitEnabled;

	public static int Size = 8;
}
