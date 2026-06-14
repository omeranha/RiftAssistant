using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class WizardPowerInfo : IWizardPowerInfo
{
	private readonly Player class310_0;

	public IPlayerSkill ArcaneOrb => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30668);

	public IPlayerSkill ArcaneTorrent => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134456);

	public IPlayerSkill Archon => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134872);

	public IPlayerSkill ArchonArcaneBlast => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 167355);

	public IPlayerSkill ArchonArcaneBlastCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392883);

	public IPlayerSkill ArchonArcaneBlastFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392884);

	public IPlayerSkill ArchonArcaneBlastLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392885);

	public IPlayerSkill ArchonArcaneStrike => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135166);

	public IPlayerSkill ArchonArcaneStrikeCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392886);

	public IPlayerSkill ArchonArcaneStrikeFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392887);

	public IPlayerSkill ArchonArcaneStrikeLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392888);

	public IPlayerSkill ArchonCancel => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 166616);

	public IPlayerSkill ArchonDisintegrationWave => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135238);

	public IPlayerSkill ArchonDisintegrationWaveCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392889);

	public IPlayerSkill ArchonDisintegrationWaveFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392890);

	public IPlayerSkill ArchonDisintegrationWaveLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392891);

	public IPlayerSkill ArchonSlowTime => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135663);

	public IPlayerSkill ArchonTeleport => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 167648);

	public IPlayerSkill BlackHole => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 243141);

	public IPlayerSkill Blizzard => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30680);

	public IPlayerSkill DiamondSkin => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 75599);

	public IPlayerSkill Disintegrate => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 91549);

	public IPlayerSkill Electrocute => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 1765);

	public IPlayerSkill EnergyArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 86991);

	public IPlayerSkill EnergyTwister => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77113);

	public IPlayerSkill ExplosiveBlast => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 87525);

	public IPlayerSkill Familiar => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 99120);

	public IPlayerSkill FrostNova => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30718);

	public IPlayerSkill Hydra => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30725);

	public IPlayerSkill IceArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 73223);

	public IPlayerSkill MagicMissile => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30744);

	public IPlayerSkill MagicWeapon => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 76108);

	public IPlayerSkill Meteor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69190);

	public IPlayerSkill MirrorImage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 98027);

	public IPlayerSkill RayOfFrost => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 93395);

	public IPlayerSkill ShockPulse => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30783);

	public IPlayerSkill SlowTime => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 1769);

	public IPlayerSkill SpectralBlade => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 71548);

	public IPlayerSkill StormArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 74499);

	public IPlayerSkill Teleport => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 168344);

	public IPlayerSkill WaveOfForce => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30796);

	public ISnoPower ArcaneDynamo => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208823);

	public ISnoPower AstralPresence => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208472);

	public ISnoPower Audacity => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 341540);

	public ISnoPower Blur => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208468);

	public ISnoPower ColdBlooded => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 226301);

	public ISnoPower Conflagration => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 218044);

	public ISnoPower Dominance => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 341344);

	public ISnoPower ElementalExposure => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 342326);

	public ISnoPower Evocation => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208473);

	public ISnoPower GalvanizingWard => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208541);

	public ISnoPower GlassCannon => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208471);

	public ISnoPower Illusionist => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208547);

	public ISnoPower Paralysis => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 226348);

	public ISnoPower PowerHungry => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208478);

	public ISnoPower Prodigy => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208493);

	public ISnoPower TemporalFlux => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208477);

	public ISnoPower UnstableAnomaly => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 208474);

	public ISnoPower UnwaveringWill => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 298038);

	internal WizardPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
