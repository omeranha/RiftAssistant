using SharpDX.Direct2D1;


namespace Plugins;

public interface IBrush : ITransparent
{
	float StrokeWidth { get; set; }

	StrokeStyle StrokeStyle { get; }

	float ScaledStrokeWidth { get; }

	void DrawEllipse(float x1, float y1, float r1, float r2, float strokeWidthCorrection = 0f);

	void DrawLine(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f);

	void DrawLineGridFit(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f);

	void DrawLineWorld(float x1, float y1, float z1, float x2, float y2, float z2, float strokeWidthCorrection = 0f);

	void DrawLineWorld(WorldCoordinate wc1, WorldCoordinate wc2, float strokeWidthCorrection = 0f);

	void DrawRectangle(System.Drawing.RectangleF rectangle);

	void DrawRectangle(SharpDX.RectangleF rectangle);

	void DrawRectangle(float x, float y, float w, float h);

	void DrawRectangleGridFit(float x, float y, float w, float h);

	void DrawWorldEllipse(float radius, int sectionCount, WorldCoordinate coordinate);

	void DrawWorldEllipse(float radius, int sectionCount, float x, float y, float z);

	void DrawWorldPlus(float radius, float x, float y, float z);

	void DrawGeometry(Geometry geometry);
}
