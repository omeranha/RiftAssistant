#nullable enable annotations
#nullable disable warnings
using System.Globalization;

namespace RiftAssistant.Model;

public class ItemStat
{
	public string Id { get; set; }

	public AcdAttribute? Attribute { get; set; }

	public uint Modifier { get; set; }

	public AttributeProcessor? Processor { get; set; }

	public double DoubleValue { get; set; }

	public int? IntegerValue { get; set; } = null;

	public string StringValue { get; set; }

	public ItemStat(AcdAttribute attribute, uint modifier, double doubleValue)
	{
		Processor = null;
		Attribute = attribute;
		Modifier = modifier;
		DoubleValue = doubleValue;
		Id = Attribute.Code + "#" + Modifier.ToString("D", CultureInfo.InvariantCulture);
	}

	public ItemStat(AcdAttribute attribute, uint modifier, double doubleValue, int integerValue)
	{
		Processor = null;
		Attribute = attribute;
		Modifier = modifier;
		DoubleValue = doubleValue;
		IntegerValue = integerValue;
		Id = Attribute.Code + "#" + Modifier.ToString("D", CultureInfo.InvariantCulture);
	}

	public ItemStat(string code, double doubleValue)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(code);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = doubleValue;
	}

	public ItemStat(string code, double level, int level2)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(code);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = level;
		IntegerValue = level2;
	}

	public ItemStat(string code, string nameLocalized)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(code);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = 0.0;
		StringValue = nameLocalized;
		IntegerValue = null;
	}

	public ItemStat(AttributeProcessor processor, double doubleValue, int integerValue)
	{
		Processor = processor;
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = doubleValue;
		IntegerValue = integerValue;
	}
}
