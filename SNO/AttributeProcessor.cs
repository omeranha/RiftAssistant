using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class AttributeProcessor : IAttributeProcessor
{
	[CompilerGenerated]
	private readonly byte byte_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly IAttribute iattribute_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly double? nullable_0;

	[CompilerGenerated]
	private readonly int int_0;

	public byte CompactId
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
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

	public IAttribute Attribute
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

	public double? Multiplier
	{
		[CompilerGenerated]
		get
		{
			return nullable_0;
		}
	}

	public int RoundDecimals
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	internal AttributeProcessor(byte byte_1, string string_1, IAttribute iattribute_1, uint uint_1, double? nullable_1, int int_1)
	{
		byte_0 = byte_1;
		string_0 = string_1;
		iattribute_0 = iattribute_1;
		uint_0 = uint_1;
		nullable_0 = nullable_1;
		int_0 = int_1;
	}

	public double ProcessDouble(double dv)
	{
		if (Multiplier.HasValue)
		{
			dv *= Multiplier.Value;
		}
		if (Attribute.ValueType == AttributeValueType._float || Multiplier.HasValue)
		{
			switch (RoundDecimals)
			{
			case -2:
				dv = Math.Floor(dv);
				break;
			case -3:
				dv = Math.Ceiling(dv);
				break;
			default:
				dv = Math.Round(dv, RoundDecimals, MidpointRounding.AwayFromZero);
				break;
			case -1:
				break;
			}
		}
		if (Code == "bound_to_account" && dv != 0.0)
		{
			dv = 1.0;
		}
		if (Code == "vendor_bought" && dv != 0.0)
		{
			dv = 1.0;
		}
		return dv;
	}

	double IAttributeProcessor.ProcessDouble(double dv)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ProcessDouble
		return this.ProcessDouble(dv);
	}

	public int ProcessInt(int iv)
	{
		if (Attribute.ValueType == AttributeValueType._float)
		{
			throw new NotImplementedException();
		}
		if (Multiplier.HasValue)
		{
			iv = Convert.ToInt32((double)iv * Multiplier.Value);
		}
		if (Code == "bound_to_account" && iv != 0)
		{
			iv = 1;
		}
		if (Code == "vendor_bought" && iv != 0)
		{
			iv = 1;
		}
		return iv;
	}

	int IAttributeProcessor.ProcessInt(int iv)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ProcessInt
		return this.ProcessInt(iv);
	}
}
