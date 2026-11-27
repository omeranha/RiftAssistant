using System.Collections.Generic;
using System.Drawing;

namespace Plugins.Default;

public class TopLabelWithTitleDecorator : ITransparentCollection
{
	public bool Enabled { get; set; }
	public Controller Assistant { get; }

	public IBrush BackgroundBrush { get; set; }
	public IBrush BorderBrush { get; set; }
	public IFont TitleFont { get; set; }
	public IFont TextFont { get; set; }

	public TopLabelWithTitleDecorator(Controller assistant)
	{
		Enabled = true;
		Assistant = assistant;
	}

	public void Paint(float x, float y, float w, float h, string text, string title = null, string hint = null)
	{
		if (!Enabled)
			return;
		if (TextFont == null)
			return;

		var layout = TextFont.GetTextLayout(text);

		var rect = new RectangleF(x, y, w, h);
		if (!string.IsNullOrEmpty(hint) && Assistant.Window.CursorInsideRect(x, y, w, h))
			Assistant.Render.SetHint(hint);

		BackgroundBrush?.DrawRectangle(rect);

		var realY = y;
		if ((TitleFont != null) && (BorderBrush != null) && !string.IsNullOrEmpty(title)) {
			var titleLayout = TitleFont.GetTextLayout(title);
			var pad = 3 * Assistant.Window.Size.Height / 1200.0f;
			realY = y + pad + titleLayout.Metrics.Height + pad;
			BorderBrush.DrawLine(x, realY, x + w, realY);
			TitleFont.DrawText(titleLayout, x + ((w - titleLayout.Metrics.Width) / 2), y + pad);
		}

		TextFont.DrawText(layout, x + ((w - layout.Metrics.Width) / 2), realY + ((h - (realY - y) - layout.Metrics.Height) / 2));

		BorderBrush?.DrawRectangle(rect);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return BackgroundBrush;
		yield return BorderBrush;
		yield return TitleFont;
		yield return TextFont;
	}
}
