using SharpDX.DirectWrite;


namespace Plugins;

public interface IFont : ITransparent
{
	int MaxHeight { get; set; }

	int MaxWidth { get; set; }

	bool WordWrap { get; set; }

	bool HeavyShadow { get; set; }

	void DrawText(string text, ScreenCoordinate coordinate, bool enableLayoutCache = true);

	void DrawText(string text, float x, float y, bool enableLayoutCache = true);

	TextLayout GetTextLayout(string text);

	TextLayout GetTextLayoutManualDispose(string text);

	void DrawText(TextLayout textLayout, float x, float y);

	void DrawText(TextLayout textLayout, ScreenCoordinate coordinate);

	void SetMaxSize(int maxWidth, int maxHeight);

	void SetShadowBrush(int a, int r, int g, int b, bool heavy);
}
