using System.Collections.Generic;
using Plugins;

namespace work;

internal class LegendaryPowerInfo : ILegendaryPowerInfo
{
	private readonly Player p;

	public IBuff AetherWalker => p.Powers.GetBuff(397788u);

	public IBuff AhavarionSpearOfLycander => p.Powers.GetBuff(318868u);

	public IBuff AkaratsAwakening => p.Powers.GetBuff(318888u);

	public IBuff AkkhansAddendum => p.Powers.GetBuff(445943u);

	public IBuff AkkhansLeniency => p.Powers.GetBuff(488910u);

	public IBuff AkkhansManacles => p.Powers.GetBuff(446008u);

	public IBuff AmbosPride => p.Powers.GetBuff(483675u);

	public IBuff AncestorsGrace => p.Powers.GetBuff(318378u);

	public IBuff AncientParthanDefenders => p.Powers.GetBuff(318770u);

	public IBuff AndarielsVisage => p.Powers.GetBuff(434034u);

	public IBuff AnessaziEdge => p.Powers.GetBuff(318720u);

	public IBuff AngelHairBraid => p.Powers.GetBuff(402415u);

	public IBuff AquilaCuirass => p.Powers.GetBuff(449064u);

	public IBuff ArchmagesVicalyke => p.Powers.GetBuff(318777u);

	public IBuff Arcstone => p.Powers.GetBuff(359598u);

	public IBuff ArmorOfTheKindRegent => p.Powers.GetBuff(318892u);

	public IBuff ArreatsLaw => p.Powers.GetBuff(486951u);

	public IBuff ArthefsSparkOfLife => p.Powers.GetBuff(318757u);

	public IBuff AshnagarrsBloodBracer => p.Powers.GetBuff(449043u);

	public IBuff AugustinesPanacea => p.Powers.GetBuff(451169u);

	public IBuff Azurewrath => p.Powers.GetBuff(441723u);

	public IBuff BakuliJungleWraps => p.Powers.GetBuff(451163u);

	public IBuff Balance => p.Powers.GetBuff(478475u);

	public IBuff BalefulRemnant => p.Powers.GetBuff(359545u);

	public IBuff BandOfHollowWhispers => p.Powers.GetBuff(364345u);

	public IBuff BandOfMight => p.Powers.GetBuff(447060u);

	public IBuff BandOfTheRueChambers => p.Powers.GetBuff(318434u);

	public IBuff BastionsRevered => p.Powers.GetBuff(484244u);

	public IBuff BeckonSail => p.Powers.GetBuff(318420u);

	public IBuff BeltOfTheTrove => p.Powers.GetBuff(484602u);

	public IBuff BeltOfTranscendence => p.Powers.GetBuff(430671u);

	public IBuff BindingOfTheLost => p.Powers.GetBuff(440598u);

	public IBuff BindingsOfTheLesserGods => p.Powers.GetBuff(485725u);

	public IBuff Blackfeather => p.Powers.GetBuff(318882u);

	public IBuff BladeOfProphecy => p.Powers.GetBuff(478476u);

	public IBuff BladeOfTheTribes => p.Powers.GetBuff(484604u);

	public IBuff BladeOfTheWarlord => p.Powers.GetBuff(447375u);

	public IBuff BlessedOfHaull => p.Powers.GetBuff(430681u);

	public IBuff BloodBrother => p.Powers.GetBuff(402456u);

	public IBuff BloodsongMail => p.Powers.GetBuff(476585u);

	public IBuff BloodtideBlade => p.Powers.GetBuff(475251u);

	public IBuff BombardiersRucksack => p.Powers.GetBuff(486306u);

	public IBuff BondsOfCLena => p.Powers.GetBuff(485504u);

	public IBuff BoneRinger => p.Powers.GetBuff(476584u);

	public IBuff BottomlessPotionOfAmplification => p.Powers.GetBuff(434626u);

	public IBuff BottomlessPotionOfChaos => p.Powers.GetBuff(451310u);

	public IBuff BottomlessPotionOfFear => p.Powers.GetBuff(428812u);

	public IBuff BottomlessPotionOfKulleAid => p.Powers.GetBuff(344094u);

	public IBuff BottomlessPotionOfRejuvenation => p.Powers.GetBuff(433021u);

	public IBuff BottomlessPotionOfTheUnfettered => p.Powers.GetBuff(483315u);

	public IBuff BovineBardiche => p.Powers.GetBuff(318382u);

	public IBuff BracerOfFury => p.Powers.GetBuff(446162u);

	public IBuff BracersOfDestruction => p.Powers.GetBuff(483847u);

	public IBuff BracersOfTheFirstMen => p.Powers.GetBuff(441279u);

