using System.Collections.Generic;
using System.Diagnostics;

namespace Plugins;

public interface IMonsterPack
{
	Stopwatch LastActive { get; }

	bool IsFullChampionPack { get; }

	ISnoMonster LeadSnoMonster { get; }

	ISnoMonster MinionSnoMonster { get; }

	IEnumerable<ISnoMonsterAffix> AffixSnoList { get; }

	IEnumerable<IMonster> MonstersAlive { get; }

	IEnumerable<IMonster> MonstersKilled { get; }

	IEnumerable<IMonster> MonstersUnknown { get; }
}
