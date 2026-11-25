using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Model;

public class PlayerPowerInfo
{
	private readonly Player class310_0;

	private Skill iplayerSkill_0;

	public Skill HealthPotionSkill => iplayerSkill_0 ?? (iplayerSkill_0 = new Skill(class310_0, SnoData.Powers.GetBySno(30211u), byte.MaxValue, ActionKey.Heal));

	public IEnumerable<Skill> CurrentSkills => class310_0.SkillSlots.Where((Skill skill) => skill?.CurrentSnoPower != null);

	public IEnumerable<Skill> UsedSkills => class310_0.SkillSlots.Where((Skill skill) => skill != null);

	public IEnumerable<SnoPower> UsedPassives => class310_0.UsedPassives;

	public Skill[] SkillSlots => class310_0.SkillSlots;

	public SnoPower[] PassiveSlots => class310_0.SnoPower_0;

	public bool SkillOverrideActive => class310_0.SkillOverrideActive;

	public IEnumerable<Buff> AllBuffs => class310_0.powerSno2buff.Values;

	public bool Frozen { get; set; }

	public bool Rooted { get; set; }

	public bool Stunned { get; set; }

	public bool CantMove
	{
		get
		{
			if (!Frozen && !Rooted)
			{
				return Stunned;
			}
			return true;
		}
	}

	public BarbarianPowerInfo UsedBarbarianPowers { get; }

	public CrusaderPowerInfo UsedCrusaderPowers { get; }

	public DemonHunterPowerInfo UsedDemonHunterPowers { get; }

	public MonkPowerInfo UsedMonkPowers { get; }

	public NecromancerPowerInfo UsedNecromancerPowers { get; }

	public WitchDoctorPowerInfo UsedWitchDoctorPowers { get; }

	public WizardPowerInfo UsedWizardPowers { get; }

	public LegendaryPowerInfo UsedLegendaryPowers { get; }

	public LegendaryGemInfo UsedLegendaryGems { get; }

	public PlayerPowerInfo(Player player)
	{
		class310_0 = player;
		UsedBarbarianPowers = new BarbarianPowerInfo(player);
		UsedCrusaderPowers = new CrusaderPowerInfo(player);
		UsedDemonHunterPowers = new DemonHunterPowerInfo(player);
		UsedMonkPowers = new MonkPowerInfo(player);
		UsedNecromancerPowers = new NecromancerPowerInfo(player);
		UsedWitchDoctorPowers = new WitchDoctorPowerInfo(player);
		UsedWizardPowers = new WizardPowerInfo(player);
		UsedLegendaryPowers = new LegendaryPowerInfo(player);
		UsedLegendaryGems = new LegendaryGemInfo(player);
	}

	public Skill GetUsedSkill(SnoPower snoPower)
	{
		if (snoPower == null)
		{
			return null;
		}
		if (snoPower == HealthPotionSkill.SnoPower)
		{
			return HealthPotionSkill;
		}
		Skill[] class386_ = class310_0.SkillSlots;
		int num = 0;
		Skill skill;
		while (true)
		{
			if (num < class386_.Length)
			{
				skill = class386_[num];
				if (skill != null && skill.CurrentSnoPower == snoPower)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return skill;
	}

	public Buff GetBuff(string code)
	{
		class310_0.dictionary_1.TryGetValue(code, out var value);
		return value;
	}

	public Buff GetBuff(uint sno)
	{
		class310_0.powerSno2buff.TryGetValue(sno, out var value);
		return value;
	}

	public bool BuffIsActive(uint sno)
	{
		if (!class310_0.powerSno2buff.TryGetValue(sno, out var value))
		{
			return false;
		}
		return value.Active;
	}

	public bool BuffIsActive(uint sno, int iconIndex)
	{
		if (!class310_0.powerSno2buff.TryGetValue(sno, out var value))
		{
			return false;
		}
		if (value.Active && (iconIndex == -1 || value.IconCounts[iconIndex] >= 1))
		{
			return true;
		}
		return false;
	}
}
