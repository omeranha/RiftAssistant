using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class NecromancerPowerInfo : INecromancerPowerInfo
{
	private readonly Player class310_0;

	public IPlayerSkill ArmyOfTheDead => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460358);

	public IPlayerSkill BloodRush => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 454090);

	public IPlayerSkill BoneArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 466857);

	public IPlayerSkill BoneSpear => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451490);

	public IPlayerSkill BoneSpikes => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462147);

	public IPlayerSkill BoneSpirit => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 464896);

	public IPlayerSkill CommandGolem => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451537);

	public IPlayerSkill CommandSkeletons => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 453801);

	public IPlayerSkill CorpseExplosion => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 454174);

	public IPlayerSkill CorpseLance => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 461650);

	public IPlayerSkill DeathNova => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462243);

	public IPlayerSkill Decrepify => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 451491);

	public IPlayerSkill Devour => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460757);

	public IPlayerSkill Frailty => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 460870);

	public IPlayerSkill GrimScythe => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462198);

	public IPlayerSkill LandOfTheDead => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 465839);

	public IPlayerSkill Leech => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462255);

	public IPlayerSkill Revive => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462239);

	public IPlayerSkill Simulacrum => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 465350);

	public IPlayerSkill SiphonBlood => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 453563);

	public IPlayerSkill SkeletalMage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 462089);

	public ISnoPower AberrantAnimator => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472949);

	public ISnoPower BloodForBlood => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465821);

	public ISnoPower BloodIsPower => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465037);

	public ISnoPower BonePrison => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472965);

	public ISnoPower CommanderOfTheRisenDead => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472962);

	public ISnoPower DarkReaping => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 470812);

	public ISnoPower DecrepifyPassiveEffect => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 471738);

	public ISnoPower DrawLife => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465264);

	public ISnoPower EternalTorment => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472795);

	public ISnoPower ExtendedServitude => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 464994);

	public ISnoPower FinalService => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465952);

	public ISnoPower FrailtyPassiveEffect => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 471845);

	public ISnoPower FueledByDeath => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465917);

	public ISnoPower GrislyTribute => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 473019);

	public ISnoPower LeechPassiveEffect => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 471869);

	public ISnoPower LifeFromDeath => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 465703);

	public ISnoPower OverwhelmingEssence => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 470764);

	public ISnoPower RathmasShield => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472910);

	public ISnoPower RigorMortis => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 466415);

	public ISnoPower Serration => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472905);

	public ISnoPower SpreadingMalediction => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 472220);

	public ISnoPower StandAlone => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 470725);

	public ISnoPower SwiftHarvesting => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 470805);

	internal NecromancerPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
