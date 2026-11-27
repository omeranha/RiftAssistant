using System;

namespace Plugins.Default;

public class WorldStarShapePainter : IWorldShapePainter
{
	public Controller Assistant { get; }
	public int VerticeCount { get; set; } = 3;
	public int VerticeJump { get; set; } = 1;

	public WorldStarShapePainter(Controller assistant)
	{
		Assistant = assistant;
	}

	public static IWorldShapePainter NewTriangle(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 3,
			VerticeJump = 1,
		};
	}

	public static IWorldShapePainter NewSquare(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 4,
			VerticeJump = 1,
		};
	}

	public static IWorldShapePainter NewCross(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 4,
			VerticeJump = 2,
		};
	}

	public static IWorldShapePainter NewPentagon(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 5,
			VerticeJump = 1,
		};
	}

	public static IWorldShapePainter NewPentagram(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 5,
			VerticeJump = 2,
		};
	}

	public static IWorldShapePainter New5Star(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 5,
			VerticeJump = 2,
		};
	}

	public static IWorldShapePainter NewDoubleTriangle(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 6,
			VerticeJump = 2,
		};
	}

	public static IWorldShapePainter NewOctagon(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 8,
			VerticeJump = 1,
		};
	}

	public static IWorldShapePainter NewDoubleSquare(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 8,
			VerticeJump = 2,
		};
	}

	public static IWorldShapePainter NewTripleTriangle(Controller assistant)
	{
		return new WorldStarShapePainter(assistant) {
			VerticeCount = 9,
			VerticeJump = 3,
		};
	}

	public void Paint(float x, float y, float z, float radius, float rotation, IBrush brush, IBrush shadowBrush)
	{
		if (shadowBrush != null) {
			shadowBrush.StrokeWidth = brush.StrokeWidth >= 0 ? brush.StrokeWidth + 1 : brush.StrokeWidth - 1;
			Paint(x, y, z, radius, rotation, shadowBrush);
		}

		Paint(x, y, z, radius, rotation, brush);
	}

	private void Paint(float x, float y, float z, float radius, float rotation, IBrush brush)
	{
		var angleStep = 360f / VerticeCount;
		for (var i = 0; i < VerticeCount; i++) {
			var sx = radius * (float)Math.Cos((((i + 0) * angleStep) + rotation) * Math.PI / 180f);
			var sy = radius * (float)Math.Sin((((i + 0) * angleStep) + rotation) * Math.PI / 180f);
			var ex = radius * (float)Math.Cos((((i + VerticeJump) * angleStep) + rotation) * Math.PI / 180f);
			var ey = radius * (float)Math.Sin((((i + VerticeJump) * angleStep) + rotation) * Math.PI / 180f);
			brush.DrawLineWorld(x + sx, y + sy, z, x + ex, y + ey, z);
		}
	}
}
