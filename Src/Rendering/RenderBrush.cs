#nullable enable annotations
#nullable disable warnings
using System;
using System.Numerics;
using Vortice;
using Vortice.Direct2D1;
using Vortice.Mathematics;

namespace RiftAssistant.Rendering;

internal class RenderBrush : ITransparent, IDisposable, IBrush
{
	private readonly Lazy<ID2D1SolidColorBrush>? brush;

	private readonly ID2D1StrokeStyle strokeStyle;

	public readonly float InitialStrokeWidth;

	private float fallbackOpacity;

	public float StrokeWidth { get; set; }

	public DashStyle DashStyle { get; }

	public float Opacity
	{
		get => brush == null ? fallbackOpacity : brush.Value.Opacity;
		set {
			if (brush != null) {
				brush.Value.Opacity = value;
			} else {
				fallbackOpacity = value;
			}
		}
	}

	public float ScaledStrokeWidth
	{
		get {
			if (StrokeWidth >= 0f) {
				return StrokeWidth;
			}
			return StrokeWidth / -600f * GameWindowManager.Window.Size.Height;
		}
	}

	internal RenderBrush(int alpha, int red, int green, int blue, float strokeWidth, DashStyle dashStyle = DashStyle.Solid, CapStyle startCap = CapStyle.Flat, CapStyle endCap = CapStyle.Flat)
	{
		brush = alpha > 0 ? new Lazy<ID2D1SolidColorBrush>(() => Overlay.Instance.renderTarget.CreateSolidColorBrush(new Color4(red / 255f, green / 255f, blue / 255f, alpha / 255f))) : null;
		StrokeWidth = strokeWidth;
		InitialStrokeWidth = strokeWidth;
		DashStyle = dashStyle;
		// The enum values are the same as Direct2D's.
		var properties = new StrokeStyleProperties {
			DashStyle = (Vortice.Direct2D1.DashStyle)(int)dashStyle,
			StartCap = (Vortice.Direct2D1.CapStyle)(int)startCap,
			EndCap = (Vortice.Direct2D1.CapStyle)(int)endCap
		};

		strokeStyle = Overlay.Instance.direct2DFactory.CreateStrokeStyle(properties);
	}

	public void Dispose()
	{
		if (brush is { IsValueCreated: true }) {
			brush.Value.Dispose();
		}
		strokeStyle.Dispose();
		GC.SuppressFinalize(this);
	}

	public void DrawRectangle(System.Drawing.RectangleF rectangle)
	{
		DrawRectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
	}

	public void DrawRectangle(float x, float y, float w, float h)
	{
		DrawRectangle(new RawRectF(x, y, x + w, y + h));
	}

	public void DrawRectangleGridFit(float x, float y, float w, float h)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			var left = (float)Math.Round(x) + 0.5f;
			var top = (float)Math.Round(y) + 0.5f;
			var rect = new RawRectF(left, top, left + (float)Math.Round(w), top + (float)Math.Round(h));

