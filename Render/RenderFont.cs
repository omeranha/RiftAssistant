using System;
using System.Collections.Generic;
using System.Drawing;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using Plugins;
using work;

public class RenderFont : ITransparent, IFont, IDisposable
{
	internal class TextLayoutCacheEntry(RenderFont font, string text)
	{
		public readonly RenderFont Font = font;
		public TextLayout Layout = new(Overlay.Instance.factory_1, text, font.GetTextFormat(), font.MaxWidth, font.MaxHeight);
		public long LastAccessTicks;
	}

	private readonly Lazy<SolidColorBrush> brush;
	private Lazy<SolidColorBrush> shadowBrush;

	public TextFormat TextFormat { get; private set; }

	public float baseFontSize;

	private bool needsLayoutUpdate;
	public Alignment Alignment { get; private set; }

	internal static readonly Dictionary<string, List<TextLayoutCacheEntry>> TextCache = [];

	public float Opacity
	{
		get => brush.Value.Opacity;
		set {
			brush.Value.Opacity = value;
			shadowBrush?.Value.Opacity = value;
		}
	}

	public bool HeavyShadow { get; set; }

	public int MaxWidth
	{
		get;
		set {
			if (field != value) {
				field = value;
				needsLayoutUpdate = true;
			}
		}
	} = 10000;

	public int MaxHeight
	{
		get;
		set {
			if (field != value) {
				field = value;
				needsLayoutUpdate = true;
			}
		}
	} = 100;

	public bool WordWrap
	{
		get;
		set {
			if (field != value) {
				field = value;
				needsLayoutUpdate = true;
			}
		}
	}

	public RenderFont(int alpha, int red, int green, int blue, string fontFamily, bool isBold, bool isItalic, float fontSize, Alignment alignment, bool wordWrap, bool enableShadow)
	{
		baseFontSize = fontSize;
		float scaledSize = GetScaledFontSize();
		Alignment = alignment;
		RecreateTextFormat(fontFamily, isBold ? FontWeight.Bold : FontWeight.Normal, isItalic ? SharpDX.DirectWrite.FontStyle.Italic : SharpDX.DirectWrite.FontStyle.Normal, scaledSize, wordWrap ? WordWrapping.Wrap : WordWrapping.NoWrap);

		var dxColor = new Color4(red / 255f, green / 255f, blue / 255f, alpha / 255f);
		brush = new Lazy<SolidColorBrush>(() => new SolidColorBrush(Overlay.Instance.renderTarget, dxColor));
		if (enableShadow) {
			shadowBrush = new Lazy<SolidColorBrush>(() => new SolidColorBrush(Overlay.Instance.renderTarget, new Color4(0f, 0f, 0f, 32f / 51f)));
		}
	}

	public void Dispose()
	{
		if (brush is { IsValueCreated: true }) {
			brush.Value.Dispose();
		}
		if (shadowBrush is { IsValueCreated: true }) {
			shadowBrush.Value.Dispose();
		}
		TextFormat?.Dispose();
		GC.SuppressFinalize(this);
	}

	public void SetShadowBrush(int alpha, int red, int green, int blue, bool heavy = false)
	{
		shadowBrush = new Lazy<SolidColorBrush>(() => new SolidColorBrush(Overlay.Instance.renderTarget, new Color4(red / 255f, green / 255f, blue / 255f, alpha / 255f)));
		HeavyShadow = heavy;
	}

	private float GetScaledFontSize()
	{
		float num = baseFontSize >= 0f ? baseFontSize / 600f * GameWindowManager.Window.Size.Height : -baseFontSize;
		return Math.Max(num, 6f);
	}

	private TextFormat GetTextFormat()
	{
		float scaledSize = GetScaledFontSize();
		if (TextFormat == null || TextFormat.FontSize != scaledSize) {
			var familyName = TextFormat?.FontFamilyName ?? "Arial";
			var weight = TextFormat?.FontWeight ?? FontWeight.Normal;
			var style = TextFormat?.FontStyle ?? SharpDX.DirectWrite.FontStyle.Normal;
			var wrapping = TextFormat?.WordWrapping ?? (WordWrap ? WordWrapping.Wrap : WordWrapping.NoWrap);

			RecreateTextFormat(familyName, weight, style, scaledSize, wrapping);
		}
		return TextFormat;
	}

	private void RecreateTextFormat(string familyName, FontWeight weight, SharpDX.DirectWrite.FontStyle style, float fontSize, WordWrapping wrapping)
	{
		TextFormat?.Dispose();
		TextFormat = new TextFormat(Overlay.Instance.factory_1, familyName, weight, style, fontSize);
		if (TextFormat.WordWrapping != wrapping) {
			TextFormat.WordWrapping = wrapping;
		}
		needsLayoutUpdate = true;
	}

	public void SetMaxSize(int maxWidth, int maxHeight)
	{
		if (maxWidth != MaxWidth || maxHeight != MaxHeight) {
			MaxWidth = maxWidth;
			MaxHeight = maxHeight;
			needsLayoutUpdate = true;
		}
	}

