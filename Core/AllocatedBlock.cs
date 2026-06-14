internal class AllocatedBlock<T>(Allocator class351_1)
{
	public readonly Allocator Allocator = class351_1;

	internal byte[] bitMask;

	public T[] Elements { get; set; }

	public r_Block Block { get; set; }

	public long StartAddress => Block.ArrayStart;

	public long LastElementAddress => Block.ArrayStart + Block.ElementSize * (Block.ElementCount - 1);

	public int Capacity => Block.ElementCount;

	public bool IsAllocated(int int_0)
	{
		return ((bitMask[int_0 / 8] >> int_0 % 8) & 1) == 1;
	}
}
