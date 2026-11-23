using System;

namespace RiftAssistant.Model;

public class MonkPowerInfo
{
	private readonly Player p;

	public Skill BlindingFlash => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 136954);

	public Skill BreathOfHeaven => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69130);

	public Skill CripplingWave => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96311);

	public Skill CycloneStrike => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 223473);

	public Skill DashingStrike => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 312736);

	public Skill DeadlyReach => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96019);

	public Skill Epiphany => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 312307);

	public Skill ExplodingPalm => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 97328);

	public Skill FistsOfThunder => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 95940);

	public Skill InnerSanctuary => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 317076);

	public Skill LashingTailKick => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 111676);

	public Skill MantraOfConviction => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 375088);

	public Skill MantraOfHealing => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 373143);

	public Skill MantraOfRetribution => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 375082);

	public Skill MantraOfSalvation => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 375049);

	public Skill MysticAlly => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 362102);

	public Skill Serenity => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96215);

	public Skill SevenSidedStrike => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96694);

	public Skill SweepingWind => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96090);

	public Skill TempestRush => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 121442);

	public Skill WaveOfLight => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96033);

	public Skill WayOfTheHundredFists => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 97110);

	public SnoPower Alacrity => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 156492);

	public SnoPower BeaconOfYtar => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209104);

	public SnoPower ChantOfResonance => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 156467);

	public SnoPower CombinationStrike => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218415);

	public SnoPower Determination => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 402633);

	public SnoPower ExaltedSoul => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209027);

	public SnoPower FleetFooted => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209029);

	public SnoPower Harmony => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 404168);

	public SnoPower MantraOfConvictionV2 => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 375089);

	public SnoPower MantraOfEvasionV2 => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 375050);

	public SnoPower MantraOfHealingV2 => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 373154);

	public SnoPower MantraOfRetributionV2 => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 375083);

	public SnoPower Momentum => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 341559);

	public SnoPower MythicRhythm => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 315271);

	public SnoPower NearDeathExperience => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 156484);

	public SnoPower RelentlessAssault => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 404245);

	public SnoPower Resolve => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 211581);

	public SnoPower SeizeTheInitiative => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209628);

	public SnoPower SixthSense => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209622);

	public SnoPower TheGuardiansPath => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209812);

	public SnoPower Transcendence => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209250);

	public SnoPower Unity => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 368899);

	public Skill P74WayOfTheHundredFists => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 487707);

	internal MonkPowerInfo(Player player)
	{
		p = player;
	}
}
