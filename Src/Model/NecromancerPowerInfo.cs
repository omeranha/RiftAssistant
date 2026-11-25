using System;

namespace RiftAssistant.Model;

public class NecromancerPowerInfo
{
	private readonly Player player0;

	public Skill ArmyOfTheDead => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 460358);

	public Skill BloodRush => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 454090);

	public Skill BoneArmor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 466857);

	public Skill BoneSpear => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 451490);

	public Skill BoneSpikes => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462147);

	public Skill BoneSpirit => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 464896);

	public Skill CommandGolem => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 451537);

	public Skill CommandSkeletons => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 453801);

	public Skill CorpseExplosion => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 454174);

	public Skill CorpseLance => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 461650);

	public Skill DeathNova => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462243);

	public Skill Decrepify => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 451491);

	public Skill Devour => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 460757);

	public Skill Frailty => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 460870);

	public Skill GrimScythe => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462198);

	public Skill LandOfTheDead => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 465839);

	public Skill Leech => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462255);

	public Skill Revive => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462239);

	public Skill Simulacrum => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 465350);

	public Skill SiphonBlood => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 453563);

	public Skill SkeletalMage => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 462089);

	public SnoPower AberrantAnimator => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472949);

	public SnoPower BloodForBlood => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465821);

	public SnoPower BloodIsPower => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465037);

	public SnoPower BonePrison => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472965);

	public SnoPower CommanderOfTheRisenDead => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472962);

	public SnoPower DarkReaping => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 470812);

	public SnoPower DecrepifyPassiveEffect => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 471738);

	public SnoPower DrawLife => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465264);

	public SnoPower EternalTorment => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472795);

	public SnoPower ExtendedServitude => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 464994);

	public SnoPower FinalService => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465952);

	public SnoPower FrailtyPassiveEffect => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 471845);

	public SnoPower FueledByDeath => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465917);

	public SnoPower GrislyTribute => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 473019);

	public SnoPower LeechPassiveEffect => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 471869);

	public SnoPower LifeFromDeath => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 465703);

	public SnoPower OverwhelmingEssence => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 470764);

	public SnoPower RathmasShield => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472910);

	public SnoPower RigorMortis => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 466415);

	public SnoPower Serration => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472905);

	public SnoPower SpreadingMalediction => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 472220);

	public SnoPower StandAlone => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 470725);

	public SnoPower SwiftHarvesting => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 470805);

	internal NecromancerPowerInfo(Player player)
	{
		player0 = player;
	}
}
