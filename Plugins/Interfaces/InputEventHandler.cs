namespace Plugins;

public interface IKeyEventHandler : IPlugin
{
	void OnKeyEvent(InputEvent keyEvent);
}
