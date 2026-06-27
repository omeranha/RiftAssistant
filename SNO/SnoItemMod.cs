using System.Globalization;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoItemMod
{
	[CompilerGenerated]
	private readonly AcdAttribute iattribute_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly SnoItemAffix isnoItemAffix_0;

	public AcdAttribute Attribute
	{
		[CompilerGenerated]
		get
		{
			return iattribute_0;
		}
	}

	public uint Modifier
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public float Min
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float Max
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
	}

	public SnoItemAffix Affix
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffix_0;
		}
	}

	internal SnoItemMod(AcdAttribute iattribute_1, uint uint_1, float float_2, float float_3, SnoItemAffix isnoItemAffix_1)
	{
		iattribute_0 = iattribute_1;
		uint_0 = uint_1;
		float_0 = float_2;
		float_1 = float_3;
		isnoItemAffix_0 = isnoItemAffix_1;
	}

	public override string ToString()
	{
		return Attribute.Code + " / " + Modifier + " = [" + Min.ToString("F", CultureInfo.InvariantCulture) + "] - [" + Max.ToString("F", CultureInfo.InvariantCulture) + "]";
	}
}
