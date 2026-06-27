using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SkillEffectRule
{
	[CompilerGenerated]
	private readonly SkillEffectType skillEffectType_0;

	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

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

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
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

	internal SkillEffectRule(SkillEffectType skillEffectType_1, SnoActor SnoActor_1, float float_1)
	{
		skillEffectType_0 = skillEffectType_1;
		SnoActor_0 = SnoActor_1;
		float_0 = float_1;
	}
}
