namespace Plugins.Default;

public class DoorShapePainter : IShapePainter
{
	public Controller Assistant { get; }

	public DoorShapePainter(Controller assistant)
	{
		Assistant = assistant;
	}

	public void Paint(float x, float y, float radius, IBrush brush, IBrush shadowBrush)
	{
		if (shadowBrush != null) {
			shadowBrush.StrokeWidth = brush.StrokeWidth + 1;
			shadowBrush.DrawRectangle(x - (radius / 2.0f), y - radius, radius, radius * 2.0f);
		}

		brush.DrawRectangle(x - (radius / 2.0f), y - radius, radius, radius * 2.0f);
		brush.DrawLine(x, y - (radius / 2.0f), x, y + (radius / 2.0f));
	}
}
