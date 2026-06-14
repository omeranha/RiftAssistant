using SharpDX;

namespace Plugins;

public interface ITexture : ITransparent
{
	float Height { get; }

	float Width { get; }

	void Draw(RectangleF rectangle, float opacity = 1f);

	void Draw(float x, float y, float w, float h, float opacityMultiplier = 1f);
}
