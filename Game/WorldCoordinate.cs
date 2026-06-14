using System;
using System.Diagnostics;
using System.Globalization;
using Plugins;

namespace work;

internal class WorldCoordinate : IWorldCoordinate
{
	public IWindow Window => GameWindowManager.Window;

	public float X { get; private set; }

	public float Y { get; private set; }

	public float Z { get; private set; }

	public bool IsValid
	{
		get
		{
			if (X == 0f && Y == 0f)
			{
				return Z != 0f;
			}
			return true;
		}
	}

	public WorldCoordinate(float float_3, float float_4, float float_5)
	{
		X = float_3;
		Y = float_4;
		Z = float_5;
	}

	public float XYDistanceTo(IWorldCoordinate otherCoordinate)
	{
		float num = otherCoordinate.X - X;
		float num2 = otherCoordinate.Y - Y;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public float XYDistanceTo(float x, float y)
	{
		float num = x - X;
		float num2 = y - Y;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public float XYZDistanceTo(float x, float y, float z)
	{
		float num = x - X;
		float num2 = y - Y;
		float num3 = z - Z;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	public float XYZDistanceTo(IWorldCoordinate otherWorldCoordinate)
	{
		float num = otherWorldCoordinate.X - X;
		float num2 = otherWorldCoordinate.Y - Y;
		float num3 = otherWorldCoordinate.Z - Z;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
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

	public void Set(IWorldCoordinate otherCoordinate)
	{
		X = otherCoordinate.X;
		Y = otherCoordinate.Y;
		Z = otherCoordinate.Z;
	}

	public void Add(IWorldCoordinate otherCoordinate)
	{
		X += otherCoordinate.X;
		Y += otherCoordinate.Y;
		Z += otherCoordinate.Z;
	}

	public IWorldCoordinate Offset(float x, float y, float z)
	{
		return Window.CreateWorldCoordinate(X + x, Y + y, Z + z);
	}

	public bool Equals(IWorldCoordinate otherWorldCoordinate)
	{
		if (otherWorldCoordinate.X == X && otherWorldCoordinate.Y == Y)
		{
			return otherWorldCoordinate.Z == Z;
		}
		return false;
	}

	public float ZDiffTo(IWorldCoordinate wc)
	{
		return Math.Abs(wc.Z - Z);
	}

	public IScreenCoordinate ToScreenCoordinate(bool raw = false, bool precise = false)
	{
		return Window.WorldToScreenCoordinate(X, Y, Z, raw, precise);
	}

	public void SetScreenCoordinate(IScreenCoordinate sc, bool raw = false, bool precise = false)
	{
		Window.SetScreenCoordinate(sc, X, Y, Z, raw, precise);
	}

	public bool IsOnScreen(double r = 1.0)
	{
		float num = X - Window.Center.X;
		float num2 = Y - Window.Center.Y;
		float num3 = Z - Window.Center.Z;
		float num4 = -0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.985f;
		if (num4 < 1f)
		{
			num4 = 1f;
		}
		float value = (-1.682f * num + 1.683f * num2 + 0.007045f) / num4 / Window.Aspect;
		float value2 = (-1.54f * num + -1.539f * num2 + 2.307f * num3 + 6.161f) / num4;
		float num5 = (-0.515f * num + -0.514f * num2 + -0.686f * num3 + 97.002f) / num4;
		if ((double)Math.Abs(value) < r && (double)Math.Abs(value2) < r)
		{
			return num5 > 0f;
		}
		return false;
	}
}
