using System.Collections.Generic;

namespace Plugins.Default;

public class MapTextureDecorator : AbstractMapDecoratorWithRadius, IWorldDecoratorWithRadius
{
	public Texture Texture { get; set; }
	public SnoItem SnoItem { get; set; }
	public float OpacityMultiplier { get; set; }

	public MapTextureDecorator(Controller assistant)
		: base(assistant)
	{
		OpacityMultiplier = 1.0f;
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled || Radius <= 0)
			return;

		if (Texture == null) {
			if (SnoItem != null)
				Texture = Assistant.Texture.GetItemTexture(SnoItem);

			if (Texture == null)
				return;
		}

		CalculateCoordinateAndRadius(coord, out var mapX, out var mapY, out var radius);

		var width = Texture.Width * radius;
		var height = Texture.Height * radius;

		Texture.Draw(mapX - (width / 2), mapY - (height / 2), width, height, OpacityMultiplier);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return Texture;
	}
}
