using System;
using System.IO;

namespace work;

public sealed class Experience
{
	public readonly long[] ParagonExpLevel = new long[20001];

	public readonly long[] ParagonTableTotal = new long[20001];

	internal Experience()
	{
		ParagonExpLevel[0] = 0L;
		ParagonTableTotal[0] = 0L;
		long num = 0L;
		byte[] byte_ = File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "experience_paragon.bin"));
		int num2 = 0;
		using DataReader @class = new DataReader(byte_);
		while (@class.Stream.Position < @class.Stream.Length)
		{
			num2++;
			if (num2 >= ParagonExpLevel.Length)
			{
				break;
			}
			long num3 = @class.method_12();
			ParagonExpLevel[num2] = num3;
			num += num3;
			ParagonTableTotal[num2] = num;
		}
	}
}
