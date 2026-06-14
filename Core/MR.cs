using System;
using System.Runtime.CompilerServices;

namespace work;

internal class MR : MemoryReader
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class118
	{
		public static readonly Class118 class118_0 = new Class118();

		internal MR method_0()
		{
			return new MR(bool_1: true);
		}
	}

	[CompilerGenerated]
	private readonly bool bool_0;

	private static readonly Lazy<MR> lazy_0 = new Lazy<MR>(() => new MR(bool_1: true));

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public static MR Instance => lazy_0.Value;

	public MR(bool bool_1)
		: base("Diablo III" + (bool_1 ? "64" : ""), bool_0: false)
	{
		bool_0 = bool_1;
	}
}