	public IBuff BriggsWrath => p.Powers.GetBuff(475252u);

	public IBuff BrokenCrown => p.Powers.GetBuff(423231u);

	public IBuff BrokenPromises => p.Powers.GetBuff(402462u);

	public IBuff BrynersJourney => p.Powers.GetBuff(475245u);

	public IBuff BulKathossWeddingBand => p.Powers.GetBuff(364340u);

	public IBuff BurizaDoKyanon => p.Powers.GetBuff(374344u);

	public IBuff ButchersCarver => p.Powers.GetBuff(246118u);

	public IBuff Calamity => p.Powers.GetBuff(318360u);

	public IBuff CamsRebuttal => p.Powers.GetBuff(318358u);

	public IBuff CapeOfTheDarkNight => p.Powers.GetBuff(318421u);

	public IBuff Carnevil => p.Powers.GetBuff(483481u);

	public IBuff CesarsMemento => p.Powers.GetBuff(449031u);

	public IBuff Chaingmail => p.Powers.GetBuff(318798u);

	public IBuff ChainOfShadows => p.Powers.GetBuff(445266u);

	public IBuff ChanonBolter => p.Powers.GetBuff(488010u);

	public IBuff ChilaniksChain => p.Powers.GetBuff(318821u);

	public IBuff Cindercoat => p.Powers.GetBuff(318790u);

	public IBuff CircleOfNailujsEvol => p.Powers.GetBuff(475247u);

	public IBuff Cluckeye => p.Powers.GetBuff(488809u);

	public IBuff CoilsOfTheFirstSpider => p.Powers.GetBuff(440790u);

	public IBuff ConventionOfElements => p.Powers.GetBuff(430674u);

	public IBuff CordOfTheSherma => p.Powers.GetBuff(434008u);

	public IBuff CorpsewhisperPauldrons => p.Powers.GetBuff(476580u);

	public IBuff CorruptedAshbringer => p.Powers.GetBuff(402455u);

	public IBuff CountessJuliasCameo => p.Powers.GetBuff(318381u);

	public IBuff CrashingRain => p.Powers.GetBuff(359554u);

	public IBuff CrownOfThePrimus => p.Powers.GetBuff(487653u);

	public IBuff CrystalFist => p.Powers.GetBuff(451170u);

	public IBuff CusterianWristguards => p.Powers.GetBuff(359557u);

	public IBuff DanettasRevenge => p.Powers.GetBuff(318813u);

	public IBuff DanettasSpite => p.Powers.GetBuff(318348u);

	public IBuff Darklight => p.Powers.GetBuff(483790u);

	public IBuff DarkMagesShade => p.Powers.GetBuff(318788u);

	public IBuff Dawn => p.Powers.GetBuff(446146u);

	public IBuff DaynteesBinding => p.Powers.GetBuff(478534u);

	public IBuff DeadlyRebirth => p.Powers.GetBuff(318808u);

	public IBuff DeadMansLegacy => p.Powers.GetBuff(478486u);

	public IBuff DeathseersCowl => p.Powers.GetBuff(318857u);

	public IBuff DeathWatchMantle => p.Powers.GetBuff(434005u);

	public IBuff Deathwish => p.Powers.GetBuff(449063u);

	public IBuff DefenderOfWestmarch => p.Powers.GetBuff(434004u);

	public IBuff DefilerCuisses => p.Powers.GetBuff(485506u);

	public IBuff DemonMachine => p.Powers.GetBuff(364332u);

	public IBuff Denial => p.Powers.GetBuff(435016u);

	public IBuff DepthDiggers => p.Powers.GetBuff(402416u);

	public IBuff DishonoredLegacy => p.Powers.GetBuff(441294u);

	public IBuff DovuEnergyTrap => p.Powers.GetBuff(318867u);

	public IBuff DrakonsLesson => p.Powers.GetBuff(430678u);

	public IBuff DreadIron => p.Powers.GetBuff(430679u);

	public IBuff EberliCharo => p.Powers.GetBuff(318853u);

	public IBuff EchoingFury => p.Powers.GetBuff(483518u);

	public IBuff ElusiveRing => p.Powers.GetBuff(446187u);

	public IBuff EmimeisDuffel => p.Powers.GetBuff(484294u);

	public IBuff EnchantingFavor => p.Powers.GetBuff(318835u);

	public IBuff EtchedSigil => p.Powers.GetBuff(484596u);

	public IBuff EternalUnion => p.Powers.GetBuff(487798u);

	public IBuff Eunjangdo => p.Powers.GetBuff(402457u);

	public IBuff EyeOfPeshkov => p.Powers.GetBuff(318431u);

	public IBuff FaithfulMemory => p.Powers.GetBuff(454927u);

	public IBuff FateOfTheFell => p.Powers.GetBuff(478478u);

