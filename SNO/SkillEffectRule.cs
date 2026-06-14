using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SkillEffectRule : ISkillEffectRule
{
	[CompilerGenerated]
	private readonly SkillEffectType skillEffectType_0;

	[CompilerGenerated]
	private readonly ISnoActor isnoActor_0;

	[CompilerGenerated]
	private readonly float float_0;

	public SkillEffectType Type
	{
		[CompilerGenerated]
		get
		{
			return skillEffectType_0;
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

	public float Radius
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	internal SkillEffectRule(SkillEffectType skillEffectType_1, ISnoActor isnoActor_1, float float_1)
	{
		skillEffectType_0 = skillEffectType_1;
		isnoActor_0 = isnoActor_1;
		float_0 = float_1;
	}
}
