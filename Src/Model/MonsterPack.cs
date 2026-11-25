using System.Collections.Generic;
using System.Diagnostics;

namespace RiftAssistant.Model;

public class MonsterPack
{

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool IsFullChampionPack { get; set; }

	public SnoMonster LeadSnoMonster { get; set; }

	public IEnumerable<SnoMonsterAffix> AffixSnoList => AffixSnoList2;

	public IEnumerable<Monster> MonstersAlive => MonstersAlive2.Values;

	public IEnumerable<Monster> MonstersKilled => MonstersKilled2.Values;

	public IEnumerable<Monster> MonstersUnknown => MonstersUnknown2.Values;

	public SnoMonster MinionSnoMonster { get; set; }

	public string String_0 { get; set; }

	public string String_1 { get; set; }

	public List<SnoMonsterAffix> AffixSnoList2 { get; set; }

	public Dictionary<double, Monster> MonstersAlive2 { get; } = new Dictionary<double, Monster>();

	public Dictionary<double, Monster> MonstersKilled2 { get; } = new Dictionary<double, Monster>();

	public Dictionary<double, Monster> MonstersUnknown2 { get; } = new Dictionary<double, Monster>();
}