	public IBuff FatesVow => p.Powers.GetBuff(478508u);

	public IBuff FazulasImprobableChain => p.Powers.GetBuff(437854u);

	public IBuff FireWalkers => p.Powers.GetBuff(434010u);

	public IBuff FjordCutter => p.Powers.GetBuff(483848u);

	public IBuff FlailOfTheAscended => p.Powers.GetBuff(451164u);

	public IBuff Fleshrake => p.Powers.GetBuff(451168u);

	public IBuff FlyingDragon => p.Powers.GetBuff(246562u);

	public IBuff FortressBallista => p.Powers.GetBuff(447816u);

	public IBuff FragmentOfDestiny => p.Powers.GetBuff(484599u);

	public IBuff FreezeOfDeflection => p.Powers.GetBuff(318816u);

	public IBuff Frostburn => p.Powers.GetBuff(451167u);

	public IBuff FrydehrsWrath => p.Powers.GetBuff(478477u);

	public IBuff Fulminator => p.Powers.GetBuff(441681u);

	public IBuff FuneraryPick => p.Powers.GetBuff(487651u);

	public IBuff FuryOfTheAncients => p.Powers.GetBuff(483849u);

	public IBuff FuryOfTheVanishedPeak => p.Powers.GetBuff(478489u);

	public IBuff GabrielsVambraces => p.Powers.GetBuff(436521u);

	public IBuff GazingDemise => p.Powers.GetBuff(484270u);

	public IBuff GelmindorsMarrowGuards => p.Powers.GetBuff(484588u);

	public IBuff Genzaniku => p.Powers.GetBuff(364311u);

	public IBuff GestureOfOrpheus => p.Powers.GetBuff(318376u);

	public IBuff GirdleOfGiants => p.Powers.GetBuff(451237u);

	public IBuff GladiatorGauntlets => p.Powers.GetBuff(318799u);

	public IBuff GoldenFlense => p.Powers.GetBuff(478537u);

	public IBuff Goldskin => p.Powers.GetBuff(246515u);

	public IBuff Goldwrap => p.Powers.GetBuff(318875u);

	public IBuff GolemskinBreeches => p.Powers.GetBuff(478510u);

	public IBuff GraspsOfEssence => p.Powers.GetBuff(484310u);

	public IBuff GuardOfJohanna => p.Powers.GetBuff(436481u);

	public IBuff GungdoGear => p.Powers.GetBuff(484605u);

	public IBuff GyanaNaKashu => p.Powers.GetBuff(318426u);

	public IBuff GyrfalconsFoote => p.Powers.GetBuff(478513u);

	public IBuff Hack => p.Powers.GetBuff(318869u);

	public IBuff HallowedBulwark => p.Powers.GetBuff(318887u);

	public IBuff HaloOfArlyse => p.Powers.GetBuff(429648u);

	public IBuff HaloOfKarini => p.Powers.GetBuff(478538u);

	public IBuff HammerJammers => p.Powers.GetBuff(446502u);

	public IBuff HandOfTheProphet => p.Powers.GetBuff(318377u);

	public IBuff HarringtonWaistguard => p.Powers.GetBuff(318881u);

	public IBuff HauntedVisions => p.Powers.GetBuff(484309u);

	public IBuff HauntingGirdle => p.Powers.GetBuff(434966u);

	public IBuff HauntOfVaxo => p.Powers.GetBuff(318782u);

	public IBuff HeartOfIron => p.Powers.GetBuff(446615u);

	public IBuff HellcatWaistguard => p.Powers.GetBuff(454934u);

	public IBuff Hellrack => p.Powers.GetBuff(247577u);

	public IBuff Hellskull => p.Powers.GetBuff(318891u);

	public IBuff HenrisPerquisition => p.Powers.GetBuff(440457u);

	public IBuff HergbrashsBinding => p.Powers.GetBuff(449048u);

	public IBuff HexingPantsOfMrYan => p.Powers.GetBuff(318817u);

	public IBuff HillenbrandsTrainingSword => p.Powers.GetBuff(359604u);

	public IBuff HolyPointShot => p.Powers.GetBuff(484313u);

	public IBuff HomingPads => p.Powers.GetBuff(318801u);

	public IBuff Homunculus => p.Powers.GetBuff(374670u);

	public IBuff HuntersWrath => p.Powers.GetBuff(440743u);

	public IBuff HwojWrap => p.Powers.GetBuff(318800u);

	public IBuff IceClimbers => p.Powers.GetBuff(318741u);

	public IBuff IncenseTorchOfTheGrandTemple => p.Powers.GetBuff(478473u);

	public IBuff Ingeom => p.Powers.GetBuff(402458u);

