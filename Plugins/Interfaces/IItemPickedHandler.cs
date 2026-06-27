namespace Plugins;

public interface IItemPickedHandler : IPlugin
{
	void OnItemPicked(Item item);
}
