using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public class PlayerPowerInfo
{
	private readonly Player class310_0;

	private Skill iplayerSkill_0;

	[CompilerGenerated]
	private bool frozen;

	[CompilerGenerated]
	private bool rooted;

	[CompilerGenerated]
	private bool stunned;

	[CompilerGenerated]
	private readonly BarbarianPowerInfo ibarbarianPowerInfo_0;

	[CompilerGenerated]
	private readonly CrusaderPowerInfo icrusaderPowerInfo_0;

	[CompilerGenerated]
	private readonly DemonHunterPowerInfo idemonHunterPowerInfo_0;

	[CompilerGenerated]
	private readonly MonkPowerInfo imonkPowerInfo_0;

	[CompilerGenerated]
	private readonly NecromancerPowerInfo inecromancerPowerInfo_0;

	[CompilerGenerated]
	private readonly WitchDoctorPowerInfo iwitchDoctorPowerInfo_0;

	[CompilerGenerated]
	private readonly WizardPowerInfo iwizardPowerInfo_0;

	[CompilerGenerated]
	private readonly LegendaryPowerInfo usedLegendaryPowers;

	[CompilerGenerated]
	private readonly LegendaryGemInfo ilegendaryGemInfo_0;

	public Skill HealthPotionSkill => iplayerSkill_0 ?? (iplayerSkill_0 = new Skill(class310_0, SnoData.Powers.GetBySno(30211u), byte.MaxValue, ActionKey.Heal));

	public IEnumerable<Skill> CurrentSkills => class310_0.SkillSlots.Where((Skill skill) => skill?.CurrentSnoPower != null);

	public IEnumerable<Skill> UsedSkills => class310_0.SkillSlots.Where((Skill skill) => skill != null);

	public IEnumerable<SnoPower> UsedPassives => class310_0.UsedPassives;

	public Skill[] SkillSlots => class310_0.SkillSlots;

	public SnoPower[] PassiveSlots => class310_0.SnoPower_0;

	public bool SkillOverrideActive => class310_0.SkillOverrideActive;

	public IEnumerable<Buff> AllBuffs => class310_0.powerSno2buff.Values;

	public bool Frozen
	{
		[CompilerGenerated]
		get
		{
			return frozen;
		}
		[CompilerGenerated]
		set
		{
			frozen = value;
		}
	}

	public bool Rooted
	{
		[CompilerGenerated]
		get
		{
			return rooted;
		}
		[CompilerGenerated]
		set
		{
			rooted = value;
		}
	}

	public bool Stunned
	{
		[CompilerGenerated]
		get
		{
			return stunned;
		}
		[CompilerGenerated]
		set
		{
			stunned = value;
		}
	}

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

	public BarbarianPowerInfo UsedBarbarianPowers
	{
		[CompilerGenerated]
		get
		{
			return ibarbarianPowerInfo_0;
		}
	}

	public CrusaderPowerInfo UsedCrusaderPowers
	{
		[CompilerGenerated]
		get
		{
			return icrusaderPowerInfo_0;
		}
	}

	public DemonHunterPowerInfo UsedDemonHunterPowers
	{
		[CompilerGenerated]
		get
		{
			return idemonHunterPowerInfo_0;
		}
	}

	public MonkPowerInfo UsedMonkPowers
	{
		[CompilerGenerated]
		get
		{
			return imonkPowerInfo_0;
		}
	}

	public NecromancerPowerInfo UsedNecromancerPowers
	{
		[CompilerGenerated]
		get
		{
			return inecromancerPowerInfo_0;
		}
	}

	public WitchDoctorPowerInfo UsedWitchDoctorPowers
	{
		[CompilerGenerated]
		get
		{
			return iwitchDoctorPowerInfo_0;
		}
	}

	public WizardPowerInfo UsedWizardPowers
	{
		[CompilerGenerated]
		get
		{
			return iwizardPowerInfo_0;
		}
	}

	public LegendaryPowerInfo UsedLegendaryPowers
	{
		[CompilerGenerated]
		get
		{
			return usedLegendaryPowers;
		}
	}

	public LegendaryGemInfo UsedLegendaryGems
	{
		[CompilerGenerated]
		get
		{
			return ilegendaryGemInfo_0;
		}
	}

	public PlayerPowerInfo(Player player)
	{
		class310_0 = player;
		ibarbarianPowerInfo_0 = new BarbarianPowerInfo(player);
		icrusaderPowerInfo_0 = new CrusaderPowerInfo(player);
		idemonHunterPowerInfo_0 = new DemonHunterPowerInfo(player);
		imonkPowerInfo_0 = new MonkPowerInfo(player);
		inecromancerPowerInfo_0 = new NecromancerPowerInfo(player);
		iwitchDoctorPowerInfo_0 = new WitchDoctorPowerInfo(player);
		iwizardPowerInfo_0 = new WizardPowerInfo(player);
		usedLegendaryPowers = new LegendaryPowerInfo(player);
		ilegendaryGemInfo_0 = new LegendaryGemInfo(player);
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

	public bool method_0(string string_0)
	{
		if (string_0 == null)
		{
			return false;
		}
		return GetBuff(string_0)?.Active ?? false;
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
