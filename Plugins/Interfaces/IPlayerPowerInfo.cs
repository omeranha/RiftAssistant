using System.Collections.Generic;

namespace Plugins;

public interface IPlayerPowerInfo
{
	IPlayerSkill HealthPotionSkill { get; }

	IEnumerable<IPlayerSkill> UsedSkills { get; }

	IEnumerable<IPlayerSkill> CurrentSkills { get; }

	IEnumerable<ISnoPower> UsedPassives { get; }

	IPlayerSkill[] SkillSlots { get; }

	ISnoPower[] PassiveSlots { get; }

	bool SkillOverrideActive { get; }

	IBarbarianPowerInfo UsedBarbarianPowers { get; }

	ICrusaderPowerInfo UsedCrusaderPowers { get; }

	IDemonHunterPowerInfo UsedDemonHunterPowers { get; }

	IMonkPowerInfo UsedMonkPowers { get; }

	INecromancerPowerInfo UsedNecromancerPowers { get; }

	IWitchDoctorPowerInfo UsedWitchDoctorPowers { get; }

	IWizardPowerInfo UsedWizardPowers { get; }

	ILegendaryPowerInfo UsedLegendaryPowers { get; }

	ILegendaryGemInfo UsedLegendaryGems { get; }

	IEnumerable<IBuff> AllBuffs { get; }

	bool Frozen { get; set; }

	bool Rooted { get; set; }

	bool Stunned { get; set; }

	bool CantMove { get; }

	IPlayerSkill GetUsedSkill(ISnoPower snoPower);

	IBuff GetBuff(string code);

	IBuff GetBuff(uint sno);

	bool BuffIsActive(uint sno);

	bool BuffIsActive(uint sno, int iconIndex);
}
