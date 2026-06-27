using System.Runtime.InteropServices;

namespace work;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MemoryManager
{
	[FieldOffset(80)]
	public int IsInitialized;
	
	[FieldOffset(88)]
	public long PtrLocalHeap;
	
	[FieldOffset(100)]
	public int Unknown1;

	public const int Size = 104;
}