	public IBuff InviolableFaith => p.Powers.GetBuff(318894u);

	public IBuff IronRose => p.Powers.GetBuff(487652u);

	public IBuff IrontoeMudsputters => p.Powers.GetBuff(318877u);

	public IBuff IvoryTower => p.Powers.GetBuff(430683u);

	public IBuff JacesHammerOfVigilance => p.Powers.GetBuff(318851u);

	public IBuff JangsEnvelopment => p.Powers.GetBuff(318795u);

	public IBuff Jawbreaker => p.Powers.GetBuff(318432u);

	public IBuff Jekangbord => p.Powers.GetBuff(478514u);

	public IBuff JeramsBracers => p.Powers.GetBuff(441278u);

	public IBuff JohannasArgument => p.Powers.GetBuff(436430u);

	public IBuff JusticeLantern => p.Powers.GetBuff(446565u);

	public IBuff JustiniansMercy => p.Powers.GetBuff(318895u);

	public IBuff KarleisPoint => p.Powers.GetBuff(478484u);

	public IBuff KassarsRetribution => p.Powers.GetBuff(359538u);

	public IBuff KekegisUnbreakableSpirit => p.Powers.GetBuff(318751u);

	public IBuff KhassettsCordOfRighteousness => p.Powers.GetBuff(451238u);

	public IBuff KmarTenclip => p.Powers.GetBuff(318423u);

	public IBuff KredesFlame => p.Powers.GetBuff(318865u);

	public IBuff KrelmsBuffBelt => p.Powers.GetBuff(359602u);

	public IBuff KrelmsBuffBracers => p.Powers.GetBuff(359591u);

	public IBuff Kridershot => p.Powers.GetBuff(318379u);

	public IBuff KrysbinsSentence => p.Powers.GetBuff(475241u);

	public IBuff KymbosGold => p.Powers.GetBuff(359597u);

	public IBuff KyoshirosBlade => p.Powers.GetBuff(447368u);

	public IBuff KyoshirosSoul => p.Powers.GetBuff(447130u);

	public IBuff LakumbasOrnament => p.Powers.GetBuff(486131u);

	public IBuff Lamentation => p.Powers.GetBuff(483792u);

	public IBuff LastBreath => p.Powers.GetBuff(447030u);

	public IBuff LefebvresSoliloquy => p.Powers.GetBuff(449236u);

	public IBuff LegersDisdain => p.Powers.GetBuff(476696u);

	public IBuff LeonineBowOfHashir => p.Powers.GetBuff(484293u);

	public IBuff LiannasWings => p.Powers.GetBuff(447696u);

	public IBuff LightOfGrace => p.Powers.GetBuff(318855u);

	public IBuff LionsClaw => p.Powers.GetBuff(402451u);

	public IBuff LordGreenstonesFan => p.Powers.GetBuff(445274u);

	public IBuff LornellesSunstone => p.Powers.GetBuff(475244u);

	public IBuff LostTime => p.Powers.GetBuff(476684u);

	public IBuff LutSocks => p.Powers.GetBuff(318810u);

	public IBuff MadawcsSorrow => p.Powers.GetBuff(318744u);

	public IBuff Madstone => p.Powers.GetBuff(402540u);

	public IBuff Magefist => p.Powers.GetBuff(451166u);

	public IBuff MalothsFocus => p.Powers.GetBuff(246780u);

	public IBuff MaltoriusPetrifiedSpike => p.Powers.GetBuff(475246u);

	public IBuff ManaldHeal => p.Powers.GetBuff(454930u);

	public IBuff Manticore => p.Powers.GetBuff(478483u);

	public IBuff MantleOfChanneling => p.Powers.GetBuff(446640u);

	public IBuff MarasKaleidoscope => p.Powers.GetBuff(318719u);

	public IBuff MaskOfJeram => p.Powers.GetBuff(318411u);

	public IBuff MaskOfScarletDeath => p.Powers.GetBuff(476581u);

	public IBuff Maximus => p.Powers.GetBuff(364317u);

	public IBuff MesserschmidtsReaver => p.Powers.GetBuff(483522u);

	public IBuff Mirrorball => p.Powers.GetBuff(487928u);

	public IBuff MoonlightWard => p.Powers.GetBuff(364343u);

	public IBuff MordullusPromise => p.Powers.GetBuff(447029u);

	public IBuff MoribundGauntlets => p.Powers.GetBuff(476589u);

	public IBuff MorticksBrace => p.Powers.GetBuff(430135u);

	public IBuff MykensBallOfHate => p.Powers.GetBuff(318775u);

	public IBuff Nagelring => p.Powers.GetBuff(402460u);

	public IBuff NayrsBlackDeath => p.Powers.GetBuff(476587u);

