namespace Plugins;

public interface IItemIdentifiedHandler : IPlugin
{
	void OnItemIdentified(IItem item);
}
