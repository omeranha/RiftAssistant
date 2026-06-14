using System.Runtime.CompilerServices;

namespace SNO;

public sealed class NavCell
{
	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly float float_2;

	[CompilerGenerated]
	private readonly float float_3;

	public float MinX
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float MinY
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
	}

	public float MaxX
	{
		[CompilerGenerated]
		get
		{
			return float_2;
		}
	}

	public float MaxY
	{
		[CompilerGenerated]
		get
		{
			return float_3;
		}
	}

	internal NavCell(float float_4, float float_5, float float_6, float float_7)
	{
		float_0 = float_4;
		float_1 = float_5;
		float_2 = float_6;
		float_3 = float_7;
	}
}
