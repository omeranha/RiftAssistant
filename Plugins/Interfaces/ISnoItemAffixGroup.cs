using System.Collections.Generic;

namespace Plugins;

public interface ISnoItemAffixGroup
{
	IEnumerable<ISnoItemAffix> Affixes { get; }

	uint Id { get; }

	void AddAffix(ISnoItemAffix affix);

	string ToString();
}
