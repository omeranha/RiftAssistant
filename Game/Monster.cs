using System.Collections.Generic;
using Plugins;
using SNO;

public class Monster(uint uint_7, uint uint_8, SnoActor SnoActor_1, SnoMonster SnoMonster_1) : Actor(uint_7, uint_8, SnoActor_1)
{
	public SnoMonster SnoMonster { get; set; } = SnoMonster_1;

	public uint UInt32_0 => SnoMonster?.Sno ?? 0;

	public MonsterPack Pack { get; set; }

	public double MaxHealth { get; set; }

	public bool IsElite { get; set; }

	public double CurHealth { get; set; }

	public bool Frozen { get; set; }

	public bool Chilled { get; set; }

	public bool Slow { get; set; }

	public bool Stunned { get; set; }

	public bool Burrowed { get; set; }

	public bool Invulnerable { get; set; }

	public bool Hidden { get; set; }

	public bool Stealthed { get; set; }

	public bool Invisible { get; set; }

	public bool Blind { get; set; }

	public bool Bleeding { get; set; }

	public ActorRarity Rarity { get; set; }

	public AnimSnoEnum Animation { get; set; }

	public AcdAnimationState AnimationState { get; set; }

	public float DotDpsApplied { get; set; }

	public bool Illusion { get; set; }

	public bool Palmed { get; set; }

	public bool Haunted { get; set; }

	public bool MarkedForDeath { get; set; }

	public bool Locust { get; set; }

	public bool Strongarmed { get; set; }

	public bool Phoenixed { get; set; }

	public bool Piranhas { get; set; }

	public bool Cursed { get; set; }

	public bool IsQuestMonster { get; set; }

	public bool Attackable { get; set; }

	public bool IsAlive => CurHealth >= 0.30000001192092896;

	public List<SnoMonsterAffix> AffixSnoList {  get; set; }
}
