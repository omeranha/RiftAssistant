using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RiftAssistant.Model;

public class Player : Actor
{

	public bool bool_8;

	internal r_PlayerData RawPlayerData;

	internal long Gold;

	internal List<SnoItem> cubedItems = new List<SnoItem>();

	internal Dictionary<string, SnoItem> dictionary_0 = new Dictionary<string, SnoItem>();

	internal ulong ulong_0;

	internal bool SkillOverrideActive;

	internal readonly Skill[] SkillSlots = new Skill[6];

	internal readonly SnoPower[] SnoPower_0 = new SnoPower[4];

	internal readonly List<SnoPower> UsedPassives = new List<SnoPower>();

	internal readonly Stopwatch iwatch_1 = new();

	internal bool bool_14;

	public long long_1;

	internal DebouncedValue<long> class362_0 = new DebouncedValue<long>(0L, 500);

	internal long ParagonTotalExp2;

	internal List<Skill> list_3 = new List<Skill>(30);

	internal readonly Dictionary<string, Buff> dictionary_1 = new Dictionary<string, Buff>(30);

	internal readonly Dictionary<uint, Buff> powerSno2buff = new Dictionary<uint, Buff>(30);

	internal Dictionary<uint, int> dictionary_3 = new Dictionary<uint, int>();

	internal Dictionary<uint, int> dictionary_4 = new Dictionary<uint, int>();

	internal Dictionary<uint, float> dictionary_5 = new Dictionary<uint, float>();

	internal Dictionary<uint, int> class112_0 = new Dictionary<uint, int>();

	internal Dictionary<uint, float> class112_1 = new Dictionary<uint, float>();

	internal float[] float_4 = new float[9];

	internal float[] float_5 = new float[9];

	public float float_6;

	public readonly Dictionary<uint, int> class112_2 = new Dictionary<uint, int>();

	public int int_13;

	public bool bool_17;

	public const float float_7 = 5.5f;

	public uint ActorId { get; set; }

	public int Index { get; set; }

	public int PortraitIndex { get; set; }

	public bool IsMe => Index == CoreCollector.D3Memory.LocalPlayerIndex;

	public bool IsInGame => RawPlayerData.IsInGameFlag == 2;

	public bool CoordinateKnown { get; set; }

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

	public uint HeroId { get; set; }

	public Hero Hero { get; set; }

	public string HeroName { get; set; }

	public bool HeroIsHardcore { get; set; }

	public bool HeroIsMale { get; set; }

	public int Season { get; set; }

	public bool Seasonal { get; set; }

	public string BattleTagAbovePortrait { get; set; }

	public HeroClassDefinition HeroClassDefinition { get; set; }

	public SnoArea SnoArea { get; set; }

	public PlayerDefense Defense { get; }

	public PlayerOffense Offense { get; } = new PlayerOffense();

	public PlayerDamage Damage { get; } = new PlayerDamage();

	public PlayerStats Stats { get; } = new PlayerStats();

	public PlayerMaterialInfo Materials { get; }

	public PlayerPowerInfo Powers { get; }

	public PlayerArmorySet[] ArmorySets { get; }

	public AnimSnoEnum Animation { get; set; }

	public AcdAnimationState AnimationState { get; set; }

	public SnoItem CubeSnoItem1 { get; set; }

	public SnoItem CubeSnoItem2 { get; set; }

	public SnoItem CubeSnoItem3 { get; set; }

	public SnoItem CubeSnoItem4 { get; set; }

	public IEnumerable<SnoItem> CubedItems => cubedItems;

	public uint CurrentLevelNormal { get; set; }

	public uint CurrentLevelNormalCap { get; set; }

	public uint CurrentLevelParagon { get; set; }

	public double CurrentLevelParagonDouble { get; set; }

	public long ParagonExpInThisLevel { get; set; }

	public long ParagonExpToNextLevel { get; set; }

	public long ParagonTotalExp { get; set; }

	public float BonusPoolPercent { get; set; }

	public long BonusPoolRemaining { get; set; }

	public int HighestSoloRiftLevel { get; set; }

	public int HighestHeroSoloRiftLevel { get; set; }

	internal int Int32_1 { get; set; }

	public int InventorySpaceTotal { get; set; } = 60;

	internal int Int32_2 { get; set; }

	public bool IsDead { get; set; }

	public HeadStone HeadStone { get; set; }

	public Stopwatch LastDied { get; } = new Stopwatch();

	public bool InCombat { get; set; }

	public int LoopingAnimationStartTick { get; set; }

	public int LoopingAnimationEndTick { get; set; }

	public int ParagonPointsAvailableTotal { get; set; }

	public int[] ParagonPointsAvailable { get; } = new int[4];

	public bool InGreaterRift { get; set; }

	public uint InGreaterRiftRank { get; set; }

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
		Defense = new PlayerDefense(this);
		Powers = new PlayerPowerInfo(this);
		Materials = new PlayerMaterialInfo(this);
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
		ArmorySets = array;
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
