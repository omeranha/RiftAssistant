namespace Plugins;

public interface IMonsterKilledHandler : IPlugin
{
	void OnMonsterKilled(IMonster monster);
}
