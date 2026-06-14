namespace Plugins;

public interface ILootGeneratedHandler : IPlugin
{
	void OnLootGenerated(IItem item, bool gambled);
}
