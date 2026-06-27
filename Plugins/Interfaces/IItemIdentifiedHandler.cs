namespace Plugins;

public interface IItemIdentifiedHandler : IPlugin
{
	void OnItemIdentified(Item item);
}
