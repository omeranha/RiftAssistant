using System.Runtime.InteropServices;

namespace work;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal class r_MemoryManager
{
	[FieldOffset(88)]
	public long PtrLocalHeap;

	public const int int_0 = 104;

	[FieldOffset(100)]
	public int int_1;

	[FieldOffset(80)]
	public int IsInitialized;
}
