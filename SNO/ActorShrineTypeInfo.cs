using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class ActorShrineTypeInfo
{
	[CompilerGenerated]
	private readonly ShrineType shrineType_0;

	[CompilerGenerated]
	private readonly ISnoActor isnoActor_0;

	public ShrineType Type
	{
		[CompilerGenerated]
		get
		{
			return shrineType_0;
		}
	}

	public ISnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return isnoActor_0;
		}
	}

	internal ActorShrineTypeInfo(ShrineType shrineType_1, ISnoActor isnoActor_1)
	{
		shrineType_0 = shrineType_1;
		isnoActor_0 = isnoActor_1;
	}
}
