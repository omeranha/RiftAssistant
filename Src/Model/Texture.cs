using System;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;

namespace RiftAssistant.Model;

public class Texture : ITransparent
{
	private readonly Lazy<Bitmap> bitmap;

	private readonly RawRectangleF? rectF;

	internal static readonly string string_0 = "BAB";

	public float Width => rectF.Value.Right - rectF.Value.Left - 1f;

	public float Height => rectF.Value.Bottom - rectF.Value.Top - 1f;

	public float Opacity { get; set; }

	public Texture(Lazy<Bitmap> lazy_1, int int_0, int int_1, int int_2, int int_3)
	{
		bitmap = lazy_1;
		rectF = new RawRectangleF(int_0, int_1, int_0 + int_2, int_1 + int_3);
		Opacity = 1f;
	}

	public void Draw(RectangleF rectangle, float opacity = 1f)
	{
		Overlay.Instance.renderTarget.DrawBitmap(bitmap.Value, rectangle, opacity, BitmapInterpolationMode.Linear, rectF);
	}

	public void Draw(float x, float y, float w, float h, float opacityMultiplier = 1f)
	{
		Overlay.Instance.renderTarget.DrawBitmap(bitmap.Value, new RawRectangleF(x, y, x + w, y + h), Opacity * opacityMultiplier, BitmapInterpolationMode.Linear, rectF);
	}
}
