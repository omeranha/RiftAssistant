using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public class Player : Actor
{
	[CompilerGenerated]
	private uint actorId;

	[CompilerGenerated]
	private int index;

	[CompilerGenerated]
	private int portraitIndex;

	public bool bool_8;

	[CompilerGenerated]
	private bool coordinateKnown;

	[CompilerGenerated]
	private uint heroId;

	[CompilerGenerated]
	private Hero ihero_0;

	[CompilerGenerated]
	private string heroName;

	[CompilerGenerated]
	private bool heroIsHardcore;

	[CompilerGenerated]
	private bool heroIsMale;

	[CompilerGenerated]
	private int season;

	[CompilerGenerated]
	private bool seasonal;

	[CompilerGenerated]
	private string battleTagAbovePortrait;

	[CompilerGenerated]
	private HeroClassDefinition iheroClassDefinition_0;

	[CompilerGenerated]
	private SnoArea isnoArea_0;

	[CompilerGenerated]
	private readonly PlayerDefense iplayerDefenseInfo_0;

	[CompilerGenerated]
	private readonly PlayerOffense iplayerOffenseInfo_0 = new PlayerOffense();

	[CompilerGenerated]
	private readonly PlayerDamage iplayerDamageInfo_0 = new PlayerDamage();

	[CompilerGenerated]
	private readonly PlayerStats iplayerStatInfo_0 = new PlayerStats();

	[CompilerGenerated]
	private readonly PlayerMaterialInfo iplayerMaterialInfo_0;

	[CompilerGenerated]
	private readonly PlayerPowerInfo iplayerPowerInfo_0;

	internal r_PlayerData RawPlayerData;

	[CompilerGenerated]
	private readonly PlayerArmorySet[] iplayerArmorySet_0;

	[CompilerGenerated]
	private AnimSnoEnum animation;

	[CompilerGenerated]
	private AcdAnimationState animationState;

	internal long Gold;

	[CompilerGenerated]
	private SnoItem isnoItem_0;

	[CompilerGenerated]
	private SnoItem isnoItem_1;

	[CompilerGenerated]
	private SnoItem isnoItem_2;

	[CompilerGenerated]
	private SnoItem isnoItem_3;

	internal List<SnoItem> cubedItems = new List<SnoItem>();

	internal Dictionary<string, SnoItem> dictionary_0 = new Dictionary<string, SnoItem>();

	internal ulong ulong_0;

	internal bool SkillOverrideActive;

	internal readonly Skill[] SkillSlots = new Skill[6];

	internal readonly SnoPower[] SnoPower_0 = new SnoPower[4];

	internal readonly List<SnoPower> UsedPassives = new List<SnoPower>();

	internal readonly Stopwatch iwatch_1 = new();

	[CompilerGenerated]
	private uint currentLevelNormal;

	[CompilerGenerated]
	private uint currentLevelNormalCap;

	[CompilerGenerated]
	private uint currentLevelParagon;

	[CompilerGenerated]
	private double currentLevelParagonDouble;

	internal bool bool_14;

	public long long_1;

	[CompilerGenerated]
	private long paragonExpInThisLevel;

	[CompilerGenerated]
	private long paragonExpToNextLevel;

	internal DebouncedValue<long> class362_0 = new DebouncedValue<long>(0L, 500);

	[CompilerGenerated]
	private long paragonTotalExp;

	[CompilerGenerated]
	private float bonusPoolPercent;

	[CompilerGenerated]
	private long bonusPoolRemaining;

	[CompilerGenerated]
	private int highestSoloRiftLevel;

	[CompilerGenerated]
	private int highestHeroSoloRiftLevel;

	internal long ParagonTotalExp2;

	internal List<Skill> list_3 = new List<Skill>(30);

	internal readonly Dictionary<string, Buff> dictionary_1 = new Dictionary<string, Buff>(30);

	internal readonly Dictionary<uint, Buff> powerSno2buff = new Dictionary<uint, Buff>(30);

	[CompilerGenerated]
	private int int_6;

	[CompilerGenerated]
	private int inventorySpaceTotal = 60;

	[CompilerGenerated]
	private int int_8;

	[CompilerGenerated]
	private bool isDead;

	[CompilerGenerated]
	private HeadStone iheadStone_0;

	internal Dictionary<uint, int> dictionary_3 = new Dictionary<uint, int>();

	internal Dictionary<uint, int> dictionary_4 = new Dictionary<uint, int>();

	internal Dictionary<uint, float> dictionary_5 = new Dictionary<uint, float>();

	internal Dictionary<uint, int> class112_0 = new Dictionary<uint, int>();

	internal Dictionary<uint, float> class112_1 = new Dictionary<uint, float>();

	internal float[] float_4 = new float[9];

	internal float[] float_5 = new float[9];

	[CompilerGenerated]
	private bool inCombat;

	[CompilerGenerated]
	private int loopingAnimationStartTick;

	[CompilerGenerated]
	private int loopingAnimationEndTick;

	public float float_6;

	[CompilerGenerated]
	private int paragonPointsAvailableTotal;

	[CompilerGenerated]
	private readonly int[] paragonPointsAvailable = new int[4];

	public readonly Dictionary<uint, int> class112_2 = new Dictionary<uint, int>();

	public int int_13;

	public bool bool_17;

	public const float float_7 = 5.5f;

	[CompilerGenerated]
	private bool inGreaterRift;

	[CompilerGenerated]
	private uint inGreaterRiftRank;

	public uint ActorId
	{
		[CompilerGenerated]
		get
		{
			return actorId;
		}
		[CompilerGenerated]
		set
		{
			actorId = value;
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return index;
		}
		[CompilerGenerated]
		set
		{
			index = value;
		}
	}

	public int PortraitIndex
	{
		[CompilerGenerated]
		get
		{
			return portraitIndex;
		}
		[CompilerGenerated]
		set
		{
			portraitIndex = value;
		}
	}

	public bool IsMe => Index == CoreCollector.D3Memory.LocalPlayerIndex;

	public bool IsInGame => RawPlayerData.IsInGameFlag == 2;

	public bool CoordinateKnown
	{
		[CompilerGenerated]
		get
		{
			return coordinateKnown;
		}
		[CompilerGenerated]
		set
		{
			coordinateKnown = value;
		}
	}

	public bool HasValidActor
	{
		get
		{
			if (base.AcdId != 0)
			{
				return base.AcdId != uint.MaxValue;
			}
			return false;
		}
	}

	public uint HeroId
	{
		[CompilerGenerated]
		get
		{
			return heroId;
		}
		[CompilerGenerated]
		set
		{
			heroId = value;
		}
	}

	public Hero Hero
	{
		[CompilerGenerated]
		get
		{
			return ihero_0;
		}
		[CompilerGenerated]
		set
		{
			ihero_0 = value;
		}
	}

	public string HeroName
	{
		[CompilerGenerated]
		get
		{
			return heroName;
		}
		[CompilerGenerated]
		set
		{
			heroName = value;
		}
	}

	public bool HeroIsHardcore
	{
		[CompilerGenerated]
		get
		{
			return heroIsHardcore;
		}
		[CompilerGenerated]
		set
		{
			heroIsHardcore = value;
		}
	}

	public bool HeroIsMale
	{
		[CompilerGenerated]
		get
		{
			return heroIsMale;
		}
		[CompilerGenerated]
		set
		{
			heroIsMale = value;
		}
	}

	public int Season
	{
		[CompilerGenerated]
		get
		{
			return season;
		}
		[CompilerGenerated]
		set
		{
			season = value;
		}
	}

	public bool Seasonal
	{
		[CompilerGenerated]
		get
		{
			return seasonal;
		}
		[CompilerGenerated]
		set
		{
			seasonal = value;
		}
	}

	public string BattleTagAbovePortrait
	{
		[CompilerGenerated]
		get
		{
			return battleTagAbovePortrait;
		}
		[CompilerGenerated]
		set
		{
			battleTagAbovePortrait = value;
		}
	}

	public HeroClassDefinition HeroClassDefinition
	{
		[CompilerGenerated]
		get
		{
			return iheroClassDefinition_0;
		}
		[CompilerGenerated]
		set
		{
			iheroClassDefinition_0 = value;
		}
	}

	public SnoArea SnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
		[CompilerGenerated]
		set
		{
			isnoArea_0 = value;
		}
	}

	public PlayerDefense Defense
	{
		[CompilerGenerated]
		get
		{
			return iplayerDefenseInfo_0;
		}
	}

	public PlayerOffense Offense
	{
		[CompilerGenerated]
		get
		{
			return iplayerOffenseInfo_0;
		}
	}

	public PlayerDamage Damage
	{
		[CompilerGenerated]
		get
		{
			return iplayerDamageInfo_0;
		}
	}

	public PlayerStats Stats
	{
		[CompilerGenerated]
		get
		{
			return iplayerStatInfo_0;
		}
	}

	public PlayerMaterialInfo Materials
	{
		[CompilerGenerated]
		get
		{
			return iplayerMaterialInfo_0;
		}
	}

	public PlayerPowerInfo Powers
	{
		[CompilerGenerated]
		get
		{
			return iplayerPowerInfo_0;
		}
	}

	public PlayerArmorySet[] ArmorySets
	{
		[CompilerGenerated]
		get
		{
			return iplayerArmorySet_0;
		}
	}

	public AnimSnoEnum Animation
	{
		[CompilerGenerated]
		get
		{
			return animation;
		}
		[CompilerGenerated]
		set
		{
			animation = value;
		}
	}

	public AcdAnimationState AnimationState
	{
		[CompilerGenerated]
		get
		{
			return animationState;
		}
		[CompilerGenerated]
		set
		{
			animationState = value;
		}
	}

	public SnoItem CubeSnoItem1
	{
		[CompilerGenerated]
		get
		{
			return isnoItem_0;
		}
		[CompilerGenerated]
		set
		{
			isnoItem_0 = value;
		}
	}

	public SnoItem CubeSnoItem2
	{
		[CompilerGenerated]
		get
		{
			return isnoItem_1;
		}
		[CompilerGenerated]
		set
		{
			isnoItem_1 = value;
		}
	}

	public SnoItem CubeSnoItem3
	{
		[CompilerGenerated]
		get
		{
			return isnoItem_2;
		}
		[CompilerGenerated]
		set
		{
			isnoItem_2 = value;
		}
	}

	public SnoItem CubeSnoItem4
	{
		[CompilerGenerated]
		get
		{
			return isnoItem_3;
		}
		[CompilerGenerated]
		set
		{
			isnoItem_3 = value;
		}
	}

	public IEnumerable<SnoItem> CubedItems => cubedItems;

	public uint CurrentLevelNormal
	{
		[CompilerGenerated]
		get
		{
			return currentLevelNormal;
		}
		[CompilerGenerated]
		set
		{
			currentLevelNormal = value;
		}
	}

	public uint CurrentLevelNormalCap
	{
		[CompilerGenerated]
		get
		{
			return currentLevelNormalCap;
		}
		[CompilerGenerated]
		set
		{
			currentLevelNormalCap = value;
		}
	}

	public uint CurrentLevelParagon
	{
		[CompilerGenerated]
		get
		{
			return currentLevelParagon;
		}
		[CompilerGenerated]
		set
		{
			currentLevelParagon = value;
		}
	}

	public double CurrentLevelParagonDouble
	{
		[CompilerGenerated]
		get
		{
			return currentLevelParagonDouble;
		}
		[CompilerGenerated]
		set
		{
			currentLevelParagonDouble = value;
		}
	}

	public long ParagonExpInThisLevel
	{
		[CompilerGenerated]
		get
		{
			return paragonExpInThisLevel;
		}
		[CompilerGenerated]
		set
		{
			paragonExpInThisLevel = value;
		}
	}

	public long ParagonExpToNextLevel
	{
		[CompilerGenerated]
		get
		{
			return paragonExpToNextLevel;
		}
		[CompilerGenerated]
		set
		{
			paragonExpToNextLevel = value;
		}
	}

	public long ParagonTotalExp
	{
		[CompilerGenerated]
		get
		{
			return paragonTotalExp;
		}
		[CompilerGenerated]
		set
		{
			paragonTotalExp = value;
		}
	}

	public float BonusPoolPercent
	{
		[CompilerGenerated]
		get
		{
			return bonusPoolPercent;
		}
		[CompilerGenerated]
		set
		{
			bonusPoolPercent = value;
		}
	}

	public long BonusPoolRemaining
	{
		[CompilerGenerated]
		get
		{
			return bonusPoolRemaining;
		}
		[CompilerGenerated]
		set
		{
			bonusPoolRemaining = value;
		}
	}

	public int HighestSoloRiftLevel
	{
		[CompilerGenerated]
		get
		{
			return highestSoloRiftLevel;
		}
		[CompilerGenerated]
		set
		{
			highestSoloRiftLevel = value;
		}
	}

	public int HighestHeroSoloRiftLevel
	{
		[CompilerGenerated]
		get
		{
			return highestHeroSoloRiftLevel;
		}
		[CompilerGenerated]
		set
		{
			highestHeroSoloRiftLevel = value;
		}
	}

	internal int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_6;
		}
		[CompilerGenerated]
		set
		{
			int_6 = value;
		}
	}

	public int InventorySpaceTotal
	{
		[CompilerGenerated]
		get
		{
			return inventorySpaceTotal;
		}
		[CompilerGenerated]
		set
		{
			inventorySpaceTotal = value;
		}
	}

	internal int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_8;
		}
		[CompilerGenerated]
		set
		{
			int_8 = value;
		}
	}

	public bool IsDead
	{
		[CompilerGenerated]
		get
		{
			return isDead;
		}
		[CompilerGenerated]
		set
		{
			isDead = value;
		}
	}

	public HeadStone HeadStone
	{
		[CompilerGenerated]
		get
		{
			return iheadStone_0;
		}
		[CompilerGenerated]
		set
		{
			iheadStone_0 = value;
		}
	}

	public Stopwatch LastDied { get; } = new Stopwatch();

	public bool InCombat
	{
		[CompilerGenerated]
		get
		{
			return inCombat;
		}
		[CompilerGenerated]
		set
		{
			inCombat = value;
		}
	}

	public int LoopingAnimationStartTick
	{
		[CompilerGenerated]
		get
		{
			return loopingAnimationStartTick;
		}
		[CompilerGenerated]
		set
		{
			loopingAnimationStartTick = value;
		}
	}

	public int LoopingAnimationEndTick
	{
		[CompilerGenerated]
		get
		{
			return loopingAnimationEndTick;
		}
		[CompilerGenerated]
		set
		{
			loopingAnimationEndTick = value;
		}
	}

	public int ParagonPointsAvailableTotal
	{
		[CompilerGenerated]
		get
		{
			return paragonPointsAvailableTotal;
		}
		[CompilerGenerated]
		set
		{
			paragonPointsAvailableTotal = value;
		}
	}

	public int[] ParagonPointsAvailable
	{
		[CompilerGenerated]
		get
		{
			return paragonPointsAvailable;
		}
	}

	public bool InGreaterRift
	{
		[CompilerGenerated]
		get
		{
			return inGreaterRift;
		}
		[CompilerGenerated]
		set
		{
			inGreaterRift = value;
		}
	}

	public uint InGreaterRiftRank
	{
		[CompilerGenerated]
		get
		{
			return inGreaterRiftRank;
		}
		[CompilerGenerated]
		set
		{
			inGreaterRiftRank = value;
		}
	}

	public bool IsInTown => SnoArea?.IsTown ?? false;

	public bool IsDeadSafeCheck
	{
		get
		{
			if (IsDead)
			{
				return LastDied.ElapsedMilliseconds > 300;
			}
			return false;
		}
	}

	public UiElement PortraitUiElement => CoreCollector.UiElements.class341_145[PortraitIndex];

	public Player(int int_14) : base(0u, 0u, null)
	{
		Index = int_14;
		iplayerDefenseInfo_0 = new PlayerDefense(this);
		iplayerPowerInfo_0 = new PlayerPowerInfo(this);
		iplayerMaterialInfo_0 = new PlayerMaterialInfo(this);
		PlayerArmorySet[] array =
		[
			new PlayerArmorySet(this, 0),
			new PlayerArmorySet(this, 1),
			new PlayerArmorySet(this, 2),
			new PlayerArmorySet(this, 3),
			new PlayerArmorySet(this, 4),
			new PlayerArmorySet(this, 5),
			new PlayerArmorySet(this, 6),
			new PlayerArmorySet(this, 7),
			new PlayerArmorySet(this, 8),
			new PlayerArmorySet(this, 9)
		];
		iplayerArmorySet_0 = array;
	}

	public void ResetStats()
	{
		Skill[] skillSlots = SkillSlots;
		foreach (Skill skill in skillSlots)
		{
			if (skill != null)
			{
				skill.OverrideSnoPower = null;
			}
		}
		Offense.CritBase = 0f;
		Offense.CritDamage = 50f;
		Offense.WeaponSpeedMainHand = 0f;
		Offense.WeaponSpeedOffHand = 0f;
		Offense.AttackSpeedMainHand = 0f;
		Offense.AttackSpeedOffHand = 0f;
		Offense.AttackSpeedPercent = 0f;
		Offense.AttackSpeedBonus = 0f;
		Offense.MainHandIsActive = true;
		Offense.WeaponDamageIncreasedBySkills = 0f;
		Offense.BonusToElitesBase = 0f;
		Array.Clear(Offense.ElementalDamageBonus, 0, Offense.ElementalDamageBonus.Length);
		Offense.HighestElementalDamageBonus = 0f;
		Offense.WeaponDamageMinPhysicalMainHand = 0f;
		Offense.WeaponDamageAddPhysicalMainHand = 0f;
		Offense.WeaponDamageMinElementalMainHand = 0f;
		Offense.WeaponDamageAddElementalMainHand = 0f;
		Offense.WeaponDamageMinPhysicalOffHand = 0f;
		Offense.WeaponDamageAddPhysicalOffHand = 0f;
		Offense.WeaponDamageMinElementalOffHand = 0f;
		Offense.WeaponDamageAddElementalOffHand = 0f;
		Offense.PlainDamageBonuses.Clear();
		Offense.DamageMin = 0f;
		Offense.AreaDamageBonus = 0f;
		base.SummonerId = 0u;
		Stats.GoldFind = 0f;
		Stats.MagicFind = 0f;
		Stats.MoveSpeed = 0f;
		Stats.MoveSpeedBonus = 0f;
		Stats.ExpOnKill = 0f;
		Stats.ExpOnKillNoPenalty = 0f;
		Stats.ExperiencePercentBonus = 0f;
		Stats.MainStat = 0f;
		Stats.Strength = 0f;
		Stats.Dexterity = 0f;
		Stats.Intelligence = 0f;
		Stats.Vitality = 0f;
		Stats.ResourceCurPri = 0f;
		Stats.ResourceCurSec = 0f;
		Stats.ResourceCurMana = 0f;
		Stats.ResourceCurArcane = 0f;
		Stats.ResourceCurFury = 0f;
		Stats.ResourceCurSpirit = 0f;
		Stats.ResourceCurHatred = 0f;
		Stats.ResourceCurDiscipline = 0f;
		Stats.ResourceCurWrath = 0f;
		Stats.ResourceCurEssence = 0f;
		Stats.ResourceRegPri = 0f;
		Stats.ResourceRegSec = 0f;
		Stats.ResourceRegMana = 0f;
		Stats.ResourceRegArcane = 0f;
		Stats.ResourceRegFury = 0f;
		Stats.ResourceRegSpirit = 0f;
		Stats.ResourceRegHatred = 0f;
		Stats.ResourceRegDiscipline = 0f;
		Stats.ResourceRegWrath = 0f;
		Stats.ResourceRegEssence = 0f;
		Stats.ResourceMaxPri = 0f;
		Stats.ResourceMaxSec = 0f;
		Stats.ResourceMaxMana = 0f;
		Stats.ResourceMaxArcane = 0f;
		Stats.ResourceMaxFury = 0f;
		Stats.ResourceMaxSpirit = 0f;
		Stats.ResourceMaxHatred = 0f;
		Stats.ResourceMaxDiscipline = 0f;
		Stats.ResourceMaxWrath = 0f;
		Stats.ResourceMaxEssence = 0f;
		Stats.CooldownReduction = 0f;
		Stats.ResourceCostReduction = 0f;
		Defense.Armor = 0f;
		Defense.ResPhysical = 0f;
		Defense.ResCold = 0f;
		Defense.ResFire = 0f;
		Defense.ResLightning = 0f;
		Defense.ResPoison = 0f;
		Defense.ResArcane = 0f;
		Defense.ResLowest = 0f;
		Defense.ResAverage = 0f;
		Defense.LifeBonus = 0f;
		Defense.LifeRegen = 0f;
		Defense.LifeOnHit = 0f;
		Defense.LifeOnKill = 0f;
		Defense.Thorns = 0f;
		Defense.GlobeBonusHealth = 0f;
		Defense.CurShield = 0f;
		Defense.CCReduction = 0f;
		Defense.DamageReduction = 0f;
		Defense.DRRanged = 0f;
		Defense.DRMelee = 0f;
		Defense.DRElite = 0f;
		Array.Clear(Defense.DamageReductionFromType, 0, Defense.DamageReductionFromType.Length);
		dictionary_3.Clear();
		dictionary_4.Clear();
		dictionary_5.Clear();
		class112_1.Clear();
		class112_0.Clear();
		Array.Clear(float_4, 0, float_4.Length);
		Array.Clear(float_5, 0, float_5.Length);
		CurrentLevelNormal = 0u;
		CurrentLevelNormalCap = 0u;
		CurrentLevelParagon = 0u;
		Stats.PickupRange = 5.5f;
		BonusPoolPercent = 0f;
		BonusPoolRemaining = 0L;
		HighestSoloRiftLevel = 0;
		InventorySpaceTotal = 60;
		Int32_2 = 0;
		Powers.Frozen = false;
		Powers.Rooted = false;
		Powers.Stunned = false;
		InCombat = false;
		LoopingAnimationStartTick = 0;
		LoopingAnimationEndTick = 0;
		InGreaterRift = false;
		InGreaterRiftRank = 0u;
		if (iwatch_1.ElapsedMilliseconds > 2000)
		{
			iwatch_1.Restart();
			foreach (Buff value in powerSno2buff.Values)
			{
				Array.Clear(value.TimeElapsedSeconds, 0, value.TimeElapsedSeconds.Length);
				Array.Clear(value.TimeLeftSeconds, 0, value.TimeLeftSeconds.Length);
				Array.Clear(value.IconCounts, 0, value.IconCounts.Length);
			}
		}
		class112_2.Clear();
	}

	public void ResetHero()
	{
		Hero = null;
		HeroName = "";
		HeroIsHardcore = false;
		HeroId = 0u;
		BattleTagAbovePortrait = null;
		HeroClassDefinition = null;
		SnoArea = null;
		bool_8 = false;
		ResetActor();
		class112_2.Clear();
	}

	public void ResetActor()
	{
		base.SnoActor = null;
		SetAcdId(0u);
		base.WorldId = 0u;
	}

	public bool IsCubed(SnoItem snoItem)
	{
		return dictionary_0.ContainsKey(snoItem.NameLocalized);
	}

	public int GetSetItemCount(uint setId)
	{
		if (!IsMe)
		{
			return 0;
		}
		int num = 0;
		foreach (Item item in CoreCollector.ItemCollector.Items.Values)
		{
			ItemLocation location = item.Location;
			if (location == ItemLocation.Bracers || location == ItemLocation.Shoulders || location == ItemLocation.Head || location == ItemLocation.Neck || location == ItemLocation.Torso || location == ItemLocation.Feet || location == ItemLocation.Hands || location == ItemLocation.LeftRing || location == ItemLocation.RightRing || location == ItemLocation.Waist || location == ItemLocation.Legs || location == ItemLocation.LeftHand || location == ItemLocation.RightHand)
			{
				num += item.CountsIntoSet(setId);
			}
		}
		int attributeValueAsInt = GetAttributeValueAsInt(SnoData.Attributes.Map.Attribute__Set_Item_Discount, 1048575u, 0);
		if (attributeValueAsInt > 0)
		{
			num += attributeValueAsInt;
		}
		else if (Powers.BuffIsActive(441113u))
		{
			num++;
		}
		return num;
	}

	public float GetPowerTagValue(SnoPower snoPower, uint tagId)
	{
		ulong key = ((ulong)snoPower.Sno << 32) + tagId;
		int? tagFormula = SnoData.Powers.GetTagFormula(0, key);
		if (!tagFormula.HasValue)
		{
			return SnoData.Powers.GetTagValue(0, key)?.Item2 ?? 0;
		}
		byte b = SnoData.Powers.FormulaData[tagFormula.Value];
		return CoreCollector.EvaluatePowerFormula(SnoData.Powers.FormulaData, tagFormula.Value + 1, b, snoPower, this).X;
	}
}
