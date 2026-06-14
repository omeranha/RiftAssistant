using Plugins;
using SNO;

internal class MonsterObstacle : Monster
{
	public MonsterObstacle(uint uint_7, uint uint_8, ISnoActor isnoActor_1) : base(uint_7, uint_8, isnoActor_1, SnoData.Monsters.SnoMonsterObstacle)
	{
		base.MaxHealth = 1.0;
	}
}
