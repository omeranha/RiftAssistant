using System.Globalization;
using Plugins;
using SNO;

public class ItemStat
{
	public string Id { get; set; }

	public AcdAttribute Attribute { get; set; }

	public uint Modifier { get; set; }

	public AttributeProcessor Processor { get; set; }

	public double DoubleValue { get; set; }

	public int? IntegerValue { get; set; } = null;

	public string StringValue { get; set; }

	public ItemStat(AcdAttribute iattribute_1, uint uint_1, double double_1)
	{
		Processor = null;
		Attribute = iattribute_1;
		Modifier = uint_1;
		DoubleValue = double_1;
		Id = Attribute.Code + "#" + Modifier.ToString("D", CultureInfo.InvariantCulture);
	}

	public ItemStat(AcdAttribute iattribute_1, uint uint_1, double double_1, int int_0)
	{
		Processor = null;
		Attribute = iattribute_1;
		Modifier = uint_1;
		DoubleValue = double_1;
		IntegerValue = int_0;
		Id = Attribute.Code + "#" + Modifier.ToString("D", CultureInfo.InvariantCulture);
	}

	public ItemStat(string string_2, double double_1)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(string_2);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = double_1;
	}

	public ItemStat(string string_2, double double_1, int int_0)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(string_2);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = double_1;
		IntegerValue = int_0;
	}

	public ItemStat(string string_2, string string_3)
	{
		Processor = SnoData.Attributes.GetAttributeProcessor(string_2);
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = 0.0;
		StringValue = string_3;
		IntegerValue = null;
	}

	public ItemStat(AttributeProcessor iattributeProcessor_1, double double_1, int int_0)
	{
		Processor = iattributeProcessor_1;
		Id = Processor.Code;
		Attribute = Processor.Attribute;
		Modifier = Processor.Modifier;
		DoubleValue = double_1;
		IntegerValue = int_0;
	}
}