	public IBuff NemesisBracers => p.Powers.GetBuff(318820u);

	public IBuff NilfursBoast => p.Powers.GetBuff(478554u);

	public IBuff Oathkeeper => p.Powers.GetBuff(447372u);

	public IBuff ObsidianRingOfTheZodiac => p.Powers.GetBuff(402459u);

	public IBuff OculusRing => p.Powers.GetBuff(402461u);

	public IBuff OdynSon => p.Powers.GetBuff(364325u);

	public IBuff OdysseysEnd => p.Powers.GetBuff(484297u);

	public IBuff Omnislash => p.Powers.GetBuff(430682u);

	public IBuff OmrynsChain => p.Powers.GetBuff(423229u);

	public IBuff OrbOfInfiniteDepth => p.Powers.GetBuff(478481u);

	public IBuff PigSticker => p.Powers.GetBuff(245836u);

	public IBuff PintosPride => p.Powers.GetBuff(447295u);

	public IBuff PoxFaulds => p.Powers.GetBuff(434009u);

	public IBuff PrideOfCassius => p.Powers.GetBuff(318419u);

	public IBuff PrimordialSoul => p.Powers.GetBuff(448998u);

	public IBuff PromiseOfGlory => p.Powers.GetBuff(318871u);

	public IBuff PusSpitter => p.Powers.GetBuff(364335u);

	public IBuff PuzzleRing => p.Powers.GetBuff(318375u);

	public IBuff Quetzalcoatl => p.Powers.GetBuff(318796u);

	public IBuff RabidStrike => p.Powers.GetBuff(486099u);

	public IBuff RakoffsGlassOfLife => p.Powers.GetBuff(318410u);

	public IBuff RanslorsFolly => p.Powers.GetBuff(478491u);

	public IBuff RazethsVolition => p.Powers.GetBuff(484311u);

	public IBuff RazorStrop => p.Powers.GetBuff(318241u);

	public IBuff RechelsRingOfLarceny => p.Powers.GetBuff(318870u);

	public IBuff ReilenasShadowhook => p.Powers.GetBuff(475253u);

	public IBuff RelicOfAkarat => p.Powers.GetBuff(318377u);

	public IBuff Remorseless => p.Powers.GetBuff(483793u);

	public IBuff RequiemCereplate => p.Powers.GetBuff(476579u);

	public IBuff RhenhoFlayer => p.Powers.GetBuff(318812u);

	public IBuff RibaldEtchings => p.Powers.GetBuff(318377u);

	public IBuff Rimeheart => p.Powers.GetBuff(318864u);

	public IBuff RingOfEmptiness => p.Powers.GetBuff(445694u);

	public IBuff RiveraDancers => p.Powers.GetBuff(447043u);

	public IBuff RogarsHugeStone => p.Powers.GetBuff(318861u);

	public IBuff SacredHarness => p.Powers.GetBuff(440434u);

	public IBuff SacredHarvester => p.Powers.GetBuff(410217u);

	public IBuff SaffronWrap => p.Powers.GetBuff(454918u);

	public IBuff SashOfKnives => p.Powers.GetBuff(434038u);

	public IBuff Scarbringer => p.Powers.GetBuff(478474u);

	public IBuff SchaefersHammer => p.Powers.GetBuff(434033u);

	public IBuff Scourge => p.Powers.GetBuff(364321u);

	public IBuff Scrimshaw => p.Powers.GetBuff(484603u);

	public IBuff ScytheOfTheCycle => p.Powers.GetBuff(476586u);

	public IBuff SeborsNightmare => p.Powers.GetBuff(434039u);

	public IBuff SerpentsSparker => p.Powers.GetBuff(484117u);

	public IBuff Sever => p.Powers.GetBuff(249967u);

	public IBuff ShardOfHate => p.Powers.GetBuff(359587u);

	public IBuff ShieldOfFury => p.Powers.GetBuff(446142u);

	public IBuff ShiMizusHaori => p.Powers.GetBuff(318779u);

	public IBuff ShukranisTriumph => p.Powers.GetBuff(486132u);

	public IBuff SinSeekers => p.Powers.GetBuff(483505u);

	public IBuff SkeletonKey => p.Powers.GetBuff(318835u);

	public IBuff SkularsSalvation => p.Powers.GetBuff(486949u);

	public IBuff SkullGrasp => p.Powers.GetBuff(451160u);

	public IBuff SkullOfResonance => p.Powers.GetBuff(318773u);

	public IBuff Skycutter => p.Powers.GetBuff(364315u);

	public IBuff SkySplitter => p.Powers.GetBuff(433993u);

	public IBuff Skywarden => p.Powers.GetBuff(359550u);

	public IBuff SlipkasLetterOpener => p.Powers.GetBuff(359604u);

