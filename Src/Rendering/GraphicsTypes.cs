using System;
using System.Numerics;
using Vortice.Direct2D1;
using Vortice.DirectWrite;

namespace RiftAssistant.Rendering;

public enum DashStyle
{
	Solid,
	Dash,
	Dot,
	DashDot,
	DashDotDot
}

public enum CapStyle
{
	Flat,
	Square,
	Round,
	Triangle
}

public enum FigureBegin
{
	Filled,
	Hollow
}

public enum FigureEnd
{
	Open,
	Closed
}

public readonly record struct TextMetrics(float Width, float Height);

public sealed class TextLayout : IDisposable
{
	private TextMetrics? metrics;

	internal IDWriteTextLayout Native { get; }

	public TextMetrics Metrics => metrics ??= ReadMetrics();

	internal TextLayout(IDWriteTextLayout native)
	{
		Native = native;
	}

	internal void SetWordWrap(bool wrap)
	{
		var wrapping = wrap ? WordWrapping.Wrap : WordWrapping.NoWrap;
		if (Native.WordWrapping != wrapping) {
			Native.WordWrapping = wrapping;
			metrics = null;
		}
	}

	public void Dispose()
	{
		Native.Dispose();
	}

	private TextMetrics ReadMetrics()
	{
		var native = Native.Metrics;
		return new TextMetrics(native.Width, native.Height);
	}
}

public sealed class PathGeometry : IDisposable
{
	internal ID2D1PathGeometry Native { get; }

	public PathGeometry()
	{
		Native = Overlay.Instance.direct2DFactory.CreatePathGeometry();
	}

	public GeometrySink Open()
	{
		return new GeometrySink(Native.Open());
	}

	public void Dispose()
	{
		Native.Dispose();
	}
}

public sealed class GeometrySink : IDisposable
{
	private readonly ID2D1GeometrySink native;

	internal GeometrySink(ID2D1GeometrySink native)
	{
		this.native = native;
	}

	public void BeginFigure(Vector2 start, FigureBegin begin)
	{
		native.BeginFigure(start, begin == FigureBegin.Filled ? Vortice.Direct2D1.FigureBegin.Filled : Vortice.Direct2D1.FigureBegin.Hollow);
	}

	public void AddLine(Vector2 point)
	{
		native.AddLine(point);
	}

	public void EndFigure(FigureEnd end)
	{
		native.EndFigure(end == FigureEnd.Closed ? Vortice.Direct2D1.FigureEnd.Closed : Vortice.Direct2D1.FigureEnd.Open);
	}

	public void Close()
	{
		native.Close();
	}

	public void Dispose()
	{
		native.Dispose();
	}
}
