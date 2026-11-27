#nullable enable annotations
#nullable disable warnings
using System;
using Vortice;
using Vortice.Direct2D1;

namespace RiftAssistant.Model;

public class Texture : ITransparent
{
	private readonly Lazy<ID2D1Bitmap> bitmap;

	private readonly RawRectF rectF;

	internal static readonly string string_0 = "BAB";

	public float Width => rectF.Right - rectF.Left - 1f;

	public float Height => rectF.Bottom - rectF.Top - 1f;

	public float Opacity { get; set; }

	internal Texture(Lazy<ID2D1Bitmap> lazy_1, int left, int top, int width, int height)
	{
		bitmap = lazy_1;
		rectF = new RawRectF(left, top, left + width, top + height);
		Opacity = 1f;
	}

	public void Draw(System.Drawing.RectangleF rectangle, float opacity = 1f)
	{
		Overlay.Instance.renderTarget.DrawBitmap(bitmap.Value, new RawRectF(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom), opacity, BitmapInterpolationMode.Linear, rectF);
	}

	public void Draw(float x, float y, float w, float h, float opacityMultiplier = 1f)
	{
		Overlay.Instance.renderTarget.DrawBitmap(bitmap.Value, new RawRectF(x, y, x + w, y + h), Opacity * opacityMultiplier, BitmapInterpolationMode.Linear, rectF);
	}
}
