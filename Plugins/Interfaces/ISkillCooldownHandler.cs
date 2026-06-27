namespace Plugins;

public interface ISkillCooldownHandler : IPlugin
{
	void OnCooldown(Skill playerSkill, bool expired);
}
