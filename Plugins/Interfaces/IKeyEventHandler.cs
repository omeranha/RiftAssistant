namespace Plugins;

public interface InputEventHandler : IPlugin
{
	void OnInputEvent(InputEvent inputEventEvent);
}