	public IBuff SloraksMadness => p.Powers.GetBuff(248686u);

	public IBuff SmokingThurible => p.Powers.GetBuff(318835u);

	public IBuff Solanium => p.Powers.GetBuff(318873u);

	public IBuff SpauldersOfZakara => p.Powers.GetBuff(318858u);

	public IBuff SpearOfJairo => p.Powers.GetBuff(475254u);

	public IBuff SpinesOfSeethingHatred => p.Powers.GetBuff(359606u);

	public IBuff SpiritGuards => p.Powers.GetBuff(430289u);

	public IBuff SquirtsNecklace => p.Powers.GetBuff(483552u);

	public IBuff StaffOfChiroptera => p.Powers.GetBuff(478487u);

	public IBuff StalgardsDecimator => p.Powers.GetBuff(318412u);

	public IBuff Standoff => p.Powers.GetBuff(446592u);

	public IBuff StArchewsGage => p.Powers.GetBuff(434007u);

	public IBuff Starfire => p.Powers.GetBuff(451242u);

	public IBuff StarmetalKukri => p.Powers.GetBuff(318724u);

	public IBuff SteuartsGreaves => p.Powers.GetBuff(475243u);

	public IBuff StoneGauntlets => p.Powers.GetBuff(483519u);

	public IBuff StoneOfJordan => p.Powers.GetBuff(484282u);

	public IBuff StormCrow => p.Powers.GetBuff(364338u);

	public IBuff StringOfEars => p.Powers.GetBuff(446541u);

	public IBuff StrongarmBracers => p.Powers.GetBuff(318772u);

	public IBuff SublimeConviction => p.Powers.GetBuff(318890u);

	public IBuff SuWongDiviner => p.Powers.GetBuff(442478u);

	public IBuff SwampLandWaders => p.Powers.GetBuff(451161u);

	public IBuff Swiftmount => p.Powers.GetBuff(359537u);

	public IBuff SwordOfIllWill => p.Powers.GetBuff(446641u);

	public IBuff TalismanOfAranoch => p.Powers.GetBuff(318715u);

	public IBuff TaskerandTheo => p.Powers.GetBuff(318731u);

	public IBuff TheBarber => p.Powers.GetBuff(454932u);

	public IBuff TheBurningAxeOfSankis => p.Powers.GetBuff(246113u);

	public IBuff TheButchersSickle => p.Powers.GetBuff(248484u);

	public IBuff TheCloakOfTheGarwulf => p.Powers.GetBuff(318300u);

	public IBuff TheCrudestBoots => p.Powers.GetBuff(485724u);

	public IBuff TheDaggerOfDarts => p.Powers.GetBuff(483400u);

	public IBuff TheDemonsDemise => p.Powers.GetBuff(488008u);

	public IBuff TheEssOfJohan => p.Powers.GetBuff(318759u);

	public IBuff TheExecutioner => p.Powers.GetBuff(483516u);

	public IBuff TheFinalWitness => p.Powers.GetBuff(318884u);

	public IBuff TheFistOfAzTurrasq => p.Powers.GetBuff(318433u);

	public IBuff TheFlavorOfTime => p.Powers.GetBuff(483515u);

	public IBuff TheFlowOfEternity => p.Powers.GetBuff(451162u);

	public IBuff TheFurnace => p.Powers.GetBuff(318753u);

	public IBuff TheGavelOfJudgment => p.Powers.GetBuff(478490u);

	public IBuff TheGidbinn => p.Powers.GetBuff(364316u);

	public IBuff TheGrandVizier => p.Powers.GetBuff(478553u);

	public IBuff TheGrinReaper => p.Powers.GetBuff(251572u);

	public IBuff TheJohnstone => p.Powers.GetBuff(476583u);

	public IBuff TheLawsOfSeph => p.Powers.GetBuff(318428u);

	public IBuff TheMagistrate => p.Powers.GetBuff(484116u);

	public IBuff TheMindsEye => p.Powers.GetBuff(318824u);

	public IBuff TheMortalDrama => p.Powers.GetBuff(484601u);

	public IBuff TheNinthCirriSatchel => p.Powers.GetBuff(484295u);

	public IBuff TheOculus => p.Powers.GetBuff(374308u);

	public IBuff ThePaddle => p.Powers.GetBuff(247777u);

	public IBuff TheRavensWing => p.Powers.GetBuff(375037u);

	public IBuff TheShameOfDelsere => p.Powers.GetBuff(445427u);

	public IBuff TheShortMansFinger => p.Powers.GetBuff(478488u);

	public IBuff TheSmolderingCore => p.Powers.GetBuff(487677u);

	public IBuff TheSpiderQueensGrasp => p.Powers.GetBuff(486133u);

