using System.Collections.Generic;

namespace Plugins;

public interface ISnoWorld
{
	uint Sno { get; }

	List<ISnoArea> SnoAreas { get; }
}
