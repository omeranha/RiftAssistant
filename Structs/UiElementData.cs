using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal sealed class UiElementData
{
	[FieldOffset(24)]
	public ulong Flags;

	[FieldOffset(48)]
	public ulong Id;

	[FieldOffset(1136)]
	public long ChildEntries;

	[FieldOffset(1144)]
	public int ChildCount;

	[FieldOffset(1176)]
	public float Left;

	[FieldOffset(1180)]
	public float Top;

	[FieldOffset(1184)]
	public float Right;

	[FieldOffset(1188)]
	public float Bottom;

	[FieldOffset(1220)]
	public uint State;

	[FieldOffset(1224)]
	public int Index;

	[FieldOffset(2656)]
	public long UnknownPtr1;

	[FieldOffset(2688)]
	public long UnknownPtr2;
}
