using System.Collections.Generic;

namespace Plugins.Default;

public class MapShapeDecorator : AbstractMapDecoratorWithRadius, IWorldDecoratorWithRadius
{
	public IBrush Brush { get; set; }
	public IBrush ShadowBrush { get; set; }
	public IShapePainter ShapePainter { get; set; }

	public MapShapeDecorator(Controller assistant)
		: base(assistant)
	{
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled || Brush == null || Radius <= 0 || ShapePainter == null)
			return;

		CalculateCoordinateAndRadius(coord, out var x, out var y, out var radius);

		ShapePainter.Paint(x, y, radius, Brush, ShadowBrush);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return Brush;
		yield return ShadowBrush;
	}
}
