using System;
using System.Drawing;
using System.Runtime.InteropServices;

public class Window
{
	public string WindowTitle = "Diablo III";

	public IntPtr Handle = IntPtr.Zero;

	public uint ProcessId;

	public WINDOWPLACEMENT WindowPlacement;

	public float WidescreenOffset { get; set; }

	public Point Offset { get; set; }

	public Size Size { get; set; }

	public float Aspect { get; set; }

	public bool IsForeground { get; set; }

	public float HeightUiRatio { get; set; }

	public int CursorX { get; set; }

	public int CursorY { get; set; }

	public static WorldCoordinate Center => CoreCollector.LocalPlayer.FloorCoordinate;

	public static Rectangle GroundRectangle => new(0, 0, GameWindowManager.Window.Size.Width, CoreCollector.D3Memory.IsUiHidden ? GameWindowManager.Window.Size.Height : Convert.ToInt32((double)CoreCollector.UiElements.class341_64.rectangleF_0.Y * 1.015));

	public Window()
	{
		WindowPlacement = default;
		WindowPlacement.length = Marshal.SizeOf(WindowPlacement);
	}

	public bool CursorInsideRect(float x, float y, float w, float h)
	{
		if ((float)CursorX >= x && (float)CursorX < x + w && (float)CursorY >= y) {
			return (float)CursorY < y + h;
		}
		return false;
	}

	public static ScreenCoordinate CreateScreenCoordinate(float x, float y)
	{
		return new ScreenCoordinate(x, y);
	}

	public static WorldCoordinate CreateWorldCoordinate(WorldCoordinate source)
	{
		return CreateWorldCoordinate(source.X, source.Y, source.Z);
	}

	public static WorldCoordinate CreateWorldCoordinate(float worldX, float worldY, float worldZ)
	{
		return new WorldCoordinate(worldX, worldY, worldZ);
	}

	public void WorldToScreenCoordinate(float worldX, float worldY, float worldZ, out float screenX, out float screenY)
	{
		float num = worldX - Center.X;
		float num2 = worldY - Center.Y;
		float num3 = worldZ - Center.Z;
		float num4 = -0.515f * num - 0.514f * num2 - 0.686f * num3 + 97.985f;
		if (num4 < 1f) {
			num4 = 1f;
		}
		float num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
		float num6 = (-1.54f * num - 1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
		num5 /= Aspect;
		screenX = (num5 + 1f) / 2f * (float)Size.Width;
		screenY = (1f - num6) / 2f * (float)Size.Height;
	}

	public ScreenCoordinate WorldToScreenCoordinate(float worldX, float worldY, float worldZ, bool raw = false, bool ultraPrecise = false)
	{
		ScreenCoordinate screenCoordinate = CreateScreenCoordinate(0f, 0f);
		SetScreenCoordinate(screenCoordinate, worldX, worldY, worldZ, raw, ultraPrecise);
		return screenCoordinate;
	}

	public void SetScreenCoordinate(ScreenCoordinate screenCoordinate, float worldX, float worldY, float worldZ, bool raw = false, bool ultraPrecise = false)
	{
		float num = worldX - Center.X;
		float num2 = worldY - Center.Y;
		float num3 = worldZ - Center.Z;
		float num4 = -0.515f * num - 0.514f * num2 - 0.686f * num3 + 97.985f;
		if (num4 < 1f) {
			num4 = 1f;
		}
		float num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
		float num6 = (-1.54f * num - 1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
		float num7 = (-0.515f * num - 0.514f * num2 - 0.686f * num3 + 97.002f) / num4;
		num5 /= Aspect;
		if (!raw) {
			float num8 = (ultraPrecise ? 0.995f : 0.98f);
			while (Math.Abs(num5) >= 1f || Math.Abs(num6) >= 1f || num7 <= 0f) {
				num *= num8;
				num2 *= num8;
				num3 *= num8;
				num4 = -0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.985f;
				if (num4 < 1f) {
					num4 = 1f;
				}
				num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
				num6 = (-1.54f * num + -1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
				num7 = (-0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.002f) / num4;
				num5 /= Aspect;
			}
		}
		screenCoordinate.X = (num5 + 1f) / 2f * (float)Size.Width;
		screenCoordinate.Y = (1f - num6) / 2f * (float)Size.Height;
	}

	public static bool CalculateMidPointByDistance(WorldCoordinate targetCoordinate, float targetDistance, WorldCoordinate midPoint)
	{
		float num = targetCoordinate.X - Center.X;
		float num2 = targetCoordinate.Y - Center.Y;
		float num3 = (float)Math.Sqrt(num * num + num2 * num2);
		if (num3 == targetDistance) {
			midPoint.Set(targetCoordinate);
			return false;
		}
		if (num3 > targetDistance) {
			midPoint.Set(Center.X + num * (targetDistance / num3), Center.Y + num2 * (targetDistance / num3), Center.Z);
			return true;
		}
		if (num3 < targetDistance) {
			midPoint.Set(Center.X + num * (targetDistance / num3), Center.Y + num2 * (targetDistance / num3), Center.Z);
		}
		return false;
	}

	public WorldCoordinate CalculateMidPointByRatio(WorldCoordinate targetCoordinate, float ratio)
	{
		float num = targetCoordinate.X - Center.X;
		float num2 = targetCoordinate.Y - Center.Y;
		float num3 = targetCoordinate.Z - Center.Z;
		float num4 = Math.Max(1f, -0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.985f);
		float num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
		float value = (-1.54f * num + -1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
		float num6 = (-0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.002f) / num4;
		num5 /= Aspect;
		while (Math.Abs(num5) >= ratio || Math.Abs(value) >= ratio || num6 <= 0f) {
			num *= 0.98f;
			num2 *= 0.98f;
			num3 *= 0.98f;
			num4 = Math.Max(1f, -0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.985f);
			num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
			value = (-1.54f * num + -1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
			num6 = (-0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.002f) / num4;
			num5 /= Aspect;
		}
		while (!(Math.Abs(num5) >= ratio) && !(Math.Abs(value) >= ratio)) {
			num *= 1.02f;
			num2 *= 1.02f;
			num3 *= 1.02f;
			num4 = Math.Max(1f, -0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.985f);
			num5 = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4;
			value = (-1.54f * num + -1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
			num5 /= Aspect;
		}
		return CreateWorldCoordinate(Center.X + num, Center.Y + num2, Center.Z + num3);
	}
}
