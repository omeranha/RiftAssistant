using System.Collections.Generic;
using Plugins;

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
