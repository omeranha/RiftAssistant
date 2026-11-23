using System;

namespace RiftAssistant.Model;

public class WitchDoctorPowerInfo
{
	private readonly Player class310_0;

	public Skill AcidCloud => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 70455);

	public Skill BigBadVoodoo => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 117402);

	public Skill CorpseSpider => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69866);

	public Skill FetishArmy => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 72785);

	public Skill Firebats => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 105963);

	public Skill Firebomb => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67567);

	public Skill Gargantuan => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30624);

	public Skill GraspOfTheDead => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69182);

	public Skill Haunt => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 83602);

	public Skill Hex => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30631);

	public Skill Horrify => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67668);

	public Skill LocustSwarm => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69867);

	public Skill MassConfusion => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67600);

	public Skill Piranhas => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 347265);

	public Skill PlagueOfToads => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 106465);

	public Skill PoisonDart => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 103181);

	public Skill Sacrifice => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 102572);

	public Skill SoulHarvest => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67616);

	public Skill SpiritBarrage => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 108506);

	public Skill SpiritWalk => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 106237);

	public Skill SummonZombieDog => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 102573);

	public Skill WallOfDeath => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 134837);

	public Skill ZombieCharger => Array.Find(class310_0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 74003);

	public SnoPower BadMedicine => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 217826);

	public SnoPower BloodRitual => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208568);

	public SnoPower CircleOfLife => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208571);

	public SnoPower ConfidenceRitual => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 442741);

	public SnoPower CreepingDeath => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340908);

	public SnoPower FetishSycophants => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218588);

	public SnoPower FierceLoyalty => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208639);

	public SnoPower GraveInjustice => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218191);

	public SnoPower GruesomeFeast => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208594);

	public SnoPower JungleFortitude => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 217968);

	public SnoPower MidnightFeast => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340909);

	public SnoPower PierceTheVeil => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208628);

	public SnoPower RushOfEssence => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208565);

	public SnoPower SpiritualAttunement => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208569);

	public SnoPower SpiritVessel => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218501);

	public SnoPower SwamplandAttunement => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340910);

	public SnoPower TraitZombieDogSpawner => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 109560);

	public SnoPower TribalRites => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208601);

	public SnoPower VisionQuest => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209041);

	public SnoPower ZombieHandler => class310_0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208563);

	internal WitchDoctorPowerInfo(Player player)
	{
		class310_0 = player;
	}
}
