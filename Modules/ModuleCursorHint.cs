using System;
using SharpDX.DirectWrite;
using Plugins;


internal class ModuleCursorHint : Module
{
	public readonly RenderBrush backgroundBrush = new RenderBrush(192, 0, 0, 0, 0f);

	public static readonly RenderFont class221_0 = new RenderFont(255, 255, 255, 255, "Arial", false, false, 7f, Alignment.Center, true, false);

	private string hint;

	private string cachedHint;

	private string location;

	private int maxWidth = -1;

	public ModuleCursorHint() : base(true)
	{
		bool_1 = false;
		method_0(backgroundBrush, class221_0, class221_0);
	}

	protected void Dispose(bool disposing)
	{
		if (disposing) {
			backgroundBrush?.Dispose();
			class221_0?.Dispose();
		}
		base.Dispose();
	}

	public void SetHint(string text, string location, int maxWidth = -1)
	{
		this.hint = text;
		this.location = location;
		this.maxWidth = maxWidth;
	}

	public void Draw()
	{
		bool bool_;
		if ((bool_ = hint != null && (!CoreCollector.IsGameReady || CoreCollector.LocalPlayer.AnimationState == AcdAnimationState.Idle)) && location != null) {
			string text = location;
			if ((text == "tooltip-top-left" || text == "tooltip-bottom-right") && !CoreCollector.UiElements.class341_162.Visible) {
				bool_ = false;
			}
		}
		if (!vmethod_0(bool_)) {
			return;
		}
		if (hint != null) {
			cachedHint = hint;
		}
		class221_0.MaxWidth = ((maxWidth == -1) ? 10000 : maxWidth);
		class221_0.WordWrap = maxWidth != -1;
		int num = GameWindowManager.Window.Size.Height / 200;
		TextLayout textLayout = class221_0.GetTextLayout(cachedHint);
		int num2 = Convert.ToInt32(textLayout.Metrics.Width + (float)(num * 4));
		int num3 = Convert.ToInt32(textLayout.Metrics.Height + (float)(num * 2));
		float num4 = (float)Math.Max(0, Math.Min(GameWindowManager.Window.CursorX - num2, GameWindowManager.Window.Size.Width - num2)) + 0.5f;
		float num5 = (float)Math.Max(0, Math.Min(Convert.ToInt32(GameWindowManager.Window.CursorY - num3), GameWindowManager.Window.Size.Height - num3)) + 0.5f;
		if (location != null) {
			string text = location;
			if (!(text == "tooltip-top-left")) {
				if (text == "tooltip-bottom-right") {
					num4 = CoreCollector.UiElements.class341_162.rectangleF_0.Right;
					num5 = CoreCollector.UiElements.class341_162.rectangleF_0.Bottom - (float)num3;
				}
			} else {
				num4 = CoreCollector.UiElements.class341_162.rectangleF_0.Left;
				num5 = CoreCollector.UiElements.class341_162.rectangleF_0.Top - (float)num3;
			}
		}
		backgroundBrush.DrawRectangle(num4, num5, num2, num3);
		class221_0.DrawText(textLayout, num4 + (float)(num * 2), num5 + (float)num);
	}
}