	public IBuff TheStarOfAzkaranth => p.Powers.GetBuff(318716u);

	public IBuff TheSwami => p.Powers.GetBuff(440336u);

	public IBuff TheTallMansFinger => p.Powers.GetBuff(318806u);

	public IBuff TheThreeHundredthSpear => p.Powers.GetBuff(487304u);

	public IBuff TheTormentor => p.Powers.GetBuff(247572u);

	public IBuff TheTwistedSword => p.Powers.GetBuff(484709u);

	public IBuff TheUndisputedChampion => p.Powers.GetBuff(484245u);

	public IBuff ThingOfTheDeep => p.Powers.GetBuff(446359u);

	public IBuff ThunderfuryBlessedBladeOfTheWindseeker => p.Powers.GetBuff(318763u);

	public IBuff ThundergodsVigor => p.Powers.GetBuff(364341u);

	public IBuff TiklandianVisage => p.Powers.GetBuff(318774u);

	public IBuff TragOulCoils => p.Powers.GetBuff(488009u);

	public IBuff TragOulsCorrodedFang => p.Powers.GetBuff(475250u);

	public IBuff Triumvirate => p.Powers.GetBuff(434849u);

	public IBuff TzoKrinsGaze => p.Powers.GetBuff(318811u);

	public IBuff UhkapianSerpent => p.Powers.GetBuff(318721u);

	public IBuff Unity => p.Powers.GetBuff(318769u);

	public IBuff UnrelentingPhalanx => p.Powers.GetBuff(402444u);

	public IBuff UnstableScepter => p.Powers.GetBuff(478479u);

	public IBuff UrsuasTroddenEffigy => p.Powers.GetBuff(484655u);

	public IBuff VadimsSurge => p.Powers.GetBuff(359604u);

	public IBuff VallasBequest => p.Powers.GetBuff(436472u);

	public IBuff ValtheksRebuke => p.Powers.GetBuff(484597u);

	public IBuff VambracesOfSescheron => p.Powers.GetBuff(447839u);

	public IBuff VelvetCamaral => p.Powers.GetBuff(318740u);

	public IBuff VengefulWind => p.Powers.GetBuff(483791u);

	public IBuff Vigilance => p.Powers.GetBuff(367008u);

	public IBuff VileHive => p.Powers.GetBuff(445765u);

	public IBuff VileWard => p.Powers.GetBuff(397783u);

	public IBuff VisageOfGiyua => p.Powers.GetBuff(318385u);

	public IBuff VisageOfGunes => p.Powers.GetBuff(446655u);

	public IBuff VoosJuicer => p.Powers.GetBuff(446969u);

	public IBuff VoToyiasSpiker => p.Powers.GetBuff(318886u);

	public IBuff WandOfWoh => p.Powers.GetBuff(478480u);

	public IBuff WarhelmOfKassar => p.Powers.GetBuff(449049u);

	public IBuff WarstaffOfGeneralQuang => p.Powers.GetBuff(318430u);

	public IBuff WarzechianArmguards => p.Powers.GetBuff(318771u);

	public IBuff WilkensReach => p.Powers.GetBuff(447843u);

	public IBuff WinterFlurry => p.Powers.GetBuff(484598u);

	public IBuff WisdomOfKalan => p.Powers.GetBuff(476686u);

	public IBuff Wizardspike => p.Powers.GetBuff(484600u);

	public IBuff WojahnniAssaulter => p.Powers.GetBuff(483506u);

	public IBuff WonKhimLau => p.Powers.GetBuff(484106u);

	public IBuff Wormwood => p.Powers.GetBuff(423238u);

	public IBuff WrapsOfClarity => p.Powers.GetBuff(441517u);

	public IBuff Wyrdward => p.Powers.GetBuff(434036u);

	public IBuff XephirianAmulet => p.Powers.GetBuff(318718u);

	public IBuff YangsRecurve => p.Powers.GetBuff(478485u);

	public IBuff ZoeysSecret => p.Powers.GetBuff(446639u);

	public IBuff BroodOfAraneae => p.Powers.GetBuff(486136u);

	public IBuff DregsOfLies => p.Powers.GetBuff(486126u);

	public IBuff EssenceOfAnguish => p.Powers.GetBuff(486198u);

	public IBuff FragmentOfDestruction => p.Powers.GetBuff(486213u);

	public IBuff RemnantOfPain => p.Powers.GetBuff(486134u);

	public IBuff ShardOfHatred => p.Powers.GetBuff(486178u);

	public IBuff SliverOfTerror => p.Powers.GetBuff(486182u);

	public IBuff StainOfSin => p.Powers.GetBuff(486209u);

	public IBuff MempoOfTwilight => p.Powers.GetBuff(487972u);

