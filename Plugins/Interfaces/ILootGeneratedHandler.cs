namespace Plugins;

public interface ILootGeneratedHandler : IPlugin
{
	void OnLootGenerated(Item item, bool gambled);
}
