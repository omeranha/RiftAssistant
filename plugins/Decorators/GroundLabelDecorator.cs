using System.Collections.Generic;
using System.Globalization;

namespace Plugins.Default;

public class GroundLabelDecorator : IWorldDecorator
{
	public bool Enabled { get; set; }
	public WorldLayer Layer { get; } = WorldLayer.Ground;
	public Controller Assistant { get; set; }

	public IFont TextFont { get; set; }

	public IBrush BackgroundBrush { get; set; }
	public IBrush BorderBrush { get; set; }

	public Texture BackgroundTexture1 { get; set; }
	public Texture BackgroundTexture2 { get; set; }
	public float BackgroundTextureOpacity1 { get; set; }
	public float BackgroundTextureOpacity2 { get; set; }

	public float? CountDownFrom { get; set; }

	private GroundLabelDecoratorPainter painter;

	public float OffsetX { get; set; }
	public float OffsetY { get; set; }
	public bool CenterBaseLine { get; set; } = true;
	public bool ForceOnScreen { get; set; } = true;

	public GroundLabelDecorator(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
	}

	public void Paint(Actor actor, WorldCoordinate coord, string text)
	{
		if (!Enabled)
			return;

		painter ??= Assistant.GetPlugin<GroundLabelDecoratorPainter>();
		if (painter == null)
			return;

		if ((CountDownFrom != null) && (actor != null)) {
			var remaining = CountDownFrom.Value - ((Assistant.Game.CurrentGameTick - actor.CreatedAtInGameTick) / 60.0f);
			if (remaining < 0)
				remaining = 0;

			var vf = (remaining > 1.0f) ? "F0" : "F1";
			text = remaining.ToString(vf, CultureInfo.InvariantCulture);
		}

		painter.EnqueLabelForPaint(this, coord, text);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return BackgroundBrush;
		yield return BorderBrush;
		yield return TextFont;
	}
}
