using Plugins;

internal class SkillEffect(uint uint_7, uint uint_8, ISnoActor isnoActor_1, ISkillEffectRule iskillEffectRule_1) : Actor(uint_7, uint_8, isnoActor_1), IActor, ISkillEffect
{
	public ISkillEffectRule SkillEffectRule { get; } = iskillEffectRule_1;
}
