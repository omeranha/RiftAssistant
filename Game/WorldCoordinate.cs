using System;
using System.Globalization;

public class WorldCoordinate(float x, float y, float z)
{
	public float X { get; private set; } = x;

	public float Y { get; private set; } = y;

	public float Z { get; private set; } = z;

	public bool IsValid
	{
		get {
			if (X == 0f && Y == 0f) {
				return Z != 0f;
			}
			return true;
		}
	}

	public float XYDistanceTo(WorldCoordinate otherCoordinate)
	{
		float x = otherCoordinate.X - X;
		float y = otherCoordinate.Y - Y;
		return (float)Math.Sqrt(x * x + y * y);
	}

	public float XYDistanceTo(float x, float y)
	{
		float distX = x - X;
		float distY = y - Y;
		return (float)Math.Sqrt(distX * distX + distY * distY);
	}

	public float XYZDistanceTo(float x, float y, float z)
	{
		float distX = x - X;
		float distY = y - Y;
		float distZ = z - Z;
		return (float)Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
	}

	public float XYZDistanceTo(WorldCoordinate otherWorldCoordinate)
	{
		float distX = otherWorldCoordinate.X - X;
		float distY = otherWorldCoordinate.Y - Y;
		float distZ = otherWorldCoordinate.Z - Z;
		return (float)Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
	}

	public override string ToString()
	{
		return X.ToString("F3", CultureInfo.InvariantCulture) + ", " + Y.ToString("F3", CultureInfo.InvariantCulture) + ", " + Z.ToString("F1", CultureInfo.InvariantCulture);
	}

	public string ToStringCompact()
	{
		return X.ToString("F0", CultureInfo.InvariantCulture) + "," + Y.ToString("F0", CultureInfo.InvariantCulture) + "," + Z.ToString("F0", CultureInfo.InvariantCulture);
	}

	public string ToStringCompactPrecise()
	{
		return X.ToString("F1", CultureInfo.InvariantCulture) + "," + Y.ToString("F1", CultureInfo.InvariantCulture) + "," + Z.ToString("F1", CultureInfo.InvariantCulture);
	}

	public void Set(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public void Set(WorldCoordinate otherCoordinate)
	{
		X = otherCoordinate.X;
		Y = otherCoordinate.Y;
		Z = otherCoordinate.Z;
	}

	public void Add(WorldCoordinate otherCoordinate)
	{
		X += otherCoordinate.X;
		Y += otherCoordinate.Y;
		Z += otherCoordinate.Z;
	}

	public WorldCoordinate Offset(float x, float y, float z)
	{
		return Window.CreateWorldCoordinate(X + x, Y + y, Z + z);
	}

	public bool Equals(WorldCoordinate otherWorldCoordinate)
	{
		if (otherWorldCoordinate.X == X && otherWorldCoordinate.Y == Y) {
			return otherWorldCoordinate.Z == Z;
		}
		return false;
	}

	public float ZDiffTo(WorldCoordinate coordinate)
	{
		return Math.Abs(coordinate.Z - Z);
	}

	public ScreenCoordinate ToScreenCoordinate(bool raw = false, bool precise = false)
	{
		return GameWindowManager.Window.WorldToScreenCoordinate(X, Y, Z, raw, precise);
	}

	public void SetScreenCoordinate(ScreenCoordinate coordinate, bool raw = false, bool precise = false)
	{
		GameWindowManager.Window.SetScreenCoordinate(coordinate, X, Y, Z, raw, precise);
	}

	public bool IsOnScreen(double r = 1.0)
	{
		var window = GameWindowManager.Window;
		float x = X - Window.Center.X;
		float y = Y - Window.Center.Y;
		float z = Z - Window.Center.Z;
		float num4 = -0.515f * x + -0.514f * y + -0.686f * z + 97.985f;
		if (num4 < 1f) {
			num4 = 1f;
		}
		float value = (-1.682f * x + 1.683f * y + 0.007045f) / num4 / window.Aspect;
		float value2 = (-1.54f * x + -1.539f * y + 2.307f * z + 6.161f) / num4;
		float num5 = (-0.515f * x + -0.514f * y + -0.686f * z + 97.002f) / num4;
		if ((double)Math.Abs(value) < r && (double)Math.Abs(value2) < r) {
			return num5 > 0f;
		}
		return false;
	}
}
