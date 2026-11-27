using System;

namespace RiftAssistant.Rendering;

internal readonly record struct MenuColor(int R, int G, int B)
{
	public static readonly MenuColor White = new(255, 255, 255);
	public static readonly MenuColor Black = new(0, 0, 0);
	public static readonly MenuColor Gray = new(128, 128, 128);
	public static readonly MenuColor Muted = new(165, 165, 165);
	public static readonly MenuColor Dark = new(40, 40, 40);
	public static readonly MenuColor Positive = new(90, 210, 100);
	public static readonly MenuColor Negative = new(225, 85, 85);
	public static readonly MenuColor Blue = new(120, 170, 255);
	public static readonly MenuColor Gold = new(255, 200, 90);
	public static readonly MenuColor Purple = new(190, 140, 255);
	public static readonly MenuColor Teal = new(90, 210, 200);
	public static readonly MenuColor Orange = new(255, 150, 70);

	public int Key => (R << 16) | (G << 8) | B;

	public MenuColor Scale(float factor)
	{
		return new MenuColor(Math.Clamp((int)(R * factor), 0, 255), Math.Clamp((int)(G * factor), 0, 255), Math.Clamp((int)(B * factor), 0, 255));
	}
}
