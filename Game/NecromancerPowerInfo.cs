using System;

public class NecromancerPowerInfo
{
	private readonly Player class310_0;

	public Skill ArmyOfTheDead => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460358);

	public Skill BloodRush => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 454090);

	public Skill BoneArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 466857);

	public Skill BoneSpear => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451490);

	public Skill BoneSpikes => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462147);

	public Skill BoneSpirit => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 464896);

	public Skill CommandGolem => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451537);

	public Skill CommandSkeletons => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 453801);

	public Skill CorpseExplosion => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 454174);

	public Skill CorpseLance => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 461650);

	public Skill DeathNova => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462243);

	public Skill Decrepify => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451491);

	public Skill Devour => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460757);

	public Skill Frailty => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460870);

	public Skill GrimScythe => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462198);

	public Skill LandOfTheDead => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 465839);

	public Skill Leech => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462255);

	public Skill Revive => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462239);

	public Skill Simulacrum => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 465350);

	public Skill SiphonBlood => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 453563);

	public Skill SkeletalMage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462089);

	public SnoPower AberrantAnimator => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472949);

	public SnoPower BloodForBlood => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465821);

	public SnoPower BloodIsPower => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465037);

	public SnoPower BonePrison => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472965);

	public SnoPower CommanderOfTheRisenDead => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472962);

	public SnoPower DarkReaping => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 470812);

	public SnoPower DecrepifyPassiveEffect => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 471738);

	public SnoPower DrawLife => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465264);

	public SnoPower EternalTorment => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472795);

	public SnoPower ExtendedServitude => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 464994);

	public SnoPower FinalService => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465952);

	public SnoPower FrailtyPassiveEffect => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 471845);

	public SnoPower FueledByDeath => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465917);

	public SnoPower GrislyTribute => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 473019);

	public SnoPower LeechPassiveEffect => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 471869);

	public SnoPower LifeFromDeath => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 465703);

	public SnoPower OverwhelmingEssence => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 470764);

	public SnoPower RathmasShield => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472910);

	public SnoPower RigorMortis => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 466415);

	public SnoPower Serration => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472905);

	public SnoPower SpreadingMalediction => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 472220);

	public SnoPower StandAlone => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 470725);

	public SnoPower SwiftHarvesting => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 470805);

	internal NecromancerPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
