using System.Drawing;
using System.Text;

namespace Plugins;

public interface IUiElement
{
	string Path { get; }

	bool Visible { get; }

	RectangleF Rectangle { get; }

	int AnimState { get; }

	uint TextureSno { get; }

	float MinimapOffsetX { get; }

	float MinimapOffsetY { get; }

	uint LegendaryGemAcdId { get; }

	uint AcdId { get; }

	IUiElement ReplacementWhenNotVisible { get; }

	bool CoordinateInsideRectangle(int x, int y);

	void Refresh();

	string ReadText(Encoding encoding, bool removeColors);
}
