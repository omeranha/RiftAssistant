using System.Collections.Generic;

namespace Plugins.Default;

public class GroundShapeDecorator : IWorldDecoratorWithRadius
{
	public bool Enabled { get; set; }
	public WorldLayer Layer { get; } = WorldLayer.Ground;
	public Controller Assistant { get; }

	public IBrush Brush { get; set; }
	public IBrush ShadowBrush { get; set; }
	public IWorldShapePainter ShapePainter { get; set; }

	public float Radius { get; set; } = 1.0f;
	public float Rotation { get; set; } = 0.0f;

	public IRadiusTransformator RadiusTransformator { get; set; }
	public IRotationTransformator RotationTransformator { get; set; }

	public GroundShapeDecorator(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled)
			return;
		if (Brush == null)
			return;
		if (Radius <= 0)
			return;
		if (ShapePainter == null)
			return;

		var radius = RadiusTransformator != null ? RadiusTransformator.TransformRadius(Radius) : Radius;
		var rotation = RotationTransformator != null ? RotationTransformator.TransformRotation(Rotation) : Rotation;

		ShapePainter.Paint(coord.X, coord.Y, coord.Z, radius, rotation, Brush, ShadowBrush);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return Brush;
		yield return ShadowBrush;
	}
}
