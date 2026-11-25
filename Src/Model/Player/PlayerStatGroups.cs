using System;
using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Model;

public class PlayerArmorySet(Player player, int int_1)
{
	public r_ArmorySet ArmorySet { get; set; }

	public Player Player { get; set; } = player;

	public int Index { get; set; } = int_1;

	public string Name { get; set; }

	public uint PotionAnnId => ArmorySet.armoryPotion.PotionAnnId;

	public List<uint> itemAnnIds = new List<uint>();

	public SnoItem PotionSno => SnoData.Items.GetBySno(ArmorySet.armoryPotion.sno);

	public SnoItem CubeSnoItem1 => SnoData.Items.GetBySno(ArmorySet.uint_4);

	public SnoItem CubeSnoItem2 => SnoData.Items.GetBySno(ArmorySet.uint_5);

	public SnoItem CubeSnoItem3 => SnoData.Items.GetBySno(ArmorySet.uint_6);

	public SnoItem CubeSnoItem4 => SnoData.Items.GetBySno(ArmorySet.uint_7);

	public SnoPower LeftSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill.sno);

	public byte LeftSkillRune => (byte)ArmorySet.armorySkill.uint_1;

	public SnoPower RightSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill1.sno);

	public byte RightSkillRune => (byte)ArmorySet.armorySkill1.uint_1;

	public SnoPower Skill1SnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill2.sno);

	public byte Skill1Rune => (byte)ArmorySet.armorySkill2.uint_1;

	public SnoPower Skill2SnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill3.sno);

	public byte Skill2Rune => (byte)ArmorySet.armorySkill3.uint_1;

	public SnoPower Skill3SnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill4.sno);

	public byte Skill3Rune => (byte)ArmorySet.armorySkill4.uint_1;

	public SnoPower Skill4SnoPower => SnoData.Powers.GetBySno(ArmorySet.armorySkill5.sno);

	public byte Skill4Rune => (byte)ArmorySet.armorySkill5.uint_1;

	public SnoPower PassiveSnoPower1 => SnoData.Powers.GetBySno(ArmorySet.sno);

	public SnoPower PassiveSnoPower2 => SnoData.Powers.GetBySno(ArmorySet.uint_1);

	public SnoPower PassiveSnoPower3 => SnoData.Powers.GetBySno(ArmorySet.uint_2);

	public SnoPower PassiveSnoPower4 => SnoData.Powers.GetBySno(ArmorySet.uint_3);

	public IEnumerable<uint> ItemAnnIds => itemAnnIds;

	public bool ContainsItem(Item item)
	{
		return itemAnnIds.Any((uint uint_0) => item.AnnId == uint_0);
	}

	public void AddItemAnnId(uint uint_0)
	{
		if (uint_0 != uint.MaxValue)
		{
			itemAnnIds.Add(uint_0);
		}
	}
}

public class PlayerDamage
{
	public double TotalDamage { get; set; }

	public double RunDps { get; set; }

	public double CurrentDps { get; set; }

	public double MaximumDps { get; set; }
}

public class PlayerDefense(Player player)
{
	private readonly Player player = player;

	public float EhpCur { get; set; }

	public float EhpMax { get; set; }

	public float HealthCur { get; set; }

	public float HealthMax { get; set; }

	public float HealthPct { get; set; }

	public float CurShield { get; set; }

	public float Armor { get; set; }

	public float LifeBonus { get; set; }

	public float ResPhysical { get; set; }

	public float ResCold { get; set; }

	public float ResFire { get; set; }

	public float ResLightning { get; set; }

	public float ResPoison { get; set; }

	public float ResArcane { get; set; }

	public float ResLowest { get; set; }

	public float ResAverage { get; set; }

	public float LifeRegen { get; set; }

	public float LifeOnHit { get; set; }

	public float LifeOnKill { get; set; }

	public float Thorns { get; set; }

	public float GlobeBonusHealth { get; set; }

	public float DRClass { get; set; }

	public float drArmor { get; set; }

	public float drResist { get; set; }

	public float drCombined { get; set; }

	public float[] DamageReductionFromType { get; set; } = new float[6];

	public float AverageDamageReductionFromType { get; set; }

	public float CCReduction { get; set; }

	public float DamageReduction { get; set; }

	public float DRRanged { get; set; }

	public float DRMelee { get; set; }

	public float DRElite { get; set; }

	public double CurrentDamageTakenPerSecond { get; set; }

	public double CurrentHealingPerSecond { get; set; }

	public double CurrentEffectiveHealingPercent
	{
		get {
			double num = CurrentHealingPerSecond - CurrentDamageTakenPerSecond;
			if (!(Math.Abs(num) < 1.0) && player.Defense.HealthMax != 0f) {
				return Math.Max(-100.0, Math.Min(100.0, num * 100.0 / (double)player.Defense.HealthMax));
			}
			return 0.0;
		}
	}
}

public class PlayerOffense
{
	public bool MainHandIsActive { get; set; }

	public float AttackSpeedPets { get; set; }

	public float AttackSpeedPercent { get; set; }

	public float WeaponSpeedMainHand { get; set; }

	public float WeaponSpeedOffHand { get; set; }

	public float AttackSpeedMainHand { get; set; }

