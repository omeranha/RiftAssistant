using Plugins;

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