	public TextLayout GetTextLayout(string text)
	{
		return RetrieveTextLayout(text, true);
	}

	public TextLayout GetTextLayoutManualDispose(string text)
	{
		return RetrieveTextLayout(text, false);
	}

	public TextLayout RetrieveTextLayout(string text, bool useCache = true)
	{
		WordWrapping expectedWrapping = WordWrap ? WordWrapping.Wrap : WordWrapping.NoWrap;

		if (useCache) {
			if (TextCache.TryGetValue(text, out var list) && list != null) {
				for (int i = 0; i < list.Count; i++) {
					if (list[i].Font == this) {
						if (needsLayoutUpdate) {
							list[i].Layout.Dispose();
							list.RemoveAt(i);
							break;
						}
						list[i].LastAccessTicks = CoreCollector.CurrentRealTimeTicks;
						return list[i].Layout;
					}
				}
			} else {
				list = new List<TextLayoutCacheEntry>();
				TextCache[text] = list;
			}

			needsLayoutUpdate = false;

			var entry = new TextLayoutCacheEntry(this, text);
			list.Add(entry);
			entry.LastAccessTicks = CoreCollector.CurrentRealTimeTicks;

			if (entry.Layout.WordWrapping != expectedWrapping) {
				entry.Layout.WordWrapping = expectedWrapping;
			}
			return entry.Layout;
		}

		var textLayout = new TextLayout(Overlay.Instance.factory_1, text, GetTextFormat(), MaxWidth, MaxHeight);
		if (textLayout.WordWrapping != expectedWrapping) {
			textLayout.WordWrapping = expectedWrapping;
		}
		return textLayout;
	}

	public void DrawText(string text, IScreenCoordinate coordinate, bool enableLayoutCache = true)
	{
		DrawText(text, coordinate.X, coordinate.Y, enableLayoutCache);
	}

	public void DrawText(string text, float x, float y, bool enableLayoutCache = true)
	{
		if (enableLayoutCache) {
			TextLayout textLayout = GetTextLayout(text);
			if (shadowBrush != null) {
				if (HeavyShadow) {
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y - 1f), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y + 1f), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y - 1f), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y - 1f), textLayout, shadowBrush.Value);
					Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y + 1f), textLayout, shadowBrush.Value);
				}
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y + 1f), textLayout, shadowBrush.Value);
			}
			Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y), textLayout, brush.Value);
			return;
		}

		TextFormat textFormat = GetTextFormat();
		if (shadowBrush != null) {
			if (HeavyShadow) {
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x - 1f, y, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x + 1f, y, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x, y - 1f, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x, y + 1f, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x - 1f, y - 1f, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x + 1f, y - 1f, 2000f, 50f), shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x - 1f, y + 1f, 2000f, 50f), shadowBrush.Value);
			}
			Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x + 1f, y + 1f, 2000f, 50f), shadowBrush.Value);
		}
		Overlay.Instance.renderTarget.DrawText(text, textFormat, new SharpDX.RectangleF(x, y, 2000f, 50f), brush.Value);
	}

	public void DrawText(TextLayout textLayout, IScreenCoordinate coordinate)
	{
		DrawText(textLayout, coordinate.X, coordinate.Y);
	}

	public void DrawText(TextLayout textLayout, float x, float y)
	{
		if (shadowBrush != null) {
			if (HeavyShadow) {
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y - 1f), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y + 1f), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y - 1f), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y - 1f), textLayout, shadowBrush.Value);
				Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x - 1f, y + 1f), textLayout, shadowBrush.Value);
			}
			Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x + 1f, y + 1f), textLayout, shadowBrush.Value);
		}
		Overlay.Instance.renderTarget.DrawTextLayout(new Vector2(x, y), textLayout, brush.Value);
	}

	internal static void CleanupCache(bool forceClearAll)
	{
		if (forceClearAll) {
			foreach (var kvp in TextCache) {
				foreach (var entry in kvp.Value) {
					entry.Layout.Dispose();
				}
			}
			TextCache.Clear();
			return;
		}

		long currentRealTimeTicks = CoreCollector.CurrentRealTimeTicks;
		var keysToRemove = new List<string>();

		foreach (var kvp in TextCache) {
			int oldEntryCount = 0;
			foreach (var entry in kvp.Value) {
				// 200,000,000 ticks = 20 seconds
				if (currentRealTimeTicks - entry.LastAccessTicks > 200000000) {
					oldEntryCount++;
				}
			}

			if (oldEntryCount > 0 && (oldEntryCount == kvp.Value.Count || oldEntryCount >= kvp.Value.Count / 2)) {
				foreach (var entry in kvp.Value) {
					entry.Layout.Dispose();
				}
				keysToRemove.Add(kvp.Key);
			}
		}

		foreach (var key in keysToRemove) {
			TextCache.Remove(key);
		}
	}
}
