using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal class AreaContainer
{
	[FieldOffset(8)]
	public long PrimaryAreaPtr;

	[FieldOffset(16)]
	public long SecondaryAreaPtr;

	public const int Size = 2432;

	public const int HeaderSize = 24;
}
