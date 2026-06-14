namespace Plugins;

public interface IItemPickedHandler : IPlugin
{
	void OnItemPicked(IItem item);
}
