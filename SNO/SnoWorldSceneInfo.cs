using System.Globalization;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly float float_2;

	[CompilerGenerated]
	private readonly float float_3;

	[CompilerGenerated]
	private readonly float float_4;

	[CompilerGenerated]
	private readonly float float_5;

	[CompilerGenerated]
	private readonly ISnoArea isnoArea_0;

	[CompilerGenerated]
	private readonly string string_0;

	public float PosX
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float PosY
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

	public float W
	{
		[CompilerGenerated]
		get
		{
			return float_4;
		}
	}

	public float H
	{
		[CompilerGenerated]
		get
		{
			return float_5;
		}
	}

	public ISnoArea SnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
	}

	public string CalculatedPosId
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	internal SnoWorldSceneInfo(float float_6, float float_7, float float_8, float float_9, ISnoArea isnoArea_1)
	{
		float_0 = float_6;
		float_1 = float_7;
		float_2 = float_8;
		float_3 = float_9;
		float_4 = MaxX - PosX;
		float_5 = MaxY - PosY;
		isnoArea_0 = isnoArea_1;
		if (isnoArea_1.SnoWorld.Sno == 332336)
		{
			float_0 = PosX - 2580f;
			float_1 = PosY - 2280f;
		}
		string_0 = PosX.ToString(CultureInfo.InvariantCulture) + PosY.ToString(CultureInfo.InvariantCulture);
	}
}
