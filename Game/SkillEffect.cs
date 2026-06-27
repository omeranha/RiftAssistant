using Plugins;
using SNO;

internal class SkillEffect(uint uint_7, uint uint_8, SnoActor SnoActor_1, SkillEffectRule SkillEffectRule_1) : Actor(uint_7, uint_8, SnoActor_1)
{
	public SkillEffectRule SkillEffectRule { get; } = SkillEffectRule_1;
}
