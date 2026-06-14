using System.Collections.Generic;

namespace Plugins;

public interface IAttribute
{
	string Code { get; }

	uint Index { get; }

	AttributeValueType ValueType { get; }

	IEnumerable<IAttributeProcessor> Processors { get; }

	bool OrderIndexPrimary { get; }

	uint GetId(uint modifier);

	string GetDescription(uint modifier);

	int GetModLowestOrderIndex(int mod);
}
