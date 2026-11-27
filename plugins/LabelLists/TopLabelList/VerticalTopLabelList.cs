namespace Plugins.Default;

public class VerticalTopLabelList : AbstractTopLabelList
{
	public VerticalTopLabelList(Controller assistant)
		: base(assistant)
	{
	}

	protected override void Paint(float x, float y, float labelWidth, float labelHeight)
	{
		TopLabelDecorator selectedLabel = null;
		var selectedY = 0f;
		foreach (var label in LabelDecorators) {
			if (!Assistant.Window.CursorInsideRect(x, y, labelWidth, labelHeight)) {
				label.Paint(x, y, labelWidth, labelHeight, HorizontalAlign.Center);
			} else {
				selectedLabel = label;
				selectedY = y;
			}

			y += labelHeight + SpacingAdjustmentInPixels;
		}

		selectedLabel?.Paint(x, selectedY, labelWidth, labelHeight, HorizontalAlign.Center);
	}
}
