namespace Plugins;

public interface IMonsterKilledHandler : IPlugin
{
	void OnMonsterKilled(Monster monster);
}
