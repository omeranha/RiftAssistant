namespace Plugins.Default;

public class CircleShapePainter : IShapePainter
{
	public Controller Assistant { get; }

	public CircleShapePainter(Controller assistant)
	{
		Assistant = assistant;
	}

	public void Paint(float x, float y, float radius, IBrush brush, IBrush shadowBrush)
	{
		if (shadowBrush != null) {
			shadowBrush.StrokeWidth = brush.StrokeWidth + 1;
			shadowBrush.DrawEllipse(x, y, radius, radius);
		}

		brush.DrawEllipse(x, y, radius, radius);
	}
}
