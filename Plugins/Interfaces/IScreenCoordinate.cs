namespace Plugins;

public interface IScreenCoordinate
{
	float X { get; set; }

	float Y { get; set; }

	IWindow Window { get; }

	void Set(float x, float y);

	float DistanceToCursor();

	IScreenCoordinate Offset(float ox, float oy);

	IWorldCoordinate ToWorldCoordinate();

	string ToString();
}
