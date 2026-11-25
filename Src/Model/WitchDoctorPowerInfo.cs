using System;

namespace RiftAssistant.Model;

public class WitchDoctorPowerInfo
{
	private readonly Player player0;

	public Skill AcidCloud => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 70455);

	public Skill BigBadVoodoo => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 117402);

	public Skill CorpseSpider => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69866);

	public Skill FetishArmy => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 72785);

	public Skill Firebats => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 105963);

	public Skill Firebomb => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67567);

	public Skill Gargantuan => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30624);

	public Skill GraspOfTheDead => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69182);

	public Skill Haunt => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 83602);

	public Skill Hex => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30631);

	public Skill Horrify => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67668);

	public Skill LocustSwarm => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69867);

	public Skill MassConfusion => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67600);

	public Skill Piranhas => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 347265);

	public Skill PlagueOfToads => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 106465);

	public Skill PoisonDart => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 103181);

	public Skill Sacrifice => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 102572);

	public Skill SoulHarvest => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 67616);

	public Skill SpiritBarrage => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 108506);

	public Skill SpiritWalk => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 106237);

	public Skill SummonZombieDog => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 102573);

	public Skill WallOfDeath => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 134837);

	public Skill ZombieCharger => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 74003);

	public SnoPower BadMedicine => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 217826);

	public SnoPower BloodRitual => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208568);

	public SnoPower CircleOfLife => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208571);

	public SnoPower ConfidenceRitual => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 442741);

	public SnoPower CreepingDeath => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340908);

	public SnoPower FetishSycophants => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218588);

	public SnoPower FierceLoyalty => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208639);

	public SnoPower GraveInjustice => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218191);

	public SnoPower GruesomeFeast => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208594);

	public SnoPower JungleFortitude => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 217968);

	public SnoPower MidnightFeast => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340909);

	public SnoPower PierceTheVeil => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208628);

	public SnoPower RushOfEssence => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208565);

	public SnoPower SpiritualAttunement => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208569);

	public SnoPower SpiritVessel => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218501);

	public SnoPower SwamplandAttunement => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340910);

	public SnoPower TraitZombieDogSpawner => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 109560);

	public SnoPower TribalRites => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208601);

	public SnoPower VisionQuest => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209041);

	public SnoPower ZombieHandler => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208563);

	internal WitchDoctorPowerInfo(Player player)
	{
		player0 = player;
	}
}
