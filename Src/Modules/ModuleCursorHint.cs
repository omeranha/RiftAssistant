using System;
using SharpDX.DirectWrite;

namespace RiftAssistant.Modules;

internal class ModuleCursorHint : Module
{
	public readonly RenderBrush backgroundBrush = new RenderBrush(192, 0, 0, 0, 0f);

	public static readonly RenderFont renderFont = new RenderFont(255, 255, 255, 255, "Arial", false, false, 7f, Alignment.Center, true, false);

	private string? hint;

	private string cachedHint = null!;

	private string? location;

	private int maxWidth = -1;

	public ModuleCursorHint() : base(true)
	{
		bool_1 = false;
		SetTransparentComponents(backgroundBrush, renderFont, renderFont);
	}

	protected void Dispose(bool disposing)
	{
		if (disposing) {
			backgroundBrush?.Dispose();
			renderFont?.Dispose();
		}
		base.Dispose();
	}

	public void SetHint(string? text, string? location, int maxWidth = -1)
	{
		this.hint = text;
		this.location = location;
		this.maxWidth = maxWidth;
	}

	public void Draw()
	{
		bool bool_;
		if ((bool_ = hint != null && (!CoreCollector.IsGameReady || CoreCollector.LocalPlayer.AnimationState == AcdAnimationState.Idle)) && location != null) {
			string location2 = location;
			if ((location2 == "tooltip-top-left" || location2 == "tooltip-bottom-right") && !CoreCollector.UiElements.Tooltip2.Visible) {
				bool_ = false;
			}
		}
		if (!vmethod_0(bool_)) {
			return;
		}
		if (hint != null) {
			cachedHint = hint;
		}
		renderFont.MaxWidth = ((maxWidth == -1) ? 10000 : maxWidth);
		renderFont.WordWrap = maxWidth != -1;
		int num = GameWindowManager.Window.Size.Height / 200;
		TextLayout textLayout = renderFont.GetTextLayout(cachedHint);
		int num2 = Convert.ToInt32(textLayout.Metrics.Width + (float)(num * 4));
		int num3 = Convert.ToInt32(textLayout.Metrics.Height + (float)(num * 2));
		float num4 = (float)Math.Max(0, Math.Min(GameWindowManager.Window.CursorX - num2, GameWindowManager.Window.Size.Width - num2)) + 0.5f;
		float num5 = (float)Math.Max(0, Math.Min(Convert.ToInt32(GameWindowManager.Window.CursorY - num3), GameWindowManager.Window.Size.Height - num3)) + 0.5f;
		if (location != null) {
			string location3 = location;
			if (!(location3 == "tooltip-top-left")) {
				if (location3 == "tooltip-bottom-right") {
					num4 = CoreCollector.UiElements.Tooltip2.rectangle.Right;
					num5 = CoreCollector.UiElements.Tooltip2.rectangle.Bottom - (float)num3;
				}
			} else {
				num4 = CoreCollector.UiElements.Tooltip2.rectangle.Left;
				num5 = CoreCollector.UiElements.Tooltip2.rectangle.Top - (float)num3;
			}
		}
		backgroundBrush.DrawRectangle(num4, num5, num2, num3);
		renderFont.DrawText(textLayout, num4 + (float)(num * 2), num5 + (float)num);
	}
}
