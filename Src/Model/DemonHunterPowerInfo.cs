using System;

namespace RiftAssistant.Model;

public class DemonHunterPowerInfo
{
	private readonly Player p;

	public Skill? Bolas => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 77552);

	public Skill? Caltrops => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129216);

	public Skill? Chakram => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129213);

	public Skill? ClusterArrow => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129214);

	public Skill? Companion => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 365311);

	public Skill? ElementalArrow => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 131325);

	public Skill? EntanglingShot => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 361936);

	public Skill? EvasiveFire => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 377450);

	public Skill? FanOfKnives => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 77546);

	public Skill? Grenades => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 86610);

	public Skill? HungeringArrow => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129215);

	public Skill? Impale => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 131366);

	public Skill? MarkedForDeath => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 130738);

	public Skill? Multishot => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 77649);

	public Skill? Preparation => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129212);

	public Skill? RainOfVengeance => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 130831);

	public Skill? RapidFire => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 131192);

	public Skill? Sentry => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 129217);

	public Skill? ShadowPower => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 130830);

	public Skill? SmokeScreen => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 130695);

	public Skill? SpikeTrap => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 75301);

	public Skill? Strafe => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 134030);

	public Skill? Vault => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 111215);

	public Skill? Vengeance => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 302846);

	public SnoPower? Ambush => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 352920);

	public SnoPower? Archery => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 209734);

	public SnoPower? Awareness => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 324770);

	public SnoPower? Ballistics => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155723);

	public SnoPower? Brooding => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 210801);

	public SnoPower? CompanionPassiveEffect => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 365312);

	public SnoPower? CullTheWeak => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155721);

	public SnoPower? CustomEngineering => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208610);

	public SnoPower? Grenadier => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208779);

	public SnoPower? HotPursuit => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155725);

	public SnoPower? Leech => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 439525);

	public SnoPower? NightStalker => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218350);

	public SnoPower? NumbingTraps => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218398);

	public SnoPower? Perfectionist => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155722);

	public SnoPower? PreparationPassiveEffect => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 324845);

	public SnoPower? Sharpshooter => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155715);

	public SnoPower? SingleOut => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 338859);

	public SnoPower? SteadyAim => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 164363);

	public SnoPower? TacticalAdvantage => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218385);

	public SnoPower? ThrillOfTheHunt => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 211225);

	public SnoPower? VengeancePassiveEffect => p.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 155714);

	public Skill? P74Ballista => Array.Find(p.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 487822);

	internal DemonHunterPowerInfo(Player player)
	{
		p = player;
	}
}
