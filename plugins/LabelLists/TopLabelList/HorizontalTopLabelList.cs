namespace Plugins.Default;

public class HorizontalTopLabelList : AbstractTopLabelList
{
	public HorizontalTopLabelList(Controller assistant)
		: base(assistant)
	{
	}

	protected override void Paint(float x, float y, float labelWidth, float labelHeight)
	{
		TopLabelDecorator selectedLabel = null;
		var selectedX = 0f;
		foreach (var label in LabelDecorators) {
			if (!Assistant.Window.CursorInsideRect(x, y, labelWidth, labelHeight)) {
				label.Paint(x, y, labelWidth, labelHeight, HorizontalAlign.Center);
			} else {
				selectedLabel = label;
				selectedX = x;
			}

			x += labelWidth + SpacingAdjustmentInPixels;
		}

		selectedLabel?.Paint(selectedX, y, labelWidth, labelHeight, HorizontalAlign.Center);
	}
}
