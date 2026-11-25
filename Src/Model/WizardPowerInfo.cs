using System;

namespace RiftAssistant.Model;

public class WizardPowerInfo
{
	private readonly Player player0;

	public Skill? ArcaneOrb => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30668);

	public Skill? ArcaneTorrent => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 134456);

	public Skill? Archon => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 134872);

	public Skill? ArchonArcaneBlast => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 167355);

	public Skill? ArchonArcaneBlastCold => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392883);

	public Skill? ArchonArcaneBlastFire => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392884);

	public Skill? ArchonArcaneBlastLightning => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392885);

	public Skill? ArchonArcaneStrike => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 135166);

	public Skill? ArchonArcaneStrikeCold => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392886);

	public Skill? ArchonArcaneStrikeFire => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392887);

	public Skill? ArchonArcaneStrikeLightning => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392888);

	public Skill? ArchonCancel => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 166616);

	public Skill? ArchonDisintegrationWave => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 135238);

	public Skill? ArchonDisintegrationWaveCold => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392889);

	public Skill? ArchonDisintegrationWaveFire => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392890);

	public Skill? ArchonDisintegrationWaveLightning => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 392891);

	public Skill? ArchonSlowTime => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 135663);

	public Skill? ArchonTeleport => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 167648);

	public Skill? BlackHole => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 243141);

	public Skill? Blizzard => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30680);

	public Skill? DiamondSkin => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 75599);

	public Skill? Disintegrate => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 91549);

	public Skill? Electrocute => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 1765);

	public Skill? EnergyArmor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 86991);

	public Skill? EnergyTwister => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 77113);

	public Skill? ExplosiveBlast => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 87525);

	public Skill? Familiar => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 99120);

	public Skill? FrostNova => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30718);

	public Skill? Hydra => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30725);

	public Skill? IceArmor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 73223);

	public Skill? MagicMissile => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30744);

	public Skill? MagicWeapon => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 76108);

	public Skill? Meteor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 69190);

	public Skill? MirrorImage => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 98027);

	public Skill? RayOfFrost => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 93395);

	public Skill? ShockPulse => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30783);

	public Skill? SlowTime => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 1769);

	public Skill? SpectralBlade => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 71548);

	public Skill? StormArmor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 74499);

	public Skill? Teleport => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 168344);

	public Skill? WaveOfForce => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 30796);

	public SnoPower? ArcaneDynamo => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208823);

	public SnoPower? AstralPresence => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208472);

	public SnoPower? Audacity => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 341540);

	public SnoPower? Blur => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208468);

	public SnoPower? ColdBlooded => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 226301);

	public SnoPower? Conflagration => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 218044);

	public SnoPower? Dominance => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 341344);

	public SnoPower? ElementalExposure => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 342326);

	public SnoPower? Evocation => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208473);

	public SnoPower? GalvanizingWard => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208541);

	public SnoPower? GlassCannon => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208471);

	public SnoPower? Illusionist => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208547);

	public SnoPower? Paralysis => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 226348);

	public SnoPower? PowerHungry => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208478);

	public SnoPower? Prodigy => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208493);

	public SnoPower? TemporalFlux => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208477);

	public SnoPower? UnstableAnomaly => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 208474);

	public SnoPower? UnwaveringWill => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 298038);

	internal WizardPowerInfo(Player player)
	{
		player0 = player;
	}
}
