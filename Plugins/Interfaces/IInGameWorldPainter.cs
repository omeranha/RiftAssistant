namespace Plugins;

public interface IInGameWorldPainter : IPlugin
{
	void PaintWorld(WorldLayer layer);
}
