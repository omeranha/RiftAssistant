using System.Collections.Generic;
using Plugins;
using SNO;

namespace SNO;

public class SnoPowerList
{
	private readonly Dictionary<HeroClass, List<SnoPower>> dictionary_0 = new Dictionary<HeroClass, List<SnoPower>>();

	private readonly List<SnoPower> list_0 = new List<SnoPower>();

	private readonly List<SnoPower> list_1 = new List<SnoPower>();

	public SnoPower Barbarian_AncientSpear { get; }

	public SnoPower Barbarian_Avalanche { get; }

	public SnoPower Barbarian_Bash { get; }

	public SnoPower Barbarian_BattleRage { get; }

	public SnoPower Barbarian_CallOfTheAncients { get; }

	public SnoPower Barbarian_Cleave { get; }

	public SnoPower Barbarian_Earthquake { get; }

	public SnoPower Barbarian_Frenzy { get; }

	public SnoPower Barbarian_FuriousCharge { get; }

	public SnoPower Barbarian_GroundStomp { get; }

	public SnoPower Barbarian_HammerOfTheAncients { get; }

	public SnoPower Barbarian_IgnorePain { get; }

	public SnoPower Barbarian_Leap { get; }

	public SnoPower Barbarian_Overpower { get; }

	public SnoPower Barbarian_Rend { get; }

	public SnoPower Barbarian_Revenge { get; }

	public SnoPower Barbarian_SeismicSlam { get; }

	public SnoPower Barbarian_Sprint { get; }

	public SnoPower Barbarian_ThreateningShout { get; }

	public SnoPower Barbarian_WarCry { get; }

	public SnoPower Barbarian_WeaponThrow { get; }

	public SnoPower Barbarian_Whirlwind { get; }

	public SnoPower Barbarian_WrathOfTheBerserker { get; }

	public SnoPower Barbarian_Passive_Animosity { get; }

	public SnoPower Barbarian_Passive_BerserkerRage { get; }

	public SnoPower Barbarian_Passive_Bloodthirst { get; }

	public SnoPower Barbarian_Passive_BoonOfBulKathos { get; }

	public SnoPower Barbarian_Passive_Brawler { get; }

	public SnoPower Barbarian_Passive_EarthenMight { get; }

	public SnoPower Barbarian_Passive_InspiringPresence { get; }

	public SnoPower Barbarian_Passive_Juggernaut { get; }

	public SnoPower Barbarian_Passive_NervesOfSteel { get; }

	public SnoPower Barbarian_Passive_NoEscape { get; }

	public SnoPower Barbarian_Passive_PoundOfFlesh { get; }

	public SnoPower Barbarian_Passive_Rampage { get; }

	public SnoPower Barbarian_Passive_Relentless { get; }

	public SnoPower Barbarian_Passive_Ruthless { get; }

	public SnoPower Barbarian_Passive_Superstition { get; }

	public SnoPower Barbarian_Passive_SwordAndBoard { get; }

	public SnoPower Barbarian_Passive_ToughAsNails { get; }

	public SnoPower Barbarian_Passive_Unforgiving { get; }

	public SnoPower Barbarian_Passive_WeaponsMaster { get; }

	public SnoPower Crusader_AkaratsChampion { get; }

	public SnoPower Crusader_BlessedHammer { get; }

	public SnoPower Crusader_BlessedShield { get; }

	public SnoPower Crusader_Bombardment { get; }

	public SnoPower Crusader_Condemn { get; }

	public SnoPower Crusader_Consecration { get; }

	public SnoPower Crusader_CrushingResolve { get; }

	public SnoPower Crusader_FallingSword { get; }

	public SnoPower Crusader_FistOfTheHeavens { get; }

	public SnoPower Crusader_HeavensFury { get; }

	public SnoPower Crusader_IronSkin { get; }

	public SnoPower Crusader_Judgment { get; }

	public SnoPower Crusader_Justice { get; }

	public SnoPower Crusader_LawsOfHope { get; }

	public SnoPower Crusader_LawsOfJustice { get; }

	public SnoPower Crusader_LawsOfValor { get; }

	public SnoPower Crusader_Phalanx { get; }

	public SnoPower Crusader_Provoke { get; }

	public SnoPower Crusader_Punish { get; }

	public SnoPower Crusader_ShieldBash { get; }

	public SnoPower Crusader_ShieldGlare { get; }

	public SnoPower Crusader_Slash { get; }

	public SnoPower Crusader_Smite { get; }

	public SnoPower Crusader_SteedCharge { get; }

	public SnoPower Crusader_SweepAttack { get; }

	public SnoPower Crusader_Passive_Blunt { get; }

	public SnoPower Crusader_Passive_DivineFortress { get; }

	public SnoPower Crusader_Passive_Fanaticism { get; }

	public SnoPower Crusader_Passive_Fervor { get; }

	public SnoPower Crusader_Passive_Finery { get; }

	public SnoPower Crusader_Passive_HeavenlyStrength { get; }

	public SnoPower Crusader_Passive_HoldYourGround { get; }

	public SnoPower Crusader_Passive_HolyCause { get; }

	public SnoPower Crusader_Passive_Indestructible { get; }

	public SnoPower Crusader_Passive_Insurmountable { get; }

	public SnoPower Crusader_Passive_IronMaiden { get; }

	public SnoPower Crusader_Passive_LongArmOfTheLaw { get; }

	public SnoPower Crusader_Passive_LordCommander { get; }

	public SnoPower Crusader_Passive_Renewal { get; }

	public SnoPower Crusader_Passive_Righteousness { get; }

	public SnoPower Crusader_Passive_ToweringShield { get; }

	public SnoPower Crusader_Passive_Vigilant { get; }

	public SnoPower Crusader_Passive_Wrathful { get; }

	public SnoPower DemonHunter_Bolas { get; }

	public SnoPower DemonHunter_Caltrops { get; }

	public SnoPower DemonHunter_Chakram { get; }

	public SnoPower DemonHunter_ClusterArrow { get; }

	public SnoPower DemonHunter_Companion { get; }

	public SnoPower DemonHunter_ElementalArrow { get; }

	public SnoPower DemonHunter_EntanglingShot { get; }

	public SnoPower DemonHunter_EvasiveFire { get; }

	public SnoPower DemonHunter_FanOfKnives { get; }

	public SnoPower DemonHunter_Grenades { get; }

	public SnoPower DemonHunter_HungeringArrow { get; }

	public SnoPower DemonHunter_Impale { get; }

	public SnoPower DemonHunter_MarkedForDeath { get; }

	public SnoPower DemonHunter_Multishot { get; }

	public SnoPower DemonHunter_Preparation { get; }

	public SnoPower DemonHunter_RainOfVengeance { get; }

	public SnoPower DemonHunter_RapidFire { get; }

	public SnoPower DemonHunter_Sentry { get; }

	public SnoPower DemonHunter_ShadowPower { get; }

	public SnoPower DemonHunter_SmokeScreen { get; }

	public SnoPower DemonHunter_SpikeTrap { get; }

	public SnoPower DemonHunter_Strafe { get; }

	public SnoPower DemonHunter_Vault { get; }

	public SnoPower DemonHunter_Vengeance { get; }

	public SnoPower DemonHunter_Passive_Ambush { get; }

	public SnoPower DemonHunter_Passive_Archery { get; }

	public SnoPower DemonHunter_Passive_Awareness { get; }

	public SnoPower DemonHunter_Passive_Ballistics { get; }

	public SnoPower DemonHunter_Passive_Brooding { get; }

	public SnoPower DemonHunter_Passive_CompanionPassiveEffect { get; }

	public SnoPower DemonHunter_Passive_CullTheWeak { get; }

	public SnoPower DemonHunter_Passive_CustomEngineering { get; }

	public SnoPower DemonHunter_Passive_Grenadier { get; }

	public SnoPower DemonHunter_Passive_HotPursuit { get; }

	public SnoPower DemonHunter_Passive_Leech { get; }

	public SnoPower DemonHunter_Passive_NightStalker { get; }

	public SnoPower DemonHunter_Passive_NumbingTraps { get; }

	public SnoPower DemonHunter_Passive_Perfectionist { get; }

	public SnoPower DemonHunter_Passive_PreparationPassiveEffect { get; }

	public SnoPower DemonHunter_Passive_Sharpshooter { get; }

	public SnoPower DemonHunter_Passive_SingleOut { get; }

	public SnoPower DemonHunter_Passive_SteadyAim { get; }

	public SnoPower DemonHunter_Passive_TacticalAdvantage { get; }

	public SnoPower DemonHunter_Passive_ThrillOfTheHunt { get; }

	public SnoPower DemonHunter_Passive_VengeancePassiveEffect { get; }

	public SnoPower Monk_BlindingFlash { get; }

	public SnoPower Monk_BreathOfHeaven { get; }

	public SnoPower Monk_CripplingWave { get; }

	public SnoPower Monk_CycloneStrike { get; }

	public SnoPower Monk_DashingStrike { get; }

	public SnoPower Monk_DeadlyReach { get; }

	public SnoPower Monk_Epiphany { get; }

	public SnoPower Monk_ExplodingPalm { get; }

	public SnoPower Monk_FistsOfThunder { get; }

	public SnoPower Monk_InnerSanctuary { get; }

	public SnoPower Monk_LashingTailKick { get; }

	public SnoPower Monk_MantraOfConviction { get; }

	public SnoPower Monk_MantraOfHealing { get; }

	public SnoPower Monk_MantraOfRetribution { get; }

	public SnoPower Monk_MantraOfSalvation { get; }

	public SnoPower Monk_MysticAlly { get; }

	public SnoPower Monk_Serenity { get; }

	public SnoPower Monk_SevenSidedStrike { get; }

	public SnoPower Monk_SweepingWind { get; }

	public SnoPower Monk_TempestRush { get; }

	public SnoPower Monk_WaveOfLight { get; }

	public SnoPower Monk_WayOfTheHundredFists { get; }

	public SnoPower Monk_Passive_Alacrity { get; }

	public SnoPower Monk_Passive_BeaconOfYtar { get; }

	public SnoPower Monk_Passive_ChantOfResonance { get; }

	public SnoPower Monk_Passive_CombinationStrike { get; }

	public SnoPower Monk_Passive_Determination { get; }

	public SnoPower Monk_Passive_ExaltedSoul { get; }

	public SnoPower Monk_Passive_FleetFooted { get; }

	public SnoPower Monk_Passive_Harmony { get; }

	public SnoPower Monk_Passive_MantraOfConvictionV2 { get; }

	public SnoPower Monk_Passive_MantraOfEvasionV2 { get; }

	public SnoPower Monk_Passive_MantraOfHealingV2 { get; }

	public SnoPower Monk_Passive_MantraOfRetributionV2 { get; }

	public SnoPower Monk_Passive_Momentum { get; }

	public SnoPower Monk_Passive_MythicRhythm { get; }

	public SnoPower Monk_Passive_NearDeathExperience { get; }

	public SnoPower Monk_Passive_RelentlessAssault { get; }

	public SnoPower Monk_Passive_Resolve { get; }

	public SnoPower Monk_Passive_SeizeTheInitiative { get; }

	public SnoPower Monk_Passive_SixthSense { get; }

	public SnoPower Monk_Passive_TheGuardiansPath { get; }

	public SnoPower Monk_Passive_Transcendence { get; }

	public SnoPower Monk_Passive_Unity { get; }

	public SnoPower Necromancer_ArmyOfTheDead { get; }

	public SnoPower Necromancer_BloodRush { get; }

	public SnoPower Necromancer_BoneArmor { get; }

	public SnoPower Necromancer_BoneSpear { get; }

	public SnoPower Necromancer_BoneSpikes { get; }

	public SnoPower Necromancer_BoneSpirit { get; }

	public SnoPower Necromancer_CommandGolem { get; }

	public SnoPower Necromancer_CommandSkeletons { get; }

	public SnoPower Necromancer_CorpseExplosion { get; }

	public SnoPower Necromancer_CorpseLance { get; }

	public SnoPower Necromancer_DeathNova { get; }

	public SnoPower Necromancer_Decrepify { get; }

	public SnoPower Necromancer_Devour { get; }

	public SnoPower Necromancer_Frailty { get; }

	public SnoPower Necromancer_GrimScythe { get; }

	public SnoPower Necromancer_LandOfTheDead { get; }

	public SnoPower Necromancer_Leech { get; }

	public SnoPower Necromancer_Revive { get; }

	public SnoPower Necromancer_Simulacrum { get; }

	public SnoPower Necromancer_SiphonBlood { get; }

	public SnoPower Necromancer_SkeletalMage { get; }

	public SnoPower Necromancer_Passive_AberrantAnimator { get; }

	public SnoPower Necromancer_Passive_BloodForBlood { get; }

	public SnoPower Necromancer_Passive_BloodIsPower { get; }

	public SnoPower Necromancer_Passive_BonePrison { get; }

	public SnoPower Necromancer_Passive_CommanderOfTheRisenDead { get; }

	public SnoPower Necromancer_Passive_DarkReaping { get; }

	public SnoPower Necromancer_Passive_DecrepifyPassiveEffect { get; }

	public SnoPower Necromancer_Passive_DrawLife { get; }

	public SnoPower Necromancer_Passive_EternalTorment { get; }

	public SnoPower Necromancer_Passive_ExtendedServitude { get; }

	public SnoPower Necromancer_Passive_FinalService { get; }

	public SnoPower Necromancer_Passive_FrailtyPassiveEffect { get; }

	public SnoPower Necromancer_Passive_FueledByDeath { get; }

	public SnoPower Necromancer_Passive_GrislyTribute { get; }

	public SnoPower Necromancer_Passive_LeechPassiveEffect { get; }

	public SnoPower Necromancer_Passive_LifeFromDeath { get; }

	public SnoPower Necromancer_Passive_OverwhelmingEssence { get; }

	public SnoPower Necromancer_Passive_RathmasShield { get; }

	public SnoPower Necromancer_Passive_RigorMortis { get; }

	public SnoPower Necromancer_Passive_Serration { get; }

	public SnoPower Necromancer_Passive_SpreadingMalediction { get; }

	public SnoPower Necromancer_Passive_StandAlone { get; }

	public SnoPower Necromancer_Passive_SwiftHarvesting { get; }

	public SnoPower WitchDoctor_AcidCloud { get; }

	public SnoPower WitchDoctor_BigBadVoodoo { get; }

	public SnoPower WitchDoctor_CorpseSpider { get; }

	public SnoPower WitchDoctor_FetishArmy { get; }

	public SnoPower WitchDoctor_Firebats { get; }

	public SnoPower WitchDoctor_Firebomb { get; }

	public SnoPower WitchDoctor_Gargantuan { get; }

	public SnoPower WitchDoctor_GraspOfTheDead { get; }

	public SnoPower WitchDoctor_Haunt { get; }

	public SnoPower WitchDoctor_Hex { get; }

	public SnoPower WitchDoctor_Horrify { get; }

	public SnoPower WitchDoctor_LocustSwarm { get; }

	public SnoPower WitchDoctor_MassConfusion { get; }

	public SnoPower WitchDoctor_Piranhas { get; }

	public SnoPower WitchDoctor_PlagueOfToads { get; }

	public SnoPower WitchDoctor_PoisonDart { get; }

	public SnoPower WitchDoctor_Sacrifice { get; }

	public SnoPower WitchDoctor_SoulHarvest { get; }

	public SnoPower WitchDoctor_SpiritBarrage { get; }

	public SnoPower WitchDoctor_SpiritWalk { get; }

	public SnoPower WitchDoctor_SummonZombieDog { get; }

	public SnoPower WitchDoctor_WallOfDeath { get; }

	public SnoPower WitchDoctor_ZombieCharger { get; }

	public SnoPower WitchDoctor_Passive_BadMedicine { get; }

	public SnoPower WitchDoctor_Passive_BloodRitual { get; }

	public SnoPower WitchDoctor_Passive_CircleOfLife { get; }

	public SnoPower WitchDoctor_Passive_ConfidenceRitual { get; }

	public SnoPower WitchDoctor_Passive_CreepingDeath { get; }

	public SnoPower WitchDoctor_Passive_FetishSycophants { get; }

	public SnoPower WitchDoctor_Passive_FierceLoyalty { get; }

	public SnoPower WitchDoctor_Passive_GraveInjustice { get; }

	public SnoPower WitchDoctor_Passive_GruesomeFeast { get; }

	public SnoPower WitchDoctor_Passive_JungleFortitude { get; }

	public SnoPower WitchDoctor_Passive_MidnightFeast { get; }

	public SnoPower WitchDoctor_Passive_PierceTheVeil { get; }

	public SnoPower WitchDoctor_Passive_RushOfEssence { get; }

	public SnoPower WitchDoctor_Passive_SpiritualAttunement { get; }

	public SnoPower WitchDoctor_Passive_SpiritVessel { get; }

	public SnoPower WitchDoctor_Passive_SwamplandAttunement { get; }

	public SnoPower WitchDoctor_Passive_TraitZombieDogSpawner { get; }

	public SnoPower WitchDoctor_Passive_TribalRites { get; }

	public SnoPower WitchDoctor_Passive_VisionQuest { get; }

	public SnoPower WitchDoctor_Passive_ZombieHandler { get; }

	public SnoPower Wizard_ArcaneOrb { get; }

	public SnoPower Wizard_ArcaneTorrent { get; }

	public SnoPower Wizard_Archon { get; }

	public SnoPower Wizard_ArchonArcaneBlast { get; }

	public SnoPower Wizard_ArchonArcaneBlastCold { get; }

	public SnoPower Wizard_ArchonArcaneBlastFire { get; }

	public SnoPower Wizard_ArchonArcaneBlastLightning { get; }

	public SnoPower Wizard_ArchonArcaneStrike { get; }

	public SnoPower Wizard_ArchonArcaneStrikeCold { get; }

	public SnoPower Wizard_ArchonArcaneStrikeFire { get; }

	public SnoPower Wizard_ArchonArcaneStrikeLightning { get; }

	public SnoPower Wizard_ArchonCancel { get; }

	public SnoPower Wizard_ArchonDisintegrationWave { get; }

	public SnoPower Wizard_ArchonDisintegrationWaveCold { get; }

	public SnoPower Wizard_ArchonDisintegrationWaveFire { get; }

	public SnoPower Wizard_ArchonDisintegrationWaveLightning { get; }

	public SnoPower Wizard_ArchonSlowTime { get; }

	public SnoPower Wizard_ArchonTeleport { get; }

	public SnoPower Wizard_BlackHole { get; }

	public SnoPower Wizard_Blizzard { get; }

	public SnoPower Wizard_DiamondSkin { get; }

	public SnoPower Wizard_Disintegrate { get; }

	public SnoPower Wizard_Electrocute { get; }

	public SnoPower Wizard_EnergyArmor { get; }

	public SnoPower Wizard_EnergyTwister { get; }

	public SnoPower Wizard_ExplosiveBlast { get; }

	public SnoPower Wizard_Familiar { get; }

	public SnoPower Wizard_FrostNova { get; }

	public SnoPower Wizard_Hydra { get; }

	public SnoPower Wizard_IceArmor { get; }

	public SnoPower Wizard_MagicMissile { get; }

	public SnoPower Wizard_MagicWeapon { get; }

	public SnoPower Wizard_Meteor { get; }

	public SnoPower Wizard_MirrorImage { get; }

	public SnoPower Wizard_RayOfFrost { get; }

	public SnoPower Wizard_ShockPulse { get; }

	public SnoPower Wizard_SlowTime { get; }

	public SnoPower Wizard_SpectralBlade { get; }

	public SnoPower Wizard_StormArmor { get; }

	public SnoPower Wizard_Teleport { get; }

	public SnoPower Wizard_WaveOfForce { get; }

	public SnoPower Wizard_Passive_ArcaneDynamo { get; }

	public SnoPower Wizard_Passive_AstralPresence { get; }

	public SnoPower Wizard_Passive_Audacity { get; }

	public SnoPower Wizard_Passive_Blur { get; }

	public SnoPower Wizard_Passive_ColdBlooded { get; }

	public SnoPower Wizard_Passive_Conflagration { get; }

	public SnoPower Wizard_Passive_Dominance { get; }

	public SnoPower Wizard_Passive_ElementalExposure { get; }

	public SnoPower Wizard_Passive_Evocation { get; }

	public SnoPower Wizard_Passive_GalvanizingWard { get; }

	public SnoPower Wizard_Passive_GlassCannon { get; }

	public SnoPower Wizard_Passive_Illusionist { get; }

	public SnoPower Wizard_Passive_Paralysis { get; }

	public SnoPower Wizard_Passive_PowerHungry { get; }

	public SnoPower Wizard_Passive_Prodigy { get; }

	public SnoPower Wizard_Passive_TemporalFlux { get; }

	public SnoPower Wizard_Passive_UnstableAnomaly { get; }

	public SnoPower Wizard_Passive_UnwaveringWill { get; }

	public SnoPower BaneOfThePowerfulPrimary => SnoData.Powers.GetBySno(383014u);

	public SnoPower BaneOfThePowerfulSecondary => SnoData.Powers.GetBySno(451157u);

	public SnoPower BaneOfTheStrickenPrimary => SnoData.Powers.GetBySno(428348u);

	public SnoPower BaneOfTheStrickenSecondary => SnoData.Powers.GetBySno(428349u);

	public SnoPower BaneOfTheTrappedPrimary => SnoData.Powers.GetBySno(403456u);

	public SnoPower BaneOfTheTrappedSecondary => SnoData.Powers.GetBySno(403457u);

	public SnoPower BoonOfTheHoarderPrimary => SnoData.Powers.GetBySno(403470u);

	public SnoPower BoonOfTheHoarderSecondary => SnoData.Powers.GetBySno(403784u);

	public SnoPower BoyarskysChipPrimary => SnoData.Powers.GetBySno(428352u);

	public SnoPower BoyarskysChipSecondary => SnoData.Powers.GetBySno(428353u);

	public SnoPower EnforcerPrimary => SnoData.Powers.GetBySno(403466u);

	public SnoPower EnforcerSecondary => SnoData.Powers.GetBySno(403472u);

	public SnoPower EsotericAlterationPrimary => SnoData.Powers.GetBySno(428029u);

	public SnoPower EsotericAlterationSecondary => SnoData.Powers.GetBySno(428030u);

	public SnoPower GemOfEasePrimary => SnoData.Powers.GetBySno(403459u);

	public SnoPower GemOfEaseSecondary => SnoData.Powers.GetBySno(428691u);

	public SnoPower GemOfEfficaciousToxinPrimary => SnoData.Powers.GetBySno(403461u);

	public SnoPower GemOfEfficaciousToxinSecondary => SnoData.Powers.GetBySno(403556u);

	public SnoPower GogokOfSwiftnessPrimary => SnoData.Powers.GetBySno(403464u);

	public SnoPower GogokOfSwiftnessSecondary => SnoData.Powers.GetBySno(403524u);

	public SnoPower IceblinkPrimary => SnoData.Powers.GetBySno(428354u);

	public SnoPower IceblinkSecondary => SnoData.Powers.GetBySno(428356u);

	public SnoPower InvigoratingGemstonePrimary => SnoData.Powers.GetBySno(403465u);

	public SnoPower InvigoratingGemstoneSecondary => SnoData.Powers.GetBySno(403624u);

	public SnoPower LegacyOfDreamsPrimary => SnoData.Powers.GetBySno(483319u);

	public SnoPower LegacyOfDreamsSecondary => SnoData.Powers.GetBySno(483320u);

	public SnoPower MirinaeTeardropOfTheStarweaverPrimary => SnoData.Powers.GetBySno(403463u);

	public SnoPower MirinaeTeardropOfTheStarweaverSecondary => SnoData.Powers.GetBySno(403620u);

	public SnoPower MoltenWildebeestsGizzardPrimary => SnoData.Powers.GetBySno(428031u);

	public SnoPower MoltenWildebeestsGizzardSecondary => SnoData.Powers.GetBySno(428032u);

	public SnoPower MoratoriumPrimary => SnoData.Powers.GetBySno(403467u);

	public SnoPower MoratoriumSecondary => SnoData.Powers.GetBySno(403687u);

	public SnoPower MutilationGuardPrimary => SnoData.Powers.GetBySno(428350u);

	public SnoPower MutilationGuardSecondary => SnoData.Powers.GetBySno(428351u);

	public SnoPower PainEnhancerPrimary => SnoData.Powers.GetBySno(403462u);

	public SnoPower PainEnhancerSecondary => SnoData.Powers.GetBySno(403600u);

	public SnoPower RedSoulShardPrimary => SnoData.Powers.GetBySno(454736u);

	public SnoPower RedSoulShardSecondary => SnoData.Powers.GetBySno(454737u);

	public SnoPower SimplicitysStrengthPrimary => SnoData.Powers.GetBySno(403469u);

	public SnoPower SimplicitysStrengthSecondary => SnoData.Powers.GetBySno(403473u);

	public SnoPower TaegukPrimary => SnoData.Powers.GetBySno(403471u);

	public SnoPower TaegukSecondary => SnoData.Powers.GetBySno(403785u);

	public SnoPower WreathOfLightningPrimary => SnoData.Powers.GetBySno(403460u);

	public SnoPower WreathOfLightningSecondary => SnoData.Powers.GetBySno(403560u);

	public SnoPower ZeisStoneOfVengeancePrimary => SnoData.Powers.GetBySno(403468u);

	public SnoPower ZeisStoneOfVengeanceSecondary => SnoData.Powers.GetBySno(403727u);

	public SnoPower AetherWalker => SnoData.Powers.GetBySno(397788u);

	public SnoPower AhavarionSpearOfLycander => SnoData.Powers.GetBySno(318868u);

	public SnoPower AkaratsAwakening => SnoData.Powers.GetBySno(318888u);

	public SnoPower AkkhansAddendum => SnoData.Powers.GetBySno(445943u);

	public SnoPower AkkhansLeniency => SnoData.Powers.GetBySno(488910u);

	public SnoPower AkkhansManacles => SnoData.Powers.GetBySno(446008u);

	public SnoPower AmbosPride => SnoData.Powers.GetBySno(483675u);

	public SnoPower AncestorsGrace => SnoData.Powers.GetBySno(318378u);

	public SnoPower AncientParthanDefenders => SnoData.Powers.GetBySno(318770u);

	public SnoPower AndarielsVisage => SnoData.Powers.GetBySno(434034u);

	public SnoPower AnessaziEdge => SnoData.Powers.GetBySno(318720u);

	public SnoPower AngelHairBraid => SnoData.Powers.GetBySno(402415u);

	public SnoPower AquilaCuirass => SnoData.Powers.GetBySno(449064u);

	public SnoPower ArchmagesVicalyke => SnoData.Powers.GetBySno(318777u);

	public SnoPower Arcstone => SnoData.Powers.GetBySno(359598u);

	public SnoPower ArmorOfTheKindRegent => SnoData.Powers.GetBySno(318892u);

	public SnoPower ArreatsLaw => SnoData.Powers.GetBySno(486951u);

	public SnoPower ArthefsSparkOfLife => SnoData.Powers.GetBySno(318757u);

	public SnoPower AshnagarrsBloodBracer => SnoData.Powers.GetBySno(449043u);

	public SnoPower AugustinesPanacea => SnoData.Powers.GetBySno(451169u);

	public SnoPower Azurewrath => SnoData.Powers.GetBySno(441723u);

	public SnoPower BakuliJungleWraps => SnoData.Powers.GetBySno(451163u);

	public SnoPower Balance => SnoData.Powers.GetBySno(478475u);

	public SnoPower BalefulRemnant => SnoData.Powers.GetBySno(359545u);

	public SnoPower BandOfHollowWhispers => SnoData.Powers.GetBySno(364345u);

	public SnoPower BandOfMight => SnoData.Powers.GetBySno(447060u);

	public SnoPower BandOfTheRueChambers => SnoData.Powers.GetBySno(318434u);

	public SnoPower BastionsRevered => SnoData.Powers.GetBySno(484244u);

	public SnoPower BeckonSail => SnoData.Powers.GetBySno(318420u);

	public SnoPower BeltOfTheTrove => SnoData.Powers.GetBySno(484602u);

	public SnoPower BeltOfTranscendence => SnoData.Powers.GetBySno(430671u);

	public SnoPower BindingOfTheLost => SnoData.Powers.GetBySno(440598u);

	public SnoPower BindingsOfTheLesserGods => SnoData.Powers.GetBySno(485725u);

	public SnoPower Blackfeather => SnoData.Powers.GetBySno(318882u);

	public SnoPower BladeOfProphecy => SnoData.Powers.GetBySno(478476u);

	public SnoPower BladeOfTheTribes => SnoData.Powers.GetBySno(484604u);

	public SnoPower BladeOfTheWarlord => SnoData.Powers.GetBySno(447375u);

	public SnoPower BlessedOfHaull => SnoData.Powers.GetBySno(430681u);

	public SnoPower BloodBrother => SnoData.Powers.GetBySno(402456u);

	public SnoPower BloodsongMail => SnoData.Powers.GetBySno(476585u);

	public SnoPower BloodtideBlade => SnoData.Powers.GetBySno(475251u);

	public SnoPower BombardiersRucksack => SnoData.Powers.GetBySno(486306u);

	public SnoPower BondsOfCLena => SnoData.Powers.GetBySno(485504u);

	public SnoPower BoneRinger => SnoData.Powers.GetBySno(476584u);

	public SnoPower BottomlessPotionOfAmplification => SnoData.Powers.GetBySno(434626u);

	public SnoPower BottomlessPotionOfChaos => SnoData.Powers.GetBySno(451310u);

	public SnoPower BottomlessPotionOfFear => SnoData.Powers.GetBySno(428812u);

	public SnoPower BottomlessPotionOfKulleAid => SnoData.Powers.GetBySno(344094u);

	public SnoPower BottomlessPotionOfRejuvenation => SnoData.Powers.GetBySno(433021u);

	public SnoPower BottomlessPotionOfTheUnfettered => SnoData.Powers.GetBySno(483315u);

	public SnoPower BovineBardiche => SnoData.Powers.GetBySno(318382u);

	public SnoPower BracerOfFury => SnoData.Powers.GetBySno(446162u);

	public SnoPower BracersOfDestruction => SnoData.Powers.GetBySno(483847u);

	public SnoPower BracersOfTheFirstMen => SnoData.Powers.GetBySno(441279u);

	public SnoPower BriggsWrath => SnoData.Powers.GetBySno(475252u);

	public SnoPower BrokenCrown => SnoData.Powers.GetBySno(423231u);

	public SnoPower BrokenPromises => SnoData.Powers.GetBySno(402462u);

	public SnoPower BrynersJourney => SnoData.Powers.GetBySno(475245u);

	public SnoPower BulKathossWeddingBand => SnoData.Powers.GetBySno(364340u);

	public SnoPower BurizaDoKyanon => SnoData.Powers.GetBySno(374344u);

	public SnoPower ButchersCarver => SnoData.Powers.GetBySno(246118u);

	public SnoPower Calamity => SnoData.Powers.GetBySno(318360u);

	public SnoPower CamsRebuttal => SnoData.Powers.GetBySno(318358u);

	public SnoPower CapeOfTheDarkNight => SnoData.Powers.GetBySno(318421u);

	public SnoPower Carnevil => SnoData.Powers.GetBySno(483481u);

	public SnoPower CesarsMemento => SnoData.Powers.GetBySno(449031u);

	public SnoPower Chaingmail => SnoData.Powers.GetBySno(318798u);

	public SnoPower ChainOfShadows => SnoData.Powers.GetBySno(445266u);

	public SnoPower ChanonBolter => SnoData.Powers.GetBySno(488010u);

	public SnoPower ChilaniksChain => SnoData.Powers.GetBySno(318821u);

	public SnoPower Cindercoat => SnoData.Powers.GetBySno(318790u);

	public SnoPower CircleOfNailujsEvol => SnoData.Powers.GetBySno(475247u);

	public SnoPower Cluckeye => SnoData.Powers.GetBySno(488809u);

	public SnoPower CoilsOfTheFirstSpider => SnoData.Powers.GetBySno(440790u);

	public SnoPower ConventionOfElements => SnoData.Powers.GetBySno(430674u);

	public SnoPower CordOfTheSherma => SnoData.Powers.GetBySno(434008u);

	public SnoPower CorpsewhisperPauldrons => SnoData.Powers.GetBySno(476580u);

	public SnoPower CorruptedAshbringer => SnoData.Powers.GetBySno(402455u);

	public SnoPower CountessJuliasCameo => SnoData.Powers.GetBySno(318381u);

	public SnoPower CrashingRain => SnoData.Powers.GetBySno(359554u);

	public SnoPower CrownOfThePrimus => SnoData.Powers.GetBySno(487653u);

	public SnoPower CrystalFist => SnoData.Powers.GetBySno(451170u);

	public SnoPower CusterianWristguards => SnoData.Powers.GetBySno(359557u);

	public SnoPower DanettasRevenge => SnoData.Powers.GetBySno(318813u);

	public SnoPower DanettasSpite => SnoData.Powers.GetBySno(318348u);

	public SnoPower Darklight => SnoData.Powers.GetBySno(483790u);

	public SnoPower DarkMagesShade => SnoData.Powers.GetBySno(318788u);

	public SnoPower Dawn => SnoData.Powers.GetBySno(446146u);

	public SnoPower DaynteesBinding => SnoData.Powers.GetBySno(478534u);

	public SnoPower DeadlyRebirth => SnoData.Powers.GetBySno(318808u);

	public SnoPower DeadMansLegacy => SnoData.Powers.GetBySno(478486u);

	public SnoPower DeathseersCowl => SnoData.Powers.GetBySno(318857u);

	public SnoPower DeathWatchMantle => SnoData.Powers.GetBySno(434005u);

	public SnoPower Deathwish => SnoData.Powers.GetBySno(449063u);

	public SnoPower DefenderOfWestmarch => SnoData.Powers.GetBySno(434004u);

	public SnoPower DefilerCuisses => SnoData.Powers.GetBySno(485506u);

	public SnoPower DemonMachine => SnoData.Powers.GetBySno(364332u);

	public SnoPower Denial => SnoData.Powers.GetBySno(435016u);

	public SnoPower DepthDiggers => SnoData.Powers.GetBySno(402416u);

	public SnoPower DishonoredLegacy => SnoData.Powers.GetBySno(441294u);

	public SnoPower DovuEnergyTrap => SnoData.Powers.GetBySno(318867u);

	public SnoPower DrakonsLesson => SnoData.Powers.GetBySno(430678u);

	public SnoPower DreadIron => SnoData.Powers.GetBySno(430679u);

	public SnoPower EberliCharo => SnoData.Powers.GetBySno(318853u);

	public SnoPower EchoingFury => SnoData.Powers.GetBySno(483518u);

	public SnoPower ElusiveRing => SnoData.Powers.GetBySno(446187u);

	public SnoPower EmimeisDuffel => SnoData.Powers.GetBySno(484294u);

	public SnoPower EnchantingFavor => SnoData.Powers.GetBySno(318835u);

	public SnoPower EtchedSigil => SnoData.Powers.GetBySno(484596u);

	public SnoPower EternalUnion => SnoData.Powers.GetBySno(487798u);

	public SnoPower Eunjangdo => SnoData.Powers.GetBySno(402457u);

	public SnoPower EyeOfPeshkov => SnoData.Powers.GetBySno(318431u);

	public SnoPower FaithfulMemory => SnoData.Powers.GetBySno(454927u);

	public SnoPower FateOfTheFell => SnoData.Powers.GetBySno(478478u);

	public SnoPower FatesVow => SnoData.Powers.GetBySno(478508u);

	public SnoPower FazulasImprobableChain => SnoData.Powers.GetBySno(437854u);

	public SnoPower FireWalkers => SnoData.Powers.GetBySno(434010u);

	public SnoPower FjordCutter => SnoData.Powers.GetBySno(483848u);

	public SnoPower FlailOfTheAscended => SnoData.Powers.GetBySno(451164u);

	public SnoPower Fleshrake => SnoData.Powers.GetBySno(451168u);

	public SnoPower FlyingDragon => SnoData.Powers.GetBySno(246562u);

	public SnoPower FortressBallista => SnoData.Powers.GetBySno(447816u);

	public SnoPower FragmentOfDestiny => SnoData.Powers.GetBySno(484599u);

	public SnoPower FreezeOfDeflection => SnoData.Powers.GetBySno(318816u);

	public SnoPower Frostburn => SnoData.Powers.GetBySno(451167u);

	public SnoPower FrydehrsWrath => SnoData.Powers.GetBySno(478477u);

	public SnoPower Fulminator => SnoData.Powers.GetBySno(441681u);

	public SnoPower FuneraryPick => SnoData.Powers.GetBySno(487651u);

	public SnoPower FuryOfTheAncients => SnoData.Powers.GetBySno(483849u);

	public SnoPower FuryOfTheVanishedPeak => SnoData.Powers.GetBySno(478489u);

	public SnoPower GabrielsVambraces => SnoData.Powers.GetBySno(436521u);

	public SnoPower GazingDemise => SnoData.Powers.GetBySno(484270u);

	public SnoPower GelmindorsMarrowGuards => SnoData.Powers.GetBySno(484588u);

	public SnoPower Genzaniku => SnoData.Powers.GetBySno(364311u);

	public SnoPower GestureOfOrpheus => SnoData.Powers.GetBySno(318376u);

	public SnoPower GirdleOfGiants => SnoData.Powers.GetBySno(451237u);

	public SnoPower GladiatorGauntlets => SnoData.Powers.GetBySno(318799u);

	public SnoPower GoldenFlense => SnoData.Powers.GetBySno(478537u);

	public SnoPower Goldskin => SnoData.Powers.GetBySno(246515u);

	public SnoPower Goldwrap => SnoData.Powers.GetBySno(318875u);

	public SnoPower GolemskinBreeches => SnoData.Powers.GetBySno(478510u);

	public SnoPower GraspsOfEssence => SnoData.Powers.GetBySno(484310u);

	public SnoPower GuardOfJohanna => SnoData.Powers.GetBySno(436481u);

	public SnoPower GungdoGear => SnoData.Powers.GetBySno(484605u);

	public SnoPower GyanaNaKashu => SnoData.Powers.GetBySno(318426u);

	public SnoPower GyrfalconsFoote => SnoData.Powers.GetBySno(478513u);

	public SnoPower Hack => SnoData.Powers.GetBySno(318869u);

	public SnoPower HallowedBulwark => SnoData.Powers.GetBySno(318887u);

	public SnoPower HaloOfArlyse => SnoData.Powers.GetBySno(429648u);

	public SnoPower HaloOfKarini => SnoData.Powers.GetBySno(478538u);

	public SnoPower HammerJammers => SnoData.Powers.GetBySno(446502u);

	public SnoPower HandOfTheProphet => SnoData.Powers.GetBySno(318377u);

	public SnoPower HarringtonWaistguard => SnoData.Powers.GetBySno(318881u);

	public SnoPower HauntedVisions => SnoData.Powers.GetBySno(484309u);

	public SnoPower HauntingGirdle => SnoData.Powers.GetBySno(434966u);

	public SnoPower HauntOfVaxo => SnoData.Powers.GetBySno(318782u);

	public SnoPower HeartOfIron => SnoData.Powers.GetBySno(446615u);

	public SnoPower HellcatWaistguard => SnoData.Powers.GetBySno(454934u);

	public SnoPower Hellrack => SnoData.Powers.GetBySno(247577u);

	public SnoPower Hellskull => SnoData.Powers.GetBySno(318891u);

	public SnoPower HenrisPerquisition => SnoData.Powers.GetBySno(440457u);

	public SnoPower HergbrashsBinding => SnoData.Powers.GetBySno(449048u);

	public SnoPower HexingPantsOfMrYan => SnoData.Powers.GetBySno(318817u);

	public SnoPower HillenbrandsTrainingSword => SnoData.Powers.GetBySno(359604u);

	public SnoPower HolyPointShot => SnoData.Powers.GetBySno(484313u);

	public SnoPower HomingPads => SnoData.Powers.GetBySno(318801u);

	public SnoPower Homunculus => SnoData.Powers.GetBySno(374670u);

	public SnoPower HuntersWrath => SnoData.Powers.GetBySno(440743u);

	public SnoPower HwojWrap => SnoData.Powers.GetBySno(318800u);

	public SnoPower IceClimbers => SnoData.Powers.GetBySno(318741u);

	public SnoPower IncenseTorchOfTheGrandTemple => SnoData.Powers.GetBySno(478473u);

	public SnoPower Ingeom => SnoData.Powers.GetBySno(402458u);

	public SnoPower InviolableFaith => SnoData.Powers.GetBySno(318894u);

	public SnoPower IronRose => SnoData.Powers.GetBySno(487652u);

	public SnoPower IrontoeMudsputters => SnoData.Powers.GetBySno(318877u);

	public SnoPower IvoryTower => SnoData.Powers.GetBySno(430683u);

	public SnoPower JacesHammerOfVigilance => SnoData.Powers.GetBySno(318851u);

	public SnoPower JangsEnvelopment => SnoData.Powers.GetBySno(318795u);

	public SnoPower Jawbreaker => SnoData.Powers.GetBySno(318432u);

	public SnoPower Jekangbord => SnoData.Powers.GetBySno(478514u);

	public SnoPower JeramsBracers => SnoData.Powers.GetBySno(441278u);

	public SnoPower JohannasArgument => SnoData.Powers.GetBySno(436430u);

	public SnoPower JusticeLantern => SnoData.Powers.GetBySno(446565u);

	public SnoPower JustiniansMercy => SnoData.Powers.GetBySno(318895u);

	public SnoPower KarleisPoint => SnoData.Powers.GetBySno(478484u);

	public SnoPower KassarsRetribution => SnoData.Powers.GetBySno(359538u);

	public SnoPower KekegisUnbreakableSpirit => SnoData.Powers.GetBySno(318751u);

	public SnoPower KhassettsCordOfRighteousness => SnoData.Powers.GetBySno(451238u);

	public SnoPower KmarTenclip => SnoData.Powers.GetBySno(318423u);

	public SnoPower KredesFlame => SnoData.Powers.GetBySno(318865u);

	public SnoPower KrelmsBuffBelt => SnoData.Powers.GetBySno(359602u);

	public SnoPower KrelmsBuffBracers => SnoData.Powers.GetBySno(359591u);

	public SnoPower Kridershot => SnoData.Powers.GetBySno(318379u);

	public SnoPower KrysbinsSentence => SnoData.Powers.GetBySno(475241u);

	public SnoPower KymbosGold => SnoData.Powers.GetBySno(359597u);

	public SnoPower KyoshirosBlade => SnoData.Powers.GetBySno(447368u);

	public SnoPower KyoshirosSoul => SnoData.Powers.GetBySno(447130u);

	public SnoPower LakumbasOrnament => SnoData.Powers.GetBySno(486131u);

	public SnoPower Lamentation => SnoData.Powers.GetBySno(483792u);

	public SnoPower LastBreath => SnoData.Powers.GetBySno(447030u);

	public SnoPower LefebvresSoliloquy => SnoData.Powers.GetBySno(449236u);

	public SnoPower LegersDisdain => SnoData.Powers.GetBySno(476696u);

	public SnoPower LeonineBowOfHashir => SnoData.Powers.GetBySno(484293u);

	public SnoPower LiannasWings => SnoData.Powers.GetBySno(447696u);

	public SnoPower LightOfGrace => SnoData.Powers.GetBySno(318855u);

	public SnoPower LionsClaw => SnoData.Powers.GetBySno(402451u);

	public SnoPower LordGreenstonesFan => SnoData.Powers.GetBySno(445274u);

	public SnoPower LornellesSunstone => SnoData.Powers.GetBySno(475244u);

	public SnoPower LostTime => SnoData.Powers.GetBySno(476684u);

	public SnoPower LutSocks => SnoData.Powers.GetBySno(318810u);

	public SnoPower MadawcsSorrow => SnoData.Powers.GetBySno(318744u);

	public SnoPower Madstone => SnoData.Powers.GetBySno(402540u);

	public SnoPower Magefist => SnoData.Powers.GetBySno(451166u);

	public SnoPower MalothsFocus => SnoData.Powers.GetBySno(246780u);

	public SnoPower MaltoriusPetrifiedSpike => SnoData.Powers.GetBySno(475246u);

	public SnoPower ManaldHeal => SnoData.Powers.GetBySno(454930u);

	public SnoPower Manticore => SnoData.Powers.GetBySno(478483u);

	public SnoPower MantleOfChanneling => SnoData.Powers.GetBySno(446640u);

	public SnoPower MarasKaleidoscope => SnoData.Powers.GetBySno(318719u);

	public SnoPower MaskOfJeram => SnoData.Powers.GetBySno(318411u);

	public SnoPower MaskOfScarletDeath => SnoData.Powers.GetBySno(476581u);

	public SnoPower Maximus => SnoData.Powers.GetBySno(364317u);

	public SnoPower MesserschmidtsReaver => SnoData.Powers.GetBySno(483522u);

	public SnoPower Mirrorball => SnoData.Powers.GetBySno(487928u);

	public SnoPower MoonlightWard => SnoData.Powers.GetBySno(364343u);

	public SnoPower MordullusPromise => SnoData.Powers.GetBySno(447029u);

	public SnoPower MoribundGauntlets => SnoData.Powers.GetBySno(476589u);

	public SnoPower MorticksBrace => SnoData.Powers.GetBySno(430135u);

	public SnoPower MykensBallOfHate => SnoData.Powers.GetBySno(318775u);

	public SnoPower Nagelring => SnoData.Powers.GetBySno(402460u);

	public SnoPower NayrsBlackDeath => SnoData.Powers.GetBySno(476587u);

	public SnoPower NemesisBracers => SnoData.Powers.GetBySno(318820u);

	public SnoPower NilfursBoast => SnoData.Powers.GetBySno(478554u);

	public SnoPower Oathkeeper => SnoData.Powers.GetBySno(447372u);

	public SnoPower ObsidianRingOfTheZodiac => SnoData.Powers.GetBySno(402459u);

	public SnoPower OculusRing => SnoData.Powers.GetBySno(402461u);

	public SnoPower OdynSon => SnoData.Powers.GetBySno(364325u);

	public SnoPower OdysseysEnd => SnoData.Powers.GetBySno(484297u);

	public SnoPower Omnislash => SnoData.Powers.GetBySno(430682u);

	public SnoPower OmrynsChain => SnoData.Powers.GetBySno(423229u);

	public SnoPower OrbOfInfiniteDepth => SnoData.Powers.GetBySno(478481u);

	public SnoPower PigSticker => SnoData.Powers.GetBySno(245836u);

	public SnoPower PintosPride => SnoData.Powers.GetBySno(447295u);

	public SnoPower PoxFaulds => SnoData.Powers.GetBySno(434009u);

	public SnoPower PrideOfCassius => SnoData.Powers.GetBySno(318419u);

	public SnoPower PrimordialSoul => SnoData.Powers.GetBySno(448998u);

	public SnoPower PromiseOfGlory => SnoData.Powers.GetBySno(318871u);

	public SnoPower PusSpitter => SnoData.Powers.GetBySno(364335u);

	public SnoPower PuzzleRing => SnoData.Powers.GetBySno(318375u);

	public SnoPower Quetzalcoatl => SnoData.Powers.GetBySno(318796u);

	public SnoPower RabidStrike => SnoData.Powers.GetBySno(486099u);

	public SnoPower RakoffsGlassOfLife => SnoData.Powers.GetBySno(318410u);

	public SnoPower RanslorsFolly => SnoData.Powers.GetBySno(478491u);

	public SnoPower RazethsVolition => SnoData.Powers.GetBySno(484311u);

	public SnoPower RazorStrop => SnoData.Powers.GetBySno(318241u);

	public SnoPower RechelsRingOfLarceny => SnoData.Powers.GetBySno(318870u);

	public SnoPower ReilenasShadowhook => SnoData.Powers.GetBySno(475253u);

	public SnoPower RelicOfAkarat => SnoData.Powers.GetBySno(318377u);

	public SnoPower Remorseless => SnoData.Powers.GetBySno(483793u);

	public SnoPower RequiemCereplate => SnoData.Powers.GetBySno(476579u);

	public SnoPower RhenhoFlayer => SnoData.Powers.GetBySno(318812u);

	public SnoPower RibaldEtchings => SnoData.Powers.GetBySno(318377u);

	public SnoPower Rimeheart => SnoData.Powers.GetBySno(318864u);

	public SnoPower RingOfEmptiness => SnoData.Powers.GetBySno(445694u);

	public SnoPower RiveraDancers => SnoData.Powers.GetBySno(447043u);

	public SnoPower RogarsHugeStone => SnoData.Powers.GetBySno(318861u);

	public SnoPower SacredHarness => SnoData.Powers.GetBySno(440434u);

	public SnoPower SacredHarvester => SnoData.Powers.GetBySno(410217u);

	public SnoPower SaffronWrap => SnoData.Powers.GetBySno(454918u);

	public SnoPower SashOfKnives => SnoData.Powers.GetBySno(434038u);

	public SnoPower Scarbringer => SnoData.Powers.GetBySno(478474u);

	public SnoPower SchaefersHammer => SnoData.Powers.GetBySno(434033u);

	public SnoPower Scourge => SnoData.Powers.GetBySno(364321u);

	public SnoPower Scrimshaw => SnoData.Powers.GetBySno(484603u);

	public SnoPower ScytheOfTheCycle => SnoData.Powers.GetBySno(476586u);

	public SnoPower SeborsNightmare => SnoData.Powers.GetBySno(434039u);

	public SnoPower SerpentsSparker => SnoData.Powers.GetBySno(484117u);

	public SnoPower Sever => SnoData.Powers.GetBySno(249967u);

	public SnoPower ShardOfHate => SnoData.Powers.GetBySno(359587u);

	public SnoPower ShieldOfFury => SnoData.Powers.GetBySno(446142u);

	public SnoPower ShiMizusHaori => SnoData.Powers.GetBySno(318779u);

	public SnoPower ShukranisTriumph => SnoData.Powers.GetBySno(486132u);

	public SnoPower SinSeekers => SnoData.Powers.GetBySno(483505u);

	public SnoPower SkeletonKey => SnoData.Powers.GetBySno(318835u);

	public SnoPower SkularsSalvation => SnoData.Powers.GetBySno(486949u);

	public SnoPower SkullGrasp => SnoData.Powers.GetBySno(451160u);

	public SnoPower SkullOfResonance => SnoData.Powers.GetBySno(318773u);

	public SnoPower Skycutter => SnoData.Powers.GetBySno(364315u);

	public SnoPower SkySplitter => SnoData.Powers.GetBySno(433993u);

	public SnoPower Skywarden => SnoData.Powers.GetBySno(359550u);

	public SnoPower SlipkasLetterOpener => SnoData.Powers.GetBySno(359604u);

	public SnoPower SloraksMadness => SnoData.Powers.GetBySno(248686u);

	public SnoPower SmokingThurible => SnoData.Powers.GetBySno(318835u);

	public SnoPower Solanium => SnoData.Powers.GetBySno(318873u);

	public SnoPower SpauldersOfZakara => SnoData.Powers.GetBySno(318858u);

	public SnoPower SpearOfJairo => SnoData.Powers.GetBySno(475254u);

	public SnoPower SpinesOfSeethingHatred => SnoData.Powers.GetBySno(359606u);

	public SnoPower SpiritGuards => SnoData.Powers.GetBySno(430289u);

	public SnoPower SquirtsNecklace => SnoData.Powers.GetBySno(483552u);

	public SnoPower StaffOfChiroptera => SnoData.Powers.GetBySno(478487u);

	public SnoPower StalgardsDecimator => SnoData.Powers.GetBySno(318412u);

	public SnoPower Standoff => SnoData.Powers.GetBySno(446592u);

	public SnoPower StArchewsGage => SnoData.Powers.GetBySno(434007u);

	public SnoPower Starfire => SnoData.Powers.GetBySno(451242u);

	public SnoPower StarmetalKukri => SnoData.Powers.GetBySno(318724u);

	public SnoPower SteuartsGreaves => SnoData.Powers.GetBySno(475243u);

	public SnoPower StoneGauntlets => SnoData.Powers.GetBySno(483519u);

	public SnoPower StoneOfJordan => SnoData.Powers.GetBySno(484282u);

	public SnoPower StormCrow => SnoData.Powers.GetBySno(364338u);

	public SnoPower StringOfEars => SnoData.Powers.GetBySno(446541u);

	public SnoPower StrongarmBracers => SnoData.Powers.GetBySno(318772u);

	public SnoPower SublimeConviction => SnoData.Powers.GetBySno(318890u);

	public SnoPower SuWongDiviner => SnoData.Powers.GetBySno(442478u);

	public SnoPower SwampLandWaders => SnoData.Powers.GetBySno(451161u);

	public SnoPower Swiftmount => SnoData.Powers.GetBySno(359537u);

	public SnoPower SwordOfIllWill => SnoData.Powers.GetBySno(446641u);

	public SnoPower TalismanOfAranoch => SnoData.Powers.GetBySno(318715u);

	public SnoPower TaskerandTheo => SnoData.Powers.GetBySno(318731u);

	public SnoPower TheBarber => SnoData.Powers.GetBySno(454932u);

	public SnoPower TheBurningAxeOfSankis => SnoData.Powers.GetBySno(246113u);

	public SnoPower TheButchersSickle => SnoData.Powers.GetBySno(248484u);

	public SnoPower TheCloakOfTheGarwulf => SnoData.Powers.GetBySno(318300u);

	public SnoPower TheCrudestBoots => SnoData.Powers.GetBySno(485724u);

	public SnoPower TheDaggerOfDarts => SnoData.Powers.GetBySno(483400u);

	public SnoPower TheDemonsDemise => SnoData.Powers.GetBySno(488008u);

	public SnoPower TheEssOfJohan => SnoData.Powers.GetBySno(318759u);

	public SnoPower TheExecutioner => SnoData.Powers.GetBySno(483516u);

	public SnoPower TheFinalWitness => SnoData.Powers.GetBySno(318884u);

	public SnoPower TheFistOfAzTurrasq => SnoData.Powers.GetBySno(318433u);

	public SnoPower TheFlavorOfTime => SnoData.Powers.GetBySno(483515u);

	public SnoPower TheFlowOfEternity => SnoData.Powers.GetBySno(451162u);

	public SnoPower TheFurnace => SnoData.Powers.GetBySno(318753u);

	public SnoPower TheGavelOfJudgment => SnoData.Powers.GetBySno(478490u);

	public SnoPower TheGidbinn => SnoData.Powers.GetBySno(364316u);

	public SnoPower TheGrandVizier => SnoData.Powers.GetBySno(478553u);

	public SnoPower TheGrinReaper => SnoData.Powers.GetBySno(251572u);

	public SnoPower TheJohnstone => SnoData.Powers.GetBySno(476583u);

	public SnoPower TheLawsOfSeph => SnoData.Powers.GetBySno(318428u);

	public SnoPower TheMagistrate => SnoData.Powers.GetBySno(484116u);

	public SnoPower TheMindsEye => SnoData.Powers.GetBySno(318824u);

	public SnoPower TheMortalDrama => SnoData.Powers.GetBySno(484601u);

	public SnoPower TheNinthCirriSatchel => SnoData.Powers.GetBySno(484295u);

	public SnoPower TheOculus => SnoData.Powers.GetBySno(374308u);

	public SnoPower ThePaddle => SnoData.Powers.GetBySno(247777u);

	public SnoPower TheRavensWing => SnoData.Powers.GetBySno(375037u);

	public SnoPower TheShameOfDelsere => SnoData.Powers.GetBySno(445427u);

	public SnoPower TheShortMansFinger => SnoData.Powers.GetBySno(478488u);

	public SnoPower TheSmolderingCore => SnoData.Powers.GetBySno(487677u);

	public SnoPower TheSpiderQueensGrasp => SnoData.Powers.GetBySno(486133u);

	public SnoPower TheStarOfAzkaranth => SnoData.Powers.GetBySno(318716u);

	public SnoPower TheSwami => SnoData.Powers.GetBySno(440336u);

	public SnoPower TheTallMansFinger => SnoData.Powers.GetBySno(318806u);

	public SnoPower TheThreeHundredthSpear => SnoData.Powers.GetBySno(487304u);

	public SnoPower TheTormentor => SnoData.Powers.GetBySno(247572u);

	public SnoPower TheTwistedSword => SnoData.Powers.GetBySno(484709u);

	public SnoPower TheUndisputedChampion => SnoData.Powers.GetBySno(484245u);

	public SnoPower ThingOfTheDeep => SnoData.Powers.GetBySno(446359u);

	public SnoPower ThunderfuryBlessedBladeOfTheWindseeker => SnoData.Powers.GetBySno(318763u);

	public SnoPower ThundergodsVigor => SnoData.Powers.GetBySno(364341u);

	public SnoPower TiklandianVisage => SnoData.Powers.GetBySno(318774u);

	public SnoPower TragOulCoils => SnoData.Powers.GetBySno(488009u);

	public SnoPower TragOulsCorrodedFang => SnoData.Powers.GetBySno(475250u);

	public SnoPower Triumvirate => SnoData.Powers.GetBySno(434849u);

	public SnoPower TzoKrinsGaze => SnoData.Powers.GetBySno(318811u);

	public SnoPower UhkapianSerpent => SnoData.Powers.GetBySno(318721u);

	public SnoPower Unity => SnoData.Powers.GetBySno(318769u);

	public SnoPower UnrelentingPhalanx => SnoData.Powers.GetBySno(402444u);

	public SnoPower UnstableScepter => SnoData.Powers.GetBySno(478479u);

	public SnoPower UrsuasTroddenEffigy => SnoData.Powers.GetBySno(484655u);

	public SnoPower VadimsSurge => SnoData.Powers.GetBySno(359604u);

	public SnoPower VallasBequest => SnoData.Powers.GetBySno(436472u);

	public SnoPower ValtheksRebuke => SnoData.Powers.GetBySno(484597u);

	public SnoPower VambracesOfSescheron => SnoData.Powers.GetBySno(447839u);

	public SnoPower VelvetCamaral => SnoData.Powers.GetBySno(318740u);

	public SnoPower VengefulWind => SnoData.Powers.GetBySno(483791u);

	public SnoPower Vigilance => SnoData.Powers.GetBySno(367008u);

	public SnoPower VileHive => SnoData.Powers.GetBySno(445765u);

	public SnoPower VileWard => SnoData.Powers.GetBySno(397783u);

	public SnoPower VisageOfGiyua => SnoData.Powers.GetBySno(318385u);

	public SnoPower VisageOfGunes => SnoData.Powers.GetBySno(446655u);

	public SnoPower VoosJuicer => SnoData.Powers.GetBySno(446969u);

	public SnoPower VoToyiasSpiker => SnoData.Powers.GetBySno(318886u);

	public SnoPower WandOfWoh => SnoData.Powers.GetBySno(478480u);

	public SnoPower WarhelmOfKassar => SnoData.Powers.GetBySno(449049u);

	public SnoPower WarstaffOfGeneralQuang => SnoData.Powers.GetBySno(318430u);

	public SnoPower WarzechianArmguards => SnoData.Powers.GetBySno(318771u);

	public SnoPower WilkensReach => SnoData.Powers.GetBySno(447843u);

	public SnoPower WinterFlurry => SnoData.Powers.GetBySno(484598u);

	public SnoPower WisdomOfKalan => SnoData.Powers.GetBySno(476686u);

	public SnoPower Wizardspike => SnoData.Powers.GetBySno(484600u);

	public SnoPower WojahnniAssaulter => SnoData.Powers.GetBySno(483506u);

	public SnoPower WonKhimLau => SnoData.Powers.GetBySno(484106u);

	public SnoPower Wormwood => SnoData.Powers.GetBySno(423238u);

	public SnoPower WrapsOfClarity => SnoData.Powers.GetBySno(441517u);

	public SnoPower Wyrdward => SnoData.Powers.GetBySno(434036u);

	public SnoPower XephirianAmulet => SnoData.Powers.GetBySno(318718u);

	public SnoPower YangsRecurve => SnoData.Powers.GetBySno(478485u);

	public SnoPower ZoeysSecret => SnoData.Powers.GetBySno(446639u);

	public SnoPower Generic_1000MonsterFightMeteor { get; }

	public SnoPower Generic_a1dunLeorBigFireGrate { get; }

	public SnoPower Generic_a1dunLeorFireGutterfire { get; }

	public SnoPower Generic_a1dunLeorHallwayBladeTrap { get; }

	public SnoPower Generic_a1dunleoricfireTrench { get; }

	public SnoPower Generic_a1dunleoricfireTrench01 { get; }

	public SnoPower Generic_a1dunleoricfireTrench02 { get; }

	public SnoPower Generic_a2dunAqdActWoodPlatformDamage { get; }

	public SnoPower Generic_a2dunCaveGoatmenDroppingLogTrapattack { get; }

	public SnoPower Generic_a2dunCaveLarva { get; }

	public SnoPower Generic_a2dunCaveLarvaAOE { get; }

	public SnoPower Generic_a2dunCaveSlimeGeyserA { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerColdspawnAttack { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerFire { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerFirespawnAttack { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerIceNova { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerLightningpewpew { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerLightningspawnAttack { get; }

	public SnoPower Generic_a2dunZoltTeslaTowerPoisonspawnAttack { get; }

	public SnoPower Generic_A2EvacuationBelialBomb { get; }

	public SnoPower Generic_a3battlefielddemonicforge { get; }

	public SnoPower Generic_A3BattlefieldDemonMineAOE { get; }

	public SnoPower Generic_a3dunbastionKeepGuardFireAtNothing { get; }

	public SnoPower Generic_a3duncraterDemonClawBombA { get; }

	public SnoPower Generic_a3dunCraterDemonClawBombAtrigger { get; }

	public SnoPower Generic_a3duncraterDemonGroundTrapGasChamber { get; }

	public SnoPower Generic_a3duncraterDemonGroundTrapGasChamberFireOnly { get; }

	public SnoPower Generic_a3dunKeepBarrelStackShortDamage { get; }

	public SnoPower Generic_a3dunKeepExplodingBarrelStunpower { get; }

	public SnoPower Generic_a3dunkeepfireTrench01 { get; }

	public SnoPower Generic_a3dunkeepfireTrench02 { get; }

	public SnoPower Generic_A3IntroCatapultAttack { get; }

	public SnoPower Generic_a4dunGardenCorruptionMine { get; }

	public SnoPower Generic_a4dunHeavenHellRiftFallingRocksA { get; }

	public SnoPower Generic_a4dunHeavenHellRiftFallingRocksB { get; }

	public SnoPower Generic_a4DunHellFissure { get; }

	public SnoPower Generic_a4dunSpireCorruptionGeyser { get; }

	public SnoPower Generic_a4dunspirefirewall { get; }

	public SnoPower Generic_a4dunspireSpikeTrap { get; }

	public SnoPower Generic_ActorDisabledBuff { get; }

	public SnoPower Generic_ActorGhostedBuff { get; }

	public SnoPower Generic_ActorInTownBuff { get; }

	public SnoPower Generic_ActorInvulBuff { get; }

	public SnoPower Generic_ActorLoadingBuff { get; }

	public SnoPower Generic_Adriaevent47blast { get; }

	public SnoPower Generic_Adriaevent47projectile { get; }

	public SnoPower Generic_AIBackpedal { get; }

	public SnoPower Generic_AIBackpedalOneShotThroughActors { get; }

	public SnoPower Generic_AICircle { get; }

	public SnoPower Generic_AICircleLong { get; }

	public SnoPower Generic_AICircleStrafe { get; }

	public SnoPower Generic_AICircleStrafeShort { get; }

	public SnoPower Generic_AIClose { get; }

	public SnoPower Generic_AICloseFar { get; }

	public SnoPower Generic_AICloseFarther { get; }

	public SnoPower Generic_AICloseLong { get; }

	public SnoPower Generic_AIEscortFollow { get; }

	public SnoPower Generic_AIEvadeBuff { get; }

	public SnoPower Generic_AIFollow { get; }

	public SnoPower Generic_AIFollowClose { get; }

	public SnoPower Generic_AIFollowMeleeLead { get; }

	public SnoPower Generic_AIFollowMeleeLeadPet { get; }

	public SnoPower Generic_AIFollowMeleeLeadPetFar { get; }

	public SnoPower Generic_AIFollowPath { get; }

	public SnoPower Generic_AIFollowWithWalk { get; }

	public SnoPower Generic_AIFollowWithWalkFar { get; }

	public SnoPower Generic_AIFollowWithWalkNatural { get; }

	public SnoPower Generic_AIIdle { get; }

	public SnoPower Generic_AIIdleLong { get; }

	public SnoPower Generic_AIIdleShort { get; }

	public SnoPower Generic_AIOrbit { get; }

	public SnoPower Generic_AIReturnToGuardObject { get; }

	public SnoPower Generic_AIReturnToPath { get; }

	public SnoPower Generic_AIRunAway { get; }

	public SnoPower Generic_AIRunAwayLong { get; }

	public SnoPower Generic_AIRunAwayShort { get; }

	public SnoPower Generic_AIRunAwayShortV2 { get; }

	public SnoPower Generic_AIRunInFront { get; }

	public SnoPower Generic_AIRunInFrontGuaranteed { get; }

	public SnoPower Generic_AIRunNearby { get; }

	public SnoPower Generic_AIRunNearbyGloam { get; }

	public SnoPower Generic_AIRunNearbyLong { get; }

	public SnoPower Generic_AIRunNearbyShort { get; }

	public SnoPower Generic_AIRunTo { get; }

	public SnoPower Generic_AIRunToGuaranteed { get; }

	public SnoPower Generic_AIRunToGuaranteedSpider { get; }

	public SnoPower Generic_AISprintInFrontGuaranteed { get; }

	public SnoPower Generic_AISprintTo { get; }

	public SnoPower Generic_AISprintToGuaranteed { get; }

	public SnoPower Generic_AIStrafe { get; }

	public SnoPower Generic_AITownWalkToGuaranteed { get; }

	public SnoPower Generic_AIWalkInFront { get; }

	public SnoPower Generic_AIWalkInFrontGuaranteed { get; }

	public SnoPower Generic_AIWalkTo { get; }

	public SnoPower Generic_AIWalkToGuaranteed { get; }

	public SnoPower Generic_AIWander { get; }

	public SnoPower Generic_AIWanderLong { get; }

	public SnoPower Generic_AIWanderMinion { get; }

	public SnoPower Generic_AIWanderRun { get; }

	public SnoPower Generic_AIWandersuperLong { get; }

	public SnoPower Generic_AIWarnOthers { get; }

	public SnoPower Generic_AncientSpearKnockback { get; }

	public SnoPower Generic_AngelCorruptPiercingDash { get; }

	public SnoPower Generic_AnniversaryBuffEXPMF { get; }

	public SnoPower Generic_AxeBadData { get; }

	public SnoPower Generic_AxeOperateGizmo { get; }

	public SnoPower Generic_AxeOperateNPC { get; }

	public SnoPower Generic_AzmodanAODDamage { get; }

	public SnoPower Generic_AzmodanFallingCorpses { get; }

	public SnoPower Generic_AzmodanGlobeOfAnnihilation { get; }

	public SnoPower Generic_AzmodanLaserAttack { get; }

	public SnoPower Generic_AzmodanMelee { get; }

	public SnoPower Generic_AzmodanonDeath { get; }

	public SnoPower Generic_AzmodanPhase3Channel { get; }

	public SnoPower Generic_AzmodanTaunt { get; }

	public SnoPower Generic_AzmodanTurning { get; }

	public SnoPower Generic_BannerDrop { get; }

	public SnoPower Generic_BannerDropPVP { get; }

	public SnoPower Generic_BanterCooldown { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsBasicMelee { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsCleave { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsFuriousCharge { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsLeap { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsSeismicSlam { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsWeaponThrow { get; }

	public SnoPower Generic_BarbarianCallOfTheAncientsWhirlwind { get; }

	public SnoPower Generic_BarbarianGroundStompEffect { get; }

	public SnoPower Generic_BarbarianLeapOLD { get; }

	public SnoPower Generic_BarbarianOverpowerCowKing { get; }

	public SnoPower Generic_BarbarianRevengeBuff { get; }

	public SnoPower Generic_BarbarianWhirlwindDustDevilsPassability { get; }

	public SnoPower Generic_BareHandedPassive { get; }

	public SnoPower Generic_BarrelExplodeInstant { get; }

	public SnoPower Generic_BeastCharge { get; }

	public SnoPower Generic_BeastWeaponMeleeInstant { get; }

	public SnoPower Generic_BelialArmProxy { get; }

	public SnoPower Generic_BelialGroundPound { get; }

	public SnoPower Generic_BelialLightningBreath { get; }

	public SnoPower Generic_BelialLightningStrikeEnrage { get; }

	public SnoPower Generic_BelialLightningStrikev2 { get; }

	public SnoPower Generic_BelialMelee { get; }

	public SnoPower Generic_BelialMeleeReach { get; }

	public SnoPower Generic_BelialPhase3Buff { get; }

	public SnoPower Generic_BelialRangedAttack { get; }

	public SnoPower Generic_BelialSprint { get; }

	public SnoPower Generic_BelialSprintAway { get; }

	public SnoPower Generic_BigRedCharge { get; }

	public SnoPower Generic_BigRedFireBreath { get; }

	public SnoPower Generic_BlockChance10 { get; }

	public SnoPower Generic_BodyGuardTeleport { get; }

	public SnoPower Generic_BoneTurretMortarCast { get; }

	public SnoPower Generic_BountyGroundsBurrowOut { get; }

	public SnoPower Generic_BrickhouseArmShields { get; }

	public SnoPower Generic_BrickhouseDestructionSetup { get; }

	public SnoPower Generic_BrickhouseEnrage { get; }

	public SnoPower Generic_BrickhouseSlam { get; }

	public SnoPower Generic_BugWingsBuff { get; }

	public SnoPower Generic_BurrowIn { get; }

	public SnoPower Generic_BurrowInHidden { get; }

	public SnoPower Generic_BurrowInSetup { get; }

	public SnoPower Generic_BurrowInSetup2HSwing { get; }

	public SnoPower Generic_BurrowInSetupHidden { get; }

	public SnoPower Generic_BurrowInSetupStaff { get; }

	public SnoPower Generic_BurrowOut { get; }

	public SnoPower Generic_BurrowOutNoFacing { get; }

	public SnoPower Generic_BurrowOutSetup { get; }

	public SnoPower Generic_BurrowStartBuff { get; }

	public SnoPower Generic_ButcherDamagingFire { get; }

	public SnoPower Generic_ButcherFloorPanelFire { get; }

	public SnoPower Generic_ButcherFrenzy { get; }

	public SnoPower Generic_ButcherFrenzyCustomLRBoss { get; }

	public SnoPower Generic_ButcherGrapplingHook { get; }

	public SnoPower Generic_ButcherOnDeath { get; }

	public SnoPower Generic_ButcherSlam { get; }

	public SnoPower Generic_ButcherSmash { get; }

	public SnoPower Generic_ButcherSpears { get; }

	public SnoPower Generic_ButcherTargetRanged { get; }

	public SnoPower Generic_CainIntroSwing { get; }

	public SnoPower Generic_CaldeumPoisonLaser { get; }

	public SnoPower Generic_CalldownGrenade { get; }

	public SnoPower Generic_CalloutCooldown { get; }

	public SnoPower Generic_CameraFocusBuff { get; }

	public SnoPower Generic_CameraFocusPetBuff { get; }

	public SnoPower Generic_CannotDieDuringBuff { get; }

	public SnoPower Generic_caOutBoneYardsCollapsingBonesDamage { get; }

	public SnoPower Generic_caOutOasisAttackPlantattack { get; }

	public SnoPower Generic_CatapultAttack { get; }

	public SnoPower Generic_ChampionClone { get; }

	public SnoPower Generic_ChampionTeleport { get; }

	public SnoPower Generic_CleanupSummonsOnDeath { get; }

	public SnoPower Generic_CollectorsEditionBuff { get; }

	public SnoPower Generic_CommunityBuffLegacyOfNightmares { get; }

	public SnoPower Generic_CommunityBuffPandemonium { get; }

	public SnoPower Generic_CommunityBuffShadowClones { get; }

	public SnoPower Generic_CommunityBuffTriunesWill { get; }

	public SnoPower Generic_CommunityEventBuffEXPMF { get; }

	public SnoPower Generic_CompanionBuff { get; }

	public SnoPower Generic_ConsolePowerGlobe { get; }

	public SnoPower Generic_ConsumablePotionBuffs { get; }

	public SnoPower Generic_Cooldown { get; }

	public SnoPower Generic_CopiedVisualEffectsBuff { get; }

	public SnoPower Generic_CoreEliteDropPod { get; }

	public SnoPower Generic_CoreEliteDropPodBegin { get; }

	public SnoPower Generic_CoreElitePodSetUp { get; }

	public SnoPower Generic_CorpulentExplode { get; }

	public SnoPower Generic_CorruptAngelSpectralStrike { get; }

	public SnoPower Generic_CosmeticSpectralHoundBuff { get; }

	public SnoPower Generic_CreepMobCreeperAttack { get; }

	public SnoPower Generic_CreepMobKnockback { get; }

	public SnoPower Generic_CreepMobKnockbackLR { get; }

	public SnoPower Generic_CreepMobRangedArmAttack { get; }

	public SnoPower Generic_CritDebuffCold { get; }

	public SnoPower Generic_CryptChildEat { get; }

	public SnoPower Generic_CryptChildLeapOut { get; }

	public SnoPower Generic_CryptChildLeapOutBuff { get; }

	public SnoPower Generic_DamageAttribute { get; }

	public SnoPower Generic_DeathBroBoneCage { get; }

	public SnoPower Generic_DeathBroSummonSkeletons { get; }

	public SnoPower Generic_DeathBroTeleport { get; }

	public SnoPower Generic_DebuffBleed { get; }

	public SnoPower Generic_DebuffBlind { get; }

	public SnoPower Generic_DebuffCharmed { get; }

	public SnoPower Generic_DebuffChilled { get; }

	public SnoPower Generic_DebuffFeared { get; }

	public SnoPower Generic_DebuffFireDamageProc { get; }

	public SnoPower Generic_DebuffForceGripped { get; }

	public SnoPower Generic_DebuffPoisonDamageProc { get; }

	public SnoPower Generic_DebuffRooted { get; }

	public SnoPower Generic_DebuffSlowed { get; }

	public SnoPower Generic_DebuffStunned { get; }

	public SnoPower Generic_DeleteSelfAnim { get; }

	public SnoPower Generic_demonFlyerdropBomb { get; }

	public SnoPower Generic_DemonFlyerFireBreath { get; }

	public SnoPower Generic_DemonFlyerProjectile { get; }

	public SnoPower Generic_demonFlyersnatch { get; }

	public SnoPower Generic_DemonHunterBallistaV3 { get; }

	public SnoPower Generic_DemonHunterCompanion { get; }

	public SnoPower Generic_DemonHunterEvasiveFireFlip { get; }

	public SnoPower Generic_DemonHunterSentryTurretAttack { get; }

	public SnoPower Generic_DemonTrooperLeapOut { get; }

	public SnoPower Generic_DervishWhirlwind { get; }

	public SnoPower Generic_DervishWhirlwindMortarPrototype { get; }

	public SnoPower Generic_DespairMeleeCleave { get; }

	public SnoPower Generic_DespairMeleeCleaveEnrage { get; }

	public SnoPower Generic_DespairSummonMinion { get; }

	public SnoPower Generic_DespairTeleport { get; }

	public SnoPower Generic_DespairTeleportAway { get; }

	public SnoPower Generic_DespairVolley { get; }

	public SnoPower Generic_DespairVolleyLRBoss { get; }

	public SnoPower Generic_DestructableObjectAOE { get; }

	public SnoPower Generic_DestructableObjectChandelierAOE { get; }

	public SnoPower Generic_DestructableObjectChandelierAOEHoist { get; }

	public SnoPower Generic_DestructionStreakBuffRunSpeed { get; }

	public SnoPower Generic_DHCompanionChargeAttack { get; }

	public SnoPower Generic_DHCompanionMeleeAttack { get; }

	public SnoPower Generic_DHrainofArrowsshadowBeastbombDrop { get; }

	public SnoPower Generic_DiabloCharge { get; }

	public SnoPower Generic_DiabloClawRip { get; }

	public SnoPower Generic_DiabloClawRipUber { get; }

	public SnoPower Generic_DiabloCorruptionShield { get; }

	public SnoPower Generic_DiabloCurseOfAnguish { get; }

	public SnoPower Generic_DiabloCurseOfDestruction { get; }

	public SnoPower Generic_DiabloCurseOfHate { get; }

	public SnoPower Generic_DiabloCurseOfPain { get; }

	public SnoPower Generic_DiabloExpandingFireRing { get; }

	public SnoPower Generic_DiabloExpandingFireRingUber { get; }

	public SnoPower Generic_DiabloFireMeteor { get; }

	public SnoPower Generic_DiabloGetHit { get; }

	public SnoPower Generic_DiabloHellSpikes { get; }

	public SnoPower Generic_DiabloLightningBreath { get; }

	public SnoPower Generic_DiabloLightningBreathLRTerrorDemon { get; }

	public SnoPower Generic_DiabloLightningBreathLRTerrorDemonClone { get; }

	public SnoPower Generic_DiabloLightningBreathTurretMB313 { get; }

	public SnoPower Generic_DiabloLightningBreathUber { get; }

	public SnoPower Generic_DiabloLightningBreathv2 { get; }

	public SnoPower Generic_DiabloPhase1Buff { get; }

	public SnoPower Generic_DiabloPhase2Buff { get; }

	public SnoPower Generic_DiabloPhase3Buff { get; }

	public SnoPower Generic_DiabloRingOfFire { get; }

	public SnoPower Generic_DiabloRingOfFireUber { get; }

	public SnoPower Generic_DiabloShadowClones { get; }

	public SnoPower Generic_DiabloShadowVanish { get; }

	public SnoPower Generic_DiabloShadowVanishCharge { get; }

	public SnoPower Generic_DiabloShadowVanishGrab { get; }

	public SnoPower Generic_DiabloSmashPunyDestructible { get; }

	public SnoPower Generic_DiabloStompAndStun { get; }

	public SnoPower Generic_DiabloStompAndStunMB313 { get; }

	public SnoPower Generic_DiabloTeleport { get; }

	public SnoPower Generic_DisableGetHitBuffInfinite { get; }

	public SnoPower Generic_DisablePowerBuffInfinite { get; }

	public SnoPower Generic_DOTDebuff { get; }

	public SnoPower Generic_DrinkHealthPotion { get; }

	public SnoPower Generic_DualWieldBuff { get; }

	public SnoPower Generic_DualWieldScripted { get; }

	public SnoPower Generic_DualWieldScriptedRemove { get; }

	public SnoPower Generic_DuelBuff { get; }

	public SnoPower Generic_DuelDefeatBuff { get; }

	public SnoPower Generic_EasterEggWorldBuff { get; }

	public SnoPower Generic_EatCorpse { get; }

	public SnoPower Generic_ElectricEelElectricBurst { get; }

	public SnoPower Generic_ElectricEelLeapOut { get; }

	public SnoPower Generic_EmoteAttack { get; }

	public SnoPower Generic_EmoteBye { get; }

	public SnoPower Generic_EmoteDance { get; }

	public SnoPower Generic_EmoteDie { get; }

	public SnoPower Generic_EmoteFollow { get; }

	public SnoPower Generic_EmoteGive { get; }

	public SnoPower Generic_EmoteGo { get; }

	public SnoPower Generic_EmoteHelp { get; }

	public SnoPower Generic_EmoteHold { get; }

	public SnoPower Generic_EmoteLaugh { get; }

	public SnoPower Generic_EmoteNo { get; }

	public SnoPower Generic_EmoteRetreat { get; }

	public SnoPower Generic_EmoteRun { get; }

	public SnoPower Generic_EmoteSorry { get; }

	public SnoPower Generic_EmoteStay { get; }

	public SnoPower Generic_EmoteTakeObjective { get; }

	public SnoPower Generic_EmoteThanks { get; }

	public SnoPower Generic_EmoteWait { get; }

	public SnoPower Generic_EmoteYes { get; }

	public SnoPower Generic_EnchantressAmplifyElemental { get; }

	public SnoPower Generic_EnchantressArcaneOrb { get; }

	public SnoPower Generic_EnchantressCharm { get; }

	public SnoPower Generic_EnchantressCheatDeath { get; }

	public SnoPower Generic_EnchantressCheatDeathPassive { get; }

	public SnoPower Generic_EnchantressCombinedShield { get; }

	public SnoPower Generic_EnchantressCooldownReduction { get; }

	public SnoPower Generic_EnchantressCripple { get; }

	public SnoPower Generic_EnchantressDisorient { get; }

	public SnoPower Generic_EnchantressFocusedMind { get; }

	public SnoPower Generic_EnchantressMassCharm { get; }

	public SnoPower Generic_EnchantressMeleeInstant { get; }

	public SnoPower Generic_EnchantressRunAway { get; }

	public SnoPower Generic_EnchantressScorchedEarth { get; }

	public SnoPower Generic_EnterRecallPortal { get; }

	public SnoPower Generic_EnterStoneOfRecall { get; }

	public SnoPower Generic_EnvironmentKillBuffResourceRegen { get; }

	public SnoPower Generic_EquippedLegendaryPower { get; }

	public SnoPower Generic_EscortingBuff { get; }

	public SnoPower Generic_ExitRecallPortal { get; }

	public SnoPower Generic_ExitStoneOfRecall { get; }

	public SnoPower Generic_FallenChampionLeaderShout { get; }

	public SnoPower Generic_FallenChampionPowerHit { get; }

	public SnoPower Generic_FallenGruntShout { get; }

	public SnoPower Generic_FallenLunaticAggroA { get; }

	public SnoPower Generic_FallenLunaticAggroB { get; }

	public SnoPower Generic_FallenLunaticAggroC { get; }

	public SnoPower Generic_FallenLunaticAggroD { get; }

	public SnoPower Generic_FallenLunaticSuicide { get; }

	public SnoPower Generic_FallenLunaticSuicideRingSummon { get; }

	public SnoPower Generic_FallenShamanProjectile { get; }

	public SnoPower Generic_FallenShamanProjectileLR { get; }

	public SnoPower Generic_FallingSwordCheckPathPassability { get; }

	public SnoPower Generic_FastMummyDiseaseCloud { get; }

	public SnoPower Generic_FrenzyAffix { get; }

	public SnoPower Generic_GenericArrowProjectile { get; }

	public SnoPower Generic_GenericSetCannotBeAddedToAITargetList { get; }

	public SnoPower Generic_GenericSetDoesFakeDamage { get; }

	public SnoPower Generic_GenericSetInvisible { get; }

	public SnoPower Generic_GenericSetInvulnerable { get; }

	public SnoPower Generic_GenericSetObserver { get; }

	public SnoPower Generic_GenericSetTakesNoDamage { get; }

	public SnoPower Generic_GenericSetUntargetable { get; }

	public SnoPower Generic_GenericTaunt { get; }

	public SnoPower Generic_GhostAUniqueHouse1000UndeadSlow { get; }

	public SnoPower Generic_GhostMeleeDrain { get; }

	public SnoPower Generic_GhostSoulSiphon { get; }

	public SnoPower Generic_GhostWalkThroughWalls { get; }

	public SnoPower Generic_Gizmoa3dunrmptOilVatAAttack { get; }

	public SnoPower Generic_GizmoOperatePortalWithAnimation { get; }

	public SnoPower Generic_gkillElitePack { get; }

	public SnoPower Generic_glevelUp { get; }

	public SnoPower Generic_glevelUpAA { get; }

	public SnoPower Generic_GluttonyBreathAttack { get; }

	public SnoPower Generic_GluttonyGasCloud { get; }

	public SnoPower Generic_GluttonyGasCloudLRBoss { get; }

	public SnoPower Generic_GluttonyLoogiespawn { get; }

	public SnoPower Generic_GluttonyOnDeath { get; }

	public SnoPower Generic_GoatmanColdShield { get; }

	public SnoPower Generic_GoatmanDrumsBeating { get; }

	public SnoPower Generic_GoatmanIceball { get; }

	public SnoPower Generic_GoatmanLightningShield { get; }

	public SnoPower Generic_GoatmanMoonclanRangedProjectile { get; }

	public SnoPower Generic_GoatmanShamanEmpower { get; }

	public SnoPower Generic_GoatmanShamanLightningbolt { get; }

	public SnoPower Generic_GoatMutantEnrage { get; }

	public SnoPower Generic_GoatMutantGroundSmash { get; }

	public SnoPower Generic_GoatMutantRangedProjectile { get; }

	public SnoPower Generic_GoatMutantShamanBlast { get; }

	public SnoPower Generic_GoblinAffixTeleporter { get; }

	public SnoPower Generic_gparagonBuff { get; }

	public SnoPower Generic_GraveDiggerKnockbackAttack { get; }

	public SnoPower Generic_graveDiggerwardenrangedAttack { get; }

	public SnoPower Generic_GraveRobberDodgeLeft { get; }

	public SnoPower Generic_GraveRobberDodgeRight { get; }

	public SnoPower Generic_graveRobberProjectile { get; }

	public SnoPower Generic_GreedStompAndStun { get; }

	public SnoPower Generic_HealingWellHeal { get; }

	public SnoPower Generic_Hearth { get; }

	public SnoPower Generic_HearthFinish { get; }

	public SnoPower Generic_HellPortalSummoningMachineActivate { get; }

	public SnoPower Generic_HelperArcherProjectile { get; }

	public SnoPower Generic_HirelingCalloutBattleCry { get; }

	public SnoPower Generic_HirelingCalloutBattleFinished { get; }

	public SnoPower Generic_HirelingDismiss { get; }

	public SnoPower Generic_HirelingDismissBuff { get; }

	public SnoPower Generic_HirelingDismissBuffRemove { get; }

	public SnoPower Generic_HirelingMageMagicMissile { get; }

	public SnoPower Generic_HoodedNightmareBoneArmor { get; }

	public SnoPower Generic_HoodedNightmareCurses { get; }

	public SnoPower Generic_HoodedNightmareGatewayToHell { get; }

	public SnoPower Generic_HoodedNightmareLightningOfUnlife { get; }

	public SnoPower Generic_IdentifyAllWithCast { get; }

	public SnoPower Generic_IdentifyWithCast { get; }

	public SnoPower Generic_IdentifyWithCastLegendary { get; }

	public SnoPower Generic_IGRBuffEXP { get; }

	public SnoPower Generic_ImmuneToFearDuringBuff { get; }

	public SnoPower Generic_ImmuneToRootDuringBuff { get; }

	public SnoPower Generic_ImmuneToSnareDuringBuff { get; }

	public SnoPower Generic_ImmuneToStunDuringBuff { get; }

	public SnoPower Generic_InteractCrouching { get; }

	public SnoPower Generic_InteractNormal { get; }

	public SnoPower Generic_InvisibileDuringBuff { get; }

	public SnoPower Generic_InvulnerableDuringBuff { get; }

	public SnoPower Generic_ItemPassiveSetBonusChantodo { get; }

	public SnoPower Generic_itemPassiveUniqueAmulet001 { get; }

	public SnoPower Generic_ItemPassiveUniqueBelt016p2 { get; }

	public SnoPower Generic_ItemPassiveUniqueDagger006 { get; }

	public SnoPower Generic_ItemPassiveUniqueDagger011x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueFist010 { get; }

	public SnoPower Generic_ItemPassiveUniqueFist010x1 { get; }

	public SnoPower Generic_itemPassiveUniqueMace1H009 { get; }

	public SnoPower Generic_ItemPassiveUniqueMace2H006 { get; }

	public SnoPower Generic_ItemPassiveUniqueMighty1H011 { get; }

	public SnoPower Generic_ItemPassiveUniqueMighty1H011x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueMojo010 { get; }

	public SnoPower Generic_ItemPassiveUniqueMojo010x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueMojo010x1tooltipDummy1 { get; }

	public SnoPower Generic_ItemPassiveUniquePotion01x1 { get; }

	public SnoPower Generic_ItemPassiveUniquePotion02x1 { get; }

	public SnoPower Generic_ItemPassiveUniquePotion03x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing015 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing015x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing024 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing500p2 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing502x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing503x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing506x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing511x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing512x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing513AIPickupx1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing518x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing522x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing524x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing529x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing535x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing542x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing543x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing546x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing553x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing556x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing561x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing563x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing564x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing566x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing567x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing570x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing572x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing573x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing574x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing578x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing580x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing582x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing583x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing584x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing585x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing586x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing596x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing597p2 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing598x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing599x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing601x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing603x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing605x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing621x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing625x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing627x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing632x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing633x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing636x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing637x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing640x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing641x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing650x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing652x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing654x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing657x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing659x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing661x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing666x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing676x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing678x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing680x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing681p2 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing682x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing683x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing684x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing689x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing693x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing702x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing710x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing711x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing713x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing714x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing715x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing716x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing717x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing718x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing719x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing720x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing721x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing722x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing723x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing724SpawnDecoyx1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing724x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing725x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing726x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing727x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing728x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing729x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing730x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing731x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing732x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing733x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing734x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing735x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing736x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing737x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing738x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing740x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing743x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing746x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing752x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing756x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing757x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing758x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing760x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing763x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing764x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing765x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing766x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing767x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing768x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing769x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing770x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing771x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing772x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing773x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing774x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing775x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing776x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing777x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing778x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing779x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing780x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing781x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing782x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing783x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing784x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing785x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing786x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing787x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing788x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing789x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing790x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing791x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing792x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing793x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing794x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing795x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing796x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing797x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing798x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing799x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing800x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing801x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing802x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing803x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing804x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing805x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing806x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing807x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing808x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing809x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing810x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing811x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing812x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing813x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing814x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing815x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing816x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing817x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing818x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing819x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing820x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing821x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing822x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing823x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing824x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing825x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing826x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing827x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing828x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing829x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing830x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing831x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing832x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing833x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing834x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing835x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing836x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing837x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing838x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing839x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing840x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing841x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing842x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing843x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing844x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing845x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing846x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing847x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing848x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing849x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing850x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing851x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing852x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing853x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing854x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing855x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing856x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing857x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing858x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing859x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing860x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing861x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing862x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing863x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing864x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing865x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing866x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing867x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing868x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing869x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing870x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing871x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing872x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing873x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing874x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing875x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing876x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing877x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing878x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing879x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing880x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing899x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing900x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing901x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing902x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing904x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing910x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing913x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing914x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing924x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing925x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing926x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing927x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing928x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing929x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing930x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing931x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing932x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing933x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing934x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing935x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing936x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing937x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing938x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing939x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing940x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing941x1 { get; }

	public SnoPower Generic_ItemPassiveUniqueRing999 { get; }

	public SnoPower Generic_ItemPassiveUniqueRingHellfirex1 { get; }

	public SnoPower Generic_itemPassiveUniqueShield011 { get; }

	public SnoPower Generic_ItemPassiveUniqueShoulder009 { get; }

	public SnoPower Generic_itemPassiveUniqueWizardHat004p2 { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25Barbarian { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25Crusader { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25DemonHunter { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25Monk { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25Necromancer { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25WitchDoctor { get; }

	public SnoPower Generic_ItemPassivex1Amuletnormunique25Wizard { get; }

	public SnoPower Generic_IzualCharge { get; }

	public SnoPower Generic_IzualFrostNova { get; }

	public SnoPower Generic_IzualFrozenCast { get; }

	public SnoPower Generic_KillActor { get; }

	public SnoPower Generic_Knockback { get; }

	public SnoPower Generic_KnockbackNoLandingAnim { get; }

	public SnoPower Generic_KnockbackOverObstacles { get; }

	public SnoPower Generic_KnockbackThroughOwnedByTeam { get; }

	public SnoPower Generic_Knockdown { get; }

	public SnoPower Generic_LacuniBurrowIn { get; }

	public SnoPower Generic_LacuniBurrowOut { get; }

	public SnoPower Generic_LacuniCombo { get; }

	public SnoPower Generic_LacuniLeap { get; }

	public SnoPower Generic_LacuniLob { get; }

	public SnoPower Generic_LacuniMaleDoubleSwing { get; }

	public SnoPower Generic_Laugh { get; }

	public SnoPower Generic_LaughSkeletonKing { get; }

	public SnoPower Generic_LeahHulkOut { get; }

	public SnoPower Generic_LeahVortex { get; }

	public SnoPower Generic_LeahVortexAgain { get; }

	public SnoPower Generic_LostSoulsPrototypeV2 { get; }

	public SnoPower Generic_LRBossCollapseCeiling { get; }

	public SnoPower Generic_LRBossFast { get; }

	public SnoPower Generic_LRBossIzualCharge { get; }

	public SnoPower Generic_LRBossPathBlockedTeleport { get; }

	public SnoPower Generic_LRBossSprint { get; }

	public SnoPower Generic_LSp4SeaMonsterSpawnCrabs { get; }

	public SnoPower Generic_MaghdaMark { get; }

	public SnoPower Generic_MaghdaMothDust { get; }

	public SnoPower Generic_MaghdaPortalCreateCinematic { get; }

	public SnoPower Generic_MaghdaProjectile { get; }

	public SnoPower Generic_MaghdaPunish { get; }

	public SnoPower Generic_MaghdaPunishCinematic { get; }

	public SnoPower Generic_MaghdaSummonBeserker { get; }

	public SnoPower Generic_MaghdaTeleport { get; }

	public SnoPower Generic_MagicPaintingSummonSkeleton { get; }

	public SnoPower Generic_MalletDemonPowerHit { get; }

	public SnoPower Generic_ManualWalk { get; }

	public SnoPower Generic_MastaBlastaCombinedDismountRider { get; }

	public SnoPower Generic_MastaBlastaCombinedLobbedShot { get; }

	public SnoPower Generic_MastaBlastaRiderAlphaStrike { get; }

	public SnoPower Generic_MastaBlastaRiderCombine { get; }

	public SnoPower Generic_MastaBlastaRiderLeap { get; }

	public SnoPower Generic_MastaBlastaRiderLobbedShot { get; }

	public SnoPower Generic_MastaBlastaRiderLobbedShotLR { get; }

	public SnoPower Generic_MastaBlastaSteedCombine { get; }

	public SnoPower Generic_MastaBlastaSteedDrainAttack { get; }

	public SnoPower Generic_MastaBlastaSteedStomp { get; }

	public SnoPower Generic_MistressOfPainAscend { get; }

	public SnoPower Generic_MistressOfPainDescend { get; }

	public SnoPower Generic_MistressOfPainPainBolts { get; }

	public SnoPower Generic_MistressOfPainPainBoltsLR { get; }

	public SnoPower Generic_MistressOfPainSpiderlingExplode { get; }

	public SnoPower Generic_MistressOfPainSummonSpiders { get; }

	public SnoPower Generic_MistressOfPainSummonSpidersAirborne { get; }

	public SnoPower Generic_MistressOfPainTeleportToThrone { get; }

	public SnoPower Generic_MistressOfPainWebPatch { get; }

	public SnoPower Generic_MonkLashingTailKickHandOfYtarPassability { get; }

	public SnoPower Generic_MonkLethalDecoyTaunt { get; }

	public SnoPower Generic_MonkMysticAllyPetRuneAKick { get; }

	public SnoPower Generic_MonkMysticAllyPetRuneBWaveAttackFast { get; }

	public SnoPower Generic_MonkMysticAllyPetRuneCGroundPunch { get; }

	public SnoPower Generic_MonkMysticAllyPetRuneDAOEAttack { get; }

	public SnoPower Generic_MonkMysticAllyPetWeaponMeleeInstant { get; }

	public SnoPower Generic_MonkResistAura { get; }

	public SnoPower Generic_MonkResistAuraRuneCArcane { get; }

	public SnoPower Generic_MonkResistAuraRuneCCold { get; }

	public SnoPower Generic_MonkResistAuraRuneCFire { get; }

	public SnoPower Generic_MonkResistAuraRuneCHoly { get; }

	public SnoPower Generic_MonkResistAuraRuneCLightning { get; }

	public SnoPower Generic_MonkResistAuraRuneCPoison { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchanted { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchantedCast { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchantedCastNoTarget { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchantedChampion { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchantedMinion { get; }

	public SnoPower Generic_MonsterAffixArcaneEnchantedNewPetBasic { get; }

	public SnoPower Generic_MonsterAffixAvengerArcaneEnchanted { get; }

	public SnoPower Generic_MonsterAffixAvengerArcaneEnchantedCast { get; }

	public SnoPower Generic_MonsterAffixAvengerArcaneEnchantedNewPetBasic { get; }

	public SnoPower Generic_MonsterAffixAvengerBuff { get; }

	public SnoPower Generic_MonsterAffixAvengerChampion { get; }

	public SnoPower Generic_MonsterAffixAvengerMortar { get; }

	public SnoPower Generic_MonsterAffixAvengerMortarCast { get; }

	public SnoPower Generic_MonsterAffixBallista { get; }

	public SnoPower Generic_MonsterAffixChampionBuff { get; }

	public SnoPower Generic_MonsterAffixDesecrator { get; }

	public SnoPower Generic_MonsterAffixDesecratorBuff { get; }

	public SnoPower Generic_MonsterAffixDesecratorBuffChampion { get; }

	public SnoPower Generic_MonsterAffixDesecratorCast { get; }

	public SnoPower Generic_MonsterAffixDieTogether { get; }

	public SnoPower Generic_MonsterAffixElectrified { get; }

	public SnoPower Generic_MonsterAffixElectrifiedLRBossCustom { get; }

	public SnoPower Generic_MonsterAffixElectrifiedMinion { get; }

	public SnoPower Generic_MonsterAffixExtraHealth { get; }

	public SnoPower Generic_MonsterAffixFast { get; }

	public SnoPower Generic_MonsterAffixFrozen { get; }

	public SnoPower Generic_MonsterAffixFrozenCast { get; }

	public SnoPower Generic_MonsterAffixFrozenRare { get; }

	public SnoPower Generic_MonsterAffixHealing { get; }

	public SnoPower Generic_MonsterAffixHealthlink { get; }

	public SnoPower Generic_MonsterAffixIllusionist { get; }

	public SnoPower Generic_MonsterAffixIllusionistCast { get; }

	public SnoPower Generic_MonsterAffixJailer { get; }

	public SnoPower Generic_MonsterAffixJailerCast { get; }

	public SnoPower Generic_MonsterAffixJailerChampion { get; }

	public SnoPower Generic_MonsterAffixJuggernaut { get; }

	public SnoPower Generic_MonsterAffixKnockback { get; }

	public SnoPower Generic_MonsterAffixLinked { get; }

	public SnoPower Generic_MonsterAffixMissileDampening { get; }

	public SnoPower Generic_MonsterAffixMissileDampeningCast { get; }

	public SnoPower Generic_MonsterAffixMolten { get; }

	public SnoPower Generic_MonsterAffixMoltenMinion { get; }

	public SnoPower Generic_MonsterAffixMortar { get; }

	public SnoPower Generic_MonsterAffixMortarCast { get; }

	public SnoPower Generic_MonsterAffixNightmarish { get; }

	public SnoPower Generic_MonsterAffixPheonix { get; }

	public SnoPower Generic_MonsterAffixPlagued { get; }

	public SnoPower Generic_MonsterAffixPlaguedCast { get; }

	public SnoPower Generic_MonsterAffixPuppetmaster { get; }

	public SnoPower Generic_MonsterAffixPuppetmasterMinion { get; }

	public SnoPower Generic_MonsterAffixReflectsDamage { get; }

	public SnoPower Generic_MonsterAffixReflectsDamageCast { get; }

	public SnoPower Generic_MonsterAffixShielding { get; }

	public SnoPower Generic_MonsterAffixShieldingCast { get; }

	public SnoPower Generic_MonsterAffixTeleporterBuff { get; }

	public SnoPower Generic_MonsterAffixTeleporterCast { get; }

	public SnoPower Generic_MonsterAffixThunderstormBuff { get; }

	public SnoPower Generic_MonsterAffixThunderstormBuffChampion { get; }

	public SnoPower Generic_MonsterAffixThunderstormCast { get; }

	public SnoPower Generic_MonsterAffixVampiric { get; }

	public SnoPower Generic_MonsterAffixVortexBuff { get; }

	public SnoPower Generic_MonsterAffixVortexBuffChampion { get; }

	public SnoPower Generic_MonsterAffixVortexCast { get; }

	public SnoPower Generic_MonsterAffixWaller { get; }

	public SnoPower Generic_MonsterAffixWallerCast { get; }

	public SnoPower Generic_MonsterAffixWallerRare { get; }

	public SnoPower Generic_MonsterAffixWallerRareCast { get; }

	public SnoPower Generic_MonsterPoisonMeleeAttack { get; }

	public SnoPower Generic_MonsterRangedProjectile { get; }

	public SnoPower Generic_MonsterSpellProjectile { get; }

	public SnoPower Generic_MorluSpellcasterBreathOfFire { get; }

	public SnoPower Generic_MorluSpellcasterBreathOfFrost { get; }

	public SnoPower Generic_MorluSpellcasterMeteor { get; }

	public SnoPower Generic_MorluSpellcasterMeteorGraspOfTheDeadPrototype { get; }

	public SnoPower Generic_MorluSpellcasterShift { get; }

	public SnoPower Generic_MorluSpellcasterShiftNoCooldownCold { get; }

	public SnoPower Generic_MultiplayerBuff { get; }

	public SnoPower Generic_NPCLookAt { get; }

	public SnoPower Generic_OasisRockslideADamage { get; }

	public SnoPower Generic_OnDeathArcane { get; }

	public SnoPower Generic_OnDeathCold { get; }

	public SnoPower Generic_OnDeathFire { get; }

	public SnoPower Generic_OnDeathLightning { get; }

	public SnoPower Generic_OnDeathPoison { get; }

	public SnoPower Generic_OperateHelperAttach { get; }

	public SnoPower Generic_p1GreedCharge { get; }

	public SnoPower Generic_p1GreedChargeLong { get; }

	public SnoPower Generic_p1GreedChargeNoLOS { get; }

	public SnoPower Generic_p1GreedGoblinKnockback { get; }

	public SnoPower Generic_p1GreedGoldenMeteorShower { get; }

	public SnoPower Generic_p1GreedGoldSpawner { get; }

	public SnoPower Generic_p1GreedMinionPassiveLifetimeBuff { get; }

	public SnoPower Generic_p1GreedPassiveGoblinSpawnertest { get; }

	public SnoPower Generic_p1GreedPassiveLifetimeBuff { get; }

	public SnoPower Generic_p1GreedShockwave { get; }

	public SnoPower Generic_p1GreedSpawnMinion { get; }

	public SnoPower Generic_p1GreedUltimateMeteorShower { get; }

	public SnoPower Generic_p1TieredRiftSpawnNPC { get; }

	public SnoPower Generic_p1TreasureGoblinOnDeathAnniversaryPortal { get; }

	public SnoPower Generic_p1TreasureGoblinOnDeathGreedPortal { get; }

	public SnoPower Generic_p1TreasureGoblinOnDeathWhimsyshirePortal { get; }

	public SnoPower Generic_p2FallenLunaticAggroring { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing002 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing005 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing051 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing053 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing055 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing056 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing057 { get; }

	public SnoPower Generic_P2SpecialGoblinRiftSpawn { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing009 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing011 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing013 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing014 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing015 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing016 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing017 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing018 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing019 { get; }

	public SnoPower Generic_P42ItemPassiveUniqueRing020 { get; }

	public SnoPower Generic_p42ItemPassiveUniqueRing945 { get; }

	public SnoPower Generic_p43ADBarrelExplode { get; }

	public SnoPower Generic_p43ADEventAnvilOfFury { get; }

	public SnoPower Generic_p43ADTrapArrow { get; }

	public SnoPower Generic_p43d1ButcherMeleeBasic { get; }

	public SnoPower Generic_p43d1DiabloClawRip { get; }

	public SnoPower Generic_p43d1fastMummyMelee { get; }

	public SnoPower Generic_p43d1fastMummyStealth { get; }

	public SnoPower Generic_p43d1FleshPitFlyerBlink { get; }

	public SnoPower Generic_p43d1GorehoundAcidSpit { get; }

	public SnoPower Generic_p43d1MageFlash { get; }

	public SnoPower Generic_p43d1MageTeleport { get; }

	public SnoPower Generic_p43d1TerrorDemonLightningBreath { get; }

	public SnoPower Generic_p43d1ZoltunKulleFieryBoulder { get; }

	public SnoPower Generic_p43d1ZoltunKulleTeleport { get; }

	public SnoPower Generic_p43d1ZombieSkinnyMelee { get; }

	public SnoPower Generic_P43ItemPassiveUniqueRing007 { get; }

	public SnoPower Generic_P43ItemPassiveUniqueRing008 { get; }

	public SnoPower Generic_P43ItemPassiveUniqueRing009 { get; }

	public SnoPower Generic_P43ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P4CrabMotherEnrage { get; }

	public SnoPower Generic_P4DemonFlyerFireBreath { get; }

	public SnoPower Generic_p4demonTrooperSpecialMelee { get; }

	public SnoPower Generic_P4ForestMysteriousHermitArcaneFireball { get; }

	public SnoPower Generic_P4ForestMysteriousHermitArcaneFireball_ { get; }

	public SnoPower Generic_P4ForestMysteriousHermitArcaneFlameWall_ { get; }

	public SnoPower Generic_p4ForestMysteriousHermitBoomerangBlade { get; }

	public SnoPower Generic_p4ForestMysteriousHermitProjectile { get; }

	public SnoPower Generic_p4ForestMysteriousHermitTeleportIllusion { get; }

	public SnoPower Generic_P4ForestMysteriousManSpiritForm { get; }

	public SnoPower Generic_P4ForestMysteriousManSpiritSetup { get; }

	public SnoPower Generic_p4GoatmanFireball { get; }

	public SnoPower Generic_p4IceGoatmanRangedChargedShot { get; }

	public SnoPower Generic_p4IcePorcupineBackpedalShot { get; }

	public SnoPower Generic_p4IcePorcupineJumpBack { get; }

	public SnoPower Generic_p4IcePorcupineNova { get; }

	public SnoPower Generic_p4IcePorcupineShot { get; }

	public SnoPower Generic_p4ItemPassiveUniqueRing024KKG { get; }

	public SnoPower Generic_P4ItemPassiveUniqueRing043SpawnDecoy { get; }

	public SnoPower Generic_p4LRBossFedExCharge { get; }

	public SnoPower Generic_p4LRBossSpawnBoneTurrets { get; }

	public SnoPower Generic_p4LRTerrorDemonWall { get; }

	public SnoPower Generic_p4MaggotSuicideProgressiveFreeze { get; }

	public SnoPower Generic_P4MermaidHydra { get; }

	public SnoPower Generic_p4MoleRatCharge { get; }

	public SnoPower Generic_p4rathostteleport { get; }

	public SnoPower Generic_p4RatKingDoubleSwing { get; }

	public SnoPower Generic_p4RatKingLifetimeBuffPlagued { get; }

	public SnoPower Generic_p4RatKingRatBallMonsterSetup { get; }

	public SnoPower Generic_p4RatKingSummonRatBallMonster { get; }

	public SnoPower Generic_p4RatKingSummonRatVolcano { get; }

	public SnoPower Generic_p4RatKingThunderdome { get; }

	public SnoPower Generic_p4RatKingWaspRain { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianBurrowOut { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianCombatRoll { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianFuriousCharge { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianGroundstomp { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianHammerOfTheAncients { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianIntroFear { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianLeapQuake { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianShout { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianSummon { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianWeaponThrow { get; }

	public SnoPower Generic_P4RuinsCannibalBarbarianWhirlwind { get; }

	public SnoPower Generic_p4ruinsfrostEventTheZiggurat { get; }

	public SnoPower Generic_P4RuinsFrostTrapSwingingBlade { get; }

	public SnoPower Generic_P4SacrificeMonsterBreakableNova { get; }

	public SnoPower Generic_P4SacrificeMonsterEnrage { get; }

	public SnoPower Generic_P4SandWaspProjectile { get; }

	public SnoPower Generic_p4SasquatchGorillaPound { get; }

	public SnoPower Generic_p4SasquatchRockPunchKnockback { get; }

	public SnoPower Generic_p4SasquatchSpikeLine { get; }

	public SnoPower Generic_p4SasquatchTriplePunch { get; }

	public SnoPower Generic_p4ScavengerSpawnerADeath { get; }

	public SnoPower Generic_p4ScorpionBugHoverProjectile { get; }

	public SnoPower Generic_p4SeaMonsterSpawnCrabs { get; }

	public SnoPower Generic_p4SetDungBarbKingsEnmy { get; }

	public SnoPower Generic_p4SetDungBarbKingsPly { get; }

	public SnoPower Generic_p4SetDungBarbMightEnmy { get; }

	public SnoPower Generic_p4SetDungBarbMightPly { get; }

	public SnoPower Generic_p4SetDungBarbRaekorEnmy { get; }

	public SnoPower Generic_p4SetDungBarbRaekorPly { get; }

	public SnoPower Generic_p4SetDungBarbWastesEnmy { get; }

	public SnoPower Generic_p4SetDungBarbWastesPly { get; }

	public SnoPower Generic_p4SetDungCruAkkhanEnmy { get; }

	public SnoPower Generic_p4SetDungCruAkkhanPly { get; }

	public SnoPower Generic_p4SetDungCruRolandEnmy { get; }

	public SnoPower Generic_p4SetDungCruRolandPly { get; }

	public SnoPower Generic_p4SetDungCruSeekerEnmy { get; }

	public SnoPower Generic_p4SetDungCruSeekerPly { get; }

	public SnoPower Generic_p4SetDungCruThornsEnmy { get; }

	public SnoPower Generic_p4SetDungCruThornsPly { get; }

	public SnoPower Generic_p4SetDungDeathBarbKings { get; }

	public SnoPower Generic_p4SetDungDeathBarbMight { get; }

	public SnoPower Generic_p4SetDungDeathBarbRaekor { get; }

	public SnoPower Generic_p4SetDungDeathBarbWastes { get; }

	public SnoPower Generic_p4SetDungDeathCruAkkhan { get; }

	public SnoPower Generic_p4SetDungDeathCruRoland { get; }

	public SnoPower Generic_p4SetDungDeathCruSeeker { get; }

	public SnoPower Generic_p4SetDungDeathCruThorns { get; }

	public SnoPower Generic_p4SetDungDeathDHEss { get; }

	public SnoPower Generic_p4SetDungDeathDHMar { get; }

	public SnoPower Generic_p4SetDungDeathDHNat { get; }

	public SnoPower Generic_p4SetDungDeathDHShadow { get; }

	public SnoPower Generic_p4SetDungDeathMonkInnas { get; }

	public SnoPower Generic_p4SetDungDeathMonkStorms { get; }

	public SnoPower Generic_p4SetDungDeathMonkSunwuko { get; }

	public SnoPower Generic_p4SetDungDeathMonkUliana { get; }

	public SnoPower Generic_p4SetDungDeathWDHaunt { get; }

	public SnoPower Generic_p4SetDungDeathWDJade { get; }

	public SnoPower Generic_p4SetDungDeathWDSpider { get; }

	public SnoPower Generic_p4SetDungDeathWDTooth { get; }

	public SnoPower Generic_p4SetDungDeathWizFirebird { get; }

	public SnoPower Generic_p4SetDungDeathWizOpus { get; }

	public SnoPower Generic_p4SetDungDeathWizRasha { get; }

	public SnoPower Generic_p4SetDungDeathWizVyr { get; }

	public SnoPower Generic_p4SetDungDHEssEnmy { get; }

	public SnoPower Generic_p4SetDungDHEssPly { get; }

	public SnoPower Generic_p4SetDungDHMarEnmy { get; }

	public SnoPower Generic_p4SetDungDHMarPly { get; }

	public SnoPower Generic_p4SetDungDHNatEnmy { get; }

	public SnoPower Generic_p4SetDungDHNatPly { get; }

	public SnoPower Generic_p4SetDungDHShadowEnmy { get; }

	public SnoPower Generic_p4SetDungDHShadowPly { get; }

	public SnoPower Generic_p4SetDungGenericsEnmy { get; }

	public SnoPower Generic_p4SetDungGenericsPly { get; }

	public SnoPower Generic_p4SetDungGenericsPlyBalance { get; }

	public SnoPower Generic_p4SetDungGenericsPortal { get; }

	public SnoPower Generic_p4SetDungMonkInnasEnmy { get; }

	public SnoPower Generic_p4SetDungMonkInnasPly { get; }

	public SnoPower Generic_p4SetDungMonkStormsEnmy { get; }

	public SnoPower Generic_p4SetDungMonkStormsPly { get; }

	public SnoPower Generic_p4SetDungMonkSunwukoEnmy { get; }

	public SnoPower Generic_p4SetDungMonkSunwukoPly { get; }

	public SnoPower Generic_p4SetDungMonkUlianaEnmy { get; }

	public SnoPower Generic_p4SetDungMonkUlianaPly { get; }

	public SnoPower Generic_p4SetDungMonsterAffixMortarCast { get; }

	public SnoPower Generic_p4SetDungPedestalBarbKings { get; }

	public SnoPower Generic_p4SetDungPedestalBarbMight { get; }

	public SnoPower Generic_p4SetDungPedestalBarbRaekor { get; }

	public SnoPower Generic_p4SetDungPedestalBarbWastes { get; }

	public SnoPower Generic_p4SetDungPedestalCruAkkhan { get; }

	public SnoPower Generic_p4SetDungPedestalCruRoland { get; }

	public SnoPower Generic_p4SetDungPedestalCruSeeker { get; }

	public SnoPower Generic_p4SetDungPedestalCruThorns { get; }

	public SnoPower Generic_p4SetDungPedestalDHEss { get; }

	public SnoPower Generic_p4SetDungPedestalDHMar { get; }

	public SnoPower Generic_p4SetDungPedestalDHNat { get; }

	public SnoPower Generic_p4SetDungPedestalDHShadow { get; }

	public SnoPower Generic_p4SetDungPedestalMonkInnas { get; }

	public SnoPower Generic_p4SetDungPedestalMonkStorms { get; }

	public SnoPower Generic_p4SetDungPedestalMonkSunwuko { get; }

	public SnoPower Generic_p4SetDungPedestalMonkUliana { get; }

	public SnoPower Generic_p4SetDungPedestalWDHaunt { get; }

	public SnoPower Generic_p4SetDungPedestalWDJade { get; }

	public SnoPower Generic_p4SetDungPedestalWDSpider { get; }

	public SnoPower Generic_p4SetDungPedestalWDTooth { get; }

	public SnoPower Generic_p4SetDungPedestalWizFirebird { get; }

	public SnoPower Generic_p4SetDungPedestalWizOpus { get; }

	public SnoPower Generic_p4SetDungPedestalWizRasha { get; }

	public SnoPower Generic_p4SetDungPedestalWizVyr { get; }

	public SnoPower Generic_p4SetDungPortalChecks { get; }

	public SnoPower Generic_p4SetDungWDHauntEnmy { get; }

	public SnoPower Generic_p4SetDungWDHauntPly { get; }

	public SnoPower Generic_p4SetDungWDJadeEnmy { get; }

	public SnoPower Generic_p4SetDungWDJadePly { get; }

	public SnoPower Generic_p4SetDungWDSpiderEnmy { get; }

	public SnoPower Generic_p4SetDungWDSpiderPly { get; }

	public SnoPower Generic_p4SetDungWDToothEnmy { get; }

	public SnoPower Generic_p4SetDungWDToothPly { get; }

	public SnoPower Generic_p4SetDungWestmarchBruteCharge { get; }

	public SnoPower Generic_p4SetDungWizFirebirdEnmy { get; }

	public SnoPower Generic_p4SetDungWizFirebirdPly { get; }

	public SnoPower Generic_p4SetDungWizOpusEnmy { get; }

	public SnoPower Generic_p4SetDungWizOpusPly { get; }

	public SnoPower Generic_p4SetDungWizRashaEnmy { get; }

	public SnoPower Generic_p4SetDungWizRashaPly { get; }

	public SnoPower Generic_p4SetDungWizVyrEnmy { get; }

	public SnoPower Generic_p4SetDungWizVyrPly { get; }

	public SnoPower Generic_P4ShrineDebuffDamage { get; }

	public SnoPower Generic_P4ShrineDebuffSpawner { get; }

	public SnoPower Generic_p4SkeletonZombieSpawnerADeath { get; }

	public SnoPower Generic_P4SpiderBombAODDamage { get; }

	public SnoPower Generic_P4SpiderBombBurrowIn { get; }

	public SnoPower Generic_p4WaspNestDeath { get; }

	public SnoPower Generic_p4WickermanSpawnerADeath { get; }

	public SnoPower Generic_P4WoodWraithSummonSporesCeremonyEvent { get; }

	public SnoPower Generic_p4WoodWraithVineTrap { get; }

	public SnoPower Generic_p4YetiIceBreath { get; }

	public SnoPower Generic_p4YetiIceSpikes { get; }

	public SnoPower Generic_p4YetiMeleeBasic { get; }

	public SnoPower Generic_p4YetiOverheadSmash { get; }

	public SnoPower Generic_p4YetiSnowBoulderRoll { get; }

	public SnoPower Generic_P5ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P610ItemPassiveUniqueMojo010x1tooltipDummy2 { get; }

	public SnoPower Generic_P61ItemPassiveUniqueRing021 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing930 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing932 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing933 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing934 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing935 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing941 { get; }

	public SnoPower Generic_P66ItemPassiveUniqueRing946 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing947 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing948 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing949 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing950 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing951 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing952 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing953 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing956 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing957 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing958 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing959 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing960 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing961 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing962 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing963 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing964 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing965 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing966 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing002 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing006 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing007 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing008 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing009 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing011 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing013 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing014 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing970 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing011 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing013 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing014 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing015 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing100 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing101 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing102 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing103 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing104 { get; }

	public SnoPower Generic_p6CrowHoundProjectile { get; }

	public SnoPower Generic_P6EnvyBossLookSwitch { get; }

	public SnoPower Generic_P6EnvyBossMirrorPortBuff { get; }

	public SnoPower Generic_P6EnvyBossMirrorPortBuffRemove { get; }

	public SnoPower Generic_P6EnvyBossRangedPortBuff { get; }

	public SnoPower Generic_P6EnvyDMGReduction { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing002 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing004 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing005 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing006 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing007 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing008 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing009 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing011 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing013 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing014 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing015 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing016 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing017 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing018 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing019 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing020 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing021 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing022 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing023 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing024 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing025 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing026 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing027 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing028 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing029 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing030 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing031 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing032 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing033 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing034 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing035 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing036 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing038 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing051 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing052 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing053 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing055 { get; }

	public SnoPower Generic_P6ItemPassiveUniqueRing056 { get; }

	public SnoPower Generic_P6NecroBoneSpikesInversePassability { get; }

	public SnoPower Generic_P6NecroBoneSpiritPassive { get; }

	public SnoPower Generic_P6NecroDevourAura { get; }

	public SnoPower Generic_P6NecroFrailtyAura { get; }

	public SnoPower Generic_P6NecroGenericCorpseTargeting { get; }

	public SnoPower Generic_P6NecroGolemMelee { get; }

	public SnoPower Generic_P6NecroRaiseDeadDDecayAura { get; }

	public SnoPower Generic_P6NecroRaiseDeadDDecayAuraSpawn { get; }

	public SnoPower Generic_P6NecroRaiseDeadEArcherAttack { get; }

	public SnoPower Generic_P6NecroRaiseDeadEArcherSpawnAttack { get; }

	public SnoPower Generic_P6NecroRaiseDeadMageSpawnAttack { get; }

	public SnoPower Generic_P6NecroRaiseDeadMageSpawnAttackNoTarget { get; }

	public SnoPower Generic_p6NecroRaiseGolemBloodGolemVeinAoE { get; }

	public SnoPower Generic_P6NecroRaiseGolemBoneGolemTornado { get; }

	public SnoPower Generic_P6NecroRaiseGolemConsumeGolemEatCorpses { get; }

	public SnoPower Generic_p6NecroRaiseGolemDestroyBreakables { get; }

	public SnoPower Generic_P6NecroRaiseGolemFleshGolemDropCorpses { get; }

	public SnoPower Generic_P6NecroRaiseGolemIceGolemFreeze { get; }

	public SnoPower Generic_P6NecroRaiseSkeletonsChargeAttack { get; }

	public SnoPower Generic_p6NecroReviveAngelCorruptPiercingDash { get; }

	public SnoPower Generic_p6NecroRevivearmorScavengerbuff { get; }

	public SnoPower Generic_p6NecroReviveBeastCharge { get; }

	public SnoPower Generic_p6NecroReviveBigRedCharge { get; }

	public SnoPower Generic_p6NecroReviveBogFamilyRangedRapidShot { get; }

	public SnoPower Generic_p6NecroReviveBrickhouseSlam { get; }

	public SnoPower Generic_p6NecroReviveCorpulentExplode { get; }

	public SnoPower Generic_p6NecroReviveCrowHoundProjectile { get; }

	public SnoPower Generic_p6NecroReviveDarkAngelSoulRush { get; }

	public SnoPower Generic_p6NecroRevivedeathMaidenSpinAttack { get; }

	public SnoPower Generic_p6NecroReviveDemonFlyerProjectile { get; }

	public SnoPower Generic_p6NecroReviveDervishWhirlwind { get; }

	public SnoPower Generic_p6NecroReviveFallenShamanProjectile { get; }

	public SnoPower Generic_p6NecroReviveFastMummyDiseaseCloud { get; }

	public SnoPower Generic_p6NecroReviveFloaterAngelProjectile { get; }

	public SnoPower Generic_p6NecroReviveGoatmanRangedProjectile { get; }

	public SnoPower Generic_p6NecroReviveGoatmanShamanLightningbolt { get; }

	public SnoPower Generic_P6NecroReviveGoatMutantRangedProjectile { get; }

	public SnoPower Generic_P6NecroReviveGoatMutantShamanBlast { get; }

	public SnoPower Generic_p6NecroReviveHoodedNightmareProjectile { get; }

	public SnoPower Generic_P6NecroReviveIcePorcupineShot { get; }

	public SnoPower Generic_p6NecroReviveLacuniLeap { get; }

	public SnoPower Generic_p6NecroReviveLacuniMaleDoubleSwing { get; }

	public SnoPower Generic_p6NecroReviveLeaperAngelLeap { get; }

	public SnoPower Generic_P6NecroReviveMelee { get; }

	public SnoPower Generic_p6NecroReviveMermaidRangedProjectile { get; }

	public SnoPower Generic_p6NecroReviveMoleMutantRangedProjectile { get; }

	public SnoPower Generic_p6NecroReviveMoleMutantShamanProjectile { get; }

	public SnoPower Generic_p6NecroReviveMorluSpellcasterBreathOfFire { get; }

	public SnoPower Generic_p6NecroReviveNightScreamerProjectile { get; }

	public SnoPower Generic_p6NecroRevivepandExtRanged { get; }

	public SnoPower Generic_p6NecroRevivePortalGuardianMinionprojectile { get; }

	public SnoPower Generic_p6NecroReviveQuillDemonProjectile { get; }

	public SnoPower Generic_p6NecroReviverockwormprojectile { get; }

	public SnoPower Generic_p6NecroReviveSandWaspProjectile { get; }

	public SnoPower Generic_p6NecroReviveScorpionBugHoverProjectile { get; }

	public SnoPower Generic_p6NecroReviveShepherdProjectile { get; }

	public SnoPower Generic_p6NecroReviveSkeletonArcherProjectile { get; }

	public SnoPower Generic_p6NecroReviveskeletonMageProjectile { get; }

	public SnoPower Generic_p6NecroReviveSkeletonSummonerProjectile { get; }

	public SnoPower Generic_p6NecroReviveSniperAngelcloseRangedAttack { get; }

	public SnoPower Generic_p6NecroReviveSuccubusBloodStar { get; }

	public SnoPower Generic_p6NecroReviveTempleCultistCasterProjectile { get; }

	public SnoPower Generic_p6NecroReviveTempleCultistSuicide { get; }

	public SnoPower Generic_p6NecroReviveThousandPounderKnockback { get; }

	public SnoPower Generic_p6NecroReviveTriuneSummonerProjectile { get; }

	public SnoPower Generic_p6NecroReviveUnburiedKnockback { get; }

	public SnoPower Generic_p6NecroReviveWerewolfMelee { get; }

	public SnoPower Generic_p6NecroReviveWestmarchBruteBDecapitateSlide { get; }

	public SnoPower Generic_p6NecroReviveWestmarchBruteCharge { get; }

	public SnoPower Generic_p6NecroReviveWestmarchHoundTaunt { get; }

	public SnoPower Generic_p6NecroReviveWestmarchHoundTauntSearch { get; }

	public SnoPower Generic_p6NecroRevivewestmarchRangedProjectile { get; }

	public SnoPower Generic_P6NecroReviveWraithMelee { get; }

	public SnoPower Generic_p6NecroReviveZombieFemaleProjectile { get; }

	public SnoPower Generic_P6NecroSimulacrumWeaponMeleeInstant { get; }

	public SnoPower Generic_P6NecroSkeletalWarriorMelee { get; }

	public SnoPower Generic_P6NecroSkeletalWarriorUberMelee { get; }

	public SnoPower Generic_P6NecroSkeletonMageFireProjectile { get; }

	public SnoPower Generic_P6NecroTraitGolemSpawner { get; }

	public SnoPower Generic_P6NecroTraitSkeletonSpawner { get; }

	public SnoPower Generic_p6RavenFlyerJumpBackAttack { get; }

	public SnoPower Generic_p6RavenFlyerPathingBuff { get; }

	public SnoPower Generic_p6SetDungDeathNecroBlood { get; }

	public SnoPower Generic_p6SetDungDeathNecroBone { get; }

	public SnoPower Generic_p6SetDungDeathNecroPlague { get; }

	public SnoPower Generic_p6SetDungDeathNecroSaint { get; }

	public SnoPower Generic_p6SetDungNecroBloodEnmy { get; }

	public SnoPower Generic_p6SetDungNecroBloodPly { get; }

	public SnoPower Generic_p6SetDungNecroBoneEnmy { get; }

	public SnoPower Generic_p6SetDungNecroBonePly { get; }

	public SnoPower Generic_p6SetDungNecroPlagueEnmy { get; }

	public SnoPower Generic_p6SetDungNecroPlaguePly { get; }

	public SnoPower Generic_p6SetDungNecroSaintEnmy { get; }

	public SnoPower Generic_p6SetDungNecroSaintPly { get; }

	public SnoPower Generic_p6SetDungPedestalNecroBlood { get; }

	public SnoPower Generic_p6SetDungPedestalNecroBone { get; }

	public SnoPower Generic_p6SetDungPedestalNecroPlague { get; }

	public SnoPower Generic_p6SetDungPedestalNecroSaint { get; }

	public SnoPower Generic_P6ShepherdBossTeleportOutro { get; }

	public SnoPower Generic_p6ShepherdRangedAttack { get; }

	public SnoPower Generic_p6ShepherdRangedAttackBoss { get; }

	public SnoPower Generic_p6ShepherdRangedAttackBossTransformed { get; }

	public SnoPower Generic_p6ShepherdRangedAttackNodmg { get; }

	public SnoPower Generic_P6ShepherdSpawnBossOutro { get; }

	public SnoPower Generic_P6ShepherdSpawnIntro { get; }

	public SnoPower Generic_P6ShepherdSpawnOutro { get; }

	public SnoPower Generic_P6ShepherdTeleportIntro { get; }

	public SnoPower Generic_P6ShepherdTeleportIntroMirror { get; }

	public SnoPower Generic_P6ShepherdTeleportOutro { get; }

	public SnoPower Generic_p6TempleCultistLobbedShot { get; }

	public SnoPower Generic_p6TempleCultistSuicide { get; }

	public SnoPower Generic_p6TempleMonstrosityGrenadeVolley { get; }

	public SnoPower Generic_p6TempleMonstrosityMeleeLance { get; }

	public SnoPower Generic_P6WerewolfClawRush { get; }

	public SnoPower Generic_P6WerewolfHowl { get; }

	public SnoPower Generic_P6WerewolfJumpBack { get; }

	public SnoPower Generic_P6WerewolfLeap { get; }

	public SnoPower Generic_P6WerewolfLeapFire { get; }

	public SnoPower Generic_P6WerewolfMelee { get; }

	public SnoPower Generic_P6WerewolfMeleeFire { get; }

	public SnoPower Generic_P71ItemPassiveEthereal001 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal002 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal003 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal004 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal005 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal006 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal007 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal008 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal009 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal010 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal011 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal012 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal013 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal014 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal015 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal016 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal017 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal018 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal019 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal020 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal021 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal022 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal023 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal024 { get; }

	public SnoPower Generic_P71ItemPassiveEthereal025 { get; }

	public SnoPower Generic_P71ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P7ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P7ItemPassiveUniqueRing002 { get; }

	public SnoPower Generic_P7ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_PagesBuffDamage { get; }

	public SnoPower Generic_PagesBuffElectrified { get; }

	public SnoPower Generic_PagesBuffElectrifiedCast { get; }

	public SnoPower Generic_PagesBuffElectrifiedCastTieredRift { get; }

	public SnoPower Generic_PagesBuffElectrifiedTieredRift { get; }

	public SnoPower Generic_PagesBuffInfiniteCasting { get; }

	public SnoPower Generic_PagesBuffInvulnerable { get; }

	public SnoPower Generic_PagesBuffInvulnerableCastv2 { get; }

	public SnoPower Generic_PagesBuffRunSpeed { get; }

	public SnoPower Generic_PagesBuffRunSpeedKnockbackCast { get; }

	public SnoPower Generic_PagesBuffRunSpeedWallerCast { get; }

	public SnoPower Generic_PagesBuffRunSpeedWallerCastUpgrade { get; }

	public SnoPower Generic_PandemoniumPortal { get; }

	public SnoPower Generic_PandemoniumPortalDiablo { get; }

	public SnoPower Generic_PandemoniumPortalghom { get; }

	public SnoPower Generic_PandemoniumPortalSiegeBreaker { get; }

	public SnoPower Generic_PandemoniumPortalSkeletonKing { get; }

	public SnoPower Generic_PassiveChallengeRift { get; }

	public SnoPower Generic_PassiveSetDungeon { get; }

	public SnoPower Generic_PickupNearby { get; }

	public SnoPower Generic_PlagueOfToadsKnockback { get; }

	public SnoPower Generic_PlayerUpscaledBuff { get; }

	public SnoPower Generic_ProxyDelayedPower { get; }

	public SnoPower Generic_Punch { get; }

	public SnoPower Generic_PVPBuff { get; }

	public SnoPower Generic_PVPcontrolpoint { get; }

	public SnoPower Generic_PvPDamageBuff { get; }

	public SnoPower Generic_PvPDeathstreakBuff { get; }

	public SnoPower Generic_PvPHealingMacguffin { get; }

	public SnoPower Generic_PVPhill { get; }

	public SnoPower Generic_PvPHunterBuff { get; }

	public SnoPower Generic_PvPLevelEqualizerBuff { get; }

	public SnoPower Generic_PVPPeanutNeutralObjective { get; }

	public SnoPower Generic_PvPRangedProjectile { get; }

	public SnoPower Generic_PVPRoundEndBuff { get; }

	public SnoPower Generic_PVPShrineMurderball { get; }

	public SnoPower Generic_PVPSkirmishBuff { get; }

	public SnoPower Generic_PVPspawnersetup { get; }

	public SnoPower Generic_PVPspawnerTowerDefenders { get; }

	public SnoPower Generic_PVPStationaryattack { get; }

	public SnoPower Generic_PVPThreeControlSpawnDefenders { get; }

	public SnoPower Generic_pxBoneyardsCampSnakemanSpawner { get; }

	public SnoPower Generic_pxbountytestchaosportalssummonChampion { get; }

	public SnoPower Generic_pxBridgeCampDemonSpawner { get; }

	public SnoPower Generic_pxCampPortalSpawner { get; }

	public SnoPower Generic_pxCraterCampDemonSpawner { get; }

	public SnoPower Generic_pxFesteringWoodsCampGhoulSpawner { get; }

	public SnoPower Generic_pxGardensOfHopeCampDemonSpawner { get; }

	public SnoPower Generic_pxGraveyardCampReaperSpawner { get; }

	public SnoPower Generic_pxHighlandsCampCultistSpawner { get; }

	public SnoPower Generic_pxLeoricsDungeonCampDemonSpawner { get; }

	public SnoPower Generic_pxOasisCampSnakemanSpawner { get; }

	public SnoPower Generic_pxQuestFollowerDamageSetup { get; }

	public SnoPower Generic_pxRampartsCampDemonSpawner { get; }

	public SnoPower Generic_pxRuinsFrostKingKanaiWhirlwind { get; }

	public SnoPower Generic_pxRuinsFrostThreeGuardiansGoatmanLeap { get; }

	public SnoPower Generic_pxSpiderCavesCampCocoonHumanVictim { get; }

	public SnoPower Generic_pxSpiderCavesCampSpiderSpawner { get; }

	public SnoPower Generic_pxSpireCampDemonSpawner { get; }

	public SnoPower Generic_pxStingingWindsCampCultistSpawner { get; }

	public SnoPower Generic_pxWestmarchCampReaperSpawner { get; }

	public SnoPower Generic_pxWildernessCampTemplarSpawner { get; }

	public SnoPower Generic_QuestCanyonBridgeEnchantressRevealFootsteps { get; }

	public SnoPower Generic_QuestCanyonBridgePlayerRevealFootsteps { get; }

	public SnoPower Generic_QuillDemonProjectile { get; }

	public SnoPower Generic_QuillDemonProjectileFastAttack { get; }

	public SnoPower Generic_RandomMovespeedScripted { get; }

	public SnoPower Generic_RangedEscortProjectile { get; }

	public SnoPower Generic_RatKingLifetimeBuff { get; }

	public SnoPower Generic_RedWingsBuff { get; }

	public SnoPower Generic_RemoveBurrowEffect { get; }

	public SnoPower Generic_ResurrectFallen { get; }

	public SnoPower Generic_ResurrectionBuff { get; }

	public SnoPower Generic_RockwormAttack { get; }

	public SnoPower Generic_RockwormBurrowAndTeleport { get; }

	public SnoPower Generic_RockwormBurstOut { get; }

	public SnoPower Generic_RockwormGrab { get; }

	public SnoPower Generic_RockwormGrabBurstOut { get; }

	public SnoPower Generic_RockwormHideIdle { get; }

	public SnoPower Generic_RockwormPreBurst { get; }

	public SnoPower Generic_RockwormRetreat { get; }

	public SnoPower Generic_RockwormWeb { get; }

	public SnoPower Generic_RootTryGrab { get; }

	public SnoPower Generic_SandMonsterBurrowOut { get; }

	public SnoPower Generic_SandMonsterBurrowOutLong { get; }

	public SnoPower Generic_SandMonsterSandWall { get; }

	public SnoPower Generic_SandmonsterWeaponMeleeInstant { get; }

	public SnoPower Generic_SandsharkBurrowIn { get; }

	public SnoPower Generic_SandsharkBurrowOut { get; }

	public SnoPower Generic_SandTornadoOnSpawn { get; }

	public SnoPower Generic_SandWaspProjectile { get; }

	public SnoPower Generic_ScavengerBurrowIn { get; }

	public SnoPower Generic_ScavengerBurrowOut { get; }

	public SnoPower Generic_ScavengerLeap { get; }

	public SnoPower Generic_ScoundrelAnatomy { get; }

	public SnoPower Generic_ScoundrelBandage { get; }

	public SnoPower Generic_ScoundrelCheatDeathPassive { get; }

	public SnoPower Generic_ScoundrelCripplingShot { get; }

	public SnoPower Generic_ScoundrelDebuffCloud { get; }

	public SnoPower Generic_ScoundrelHysteria { get; }

	public SnoPower Generic_ScoundrelPiercingShot { get; }

	public SnoPower Generic_ScoundrelPowerShot { get; }

	public SnoPower Generic_ScoundrelRangedProjectile { get; }

	public SnoPower Generic_ScoundrelRunAway { get; }

	public SnoPower Generic_ScoundrelVanishV2 { get; }

	public SnoPower Generic_ScrollBuff { get; }

	public SnoPower Generic_SeasonThemeBarbarianWhirlwind { get; }

	public SnoPower Generic_SelectingSkill { get; }

	public SnoPower Generic_SetItemBonusBuff { get; }

	public SnoPower Generic_SetModeEscortFollow { get; }

	public SnoPower Generic_ShieldSkeletonShield { get; }

	public SnoPower Generic_ShrineCallMonster { get; }

	public SnoPower Generic_ShrineDesecratedBlessed { get; }

	public SnoPower Generic_ShrineDesecratedEnlightened { get; }

	public SnoPower Generic_ShrineDesecratedFortune { get; }

	public SnoPower Generic_ShrineDesecratedFrenzied { get; }

	public SnoPower Generic_ShrineDesecratedHoarder { get; }

	public SnoPower Generic_ShrineDesecratedReloaded { get; }

	public SnoPower Generic_ShrineDesecratedtreasureGoblin { get; }

	public SnoPower Generic_ShrinePowerBlessed { get; }

	public SnoPower Generic_ShrinePowerEnlightened { get; }

	public SnoPower Generic_ShrinePowerFortune { get; }

	public SnoPower Generic_ShrinePowerFrenzied { get; }

	public SnoPower Generic_SidekickStatsBoostBuff { get; }

	public SnoPower Generic_SidekickWeaponDamageBoostBuff { get; }

	public SnoPower Generic_SiegebreakerDemonBite { get; }

	public SnoPower Generic_SiegebreakerDemonCharge { get; }

	public SnoPower Generic_SiegebreakerDemonChargeNew { get; }

	public SnoPower Generic_SiegebreakerDemonGrab { get; }

	public SnoPower Generic_SiegebreakerDemonGrabToBite { get; }

	public SnoPower Generic_SiegebreakerDemonLookAround { get; }

	public SnoPower Generic_SiegebreakerDemonMiniCharge { get; }

	public SnoPower Generic_SiegebreakerDemonPound { get; }

	public SnoPower Generic_SiegebreakerDemonRoar { get; }

	public SnoPower Generic_SiegebreakerDemonStomp { get; }

	public SnoPower Generic_SiegebreakerEnrage { get; }

	public SnoPower Generic_SiegeBreakerReflectsDamageCast { get; }

	public SnoPower Generic_SkeletonArcherProjectile { get; }

	public SnoPower Generic_SkeletonKingCleave { get; }

	public SnoPower Generic_SkeletonKingSummonSkeleton { get; }

	public SnoPower Generic_SkeletonKingTeleport { get; }

	public SnoPower Generic_SkeletonKingTeleportAway { get; }

	public SnoPower Generic_SkeletonKingWhirlwind { get; }

	public SnoPower Generic_skeletonMageColdprojectile { get; }

	public SnoPower Generic_skeletonMageFireAOE { get; }

	public SnoPower Generic_skeletonMageFireprojectile { get; }

	public SnoPower Generic_skeletonMageLightningpierce { get; }

	public SnoPower Generic_skeletonMagepoisondeath { get; }

	public SnoPower Generic_skeletonMagePoisonpierce { get; }

	public SnoPower Generic_SkeletonSummonerProjectile { get; }

	public SnoPower Generic_SkillOverrideStartedOrEnded { get; }

	public SnoPower Generic_SnakemanCasterElectricBurst { get; }

	public SnoPower Generic_SnakemanMeleeStealth { get; }

	public SnoPower Generic_SnakemanMeleeUnstealth { get; }

	public SnoPower Generic_SoaringAscend { get; }

	public SnoPower Generic_SoaringDescend { get; }

	public SnoPower Generic_SoulRipperDespairTongueLash { get; }

	public SnoPower Generic_SoulRipperTongueLash { get; }

	public SnoPower Generic_SpiderQueenVomitSpidersCharge { get; }

	public SnoPower Generic_SpiderQueenVomitSpidersVomit { get; }

	public SnoPower Generic_SpiderQueenWebSpit { get; }

	public SnoPower Generic_SpiderSprintThroughObjectsTo { get; }

	public SnoPower Generic_SpiderWebImmobolize { get; }

	public SnoPower Generic_SpiderWebSlow { get; }

	public SnoPower Generic_SpiderWebSlowSpit { get; }

	public SnoPower Generic_SplashDamageProc { get; }

	public SnoPower Generic_SporeCloud { get; }

	public SnoPower Generic_StealthBuff { get; }

	public SnoPower Generic_StitchExplode { get; }

	public SnoPower Generic_StitchMeleeAlternate { get; }

	public SnoPower Generic_StitchPush { get; }

	public SnoPower Generic_SuccubusBloodStar { get; }

	public SnoPower Generic_SuccubusBloodStarLR { get; }

	public SnoPower Generic_SuccubusFly { get; }

	public SnoPower Generic_SuccubusLeap { get; }

	public SnoPower Generic_SuicideProc { get; }

	public SnoPower Generic_SuicideScripted { get; }

	public SnoPower Generic_Summoned { get; }

	public SnoPower Generic_SummonFallenAUnique01 { get; }

	public SnoPower Generic_SummonFallenOnSpawn { get; }

	public SnoPower Generic_SummoningMachineSummon { get; }

	public SnoPower Generic_SummonSkeleton { get; }

	public SnoPower Generic_SummonSkeletonJondar { get; }

	public SnoPower Generic_SummonSkeletonOnSpawn { get; }

	public SnoPower Generic_SummonSkeletonOrb { get; }

	public SnoPower Generic_SummonSkeletonPillar { get; }

	public SnoPower Generic_SummonTriuneDemon { get; }

	public SnoPower Generic_SummonZombieCrawler { get; }

	public SnoPower Generic_SummonZombieVomit { get; }

	public SnoPower Generic_Swarmdeath { get; }

	public SnoPower Generic_TarPitSlowOff { get; }

	public SnoPower Generic_TarPitSlowOn { get; }

	public SnoPower Generic_TauntedMonsterRangedProjectile { get; }

	public SnoPower Generic_TauntedWeaponMeleeInstant { get; }

	public SnoPower Generic_TeleportCheckPathPassability { get; }

	public SnoPower Generic_TeleportToPlayer { get; }

	public SnoPower Generic_TeleportToPlayerCast { get; }

	public SnoPower Generic_TeleportToWaypoint { get; }

	public SnoPower Generic_TeleportToWaypointCast { get; }

	public SnoPower Generic_TemplarCheatDeathPassive { get; }

	public SnoPower Generic_TemplarGuardianV2 { get; }

	public SnoPower Generic_TemplarHeal110 { get; }

	public SnoPower Generic_TemplarInspire { get; }

	public SnoPower Generic_TemplarIntervene { get; }

	public SnoPower Generic_TemplarInterveneProc { get; }

	public SnoPower Generic_TemplarIntimidate { get; }

	public SnoPower Generic_TemplarLoyalty { get; }

	public SnoPower Generic_TemplarMeleeInstant { get; }

	public SnoPower Generic_TemplarOnslaught { get; }

	public SnoPower Generic_TemplarOnslaughtV2 { get; }

	public SnoPower Generic_TemplarShieldCharge { get; }

	public SnoPower Generic_TentacleHorseAUnique01Charge { get; }

	public SnoPower Generic_TerrorDemonMeleeStrike { get; }

	public SnoPower Generic_TerrorDemonShadowPhase { get; }

	public SnoPower Generic_TerrorDemonShadowPhaseEnd { get; }

	public SnoPower Generic_TestSpikeTrapRuins { get; }

	public SnoPower Generic_Thorns { get; }

	public SnoPower Generic_ThousandPounderKnockback { get; }

	public SnoPower Generic_ThousandPounderMelee { get; }

	public SnoPower Generic_tongueprototype { get; }

	public SnoPower Generic_TraitBarbarianFury { get; }

	public SnoPower Generic_TraitMonkSpirit { get; }

	public SnoPower Generic_TransformToActivatedTriune { get; }

	public SnoPower Generic_trDunCathWallCollapseDamage { get; }

	public SnoPower Generic_trDunCathWallCollapseDamageoffset { get; }

	public SnoPower Generic_TreasureGoblinAnniversaryEscape { get; }

	public SnoPower Generic_TreasureGoblinAnniversaryThrowPortal { get; }

	public SnoPower Generic_TreasureGoblinEscape { get; }

	public SnoPower Generic_TreasureGoblinPause { get; }

	public SnoPower Generic_TreasureGoblinPlayAlertSound { get; }

	public SnoPower Generic_TreasureGoblinPortalIn { get; }

	public SnoPower Generic_TreasureGoblinThrowPortal { get; }

	public SnoPower Generic_TreasureGoblinThrowPortalBackup { get; }

	public SnoPower Generic_TreasureGoblinThrowPortalFast { get; }

	public SnoPower Generic_TreasureGoblinUsePortal { get; }

	public SnoPower Generic_TriuneBerserkerPowerHit { get; }

	public SnoPower Generic_TriuneSummonerProjectile { get; }

	public SnoPower Generic_TriuneSummonerShield { get; }

	public SnoPower Generic_TriuneSummonerSplitSummonCast { get; }

	public SnoPower Generic_TriuneVesselCharge { get; }

	public SnoPower Generic_TriuneVesselOverpower { get; }

	public SnoPower Generic_trOutLogStackShortDamage { get; }

	public SnoPower Generic_trOutLogStackTrap { get; }

	public SnoPower Generic_trouttristramfieldspunjitrapaoe { get; }

	public SnoPower Generic_trouttristramfieldspunjitrapmirroraoe { get; }

	public SnoPower Generic_UberDespairMeleeCleave { get; }

	public SnoPower Generic_UberDespairSummonMinion { get; }

	public SnoPower Generic_UberDespairSummonMinionDiablo { get; }

	public SnoPower Generic_UberDespairTeleport { get; }

	public SnoPower Generic_UberDespairTeleportEnrageDiablo { get; }

	public SnoPower Generic_UberDespairVolley { get; }

	public SnoPower Generic_UberDespairVolleyDiablo { get; }

	public SnoPower Generic_UberDiabloMirrorImage { get; }

	public SnoPower Generic_UberDiabloStompAndStun { get; }

	public SnoPower Generic_UberGluttonyBreathAttack { get; }

	public SnoPower Generic_UberGluttonyGasCloud { get; }

	public SnoPower Generic_UberGluttonyGasCloudDiablo { get; }

	public SnoPower Generic_UberGluttonyLoogiespawn { get; }

	public SnoPower Generic_UberMaghdaMothDust { get; }

	public SnoPower Generic_UberMaghdaPunish { get; }

	public SnoPower Generic_UberMaghdaPunishShielded { get; }

	public SnoPower Generic_UberMaghdaSummonBeserker { get; }

	public SnoPower Generic_UberMaghdaSummonBeserkerDiablo { get; }

	public SnoPower Generic_UberSiegebreakerDemonPound { get; }

	public SnoPower Generic_UberSiegebreakerDemonStomp { get; }

	public SnoPower Generic_UberSkeletonKingCleave { get; }

	public SnoPower Generic_UberSkeletonKingSummonSkeleton { get; }

	public SnoPower Generic_UberSkeletonKingSummonSkeletonDiablo { get; }

	public SnoPower Generic_UberSkeletonKingWhirlwind { get; }

	public SnoPower Generic_UberZoltunKulleCollapseCeiling { get; }

	public SnoPower Generic_UberZoltunKulleEnergyTwister { get; }

	public SnoPower Generic_UberZoltunKulleFieryBoulder { get; }

	public SnoPower Generic_UberZoltunKulleSlowTime { get; }

	public SnoPower Generic_UberZoltunKulleSlowTimeDiablo { get; }

	public SnoPower Generic_UberZoltunKulleTeleport { get; }

	public SnoPower Generic_UnburiedBossCleave { get; }

	public SnoPower Generic_UnburiedKnockback { get; }

	public SnoPower Generic_UnburiedMeleeAttack { get; }

	public SnoPower Generic_UnburiedWreckableAttack { get; }

	public SnoPower Generic_UnholyShield { get; }

	public SnoPower Generic_UninterruptibleDuringBuff { get; }

	public SnoPower Generic_UniqueMonsterEarthquakePrototype { get; }

	public SnoPower Generic_UniqueMonsterGenericAOENova { get; }

	public SnoPower Generic_UniqueMonsterGenericAOERandomAroundOwner { get; }

	public SnoPower Generic_UniqueMonsterGenericAOETargeted { get; }

	public SnoPower Generic_UniqueMonsterGenericProjectile { get; }

	public SnoPower Generic_UniqueMonsterGenericProjectile2 { get; }

	public SnoPower Generic_UniqueMonsterGenericProjectileAllPlayers { get; }

	public SnoPower Generic_UniqueMonsterGenericSummon { get; }

	public SnoPower Generic_UniqueMonsterGenericSummon2 { get; }

	public SnoPower Generic_UniqueMonsterIceTrailPassivePrototype { get; }

	public SnoPower Generic_UniqueMonsterTempestRushPrototype { get; }

	public SnoPower Generic_UntargetableDuringBuff { get; }

	public SnoPower Generic_UrzaelStompAndStun { get; }

	public SnoPower Generic_UseArcaneGlyph { get; }

	public SnoPower Generic_UseDungeonStone { get; }

	public SnoPower Generic_UseHealthGlyph { get; }

	public SnoPower Generic_UseItem { get; }

	public SnoPower Generic_UseLootRunPortal { get; }

	public SnoPower Generic_UseLootRunProgressGlyph { get; }

	public SnoPower Generic_UseManaGlyph { get; }

	public SnoPower Generic_UseStoneOfRecall { get; }

	public SnoPower Generic_Walk { get; }

	public SnoPower Generic_WallMonsterSpawn { get; }

	public SnoPower Generic_WallMonsterSpawnSiegeBreaker { get; }

	public SnoPower Generic_Warp { get; }

	public SnoPower Generic_WarpInMagical { get; }

	public SnoPower Generic_waterloggedCorpseEelSpawn { get; }

	public SnoPower Generic_waterloggedCorpsePoisonCloud { get; }

	public SnoPower Generic_waterTowerAOasiscaOutBreakableDamage { get; }

	public SnoPower Generic_WeaponMeleeInstant { get; }

	public SnoPower Generic_WeaponMeleeInstantBothHand { get; }

	public SnoPower Generic_WeaponMeleeInstantCowKing { get; }

	public SnoPower Generic_WeaponMeleeInstantFreezeFacing { get; }

	public SnoPower Generic_WeaponMeleeInstantOffHand { get; }

	public SnoPower Generic_WeaponMeleeInstantShortEscape { get; }

	public SnoPower Generic_WeaponMeleeInstantWreckables { get; }

	public SnoPower Generic_WeaponMeleeNoClose { get; }

	public SnoPower Generic_WeaponMeleeObstruction { get; }

	public SnoPower Generic_WeaponMeleeReachInstant { get; }

	public SnoPower Generic_WeaponMeleeReachInstantFreezeFacing { get; }

	public SnoPower Generic_WeaponRangedInstant { get; }

	public SnoPower Generic_WeaponRangedProjectile { get; }

	public SnoPower Generic_WeaponRangedWand { get; }

	public SnoPower Generic_WitchdoctorCorpseSpiderLeap { get; }

	public SnoPower Generic_WitchdoctorFetishArmyHunter { get; }

	public SnoPower Generic_WitchdoctorFetishArmyMelee { get; }

	public SnoPower Generic_WitchdoctorFetishArmyPoisonDart { get; }

	public SnoPower Generic_WitchdoctorFetishArmyShaman { get; }

	public SnoPower Generic_WitchdoctorFetishSycophantsMelee { get; }

	public SnoPower Generic_WitchdoctorGargantuanCleave { get; }

	public SnoPower Generic_WitchdoctorGargantuanPoisonCloud { get; }

	public SnoPower Generic_WitchdoctorGargantuanSlam { get; }

	public SnoPower Generic_WitchdoctorGargantuanSmash { get; }

	public SnoPower Generic_WitchdoctorHexChickenWalk { get; }

	public SnoPower Generic_WitchdoctorHexExplode { get; }

	public SnoPower Generic_WitchdoctorHexFetish { get; }

	public SnoPower Generic_WitchdoctorHexFetishHeal { get; }

	public SnoPower Generic_WitchdoctorPlagueOfToadsBigToadAttack { get; }

	public SnoPower Generic_WitchdoctorPlagueOfToadsBigToadTongueSlap { get; }

	public SnoPower Generic_WitchdoctorSpiritBarrageRuneCAOE { get; }

	public SnoPower Generic_WitchdoctorZombieDogFireAoE { get; }

	public SnoPower Generic_WitchdoctorZombieDogMelee { get; }

	public SnoPower Generic_WitchdoctorZombieDogPoisonDoT { get; }

	public SnoPower Generic_WizardArcaneTorrentRuneCMine { get; }

	public SnoPower Generic_WizardEnergyShield { get; }

	public SnoPower Generic_WizardHydraDefaultFirePrototype { get; }

	public SnoPower Generic_WizardHydraRuneAcidPrototype { get; }

	public SnoPower Generic_WizardHydraRuneArcanePrototype { get; }

	public SnoPower Generic_WizardHydraRuneBigPrototype { get; }

	public SnoPower Generic_WizardHydraRuneFirePrototype { get; }

	public SnoPower Generic_WizardHydraRuneFrostPrototype { get; }

	public SnoPower Generic_WizardHydraRuneLightningPrototype { get; }

	public SnoPower Generic_WizardMagicMissileCount { get; }

	public SnoPower Generic_WizardMagicMissileDamage { get; }

	public SnoPower Generic_WizardMagicMissileSpeed { get; }

	public SnoPower Generic_WoDFlagBuff { get; }

	public SnoPower Generic_WoodWraithSummonSpores { get; }

	public SnoPower Generic_WorldCreatingBuff { get; }

	public SnoPower Generic_x1abattoirfurnace01 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinner { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerEvent { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase1 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase2 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase3 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwise { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEvent { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase1 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase2 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase3 { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwise { get; }

	public SnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwiseEvent { get; }

	public SnoPower Generic_x1AbattoirfurnaceWall { get; }

	public SnoPower Generic_x1AdriaArenaFloorPanelFire { get; }

	public SnoPower Generic_x1AdriaArenaFloorPanelStart { get; }

	public SnoPower Generic_X1AdriaBossArenaGasOff0 { get; }

	public SnoPower Generic_X1AdriaBossArenaGasOff1 { get; }

	public SnoPower Generic_X1AdriaBossArenaGasOn0 { get; }

	public SnoPower Generic_X1AdriaBossArenaGasOn1 { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerActivate { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerInitialPoolsBuff { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerLifetimeBuff { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerRoomPools { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsInner { get; }

	public SnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsOuter { get; }

	public SnoPower Generic_x1AdriaDelayedTeleportAttack { get; }

	public SnoPower Generic_x1AdriaDelayedTeleportCauldronActivate { get; }

	public SnoPower Generic_x1AdriaDelayedTeleportStart { get; }

	public SnoPower Generic_x1AdriaJumpBack { get; }

	public SnoPower Generic_x1AdriaPhaseOneAIState { get; }

	public SnoPower Generic_x1AdriaPhaseTwoAIState { get; }

	public SnoPower Generic_x1AdriaScriptedSequence180Turn { get; }

	public SnoPower Generic_x1AdriaSpitAtPlayer { get; }

	public SnoPower Generic_x1AdriaWingSweepLeft { get; }

	public SnoPower Generic_x1AdriaWingSweepRight { get; }

	public SnoPower Generic_X1armorScavengerAsteroidRain { get; }

	public SnoPower Generic_x1armorScavengerbuff { get; }

	public SnoPower Generic_x1armorScavengerBurrowIn { get; }

	public SnoPower Generic_x1armorScavengerBurrowOut { get; }

	public SnoPower Generic_x1armorScavengerPreBurrow { get; }

	public SnoPower Generic_X1AsteroidBasic { get; }

	public SnoPower Generic_X1AsteroidBasicSmall { get; }

	public SnoPower Generic_X1AsteroidPool { get; }

	public SnoPower Generic_X1AsteroidSpawn { get; }

	public SnoPower Generic_X1BarbarianAvalanchev2Passive { get; }

	public SnoPower Generic_X1BloodhawkEventBallistaBossFuriousCharge { get; }

	public SnoPower Generic_x1bogbearTrap { get; }

	public SnoPower Generic_x1BogBearTrapTrigger { get; }

	public SnoPower Generic_x1BogBlightBurrowIn { get; }

	public SnoPower Generic_x1BogBlightBurrowOut { get; }

	public SnoPower Generic_x1BogBlightPustuleDeath { get; }

	public SnoPower Generic_x1BogBlightPustuleSpawn { get; }

	public SnoPower Generic_x1BogBlightPustuleSpawnCon { get; }

	public SnoPower Generic_x1BogBogWater { get; }

	public SnoPower Generic_x1BogBogWaterlarge { get; }

	public SnoPower Generic_x1BogBogWatermedium { get; }

	public SnoPower Generic_x1BogFamilyBruteCharge { get; }

	public SnoPower Generic_x1BogFamilyBruteShout { get; }

	public SnoPower Generic_x1BogFamilyBruteSummonMeleeAction { get; }

	public SnoPower Generic_x1BogFamilyBruteSummonMeleeActionUnique { get; }

	public SnoPower Generic_x1BogFamilyBruteThrowDude { get; }

	public SnoPower Generic_X1BogFamilyGuardTowerSetup { get; }

	public SnoPower Generic_x1BogFamilyMeleeTransform { get; }

	public SnoPower Generic_x1BogFamilyRangedBearTrap { get; }

	public SnoPower Generic_x1BogFamilyRangedBearTrapFromTower { get; }

	public SnoPower Generic_x1BogFamilyRangedBearTrapFromTowerReturnToFacing { get; }

	public SnoPower Generic_x1BogFamilyRangedRapidShot { get; }

	public SnoPower Generic_x1BogFamilyRangedRapidShotFromTower { get; }

	public SnoPower Generic_x1BogFamilyRangedRapidShotFromTowerReturnToFacing { get; }

	public SnoPower Generic_X1BogKingOfTheHillLeap { get; }

	public SnoPower Generic_x1BogPlantexplodeKnockback { get; }

	public SnoPower Generic_x1CatacombsDoorAonDeath { get; }

	public SnoPower Generic_x1CatacombsFloorRunesAonDeath { get; }

	public SnoPower Generic_x1CatacombsSpiritTotemactivate { get; }

	public SnoPower Generic_x1CesspoolSlimePosionAttack { get; }

	public SnoPower Generic_x1ChallengeBuffImmuneStun { get; }

	public SnoPower Generic_X1ChallengeLureSupersizeLure { get; }

	public SnoPower Generic_x1CrazedAngelArcherFireArrow { get; }

	public SnoPower Generic_X1CrusaderLawsOfFate { get; }

	public SnoPower Generic_X1CrusaderLawsOfFatePassive { get; }

	public SnoPower Generic_X1CrusaderLawsOfHope { get; }

	public SnoPower Generic_X1CrusaderLawsOfHopePassive { get; }

	public SnoPower Generic_X1CrusaderLawsOfHopePassive2 { get; }

	public SnoPower Generic_X1CrusaderLawsOfJustice { get; }

	public SnoPower Generic_X1CrusaderLawsOfJusticePassive { get; }

	public SnoPower Generic_X1CrusaderLawsOfJusticePassive2 { get; }

	public SnoPower Generic_X1CrusaderLawsOfValor { get; }

	public SnoPower Generic_X1CrusaderLawsOfValorPassive { get; }

	public SnoPower Generic_X1CrusaderLawsOfValorPassive2 { get; }

	public SnoPower Generic_x1CrusaderPhalanxArcherRangedProjectile { get; }

	public SnoPower Generic_X1CrusaderPhalanxBasicMelee { get; }

	public SnoPower Generic_x1DarkAngelDeath { get; }

	public SnoPower Generic_x1DarkAngelSoulRush { get; }

	public SnoPower Generic_x1DarkAngelSummon { get; }

	public SnoPower Generic_x1deathMaidenPowerSlamLRBoss { get; }

	public SnoPower Generic_x1deathMaidenPowerSlamPrototype { get; }

	public SnoPower Generic_x1deathMaidenSpinAttackMortarLRBoss { get; }

	public SnoPower Generic_x1deathMaidenSpinAttackPrototype { get; }

	public SnoPower Generic_x1deathMaidenSummonprototype { get; }

	public SnoPower Generic_x1deathMaidenSummonprototypeextraskeletons { get; }

	public SnoPower Generic_x1DeathMaidenUniqueFireAbattoirFurnaceFireWreath { get; }

	public SnoPower Generic_x1DetonateDOTBuffs { get; }

	public SnoPower Generic_X1DHCompanionBoarIntervene { get; }

	public SnoPower Generic_x1FloaterAngelLightningBeam { get; }

	public SnoPower Generic_x1FloaterAngelLightningBeamMalthael { get; }

	public SnoPower Generic_x1FloaterAngelTeleport { get; }

	public SnoPower Generic_x1FloaterAngelTransform { get; }

	public SnoPower Generic_x1FloaterAngelTransformMalthael { get; }

	public SnoPower Generic_X1FortressBVisuals { get; }

	public SnoPower Generic_X1FortressJudgeEventSpawnKnockback { get; }

	public SnoPower Generic_x1FortressPortalSwitch { get; }

	public SnoPower Generic_X1FortressPortalSwitchCheckMonsters { get; }

	public SnoPower Generic_X1FortressPortalSwitchTeleportMonster { get; }

	public SnoPower Generic_x1FortressRotatingDoor { get; }

	public SnoPower Generic_X1GenericBreakWallsBuff { get; }

	public SnoPower Generic_x1GhostDarkSoulSiphon { get; }

	public SnoPower Generic_x1GhostSoulSiphon { get; }

	public SnoPower Generic_x1GhostSoulSiphonFire { get; }

	public SnoPower Generic_x1GhostWalkThroughWalls { get; }

	public SnoPower Generic_x1GreedDeath { get; }

	public SnoPower Generic_x1GreedDeathAncient { get; }

	public SnoPower Generic_x1ImperiusCleave { get; }

	public SnoPower Generic_X1ImperiusEnemyOrNothing { get; }

	public SnoPower Generic_x1ImperiusLeapSmash { get; }

	public SnoPower Generic_x1ImperiusWingsBuff { get; }

	public SnoPower Generic_X1Kylacheer { get; }

	public SnoPower Generic_X1Kylafalldownanimation { get; }

	public SnoPower Generic_X1Kylashieldup { get; }

	public SnoPower Generic_X1LegendaryAIRunToGuaranteedSpider { get; }

	public SnoPower Generic_X1LegendaryGenericPotionPowerup { get; }

	public SnoPower Generic_X1LifetimeBuffAbsorbNonPlayerDamage { get; }

	public SnoPower Generic_X1LRBossBigRedIzualFrostNova { get; }

	public SnoPower Generic_x1LRBossButcherSpears { get; }

	public SnoPower Generic_x1LRBossDarkAngelSoulRush { get; }

	public SnoPower Generic_x1LRBossDarkAngelSummon { get; }

	public SnoPower Generic_x1LRBossDarkAngelWave { get; }

	public SnoPower Generic_X1LRBossdemonFlyerMegaFireBreath { get; }

	public SnoPower Generic_X1LRBossExpandingFireRing { get; }

	public SnoPower Generic_X1LRBossFireNova { get; }

	public SnoPower Generic_X1LRBossGenericTaunt { get; }

	public SnoPower Generic_X1LRBossMorluSpellcasterMeteor { get; }

	public SnoPower Generic_x1LRBossmorluSpellcasterWeaponMeleeInstant { get; }

	public SnoPower Generic_X1LRBossRatKingBurrowSetup { get; }

	public SnoPower Generic_X1LRBossRatKingDeadPlayerTaunt { get; }

	public SnoPower Generic_X1LRBossRatKingDeadPlayerTauntSearch { get; }

	public SnoPower Generic_X1LRBossRatKingOnDeath { get; }

	public SnoPower Generic_x1LRBossSandmonsterOnDeath { get; }

	public SnoPower Generic_x1LRBossSharedCooldown { get; }

	public SnoPower Generic_X1LRBossSkeletonKingSummonSkeleton { get; }

	public SnoPower Generic_X1LRBossSkeletonKingWhirlwind { get; }

	public SnoPower Generic_X1LRBossSkeletonSummonerProjectile { get; }

	public SnoPower Generic_X1LRBossSkeletonSummonerProjectileB { get; }

	public SnoPower Generic_X1LRBossSkeletonSummonerProjectileC { get; }

	public SnoPower Generic_x1LRBossSkeletonSummonerSummoning { get; }

	public SnoPower Generic_X1LRBossSuccubusFirestorm { get; }

	public SnoPower Generic_X1LRBossSummonCoreElites { get; }

	public SnoPower Generic_X1LRCreepMobHerdingAttack { get; }

	public SnoPower Generic_X1LRCreepMobMultipleArmAttack { get; }

	public SnoPower Generic_X1LRCreepMobRangedArmLineAttack { get; }

	public SnoPower Generic_x1MalthaelBaalAIState { get; }

	public SnoPower Generic_x1MalthaelBaalFesteringAppendageMelee { get; }

	public SnoPower Generic_x1MalthaelBaalHoarfrost { get; }

	public SnoPower Generic_x1MalthaelBaalRift { get; }

	public SnoPower Generic_x1MalthaelBaalSummonFesteringAppendages { get; }

	public SnoPower Generic_x1MalthaelDeathFogMonsterSetup { get; }

	public SnoPower Generic_x1MalthaelDiabloAIState { get; }

	public SnoPower Generic_x1MalthaelDiabloTeleportFireNovaLightning { get; }

	public SnoPower Generic_X1MalthaelDrainSoul { get; }

	public SnoPower Generic_x1MalthaelHealthGlobeDropper { get; }

	public SnoPower Generic_x1MalthaelMephistoAIState { get; }

	public SnoPower Generic_x1MalthaelMephistoPoisonCloud { get; }

	public SnoPower Generic_x1MalthaelMephistoSkullMissile { get; }

	public SnoPower Generic_x1MalthaelMephistoSpawnInvisLightningProxies { get; }

	public SnoPower Generic_x1MalthaelMephistoSpiralLightningInward { get; }

	public SnoPower Generic_x1MalthaelMephistoSummonRotatingLightning { get; }

	public SnoPower Generic_x1MalthaelMephistoTeleportExplodeOrbs { get; }

	public SnoPower Generic_x1MalthaelOnDeath { get; }

	public SnoPower Generic_x1MalthaelPhaseOneAIState { get; }

	public SnoPower Generic_x1MalthaelPhaseThreeAIState { get; }

	public SnoPower Generic_x1MalthaelPhaseTwoAIState { get; }

	public SnoPower Generic_X1MalthaelSickleThrowTeleport { get; }

	public SnoPower Generic_x1MalthaelSpiritDeath { get; }

	public SnoPower Generic_x1MalthaelSpiritFog { get; }

	public SnoPower Generic_X1MalthaelSummonDeathFogMonster { get; }

	public SnoPower Generic_X1MalthaelSummonFloaterAngel { get; }

	public SnoPower Generic_x1MalthaelSwordShieldStart { get; }

	public SnoPower Generic_x1MalthaelSwordShieldStop { get; }

	public SnoPower Generic_x1MoleMutantEnragedCombo { get; }

	public SnoPower Generic_x1MoleMutantRangedJumpBackShot { get; }

	public SnoPower Generic_x1MoleMutantRangedProjectile { get; }

	public SnoPower Generic_x1MoleMutantShamanBlast { get; }

	public SnoPower Generic_x1MoleMutantShamanResurrect { get; }

	public SnoPower Generic_X1MonkMysticAllyRuneAExplode { get; }

	public SnoPower Generic_X1MonkMysticAllyRuneATagForExplosion { get; }

	public SnoPower Generic_X1MonkMysticAllyv2Passive { get; }

	public SnoPower Generic_X1MonkMysticAllyv3Passive { get; }

	public SnoPower Generic_X1MonsterAffixAvengerCorpseBomberRare { get; }

	public SnoPower Generic_X1MonsterAffixAvengerCorpseBomberRareCast { get; }

	public SnoPower Generic_X1MonsterAffixAvengerLightningStorm { get; }

	public SnoPower Generic_X1MonsterAffixAvengerLightningStormCast { get; }

	public SnoPower Generic_X1MonsterAffixAvengerOrbiter { get; }

	public SnoPower Generic_X1MonsterAffixAvengerOrbiterCast { get; }

	public SnoPower Generic_X1MonsterAffixCorpseBomber { get; }

	public SnoPower Generic_X1MonsterAffixCorpseBomberCast { get; }

	public SnoPower Generic_X1MonsterAffixCorpseBomberRare { get; }

	public SnoPower Generic_X1MonsterAffixCorpseBomberRareCast { get; }

	public SnoPower Generic_X1MonsterAffixLightningStorm { get; }

	public SnoPower Generic_x1MonsterAffixLightningStormAIClose { get; }

	public SnoPower Generic_X1MonsterAffixLightningStormCast { get; }

	public SnoPower Generic_X1MonsterAffixLightningStormChampion { get; }

	public SnoPower Generic_X1MonsterAffixLightningStormKillSelf { get; }

	public SnoPower Generic_X1MonsterAffixLightningStormPulse { get; }

	public SnoPower Generic_X1MonsterAffixLightningStormTagTarget { get; }

	public SnoPower Generic_X1MonsterAffixOrbiter { get; }

	public SnoPower Generic_X1MonsterAffixOrbiterCast { get; }

	public SnoPower Generic_X1MonsterAffixOrbiterChampion { get; }

	public SnoPower Generic_X1MonsterAffixOrbiterChampionCast { get; }

	public SnoPower Generic_X1MonsterAffixTeleportMines { get; }

	public SnoPower Generic_X1MonsterAffixTeleportMinesCast { get; }

	public SnoPower Generic_X1NegativeHealthGlobeFlash { get; }

	public SnoPower Generic_x1NightScreamerAllyBiteTransform { get; }

	public SnoPower Generic_x1NightScreamerCanTransform { get; }

	public SnoPower Generic_X1NightScreamerFuriousCharge { get; }

	public SnoPower Generic_x1NightScreamerScreamAttack { get; }

	public SnoPower Generic_x1NPCWestmarchAldritchCrushingResolve { get; }

	public SnoPower Generic_x1PandBruteDecapitateSlide { get; }

	public SnoPower Generic_X1pandemoniumideationtimeStopBuff { get; }

	public SnoPower Generic_x1PandExtCollapsingPillar { get; }

	public SnoPower Generic_x1PandExtEventgreatWeaponbossSuckIn { get; }

	public SnoPower Generic_x1PandExtEventgreatWeaponfireEnergyPulses { get; }

	public SnoPower Generic_x1PandExtEventgreatWeaponsummonBoss { get; }

	public SnoPower Generic_x1PandExtEventgreatWeaponsummonMonsters { get; }

	public SnoPower Generic_x1PandExtideationbaconbeaconOnDeath { get; }

	public SnoPower Generic_x1PandExtIdeationWarSpawnerAngel { get; }

	public SnoPower Generic_x1PandExtIdeationWarSpawnerDemon { get; }

	public SnoPower Generic_x1PandExtImperiusChargetowerschains { get; }

	public SnoPower Generic_x1PandExtImperiusChargeTowersSetup { get; }

	public SnoPower Generic_X1PandExtRamKnockback { get; }

	public SnoPower Generic_x1pandExtRangedPrototype { get; }

	public SnoPower Generic_x1pandExtRangedPrototypeStrafeLeft { get; }

	public SnoPower Generic_x1pandExtRangedPrototypeStrafeRight { get; }

	public SnoPower Generic_X1PandExtTimeTrap { get; }

	public SnoPower Generic_X1PandFortressOrdnanceChronoField { get; }

	public SnoPower Generic_X1PandFortressOrdnanceMine { get; }

	public SnoPower Generic_X1PandFortressOrdnanceShocker { get; }

	public SnoPower Generic_X1PandHexMazePortalChampSummon { get; }

	public SnoPower Generic_X1PandIntSplitMonstermerge { get; }

	public SnoPower Generic_X1PandIntSplitMonstersplit { get; }

	public SnoPower Generic_x1PandLeaperAngelLeap { get; }

	public SnoPower Generic_x1PandMazePortalTestPower { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerBloone { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerBorgoth { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerGrotescor { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerHaziael { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerMagrethar { get; }

	public SnoPower Generic_x1PandMazePortalTestPowerSeverag { get; }

	public SnoPower Generic_x1PandRockwormBurstOut { get; }

	public SnoPower Generic_x1PandSniperAngelcloseRangedAttack { get; }

	public SnoPower Generic_x1PandSniperAngelcloseRangedAttackLRBoss { get; }

	public SnoPower Generic_x1PandSniperAngelrangedAttack { get; }

	public SnoPower Generic_x1PandSniperAngelrangedAttackLRBoss { get; }

	public SnoPower Generic_X1PassiveBountyScroll { get; }

	public SnoPower Generic_X1PassiveBountyScrollBeastDamage { get; }

	public SnoPower Generic_X1PassiveBountyScrollBossDamage { get; }

	public SnoPower Generic_X1PassiveBountyScrollDemonDamage { get; }

	public SnoPower Generic_X1PassiveBountyScrollEliteDamage { get; }

	public SnoPower Generic_X1PassiveBountyScrollExperience { get; }

	public SnoPower Generic_X1PassiveBountyScrollLifeRegen { get; }

	public SnoPower Generic_X1PassiveBountyScrollRunSpeed { get; }

	public SnoPower Generic_X1PassiveBountyScrollUndeadDamage { get; }

	public SnoPower Generic_X1PlaguedLacuniMaleSummon { get; }

	public SnoPower Generic_x1PlaguedLacuniSpecialMelee { get; }

	public SnoPower Generic_x1portalGuardianMinionprojectile { get; }

	public SnoPower Generic_x1PortalGuardianTurning { get; }

	public SnoPower Generic_x1PortalMonsterBurrowIn { get; }

	public SnoPower Generic_x1PortalMonsterBurrowOut { get; }

	public SnoPower Generic_x1PortalMonsterLifetimeBuff { get; }

	public SnoPower Generic_X1PortalMonsterPortalSummon { get; }

	public SnoPower Generic_X1PortalMonsterRoarSummon { get; }

	public SnoPower Generic_X1PortalMonsterStomp { get; }

	public SnoPower Generic_x1PortalMonsterSwipe { get; }

	public SnoPower Generic_x1RockFodderCharge { get; }

	public SnoPower Generic_X1RockFodderFuriousCharge { get; }

	public SnoPower Generic_X1RockFodderFuriousChargeRockHiveQueen { get; }

	public SnoPower Generic_x1RockFodderTumble { get; }

	public SnoPower Generic_x1rockwormpandprojectile { get; }

	public SnoPower Generic_X1SandmonsterpetWeaponMeleeInstant { get; }

	public SnoPower Generic_X1SandmonsterWeaponMeleeInstant { get; }

	public SnoPower Generic_x1ScaryEyesBurrowInHidden { get; }

	public SnoPower Generic_x1ScaryEyesBurrowOut { get; }

	public SnoPower Generic_x1ScaryEyescharge { get; }

	public SnoPower Generic_X1ScoundrelMultishot { get; }

	public SnoPower Generic_X1ScoundrelMultishotPassive { get; }

	public SnoPower Generic_X1ShardPassiveFakeGlobes { get; }

	public SnoPower Generic_X1ShardPassiveMinResource { get; }

	public SnoPower Generic_x1SkeletonArcherFireArrow { get; }

	public SnoPower Generic_x1SkeletonArcherFireArrowBackpedal { get; }

	public SnoPower Generic_x1SkeletonStab { get; }

	public SnoPower Generic_x1SkeletonStrafe { get; }

	public SnoPower Generic_X1SnitchleyTreasureGoblinEscape { get; }

	public SnoPower Generic_X1SpectralHoundBuff { get; }

	public SnoPower Generic_X1SummonVanityPet { get; }

	public SnoPower Generic_X1tempballistaswitchleap { get; }

	public SnoPower Generic_x1UberDiabloHellSpikes { get; }

	public SnoPower Generic_x1UdderLightning { get; }

	public SnoPower Generic_x1UniqueNPCEnchantressForcefulPush { get; }

	public SnoPower Generic_x1UniqueNPCEnchantressMassCharm { get; }

	public SnoPower Generic_x1UniqueNPCEnchantressScorchedEarth { get; }

	public SnoPower Generic_x1UniqueNPCTemplarHeal { get; }

	public SnoPower Generic_x1UniqueNPCTemplarOnslaught { get; }

	public SnoPower Generic_x1UniqueNPCTemplarShieldCharge { get; }

	public SnoPower Generic_x1UniqueTriuneSummonerProjectile { get; }

	public SnoPower Generic_x1UrzaelCannonball { get; }

	public SnoPower Generic_x1UrzaelCannonballBurning { get; }

	public SnoPower Generic_x1UrzaelCeilingDebris { get; }

	public SnoPower Generic_x1UrzaelCeilingDebrisBurning { get; }

	public SnoPower Generic_x1UrzaelFlameSweep { get; }

	public SnoPower Generic_x1UrzaelLeapKnockback { get; }

	public SnoPower Generic_x1UrzaelMeleeInstant { get; }

	public SnoPower Generic_x1UrzaelPhaseOneAIState { get; }

	public SnoPower Generic_x1UrzaelPhaseTwoAIState { get; }

	public SnoPower Generic_x1WestmarchBruteBChargeCustomLRBoss { get; }

	public SnoPower Generic_x1WestmarchBruteBChargeCustomLRBossHulkmode { get; }

	public SnoPower Generic_x1WestmarchBruteCharge { get; }

	public SnoPower Generic_x1WestmarchBruteDecapitate { get; }

	public SnoPower Generic_x1WestmarchBruteVomit { get; }

	public SnoPower Generic_X1WestmarchHoundDeadPlayerTaunt { get; }

	public SnoPower Generic_X1WestmarchHoundDeadPlayerTauntSearch { get; }

	public SnoPower Generic_X1WestmarchHoundShakeTarget { get; }

	public SnoPower Generic_x1westmarchRangedRangedAttackPrototype { get; }

	public SnoPower Generic_x1westmarchRangedSlowAreaDenialPrototype { get; }

	public SnoPower Generic_x1WestmarchRatCharge { get; }

	public SnoPower Generic_x1WestmarchRatKamikaze { get; }

	public SnoPower Generic_X1WestmConvert { get; }

	public SnoPower Generic_X1WestmConvert2 { get; }

	public SnoPower Generic_X1WestmConvertAoE { get; }

	public SnoPower Generic_X1WestmConvertDelayedStart2 { get; }

	public SnoPower Generic_X1WestmConvertDelayedStartFromTarget { get; }

	public SnoPower Generic_X1WestmConvertScripted { get; }

	public SnoPower Generic_X1westmdoomedWomanvisual { get; }

	public SnoPower Generic_x1westmHoistTriggeronDeathPower { get; }

	public SnoPower Generic_x1westmideationeventRATZNGGOLD { get; }

	public SnoPower Generic_x1westmSoulSummonerOrbSummonNearTarget { get; }

	public SnoPower Generic_X1westmSoulsummonersetup { get; }

	public SnoPower Generic_X1westmSoulSummonerSummon { get; }

	public SnoPower Generic_X1westmUniqueghostLordshockwave { get; }

	public SnoPower Generic_x1WickermanAggro { get; }

	public SnoPower Generic_X1WickerManFireNova { get; }

	public SnoPower Generic_X1WickerManFirePhantom { get; }

	public SnoPower Generic_x1WickermanSuicide { get; }

	public SnoPower Generic_x1WraithChargeClose { get; }

	public SnoPower Generic_X1WraithMelee { get; }

	public SnoPower Generic_X1WraithPiercingDash { get; }

	public SnoPower Generic_X1X1EventSpeedKillChampionSpawner { get; }

	public SnoPower Generic_X1X1EventSpeedKillSpawner { get; }

	public SnoPower Generic_x1ZombieFemaleProjectilePoison { get; }

	public SnoPower Generic_ZKBallSummonSkeleton { get; }

	public SnoPower Generic_zoltsmallFloorSpawner { get; }

	public SnoPower Generic_zoltTabletstateChange { get; }

	public SnoPower Generic_ZoltunKulleCollapseCeiling { get; }

	public SnoPower Generic_ZoltunKulleEnergyTwister { get; }

	public SnoPower Generic_ZoltunKulleFieryBoulder { get; }

	public SnoPower Generic_ZoltunKulleSlowTime { get; }

	public SnoPower Generic_ZoltunKulleTeleport { get; }

	public SnoPower Generic_ZoltunKulleTeleportToPlayer { get; }

	public SnoPower Generic_ZoltunKulleTeleportToPlayerEnrage { get; }

	public SnoPower Generic_ZombieEatStart { get; }

	public SnoPower Generic_ZombieEatStop { get; }

	public SnoPower Generic_ZombieFemaleProjectile { get; }

	public SnoPower Generic_ZombieKillerGrab { get; }

	public SnoPower BroodOfAraneae => SnoData.Powers.GetBySno(486136u);

	public SnoPower DregsOfLies => SnoData.Powers.GetBySno(486126u);

	public SnoPower EssenceOfAnguish => SnoData.Powers.GetBySno(486198u);

	public SnoPower FragmentOfDestruction => SnoData.Powers.GetBySno(486213u);

	public SnoPower RemnantOfPain => SnoData.Powers.GetBySno(486134u);

	public SnoPower ShardOfHatred => SnoData.Powers.GetBySno(486178u);

	public SnoPower SliverOfTerror => SnoData.Powers.GetBySno(486182u);

	public SnoPower StainOfSin => SnoData.Powers.GetBySno(486209u);

	public SnoPower Generic_CommunityBuffWeather { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing007 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing010 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing013 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing019 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing020 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing021 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing022 { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing025 { get; }

	public SnoPower Generic_P67ItemPassiveUniqueRing968 { get; }

	public SnoPower Generic_P68ItemPassiveUniqueRing018 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_P69ItemPassiveUniqueRing004 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard029 { get; }

	public SnoPower Generic_P72ItemPassiveUniqueRing005 { get; }

	public SnoPower Generic_P72ItemPassiveUniqueRing006 { get; }

	public SnoPower DemonHunter_P74Ballista { get; }

	public SnoPower Monk_P74WayOfTheHundredFists { get; }

	public SnoPower WhisperOfAtonementPrimary => SnoData.Powers.GetBySno(486910u);

	public SnoPower WhisperOfAtonementSecondary => SnoData.Powers.GetBySno(486910u);

	public SnoPower MempoOfTwilight => SnoData.Powers.GetBySno(487972u);

	public SnoPower Generic_P72ItemPassiveSoulshard002 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard003 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard004 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard006 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard007 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard008 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard010 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard011 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard012 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard014 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard015 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard016 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard018 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard019 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard020 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard022 { get; }

	public SnoPower Generic_P73ExplodingLunaticSuicide { get; }

	public SnoPower Generic_P73ItemPassiveUniqueRing003 { get; }

	public SnoPower Generic_P73PagesBuffDamageSwarmRift { get; }

	public SnoPower Generic_P73PagesBuffElectrifiedCastSwarmRift { get; }

	public SnoPower Generic_P73PagesBuffRunSpeed { get; }

	public SnoPower Generic_P73PagesBuffRunSpeedKnockbackCast { get; }

	public SnoPower Generic_P73PagesBuffRunSpeedWallerCast { get; }

	public SnoPower Generic_P73PagesBuffRunSpeedWallerCastUpgrade { get; }

	public SnoPower Generic_P73ShrineDesecratedtreasureGoblin { get; }

	public SnoPower Generic_P73SwarmRiftCloneDeathExplosionAffix { get; }

	public SnoPower Generic_P73SwarmRiftGreenMeteors { get; }

	public SnoPower Generic_P73SwarmRiftLunaticMolten { get; }

	public SnoPower Generic_P73SwarmRiftPagesBuffElectrifiedTieredRift { get; }

	public SnoPower Generic_P73SwarmRiftPagesBuffInfiniteCasting { get; }

	public SnoPower Generic_p73SwarmRiftSummon { get; }

	public SnoPower Generic_P74GargantuanWormwoodSeasonTheme { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing004 { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing006 { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing007 { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing009 { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing012 { get; }

	public SnoPower Generic_P74ItemPassiveUniqueRing014 { get; }

	public SnoPower Generic_P74NecroGolemDevourAura { get; }

	public SnoPower Generic_CommunityBuffDarkAlchemy { get; }

	public SnoPower Generic_P2ItemPassiveUniqueRing026 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard023 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard024 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard026 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard027 { get; }

	public SnoPower Generic_P72ItemPassiveSoulshard028 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme001 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme002 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme003 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme004 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme005 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme006 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme007 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme008 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme009 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme010 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme011 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme012 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme013 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme014 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme015 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme016 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme017 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme018 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme019 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme020 { get; }

	public SnoPower Generic_P74ItemPassiveSeasonTheme021 { get; }

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor018AIPetPickup { get; }

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor021AIPetPickup { get; }

	public SnoPower Generic_P75ItemPassiveDarkAlchemySeal001 { get; }

	public SnoPower Generic_P75ItemPassiveUniqueRing001 { get; }

	public SnoPower Generic_P75ItemPassiveUniqueRing006 { get; }

	public SnoPower Generic_P75PagesBuffDamageDarkAlchemy { get; }

	public SnoPower VigilanteBelt => SnoData.Powers.GetBySno(488555u);

	public SnoPower Generic_CommunityBuffNestingPortalSpawn { get; }

	public SnoPower Generic_MonsterAffixLethargy { get; }

	public SnoPower Generic_MonsterAffixNecrotic { get; }

	public SnoPower Generic_MonsterAffixNecroticQAtest { get; }

	public SnoPower Generic_MonsterAffixResourceSteal { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Alcarnus { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76BloodPit { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Bog { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Boneyard { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Church { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76ForestTower { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GideonsCourt { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GravyardAct1 { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Hell { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76MoorsSacrifice { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76NewTristram { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76OldTristram { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76PandBatteringRam { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Sescheron { get; }

	public SnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Spire { get; }

	public SnoPower Generic_P76ItemPassiveSpawnChest001 { get; }

	public SnoPower Generic_itemPassiveUniqueAmulet003 { get; } = SnoData.Powers.GetBySno(246750u);

	public SnoPower Generic_itemPassiveUniqueAmulet011 { get; } = SnoData.Powers.GetBySno(248136u);

	public SnoPower Generic_ItemPassiveUniqueAmulet017x1 { get; } = SnoData.Powers.GetBySno(322978u);

	public SnoPower Generic_ItemPassiveUniqueAmulet105x1 { get; } = SnoData.Powers.GetBySno(334880u);

	public SnoPower Generic_ItemPassiveUniqueAxe1H003 { get; } = SnoData.Powers.GetBySno(245854u);

	public SnoPower Generic_ItemPassiveUniqueAxe1H005 { get; } = SnoData.Powers.GetBySno(246101u);

	public SnoPower Generic_ItemPassiveUniqueAxe1H005x1 { get; } = SnoData.Powers.GetBySno(364318u);

	public SnoPower Generic_ItemPassiveUniqueAxe2H010 { get; } = SnoData.Powers.GetBySno(248462u);

	public SnoPower Generic_ItemPassiveUniqueAxe2H012x1 { get; } = SnoData.Powers.GetBySno(322974u);

	public SnoPower Generic_ItemPassiveUniqueBarbBelt003 { get; } = SnoData.Powers.GetBySno(246363u);

	public SnoPower Generic_ItemPassiveUniqueBelt016x1 { get; } = SnoData.Powers.GetBySno(322980u);

	public SnoPower Generic_ItemPassiveUniqueBoots007 { get; } = SnoData.Powers.GetBySno(246442u);

	public SnoPower Generic_ItemPassiveUniqueBoots007x1 { get; } = SnoData.Powers.GetBySno(342515u);

	public SnoPower Generic_ItemPassiveUniqueBoots020x1 { get; } = SnoData.Powers.GetBySno(322976u);

	public SnoPower Generic_ItemPassiveUniqueBow008 { get; } = SnoData.Powers.GetBySno(246605u);

	public SnoPower Generic_ItemPassiveUniqueBow015 { get; } = SnoData.Powers.GetBySno(248817u);

	public SnoPower Generic_ItemPassiveUniqueBow015x1 { get; } = SnoData.Powers.GetBySno(344372u);

	public SnoPower Generic_ItemPassiveUniqueBracer105x1 { get; } = SnoData.Powers.GetBySno(334881u);

	public SnoPower Generic_ItemPassiveUniqueCeremonialDagger002 { get; } = SnoData.Powers.GetBySno(245835u);

	public SnoPower Generic_ItemPassiveUniqueCeremonialDagger008 { get; } = SnoData.Powers.GetBySno(247896u);

	public SnoPower Generic_ItemPassiveUniqueDagger010 { get; } = SnoData.Powers.GetBySno(245837u);

	public SnoPower Generic_ItemPassiveUniqueDagger010x1 { get; } = SnoData.Powers.GetBySno(364312u);

	public SnoPower Generic_ItemPassiveUniqueDagger103x1 { get; } = SnoData.Powers.GetBySno(322979u);

	public SnoPower Generic_ItemPassiveUniqueHandXBow012 { get; } = SnoData.Powers.GetBySno(246678u);

	public SnoPower Generic_itemPassiveUniqueHelm003 { get; } = SnoData.Powers.GetBySno(246814u);

	public SnoPower Generic_itemPassiveUniqueHelm003x1 { get; } = SnoData.Powers.GetBySno(338061u);

	public SnoPower Generic_ItemPassiveUniqueHelm017x1 { get; } = SnoData.Powers.GetBySno(322977u);

	public SnoPower Generic_itemPassiveUniqueMace1H002 { get; } = SnoData.Powers.GetBySno(246918u);

	public SnoPower Generic_ItemPassiveUniqueMace2H003 { get; } = SnoData.Powers.GetBySno(249958u);

	public SnoPower Generic_ItemPassiveUniqueMace2H009 { get; } = SnoData.Powers.GetBySno(247913u);

	public SnoPower Generic_ItemPassiveUniqueMace2H009x1 { get; } = SnoData.Powers.GetBySno(364319u);

	public SnoPower Generic_ItemPassiveUniqueMighty1H006 { get; } = SnoData.Powers.GetBySno(246836u);

	public SnoPower Generic_ItemPassiveUniqueMighty1H006p3 { get; } = SnoData.Powers.GetBySno(441762u);

	public SnoPower Generic_ItemPassiveUniqueMighty1H006x1 { get; } = SnoData.Powers.GetBySno(364322u);

	public SnoPower Generic_itemPassiveUniquePants007 { get; } = SnoData.Powers.GetBySno(247009u);

	public SnoPower Generic_itemPassiveUniquePants007x1 { get; } = SnoData.Powers.GetBySno(364342u);

	public SnoPower Generic_ItemPassiveUniquePolearm001 { get; } = SnoData.Powers.GetBySno(247641u);

	public SnoPower Generic_ItemPassiveUniqueRing001 { get; } = SnoData.Powers.GetBySno(248880u);

	public SnoPower Generic_ItemPassiveUniqueRing004 { get; } = SnoData.Powers.GetBySno(247797u);

	public SnoPower Generic_ItemPassiveUniqueRing020 { get; } = SnoData.Powers.GetBySno(248537u);

	public SnoPower Generic_ItemPassiveUniqueRing025x1 { get; } = SnoData.Powers.GetBySno(322975u);

	public SnoPower Generic_ItemPassiveUniqueRing505x1 { get; } = SnoData.Powers.GetBySno(318349u);

	public SnoPower Generic_ItemPassiveUniqueRing508x1 { get; } = SnoData.Powers.GetBySno(318359u);

	public SnoPower Generic_ItemPassiveUniqueRing510x1 { get; } = SnoData.Powers.GetBySno(318371u);

	public SnoPower Generic_ItemPassiveUniqueRing521x1 { get; } = SnoData.Powers.GetBySno(318383u);

	public SnoPower Generic_ItemPassiveUniqueRing528x1 { get; } = SnoData.Powers.GetBySno(318417u);

	public SnoPower Generic_ItemPassiveUniqueRing551x1 { get; } = SnoData.Powers.GetBySno(318722u);

	public SnoPower Generic_ItemPassiveUniqueRing555x1 { get; } = SnoData.Powers.GetBySno(318732u);

	public SnoPower Generic_ItemPassiveUniqueRing557x1 { get; } = SnoData.Powers.GetBySno(318734u);

	public SnoPower Generic_ItemPassiveUniqueRing560x1 { get; } = SnoData.Powers.GetBySno(318742u);

	public SnoPower Generic_ItemPassiveUniqueRing565x1 { get; } = SnoData.Powers.GetBySno(318747u);

	public SnoPower Generic_ItemPassiveUniqueRing568x1 { get; } = SnoData.Powers.GetBySno(318750u);

	public SnoPower Generic_ItemPassiveUniqueRing576x1 { get; } = SnoData.Powers.GetBySno(318758u);

	public SnoPower Generic_ItemPassiveUniqueRing579x1 { get; } = SnoData.Powers.GetBySno(318761u);

	public SnoPower Generic_ItemPassiveUniqueRing594x1 { get; } = SnoData.Powers.GetBySno(318776u);

	public SnoPower Generic_ItemPassiveUniqueRing602x1 { get; } = SnoData.Powers.GetBySno(318784u);

	public SnoPower Generic_ItemPassiveUniqueRing604x1 { get; } = SnoData.Powers.GetBySno(318786u);

	public SnoPower Generic_ItemPassiveUniqueRing607x1 { get; } = SnoData.Powers.GetBySno(318789u);

	public SnoPower Generic_ItemPassiveUniqueRing609x1 { get; } = SnoData.Powers.GetBySno(318791u);

	public SnoPower Generic_ItemPassiveUniqueRing610x1 { get; } = SnoData.Powers.GetBySno(318792u);

	public SnoPower Generic_ItemPassiveUniqueRing611x1 { get; } = SnoData.Powers.GetBySno(318793u);

	public SnoPower Generic_ItemPassiveUniqueRing612x1 { get; } = SnoData.Powers.GetBySno(318794u);

	public SnoPower Generic_ItemPassiveUniqueRing615x1 { get; } = SnoData.Powers.GetBySno(318797u);

	public SnoPower Generic_ItemPassiveUniqueRing620x1 { get; } = SnoData.Powers.GetBySno(318802u);

	public SnoPower Generic_ItemPassiveUniqueRing622x1 { get; } = SnoData.Powers.GetBySno(318804u);

	public SnoPower Generic_ItemPassiveUniqueRing623x1 { get; } = SnoData.Powers.GetBySno(318805u);

	public SnoPower Generic_ItemPassiveUniqueRing643x1 { get; } = SnoData.Powers.GetBySno(318825u);

	public SnoPower Generic_ItemPassiveUniqueRing644x1 { get; } = SnoData.Powers.GetBySno(318826u);

	public SnoPower Generic_ItemPassiveUniqueRing645x1 { get; } = SnoData.Powers.GetBySno(318827u);

	public SnoPower Generic_ItemPassiveUniqueRing646x1 { get; } = SnoData.Powers.GetBySno(318828u);

	public SnoPower Generic_ItemPassiveUniqueRing647x1 { get; } = SnoData.Powers.GetBySno(318829u);

	public SnoPower Generic_ItemPassiveUniqueRing648p2 { get; } = SnoData.Powers.GetBySno(434022u);

	public SnoPower Generic_ItemPassiveUniqueRing648x1 { get; } = SnoData.Powers.GetBySno(318830u);

	public SnoPower Generic_ItemPassiveUniqueRing649x1 { get; } = SnoData.Powers.GetBySno(318831u);

	public SnoPower Generic_ItemPassiveUniqueRing651x1 { get; } = SnoData.Powers.GetBySno(318833u);

	public SnoPower Generic_ItemPassiveUniqueRing655x1 { get; } = SnoData.Powers.GetBySno(318850u);

	public SnoPower Generic_ItemPassiveUniqueRing664x1 { get; } = SnoData.Powers.GetBySno(318860u);

	public SnoPower Generic_ItemPassiveUniqueRing667x1 { get; } = SnoData.Powers.GetBySno(318863u);

	public SnoPower Generic_ItemPassiveUniqueRing670x1 { get; } = SnoData.Powers.GetBySno(318866u);

	public SnoPower Generic_ItemPassiveUniqueRing687x1 { get; } = SnoData.Powers.GetBySno(318883u);

	public SnoPower Generic_ItemPassiveUniqueRing697x1 { get; } = SnoData.Powers.GetBySno(318893u);

	public SnoPower Generic_ItemPassiveUniqueRing703x1 { get; } = SnoData.Powers.GetBySno(359540u);

	public SnoPower Generic_ItemPassiveUniqueRing705x1 { get; } = SnoData.Powers.GetBySno(359546u);

	public SnoPower Generic_ItemPassiveUniqueRing707x1 { get; } = SnoData.Powers.GetBySno(359552u);

	public SnoPower Generic_ItemPassiveUniqueRing708x1 { get; } = SnoData.Powers.GetBySno(359553u);

	public SnoPower Generic_ItemPassiveUniqueRing742x1 { get; } = SnoData.Powers.GetBySno(359593u);

	public SnoPower Generic_ItemPassiveUniqueRing749x1 { get; } = SnoData.Powers.GetBySno(359605u);

	public SnoPower Generic_ItemPassiveUniqueRing751x1 { get; } = SnoData.Powers.GetBySno(397780u);

	public SnoPower Generic_ItemPassiveUniqueRing753x1 { get; } = SnoData.Powers.GetBySno(397782u);

	public SnoPower Generic_ItemPassiveUniqueRing755x1 { get; } = SnoData.Powers.GetBySno(397784u);

	public SnoPower Generic_ItemPassiveUniqueRing761x1 { get; } = SnoData.Powers.GetBySno(397792u);

	public SnoPower Generic_ItemPassiveUniqueRing762x1 { get; } = SnoData.Powers.GetBySno(397802u);

	public SnoPower Generic_ItemPassiveUniqueRing903x1 { get; } = SnoData.Powers.GetBySno(402411u);

	public SnoPower Generic_ItemPassiveUniqueRing905x1 { get; } = SnoData.Powers.GetBySno(402413u);

	public SnoPower Generic_ItemPassiveUniqueRing906x1 { get; } = SnoData.Powers.GetBySno(402414u);

	public SnoPower Generic_ItemPassiveUniqueRing911x1 { get; } = SnoData.Powers.GetBySno(402447u);

	public SnoPower Generic_ItemPassiveUniqueRing912x1 { get; } = SnoData.Powers.GetBySno(402448u);

	public SnoPower Generic_itemPassiveUniqueShield008 { get; } = SnoData.Powers.GetBySno(247053u);

	public SnoPower Generic_ItemPassiveUniqueShoulder002 { get; } = SnoData.Powers.GetBySno(247619u);

	public SnoPower Generic_ItemPassiveUniqueShoulder002x1 { get; } = SnoData.Powers.GetBySno(364339u);

	public SnoPower Generic_ItemPassiveUniqueShoulder103x1 { get; } = SnoData.Powers.GetBySno(334883u);

	public SnoPower Generic_ItemPassiveUniqueSword1H004 { get; } = SnoData.Powers.GetBySno(247662u);

	public SnoPower Generic_ItemPassiveUniqueSword1H012 { get; } = SnoData.Powers.GetBySno(249592u);

	public SnoPower Generic_ItemPassiveUniqueSword1H012x1 { get; } = SnoData.Powers.GetBySno(374362u);

	public SnoPower Generic_ItemPassiveUniqueSword2H004 { get; } = SnoData.Powers.GetBySno(247537u);

	public SnoPower Generic_ItemPassiveUniqueSword2H010 { get; } = SnoData.Powers.GetBySno(249138u);

	public SnoPower Generic_itemPassiveUniqueWizardHat004 { get; } = SnoData.Powers.GetBySno(247090u);

	public SnoPower Generic_ItemPassiveUniqueXBow001 { get; } = SnoData.Powers.GetBySno(247429u);

	public SnoPower Generic_ItemPassiveUniqueXBow011 { get; } = SnoData.Powers.GetBySno(248480u);

	public SnoPower Generic_ItemPassiveUniqueXBow012 { get; } = SnoData.Powers.GetBySno(247430u);

	public SnoPower Generic_LewisItemPassiveTest { get; } = SnoData.Powers.GetBySno(437919u);

	public SnoPower Generic_p1ItemPassiveUniqueRing942 { get; } = SnoData.Powers.GetBySno(408974u);

	public SnoPower Generic_p1ItemPassiveUniqueRing943 { get; } = SnoData.Powers.GetBySno(409811u);

	public SnoPower Generic_p1ItemPassiveUniqueRing945 { get; } = SnoData.Powers.GetBySno(440923u);

	public SnoPower Generic_P2ItemPassiveUniqueRing004 { get; } = SnoData.Powers.GetBySno(423227u);

	public SnoPower Generic_P2ItemPassiveUniqueRing009 { get; } = SnoData.Powers.GetBySno(423233u);

	public SnoPower Generic_P2ItemPassiveUniqueRing011 { get; } = SnoData.Powers.GetBySno(423235u);

	public SnoPower Generic_P2ItemPassiveUniqueRing015 { get; } = SnoData.Powers.GetBySno(423239u);

	public SnoPower Generic_P2ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(423240u);

	public SnoPower Generic_P2ItemPassiveUniqueRing017 { get; } = SnoData.Powers.GetBySno(423241u);

	public SnoPower Generic_P2ItemPassiveUniqueRing018 { get; } = SnoData.Powers.GetBySno(423242u);

	public SnoPower Generic_P2ItemPassiveUniqueRing023 { get; } = SnoData.Powers.GetBySno(428220u);

	public SnoPower Generic_P2ItemPassiveUniqueRing027 { get; } = SnoData.Powers.GetBySno(429851u);

	public SnoPower Generic_P2ItemPassiveUniqueRing028 { get; } = SnoData.Powers.GetBySno(429855u);

	public SnoPower Generic_P2ItemPassiveUniqueRing029 { get; } = SnoData.Powers.GetBySno(429856u);

	public SnoPower Generic_P2ItemPassiveUniqueRing030 { get; } = SnoData.Powers.GetBySno(429857u);

	public SnoPower Generic_P2ItemPassiveUniqueRing031 { get; } = SnoData.Powers.GetBySno(429885u);

	public SnoPower Generic_P2ItemPassiveUniqueRing033 { get; } = SnoData.Powers.GetBySno(430228u);

	public SnoPower Generic_P2ItemPassiveUniqueRing036 { get; } = SnoData.Powers.GetBySno(430672u);

	public SnoPower Generic_P2ItemPassiveUniqueRing037 { get; } = SnoData.Powers.GetBySno(430673u);

	public SnoPower Generic_P2ItemPassiveUniqueRing039 { get; } = SnoData.Powers.GetBySno(430675u);

	public SnoPower Generic_P2ItemPassiveUniqueRing040 { get; } = SnoData.Powers.GetBySno(430676u);

	public SnoPower Generic_P2ItemPassiveUniqueRing041 { get; } = SnoData.Powers.GetBySno(430677u);

	public SnoPower Generic_P2ItemPassiveUniqueRing044 { get; } = SnoData.Powers.GetBySno(430680u);

	public SnoPower Generic_P2ItemPassiveUniqueRing048 { get; } = SnoData.Powers.GetBySno(430684u);

	public SnoPower Generic_P2ItemPassiveUniqueRing049 { get; } = SnoData.Powers.GetBySno(430685u);

	public SnoPower Generic_P2ItemPassiveUniqueRing050 { get; } = SnoData.Powers.GetBySno(430686u);

	public SnoPower Generic_P2ItemPassiveUniqueRing059 { get; } = SnoData.Powers.GetBySno(435040u);

	public SnoPower Generic_P3ItemPassiveUniqueRing001 { get; } = SnoData.Powers.GetBySno(436426u);

	public SnoPower Generic_P3ItemPassiveUniqueRing002 { get; } = SnoData.Powers.GetBySno(436427u);

	public SnoPower Generic_P3ItemPassiveUniqueRing003 { get; } = SnoData.Powers.GetBySno(436428u);

	public SnoPower Generic_P3ItemPassiveUniqueRing005 { get; } = SnoData.Powers.GetBySno(436468u);

	public SnoPower Generic_P3ItemPassiveUniqueRing009 { get; } = SnoData.Powers.GetBySno(437710u);

	public SnoPower Generic_P3ItemPassiveUniqueRing010 { get; } = SnoData.Powers.GetBySno(437711u);

	public SnoPower Generic_P3ItemPassiveUniqueRing011 { get; } = SnoData.Powers.GetBySno(437840u);

	public SnoPower Generic_P3ItemPassiveUniqueRing012 { get; } = SnoData.Powers.GetBySno(437843u);

	public SnoPower Generic_P3ItemPassiveUniqueRing013 { get; } = SnoData.Powers.GetBySno(437844u);

	public SnoPower Generic_P3ItemPassiveUniqueRing015 { get; } = SnoData.Powers.GetBySno(439303u);

	public SnoPower Generic_P3ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(439308u);

	public SnoPower Generic_P3ItemPassiveUniqueRing017 { get; } = SnoData.Powers.GetBySno(439309u);

	public SnoPower Generic_P3ItemPassiveUniqueRing018 { get; } = SnoData.Powers.GetBySno(439310u);

	public SnoPower Generic_P3ItemPassiveUniqueRing019 { get; } = SnoData.Powers.GetBySno(439311u);

	public SnoPower Generic_P3ItemPassiveUniqueRing020 { get; } = SnoData.Powers.GetBySno(439312u);

	public SnoPower Generic_P3ItemPassiveUniqueRing021 { get; } = SnoData.Powers.GetBySno(440235u);

	public SnoPower Generic_P3ItemPassiveUniqueRing025 { get; } = SnoData.Powers.GetBySno(440568u);

	public SnoPower Generic_P3ItemPassiveUniqueRing026 { get; } = SnoData.Powers.GetBySno(440569u);

	public SnoPower Generic_P3ItemPassiveUniqueRing030 { get; } = SnoData.Powers.GetBySno(441113u);

	public SnoPower Generic_P3ItemPassiveUniqueRing033 { get; } = SnoData.Powers.GetBySno(441280u);

	public SnoPower Generic_P3ItemPassiveUniqueRing035 { get; } = SnoData.Powers.GetBySno(441305u);

	public SnoPower Generic_P3ItemPassiveUniqueRing036 { get; } = SnoData.Powers.GetBySno(441318u);

	public SnoPower Generic_P3ItemPassiveUniqueRing037 { get; } = SnoData.Powers.GetBySno(441349u);

	public SnoPower Generic_P3ItemPassiveUniqueRing039 { get; } = SnoData.Powers.GetBySno(442353u);

	public SnoPower Generic_P3ItemPassiveUniqueRing040 { get; } = SnoData.Powers.GetBySno(442477u);

	public SnoPower Generic_P41ItemPassiveUniqueRing001 { get; } = SnoData.Powers.GetBySno(451158u);

	public SnoPower Generic_P41ItemPassiveUniqueRing007 { get; } = SnoData.Powers.GetBySno(451165u);

	public SnoPower Generic_P41ItemPassiveUniqueRing013 { get; } = SnoData.Powers.GetBySno(451171u);

	public SnoPower Generic_P41ItemPassiveUniqueRing014 { get; } = SnoData.Powers.GetBySno(451172u);

	public SnoPower Generic_P41ItemPassiveUniqueRing015 { get; } = SnoData.Powers.GetBySno(451173u);

	public SnoPower Generic_P41ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(451174u);

	public SnoPower Generic_P41ItemPassiveUniqueRing017 { get; } = SnoData.Powers.GetBySno(451175u);

	public SnoPower Generic_P41ItemPassiveUniqueRing018 { get; } = SnoData.Powers.GetBySno(451176u);

	public SnoPower Generic_P41ItemPassiveUniqueRing019 { get; } = SnoData.Powers.GetBySno(451177u);

	public SnoPower Generic_P41ItemPassiveUniqueRing020 { get; } = SnoData.Powers.GetBySno(451178u);

	public SnoPower Generic_P41ItemPassiveUniqueRing021 { get; } = SnoData.Powers.GetBySno(451186u);

	public SnoPower Generic_P42ItemPassiveUniqueRing001 { get; } = SnoData.Powers.GetBySno(451236u);

	public SnoPower Generic_P42ItemPassiveUniqueRing004 { get; } = SnoData.Powers.GetBySno(451239u);

	public SnoPower Generic_P42ItemPassiveUniqueRing005 { get; } = SnoData.Powers.GetBySno(451240u);

	public SnoPower Generic_P42ItemPassiveUniqueRing006 { get; } = SnoData.Powers.GetBySno(451241u);

	public SnoPower Generic_P42ItemPassiveUniqueRing008 { get; } = SnoData.Powers.GetBySno(451243u);

	public SnoPower Generic_P42ItemPassiveUniqueRing697x1 { get; } = SnoData.Powers.GetBySno(451313u);

	public SnoPower Generic_P43ItemPassiveUniqueRing003 { get; } = SnoData.Powers.GetBySno(454929u);

	public SnoPower Generic_P43ItemPassiveUniqueRing011 { get; } = SnoData.Powers.GetBySno(454939u);

	public SnoPower Generic_P43ItemPassiveUniqueRing012 { get; } = SnoData.Powers.GetBySno(454940u);

	public SnoPower Generic_P4ItemPassiveUniqueRing001 { get; } = SnoData.Powers.GetBySno(444521u);

	public SnoPower Generic_P4ItemPassiveUniqueRing002 { get; } = SnoData.Powers.GetBySno(444522u);

	public SnoPower Generic_P4ItemPassiveUniqueRing003 { get; } = SnoData.Powers.GetBySno(444929u);

	public SnoPower Generic_P4ItemPassiveUniqueRing004 { get; } = SnoData.Powers.GetBySno(444969u);

	public SnoPower Generic_P4ItemPassiveUniqueRing005 { get; } = SnoData.Powers.GetBySno(445008u);

	public SnoPower Generic_P4ItemPassiveUniqueRing008 { get; } = SnoData.Powers.GetBySno(445279u);

	public SnoPower Generic_P4ItemPassiveUniqueRing010 { get; } = SnoData.Powers.GetBySno(445639u);

	public SnoPower Generic_P4ItemPassiveUniqueRing011 { get; } = SnoData.Powers.GetBySno(445692u);

	public SnoPower Generic_P4ItemPassiveUniqueRing014 { get; } = SnoData.Powers.GetBySno(445798u);

	public SnoPower Generic_P4ItemPassiveUniqueRing015 { get; } = SnoData.Powers.GetBySno(445814u);

	public SnoPower Generic_P4ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(445829u);

	public SnoPower Generic_P4ItemPassiveUniqueRing017 { get; } = SnoData.Powers.GetBySno(445920u);

	public SnoPower Generic_P4ItemPassiveUniqueRing018 { get; } = SnoData.Powers.GetBySno(445942u);

	public SnoPower Generic_P4ItemPassiveUniqueRing021 { get; } = SnoData.Powers.GetBySno(446063u);

	public SnoPower Generic_P4ItemPassiveUniqueRing027 { get; } = SnoData.Powers.GetBySno(446195u);

	public SnoPower Generic_P4ItemPassiveUniqueRing028 { get; } = SnoData.Powers.GetBySno(446318u);

	public SnoPower Generic_P4ItemPassiveUniqueRing031 { get; } = SnoData.Powers.GetBySno(446511u);

	public SnoPower Generic_P4ItemPassiveUniqueRing033 { get; } = SnoData.Powers.GetBySno(446562u);

	public SnoPower Generic_P4ItemPassiveUniqueRing037 { get; } = SnoData.Powers.GetBySno(446638u);

	public SnoPower Generic_P4ItemPassiveUniqueRing042 { get; } = SnoData.Powers.GetBySno(446734u);

	public SnoPower Generic_P4ItemPassiveUniqueRing043 { get; } = SnoData.Powers.GetBySno(446761u);

	public SnoPower Generic_P4ItemPassiveUniqueRing044 { get; } = SnoData.Powers.GetBySno(446762u);

	public SnoPower Generic_P4ItemPassiveUniqueRing051 { get; } = SnoData.Powers.GetBySno(447290u);

	public SnoPower Generic_P4ItemPassiveUniqueRing052 { get; } = SnoData.Powers.GetBySno(447291u);

	public SnoPower Generic_P4ItemPassiveUniqueRing057 { get; } = SnoData.Powers.GetBySno(447541u);

	public SnoPower Generic_P4ItemPassiveUniqueRing058 { get; } = SnoData.Powers.GetBySno(447553u);

	public SnoPower Generic_P4ItemPassiveUniqueRing059 { get; } = SnoData.Powers.GetBySno(447581u);

	public SnoPower Generic_P4ItemPassiveUniqueRing064 { get; } = SnoData.Powers.GetBySno(447905u);

	public SnoPower Generic_P4ItemPassiveUniqueRing066 { get; } = SnoData.Powers.GetBySno(449001u);

	public SnoPower Generic_P4ItemPassiveUniqueRing067 { get; } = SnoData.Powers.GetBySno(449021u);

	public SnoPower Generic_P4ItemPassiveUniqueRing069 { get; } = SnoData.Powers.GetBySno(449037u);

	public SnoPower Generic_P4ItemPassiveUniqueRing071 { get; } = SnoData.Powers.GetBySno(449046u);

	public SnoPower Generic_P4ItemPassiveUniqueRing076 { get; } = SnoData.Powers.GetBySno(449114u);

	public SnoPower Generic_P4ItemPassiveUniqueRing077 { get; } = SnoData.Powers.GetBySno(449222u);

	public SnoPower Generic_P4ItemPassiveUniqueRing079 { get; } = SnoData.Powers.GetBySno(449237u);

	public SnoPower Generic_P4ItemPassiveUniqueRing080 { get; } = SnoData.Powers.GetBySno(449252u);

	public SnoPower Generic_P4ItemPassiveUniqueRing081 { get; } = SnoData.Powers.GetBySno(449264u);

	public SnoPower Generic_P4ItemPassiveUniqueRing082 { get; } = SnoData.Powers.GetBySno(449671u);

	public SnoPower Generic_P4ItemPassiveUniqueRing083 { get; } = SnoData.Powers.GetBySno(449703u);

	public SnoPower Generic_P4ItemPassiveUniqueRing084 { get; } = SnoData.Powers.GetBySno(450294u);

	public SnoPower Generic_P4ItemPassiveUniqueRing085 { get; } = SnoData.Powers.GetBySno(450472u);

	public SnoPower Generic_P5ItemPassiveUniqueRing002 { get; } = SnoData.Powers.GetBySno(451257u);

	public SnoPower Generic_P5ItemPassiveUniqueRing003 { get; } = SnoData.Powers.GetBySno(451258u);

	public SnoPower Generic_P5ItemPassiveUniqueRing004 { get; } = SnoData.Powers.GetBySno(451259u);

	public SnoPower Generic_P5ItemPassiveUniqueRing005 { get; } = SnoData.Powers.GetBySno(451260u);

	public SnoPower Generic_P5ItemPassiveUniqueRing006 { get; } = SnoData.Powers.GetBySno(451261u);

	public SnoPower Generic_P5ItemPassiveUniqueRing007 { get; } = SnoData.Powers.GetBySno(451262u);

	public SnoPower Generic_P5ItemPassiveUniqueRing008 { get; } = SnoData.Powers.GetBySno(451263u);

	public SnoPower Generic_P5ItemPassiveUniqueRing009 { get; } = SnoData.Powers.GetBySno(451264u);

	public SnoPower Generic_P5ItemPassiveUniqueRing010 { get; } = SnoData.Powers.GetBySno(451265u);

	public SnoPower Generic_P5ItemPassiveUniqueRing011 { get; } = SnoData.Powers.GetBySno(451266u);

	public SnoPower Generic_P5ItemPassiveUniqueRing012 { get; } = SnoData.Powers.GetBySno(451267u);

	public SnoPower Generic_P5ItemPassiveUniqueRing013 { get; } = SnoData.Powers.GetBySno(451268u);

	public SnoPower Generic_P5ItemPassiveUniqueRing014 { get; } = SnoData.Powers.GetBySno(451269u);

	public SnoPower Generic_P5ItemPassiveUniqueRing015 { get; } = SnoData.Powers.GetBySno(451270u);

	public SnoPower Generic_P5ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(451271u);

	public SnoPower Generic_P5ItemPassiveUniqueRing017 { get; } = SnoData.Powers.GetBySno(451272u);

	public SnoPower Generic_P5ItemPassiveUniqueRing018 { get; } = SnoData.Powers.GetBySno(451273u);

	public SnoPower Generic_P5ItemPassiveUniqueRing019 { get; } = SnoData.Powers.GetBySno(451274u);

	public SnoPower Generic_P5ItemPassiveUniqueRing020 { get; } = SnoData.Powers.GetBySno(451275u);

	public SnoPower Generic_P61ItemPassiveUniqueRing027 { get; } = SnoData.Powers.GetBySno(478539u);

	public SnoPower Generic_P6ItemPassiveUniqueRing044 { get; } = SnoData.Powers.GetBySno(475248u);

	public SnoPower Generic_P6ItemPassiveUniqueRing045 { get; } = SnoData.Powers.GetBySno(475249u);

	public SnoPower Generic_P6ItemPassiveUniqueRing054 { get; } = SnoData.Powers.GetBySno(476050u);

	public SnoPower Generic_P6ItemPassiveUniqueRing057 { get; } = SnoData.Powers.GetBySno(476578u);

	public SnoPower Generic_P6ItemPassiveUniqueRing061 { get; } = SnoData.Powers.GetBySno(476582u);

	public SnoPower Generic_P6ItemPassiveUniqueRing067 { get; } = SnoData.Powers.GetBySno(476588u);

	public SnoPower Generic_P6ItemPassiveUniqueRing069 { get; } = SnoData.Powers.GetBySno(476590u);

	public SnoPower Generic_P6ItemPassiveUniqueRing072 { get; } = SnoData.Powers.GetBySno(476689u);

	public SnoPower Generic_P6ItemPassiveUniqueRing073 { get; } = SnoData.Powers.GetBySno(476695u);

	public SnoPower Generic_X1LegendaryPotion07 { get; } = SnoData.Powers.GetBySno(405166u);

	public SnoPower Generic_P74ItemPassiveUniqueRing016 { get; } = SnoData.Powers.GetBySno(488102u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMajor001 { get; } = SnoData.Powers.GetBySno(488004u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMajor002 { get; } = SnoData.Powers.GetBySno(488036u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMajor003 { get; } = SnoData.Powers.GetBySno(488037u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMajor004 { get; } = SnoData.Powers.GetBySno(488038u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor001 { get; } = SnoData.Powers.GetBySno(488006u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor002 { get; } = SnoData.Powers.GetBySno(488011u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor003 { get; } = SnoData.Powers.GetBySno(488012u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor004 { get; } = SnoData.Powers.GetBySno(488013u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor005 { get; } = SnoData.Powers.GetBySno(488014u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor006 { get; } = SnoData.Powers.GetBySno(488015u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor007 { get; } = SnoData.Powers.GetBySno(488016u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor008 { get; } = SnoData.Powers.GetBySno(488017u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor009 { get; } = SnoData.Powers.GetBySno(488018u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor010 { get; } = SnoData.Powers.GetBySno(488019u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor011 { get; } = SnoData.Powers.GetBySno(488020u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor012 { get; } = SnoData.Powers.GetBySno(488021u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor013 { get; } = SnoData.Powers.GetBySno(488022u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor014 { get; } = SnoData.Powers.GetBySno(488023u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor015 { get; } = SnoData.Powers.GetBySno(488024u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor016 { get; } = SnoData.Powers.GetBySno(488025u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor017 { get; } = SnoData.Powers.GetBySno(488026u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor018 { get; } = SnoData.Powers.GetBySno(488027u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor019 { get; } = SnoData.Powers.GetBySno(488028u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor020 { get; } = SnoData.Powers.GetBySno(488029u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor021 { get; } = SnoData.Powers.GetBySno(488030u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor022 { get; } = SnoData.Powers.GetBySno(488031u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor023 { get; } = SnoData.Powers.GetBySno(488032u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor024 { get; } = SnoData.Powers.GetBySno(488033u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor025 { get; } = SnoData.Powers.GetBySno(488034u);

	public SnoPower Generic_P75ItemPassiveDarkAlchemyMinor026 { get; } = SnoData.Powers.GetBySno(488035u);

	public IEnumerable<SnoPower> GetClassSpecificPowers(HeroClass heroClass)
	{
		return dictionary_0[heroClass];
	}

	public IEnumerable<SnoPower> GetLegendaryGemPowers()
	{
		return list_0;
	}

	public IEnumerable<SnoPower> GetLegendaryItemPowers()
	{
		return list_1;
	}

	public SnoPowerList()
	{
		List<SnoPower> list = new List<SnoPower>();
		dictionary_0[HeroClass.Barbarian] = list;
		list.Add(Barbarian_AncientSpear = SnoData.Powers.GetBySno(377453u));
		list.Add(Barbarian_Avalanche = SnoData.Powers.GetBySno(353447u));
		list.Add(Barbarian_Bash = SnoData.Powers.GetBySno(79242u));
		list.Add(Barbarian_BattleRage = SnoData.Powers.GetBySno(79076u));
		list.Add(Barbarian_CallOfTheAncients = SnoData.Powers.GetBySno(80049u));
		list.Add(Barbarian_Cleave = SnoData.Powers.GetBySno(80263u));
		list.Add(Barbarian_Earthquake = SnoData.Powers.GetBySno(98878u));
		list.Add(Barbarian_Frenzy = SnoData.Powers.GetBySno(78548u));
		list.Add(Barbarian_FuriousCharge = SnoData.Powers.GetBySno(97435u));
		list.Add(Barbarian_GroundStomp = SnoData.Powers.GetBySno(79446u));
		list.Add(Barbarian_HammerOfTheAncients = SnoData.Powers.GetBySno(80028u));
		list.Add(Barbarian_IgnorePain = SnoData.Powers.GetBySno(79528u));
		list.Add(Barbarian_Leap = SnoData.Powers.GetBySno(93409u));
		list.Add(Barbarian_Overpower = SnoData.Powers.GetBySno(159169u));
		list.Add(Barbarian_Rend = SnoData.Powers.GetBySno(70472u));
		list.Add(Barbarian_Revenge = SnoData.Powers.GetBySno(109342u));
		list.Add(Barbarian_SeismicSlam = SnoData.Powers.GetBySno(86989u));
		list.Add(Barbarian_Sprint = SnoData.Powers.GetBySno(78551u));
		list.Add(Barbarian_ThreateningShout = SnoData.Powers.GetBySno(79077u));
		list.Add(Barbarian_WarCry = SnoData.Powers.GetBySno(375483u));
		list.Add(Barbarian_WeaponThrow = SnoData.Powers.GetBySno(377452u));
		list.Add(Barbarian_Whirlwind = SnoData.Powers.GetBySno(96296u));
		list.Add(Barbarian_WrathOfTheBerserker = SnoData.Powers.GetBySno(79607u));
		list.Add(Barbarian_Passive_Animosity = SnoData.Powers.GetBySno(205228u));
		list.Add(Barbarian_Passive_BerserkerRage = SnoData.Powers.GetBySno(205187u));
		list.Add(Barbarian_Passive_Bloodthirst = SnoData.Powers.GetBySno(205217u));
		list.Add(Barbarian_Passive_BoonOfBulKathos = SnoData.Powers.GetBySno(204603u));
		list.Add(Barbarian_Passive_Brawler = SnoData.Powers.GetBySno(205133u));
		list.Add(Barbarian_Passive_EarthenMight = SnoData.Powers.GetBySno(361661u));
		list.Add(Barbarian_Passive_InspiringPresence = SnoData.Powers.GetBySno(205546u));
		list.Add(Barbarian_Passive_Juggernaut = SnoData.Powers.GetBySno(205707u));
		list.Add(Barbarian_Passive_NervesOfSteel = SnoData.Powers.GetBySno(217819u));
		list.Add(Barbarian_Passive_NoEscape = SnoData.Powers.GetBySno(204725u));
		list.Add(Barbarian_Passive_PoundOfFlesh = SnoData.Powers.GetBySno(205205u));
		list.Add(Barbarian_Passive_Rampage = SnoData.Powers.GetBySno(296572u));
		list.Add(Barbarian_Passive_Relentless = SnoData.Powers.GetBySno(205398u));
		list.Add(Barbarian_Passive_Ruthless = SnoData.Powers.GetBySno(205175u));
		list.Add(Barbarian_Passive_Superstition = SnoData.Powers.GetBySno(205491u));
		list.Add(Barbarian_Passive_SwordAndBoard = SnoData.Powers.GetBySno(340877u));
		list.Add(Barbarian_Passive_ToughAsNails = SnoData.Powers.GetBySno(205848u));
		list.Add(Barbarian_Passive_Unforgiving = SnoData.Powers.GetBySno(205300u));
		list.Add(Barbarian_Passive_WeaponsMaster = SnoData.Powers.GetBySno(206147u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.Crusader] = list;
		list.Add(Crusader_AkaratsChampion = SnoData.Powers.GetBySno(269032u));
		list.Add(Crusader_BlessedHammer = SnoData.Powers.GetBySno(266766u));
		list.Add(Crusader_BlessedShield = SnoData.Powers.GetBySno(266951u));
		list.Add(Crusader_Bombardment = SnoData.Powers.GetBySno(284876u));
		list.Add(Crusader_Condemn = SnoData.Powers.GetBySno(266627u));
		list.Add(Crusader_Consecration = SnoData.Powers.GetBySno(273941u));
		list.Add(Crusader_CrushingResolve = SnoData.Powers.GetBySno(267818u));
		list.Add(Crusader_FallingSword = SnoData.Powers.GetBySno(239137u));
		list.Add(Crusader_FistOfTheHeavens = SnoData.Powers.GetBySno(239218u));
		list.Add(Crusader_HeavensFury = SnoData.Powers.GetBySno(316014u));
		list.Add(Crusader_IronSkin = SnoData.Powers.GetBySno(291804u));
		list.Add(Crusader_Judgment = SnoData.Powers.GetBySno(267600u));
		list.Add(Crusader_Justice = SnoData.Powers.GetBySno(325216u));
		list.Add(Crusader_LawsOfHope = SnoData.Powers.GetBySno(342279u));
		list.Add(Crusader_LawsOfJustice = SnoData.Powers.GetBySno(342280u));
		list.Add(Crusader_LawsOfValor = SnoData.Powers.GetBySno(342281u));
		list.Add(Crusader_Phalanx = SnoData.Powers.GetBySno(330729u));
		list.Add(Crusader_Provoke = SnoData.Powers.GetBySno(290545u));
		list.Add(Crusader_Punish = SnoData.Powers.GetBySno(285903u));
		list.Add(Crusader_ShieldBash = SnoData.Powers.GetBySno(353492u));
		list.Add(Crusader_ShieldGlare = SnoData.Powers.GetBySno(268530u));
		list.Add(Crusader_Slash = SnoData.Powers.GetBySno(289243u));
		list.Add(Crusader_Smite = SnoData.Powers.GetBySno(286510u));
		list.Add(Crusader_SteedCharge = SnoData.Powers.GetBySno(243853u));
		list.Add(Crusader_SweepAttack = SnoData.Powers.GetBySno(239042u));
		list.Add(Crusader_Passive_Blunt = SnoData.Powers.GetBySno(348773u));
		list.Add(Crusader_Passive_DivineFortress = SnoData.Powers.GetBySno(356176u));
		list.Add(Crusader_Passive_Fanaticism = SnoData.Powers.GetBySno(357269u));
		list.Add(Crusader_Passive_Fervor = SnoData.Powers.GetBySno(357218u));
		list.Add(Crusader_Passive_Finery = SnoData.Powers.GetBySno(311629u));
		list.Add(Crusader_Passive_HeavenlyStrength = SnoData.Powers.GetBySno(286177u));
		list.Add(Crusader_Passive_HoldYourGround = SnoData.Powers.GetBySno(302500u));
		list.Add(Crusader_Passive_HolyCause = SnoData.Powers.GetBySno(310804u));
		list.Add(Crusader_Passive_Indestructible = SnoData.Powers.GetBySno(309830u));
		list.Add(Crusader_Passive_Insurmountable = SnoData.Powers.GetBySno(310640u));
		list.Add(Crusader_Passive_IronMaiden = SnoData.Powers.GetBySno(310783u));
		list.Add(Crusader_Passive_LongArmOfTheLaw = SnoData.Powers.GetBySno(310678u));
		list.Add(Crusader_Passive_LordCommander = SnoData.Powers.GetBySno(348741u));
		list.Add(Crusader_Passive_Renewal = SnoData.Powers.GetBySno(356173u));
		list.Add(Crusader_Passive_Righteousness = SnoData.Powers.GetBySno(356147u));
		list.Add(Crusader_Passive_ToweringShield = SnoData.Powers.GetBySno(356052u));
		list.Add(Crusader_Passive_Vigilant = SnoData.Powers.GetBySno(310626u));
		list.Add(Crusader_Passive_Wrathful = SnoData.Powers.GetBySno(310775u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.DemonHunter] = list;
		list.Add(DemonHunter_Bolas = SnoData.Powers.GetBySno(77552u));
		list.Add(DemonHunter_Caltrops = SnoData.Powers.GetBySno(129216u));
		list.Add(DemonHunter_Chakram = SnoData.Powers.GetBySno(129213u));
		list.Add(DemonHunter_ClusterArrow = SnoData.Powers.GetBySno(129214u));
		list.Add(DemonHunter_Companion = SnoData.Powers.GetBySno(365311u));
		list.Add(DemonHunter_ElementalArrow = SnoData.Powers.GetBySno(131325u));
		list.Add(DemonHunter_EntanglingShot = SnoData.Powers.GetBySno(361936u));
		list.Add(DemonHunter_EvasiveFire = SnoData.Powers.GetBySno(377450u));
		list.Add(DemonHunter_FanOfKnives = SnoData.Powers.GetBySno(77546u));
		list.Add(DemonHunter_Grenades = SnoData.Powers.GetBySno(86610u));
		list.Add(DemonHunter_HungeringArrow = SnoData.Powers.GetBySno(129215u));
		list.Add(DemonHunter_Impale = SnoData.Powers.GetBySno(131366u));
		list.Add(DemonHunter_MarkedForDeath = SnoData.Powers.GetBySno(130738u));
		list.Add(DemonHunter_Multishot = SnoData.Powers.GetBySno(77649u));
		list.Add(DemonHunter_P74Ballista = SnoData.Powers.GetBySno(487822u));
		list.Add(DemonHunter_Preparation = SnoData.Powers.GetBySno(129212u));
		list.Add(DemonHunter_RainOfVengeance = SnoData.Powers.GetBySno(130831u));
		list.Add(DemonHunter_RapidFire = SnoData.Powers.GetBySno(131192u));
		list.Add(DemonHunter_Sentry = SnoData.Powers.GetBySno(129217u));
		list.Add(DemonHunter_ShadowPower = SnoData.Powers.GetBySno(130830u));
		list.Add(DemonHunter_SmokeScreen = SnoData.Powers.GetBySno(130695u));
		list.Add(DemonHunter_SpikeTrap = SnoData.Powers.GetBySno(75301u));
		list.Add(DemonHunter_Strafe = SnoData.Powers.GetBySno(134030u));
		list.Add(DemonHunter_Vault = SnoData.Powers.GetBySno(111215u));
		list.Add(DemonHunter_Vengeance = SnoData.Powers.GetBySno(302846u));
		list.Add(DemonHunter_Passive_Ambush = SnoData.Powers.GetBySno(352920u));
		list.Add(DemonHunter_Passive_Archery = SnoData.Powers.GetBySno(209734u));
		list.Add(DemonHunter_Passive_Awareness = SnoData.Powers.GetBySno(324770u));
		list.Add(DemonHunter_Passive_Ballistics = SnoData.Powers.GetBySno(155723u));
		list.Add(DemonHunter_Passive_Brooding = SnoData.Powers.GetBySno(210801u));
		list.Add(DemonHunter_Passive_CompanionPassiveEffect = SnoData.Powers.GetBySno(365312u));
		list.Add(DemonHunter_Passive_CullTheWeak = SnoData.Powers.GetBySno(155721u));
		list.Add(DemonHunter_Passive_CustomEngineering = SnoData.Powers.GetBySno(208610u));
		list.Add(DemonHunter_Passive_Grenadier = SnoData.Powers.GetBySno(208779u));
		list.Add(DemonHunter_Passive_HotPursuit = SnoData.Powers.GetBySno(155725u));
		list.Add(DemonHunter_Passive_Leech = SnoData.Powers.GetBySno(439525u));
		list.Add(DemonHunter_Passive_NightStalker = SnoData.Powers.GetBySno(218350u));
		list.Add(DemonHunter_Passive_NumbingTraps = SnoData.Powers.GetBySno(218398u));
		list.Add(DemonHunter_Passive_Perfectionist = SnoData.Powers.GetBySno(155722u));
		list.Add(DemonHunter_Passive_PreparationPassiveEffect = SnoData.Powers.GetBySno(324845u));
		list.Add(DemonHunter_Passive_Sharpshooter = SnoData.Powers.GetBySno(155715u));
		list.Add(DemonHunter_Passive_SingleOut = SnoData.Powers.GetBySno(338859u));
		list.Add(DemonHunter_Passive_SteadyAim = SnoData.Powers.GetBySno(164363u));
		list.Add(DemonHunter_Passive_TacticalAdvantage = SnoData.Powers.GetBySno(218385u));
		list.Add(DemonHunter_Passive_ThrillOfTheHunt = SnoData.Powers.GetBySno(211225u));
		list.Add(DemonHunter_Passive_VengeancePassiveEffect = SnoData.Powers.GetBySno(155714u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.Monk] = list;
		list.Add(Monk_BlindingFlash = SnoData.Powers.GetBySno(136954u));
		list.Add(Monk_BreathOfHeaven = SnoData.Powers.GetBySno(69130u));
		list.Add(Monk_CripplingWave = SnoData.Powers.GetBySno(96311u));
		list.Add(Monk_CycloneStrike = SnoData.Powers.GetBySno(223473u));
		list.Add(Monk_DashingStrike = SnoData.Powers.GetBySno(312736u));
		list.Add(Monk_DeadlyReach = SnoData.Powers.GetBySno(96019u));
		list.Add(Monk_Epiphany = SnoData.Powers.GetBySno(312307u));
		list.Add(Monk_ExplodingPalm = SnoData.Powers.GetBySno(97328u));
		list.Add(Monk_FistsOfThunder = SnoData.Powers.GetBySno(95940u));
		list.Add(Monk_InnerSanctuary = SnoData.Powers.GetBySno(317076u));
		list.Add(Monk_LashingTailKick = SnoData.Powers.GetBySno(111676u));
		list.Add(Monk_MantraOfConviction = SnoData.Powers.GetBySno(375088u));
		list.Add(Monk_MantraOfHealing = SnoData.Powers.GetBySno(373143u));
		list.Add(Monk_MantraOfRetribution = SnoData.Powers.GetBySno(375082u));
		list.Add(Monk_MantraOfSalvation = SnoData.Powers.GetBySno(375049u));
		list.Add(Monk_MysticAlly = SnoData.Powers.GetBySno(362102u));
		list.Add(Monk_Serenity = SnoData.Powers.GetBySno(96215u));
		list.Add(Monk_P74WayOfTheHundredFists = SnoData.Powers.GetBySno(487707u));
		list.Add(Monk_SevenSidedStrike = SnoData.Powers.GetBySno(96694u));
		list.Add(Monk_SweepingWind = SnoData.Powers.GetBySno(96090u));
		list.Add(Monk_TempestRush = SnoData.Powers.GetBySno(121442u));
		list.Add(Monk_WaveOfLight = SnoData.Powers.GetBySno(96033u));
		list.Add(Monk_WayOfTheHundredFists = SnoData.Powers.GetBySno(97110u));
		list.Add(Monk_Passive_Alacrity = SnoData.Powers.GetBySno(156492u));
		list.Add(Monk_Passive_BeaconOfYtar = SnoData.Powers.GetBySno(209104u));
		list.Add(Monk_Passive_ChantOfResonance = SnoData.Powers.GetBySno(156467u));
		list.Add(Monk_Passive_CombinationStrike = SnoData.Powers.GetBySno(218415u));
		list.Add(Monk_Passive_Determination = SnoData.Powers.GetBySno(402633u));
		list.Add(Monk_Passive_ExaltedSoul = SnoData.Powers.GetBySno(209027u));
		list.Add(Monk_Passive_FleetFooted = SnoData.Powers.GetBySno(209029u));
		list.Add(Monk_Passive_Harmony = SnoData.Powers.GetBySno(404168u));
		list.Add(Monk_Passive_MantraOfConvictionV2 = SnoData.Powers.GetBySno(375089u));
		list.Add(Monk_Passive_MantraOfEvasionV2 = SnoData.Powers.GetBySno(375050u));
		list.Add(Monk_Passive_MantraOfHealingV2 = SnoData.Powers.GetBySno(373154u));
		list.Add(Monk_Passive_MantraOfRetributionV2 = SnoData.Powers.GetBySno(375083u));
		list.Add(Monk_Passive_Momentum = SnoData.Powers.GetBySno(341559u));
		list.Add(Monk_Passive_MythicRhythm = SnoData.Powers.GetBySno(315271u));
		list.Add(Monk_Passive_NearDeathExperience = SnoData.Powers.GetBySno(156484u));
		list.Add(Monk_Passive_RelentlessAssault = SnoData.Powers.GetBySno(404245u));
		list.Add(Monk_Passive_Resolve = SnoData.Powers.GetBySno(211581u));
		list.Add(Monk_Passive_SeizeTheInitiative = SnoData.Powers.GetBySno(209628u));
		list.Add(Monk_Passive_SixthSense = SnoData.Powers.GetBySno(209622u));
		list.Add(Monk_Passive_TheGuardiansPath = SnoData.Powers.GetBySno(209812u));
		list.Add(Monk_Passive_Transcendence = SnoData.Powers.GetBySno(209250u));
		list.Add(Monk_Passive_Unity = SnoData.Powers.GetBySno(368899u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.Necromancer] = list;
		list.Add(Necromancer_ArmyOfTheDead = SnoData.Powers.GetBySno(460358u));
		list.Add(Necromancer_BloodRush = SnoData.Powers.GetBySno(454090u));
		list.Add(Necromancer_BoneArmor = SnoData.Powers.GetBySno(466857u));
		list.Add(Necromancer_BoneSpear = SnoData.Powers.GetBySno(451490u));
		list.Add(Necromancer_BoneSpikes = SnoData.Powers.GetBySno(462147u));
		list.Add(Necromancer_BoneSpirit = SnoData.Powers.GetBySno(464896u));
		list.Add(Necromancer_CommandGolem = SnoData.Powers.GetBySno(451537u));
		list.Add(Necromancer_CommandSkeletons = SnoData.Powers.GetBySno(453801u));
		list.Add(Necromancer_CorpseExplosion = SnoData.Powers.GetBySno(454174u));
		list.Add(Necromancer_CorpseLance = SnoData.Powers.GetBySno(461650u));
		list.Add(Necromancer_DeathNova = SnoData.Powers.GetBySno(462243u));
		list.Add(Necromancer_Decrepify = SnoData.Powers.GetBySno(451491u));
		list.Add(Necromancer_Devour = SnoData.Powers.GetBySno(460757u));
		list.Add(Necromancer_Frailty = SnoData.Powers.GetBySno(460870u));
		list.Add(Necromancer_GrimScythe = SnoData.Powers.GetBySno(462198u));
		list.Add(Necromancer_LandOfTheDead = SnoData.Powers.GetBySno(465839u));
		list.Add(Necromancer_Leech = SnoData.Powers.GetBySno(462255u));
		list.Add(Necromancer_Revive = SnoData.Powers.GetBySno(462239u));
		list.Add(Necromancer_Simulacrum = SnoData.Powers.GetBySno(465350u));
		list.Add(Necromancer_SiphonBlood = SnoData.Powers.GetBySno(453563u));
		list.Add(Necromancer_SkeletalMage = SnoData.Powers.GetBySno(462089u));
		list.Add(Necromancer_Passive_AberrantAnimator = SnoData.Powers.GetBySno(472949u));
		list.Add(Necromancer_Passive_BloodForBlood = SnoData.Powers.GetBySno(465821u));
		list.Add(Necromancer_Passive_BloodIsPower = SnoData.Powers.GetBySno(465037u));
		list.Add(Necromancer_Passive_BonePrison = SnoData.Powers.GetBySno(472965u));
		list.Add(Necromancer_Passive_CommanderOfTheRisenDead = SnoData.Powers.GetBySno(472962u));
		list.Add(Necromancer_Passive_DarkReaping = SnoData.Powers.GetBySno(470812u));
		list.Add(Necromancer_Passive_DecrepifyPassiveEffect = SnoData.Powers.GetBySno(471738u));
		list.Add(Necromancer_Passive_DrawLife = SnoData.Powers.GetBySno(465264u));
		list.Add(Necromancer_Passive_EternalTorment = SnoData.Powers.GetBySno(472795u));
		list.Add(Necromancer_Passive_ExtendedServitude = SnoData.Powers.GetBySno(464994u));
		list.Add(Necromancer_Passive_FinalService = SnoData.Powers.GetBySno(465952u));
		list.Add(Necromancer_Passive_FrailtyPassiveEffect = SnoData.Powers.GetBySno(471845u));
		list.Add(Necromancer_Passive_FueledByDeath = SnoData.Powers.GetBySno(465917u));
		list.Add(Necromancer_Passive_GrislyTribute = SnoData.Powers.GetBySno(473019u));
		list.Add(Necromancer_Passive_LeechPassiveEffect = SnoData.Powers.GetBySno(471869u));
		list.Add(Necromancer_Passive_LifeFromDeath = SnoData.Powers.GetBySno(465703u));
		list.Add(Necromancer_Passive_OverwhelmingEssence = SnoData.Powers.GetBySno(470764u));
		list.Add(Necromancer_Passive_RathmasShield = SnoData.Powers.GetBySno(472910u));
		list.Add(Necromancer_Passive_RigorMortis = SnoData.Powers.GetBySno(466415u));
		list.Add(Necromancer_Passive_Serration = SnoData.Powers.GetBySno(472905u));
		list.Add(Necromancer_Passive_SpreadingMalediction = SnoData.Powers.GetBySno(472220u));
		list.Add(Necromancer_Passive_StandAlone = SnoData.Powers.GetBySno(470725u));
		list.Add(Necromancer_Passive_SwiftHarvesting = SnoData.Powers.GetBySno(470805u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.WitchDoctor] = list;
		list.Add(WitchDoctor_AcidCloud = SnoData.Powers.GetBySno(70455u));
		list.Add(WitchDoctor_BigBadVoodoo = SnoData.Powers.GetBySno(117402u));
		list.Add(WitchDoctor_CorpseSpider = SnoData.Powers.GetBySno(69866u));
		list.Add(WitchDoctor_FetishArmy = SnoData.Powers.GetBySno(72785u));
		list.Add(WitchDoctor_Firebats = SnoData.Powers.GetBySno(105963u));
		list.Add(WitchDoctor_Firebomb = SnoData.Powers.GetBySno(67567u));
		list.Add(WitchDoctor_Gargantuan = SnoData.Powers.GetBySno(30624u));
		list.Add(WitchDoctor_GraspOfTheDead = SnoData.Powers.GetBySno(69182u));
		list.Add(WitchDoctor_Haunt = SnoData.Powers.GetBySno(83602u));
		list.Add(WitchDoctor_Hex = SnoData.Powers.GetBySno(30631u));
		list.Add(WitchDoctor_Horrify = SnoData.Powers.GetBySno(67668u));
		list.Add(WitchDoctor_LocustSwarm = SnoData.Powers.GetBySno(69867u));
		list.Add(WitchDoctor_MassConfusion = SnoData.Powers.GetBySno(67600u));
		list.Add(WitchDoctor_Piranhas = SnoData.Powers.GetBySno(347265u));
		list.Add(WitchDoctor_PlagueOfToads = SnoData.Powers.GetBySno(106465u));
		list.Add(WitchDoctor_PoisonDart = SnoData.Powers.GetBySno(103181u));
		list.Add(WitchDoctor_Sacrifice = SnoData.Powers.GetBySno(102572u));
		list.Add(WitchDoctor_SoulHarvest = SnoData.Powers.GetBySno(67616u));
		list.Add(WitchDoctor_SpiritBarrage = SnoData.Powers.GetBySno(108506u));
		list.Add(WitchDoctor_SpiritWalk = SnoData.Powers.GetBySno(106237u));
		list.Add(WitchDoctor_SummonZombieDog = SnoData.Powers.GetBySno(102573u));
		list.Add(WitchDoctor_WallOfDeath = SnoData.Powers.GetBySno(134837u));
		list.Add(WitchDoctor_ZombieCharger = SnoData.Powers.GetBySno(74003u));
		list.Add(WitchDoctor_Passive_BadMedicine = SnoData.Powers.GetBySno(217826u));
		list.Add(WitchDoctor_Passive_BloodRitual = SnoData.Powers.GetBySno(208568u));
		list.Add(WitchDoctor_Passive_CircleOfLife = SnoData.Powers.GetBySno(208571u));
		list.Add(WitchDoctor_Passive_ConfidenceRitual = SnoData.Powers.GetBySno(442741u));
		list.Add(WitchDoctor_Passive_CreepingDeath = SnoData.Powers.GetBySno(340908u));
		list.Add(WitchDoctor_Passive_FetishSycophants = SnoData.Powers.GetBySno(218588u));
		list.Add(WitchDoctor_Passive_FierceLoyalty = SnoData.Powers.GetBySno(208639u));
		list.Add(WitchDoctor_Passive_GraveInjustice = SnoData.Powers.GetBySno(218191u));
		list.Add(WitchDoctor_Passive_GruesomeFeast = SnoData.Powers.GetBySno(208594u));
		list.Add(WitchDoctor_Passive_JungleFortitude = SnoData.Powers.GetBySno(217968u));
		list.Add(WitchDoctor_Passive_MidnightFeast = SnoData.Powers.GetBySno(340909u));
		list.Add(WitchDoctor_Passive_PierceTheVeil = SnoData.Powers.GetBySno(208628u));
		list.Add(WitchDoctor_Passive_RushOfEssence = SnoData.Powers.GetBySno(208565u));
		list.Add(WitchDoctor_Passive_SpiritualAttunement = SnoData.Powers.GetBySno(208569u));
		list.Add(WitchDoctor_Passive_SpiritVessel = SnoData.Powers.GetBySno(218501u));
		list.Add(WitchDoctor_Passive_SwamplandAttunement = SnoData.Powers.GetBySno(340910u));
		list.Add(WitchDoctor_Passive_TraitZombieDogSpawner = SnoData.Powers.GetBySno(109560u));
		list.Add(WitchDoctor_Passive_TribalRites = SnoData.Powers.GetBySno(208601u));
		list.Add(WitchDoctor_Passive_VisionQuest = SnoData.Powers.GetBySno(209041u));
		list.Add(WitchDoctor_Passive_ZombieHandler = SnoData.Powers.GetBySno(208563u));
		list = new List<SnoPower>();
		dictionary_0[HeroClass.Wizard] = list;
		list.Add(Wizard_ArcaneOrb = SnoData.Powers.GetBySno(30668u));
		list.Add(Wizard_ArcaneTorrent = SnoData.Powers.GetBySno(134456u));
		list.Add(Wizard_Archon = SnoData.Powers.GetBySno(134872u));
		list.Add(Wizard_ArchonArcaneBlast = SnoData.Powers.GetBySno(167355u));
		list.Add(Wizard_ArchonArcaneBlastCold = SnoData.Powers.GetBySno(392883u));
		list.Add(Wizard_ArchonArcaneBlastFire = SnoData.Powers.GetBySno(392884u));
		list.Add(Wizard_ArchonArcaneBlastLightning = SnoData.Powers.GetBySno(392885u));
		list.Add(Wizard_ArchonArcaneStrike = SnoData.Powers.GetBySno(135166u));
		list.Add(Wizard_ArchonArcaneStrikeCold = SnoData.Powers.GetBySno(392886u));
		list.Add(Wizard_ArchonArcaneStrikeFire = SnoData.Powers.GetBySno(392887u));
		list.Add(Wizard_ArchonArcaneStrikeLightning = SnoData.Powers.GetBySno(392888u));
		list.Add(Wizard_ArchonCancel = SnoData.Powers.GetBySno(166616u));
		list.Add(Wizard_ArchonDisintegrationWave = SnoData.Powers.GetBySno(135238u));
		list.Add(Wizard_ArchonDisintegrationWaveCold = SnoData.Powers.GetBySno(392889u));
		list.Add(Wizard_ArchonDisintegrationWaveFire = SnoData.Powers.GetBySno(392890u));
		list.Add(Wizard_ArchonDisintegrationWaveLightning = SnoData.Powers.GetBySno(392891u));
		list.Add(Wizard_ArchonSlowTime = SnoData.Powers.GetBySno(135663u));
		list.Add(Wizard_ArchonTeleport = SnoData.Powers.GetBySno(167648u));
		list.Add(Wizard_BlackHole = SnoData.Powers.GetBySno(243141u));
		list.Add(Wizard_Blizzard = SnoData.Powers.GetBySno(30680u));
		list.Add(Wizard_DiamondSkin = SnoData.Powers.GetBySno(75599u));
		list.Add(Wizard_Disintegrate = SnoData.Powers.GetBySno(91549u));
		list.Add(Wizard_Electrocute = SnoData.Powers.GetBySno(1765u));
		list.Add(Wizard_EnergyArmor = SnoData.Powers.GetBySno(86991u));
		list.Add(Wizard_EnergyTwister = SnoData.Powers.GetBySno(77113u));
		list.Add(Wizard_ExplosiveBlast = SnoData.Powers.GetBySno(87525u));
		list.Add(Wizard_Familiar = SnoData.Powers.GetBySno(99120u));
		list.Add(Wizard_FrostNova = SnoData.Powers.GetBySno(30718u));
		list.Add(Wizard_Hydra = SnoData.Powers.GetBySno(30725u));
		list.Add(Wizard_IceArmor = SnoData.Powers.GetBySno(73223u));
		list.Add(Wizard_MagicMissile = SnoData.Powers.GetBySno(30744u));
		list.Add(Wizard_MagicWeapon = SnoData.Powers.GetBySno(76108u));
		list.Add(Wizard_Meteor = SnoData.Powers.GetBySno(69190u));
		list.Add(Wizard_MirrorImage = SnoData.Powers.GetBySno(98027u));
		list.Add(Wizard_RayOfFrost = SnoData.Powers.GetBySno(93395u));
		list.Add(Wizard_ShockPulse = SnoData.Powers.GetBySno(30783u));
		list.Add(Wizard_SlowTime = SnoData.Powers.GetBySno(1769u));
		list.Add(Wizard_SpectralBlade = SnoData.Powers.GetBySno(71548u));
		list.Add(Wizard_StormArmor = SnoData.Powers.GetBySno(74499u));
		list.Add(Wizard_Teleport = SnoData.Powers.GetBySno(168344u));
		list.Add(Wizard_WaveOfForce = SnoData.Powers.GetBySno(30796u));
		list.Add(Wizard_Passive_ArcaneDynamo = SnoData.Powers.GetBySno(208823u));
		list.Add(Wizard_Passive_AstralPresence = SnoData.Powers.GetBySno(208472u));
		list.Add(Wizard_Passive_Audacity = SnoData.Powers.GetBySno(341540u));
		list.Add(Wizard_Passive_Blur = SnoData.Powers.GetBySno(208468u));
		list.Add(Wizard_Passive_ColdBlooded = SnoData.Powers.GetBySno(226301u));
		list.Add(Wizard_Passive_Conflagration = SnoData.Powers.GetBySno(218044u));
		list.Add(Wizard_Passive_Dominance = SnoData.Powers.GetBySno(341344u));
		list.Add(Wizard_Passive_ElementalExposure = SnoData.Powers.GetBySno(342326u));
		list.Add(Wizard_Passive_Evocation = SnoData.Powers.GetBySno(208473u));
		list.Add(Wizard_Passive_GalvanizingWard = SnoData.Powers.GetBySno(208541u));
		list.Add(Wizard_Passive_GlassCannon = SnoData.Powers.GetBySno(208471u));
		list.Add(Wizard_Passive_Illusionist = SnoData.Powers.GetBySno(208547u));
		list.Add(Wizard_Passive_Paralysis = SnoData.Powers.GetBySno(226348u));
		list.Add(Wizard_Passive_PowerHungry = SnoData.Powers.GetBySno(208478u));
		list.Add(Wizard_Passive_Prodigy = SnoData.Powers.GetBySno(208493u));
		list.Add(Wizard_Passive_TemporalFlux = SnoData.Powers.GetBySno(208477u));
		list.Add(Wizard_Passive_UnstableAnomaly = SnoData.Powers.GetBySno(208474u));
		list.Add(Wizard_Passive_UnwaveringWill = SnoData.Powers.GetBySno(298038u));
		list_0.Add(BaneOfThePowerfulPrimary);
		list_0.Add(BaneOfThePowerfulSecondary);
		list_0.Add(BaneOfTheStrickenPrimary);
		list_0.Add(BaneOfTheStrickenSecondary);
		list_0.Add(BaneOfTheTrappedPrimary);
		list_0.Add(BaneOfTheTrappedSecondary);
		list_0.Add(BoonOfTheHoarderPrimary);
		list_0.Add(BoonOfTheHoarderSecondary);
		list_0.Add(BoyarskysChipPrimary);
		list_0.Add(BoyarskysChipSecondary);
		list_0.Add(EnforcerPrimary);
		list_0.Add(EnforcerSecondary);
		list_0.Add(EsotericAlterationPrimary);
		list_0.Add(EsotericAlterationSecondary);
		list_0.Add(GemOfEasePrimary);
		list_0.Add(GemOfEaseSecondary);
		list_0.Add(GemOfEfficaciousToxinPrimary);
		list_0.Add(GemOfEfficaciousToxinSecondary);
		list_0.Add(GogokOfSwiftnessPrimary);
		list_0.Add(GogokOfSwiftnessSecondary);
		list_0.Add(IceblinkPrimary);
		list_0.Add(IceblinkSecondary);
		list_0.Add(InvigoratingGemstonePrimary);
		list_0.Add(InvigoratingGemstoneSecondary);
		list_0.Add(LegacyOfDreamsPrimary);
		list_0.Add(LegacyOfDreamsSecondary);
		list_0.Add(MirinaeTeardropOfTheStarweaverPrimary);
		list_0.Add(MirinaeTeardropOfTheStarweaverSecondary);
		list_0.Add(MoltenWildebeestsGizzardPrimary);
		list_0.Add(MoltenWildebeestsGizzardSecondary);
		list_0.Add(MoratoriumPrimary);
		list_0.Add(MoratoriumSecondary);
		list_0.Add(MutilationGuardPrimary);
		list_0.Add(MutilationGuardSecondary);
		list_0.Add(PainEnhancerPrimary);
		list_0.Add(PainEnhancerSecondary);
		list_0.Add(RedSoulShardPrimary);
		list_0.Add(RedSoulShardSecondary);
		list_0.Add(SimplicitysStrengthPrimary);
		list_0.Add(SimplicitysStrengthSecondary);
		list_0.Add(TaegukPrimary);
		list_0.Add(TaegukSecondary);
		list_0.Add(WhisperOfAtonementPrimary);
		list_0.Add(WhisperOfAtonementSecondary);
		list_0.Add(WreathOfLightningPrimary);
		list_0.Add(WreathOfLightningSecondary);
		list_0.Add(ZeisStoneOfVengeancePrimary);
		list_0.Add(ZeisStoneOfVengeanceSecondary);
		list_1.Add(AetherWalker);
		list_1.Add(AhavarionSpearOfLycander);
		list_1.Add(AkaratsAwakening);
		list_1.Add(AkkhansAddendum);
		list_1.Add(AkkhansLeniency);
		list_1.Add(AkkhansManacles);
		list_1.Add(AmbosPride);
		list_1.Add(AncestorsGrace);
		list_1.Add(AncientParthanDefenders);
		list_1.Add(AndarielsVisage);
		list_1.Add(AnessaziEdge);
		list_1.Add(AngelHairBraid);
		list_1.Add(AquilaCuirass);
		list_1.Add(ArchmagesVicalyke);
		list_1.Add(Arcstone);
		list_1.Add(ArmorOfTheKindRegent);
		list_1.Add(ArreatsLaw);
		list_1.Add(ArthefsSparkOfLife);
		list_1.Add(AshnagarrsBloodBracer);
		list_1.Add(AugustinesPanacea);
		list_1.Add(Azurewrath);
		list_1.Add(BakuliJungleWraps);
		list_1.Add(Balance);
		list_1.Add(BalefulRemnant);
		list_1.Add(BandOfHollowWhispers);
		list_1.Add(BandOfMight);
		list_1.Add(BandOfTheRueChambers);
		list_1.Add(BastionsRevered);
		list_1.Add(BeckonSail);
		list_1.Add(BeltOfTheTrove);
		list_1.Add(BeltOfTranscendence);
		list_1.Add(BindingOfTheLost);
		list_1.Add(BindingsOfTheLesserGods);
		list_1.Add(Blackfeather);
		list_1.Add(BladeOfProphecy);
		list_1.Add(BladeOfTheTribes);
		list_1.Add(BladeOfTheWarlord);
		list_1.Add(BlessedOfHaull);
		list_1.Add(BloodBrother);
		list_1.Add(BloodsongMail);
		list_1.Add(BloodtideBlade);
		list_1.Add(BombardiersRucksack);
		list_1.Add(BondsOfCLena);
		list_1.Add(BoneRinger);
		list_1.Add(BottomlessPotionOfAmplification);
		list_1.Add(BottomlessPotionOfChaos);
		list_1.Add(BottomlessPotionOfFear);
		list_1.Add(BottomlessPotionOfKulleAid);
		list_1.Add(BottomlessPotionOfRejuvenation);
		list_1.Add(BottomlessPotionOfTheUnfettered);
		list_1.Add(BovineBardiche);
		list_1.Add(BracerOfFury);
		list_1.Add(BracersOfDestruction);
		list_1.Add(BracersOfTheFirstMen);
		list_1.Add(BriggsWrath);
		list_1.Add(BrokenCrown);
		list_1.Add(BrokenPromises);
		list_1.Add(BroodOfAraneae);
		list_1.Add(BrynersJourney);
		list_1.Add(BulKathossWeddingBand);
		list_1.Add(BurizaDoKyanon);
		list_1.Add(ButchersCarver);
		list_1.Add(Calamity);
		list_1.Add(CamsRebuttal);
		list_1.Add(CapeOfTheDarkNight);
		list_1.Add(Carnevil);
		list_1.Add(CesarsMemento);
		list_1.Add(Chaingmail);
		list_1.Add(ChainOfShadows);
		list_1.Add(ChanonBolter);
		list_1.Add(ChilaniksChain);
		list_1.Add(Cindercoat);
		list_1.Add(CircleOfNailujsEvol);
		list_1.Add(Cluckeye);
		list_1.Add(CoilsOfTheFirstSpider);
		list_1.Add(ConventionOfElements);
		list_1.Add(CordOfTheSherma);
		list_1.Add(CorpsewhisperPauldrons);
		list_1.Add(CorruptedAshbringer);
		list_1.Add(CountessJuliasCameo);
		list_1.Add(CrashingRain);
		list_1.Add(CrownOfThePrimus);
		list_1.Add(CrystalFist);
		list_1.Add(CusterianWristguards);
		list_1.Add(DanettasRevenge);
		list_1.Add(DanettasSpite);
		list_1.Add(Darklight);
		list_1.Add(DarkMagesShade);
		list_1.Add(Dawn);
		list_1.Add(DaynteesBinding);
		list_1.Add(DeadlyRebirth);
		list_1.Add(DeadMansLegacy);
		list_1.Add(DeathseersCowl);
		list_1.Add(DeathWatchMantle);
		list_1.Add(Deathwish);
		list_1.Add(DefenderOfWestmarch);
		list_1.Add(DefilerCuisses);
		list_1.Add(DemonMachine);
		list_1.Add(Denial);
		list_1.Add(DepthDiggers);
		list_1.Add(DishonoredLegacy);
		list_1.Add(DovuEnergyTrap);
		list_1.Add(DrakonsLesson);
		list_1.Add(DreadIron);
		list_1.Add(DregsOfLies);
		list_1.Add(EberliCharo);
		list_1.Add(EchoingFury);
		list_1.Add(ElusiveRing);
		list_1.Add(EmimeisDuffel);
		list_1.Add(EnchantingFavor);
		list_1.Add(EssenceOfAnguish);
		list_1.Add(EtchedSigil);
		list_1.Add(EternalUnion);
		list_1.Add(Eunjangdo);
		list_1.Add(EyeOfPeshkov);
		list_1.Add(FaithfulMemory);
		list_1.Add(FateOfTheFell);
		list_1.Add(FatesVow);
		list_1.Add(FazulasImprobableChain);
		list_1.Add(FireWalkers);
		list_1.Add(FjordCutter);
		list_1.Add(FlailOfTheAscended);
		list_1.Add(Fleshrake);
		list_1.Add(FlyingDragon);
		list_1.Add(FortressBallista);
		list_1.Add(FragmentOfDestiny);
		list_1.Add(FragmentOfDestruction);
		list_1.Add(FreezeOfDeflection);
		list_1.Add(Frostburn);
		list_1.Add(FrydehrsWrath);
		list_1.Add(Fulminator);
		list_1.Add(FuneraryPick);
		list_1.Add(FuryOfTheAncients);
		list_1.Add(FuryOfTheVanishedPeak);
		list_1.Add(GabrielsVambraces);
		list_1.Add(GazingDemise);
		list_1.Add(GelmindorsMarrowGuards);
		list_1.Add(Genzaniku);
		list_1.Add(GestureOfOrpheus);
		list_1.Add(GirdleOfGiants);
		list_1.Add(GladiatorGauntlets);
		list_1.Add(GoldenFlense);
		list_1.Add(Goldskin);
		list_1.Add(Goldwrap);
		list_1.Add(GolemskinBreeches);
		list_1.Add(GraspsOfEssence);
		list_1.Add(GuardOfJohanna);
		list_1.Add(GungdoGear);
		list_1.Add(GyanaNaKashu);
		list_1.Add(GyrfalconsFoote);
		list_1.Add(Hack);
		list_1.Add(HallowedBulwark);
		list_1.Add(HaloOfArlyse);
		list_1.Add(HaloOfKarini);
		list_1.Add(HammerJammers);
		list_1.Add(HandOfTheProphet);
		list_1.Add(HarringtonWaistguard);
		list_1.Add(HauntedVisions);
		list_1.Add(HauntingGirdle);
		list_1.Add(HauntOfVaxo);
		list_1.Add(HeartOfIron);
		list_1.Add(HellcatWaistguard);
		list_1.Add(Hellrack);
		list_1.Add(Hellskull);
		list_1.Add(HenrisPerquisition);
		list_1.Add(HergbrashsBinding);
		list_1.Add(HexingPantsOfMrYan);
		list_1.Add(HillenbrandsTrainingSword);
		list_1.Add(HolyPointShot);
		list_1.Add(HomingPads);
		list_1.Add(Homunculus);
		list_1.Add(HuntersWrath);
		list_1.Add(HwojWrap);
		list_1.Add(IceClimbers);
		list_1.Add(IncenseTorchOfTheGrandTemple);
		list_1.Add(Ingeom);
		list_1.Add(InviolableFaith);
		list_1.Add(IronRose);
		list_1.Add(IrontoeMudsputters);
		list_1.Add(IvoryTower);
		list_1.Add(JacesHammerOfVigilance);
		list_1.Add(JangsEnvelopment);
		list_1.Add(Jawbreaker);
		list_1.Add(Jekangbord);
		list_1.Add(JeramsBracers);
		list_1.Add(JohannasArgument);
		list_1.Add(JusticeLantern);
		list_1.Add(JustiniansMercy);
		list_1.Add(KarleisPoint);
		list_1.Add(KassarsRetribution);
		list_1.Add(KekegisUnbreakableSpirit);
		list_1.Add(KhassettsCordOfRighteousness);
		list_1.Add(KmarTenclip);
		list_1.Add(KredesFlame);
		list_1.Add(KrelmsBuffBelt);
		list_1.Add(KrelmsBuffBracers);
		list_1.Add(Kridershot);
		list_1.Add(KrysbinsSentence);
		list_1.Add(KymbosGold);
		list_1.Add(KyoshirosBlade);
		list_1.Add(KyoshirosSoul);
		list_1.Add(LakumbasOrnament);
		list_1.Add(Lamentation);
		list_1.Add(LastBreath);
		list_1.Add(LefebvresSoliloquy);
		list_1.Add(LegersDisdain);
		list_1.Add(LeonineBowOfHashir);
		list_1.Add(LiannasWings);
		list_1.Add(LightOfGrace);
		list_1.Add(LionsClaw);
		list_1.Add(LordGreenstonesFan);
		list_1.Add(LornellesSunstone);
		list_1.Add(LostTime);
		list_1.Add(LutSocks);
		list_1.Add(MadawcsSorrow);
		list_1.Add(Madstone);
		list_1.Add(Magefist);
		list_1.Add(MalothsFocus);
		list_1.Add(MaltoriusPetrifiedSpike);
		list_1.Add(ManaldHeal);
		list_1.Add(Manticore);
		list_1.Add(MantleOfChanneling);
		list_1.Add(MarasKaleidoscope);
		list_1.Add(MaskOfJeram);
		list_1.Add(MaskOfScarletDeath);
		list_1.Add(Maximus);
		list_1.Add(MempoOfTwilight);
		list_1.Add(MesserschmidtsReaver);
		list_1.Add(Mirrorball);
		list_1.Add(MoonlightWard);
		list_1.Add(MordullusPromise);
		list_1.Add(MoribundGauntlets);
		list_1.Add(MorticksBrace);
		list_1.Add(MykensBallOfHate);
		list_1.Add(Nagelring);
		list_1.Add(NayrsBlackDeath);
		list_1.Add(NemesisBracers);
		list_1.Add(NilfursBoast);
		list_1.Add(Oathkeeper);
		list_1.Add(ObsidianRingOfTheZodiac);
		list_1.Add(OculusRing);
		list_1.Add(OdynSon);
		list_1.Add(OdysseysEnd);
		list_1.Add(Omnislash);
		list_1.Add(OmrynsChain);
		list_1.Add(OrbOfInfiniteDepth);
		list_1.Add(PigSticker);
		list_1.Add(PintosPride);
		list_1.Add(PoxFaulds);
		list_1.Add(PrideOfCassius);
		list_1.Add(PrimordialSoul);
		list_1.Add(PromiseOfGlory);
		list_1.Add(PusSpitter);
		list_1.Add(PuzzleRing);
		list_1.Add(Quetzalcoatl);
		list_1.Add(RabidStrike);
		list_1.Add(RakoffsGlassOfLife);
		list_1.Add(RanslorsFolly);
		list_1.Add(RazethsVolition);
		list_1.Add(RazorStrop);
		list_1.Add(RechelsRingOfLarceny);
		list_1.Add(ReilenasShadowhook);
		list_1.Add(RelicOfAkarat);
		list_1.Add(RemnantOfPain);
		list_1.Add(Remorseless);
		list_1.Add(RequiemCereplate);
		list_1.Add(RhenhoFlayer);
		list_1.Add(RibaldEtchings);
		list_1.Add(Rimeheart);
		list_1.Add(RingOfEmptiness);
		list_1.Add(RiveraDancers);
		list_1.Add(RogarsHugeStone);
		list_1.Add(SacredHarness);
		list_1.Add(SacredHarvester);
		list_1.Add(SaffronWrap);
		list_1.Add(SashOfKnives);
		list_1.Add(Scarbringer);
		list_1.Add(SchaefersHammer);
		list_1.Add(Scourge);
		list_1.Add(Scrimshaw);
		list_1.Add(ScytheOfTheCycle);
		list_1.Add(SeborsNightmare);
		list_1.Add(SerpentsSparker);
		list_1.Add(Sever);
		list_1.Add(ShardOfHate);
		list_1.Add(ShardOfHatred);
		list_1.Add(ShieldOfFury);
		list_1.Add(ShiMizusHaori);
		list_1.Add(ShukranisTriumph);
		list_1.Add(SinSeekers);
		list_1.Add(SkeletonKey);
		list_1.Add(SkularsSalvation);
		list_1.Add(SkullGrasp);
		list_1.Add(SkullOfResonance);
		list_1.Add(Skycutter);
		list_1.Add(SkySplitter);
		list_1.Add(Skywarden);
		list_1.Add(SlipkasLetterOpener);
		list_1.Add(SliverOfTerror);
		list_1.Add(SloraksMadness);
		list_1.Add(SmokingThurible);
		list_1.Add(Solanium);
		list_1.Add(SpauldersOfZakara);
		list_1.Add(SpearOfJairo);
		list_1.Add(SpinesOfSeethingHatred);
		list_1.Add(SpiritGuards);
		list_1.Add(SquirtsNecklace);
		list_1.Add(StaffOfChiroptera);
		list_1.Add(StainOfSin);
		list_1.Add(StalgardsDecimator);
		list_1.Add(Standoff);
		list_1.Add(StArchewsGage);
		list_1.Add(Starfire);
		list_1.Add(StarmetalKukri);
		list_1.Add(SteuartsGreaves);
		list_1.Add(StoneGauntlets);
		list_1.Add(StoneOfJordan);
		list_1.Add(StormCrow);
		list_1.Add(StringOfEars);
		list_1.Add(StrongarmBracers);
		list_1.Add(SublimeConviction);
		list_1.Add(SuWongDiviner);
		list_1.Add(SwampLandWaders);
		list_1.Add(Swiftmount);
		list_1.Add(SwordOfIllWill);
		list_1.Add(TalismanOfAranoch);
		list_1.Add(TaskerandTheo);
		list_1.Add(TheBarber);
		list_1.Add(TheBurningAxeOfSankis);
		list_1.Add(TheButchersSickle);
		list_1.Add(TheCloakOfTheGarwulf);
		list_1.Add(TheCrudestBoots);
		list_1.Add(TheDaggerOfDarts);
		list_1.Add(TheDemonsDemise);
		list_1.Add(TheEssOfJohan);
		list_1.Add(TheExecutioner);
		list_1.Add(TheFinalWitness);
		list_1.Add(TheFistOfAzTurrasq);
		list_1.Add(TheFlavorOfTime);
		list_1.Add(TheFlowOfEternity);
		list_1.Add(TheFurnace);
		list_1.Add(TheGavelOfJudgment);
		list_1.Add(TheGidbinn);
		list_1.Add(TheGrandVizier);
		list_1.Add(TheGrinReaper);
		list_1.Add(TheJohnstone);
		list_1.Add(TheLawsOfSeph);
		list_1.Add(TheMagistrate);
		list_1.Add(TheMindsEye);
		list_1.Add(TheMortalDrama);
		list_1.Add(TheNinthCirriSatchel);
		list_1.Add(TheOculus);
		list_1.Add(ThePaddle);
		list_1.Add(TheRavensWing);
		list_1.Add(TheShameOfDelsere);
		list_1.Add(TheShortMansFinger);
		list_1.Add(TheSmolderingCore);
		list_1.Add(TheSpiderQueensGrasp);
		list_1.Add(TheStarOfAzkaranth);
		list_1.Add(TheSwami);
		list_1.Add(TheTallMansFinger);
		list_1.Add(TheThreeHundredthSpear);
		list_1.Add(TheTormentor);
		list_1.Add(TheTwistedSword);
		list_1.Add(TheUndisputedChampion);
		list_1.Add(ThingOfTheDeep);
		list_1.Add(ThunderfuryBlessedBladeOfTheWindseeker);
		list_1.Add(ThundergodsVigor);
		list_1.Add(TiklandianVisage);
		list_1.Add(TragOulCoils);
		list_1.Add(TragOulsCorrodedFang);
		list_1.Add(Triumvirate);
		list_1.Add(TzoKrinsGaze);
		list_1.Add(UhkapianSerpent);
		list_1.Add(Unity);
		list_1.Add(UnrelentingPhalanx);
		list_1.Add(UnstableScepter);
		list_1.Add(UrsuasTroddenEffigy);
		list_1.Add(VadimsSurge);
		list_1.Add(VallasBequest);
		list_1.Add(ValtheksRebuke);
		list_1.Add(VambracesOfSescheron);
		list_1.Add(VelvetCamaral);
		list_1.Add(VengefulWind);
		list_1.Add(Vigilance);
		list_1.Add(VigilanteBelt);
		list_1.Add(VileHive);
		list_1.Add(VileWard);
		list_1.Add(VisageOfGiyua);
		list_1.Add(VisageOfGunes);
		list_1.Add(VoosJuicer);
		list_1.Add(VoToyiasSpiker);
		list_1.Add(WandOfWoh);
		list_1.Add(WarhelmOfKassar);
		list_1.Add(WarstaffOfGeneralQuang);
		list_1.Add(WarzechianArmguards);
		list_1.Add(WilkensReach);
		list_1.Add(WinterFlurry);
		list_1.Add(WisdomOfKalan);
		list_1.Add(Wizardspike);
		list_1.Add(WojahnniAssaulter);
		list_1.Add(WonKhimLau);
		list_1.Add(Wormwood);
		list_1.Add(WrapsOfClarity);
		list_1.Add(Wyrdward);
		list_1.Add(XephirianAmulet);
		list_1.Add(YangsRecurve);
		list_1.Add(ZoeysSecret);
		Generic_1000MonsterFightMeteor = SnoData.Powers.GetBySno(199789u);
		Generic_a1dunLeorBigFireGrate = SnoData.Powers.GetBySno(108017u);
		Generic_a1dunLeorFireGutterfire = SnoData.Powers.GetBySno(175159u);
		Generic_a1dunLeorHallwayBladeTrap = SnoData.Powers.GetBySno(441108u);
		Generic_a1dunleoricfireTrench = SnoData.Powers.GetBySno(89418u);
		Generic_a1dunleoricfireTrench01 = SnoData.Powers.GetBySno(90428u);
		Generic_a1dunleoricfireTrench02 = SnoData.Powers.GetBySno(112259u);
		Generic_a2dunAqdActWoodPlatformDamage = SnoData.Powers.GetBySno(396386u);
		Generic_a2dunCaveGoatmenDroppingLogTrapattack = SnoData.Powers.GetBySno(175069u);
		Generic_a2dunCaveLarva = SnoData.Powers.GetBySno(206565u);
		Generic_a2dunCaveLarvaAOE = SnoData.Powers.GetBySno(189864u);
		Generic_a2dunCaveSlimeGeyserA = SnoData.Powers.GetBySno(114308u);
		Generic_a2dunZoltTeslaTowerColdspawnAttack = SnoData.Powers.GetBySno(223739u);
		Generic_a2dunZoltTeslaTowerFire = SnoData.Powers.GetBySno(29983u);
		Generic_a2dunZoltTeslaTowerFirespawnAttack = SnoData.Powers.GetBySno(223738u);
		Generic_a2dunZoltTeslaTowerIceNova = SnoData.Powers.GetBySno(29984u);
		Generic_a2dunZoltTeslaTowerLightningpewpew = SnoData.Powers.GetBySno(174642u);
		Generic_a2dunZoltTeslaTowerLightningspawnAttack = SnoData.Powers.GetBySno(223731u);
		Generic_a2dunZoltTeslaTowerPoisonspawnAttack = SnoData.Powers.GetBySno(223740u);
		Generic_A2EvacuationBelialBomb = SnoData.Powers.GetBySno(153000u);
		Generic_a3battlefielddemonicforge = SnoData.Powers.GetBySno(174905u);
		Generic_A3BattlefieldDemonMineAOE = SnoData.Powers.GetBySno(122327u);
		Generic_a3dunbastionKeepGuardFireAtNothing = SnoData.Powers.GetBySno(180931u);
		Generic_a3duncraterDemonClawBombA = SnoData.Powers.GetBySno(162328u);
		Generic_a3dunCraterDemonClawBombAtrigger = SnoData.Powers.GetBySno(206575u);
		Generic_a3duncraterDemonGroundTrapGasChamber = SnoData.Powers.GetBySno(123043u);
		Generic_a3duncraterDemonGroundTrapGasChamberFireOnly = SnoData.Powers.GetBySno(212330u);
		Generic_a3dunKeepBarrelStackShortDamage = SnoData.Powers.GetBySno(55014u);
		Generic_a3dunKeepExplodingBarrelStunpower = SnoData.Powers.GetBySno(186638u);
		Generic_a3dunkeepfireTrench01 = SnoData.Powers.GetBySno(200051u);
		Generic_a3dunkeepfireTrench02 = SnoData.Powers.GetBySno(200038u);
		Generic_A3IntroCatapultAttack = SnoData.Powers.GetBySno(244155u);
		Generic_a4dunGardenCorruptionMine = SnoData.Powers.GetBySno(188960u);
		Generic_a4dunHeavenHellRiftFallingRocksA = SnoData.Powers.GetBySno(223721u);
		Generic_a4dunHeavenHellRiftFallingRocksB = SnoData.Powers.GetBySno(223722u);
		Generic_a4DunHellFissure = SnoData.Powers.GetBySno(223286u);
		Generic_a4dunSpireCorruptionGeyser = SnoData.Powers.GetBySno(219695u);
		Generic_a4dunspirefirewall = SnoData.Powers.GetBySno(223284u);
		Generic_a4dunspireSpikeTrap = SnoData.Powers.GetBySno(220634u);
		Generic_ActorDisabledBuff = SnoData.Powers.GetBySno(93716u);
		Generic_ActorGhostedBuff = SnoData.Powers.GetBySno(224639u);
		Generic_ActorInTownBuff = SnoData.Powers.GetBySno(220304u);
		Generic_ActorInvulBuff = SnoData.Powers.GetBySno(439438u);
		Generic_ActorLoadingBuff = SnoData.Powers.GetBySno(212032u);
		Generic_Adriaevent47blast = SnoData.Powers.GetBySno(199222u);
		Generic_Adriaevent47projectile = SnoData.Powers.GetBySno(199198u);
		Generic_AIBackpedal = SnoData.Powers.GetBySno(313697u);
		Generic_AIBackpedalOneShotThroughActors = SnoData.Powers.GetBySno(327537u);
		Generic_AICircle = SnoData.Powers.GetBySno(29986u);
		Generic_AICircleLong = SnoData.Powers.GetBySno(29987u);
		Generic_AICircleStrafe = SnoData.Powers.GetBySno(29989u);
		Generic_AICircleStrafeShort = SnoData.Powers.GetBySno(29988u);
		Generic_AIClose = SnoData.Powers.GetBySno(29990u);
		Generic_AICloseFar = SnoData.Powers.GetBySno(466012u);
		Generic_AICloseFarther = SnoData.Powers.GetBySno(477010u);
		Generic_AICloseLong = SnoData.Powers.GetBySno(29991u);
		Generic_AIEscortFollow = SnoData.Powers.GetBySno(29992u);
		Generic_AIEvadeBuff = SnoData.Powers.GetBySno(99543u);
		Generic_AIFollow = SnoData.Powers.GetBySno(29993u);
		Generic_AIFollowClose = SnoData.Powers.GetBySno(29995u);
		Generic_AIFollowMeleeLead = SnoData.Powers.GetBySno(104514u);
		Generic_AIFollowMeleeLeadPet = SnoData.Powers.GetBySno(231004u);
		Generic_AIFollowMeleeLeadPetFar = SnoData.Powers.GetBySno(472153u);
		Generic_AIFollowPath = SnoData.Powers.GetBySno(29994u);
		Generic_AIFollowWithWalk = SnoData.Powers.GetBySno(1728u);
		Generic_AIFollowWithWalkFar = SnoData.Powers.GetBySno(467524u);
		Generic_AIFollowWithWalkNatural = SnoData.Powers.GetBySno(477018u);
		Generic_AIIdle = SnoData.Powers.GetBySno(29996u);
		Generic_AIIdleLong = SnoData.Powers.GetBySno(29997u);
		Generic_AIIdleShort = SnoData.Powers.GetBySno(29998u);
		Generic_AIOrbit = SnoData.Powers.GetBySno(55433u);
		Generic_AIReturnToGuardObject = SnoData.Powers.GetBySno(193411u);
		Generic_AIReturnToPath = SnoData.Powers.GetBySno(30000u);
		Generic_AIRunAway = SnoData.Powers.GetBySno(30001u);
		Generic_AIRunAwayLong = SnoData.Powers.GetBySno(30002u);
		Generic_AIRunAwayShort = SnoData.Powers.GetBySno(30003u);
		Generic_AIRunAwayShortV2 = SnoData.Powers.GetBySno(410363u);
		Generic_AIRunInFront = SnoData.Powers.GetBySno(30004u);
		Generic_AIRunInFrontGuaranteed = SnoData.Powers.GetBySno(163339u);
		Generic_AIRunNearby = SnoData.Powers.GetBySno(30005u);
		Generic_AIRunNearbyGloam = SnoData.Powers.GetBySno(30006u);
		Generic_AIRunNearbyLong = SnoData.Powers.GetBySno(30007u);
		Generic_AIRunNearbyShort = SnoData.Powers.GetBySno(30008u);
		Generic_AIRunTo = SnoData.Powers.GetBySno(30009u);
		Generic_AIRunToGuaranteed = SnoData.Powers.GetBySno(163338u);
		Generic_AIRunToGuaranteedSpider = SnoData.Powers.GetBySno(376110u);
		Generic_AISprintInFrontGuaranteed = SnoData.Powers.GetBySno(163336u);
		Generic_AISprintTo = SnoData.Powers.GetBySno(82805u);
		Generic_AISprintToGuaranteed = SnoData.Powers.GetBySno(163335u);
		Generic_AIStrafe = SnoData.Powers.GetBySno(30010u);
		Generic_AITownWalkToGuaranteed = SnoData.Powers.GetBySno(217618u);
		Generic_AIWalkInFront = SnoData.Powers.GetBySno(30012u);
		Generic_AIWalkInFrontGuaranteed = SnoData.Powers.GetBySno(163334u);
		Generic_AIWalkTo = SnoData.Powers.GetBySno(30013u);
		Generic_AIWalkToGuaranteed = SnoData.Powers.GetBySno(163333u);
		Generic_AIWander = SnoData.Powers.GetBySno(1729u);
		Generic_AIWanderLong = SnoData.Powers.GetBySno(30015u);
		Generic_AIWanderMinion = SnoData.Powers.GetBySno(476791u);
		Generic_AIWanderRun = SnoData.Powers.GetBySno(30014u);
		Generic_AIWandersuperLong = SnoData.Powers.GetBySno(30016u);
		Generic_AIWarnOthers = SnoData.Powers.GetBySno(114421u);
		Generic_AncientSpearKnockback = SnoData.Powers.GetBySno(106281u);
		Generic_AngelCorruptPiercingDash = SnoData.Powers.GetBySno(440446u);
		Generic_AnniversaryBuffEXPMF = SnoData.Powers.GetBySno(311167u);
		Generic_AxeBadData = SnoData.Powers.GetBySno(30020u);
		Generic_AxeOperateGizmo = SnoData.Powers.GetBySno(30021u);
		Generic_AxeOperateNPC = SnoData.Powers.GetBySno(30022u);
		Generic_AzmodanAODDamage = SnoData.Powers.GetBySno(123199u);
		Generic_AzmodanFallingCorpses = SnoData.Powers.GetBySno(122700u);
		Generic_AzmodanGlobeOfAnnihilation = SnoData.Powers.GetBySno(122699u);
		Generic_AzmodanLaserAttack = SnoData.Powers.GetBySno(129243u);
		Generic_AzmodanMelee = SnoData.Powers.GetBySno(133744u);
		Generic_AzmodanonDeath = SnoData.Powers.GetBySno(176046u);
		Generic_AzmodanPhase3Channel = SnoData.Powers.GetBySno(123466u);
		Generic_AzmodanTaunt = SnoData.Powers.GetBySno(211934u);
		Generic_AzmodanTurning = SnoData.Powers.GetBySno(211856u);
		Generic_BannerDrop = SnoData.Powers.GetBySno(185040u);
		Generic_BannerDropPVP = SnoData.Powers.GetBySno(234255u);
		Generic_BanterCooldown = SnoData.Powers.GetBySno(134334u);
		Generic_BarbarianCallOfTheAncientsBasicMelee = SnoData.Powers.GetBySno(187092u);
		Generic_BarbarianCallOfTheAncientsCleave = SnoData.Powers.GetBySno(168823u);
		Generic_BarbarianCallOfTheAncientsFuriousCharge = SnoData.Powers.GetBySno(168824u);
		Generic_BarbarianCallOfTheAncientsLeap = SnoData.Powers.GetBySno(168825u);
		Generic_BarbarianCallOfTheAncientsSeismicSlam = SnoData.Powers.GetBySno(168827u);
		Generic_BarbarianCallOfTheAncientsWeaponThrow = SnoData.Powers.GetBySno(168828u);
		Generic_BarbarianCallOfTheAncientsWhirlwind = SnoData.Powers.GetBySno(168830u);
		Generic_BarbarianGroundStompEffect = SnoData.Powers.GetBySno(30080u);
		Generic_BarbarianLeapOLD = SnoData.Powers.GetBySno(30097u);
		Generic_BarbarianOverpowerCowKing = SnoData.Powers.GetBySno(368239u);
		Generic_BarbarianRevengeBuff = SnoData.Powers.GetBySno(109344u);
		Generic_BarbarianWhirlwindDustDevilsPassability = SnoData.Powers.GetBySno(442221u);
		Generic_BareHandedPassive = SnoData.Powers.GetBySno(30145u);
		Generic_BarrelExplodeInstant = SnoData.Powers.GetBySno(1736u);
		Generic_BeastCharge = SnoData.Powers.GetBySno(30147u);
		Generic_BeastWeaponMeleeInstant = SnoData.Powers.GetBySno(109289u);
		Generic_BelialArmProxy = SnoData.Powers.GetBySno(259123u);
		Generic_BelialGroundPound = SnoData.Powers.GetBySno(67753u);
		Generic_BelialLightningBreath = SnoData.Powers.GetBySno(95856u);
		Generic_BelialLightningStrikeEnrage = SnoData.Powers.GetBySno(241757u);
		Generic_BelialLightningStrikev2 = SnoData.Powers.GetBySno(96212u);
		Generic_BelialMelee = SnoData.Powers.GetBySno(96712u);
		Generic_BelialMeleeReach = SnoData.Powers.GetBySno(156429u);
		Generic_BelialPhase3Buff = SnoData.Powers.GetBySno(95811u);
		Generic_BelialRangedAttack = SnoData.Powers.GetBySno(63079u);
		Generic_BelialSprint = SnoData.Powers.GetBySno(98565u);
		Generic_BelialSprintAway = SnoData.Powers.GetBySno(105312u);
		Generic_BigRedCharge = SnoData.Powers.GetBySno(149875u);
		Generic_BigRedFireBreath = SnoData.Powers.GetBySno(150552u);
		Generic_BlockChance10 = SnoData.Powers.GetBySno(355392u);
		Generic_BodyGuardTeleport = SnoData.Powers.GetBySno(131193u);
		Generic_BoneTurretMortarCast = SnoData.Powers.GetBySno(433233u);
		Generic_BountyGroundsBurrowOut = SnoData.Powers.GetBySno(446530u);
		Generic_BrickhouseArmShields = SnoData.Powers.GetBySno(72675u);
		Generic_BrickhouseDestructionSetup = SnoData.Powers.GetBySno(180875u);
		Generic_BrickhouseEnrage = SnoData.Powers.GetBySno(72713u);
		Generic_BrickhouseSlam = SnoData.Powers.GetBySno(72812u);
		Generic_BugWingsBuff = SnoData.Powers.GetBySno(255336u);
		Generic_BurrowIn = SnoData.Powers.GetBySno(30156u);
		Generic_BurrowInHidden = SnoData.Powers.GetBySno(194582u);
		Generic_BurrowInSetup = SnoData.Powers.GetBySno(69949u);
		Generic_BurrowInSetup2HSwing = SnoData.Powers.GetBySno(327086u);
		Generic_BurrowInSetupHidden = SnoData.Powers.GetBySno(346610u);
		Generic_BurrowInSetupStaff = SnoData.Powers.GetBySno(327088u);
		Generic_BurrowOut = SnoData.Powers.GetBySno(30157u);
		Generic_BurrowOutNoFacing = SnoData.Powers.GetBySno(75226u);
		Generic_BurrowOutSetup = SnoData.Powers.GetBySno(194596u);
		Generic_BurrowStartBuff = SnoData.Powers.GetBySno(30158u);
		Generic_ButcherDamagingFire = SnoData.Powers.GetBySno(86627u);
		Generic_ButcherFloorPanelFire = SnoData.Powers.GetBySno(96925u);
		Generic_ButcherFrenzy = SnoData.Powers.GetBySno(85001u);
		Generic_ButcherFrenzyCustomLRBoss = SnoData.Powers.GetBySno(364220u);
		Generic_ButcherGrapplingHook = SnoData.Powers.GetBySno(83008u);
		Generic_ButcherOnDeath = SnoData.Powers.GetBySno(209203u);
		Generic_ButcherSlam = SnoData.Powers.GetBySno(85152u);
		Generic_ButcherSmash = SnoData.Powers.GetBySno(30160u);
		Generic_ButcherSpears = SnoData.Powers.GetBySno(198671u);
		Generic_ButcherTargetRanged = SnoData.Powers.GetBySno(109153u);
		Generic_CainIntroSwing = SnoData.Powers.GetBySno(102449u);
		Generic_CaldeumPoisonLaser = SnoData.Powers.GetBySno(156211u);
		Generic_CalldownGrenade = SnoData.Powers.GetBySno(91155u);
		Generic_CalloutCooldown = SnoData.Powers.GetBySno(134225u);
		Generic_CameraFocusBuff = SnoData.Powers.GetBySno(151595u);
		Generic_CameraFocusPetBuff = SnoData.Powers.GetBySno(151604u);
		Generic_CannotDieDuringBuff = SnoData.Powers.GetBySno(225599u);
		Generic_caOutBoneYardsCollapsingBonesDamage = SnoData.Powers.GetBySno(396376u);
		Generic_caOutOasisAttackPlantattack = SnoData.Powers.GetBySno(102874u);
		Generic_CatapultAttack = SnoData.Powers.GetBySno(108036u);
		Generic_ChampionClone = SnoData.Powers.GetBySno(30166u);
		Generic_ChampionTeleport = SnoData.Powers.GetBySno(30167u);
		Generic_CleanupSummonsOnDeath = SnoData.Powers.GetBySno(442438u);
		Generic_CollectorsEditionBuff = SnoData.Powers.GetBySno(208706u);
		Generic_CommunityBuffDarkAlchemy = SnoData.Powers.GetBySno(488071u);
		Generic_CommunityBuffLegacyOfNightmares = SnoData.Powers.GetBySno(483485u);
		Generic_CommunityBuffNestingPortalSpawn = SnoData.Powers.GetBySno(488544u);
		Generic_CommunityBuffPandemonium = SnoData.Powers.GetBySno(483967u);
		Generic_CommunityBuffShadowClones = SnoData.Powers.GetBySno(484633u);
		Generic_CommunityBuffTriunesWill = SnoData.Powers.GetBySno(483606u);
		Generic_CommunityBuffWeather = SnoData.Powers.GetBySno(484426u);
		Generic_CommunityEventBuffEXPMF = SnoData.Powers.GetBySno(370781u);
		Generic_CompanionBuff = SnoData.Powers.GetBySno(275399u);
		Generic_ConsolePowerGlobe = SnoData.Powers.GetBySno(300082u);
		Generic_ConsumablePotionBuffs = SnoData.Powers.GetBySno(409455u);
		Generic_Cooldown = SnoData.Powers.GetBySno(30176u);
		Generic_CopiedVisualEffectsBuff = SnoData.Powers.GetBySno(91052u);
		Generic_CoreEliteDropPod = SnoData.Powers.GetBySno(134816u);
		Generic_CoreEliteDropPodBegin = SnoData.Powers.GetBySno(136455u);
		Generic_CoreElitePodSetUp = SnoData.Powers.GetBySno(134815u);
		Generic_CorpulentExplode = SnoData.Powers.GetBySno(30178u);
		Generic_CorruptAngelSpectralStrike = SnoData.Powers.GetBySno(122978u);
		Generic_CosmeticSpectralHoundBuff = SnoData.Powers.GetBySno(428398u);
		Generic_CreepMobCreeperAttack = SnoData.Powers.GetBySno(72366u);
		Generic_CreepMobKnockback = SnoData.Powers.GetBySno(71646u);
		Generic_CreepMobKnockbackLR = SnoData.Powers.GetBySno(376935u);
		Generic_CreepMobRangedArmAttack = SnoData.Powers.GetBySno(71688u);
		Generic_CritDebuffCold = SnoData.Powers.GetBySno(30180u);
		Generic_CryptChildEat = SnoData.Powers.GetBySno(1738u);
		Generic_CryptChildLeapOut = SnoData.Powers.GetBySno(30185u);
		Generic_CryptChildLeapOutBuff = SnoData.Powers.GetBySno(30186u);
		Generic_DamageAttribute = SnoData.Powers.GetBySno(86152u);
		Generic_DeathBroBoneCage = SnoData.Powers.GetBySno(451544u);
		Generic_DeathBroSummonSkeletons = SnoData.Powers.GetBySno(451528u);
		Generic_DeathBroTeleport = SnoData.Powers.GetBySno(451543u);
		Generic_DebuffBleed = SnoData.Powers.GetBySno(228423u);
		Generic_DebuffBlind = SnoData.Powers.GetBySno(103216u);
		Generic_DebuffCharmed = SnoData.Powers.GetBySno(311910u);
		Generic_DebuffChilled = SnoData.Powers.GetBySno(30195u);
		Generic_DebuffFeared = SnoData.Powers.GetBySno(101002u);
		Generic_DebuffFireDamageProc = SnoData.Powers.GetBySno(312061u);
		Generic_DebuffForceGripped = SnoData.Powers.GetBySno(312799u);
		Generic_DebuffPoisonDamageProc = SnoData.Powers.GetBySno(312062u);
		Generic_DebuffRooted = SnoData.Powers.GetBySno(101003u);
		Generic_DebuffSlowed = SnoData.Powers.GetBySno(100971u);
		Generic_DebuffStunned = SnoData.Powers.GetBySno(101000u);
		Generic_DeleteSelfAnim = SnoData.Powers.GetBySno(346635u);
		Generic_demonFlyerdropBomb = SnoData.Powers.GetBySno(132940u);
		Generic_DemonFlyerFireBreath = SnoData.Powers.GetBySno(155188u);
		Generic_DemonFlyerProjectile = SnoData.Powers.GetBySno(130798u);
		Generic_demonFlyersnatch = SnoData.Powers.GetBySno(121326u);
		Generic_DemonHunterBallistaV3 = SnoData.Powers.GetBySno(484727u);
		Generic_DemonHunterCompanion = SnoData.Powers.GetBySno(133695u);
		Generic_DemonHunterEvasiveFireFlip = SnoData.Powers.GetBySno(134280u);
		Generic_DemonHunterSentryTurretAttack = SnoData.Powers.GetBySno(129661u);
		Generic_DemonTrooperLeapOut = SnoData.Powers.GetBySno(143198u);
		Generic_DervishWhirlwind = SnoData.Powers.GetBySno(30207u);
		Generic_DervishWhirlwindMortarPrototype = SnoData.Powers.GetBySno(256026u);
		Generic_DespairMeleeCleave = SnoData.Powers.GetBySno(152865u);
		Generic_DespairMeleeCleaveEnrage = SnoData.Powers.GetBySno(241778u);
		Generic_DespairSummonMinion = SnoData.Powers.GetBySno(150486u);
		Generic_DespairTeleport = SnoData.Powers.GetBySno(149911u);
		Generic_DespairTeleportAway = SnoData.Powers.GetBySno(209700u);
		Generic_DespairVolley = SnoData.Powers.GetBySno(152866u);
		Generic_DespairVolleyLRBoss = SnoData.Powers.GetBySno(366277u);
		Generic_DestructableObjectAOE = SnoData.Powers.GetBySno(30208u);
		Generic_DestructableObjectChandelierAOE = SnoData.Powers.GetBySno(30209u);
		Generic_DestructableObjectChandelierAOEHoist = SnoData.Powers.GetBySno(358809u);
		Generic_DestructionStreakBuffRunSpeed = SnoData.Powers.GetBySno(368174u);
		Generic_DHCompanionChargeAttack = SnoData.Powers.GetBySno(133887u);
		Generic_DHCompanionMeleeAttack = SnoData.Powers.GetBySno(227240u);
		Generic_DHrainofArrowsshadowBeastbombDrop = SnoData.Powers.GetBySno(150075u);
		Generic_DiabloCharge = SnoData.Powers.GetBySno(195816u);
		Generic_DiabloClawRip = SnoData.Powers.GetBySno(136189u);
		Generic_DiabloClawRipUber = SnoData.Powers.GetBySno(375905u);
		Generic_DiabloCorruptionShield = SnoData.Powers.GetBySno(161174u);
		Generic_DiabloCurseOfAnguish = SnoData.Powers.GetBySno(136828u);
		Generic_DiabloCurseOfDestruction = SnoData.Powers.GetBySno(136831u);
		Generic_DiabloCurseOfHate = SnoData.Powers.GetBySno(136830u);
		Generic_DiabloCurseOfPain = SnoData.Powers.GetBySno(136829u);
		Generic_DiabloExpandingFireRing = SnoData.Powers.GetBySno(185997u);
		Generic_DiabloExpandingFireRingUber = SnoData.Powers.GetBySno(375908u);
		Generic_DiabloFireMeteor = SnoData.Powers.GetBySno(214831u);
		Generic_DiabloGetHit = SnoData.Powers.GetBySno(214668u);
		Generic_DiabloHellSpikes = SnoData.Powers.GetBySno(136226u);
		Generic_DiabloLightningBreath = SnoData.Powers.GetBySno(136219u);
		Generic_DiabloLightningBreathLRTerrorDemon = SnoData.Powers.GetBySno(428985u);
		Generic_DiabloLightningBreathLRTerrorDemonClone = SnoData.Powers.GetBySno(439719u);
		Generic_DiabloLightningBreathTurretMB313 = SnoData.Powers.GetBySno(478410u);
		Generic_DiabloLightningBreathUber = SnoData.Powers.GetBySno(375904u);
		Generic_DiabloLightningBreathv2 = SnoData.Powers.GetBySno(167560u);
		Generic_DiabloPhase1Buff = SnoData.Powers.GetBySno(141865u);
		Generic_DiabloPhase2Buff = SnoData.Powers.GetBySno(136850u);
		Generic_DiabloPhase3Buff = SnoData.Powers.GetBySno(136852u);
		Generic_DiabloRingOfFire = SnoData.Powers.GetBySno(136223u);
		Generic_DiabloRingOfFireUber = SnoData.Powers.GetBySno(375907u);
		Generic_DiabloShadowClones = SnoData.Powers.GetBySno(136281u);
		Generic_DiabloShadowVanish = SnoData.Powers.GetBySno(136237u);
		Generic_DiabloShadowVanishCharge = SnoData.Powers.GetBySno(142582u);
		Generic_DiabloShadowVanishGrab = SnoData.Powers.GetBySno(136849u);
		Generic_DiabloSmashPunyDestructible = SnoData.Powers.GetBySno(169212u);
		Generic_DiabloStompAndStun = SnoData.Powers.GetBySno(199476u);
		Generic_DiabloStompAndStunMB313 = SnoData.Powers.GetBySno(478072u);
		Generic_DiabloTeleport = SnoData.Powers.GetBySno(219598u);
		Generic_DisableGetHitBuffInfinite = SnoData.Powers.GetBySno(360319u);
		Generic_DisablePowerBuffInfinite = SnoData.Powers.GetBySno(340708u);
		Generic_DOTDebuff = SnoData.Powers.GetBySno(95701u);
		Generic_DrinkHealthPotion = SnoData.Powers.GetBySno(30211u);
		Generic_DualWieldBuff = SnoData.Powers.GetBySno(193438u);
		Generic_DualWieldScripted = SnoData.Powers.GetBySno(335158u);
		Generic_DualWieldScriptedRemove = SnoData.Powers.GetBySno(335253u);
		Generic_DuelBuff = SnoData.Powers.GetBySno(270058u);
		Generic_DuelDefeatBuff = SnoData.Powers.GetBySno(275135u);
		Generic_EasterEggWorldBuff = SnoData.Powers.GetBySno(434761u);
		Generic_EatCorpse = SnoData.Powers.GetBySno(30214u);
		Generic_ElectricEelElectricBurst = SnoData.Powers.GetBySno(57932u);
		Generic_ElectricEelLeapOut = SnoData.Powers.GetBySno(59836u);
		Generic_EmoteAttack = SnoData.Powers.GetBySno(188254u);
		Generic_EmoteBye = SnoData.Powers.GetBySno(185085u);
		Generic_EmoteDance = SnoData.Powers.GetBySno(384214u);
		Generic_EmoteDie = SnoData.Powers.GetBySno(185087u);
		Generic_EmoteFollow = SnoData.Powers.GetBySno(185042u);
		Generic_EmoteGive = SnoData.Powers.GetBySno(185081u);
		Generic_EmoteGo = SnoData.Powers.GetBySno(185629u);
		Generic_EmoteHelp = SnoData.Powers.GetBySno(185093u);
		Generic_EmoteHold = SnoData.Powers.GetBySno(188256u);
		Generic_EmoteLaugh = SnoData.Powers.GetBySno(188258u);
		Generic_EmoteNo = SnoData.Powers.GetBySno(188252u);
		Generic_EmoteRetreat = SnoData.Powers.GetBySno(188255u);
		Generic_EmoteRun = SnoData.Powers.GetBySno(185598u);
		Generic_EmoteSorry = SnoData.Powers.GetBySno(185083u);
		Generic_EmoteStay = SnoData.Powers.GetBySno(188253u);
		Generic_EmoteTakeObjective = SnoData.Powers.GetBySno(188257u);
		Generic_EmoteThanks = SnoData.Powers.GetBySno(185082u);
		Generic_EmoteWait = SnoData.Powers.GetBySno(185600u);
		Generic_EmoteYes = SnoData.Powers.GetBySno(188251u);
		Generic_EnchantressAmplifyElemental = SnoData.Powers.GetBySno(485108u);
		Generic_EnchantressArcaneOrb = SnoData.Powers.GetBySno(485321u);
		Generic_EnchantressCharm = SnoData.Powers.GetBySno(102057u);
		Generic_EnchantressCheatDeath = SnoData.Powers.GetBySno(484963u);
		Generic_EnchantressCheatDeathPassive = SnoData.Powers.GetBySno(485530u);
		Generic_EnchantressCombinedShield = SnoData.Powers.GetBySno(485107u);
		Generic_EnchantressCooldownReduction = SnoData.Powers.GetBySno(485099u);
		Generic_EnchantressCripple = SnoData.Powers.GetBySno(84469u);
		Generic_EnchantressDisorient = SnoData.Powers.GetBySno(101990u);
		Generic_EnchantressFocusedMind = SnoData.Powers.GetBySno(101425u);
		Generic_EnchantressMassCharm = SnoData.Powers.GetBySno(201524u);
		Generic_EnchantressMeleeInstant = SnoData.Powers.GetBySno(230238u);
		Generic_EnchantressRunAway = SnoData.Powers.GetBySno(186200u);
		Generic_EnchantressScorchedEarth = SnoData.Powers.GetBySno(220872u);
		Generic_EnterRecallPortal = SnoData.Powers.GetBySno(201538u);
		Generic_EnterStoneOfRecall = SnoData.Powers.GetBySno(200036u);
		Generic_EnvironmentKillBuffResourceRegen = SnoData.Powers.GetBySno(391680u);
		Generic_EquippedLegendaryPower = SnoData.Powers.GetBySno(434427u);
		Generic_EscortingBuff = SnoData.Powers.GetBySno(86241u);
		Generic_ExitRecallPortal = SnoData.Powers.GetBySno(201570u);
		Generic_ExitStoneOfRecall = SnoData.Powers.GetBySno(200039u);
		Generic_FallenChampionLeaderShout = SnoData.Powers.GetBySno(30222u);
		Generic_FallenChampionPowerHit = SnoData.Powers.GetBySno(1740u);
		Generic_FallenGruntShout = SnoData.Powers.GetBySno(30223u);
		Generic_FallenLunaticAggroA = SnoData.Powers.GetBySno(158955u);
		Generic_FallenLunaticAggroB = SnoData.Powers.GetBySno(330501u);
		Generic_FallenLunaticAggroC = SnoData.Powers.GetBySno(330800u);
		Generic_FallenLunaticAggroD = SnoData.Powers.GetBySno(330802u);
		Generic_FallenLunaticSuicide = SnoData.Powers.GetBySno(66547u);
		Generic_FallenLunaticSuicideRingSummon = SnoData.Powers.GetBySno(433469u);
		Generic_FallenShamanProjectile = SnoData.Powers.GetBySno(30225u);
		Generic_FallenShamanProjectileLR = SnoData.Powers.GetBySno(364817u);
		Generic_FallingSwordCheckPathPassability = SnoData.Powers.GetBySno(329401u);
		Generic_FastMummyDiseaseCloud = SnoData.Powers.GetBySno(30227u);
		Generic_FrenzyAffix = SnoData.Powers.GetBySno(123843u);
		Generic_GenericArrowProjectile = SnoData.Powers.GetBySno(30242u);
		Generic_GenericSetCannotBeAddedToAITargetList = SnoData.Powers.GetBySno(129386u);
		Generic_GenericSetDoesFakeDamage = SnoData.Powers.GetBySno(129395u);
		Generic_GenericSetInvisible = SnoData.Powers.GetBySno(76107u);
		Generic_GenericSetInvulnerable = SnoData.Powers.GetBySno(62731u);
		Generic_GenericSetObserver = SnoData.Powers.GetBySno(129393u);
		Generic_GenericSetTakesNoDamage = SnoData.Powers.GetBySno(129394u);
		Generic_GenericSetUntargetable = SnoData.Powers.GetBySno(62666u);
		Generic_GenericTaunt = SnoData.Powers.GetBySno(60777u);
		Generic_GhostAUniqueHouse1000UndeadSlow = SnoData.Powers.GetBySno(94972u);
		Generic_GhostMeleeDrain = SnoData.Powers.GetBySno(30243u);
		Generic_GhostSoulSiphon = SnoData.Powers.GetBySno(30244u);
		Generic_GhostWalkThroughWalls = SnoData.Powers.GetBySno(99094u);
		Generic_Gizmoa3dunrmptOilVatAAttack = SnoData.Powers.GetBySno(129689u);
		Generic_GizmoOperatePortalWithAnimation = SnoData.Powers.GetBySno(30249u);
		Generic_gkillElitePack = SnoData.Powers.GetBySno(230745u);
		Generic_glevelUp = SnoData.Powers.GetBySno(85954u);
		Generic_glevelUpAA = SnoData.Powers.GetBySno(252038u);
		Generic_GluttonyBreathAttack = SnoData.Powers.GetBySno(93838u);
		Generic_GluttonyGasCloud = SnoData.Powers.GetBySno(93676u);
		Generic_GluttonyGasCloudLRBoss = SnoData.Powers.GetBySno(369667u);
		Generic_GluttonyLoogiespawn = SnoData.Powers.GetBySno(211292u);
		Generic_GluttonyOnDeath = SnoData.Powers.GetBySno(98587u);
		Generic_GoatmanColdShield = SnoData.Powers.GetBySno(123158u);
		Generic_GoatmanDrumsBeating = SnoData.Powers.GetBySno(97497u);
		Generic_GoatmanIceball = SnoData.Powers.GetBySno(99077u);
		Generic_GoatmanLightningShield = SnoData.Powers.GetBySno(30251u);
		Generic_GoatmanMoonclanRangedProjectile = SnoData.Powers.GetBySno(30252u);
		Generic_GoatmanShamanEmpower = SnoData.Powers.GetBySno(168554u);
		Generic_GoatmanShamanLightningbolt = SnoData.Powers.GetBySno(77342u);
		Generic_GoatMutantEnrage = SnoData.Powers.GetBySno(131588u);
		Generic_GoatMutantGroundSmash = SnoData.Powers.GetBySno(131699u);
		Generic_GoatMutantRangedProjectile = SnoData.Powers.GetBySno(159004u);
		Generic_GoatMutantShamanBlast = SnoData.Powers.GetBySno(157947u);
		Generic_GoblinAffixTeleporter = SnoData.Powers.GetBySno(413313u);
		Generic_gparagonBuff = SnoData.Powers.GetBySno(286747u);
		Generic_GraveDiggerKnockbackAttack = SnoData.Powers.GetBySno(30255u);
		Generic_graveDiggerwardenrangedAttack = SnoData.Powers.GetBySno(113817u);
		Generic_GraveRobberDodgeLeft = SnoData.Powers.GetBySno(30256u);
		Generic_GraveRobberDodgeRight = SnoData.Powers.GetBySno(30257u);
		Generic_graveRobberProjectile = SnoData.Powers.GetBySno(30258u);
		Generic_GreedStompAndStun = SnoData.Powers.GetBySno(408505u);
		Generic_HealingWellHeal = SnoData.Powers.GetBySno(30264u);
		Generic_Hearth = SnoData.Powers.GetBySno(30265u);
		Generic_HearthFinish = SnoData.Powers.GetBySno(30266u);
		Generic_HellPortalSummoningMachineActivate = SnoData.Powers.GetBySno(118226u);
		Generic_HelperArcherProjectile = SnoData.Powers.GetBySno(73289u);
		Generic_HirelingCalloutBattleCry = SnoData.Powers.GetBySno(87093u);
		Generic_HirelingCalloutBattleFinished = SnoData.Powers.GetBySno(117323u);
		Generic_HirelingDismiss = SnoData.Powers.GetBySno(196142u);
		Generic_HirelingDismissBuff = SnoData.Powers.GetBySno(196103u);
		Generic_HirelingDismissBuffRemove = SnoData.Powers.GetBySno(196251u);
		Generic_HirelingMageMagicMissile = SnoData.Powers.GetBySno(30273u);
		Generic_HoodedNightmareBoneArmor = SnoData.Powers.GetBySno(135701u);
		Generic_HoodedNightmareCurses = SnoData.Powers.GetBySno(136071u);
		Generic_HoodedNightmareGatewayToHell = SnoData.Powers.GetBySno(136072u);
		Generic_HoodedNightmareLightningOfUnlife = SnoData.Powers.GetBySno(135412u);
		Generic_IdentifyAllWithCast = SnoData.Powers.GetBySno(293981u);
		Generic_IdentifyWithCast = SnoData.Powers.GetBySno(226757u);
		Generic_IdentifyWithCastLegendary = SnoData.Powers.GetBySno(259848u);
		Generic_IGRBuffEXP = SnoData.Powers.GetBySno(238686u);
		Generic_ImmuneToFearDuringBuff = SnoData.Powers.GetBySno(30283u);
		Generic_ImmuneToRootDuringBuff = SnoData.Powers.GetBySno(30284u);
		Generic_ImmuneToSnareDuringBuff = SnoData.Powers.GetBySno(30285u);
		Generic_ImmuneToStunDuringBuff = SnoData.Powers.GetBySno(30286u);
		Generic_InteractCrouching = SnoData.Powers.GetBySno(30287u);
		Generic_InteractNormal = SnoData.Powers.GetBySno(30288u);
		Generic_InvisibileDuringBuff = SnoData.Powers.GetBySno(30289u);
		Generic_InvulnerableDuringBuff = SnoData.Powers.GetBySno(30290u);
		Generic_ItemPassiveSetBonusChantodo = SnoData.Powers.GetBySno(371005u);
		Generic_itemPassiveUniqueAmulet001 = SnoData.Powers.GetBySno(246590u);
		Generic_ItemPassiveUniqueBelt016p2 = SnoData.Powers.GetBySno(433996u);
		Generic_ItemPassiveUniqueDagger006 = SnoData.Powers.GetBySno(247769u);
		Generic_ItemPassiveUniqueDagger011x1 = SnoData.Powers.GetBySno(334882u);
		Generic_ItemPassiveUniqueFist010 = SnoData.Powers.GetBySno(248928u);
		Generic_ItemPassiveUniqueFist010x1 = SnoData.Powers.GetBySno(360490u);
		Generic_itemPassiveUniqueMace1H009 = SnoData.Powers.GetBySno(247484u);
		Generic_ItemPassiveUniqueMace2H006 = SnoData.Powers.GetBySno(248501u);
		Generic_ItemPassiveUniqueMighty1H011 = SnoData.Powers.GetBySno(248481u);
		Generic_ItemPassiveUniqueMighty1H011x1 = SnoData.Powers.GetBySno(360488u);
		Generic_ItemPassiveUniqueMojo010 = SnoData.Powers.GetBySno(248489u);
		Generic_ItemPassiveUniqueMojo010x1 = SnoData.Powers.GetBySno(360491u);
		Generic_ItemPassiveUniqueMojo010x1tooltipDummy1 = SnoData.Powers.GetBySno(440744u);
		Generic_ItemPassiveUniquePotion01x1 = SnoData.Powers.GetBySno(341335u);
		Generic_ItemPassiveUniquePotion02x1 = SnoData.Powers.GetBySno(341340u);
		Generic_ItemPassiveUniquePotion03x1 = SnoData.Powers.GetBySno(341341u);
		Generic_ItemPassiveUniqueRing015 = SnoData.Powers.GetBySno(248763u);
		Generic_ItemPassiveUniqueRing015x1 = SnoData.Powers.GetBySno(360492u);
		Generic_ItemPassiveUniqueRing024 = SnoData.Powers.GetBySno(257586u);
		Generic_ItemPassiveUniqueRing500p2 = SnoData.Powers.GetBySno(434037u);
		Generic_ItemPassiveUniqueRing502x1 = SnoData.Powers.GetBySno(318346u);
		Generic_ItemPassiveUniqueRing503x1 = SnoData.Powers.GetBySno(318347u);
		Generic_ItemPassiveUniqueRing506x1 = SnoData.Powers.GetBySno(318351u);
		Generic_ItemPassiveUniqueRing511x1 = SnoData.Powers.GetBySno(318372u);
		Generic_ItemPassiveUniqueRing512x1 = SnoData.Powers.GetBySno(318374u);
		Generic_ItemPassiveUniqueRing513AIPickupx1 = SnoData.Powers.GetBySno(326968u);
		Generic_ItemPassiveUniqueRing518x1 = SnoData.Powers.GetBySno(318380u);
		Generic_ItemPassiveUniqueRing522x1 = SnoData.Powers.GetBySno(318384u);
		Generic_ItemPassiveUniqueRing524x1 = SnoData.Powers.GetBySno(318386u);
		Generic_ItemPassiveUniqueRing529x1 = SnoData.Powers.GetBySno(318418u);
		Generic_ItemPassiveUniqueRing535x1 = SnoData.Powers.GetBySno(318427u);
		Generic_ItemPassiveUniqueRing542x1 = SnoData.Powers.GetBySno(318435u);
		Generic_ItemPassiveUniqueRing543x1 = SnoData.Powers.GetBySno(318436u);
		Generic_ItemPassiveUniqueRing546x1 = SnoData.Powers.GetBySno(318717u);
		Generic_ItemPassiveUniqueRing553x1 = SnoData.Powers.GetBySno(318730u);
		Generic_ItemPassiveUniqueRing556x1 = SnoData.Powers.GetBySno(318733u);
		Generic_ItemPassiveUniqueRing561x1 = SnoData.Powers.GetBySno(318743u);
		Generic_ItemPassiveUniqueRing563x1 = SnoData.Powers.GetBySno(318745u);
		Generic_ItemPassiveUniqueRing564x1 = SnoData.Powers.GetBySno(318746u);
		Generic_ItemPassiveUniqueRing566x1 = SnoData.Powers.GetBySno(318748u);
		Generic_ItemPassiveUniqueRing567x1 = SnoData.Powers.GetBySno(318749u);
		Generic_ItemPassiveUniqueRing570x1 = SnoData.Powers.GetBySno(318752u);
		Generic_ItemPassiveUniqueRing572x1 = SnoData.Powers.GetBySno(318754u);
		Generic_ItemPassiveUniqueRing573x1 = SnoData.Powers.GetBySno(318755u);
		Generic_ItemPassiveUniqueRing574x1 = SnoData.Powers.GetBySno(318756u);
		Generic_ItemPassiveUniqueRing578x1 = SnoData.Powers.GetBySno(318760u);
		Generic_ItemPassiveUniqueRing580x1 = SnoData.Powers.GetBySno(318762u);
		Generic_ItemPassiveUniqueRing582x1 = SnoData.Powers.GetBySno(318764u);
		Generic_ItemPassiveUniqueRing583x1 = SnoData.Powers.GetBySno(318765u);
		Generic_ItemPassiveUniqueRing584x1 = SnoData.Powers.GetBySno(318766u);
		Generic_ItemPassiveUniqueRing585x1 = SnoData.Powers.GetBySno(318767u);
		Generic_ItemPassiveUniqueRing586x1 = SnoData.Powers.GetBySno(318768u);
		Generic_ItemPassiveUniqueRing596x1 = SnoData.Powers.GetBySno(318778u);
		Generic_ItemPassiveUniqueRing597p2 = SnoData.Powers.GetBySno(434006u);
		Generic_ItemPassiveUniqueRing598x1 = SnoData.Powers.GetBySno(318780u);
		Generic_ItemPassiveUniqueRing599x1 = SnoData.Powers.GetBySno(318781u);
		Generic_ItemPassiveUniqueRing601x1 = SnoData.Powers.GetBySno(318783u);
		Generic_ItemPassiveUniqueRing603x1 = SnoData.Powers.GetBySno(318785u);
		Generic_ItemPassiveUniqueRing605x1 = SnoData.Powers.GetBySno(318787u);
		Generic_ItemPassiveUniqueRing621x1 = SnoData.Powers.GetBySno(318803u);
		Generic_ItemPassiveUniqueRing625x1 = SnoData.Powers.GetBySno(318807u);
		Generic_ItemPassiveUniqueRing627x1 = SnoData.Powers.GetBySno(318809u);
		Generic_ItemPassiveUniqueRing632x1 = SnoData.Powers.GetBySno(318814u);
		Generic_ItemPassiveUniqueRing633x1 = SnoData.Powers.GetBySno(318815u);
		Generic_ItemPassiveUniqueRing636x1 = SnoData.Powers.GetBySno(318818u);
		Generic_ItemPassiveUniqueRing637x1 = SnoData.Powers.GetBySno(318819u);
		Generic_ItemPassiveUniqueRing640x1 = SnoData.Powers.GetBySno(318822u);
		Generic_ItemPassiveUniqueRing641x1 = SnoData.Powers.GetBySno(318823u);
		Generic_ItemPassiveUniqueRing650x1 = SnoData.Powers.GetBySno(318832u);
		Generic_ItemPassiveUniqueRing652x1 = SnoData.Powers.GetBySno(318834u);
		Generic_ItemPassiveUniqueRing654x1 = SnoData.Powers.GetBySno(318849u);
		Generic_ItemPassiveUniqueRing657x1 = SnoData.Powers.GetBySno(318852u);
		Generic_ItemPassiveUniqueRing659x1 = SnoData.Powers.GetBySno(318854u);
		Generic_ItemPassiveUniqueRing661x1 = SnoData.Powers.GetBySno(318856u);
		Generic_ItemPassiveUniqueRing666x1 = SnoData.Powers.GetBySno(318862u);
		Generic_ItemPassiveUniqueRing676x1 = SnoData.Powers.GetBySno(318872u);
		Generic_ItemPassiveUniqueRing678x1 = SnoData.Powers.GetBySno(318874u);
		Generic_ItemPassiveUniqueRing680x1 = SnoData.Powers.GetBySno(318876u);
		Generic_ItemPassiveUniqueRing681p2 = SnoData.Powers.GetBySno(434012u);
		Generic_ItemPassiveUniqueRing682x1 = SnoData.Powers.GetBySno(318878u);
		Generic_ItemPassiveUniqueRing683x1 = SnoData.Powers.GetBySno(318879u);
		Generic_ItemPassiveUniqueRing684x1 = SnoData.Powers.GetBySno(318880u);
		Generic_ItemPassiveUniqueRing689x1 = SnoData.Powers.GetBySno(318885u);
		Generic_ItemPassiveUniqueRing693x1 = SnoData.Powers.GetBySno(318889u);
		Generic_ItemPassiveUniqueRing702x1 = SnoData.Powers.GetBySno(359539u);
		Generic_ItemPassiveUniqueRing710x1 = SnoData.Powers.GetBySno(359555u);
		Generic_ItemPassiveUniqueRing711x1 = SnoData.Powers.GetBySno(359556u);
		Generic_ItemPassiveUniqueRing713x1 = SnoData.Powers.GetBySno(359558u);
		Generic_ItemPassiveUniqueRing714x1 = SnoData.Powers.GetBySno(359559u);
		Generic_ItemPassiveUniqueRing715x1 = SnoData.Powers.GetBySno(359560u);
		Generic_ItemPassiveUniqueRing716x1 = SnoData.Powers.GetBySno(359561u);
		Generic_ItemPassiveUniqueRing717x1 = SnoData.Powers.GetBySno(359562u);
		Generic_ItemPassiveUniqueRing718x1 = SnoData.Powers.GetBySno(359563u);
		Generic_ItemPassiveUniqueRing719x1 = SnoData.Powers.GetBySno(359564u);
		Generic_ItemPassiveUniqueRing720x1 = SnoData.Powers.GetBySno(359565u);
		Generic_ItemPassiveUniqueRing721x1 = SnoData.Powers.GetBySno(359566u);
		Generic_ItemPassiveUniqueRing722x1 = SnoData.Powers.GetBySno(359567u);
		Generic_ItemPassiveUniqueRing723x1 = SnoData.Powers.GetBySno(359568u);
		Generic_ItemPassiveUniqueRing724SpawnDecoyx1 = SnoData.Powers.GetBySno(425390u);
		Generic_ItemPassiveUniqueRing724x1 = SnoData.Powers.GetBySno(359569u);
		Generic_ItemPassiveUniqueRing725x1 = SnoData.Powers.GetBySno(359570u);
		Generic_ItemPassiveUniqueRing726x1 = SnoData.Powers.GetBySno(359573u);
		Generic_ItemPassiveUniqueRing727x1 = SnoData.Powers.GetBySno(359574u);
		Generic_ItemPassiveUniqueRing728x1 = SnoData.Powers.GetBySno(359576u);
		Generic_ItemPassiveUniqueRing729x1 = SnoData.Powers.GetBySno(359577u);
		Generic_ItemPassiveUniqueRing730x1 = SnoData.Powers.GetBySno(359578u);
		Generic_ItemPassiveUniqueRing731x1 = SnoData.Powers.GetBySno(359579u);
		Generic_ItemPassiveUniqueRing732x1 = SnoData.Powers.GetBySno(359580u);
		Generic_ItemPassiveUniqueRing733x1 = SnoData.Powers.GetBySno(359581u);
		Generic_ItemPassiveUniqueRing734x1 = SnoData.Powers.GetBySno(359582u);
		Generic_ItemPassiveUniqueRing735x1 = SnoData.Powers.GetBySno(359583u);
		Generic_ItemPassiveUniqueRing736x1 = SnoData.Powers.GetBySno(359584u);
		Generic_ItemPassiveUniqueRing737x1 = SnoData.Powers.GetBySno(359585u);
		Generic_ItemPassiveUniqueRing738x1 = SnoData.Powers.GetBySno(359586u);
		Generic_ItemPassiveUniqueRing740x1 = SnoData.Powers.GetBySno(359589u);
		Generic_ItemPassiveUniqueRing743x1 = SnoData.Powers.GetBySno(359594u);
		Generic_ItemPassiveUniqueRing746x1 = SnoData.Powers.GetBySno(359601u);
		Generic_ItemPassiveUniqueRing752x1 = SnoData.Powers.GetBySno(397781u);
		Generic_ItemPassiveUniqueRing756x1 = SnoData.Powers.GetBySno(397785u);
		Generic_ItemPassiveUniqueRing757x1 = SnoData.Powers.GetBySno(397786u);
		Generic_ItemPassiveUniqueRing758x1 = SnoData.Powers.GetBySno(397787u);
		Generic_ItemPassiveUniqueRing760x1 = SnoData.Powers.GetBySno(397789u);
		Generic_ItemPassiveUniqueRing763x1 = SnoData.Powers.GetBySno(397805u);
		Generic_ItemPassiveUniqueRing764x1 = SnoData.Powers.GetBySno(397806u);
		Generic_ItemPassiveUniqueRing765x1 = SnoData.Powers.GetBySno(397807u);
		Generic_ItemPassiveUniqueRing766x1 = SnoData.Powers.GetBySno(397808u);
		Generic_ItemPassiveUniqueRing767x1 = SnoData.Powers.GetBySno(397809u);
		Generic_ItemPassiveUniqueRing768x1 = SnoData.Powers.GetBySno(397811u);
		Generic_ItemPassiveUniqueRing769x1 = SnoData.Powers.GetBySno(397812u);
		Generic_ItemPassiveUniqueRing770x1 = SnoData.Powers.GetBySno(397813u);
		Generic_ItemPassiveUniqueRing771x1 = SnoData.Powers.GetBySno(397814u);
		Generic_ItemPassiveUniqueRing772x1 = SnoData.Powers.GetBySno(397815u);
		Generic_ItemPassiveUniqueRing773x1 = SnoData.Powers.GetBySno(397816u);
		Generic_ItemPassiveUniqueRing774x1 = SnoData.Powers.GetBySno(397817u);
		Generic_ItemPassiveUniqueRing775x1 = SnoData.Powers.GetBySno(397818u);
		Generic_ItemPassiveUniqueRing776x1 = SnoData.Powers.GetBySno(397819u);
		Generic_ItemPassiveUniqueRing777x1 = SnoData.Powers.GetBySno(397820u);
		Generic_ItemPassiveUniqueRing778x1 = SnoData.Powers.GetBySno(397822u);
		Generic_ItemPassiveUniqueRing779x1 = SnoData.Powers.GetBySno(397831u);
		Generic_ItemPassiveUniqueRing780x1 = SnoData.Powers.GetBySno(397832u);
		Generic_ItemPassiveUniqueRing781x1 = SnoData.Powers.GetBySno(397833u);
		Generic_ItemPassiveUniqueRing782x1 = SnoData.Powers.GetBySno(397834u);
		Generic_ItemPassiveUniqueRing783x1 = SnoData.Powers.GetBySno(397835u);
		Generic_ItemPassiveUniqueRing784x1 = SnoData.Powers.GetBySno(397836u);
		Generic_ItemPassiveUniqueRing785x1 = SnoData.Powers.GetBySno(397838u);
		Generic_ItemPassiveUniqueRing786x1 = SnoData.Powers.GetBySno(397839u);
		Generic_ItemPassiveUniqueRing787x1 = SnoData.Powers.GetBySno(397841u);
		Generic_ItemPassiveUniqueRing788x1 = SnoData.Powers.GetBySno(397842u);
		Generic_ItemPassiveUniqueRing789x1 = SnoData.Powers.GetBySno(397843u);
		Generic_ItemPassiveUniqueRing790x1 = SnoData.Powers.GetBySno(397844u);
		Generic_ItemPassiveUniqueRing791x1 = SnoData.Powers.GetBySno(397845u);
		Generic_ItemPassiveUniqueRing792x1 = SnoData.Powers.GetBySno(397846u);
		Generic_ItemPassiveUniqueRing793x1 = SnoData.Powers.GetBySno(397847u);
		Generic_ItemPassiveUniqueRing794x1 = SnoData.Powers.GetBySno(397848u);
		Generic_ItemPassiveUniqueRing795x1 = SnoData.Powers.GetBySno(397849u);
		Generic_ItemPassiveUniqueRing796x1 = SnoData.Powers.GetBySno(397850u);
		Generic_ItemPassiveUniqueRing797x1 = SnoData.Powers.GetBySno(397851u);
		Generic_ItemPassiveUniqueRing798x1 = SnoData.Powers.GetBySno(397852u);
		Generic_ItemPassiveUniqueRing799x1 = SnoData.Powers.GetBySno(397853u);
		Generic_ItemPassiveUniqueRing800x1 = SnoData.Powers.GetBySno(397854u);
		Generic_ItemPassiveUniqueRing801x1 = SnoData.Powers.GetBySno(401366u);
		Generic_ItemPassiveUniqueRing802x1 = SnoData.Powers.GetBySno(401367u);
		Generic_ItemPassiveUniqueRing803x1 = SnoData.Powers.GetBySno(401368u);
		Generic_ItemPassiveUniqueRing804x1 = SnoData.Powers.GetBySno(401369u);
		Generic_ItemPassiveUniqueRing805x1 = SnoData.Powers.GetBySno(401370u);
		Generic_ItemPassiveUniqueRing806x1 = SnoData.Powers.GetBySno(401371u);
		Generic_ItemPassiveUniqueRing807x1 = SnoData.Powers.GetBySno(401378u);
		Generic_ItemPassiveUniqueRing808x1 = SnoData.Powers.GetBySno(401379u);
		Generic_ItemPassiveUniqueRing809x1 = SnoData.Powers.GetBySno(401380u);
		Generic_ItemPassiveUniqueRing810x1 = SnoData.Powers.GetBySno(401381u);
		Generic_ItemPassiveUniqueRing811x1 = SnoData.Powers.GetBySno(401382u);
		Generic_ItemPassiveUniqueRing812x1 = SnoData.Powers.GetBySno(401383u);
		Generic_ItemPassiveUniqueRing813x1 = SnoData.Powers.GetBySno(401384u);
		Generic_ItemPassiveUniqueRing814x1 = SnoData.Powers.GetBySno(401385u);
		Generic_ItemPassiveUniqueRing815x1 = SnoData.Powers.GetBySno(401386u);
		Generic_ItemPassiveUniqueRing816x1 = SnoData.Powers.GetBySno(401387u);
		Generic_ItemPassiveUniqueRing817x1 = SnoData.Powers.GetBySno(401388u);
		Generic_ItemPassiveUniqueRing818x1 = SnoData.Powers.GetBySno(401389u);
		Generic_ItemPassiveUniqueRing819x1 = SnoData.Powers.GetBySno(401390u);
		Generic_ItemPassiveUniqueRing820x1 = SnoData.Powers.GetBySno(401391u);
		Generic_ItemPassiveUniqueRing821x1 = SnoData.Powers.GetBySno(401392u);
		Generic_ItemPassiveUniqueRing822x1 = SnoData.Powers.GetBySno(401393u);
		Generic_ItemPassiveUniqueRing823x1 = SnoData.Powers.GetBySno(401394u);
		Generic_ItemPassiveUniqueRing824x1 = SnoData.Powers.GetBySno(401395u);
		Generic_ItemPassiveUniqueRing825x1 = SnoData.Powers.GetBySno(401414u);
		Generic_ItemPassiveUniqueRing826x1 = SnoData.Powers.GetBySno(401415u);
		Generic_ItemPassiveUniqueRing827x1 = SnoData.Powers.GetBySno(401416u);
		Generic_ItemPassiveUniqueRing828x1 = SnoData.Powers.GetBySno(401417u);
		Generic_ItemPassiveUniqueRing829x1 = SnoData.Powers.GetBySno(401418u);
		Generic_ItemPassiveUniqueRing830x1 = SnoData.Powers.GetBySno(401419u);
		Generic_ItemPassiveUniqueRing831x1 = SnoData.Powers.GetBySno(401420u);
		Generic_ItemPassiveUniqueRing832x1 = SnoData.Powers.GetBySno(401421u);
		Generic_ItemPassiveUniqueRing833x1 = SnoData.Powers.GetBySno(401422u);
		Generic_ItemPassiveUniqueRing834x1 = SnoData.Powers.GetBySno(401423u);
		Generic_ItemPassiveUniqueRing835x1 = SnoData.Powers.GetBySno(401424u);
		Generic_ItemPassiveUniqueRing836x1 = SnoData.Powers.GetBySno(401425u);
		Generic_ItemPassiveUniqueRing837x1 = SnoData.Powers.GetBySno(401426u);
		Generic_ItemPassiveUniqueRing838x1 = SnoData.Powers.GetBySno(401427u);
		Generic_ItemPassiveUniqueRing839x1 = SnoData.Powers.GetBySno(401428u);
		Generic_ItemPassiveUniqueRing840x1 = SnoData.Powers.GetBySno(401429u);
		Generic_ItemPassiveUniqueRing841x1 = SnoData.Powers.GetBySno(401430u);
		Generic_ItemPassiveUniqueRing842x1 = SnoData.Powers.GetBySno(401458u);
		Generic_ItemPassiveUniqueRing843x1 = SnoData.Powers.GetBySno(401459u);
		Generic_ItemPassiveUniqueRing844x1 = SnoData.Powers.GetBySno(401460u);
		Generic_ItemPassiveUniqueRing845x1 = SnoData.Powers.GetBySno(401461u);
		Generic_ItemPassiveUniqueRing846x1 = SnoData.Powers.GetBySno(401462u);
		Generic_ItemPassiveUniqueRing847x1 = SnoData.Powers.GetBySno(401463u);
		Generic_ItemPassiveUniqueRing848x1 = SnoData.Powers.GetBySno(401464u);
		Generic_ItemPassiveUniqueRing849x1 = SnoData.Powers.GetBySno(401465u);
		Generic_ItemPassiveUniqueRing850x1 = SnoData.Powers.GetBySno(401466u);
		Generic_ItemPassiveUniqueRing851x1 = SnoData.Powers.GetBySno(401467u);
		Generic_ItemPassiveUniqueRing852x1 = SnoData.Powers.GetBySno(401468u);
		Generic_ItemPassiveUniqueRing853x1 = SnoData.Powers.GetBySno(401469u);
		Generic_ItemPassiveUniqueRing854x1 = SnoData.Powers.GetBySno(401470u);
		Generic_ItemPassiveUniqueRing855x1 = SnoData.Powers.GetBySno(401471u);
		Generic_ItemPassiveUniqueRing856x1 = SnoData.Powers.GetBySno(401472u);
		Generic_ItemPassiveUniqueRing857x1 = SnoData.Powers.GetBySno(401473u);
		Generic_ItemPassiveUniqueRing858x1 = SnoData.Powers.GetBySno(401474u);
		Generic_ItemPassiveUniqueRing859x1 = SnoData.Powers.GetBySno(401475u);
		Generic_ItemPassiveUniqueRing860x1 = SnoData.Powers.GetBySno(401476u);
		Generic_ItemPassiveUniqueRing861x1 = SnoData.Powers.GetBySno(401495u);
		Generic_ItemPassiveUniqueRing862x1 = SnoData.Powers.GetBySno(401496u);
		Generic_ItemPassiveUniqueRing863x1 = SnoData.Powers.GetBySno(401497u);
		Generic_ItemPassiveUniqueRing864x1 = SnoData.Powers.GetBySno(401498u);
		Generic_ItemPassiveUniqueRing865x1 = SnoData.Powers.GetBySno(401499u);
		Generic_ItemPassiveUniqueRing866x1 = SnoData.Powers.GetBySno(401500u);
		Generic_ItemPassiveUniqueRing867x1 = SnoData.Powers.GetBySno(401501u);
		Generic_ItemPassiveUniqueRing868x1 = SnoData.Powers.GetBySno(401502u);
		Generic_ItemPassiveUniqueRing869x1 = SnoData.Powers.GetBySno(401503u);
		Generic_ItemPassiveUniqueRing870x1 = SnoData.Powers.GetBySno(401504u);
		Generic_ItemPassiveUniqueRing871x1 = SnoData.Powers.GetBySno(401505u);
		Generic_ItemPassiveUniqueRing872x1 = SnoData.Powers.GetBySno(401506u);
		Generic_ItemPassiveUniqueRing873x1 = SnoData.Powers.GetBySno(401507u);
		Generic_ItemPassiveUniqueRing874x1 = SnoData.Powers.GetBySno(401508u);
		Generic_ItemPassiveUniqueRing875x1 = SnoData.Powers.GetBySno(401509u);
		Generic_ItemPassiveUniqueRing876x1 = SnoData.Powers.GetBySno(401510u);
		Generic_ItemPassiveUniqueRing877x1 = SnoData.Powers.GetBySno(401511u);
		Generic_ItemPassiveUniqueRing878x1 = SnoData.Powers.GetBySno(409335u);
		Generic_ItemPassiveUniqueRing879x1 = SnoData.Powers.GetBySno(439528u);
		Generic_ItemPassiveUniqueRing880x1 = SnoData.Powers.GetBySno(442744u);
		Generic_ItemPassiveUniqueRing899x1 = SnoData.Powers.GetBySno(409431u);
		Generic_ItemPassiveUniqueRing900x1 = SnoData.Powers.GetBySno(409428u);
		Generic_ItemPassiveUniqueRing901x1 = SnoData.Powers.GetBySno(402407u);
		Generic_ItemPassiveUniqueRing902x1 = SnoData.Powers.GetBySno(402408u);
		Generic_ItemPassiveUniqueRing904x1 = SnoData.Powers.GetBySno(402406u);
		Generic_ItemPassiveUniqueRing910x1 = SnoData.Powers.GetBySno(402446u);
		Generic_ItemPassiveUniqueRing913x1 = SnoData.Powers.GetBySno(402449u);
		Generic_ItemPassiveUniqueRing914x1 = SnoData.Powers.GetBySno(402450u);
		Generic_ItemPassiveUniqueRing924x1 = SnoData.Powers.GetBySno(402463u);
		Generic_ItemPassiveUniqueRing925x1 = SnoData.Powers.GetBySno(402464u);
		Generic_ItemPassiveUniqueRing926x1 = SnoData.Powers.GetBySno(402465u);
		Generic_ItemPassiveUniqueRing927x1 = SnoData.Powers.GetBySno(402466u);
		Generic_ItemPassiveUniqueRing928x1 = SnoData.Powers.GetBySno(402467u);
		Generic_ItemPassiveUniqueRing929x1 = SnoData.Powers.GetBySno(402469u);
		Generic_ItemPassiveUniqueRing930x1 = SnoData.Powers.GetBySno(402470u);
		Generic_ItemPassiveUniqueRing931x1 = SnoData.Powers.GetBySno(402471u);
		Generic_ItemPassiveUniqueRing932x1 = SnoData.Powers.GetBySno(402472u);
		Generic_ItemPassiveUniqueRing933x1 = SnoData.Powers.GetBySno(402473u);
		Generic_ItemPassiveUniqueRing934x1 = SnoData.Powers.GetBySno(402474u);
		Generic_ItemPassiveUniqueRing935x1 = SnoData.Powers.GetBySno(402475u);
		Generic_ItemPassiveUniqueRing936x1 = SnoData.Powers.GetBySno(402476u);
		Generic_ItemPassiveUniqueRing937x1 = SnoData.Powers.GetBySno(402477u);
		Generic_ItemPassiveUniqueRing938x1 = SnoData.Powers.GetBySno(402478u);
		Generic_ItemPassiveUniqueRing939x1 = SnoData.Powers.GetBySno(402479u);
		Generic_ItemPassiveUniqueRing940x1 = SnoData.Powers.GetBySno(402480u);
		Generic_ItemPassiveUniqueRing941x1 = SnoData.Powers.GetBySno(440913u);
		Generic_ItemPassiveUniqueRing999 = SnoData.Powers.GetBySno(484606u);
		Generic_ItemPassiveUniqueRingHellfirex1 = SnoData.Powers.GetBySno(367462u);
		Generic_itemPassiveUniqueShield011 = SnoData.Powers.GetBySno(247585u);
		Generic_ItemPassiveUniqueShoulder009 = SnoData.Powers.GetBySno(247544u);
		Generic_itemPassiveUniqueWizardHat004p2 = SnoData.Powers.GetBySno(434035u);
		Generic_ItemPassivex1Amuletnormunique25Barbarian = SnoData.Powers.GetBySno(374500u);
		Generic_ItemPassivex1Amuletnormunique25Crusader = SnoData.Powers.GetBySno(374502u);
		Generic_ItemPassivex1Amuletnormunique25DemonHunter = SnoData.Powers.GetBySno(374503u);
		Generic_ItemPassivex1Amuletnormunique25Monk = SnoData.Powers.GetBySno(374504u);
		Generic_ItemPassivex1Amuletnormunique25Necromancer = SnoData.Powers.GetBySno(475677u);
		Generic_ItemPassivex1Amuletnormunique25WitchDoctor = SnoData.Powers.GetBySno(374506u);
		Generic_ItemPassivex1Amuletnormunique25Wizard = SnoData.Powers.GetBySno(374505u);
		Generic_IzualCharge = SnoData.Powers.GetBySno(241651u);
		Generic_IzualFrostNova = SnoData.Powers.GetBySno(162329u);
		Generic_IzualFrozenCast = SnoData.Powers.GetBySno(241653u);
		Generic_KillActor = SnoData.Powers.GetBySno(445899u);
		Generic_Knockback = SnoData.Powers.GetBySno(70432u);
		Generic_KnockbackNoLandingAnim = SnoData.Powers.GetBySno(356848u);
		Generic_KnockbackOverObstacles = SnoData.Powers.GetBySno(85936u);
		Generic_KnockbackThroughOwnedByTeam = SnoData.Powers.GetBySno(329195u);
		Generic_Knockdown = SnoData.Powers.GetBySno(30296u);
		Generic_LacuniBurrowIn = SnoData.Powers.GetBySno(30297u);
		Generic_LacuniBurrowOut = SnoData.Powers.GetBySno(30298u);
		Generic_LacuniCombo = SnoData.Powers.GetBySno(1744u);
		Generic_LacuniLeap = SnoData.Powers.GetBySno(30300u);
		Generic_LacuniLob = SnoData.Powers.GetBySno(30301u);
		Generic_LacuniMaleDoubleSwing = SnoData.Powers.GetBySno(30299u);
		Generic_Laugh = SnoData.Powers.GetBySno(30307u);
		Generic_LaughSkeletonKing = SnoData.Powers.GetBySno(84699u);
		Generic_LeahHulkOut = SnoData.Powers.GetBySno(190230u);
		Generic_LeahVortex = SnoData.Powers.GetBySno(93831u);
		Generic_LeahVortexAgain = SnoData.Powers.GetBySno(208501u);
		Generic_LostSoulsPrototypeV2 = SnoData.Powers.GetBySno(456719u);
		Generic_LRBossCollapseCeiling = SnoData.Powers.GetBySno(366477u);
		Generic_LRBossFast = SnoData.Powers.GetBySno(366481u);
		Generic_LRBossIzualCharge = SnoData.Powers.GetBySno(366830u);
		Generic_LRBossPathBlockedTeleport = SnoData.Powers.GetBySno(366204u);
		Generic_LRBossSprint = SnoData.Powers.GetBySno(366527u);
		Generic_LSp4SeaMonsterSpawnCrabs = SnoData.Powers.GetBySno(470419u);
		Generic_MaghdaMark = SnoData.Powers.GetBySno(131741u);
		Generic_MaghdaMothDust = SnoData.Powers.GetBySno(131745u);
		Generic_MaghdaPortalCreateCinematic = SnoData.Powers.GetBySno(184598u);
		Generic_MaghdaProjectile = SnoData.Powers.GetBySno(30568u);
		Generic_MaghdaPunish = SnoData.Powers.GetBySno(131746u);
		Generic_MaghdaPunishCinematic = SnoData.Powers.GetBySno(178279u);
		Generic_MaghdaSummonBeserker = SnoData.Powers.GetBySno(131744u);
		Generic_MaghdaTeleport = SnoData.Powers.GetBySno(131749u);
		Generic_MagicPaintingSummonSkeleton = SnoData.Powers.GetBySno(30313u);
		Generic_MalletDemonPowerHit = SnoData.Powers.GetBySno(123381u);
		Generic_ManualWalk = SnoData.Powers.GetBySno(229128u);
		Generic_MastaBlastaCombinedDismountRider = SnoData.Powers.GetBySno(145022u);
		Generic_MastaBlastaCombinedLobbedShot = SnoData.Powers.GetBySno(143940u);
		Generic_MastaBlastaRiderAlphaStrike = SnoData.Powers.GetBySno(140857u);
		Generic_MastaBlastaRiderCombine = SnoData.Powers.GetBySno(143991u);
		Generic_MastaBlastaRiderLeap = SnoData.Powers.GetBySno(140856u);
		Generic_MastaBlastaRiderLobbedShot = SnoData.Powers.GetBySno(139356u);
		Generic_MastaBlastaRiderLobbedShotLR = SnoData.Powers.GetBySno(445562u);
		Generic_MastaBlastaSteedCombine = SnoData.Powers.GetBySno(144289u);
		Generic_MastaBlastaSteedDrainAttack = SnoData.Powers.GetBySno(141333u);
		Generic_MastaBlastaSteedStomp = SnoData.Powers.GetBySno(140859u);
		Generic_MistressOfPainAscend = SnoData.Powers.GetBySno(212136u);
		Generic_MistressOfPainDescend = SnoData.Powers.GetBySno(212237u);
		Generic_MistressOfPainPainBolts = SnoData.Powers.GetBySno(136790u);
		Generic_MistressOfPainPainBoltsLR = SnoData.Powers.GetBySno(369693u);
		Generic_MistressOfPainSpiderlingExplode = SnoData.Powers.GetBySno(137143u);
		Generic_MistressOfPainSummonSpiders = SnoData.Powers.GetBySno(136958u);
		Generic_MistressOfPainSummonSpidersAirborne = SnoData.Powers.GetBySno(212239u);
		Generic_MistressOfPainTeleportToThrone = SnoData.Powers.GetBySno(137483u);
		Generic_MistressOfPainWebPatch = SnoData.Powers.GetBySno(136722u);
		Generic_MonkLashingTailKickHandOfYtarPassability = SnoData.Powers.GetBySno(366119u);
		Generic_MonkLethalDecoyTaunt = SnoData.Powers.GetBySno(110575u);
		Generic_MonkMysticAllyPetRuneAKick = SnoData.Powers.GetBySno(169155u);
		Generic_MonkMysticAllyPetRuneBWaveAttackFast = SnoData.Powers.GetBySno(363493u);
		Generic_MonkMysticAllyPetRuneCGroundPunch = SnoData.Powers.GetBySno(169715u);
		Generic_MonkMysticAllyPetRuneDAOEAttack = SnoData.Powers.GetBySno(169728u);
		Generic_MonkMysticAllyPetWeaponMeleeInstant = SnoData.Powers.GetBySno(169081u);
		Generic_MonkResistAura = SnoData.Powers.GetBySno(69489u);
		Generic_MonkResistAuraRuneCArcane = SnoData.Powers.GetBySno(144312u);
		Generic_MonkResistAuraRuneCCold = SnoData.Powers.GetBySno(144197u);
		Generic_MonkResistAuraRuneCFire = SnoData.Powers.GetBySno(143382u);
		Generic_MonkResistAuraRuneCHoly = SnoData.Powers.GetBySno(144322u);
		Generic_MonkResistAuraRuneCLightning = SnoData.Powers.GetBySno(144188u);
		Generic_MonkResistAuraRuneCPoison = SnoData.Powers.GetBySno(144202u);
		Generic_MonsterAffixArcaneEnchanted = SnoData.Powers.GetBySno(214594u);
		Generic_MonsterAffixArcaneEnchantedCast = SnoData.Powers.GetBySno(214791u);
		Generic_MonsterAffixArcaneEnchantedCastNoTarget = SnoData.Powers.GetBySno(450358u);
		Generic_MonsterAffixArcaneEnchantedChampion = SnoData.Powers.GetBySno(221130u);
		Generic_MonsterAffixArcaneEnchantedMinion = SnoData.Powers.GetBySno(221219u);
		Generic_MonsterAffixArcaneEnchantedNewPetBasic = SnoData.Powers.GetBySno(219671u);
		Generic_MonsterAffixAvengerArcaneEnchanted = SnoData.Powers.GetBySno(384426u);
		Generic_MonsterAffixAvengerArcaneEnchantedCast = SnoData.Powers.GetBySno(384436u);
		Generic_MonsterAffixAvengerArcaneEnchantedNewPetBasic = SnoData.Powers.GetBySno(392128u);
		Generic_MonsterAffixAvengerBuff = SnoData.Powers.GetBySno(226292u);
		Generic_MonsterAffixAvengerChampion = SnoData.Powers.GetBySno(226289u);
		Generic_MonsterAffixAvengerMortar = SnoData.Powers.GetBySno(384594u);
		Generic_MonsterAffixAvengerMortarCast = SnoData.Powers.GetBySno(384596u);
		Generic_MonsterAffixBallista = SnoData.Powers.GetBySno(91098u);
		Generic_MonsterAffixChampionBuff = SnoData.Powers.GetBySno(210333u);
		Generic_MonsterAffixDesecrator = SnoData.Powers.GetBySno(70874u);
		Generic_MonsterAffixDesecratorBuff = SnoData.Powers.GetBySno(156106u);
		Generic_MonsterAffixDesecratorBuffChampion = SnoData.Powers.GetBySno(221131u);
		Generic_MonsterAffixDesecratorCast = SnoData.Powers.GetBySno(156105u);
		Generic_MonsterAffixDieTogether = SnoData.Powers.GetBySno(91232u);
		Generic_MonsterAffixElectrified = SnoData.Powers.GetBySno(81420u);
		Generic_MonsterAffixElectrifiedLRBossCustom = SnoData.Powers.GetBySno(365083u);
		Generic_MonsterAffixElectrifiedMinion = SnoData.Powers.GetBySno(109899u);
		Generic_MonsterAffixExtraHealth = SnoData.Powers.GetBySno(70650u);
		Generic_MonsterAffixFast = SnoData.Powers.GetBySno(70849u);
		Generic_MonsterAffixFrozen = SnoData.Powers.GetBySno(90144u);
		Generic_MonsterAffixFrozenCast = SnoData.Powers.GetBySno(231149u);
		Generic_MonsterAffixFrozenRare = SnoData.Powers.GetBySno(231157u);
		Generic_MonsterAffixHealing = SnoData.Powers.GetBySno(276798u);
		Generic_MonsterAffixHealthlink = SnoData.Powers.GetBySno(71239u);
		Generic_MonsterAffixIllusionist = SnoData.Powers.GetBySno(71108u);
		Generic_MonsterAffixIllusionistCast = SnoData.Powers.GetBySno(264185u);
		Generic_MonsterAffixJailer = SnoData.Powers.GetBySno(222743u);
		Generic_MonsterAffixJailerCast = SnoData.Powers.GetBySno(222744u);
		Generic_MonsterAffixJailerChampion = SnoData.Powers.GetBySno(222745u);
		Generic_MonsterAffixJuggernaut = SnoData.Powers.GetBySno(455436u);
		Generic_MonsterAffixKnockback = SnoData.Powers.GetBySno(70655u);
		Generic_MonsterAffixLethargy = SnoData.Powers.GetBySno(488912u);
		Generic_MonsterAffixLinked = SnoData.Powers.GetBySno(226497u);
		Generic_MonsterAffixMissileDampening = SnoData.Powers.GetBySno(91028u);
		Generic_MonsterAffixMissileDampeningCast = SnoData.Powers.GetBySno(376860u);
		Generic_MonsterAffixMolten = SnoData.Powers.GetBySno(90314u);
		Generic_MonsterAffixMoltenMinion = SnoData.Powers.GetBySno(109898u);
		Generic_MonsterAffixMortar = SnoData.Powers.GetBySno(215756u);
		Generic_MonsterAffixMortarCast = SnoData.Powers.GetBySno(215757u);
		Generic_MonsterAffixNecrotic = SnoData.Powers.GetBySno(488914u);
		Generic_MonsterAffixNecroticQAtest = SnoData.Powers.GetBySno(489153u);
		Generic_MonsterAffixNightmarish = SnoData.Powers.GetBySno(247258u);
		Generic_MonsterAffixPheonix = SnoData.Powers.GetBySno(120655u);
		Generic_MonsterAffixPlagued = SnoData.Powers.GetBySno(90566u);
		Generic_MonsterAffixPlaguedCast = SnoData.Powers.GetBySno(231115u);
		Generic_MonsterAffixPuppetmaster = SnoData.Powers.GetBySno(71023u);
		Generic_MonsterAffixPuppetmasterMinion = SnoData.Powers.GetBySno(71024u);
		Generic_MonsterAffixReflectsDamage = SnoData.Powers.GetBySno(230877u);
		Generic_MonsterAffixReflectsDamageCast = SnoData.Powers.GetBySno(285770u);
		Generic_MonsterAffixResourceSteal = SnoData.Powers.GetBySno(488913u);
		Generic_MonsterAffixShielding = SnoData.Powers.GetBySno(226437u);
		Generic_MonsterAffixShieldingCast = SnoData.Powers.GetBySno(226438u);
		Generic_MonsterAffixTeleporterBuff = SnoData.Powers.GetBySno(155958u);
		Generic_MonsterAffixTeleporterCast = SnoData.Powers.GetBySno(155959u);
		Generic_MonsterAffixThunderstormBuff = SnoData.Powers.GetBySno(336177u);
		Generic_MonsterAffixThunderstormBuffChampion = SnoData.Powers.GetBySno(336178u);
		Generic_MonsterAffixThunderstormCast = SnoData.Powers.GetBySno(336179u);
		Generic_MonsterAffixVampiric = SnoData.Powers.GetBySno(70309u);
		Generic_MonsterAffixVortexBuff = SnoData.Powers.GetBySno(120306u);
		Generic_MonsterAffixVortexBuffChampion = SnoData.Powers.GetBySno(221132u);
		Generic_MonsterAffixVortexCast = SnoData.Powers.GetBySno(120305u);
		Generic_MonsterAffixWaller = SnoData.Powers.GetBySno(226293u);
		Generic_MonsterAffixWallerCast = SnoData.Powers.GetBySno(226294u);
		Generic_MonsterAffixWallerRare = SnoData.Powers.GetBySno(231117u);
		Generic_MonsterAffixWallerRareCast = SnoData.Powers.GetBySno(231118u);
		Generic_MonsterPoisonMeleeAttack = SnoData.Powers.GetBySno(30333u);
		Generic_MonsterRangedProjectile = SnoData.Powers.GetBySno(30334u);
		Generic_MonsterSpellProjectile = SnoData.Powers.GetBySno(30338u);
		Generic_MorluSpellcasterBreathOfFire = SnoData.Powers.GetBySno(158970u);
		Generic_MorluSpellcasterBreathOfFrost = SnoData.Powers.GetBySno(263415u);
		Generic_MorluSpellcasterMeteor = SnoData.Powers.GetBySno(158969u);
		Generic_MorluSpellcasterMeteorGraspOfTheDeadPrototype = SnoData.Powers.GetBySno(256045u);
		Generic_MorluSpellcasterShift = SnoData.Powers.GetBySno(158968u);
		Generic_MorluSpellcasterShiftNoCooldownCold = SnoData.Powers.GetBySno(428806u);
		Generic_MultiplayerBuff = SnoData.Powers.GetBySno(258199u);
		Generic_NPCLookAt = SnoData.Powers.GetBySno(30342u);
		Generic_OasisRockslideADamage = SnoData.Powers.GetBySno(395342u);
		Generic_OnDeathArcane = SnoData.Powers.GetBySno(30343u);
		Generic_OnDeathCold = SnoData.Powers.GetBySno(30344u);
		Generic_OnDeathFire = SnoData.Powers.GetBySno(30345u);
		Generic_OnDeathLightning = SnoData.Powers.GetBySno(30346u);
		Generic_OnDeathPoison = SnoData.Powers.GetBySno(30347u);
		Generic_OperateHelperAttach = SnoData.Powers.GetBySno(30348u);
		Generic_p1GreedCharge = SnoData.Powers.GetBySno(380460u);
		Generic_p1GreedChargeLong = SnoData.Powers.GetBySno(391073u);
		Generic_p1GreedChargeNoLOS = SnoData.Powers.GetBySno(398253u);
		Generic_p1GreedGoblinKnockback = SnoData.Powers.GetBySno(394194u);
		Generic_p1GreedGoldenMeteorShower = SnoData.Powers.GetBySno(385810u);
		Generic_p1GreedGoldSpawner = SnoData.Powers.GetBySno(385737u);
		Generic_p1GreedMinionPassiveLifetimeBuff = SnoData.Powers.GetBySno(382195u);
		Generic_p1GreedPassiveGoblinSpawnertest = SnoData.Powers.GetBySno(391176u);
		Generic_p1GreedPassiveLifetimeBuff = SnoData.Powers.GetBySno(381205u);
		Generic_p1GreedShockwave = SnoData.Powers.GetBySno(380646u);
		Generic_p1GreedSpawnMinion = SnoData.Powers.GetBySno(382342u);
		Generic_p1GreedUltimateMeteorShower = SnoData.Powers.GetBySno(391193u);
		Generic_p1TieredRiftSpawnNPC = SnoData.Powers.GetBySno(409173u);
		Generic_p1TreasureGoblinOnDeathAnniversaryPortal = SnoData.Powers.GetBySno(434819u);
		Generic_p1TreasureGoblinOnDeathGreedPortal = SnoData.Powers.GetBySno(382738u);
		Generic_p1TreasureGoblinOnDeathWhimsyshirePortal = SnoData.Powers.GetBySno(405592u);
		Generic_p2FallenLunaticAggroring = SnoData.Powers.GetBySno(434026u);
		Generic_P2ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(423205u);
		Generic_P2ItemPassiveUniqueRing002 = SnoData.Powers.GetBySno(423206u);
		Generic_P2ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(423226u);
		Generic_P2ItemPassiveUniqueRing005 = SnoData.Powers.GetBySno(423228u);
		Generic_P2ItemPassiveUniqueRing007 = SnoData.Powers.GetBySno(423230u);
		Generic_P2ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(423234u);
		Generic_P2ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(423236u);
		Generic_P2ItemPassiveUniqueRing013 = SnoData.Powers.GetBySno(423237u);
		Generic_P2ItemPassiveUniqueRing019 = SnoData.Powers.GetBySno(423243u);
		Generic_P2ItemPassiveUniqueRing020 = SnoData.Powers.GetBySno(423244u);
		Generic_P2ItemPassiveUniqueRing021 = SnoData.Powers.GetBySno(427798u);
		Generic_P2ItemPassiveUniqueRing022 = SnoData.Powers.GetBySno(427799u);
		Generic_P2ItemPassiveUniqueRing025 = SnoData.Powers.GetBySno(429665u);
		Generic_P2ItemPassiveUniqueRing026 = SnoData.Powers.GetBySno(429673u);
		Generic_P2ItemPassiveUniqueRing051 = SnoData.Powers.GetBySno(434377u);
		Generic_P2ItemPassiveUniqueRing053 = SnoData.Powers.GetBySno(434964u);
		Generic_P2ItemPassiveUniqueRing055 = SnoData.Powers.GetBySno(434967u);
		Generic_P2ItemPassiveUniqueRing056 = SnoData.Powers.GetBySno(434969u);
		Generic_P2ItemPassiveUniqueRing057 = SnoData.Powers.GetBySno(434980u);
		Generic_P2SpecialGoblinRiftSpawn = SnoData.Powers.GetBySno(429651u);
		Generic_P42ItemPassiveUniqueRing009 = SnoData.Powers.GetBySno(451244u);
		Generic_P42ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(451245u);
		Generic_P42ItemPassiveUniqueRing011 = SnoData.Powers.GetBySno(451246u);
		Generic_P42ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(451247u);
		Generic_P42ItemPassiveUniqueRing013 = SnoData.Powers.GetBySno(451248u);
		Generic_P42ItemPassiveUniqueRing014 = SnoData.Powers.GetBySno(451249u);
		Generic_P42ItemPassiveUniqueRing015 = SnoData.Powers.GetBySno(451250u);
		Generic_P42ItemPassiveUniqueRing016 = SnoData.Powers.GetBySno(451251u);
		Generic_P42ItemPassiveUniqueRing017 = SnoData.Powers.GetBySno(451252u);
		Generic_P42ItemPassiveUniqueRing018 = SnoData.Powers.GetBySno(451253u);
		Generic_P42ItemPassiveUniqueRing019 = SnoData.Powers.GetBySno(451254u);
		Generic_P42ItemPassiveUniqueRing020 = SnoData.Powers.GetBySno(451255u);
		Generic_p42ItemPassiveUniqueRing945 = SnoData.Powers.GetBySno(451333u);
		Generic_p43ADBarrelExplode = SnoData.Powers.GetBySno(455182u);
		Generic_p43ADEventAnvilOfFury = SnoData.Powers.GetBySno(455050u);
		Generic_p43ADTrapArrow = SnoData.Powers.GetBySno(455198u);
		Generic_p43d1ButcherMeleeBasic = SnoData.Powers.GetBySno(455501u);
		Generic_p43d1DiabloClawRip = SnoData.Powers.GetBySno(453765u);
		Generic_p43d1fastMummyMelee = SnoData.Powers.GetBySno(453803u);
		Generic_p43d1fastMummyStealth = SnoData.Powers.GetBySno(453802u);
		Generic_p43d1FleshPitFlyerBlink = SnoData.Powers.GetBySno(453994u);
		Generic_p43d1GorehoundAcidSpit = SnoData.Powers.GetBySno(454139u);
		Generic_p43d1MageFlash = SnoData.Powers.GetBySno(454586u);
		Generic_p43d1MageTeleport = SnoData.Powers.GetBySno(454584u);
		Generic_p43d1TerrorDemonLightningBreath = SnoData.Powers.GetBySno(454163u);
		Generic_p43d1ZoltunKulleFieryBoulder = SnoData.Powers.GetBySno(453734u);
		Generic_p43d1ZoltunKulleTeleport = SnoData.Powers.GetBySno(453738u);
		Generic_p43d1ZombieSkinnyMelee = SnoData.Powers.GetBySno(454045u);
		Generic_P43ItemPassiveUniqueRing007 = SnoData.Powers.GetBySno(454935u);
		Generic_P43ItemPassiveUniqueRing008 = SnoData.Powers.GetBySno(454936u);
		Generic_P43ItemPassiveUniqueRing009 = SnoData.Powers.GetBySno(454937u);
		Generic_P43ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(454938u);
		Generic_P4CrabMotherEnrage = SnoData.Powers.GetBySno(442660u);
		Generic_P4DemonFlyerFireBreath = SnoData.Powers.GetBySno(439325u);
		Generic_p4demonTrooperSpecialMelee = SnoData.Powers.GetBySno(435046u);
		Generic_P4ForestMysteriousHermitArcaneFireball = SnoData.Powers.GetBySno(445642u);
		Generic_P4ForestMysteriousHermitArcaneFireball_ = SnoData.Powers.GetBySno(445864u);
		Generic_P4ForestMysteriousHermitArcaneFlameWall_ = SnoData.Powers.GetBySno(445865u);
		Generic_p4ForestMysteriousHermitBoomerangBlade = SnoData.Powers.GetBySno(445808u);
		Generic_p4ForestMysteriousHermitProjectile = SnoData.Powers.GetBySno(437112u);
		Generic_p4ForestMysteriousHermitTeleportIllusion = SnoData.Powers.GetBySno(445850u);
		Generic_P4ForestMysteriousManSpiritForm = SnoData.Powers.GetBySno(437524u);
		Generic_P4ForestMysteriousManSpiritSetup = SnoData.Powers.GetBySno(437546u);
		Generic_p4GoatmanFireball = SnoData.Powers.GetBySno(433729u);
		Generic_p4IceGoatmanRangedChargedShot = SnoData.Powers.GetBySno(437534u);
		Generic_p4IcePorcupineBackpedalShot = SnoData.Powers.GetBySno(434171u);
		Generic_p4IcePorcupineJumpBack = SnoData.Powers.GetBySno(434174u);
		Generic_p4IcePorcupineNova = SnoData.Powers.GetBySno(430206u);
		Generic_p4IcePorcupineShot = SnoData.Powers.GetBySno(434209u);
		Generic_p4ItemPassiveUniqueRing024KKG = SnoData.Powers.GetBySno(436797u);
		Generic_P4ItemPassiveUniqueRing043SpawnDecoy = SnoData.Powers.GetBySno(446963u);
		Generic_p4LRBossFedExCharge = SnoData.Powers.GetBySno(433232u);
		Generic_p4LRBossSpawnBoneTurrets = SnoData.Powers.GetBySno(433225u);
		Generic_p4LRTerrorDemonWall = SnoData.Powers.GetBySno(429019u);
		Generic_p4MaggotSuicideProgressiveFreeze = SnoData.Powers.GetBySno(435737u);
		Generic_P4MermaidHydra = SnoData.Powers.GetBySno(442662u);
		Generic_p4MoleRatCharge = SnoData.Powers.GetBySno(423014u);
		Generic_p4rathostteleport = SnoData.Powers.GetBySno(423072u);
		Generic_p4RatKingDoubleSwing = SnoData.Powers.GetBySno(436574u);
		Generic_p4RatKingLifetimeBuffPlagued = SnoData.Powers.GetBySno(440700u);
		Generic_p4RatKingRatBallMonsterSetup = SnoData.Powers.GetBySno(427175u);
		Generic_p4RatKingSummonRatBallMonster = SnoData.Powers.GetBySno(427176u);
		Generic_p4RatKingSummonRatVolcano = SnoData.Powers.GetBySno(427244u);
		Generic_p4RatKingThunderdome = SnoData.Powers.GetBySno(427211u);
		Generic_p4RatKingWaspRain = SnoData.Powers.GetBySno(432984u);
		Generic_P4RuinsCannibalBarbarianBurrowOut = SnoData.Powers.GetBySno(437397u);
		Generic_P4RuinsCannibalBarbarianCombatRoll = SnoData.Powers.GetBySno(436379u);
		Generic_P4RuinsCannibalBarbarianFuriousCharge = SnoData.Powers.GetBySno(437858u);
		Generic_P4RuinsCannibalBarbarianGroundstomp = SnoData.Powers.GetBySno(436370u);
		Generic_P4RuinsCannibalBarbarianHammerOfTheAncients = SnoData.Powers.GetBySno(439318u);
		Generic_P4RuinsCannibalBarbarianIntroFear = SnoData.Powers.GetBySno(435911u);
		Generic_P4RuinsCannibalBarbarianLeapQuake = SnoData.Powers.GetBySno(436375u);
		Generic_P4RuinsCannibalBarbarianShout = SnoData.Powers.GetBySno(435875u);
		Generic_P4RuinsCannibalBarbarianSummon = SnoData.Powers.GetBySno(437262u);
		Generic_P4RuinsCannibalBarbarianWeaponThrow = SnoData.Powers.GetBySno(437865u);
		Generic_P4RuinsCannibalBarbarianWhirlwind = SnoData.Powers.GetBySno(435885u);
		Generic_p4ruinsfrostEventTheZiggurat = SnoData.Powers.GetBySno(433486u);
		Generic_P4RuinsFrostTrapSwingingBlade = SnoData.Powers.GetBySno(406180u);
		Generic_P4SacrificeMonsterBreakableNova = SnoData.Powers.GetBySno(450213u);
		Generic_P4SacrificeMonsterEnrage = SnoData.Powers.GetBySno(447376u);
		Generic_P4SandWaspProjectile = SnoData.Powers.GetBySno(410520u);
		Generic_p4SasquatchGorillaPound = SnoData.Powers.GetBySno(430556u);
		Generic_p4SasquatchRockPunchKnockback = SnoData.Powers.GetBySno(415079u);
		Generic_p4SasquatchSpikeLine = SnoData.Powers.GetBySno(430582u);
		Generic_p4SasquatchTriplePunch = SnoData.Powers.GetBySno(430448u);
		Generic_p4ScavengerSpawnerADeath = SnoData.Powers.GetBySno(435467u);
		Generic_p4ScorpionBugHoverProjectile = SnoData.Powers.GetBySno(426866u);
		Generic_p4SeaMonsterSpawnCrabs = SnoData.Powers.GetBySno(431678u);
		Generic_p4SetDungBarbKingsEnmy = SnoData.Powers.GetBySno(444770u);
		Generic_p4SetDungBarbKingsPly = SnoData.Powers.GetBySno(444771u);
		Generic_p4SetDungBarbMightEnmy = SnoData.Powers.GetBySno(444922u);
		Generic_p4SetDungBarbMightPly = SnoData.Powers.GetBySno(444923u);
		Generic_p4SetDungBarbRaekorEnmy = SnoData.Powers.GetBySno(444875u);
		Generic_p4SetDungBarbRaekorPly = SnoData.Powers.GetBySno(444876u);
		Generic_p4SetDungBarbWastesEnmy = SnoData.Powers.GetBySno(444832u);
		Generic_p4SetDungBarbWastesPly = SnoData.Powers.GetBySno(444834u);
		Generic_p4SetDungCruAkkhanEnmy = SnoData.Powers.GetBySno(444632u);
		Generic_p4SetDungCruAkkhanPly = SnoData.Powers.GetBySno(444633u);
		Generic_p4SetDungCruRolandEnmy = SnoData.Powers.GetBySno(444712u);
		Generic_p4SetDungCruRolandPly = SnoData.Powers.GetBySno(444713u);
		Generic_p4SetDungCruSeekerEnmy = SnoData.Powers.GetBySno(445277u);
		Generic_p4SetDungCruSeekerPly = SnoData.Powers.GetBySno(445278u);
		Generic_p4SetDungCruThornsEnmy = SnoData.Powers.GetBySno(445257u);
		Generic_p4SetDungCruThornsPly = SnoData.Powers.GetBySno(445258u);
		Generic_p4SetDungDeathBarbKings = SnoData.Powers.GetBySno(444769u);
		Generic_p4SetDungDeathBarbMight = SnoData.Powers.GetBySno(444915u);
		Generic_p4SetDungDeathBarbRaekor = SnoData.Powers.GetBySno(444874u);
		Generic_p4SetDungDeathBarbWastes = SnoData.Powers.GetBySno(444826u);
		Generic_p4SetDungDeathCruAkkhan = SnoData.Powers.GetBySno(444631u);
		Generic_p4SetDungDeathCruRoland = SnoData.Powers.GetBySno(444710u);
		Generic_p4SetDungDeathCruSeeker = SnoData.Powers.GetBySno(445276u);
		Generic_p4SetDungDeathCruThorns = SnoData.Powers.GetBySno(445251u);
		Generic_p4SetDungDeathDHEss = SnoData.Powers.GetBySno(445035u);
		Generic_p4SetDungDeathDHMar = SnoData.Powers.GetBySno(444996u);
		Generic_p4SetDungDeathDHNat = SnoData.Powers.GetBySno(445007u);
		Generic_p4SetDungDeathDHShadow = SnoData.Powers.GetBySno(445062u);
		Generic_p4SetDungDeathMonkInnas = SnoData.Powers.GetBySno(445173u);
		Generic_p4SetDungDeathMonkStorms = SnoData.Powers.GetBySno(445225u);
		Generic_p4SetDungDeathMonkSunwuko = SnoData.Powers.GetBySno(445191u);
		Generic_p4SetDungDeathMonkUliana = SnoData.Powers.GetBySno(445208u);
		Generic_p4SetDungDeathWDHaunt = SnoData.Powers.GetBySno(445098u);
		Generic_p4SetDungDeathWDJade = SnoData.Powers.GetBySno(445155u);
		Generic_p4SetDungDeathWDSpider = SnoData.Powers.GetBySno(445132u);
		Generic_p4SetDungDeathWDTooth = SnoData.Powers.GetBySno(445081u);
		Generic_p4SetDungDeathWizFirebird = SnoData.Powers.GetBySno(444577u);
		Generic_p4SetDungDeathWizOpus = SnoData.Powers.GetBySno(443832u);
		Generic_p4SetDungDeathWizRasha = SnoData.Powers.GetBySno(444516u);
		Generic_p4SetDungDeathWizVyr = SnoData.Powers.GetBySno(444972u);
		Generic_p4SetDungDHEssEnmy = SnoData.Powers.GetBySno(445036u);
		Generic_p4SetDungDHEssPly = SnoData.Powers.GetBySno(445037u);
		Generic_p4SetDungDHMarEnmy = SnoData.Powers.GetBySno(444997u);
		Generic_p4SetDungDHMarPly = SnoData.Powers.GetBySno(444998u);
		Generic_p4SetDungDHNatEnmy = SnoData.Powers.GetBySno(445009u);
		Generic_p4SetDungDHNatPly = SnoData.Powers.GetBySno(445010u);
		Generic_p4SetDungDHShadowEnmy = SnoData.Powers.GetBySno(445063u);
		Generic_p4SetDungDHShadowPly = SnoData.Powers.GetBySno(445064u);
		Generic_p4SetDungGenericsEnmy = SnoData.Powers.GetBySno(443795u);
		Generic_p4SetDungGenericsPly = SnoData.Powers.GetBySno(443833u);
		Generic_p4SetDungGenericsPlyBalance = SnoData.Powers.GetBySno(450351u);
		Generic_p4SetDungGenericsPortal = SnoData.Powers.GetBySno(450469u);
		Generic_p4SetDungMonkInnasEnmy = SnoData.Powers.GetBySno(445174u);
		Generic_p4SetDungMonkInnasPly = SnoData.Powers.GetBySno(445175u);
		Generic_p4SetDungMonkStormsEnmy = SnoData.Powers.GetBySno(445233u);
		Generic_p4SetDungMonkStormsPly = SnoData.Powers.GetBySno(445234u);
		Generic_p4SetDungMonkSunwukoEnmy = SnoData.Powers.GetBySno(445192u);
		Generic_p4SetDungMonkSunwukoPly = SnoData.Powers.GetBySno(445193u);
		Generic_p4SetDungMonkUlianaEnmy = SnoData.Powers.GetBySno(445209u);
		Generic_p4SetDungMonkUlianaPly = SnoData.Powers.GetBySno(445210u);
		Generic_p4SetDungMonsterAffixMortarCast = SnoData.Powers.GetBySno(447584u);
		Generic_p4SetDungPedestalBarbKings = SnoData.Powers.GetBySno(447950u);
		Generic_p4SetDungPedestalBarbMight = SnoData.Powers.GetBySno(447975u);
		Generic_p4SetDungPedestalBarbRaekor = SnoData.Powers.GetBySno(447976u);
		Generic_p4SetDungPedestalBarbWastes = SnoData.Powers.GetBySno(447977u);
		Generic_p4SetDungPedestalCruAkkhan = SnoData.Powers.GetBySno(447978u);
		Generic_p4SetDungPedestalCruRoland = SnoData.Powers.GetBySno(447979u);
		Generic_p4SetDungPedestalCruSeeker = SnoData.Powers.GetBySno(447980u);
		Generic_p4SetDungPedestalCruThorns = SnoData.Powers.GetBySno(447981u);
		Generic_p4SetDungPedestalDHEss = SnoData.Powers.GetBySno(447982u);
		Generic_p4SetDungPedestalDHMar = SnoData.Powers.GetBySno(447984u);
		Generic_p4SetDungPedestalDHNat = SnoData.Powers.GetBySno(447983u);
		Generic_p4SetDungPedestalDHShadow = SnoData.Powers.GetBySno(447985u);
		Generic_p4SetDungPedestalMonkInnas = SnoData.Powers.GetBySno(447986u);
		Generic_p4SetDungPedestalMonkStorms = SnoData.Powers.GetBySno(447987u);
		Generic_p4SetDungPedestalMonkSunwuko = SnoData.Powers.GetBySno(447988u);
		Generic_p4SetDungPedestalMonkUliana = SnoData.Powers.GetBySno(447989u);
		Generic_p4SetDungPedestalWDHaunt = SnoData.Powers.GetBySno(447990u);
		Generic_p4SetDungPedestalWDJade = SnoData.Powers.GetBySno(447991u);
		Generic_p4SetDungPedestalWDSpider = SnoData.Powers.GetBySno(447992u);
		Generic_p4SetDungPedestalWDTooth = SnoData.Powers.GetBySno(447993u);
		Generic_p4SetDungPedestalWizFirebird = SnoData.Powers.GetBySno(447995u);
		Generic_p4SetDungPedestalWizOpus = SnoData.Powers.GetBySno(447996u);
		Generic_p4SetDungPedestalWizRasha = SnoData.Powers.GetBySno(447997u);
		Generic_p4SetDungPedestalWizVyr = SnoData.Powers.GetBySno(447998u);
		Generic_p4SetDungPortalChecks = SnoData.Powers.GetBySno(447038u);
		Generic_p4SetDungWDHauntEnmy = SnoData.Powers.GetBySno(445099u);
		Generic_p4SetDungWDHauntPly = SnoData.Powers.GetBySno(445100u);
		Generic_p4SetDungWDJadeEnmy = SnoData.Powers.GetBySno(445156u);
		Generic_p4SetDungWDJadePly = SnoData.Powers.GetBySno(445157u);
		Generic_p4SetDungWDSpiderEnmy = SnoData.Powers.GetBySno(445133u);
		Generic_p4SetDungWDSpiderPly = SnoData.Powers.GetBySno(445134u);
		Generic_p4SetDungWDToothEnmy = SnoData.Powers.GetBySno(445082u);
		Generic_p4SetDungWDToothPly = SnoData.Powers.GetBySno(445083u);
		Generic_p4SetDungWestmarchBruteCharge = SnoData.Powers.GetBySno(451207u);
		Generic_p4SetDungWizFirebirdEnmy = SnoData.Powers.GetBySno(445771u);
		Generic_p4SetDungWizFirebirdPly = SnoData.Powers.GetBySno(445772u);
		Generic_p4SetDungWizOpusEnmy = SnoData.Powers.GetBySno(444008u);
		Generic_p4SetDungWizOpusPly = SnoData.Powers.GetBySno(443898u);
		Generic_p4SetDungWizRashaEnmy = SnoData.Powers.GetBySno(444519u);
		Generic_p4SetDungWizRashaPly = SnoData.Powers.GetBySno(444520u);
		Generic_p4SetDungWizVyrEnmy = SnoData.Powers.GetBySno(444975u);
		Generic_p4SetDungWizVyrPly = SnoData.Powers.GetBySno(444976u);
		Generic_P4ShrineDebuffDamage = SnoData.Powers.GetBySno(445778u);
		Generic_P4ShrineDebuffSpawner = SnoData.Powers.GetBySno(445788u);
		Generic_p4SkeletonZombieSpawnerADeath = SnoData.Powers.GetBySno(433150u);
		Generic_P4SpiderBombAODDamage = SnoData.Powers.GetBySno(274506u);
		Generic_P4SpiderBombBurrowIn = SnoData.Powers.GetBySno(275328u);
		Generic_p4WaspNestDeath = SnoData.Powers.GetBySno(410598u);
		Generic_p4WickermanSpawnerADeath = SnoData.Powers.GetBySno(435834u);
		Generic_P4WoodWraithSummonSporesCeremonyEvent = SnoData.Powers.GetBySno(435833u);
		Generic_p4WoodWraithVineTrap = SnoData.Powers.GetBySno(430133u);
		Generic_p4YetiIceBreath = SnoData.Powers.GetBySno(411373u);
		Generic_p4YetiIceSpikes = SnoData.Powers.GetBySno(413296u);
		Generic_p4YetiMeleeBasic = SnoData.Powers.GetBySno(437834u);
		Generic_p4YetiOverheadSmash = SnoData.Powers.GetBySno(440693u);
		Generic_p4YetiSnowBoulderRoll = SnoData.Powers.GetBySno(429905u);
		Generic_P5ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(451256u);
		Generic_P610ItemPassiveUniqueMojo010x1tooltipDummy2 = SnoData.Powers.GetBySno(484658u);
		Generic_P61ItemPassiveUniqueRing021 = SnoData.Powers.GetBySno(478511u);
		Generic_P66ItemPassiveUniqueRing930 = SnoData.Powers.GetBySno(483537u);
		Generic_P66ItemPassiveUniqueRing932 = SnoData.Powers.GetBySno(483571u);
		Generic_P66ItemPassiveUniqueRing933 = SnoData.Powers.GetBySno(483572u);
		Generic_P66ItemPassiveUniqueRing934 = SnoData.Powers.GetBySno(483573u);
		Generic_P66ItemPassiveUniqueRing935 = SnoData.Powers.GetBySno(483574u);
		Generic_P66ItemPassiveUniqueRing941 = SnoData.Powers.GetBySno(483548u);
		Generic_P66ItemPassiveUniqueRing946 = SnoData.Powers.GetBySno(483570u);
		Generic_P67ItemPassiveUniqueRing947 = SnoData.Powers.GetBySno(483639u);
		Generic_P67ItemPassiveUniqueRing948 = SnoData.Powers.GetBySno(483643u);
		Generic_P67ItemPassiveUniqueRing949 = SnoData.Powers.GetBySno(483655u);
		Generic_P67ItemPassiveUniqueRing950 = SnoData.Powers.GetBySno(483662u);
		Generic_P67ItemPassiveUniqueRing951 = SnoData.Powers.GetBySno(483663u);
		Generic_P67ItemPassiveUniqueRing952 = SnoData.Powers.GetBySno(483664u);
		Generic_P67ItemPassiveUniqueRing953 = SnoData.Powers.GetBySno(483670u);
		Generic_P67ItemPassiveUniqueRing956 = SnoData.Powers.GetBySno(483852u);
		Generic_P67ItemPassiveUniqueRing957 = SnoData.Powers.GetBySno(483853u);
		Generic_P67ItemPassiveUniqueRing958 = SnoData.Powers.GetBySno(483854u);
		Generic_P67ItemPassiveUniqueRing959 = SnoData.Powers.GetBySno(483859u);
		Generic_P67ItemPassiveUniqueRing960 = SnoData.Powers.GetBySno(483861u);
		Generic_P67ItemPassiveUniqueRing961 = SnoData.Powers.GetBySno(483863u);
		Generic_P67ItemPassiveUniqueRing962 = SnoData.Powers.GetBySno(483865u);
		Generic_P67ItemPassiveUniqueRing963 = SnoData.Powers.GetBySno(483866u);
		Generic_P67ItemPassiveUniqueRing964 = SnoData.Powers.GetBySno(483884u);
		Generic_P67ItemPassiveUniqueRing965 = SnoData.Powers.GetBySno(483889u);
		Generic_P67ItemPassiveUniqueRing966 = SnoData.Powers.GetBySno(483901u);
		Generic_P67ItemPassiveUniqueRing968 = SnoData.Powers.GetBySno(484057u);
		Generic_P68ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(484060u);
		Generic_P68ItemPassiveUniqueRing002 = SnoData.Powers.GetBySno(484061u);
		Generic_P68ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(484062u);
		Generic_P68ItemPassiveUniqueRing006 = SnoData.Powers.GetBySno(484121u);
		Generic_P68ItemPassiveUniqueRing007 = SnoData.Powers.GetBySno(484122u);
		Generic_P68ItemPassiveUniqueRing008 = SnoData.Powers.GetBySno(484128u);
		Generic_P68ItemPassiveUniqueRing009 = SnoData.Powers.GetBySno(484129u);
		Generic_P68ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(484130u);
		Generic_P68ItemPassiveUniqueRing011 = SnoData.Powers.GetBySno(484131u);
		Generic_P68ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(484144u);
		Generic_P68ItemPassiveUniqueRing013 = SnoData.Powers.GetBySno(484145u);
		Generic_P68ItemPassiveUniqueRing014 = SnoData.Powers.GetBySno(484146u);
		Generic_P68ItemPassiveUniqueRing018 = SnoData.Powers.GetBySno(484279u);
		Generic_P68ItemPassiveUniqueRing970 = SnoData.Powers.GetBySno(484118u);
		Generic_P69ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(484320u);
		Generic_P69ItemPassiveUniqueRing004 = SnoData.Powers.GetBySno(484497u);
		Generic_P69ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(484289u);
		Generic_P69ItemPassiveUniqueRing011 = SnoData.Powers.GetBySno(484290u);
		Generic_P69ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(484291u);
		Generic_P69ItemPassiveUniqueRing013 = SnoData.Powers.GetBySno(484301u);
		Generic_P69ItemPassiveUniqueRing014 = SnoData.Powers.GetBySno(484302u);
		Generic_P69ItemPassiveUniqueRing015 = SnoData.Powers.GetBySno(484303u);
		Generic_P69ItemPassiveUniqueRing100 = SnoData.Powers.GetBySno(484342u);
		Generic_P69ItemPassiveUniqueRing101 = SnoData.Powers.GetBySno(484343u);
		Generic_P69ItemPassiveUniqueRing102 = SnoData.Powers.GetBySno(484356u);
		Generic_P69ItemPassiveUniqueRing103 = SnoData.Powers.GetBySno(484418u);
		Generic_P69ItemPassiveUniqueRing104 = SnoData.Powers.GetBySno(484425u);
		Generic_p6CrowHoundProjectile = SnoData.Powers.GetBySno(470770u);
		Generic_P6EnvyBossLookSwitch = SnoData.Powers.GetBySno(470267u);
		Generic_P6EnvyBossMirrorPortBuff = SnoData.Powers.GetBySno(470530u);
		Generic_P6EnvyBossMirrorPortBuffRemove = SnoData.Powers.GetBySno(470543u);
		Generic_P6EnvyBossRangedPortBuff = SnoData.Powers.GetBySno(470531u);
		Generic_P6EnvyDMGReduction = SnoData.Powers.GetBySno(474684u);
		Generic_P6ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(467463u);
		Generic_P6ItemPassiveUniqueRing002 = SnoData.Powers.GetBySno(467464u);
		Generic_P6ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(467465u);
		Generic_P6ItemPassiveUniqueRing004 = SnoData.Powers.GetBySno(472266u);
		Generic_P6ItemPassiveUniqueRing005 = SnoData.Powers.GetBySno(472267u);
		Generic_P6ItemPassiveUniqueRing006 = SnoData.Powers.GetBySno(472268u);
		Generic_P6ItemPassiveUniqueRing007 = SnoData.Powers.GetBySno(472269u);
		Generic_P6ItemPassiveUniqueRing008 = SnoData.Powers.GetBySno(472270u);
		Generic_P6ItemPassiveUniqueRing009 = SnoData.Powers.GetBySno(472271u);
		Generic_P6ItemPassiveUniqueRing010 = SnoData.Powers.GetBySno(472272u);
		Generic_P6ItemPassiveUniqueRing011 = SnoData.Powers.GetBySno(472273u);
		Generic_P6ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(472274u);
		Generic_P6ItemPassiveUniqueRing013 = SnoData.Powers.GetBySno(472668u);
		Generic_P6ItemPassiveUniqueRing014 = SnoData.Powers.GetBySno(472669u);
		Generic_P6ItemPassiveUniqueRing015 = SnoData.Powers.GetBySno(472670u);
		Generic_P6ItemPassiveUniqueRing016 = SnoData.Powers.GetBySno(472671u);
		Generic_P6ItemPassiveUniqueRing017 = SnoData.Powers.GetBySno(472672u);
		Generic_P6ItemPassiveUniqueRing018 = SnoData.Powers.GetBySno(472673u);
		Generic_P6ItemPassiveUniqueRing019 = SnoData.Powers.GetBySno(472674u);
		Generic_P6ItemPassiveUniqueRing020 = SnoData.Powers.GetBySno(472675u);
		Generic_P6ItemPassiveUniqueRing021 = SnoData.Powers.GetBySno(472676u);
		Generic_P6ItemPassiveUniqueRing022 = SnoData.Powers.GetBySno(472677u);
		Generic_P6ItemPassiveUniqueRing023 = SnoData.Powers.GetBySno(472678u);
		Generic_P6ItemPassiveUniqueRing024 = SnoData.Powers.GetBySno(472679u);
		Generic_P6ItemPassiveUniqueRing025 = SnoData.Powers.GetBySno(472693u);
		Generic_P6ItemPassiveUniqueRing026 = SnoData.Powers.GetBySno(472694u);
		Generic_P6ItemPassiveUniqueRing027 = SnoData.Powers.GetBySno(472695u);
		Generic_P6ItemPassiveUniqueRing028 = SnoData.Powers.GetBySno(472697u);
		Generic_P6ItemPassiveUniqueRing029 = SnoData.Powers.GetBySno(472698u);
		Generic_P6ItemPassiveUniqueRing030 = SnoData.Powers.GetBySno(472699u);
		Generic_P6ItemPassiveUniqueRing031 = SnoData.Powers.GetBySno(472700u);
		Generic_P6ItemPassiveUniqueRing032 = SnoData.Powers.GetBySno(472701u);
		Generic_P6ItemPassiveUniqueRing033 = SnoData.Powers.GetBySno(472702u);
		Generic_P6ItemPassiveUniqueRing034 = SnoData.Powers.GetBySno(472703u);
		Generic_P6ItemPassiveUniqueRing035 = SnoData.Powers.GetBySno(472704u);
		Generic_P6ItemPassiveUniqueRing036 = SnoData.Powers.GetBySno(472705u);
		Generic_P6ItemPassiveUniqueRing038 = SnoData.Powers.GetBySno(475242u);
		Generic_P6ItemPassiveUniqueRing051 = SnoData.Powers.GetBySno(476047u);
		Generic_P6ItemPassiveUniqueRing052 = SnoData.Powers.GetBySno(476048u);
		Generic_P6ItemPassiveUniqueRing053 = SnoData.Powers.GetBySno(476049u);
		Generic_P6ItemPassiveUniqueRing055 = SnoData.Powers.GetBySno(476051u);
		Generic_P6ItemPassiveUniqueRing056 = SnoData.Powers.GetBySno(476052u);
		Generic_P6NecroBoneSpikesInversePassability = SnoData.Powers.GetBySno(472587u);
		Generic_P6NecroBoneSpiritPassive = SnoData.Powers.GetBySno(464999u);
		Generic_P6NecroDevourAura = SnoData.Powers.GetBySno(474325u);
		Generic_P6NecroFrailtyAura = SnoData.Powers.GetBySno(473992u);
		Generic_P6NecroGenericCorpseTargeting = SnoData.Powers.GetBySno(454137u);
		Generic_P6NecroGolemMelee = SnoData.Powers.GetBySno(451561u);
		Generic_P6NecroRaiseDeadDDecayAura = SnoData.Powers.GetBySno(471359u);
		Generic_P6NecroRaiseDeadDDecayAuraSpawn = SnoData.Powers.GetBySno(474371u);
		Generic_P6NecroRaiseDeadEArcherAttack = SnoData.Powers.GetBySno(471374u);
		Generic_P6NecroRaiseDeadEArcherSpawnAttack = SnoData.Powers.GetBySno(472995u);
		Generic_P6NecroRaiseDeadMageSpawnAttack = SnoData.Powers.GetBySno(457769u);
		Generic_P6NecroRaiseDeadMageSpawnAttackNoTarget = SnoData.Powers.GetBySno(464530u);
		Generic_p6NecroRaiseGolemBloodGolemVeinAoE = SnoData.Powers.GetBySno(463797u);
		Generic_P6NecroRaiseGolemBoneGolemTornado = SnoData.Powers.GetBySno(465257u);
		Generic_P6NecroRaiseGolemConsumeGolemEatCorpses = SnoData.Powers.GetBySno(471615u);
		Generic_p6NecroRaiseGolemDestroyBreakables = SnoData.Powers.GetBySno(478216u);
		Generic_P6NecroRaiseGolemFleshGolemDropCorpses = SnoData.Powers.GetBySno(466862u);
		Generic_P6NecroRaiseGolemIceGolemFreeze = SnoData.Powers.GetBySno(471655u);
		Generic_P6NecroRaiseSkeletonsChargeAttack = SnoData.Powers.GetBySno(456302u);
		Generic_p6NecroReviveAngelCorruptPiercingDash = SnoData.Powers.GetBySno(469983u);
		Generic_p6NecroRevivearmorScavengerbuff = SnoData.Powers.GetBySno(476778u);
		Generic_p6NecroReviveBeastCharge = SnoData.Powers.GetBySno(470882u);
		Generic_p6NecroReviveBigRedCharge = SnoData.Powers.GetBySno(467631u);
		Generic_p6NecroReviveBogFamilyRangedRapidShot = SnoData.Powers.GetBySno(477233u);
		Generic_p6NecroReviveBrickhouseSlam = SnoData.Powers.GetBySno(470952u);
		Generic_p6NecroReviveCorpulentExplode = SnoData.Powers.GetBySno(470990u);
		Generic_p6NecroReviveCrowHoundProjectile = SnoData.Powers.GetBySno(476425u);
		Generic_p6NecroReviveDarkAngelSoulRush = SnoData.Powers.GetBySno(476335u);
		Generic_p6NecroRevivedeathMaidenSpinAttack = SnoData.Powers.GetBySno(476485u);
		Generic_p6NecroReviveDemonFlyerProjectile = SnoData.Powers.GetBySno(471091u);
		Generic_p6NecroReviveDervishWhirlwind = SnoData.Powers.GetBySno(471147u);
		Generic_p6NecroReviveFallenShamanProjectile = SnoData.Powers.GetBySno(463173u);
		Generic_p6NecroReviveFastMummyDiseaseCloud = SnoData.Powers.GetBySno(471173u);
		Generic_p6NecroReviveFloaterAngelProjectile = SnoData.Powers.GetBySno(477406u);
		Generic_p6NecroReviveGoatmanRangedProjectile = SnoData.Powers.GetBySno(471863u);
		Generic_p6NecroReviveGoatmanShamanLightningbolt = SnoData.Powers.GetBySno(471809u);
		Generic_P6NecroReviveGoatMutantRangedProjectile = SnoData.Powers.GetBySno(471972u);
		Generic_P6NecroReviveGoatMutantShamanBlast = SnoData.Powers.GetBySno(471982u);
		Generic_p6NecroReviveHoodedNightmareProjectile = SnoData.Powers.GetBySno(467625u);
		Generic_P6NecroReviveIcePorcupineShot = SnoData.Powers.GetBySno(474749u);
		Generic_p6NecroReviveLacuniLeap = SnoData.Powers.GetBySno(472055u);
		Generic_p6NecroReviveLacuniMaleDoubleSwing = SnoData.Powers.GetBySno(472112u);
		Generic_p6NecroReviveLeaperAngelLeap = SnoData.Powers.GetBySno(474096u);
		Generic_P6NecroReviveMelee = SnoData.Powers.GetBySno(474930u);
		Generic_p6NecroReviveMermaidRangedProjectile = SnoData.Powers.GetBySno(475304u);
		Generic_p6NecroReviveMoleMutantRangedProjectile = SnoData.Powers.GetBySno(475462u);
		Generic_p6NecroReviveMoleMutantShamanProjectile = SnoData.Powers.GetBySno(475495u);
		Generic_p6NecroReviveMorluSpellcasterBreathOfFire = SnoData.Powers.GetBySno(462969u);
		Generic_p6NecroReviveNightScreamerProjectile = SnoData.Powers.GetBySno(477454u);
		Generic_p6NecroRevivepandExtRanged = SnoData.Powers.GetBySno(476314u);
		Generic_p6NecroRevivePortalGuardianMinionprojectile = SnoData.Powers.GetBySno(477336u);
		Generic_p6NecroReviveQuillDemonProjectile = SnoData.Powers.GetBySno(476524u);
		Generic_p6NecroReviverockwormprojectile = SnoData.Powers.GetBySno(477004u);
		Generic_p6NecroReviveSandWaspProjectile = SnoData.Powers.GetBySno(475916u);
		Generic_p6NecroReviveScorpionBugHoverProjectile = SnoData.Powers.GetBySno(476109u);
		Generic_p6NecroReviveShepherdProjectile = SnoData.Powers.GetBySno(476699u);
		Generic_p6NecroReviveSkeletonArcherProjectile = SnoData.Powers.GetBySno(466508u);
		Generic_p6NecroReviveskeletonMageProjectile = SnoData.Powers.GetBySno(466879u);
		Generic_p6NecroReviveSkeletonSummonerProjectile = SnoData.Powers.GetBySno(466524u);
		Generic_p6NecroReviveSniperAngelcloseRangedAttack = SnoData.Powers.GetBySno(477433u);
		Generic_p6NecroReviveSuccubusBloodStar = SnoData.Powers.GetBySno(476353u);
		Generic_p6NecroReviveTempleCultistCasterProjectile = SnoData.Powers.GetBySno(476710u);
		Generic_p6NecroReviveTempleCultistSuicide = SnoData.Powers.GetBySno(476715u);
		Generic_p6NecroReviveThousandPounderKnockback = SnoData.Powers.GetBySno(470477u);
		Generic_p6NecroReviveTriuneSummonerProjectile = SnoData.Powers.GetBySno(467271u);
		Generic_p6NecroReviveUnburiedKnockback = SnoData.Powers.GetBySno(474825u);
		Generic_p6NecroReviveWerewolfMelee = SnoData.Powers.GetBySno(476685u);
		Generic_p6NecroReviveWestmarchBruteBDecapitateSlide = SnoData.Powers.GetBySno(470970u);
		Generic_p6NecroReviveWestmarchBruteCharge = SnoData.Powers.GetBySno(477779u);
		Generic_p6NecroReviveWestmarchHoundTaunt = SnoData.Powers.GetBySno(477578u);
		Generic_p6NecroReviveWestmarchHoundTauntSearch = SnoData.Powers.GetBySno(477579u);
		Generic_p6NecroRevivewestmarchRangedProjectile = SnoData.Powers.GetBySno(476848u);
		Generic_P6NecroReviveWraithMelee = SnoData.Powers.GetBySno(476925u);
		Generic_p6NecroReviveZombieFemaleProjectile = SnoData.Powers.GetBySno(466256u);
		Generic_P6NecroSimulacrumWeaponMeleeInstant = SnoData.Powers.GetBySno(475334u);
		Generic_P6NecroSkeletalWarriorMelee = SnoData.Powers.GetBySno(455151u);
		Generic_P6NecroSkeletalWarriorUberMelee = SnoData.Powers.GetBySno(457832u);
		Generic_P6NecroSkeletonMageFireProjectile = SnoData.Powers.GetBySno(451557u);
		Generic_P6NecroTraitGolemSpawner = SnoData.Powers.GetBySno(460062u);
		Generic_P6NecroTraitSkeletonSpawner = SnoData.Powers.GetBySno(453793u);
		Generic_p6RavenFlyerJumpBackAttack = SnoData.Powers.GetBySno(467137u);
		Generic_p6RavenFlyerPathingBuff = SnoData.Powers.GetBySno(469618u);
		Generic_p6SetDungDeathNecroBlood = SnoData.Powers.GetBySno(468592u);
		Generic_p6SetDungDeathNecroBone = SnoData.Powers.GetBySno(468593u);
		Generic_p6SetDungDeathNecroPlague = SnoData.Powers.GetBySno(468594u);
		Generic_p6SetDungDeathNecroSaint = SnoData.Powers.GetBySno(468595u);
		Generic_p6SetDungNecroBloodEnmy = SnoData.Powers.GetBySno(468596u);
		Generic_p6SetDungNecroBloodPly = SnoData.Powers.GetBySno(468597u);
		Generic_p6SetDungNecroBoneEnmy = SnoData.Powers.GetBySno(468598u);
		Generic_p6SetDungNecroBonePly = SnoData.Powers.GetBySno(468599u);
		Generic_p6SetDungNecroPlagueEnmy = SnoData.Powers.GetBySno(468600u);
		Generic_p6SetDungNecroPlaguePly = SnoData.Powers.GetBySno(468601u);
		Generic_p6SetDungNecroSaintEnmy = SnoData.Powers.GetBySno(468602u);
		Generic_p6SetDungNecroSaintPly = SnoData.Powers.GetBySno(468603u);
		Generic_p6SetDungPedestalNecroBlood = SnoData.Powers.GetBySno(468604u);
		Generic_p6SetDungPedestalNecroBone = SnoData.Powers.GetBySno(468605u);
		Generic_p6SetDungPedestalNecroPlague = SnoData.Powers.GetBySno(468606u);
		Generic_p6SetDungPedestalNecroSaint = SnoData.Powers.GetBySno(468607u);
		Generic_P6ShepherdBossTeleportOutro = SnoData.Powers.GetBySno(469966u);
		Generic_p6ShepherdRangedAttack = SnoData.Powers.GetBySno(461453u);
		Generic_p6ShepherdRangedAttackBoss = SnoData.Powers.GetBySno(472850u);
		Generic_p6ShepherdRangedAttackBossTransformed = SnoData.Powers.GetBySno(476611u);
		Generic_p6ShepherdRangedAttackNodmg = SnoData.Powers.GetBySno(469818u);
		Generic_P6ShepherdSpawnBossOutro = SnoData.Powers.GetBySno(477974u);
		Generic_P6ShepherdSpawnIntro = SnoData.Powers.GetBySno(476218u);
		Generic_P6ShepherdSpawnOutro = SnoData.Powers.GetBySno(476233u);
		Generic_P6ShepherdTeleportIntro = SnoData.Powers.GetBySno(462770u);
		Generic_P6ShepherdTeleportIntroMirror = SnoData.Powers.GetBySno(473826u);
		Generic_P6ShepherdTeleportOutro = SnoData.Powers.GetBySno(462771u);
		Generic_p6TempleCultistLobbedShot = SnoData.Powers.GetBySno(465139u);
		Generic_p6TempleCultistSuicide = SnoData.Powers.GetBySno(465143u);
		Generic_p6TempleMonstrosityGrenadeVolley = SnoData.Powers.GetBySno(471378u);
		Generic_p6TempleMonstrosityMeleeLance = SnoData.Powers.GetBySno(471326u);
		Generic_P6WerewolfClawRush = SnoData.Powers.GetBySno(464675u);
		Generic_P6WerewolfHowl = SnoData.Powers.GetBySno(464614u);
		Generic_P6WerewolfJumpBack = SnoData.Powers.GetBySno(464670u);
		Generic_P6WerewolfLeap = SnoData.Powers.GetBySno(464027u);
		Generic_P6WerewolfLeapFire = SnoData.Powers.GetBySno(470440u);
		Generic_P6WerewolfMelee = SnoData.Powers.GetBySno(464583u);
		Generic_P6WerewolfMeleeFire = SnoData.Powers.GetBySno(465394u);
		Generic_P71ItemPassiveEthereal001 = SnoData.Powers.GetBySno(485635u);
		Generic_P71ItemPassiveEthereal002 = SnoData.Powers.GetBySno(485653u);
		Generic_P71ItemPassiveEthereal003 = SnoData.Powers.GetBySno(485637u);
		Generic_P71ItemPassiveEthereal004 = SnoData.Powers.GetBySno(485646u);
		Generic_P71ItemPassiveEthereal005 = SnoData.Powers.GetBySno(485649u);
		Generic_P71ItemPassiveEthereal006 = SnoData.Powers.GetBySno(485654u);
		Generic_P71ItemPassiveEthereal007 = SnoData.Powers.GetBySno(485655u);
		Generic_P71ItemPassiveEthereal008 = SnoData.Powers.GetBySno(485656u);
		Generic_P71ItemPassiveEthereal009 = SnoData.Powers.GetBySno(485702u);
		Generic_P71ItemPassiveEthereal010 = SnoData.Powers.GetBySno(485706u);
		Generic_P71ItemPassiveEthereal011 = SnoData.Powers.GetBySno(485707u);
		Generic_P71ItemPassiveEthereal012 = SnoData.Powers.GetBySno(485708u);
		Generic_P71ItemPassiveEthereal013 = SnoData.Powers.GetBySno(485712u);
		Generic_P71ItemPassiveEthereal014 = SnoData.Powers.GetBySno(485713u);
		Generic_P71ItemPassiveEthereal015 = SnoData.Powers.GetBySno(485714u);
		Generic_P71ItemPassiveEthereal016 = SnoData.Powers.GetBySno(485715u);
		Generic_P71ItemPassiveEthereal017 = SnoData.Powers.GetBySno(485716u);
		Generic_P71ItemPassiveEthereal018 = SnoData.Powers.GetBySno(485717u);
		Generic_P71ItemPassiveEthereal019 = SnoData.Powers.GetBySno(485718u);
		Generic_P71ItemPassiveEthereal020 = SnoData.Powers.GetBySno(486067u);
		Generic_P71ItemPassiveEthereal021 = SnoData.Powers.GetBySno(486068u);
		Generic_P71ItemPassiveEthereal022 = SnoData.Powers.GetBySno(486069u);
		Generic_P71ItemPassiveEthereal023 = SnoData.Powers.GetBySno(486070u);
		Generic_P71ItemPassiveEthereal024 = SnoData.Powers.GetBySno(486071u);
		Generic_P71ItemPassiveEthereal025 = SnoData.Powers.GetBySno(486072u);
		Generic_P71ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(485711u);
		Generic_P72ItemPassiveSoulshard002 = SnoData.Powers.GetBySno(486127u);
		Generic_P72ItemPassiveSoulshard003 = SnoData.Powers.GetBySno(486128u);
		Generic_P72ItemPassiveSoulshard004 = SnoData.Powers.GetBySno(486130u);
		Generic_P72ItemPassiveSoulshard006 = SnoData.Powers.GetBySno(486174u);
		Generic_P72ItemPassiveSoulshard007 = SnoData.Powers.GetBySno(486175u);
		Generic_P72ItemPassiveSoulshard008 = SnoData.Powers.GetBySno(486219u);
		Generic_P72ItemPassiveSoulshard010 = SnoData.Powers.GetBySno(486179u);
		Generic_P72ItemPassiveSoulshard011 = SnoData.Powers.GetBySno(486180u);
		Generic_P72ItemPassiveSoulshard012 = SnoData.Powers.GetBySno(486181u);
		Generic_P72ItemPassiveSoulshard014 = SnoData.Powers.GetBySno(486185u);
		Generic_P72ItemPassiveSoulshard015 = SnoData.Powers.GetBySno(486186u);
		Generic_P72ItemPassiveSoulshard016 = SnoData.Powers.GetBySno(486187u);
		Generic_P72ItemPassiveSoulshard018 = SnoData.Powers.GetBySno(486199u);
		Generic_P72ItemPassiveSoulshard019 = SnoData.Powers.GetBySno(486200u);
		Generic_P72ItemPassiveSoulshard020 = SnoData.Powers.GetBySno(486201u);
		Generic_P72ItemPassiveSoulshard022 = SnoData.Powers.GetBySno(486214u);
		Generic_P72ItemPassiveSoulshard023 = SnoData.Powers.GetBySno(486215u);
		Generic_P72ItemPassiveSoulshard024 = SnoData.Powers.GetBySno(486216u);
		Generic_P72ItemPassiveSoulshard026 = SnoData.Powers.GetBySno(486210u);
		Generic_P72ItemPassiveSoulshard027 = SnoData.Powers.GetBySno(486211u);
		Generic_P72ItemPassiveSoulshard028 = SnoData.Powers.GetBySno(486212u);
		Generic_P72ItemPassiveSoulshard029 = SnoData.Powers.GetBySno(486252u);
		Generic_P72ItemPassiveUniqueRing005 = SnoData.Powers.GetBySno(486176u);
		Generic_P72ItemPassiveUniqueRing006 = SnoData.Powers.GetBySno(486177u);
		Generic_P73ExplodingLunaticSuicide = SnoData.Powers.GetBySno(487504u);
		Generic_P73ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(486961u);
		Generic_P73PagesBuffDamageSwarmRift = SnoData.Powers.GetBySno(486865u);
		Generic_P73PagesBuffElectrifiedCastSwarmRift = SnoData.Powers.GetBySno(486863u);
		Generic_P73PagesBuffRunSpeed = SnoData.Powers.GetBySno(487614u);
		Generic_P73PagesBuffRunSpeedKnockbackCast = SnoData.Powers.GetBySno(487615u);
		Generic_P73PagesBuffRunSpeedWallerCast = SnoData.Powers.GetBySno(487617u);
		Generic_P73PagesBuffRunSpeedWallerCastUpgrade = SnoData.Powers.GetBySno(487616u);
		Generic_P73ShrineDesecratedtreasureGoblin = SnoData.Powers.GetBySno(487311u);
		Generic_P73SwarmRiftCloneDeathExplosionAffix = SnoData.Powers.GetBySno(486918u);
		Generic_P73SwarmRiftGreenMeteors = SnoData.Powers.GetBySno(487303u);
		Generic_P73SwarmRiftLunaticMolten = SnoData.Powers.GetBySno(487503u);
		Generic_P73SwarmRiftPagesBuffElectrifiedTieredRift = SnoData.Powers.GetBySno(486873u);
		Generic_P73SwarmRiftPagesBuffInfiniteCasting = SnoData.Powers.GetBySno(486868u);
		Generic_p73SwarmRiftSummon = SnoData.Powers.GetBySno(487273u);
		Generic_P74GargantuanWormwoodSeasonTheme = SnoData.Powers.GetBySno(487795u);
		Generic_P74ItemPassiveSeasonTheme001 = SnoData.Powers.GetBySno(487688u);
		Generic_P74ItemPassiveSeasonTheme002 = SnoData.Powers.GetBySno(487689u);
		Generic_P74ItemPassiveSeasonTheme003 = SnoData.Powers.GetBySno(487690u);
		Generic_P74ItemPassiveSeasonTheme004 = SnoData.Powers.GetBySno(487691u);
		Generic_P74ItemPassiveSeasonTheme005 = SnoData.Powers.GetBySno(487692u);
		Generic_P74ItemPassiveSeasonTheme006 = SnoData.Powers.GetBySno(487693u);
		Generic_P74ItemPassiveSeasonTheme007 = SnoData.Powers.GetBySno(487694u);
		Generic_P74ItemPassiveSeasonTheme008 = SnoData.Powers.GetBySno(487695u);
		Generic_P74ItemPassiveSeasonTheme009 = SnoData.Powers.GetBySno(487696u);
		Generic_P74ItemPassiveSeasonTheme010 = SnoData.Powers.GetBySno(487708u);
		Generic_P74ItemPassiveSeasonTheme011 = SnoData.Powers.GetBySno(487710u);
		Generic_P74ItemPassiveSeasonTheme012 = SnoData.Powers.GetBySno(487712u);
		Generic_P74ItemPassiveSeasonTheme013 = SnoData.Powers.GetBySno(487725u);
		Generic_P74ItemPassiveSeasonTheme014 = SnoData.Powers.GetBySno(487781u);
		Generic_P74ItemPassiveSeasonTheme015 = SnoData.Powers.GetBySno(487787u);
		Generic_P74ItemPassiveSeasonTheme016 = SnoData.Powers.GetBySno(487789u);
		Generic_P74ItemPassiveSeasonTheme017 = SnoData.Powers.GetBySno(487790u);
		Generic_P74ItemPassiveSeasonTheme018 = SnoData.Powers.GetBySno(487794u);
		Generic_P74ItemPassiveSeasonTheme019 = SnoData.Powers.GetBySno(487800u);
		Generic_P74ItemPassiveSeasonTheme020 = SnoData.Powers.GetBySno(487820u);
		Generic_P74ItemPassiveSeasonTheme021 = SnoData.Powers.GetBySno(487821u);
		Generic_P74ItemPassiveUniqueRing004 = SnoData.Powers.GetBySno(487654u);
		Generic_P74ItemPassiveUniqueRing006 = SnoData.Powers.GetBySno(487687u);
		Generic_P74ItemPassiveUniqueRing007 = SnoData.Powers.GetBySno(487706u);
		Generic_P74ItemPassiveUniqueRing009 = SnoData.Powers.GetBySno(487788u);
		Generic_P74ItemPassiveUniqueRing012 = SnoData.Powers.GetBySno(487799u);
		Generic_P74ItemPassiveUniqueRing014 = SnoData.Powers.GetBySno(487929u);
		Generic_P74NecroGolemDevourAura = SnoData.Powers.GetBySno(487646u);
		Generic_P75ItemPassiveDarkAlchemyMinor018AIPetPickup = SnoData.Powers.GetBySno(488085u);
		Generic_P75ItemPassiveDarkAlchemyMinor021AIPetPickup = SnoData.Powers.GetBySno(488086u);
		Generic_P75ItemPassiveDarkAlchemySeal001 = SnoData.Powers.GetBySno(488136u);
		Generic_P75ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(488007u);
		Generic_P75ItemPassiveUniqueRing006 = SnoData.Powers.GetBySno(488040u);
		Generic_P75PagesBuffDamageDarkAlchemy = SnoData.Powers.GetBySno(488072u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Alcarnus = SnoData.Powers.GetBySno(488780u);
		Generic_P76ItemPassiveNestingWorldSpawnP76BloodPit = SnoData.Powers.GetBySno(488694u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Bog = SnoData.Powers.GetBySno(488881u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Boneyard = SnoData.Powers.GetBySno(488737u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Church = SnoData.Powers.GetBySno(488779u);
		Generic_P76ItemPassiveNestingWorldSpawnP76ForestTower = SnoData.Powers.GetBySno(488803u);
		Generic_P76ItemPassiveNestingWorldSpawnP76GideonsCourt = SnoData.Powers.GetBySno(488883u);
		Generic_P76ItemPassiveNestingWorldSpawnP76GravyardAct1 = SnoData.Powers.GetBySno(488682u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Hell = SnoData.Powers.GetBySno(488882u);
		Generic_P76ItemPassiveNestingWorldSpawnP76MoorsSacrifice = SnoData.Powers.GetBySno(488723u);
		Generic_P76ItemPassiveNestingWorldSpawnP76NewTristram = SnoData.Powers.GetBySno(488542u);
		Generic_P76ItemPassiveNestingWorldSpawnP76OldTristram = SnoData.Powers.GetBySno(488543u);
		Generic_P76ItemPassiveNestingWorldSpawnP76PandBatteringRam = SnoData.Powers.GetBySno(488886u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Sescheron = SnoData.Powers.GetBySno(488804u);
		Generic_P76ItemPassiveNestingWorldSpawnP76Spire = SnoData.Powers.GetBySno(488884u);
		Generic_P76ItemPassiveSpawnChest001 = SnoData.Powers.GetBySno(488557u);
		Generic_P7ItemPassiveUniqueRing001 = SnoData.Powers.GetBySno(485318u);
		Generic_P7ItemPassiveUniqueRing002 = SnoData.Powers.GetBySno(485549u);
		Generic_P7ItemPassiveUniqueRing003 = SnoData.Powers.GetBySno(485333u);
		Generic_PagesBuffDamage = SnoData.Powers.GetBySno(262935u);
		Generic_PagesBuffElectrified = SnoData.Powers.GetBySno(263029u);
		Generic_PagesBuffElectrifiedCast = SnoData.Powers.GetBySno(340227u);
		Generic_PagesBuffElectrifiedCastTieredRift = SnoData.Powers.GetBySno(398655u);
		Generic_PagesBuffElectrifiedTieredRift = SnoData.Powers.GetBySno(403404u);
		Generic_PagesBuffInfiniteCasting = SnoData.Powers.GetBySno(266258u);
		Generic_PagesBuffInvulnerable = SnoData.Powers.GetBySno(266254u);
		Generic_PagesBuffInvulnerableCastv2 = SnoData.Powers.GetBySno(428595u);
		Generic_PagesBuffRunSpeed = SnoData.Powers.GetBySno(266271u);
		Generic_PagesBuffRunSpeedKnockbackCast = SnoData.Powers.GetBySno(428605u);
		Generic_PagesBuffRunSpeedWallerCast = SnoData.Powers.GetBySno(428607u);
		Generic_PagesBuffRunSpeedWallerCastUpgrade = SnoData.Powers.GetBySno(483646u);
		Generic_PandemoniumPortal = SnoData.Powers.GetBySno(257036u);
		Generic_PandemoniumPortalDiablo = SnoData.Powers.GetBySno(366954u);
		Generic_PandemoniumPortalghom = SnoData.Powers.GetBySno(366951u);
		Generic_PandemoniumPortalSiegeBreaker = SnoData.Powers.GetBySno(366953u);
		Generic_PandemoniumPortalSkeletonKing = SnoData.Powers.GetBySno(366950u);
		Generic_PassiveChallengeRift = SnoData.Powers.GetBySno(460197u);
		Generic_PassiveSetDungeon = SnoData.Powers.GetBySno(474206u);
		Generic_PickupNearby = SnoData.Powers.GetBySno(131976u);
		Generic_PlagueOfToadsKnockback = SnoData.Powers.GetBySno(147876u);
		Generic_PlayerUpscaledBuff = SnoData.Powers.GetBySno(375617u);
		Generic_ProxyDelayedPower = SnoData.Powers.GetBySno(30385u);
		Generic_Punch = SnoData.Powers.GetBySno(30391u);
		Generic_PVPBuff = SnoData.Powers.GetBySno(97359u);
		Generic_PVPcontrolpoint = SnoData.Powers.GetBySno(265723u);
		Generic_PvPDamageBuff = SnoData.Powers.GetBySno(202701u);
		Generic_PvPDeathstreakBuff = SnoData.Powers.GetBySno(203535u);
		Generic_PvPHealingMacguffin = SnoData.Powers.GetBySno(222243u);
		Generic_PVPhill = SnoData.Powers.GetBySno(267462u);
		Generic_PvPHunterBuff = SnoData.Powers.GetBySno(404985u);
		Generic_PvPLevelEqualizerBuff = SnoData.Powers.GetBySno(234527u);
		Generic_PVPPeanutNeutralObjective = SnoData.Powers.GetBySno(276837u);
		Generic_PvPRangedProjectile = SnoData.Powers.GetBySno(1749u);
		Generic_PVPRoundEndBuff = SnoData.Powers.GetBySno(170408u);
		Generic_PVPShrineMurderball = SnoData.Powers.GetBySno(275730u);
		Generic_PVPSkirmishBuff = SnoData.Powers.GetBySno(96719u);
		Generic_PVPspawnersetup = SnoData.Powers.GetBySno(268588u);
		Generic_PVPspawnerTowerDefenders = SnoData.Powers.GetBySno(272501u);
		Generic_PVPStationaryattack = SnoData.Powers.GetBySno(274304u);
		Generic_PVPThreeControlSpawnDefenders = SnoData.Powers.GetBySno(276805u);
		Generic_pxBoneyardsCampSnakemanSpawner = SnoData.Powers.GetBySno(432968u);
		Generic_pxbountytestchaosportalssummonChampion = SnoData.Powers.GetBySno(430626u);
		Generic_pxBridgeCampDemonSpawner = SnoData.Powers.GetBySno(433224u);
		Generic_pxCampPortalSpawner = SnoData.Powers.GetBySno(434337u);
		Generic_pxCraterCampDemonSpawner = SnoData.Powers.GetBySno(433300u);
		Generic_pxFesteringWoodsCampGhoulSpawner = SnoData.Powers.GetBySno(432385u);
		Generic_pxGardensOfHopeCampDemonSpawner = SnoData.Powers.GetBySno(433137u);
		Generic_pxGraveyardCampReaperSpawner = SnoData.Powers.GetBySno(433338u);
		Generic_pxHighlandsCampCultistSpawner = SnoData.Powers.GetBySno(432262u);
		Generic_pxLeoricsDungeonCampDemonSpawner = SnoData.Powers.GetBySno(434382u);
		Generic_pxOasisCampSnakemanSpawner = SnoData.Powers.GetBySno(432336u);
		Generic_pxQuestFollowerDamageSetup = SnoData.Powers.GetBySno(432327u);
		Generic_pxRampartsCampDemonSpawner = SnoData.Powers.GetBySno(433391u);
		Generic_pxRuinsFrostKingKanaiWhirlwind = SnoData.Powers.GetBySno(436329u);
		Generic_pxRuinsFrostThreeGuardiansGoatmanLeap = SnoData.Powers.GetBySno(434813u);
		Generic_pxSpiderCavesCampCocoonHumanVictim = SnoData.Powers.GetBySno(432781u);
		Generic_pxSpiderCavesCampSpiderSpawner = SnoData.Powers.GetBySno(432782u);
		Generic_pxSpireCampDemonSpawner = SnoData.Powers.GetBySno(433421u);
		Generic_pxStingingWindsCampCultistSpawner = SnoData.Powers.GetBySno(433057u);
		Generic_pxWestmarchCampReaperSpawner = SnoData.Powers.GetBySno(433254u);
		Generic_pxWildernessCampTemplarSpawner = SnoData.Powers.GetBySno(430766u);
		Generic_QuestCanyonBridgeEnchantressRevealFootsteps = SnoData.Powers.GetBySno(103338u);
		Generic_QuestCanyonBridgePlayerRevealFootsteps = SnoData.Powers.GetBySno(103337u);
		Generic_QuillDemonProjectile = SnoData.Powers.GetBySno(107729u);
		Generic_QuillDemonProjectileFastAttack = SnoData.Powers.GetBySno(364571u);
		Generic_RandomMovespeedScripted = SnoData.Powers.GetBySno(367779u);
		Generic_RangedEscortProjectile = SnoData.Powers.GetBySno(30394u);
		Generic_RatKingLifetimeBuff = SnoData.Powers.GetBySno(440699u);
		Generic_RedWingsBuff = SnoData.Powers.GetBySno(317139u);
		Generic_RemoveBurrowEffect = SnoData.Powers.GetBySno(30420u);
		Generic_ResurrectFallen = SnoData.Powers.GetBySno(30422u);
		Generic_ResurrectionBuff = SnoData.Powers.GetBySno(30424u);
		Generic_RockwormAttack = SnoData.Powers.GetBySno(30426u);
		Generic_RockwormBurrowAndTeleport = SnoData.Powers.GetBySno(330606u);
		Generic_RockwormBurstOut = SnoData.Powers.GetBySno(30427u);
		Generic_RockwormGrab = SnoData.Powers.GetBySno(219076u);
		Generic_RockwormGrabBurstOut = SnoData.Powers.GetBySno(230406u);
		Generic_RockwormHideIdle = SnoData.Powers.GetBySno(30428u);
		Generic_RockwormPreBurst = SnoData.Powers.GetBySno(30429u);
		Generic_RockwormRetreat = SnoData.Powers.GetBySno(30430u);
		Generic_RockwormWeb = SnoData.Powers.GetBySno(30431u);
		Generic_RootTryGrab = SnoData.Powers.GetBySno(30433u);
		Generic_SandMonsterBurrowOut = SnoData.Powers.GetBySno(213730u);
		Generic_SandMonsterBurrowOutLong = SnoData.Powers.GetBySno(59308u);
		Generic_SandMonsterSandWall = SnoData.Powers.GetBySno(30438u);
		Generic_SandmonsterWeaponMeleeInstant = SnoData.Powers.GetBySno(223914u);
		Generic_SandsharkBurrowIn = SnoData.Powers.GetBySno(30440u);
		Generic_SandsharkBurrowOut = SnoData.Powers.GetBySno(30441u);
		Generic_SandTornadoOnSpawn = SnoData.Powers.GetBySno(30448u);
		Generic_SandWaspProjectile = SnoData.Powers.GetBySno(30449u);
		Generic_ScavengerBurrowIn = SnoData.Powers.GetBySno(30450u);
		Generic_ScavengerBurrowOut = SnoData.Powers.GetBySno(30451u);
		Generic_ScavengerLeap = SnoData.Powers.GetBySno(1752u);
		Generic_ScoundrelAnatomy = SnoData.Powers.GetBySno(30454u);
		Generic_ScoundrelBandage = SnoData.Powers.GetBySno(30455u);
		Generic_ScoundrelCheatDeathPassive = SnoData.Powers.GetBySno(485531u);
		Generic_ScoundrelCripplingShot = SnoData.Powers.GetBySno(95675u);
		Generic_ScoundrelDebuffCloud = SnoData.Powers.GetBySno(484974u);
		Generic_ScoundrelHysteria = SnoData.Powers.GetBySno(200169u);
		Generic_ScoundrelPiercingShot = SnoData.Powers.GetBySno(485334u);
		Generic_ScoundrelPowerShot = SnoData.Powers.GetBySno(95690u);
		Generic_ScoundrelRangedProjectile = SnoData.Powers.GetBySno(99902u);
		Generic_ScoundrelRunAway = SnoData.Powers.GetBySno(99904u);
		Generic_ScoundrelVanishV2 = SnoData.Powers.GetBySno(485336u);
		Generic_ScrollBuff = SnoData.Powers.GetBySno(30469u);
		Generic_SeasonThemeBarbarianWhirlwind = SnoData.Powers.GetBySno(484654u);
		Generic_SelectingSkill = SnoData.Powers.GetBySno(217340u);
		Generic_SetItemBonusBuff = SnoData.Powers.GetBySno(123014u);
		Generic_SetModeEscortFollow = SnoData.Powers.GetBySno(30471u);
		Generic_ShieldSkeletonShield = SnoData.Powers.GetBySno(30473u);
		Generic_ShrineCallMonster = SnoData.Powers.GetBySno(213187u);
		Generic_ShrineDesecratedBlessed = SnoData.Powers.GetBySno(30476u);
		Generic_ShrineDesecratedEnlightened = SnoData.Powers.GetBySno(30477u);
		Generic_ShrineDesecratedFortune = SnoData.Powers.GetBySno(30478u);
		Generic_ShrineDesecratedFrenzied = SnoData.Powers.GetBySno(30479u);
		Generic_ShrineDesecratedHoarder = SnoData.Powers.GetBySno(260348u);
		Generic_ShrineDesecratedReloaded = SnoData.Powers.GetBySno(260349u);
		Generic_ShrineDesecratedtreasureGoblin = SnoData.Powers.GetBySno(269350u);
		Generic_ShrinePowerBlessed = SnoData.Powers.GetBySno(278268u);
		Generic_ShrinePowerEnlightened = SnoData.Powers.GetBySno(278269u);
		Generic_ShrinePowerFortune = SnoData.Powers.GetBySno(278270u);
		Generic_ShrinePowerFrenzied = SnoData.Powers.GetBySno(278271u);
		Generic_SidekickStatsBoostBuff = SnoData.Powers.GetBySno(377314u);
		Generic_SidekickWeaponDamageBoostBuff = SnoData.Powers.GetBySno(377413u);
		Generic_SiegebreakerDemonBite = SnoData.Powers.GetBySno(30482u);
		Generic_SiegebreakerDemonCharge = SnoData.Powers.GetBySno(30484u);
		Generic_SiegebreakerDemonChargeNew = SnoData.Powers.GetBySno(182586u);
		Generic_SiegebreakerDemonGrab = SnoData.Powers.GetBySno(30487u);
		Generic_SiegebreakerDemonGrabToBite = SnoData.Powers.GetBySno(30488u);
		Generic_SiegebreakerDemonLookAround = SnoData.Powers.GetBySno(1754u);
		Generic_SiegebreakerDemonMiniCharge = SnoData.Powers.GetBySno(30490u);
		Generic_SiegebreakerDemonPound = SnoData.Powers.GetBySno(30491u);
		Generic_SiegebreakerDemonRoar = SnoData.Powers.GetBySno(228688u);
		Generic_SiegebreakerDemonStomp = SnoData.Powers.GetBySno(30492u);
		Generic_SiegebreakerEnrage = SnoData.Powers.GetBySno(240529u);
		Generic_SiegeBreakerReflectsDamageCast = SnoData.Powers.GetBySno(376912u);
		Generic_SkeletonArcherProjectile = SnoData.Powers.GetBySno(30495u);
		Generic_SkeletonKingCleave = SnoData.Powers.GetBySno(30504u);
		Generic_SkeletonKingSummonSkeleton = SnoData.Powers.GetBySno(30496u);
		Generic_SkeletonKingTeleport = SnoData.Powers.GetBySno(79334u);
		Generic_SkeletonKingTeleportAway = SnoData.Powers.GetBySno(81504u);
		Generic_SkeletonKingWhirlwind = SnoData.Powers.GetBySno(73824u);
		Generic_skeletonMageColdprojectile = SnoData.Powers.GetBySno(30497u);
		Generic_skeletonMageFireAOE = SnoData.Powers.GetBySno(30498u);
		Generic_skeletonMageFireprojectile = SnoData.Powers.GetBySno(30499u);
		Generic_skeletonMageLightningpierce = SnoData.Powers.GetBySno(30500u);
		Generic_skeletonMagepoisondeath = SnoData.Powers.GetBySno(30501u);
		Generic_skeletonMagePoisonpierce = SnoData.Powers.GetBySno(30502u);
		Generic_SkeletonSummonerProjectile = SnoData.Powers.GetBySno(30503u);
		Generic_SkillOverrideStartedOrEnded = SnoData.Powers.GetBySno(221275u);
		Generic_SnakemanCasterElectricBurst = SnoData.Powers.GetBySno(30509u);
		Generic_SnakemanMeleeStealth = SnoData.Powers.GetBySno(30512u);
		Generic_SnakemanMeleeUnstealth = SnoData.Powers.GetBySno(30513u);
		Generic_SoaringAscend = SnoData.Powers.GetBySno(69743u);
		Generic_SoaringDescend = SnoData.Powers.GetBySno(54196u);
		Generic_SoulRipperDespairTongueLash = SnoData.Powers.GetBySno(226572u);
		Generic_SoulRipperTongueLash = SnoData.Powers.GetBySno(145822u);
		Generic_SpiderQueenVomitSpidersCharge = SnoData.Powers.GetBySno(151219u);
		Generic_SpiderQueenVomitSpidersVomit = SnoData.Powers.GetBySno(151516u);
		Generic_SpiderQueenWebSpit = SnoData.Powers.GetBySno(151218u);
		Generic_SpiderSprintThroughObjectsTo = SnoData.Powers.GetBySno(137642u);
		Generic_SpiderWebImmobolize = SnoData.Powers.GetBySno(30518u);
		Generic_SpiderWebSlow = SnoData.Powers.GetBySno(76961u);
		Generic_SpiderWebSlowSpit = SnoData.Powers.GetBySno(76951u);
		Generic_SplashDamageProc = SnoData.Powers.GetBySno(376298u);
		Generic_SporeCloud = SnoData.Powers.GetBySno(30525u);
		Generic_StealthBuff = SnoData.Powers.GetBySno(30527u);
		Generic_StitchExplode = SnoData.Powers.GetBySno(30529u);
		Generic_StitchMeleeAlternate = SnoData.Powers.GetBySno(30530u);
		Generic_StitchPush = SnoData.Powers.GetBySno(30531u);
		Generic_SuccubusBloodStar = SnoData.Powers.GetBySno(120874u);
		Generic_SuccubusBloodStarLR = SnoData.Powers.GetBySno(366103u);
		Generic_SuccubusFly = SnoData.Powers.GetBySno(136508u);
		Generic_SuccubusLeap = SnoData.Powers.GetBySno(120875u);
		Generic_SuicideProc = SnoData.Powers.GetBySno(30538u);
		Generic_SuicideScripted = SnoData.Powers.GetBySno(369834u);
		Generic_Summoned = SnoData.Powers.GetBySno(30540u);
		Generic_SummonFallenAUnique01 = SnoData.Powers.GetBySno(166154u);
		Generic_SummonFallenOnSpawn = SnoData.Powers.GetBySno(30541u);
		Generic_SummoningMachineSummon = SnoData.Powers.GetBySno(117580u);
		Generic_SummonSkeleton = SnoData.Powers.GetBySno(30543u);
		Generic_SummonSkeletonJondar = SnoData.Powers.GetBySno(168212u);
		Generic_SummonSkeletonOnSpawn = SnoData.Powers.GetBySno(30545u);
		Generic_SummonSkeletonOrb = SnoData.Powers.GetBySno(30546u);
		Generic_SummonSkeletonPillar = SnoData.Powers.GetBySno(1757u);
		Generic_SummonTriuneDemon = SnoData.Powers.GetBySno(30547u);
		Generic_SummonZombieCrawler = SnoData.Powers.GetBySno(30550u);
		Generic_SummonZombieVomit = SnoData.Powers.GetBySno(94734u);
		Generic_Swarmdeath = SnoData.Powers.GetBySno(128729u);
		Generic_TarPitSlowOff = SnoData.Powers.GetBySno(67110u);
		Generic_TarPitSlowOn = SnoData.Powers.GetBySno(67106u);
		Generic_TauntedMonsterRangedProjectile = SnoData.Powers.GetBySno(212952u);
		Generic_TauntedWeaponMeleeInstant = SnoData.Powers.GetBySno(212953u);
		Generic_TeleportCheckPathPassability = SnoData.Powers.GetBySno(290885u);
		Generic_TeleportToPlayer = SnoData.Powers.GetBySno(318242u);
		Generic_TeleportToPlayerCast = SnoData.Powers.GetBySno(371139u);
		Generic_TeleportToWaypoint = SnoData.Powers.GetBySno(349060u);
		Generic_TeleportToWaypointCast = SnoData.Powers.GetBySno(371141u);
		Generic_TemplarCheatDeathPassive = SnoData.Powers.GetBySno(485532u);
		Generic_TemplarGuardianV2 = SnoData.Powers.GetBySno(485511u);
		Generic_TemplarHeal110 = SnoData.Powers.GetBySno(257640u);
		Generic_TemplarInspire = SnoData.Powers.GetBySno(30356u);
		Generic_TemplarIntervene = SnoData.Powers.GetBySno(93938u);
		Generic_TemplarInterveneProc = SnoData.Powers.GetBySno(94008u);
		Generic_TemplarIntimidate = SnoData.Powers.GetBySno(93901u);
		Generic_TemplarLoyalty = SnoData.Powers.GetBySno(30357u);
		Generic_TemplarMeleeInstant = SnoData.Powers.GetBySno(230239u);
		Generic_TemplarOnslaught = SnoData.Powers.GetBySno(93888u);
		Generic_TemplarOnslaughtV2 = SnoData.Powers.GetBySno(485345u);
		Generic_TemplarShieldCharge = SnoData.Powers.GetBySno(30360u);
		Generic_TentacleHorseAUnique01Charge = SnoData.Powers.GetBySno(209509u);
		Generic_TerrorDemonMeleeStrike = SnoData.Powers.GetBySno(123907u);
		Generic_TerrorDemonShadowPhase = SnoData.Powers.GetBySno(123935u);
		Generic_TerrorDemonShadowPhaseEnd = SnoData.Powers.GetBySno(123964u);
		Generic_TestSpikeTrapRuins = SnoData.Powers.GetBySno(409416u);
		Generic_Thorns = SnoData.Powers.GetBySno(30554u);
		Generic_ThousandPounderKnockback = SnoData.Powers.GetBySno(30557u);
		Generic_ThousandPounderMelee = SnoData.Powers.GetBySno(439350u);
		Generic_tongueprototype = SnoData.Powers.GetBySno(86990u);
		Generic_TraitBarbarianFury = SnoData.Powers.GetBySno(30078u);
		Generic_TraitMonkSpirit = SnoData.Powers.GetBySno(52753u);
		Generic_TransformToActivatedTriune = SnoData.Powers.GetBySno(30563u);
		Generic_trDunCathWallCollapseDamage = SnoData.Powers.GetBySno(186216u);
		Generic_trDunCathWallCollapseDamageoffset = SnoData.Powers.GetBySno(227949u);
		Generic_TreasureGoblinAnniversaryEscape = SnoData.Powers.GetBySno(434749u);
		Generic_TreasureGoblinAnniversaryThrowPortal = SnoData.Powers.GetBySno(434776u);
		Generic_TreasureGoblinEscape = SnoData.Powers.GetBySno(105371u);
		Generic_TreasureGoblinPause = SnoData.Powers.GetBySno(54055u);
		Generic_TreasureGoblinPlayAlertSound = SnoData.Powers.GetBySno(260595u);
		Generic_TreasureGoblinPortalIn = SnoData.Powers.GetBySno(408659u);
		Generic_TreasureGoblinThrowPortal = SnoData.Powers.GetBySno(54836u);
		Generic_TreasureGoblinThrowPortalBackup = SnoData.Powers.GetBySno(432643u);
		Generic_TreasureGoblinThrowPortalFast = SnoData.Powers.GetBySno(105665u);
		Generic_TreasureGoblinUsePortal = SnoData.Powers.GetBySno(54866u);
		Generic_TriuneBerserkerPowerHit = SnoData.Powers.GetBySno(30567u);
		Generic_TriuneSummonerProjectile = SnoData.Powers.GetBySno(30570u);
		Generic_TriuneSummonerShield = SnoData.Powers.GetBySno(30571u);
		Generic_TriuneSummonerSplitSummonCast = SnoData.Powers.GetBySno(30572u);
		Generic_TriuneVesselCharge = SnoData.Powers.GetBySno(30573u);
		Generic_TriuneVesselOverpower = SnoData.Powers.GetBySno(30574u);
		Generic_trOutLogStackShortDamage = SnoData.Powers.GetBySno(186138u);
		Generic_trOutLogStackTrap = SnoData.Powers.GetBySno(100287u);
		Generic_trouttristramfieldspunjitrapaoe = SnoData.Powers.GetBySno(91261u);
		Generic_trouttristramfieldspunjitrapmirroraoe = SnoData.Powers.GetBySno(95387u);
		Generic_UberDespairMeleeCleave = SnoData.Powers.GetBySno(260844u);
		Generic_UberDespairSummonMinion = SnoData.Powers.GetBySno(257950u);
		Generic_UberDespairSummonMinionDiablo = SnoData.Powers.GetBySno(375537u);
		Generic_UberDespairTeleport = SnoData.Powers.GetBySno(260845u);
		Generic_UberDespairTeleportEnrageDiablo = SnoData.Powers.GetBySno(376039u);
		Generic_UberDespairVolley = SnoData.Powers.GetBySno(260847u);
		Generic_UberDespairVolleyDiablo = SnoData.Powers.GetBySno(376056u);
		Generic_UberDiabloMirrorImage = SnoData.Powers.GetBySno(375929u);
		Generic_UberDiabloStompAndStun = SnoData.Powers.GetBySno(365978u);
		Generic_UberGluttonyBreathAttack = SnoData.Powers.GetBySno(260848u);
		Generic_UberGluttonyGasCloud = SnoData.Powers.GetBySno(260849u);
		Generic_UberGluttonyGasCloudDiablo = SnoData.Powers.GetBySno(376396u);
		Generic_UberGluttonyLoogiespawn = SnoData.Powers.GetBySno(257951u);
		Generic_UberMaghdaMothDust = SnoData.Powers.GetBySno(278341u);
		Generic_UberMaghdaPunish = SnoData.Powers.GetBySno(260976u);
		Generic_UberMaghdaPunishShielded = SnoData.Powers.GetBySno(260977u);
		Generic_UberMaghdaSummonBeserker = SnoData.Powers.GetBySno(257952u);
		Generic_UberMaghdaSummonBeserkerDiablo = SnoData.Powers.GetBySno(375493u);
		Generic_UberSiegebreakerDemonPound = SnoData.Powers.GetBySno(259946u);
		Generic_UberSiegebreakerDemonStomp = SnoData.Powers.GetBySno(258635u);
		Generic_UberSkeletonKingCleave = SnoData.Powers.GetBySno(258636u);
		Generic_UberSkeletonKingSummonSkeleton = SnoData.Powers.GetBySno(256110u);
		Generic_UberSkeletonKingSummonSkeletonDiablo = SnoData.Powers.GetBySno(375473u);
		Generic_UberSkeletonKingWhirlwind = SnoData.Powers.GetBySno(258637u);
		Generic_UberZoltunKulleCollapseCeiling = SnoData.Powers.GetBySno(260851u);
		Generic_UberZoltunKulleEnergyTwister = SnoData.Powers.GetBySno(260852u);
		Generic_UberZoltunKulleFieryBoulder = SnoData.Powers.GetBySno(260853u);
		Generic_UberZoltunKulleSlowTime = SnoData.Powers.GetBySno(259947u);
		Generic_UberZoltunKulleSlowTimeDiablo = SnoData.Powers.GetBySno(376043u);
		Generic_UberZoltunKulleTeleport = SnoData.Powers.GetBySno(258638u);
		Generic_UnburiedBossCleave = SnoData.Powers.GetBySno(93715u);
		Generic_UnburiedKnockback = SnoData.Powers.GetBySno(30580u);
		Generic_UnburiedMeleeAttack = SnoData.Powers.GetBySno(30581u);
		Generic_UnburiedWreckableAttack = SnoData.Powers.GetBySno(202344u);
		Generic_UnholyShield = SnoData.Powers.GetBySno(122977u);
		Generic_UninterruptibleDuringBuff = SnoData.Powers.GetBySno(79486u);
		Generic_UniqueMonsterEarthquakePrototype = SnoData.Powers.GetBySno(256059u);
		Generic_UniqueMonsterGenericAOENova = SnoData.Powers.GetBySno(270004u);
		Generic_UniqueMonsterGenericAOERandomAroundOwner = SnoData.Powers.GetBySno(363519u);
		Generic_UniqueMonsterGenericAOETargeted = SnoData.Powers.GetBySno(270040u);
		Generic_UniqueMonsterGenericProjectile = SnoData.Powers.GetBySno(152540u);
		Generic_UniqueMonsterGenericProjectile2 = SnoData.Powers.GetBySno(359684u);
		Generic_UniqueMonsterGenericProjectileAllPlayers = SnoData.Powers.GetBySno(346247u);
		Generic_UniqueMonsterGenericSummon = SnoData.Powers.GetBySno(270043u);
		Generic_UniqueMonsterGenericSummon2 = SnoData.Powers.GetBySno(359685u);
		Generic_UniqueMonsterIceTrailPassivePrototype = SnoData.Powers.GetBySno(260815u);
		Generic_UniqueMonsterTempestRushPrototype = SnoData.Powers.GetBySno(256060u);
		Generic_UntargetableDuringBuff = SnoData.Powers.GetBySno(30582u);
		Generic_UrzaelStompAndStun = SnoData.Powers.GetBySno(361300u);
		Generic_UseArcaneGlyph = SnoData.Powers.GetBySno(165553u);
		Generic_UseDungeonStone = SnoData.Powers.GetBySno(220318u);
		Generic_UseHealthGlyph = SnoData.Powers.GetBySno(30584u);
		Generic_UseItem = SnoData.Powers.GetBySno(1759u);
		Generic_UseLootRunPortal = SnoData.Powers.GetBySno(389049u);
		Generic_UseLootRunProgressGlyph = SnoData.Powers.GetBySno(404128u);
		Generic_UseManaGlyph = SnoData.Powers.GetBySno(30585u);
		Generic_UseStoneOfRecall = SnoData.Powers.GetBySno(191590u);
		Generic_Walk = SnoData.Powers.GetBySno(30588u);
		Generic_WallMonsterSpawn = SnoData.Powers.GetBySno(143063u);
		Generic_WallMonsterSpawnSiegeBreaker = SnoData.Powers.GetBySno(316261u);
		Generic_Warp = SnoData.Powers.GetBySno(30589u);
		Generic_WarpInMagical = SnoData.Powers.GetBySno(132910u);
		Generic_waterloggedCorpseEelSpawn = SnoData.Powers.GetBySno(57931u);
		Generic_waterloggedCorpsePoisonCloud = SnoData.Powers.GetBySno(57028u);
		Generic_waterTowerAOasiscaOutBreakableDamage = SnoData.Powers.GetBySno(396375u);
		Generic_WeaponMeleeInstant = SnoData.Powers.GetBySno(30592u);
		Generic_WeaponMeleeInstantBothHand = SnoData.Powers.GetBySno(30593u);
		Generic_WeaponMeleeInstantCowKing = SnoData.Powers.GetBySno(368212u);
		Generic_WeaponMeleeInstantFreezeFacing = SnoData.Powers.GetBySno(106087u);
		Generic_WeaponMeleeInstantOffHand = SnoData.Powers.GetBySno(30594u);
		Generic_WeaponMeleeInstantShortEscape = SnoData.Powers.GetBySno(263041u);
		Generic_WeaponMeleeInstantWreckables = SnoData.Powers.GetBySno(202345u);
		Generic_WeaponMeleeNoClose = SnoData.Powers.GetBySno(70218u);
		Generic_WeaponMeleeObstruction = SnoData.Powers.GetBySno(30595u);
		Generic_WeaponMeleeReachInstant = SnoData.Powers.GetBySno(30596u);
		Generic_WeaponMeleeReachInstantFreezeFacing = SnoData.Powers.GetBySno(115624u);
		Generic_WeaponRangedInstant = SnoData.Powers.GetBySno(30598u);
		Generic_WeaponRangedProjectile = SnoData.Powers.GetBySno(30599u);
		Generic_WeaponRangedWand = SnoData.Powers.GetBySno(30601u);
		Generic_WitchdoctorCorpseSpiderLeap = SnoData.Powers.GetBySno(107103u);
		Generic_WitchdoctorFetishArmyHunter = SnoData.Powers.GetBySno(119166u);
		Generic_WitchdoctorFetishArmyMelee = SnoData.Powers.GetBySno(226690u);
		Generic_WitchdoctorFetishArmyPoisonDart = SnoData.Powers.GetBySno(429477u);
		Generic_WitchdoctorFetishArmyShaman = SnoData.Powers.GetBySno(118442u);
		Generic_WitchdoctorFetishSycophantsMelee = SnoData.Powers.GetBySno(435275u);
		Generic_WitchdoctorGargantuanCleave = SnoData.Powers.GetBySno(121942u);
		Generic_WitchdoctorGargantuanPoisonCloud = SnoData.Powers.GetBySno(308827u);
		Generic_WitchdoctorGargantuanSlam = SnoData.Powers.GetBySno(121943u);
		Generic_WitchdoctorGargantuanSmash = SnoData.Powers.GetBySno(186851u);
		Generic_WitchdoctorHexChickenWalk = SnoData.Powers.GetBySno(196974u);
		Generic_WitchdoctorHexExplode = SnoData.Powers.GetBySno(188442u);
		Generic_WitchdoctorHexFetish = SnoData.Powers.GetBySno(107301u);
		Generic_WitchdoctorHexFetishHeal = SnoData.Powers.GetBySno(107742u);
		Generic_WitchdoctorPlagueOfToadsBigToadAttack = SnoData.Powers.GetBySno(106592u);
		Generic_WitchdoctorPlagueOfToadsBigToadTongueSlap = SnoData.Powers.GetBySno(220908u);
		Generic_WitchdoctorSpiritBarrageRuneCAOE = SnoData.Powers.GetBySno(186471u);
		Generic_WitchdoctorZombieDogFireAoE = SnoData.Powers.GetBySno(309100u);
		Generic_WitchdoctorZombieDogMelee = SnoData.Powers.GetBySno(226692u);
		Generic_WitchdoctorZombieDogPoisonDoT = SnoData.Powers.GetBySno(310071u);
		Generic_WizardArcaneTorrentRuneCMine = SnoData.Powers.GetBySno(165598u);
		Generic_WizardEnergyShield = SnoData.Powers.GetBySno(30708u);
		Generic_WizardHydraDefaultFirePrototype = SnoData.Powers.GetBySno(77068u);
		Generic_WizardHydraRuneAcidPrototype = SnoData.Powers.GetBySno(77066u);
		Generic_WizardHydraRuneArcanePrototype = SnoData.Powers.GetBySno(77067u);
		Generic_WizardHydraRuneBigPrototype = SnoData.Powers.GetBySno(84030u);
		Generic_WizardHydraRuneFirePrototype = SnoData.Powers.GetBySno(77063u);
		Generic_WizardHydraRuneFrostPrototype = SnoData.Powers.GetBySno(83040u);
		Generic_WizardHydraRuneLightningPrototype = SnoData.Powers.GetBySno(77065u);
		Generic_WizardMagicMissileCount = SnoData.Powers.GetBySno(30745u);
		Generic_WizardMagicMissileDamage = SnoData.Powers.GetBySno(30746u);
		Generic_WizardMagicMissileSpeed = SnoData.Powers.GetBySno(30748u);
		Generic_WoDFlagBuff = SnoData.Powers.GetBySno(375412u);
		Generic_WoodWraithSummonSpores = SnoData.Powers.GetBySno(30800u);
		Generic_WorldCreatingBuff = SnoData.Powers.GetBySno(223604u);
		Generic_x1abattoirfurnace01 = SnoData.Powers.GetBySno(324819u);
		Generic_x1AbattoirfurnaceSpinner = SnoData.Powers.GetBySno(354796u);
		Generic_x1AbattoirfurnaceSpinnerEvent = SnoData.Powers.GetBySno(359960u);
		Generic_x1AbattoirfurnaceSpinnerEventPhase1 = SnoData.Powers.GetBySno(375458u);
		Generic_x1AbattoirfurnaceSpinnerEventPhase2 = SnoData.Powers.GetBySno(375462u);
		Generic_x1AbattoirfurnaceSpinnerEventPhase3 = SnoData.Powers.GetBySno(375499u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamclockwise = SnoData.Powers.GetBySno(354856u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEvent = SnoData.Powers.GetBySno(355457u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase1 = SnoData.Powers.GetBySno(377631u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase2 = SnoData.Powers.GetBySno(377636u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase3 = SnoData.Powers.GetBySno(377641u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwise = SnoData.Powers.GetBySno(354884u);
		Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwiseEvent = SnoData.Powers.GetBySno(355458u);
		Generic_x1AbattoirfurnaceWall = SnoData.Powers.GetBySno(355369u);
		Generic_x1AdriaArenaFloorPanelFire = SnoData.Powers.GetBySno(290708u);
		Generic_x1AdriaArenaFloorPanelStart = SnoData.Powers.GetBySno(298181u);
		Generic_X1AdriaBossArenaGasOff0 = SnoData.Powers.GetBySno(340805u);
		Generic_X1AdriaBossArenaGasOff1 = SnoData.Powers.GetBySno(340806u);
		Generic_X1AdriaBossArenaGasOn0 = SnoData.Powers.GetBySno(340804u);
		Generic_X1AdriaBossArenaGasOn1 = SnoData.Powers.GetBySno(340807u);
		Generic_x1AdriaCauldronSpawnerActivate = SnoData.Powers.GetBySno(330791u);
		Generic_x1AdriaCauldronSpawnerInitialPoolsBuff = SnoData.Powers.GetBySno(358590u);
		Generic_x1AdriaCauldronSpawnerLifetimeBuff = SnoData.Powers.GetBySno(330783u);
		Generic_x1AdriaCauldronSpawnerRoomPools = SnoData.Powers.GetBySno(355825u);
		Generic_x1AdriaCauldronSpawnerRoomPoolsInner = SnoData.Powers.GetBySno(355826u);
		Generic_x1AdriaCauldronSpawnerRoomPoolsOuter = SnoData.Powers.GetBySno(355827u);
		Generic_x1AdriaDelayedTeleportAttack = SnoData.Powers.GetBySno(293152u);
		Generic_x1AdriaDelayedTeleportCauldronActivate = SnoData.Powers.GetBySno(362989u);
		Generic_x1AdriaDelayedTeleportStart = SnoData.Powers.GetBySno(293151u);
		Generic_x1AdriaJumpBack = SnoData.Powers.GetBySno(284247u);
		Generic_x1AdriaPhaseOneAIState = SnoData.Powers.GetBySno(360204u);
		Generic_x1AdriaPhaseTwoAIState = SnoData.Powers.GetBySno(360205u);
		Generic_x1AdriaScriptedSequence180Turn = SnoData.Powers.GetBySno(365720u);
		Generic_x1AdriaSpitAtPlayer = SnoData.Powers.GetBySno(359746u);
		Generic_x1AdriaWingSweepLeft = SnoData.Powers.GetBySno(354328u);
		Generic_x1AdriaWingSweepRight = SnoData.Powers.GetBySno(354340u);
		Generic_X1armorScavengerAsteroidRain = SnoData.Powers.GetBySno(341833u);
		Generic_x1armorScavengerbuff = SnoData.Powers.GetBySno(271621u);
		Generic_x1armorScavengerBurrowIn = SnoData.Powers.GetBySno(273462u);
		Generic_x1armorScavengerBurrowOut = SnoData.Powers.GetBySno(271740u);
		Generic_x1armorScavengerPreBurrow = SnoData.Powers.GetBySno(322380u);
		Generic_X1AsteroidBasic = SnoData.Powers.GetBySno(330593u);
		Generic_X1AsteroidBasicSmall = SnoData.Powers.GetBySno(442208u);
		Generic_X1AsteroidPool = SnoData.Powers.GetBySno(330129u);
		Generic_X1AsteroidSpawn = SnoData.Powers.GetBySno(292865u);
		Generic_X1BarbarianAvalanchev2Passive = SnoData.Powers.GetBySno(353458u);
		Generic_X1BloodhawkEventBallistaBossFuriousCharge = SnoData.Powers.GetBySno(364196u);
		Generic_x1bogbearTrap = SnoData.Powers.GetBySno(237495u);
		Generic_x1BogBearTrapTrigger = SnoData.Powers.GetBySno(376509u);
		Generic_x1BogBlightBurrowIn = SnoData.Powers.GetBySno(276820u);
		Generic_x1BogBlightBurrowOut = SnoData.Powers.GetBySno(276843u);
		Generic_x1BogBlightPustuleDeath = SnoData.Powers.GetBySno(341714u);
		Generic_x1BogBlightPustuleSpawn = SnoData.Powers.GetBySno(234556u);
		Generic_x1BogBlightPustuleSpawnCon = SnoData.Powers.GetBySno(399284u);
		Generic_x1BogBogWater = SnoData.Powers.GetBySno(335458u);
		Generic_x1BogBogWaterlarge = SnoData.Powers.GetBySno(335795u);
		Generic_x1BogBogWatermedium = SnoData.Powers.GetBySno(335789u);
		Generic_x1BogFamilyBruteCharge = SnoData.Powers.GetBySno(238930u);
		Generic_x1BogFamilyBruteShout = SnoData.Powers.GetBySno(239018u);
		Generic_x1BogFamilyBruteSummonMeleeAction = SnoData.Powers.GetBySno(247961u);
		Generic_x1BogFamilyBruteSummonMeleeActionUnique = SnoData.Powers.GetBySno(355511u);
		Generic_x1BogFamilyBruteThrowDude = SnoData.Powers.GetBySno(238965u);
		Generic_X1BogFamilyGuardTowerSetup = SnoData.Powers.GetBySno(339982u);
		Generic_x1BogFamilyMeleeTransform = SnoData.Powers.GetBySno(338049u);
		Generic_x1BogFamilyRangedBearTrap = SnoData.Powers.GetBySno(239743u);
		Generic_x1BogFamilyRangedBearTrapFromTower = SnoData.Powers.GetBySno(340026u);
		Generic_x1BogFamilyRangedBearTrapFromTowerReturnToFacing = SnoData.Powers.GetBySno(340041u);
		Generic_x1BogFamilyRangedRapidShot = SnoData.Powers.GetBySno(336527u);
		Generic_x1BogFamilyRangedRapidShotFromTower = SnoData.Powers.GetBySno(339985u);
		Generic_x1BogFamilyRangedRapidShotFromTowerReturnToFacing = SnoData.Powers.GetBySno(339986u);
		Generic_X1BogKingOfTheHillLeap = SnoData.Powers.GetBySno(288754u);
		Generic_x1BogPlantexplodeKnockback = SnoData.Powers.GetBySno(234539u);
		Generic_x1CatacombsDoorAonDeath = SnoData.Powers.GetBySno(263272u);
		Generic_x1CatacombsFloorRunesAonDeath = SnoData.Powers.GetBySno(267289u);
		Generic_x1CatacombsSpiritTotemactivate = SnoData.Powers.GetBySno(345943u);
		Generic_x1CesspoolSlimePosionAttack = SnoData.Powers.GetBySno(301930u);
		Generic_x1ChallengeBuffImmuneStun = SnoData.Powers.GetBySno(299410u);
		Generic_X1ChallengeLureSupersizeLure = SnoData.Powers.GetBySno(346299u);
		Generic_x1CrazedAngelArcherFireArrow = SnoData.Powers.GetBySno(366438u);
		Generic_X1CrusaderLawsOfFate = SnoData.Powers.GetBySno(290960u);
		Generic_X1CrusaderLawsOfFatePassive = SnoData.Powers.GetBySno(323371u);
		Generic_X1CrusaderLawsOfHope = SnoData.Powers.GetBySno(290912u);
		Generic_X1CrusaderLawsOfHopePassive = SnoData.Powers.GetBySno(323370u);
		Generic_X1CrusaderLawsOfHopePassive2 = SnoData.Powers.GetBySno(342299u);
		Generic_X1CrusaderLawsOfJustice = SnoData.Powers.GetBySno(266722u);
		Generic_X1CrusaderLawsOfJusticePassive = SnoData.Powers.GetBySno(323386u);
		Generic_X1CrusaderLawsOfJusticePassive2 = SnoData.Powers.GetBySno(342286u);
		Generic_X1CrusaderLawsOfValor = SnoData.Powers.GetBySno(290946u);
		Generic_X1CrusaderLawsOfValorPassive = SnoData.Powers.GetBySno(323387u);
		Generic_X1CrusaderLawsOfValorPassive2 = SnoData.Powers.GetBySno(342284u);
		Generic_x1CrusaderPhalanxArcherRangedProjectile = SnoData.Powers.GetBySno(369807u);
		Generic_X1CrusaderPhalanxBasicMelee = SnoData.Powers.GetBySno(375866u);
		Generic_x1DarkAngelDeath = SnoData.Powers.GetBySno(363569u);
		Generic_x1DarkAngelSoulRush = SnoData.Powers.GetBySno(335991u);
		Generic_x1DarkAngelSummon = SnoData.Powers.GetBySno(342349u);
		Generic_x1deathMaidenPowerSlamLRBoss = SnoData.Powers.GetBySno(366275u);
		Generic_x1deathMaidenPowerSlamPrototype = SnoData.Powers.GetBySno(254440u);
		Generic_x1deathMaidenSpinAttackMortarLRBoss = SnoData.Powers.GetBySno(366276u);
		Generic_x1deathMaidenSpinAttackPrototype = SnoData.Powers.GetBySno(253326u);
		Generic_x1deathMaidenSummonprototype = SnoData.Powers.GetBySno(253328u);
		Generic_x1deathMaidenSummonprototypeextraskeletons = SnoData.Powers.GetBySno(369862u);
		Generic_x1DeathMaidenUniqueFireAbattoirFurnaceFireWreath = SnoData.Powers.GetBySno(376562u);
		Generic_x1DetonateDOTBuffs = SnoData.Powers.GetBySno(363984u);
		Generic_X1DHCompanionBoarIntervene = SnoData.Powers.GetBySno(368154u);
		Generic_x1FloaterAngelLightningBeam = SnoData.Powers.GetBySno(340186u);
		Generic_x1FloaterAngelLightningBeamMalthael = SnoData.Powers.GetBySno(359519u);
		Generic_x1FloaterAngelTeleport = SnoData.Powers.GetBySno(340168u);
		Generic_x1FloaterAngelTransform = SnoData.Powers.GetBySno(340083u);
		Generic_x1FloaterAngelTransformMalthael = SnoData.Powers.GetBySno(357811u);
		Generic_X1FortressBVisuals = SnoData.Powers.GetBySno(343407u);
		Generic_X1FortressJudgeEventSpawnKnockback = SnoData.Powers.GetBySno(334740u);
		Generic_x1FortressPortalSwitch = SnoData.Powers.GetBySno(360496u);
		Generic_X1FortressPortalSwitchCheckMonsters = SnoData.Powers.GetBySno(361425u);
		Generic_X1FortressPortalSwitchTeleportMonster = SnoData.Powers.GetBySno(361488u);
		Generic_x1FortressRotatingDoor = SnoData.Powers.GetBySno(330641u);
		Generic_X1GenericBreakWallsBuff = SnoData.Powers.GetBySno(377827u);
		Generic_x1GhostDarkSoulSiphon = SnoData.Powers.GetBySno(346580u);
		Generic_x1GhostSoulSiphon = SnoData.Powers.GetBySno(298686u);
		Generic_x1GhostSoulSiphonFire = SnoData.Powers.GetBySno(346561u);
		Generic_x1GhostWalkThroughWalls = SnoData.Powers.GetBySno(299066u);
		Generic_x1GreedDeath = SnoData.Powers.GetBySno(392702u);
		Generic_x1GreedDeathAncient = SnoData.Powers.GetBySno(483116u);
		Generic_x1ImperiusCleave = SnoData.Powers.GetBySno(293555u);
		Generic_X1ImperiusEnemyOrNothing = SnoData.Powers.GetBySno(345327u);
		Generic_x1ImperiusLeapSmash = SnoData.Powers.GetBySno(293355u);
		Generic_x1ImperiusWingsBuff = SnoData.Powers.GetBySno(378346u);
		Generic_X1Kylacheer = SnoData.Powers.GetBySno(315456u);
		Generic_X1Kylafalldownanimation = SnoData.Powers.GetBySno(315448u);
		Generic_X1Kylashieldup = SnoData.Powers.GetBySno(315450u);
		Generic_X1LegendaryAIRunToGuaranteedSpider = SnoData.Powers.GetBySno(439849u);
		Generic_X1LegendaryGenericPotionPowerup = SnoData.Powers.GetBySno(342078u);
		Generic_X1LifetimeBuffAbsorbNonPlayerDamage = SnoData.Powers.GetBySno(327306u);
		Generic_X1LRBossBigRedIzualFrostNova = SnoData.Powers.GetBySno(354164u);
		Generic_x1LRBossButcherSpears = SnoData.Powers.GetBySno(416435u);
		Generic_x1LRBossDarkAngelSoulRush = SnoData.Powers.GetBySno(366520u);
		Generic_x1LRBossDarkAngelSummon = SnoData.Powers.GetBySno(366525u);
		Generic_x1LRBossDarkAngelWave = SnoData.Powers.GetBySno(369463u);
		Generic_X1LRBossdemonFlyerMegaFireBreath = SnoData.Powers.GetBySno(354687u);
		Generic_X1LRBossExpandingFireRing = SnoData.Powers.GetBySno(374236u);
		Generic_X1LRBossFireNova = SnoData.Powers.GetBySno(367112u);
		Generic_X1LRBossGenericTaunt = SnoData.Powers.GetBySno(374471u);
		Generic_X1LRBossMorluSpellcasterMeteor = SnoData.Powers.GetBySno(374569u);
		Generic_x1LRBossmorluSpellcasterWeaponMeleeInstant = SnoData.Powers.GetBySno(428903u);
		Generic_X1LRBossRatKingBurrowSetup = SnoData.Powers.GetBySno(427151u);
		Generic_X1LRBossRatKingDeadPlayerTaunt = SnoData.Powers.GetBySno(428491u);
		Generic_X1LRBossRatKingDeadPlayerTauntSearch = SnoData.Powers.GetBySno(428492u);
		Generic_X1LRBossRatKingOnDeath = SnoData.Powers.GetBySno(427689u);
		Generic_x1LRBossSandmonsterOnDeath = SnoData.Powers.GetBySno(439911u);
		Generic_x1LRBossSharedCooldown = SnoData.Powers.GetBySno(367289u);
		Generic_X1LRBossSkeletonKingSummonSkeleton = SnoData.Powers.GetBySno(373204u);
		Generic_X1LRBossSkeletonKingWhirlwind = SnoData.Powers.GetBySno(375515u);
		Generic_X1LRBossSkeletonSummonerProjectile = SnoData.Powers.GetBySno(359186u);
		Generic_X1LRBossSkeletonSummonerProjectileB = SnoData.Powers.GetBySno(369518u);
		Generic_X1LRBossSkeletonSummonerProjectileC = SnoData.Powers.GetBySno(369519u);
		Generic_x1LRBossSkeletonSummonerSummoning = SnoData.Powers.GetBySno(365266u);
		Generic_X1LRBossSuccubusFirestorm = SnoData.Powers.GetBySno(374493u);
		Generic_X1LRBossSummonCoreElites = SnoData.Powers.GetBySno(445693u);
		Generic_X1LRCreepMobHerdingAttack = SnoData.Powers.GetBySno(429291u);
		Generic_X1LRCreepMobMultipleArmAttack = SnoData.Powers.GetBySno(309921u);
		Generic_X1LRCreepMobRangedArmLineAttack = SnoData.Powers.GetBySno(429077u);
		Generic_x1MalthaelBaalAIState = SnoData.Powers.GetBySno(328714u);
		Generic_x1MalthaelBaalFesteringAppendageMelee = SnoData.Powers.GetBySno(330055u);
		Generic_x1MalthaelBaalHoarfrost = SnoData.Powers.GetBySno(324846u);
		Generic_x1MalthaelBaalRift = SnoData.Powers.GetBySno(330084u);
		Generic_x1MalthaelBaalSummonFesteringAppendages = SnoData.Powers.GetBySno(330063u);
		Generic_x1MalthaelDeathFogMonsterSetup = SnoData.Powers.GetBySno(325140u);
		Generic_x1MalthaelDiabloAIState = SnoData.Powers.GetBySno(328715u);
		Generic_x1MalthaelDiabloTeleportFireNovaLightning = SnoData.Powers.GetBySno(334760u);
		Generic_X1MalthaelDrainSoul = SnoData.Powers.GetBySno(327766u);
		Generic_x1MalthaelHealthGlobeDropper = SnoData.Powers.GetBySno(340819u);
		Generic_x1MalthaelMephistoAIState = SnoData.Powers.GetBySno(328712u);
		Generic_x1MalthaelMephistoPoisonCloud = SnoData.Powers.GetBySno(330366u);
		Generic_x1MalthaelMephistoSkullMissile = SnoData.Powers.GetBySno(323604u);
		Generic_x1MalthaelMephistoSpawnInvisLightningProxies = SnoData.Powers.GetBySno(354617u);
		Generic_x1MalthaelMephistoSpiralLightningInward = SnoData.Powers.GetBySno(358059u);
		Generic_x1MalthaelMephistoSummonRotatingLightning = SnoData.Powers.GetBySno(348226u);
		Generic_x1MalthaelMephistoTeleportExplodeOrbs = SnoData.Powers.GetBySno(347681u);
		Generic_x1MalthaelOnDeath = SnoData.Powers.GetBySno(371010u);
		Generic_x1MalthaelPhaseOneAIState = SnoData.Powers.GetBySno(330358u);
		Generic_x1MalthaelPhaseThreeAIState = SnoData.Powers.GetBySno(367300u);
		Generic_x1MalthaelPhaseTwoAIState = SnoData.Powers.GetBySno(330360u);
		Generic_X1MalthaelSickleThrowTeleport = SnoData.Powers.GetBySno(327847u);
		Generic_x1MalthaelSpiritDeath = SnoData.Powers.GetBySno(360885u);
		Generic_x1MalthaelSpiritFog = SnoData.Powers.GetBySno(362756u);
		Generic_X1MalthaelSummonDeathFogMonster = SnoData.Powers.GetBySno(325184u);
		Generic_X1MalthaelSummonFloaterAngel = SnoData.Powers.GetBySno(354045u);
		Generic_x1MalthaelSwordShieldStart = SnoData.Powers.GetBySno(325648u);
		Generic_x1MalthaelSwordShieldStop = SnoData.Powers.GetBySno(325649u);
		Generic_x1MoleMutantEnragedCombo = SnoData.Powers.GetBySno(350022u);
		Generic_x1MoleMutantRangedJumpBackShot = SnoData.Powers.GetBySno(354881u);
		Generic_x1MoleMutantRangedProjectile = SnoData.Powers.GetBySno(349044u);
		Generic_x1MoleMutantShamanBlast = SnoData.Powers.GetBySno(349528u);
		Generic_x1MoleMutantShamanResurrect = SnoData.Powers.GetBySno(350639u);
		Generic_X1MonkMysticAllyRuneAExplode = SnoData.Powers.GetBySno(363878u);
		Generic_X1MonkMysticAllyRuneATagForExplosion = SnoData.Powers.GetBySno(363876u);
		Generic_X1MonkMysticAllyv2Passive = SnoData.Powers.GetBySno(362118u);
		Generic_X1MonkMysticAllyv3Passive = SnoData.Powers.GetBySno(485709u);
		Generic_X1MonsterAffixAvengerCorpseBomberRare = SnoData.Powers.GetBySno(384623u);
		Generic_X1MonsterAffixAvengerCorpseBomberRareCast = SnoData.Powers.GetBySno(384624u);
		Generic_X1MonsterAffixAvengerLightningStorm = SnoData.Powers.GetBySno(384628u);
		Generic_X1MonsterAffixAvengerLightningStormCast = SnoData.Powers.GetBySno(384630u);
		Generic_X1MonsterAffixAvengerOrbiter = SnoData.Powers.GetBySno(384570u);
		Generic_X1MonsterAffixAvengerOrbiterCast = SnoData.Powers.GetBySno(384571u);
		Generic_X1MonsterAffixCorpseBomber = SnoData.Powers.GetBySno(308319u);
		Generic_X1MonsterAffixCorpseBomberCast = SnoData.Powers.GetBySno(308318u);
		Generic_X1MonsterAffixCorpseBomberRare = SnoData.Powers.GetBySno(309247u);
		Generic_X1MonsterAffixCorpseBomberRareCast = SnoData.Powers.GetBySno(309248u);
		Generic_X1MonsterAffixLightningStorm = SnoData.Powers.GetBySno(328052u);
		Generic_x1MonsterAffixLightningStormAIClose = SnoData.Powers.GetBySno(332756u);
		Generic_X1MonsterAffixLightningStormCast = SnoData.Powers.GetBySno(328053u);
		Generic_X1MonsterAffixLightningStormChampion = SnoData.Powers.GetBySno(349751u);
		Generic_X1MonsterAffixLightningStormKillSelf = SnoData.Powers.GetBySno(349748u);
		Generic_X1MonsterAffixLightningStormPulse = SnoData.Powers.GetBySno(348532u);
		Generic_X1MonsterAffixLightningStormTagTarget = SnoData.Powers.GetBySno(332683u);
		Generic_X1MonsterAffixOrbiter = SnoData.Powers.GetBySno(343528u);
		Generic_X1MonsterAffixOrbiterCast = SnoData.Powers.GetBySno(343527u);
		Generic_X1MonsterAffixOrbiterChampion = SnoData.Powers.GetBySno(345214u);
		Generic_X1MonsterAffixOrbiterChampionCast = SnoData.Powers.GetBySno(345215u);
		Generic_X1MonsterAffixTeleportMines = SnoData.Powers.GetBySno(337106u);
		Generic_X1MonsterAffixTeleportMinesCast = SnoData.Powers.GetBySno(337107u);
		Generic_X1NegativeHealthGlobeFlash = SnoData.Powers.GetBySno(334807u);
		Generic_x1NightScreamerAllyBiteTransform = SnoData.Powers.GetBySno(338025u);
		Generic_x1NightScreamerCanTransform = SnoData.Powers.GetBySno(338114u);
		Generic_X1NightScreamerFuriousCharge = SnoData.Powers.GetBySno(322542u);
		Generic_x1NightScreamerScreamAttack = SnoData.Powers.GetBySno(324956u);
		Generic_x1NPCWestmarchAldritchCrushingResolve = SnoData.Powers.GetBySno(367807u);
		Generic_x1PandBruteDecapitateSlide = SnoData.Powers.GetBySno(329848u);
		Generic_X1pandemoniumideationtimeStopBuff = SnoData.Powers.GetBySno(300679u);
		Generic_x1PandExtCollapsingPillar = SnoData.Powers.GetBySno(322467u);
		Generic_x1PandExtEventgreatWeaponbossSuckIn = SnoData.Powers.GetBySno(360331u);
		Generic_x1PandExtEventgreatWeaponfireEnergyPulses = SnoData.Powers.GetBySno(361400u);
		Generic_x1PandExtEventgreatWeaponsummonBoss = SnoData.Powers.GetBySno(358496u);
		Generic_x1PandExtEventgreatWeaponsummonMonsters = SnoData.Powers.GetBySno(357034u);
		Generic_x1PandExtideationbaconbeaconOnDeath = SnoData.Powers.GetBySno(300721u);
		Generic_x1PandExtIdeationWarSpawnerAngel = SnoData.Powers.GetBySno(301247u);
		Generic_x1PandExtIdeationWarSpawnerDemon = SnoData.Powers.GetBySno(301248u);
		Generic_x1PandExtImperiusChargetowerschains = SnoData.Powers.GetBySno(364483u);
		Generic_x1PandExtImperiusChargeTowersSetup = SnoData.Powers.GetBySno(365313u);
		Generic_X1PandExtRamKnockback = SnoData.Powers.GetBySno(323354u);
		Generic_x1pandExtRangedPrototype = SnoData.Powers.GetBySno(272299u);
		Generic_x1pandExtRangedPrototypeStrafeLeft = SnoData.Powers.GetBySno(323070u);
		Generic_x1pandExtRangedPrototypeStrafeRight = SnoData.Powers.GetBySno(323071u);
		Generic_X1PandExtTimeTrap = SnoData.Powers.GetBySno(347846u);
		Generic_X1PandFortressOrdnanceChronoField = SnoData.Powers.GetBySno(321861u);
		Generic_X1PandFortressOrdnanceMine = SnoData.Powers.GetBySno(321168u);
		Generic_X1PandFortressOrdnanceShocker = SnoData.Powers.GetBySno(321860u);
		Generic_X1PandHexMazePortalChampSummon = SnoData.Powers.GetBySno(347156u);
		Generic_X1PandIntSplitMonstermerge = SnoData.Powers.GetBySno(276351u);
		Generic_X1PandIntSplitMonstersplit = SnoData.Powers.GetBySno(276298u);
		Generic_x1PandLeaperAngelLeap = SnoData.Powers.GetBySno(277005u);
		Generic_x1PandMazePortalTestPower = SnoData.Powers.GetBySno(270752u);
		Generic_x1PandMazePortalTestPowerBloone = SnoData.Powers.GetBySno(374755u);
		Generic_x1PandMazePortalTestPowerBorgoth = SnoData.Powers.GetBySno(374759u);
		Generic_x1PandMazePortalTestPowerGrotescor = SnoData.Powers.GetBySno(374763u);
		Generic_x1PandMazePortalTestPowerHaziael = SnoData.Powers.GetBySno(374767u);
		Generic_x1PandMazePortalTestPowerMagrethar = SnoData.Powers.GetBySno(374771u);
		Generic_x1PandMazePortalTestPowerSeverag = SnoData.Powers.GetBySno(374775u);
		Generic_x1PandRockwormBurstOut = SnoData.Powers.GetBySno(330626u);
		Generic_x1PandSniperAngelcloseRangedAttack = SnoData.Powers.GetBySno(279220u);
		Generic_x1PandSniperAngelcloseRangedAttackLRBoss = SnoData.Powers.GetBySno(375514u);
		Generic_x1PandSniperAngelrangedAttack = SnoData.Powers.GetBySno(274493u);
		Generic_x1PandSniperAngelrangedAttackLRBoss = SnoData.Powers.GetBySno(365321u);
		Generic_X1PassiveBountyScroll = SnoData.Powers.GetBySno(356461u);
		Generic_X1PassiveBountyScrollBeastDamage = SnoData.Powers.GetBySno(375252u);
		Generic_X1PassiveBountyScrollBossDamage = SnoData.Powers.GetBySno(366183u);
		Generic_X1PassiveBountyScrollDemonDamage = SnoData.Powers.GetBySno(375246u);
		Generic_X1PassiveBountyScrollEliteDamage = SnoData.Powers.GetBySno(359128u);
		Generic_X1PassiveBountyScrollExperience = SnoData.Powers.GetBySno(356462u);
		Generic_X1PassiveBountyScrollLifeRegen = SnoData.Powers.GetBySno(377214u);
		Generic_X1PassiveBountyScrollRunSpeed = SnoData.Powers.GetBySno(375263u);
		Generic_X1PassiveBountyScrollUndeadDamage = SnoData.Powers.GetBySno(375248u);
		Generic_X1PlaguedLacuniMaleSummon = SnoData.Powers.GetBySno(357878u);
		Generic_x1PlaguedLacuniSpecialMelee = SnoData.Powers.GetBySno(359826u);
		Generic_x1portalGuardianMinionprojectile = SnoData.Powers.GetBySno(302416u);
		Generic_x1PortalGuardianTurning = SnoData.Powers.GetBySno(334633u);
		Generic_x1PortalMonsterBurrowIn = SnoData.Powers.GetBySno(270783u);
		Generic_x1PortalMonsterBurrowOut = SnoData.Powers.GetBySno(270782u);
		Generic_x1PortalMonsterLifetimeBuff = SnoData.Powers.GetBySno(270784u);
		Generic_X1PortalMonsterPortalSummon = SnoData.Powers.GetBySno(325081u);
		Generic_X1PortalMonsterRoarSummon = SnoData.Powers.GetBySno(330047u);
		Generic_X1PortalMonsterStomp = SnoData.Powers.GetBySno(279029u);
		Generic_x1PortalMonsterSwipe = SnoData.Powers.GetBySno(323805u);
		Generic_x1RockFodderCharge = SnoData.Powers.GetBySno(271815u);
		Generic_X1RockFodderFuriousCharge = SnoData.Powers.GetBySno(322494u);
		Generic_X1RockFodderFuriousChargeRockHiveQueen = SnoData.Powers.GetBySno(371040u);
		Generic_x1RockFodderTumble = SnoData.Powers.GetBySno(327540u);
		Generic_x1rockwormpandprojectile = SnoData.Powers.GetBySno(323210u);
		Generic_X1SandmonsterpetWeaponMeleeInstant = SnoData.Powers.GetBySno(439832u);
		Generic_X1SandmonsterWeaponMeleeInstant = SnoData.Powers.GetBySno(377188u);
		Generic_x1ScaryEyesBurrowInHidden = SnoData.Powers.GetBySno(246451u);
		Generic_x1ScaryEyesBurrowOut = SnoData.Powers.GetBySno(246453u);
		Generic_x1ScaryEyescharge = SnoData.Powers.GetBySno(254946u);
		Generic_X1ScoundrelMultishot = SnoData.Powers.GetBySno(365395u);
		Generic_X1ScoundrelMultishotPassive = SnoData.Powers.GetBySno(366585u);
		Generic_X1ShardPassiveFakeGlobes = SnoData.Powers.GetBySno(333071u);
		Generic_X1ShardPassiveMinResource = SnoData.Powers.GetBySno(333072u);
		Generic_x1SkeletonArcherFireArrow = SnoData.Powers.GetBySno(300136u);
		Generic_x1SkeletonArcherFireArrowBackpedal = SnoData.Powers.GetBySno(313920u);
		Generic_x1SkeletonStab = SnoData.Powers.GetBySno(315052u);
		Generic_x1SkeletonStrafe = SnoData.Powers.GetBySno(314835u);
		Generic_X1SnitchleyTreasureGoblinEscape = SnoData.Powers.GetBySno(375703u);
		Generic_X1SpectralHoundBuff = SnoData.Powers.GetBySno(370348u);
		Generic_X1SummonVanityPet = SnoData.Powers.GetBySno(319739u);
		Generic_X1tempballistaswitchleap = SnoData.Powers.GetBySno(286732u);
		Generic_x1UberDiabloHellSpikes = SnoData.Powers.GetBySno(375439u);
		Generic_x1UdderLightning = SnoData.Powers.GetBySno(338723u);
		Generic_x1UniqueNPCEnchantressForcefulPush = SnoData.Powers.GetBySno(345292u);
		Generic_x1UniqueNPCEnchantressMassCharm = SnoData.Powers.GetBySno(344565u);
		Generic_x1UniqueNPCEnchantressScorchedEarth = SnoData.Powers.GetBySno(345394u);
		Generic_x1UniqueNPCTemplarHeal = SnoData.Powers.GetBySno(344096u);
		Generic_x1UniqueNPCTemplarOnslaught = SnoData.Powers.GetBySno(344099u);
		Generic_x1UniqueNPCTemplarShieldCharge = SnoData.Powers.GetBySno(344098u);
		Generic_x1UniqueTriuneSummonerProjectile = SnoData.Powers.GetBySno(346525u);
		Generic_x1UrzaelCannonball = SnoData.Powers.GetBySno(340870u);
		Generic_x1UrzaelCannonballBurning = SnoData.Powers.GetBySno(347799u);
		Generic_x1UrzaelCeilingDebris = SnoData.Powers.GetBySno(346168u);
		Generic_x1UrzaelCeilingDebrisBurning = SnoData.Powers.GetBySno(347842u);
		Generic_x1UrzaelFlameSweep = SnoData.Powers.GetBySno(292061u);
		Generic_x1UrzaelLeapKnockback = SnoData.Powers.GetBySno(346045u);
		Generic_x1UrzaelMeleeInstant = SnoData.Powers.GetBySno(308295u);
		Generic_x1UrzaelPhaseOneAIState = SnoData.Powers.GetBySno(346028u);
		Generic_x1UrzaelPhaseTwoAIState = SnoData.Powers.GetBySno(346027u);
		Generic_x1WestmarchBruteBChargeCustomLRBoss = SnoData.Powers.GetBySno(364239u);
		Generic_x1WestmarchBruteBChargeCustomLRBossHulkmode = SnoData.Powers.GetBySno(367003u);
		Generic_x1WestmarchBruteCharge = SnoData.Powers.GetBySno(278970u);
		Generic_x1WestmarchBruteDecapitate = SnoData.Powers.GetBySno(278971u);
		Generic_x1WestmarchBruteVomit = SnoData.Powers.GetBySno(278972u);
		Generic_X1WestmarchHoundDeadPlayerTaunt = SnoData.Powers.GetBySno(335450u);
		Generic_X1WestmarchHoundDeadPlayerTauntSearch = SnoData.Powers.GetBySno(335449u);
		Generic_X1WestmarchHoundShakeTarget = SnoData.Powers.GetBySno(335522u);
		Generic_x1westmarchRangedRangedAttackPrototype = SnoData.Powers.GetBySno(289871u);
		Generic_x1westmarchRangedSlowAreaDenialPrototype = SnoData.Powers.GetBySno(289870u);
		Generic_x1WestmarchRatCharge = SnoData.Powers.GetBySno(360845u);
		Generic_x1WestmarchRatKamikaze = SnoData.Powers.GetBySno(360240u);
		Generic_X1WestmConvert = SnoData.Powers.GetBySno(306381u);
		Generic_X1WestmConvert2 = SnoData.Powers.GetBySno(330011u);
		Generic_X1WestmConvertAoE = SnoData.Powers.GetBySno(307341u);
		Generic_X1WestmConvertDelayedStart2 = SnoData.Powers.GetBySno(330009u);
		Generic_X1WestmConvertDelayedStartFromTarget = SnoData.Powers.GetBySno(313957u);
		Generic_X1WestmConvertScripted = SnoData.Powers.GetBySno(328861u);
		Generic_X1westmdoomedWomanvisual = SnoData.Powers.GetBySno(354949u);
		Generic_x1westmHoistTriggeronDeathPower = SnoData.Powers.GetBySno(244759u);
		Generic_x1westmideationeventRATZNGGOLD = SnoData.Powers.GetBySno(285955u);
		Generic_x1westmSoulSummonerOrbSummonNearTarget = SnoData.Powers.GetBySno(319534u);
		Generic_X1westmSoulsummonersetup = SnoData.Powers.GetBySno(301826u);
		Generic_X1westmSoulSummonerSummon = SnoData.Powers.GetBySno(313229u);
		Generic_X1westmUniqueghostLordshockwave = SnoData.Powers.GetBySno(315014u);
		Generic_x1WickermanAggro = SnoData.Powers.GetBySno(247959u);
		Generic_X1WickerManFireNova = SnoData.Powers.GetBySno(348207u);
		Generic_X1WickerManFirePhantom = SnoData.Powers.GetBySno(288538u);
		Generic_x1WickermanSuicide = SnoData.Powers.GetBySno(247960u);
		Generic_x1WraithChargeClose = SnoData.Powers.GetBySno(291711u);
		Generic_X1WraithMelee = SnoData.Powers.GetBySno(265587u);
		Generic_X1WraithPiercingDash = SnoData.Powers.GetBySno(265911u);
		Generic_X1X1EventSpeedKillChampionSpawner = SnoData.Powers.GetBySno(365581u);
		Generic_X1X1EventSpeedKillSpawner = SnoData.Powers.GetBySno(364720u);
		Generic_x1ZombieFemaleProjectilePoison = SnoData.Powers.GetBySno(355496u);
		Generic_ZKBallSummonSkeleton = SnoData.Powers.GetBySno(30804u);
		Generic_zoltsmallFloorSpawner = SnoData.Powers.GetBySno(30808u);
		Generic_zoltTabletstateChange = SnoData.Powers.GetBySno(30810u);
		Generic_ZoltunKulleCollapseCeiling = SnoData.Powers.GetBySno(139705u);
		Generic_ZoltunKulleEnergyTwister = SnoData.Powers.GetBySno(139736u);
		Generic_ZoltunKulleFieryBoulder = SnoData.Powers.GetBySno(139942u);
		Generic_ZoltunKulleSlowTime = SnoData.Powers.GetBySno(139831u);
		Generic_ZoltunKulleTeleport = SnoData.Powers.GetBySno(139711u);
		Generic_ZoltunKulleTeleportToPlayer = SnoData.Powers.GetBySno(241753u);
		Generic_ZoltunKulleTeleportToPlayerEnrage = SnoData.Powers.GetBySno(243289u);
		Generic_ZombieEatStart = SnoData.Powers.GetBySno(178483u);
		Generic_ZombieEatStop = SnoData.Powers.GetBySno(178485u);
		Generic_ZombieFemaleProjectile = SnoData.Powers.GetBySno(110518u);
		Generic_ZombieKillerGrab = SnoData.Powers.GetBySno(1771u);
	}
}
