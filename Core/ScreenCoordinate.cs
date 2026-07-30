using System;

public class ScreenCoordinate(float float_2, float float_3)
{
	public float X { get; set; } = float_2;

	public float Y { get; set; } = float_3;

	public void Set(float x, float y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		return X.ToString("F0") + ":" + Y.ToString("F0");
	}

	public ScreenCoordinate Offset(float ox, float oy)
	{
		return Window.CreateScreenCoordinate(X + ox, Y + oy);
	}

	public float DistanceToCursor()
	{
		var window = GameWindowManager.Window;
		float num = (float)window.CursorX - X;
		float num2 = (float)window.CursorY - Y;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public WorldCoordinate ToWorldCoordinate()
	{
		var window = GameWindowManager.Window;
		double num = (X * 2f / (float)window.Size.Width - 1f) * window.Aspect;
		double num2 = 1f - Y * 2f / (float)window.Size.Height;
		double num3 = (29526432200.0 * num + 32982475226.0 * num2 - 2075961051.0) / (200.0 * (1025.0 * num + 1731293.0 * num2 - 5180418.0));
		double num4 = (5908959400.0 * num - 6592285673.0 * num2 + 414078108.0) / (-41000.0 * num - 69251720.0 * num2 + 207216720.0);
		return Window.CreateWorldCoordinate(Window.Center.X + (float)num3, Window.Center.Y + (float)num4, Window.Center.Z);
	}
}
