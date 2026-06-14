using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

	public string method_1()
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
		StringBuilder stringBuilder = new StringBuilder(num);
		int num3 = 0;
		int num4 = num;
		while (num4 > 0)
		{
			int num5 = ((num4 > bufferSize) ? bufferSize : num4);
			stream.ReadExactly(byteBuffer, 0, num5);
			int chars = decoder.GetChars(byteBuffer, 0, num5, charBuffer, 0);
			stringBuilder.Append(charBuffer, 0, chars);
			num3 += num5;
			num4 -= num5;
		}
		return stringBuilder.ToString();
	}

	public string[] method_2()
	{
		int num = method_11();
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = 0;
			int num3 = 0;
			byte b;
			do
			{
				if (num3 == 35)
				{
					throw new FormatException("bad formatted 7-bit integer!");
				}
				b = (byte)stream.ReadByte();
				num2 |= (b & 0x7F) << num3;
				num3 += 7;
			}
			while ((b & 0x80) != 0);
			if (num2 == 0)
			{
				array[i] = "";
				continue;
			}
			if (num2 <= bufferSize)
			{
				stream.ReadExactly(byteBuffer, 0, num2);
				array[i] = encoder.GetString(byteBuffer, 0, num2);
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder(num2);
			int num4 = 0;
			int num5 = num2;
			while (num5 > 0)
			{
				int num6 = ((num5 > bufferSize) ? bufferSize : num5);
				stream.ReadExactly(byteBuffer, 0, num6);
				int chars = decoder.GetChars(byteBuffer, 0, num6, charBuffer, 0);
				stringBuilder.Append(charBuffer, 0, chars);
				num4 += num6;
				num5 -= num6;
			}
			array[i] = stringBuilder.ToString();
		}
		return array;
	}

	public void method_3(List<string> list_0)
	{
		int num = method_11();
		for (int i = 0; i < num; i++)
		{
			int num2 = 0;
			int num3 = 0;
			byte b;
			do
			{
				if (num3 == 35)
				{
					throw new FormatException("bad formatted 7-bit integer!");
				}
				b = (byte)stream.ReadByte();
				num2 |= (b & 0x7F) << num3;
				num3 += 7;
			}
			while ((b & 0x80) != 0);
			if (num2 == 0)
			{
				list_0.Add("");
				continue;
			}
			if (num2 <= bufferSize)
			{
				stream.ReadExactly(byteBuffer, 0, num2);
				list_0.Add(encoder.GetString(byteBuffer, 0, num2));
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder(num2);
			int num4 = 0;
			int num5 = num2;
			while (num5 > 0)
			{
				int num6 = ((num5 > bufferSize) ? bufferSize : num5);
				stream.ReadExactly(byteBuffer, 0, num6);
				int chars = decoder.GetChars(byteBuffer, 0, num6, charBuffer, 0);
				stringBuilder.Append(charBuffer, 0, chars);
				num4 += num6;
				num5 -= num6;
			}
			list_0.Add(stringBuilder.ToString());
		}
	}

	public string method_4()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		return method_1();
	}

	public string[,] method_5()
	{
		int num = method_11();
		int num2 = method_11();
		string[,] array = new string[num, num2];
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (stream.ReadByte() != 0)
				{
					array[i, j] = method_1();
				}
			}
		}
		return array;
	}

	public byte method_6()
	{
		return (byte)stream.ReadByte();
	}

	public int method_7()
	{
		stream.ReadExactly(buffer16, 0, 4);
		return buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24);
	}

	public uint method_8()
	{
		stream.ReadExactly(buffer16, 0, 4);
		return (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
	}

	public long method_9()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return (long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num);
	}

	public ulong method_10()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return ((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num;
	}

	public int method_11()
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

	public long method_12()
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

	public int? method_13()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 4);
		return buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24);
	}

	public unsafe float method_14()
	{
		stream.ReadExactly(buffer16, 0, 4);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return *(float*)(&num);
	}

	public unsafe float? method_15()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 4);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return *(float*)(&num);
	}

	public unsafe double method_16()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		ulong num2 = ((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num;
		return *(double*)(&num2);
	}

	public unsafe double? method_17()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		ulong num2 = ((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num;
		return *(double*)(&num2);
	}

	public bool method_18()
	{
		return stream.ReadByte() == 1;
	}

	public bool? method_19()
	{
		int num = stream.ReadByte();
		if (num == 2)
		{
			return null;
		}
		return num == 1;
	}

	public DateTime method_20()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public DateTime? method_21()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public long? method_22()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return (long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num);
	}

	public DateTime method_23()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public DateTime? method_24()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public DateTime method_25()
	{
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public DateTime? method_26()
	{
		if (stream.ReadByte() == 0)
		{
			return null;
		}
		stream.ReadExactly(buffer16, 0, 8);
		uint num = (uint)(buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24));
		return new DateTime((long)(((ulong)(uint)(buffer16[4] | (buffer16[5] << 8) | (buffer16[6] << 16) | (buffer16[7] << 24)) << 32) | num));
	}

	public byte[] method_27()
	{
		stream.ReadExactly(buffer16, 0, 4);
		int num = buffer16[0] | (buffer16[1] << 8) | (buffer16[2] << 16) | (buffer16[3] << 24);
		byte[] array = new byte[num];
		if (num > 0)
		{
			stream.ReadExactly(array, 0, num);
		}
		return array;
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
