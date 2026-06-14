namespace Plugins;

public interface IItemLocationChangedHandler : IPlugin
{
	void OnItemLocationChanged(IItem item, ItemLocation from, ItemLocation to);
}
