namespace Plugins.Default;

public class PlusShapePainter : IShapePainter
{
	public Controller Assistant { get; }

	public PlusShapePainter(Controller assistant)
	{
		Assistant = assistant;
	}

	public void Paint(float x, float y, float radius, IBrush brush, IBrush shadowBrush)
	{
		if (shadowBrush != null) {
			shadowBrush.StrokeWidth = brush.StrokeWidth + 1;
			shadowBrush.DrawLine(x - radius, y, x + radius, y);
			shadowBrush.DrawLine(x, y - radius, x, y + radius);
		}

		brush.DrawLine(x - radius, y, x + radius, y);
		brush.DrawLine(x, y - radius, x, y + radius);
	}
}
