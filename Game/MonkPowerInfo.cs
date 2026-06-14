using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class MonkPowerInfo : IMonkPowerInfo
{
	private readonly Player p;

	public IPlayerSkill BlindingFlash => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 136954);

	public IPlayerSkill BreathOfHeaven => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69130);

	public IPlayerSkill CripplingWave => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96311);

	public IPlayerSkill CycloneStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 223473);

	public IPlayerSkill DashingStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 312736);

	public IPlayerSkill DeadlyReach => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96019);

	public IPlayerSkill Epiphany => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 312307);

	public IPlayerSkill ExplodingPalm => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 97328);

	public IPlayerSkill FistsOfThunder => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 95940);

	public IPlayerSkill InnerSanctuary => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 317076);

	public IPlayerSkill LashingTailKick => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 111676);

	public IPlayerSkill MantraOfConviction => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375088);

	public IPlayerSkill MantraOfHealing => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 373143);

	public IPlayerSkill MantraOfRetribution => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375082);

	public IPlayerSkill MantraOfSalvation => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375049);

	public IPlayerSkill MysticAlly => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 362102);

	public IPlayerSkill Serenity => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96215);

	public IPlayerSkill SevenSidedStrike => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96694);

	public IPlayerSkill SweepingWind => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96090);

	public IPlayerSkill TempestRush => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 121442);

	public IPlayerSkill WaveOfLight => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96033);

	public IPlayerSkill WayOfTheHundredFists => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 97110);

	public ISnoPower Alacrity => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 156492);

	public ISnoPower BeaconOfYtar => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209104);

	public ISnoPower ChantOfResonance => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 156467);

	public ISnoPower CombinationStrike => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218415);

	public ISnoPower Determination => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 402633);

	public ISnoPower ExaltedSoul => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209027);

	public ISnoPower FleetFooted => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209029);

	public ISnoPower Harmony => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 404168);

	public ISnoPower MantraOfConvictionV2 => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 375089);

	public ISnoPower MantraOfEvasionV2 => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 375050);

	public ISnoPower MantraOfHealingV2 => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 373154);

	public ISnoPower MantraOfRetributionV2 => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 375083);

	public ISnoPower Momentum => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 341559);

	public ISnoPower MythicRhythm => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 315271);

	public ISnoPower NearDeathExperience => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 156484);

	public ISnoPower RelentlessAssault => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 404245);

	public ISnoPower Resolve => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 211581);

	public ISnoPower SeizeTheInitiative => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209628);

	public ISnoPower SixthSense => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209622);

	public ISnoPower TheGuardiansPath => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209812);

	public ISnoPower Transcendence => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 209250);

	public ISnoPower Unity => p.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 368899);

	public IPlayerSkill P74WayOfTheHundredFists => Array.Find(p.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 487707);

	internal MonkPowerInfo(Player player)
	{
		p = player;
	}
}
