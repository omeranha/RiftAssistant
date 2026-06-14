using System.Collections.Generic;

namespace Plugins;

public interface ISnoPowerList
{
	ISnoPower Barbarian_AncientSpear { get; }

	ISnoPower Barbarian_Avalanche { get; }

	ISnoPower Barbarian_Bash { get; }

	ISnoPower Barbarian_BattleRage { get; }

	ISnoPower Barbarian_CallOfTheAncients { get; }

	ISnoPower Barbarian_Cleave { get; }

	ISnoPower Barbarian_Earthquake { get; }

	ISnoPower Barbarian_Frenzy { get; }

	ISnoPower Barbarian_FuriousCharge { get; }

	ISnoPower Barbarian_GroundStomp { get; }

	ISnoPower Barbarian_HammerOfTheAncients { get; }

	ISnoPower Barbarian_IgnorePain { get; }

	ISnoPower Barbarian_Leap { get; }

	ISnoPower Barbarian_Overpower { get; }

	ISnoPower Barbarian_Rend { get; }

	ISnoPower Barbarian_Revenge { get; }

	ISnoPower Barbarian_SeismicSlam { get; }

	ISnoPower Barbarian_Sprint { get; }

	ISnoPower Barbarian_ThreateningShout { get; }

	ISnoPower Barbarian_WarCry { get; }

	ISnoPower Barbarian_WeaponThrow { get; }

	ISnoPower Barbarian_Whirlwind { get; }

	ISnoPower Barbarian_WrathOfTheBerserker { get; }

	ISnoPower Barbarian_Passive_Animosity { get; }

	ISnoPower Barbarian_Passive_BerserkerRage { get; }

	ISnoPower Barbarian_Passive_Bloodthirst { get; }

	ISnoPower Barbarian_Passive_BoonOfBulKathos { get; }

	ISnoPower Barbarian_Passive_Brawler { get; }

	ISnoPower Barbarian_Passive_EarthenMight { get; }

	ISnoPower Barbarian_Passive_InspiringPresence { get; }

	ISnoPower Barbarian_Passive_Juggernaut { get; }

	ISnoPower Barbarian_Passive_NervesOfSteel { get; }

	ISnoPower Barbarian_Passive_NoEscape { get; }

	ISnoPower Barbarian_Passive_PoundOfFlesh { get; }

	ISnoPower Barbarian_Passive_Rampage { get; }

	ISnoPower Barbarian_Passive_Relentless { get; }

	ISnoPower Barbarian_Passive_Ruthless { get; }

	ISnoPower Barbarian_Passive_Superstition { get; }

	ISnoPower Barbarian_Passive_SwordAndBoard { get; }

	ISnoPower Barbarian_Passive_ToughAsNails { get; }

	ISnoPower Barbarian_Passive_Unforgiving { get; }

	ISnoPower Barbarian_Passive_WeaponsMaster { get; }

	ISnoPower Crusader_AkaratsChampion { get; }

	ISnoPower Crusader_BlessedHammer { get; }

	ISnoPower Crusader_BlessedShield { get; }

	ISnoPower Crusader_Bombardment { get; }

	ISnoPower Crusader_Condemn { get; }

	ISnoPower Crusader_Consecration { get; }

	ISnoPower Crusader_CrushingResolve { get; }

	ISnoPower Crusader_FallingSword { get; }

	ISnoPower Crusader_FistOfTheHeavens { get; }

	ISnoPower Crusader_HeavensFury { get; }

	ISnoPower Crusader_IronSkin { get; }

	ISnoPower Crusader_Judgment { get; }

	ISnoPower Crusader_Justice { get; }

	ISnoPower Crusader_LawsOfHope { get; }

	ISnoPower Crusader_LawsOfJustice { get; }

	ISnoPower Crusader_LawsOfValor { get; }

	ISnoPower Crusader_Phalanx { get; }

	ISnoPower Crusader_Provoke { get; }

	ISnoPower Crusader_Punish { get; }

	ISnoPower Crusader_ShieldBash { get; }

	ISnoPower Crusader_ShieldGlare { get; }

	ISnoPower Crusader_Slash { get; }

	ISnoPower Crusader_Smite { get; }

	ISnoPower Crusader_SteedCharge { get; }

	ISnoPower Crusader_SweepAttack { get; }

	ISnoPower Crusader_Passive_Blunt { get; }

	ISnoPower Crusader_Passive_DivineFortress { get; }

	ISnoPower Crusader_Passive_Fanaticism { get; }

	ISnoPower Crusader_Passive_Fervor { get; }

	ISnoPower Crusader_Passive_Finery { get; }

	ISnoPower Crusader_Passive_HeavenlyStrength { get; }

	ISnoPower Crusader_Passive_HoldYourGround { get; }

	ISnoPower Crusader_Passive_HolyCause { get; }

	ISnoPower Crusader_Passive_Indestructible { get; }

	ISnoPower Crusader_Passive_Insurmountable { get; }

	ISnoPower Crusader_Passive_IronMaiden { get; }

	ISnoPower Crusader_Passive_LongArmOfTheLaw { get; }

	ISnoPower Crusader_Passive_LordCommander { get; }

	ISnoPower Crusader_Passive_Renewal { get; }

	ISnoPower Crusader_Passive_Righteousness { get; }

	ISnoPower Crusader_Passive_ToweringShield { get; }

	ISnoPower Crusader_Passive_Vigilant { get; }

	ISnoPower Crusader_Passive_Wrathful { get; }

	ISnoPower DemonHunter_Bolas { get; }

	ISnoPower DemonHunter_Caltrops { get; }

	ISnoPower DemonHunter_Chakram { get; }

	ISnoPower DemonHunter_ClusterArrow { get; }

	ISnoPower DemonHunter_Companion { get; }

	ISnoPower DemonHunter_ElementalArrow { get; }

	ISnoPower DemonHunter_EntanglingShot { get; }

	ISnoPower DemonHunter_EvasiveFire { get; }

	ISnoPower DemonHunter_FanOfKnives { get; }

	ISnoPower DemonHunter_Grenades { get; }

	ISnoPower DemonHunter_HungeringArrow { get; }

	ISnoPower DemonHunter_Impale { get; }

	ISnoPower DemonHunter_MarkedForDeath { get; }

	ISnoPower DemonHunter_Multishot { get; }

	ISnoPower DemonHunter_Preparation { get; }

	ISnoPower DemonHunter_RainOfVengeance { get; }

	ISnoPower DemonHunter_RapidFire { get; }

	ISnoPower DemonHunter_Sentry { get; }

	ISnoPower DemonHunter_ShadowPower { get; }

	ISnoPower DemonHunter_SmokeScreen { get; }

	ISnoPower DemonHunter_SpikeTrap { get; }

	ISnoPower DemonHunter_Strafe { get; }

	ISnoPower DemonHunter_Vault { get; }

	ISnoPower DemonHunter_Vengeance { get; }

	ISnoPower DemonHunter_Passive_Ambush { get; }

	ISnoPower DemonHunter_Passive_Archery { get; }

	ISnoPower DemonHunter_Passive_Awareness { get; }

	ISnoPower DemonHunter_Passive_Ballistics { get; }

	ISnoPower DemonHunter_Passive_Brooding { get; }

	ISnoPower DemonHunter_Passive_CompanionPassiveEffect { get; }

	ISnoPower DemonHunter_Passive_CullTheWeak { get; }

	ISnoPower DemonHunter_Passive_CustomEngineering { get; }

	ISnoPower DemonHunter_Passive_Grenadier { get; }

	ISnoPower DemonHunter_Passive_HotPursuit { get; }

	ISnoPower DemonHunter_Passive_Leech { get; }

	ISnoPower DemonHunter_Passive_NightStalker { get; }

	ISnoPower DemonHunter_Passive_NumbingTraps { get; }

	ISnoPower DemonHunter_Passive_Perfectionist { get; }

	ISnoPower DemonHunter_Passive_PreparationPassiveEffect { get; }

	ISnoPower DemonHunter_Passive_Sharpshooter { get; }

	ISnoPower DemonHunter_Passive_SingleOut { get; }

	ISnoPower DemonHunter_Passive_SteadyAim { get; }

	ISnoPower DemonHunter_Passive_TacticalAdvantage { get; }

	ISnoPower DemonHunter_Passive_ThrillOfTheHunt { get; }

	ISnoPower DemonHunter_Passive_VengeancePassiveEffect { get; }

	ISnoPower Monk_BlindingFlash { get; }

	ISnoPower Monk_BreathOfHeaven { get; }

	ISnoPower Monk_CripplingWave { get; }

	ISnoPower Monk_CycloneStrike { get; }

	ISnoPower Monk_DashingStrike { get; }

	ISnoPower Monk_DeadlyReach { get; }

	ISnoPower Monk_Epiphany { get; }

	ISnoPower Monk_ExplodingPalm { get; }

	ISnoPower Monk_FistsOfThunder { get; }

	ISnoPower Monk_InnerSanctuary { get; }

	ISnoPower Monk_LashingTailKick { get; }

	ISnoPower Monk_MantraOfConviction { get; }

	ISnoPower Monk_MantraOfHealing { get; }

	ISnoPower Monk_MantraOfRetribution { get; }

	ISnoPower Monk_MantraOfSalvation { get; }

	ISnoPower Monk_MysticAlly { get; }

	ISnoPower Monk_Serenity { get; }

	ISnoPower Monk_SevenSidedStrike { get; }

	ISnoPower Monk_SweepingWind { get; }

	ISnoPower Monk_TempestRush { get; }

	ISnoPower Monk_WaveOfLight { get; }

	ISnoPower Monk_WayOfTheHundredFists { get; }

	ISnoPower Monk_Passive_Alacrity { get; }

	ISnoPower Monk_Passive_BeaconOfYtar { get; }

	ISnoPower Monk_Passive_ChantOfResonance { get; }

	ISnoPower Monk_Passive_CombinationStrike { get; }

	ISnoPower Monk_Passive_Determination { get; }

	ISnoPower Monk_Passive_ExaltedSoul { get; }

	ISnoPower Monk_Passive_FleetFooted { get; }

	ISnoPower Monk_Passive_Harmony { get; }

	ISnoPower Monk_Passive_MantraOfConvictionV2 { get; }

	ISnoPower Monk_Passive_MantraOfEvasionV2 { get; }

	ISnoPower Monk_Passive_MantraOfHealingV2 { get; }

	ISnoPower Monk_Passive_MantraOfRetributionV2 { get; }

	ISnoPower Monk_Passive_Momentum { get; }

	ISnoPower Monk_Passive_MythicRhythm { get; }

	ISnoPower Monk_Passive_NearDeathExperience { get; }

	ISnoPower Monk_Passive_RelentlessAssault { get; }

	ISnoPower Monk_Passive_Resolve { get; }

	ISnoPower Monk_Passive_SeizeTheInitiative { get; }

	ISnoPower Monk_Passive_SixthSense { get; }

	ISnoPower Monk_Passive_TheGuardiansPath { get; }

	ISnoPower Monk_Passive_Transcendence { get; }

	ISnoPower Monk_Passive_Unity { get; }

	ISnoPower Necromancer_ArmyOfTheDead { get; }

	ISnoPower Necromancer_BloodRush { get; }

	ISnoPower Necromancer_BoneArmor { get; }

	ISnoPower Necromancer_BoneSpear { get; }

	ISnoPower Necromancer_BoneSpikes { get; }

	ISnoPower Necromancer_BoneSpirit { get; }

	ISnoPower Necromancer_CommandGolem { get; }

	ISnoPower Necromancer_CommandSkeletons { get; }

	ISnoPower Necromancer_CorpseExplosion { get; }

	ISnoPower Necromancer_CorpseLance { get; }

	ISnoPower Necromancer_DeathNova { get; }

	ISnoPower Necromancer_Decrepify { get; }

	ISnoPower Necromancer_Devour { get; }

	ISnoPower Necromancer_Frailty { get; }

	ISnoPower Necromancer_GrimScythe { get; }

	ISnoPower Necromancer_LandOfTheDead { get; }

	ISnoPower Necromancer_Leech { get; }

	ISnoPower Necromancer_Revive { get; }

	ISnoPower Necromancer_Simulacrum { get; }

	ISnoPower Necromancer_SiphonBlood { get; }

	ISnoPower Necromancer_SkeletalMage { get; }

	ISnoPower Necromancer_Passive_AberrantAnimator { get; }

	ISnoPower Necromancer_Passive_BloodForBlood { get; }

	ISnoPower Necromancer_Passive_BloodIsPower { get; }

	ISnoPower Necromancer_Passive_BonePrison { get; }

	ISnoPower Necromancer_Passive_CommanderOfTheRisenDead { get; }

	ISnoPower Necromancer_Passive_DarkReaping { get; }

	ISnoPower Necromancer_Passive_DecrepifyPassiveEffect { get; }

	ISnoPower Necromancer_Passive_DrawLife { get; }

	ISnoPower Necromancer_Passive_EternalTorment { get; }

	ISnoPower Necromancer_Passive_ExtendedServitude { get; }

	ISnoPower Necromancer_Passive_FinalService { get; }

	ISnoPower Necromancer_Passive_FrailtyPassiveEffect { get; }

	ISnoPower Necromancer_Passive_FueledByDeath { get; }

	ISnoPower Necromancer_Passive_GrislyTribute { get; }

	ISnoPower Necromancer_Passive_LeechPassiveEffect { get; }

	ISnoPower Necromancer_Passive_LifeFromDeath { get; }

	ISnoPower Necromancer_Passive_OverwhelmingEssence { get; }

	ISnoPower Necromancer_Passive_RathmasShield { get; }

	ISnoPower Necromancer_Passive_RigorMortis { get; }

	ISnoPower Necromancer_Passive_Serration { get; }

	ISnoPower Necromancer_Passive_SpreadingMalediction { get; }

	ISnoPower Necromancer_Passive_StandAlone { get; }

	ISnoPower Necromancer_Passive_SwiftHarvesting { get; }

	ISnoPower WitchDoctor_AcidCloud { get; }

	ISnoPower WitchDoctor_BigBadVoodoo { get; }

	ISnoPower WitchDoctor_CorpseSpider { get; }

	ISnoPower WitchDoctor_FetishArmy { get; }

	ISnoPower WitchDoctor_Firebats { get; }

	ISnoPower WitchDoctor_Firebomb { get; }

	ISnoPower WitchDoctor_Gargantuan { get; }

	ISnoPower WitchDoctor_GraspOfTheDead { get; }

	ISnoPower WitchDoctor_Haunt { get; }

	ISnoPower WitchDoctor_Hex { get; }

	ISnoPower WitchDoctor_Horrify { get; }

	ISnoPower WitchDoctor_LocustSwarm { get; }

	ISnoPower WitchDoctor_MassConfusion { get; }

	ISnoPower WitchDoctor_Piranhas { get; }

	ISnoPower WitchDoctor_PlagueOfToads { get; }

	ISnoPower WitchDoctor_PoisonDart { get; }

	ISnoPower WitchDoctor_Sacrifice { get; }

	ISnoPower WitchDoctor_SoulHarvest { get; }

	ISnoPower WitchDoctor_SpiritBarrage { get; }

	ISnoPower WitchDoctor_SpiritWalk { get; }

	ISnoPower WitchDoctor_SummonZombieDog { get; }

	ISnoPower WitchDoctor_WallOfDeath { get; }

	ISnoPower WitchDoctor_ZombieCharger { get; }

	ISnoPower WitchDoctor_Passive_BadMedicine { get; }

	ISnoPower WitchDoctor_Passive_BloodRitual { get; }

	ISnoPower WitchDoctor_Passive_CircleOfLife { get; }

	ISnoPower WitchDoctor_Passive_ConfidenceRitual { get; }

	ISnoPower WitchDoctor_Passive_CreepingDeath { get; }

	ISnoPower WitchDoctor_Passive_FetishSycophants { get; }

	ISnoPower WitchDoctor_Passive_FierceLoyalty { get; }

	ISnoPower WitchDoctor_Passive_GraveInjustice { get; }

	ISnoPower WitchDoctor_Passive_GruesomeFeast { get; }

	ISnoPower WitchDoctor_Passive_JungleFortitude { get; }

	ISnoPower WitchDoctor_Passive_MidnightFeast { get; }

	ISnoPower WitchDoctor_Passive_PierceTheVeil { get; }

	ISnoPower WitchDoctor_Passive_RushOfEssence { get; }

	ISnoPower WitchDoctor_Passive_SpiritualAttunement { get; }

	ISnoPower WitchDoctor_Passive_SpiritVessel { get; }

	ISnoPower WitchDoctor_Passive_SwamplandAttunement { get; }

	ISnoPower WitchDoctor_Passive_TraitZombieDogSpawner { get; }

	ISnoPower WitchDoctor_Passive_TribalRites { get; }

	ISnoPower WitchDoctor_Passive_VisionQuest { get; }

	ISnoPower WitchDoctor_Passive_ZombieHandler { get; }

	ISnoPower Wizard_ArcaneOrb { get; }

	ISnoPower Wizard_ArcaneTorrent { get; }

	ISnoPower Wizard_Archon { get; }

	ISnoPower Wizard_ArchonArcaneBlast { get; }

	ISnoPower Wizard_ArchonArcaneBlastCold { get; }

	ISnoPower Wizard_ArchonArcaneBlastFire { get; }

	ISnoPower Wizard_ArchonArcaneBlastLightning { get; }

	ISnoPower Wizard_ArchonArcaneStrike { get; }

	ISnoPower Wizard_ArchonArcaneStrikeCold { get; }

	ISnoPower Wizard_ArchonArcaneStrikeFire { get; }

	ISnoPower Wizard_ArchonArcaneStrikeLightning { get; }

	ISnoPower Wizard_ArchonCancel { get; }

	ISnoPower Wizard_ArchonDisintegrationWave { get; }

	ISnoPower Wizard_ArchonDisintegrationWaveCold { get; }

	ISnoPower Wizard_ArchonDisintegrationWaveFire { get; }

	ISnoPower Wizard_ArchonDisintegrationWaveLightning { get; }

	ISnoPower Wizard_ArchonSlowTime { get; }

	ISnoPower Wizard_ArchonTeleport { get; }

	ISnoPower Wizard_BlackHole { get; }

	ISnoPower Wizard_Blizzard { get; }

	ISnoPower Wizard_DiamondSkin { get; }

	ISnoPower Wizard_Disintegrate { get; }

	ISnoPower Wizard_Electrocute { get; }

	ISnoPower Wizard_EnergyArmor { get; }

	ISnoPower Wizard_EnergyTwister { get; }

	ISnoPower Wizard_ExplosiveBlast { get; }

	ISnoPower Wizard_Familiar { get; }

	ISnoPower Wizard_FrostNova { get; }

	ISnoPower Wizard_Hydra { get; }

	ISnoPower Wizard_IceArmor { get; }

	ISnoPower Wizard_MagicMissile { get; }

	ISnoPower Wizard_MagicWeapon { get; }

	ISnoPower Wizard_Meteor { get; }

	ISnoPower Wizard_MirrorImage { get; }

	ISnoPower Wizard_RayOfFrost { get; }

	ISnoPower Wizard_ShockPulse { get; }

	ISnoPower Wizard_SlowTime { get; }

	ISnoPower Wizard_SpectralBlade { get; }

	ISnoPower Wizard_StormArmor { get; }

	ISnoPower Wizard_Teleport { get; }

	ISnoPower Wizard_WaveOfForce { get; }

	ISnoPower Wizard_Passive_ArcaneDynamo { get; }

	ISnoPower Wizard_Passive_AstralPresence { get; }

	ISnoPower Wizard_Passive_Audacity { get; }

	ISnoPower Wizard_Passive_Blur { get; }

	ISnoPower Wizard_Passive_ColdBlooded { get; }

	ISnoPower Wizard_Passive_Conflagration { get; }

	ISnoPower Wizard_Passive_Dominance { get; }

	ISnoPower Wizard_Passive_ElementalExposure { get; }

	ISnoPower Wizard_Passive_Evocation { get; }

	ISnoPower Wizard_Passive_GalvanizingWard { get; }

	ISnoPower Wizard_Passive_GlassCannon { get; }

	ISnoPower Wizard_Passive_Illusionist { get; }

	ISnoPower Wizard_Passive_Paralysis { get; }

	ISnoPower Wizard_Passive_PowerHungry { get; }

	ISnoPower Wizard_Passive_Prodigy { get; }

	ISnoPower Wizard_Passive_TemporalFlux { get; }

	ISnoPower Wizard_Passive_UnstableAnomaly { get; }

	ISnoPower Wizard_Passive_UnwaveringWill { get; }

	ISnoPower BaneOfThePowerfulPrimary { get; }

	ISnoPower BaneOfThePowerfulSecondary { get; }

	ISnoPower BaneOfTheStrickenPrimary { get; }

	ISnoPower BaneOfTheStrickenSecondary { get; }

	ISnoPower BaneOfTheTrappedPrimary { get; }

	ISnoPower BaneOfTheTrappedSecondary { get; }

	ISnoPower BoonOfTheHoarderPrimary { get; }

	ISnoPower BoonOfTheHoarderSecondary { get; }

	ISnoPower BoyarskysChipPrimary { get; }

	ISnoPower BoyarskysChipSecondary { get; }

	ISnoPower EnforcerPrimary { get; }

	ISnoPower EnforcerSecondary { get; }

	ISnoPower EsotericAlterationPrimary { get; }

	ISnoPower EsotericAlterationSecondary { get; }

	ISnoPower GemOfEasePrimary { get; }

	ISnoPower GemOfEaseSecondary { get; }

	ISnoPower GemOfEfficaciousToxinPrimary { get; }

	ISnoPower GemOfEfficaciousToxinSecondary { get; }

	ISnoPower GogokOfSwiftnessPrimary { get; }

	ISnoPower GogokOfSwiftnessSecondary { get; }

	ISnoPower IceblinkPrimary { get; }

	ISnoPower IceblinkSecondary { get; }

