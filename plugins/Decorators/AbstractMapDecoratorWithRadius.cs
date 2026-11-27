namespace Plugins.Default;

public abstract class AbstractMapDecoratorWithRadius
{
	public bool Enabled { get; set; }
	public WorldLayer Layer { get; } = WorldLayer.Map;
	public Controller Assistant { get; }

	public float Radius { get; set; } = 1.0f;
	public IRadiusTransformator RadiusTransformator { get; set; }

	protected AbstractMapDecoratorWithRadius(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
	}

	public void CalculateCoordinateAndRadius(WorldCoordinate coord, out float mapX, out float mapY, out float radius)
	{
		Assistant.Render.GetMinimapCoordinates(coord.X, coord.Y, out mapX, out mapY);

		radius = Radius * Assistant.Render.MinimapScale;

		if (RadiusTransformator != null) {
			radius = RadiusTransformator.TransformRadius(radius);
		}
	}
}
