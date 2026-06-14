using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class WitchDoctorPowerInfo : IWitchDoctorPowerInfo
{
	private readonly Player class310_0;

	public IPlayerSkill AcidCloud => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 70455);

	public IPlayerSkill BigBadVoodoo => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 117402);

	public IPlayerSkill CorpseSpider => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69866);

	public IPlayerSkill FetishArmy => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 72785);

	public IPlayerSkill Firebats => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 105963);

	public IPlayerSkill Firebomb => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 67567);

	public IPlayerSkill Gargantuan => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30624);

	public IPlayerSkill GraspOfTheDead => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69182);

	public IPlayerSkill Haunt => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 83602);

	public IPlayerSkill Hex => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30631);

	public IPlayerSkill Horrify => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 67668);

	public IPlayerSkill LocustSwarm => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69867);

	public IPlayerSkill MassConfusion => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 67600);

	public IPlayerSkill Piranhas => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 347265);

	public IPlayerSkill PlagueOfToads => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 106465);

	public IPlayerSkill PoisonDart => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 103181);

	public IPlayerSkill Sacrifice => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 102572);

	public IPlayerSkill SoulHarvest => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 67616);

	public IPlayerSkill SpiritBarrage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 108506);

	public IPlayerSkill SpiritWalk => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 106237);

	public IPlayerSkill SummonZombieDog => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 102573);

	public IPlayerSkill WallOfDeath => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134837);

	public IPlayerSkill ZombieCharger => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 74003);

	public ISnoPower BadMedicine => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 217826);

	public ISnoPower BloodRitual => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208568);

	public ISnoPower CircleOfLife => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208571);

	public ISnoPower ConfidenceRitual => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 442741);

	public ISnoPower CreepingDeath => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 340908);

	public ISnoPower FetishSycophants => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218588);

	public ISnoPower FierceLoyalty => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208639);

	public ISnoPower GraveInjustice => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218191);

	public ISnoPower GruesomeFeast => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208594);

	public ISnoPower JungleFortitude => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 217968);

	public ISnoPower MidnightFeast => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 340909);

	public ISnoPower PierceTheVeil => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208628);

	public ISnoPower RushOfEssence => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208565);

	public ISnoPower SpiritualAttunement => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208569);

	public ISnoPower SpiritVessel => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218501);

	public ISnoPower SwamplandAttunement => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 340910);

	public ISnoPower TraitZombieDogSpawner => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 109560);

	public ISnoPower TribalRites => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208601);

	public ISnoPower VisionQuest => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209041);

	public ISnoPower ZombieHandler => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208563);

	internal WitchDoctorPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