	public float AttackSpeedOffHand { get; set; }

	public float AttackSpeedBonus { get; set; }

	public float CritBase { get; set; }

	public float CritDamage { get; set; }

	public float AttackSpeed {  get; set; }

	public float CriticalHitChance { get; set; }

	public float WeaponDamageIncreasedBySkills { get; set; }

	public float BonusToElitesBase { get; set; }

	public List<(SnoPower, float)> PlainDamageBonuses { get; set; } = [];

	public float WeaponDamageMinPhysicalMainHand { get; set; }

	public float WeaponDamageAddPhysicalMainHand { get; set; }

	public float WeaponDamageMinElementalMainHand { get; set; }

	public float WeaponDamageAddElementalMainHand { get; set; }

	public float WeaponDamageMinPhysicalOffHand { get; set; }

	public float WeaponDamageAddPhysicalOffHand { get; set; }

	public float WeaponDamageMinElementalOffHand { get; set; }

	public float WeaponDamageAddElementalOffHand { get; set; }

	public float WeaponBaseDamageMinAmainHand { get; set; }

	public float WeaponBaseDamageMinAoffHand { get; set; }

	public float WeaponBaseDamageMaxAmainHand { get; set; }

	public float WeaponBaseDamageMaxAoffHand { get; set; }

	public float WeaponBaseDamageMinBmainHand { get; set; }

	public float WeaponBaseDamageMinBoffHand { get; set; }

	public float WeaponBaseDamageMaxBmainHand { get; set; }

	public float WeaponBaseDamageMaxBoffHand { get; set; }

	public float DamageMin { get; set; }

	public float DamageMax { get; set; }

	public float WeaponDamageMainHand { get; set; }

	public float WeaponDamageSecondHand { get; set; }

	public float SheetDpsMainHand { get; set; }

	public float SheetDpsOffHand { get; set; }

	public float SheetDps { get; set; }

	public float AreaDamageBonus { get; set; }

	public float[] ElementalDamageBonus { get; set; } = new float[8];

	public float HighestElementalDamageBonus { get; set; }

	public float BonusToPhysical => ElementalDamageBonus[0];

	public float BonusToFire => ElementalDamageBonus[1];

	public float BonusToLightning => ElementalDamageBonus[2];

	public float BonusToCold => ElementalDamageBonus[3];

	public float BonusToPoison => ElementalDamageBonus[4];

	public float BonusToArcane => ElementalDamageBonus[5];

	public float BonusToHoly => ElementalDamageBonus[6];

	public float BonusToElites => BonusToElitesBase;
}

public class PlayerStats
{
	public float ResourceMaxArcane { get; set; }

	public float ResourceMaxSpirit { get; set; }

	public float ResourceMaxFury { get; set; }

	public float ResourceMaxMana { get; set; }

	public float ResourceMaxHatred { get; set; }

	public float ResourceMaxDiscipline { get; set; }

	public float ResourceMaxWrath { get; set; }

	public float ResourceMaxEssence { get; set; }

	public float ResourceCurArcane { get; set; }

	public float ResourceCurSpirit { get; set; }

	public float ResourceCurFury { get; set; }

	public float ResourceCurMana { get; set; }

	public float ResourceCurHatred { get; set; }

	public float ResourceCurDiscipline { get; set; }

	public float ResourceCurWrath { get; set; }

	public float ResourceCurEssence { get; set; }

	public float ResourcePctArcane { get; set; }

	public float ResourcePctSpirit { get; set; }

	public float ResourcePctFury { get; set; }

	public float ResourcePctMana { get; set; }

	public float ResourcePctHatred { get; set; }

	public float ResourcePctDiscipline { get; set; }

	public float ResourcePctWrath { get; set; }

	public float ResourcePctEssence { get; set; }

	public float ResourceRegArcane { get; set; }

	public float ResourceRegSpirit { get; set; }

	public float ResourceRegFury { get; set; }

	public float ResourceRegMana { get; set; }

	public float ResourceRegHatred { get; set; }

	public float ResourceRegDiscipline { get; set; }

	public float ResourceRegWrath { get; set; }

	public float ResourceRegEssence { get; set; }

	public float ResourceCurPri { get; set; }

	public float ResourceCurSec { get; set; }

	public float ResourceMaxPri { get; set; }

	public float ResourceMaxSec { get; set; }

	public float ResourcePctPri { get; set; }

	public float ResourcePctSec { get; set; }

	public float ResourceRegPri { get; set; }

	public float ResourceRegSec { get; set; }

	public float CooldownReduction { get; set; }

	public float ResourceCostReduction { get; set; }

	public float MainStat { get; set; }

	public float Strength { get; set; }

	public float Dexterity { get; set; }

	public float Intelligence { get; set; }

	public float Vitality { get; set; }

	public float MoveSpeed { get; set; }

	public float MoveSpeedBonus { get; set; }

	public float MagicFind { get; set; }

	public float GoldFind { get; set; }

	public float ExperiencePercentBonus { get; set; }

	public float ExpOnKill { get; set; }

	public float ExpOnKillNoPenalty { get; set; }

	public float ExperienceOnKillBonus => ExpOnKill + ExpOnKillNoPenalty;

	public float PickupRange { get; set; }
}