	ISnoPower InvigoratingGemstonePrimary { get; }

	ISnoPower InvigoratingGemstoneSecondary { get; }

	ISnoPower LegacyOfDreamsPrimary { get; }

	ISnoPower LegacyOfDreamsSecondary { get; }

	ISnoPower MirinaeTeardropOfTheStarweaverPrimary { get; }

	ISnoPower MirinaeTeardropOfTheStarweaverSecondary { get; }

	ISnoPower MoltenWildebeestsGizzardPrimary { get; }

	ISnoPower MoltenWildebeestsGizzardSecondary { get; }

	ISnoPower MoratoriumPrimary { get; }

	ISnoPower MoratoriumSecondary { get; }

	ISnoPower MutilationGuardPrimary { get; }

	ISnoPower MutilationGuardSecondary { get; }

	ISnoPower PainEnhancerPrimary { get; }

	ISnoPower PainEnhancerSecondary { get; }

	ISnoPower RedSoulShardPrimary { get; }

	ISnoPower RedSoulShardSecondary { get; }

	ISnoPower SimplicitysStrengthPrimary { get; }

	ISnoPower SimplicitysStrengthSecondary { get; }

	ISnoPower TaegukPrimary { get; }

	ISnoPower TaegukSecondary { get; }

	ISnoPower WhisperOfAtonementPrimary { get; }

	ISnoPower WhisperOfAtonementSecondary { get; }

	ISnoPower WreathOfLightningPrimary { get; }

	ISnoPower WreathOfLightningSecondary { get; }

	ISnoPower ZeisStoneOfVengeancePrimary { get; }

	ISnoPower ZeisStoneOfVengeanceSecondary { get; }

	ISnoPower AetherWalker { get; }

	ISnoPower AhavarionSpearOfLycander { get; }

	ISnoPower AkaratsAwakening { get; }

	ISnoPower AkkhansAddendum { get; }

	ISnoPower AkkhansLeniency { get; }

	ISnoPower AkkhansManacles { get; }

	ISnoPower AmbosPride { get; }

	ISnoPower AncestorsGrace { get; }

	ISnoPower AncientParthanDefenders { get; }

	ISnoPower AndarielsVisage { get; }

	ISnoPower AnessaziEdge { get; }

	ISnoPower AngelHairBraid { get; }

	ISnoPower AquilaCuirass { get; }

	ISnoPower ArchmagesVicalyke { get; }

	ISnoPower Arcstone { get; }

	ISnoPower ArmorOfTheKindRegent { get; }

	ISnoPower ArreatsLaw { get; }

	ISnoPower ArthefsSparkOfLife { get; }

	ISnoPower AshnagarrsBloodBracer { get; }

	ISnoPower AugustinesPanacea { get; }

	ISnoPower Azurewrath { get; }

	ISnoPower BakuliJungleWraps { get; }

	ISnoPower Balance { get; }

	ISnoPower BalefulRemnant { get; }

	ISnoPower BandOfHollowWhispers { get; }

	ISnoPower BandOfMight { get; }

	ISnoPower BandOfTheRueChambers { get; }

	ISnoPower BastionsRevered { get; }

	ISnoPower BeckonSail { get; }

	ISnoPower BeltOfTheTrove { get; }

	ISnoPower BeltOfTranscendence { get; }

	ISnoPower BindingOfTheLost { get; }

	ISnoPower BindingsOfTheLesserGods { get; }

	ISnoPower Blackfeather { get; }

	ISnoPower BladeOfProphecy { get; }

	ISnoPower BladeOfTheTribes { get; }

	ISnoPower BladeOfTheWarlord { get; }

	ISnoPower BlessedOfHaull { get; }

	ISnoPower BloodBrother { get; }

	ISnoPower BloodsongMail { get; }

	ISnoPower BloodtideBlade { get; }

	ISnoPower BombardiersRucksack { get; }

	ISnoPower BondsOfCLena { get; }

	ISnoPower BoneRinger { get; }

	ISnoPower BottomlessPotionOfAmplification { get; }

	ISnoPower BottomlessPotionOfChaos { get; }

	ISnoPower BottomlessPotionOfFear { get; }

	ISnoPower BottomlessPotionOfKulleAid { get; }

	ISnoPower BottomlessPotionOfRejuvenation { get; }

	ISnoPower BottomlessPotionOfTheUnfettered { get; }

	ISnoPower BovineBardiche { get; }

	ISnoPower BracerOfFury { get; }

	ISnoPower BracersOfDestruction { get; }

	ISnoPower BracersOfTheFirstMen { get; }

	ISnoPower BriggsWrath { get; }

	ISnoPower BrokenCrown { get; }

	ISnoPower BrokenPromises { get; }

	ISnoPower BroodOfAraneae { get; }

	ISnoPower BrynersJourney { get; }

	ISnoPower BulKathossWeddingBand { get; }

	ISnoPower BurizaDoKyanon { get; }

	ISnoPower ButchersCarver { get; }

	ISnoPower Calamity { get; }

	ISnoPower CamsRebuttal { get; }

	ISnoPower CapeOfTheDarkNight { get; }

	ISnoPower Carnevil { get; }

	ISnoPower CesarsMemento { get; }

	ISnoPower Chaingmail { get; }

	ISnoPower ChainOfShadows { get; }

	ISnoPower ChanonBolter { get; }

	ISnoPower ChilaniksChain { get; }

	ISnoPower Cindercoat { get; }

	ISnoPower CircleOfNailujsEvol { get; }

	ISnoPower Cluckeye { get; }

	ISnoPower CoilsOfTheFirstSpider { get; }

	ISnoPower ConventionOfElements { get; }

	ISnoPower CordOfTheSherma { get; }

	ISnoPower CorpsewhisperPauldrons { get; }

	ISnoPower CorruptedAshbringer { get; }

	ISnoPower CountessJuliasCameo { get; }

	ISnoPower CrashingRain { get; }

	ISnoPower CrownOfThePrimus { get; }

	ISnoPower CrystalFist { get; }

	ISnoPower CusterianWristguards { get; }

	ISnoPower DanettasRevenge { get; }

	ISnoPower DanettasSpite { get; }

	ISnoPower Darklight { get; }

	ISnoPower DarkMagesShade { get; }

	ISnoPower Dawn { get; }

	ISnoPower DaynteesBinding { get; }

	ISnoPower DeadlyRebirth { get; }

	ISnoPower DeadMansLegacy { get; }

	ISnoPower DeathseersCowl { get; }

	ISnoPower DeathWatchMantle { get; }

	ISnoPower Deathwish { get; }

	ISnoPower DefenderOfWestmarch { get; }

	ISnoPower DefilerCuisses { get; }

	ISnoPower DemonMachine { get; }

	ISnoPower Denial { get; }

	ISnoPower DepthDiggers { get; }

	ISnoPower DishonoredLegacy { get; }

	ISnoPower DovuEnergyTrap { get; }

	ISnoPower DrakonsLesson { get; }

	ISnoPower DreadIron { get; }

	ISnoPower DregsOfLies { get; }

	ISnoPower EberliCharo { get; }

	ISnoPower EchoingFury { get; }

	ISnoPower ElusiveRing { get; }

	ISnoPower EmimeisDuffel { get; }

	ISnoPower EnchantingFavor { get; }

	ISnoPower EssenceOfAnguish { get; }

	ISnoPower EtchedSigil { get; }

	ISnoPower EternalUnion { get; }

	ISnoPower Eunjangdo { get; }

	ISnoPower EyeOfPeshkov { get; }

	ISnoPower FaithfulMemory { get; }

	ISnoPower FateOfTheFell { get; }

	ISnoPower FatesVow { get; }

	ISnoPower FazulasImprobableChain { get; }

	ISnoPower FireWalkers { get; }

	ISnoPower FjordCutter { get; }

	ISnoPower FlailOfTheAscended { get; }

	ISnoPower Fleshrake { get; }

	ISnoPower FlyingDragon { get; }

	ISnoPower FortressBallista { get; }

	ISnoPower FragmentOfDestiny { get; }

	ISnoPower FragmentOfDestruction { get; }

	ISnoPower FreezeOfDeflection { get; }

	ISnoPower Frostburn { get; }

	ISnoPower FrydehrsWrath { get; }

	ISnoPower Fulminator { get; }

	ISnoPower FuneraryPick { get; }

	ISnoPower FuryOfTheAncients { get; }

	ISnoPower FuryOfTheVanishedPeak { get; }

	ISnoPower GabrielsVambraces { get; }

	ISnoPower GazingDemise { get; }

	ISnoPower GelmindorsMarrowGuards { get; }

	ISnoPower Genzaniku { get; }

	ISnoPower GestureOfOrpheus { get; }

	ISnoPower GirdleOfGiants { get; }

	ISnoPower GladiatorGauntlets { get; }

	ISnoPower GoldenFlense { get; }

	ISnoPower Goldskin { get; }

	ISnoPower Goldwrap { get; }

	ISnoPower GolemskinBreeches { get; }

	ISnoPower GraspsOfEssence { get; }

	ISnoPower GuardOfJohanna { get; }

	ISnoPower GungdoGear { get; }

	ISnoPower GyanaNaKashu { get; }

	ISnoPower GyrfalconsFoote { get; }

	ISnoPower Hack { get; }

	ISnoPower HallowedBulwark { get; }

	ISnoPower HaloOfArlyse { get; }

	ISnoPower HaloOfKarini { get; }

	ISnoPower HammerJammers { get; }

	ISnoPower HandOfTheProphet { get; }

	ISnoPower HarringtonWaistguard { get; }

	ISnoPower HauntedVisions { get; }

	ISnoPower HauntingGirdle { get; }

	ISnoPower HauntOfVaxo { get; }

	ISnoPower HeartOfIron { get; }

	ISnoPower HellcatWaistguard { get; }

	ISnoPower Hellrack { get; }

	ISnoPower Hellskull { get; }

	ISnoPower HenrisPerquisition { get; }

	ISnoPower HergbrashsBinding { get; }

	ISnoPower HexingPantsOfMrYan { get; }

	ISnoPower HillenbrandsTrainingSword { get; }

	ISnoPower HolyPointShot { get; }

	ISnoPower HomingPads { get; }

	ISnoPower Homunculus { get; }

	ISnoPower HuntersWrath { get; }

	ISnoPower HwojWrap { get; }

	ISnoPower IceClimbers { get; }

	ISnoPower IncenseTorchOfTheGrandTemple { get; }

	ISnoPower Ingeom { get; }

	ISnoPower InviolableFaith { get; }

	ISnoPower IronRose { get; }

	ISnoPower IrontoeMudsputters { get; }

	ISnoPower IvoryTower { get; }

	ISnoPower JacesHammerOfVigilance { get; }

	ISnoPower JangsEnvelopment { get; }

	ISnoPower Jawbreaker { get; }

	ISnoPower Jekangbord { get; }

	ISnoPower JeramsBracers { get; }

	ISnoPower JohannasArgument { get; }

	ISnoPower JusticeLantern { get; }

	ISnoPower JustiniansMercy { get; }

	ISnoPower KarleisPoint { get; }

	ISnoPower KassarsRetribution { get; }

	ISnoPower KekegisUnbreakableSpirit { get; }

	ISnoPower KhassettsCordOfRighteousness { get; }

	ISnoPower KmarTenclip { get; }

	ISnoPower KredesFlame { get; }

	ISnoPower KrelmsBuffBelt { get; }

	ISnoPower KrelmsBuffBracers { get; }

	ISnoPower Kridershot { get; }

	ISnoPower KrysbinsSentence { get; }

	ISnoPower KymbosGold { get; }

	ISnoPower KyoshirosBlade { get; }

	ISnoPower KyoshirosSoul { get; }

	ISnoPower LakumbasOrnament { get; }

	ISnoPower Lamentation { get; }

	ISnoPower LastBreath { get; }

	ISnoPower LefebvresSoliloquy { get; }

	ISnoPower LegersDisdain { get; }

	ISnoPower LeonineBowOfHashir { get; }

	ISnoPower LiannasWings { get; }

	ISnoPower LightOfGrace { get; }

	ISnoPower LionsClaw { get; }

	ISnoPower LordGreenstonesFan { get; }

	ISnoPower LornellesSunstone { get; }

	ISnoPower LostTime { get; }

	ISnoPower LutSocks { get; }

	ISnoPower MadawcsSorrow { get; }

	ISnoPower Madstone { get; }

	ISnoPower Magefist { get; }

	ISnoPower MalothsFocus { get; }

	ISnoPower MaltoriusPetrifiedSpike { get; }

	ISnoPower ManaldHeal { get; }

	ISnoPower Manticore { get; }

	ISnoPower MantleOfChanneling { get; }

	ISnoPower MarasKaleidoscope { get; }

	ISnoPower MaskOfJeram { get; }

	ISnoPower MaskOfScarletDeath { get; }

	ISnoPower Maximus { get; }

	ISnoPower MempoOfTwilight { get; }

	ISnoPower MesserschmidtsReaver { get; }

	ISnoPower Mirrorball { get; }

	ISnoPower MoonlightWard { get; }

	ISnoPower MordullusPromise { get; }

	ISnoPower MoribundGauntlets { get; }

	ISnoPower MorticksBrace { get; }

	ISnoPower MykensBallOfHate { get; }

	ISnoPower Nagelring { get; }

	ISnoPower NayrsBlackDeath { get; }

	ISnoPower NemesisBracers { get; }

	ISnoPower NilfursBoast { get; }

	ISnoPower Oathkeeper { get; }

	ISnoPower ObsidianRingOfTheZodiac { get; }

	ISnoPower OculusRing { get; }

	ISnoPower OdynSon { get; }

	ISnoPower OdysseysEnd { get; }

	ISnoPower Omnislash { get; }

	ISnoPower OmrynsChain { get; }

	ISnoPower OrbOfInfiniteDepth { get; }

	ISnoPower PigSticker { get; }

	ISnoPower PintosPride { get; }

	ISnoPower PoxFaulds { get; }

	ISnoPower PrideOfCassius { get; }

	ISnoPower PrimordialSoul { get; }

	ISnoPower PromiseOfGlory { get; }

	ISnoPower PusSpitter { get; }

	ISnoPower PuzzleRing { get; }

	ISnoPower Quetzalcoatl { get; }

	ISnoPower RabidStrike { get; }

	ISnoPower RakoffsGlassOfLife { get; }

	ISnoPower RanslorsFolly { get; }

	ISnoPower RazethsVolition { get; }

	ISnoPower RazorStrop { get; }

	ISnoPower RechelsRingOfLarceny { get; }

	ISnoPower ReilenasShadowhook { get; }

	ISnoPower RelicOfAkarat { get; }

	ISnoPower RemnantOfPain { get; }

	ISnoPower Remorseless { get; }

	ISnoPower RequiemCereplate { get; }

	ISnoPower RhenhoFlayer { get; }

	ISnoPower RibaldEtchings { get; }

	ISnoPower Rimeheart { get; }

	ISnoPower RingOfEmptiness { get; }

	ISnoPower RiveraDancers { get; }

	ISnoPower RogarsHugeStone { get; }

	ISnoPower SacredHarness { get; }

	ISnoPower SacredHarvester { get; }

	ISnoPower SaffronWrap { get; }

	ISnoPower SashOfKnives { get; }

	ISnoPower Scarbringer { get; }

	ISnoPower SchaefersHammer { get; }

	ISnoPower Scourge { get; }

	ISnoPower Scrimshaw { get; }

	ISnoPower ScytheOfTheCycle { get; }

	ISnoPower SeborsNightmare { get; }

	ISnoPower SerpentsSparker { get; }

	ISnoPower Sever { get; }

	ISnoPower ShardOfHate { get; }

	ISnoPower ShardOfHatred { get; }

	ISnoPower ShieldOfFury { get; }

	ISnoPower ShiMizusHaori { get; }

	ISnoPower ShukranisTriumph { get; }

	ISnoPower SinSeekers { get; }

	ISnoPower SkeletonKey { get; }

	ISnoPower SkularsSalvation { get; }

	ISnoPower SkullGrasp { get; }

	ISnoPower SkullOfResonance { get; }

	ISnoPower Skycutter { get; }

	ISnoPower SkySplitter { get; }

	ISnoPower Skywarden { get; }

	ISnoPower SlipkasLetterOpener { get; }

	ISnoPower SliverOfTerror { get; }

	ISnoPower SloraksMadness { get; }

	ISnoPower SmokingThurible { get; }

	ISnoPower Solanium { get; }

	ISnoPower SpauldersOfZakara { get; }

	ISnoPower SpearOfJairo { get; }

	ISnoPower SpinesOfSeethingHatred { get; }

	ISnoPower SpiritGuards { get; }

	ISnoPower SquirtsNecklace { get; }

	ISnoPower StaffOfChiroptera { get; }

	ISnoPower StainOfSin { get; }

	ISnoPower StalgardsDecimator { get; }

	ISnoPower Standoff { get; }

	ISnoPower StArchewsGage { get; }

	ISnoPower Starfire { get; }

	ISnoPower StarmetalKukri { get; }

	ISnoPower SteuartsGreaves { get; }

	ISnoPower StoneGauntlets { get; }

	ISnoPower StoneOfJordan { get; }

	ISnoPower StormCrow { get; }

	ISnoPower StringOfEars { get; }

	ISnoPower StrongarmBracers { get; }

	ISnoPower SublimeConviction { get; }

	ISnoPower SuWongDiviner { get; }

	ISnoPower SwampLandWaders { get; }

	ISnoPower Swiftmount { get; }

	ISnoPower SwordOfIllWill { get; }

	ISnoPower TalismanOfAranoch { get; }

	ISnoPower TaskerandTheo { get; }

	ISnoPower TheBarber { get; }

	ISnoPower TheBurningAxeOfSankis { get; }

	ISnoPower TheButchersSickle { get; }

	ISnoPower TheCloakOfTheGarwulf { get; }

	ISnoPower TheCrudestBoots { get; }

	ISnoPower TheDaggerOfDarts { get; }

	ISnoPower TheDemonsDemise { get; }

	ISnoPower TheEssOfJohan { get; }

	ISnoPower TheExecutioner { get; }

	ISnoPower TheFinalWitness { get; }

	ISnoPower TheFistOfAzTurrasq { get; }

	ISnoPower TheFlavorOfTime { get; }

	ISnoPower TheFlowOfEternity { get; }

	ISnoPower TheFurnace { get; }

	ISnoPower TheGavelOfJudgment { get; }

	ISnoPower TheGidbinn { get; }

	ISnoPower TheGrandVizier { get; }

	ISnoPower TheGrinReaper { get; }

	ISnoPower TheJohnstone { get; }

	ISnoPower TheLawsOfSeph { get; }

	ISnoPower TheMagistrate { get; }

	ISnoPower TheMindsEye { get; }

	ISnoPower TheMortalDrama { get; }

	ISnoPower TheNinthCirriSatchel { get; }

	ISnoPower TheOculus { get; }

	ISnoPower ThePaddle { get; }

	ISnoPower TheRavensWing { get; }

	ISnoPower TheShameOfDelsere { get; }

	ISnoPower TheShortMansFinger { get; }

	ISnoPower TheSmolderingCore { get; }

	ISnoPower TheSpiderQueensGrasp { get; }

	ISnoPower TheStarOfAzkaranth { get; }

	ISnoPower TheSwami { get; }

	ISnoPower TheTallMansFinger { get; }

	ISnoPower TheThreeHundredthSpear { get; }

	ISnoPower TheTormentor { get; }

	ISnoPower TheTwistedSword { get; }

	ISnoPower TheUndisputedChampion { get; }

	ISnoPower ThingOfTheDeep { get; }

	ISnoPower ThunderfuryBlessedBladeOfTheWindseeker { get; }

	ISnoPower ThundergodsVigor { get; }

	ISnoPower TiklandianVisage { get; }

	ISnoPower TragOulCoils { get; }

	ISnoPower TragOulsCorrodedFang { get; }

	ISnoPower Triumvirate { get; }

	ISnoPower TzoKrinsGaze { get; }

	ISnoPower UhkapianSerpent { get; }

	ISnoPower Unity { get; }

	ISnoPower UnrelentingPhalanx { get; }

	ISnoPower UnstableScepter { get; }

	ISnoPower UrsuasTroddenEffigy { get; }

	ISnoPower VadimsSurge { get; }

	ISnoPower VallasBequest { get; }

	ISnoPower ValtheksRebuke { get; }

	ISnoPower VambracesOfSescheron { get; }

	ISnoPower VelvetCamaral { get; }

	ISnoPower VengefulWind { get; }

	ISnoPower Vigilance { get; }

	ISnoPower VileHive { get; }

	ISnoPower VileWard { get; }

	ISnoPower VisageOfGiyua { get; }

	ISnoPower VisageOfGunes { get; }

	ISnoPower VoosJuicer { get; }

	ISnoPower VoToyiasSpiker { get; }

	ISnoPower WandOfWoh { get; }

	ISnoPower WarhelmOfKassar { get; }

	ISnoPower WarstaffOfGeneralQuang { get; }

	ISnoPower WarzechianArmguards { get; }

	ISnoPower WilkensReach { get; }

	ISnoPower WinterFlurry { get; }

	ISnoPower WisdomOfKalan { get; }

	ISnoPower Wizardspike { get; }

	ISnoPower WojahnniAssaulter { get; }

	ISnoPower WonKhimLau { get; }

	ISnoPower Wormwood { get; }

	ISnoPower WrapsOfClarity { get; }

	ISnoPower Wyrdward { get; }

	ISnoPower XephirianAmulet { get; }

	ISnoPower YangsRecurve { get; }

	ISnoPower ZoeysSecret { get; }

	ISnoPower Generic_1000MonsterFightMeteor { get; }

	ISnoPower Generic_a1dunLeorBigFireGrate { get; }

	ISnoPower Generic_a1dunLeorFireGutterfire { get; }

	ISnoPower Generic_a1dunLeorHallwayBladeTrap { get; }

