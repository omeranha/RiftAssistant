using System;

public class MonkPowerInfo
{
	private readonly Player p;

	public Skill BlindingFlash => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 136954);

	public Skill BreathOfHeaven => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69130);

	public Skill CripplingWave => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96311);

	public Skill CycloneStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 223473);

	public Skill DashingStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 312736);

	public Skill DeadlyReach => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96019);

	public Skill Epiphany => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 312307);

	public Skill ExplodingPalm => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 97328);

	public Skill FistsOfThunder => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 95940);

	public Skill InnerSanctuary => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 317076);

	public Skill LashingTailKick => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 111676);

	public Skill MantraOfConviction => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375088);

	public Skill MantraOfHealing => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 373143);

	public Skill MantraOfRetribution => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375082);

	public Skill MantraOfSalvation => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375049);

	public Skill MysticAlly => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 362102);

	public Skill Serenity => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96215);

	public Skill SevenSidedStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96694);

	public Skill SweepingWind => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96090);

	public Skill TempestRush => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 121442);

	public Skill WaveOfLight => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96033);

	public Skill WayOfTheHundredFists => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 97110);

	public SnoPower Alacrity => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 156492);

	public SnoPower BeaconOfYtar => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209104);

	public SnoPower ChantOfResonance => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 156467);

	public SnoPower CombinationStrike => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 218415);

	public SnoPower Determination => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 402633);

	public SnoPower ExaltedSoul => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209027);

	public SnoPower FleetFooted => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209029);

	public SnoPower Harmony => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 404168);

	public SnoPower MantraOfConvictionV2 => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 375089);

	public SnoPower MantraOfEvasionV2 => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 375050);

	public SnoPower MantraOfHealingV2 => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 373154);

	public SnoPower MantraOfRetributionV2 => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 375083);

	public SnoPower Momentum => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 341559);

	public SnoPower MythicRhythm => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 315271);

	public SnoPower NearDeathExperience => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 156484);

	public SnoPower RelentlessAssault => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 404245);

	public SnoPower Resolve => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 211581);

	public SnoPower SeizeTheInitiative => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209628);

	public SnoPower SixthSense => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209622);

	public SnoPower TheGuardiansPath => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209812);

	public SnoPower Transcendence => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209250);

	public SnoPower Unity => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 368899);

	public Skill P74WayOfTheHundredFists => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 487707);

	internal MonkPowerInfo(Player player)
	{
		p = player;
	}
}
