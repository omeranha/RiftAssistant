using SNO;

namespace Plugins;

public interface INewAreaHandler : IPlugin
{
	void OnNewArea(bool newGame, SnoArea area);
}
