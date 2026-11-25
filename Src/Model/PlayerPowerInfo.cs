using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Model;

public class PlayerPowerInfo
{
	private readonly Player player0;

	private Skill skill0;

	public Skill HealthPotionSkill => skill0 ?? (skill0 = new Skill(player0, SnoData.Powers.GetBySno(30211u), byte.MaxValue, ActionKey.Heal));

	public IEnumerable<Skill> CurrentSkills => player0.SkillSlots.Where((Skill skill) => skill?.CurrentSnoPower != null);

	public IEnumerable<Skill> UsedSkills => player0.SkillSlots.Where((Skill skill) => skill != null);

	public IEnumerable<SnoPower> UsedPassives => player0.UsedPassives;

	public Skill[] SkillSlots => player0.SkillSlots;

	public SnoPower[] PassiveSlots => player0.SnoPowers0;

	public bool SkillOverrideActive => player0.SkillOverrideActive;

	public IEnumerable<Buff> AllBuffs => player0.powerSno2buff.Values;

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
		player0 = player;
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
		Skill[] class386_ = player0.SkillSlots;
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
		player0.buffsByKey.TryGetValue(code, out var value);
		return value;
	}

	public Buff GetBuff(uint sno)
	{
		player0.powerSno2buff.TryGetValue(sno, out var value);
		return value;
	}

	public bool BuffIsActive(uint sno)
	{
		if (!player0.powerSno2buff.TryGetValue(sno, out var value))
		{
			return false;
		}
		return value.Active;
	}

	public bool BuffIsActive(uint sno, int iconIndex)
	{
		if (!player0.powerSno2buff.TryGetValue(sno, out var value))
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
