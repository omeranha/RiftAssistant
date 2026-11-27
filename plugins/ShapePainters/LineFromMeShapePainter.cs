namespace Plugins.Default;

public class LineFromMeShapePainter : IShapePainter
{
	public Controller Assistant { get; }

	public LineFromMeShapePainter(Controller assistant)
	{
		Assistant = assistant;
	}

	public void Paint(float x, float y, float radius, IBrush brush, IBrush shadowBrush)
	{
		Assistant.Render.GetMinimapCoordinates(Assistant.Game.LocalPlayer.FloorCoordinate.X, Assistant.Game.LocalPlayer.FloorCoordinate.Y, out var meOnMapX, out var meOnMapY);

		brush.DrawLine(x, y, meOnMapX, meOnMapY);
	}
}
