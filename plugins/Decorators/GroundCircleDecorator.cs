using System;
using System.Collections.Generic;

namespace Plugins.Default;

public class GroundCircleDecorator : IWorldDecoratorWithRadius
{
	public bool Enabled { get; set; }
	public WorldLayer Layer { get; } = WorldLayer.Ground;
	public Controller Assistant { get; }

	public IBrush Brush { get; set; }
	public bool HasShadow { get; set; } = true;
	private readonly IBrush _shadowBrush;

	public float Radius { get; set; }
	public IRadiusTransformator RadiusTransformator { get; set; }

	public GroundCircleDecorator(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
		_shadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1);
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled)
			return;
		if (Brush == null)
			return;

		var radius = Radius;
		if (radius == -1) {
			if (actor != null) {
				radius = Math.Min(actor.RadiusBottom, 20);
			} else {
				return;
			}
		}

		if (RadiusTransformator != null) {
			radius = RadiusTransformator.TransformRadius(radius);
		}

		if (HasShadow) {
			if (Brush.DashStyle == DashStyle.Solid) {
				_shadowBrush.StrokeWidth = Brush.StrokeWidth >= 0 ? Brush.StrokeWidth + 1 : Brush.StrokeWidth - 1;
				_shadowBrush.DrawWorldEllipse(radius, -1, coord);
			}
		}

		Brush.DrawWorldEllipse(radius, -1, coord);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return Brush;
		yield return _shadowBrush;
	}
}
