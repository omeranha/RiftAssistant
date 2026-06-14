namespace Plugins;

public interface INewAreaHandler : IPlugin
{
	void OnNewArea(bool newGame, ISnoArea area);
}
