using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class ActorShrineTypeInfo
{
	[CompilerGenerated]
	private readonly ShrineType shrineType_0;

	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

	public ShrineType Type
	{
		[CompilerGenerated]
		get
		{
			return shrineType_0;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
	}

	internal ActorShrineTypeInfo(ShrineType shrineType_1, SnoActor SnoActor_1)
	{
		shrineType_0 = shrineType_1;
		SnoActor_0 = SnoActor_1;
	}
}
