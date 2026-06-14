using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class Class91(Stream stream_1) : IDisposable
{
	protected Stream stream_0 = stream_1;
	private const int BufferSize = 2048;
	private byte[] byte_1 = new byte[BufferSize];

	public Stream Stream_0 => stream_0;

	public void Dispose()
	{
		stream_0?.Close();
		stream_0 = null;
		byte_1 = null;
	}

	public string method_1()
	{
		int byteCount = method_11();
		if (byteCount == 0) return string.Empty;

		if (byteCount <= 512) {
			Span<byte> stackBuffer = stackalloc byte[byteCount];
			stream_0.ReadExactly(stackBuffer);
			return Encoding.UTF8.GetString(stackBuffer);
		}

		if (byteCount <= BufferSize) {
			stream_0.ReadExactly(byte_1, 0, byteCount);
			return Encoding.UTF8.GetString(byte_1, 0, byteCount);
		}

		byte[] rentBytes = ArrayPool<byte>.Shared.Rent(byteCount);
		try {
			stream_0.ReadExactly(rentBytes, 0, byteCount);
			return Encoding.UTF8.GetString(rentBytes, 0, byteCount);
		} finally {
			ArrayPool<byte>.Shared.Return(rentBytes);
		}
	}

	public string[] method_2()
	{
		int count = method_11();
		string[] array = new string[count];
		for (int i = 0; i < count; i++) {
			array[i] = method_1();
		}
		return array;
	}

	public void method_3(List<string> list_0)
	{
		int count = method_11();
		if (list_0.Capacity < list_0.Count + count) {
			list_0.Capacity = list_0.Count + count;
		}

		for (int i = 0; i < count; i++) {
			list_0.Add(method_1());
		}
	}

	public string method_4()
	{
		if (stream_0.ReadByte() == 0) return null;
		return method_1();
	}

	public string[,] method_5()
	{
		int dim1 = method_11();
		int dim2 = method_11();
		string[,] array = new string[dim1, dim2];

		for (int i = 0; i < dim1; i++) {
			for (int j = 0; j < dim2; j++) {
				if (stream_0.ReadByte() != 0) {
					array[i, j] = method_1();
				}
			}
		}
		return array;
	}

	public byte method_6() => (byte)stream_0.ReadByte();

	public int method_7()
	{
		Span<byte> buffer = stackalloc byte[4];
		stream_0.ReadExactly(buffer);
		return BinaryPrimitives.ReadInt32LittleEndian(buffer);
	}

	public uint method_8()
	{
		Span<byte> buffer = stackalloc byte[4];
		stream_0.ReadExactly(buffer);
		return BinaryPrimitives.ReadUInt32LittleEndian(buffer);
	}

	public long method_9()
	{
		Span<byte> buffer = stackalloc byte[8];
		stream_0.ReadExactly(buffer);
		return BinaryPrimitives.ReadInt64LittleEndian(buffer);
	}

	public ulong method_10()
	{
		Span<byte> buffer = stackalloc byte[8];
		stream_0.ReadExactly(buffer);
		return BinaryPrimitives.ReadUInt64LittleEndian(buffer);
	}

	public int method_11()
	{
		int count = 0;
		int shift = 0;
		byte b;
		do {
			if (shift == 35) throw new FormatException("bad formatted 7-bit integer!");

			int read = stream_0.ReadByte();
			if (read == -1) throw new EndOfStreamException();

			b = (byte)read;
			count |= (b & 0x7F) << shift;
			shift += 7;
		} while ((b & 0x80) != 0);

		return count;
	}

	public long method_12()
	{
		long count = 0;
		int shift = 0;
		byte b;
		do {
			if (shift == 70) throw new FormatException("bad formatted (1..10)*7-bit long!");

			int read = stream_0.ReadByte();
			if (read == -1) throw new EndOfStreamException();

			b = (byte)read;
			count |= (long)(b & 0x7F) << shift;
			shift += 7;
		} while ((b & 0x80) != 0);

		return count;
	}

	public int? method_13()
	{
		if (stream_0.ReadByte() == 0) return null;
		return method_7();
	}

	public float method_14()
	{
		Span<byte> buffer = stackalloc byte[4];
		stream_0.ReadExactly(buffer);
		return BitConverter.Int32BitsToSingle(BinaryPrimitives.ReadInt32LittleEndian(buffer));
	}

	public float? method_15()
	{
		if (stream_0.ReadByte() == 0) return null;
		return method_14();
	}

	public double method_16()
	{
		Span<byte> buffer = stackalloc byte[8];
		stream_0.ReadExactly(buffer);
		return BitConverter.Int64BitsToDouble(BinaryPrimitives.ReadInt64LittleEndian(buffer));
	}

	public double? method_17()
	{
		if (stream_0.ReadByte() == 0) return null;
		return method_16();
	}

	public bool method_18() => stream_0.ReadByte() == 1;

	public bool? method_19()
	{
		int b = stream_0.ReadByte();
		if (b == 2) return null;
		return b == 1;
	}

	public DateTime method_20() => new DateTime(method_9());

	public DateTime? method_21()
	{
		if (stream_0.ReadByte() == 0) return null;
		return new DateTime(method_9());
	}

	public long? method_22()
	{
		if (stream_0.ReadByte() == 0) return null;
		return method_9();
	}

	public DateTime method_23() => new(method_9());

	public DateTime? method_24() => method_21();

	public DateTime method_25() => new(method_9());

	public DateTime? method_26() => method_21();

	public byte[] method_27()
	{
		int length = method_7();
		if (length == 0) return Array.Empty<byte>();

		byte[] array = new byte[length];
		stream_0.ReadExactly(array);
		return array;
	}
}