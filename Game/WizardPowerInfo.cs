using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

public class WizardPowerInfo
{
	private readonly Player class310_0;

	public Skill ArcaneOrb => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30668);

	public Skill ArcaneTorrent => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134456);

	public Skill Archon => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 134872);

	public Skill ArchonArcaneBlast => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 167355);

	public Skill ArchonArcaneBlastCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392883);

	public Skill ArchonArcaneBlastFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392884);

	public Skill ArchonArcaneBlastLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392885);

	public Skill ArchonArcaneStrike => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135166);

	public Skill ArchonArcaneStrikeCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392886);

	public Skill ArchonArcaneStrikeFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392887);

	public Skill ArchonArcaneStrikeLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392888);

	public Skill ArchonCancel => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 166616);

	public Skill ArchonDisintegrationWave => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135238);

	public Skill ArchonDisintegrationWaveCold => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392889);

	public Skill ArchonDisintegrationWaveFire => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392890);

	public Skill ArchonDisintegrationWaveLightning => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 392891);

	public Skill ArchonSlowTime => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 135663);

	public Skill ArchonTeleport => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 167648);

	public Skill BlackHole => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 243141);

	public Skill Blizzard => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30680);

	public Skill DiamondSkin => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 75599);

	public Skill Disintegrate => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 91549);

	public Skill Electrocute => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 1765);

	public Skill EnergyArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 86991);

	public Skill EnergyTwister => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 77113);

	public Skill ExplosiveBlast => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 87525);

	public Skill Familiar => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 99120);

	public Skill FrostNova => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30718);

	public Skill Hydra => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30725);

	public Skill IceArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 73223);

	public Skill MagicMissile => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30744);

	public Skill MagicWeapon => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 76108);

	public Skill Meteor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 69190);

	public Skill MirrorImage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 98027);

	public Skill RayOfFrost => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 93395);

	public Skill ShockPulse => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30783);

	public Skill SlowTime => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 1769);

	public Skill SpectralBlade => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 71548);

	public Skill StormArmor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 74499);

	public Skill Teleport => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 168344);

	public Skill WaveOfForce => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 30796);

	public SnoPower ArcaneDynamo => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208823);

	public SnoPower AstralPresence => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208472);

	public SnoPower Audacity => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 341540);

	public SnoPower Blur => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208468);

	public SnoPower ColdBlooded => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 226301);

	public SnoPower Conflagration => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 218044);

	public SnoPower Dominance => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 341344);

	public SnoPower ElementalExposure => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 342326);

	public SnoPower Evocation => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208473);

	public SnoPower GalvanizingWard => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208541);

	public SnoPower GlassCannon => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208471);

	public SnoPower Illusionist => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208547);

	public SnoPower Paralysis => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 226348);

	public SnoPower PowerHungry => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208478);

	public SnoPower Prodigy => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208493);

	public SnoPower TemporalFlux => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208477);

	public SnoPower UnstableAnomaly => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 208474);

	public SnoPower UnwaveringWill => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 298038);

	internal WizardPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
