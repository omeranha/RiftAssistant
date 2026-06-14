using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class AcdAttribute : IAttribute
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly AttributeValueType attributeValueType_0;

	[CompilerGenerated]
	private bool bool_0 = true;

	private readonly Dictionary<uint, string> dictionary_0;

	private readonly List<AttributeProcessor> list_0 = new List<AttributeProcessor>();

	private readonly Dictionary<int, int> dictionary_1 = new Dictionary<int, int>();

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public uint Index
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public AttributeValueType ValueType
	{
		[CompilerGenerated]
		get
		{
			return attributeValueType_0;
		}
	}

	public IEnumerable<IAttributeProcessor> Processors => list_0;

	public bool OrderIndexPrimary
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		internal set
		{
			bool_0 = value;
		}
	}

	internal AcdAttribute(string string_1, uint uint_1, AttributeValueType attributeValueType_1, Dictionary<uint, string> dictionary_2)
	{
		string_0 = string_1;
		uint_0 = uint_1;
		attributeValueType_0 = attributeValueType_1;
		dictionary_0 = dictionary_2;
	}

	public uint GetId(uint modifier)
	{
		return Index | (modifier << 12);
	}

	uint IAttribute.GetId(uint modifier)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetId
		return this.GetId(modifier);
	}

	public string GetDescription(uint modifier)
	{
		dictionary_0.TryGetValue(modifier, out var value);
		if (value == null && dictionary_0.Count > 0)
		{
			dictionary_0.TryGetValue(uint.MaxValue, out value);
		}
		return value;
	}

	string IAttribute.GetDescription(uint modifier)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDescription
		return this.GetDescription(modifier);
	}

	public void AddProcessor(AttributeProcessor processor)
	{
		list_0.Add(processor);
	}

	public int GetModLowestOrderIndex(int mod)
	{
		dictionary_1.TryGetValue(mod, out var value);
		return value;
	}

	int IAttribute.GetModLowestOrderIndex(int mod)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetModLowestOrderIndex
		return this.GetModLowestOrderIndex(mod);
	}

	public void SetModLowestOrderIndex(int mod, int value)
	{
		dictionary_1[mod] = value;
	}
}
