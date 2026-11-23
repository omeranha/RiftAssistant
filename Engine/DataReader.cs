using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RiftAssistant.Engine;

internal class DataReader : IDisposable
{
	protected Stream stream;

	private byte[] buffer16 = new byte[16];

	private static readonly Encoding encoder = Encoding.UTF8;

	private static readonly Decoder decoder = encoder.GetDecoder();

	private static readonly int bufferSize = 2048;

	private static readonly int charBufferSize = encoder.GetMaxCharCount(bufferSize);

	private byte[] byteBuffer = new byte[bufferSize];

	private char[] charBuffer = new char[charBufferSize];

	public Stream Stream => stream;

	public DataReader() { }

	public DataReader(Stream stream)
	{
		this.stream = stream;
	}

	public DataReader(byte[] bytes)
	{
		this.stream = new MemoryStream(bytes) {
			Position = 0L
		};
	}

	protected void Close()
	{
		stream.Close();
		stream = null;
		buffer16 = null;
		byteBuffer = null;
		charBuffer = null;
	}

	public string ReadString()
	{
		int num = 0;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 == 35)
			{
				throw new FormatException("bad formatted 7-bit integer!");
			}
			b = (byte)stream.ReadByte();
			num |= (b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80) != 0);
		if (num == 0)
		{
			return "";
		}
		if (num <= bufferSize)
		{
			stream.ReadExactly(byteBuffer, 0, num);
			return encoder.GetString(byteBuffer, 0, num);
		}
		StringBuilder stringBuilder2 = new StringBuilder(num);
		int num3 = 0;
		int num4 = num;
		while (num4 > 0)
		{
			int num5 = ((num4 > bufferSize) ? bufferSize : num4);
			stream.ReadExactly(byteBuffer, 0, num5);
			int chars = decoder.GetChars(byteBuffer, 0, num5, charBuffer, 0);
			stringBuilder2.Append(charBuffer, 0, chars);
			num3 += num5;
			num4 -= num5;
		}
		return stringBuilder2.ToString();
	}

	public byte ReadByte()
	{
		return (byte)stream.ReadByte();
	}

	public int ReadInt32()
	{
		stream.ReadExactly(buffer16, 0, 4);
		return buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24);
	}

	public uint ReadUInt32()
	{
		stream.ReadExactly(buffer16, 0, 4);
		return (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
	}

	public ulong ReadUInt64()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return ((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num;
	}

	public int ReadPackedInt32()
	{
		int num = 0;
		byte b = (byte)stream.ReadByte();
		num |= b & 0x7F;
		if ((b & 0x80) == 0)
		{
			return num;
		}
		b = (byte)stream.ReadByte();
		num |= (b & 0x7F) << 7;
		if ((b & 0x80) == 0)
		{
			return num;
		}
		b = (byte)stream.ReadByte();
		num |= (b & 0x7F) << 14;
		if ((b & 0x80) == 0)
		{
			return num;
		}
		b = (byte)stream.ReadByte();
		num |= (b & 0x7F) << 21;
		if ((b & 0x80) == 0)
		{
			return num;
		}
		b = (byte)stream.ReadByte();
		num |= (b & 0x7F) << 28;
		if ((b & 0x80) == 0)
		{
			return num;
		}
		b = (byte)stream.ReadByte();
		num |= (b & 0x7F) << 3;
		if ((b & 0x80) != 0)
		{
			throw new FormatException("bad formatted (1..5)*7-bit int!");
		}
		return num;
	}

	public long ReadPackedInt64()
	{
		long num = 0L;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 == 105)
			{
				throw new FormatException("bad formatted (1..14)*7-bit long!");
			}
			b = (byte)stream.ReadByte();
			num |= (long)(b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80) != 0);
		return num;
	}

	public unsafe float ReadSingle()
	{
		stream.ReadExactly(buffer16, 0, 4);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return *(float*)(&num);
	}

	public bool ReadBoolean()
	{
		return stream.ReadByte() == 1;
	}

	public void Dispose()
	{
		stream?.Dispose();
		stream = null;
		buffer16 = null;
		byteBuffer = null;
		charBuffer = null;
	}
}
