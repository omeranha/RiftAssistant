using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoScene
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private SceneHint SceneHint_0;

	public readonly int NavCellBinPosition;

	public readonly int NavCellSavedCount;

	public readonly int NavSquareW;

	public readonly int NavSquareH;

	public readonly int NavSquareSavedCount;

	public readonly int NavSquareBinPosition;

	public NavCell[] NavCells;

	public float[,] NavSquares;

	private static Stream stream_0;

	private static Stream stream_1;

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public SceneHint Hint
	{
		[CompilerGenerated]
		get
		{
			return SceneHint_0;
		}
		[CompilerGenerated]
		set
		{
			SceneHint_0 = value;
		}
	}

	private static Stream Stream_0 => stream_0 ?? (stream_0 = new FileStream(Path.Combine(Program.AppDir, "data", "scene_cell.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	private static Stream Stream_1 => stream_1 ?? (stream_1 = new FileStream(Path.Combine(Program.AppDir, "data", "scene_square.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	internal SnoScene(uint uint_1, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, string string_1)
	{
		uint_0 = uint_1;
		string_0 = string_1;
		NavCellBinPosition = int_0;
		NavCellSavedCount = int_1;
		NavSquareW = int_2;
		NavSquareH = int_3;
		NavSquareSavedCount = int_4;
		NavSquareBinPosition = int_5;
	}

	public void LoadNavCells()
	{
		if (NavCells == null)
		{
			NavCells = new NavCell[NavCellSavedCount];
			Stream_0.Position = NavCellBinPosition;
			DataReader @class = new DataReader(Stream_0);
			for (int i = 0; i < NavCellSavedCount; i++)
			{
				float float_ = @class.method_14();
				float float_2 = @class.method_14();
				@class.method_14();
				float float_3 = @class.method_14();
				float float_4 = @class.method_14();
				@class.method_14();
				@class.method_8();
				NavCells[i] = new NavCell(float_, float_2, float_3, float_4);
			}
		}
	}

	public void LoadNavSquares()
	{
		if (NavSquares != null)
		{
			return;
		}
		NavSquares = new float[NavSquareW, NavSquareH];
		Stream_1.Position = NavSquareBinPosition;
		DataReader @class = new DataReader(Stream_1);
		int num = 0;
		for (int i = 0; i < NavSquareSavedCount; i++)
		{
			int num2 = @class.method_11();
			byte num3 = @class.method_6();
			float num4 = float.NaN;
			if (num3 == 1)
			{
				num4 = @class.method_14();
			}
			for (int j = 0; j < num2; j++)
			{
				int num5 = num % NavSquareW;
				int num6 = num / NavSquareW;
				NavSquares[num5, num6] = num4;
				num++;
			}
		}
	}

	public override string ToString()
	{
		return Code;
	}
}
