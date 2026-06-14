namespace Plugins;

public interface ISkillCooldownHandler : IPlugin
{
	void OnCooldown(IPlayerSkill playerSkill, bool expired);
}
