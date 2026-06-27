using Plugins;
using SNO;

internal class MonsterObstacle : Monster
{
	public MonsterObstacle(uint uint_7, uint uint_8, SnoActor SnoActor_1) : base(uint_7, uint_8, SnoActor_1, SnoData.Monsters.SnoMonsterObstacle)
	{
		base.MaxHealth = 1.0;
	}
}
