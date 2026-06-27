namespace Plugins;

public interface IItemLocationChangedHandler : IPlugin
{
	void OnItemLocationChanged(Item item, ItemLocation from, ItemLocation to);
}
