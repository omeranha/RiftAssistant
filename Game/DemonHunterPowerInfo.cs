using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

public class DemonHunterPowerInfo
{
	private readonly Player p;

	public Skill Bolas => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77552);

	public Skill Caltrops => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129216);

	public Skill Chakram => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129213);

	public Skill ClusterArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129214);

	public Skill Companion => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 365311);

	public Skill ElementalArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131325);

	public Skill EntanglingShot => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 361936);

	public Skill EvasiveFire => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 377450);

	public Skill FanOfKnives => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77546);

	public Skill Grenades => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 86610);

	public Skill HungeringArrow => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129215);

	public Skill Impale => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131366);

	public Skill MarkedForDeath => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130738);

	public Skill Multishot => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77649);

	public Skill Preparation => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129212);

	public Skill RainOfVengeance => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130831);

	public Skill RapidFire => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 131192);

	public Skill Sentry => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 129217);

	public Skill ShadowPower => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130830);

	public Skill SmokeScreen => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 130695);

	public Skill SpikeTrap => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 75301);

	public Skill Strafe => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134030);

	public Skill Vault => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 111215);

	public Skill Vengeance => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 302846);

	public SnoPower Ambush => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 352920);

	public SnoPower Archery => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 209734);

	public SnoPower Awareness => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 324770);

	public SnoPower Ballistics => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155723);

	public SnoPower Brooding => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 210801);

	public SnoPower CompanionPassiveEffect => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 365312);

	public SnoPower CullTheWeak => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155721);

	public SnoPower CustomEngineering => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208610);

	public SnoPower Grenadier => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208779);

	public SnoPower HotPursuit => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155725);

	public SnoPower Leech => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 439525);

	public SnoPower NightStalker => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 218350);

	public SnoPower NumbingTraps => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 218398);

	public SnoPower Perfectionist => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155722);

	public SnoPower PreparationPassiveEffect => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 324845);

	public SnoPower Sharpshooter => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155715);

	public SnoPower SingleOut => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 338859);

	public SnoPower SteadyAim => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 164363);

	public SnoPower TacticalAdvantage => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 218385);

	public SnoPower ThrillOfTheHunt => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 211225);

	public SnoPower VengeancePassiveEffect => p.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 155714);

	public Skill P74Ballista => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 487822);

	internal DemonHunterPowerInfo(Player player)
	{
		p = player;
	}
}
