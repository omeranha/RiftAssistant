namespace Plugins;

public interface IMouseClickHandler : IPlugin
{
	bool MouseDown(Vk button);

	bool MouseUp(Vk button);
}
