namespace Plugins.Default;

public interface IWorldDecorator : ITransparentCollection
{
	bool Enabled { get; set; }
	WorldLayer Layer { get; }
	void Paint(Actor actor, WorldCoordinate coord, string text);
}
