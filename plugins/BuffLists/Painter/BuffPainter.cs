using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Numerics;

namespace Plugins.Default;

public class BuffPainter : ITransparentCollection, ITransparent
{
	public bool Enabled { get; set; }
	public Controller Assistant { get; set; }

	public IFont TimeLeftFont { get; set; }
	public IFont StackFont { get; set; }
	public IBrush TimeLeftClockBrush { get; set; }
	public float Opacity { get; set; }

	public bool ShowTooltips { get; set; } = true;
	public bool ShowTimeLeftNumbers { get; set; } = true;
	public bool HasIconBorder { get; set; } = true;

	public double? UseAlternateStyleWhenBuffIsAlmostGone { get; set; } // value should be between 0.0 and 1.0 (represent a percentage of the whole life of the buff)
	public IBrush AlmostGoneBorderBrush { get; set; }
	public IFont AlmostGoneTimeLeftFont { get; set; }

	public BuffPainter(Controller assistant, bool setDefaultStyle)
	{
		Enabled = true;
		Assistant = assistant;

		if (setDefaultStyle) {
			TimeLeftFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 255, 255, false, false, 255, 0, 0, 0, true);
			StackFont = Assistant.Render.CreateFont("Arial", 9, 255, 255, 255, 255, false, false, 255, 0, 0, 0, true);
			TimeLeftClockBrush = Assistant.Render.CreateBrush(220, 0, 0, 0, 0);

			AlmostGoneTimeLeftFont = Assistant.Render.CreateFont("Arial", 9, 255, 255, 0, 0, false, false, 255, 0, 0, 0, true);
			AlmostGoneBorderBrush = Assistant.Render.CreateBrush(220, 255, 0, 0, 3);
			UseAlternateStyleWhenBuffIsAlmostGone = null;
		}
	}

	public void PaintVertical(List<BuffPaintInfo> infoList, float x, float y, float size, float spacing)
	{
		foreach (var info in infoList) {
			var s = info.Size;
			Paint(info, new RectangleF(x + ((size - s) / 2), y, s, s));
			y += s + spacing;
		}
	}

	public void PaintVerticalCenter(List<BuffPaintInfo> infoList, float x, float y, float height, float size, float spacing)
	{
		var totalHeight = spacing * (infoList.Count - 1);
		foreach (var info in infoList)
			totalHeight += info.Size;

		y += (height - totalHeight) / 2;

		foreach (var info in infoList) {
			var s = info.Size;
			Paint(info, new RectangleF(x + ((size - s) / 2), y, s, s));
			y += s + spacing;
		}
	}

	public void PaintHorizontal(List<BuffPaintInfo> infoList, float x, float y, float size, float spacing)
	{
		foreach (var info in infoList) {
			var s = info.Size;
			Paint(info, new RectangleF(x, y + ((size - s) / 2), s, s));
			x += s + spacing;
		}
	}

	public void PaintHorizontalCenter(List<BuffPaintInfo> infoList, float x, float y, float width, float size, float spacing)
	{
		var totalWidth = spacing * (infoList.Count - 1);
		foreach (var info in infoList)
			totalWidth += info.Size;

		x += (width - totalWidth) / 2;

		foreach (var info in infoList) {
			var s = info.Size;
			Paint(info, new RectangleF(x, y + ((size - s) / 2), s, s));
			x += s + spacing;
		}
	}

	protected void Paint(BuffPaintInfo info, RectangleF rect)
	{
		var firstIcon = info.Icons[0];
		var isDebuff = firstIcon.Harmful;

		info.BackgroundTexture?.Draw(rect.X, rect.Y, rect.Width, rect.Height, Opacity);

		info.Texture.Draw(rect.X, rect.Y, rect.Width, rect.Height, Opacity);

		DrawTimeLeftClock(rect, info.Elapsed, info.TimeLeft);

		if (HasIconBorder) {
			(isDebuff ? Assistant.Texture.DebuffFrameTexture : Assistant.Texture.BuffFrameTexture).Draw(rect.X, rect.Y, rect.Width, rect.Height, Opacity);
		}

		if (Assistant.Window.CursorInsideRect(rect.X, rect.Y, rect.Width, rect.Height) && ShowTooltips) {
			if (info.Rule == null) {
				var name = info.SnoPower.NameLocalized;
				if (name == null) {
					foreach (var icon in info.Icons)
						name += (name == null ? "" : "\n") + icon.TitleLocalized;
				}

				string desc = null;
				foreach (var icon in info.Icons)
					desc += (desc == null ? "\n\n" : "\n") + icon.DescriptionLocalized;
				Assistant.Render.SetHint(name + desc);
			} else if (firstIcon.Exists) {
				var name = !info.Rule.DisableName ? (info.Rule.UsePowersName ? info.SnoPower.NameLocalized : firstIcon.TitleLocalized) : null;
				var desc = info.Rule.UsePowersDesc ? info.SnoPower.DescriptionLocalized : (firstIcon.DescriptionLocalized ?? "");
				Assistant.Render.SetHint(name + (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(desc) ? "\n\n" : "") + desc);
			}
		}

		DrawTimeLeftNumbers(rect, info);

		if (info.Stacks > -1) {
			DrawStacks(rect, info.Stacks);
		}
	}

	private void DrawTimeLeftClock(RectangleF rect, double elapsed, double timeLeft)
	{
		if ((timeLeft > 0) && (elapsed >= 0) && (TimeLeftClockBrush != null)) {
			var endAngle = Convert.ToInt32(360.0d / (timeLeft + elapsed) * elapsed);
			var startAngle = 0;
			TimeLeftClockBrush.Opacity = 1 - (float)(0.3f / (timeLeft + elapsed) * elapsed);
			var rad = rect.Width * 0.45f;
			var center = new Vector2(rect.X + rect.Width / 2f, rect.Y + rect.Height / 2f);
			using (var pg = Assistant.Render.CreateGeometry()) {
				using (var gs = pg.Open()) {
					gs.BeginFigure(center, FigureBegin.Filled);
					for (var angle = startAngle; angle <= endAngle; angle++) {
						var mx = rad * (float)Math.Cos((angle - 90) * Math.PI / 180.0f);
						var my = rad * (float)Math.Sin((angle - 90) * Math.PI / 180.0f);
						var vec = new Vector2(center.X + mx, center.Y + my);
						gs.AddLine(vec);
					}

					gs.EndFigure(FigureEnd.Closed);
					gs.Close();
				}

				TimeLeftClockBrush.DrawGeometry(pg);
			}
		}
	}

	private void DrawTimeLeftNumbers(RectangleF rect, BuffPaintInfo info)
	{
		if (info.TimeLeft == 0)
			return;
		if (!ShowTimeLeftNumbers)
			return;
		if (info.TimeLeftNumbersOverride != null && !info.TimeLeftNumbersOverride.Value)
			return;

		string text;
		if (info.TimeLeft > 1.0f) {
			var mins = Convert.ToInt32(Math.Floor(info.TimeLeft / 60.0d));
			var secs = Math.Floor(info.TimeLeft - (mins * 60.0d));
			text = info.TimeLeft >= 60
				? mins.ToString("F0", CultureInfo.InvariantCulture) + ":" + (secs < 10 ? "0" : "") + secs.ToString("F0", CultureInfo.InvariantCulture)
				: info.TimeLeft.ToString("F0", CultureInfo.InvariantCulture);
		} else {
			text = info.TimeLeft.ToString("F1", CultureInfo.InvariantCulture);
		}

		var layout = TimeLeftFont.GetTextLayout(text);

		if (UseAlternateStyleWhenBuffIsAlmostGone != null && info.TimeLeft <= (info.Elapsed + info.TimeLeft) * UseAlternateStyleWhenBuffIsAlmostGone.Value) {
			AlmostGoneBorderBrush?.DrawRectangle(rect);
			AlmostGoneTimeLeftFont.DrawText(layout, rect.X + ((rect.Width - (float)Math.Ceiling(layout.Metrics.Width)) / 2.0f), rect.Y + ((rect.Height - layout.Metrics.Height) / 2));
		} else {
			TimeLeftFont.DrawText(layout, rect.X + ((rect.Width - (float)Math.Ceiling(layout.Metrics.Width)) / 2.0f), rect.Y + ((rect.Height - layout.Metrics.Height) / 2));
		}
	}

	private void DrawStacks(RectangleF rect, int stacks)
	{
		var layout = StackFont.GetTextLayout(stacks.ToString());
		StackFont.DrawText(layout, rect.Right - (rect.Width / 8.0f) - (float)Math.Ceiling(layout.Metrics.Width), rect.Bottom - layout.Metrics.Height - (rect.Width / 15.0f));
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return TimeLeftFont;
		yield return StackFont;
		yield return TimeLeftClockBrush;
		yield return this;
	}
}
