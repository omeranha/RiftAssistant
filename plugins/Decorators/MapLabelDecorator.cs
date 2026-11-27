using System.Collections.Generic;

namespace Plugins.Default;

public class MapLabelDecorator : IWorldDecorator
{
	public bool Enabled { get; set; }
	public WorldLayer Layer { get; } = WorldLayer.Map;
	public Controller Assistant { get; }

	public IFont LabelFont { get; set; }
	public bool Up { get; set; }
	public float RadiusOffset { get; set; }

	public MapLabelDecorator(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled)
			return;
		if (LabelFont == null)
			return;
		if (string.IsNullOrEmpty(text))
			return;
		Assistant.Render.GetMinimapCoordinates(coord.X, coord.Y, out var mapx, out var mapy);

		var offset = RadiusOffset * Assistant.Render.MinimapScale;

		var layout = LabelFont.GetTextLayout(text);
		if (!Up) {
			LabelFont.DrawText(layout, mapx - (layout.Metrics.Width / 2), mapy + offset);
		} else {
			LabelFont.DrawText(layout, mapx - (layout.Metrics.Width / 2), mapy - offset - layout.Metrics.Height);
		}
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield break;
	}
}
