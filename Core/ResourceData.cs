using System;
using System.Buffers.Binary;
using System.IO;
using Microsoft.Win32.SafeHandles;

internal static class ResourceData
{
	private static readonly SafeFileHandle Handle = File.OpenHandle(Path.Combine(Program.AppDir, "data", "resource_data.bin"), FileMode.Open, FileAccess.Read, FileShare.Read, FileOptions.RandomAccess);

	public static byte[] ReadBlob(long position)
	{
		Span<byte> header = stackalloc byte[sizeof(int)];
		RandomAccess.Read(Handle, header, position);
		int length = BinaryPrimitives.ReadInt32LittleEndian(header);
		if (length <= 0) return [];

		byte[] blob = new byte[length];
		RandomAccess.Read(Handle, blob, position + sizeof(int));
		return blob;
	}
}