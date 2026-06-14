namespace Plugins;

public interface IItemStat
{
	string Id { get; }

	IAttribute Attribute { get; }

	uint Modifier { get; }

	IAttributeProcessor Processor { get; }

	double DoubleValue { get; }

	int? IntegerValue { get; }

	string StringValue { get; }
}