	ISnoPower Generic_a1dunleoricfireTrench { get; }

	ISnoPower Generic_a1dunleoricfireTrench01 { get; }

	ISnoPower Generic_a1dunleoricfireTrench02 { get; }

	ISnoPower Generic_a2dunAqdActWoodPlatformDamage { get; }

	ISnoPower Generic_a2dunCaveGoatmenDroppingLogTrapattack { get; }

	ISnoPower Generic_a2dunCaveLarva { get; }

	ISnoPower Generic_a2dunCaveLarvaAOE { get; }

	ISnoPower Generic_a2dunCaveSlimeGeyserA { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerColdspawnAttack { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerFire { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerFirespawnAttack { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerIceNova { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerLightningpewpew { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerLightningspawnAttack { get; }

	ISnoPower Generic_a2dunZoltTeslaTowerPoisonspawnAttack { get; }

	ISnoPower Generic_A2EvacuationBelialBomb { get; }

	ISnoPower Generic_a3battlefielddemonicforge { get; }

	ISnoPower Generic_A3BattlefieldDemonMineAOE { get; }

	ISnoPower Generic_a3dunbastionKeepGuardFireAtNothing { get; }

	ISnoPower Generic_a3duncraterDemonClawBombA { get; }

	ISnoPower Generic_a3dunCraterDemonClawBombAtrigger { get; }

	ISnoPower Generic_a3duncraterDemonGroundTrapGasChamber { get; }

	ISnoPower Generic_a3duncraterDemonGroundTrapGasChamberFireOnly { get; }

	ISnoPower Generic_a3dunKeepBarrelStackShortDamage { get; }

	ISnoPower Generic_a3dunKeepExplodingBarrelStunpower { get; }

	ISnoPower Generic_a3dunkeepfireTrench01 { get; }

	ISnoPower Generic_a3dunkeepfireTrench02 { get; }

	ISnoPower Generic_A3IntroCatapultAttack { get; }

	ISnoPower Generic_a4dunGardenCorruptionMine { get; }

	ISnoPower Generic_a4dunHeavenHellRiftFallingRocksA { get; }

	ISnoPower Generic_a4dunHeavenHellRiftFallingRocksB { get; }

	ISnoPower Generic_a4DunHellFissure { get; }

	ISnoPower Generic_a4dunSpireCorruptionGeyser { get; }

	ISnoPower Generic_a4dunspirefirewall { get; }

	ISnoPower Generic_a4dunspireSpikeTrap { get; }

	ISnoPower Generic_ActorDisabledBuff { get; }

	ISnoPower Generic_ActorGhostedBuff { get; }

	ISnoPower Generic_ActorInTownBuff { get; }

	ISnoPower Generic_ActorInvulBuff { get; }

	ISnoPower Generic_ActorLoadingBuff { get; }

	ISnoPower Generic_Adriaevent47blast { get; }

	ISnoPower Generic_Adriaevent47projectile { get; }

	ISnoPower Generic_AIBackpedal { get; }

	ISnoPower Generic_AIBackpedalOneShotThroughActors { get; }

	ISnoPower Generic_AICircle { get; }

	ISnoPower Generic_AICircleLong { get; }

	ISnoPower Generic_AICircleStrafe { get; }

	ISnoPower Generic_AICircleStrafeShort { get; }

	ISnoPower Generic_AIClose { get; }

	ISnoPower Generic_AICloseFar { get; }

	ISnoPower Generic_AICloseFarther { get; }

	ISnoPower Generic_AICloseLong { get; }

	ISnoPower Generic_AIEscortFollow { get; }

	ISnoPower Generic_AIEvadeBuff { get; }

	ISnoPower Generic_AIFollow { get; }

	ISnoPower Generic_AIFollowClose { get; }

	ISnoPower Generic_AIFollowMeleeLead { get; }

	ISnoPower Generic_AIFollowMeleeLeadPet { get; }

	ISnoPower Generic_AIFollowMeleeLeadPetFar { get; }

	ISnoPower Generic_AIFollowPath { get; }

	ISnoPower Generic_AIFollowWithWalk { get; }

	ISnoPower Generic_AIFollowWithWalkFar { get; }

	ISnoPower Generic_AIFollowWithWalkNatural { get; }

	ISnoPower Generic_AIIdle { get; }

	ISnoPower Generic_AIIdleLong { get; }

	ISnoPower Generic_AIIdleShort { get; }

	ISnoPower Generic_AIOrbit { get; }

	ISnoPower Generic_AIReturnToGuardObject { get; }

	ISnoPower Generic_AIReturnToPath { get; }

	ISnoPower Generic_AIRunAway { get; }

	ISnoPower Generic_AIRunAwayLong { get; }

	ISnoPower Generic_AIRunAwayShort { get; }

	ISnoPower Generic_AIRunAwayShortV2 { get; }

	ISnoPower Generic_AIRunInFront { get; }

	ISnoPower Generic_AIRunInFrontGuaranteed { get; }

	ISnoPower Generic_AIRunNearby { get; }

	ISnoPower Generic_AIRunNearbyGloam { get; }

	ISnoPower Generic_AIRunNearbyLong { get; }

	ISnoPower Generic_AIRunNearbyShort { get; }

	ISnoPower Generic_AIRunTo { get; }

	ISnoPower Generic_AIRunToGuaranteed { get; }

	ISnoPower Generic_AIRunToGuaranteedSpider { get; }

	ISnoPower Generic_AISprintInFrontGuaranteed { get; }

	ISnoPower Generic_AISprintTo { get; }

	ISnoPower Generic_AISprintToGuaranteed { get; }

	ISnoPower Generic_AIStrafe { get; }

	ISnoPower Generic_AITownWalkToGuaranteed { get; }

	ISnoPower Generic_AIWalkInFront { get; }

	ISnoPower Generic_AIWalkInFrontGuaranteed { get; }

	ISnoPower Generic_AIWalkTo { get; }

	ISnoPower Generic_AIWalkToGuaranteed { get; }

	ISnoPower Generic_AIWander { get; }

	ISnoPower Generic_AIWanderLong { get; }

	ISnoPower Generic_AIWanderMinion { get; }

	ISnoPower Generic_AIWanderRun { get; }

	ISnoPower Generic_AIWandersuperLong { get; }

	ISnoPower Generic_AIWarnOthers { get; }

	ISnoPower Generic_AncientSpearKnockback { get; }

	ISnoPower Generic_AngelCorruptPiercingDash { get; }

	ISnoPower Generic_AnniversaryBuffEXPMF { get; }

	ISnoPower Generic_AxeBadData { get; }

	ISnoPower Generic_AxeOperateGizmo { get; }

	ISnoPower Generic_AxeOperateNPC { get; }

	ISnoPower Generic_AzmodanAODDamage { get; }

	ISnoPower Generic_AzmodanFallingCorpses { get; }

	ISnoPower Generic_AzmodanGlobeOfAnnihilation { get; }

	ISnoPower Generic_AzmodanLaserAttack { get; }

	ISnoPower Generic_AzmodanMelee { get; }

	ISnoPower Generic_AzmodanonDeath { get; }

	ISnoPower Generic_AzmodanPhase3Channel { get; }

	ISnoPower Generic_AzmodanTaunt { get; }

	ISnoPower Generic_AzmodanTurning { get; }

	ISnoPower Generic_BannerDrop { get; }

	ISnoPower Generic_BannerDropPVP { get; }

	ISnoPower Generic_BanterCooldown { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsBasicMelee { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsCleave { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsFuriousCharge { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsLeap { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsSeismicSlam { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsWeaponThrow { get; }

	ISnoPower Generic_BarbarianCallOfTheAncientsWhirlwind { get; }

	ISnoPower Generic_BarbarianGroundStompEffect { get; }

	ISnoPower Generic_BarbarianLeapOLD { get; }

	ISnoPower Generic_BarbarianOverpowerCowKing { get; }

	ISnoPower Generic_BarbarianRevengeBuff { get; }

	ISnoPower Generic_BarbarianWhirlwindDustDevilsPassability { get; }

	ISnoPower Generic_BareHandedPassive { get; }

	ISnoPower Generic_BarrelExplodeInstant { get; }

	ISnoPower Generic_BeastCharge { get; }

	ISnoPower Generic_BeastWeaponMeleeInstant { get; }

	ISnoPower Generic_BelialArmProxy { get; }

	ISnoPower Generic_BelialGroundPound { get; }

	ISnoPower Generic_BelialLightningBreath { get; }

	ISnoPower Generic_BelialLightningStrikeEnrage { get; }

	ISnoPower Generic_BelialLightningStrikev2 { get; }

	ISnoPower Generic_BelialMelee { get; }

	ISnoPower Generic_BelialMeleeReach { get; }

	ISnoPower Generic_BelialPhase3Buff { get; }

	ISnoPower Generic_BelialRangedAttack { get; }

	ISnoPower Generic_BelialSprint { get; }

	ISnoPower Generic_BelialSprintAway { get; }

	ISnoPower Generic_BigRedCharge { get; }

	ISnoPower Generic_BigRedFireBreath { get; }

	ISnoPower Generic_BlockChance10 { get; }

	ISnoPower Generic_BodyGuardTeleport { get; }

	ISnoPower Generic_BoneTurretMortarCast { get; }

	ISnoPower Generic_BountyGroundsBurrowOut { get; }

	ISnoPower Generic_BrickhouseArmShields { get; }

	ISnoPower Generic_BrickhouseDestructionSetup { get; }

	ISnoPower Generic_BrickhouseEnrage { get; }

	ISnoPower Generic_BrickhouseSlam { get; }

	ISnoPower Generic_BugWingsBuff { get; }

	ISnoPower Generic_BurrowIn { get; }

	ISnoPower Generic_BurrowInHidden { get; }

	ISnoPower Generic_BurrowInSetup { get; }

	ISnoPower Generic_BurrowInSetup2HSwing { get; }

	ISnoPower Generic_BurrowInSetupHidden { get; }

	ISnoPower Generic_BurrowInSetupStaff { get; }

	ISnoPower Generic_BurrowOut { get; }

	ISnoPower Generic_BurrowOutNoFacing { get; }

	ISnoPower Generic_BurrowOutSetup { get; }

	ISnoPower Generic_BurrowStartBuff { get; }

	ISnoPower Generic_ButcherDamagingFire { get; }

	ISnoPower Generic_ButcherFloorPanelFire { get; }

	ISnoPower Generic_ButcherFrenzy { get; }

	ISnoPower Generic_ButcherFrenzyCustomLRBoss { get; }

	ISnoPower Generic_ButcherGrapplingHook { get; }

	ISnoPower Generic_ButcherOnDeath { get; }

	ISnoPower Generic_ButcherSlam { get; }

	ISnoPower Generic_ButcherSmash { get; }

	ISnoPower Generic_ButcherSpears { get; }

	ISnoPower Generic_ButcherTargetRanged { get; }

	ISnoPower Generic_CainIntroSwing { get; }

	ISnoPower Generic_CaldeumPoisonLaser { get; }

	ISnoPower Generic_CalldownGrenade { get; }

	ISnoPower Generic_CalloutCooldown { get; }

	ISnoPower Generic_CameraFocusBuff { get; }

	ISnoPower Generic_CameraFocusPetBuff { get; }

	ISnoPower Generic_CannotDieDuringBuff { get; }

	ISnoPower Generic_caOutBoneYardsCollapsingBonesDamage { get; }

	ISnoPower Generic_caOutOasisAttackPlantattack { get; }

	ISnoPower Generic_CatapultAttack { get; }

	ISnoPower Generic_ChampionClone { get; }

	ISnoPower Generic_ChampionTeleport { get; }

	ISnoPower Generic_CleanupSummonsOnDeath { get; }

	ISnoPower Generic_CollectorsEditionBuff { get; }

	ISnoPower Generic_CommunityBuffDarkAlchemy { get; }

	ISnoPower Generic_CommunityBuffLegacyOfNightmares { get; }

	ISnoPower Generic_CommunityBuffPandemonium { get; }

	ISnoPower Generic_CommunityBuffShadowClones { get; }

	ISnoPower Generic_CommunityBuffTriunesWill { get; }

	ISnoPower Generic_CommunityBuffWeather { get; }

	ISnoPower Generic_CommunityEventBuffEXPMF { get; }

	ISnoPower Generic_CompanionBuff { get; }

	ISnoPower Generic_ConsolePowerGlobe { get; }

	ISnoPower Generic_ConsumablePotionBuffs { get; }

	ISnoPower Generic_Cooldown { get; }

	ISnoPower Generic_CopiedVisualEffectsBuff { get; }

	ISnoPower Generic_CoreEliteDropPod { get; }

	ISnoPower Generic_CoreEliteDropPodBegin { get; }

	ISnoPower Generic_CoreElitePodSetUp { get; }

	ISnoPower Generic_CorpulentExplode { get; }

	ISnoPower Generic_CorruptAngelSpectralStrike { get; }

	ISnoPower Generic_CosmeticSpectralHoundBuff { get; }

	ISnoPower Generic_CreepMobCreeperAttack { get; }

	ISnoPower Generic_CreepMobKnockback { get; }

	ISnoPower Generic_CreepMobKnockbackLR { get; }

	ISnoPower Generic_CreepMobRangedArmAttack { get; }

	ISnoPower Generic_CritDebuffCold { get; }

	ISnoPower Generic_CryptChildEat { get; }

	ISnoPower Generic_CryptChildLeapOut { get; }

	ISnoPower Generic_CryptChildLeapOutBuff { get; }

	ISnoPower Generic_DamageAttribute { get; }

	ISnoPower Generic_DeathBroBoneCage { get; }

	ISnoPower Generic_DeathBroSummonSkeletons { get; }

	ISnoPower Generic_DeathBroTeleport { get; }

	ISnoPower Generic_DebuffBleed { get; }

	ISnoPower Generic_DebuffBlind { get; }

	ISnoPower Generic_DebuffCharmed { get; }

	ISnoPower Generic_DebuffChilled { get; }

	ISnoPower Generic_DebuffFeared { get; }

	ISnoPower Generic_DebuffFireDamageProc { get; }

	ISnoPower Generic_DebuffForceGripped { get; }

	ISnoPower Generic_DebuffPoisonDamageProc { get; }

	ISnoPower Generic_DebuffRooted { get; }

	ISnoPower Generic_DebuffSlowed { get; }

	ISnoPower Generic_DebuffStunned { get; }

	ISnoPower Generic_DeleteSelfAnim { get; }

	ISnoPower Generic_demonFlyerdropBomb { get; }

	ISnoPower Generic_DemonFlyerFireBreath { get; }

	ISnoPower Generic_DemonFlyerProjectile { get; }

	ISnoPower Generic_demonFlyersnatch { get; }

	ISnoPower Generic_DemonHunterBallistaV3 { get; }

	ISnoPower Generic_DemonHunterCompanion { get; }

	ISnoPower Generic_DemonHunterEvasiveFireFlip { get; }

	ISnoPower Generic_DemonHunterSentryTurretAttack { get; }

	ISnoPower Generic_DemonTrooperLeapOut { get; }

	ISnoPower Generic_DervishWhirlwind { get; }

	ISnoPower Generic_DervishWhirlwindMortarPrototype { get; }

	ISnoPower Generic_DespairMeleeCleave { get; }

	ISnoPower Generic_DespairMeleeCleaveEnrage { get; }

	ISnoPower Generic_DespairSummonMinion { get; }

	ISnoPower Generic_DespairTeleport { get; }

	ISnoPower Generic_DespairTeleportAway { get; }

	ISnoPower Generic_DespairVolley { get; }

	ISnoPower Generic_DespairVolleyLRBoss { get; }

	ISnoPower Generic_DestructableObjectAOE { get; }

	ISnoPower Generic_DestructableObjectChandelierAOE { get; }

	ISnoPower Generic_DestructableObjectChandelierAOEHoist { get; }

	ISnoPower Generic_DestructionStreakBuffRunSpeed { get; }

	ISnoPower Generic_DHCompanionChargeAttack { get; }

	ISnoPower Generic_DHCompanionMeleeAttack { get; }

	ISnoPower Generic_DHrainofArrowsshadowBeastbombDrop { get; }

	ISnoPower Generic_DiabloCharge { get; }

	ISnoPower Generic_DiabloClawRip { get; }

	ISnoPower Generic_DiabloClawRipUber { get; }

	ISnoPower Generic_DiabloCorruptionShield { get; }

	ISnoPower Generic_DiabloCurseOfAnguish { get; }

	ISnoPower Generic_DiabloCurseOfDestruction { get; }

	ISnoPower Generic_DiabloCurseOfHate { get; }

	ISnoPower Generic_DiabloCurseOfPain { get; }

	ISnoPower Generic_DiabloExpandingFireRing { get; }

	ISnoPower Generic_DiabloExpandingFireRingUber { get; }

	ISnoPower Generic_DiabloFireMeteor { get; }

	ISnoPower Generic_DiabloGetHit { get; }

	ISnoPower Generic_DiabloHellSpikes { get; }

	ISnoPower Generic_DiabloLightningBreath { get; }

	ISnoPower Generic_DiabloLightningBreathLRTerrorDemon { get; }

	ISnoPower Generic_DiabloLightningBreathLRTerrorDemonClone { get; }

	ISnoPower Generic_DiabloLightningBreathTurretMB313 { get; }

	ISnoPower Generic_DiabloLightningBreathUber { get; }

	ISnoPower Generic_DiabloLightningBreathv2 { get; }

	ISnoPower Generic_DiabloPhase1Buff { get; }

	ISnoPower Generic_DiabloPhase2Buff { get; }

	ISnoPower Generic_DiabloPhase3Buff { get; }

	ISnoPower Generic_DiabloRingOfFire { get; }

	ISnoPower Generic_DiabloRingOfFireUber { get; }

	ISnoPower Generic_DiabloShadowClones { get; }

	ISnoPower Generic_DiabloShadowVanish { get; }

	ISnoPower Generic_DiabloShadowVanishCharge { get; }

	ISnoPower Generic_DiabloShadowVanishGrab { get; }

	ISnoPower Generic_DiabloSmashPunyDestructible { get; }

	ISnoPower Generic_DiabloStompAndStun { get; }

	ISnoPower Generic_DiabloStompAndStunMB313 { get; }

	ISnoPower Generic_DiabloTeleport { get; }

	ISnoPower Generic_DisableGetHitBuffInfinite { get; }

	ISnoPower Generic_DisablePowerBuffInfinite { get; }

	ISnoPower Generic_DOTDebuff { get; }

	ISnoPower Generic_DrinkHealthPotion { get; }

	ISnoPower Generic_DualWieldBuff { get; }

	ISnoPower Generic_DualWieldScripted { get; }

	ISnoPower Generic_DualWieldScriptedRemove { get; }

	ISnoPower Generic_DuelBuff { get; }

	ISnoPower Generic_DuelDefeatBuff { get; }

	ISnoPower Generic_EasterEggWorldBuff { get; }

	ISnoPower Generic_EatCorpse { get; }

	ISnoPower Generic_ElectricEelElectricBurst { get; }

	ISnoPower Generic_ElectricEelLeapOut { get; }

	ISnoPower Generic_EmoteAttack { get; }

	ISnoPower Generic_EmoteBye { get; }

	ISnoPower Generic_EmoteDance { get; }

	ISnoPower Generic_EmoteDie { get; }

	ISnoPower Generic_EmoteFollow { get; }

	ISnoPower Generic_EmoteGive { get; }

	ISnoPower Generic_EmoteGo { get; }

	ISnoPower Generic_EmoteHelp { get; }

	ISnoPower Generic_EmoteHold { get; }

	ISnoPower Generic_EmoteLaugh { get; }

	ISnoPower Generic_EmoteNo { get; }

	ISnoPower Generic_EmoteRetreat { get; }

	ISnoPower Generic_EmoteRun { get; }

	ISnoPower Generic_EmoteSorry { get; }

	ISnoPower Generic_EmoteStay { get; }

	ISnoPower Generic_EmoteTakeObjective { get; }

	ISnoPower Generic_EmoteThanks { get; }

	ISnoPower Generic_EmoteWait { get; }

	ISnoPower Generic_EmoteYes { get; }

	ISnoPower Generic_EnchantressAmplifyElemental { get; }

	ISnoPower Generic_EnchantressArcaneOrb { get; }

	ISnoPower Generic_EnchantressCharm { get; }

	ISnoPower Generic_EnchantressCheatDeath { get; }

	ISnoPower Generic_EnchantressCheatDeathPassive { get; }

	ISnoPower Generic_EnchantressCombinedShield { get; }

	ISnoPower Generic_EnchantressCooldownReduction { get; }

	ISnoPower Generic_EnchantressCripple { get; }

	ISnoPower Generic_EnchantressDisorient { get; }

	ISnoPower Generic_EnchantressFocusedMind { get; }

	ISnoPower Generic_EnchantressMassCharm { get; }

	ISnoPower Generic_EnchantressMeleeInstant { get; }

	ISnoPower Generic_EnchantressRunAway { get; }

	ISnoPower Generic_EnchantressScorchedEarth { get; }

	ISnoPower Generic_EnterRecallPortal { get; }

	ISnoPower Generic_EnterStoneOfRecall { get; }

	ISnoPower Generic_EnvironmentKillBuffResourceRegen { get; }

	ISnoPower Generic_EquippedLegendaryPower { get; }

	ISnoPower Generic_EscortingBuff { get; }

	ISnoPower Generic_ExitRecallPortal { get; }

	ISnoPower Generic_ExitStoneOfRecall { get; }

	ISnoPower Generic_FallenChampionLeaderShout { get; }

	ISnoPower Generic_FallenChampionPowerHit { get; }

	ISnoPower Generic_FallenGruntShout { get; }

	ISnoPower Generic_FallenLunaticAggroA { get; }

	ISnoPower Generic_FallenLunaticAggroB { get; }

	ISnoPower Generic_FallenLunaticAggroC { get; }

	ISnoPower Generic_FallenLunaticAggroD { get; }

	ISnoPower Generic_FallenLunaticSuicide { get; }

	ISnoPower Generic_FallenLunaticSuicideRingSummon { get; }

	ISnoPower Generic_FallenShamanProjectile { get; }

	ISnoPower Generic_FallenShamanProjectileLR { get; }

	ISnoPower Generic_FallingSwordCheckPathPassability { get; }

	ISnoPower Generic_FastMummyDiseaseCloud { get; }

	ISnoPower Generic_FrenzyAffix { get; }

	ISnoPower Generic_GenericArrowProjectile { get; }

	ISnoPower Generic_GenericSetCannotBeAddedToAITargetList { get; }

	ISnoPower Generic_GenericSetDoesFakeDamage { get; }

	ISnoPower Generic_GenericSetInvisible { get; }

	ISnoPower Generic_GenericSetInvulnerable { get; }

	ISnoPower Generic_GenericSetObserver { get; }

	ISnoPower Generic_GenericSetTakesNoDamage { get; }

	ISnoPower Generic_GenericSetUntargetable { get; }

	ISnoPower Generic_GenericTaunt { get; }

	ISnoPower Generic_GhostAUniqueHouse1000UndeadSlow { get; }

	ISnoPower Generic_GhostMeleeDrain { get; }

	ISnoPower Generic_GhostSoulSiphon { get; }

	ISnoPower Generic_GhostWalkThroughWalls { get; }

	ISnoPower Generic_Gizmoa3dunrmptOilVatAAttack { get; }

	ISnoPower Generic_GizmoOperatePortalWithAnimation { get; }

	ISnoPower Generic_gkillElitePack { get; }

	ISnoPower Generic_glevelUp { get; }

	ISnoPower Generic_glevelUpAA { get; }

	ISnoPower Generic_GluttonyBreathAttack { get; }

	ISnoPower Generic_GluttonyGasCloud { get; }

	ISnoPower Generic_GluttonyGasCloudLRBoss { get; }

	ISnoPower Generic_GluttonyLoogiespawn { get; }

	ISnoPower Generic_GluttonyOnDeath { get; }

	ISnoPower Generic_GoatmanColdShield { get; }

	ISnoPower Generic_GoatmanDrumsBeating { get; }

	ISnoPower Generic_GoatmanIceball { get; }

	ISnoPower Generic_GoatmanLightningShield { get; }

	ISnoPower Generic_GoatmanMoonclanRangedProjectile { get; }

	ISnoPower Generic_GoatmanShamanEmpower { get; }

	ISnoPower Generic_GoatmanShamanLightningbolt { get; }

	ISnoPower Generic_GoatMutantEnrage { get; }

	ISnoPower Generic_GoatMutantGroundSmash { get; }

	ISnoPower Generic_GoatMutantRangedProjectile { get; }

	ISnoPower Generic_GoatMutantShamanBlast { get; }

	ISnoPower Generic_GoblinAffixTeleporter { get; }

	ISnoPower Generic_gparagonBuff { get; }

	ISnoPower Generic_GraveDiggerKnockbackAttack { get; }

	ISnoPower Generic_graveDiggerwardenrangedAttack { get; }

	ISnoPower Generic_GraveRobberDodgeLeft { get; }

	ISnoPower Generic_GraveRobberDodgeRight { get; }

	ISnoPower Generic_graveRobberProjectile { get; }

	ISnoPower Generic_GreedStompAndStun { get; }

	ISnoPower Generic_HealingWellHeal { get; }

	ISnoPower Generic_Hearth { get; }

	ISnoPower Generic_HearthFinish { get; }

	ISnoPower Generic_HellPortalSummoningMachineActivate { get; }

	ISnoPower Generic_HelperArcherProjectile { get; }

	ISnoPower Generic_HirelingCalloutBattleCry { get; }

	ISnoPower Generic_HirelingCalloutBattleFinished { get; }

	ISnoPower Generic_HirelingDismiss { get; }

	ISnoPower Generic_HirelingDismissBuff { get; }

	ISnoPower Generic_HirelingDismissBuffRemove { get; }

	ISnoPower Generic_HirelingMageMagicMissile { get; }

	ISnoPower Generic_HoodedNightmareBoneArmor { get; }

	ISnoPower Generic_HoodedNightmareCurses { get; }

	ISnoPower Generic_HoodedNightmareGatewayToHell { get; }

	ISnoPower Generic_HoodedNightmareLightningOfUnlife { get; }

	ISnoPower Generic_IdentifyAllWithCast { get; }

	ISnoPower Generic_IdentifyWithCast { get; }

	ISnoPower Generic_IdentifyWithCastLegendary { get; }

	ISnoPower Generic_IGRBuffEXP { get; }

	ISnoPower Generic_ImmuneToFearDuringBuff { get; }

	ISnoPower Generic_ImmuneToRootDuringBuff { get; }

	ISnoPower Generic_ImmuneToSnareDuringBuff { get; }

	ISnoPower Generic_ImmuneToStunDuringBuff { get; }

	ISnoPower Generic_InteractCrouching { get; }

	ISnoPower Generic_InteractNormal { get; }

	ISnoPower Generic_InvisibileDuringBuff { get; }

	ISnoPower Generic_InvulnerableDuringBuff { get; }

	ISnoPower Generic_ItemPassiveSetBonusChantodo { get; }

	ISnoPower Generic_itemPassiveUniqueAmulet001 { get; }

	ISnoPower Generic_ItemPassiveUniqueBelt016p2 { get; }

	ISnoPower Generic_ItemPassiveUniqueDagger006 { get; }

	ISnoPower Generic_ItemPassiveUniqueDagger011x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueFist010 { get; }

	ISnoPower Generic_ItemPassiveUniqueFist010x1 { get; }

	ISnoPower Generic_itemPassiveUniqueMace1H009 { get; }

	ISnoPower Generic_ItemPassiveUniqueMace2H006 { get; }

	ISnoPower Generic_ItemPassiveUniqueMighty1H011 { get; }

	ISnoPower Generic_ItemPassiveUniqueMighty1H011x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueMojo010 { get; }

	ISnoPower Generic_ItemPassiveUniqueMojo010x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueMojo010x1tooltipDummy1 { get; }

	ISnoPower Generic_ItemPassiveUniquePotion01x1 { get; }

	ISnoPower Generic_ItemPassiveUniquePotion02x1 { get; }

	ISnoPower Generic_ItemPassiveUniquePotion03x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing015x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing024 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing500p2 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing502x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing503x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing506x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing511x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing512x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing513AIPickupx1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing518x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing522x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing524x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing529x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing535x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing542x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing543x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing546x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing553x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing556x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing561x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing563x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing564x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing566x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing567x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing570x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing572x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing573x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing574x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing578x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing580x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing582x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing583x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing584x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing585x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing586x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing596x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing597p2 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing598x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing599x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing601x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing603x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing605x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing621x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing625x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing627x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing632x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing633x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing636x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing637x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing640x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing641x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing650x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing652x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing654x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing657x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing659x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing661x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing666x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing676x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing678x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing680x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing681p2 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing682x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing683x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing684x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing689x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing693x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing702x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing710x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing711x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing713x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing714x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing715x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing716x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing717x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing718x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing719x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing720x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing721x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing722x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing723x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing724SpawnDecoyx1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing724x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing725x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing726x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing727x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing728x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing729x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing730x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing731x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing732x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing733x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing734x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing735x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing736x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing737x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing738x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing740x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing743x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing746x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing752x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing756x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing757x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing758x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing760x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing763x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing764x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing765x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing766x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing767x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing768x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing769x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing770x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing771x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing772x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing773x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing774x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing775x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing776x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing777x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing778x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing779x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing780x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing781x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing782x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing783x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing784x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing785x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing786x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing787x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing788x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing789x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing790x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing791x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing792x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing793x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing794x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing795x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing796x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing797x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing798x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing799x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing800x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing801x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing802x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing803x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing804x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing805x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing806x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing807x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing808x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing809x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing810x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing811x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing812x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing813x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing814x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing815x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing816x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing817x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing818x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing819x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing820x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing821x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing822x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing823x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing824x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing825x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing826x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing827x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing828x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing829x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing830x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing831x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing832x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing833x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing834x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing835x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing836x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing837x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing838x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing839x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing840x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing841x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing842x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing843x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing844x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing845x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing846x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing847x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing848x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing849x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing850x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing851x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing852x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing853x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing854x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing855x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing856x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing857x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing858x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing859x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing860x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing861x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing862x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing863x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing864x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing865x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing866x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing867x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing868x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing869x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing870x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing871x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing872x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing873x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing874x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing875x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing876x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing877x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing878x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing879x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing880x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing899x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing900x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing901x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing902x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing904x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing910x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing913x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing914x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing924x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing925x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing926x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing927x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing928x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing929x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing930x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing931x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing932x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing933x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing934x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing935x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing936x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing937x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing938x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing939x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing940x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing941x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing999 { get; }

	ISnoPower Generic_ItemPassiveUniqueRingHellfirex1 { get; }

	ISnoPower Generic_itemPassiveUniqueShield011 { get; }

	ISnoPower Generic_ItemPassiveUniqueShoulder009 { get; }

	ISnoPower Generic_itemPassiveUniqueWizardHat004p2 { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25Barbarian { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25Crusader { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25DemonHunter { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25Monk { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25Necromancer { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25WitchDoctor { get; }

	ISnoPower Generic_ItemPassivex1Amuletnormunique25Wizard { get; }

	ISnoPower Generic_IzualCharge { get; }

	ISnoPower Generic_IzualFrostNova { get; }

	ISnoPower Generic_IzualFrozenCast { get; }

	ISnoPower Generic_KillActor { get; }

	ISnoPower Generic_Knockback { get; }

	ISnoPower Generic_KnockbackNoLandingAnim { get; }

	ISnoPower Generic_KnockbackOverObstacles { get; }

	ISnoPower Generic_KnockbackThroughOwnedByTeam { get; }

	ISnoPower Generic_Knockdown { get; }

	ISnoPower Generic_LacuniBurrowIn { get; }

	ISnoPower Generic_LacuniBurrowOut { get; }

	ISnoPower Generic_LacuniCombo { get; }

	ISnoPower Generic_LacuniLeap { get; }

	ISnoPower Generic_LacuniLob { get; }

	ISnoPower Generic_LacuniMaleDoubleSwing { get; }

	ISnoPower Generic_Laugh { get; }

	ISnoPower Generic_LaughSkeletonKing { get; }

	ISnoPower Generic_LeahHulkOut { get; }

	ISnoPower Generic_LeahVortex { get; }

	ISnoPower Generic_LeahVortexAgain { get; }

	ISnoPower Generic_LostSoulsPrototypeV2 { get; }

	ISnoPower Generic_LRBossCollapseCeiling { get; }

	ISnoPower Generic_LRBossFast { get; }

	ISnoPower Generic_LRBossIzualCharge { get; }

	ISnoPower Generic_LRBossPathBlockedTeleport { get; }

	ISnoPower Generic_LRBossSprint { get; }

	ISnoPower Generic_LSp4SeaMonsterSpawnCrabs { get; }

	ISnoPower Generic_MaghdaMark { get; }

	ISnoPower Generic_MaghdaMothDust { get; }

	ISnoPower Generic_MaghdaPortalCreateCinematic { get; }

	ISnoPower Generic_MaghdaProjectile { get; }

	ISnoPower Generic_MaghdaPunish { get; }

	ISnoPower Generic_MaghdaPunishCinematic { get; }

	ISnoPower Generic_MaghdaSummonBeserker { get; }

	ISnoPower Generic_MaghdaTeleport { get; }

	ISnoPower Generic_MagicPaintingSummonSkeleton { get; }

	ISnoPower Generic_MalletDemonPowerHit { get; }

	ISnoPower Generic_ManualWalk { get; }

	ISnoPower Generic_MastaBlastaCombinedDismountRider { get; }

	ISnoPower Generic_MastaBlastaCombinedLobbedShot { get; }

	ISnoPower Generic_MastaBlastaRiderAlphaStrike { get; }

	ISnoPower Generic_MastaBlastaRiderCombine { get; }

	ISnoPower Generic_MastaBlastaRiderLeap { get; }

	ISnoPower Generic_MastaBlastaRiderLobbedShot { get; }

	ISnoPower Generic_MastaBlastaRiderLobbedShotLR { get; }

	ISnoPower Generic_MastaBlastaSteedCombine { get; }

	ISnoPower Generic_MastaBlastaSteedDrainAttack { get; }

	ISnoPower Generic_MastaBlastaSteedStomp { get; }

	ISnoPower Generic_MistressOfPainAscend { get; }

	ISnoPower Generic_MistressOfPainDescend { get; }

	ISnoPower Generic_MistressOfPainPainBolts { get; }

	ISnoPower Generic_MistressOfPainPainBoltsLR { get; }

	ISnoPower Generic_MistressOfPainSpiderlingExplode { get; }

	ISnoPower Generic_MistressOfPainSummonSpiders { get; }

	ISnoPower Generic_MistressOfPainSummonSpidersAirborne { get; }

	ISnoPower Generic_MistressOfPainTeleportToThrone { get; }

	ISnoPower Generic_MistressOfPainWebPatch { get; }

	ISnoPower Generic_MonkLashingTailKickHandOfYtarPassability { get; }

	ISnoPower Generic_MonkLethalDecoyTaunt { get; }

	ISnoPower Generic_MonkMysticAllyPetRuneAKick { get; }

	ISnoPower Generic_MonkMysticAllyPetRuneBWaveAttackFast { get; }

	ISnoPower Generic_MonkMysticAllyPetRuneCGroundPunch { get; }

	ISnoPower Generic_MonkMysticAllyPetRuneDAOEAttack { get; }

	ISnoPower Generic_MonkMysticAllyPetWeaponMeleeInstant { get; }

	ISnoPower Generic_MonkResistAura { get; }

	ISnoPower Generic_MonkResistAuraRuneCArcane { get; }

	ISnoPower Generic_MonkResistAuraRuneCCold { get; }

	ISnoPower Generic_MonkResistAuraRuneCFire { get; }

	ISnoPower Generic_MonkResistAuraRuneCHoly { get; }

	ISnoPower Generic_MonkResistAuraRuneCLightning { get; }

	ISnoPower Generic_MonkResistAuraRuneCPoison { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchanted { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchantedCast { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchantedCastNoTarget { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchantedChampion { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchantedMinion { get; }

	ISnoPower Generic_MonsterAffixArcaneEnchantedNewPetBasic { get; }

	ISnoPower Generic_MonsterAffixAvengerArcaneEnchanted { get; }

	ISnoPower Generic_MonsterAffixAvengerArcaneEnchantedCast { get; }

	ISnoPower Generic_MonsterAffixAvengerArcaneEnchantedNewPetBasic { get; }

	ISnoPower Generic_MonsterAffixAvengerBuff { get; }

	ISnoPower Generic_MonsterAffixAvengerChampion { get; }

	ISnoPower Generic_MonsterAffixAvengerMortar { get; }

	ISnoPower Generic_MonsterAffixAvengerMortarCast { get; }

	ISnoPower Generic_MonsterAffixBallista { get; }

	ISnoPower Generic_MonsterAffixChampionBuff { get; }

	ISnoPower Generic_MonsterAffixDesecrator { get; }

	ISnoPower Generic_MonsterAffixDesecratorBuff { get; }

	ISnoPower Generic_MonsterAffixDesecratorBuffChampion { get; }

	ISnoPower Generic_MonsterAffixDesecratorCast { get; }

	ISnoPower Generic_MonsterAffixDieTogether { get; }

	ISnoPower Generic_MonsterAffixElectrified { get; }

	ISnoPower Generic_MonsterAffixElectrifiedLRBossCustom { get; }

	ISnoPower Generic_MonsterAffixElectrifiedMinion { get; }

	ISnoPower Generic_MonsterAffixExtraHealth { get; }

	ISnoPower Generic_MonsterAffixFast { get; }

	ISnoPower Generic_MonsterAffixFrozen { get; }

	ISnoPower Generic_MonsterAffixFrozenCast { get; }

	ISnoPower Generic_MonsterAffixFrozenRare { get; }

	ISnoPower Generic_MonsterAffixHealing { get; }

	ISnoPower Generic_MonsterAffixHealthlink { get; }

	ISnoPower Generic_MonsterAffixIllusionist { get; }

	ISnoPower Generic_MonsterAffixIllusionistCast { get; }

	ISnoPower Generic_MonsterAffixJailer { get; }

	ISnoPower Generic_MonsterAffixJailerCast { get; }

	ISnoPower Generic_MonsterAffixJailerChampion { get; }

	ISnoPower Generic_MonsterAffixJuggernaut { get; }

	ISnoPower Generic_MonsterAffixKnockback { get; }

	ISnoPower Generic_MonsterAffixLinked { get; }

	ISnoPower Generic_MonsterAffixMissileDampening { get; }

	ISnoPower Generic_MonsterAffixMissileDampeningCast { get; }

	ISnoPower Generic_MonsterAffixMolten { get; }

	ISnoPower Generic_MonsterAffixMoltenMinion { get; }

	ISnoPower Generic_MonsterAffixMortar { get; }

	ISnoPower Generic_MonsterAffixMortarCast { get; }

	ISnoPower Generic_MonsterAffixNightmarish { get; }

	ISnoPower Generic_MonsterAffixPheonix { get; }

	ISnoPower Generic_MonsterAffixPlagued { get; }

	ISnoPower Generic_MonsterAffixPlaguedCast { get; }

	ISnoPower Generic_MonsterAffixPuppetmaster { get; }

	ISnoPower Generic_MonsterAffixPuppetmasterMinion { get; }

	ISnoPower Generic_MonsterAffixReflectsDamage { get; }

	ISnoPower Generic_MonsterAffixReflectsDamageCast { get; }

	ISnoPower Generic_MonsterAffixShielding { get; }

	ISnoPower Generic_MonsterAffixShieldingCast { get; }

	ISnoPower Generic_MonsterAffixTeleporterBuff { get; }

	ISnoPower Generic_MonsterAffixTeleporterCast { get; }

	ISnoPower Generic_MonsterAffixThunderstormBuff { get; }

	ISnoPower Generic_MonsterAffixThunderstormBuffChampion { get; }

	ISnoPower Generic_MonsterAffixThunderstormCast { get; }

	ISnoPower Generic_MonsterAffixVampiric { get; }

	ISnoPower Generic_MonsterAffixVortexBuff { get; }

	ISnoPower Generic_MonsterAffixVortexBuffChampion { get; }

	ISnoPower Generic_MonsterAffixVortexCast { get; }

	ISnoPower Generic_MonsterAffixWaller { get; }

	ISnoPower Generic_MonsterAffixWallerCast { get; }

	ISnoPower Generic_MonsterAffixWallerRare { get; }

	ISnoPower Generic_MonsterAffixWallerRareCast { get; }

	ISnoPower Generic_MonsterPoisonMeleeAttack { get; }

	ISnoPower Generic_MonsterRangedProjectile { get; }

	ISnoPower Generic_MonsterSpellProjectile { get; }

	ISnoPower Generic_MorluSpellcasterBreathOfFire { get; }

	ISnoPower Generic_MorluSpellcasterBreathOfFrost { get; }

	ISnoPower Generic_MorluSpellcasterMeteor { get; }

	ISnoPower Generic_MorluSpellcasterMeteorGraspOfTheDeadPrototype { get; }

	ISnoPower Generic_MorluSpellcasterShift { get; }

	ISnoPower Generic_MorluSpellcasterShiftNoCooldownCold { get; }

	ISnoPower Generic_MultiplayerBuff { get; }

	ISnoPower Generic_NPCLookAt { get; }

	ISnoPower Generic_OasisRockslideADamage { get; }

	ISnoPower Generic_OnDeathArcane { get; }

	ISnoPower Generic_OnDeathCold { get; }

	ISnoPower Generic_OnDeathFire { get; }

	ISnoPower Generic_OnDeathLightning { get; }

	ISnoPower Generic_OnDeathPoison { get; }

	ISnoPower Generic_OperateHelperAttach { get; }

	ISnoPower Generic_p1GreedCharge { get; }

	ISnoPower Generic_p1GreedChargeLong { get; }

	ISnoPower Generic_p1GreedChargeNoLOS { get; }

	ISnoPower Generic_p1GreedGoblinKnockback { get; }

	ISnoPower Generic_p1GreedGoldenMeteorShower { get; }

	ISnoPower Generic_p1GreedGoldSpawner { get; }

	ISnoPower Generic_p1GreedMinionPassiveLifetimeBuff { get; }

	ISnoPower Generic_p1GreedPassiveGoblinSpawnertest { get; }

	ISnoPower Generic_p1GreedPassiveLifetimeBuff { get; }

	ISnoPower Generic_p1GreedShockwave { get; }

	ISnoPower Generic_p1GreedSpawnMinion { get; }

	ISnoPower Generic_p1GreedUltimateMeteorShower { get; }

	ISnoPower Generic_p1TieredRiftSpawnNPC { get; }

	ISnoPower Generic_p1TreasureGoblinOnDeathAnniversaryPortal { get; }

	ISnoPower Generic_p1TreasureGoblinOnDeathGreedPortal { get; }

	ISnoPower Generic_p1TreasureGoblinOnDeathWhimsyshirePortal { get; }

	ISnoPower Generic_p2FallenLunaticAggroring { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing022 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing025 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing026 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing051 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing053 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing055 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing056 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing057 { get; }

	ISnoPower Generic_P2SpecialGoblinRiftSpawn { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_p42ItemPassiveUniqueRing945 { get; }

	ISnoPower Generic_p43ADBarrelExplode { get; }

	ISnoPower Generic_p43ADEventAnvilOfFury { get; }

	ISnoPower Generic_p43ADTrapArrow { get; }

	ISnoPower Generic_p43d1ButcherMeleeBasic { get; }

	ISnoPower Generic_p43d1DiabloClawRip { get; }

	ISnoPower Generic_p43d1fastMummyMelee { get; }

	ISnoPower Generic_p43d1fastMummyStealth { get; }

	ISnoPower Generic_p43d1FleshPitFlyerBlink { get; }

	ISnoPower Generic_p43d1GorehoundAcidSpit { get; }

	ISnoPower Generic_p43d1MageFlash { get; }

	ISnoPower Generic_p43d1MageTeleport { get; }

	ISnoPower Generic_p43d1TerrorDemonLightningBreath { get; }

	ISnoPower Generic_p43d1ZoltunKulleFieryBoulder { get; }

	ISnoPower Generic_p43d1ZoltunKulleTeleport { get; }

	ISnoPower Generic_p43d1ZombieSkinnyMelee { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P4CrabMotherEnrage { get; }

	ISnoPower Generic_P4DemonFlyerFireBreath { get; }

	ISnoPower Generic_p4demonTrooperSpecialMelee { get; }

	ISnoPower Generic_P4ForestMysteriousHermitArcaneFireball { get; }

	ISnoPower Generic_P4ForestMysteriousHermitArcaneFireball_ { get; }

	ISnoPower Generic_P4ForestMysteriousHermitArcaneFlameWall_ { get; }

	ISnoPower Generic_p4ForestMysteriousHermitBoomerangBlade { get; }

	ISnoPower Generic_p4ForestMysteriousHermitProjectile { get; }

	ISnoPower Generic_p4ForestMysteriousHermitTeleportIllusion { get; }

	ISnoPower Generic_P4ForestMysteriousManSpiritForm { get; }

	ISnoPower Generic_P4ForestMysteriousManSpiritSetup { get; }

	ISnoPower Generic_p4GoatmanFireball { get; }

	ISnoPower Generic_p4IceGoatmanRangedChargedShot { get; }

	ISnoPower Generic_p4IcePorcupineBackpedalShot { get; }

	ISnoPower Generic_p4IcePorcupineJumpBack { get; }

	ISnoPower Generic_p4IcePorcupineNova { get; }

	ISnoPower Generic_p4IcePorcupineShot { get; }

	ISnoPower Generic_p4ItemPassiveUniqueRing024KKG { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing043SpawnDecoy { get; }

	ISnoPower Generic_p4LRBossFedExCharge { get; }

	ISnoPower Generic_p4LRBossSpawnBoneTurrets { get; }

	ISnoPower Generic_p4LRTerrorDemonWall { get; }

	ISnoPower Generic_p4MaggotSuicideProgressiveFreeze { get; }

	ISnoPower Generic_P4MermaidHydra { get; }

	ISnoPower Generic_p4MoleRatCharge { get; }

	ISnoPower Generic_p4rathostteleport { get; }

	ISnoPower Generic_p4RatKingDoubleSwing { get; }

	ISnoPower Generic_p4RatKingLifetimeBuffPlagued { get; }

	ISnoPower Generic_p4RatKingRatBallMonsterSetup { get; }

	ISnoPower Generic_p4RatKingSummonRatBallMonster { get; }

	ISnoPower Generic_p4RatKingSummonRatVolcano { get; }

	ISnoPower Generic_p4RatKingThunderdome { get; }

	ISnoPower Generic_p4RatKingWaspRain { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianBurrowOut { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianCombatRoll { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianFuriousCharge { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianGroundstomp { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianHammerOfTheAncients { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianIntroFear { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianLeapQuake { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianShout { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianSummon { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianWeaponThrow { get; }

	ISnoPower Generic_P4RuinsCannibalBarbarianWhirlwind { get; }

	ISnoPower Generic_p4ruinsfrostEventTheZiggurat { get; }

	ISnoPower Generic_P4RuinsFrostTrapSwingingBlade { get; }

	ISnoPower Generic_P4SacrificeMonsterBreakableNova { get; }

	ISnoPower Generic_P4SacrificeMonsterEnrage { get; }

	ISnoPower Generic_P4SandWaspProjectile { get; }

	ISnoPower Generic_p4SasquatchGorillaPound { get; }

	ISnoPower Generic_p4SasquatchRockPunchKnockback { get; }

	ISnoPower Generic_p4SasquatchSpikeLine { get; }

	ISnoPower Generic_p4SasquatchTriplePunch { get; }

	ISnoPower Generic_p4ScavengerSpawnerADeath { get; }

	ISnoPower Generic_p4ScorpionBugHoverProjectile { get; }

	ISnoPower Generic_p4SeaMonsterSpawnCrabs { get; }

	ISnoPower Generic_p4SetDungBarbKingsEnmy { get; }

	ISnoPower Generic_p4SetDungBarbKingsPly { get; }

	ISnoPower Generic_p4SetDungBarbMightEnmy { get; }

	ISnoPower Generic_p4SetDungBarbMightPly { get; }

	ISnoPower Generic_p4SetDungBarbRaekorEnmy { get; }

	ISnoPower Generic_p4SetDungBarbRaekorPly { get; }

	ISnoPower Generic_p4SetDungBarbWastesEnmy { get; }

	ISnoPower Generic_p4SetDungBarbWastesPly { get; }

	ISnoPower Generic_p4SetDungCruAkkhanEnmy { get; }

	ISnoPower Generic_p4SetDungCruAkkhanPly { get; }

	ISnoPower Generic_p4SetDungCruRolandEnmy { get; }

	ISnoPower Generic_p4SetDungCruRolandPly { get; }

	ISnoPower Generic_p4SetDungCruSeekerEnmy { get; }

	ISnoPower Generic_p4SetDungCruSeekerPly { get; }

	ISnoPower Generic_p4SetDungCruThornsEnmy { get; }

	ISnoPower Generic_p4SetDungCruThornsPly { get; }

	ISnoPower Generic_p4SetDungDeathBarbKings { get; }

	ISnoPower Generic_p4SetDungDeathBarbMight { get; }

	ISnoPower Generic_p4SetDungDeathBarbRaekor { get; }

	ISnoPower Generic_p4SetDungDeathBarbWastes { get; }

	ISnoPower Generic_p4SetDungDeathCruAkkhan { get; }

	ISnoPower Generic_p4SetDungDeathCruRoland { get; }

	ISnoPower Generic_p4SetDungDeathCruSeeker { get; }

	ISnoPower Generic_p4SetDungDeathCruThorns { get; }

	ISnoPower Generic_p4SetDungDeathDHEss { get; }

	ISnoPower Generic_p4SetDungDeathDHMar { get; }

	ISnoPower Generic_p4SetDungDeathDHNat { get; }

	ISnoPower Generic_p4SetDungDeathDHShadow { get; }

	ISnoPower Generic_p4SetDungDeathMonkInnas { get; }

	ISnoPower Generic_p4SetDungDeathMonkStorms { get; }

	ISnoPower Generic_p4SetDungDeathMonkSunwuko { get; }

	ISnoPower Generic_p4SetDungDeathMonkUliana { get; }

	ISnoPower Generic_p4SetDungDeathWDHaunt { get; }

	ISnoPower Generic_p4SetDungDeathWDJade { get; }

	ISnoPower Generic_p4SetDungDeathWDSpider { get; }

	ISnoPower Generic_p4SetDungDeathWDTooth { get; }

	ISnoPower Generic_p4SetDungDeathWizFirebird { get; }

	ISnoPower Generic_p4SetDungDeathWizOpus { get; }

	ISnoPower Generic_p4SetDungDeathWizRasha { get; }

	ISnoPower Generic_p4SetDungDeathWizVyr { get; }

	ISnoPower Generic_p4SetDungDHEssEnmy { get; }

	ISnoPower Generic_p4SetDungDHEssPly { get; }

	ISnoPower Generic_p4SetDungDHMarEnmy { get; }

	ISnoPower Generic_p4SetDungDHMarPly { get; }

	ISnoPower Generic_p4SetDungDHNatEnmy { get; }

	ISnoPower Generic_p4SetDungDHNatPly { get; }

	ISnoPower Generic_p4SetDungDHShadowEnmy { get; }

	ISnoPower Generic_p4SetDungDHShadowPly { get; }

	ISnoPower Generic_p4SetDungGenericsEnmy { get; }

	ISnoPower Generic_p4SetDungGenericsPly { get; }

	ISnoPower Generic_p4SetDungGenericsPlyBalance { get; }

	ISnoPower Generic_p4SetDungGenericsPortal { get; }

	ISnoPower Generic_p4SetDungMonkInnasEnmy { get; }

	ISnoPower Generic_p4SetDungMonkInnasPly { get; }

	ISnoPower Generic_p4SetDungMonkStormsEnmy { get; }

	ISnoPower Generic_p4SetDungMonkStormsPly { get; }

	ISnoPower Generic_p4SetDungMonkSunwukoEnmy { get; }

	ISnoPower Generic_p4SetDungMonkSunwukoPly { get; }

	ISnoPower Generic_p4SetDungMonkUlianaEnmy { get; }

	ISnoPower Generic_p4SetDungMonkUlianaPly { get; }

	ISnoPower Generic_p4SetDungMonsterAffixMortarCast { get; }

	ISnoPower Generic_p4SetDungPedestalBarbKings { get; }

	ISnoPower Generic_p4SetDungPedestalBarbMight { get; }

	ISnoPower Generic_p4SetDungPedestalBarbRaekor { get; }

	ISnoPower Generic_p4SetDungPedestalBarbWastes { get; }

	ISnoPower Generic_p4SetDungPedestalCruAkkhan { get; }

	ISnoPower Generic_p4SetDungPedestalCruRoland { get; }

	ISnoPower Generic_p4SetDungPedestalCruSeeker { get; }

	ISnoPower Generic_p4SetDungPedestalCruThorns { get; }

	ISnoPower Generic_p4SetDungPedestalDHEss { get; }

	ISnoPower Generic_p4SetDungPedestalDHMar { get; }

	ISnoPower Generic_p4SetDungPedestalDHNat { get; }

	ISnoPower Generic_p4SetDungPedestalDHShadow { get; }

	ISnoPower Generic_p4SetDungPedestalMonkInnas { get; }

	ISnoPower Generic_p4SetDungPedestalMonkStorms { get; }

	ISnoPower Generic_p4SetDungPedestalMonkSunwuko { get; }

	ISnoPower Generic_p4SetDungPedestalMonkUliana { get; }

	ISnoPower Generic_p4SetDungPedestalWDHaunt { get; }

	ISnoPower Generic_p4SetDungPedestalWDJade { get; }

	ISnoPower Generic_p4SetDungPedestalWDSpider { get; }

	ISnoPower Generic_p4SetDungPedestalWDTooth { get; }

	ISnoPower Generic_p4SetDungPedestalWizFirebird { get; }

	ISnoPower Generic_p4SetDungPedestalWizOpus { get; }

	ISnoPower Generic_p4SetDungPedestalWizRasha { get; }

	ISnoPower Generic_p4SetDungPedestalWizVyr { get; }

	ISnoPower Generic_p4SetDungPortalChecks { get; }

	ISnoPower Generic_p4SetDungWDHauntEnmy { get; }

	ISnoPower Generic_p4SetDungWDHauntPly { get; }

	ISnoPower Generic_p4SetDungWDJadeEnmy { get; }

	ISnoPower Generic_p4SetDungWDJadePly { get; }

	ISnoPower Generic_p4SetDungWDSpiderEnmy { get; }

	ISnoPower Generic_p4SetDungWDSpiderPly { get; }

	ISnoPower Generic_p4SetDungWDToothEnmy { get; }

	ISnoPower Generic_p4SetDungWDToothPly { get; }

	ISnoPower Generic_p4SetDungWestmarchBruteCharge { get; }

	ISnoPower Generic_p4SetDungWizFirebirdEnmy { get; }

	ISnoPower Generic_p4SetDungWizFirebirdPly { get; }

	ISnoPower Generic_p4SetDungWizOpusEnmy { get; }

	ISnoPower Generic_p4SetDungWizOpusPly { get; }

	ISnoPower Generic_p4SetDungWizRashaEnmy { get; }

	ISnoPower Generic_p4SetDungWizRashaPly { get; }

	ISnoPower Generic_p4SetDungWizVyrEnmy { get; }

	ISnoPower Generic_p4SetDungWizVyrPly { get; }

	ISnoPower Generic_P4ShrineDebuffDamage { get; }

	ISnoPower Generic_P4ShrineDebuffSpawner { get; }

	ISnoPower Generic_p4SkeletonZombieSpawnerADeath { get; }

	ISnoPower Generic_P4SpiderBombAODDamage { get; }

	ISnoPower Generic_P4SpiderBombBurrowIn { get; }

	ISnoPower Generic_p4WaspNestDeath { get; }

	ISnoPower Generic_p4WickermanSpawnerADeath { get; }

	ISnoPower Generic_P4WoodWraithSummonSporesCeremonyEvent { get; }

	ISnoPower Generic_p4WoodWraithVineTrap { get; }

	ISnoPower Generic_p4YetiIceBreath { get; }

	ISnoPower Generic_p4YetiIceSpikes { get; }

	ISnoPower Generic_p4YetiMeleeBasic { get; }

	ISnoPower Generic_p4YetiOverheadSmash { get; }

	ISnoPower Generic_p4YetiSnowBoulderRoll { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P610ItemPassiveUniqueMojo010x1tooltipDummy2 { get; }

	ISnoPower Generic_P61ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing930 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing932 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing933 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing934 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing935 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing941 { get; }

	ISnoPower Generic_P66ItemPassiveUniqueRing946 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing947 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing948 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing949 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing950 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing951 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing952 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing953 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing956 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing957 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing958 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing959 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing960 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing961 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing962 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing963 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing964 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing965 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing966 { get; }

	ISnoPower Generic_P67ItemPassiveUniqueRing968 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P68ItemPassiveUniqueRing970 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing100 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing101 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing102 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing103 { get; }

	ISnoPower Generic_P69ItemPassiveUniqueRing104 { get; }

	ISnoPower Generic_p6CrowHoundProjectile { get; }

	ISnoPower Generic_P6EnvyBossLookSwitch { get; }

	ISnoPower Generic_P6EnvyBossMirrorPortBuff { get; }

	ISnoPower Generic_P6EnvyBossMirrorPortBuffRemove { get; }

	ISnoPower Generic_P6EnvyBossRangedPortBuff { get; }

	ISnoPower Generic_P6EnvyDMGReduction { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing022 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing023 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing024 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing025 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing026 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing027 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing028 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing029 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing030 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing031 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing032 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing033 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing034 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing035 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing036 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing038 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing051 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing052 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing053 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing055 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing056 { get; }

	ISnoPower Generic_P6NecroBoneSpikesInversePassability { get; }

	ISnoPower Generic_P6NecroBoneSpiritPassive { get; }

	ISnoPower Generic_P6NecroDevourAura { get; }

	ISnoPower Generic_P6NecroFrailtyAura { get; }

	ISnoPower Generic_P6NecroGenericCorpseTargeting { get; }

	ISnoPower Generic_P6NecroGolemMelee { get; }

	ISnoPower Generic_P6NecroRaiseDeadDDecayAura { get; }

	ISnoPower Generic_P6NecroRaiseDeadDDecayAuraSpawn { get; }

	ISnoPower Generic_P6NecroRaiseDeadEArcherAttack { get; }

	ISnoPower Generic_P6NecroRaiseDeadEArcherSpawnAttack { get; }

	ISnoPower Generic_P6NecroRaiseDeadMageSpawnAttack { get; }

	ISnoPower Generic_P6NecroRaiseDeadMageSpawnAttackNoTarget { get; }

	ISnoPower Generic_p6NecroRaiseGolemBloodGolemVeinAoE { get; }

	ISnoPower Generic_P6NecroRaiseGolemBoneGolemTornado { get; }

	ISnoPower Generic_P6NecroRaiseGolemConsumeGolemEatCorpses { get; }

	ISnoPower Generic_p6NecroRaiseGolemDestroyBreakables { get; }

	ISnoPower Generic_P6NecroRaiseGolemFleshGolemDropCorpses { get; }

	ISnoPower Generic_P6NecroRaiseGolemIceGolemFreeze { get; }

	ISnoPower Generic_P6NecroRaiseSkeletonsChargeAttack { get; }

	ISnoPower Generic_p6NecroReviveAngelCorruptPiercingDash { get; }

	ISnoPower Generic_p6NecroRevivearmorScavengerbuff { get; }

	ISnoPower Generic_p6NecroReviveBeastCharge { get; }

	ISnoPower Generic_p6NecroReviveBigRedCharge { get; }

	ISnoPower Generic_p6NecroReviveBogFamilyRangedRapidShot { get; }

	ISnoPower Generic_p6NecroReviveBrickhouseSlam { get; }

	ISnoPower Generic_p6NecroReviveCorpulentExplode { get; }

	ISnoPower Generic_p6NecroReviveCrowHoundProjectile { get; }

	ISnoPower Generic_p6NecroReviveDarkAngelSoulRush { get; }

	ISnoPower Generic_p6NecroRevivedeathMaidenSpinAttack { get; }

	ISnoPower Generic_p6NecroReviveDemonFlyerProjectile { get; }

	ISnoPower Generic_p6NecroReviveDervishWhirlwind { get; }

	ISnoPower Generic_p6NecroReviveFallenShamanProjectile { get; }

	ISnoPower Generic_p6NecroReviveFastMummyDiseaseCloud { get; }

	ISnoPower Generic_p6NecroReviveFloaterAngelProjectile { get; }

	ISnoPower Generic_p6NecroReviveGoatmanRangedProjectile { get; }

	ISnoPower Generic_p6NecroReviveGoatmanShamanLightningbolt { get; }

	ISnoPower Generic_P6NecroReviveGoatMutantRangedProjectile { get; }

	ISnoPower Generic_P6NecroReviveGoatMutantShamanBlast { get; }

	ISnoPower Generic_p6NecroReviveHoodedNightmareProjectile { get; }

	ISnoPower Generic_P6NecroReviveIcePorcupineShot { get; }

	ISnoPower Generic_p6NecroReviveLacuniLeap { get; }

	ISnoPower Generic_p6NecroReviveLacuniMaleDoubleSwing { get; }

	ISnoPower Generic_p6NecroReviveLeaperAngelLeap { get; }

	ISnoPower Generic_P6NecroReviveMelee { get; }

	ISnoPower Generic_p6NecroReviveMermaidRangedProjectile { get; }

	ISnoPower Generic_p6NecroReviveMoleMutantRangedProjectile { get; }

	ISnoPower Generic_p6NecroReviveMoleMutantShamanProjectile { get; }

	ISnoPower Generic_p6NecroReviveMorluSpellcasterBreathOfFire { get; }

	ISnoPower Generic_p6NecroReviveNightScreamerProjectile { get; }

	ISnoPower Generic_p6NecroRevivepandExtRanged { get; }

	ISnoPower Generic_p6NecroRevivePortalGuardianMinionprojectile { get; }

	ISnoPower Generic_p6NecroReviveQuillDemonProjectile { get; }

	ISnoPower Generic_p6NecroReviverockwormprojectile { get; }

	ISnoPower Generic_p6NecroReviveSandWaspProjectile { get; }

	ISnoPower Generic_p6NecroReviveScorpionBugHoverProjectile { get; }

	ISnoPower Generic_p6NecroReviveShepherdProjectile { get; }

	ISnoPower Generic_p6NecroReviveSkeletonArcherProjectile { get; }

	ISnoPower Generic_p6NecroReviveskeletonMageProjectile { get; }

	ISnoPower Generic_p6NecroReviveSkeletonSummonerProjectile { get; }

	ISnoPower Generic_p6NecroReviveSniperAngelcloseRangedAttack { get; }

	ISnoPower Generic_p6NecroReviveSuccubusBloodStar { get; }

	ISnoPower Generic_p6NecroReviveTempleCultistCasterProjectile { get; }

	ISnoPower Generic_p6NecroReviveTempleCultistSuicide { get; }

	ISnoPower Generic_p6NecroReviveThousandPounderKnockback { get; }

	ISnoPower Generic_p6NecroReviveTriuneSummonerProjectile { get; }

	ISnoPower Generic_p6NecroReviveUnburiedKnockback { get; }

	ISnoPower Generic_p6NecroReviveWerewolfMelee { get; }

	ISnoPower Generic_p6NecroReviveWestmarchBruteBDecapitateSlide { get; }

	ISnoPower Generic_p6NecroReviveWestmarchBruteCharge { get; }

	ISnoPower Generic_p6NecroReviveWestmarchHoundTaunt { get; }

	ISnoPower Generic_p6NecroReviveWestmarchHoundTauntSearch { get; }

	ISnoPower Generic_p6NecroRevivewestmarchRangedProjectile { get; }

	ISnoPower Generic_P6NecroReviveWraithMelee { get; }

	ISnoPower Generic_p6NecroReviveZombieFemaleProjectile { get; }

	ISnoPower Generic_P6NecroSimulacrumWeaponMeleeInstant { get; }

	ISnoPower Generic_P6NecroSkeletalWarriorMelee { get; }

	ISnoPower Generic_P6NecroSkeletalWarriorUberMelee { get; }

	ISnoPower Generic_P6NecroSkeletonMageFireProjectile { get; }

	ISnoPower Generic_P6NecroTraitGolemSpawner { get; }

	ISnoPower Generic_P6NecroTraitSkeletonSpawner { get; }

	ISnoPower Generic_p6RavenFlyerJumpBackAttack { get; }

	ISnoPower Generic_p6RavenFlyerPathingBuff { get; }

	ISnoPower Generic_p6SetDungDeathNecroBlood { get; }

	ISnoPower Generic_p6SetDungDeathNecroBone { get; }

	ISnoPower Generic_p6SetDungDeathNecroPlague { get; }

	ISnoPower Generic_p6SetDungDeathNecroSaint { get; }

	ISnoPower Generic_p6SetDungNecroBloodEnmy { get; }

	ISnoPower Generic_p6SetDungNecroBloodPly { get; }

	ISnoPower Generic_p6SetDungNecroBoneEnmy { get; }

	ISnoPower Generic_p6SetDungNecroBonePly { get; }

	ISnoPower Generic_p6SetDungNecroPlagueEnmy { get; }

	ISnoPower Generic_p6SetDungNecroPlaguePly { get; }

	ISnoPower Generic_p6SetDungNecroSaintEnmy { get; }

	ISnoPower Generic_p6SetDungNecroSaintPly { get; }

	ISnoPower Generic_p6SetDungPedestalNecroBlood { get; }

	ISnoPower Generic_p6SetDungPedestalNecroBone { get; }

	ISnoPower Generic_p6SetDungPedestalNecroPlague { get; }

	ISnoPower Generic_p6SetDungPedestalNecroSaint { get; }

	ISnoPower Generic_P6ShepherdBossTeleportOutro { get; }

	ISnoPower Generic_p6ShepherdRangedAttack { get; }

	ISnoPower Generic_p6ShepherdRangedAttackBoss { get; }

	ISnoPower Generic_p6ShepherdRangedAttackBossTransformed { get; }

	ISnoPower Generic_p6ShepherdRangedAttackNodmg { get; }

	ISnoPower Generic_P6ShepherdSpawnBossOutro { get; }

	ISnoPower Generic_P6ShepherdSpawnIntro { get; }

	ISnoPower Generic_P6ShepherdSpawnOutro { get; }

	ISnoPower Generic_P6ShepherdTeleportIntro { get; }

	ISnoPower Generic_P6ShepherdTeleportIntroMirror { get; }

	ISnoPower Generic_P6ShepherdTeleportOutro { get; }

	ISnoPower Generic_p6TempleCultistLobbedShot { get; }

	ISnoPower Generic_p6TempleCultistSuicide { get; }

	ISnoPower Generic_p6TempleMonstrosityGrenadeVolley { get; }

	ISnoPower Generic_p6TempleMonstrosityMeleeLance { get; }

	ISnoPower Generic_P6WerewolfClawRush { get; }

	ISnoPower Generic_P6WerewolfHowl { get; }

	ISnoPower Generic_P6WerewolfJumpBack { get; }

	ISnoPower Generic_P6WerewolfLeap { get; }

	ISnoPower Generic_P6WerewolfLeapFire { get; }

	ISnoPower Generic_P6WerewolfMelee { get; }

	ISnoPower Generic_P6WerewolfMeleeFire { get; }

	ISnoPower Generic_P71ItemPassiveEthereal001 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal002 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal003 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal004 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal005 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal006 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal007 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal008 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal009 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal010 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal011 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal012 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal013 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal014 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal015 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal016 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal017 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal018 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal019 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal020 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal021 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal022 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal023 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal024 { get; }

	ISnoPower Generic_P71ItemPassiveEthereal025 { get; }

	ISnoPower Generic_P71ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard002 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard003 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard004 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard006 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard007 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard008 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard010 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard011 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard012 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard014 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard015 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard016 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard018 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard019 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard020 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard022 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard023 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard024 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard026 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard027 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard028 { get; }

	ISnoPower Generic_P72ItemPassiveSoulshard029 { get; }

	ISnoPower Generic_P72ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P72ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P73ExplodingLunaticSuicide { get; }

	ISnoPower Generic_P73ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P73PagesBuffDamageSwarmRift { get; }

	ISnoPower Generic_P73PagesBuffElectrifiedCastSwarmRift { get; }

	ISnoPower Generic_P73PagesBuffRunSpeed { get; }

	ISnoPower Generic_P73PagesBuffRunSpeedKnockbackCast { get; }

	ISnoPower Generic_P73PagesBuffRunSpeedWallerCast { get; }

	ISnoPower Generic_P73PagesBuffRunSpeedWallerCastUpgrade { get; }

	ISnoPower Generic_P73ShrineDesecratedtreasureGoblin { get; }

	ISnoPower Generic_P73SwarmRiftCloneDeathExplosionAffix { get; }

	ISnoPower Generic_P73SwarmRiftGreenMeteors { get; }

	ISnoPower Generic_P73SwarmRiftLunaticMolten { get; }

	ISnoPower Generic_P73SwarmRiftPagesBuffElectrifiedTieredRift { get; }

	ISnoPower Generic_P73SwarmRiftPagesBuffInfiniteCasting { get; }

	ISnoPower Generic_p73SwarmRiftSummon { get; }

	ISnoPower Generic_P74GargantuanWormwoodSeasonTheme { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme001 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme002 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme003 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme004 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme005 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme006 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme007 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme008 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme009 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme010 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme011 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme012 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme013 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme014 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme015 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme016 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme017 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme018 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme019 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme020 { get; }

	ISnoPower Generic_P74ItemPassiveSeasonTheme021 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P74NecroGolemDevourAura { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor018AIPetPickup { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor021AIPetPickup { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemySeal001 { get; }

	ISnoPower Generic_P75ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P75ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P75PagesBuffDamageDarkAlchemy { get; }

	ISnoPower Generic_P7ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P7ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P7ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_PagesBuffDamage { get; }

	ISnoPower Generic_PagesBuffElectrified { get; }

	ISnoPower Generic_PagesBuffElectrifiedCast { get; }

	ISnoPower Generic_PagesBuffElectrifiedCastTieredRift { get; }

	ISnoPower Generic_PagesBuffElectrifiedTieredRift { get; }

	ISnoPower Generic_PagesBuffInfiniteCasting { get; }

	ISnoPower Generic_PagesBuffInvulnerable { get; }

	ISnoPower Generic_PagesBuffInvulnerableCastv2 { get; }

	ISnoPower Generic_PagesBuffRunSpeed { get; }

	ISnoPower Generic_PagesBuffRunSpeedKnockbackCast { get; }

	ISnoPower Generic_PagesBuffRunSpeedWallerCast { get; }

	ISnoPower Generic_PagesBuffRunSpeedWallerCastUpgrade { get; }

	ISnoPower Generic_PandemoniumPortal { get; }

	ISnoPower Generic_PandemoniumPortalDiablo { get; }

	ISnoPower Generic_PandemoniumPortalghom { get; }

	ISnoPower Generic_PandemoniumPortalSiegeBreaker { get; }

	ISnoPower Generic_PandemoniumPortalSkeletonKing { get; }

	ISnoPower Generic_PassiveChallengeRift { get; }

	ISnoPower Generic_PassiveSetDungeon { get; }

	ISnoPower Generic_PickupNearby { get; }

	ISnoPower Generic_PlagueOfToadsKnockback { get; }

	ISnoPower Generic_PlayerUpscaledBuff { get; }

	ISnoPower Generic_ProxyDelayedPower { get; }

	ISnoPower Generic_Punch { get; }

	ISnoPower Generic_PVPBuff { get; }

	ISnoPower Generic_PVPcontrolpoint { get; }

	ISnoPower Generic_PvPDamageBuff { get; }

	ISnoPower Generic_PvPDeathstreakBuff { get; }

	ISnoPower Generic_PvPHealingMacguffin { get; }

	ISnoPower Generic_PVPhill { get; }

	ISnoPower Generic_PvPHunterBuff { get; }

	ISnoPower Generic_PvPLevelEqualizerBuff { get; }

	ISnoPower Generic_PVPPeanutNeutralObjective { get; }

	ISnoPower Generic_PvPRangedProjectile { get; }

	ISnoPower Generic_PVPRoundEndBuff { get; }

	ISnoPower Generic_PVPShrineMurderball { get; }

	ISnoPower Generic_PVPSkirmishBuff { get; }

	ISnoPower Generic_PVPspawnersetup { get; }

	ISnoPower Generic_PVPspawnerTowerDefenders { get; }

	ISnoPower Generic_PVPStationaryattack { get; }

	ISnoPower Generic_PVPThreeControlSpawnDefenders { get; }

	ISnoPower Generic_pxBoneyardsCampSnakemanSpawner { get; }

	ISnoPower Generic_pxbountytestchaosportalssummonChampion { get; }

	ISnoPower Generic_pxBridgeCampDemonSpawner { get; }

	ISnoPower Generic_pxCampPortalSpawner { get; }

	ISnoPower Generic_pxCraterCampDemonSpawner { get; }

	ISnoPower Generic_pxFesteringWoodsCampGhoulSpawner { get; }

	ISnoPower Generic_pxGardensOfHopeCampDemonSpawner { get; }

	ISnoPower Generic_pxGraveyardCampReaperSpawner { get; }

	ISnoPower Generic_pxHighlandsCampCultistSpawner { get; }

	ISnoPower Generic_pxLeoricsDungeonCampDemonSpawner { get; }

	ISnoPower Generic_pxOasisCampSnakemanSpawner { get; }

	ISnoPower Generic_pxQuestFollowerDamageSetup { get; }

	ISnoPower Generic_pxRampartsCampDemonSpawner { get; }

	ISnoPower Generic_pxRuinsFrostKingKanaiWhirlwind { get; }

	ISnoPower Generic_pxRuinsFrostThreeGuardiansGoatmanLeap { get; }

	ISnoPower Generic_pxSpiderCavesCampCocoonHumanVictim { get; }

	ISnoPower Generic_pxSpiderCavesCampSpiderSpawner { get; }

	ISnoPower Generic_pxSpireCampDemonSpawner { get; }

	ISnoPower Generic_pxStingingWindsCampCultistSpawner { get; }

	ISnoPower Generic_pxWestmarchCampReaperSpawner { get; }

	ISnoPower Generic_pxWildernessCampTemplarSpawner { get; }

	ISnoPower Generic_QuestCanyonBridgeEnchantressRevealFootsteps { get; }

	ISnoPower Generic_QuestCanyonBridgePlayerRevealFootsteps { get; }

	ISnoPower Generic_QuillDemonProjectile { get; }

	ISnoPower Generic_QuillDemonProjectileFastAttack { get; }

	ISnoPower Generic_RandomMovespeedScripted { get; }

	ISnoPower Generic_RangedEscortProjectile { get; }

	ISnoPower Generic_RatKingLifetimeBuff { get; }

	ISnoPower Generic_RedWingsBuff { get; }

	ISnoPower Generic_RemoveBurrowEffect { get; }

	ISnoPower Generic_ResurrectFallen { get; }

	ISnoPower Generic_ResurrectionBuff { get; }

	ISnoPower Generic_RockwormAttack { get; }

	ISnoPower Generic_RockwormBurrowAndTeleport { get; }

	ISnoPower Generic_RockwormBurstOut { get; }

	ISnoPower Generic_RockwormGrab { get; }

	ISnoPower Generic_RockwormGrabBurstOut { get; }

	ISnoPower Generic_RockwormHideIdle { get; }

	ISnoPower Generic_RockwormPreBurst { get; }

	ISnoPower Generic_RockwormRetreat { get; }

	ISnoPower Generic_RockwormWeb { get; }

	ISnoPower Generic_RootTryGrab { get; }

	ISnoPower Generic_SandMonsterBurrowOut { get; }

	ISnoPower Generic_SandMonsterBurrowOutLong { get; }

	ISnoPower Generic_SandMonsterSandWall { get; }

	ISnoPower Generic_SandmonsterWeaponMeleeInstant { get; }

	ISnoPower Generic_SandsharkBurrowIn { get; }

	ISnoPower Generic_SandsharkBurrowOut { get; }

	ISnoPower Generic_SandTornadoOnSpawn { get; }

	ISnoPower Generic_SandWaspProjectile { get; }

	ISnoPower Generic_ScavengerBurrowIn { get; }

	ISnoPower Generic_ScavengerBurrowOut { get; }

	ISnoPower Generic_ScavengerLeap { get; }

	ISnoPower Generic_ScoundrelAnatomy { get; }

	ISnoPower Generic_ScoundrelBandage { get; }

	ISnoPower Generic_ScoundrelCheatDeathPassive { get; }

	ISnoPower Generic_ScoundrelCripplingShot { get; }

	ISnoPower Generic_ScoundrelDebuffCloud { get; }

	ISnoPower Generic_ScoundrelHysteria { get; }

	ISnoPower Generic_ScoundrelPiercingShot { get; }

	ISnoPower Generic_ScoundrelPowerShot { get; }

	ISnoPower Generic_ScoundrelRangedProjectile { get; }

	ISnoPower Generic_ScoundrelRunAway { get; }

	ISnoPower Generic_ScoundrelVanishV2 { get; }

	ISnoPower Generic_ScrollBuff { get; }

	ISnoPower Generic_SeasonThemeBarbarianWhirlwind { get; }

	ISnoPower Generic_SelectingSkill { get; }

	ISnoPower Generic_SetItemBonusBuff { get; }

	ISnoPower Generic_SetModeEscortFollow { get; }

	ISnoPower Generic_ShieldSkeletonShield { get; }

	ISnoPower Generic_ShrineCallMonster { get; }

	ISnoPower Generic_ShrineDesecratedBlessed { get; }

	ISnoPower Generic_ShrineDesecratedEnlightened { get; }

	ISnoPower Generic_ShrineDesecratedFortune { get; }

	ISnoPower Generic_ShrineDesecratedFrenzied { get; }

	ISnoPower Generic_ShrineDesecratedHoarder { get; }

	ISnoPower Generic_ShrineDesecratedReloaded { get; }

	ISnoPower Generic_ShrineDesecratedtreasureGoblin { get; }

	ISnoPower Generic_ShrinePowerBlessed { get; }

	ISnoPower Generic_ShrinePowerEnlightened { get; }

	ISnoPower Generic_ShrinePowerFortune { get; }

	ISnoPower Generic_ShrinePowerFrenzied { get; }

	ISnoPower Generic_SidekickStatsBoostBuff { get; }

	ISnoPower Generic_SidekickWeaponDamageBoostBuff { get; }

	ISnoPower Generic_SiegebreakerDemonBite { get; }

	ISnoPower Generic_SiegebreakerDemonCharge { get; }

	ISnoPower Generic_SiegebreakerDemonChargeNew { get; }

	ISnoPower Generic_SiegebreakerDemonGrab { get; }

	ISnoPower Generic_SiegebreakerDemonGrabToBite { get; }

	ISnoPower Generic_SiegebreakerDemonLookAround { get; }

	ISnoPower Generic_SiegebreakerDemonMiniCharge { get; }

	ISnoPower Generic_SiegebreakerDemonPound { get; }

	ISnoPower Generic_SiegebreakerDemonRoar { get; }

	ISnoPower Generic_SiegebreakerDemonStomp { get; }

	ISnoPower Generic_SiegebreakerEnrage { get; }

	ISnoPower Generic_SiegeBreakerReflectsDamageCast { get; }

	ISnoPower Generic_SkeletonArcherProjectile { get; }

	ISnoPower Generic_SkeletonKingCleave { get; }

	ISnoPower Generic_SkeletonKingSummonSkeleton { get; }

	ISnoPower Generic_SkeletonKingTeleport { get; }

	ISnoPower Generic_SkeletonKingTeleportAway { get; }

	ISnoPower Generic_SkeletonKingWhirlwind { get; }

	ISnoPower Generic_skeletonMageColdprojectile { get; }

	ISnoPower Generic_skeletonMageFireAOE { get; }

	ISnoPower Generic_skeletonMageFireprojectile { get; }

	ISnoPower Generic_skeletonMageLightningpierce { get; }

	ISnoPower Generic_skeletonMagepoisondeath { get; }

	ISnoPower Generic_skeletonMagePoisonpierce { get; }

	ISnoPower Generic_SkeletonSummonerProjectile { get; }

	ISnoPower Generic_SkillOverrideStartedOrEnded { get; }

	ISnoPower Generic_SnakemanCasterElectricBurst { get; }

	ISnoPower Generic_SnakemanMeleeStealth { get; }

	ISnoPower Generic_SnakemanMeleeUnstealth { get; }

	ISnoPower Generic_SoaringAscend { get; }

	ISnoPower Generic_SoaringDescend { get; }

	ISnoPower Generic_SoulRipperDespairTongueLash { get; }

	ISnoPower Generic_SoulRipperTongueLash { get; }

	ISnoPower Generic_SpiderQueenVomitSpidersCharge { get; }

	ISnoPower Generic_SpiderQueenVomitSpidersVomit { get; }

	ISnoPower Generic_SpiderQueenWebSpit { get; }

	ISnoPower Generic_SpiderSprintThroughObjectsTo { get; }

	ISnoPower Generic_SpiderWebImmobolize { get; }

	ISnoPower Generic_SpiderWebSlow { get; }

	ISnoPower Generic_SpiderWebSlowSpit { get; }

	ISnoPower Generic_SplashDamageProc { get; }

	ISnoPower Generic_SporeCloud { get; }

	ISnoPower Generic_StealthBuff { get; }

	ISnoPower Generic_StitchExplode { get; }

	ISnoPower Generic_StitchMeleeAlternate { get; }

	ISnoPower Generic_StitchPush { get; }

	ISnoPower Generic_SuccubusBloodStar { get; }

	ISnoPower Generic_SuccubusBloodStarLR { get; }

	ISnoPower Generic_SuccubusFly { get; }

	ISnoPower Generic_SuccubusLeap { get; }

	ISnoPower Generic_SuicideProc { get; }

	ISnoPower Generic_SuicideScripted { get; }

	ISnoPower Generic_Summoned { get; }

	ISnoPower Generic_SummonFallenAUnique01 { get; }

	ISnoPower Generic_SummonFallenOnSpawn { get; }

	ISnoPower Generic_SummoningMachineSummon { get; }

	ISnoPower Generic_SummonSkeleton { get; }

	ISnoPower Generic_SummonSkeletonJondar { get; }

	ISnoPower Generic_SummonSkeletonOnSpawn { get; }

	ISnoPower Generic_SummonSkeletonOrb { get; }

	ISnoPower Generic_SummonSkeletonPillar { get; }

	ISnoPower Generic_SummonTriuneDemon { get; }

	ISnoPower Generic_SummonZombieCrawler { get; }

	ISnoPower Generic_SummonZombieVomit { get; }

	ISnoPower Generic_Swarmdeath { get; }

	ISnoPower Generic_TarPitSlowOff { get; }

	ISnoPower Generic_TarPitSlowOn { get; }

	ISnoPower Generic_TauntedMonsterRangedProjectile { get; }

	ISnoPower Generic_TauntedWeaponMeleeInstant { get; }

	ISnoPower Generic_TeleportCheckPathPassability { get; }

	ISnoPower Generic_TeleportToPlayer { get; }

	ISnoPower Generic_TeleportToPlayerCast { get; }

	ISnoPower Generic_TeleportToWaypoint { get; }

	ISnoPower Generic_TeleportToWaypointCast { get; }

	ISnoPower Generic_TemplarCheatDeathPassive { get; }

	ISnoPower Generic_TemplarGuardianV2 { get; }

	ISnoPower Generic_TemplarHeal110 { get; }

	ISnoPower Generic_TemplarInspire { get; }

	ISnoPower Generic_TemplarIntervene { get; }

	ISnoPower Generic_TemplarInterveneProc { get; }

	ISnoPower Generic_TemplarIntimidate { get; }

	ISnoPower Generic_TemplarLoyalty { get; }

	ISnoPower Generic_TemplarMeleeInstant { get; }

	ISnoPower Generic_TemplarOnslaught { get; }

	ISnoPower Generic_TemplarOnslaughtV2 { get; }

	ISnoPower Generic_TemplarShieldCharge { get; }

	ISnoPower Generic_TentacleHorseAUnique01Charge { get; }

	ISnoPower Generic_TerrorDemonMeleeStrike { get; }

	ISnoPower Generic_TerrorDemonShadowPhase { get; }

	ISnoPower Generic_TerrorDemonShadowPhaseEnd { get; }

	ISnoPower Generic_TestSpikeTrapRuins { get; }

	ISnoPower Generic_Thorns { get; }

	ISnoPower Generic_ThousandPounderKnockback { get; }

	ISnoPower Generic_ThousandPounderMelee { get; }

	ISnoPower Generic_tongueprototype { get; }

	ISnoPower Generic_TraitBarbarianFury { get; }

	ISnoPower Generic_TraitMonkSpirit { get; }

	ISnoPower Generic_TransformToActivatedTriune { get; }

	ISnoPower Generic_trDunCathWallCollapseDamage { get; }

	ISnoPower Generic_trDunCathWallCollapseDamageoffset { get; }

	ISnoPower Generic_TreasureGoblinAnniversaryEscape { get; }

	ISnoPower Generic_TreasureGoblinAnniversaryThrowPortal { get; }

	ISnoPower Generic_TreasureGoblinEscape { get; }

	ISnoPower Generic_TreasureGoblinPause { get; }

	ISnoPower Generic_TreasureGoblinPlayAlertSound { get; }

	ISnoPower Generic_TreasureGoblinPortalIn { get; }

	ISnoPower Generic_TreasureGoblinThrowPortal { get; }

	ISnoPower Generic_TreasureGoblinThrowPortalBackup { get; }

	ISnoPower Generic_TreasureGoblinThrowPortalFast { get; }

	ISnoPower Generic_TreasureGoblinUsePortal { get; }

	ISnoPower Generic_TriuneBerserkerPowerHit { get; }

	ISnoPower Generic_TriuneSummonerProjectile { get; }

	ISnoPower Generic_TriuneSummonerShield { get; }

	ISnoPower Generic_TriuneSummonerSplitSummonCast { get; }

	ISnoPower Generic_TriuneVesselCharge { get; }

	ISnoPower Generic_TriuneVesselOverpower { get; }

	ISnoPower Generic_trOutLogStackShortDamage { get; }

	ISnoPower Generic_trOutLogStackTrap { get; }

	ISnoPower Generic_trouttristramfieldspunjitrapaoe { get; }

	ISnoPower Generic_trouttristramfieldspunjitrapmirroraoe { get; }

	ISnoPower Generic_UberDespairMeleeCleave { get; }

	ISnoPower Generic_UberDespairSummonMinion { get; }

	ISnoPower Generic_UberDespairSummonMinionDiablo { get; }

	ISnoPower Generic_UberDespairTeleport { get; }

	ISnoPower Generic_UberDespairTeleportEnrageDiablo { get; }

	ISnoPower Generic_UberDespairVolley { get; }

	ISnoPower Generic_UberDespairVolleyDiablo { get; }

	ISnoPower Generic_UberDiabloMirrorImage { get; }

	ISnoPower Generic_UberDiabloStompAndStun { get; }

	ISnoPower Generic_UberGluttonyBreathAttack { get; }

	ISnoPower Generic_UberGluttonyGasCloud { get; }

	ISnoPower Generic_UberGluttonyGasCloudDiablo { get; }

	ISnoPower Generic_UberGluttonyLoogiespawn { get; }

	ISnoPower Generic_UberMaghdaMothDust { get; }

	ISnoPower Generic_UberMaghdaPunish { get; }

	ISnoPower Generic_UberMaghdaPunishShielded { get; }

	ISnoPower Generic_UberMaghdaSummonBeserker { get; }

	ISnoPower Generic_UberMaghdaSummonBeserkerDiablo { get; }

	ISnoPower Generic_UberSiegebreakerDemonPound { get; }

	ISnoPower Generic_UberSiegebreakerDemonStomp { get; }

	ISnoPower Generic_UberSkeletonKingCleave { get; }

	ISnoPower Generic_UberSkeletonKingSummonSkeleton { get; }

	ISnoPower Generic_UberSkeletonKingSummonSkeletonDiablo { get; }

	ISnoPower Generic_UberSkeletonKingWhirlwind { get; }

	ISnoPower Generic_UberZoltunKulleCollapseCeiling { get; }

	ISnoPower Generic_UberZoltunKulleEnergyTwister { get; }

	ISnoPower Generic_UberZoltunKulleFieryBoulder { get; }

	ISnoPower Generic_UberZoltunKulleSlowTime { get; }

	ISnoPower Generic_UberZoltunKulleSlowTimeDiablo { get; }

	ISnoPower Generic_UberZoltunKulleTeleport { get; }

	ISnoPower Generic_UnburiedBossCleave { get; }

	ISnoPower Generic_UnburiedKnockback { get; }

	ISnoPower Generic_UnburiedMeleeAttack { get; }

	ISnoPower Generic_UnburiedWreckableAttack { get; }

	ISnoPower Generic_UnholyShield { get; }

	ISnoPower Generic_UninterruptibleDuringBuff { get; }

	ISnoPower Generic_UniqueMonsterEarthquakePrototype { get; }

	ISnoPower Generic_UniqueMonsterGenericAOENova { get; }

	ISnoPower Generic_UniqueMonsterGenericAOERandomAroundOwner { get; }

	ISnoPower Generic_UniqueMonsterGenericAOETargeted { get; }

	ISnoPower Generic_UniqueMonsterGenericProjectile { get; }

	ISnoPower Generic_UniqueMonsterGenericProjectile2 { get; }

	ISnoPower Generic_UniqueMonsterGenericProjectileAllPlayers { get; }

	ISnoPower Generic_UniqueMonsterGenericSummon { get; }

	ISnoPower Generic_UniqueMonsterGenericSummon2 { get; }

	ISnoPower Generic_UniqueMonsterIceTrailPassivePrototype { get; }

	ISnoPower Generic_UniqueMonsterTempestRushPrototype { get; }

	ISnoPower Generic_UntargetableDuringBuff { get; }

	ISnoPower Generic_UrzaelStompAndStun { get; }

	ISnoPower Generic_UseArcaneGlyph { get; }

	ISnoPower Generic_UseDungeonStone { get; }

	ISnoPower Generic_UseHealthGlyph { get; }

	ISnoPower Generic_UseItem { get; }

	ISnoPower Generic_UseLootRunPortal { get; }

	ISnoPower Generic_UseLootRunProgressGlyph { get; }

	ISnoPower Generic_UseManaGlyph { get; }

	ISnoPower Generic_UseStoneOfRecall { get; }

	ISnoPower Generic_Walk { get; }

	ISnoPower Generic_WallMonsterSpawn { get; }

	ISnoPower Generic_WallMonsterSpawnSiegeBreaker { get; }

	ISnoPower Generic_Warp { get; }

	ISnoPower Generic_WarpInMagical { get; }

	ISnoPower Generic_waterloggedCorpseEelSpawn { get; }

	ISnoPower Generic_waterloggedCorpsePoisonCloud { get; }

	ISnoPower Generic_waterTowerAOasiscaOutBreakableDamage { get; }

	ISnoPower Generic_WeaponMeleeInstant { get; }

	ISnoPower Generic_WeaponMeleeInstantBothHand { get; }

	ISnoPower Generic_WeaponMeleeInstantCowKing { get; }

	ISnoPower Generic_WeaponMeleeInstantFreezeFacing { get; }

	ISnoPower Generic_WeaponMeleeInstantOffHand { get; }

	ISnoPower Generic_WeaponMeleeInstantShortEscape { get; }

	ISnoPower Generic_WeaponMeleeInstantWreckables { get; }

	ISnoPower Generic_WeaponMeleeNoClose { get; }

	ISnoPower Generic_WeaponMeleeObstruction { get; }

	ISnoPower Generic_WeaponMeleeReachInstant { get; }

	ISnoPower Generic_WeaponMeleeReachInstantFreezeFacing { get; }

	ISnoPower Generic_WeaponRangedInstant { get; }

	ISnoPower Generic_WeaponRangedProjectile { get; }

	ISnoPower Generic_WeaponRangedWand { get; }

	ISnoPower Generic_WitchdoctorCorpseSpiderLeap { get; }

	ISnoPower Generic_WitchdoctorFetishArmyHunter { get; }

	ISnoPower Generic_WitchdoctorFetishArmyMelee { get; }

	ISnoPower Generic_WitchdoctorFetishArmyPoisonDart { get; }

	ISnoPower Generic_WitchdoctorFetishArmyShaman { get; }

	ISnoPower Generic_WitchdoctorFetishSycophantsMelee { get; }

	ISnoPower Generic_WitchdoctorGargantuanCleave { get; }

	ISnoPower Generic_WitchdoctorGargantuanPoisonCloud { get; }

	ISnoPower Generic_WitchdoctorGargantuanSlam { get; }

	ISnoPower Generic_WitchdoctorGargantuanSmash { get; }

	ISnoPower Generic_WitchdoctorHexChickenWalk { get; }

	ISnoPower Generic_WitchdoctorHexExplode { get; }

	ISnoPower Generic_WitchdoctorHexFetish { get; }

	ISnoPower Generic_WitchdoctorHexFetishHeal { get; }

	ISnoPower Generic_WitchdoctorPlagueOfToadsBigToadAttack { get; }

	ISnoPower Generic_WitchdoctorPlagueOfToadsBigToadTongueSlap { get; }

	ISnoPower Generic_WitchdoctorSpiritBarrageRuneCAOE { get; }

	ISnoPower Generic_WitchdoctorZombieDogFireAoE { get; }

	ISnoPower Generic_WitchdoctorZombieDogMelee { get; }

	ISnoPower Generic_WitchdoctorZombieDogPoisonDoT { get; }

	ISnoPower Generic_WizardArcaneTorrentRuneCMine { get; }

	ISnoPower Generic_WizardEnergyShield { get; }

	ISnoPower Generic_WizardHydraDefaultFirePrototype { get; }

	ISnoPower Generic_WizardHydraRuneAcidPrototype { get; }

	ISnoPower Generic_WizardHydraRuneArcanePrototype { get; }

	ISnoPower Generic_WizardHydraRuneBigPrototype { get; }

	ISnoPower Generic_WizardHydraRuneFirePrototype { get; }

	ISnoPower Generic_WizardHydraRuneFrostPrototype { get; }

	ISnoPower Generic_WizardHydraRuneLightningPrototype { get; }

	ISnoPower Generic_WizardMagicMissileCount { get; }

	ISnoPower Generic_WizardMagicMissileDamage { get; }

	ISnoPower Generic_WizardMagicMissileSpeed { get; }

	ISnoPower Generic_WoDFlagBuff { get; }

	ISnoPower Generic_WoodWraithSummonSpores { get; }

	ISnoPower Generic_WorldCreatingBuff { get; }

	ISnoPower Generic_x1abattoirfurnace01 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinner { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerEvent { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase1 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase2 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerEventPhase3 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwise { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEvent { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase1 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase2 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamclockwiseEventPhase3 { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwise { get; }

	ISnoPower Generic_x1AbattoirfurnaceSpinnerfireBeamcounterClockwiseEvent { get; }

	ISnoPower Generic_x1AbattoirfurnaceWall { get; }

	ISnoPower Generic_x1AdriaArenaFloorPanelFire { get; }

	ISnoPower Generic_x1AdriaArenaFloorPanelStart { get; }

	ISnoPower Generic_X1AdriaBossArenaGasOff0 { get; }

	ISnoPower Generic_X1AdriaBossArenaGasOff1 { get; }

	ISnoPower Generic_X1AdriaBossArenaGasOn0 { get; }

	ISnoPower Generic_X1AdriaBossArenaGasOn1 { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerActivate { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerInitialPoolsBuff { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerLifetimeBuff { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerRoomPools { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsInner { get; }

	ISnoPower Generic_x1AdriaCauldronSpawnerRoomPoolsOuter { get; }

	ISnoPower Generic_x1AdriaDelayedTeleportAttack { get; }

	ISnoPower Generic_x1AdriaDelayedTeleportCauldronActivate { get; }

	ISnoPower Generic_x1AdriaDelayedTeleportStart { get; }

	ISnoPower Generic_x1AdriaJumpBack { get; }

	ISnoPower Generic_x1AdriaPhaseOneAIState { get; }

	ISnoPower Generic_x1AdriaPhaseTwoAIState { get; }

	ISnoPower Generic_x1AdriaScriptedSequence180Turn { get; }

	ISnoPower Generic_x1AdriaSpitAtPlayer { get; }

	ISnoPower Generic_x1AdriaWingSweepLeft { get; }

	ISnoPower Generic_x1AdriaWingSweepRight { get; }

	ISnoPower Generic_X1armorScavengerAsteroidRain { get; }

	ISnoPower Generic_x1armorScavengerbuff { get; }

	ISnoPower Generic_x1armorScavengerBurrowIn { get; }

	ISnoPower Generic_x1armorScavengerBurrowOut { get; }

	ISnoPower Generic_x1armorScavengerPreBurrow { get; }

	ISnoPower Generic_X1AsteroidBasic { get; }

	ISnoPower Generic_X1AsteroidBasicSmall { get; }

	ISnoPower Generic_X1AsteroidPool { get; }

	ISnoPower Generic_X1AsteroidSpawn { get; }

	ISnoPower Generic_X1BarbarianAvalanchev2Passive { get; }

	ISnoPower Generic_X1BloodhawkEventBallistaBossFuriousCharge { get; }

	ISnoPower Generic_x1bogbearTrap { get; }

	ISnoPower Generic_x1BogBearTrapTrigger { get; }

	ISnoPower Generic_x1BogBlightBurrowIn { get; }

	ISnoPower Generic_x1BogBlightBurrowOut { get; }

	ISnoPower Generic_x1BogBlightPustuleDeath { get; }

	ISnoPower Generic_x1BogBlightPustuleSpawn { get; }

	ISnoPower Generic_x1BogBlightPustuleSpawnCon { get; }

	ISnoPower Generic_x1BogBogWater { get; }

	ISnoPower Generic_x1BogBogWaterlarge { get; }

	ISnoPower Generic_x1BogBogWatermedium { get; }

	ISnoPower Generic_x1BogFamilyBruteCharge { get; }

	ISnoPower Generic_x1BogFamilyBruteShout { get; }

	ISnoPower Generic_x1BogFamilyBruteSummonMeleeAction { get; }

	ISnoPower Generic_x1BogFamilyBruteSummonMeleeActionUnique { get; }

	ISnoPower Generic_x1BogFamilyBruteThrowDude { get; }

	ISnoPower Generic_X1BogFamilyGuardTowerSetup { get; }

	ISnoPower Generic_x1BogFamilyMeleeTransform { get; }

	ISnoPower Generic_x1BogFamilyRangedBearTrap { get; }

	ISnoPower Generic_x1BogFamilyRangedBearTrapFromTower { get; }

	ISnoPower Generic_x1BogFamilyRangedBearTrapFromTowerReturnToFacing { get; }

	ISnoPower Generic_x1BogFamilyRangedRapidShot { get; }

	ISnoPower Generic_x1BogFamilyRangedRapidShotFromTower { get; }

	ISnoPower Generic_x1BogFamilyRangedRapidShotFromTowerReturnToFacing { get; }

	ISnoPower Generic_X1BogKingOfTheHillLeap { get; }

	ISnoPower Generic_x1BogPlantexplodeKnockback { get; }

	ISnoPower Generic_x1CatacombsDoorAonDeath { get; }

	ISnoPower Generic_x1CatacombsFloorRunesAonDeath { get; }

	ISnoPower Generic_x1CatacombsSpiritTotemactivate { get; }

	ISnoPower Generic_x1CesspoolSlimePosionAttack { get; }

	ISnoPower Generic_x1ChallengeBuffImmuneStun { get; }

	ISnoPower Generic_X1ChallengeLureSupersizeLure { get; }

	ISnoPower Generic_x1CrazedAngelArcherFireArrow { get; }

	ISnoPower Generic_X1CrusaderLawsOfFate { get; }

	ISnoPower Generic_X1CrusaderLawsOfFatePassive { get; }

	ISnoPower Generic_X1CrusaderLawsOfHope { get; }

	ISnoPower Generic_X1CrusaderLawsOfHopePassive { get; }

	ISnoPower Generic_X1CrusaderLawsOfHopePassive2 { get; }

	ISnoPower Generic_X1CrusaderLawsOfJustice { get; }

	ISnoPower Generic_X1CrusaderLawsOfJusticePassive { get; }

	ISnoPower Generic_X1CrusaderLawsOfJusticePassive2 { get; }

	ISnoPower Generic_X1CrusaderLawsOfValor { get; }

	ISnoPower Generic_X1CrusaderLawsOfValorPassive { get; }

	ISnoPower Generic_X1CrusaderLawsOfValorPassive2 { get; }

	ISnoPower Generic_x1CrusaderPhalanxArcherRangedProjectile { get; }

	ISnoPower Generic_X1CrusaderPhalanxBasicMelee { get; }

	ISnoPower Generic_x1DarkAngelDeath { get; }

	ISnoPower Generic_x1DarkAngelSoulRush { get; }

	ISnoPower Generic_x1DarkAngelSummon { get; }

	ISnoPower Generic_x1deathMaidenPowerSlamLRBoss { get; }

	ISnoPower Generic_x1deathMaidenPowerSlamPrototype { get; }

	ISnoPower Generic_x1deathMaidenSpinAttackMortarLRBoss { get; }

	ISnoPower Generic_x1deathMaidenSpinAttackPrototype { get; }

	ISnoPower Generic_x1deathMaidenSummonprototype { get; }

	ISnoPower Generic_x1deathMaidenSummonprototypeextraskeletons { get; }

	ISnoPower Generic_x1DeathMaidenUniqueFireAbattoirFurnaceFireWreath { get; }

	ISnoPower Generic_x1DetonateDOTBuffs { get; }

	ISnoPower Generic_X1DHCompanionBoarIntervene { get; }

	ISnoPower Generic_x1FloaterAngelLightningBeam { get; }

	ISnoPower Generic_x1FloaterAngelLightningBeamMalthael { get; }

	ISnoPower Generic_x1FloaterAngelTeleport { get; }

	ISnoPower Generic_x1FloaterAngelTransform { get; }

	ISnoPower Generic_x1FloaterAngelTransformMalthael { get; }

	ISnoPower Generic_X1FortressBVisuals { get; }

	ISnoPower Generic_X1FortressJudgeEventSpawnKnockback { get; }

	ISnoPower Generic_x1FortressPortalSwitch { get; }

	ISnoPower Generic_X1FortressPortalSwitchCheckMonsters { get; }

	ISnoPower Generic_X1FortressPortalSwitchTeleportMonster { get; }

	ISnoPower Generic_x1FortressRotatingDoor { get; }

	ISnoPower Generic_X1GenericBreakWallsBuff { get; }

	ISnoPower Generic_x1GhostDarkSoulSiphon { get; }

	ISnoPower Generic_x1GhostSoulSiphon { get; }

	ISnoPower Generic_x1GhostSoulSiphonFire { get; }

	ISnoPower Generic_x1GhostWalkThroughWalls { get; }

	ISnoPower Generic_x1GreedDeath { get; }

	ISnoPower Generic_x1GreedDeathAncient { get; }

	ISnoPower Generic_x1ImperiusCleave { get; }

	ISnoPower Generic_X1ImperiusEnemyOrNothing { get; }

	ISnoPower Generic_x1ImperiusLeapSmash { get; }

	ISnoPower Generic_x1ImperiusWingsBuff { get; }

	ISnoPower Generic_X1Kylacheer { get; }

	ISnoPower Generic_X1Kylafalldownanimation { get; }

	ISnoPower Generic_X1Kylashieldup { get; }

	ISnoPower Generic_X1LegendaryAIRunToGuaranteedSpider { get; }

	ISnoPower Generic_X1LegendaryGenericPotionPowerup { get; }

	ISnoPower Generic_X1LifetimeBuffAbsorbNonPlayerDamage { get; }

	ISnoPower Generic_X1LRBossBigRedIzualFrostNova { get; }

	ISnoPower Generic_x1LRBossButcherSpears { get; }

	ISnoPower Generic_x1LRBossDarkAngelSoulRush { get; }

	ISnoPower Generic_x1LRBossDarkAngelSummon { get; }

	ISnoPower Generic_x1LRBossDarkAngelWave { get; }

	ISnoPower Generic_X1LRBossdemonFlyerMegaFireBreath { get; }

	ISnoPower Generic_X1LRBossExpandingFireRing { get; }

	ISnoPower Generic_X1LRBossFireNova { get; }

	ISnoPower Generic_X1LRBossGenericTaunt { get; }

	ISnoPower Generic_X1LRBossMorluSpellcasterMeteor { get; }

	ISnoPower Generic_x1LRBossmorluSpellcasterWeaponMeleeInstant { get; }

	ISnoPower Generic_X1LRBossRatKingBurrowSetup { get; }

	ISnoPower Generic_X1LRBossRatKingDeadPlayerTaunt { get; }

	ISnoPower Generic_X1LRBossRatKingDeadPlayerTauntSearch { get; }

	ISnoPower Generic_X1LRBossRatKingOnDeath { get; }

	ISnoPower Generic_x1LRBossSandmonsterOnDeath { get; }

	ISnoPower Generic_x1LRBossSharedCooldown { get; }

	ISnoPower Generic_X1LRBossSkeletonKingSummonSkeleton { get; }

	ISnoPower Generic_X1LRBossSkeletonKingWhirlwind { get; }

	ISnoPower Generic_X1LRBossSkeletonSummonerProjectile { get; }

	ISnoPower Generic_X1LRBossSkeletonSummonerProjectileB { get; }

	ISnoPower Generic_X1LRBossSkeletonSummonerProjectileC { get; }

	ISnoPower Generic_x1LRBossSkeletonSummonerSummoning { get; }

	ISnoPower Generic_X1LRBossSuccubusFirestorm { get; }

	ISnoPower Generic_X1LRBossSummonCoreElites { get; }

	ISnoPower Generic_X1LRCreepMobHerdingAttack { get; }

	ISnoPower Generic_X1LRCreepMobMultipleArmAttack { get; }

	ISnoPower Generic_X1LRCreepMobRangedArmLineAttack { get; }

	ISnoPower Generic_x1MalthaelBaalAIState { get; }

	ISnoPower Generic_x1MalthaelBaalFesteringAppendageMelee { get; }

	ISnoPower Generic_x1MalthaelBaalHoarfrost { get; }

	ISnoPower Generic_x1MalthaelBaalRift { get; }

	ISnoPower Generic_x1MalthaelBaalSummonFesteringAppendages { get; }

	ISnoPower Generic_x1MalthaelDeathFogMonsterSetup { get; }

	ISnoPower Generic_x1MalthaelDiabloAIState { get; }

	ISnoPower Generic_x1MalthaelDiabloTeleportFireNovaLightning { get; }

	ISnoPower Generic_X1MalthaelDrainSoul { get; }

	ISnoPower Generic_x1MalthaelHealthGlobeDropper { get; }

	ISnoPower Generic_x1MalthaelMephistoAIState { get; }

	ISnoPower Generic_x1MalthaelMephistoPoisonCloud { get; }

	ISnoPower Generic_x1MalthaelMephistoSkullMissile { get; }

	ISnoPower Generic_x1MalthaelMephistoSpawnInvisLightningProxies { get; }

	ISnoPower Generic_x1MalthaelMephistoSpiralLightningInward { get; }

	ISnoPower Generic_x1MalthaelMephistoSummonRotatingLightning { get; }

	ISnoPower Generic_x1MalthaelMephistoTeleportExplodeOrbs { get; }

	ISnoPower Generic_x1MalthaelOnDeath { get; }

	ISnoPower Generic_x1MalthaelPhaseOneAIState { get; }

	ISnoPower Generic_x1MalthaelPhaseThreeAIState { get; }

	ISnoPower Generic_x1MalthaelPhaseTwoAIState { get; }

	ISnoPower Generic_X1MalthaelSickleThrowTeleport { get; }

	ISnoPower Generic_x1MalthaelSpiritDeath { get; }

	ISnoPower Generic_x1MalthaelSpiritFog { get; }

	ISnoPower Generic_X1MalthaelSummonDeathFogMonster { get; }

	ISnoPower Generic_X1MalthaelSummonFloaterAngel { get; }

	ISnoPower Generic_x1MalthaelSwordShieldStart { get; }

	ISnoPower Generic_x1MalthaelSwordShieldStop { get; }

	ISnoPower Generic_x1MoleMutantEnragedCombo { get; }

	ISnoPower Generic_x1MoleMutantRangedJumpBackShot { get; }

	ISnoPower Generic_x1MoleMutantRangedProjectile { get; }

	ISnoPower Generic_x1MoleMutantShamanBlast { get; }

	ISnoPower Generic_x1MoleMutantShamanResurrect { get; }

	ISnoPower Generic_X1MonkMysticAllyRuneAExplode { get; }

	ISnoPower Generic_X1MonkMysticAllyRuneATagForExplosion { get; }

	ISnoPower Generic_X1MonkMysticAllyv2Passive { get; }

	ISnoPower Generic_X1MonkMysticAllyv3Passive { get; }

	ISnoPower Generic_X1MonsterAffixAvengerCorpseBomberRare { get; }

	ISnoPower Generic_X1MonsterAffixAvengerCorpseBomberRareCast { get; }

	ISnoPower Generic_X1MonsterAffixAvengerLightningStorm { get; }

	ISnoPower Generic_X1MonsterAffixAvengerLightningStormCast { get; }

	ISnoPower Generic_X1MonsterAffixAvengerOrbiter { get; }

	ISnoPower Generic_X1MonsterAffixAvengerOrbiterCast { get; }

	ISnoPower Generic_X1MonsterAffixCorpseBomber { get; }

	ISnoPower Generic_X1MonsterAffixCorpseBomberCast { get; }

	ISnoPower Generic_X1MonsterAffixCorpseBomberRare { get; }

	ISnoPower Generic_X1MonsterAffixCorpseBomberRareCast { get; }

	ISnoPower Generic_X1MonsterAffixLightningStorm { get; }

	ISnoPower Generic_x1MonsterAffixLightningStormAIClose { get; }

	ISnoPower Generic_X1MonsterAffixLightningStormCast { get; }

	ISnoPower Generic_X1MonsterAffixLightningStormChampion { get; }

	ISnoPower Generic_X1MonsterAffixLightningStormKillSelf { get; }

	ISnoPower Generic_X1MonsterAffixLightningStormPulse { get; }

	ISnoPower Generic_X1MonsterAffixLightningStormTagTarget { get; }

	ISnoPower Generic_X1MonsterAffixOrbiter { get; }

	ISnoPower Generic_X1MonsterAffixOrbiterCast { get; }

	ISnoPower Generic_X1MonsterAffixOrbiterChampion { get; }

	ISnoPower Generic_X1MonsterAffixOrbiterChampionCast { get; }

	ISnoPower Generic_X1MonsterAffixTeleportMines { get; }

	ISnoPower Generic_X1MonsterAffixTeleportMinesCast { get; }

	ISnoPower Generic_X1NegativeHealthGlobeFlash { get; }

	ISnoPower Generic_x1NightScreamerAllyBiteTransform { get; }

	ISnoPower Generic_x1NightScreamerCanTransform { get; }

	ISnoPower Generic_X1NightScreamerFuriousCharge { get; }

	ISnoPower Generic_x1NightScreamerScreamAttack { get; }

	ISnoPower Generic_x1NPCWestmarchAldritchCrushingResolve { get; }

	ISnoPower Generic_x1PandBruteDecapitateSlide { get; }

	ISnoPower Generic_X1pandemoniumideationtimeStopBuff { get; }

	ISnoPower Generic_x1PandExtCollapsingPillar { get; }

	ISnoPower Generic_x1PandExtEventgreatWeaponbossSuckIn { get; }

	ISnoPower Generic_x1PandExtEventgreatWeaponfireEnergyPulses { get; }

	ISnoPower Generic_x1PandExtEventgreatWeaponsummonBoss { get; }

	ISnoPower Generic_x1PandExtEventgreatWeaponsummonMonsters { get; }

	ISnoPower Generic_x1PandExtideationbaconbeaconOnDeath { get; }

	ISnoPower Generic_x1PandExtIdeationWarSpawnerAngel { get; }

	ISnoPower Generic_x1PandExtIdeationWarSpawnerDemon { get; }

	ISnoPower Generic_x1PandExtImperiusChargetowerschains { get; }

	ISnoPower Generic_x1PandExtImperiusChargeTowersSetup { get; }

	ISnoPower Generic_X1PandExtRamKnockback { get; }

	ISnoPower Generic_x1pandExtRangedPrototype { get; }

	ISnoPower Generic_x1pandExtRangedPrototypeStrafeLeft { get; }

	ISnoPower Generic_x1pandExtRangedPrototypeStrafeRight { get; }

	ISnoPower Generic_X1PandExtTimeTrap { get; }

	ISnoPower Generic_X1PandFortressOrdnanceChronoField { get; }

	ISnoPower Generic_X1PandFortressOrdnanceMine { get; }

	ISnoPower Generic_X1PandFortressOrdnanceShocker { get; }

	ISnoPower Generic_X1PandHexMazePortalChampSummon { get; }

	ISnoPower Generic_X1PandIntSplitMonstermerge { get; }

	ISnoPower Generic_X1PandIntSplitMonstersplit { get; }

	ISnoPower Generic_x1PandLeaperAngelLeap { get; }

	ISnoPower Generic_x1PandMazePortalTestPower { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerBloone { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerBorgoth { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerGrotescor { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerHaziael { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerMagrethar { get; }

	ISnoPower Generic_x1PandMazePortalTestPowerSeverag { get; }

	ISnoPower Generic_x1PandRockwormBurstOut { get; }

	ISnoPower Generic_x1PandSniperAngelcloseRangedAttack { get; }

	ISnoPower Generic_x1PandSniperAngelcloseRangedAttackLRBoss { get; }

	ISnoPower Generic_x1PandSniperAngelrangedAttack { get; }

	ISnoPower Generic_x1PandSniperAngelrangedAttackLRBoss { get; }

	ISnoPower Generic_X1PassiveBountyScroll { get; }

	ISnoPower Generic_X1PassiveBountyScrollBeastDamage { get; }

	ISnoPower Generic_X1PassiveBountyScrollBossDamage { get; }

	ISnoPower Generic_X1PassiveBountyScrollDemonDamage { get; }

	ISnoPower Generic_X1PassiveBountyScrollEliteDamage { get; }

	ISnoPower Generic_X1PassiveBountyScrollExperience { get; }

	ISnoPower Generic_X1PassiveBountyScrollLifeRegen { get; }

	ISnoPower Generic_X1PassiveBountyScrollRunSpeed { get; }

	ISnoPower Generic_X1PassiveBountyScrollUndeadDamage { get; }

	ISnoPower Generic_X1PlaguedLacuniMaleSummon { get; }

	ISnoPower Generic_x1PlaguedLacuniSpecialMelee { get; }

	ISnoPower Generic_x1portalGuardianMinionprojectile { get; }

	ISnoPower Generic_x1PortalGuardianTurning { get; }

	ISnoPower Generic_x1PortalMonsterBurrowIn { get; }

	ISnoPower Generic_x1PortalMonsterBurrowOut { get; }

	ISnoPower Generic_x1PortalMonsterLifetimeBuff { get; }

	ISnoPower Generic_X1PortalMonsterPortalSummon { get; }

	ISnoPower Generic_X1PortalMonsterRoarSummon { get; }

	ISnoPower Generic_X1PortalMonsterStomp { get; }

	ISnoPower Generic_x1PortalMonsterSwipe { get; }

	ISnoPower Generic_x1RockFodderCharge { get; }

	ISnoPower Generic_X1RockFodderFuriousCharge { get; }

	ISnoPower Generic_X1RockFodderFuriousChargeRockHiveQueen { get; }

	ISnoPower Generic_x1RockFodderTumble { get; }

	ISnoPower Generic_x1rockwormpandprojectile { get; }

	ISnoPower Generic_X1SandmonsterpetWeaponMeleeInstant { get; }

	ISnoPower Generic_X1SandmonsterWeaponMeleeInstant { get; }

	ISnoPower Generic_x1ScaryEyesBurrowInHidden { get; }

	ISnoPower Generic_x1ScaryEyesBurrowOut { get; }

	ISnoPower Generic_x1ScaryEyescharge { get; }

	ISnoPower Generic_X1ScoundrelMultishot { get; }

	ISnoPower Generic_X1ScoundrelMultishotPassive { get; }

	ISnoPower Generic_X1ShardPassiveFakeGlobes { get; }

	ISnoPower Generic_X1ShardPassiveMinResource { get; }

	ISnoPower Generic_x1SkeletonArcherFireArrow { get; }

	ISnoPower Generic_x1SkeletonArcherFireArrowBackpedal { get; }

	ISnoPower Generic_x1SkeletonStab { get; }

	ISnoPower Generic_x1SkeletonStrafe { get; }

	ISnoPower Generic_X1SnitchleyTreasureGoblinEscape { get; }

	ISnoPower Generic_X1SpectralHoundBuff { get; }

	ISnoPower Generic_X1SummonVanityPet { get; }

	ISnoPower Generic_X1tempballistaswitchleap { get; }

	ISnoPower Generic_x1UberDiabloHellSpikes { get; }

	ISnoPower Generic_x1UdderLightning { get; }

	ISnoPower Generic_x1UniqueNPCEnchantressForcefulPush { get; }

	ISnoPower Generic_x1UniqueNPCEnchantressMassCharm { get; }

	ISnoPower Generic_x1UniqueNPCEnchantressScorchedEarth { get; }

	ISnoPower Generic_x1UniqueNPCTemplarHeal { get; }

	ISnoPower Generic_x1UniqueNPCTemplarOnslaught { get; }

	ISnoPower Generic_x1UniqueNPCTemplarShieldCharge { get; }

	ISnoPower Generic_x1UniqueTriuneSummonerProjectile { get; }

	ISnoPower Generic_x1UrzaelCannonball { get; }

	ISnoPower Generic_x1UrzaelCannonballBurning { get; }

	ISnoPower Generic_x1UrzaelCeilingDebris { get; }

	ISnoPower Generic_x1UrzaelCeilingDebrisBurning { get; }

	ISnoPower Generic_x1UrzaelFlameSweep { get; }

	ISnoPower Generic_x1UrzaelLeapKnockback { get; }

	ISnoPower Generic_x1UrzaelMeleeInstant { get; }

	ISnoPower Generic_x1UrzaelPhaseOneAIState { get; }

	ISnoPower Generic_x1UrzaelPhaseTwoAIState { get; }

	ISnoPower Generic_x1WestmarchBruteBChargeCustomLRBoss { get; }

	ISnoPower Generic_x1WestmarchBruteBChargeCustomLRBossHulkmode { get; }

	ISnoPower Generic_x1WestmarchBruteCharge { get; }

	ISnoPower Generic_x1WestmarchBruteDecapitate { get; }

	ISnoPower Generic_x1WestmarchBruteVomit { get; }

	ISnoPower Generic_X1WestmarchHoundDeadPlayerTaunt { get; }

	ISnoPower Generic_X1WestmarchHoundDeadPlayerTauntSearch { get; }

	ISnoPower Generic_X1WestmarchHoundShakeTarget { get; }

	ISnoPower Generic_x1westmarchRangedRangedAttackPrototype { get; }

	ISnoPower Generic_x1westmarchRangedSlowAreaDenialPrototype { get; }

	ISnoPower Generic_x1WestmarchRatCharge { get; }

	ISnoPower Generic_x1WestmarchRatKamikaze { get; }

	ISnoPower Generic_X1WestmConvert { get; }

	ISnoPower Generic_X1WestmConvert2 { get; }

	ISnoPower Generic_X1WestmConvertAoE { get; }

	ISnoPower Generic_X1WestmConvertDelayedStart2 { get; }

	ISnoPower Generic_X1WestmConvertDelayedStartFromTarget { get; }

	ISnoPower Generic_X1WestmConvertScripted { get; }

	ISnoPower Generic_X1westmdoomedWomanvisual { get; }

	ISnoPower Generic_x1westmHoistTriggeronDeathPower { get; }

	ISnoPower Generic_x1westmideationeventRATZNGGOLD { get; }

	ISnoPower Generic_x1westmSoulSummonerOrbSummonNearTarget { get; }

	ISnoPower Generic_X1westmSoulsummonersetup { get; }

	ISnoPower Generic_X1westmSoulSummonerSummon { get; }

	ISnoPower Generic_X1westmUniqueghostLordshockwave { get; }

	ISnoPower Generic_x1WickermanAggro { get; }

	ISnoPower Generic_X1WickerManFireNova { get; }

	ISnoPower Generic_X1WickerManFirePhantom { get; }

	ISnoPower Generic_x1WickermanSuicide { get; }

	ISnoPower Generic_x1WraithChargeClose { get; }

	ISnoPower Generic_X1WraithMelee { get; }

	ISnoPower Generic_X1WraithPiercingDash { get; }

	ISnoPower Generic_X1X1EventSpeedKillChampionSpawner { get; }

	ISnoPower Generic_X1X1EventSpeedKillSpawner { get; }

	ISnoPower Generic_x1ZombieFemaleProjectilePoison { get; }

	ISnoPower Generic_ZKBallSummonSkeleton { get; }

	ISnoPower Generic_zoltsmallFloorSpawner { get; }

	ISnoPower Generic_zoltTabletstateChange { get; }

	ISnoPower Generic_ZoltunKulleCollapseCeiling { get; }

	ISnoPower Generic_ZoltunKulleEnergyTwister { get; }

	ISnoPower Generic_ZoltunKulleFieryBoulder { get; }

	ISnoPower Generic_ZoltunKulleSlowTime { get; }

	ISnoPower Generic_ZoltunKulleTeleport { get; }

	ISnoPower Generic_ZoltunKulleTeleportToPlayer { get; }

	ISnoPower Generic_ZoltunKulleTeleportToPlayerEnrage { get; }

	ISnoPower Generic_ZombieEatStart { get; }

	ISnoPower Generic_ZombieEatStop { get; }

	ISnoPower Generic_ZombieFemaleProjectile { get; }

	ISnoPower Generic_ZombieKillerGrab { get; }

	ISnoPower DemonHunter_P74Ballista { get; }

	ISnoPower Monk_P74WayOfTheHundredFists { get; }

	ISnoPower VigilanteBelt { get; }

	ISnoPower Generic_CommunityBuffNestingPortalSpawn { get; }

	ISnoPower Generic_MonsterAffixLethargy { get; }

	ISnoPower Generic_MonsterAffixNecrotic { get; }

	ISnoPower Generic_MonsterAffixNecroticQAtest { get; }

	ISnoPower Generic_MonsterAffixResourceSteal { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Alcarnus { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76BloodPit { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Bog { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Boneyard { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Church { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76ForestTower { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GideonsCourt { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76GravyardAct1 { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Hell { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76MoorsSacrifice { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76NewTristram { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76OldTristram { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76PandBatteringRam { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Sescheron { get; }

	ISnoPower Generic_P76ItemPassiveNestingWorldSpawnP76Spire { get; }

	ISnoPower Generic_P76ItemPassiveSpawnChest001 { get; }

	ISnoPower Generic_itemPassiveUniqueAmulet003 { get; }

	ISnoPower Generic_itemPassiveUniqueAmulet011 { get; }

	ISnoPower Generic_ItemPassiveUniqueAmulet017x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueAmulet105x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueAxe1H003 { get; }

	ISnoPower Generic_ItemPassiveUniqueAxe1H005 { get; }

	ISnoPower Generic_ItemPassiveUniqueAxe1H005x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueAxe2H010 { get; }

	ISnoPower Generic_ItemPassiveUniqueAxe2H012x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueBarbBelt003 { get; }

	ISnoPower Generic_ItemPassiveUniqueBelt016x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueBoots007 { get; }

	ISnoPower Generic_ItemPassiveUniqueBoots007x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueBoots020x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueBow008 { get; }

	ISnoPower Generic_ItemPassiveUniqueBow015 { get; }

	ISnoPower Generic_ItemPassiveUniqueBow015x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueBracer105x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueCeremonialDagger002 { get; }

	ISnoPower Generic_ItemPassiveUniqueCeremonialDagger008 { get; }

	ISnoPower Generic_ItemPassiveUniqueDagger010 { get; }

	ISnoPower Generic_ItemPassiveUniqueDagger010x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueDagger103x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueHandXBow012 { get; }

	ISnoPower Generic_itemPassiveUniqueHelm003 { get; }

	ISnoPower Generic_itemPassiveUniqueHelm003x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueHelm017x1 { get; }

	ISnoPower Generic_itemPassiveUniqueMace1H002 { get; }

	ISnoPower Generic_ItemPassiveUniqueMace2H003 { get; }

	ISnoPower Generic_ItemPassiveUniqueMace2H009 { get; }

	ISnoPower Generic_ItemPassiveUniqueMace2H009x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueMighty1H006 { get; }

	ISnoPower Generic_ItemPassiveUniqueMighty1H006p3 { get; }

	ISnoPower Generic_ItemPassiveUniqueMighty1H006x1 { get; }

	ISnoPower Generic_itemPassiveUniquePants007 { get; }

	ISnoPower Generic_itemPassiveUniquePants007x1 { get; }

	ISnoPower Generic_ItemPassiveUniquePolearm001 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing025x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing505x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing508x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing510x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing521x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing528x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing551x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing555x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing557x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing560x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing565x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing568x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing576x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing579x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing594x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing602x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing604x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing607x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing609x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing610x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing611x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing612x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing615x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing620x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing622x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing623x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing643x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing644x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing645x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing646x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing647x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing648p2 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing648x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing649x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing651x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing655x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing664x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing667x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing670x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing687x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing697x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing703x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing705x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing707x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing708x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing742x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing749x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing751x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing753x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing755x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing761x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing762x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing903x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing905x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing906x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing911x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueRing912x1 { get; }

	ISnoPower Generic_itemPassiveUniqueShield008 { get; }

	ISnoPower Generic_ItemPassiveUniqueShoulder002 { get; }

	ISnoPower Generic_ItemPassiveUniqueShoulder002x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueShoulder103x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueSword1H004 { get; }

	ISnoPower Generic_ItemPassiveUniqueSword1H012 { get; }

	ISnoPower Generic_ItemPassiveUniqueSword1H012x1 { get; }

	ISnoPower Generic_ItemPassiveUniqueSword2H004 { get; }

	ISnoPower Generic_ItemPassiveUniqueSword2H010 { get; }

	ISnoPower Generic_itemPassiveUniqueWizardHat004 { get; }

	ISnoPower Generic_ItemPassiveUniqueXBow001 { get; }

	ISnoPower Generic_ItemPassiveUniqueXBow011 { get; }

	ISnoPower Generic_ItemPassiveUniqueXBow012 { get; }

	ISnoPower Generic_LewisItemPassiveTest { get; }

	ISnoPower Generic_p1ItemPassiveUniqueRing942 { get; }

	ISnoPower Generic_p1ItemPassiveUniqueRing943 { get; }

	ISnoPower Generic_p1ItemPassiveUniqueRing945 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing023 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing027 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing028 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing029 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing030 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing031 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing033 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing036 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing037 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing039 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing040 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing041 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing044 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing048 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing049 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing050 { get; }

	ISnoPower Generic_P2ItemPassiveUniqueRing059 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing025 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing026 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing030 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing033 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing035 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing036 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing037 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing039 { get; }

	ISnoPower Generic_P3ItemPassiveUniqueRing040 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_P41ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P42ItemPassiveUniqueRing697x1 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P43ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing001 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing021 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing027 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing028 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing031 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing033 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing037 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing042 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing043 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing044 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing051 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing052 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing057 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing058 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing059 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing064 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing066 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing067 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing069 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing071 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing076 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing077 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing079 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing080 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing081 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing082 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing083 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing084 { get; }

	ISnoPower Generic_P4ItemPassiveUniqueRing085 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing002 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing003 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing004 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing005 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing006 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing007 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing008 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing009 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing010 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing011 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing012 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing013 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing014 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing015 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing017 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing018 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing019 { get; }

	ISnoPower Generic_P5ItemPassiveUniqueRing020 { get; }

	ISnoPower Generic_P61ItemPassiveUniqueRing027 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing044 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing045 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing054 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing057 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing061 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing067 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing069 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing072 { get; }

	ISnoPower Generic_P6ItemPassiveUniqueRing073 { get; }

	ISnoPower Generic_P74ItemPassiveUniqueRing016 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor001 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor002 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor003 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMajor004 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor001 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor002 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor003 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor004 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor005 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor006 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor007 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor008 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor009 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor010 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor011 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor012 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor013 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor014 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor015 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor016 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor017 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor018 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor019 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor020 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor021 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor022 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor023 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor024 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor025 { get; }

	ISnoPower Generic_P75ItemPassiveDarkAlchemyMinor026 { get; }

	ISnoPower Generic_X1LegendaryPotion07 { get; }

	IEnumerable<ISnoPower> GetClassSpecificPowers(HeroClass heroClass);

	IEnumerable<ISnoPower> GetLegendaryGemPowers();

	IEnumerable<ISnoPower> GetLegendaryItemPowers();
}