	public IBuff VigilanteBelt => p.Powers.GetBuff(488555u);

	internal LegendaryPowerInfo(Player player)
	{
		p = player;
	}

	public IEnumerable<IBuff> AllBuffs()
	{
		if (p.powerSno2buff.TryGetValue(397788u, out var value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318868u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318888u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445943u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488910u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446008u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483675u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318378u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318770u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434034u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318720u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402415u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449064u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318777u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359598u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318892u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486951u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318757u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449043u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451169u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441723u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451163u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478475u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359545u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364345u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447060u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318434u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484244u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318420u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484602u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430671u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440598u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(485725u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318882u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478476u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484604u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447375u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430681u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402456u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476585u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475251u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486306u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(485504u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476584u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434626u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451310u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(428812u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(344094u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(433021u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483315u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318382u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446162u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483847u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441279u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475252u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(423231u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402462u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475245u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364340u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(374344u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(246118u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318360u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318358u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318421u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483481u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449031u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318798u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445266u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488010u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318821u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318790u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475247u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488809u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440790u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430674u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434008u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476580u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402455u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318381u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359554u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487653u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451170u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359557u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318813u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318348u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483790u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318788u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446146u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478534u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318808u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478486u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318857u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434005u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449063u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434004u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(485506u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364332u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(435016u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402416u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441294u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318867u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430678u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430679u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318853u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483518u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446187u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484294u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318835u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484596u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487798u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402457u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318431u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(454927u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478478u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478508u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(437854u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434010u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483848u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451164u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451168u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(246562u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447816u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484599u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318816u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451167u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478477u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441681u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487651u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483849u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478489u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(436521u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484270u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484588u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364311u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318376u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451237u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318799u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478537u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(246515u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318875u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478510u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484310u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(436481u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484605u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318426u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478513u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318869u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318887u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(429648u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478538u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446502u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318377u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318881u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484309u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434966u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318782u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446615u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(454934u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(247577u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318891u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440457u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449048u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318817u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359604u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484313u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318801u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(374670u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440743u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318800u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318741u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478473u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402458u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318894u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487652u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318877u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430683u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318851u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318795u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318432u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478514u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441278u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(436430u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446565u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318895u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478484u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359538u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318751u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451238u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318423u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318865u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359602u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359591u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318379u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475241u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359597u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447368u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447130u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486131u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483792u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447030u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449236u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476696u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484293u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447696u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318855u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402451u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445274u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475244u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476684u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318810u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318744u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402540u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451166u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(246780u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475246u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(454930u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478483u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446640u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318719u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318411u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476581u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364317u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483522u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487928u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364343u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447029u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476589u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430135u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318775u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402460u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476587u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318820u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478554u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447372u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402459u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402461u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364325u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484297u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430682u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(423229u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478481u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(245836u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447295u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434009u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318419u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(448998u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318871u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364335u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318375u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318796u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486099u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318410u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478491u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484311u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318241u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318870u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475253u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318377u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483793u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476579u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318812u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318377u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318864u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445694u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447043u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318861u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440434u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(410217u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(454918u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434038u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478474u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434033u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364321u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484603u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476586u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434039u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484117u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(249967u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359587u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446142u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318779u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486132u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483505u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318835u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486949u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451160u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318773u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364315u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(433993u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359550u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359604u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(248686u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318835u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318873u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318858u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475254u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359606u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(430289u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483552u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478487u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318412u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446592u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434007u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451242u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318724u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475243u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483519u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484282u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364338u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446541u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318772u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318890u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(442478u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451161u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359537u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446641u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318715u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318731u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(454932u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(246113u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(248484u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318300u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(485724u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483400u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488008u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318759u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483516u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318884u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318433u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483515u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(451162u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318753u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478490u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364316u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478553u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(251572u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476583u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318428u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484116u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318824u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484601u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484295u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(374308u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(247777u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(375037u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445427u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478488u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487677u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486133u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318716u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(440336u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318806u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487304u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(247572u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484709u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484245u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446359u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318763u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(364341u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318774u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488009u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(475250u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434849u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318811u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318721u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318769u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(402444u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478479u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484655u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(359604u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(436472u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484597u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447839u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318740u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483791u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(367008u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(445765u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(397783u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318385u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446655u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446969u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318886u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478480u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(449049u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318430u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318771u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(447843u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484598u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(476686u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484600u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(483506u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(484106u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(423238u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(441517u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(434036u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(318718u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(478485u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(446639u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486136u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486126u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486198u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486213u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486134u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486178u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486182u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(486209u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(487972u, out value))
		{
			yield return value;
		}
		if (p.powerSno2buff.TryGetValue(488555u, out value))
		{
			yield return value;
		}
	}
}
