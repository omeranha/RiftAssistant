using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class DemonHunterPowerInfo : IDemonHunterPowerInfo
{
	private readonly Player p;

	public IPlayerSkill Bolas => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77552);

	public IPlayerSkill Caltrops => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129216);

	public IPlayerSkill Chakram => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129213);

	public IPlayerSkill ClusterArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129214);

	public IPlayerSkill Companion => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 365311);

	public IPlayerSkill ElementalArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131325);

	public IPlayerSkill EntanglingShot => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 361936);

	public IPlayerSkill EvasiveFire => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 377450);

	public IPlayerSkill FanOfKnives => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77546);

	public IPlayerSkill Grenades => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 86610);

	public IPlayerSkill HungeringArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129215);

	public IPlayerSkill Impale => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131366);

	public IPlayerSkill MarkedForDeath => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130738);

	public IPlayerSkill Multishot => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77649);

	public IPlayerSkill Preparation => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129212);

	public IPlayerSkill RainOfVengeance => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130831);

	public IPlayerSkill RapidFire => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131192);

	public IPlayerSkill Sentry => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129217);

	public IPlayerSkill ShadowPower => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130830);

	public IPlayerSkill SmokeScreen => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130695);

	public IPlayerSkill SpikeTrap => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 75301);

	public IPlayerSkill Strafe => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134030);

	public IPlayerSkill Vault => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 111215);

	public IPlayerSkill Vengeance => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 302846);

	public ISnoPower Ambush => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 352920);

	public ISnoPower Archery => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209734);

	public ISnoPower Awareness => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 324770);

	public ISnoPower Ballistics => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155723);

	public ISnoPower Brooding => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 210801);

	public ISnoPower CompanionPassiveEffect => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 365312);

	public ISnoPower CullTheWeak => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155721);

	public ISnoPower CustomEngineering => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208610);

	public ISnoPower Grenadier => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208779);

	public ISnoPower HotPursuit => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155725);

	public ISnoPower Leech => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 439525);

	public ISnoPower NightStalker => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218350);

	public ISnoPower NumbingTraps => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218398);

	public ISnoPower Perfectionist => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155722);

	public ISnoPower PreparationPassiveEffect => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 324845);

	public ISnoPower Sharpshooter => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155715);

	public ISnoPower SingleOut => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 338859);

	public ISnoPower SteadyAim => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 164363);

	public ISnoPower TacticalAdvantage => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218385);

	public ISnoPower ThrillOfTheHunt => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 211225);

	public ISnoPower VengeancePassiveEffect => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 155714);

	public IPlayerSkill P74Ballista => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 487822);

	internal DemonHunterPowerInfo(Player player)
	{
		p = player;
	}
}
