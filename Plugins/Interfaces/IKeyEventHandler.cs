namespace Plugins;

public interface IKeyEventHandler : IPlugin
{
	void OnKeyEvent(IKeyEvent keyEvent);
}
