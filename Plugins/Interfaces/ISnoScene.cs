namespace Plugins;

public interface ISnoScene
{
	uint Sno { get; }

	string Code { get; }

	ISceneHint Hint { get; }
}