			if (realStrokeWidth > 0f) {
				Overlay.Instance.renderTarget.DrawRectangle(rect, brush.Value, realStrokeWidth, strokeStyle);
			} else {
				Overlay.Instance.renderTarget.FillRectangle(rect, brush.Value);
			}
		}
	}

	private void DrawRectangle(RawRectF rectangle)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			if (realStrokeWidth > 0f) {
				Overlay.Instance.renderTarget.DrawRectangle(rectangle, brush.Value, realStrokeWidth, strokeStyle);
			} else {
				Overlay.Instance.renderTarget.FillRectangle(rectangle, brush.Value);
			}
		}
	}

	public void DrawLine(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			Overlay.Instance.renderTarget.DrawLine(new Vector2(x1, y1), new Vector2(x2, y2), brush.Value, realStrokeWidth + strokeWidthCorrection, strokeStyle);
		}
	}

	public void DrawLineGridFit(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			Overlay.Instance.renderTarget.DrawLine(new Vector2((float)Math.Round(x1) + 0.5f, (float)Math.Round(y1) + 0.5f), new Vector2((float)Math.Round(x2) + 0.5f, (float)Math.Round(y2) + 0.5f), brush.Value, realStrokeWidth + strokeWidthCorrection, strokeStyle);
		}
	}

	public void DrawLineWorld(float x1, float y1, float z1, float x2, float y2, float z2, float strokeWidthCorrection = 0f)
	{
		if (brush != null) {
			GameWindowManager.Window.WorldToScreenCoordinate(x1, y1, z1, out var screenX, out var screenY);
			GameWindowManager.Window.WorldToScreenCoordinate(x2, y2, z2, out var screenX2, out var screenY2);
			float realStrokeWidth = ScaledStrokeWidth;
			Overlay.Instance.renderTarget.DrawLine(new Vector2(screenX, screenY), new Vector2(screenX2, screenY2), brush.Value, realStrokeWidth + strokeWidthCorrection, strokeStyle);
		}
	}

	public void DrawLineWorld(WorldCoordinate wc1, WorldCoordinate wc2, float strokeWidthCorrection = 0f)
	{
		DrawLineWorld(wc1.X, wc1.Y, wc1.Z, wc2.X, wc2.Y, wc2.Z, strokeWidthCorrection);
	}

	public void DrawEllipse(float x1, float y1, float r1, float r2, float strokeWidthCorrection = 0f)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			var center = new Vector2(x1, y1);
			var ellipse = new Ellipse(center, r1, r2);

			if (realStrokeWidth > 0f) {
				Overlay.Instance.renderTarget.DrawEllipse(ellipse, brush.Value, realStrokeWidth + strokeWidthCorrection, strokeStyle);
			} else {
				Overlay.Instance.renderTarget.FillEllipse(ellipse, brush.Value);
			}
		}
	}

	public void DrawGeometry(PathGeometry geometry)
	{
		if (brush != null) {
			float realStrokeWidth = ScaledStrokeWidth;
			if (realStrokeWidth > 0f) {
				Overlay.Instance.renderTarget.DrawGeometry(geometry.Native, brush.Value, realStrokeWidth, strokeStyle);
			} else {
				Overlay.Instance.renderTarget.FillGeometry(geometry.Native, brush.Value);
			}
		}
	}

	public void DrawWorldEllipse(float radius, int sectionCount, WorldCoordinate coordinate)
	{
		DrawWorldEllipse(radius, sectionCount, coordinate.X, coordinate.Y, coordinate.Z);
	}

	public void DrawWorldEllipse(float radius, int sectionCount, float x, float y, float z)
	{
		switch (sectionCount) {
			case -1:
				sectionCount = Convert.ToInt32(radius * 1.15 + 25.0);
				break;
			case -2:
				sectionCount = Convert.ToInt32(radius * 1.15 + 25.0) / 2;
				break;
		}

		if (sectionCount < 6) {
			sectionCount = 6;
		}

		using var pathGeometry = new PathGeometry();
		using (var geometrySink = pathGeometry.Open()) {
			for (int i = 0; i < sectionCount; i++) {
				float num = radius * (float)Math.Cos(360f / sectionCount * i * Math.PI / 180.0);
				float num2 = radius * (float)Math.Sin(360f / sectionCount * i * Math.PI / 180.0);
				GameWindowManager.Window.WorldToScreenCoordinate(x + num, y + num2, z, out var screenX, out var screenY);
				if (i > 0) {
					geometrySink.AddLine(new Vector2(screenX, screenY));
				} else {
					geometrySink.BeginFigure(new Vector2(screenX, screenY), StrokeWidth != 0f ? FigureBegin.Hollow : FigureBegin.Filled);
				}
			}
			geometrySink.EndFigure(FigureEnd.Closed);
			geometrySink.Close();
		}
		DrawGeometry(pathGeometry);
	}
	public void DrawWorldPlus(float radius, float x, float y, float z)
	{
		float num = radius * (float)Math.Cos(0.0);
		float num2 = radius * (float)Math.Sin(0.0);
		GameWindowManager.Window.WorldToScreenCoordinate(x + num, y + num2, z, out var screenX, out var screenY);

		num = radius * (float)Math.Cos(Math.PI);
		num2 = radius * (float)Math.Sin(Math.PI);
		GameWindowManager.Window.WorldToScreenCoordinate(x + num, y + num2, z, out var screenX2, out var screenY2);
		DrawLine(screenX, screenY, screenX2, screenY2);

		num = radius * (float)Math.Cos(Math.PI / 2.0);
		num2 = radius * (float)Math.Sin(Math.PI / 2.0);
		GameWindowManager.Window.WorldToScreenCoordinate(x + num, y + num2, z, out screenX, out screenY);

		num = radius * (float)Math.Cos(4.71238898038469);
		num2 = radius * (float)Math.Sin(4.71238898038469);
		GameWindowManager.Window.WorldToScreenCoordinate(x + num, y + num2, z, out screenX2, out screenY2);
		DrawLine(screenX, screenY, screenX2, screenY2);
	}
}
