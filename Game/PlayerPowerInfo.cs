using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;

namespace work;

internal class PlayerPowerInfo : IPlayerPowerInfo
{
	private readonly Player class310_0;

	private IPlayerSkill iplayerSkill_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private readonly IBarbarianPowerInfo ibarbarianPowerInfo_0;

	[CompilerGenerated]
	private readonly ICrusaderPowerInfo icrusaderPowerInfo_0;

	[CompilerGenerated]
	private readonly IDemonHunterPowerInfo idemonHunterPowerInfo_0;

	[CompilerGenerated]
	private readonly IMonkPowerInfo imonkPowerInfo_0;

	[CompilerGenerated]
	private readonly INecromancerPowerInfo inecromancerPowerInfo_0;

	[CompilerGenerated]
	private readonly IWitchDoctorPowerInfo iwitchDoctorPowerInfo_0;

	[CompilerGenerated]
	private readonly IWizardPowerInfo iwizardPowerInfo_0;

	[CompilerGenerated]
	private readonly ILegendaryPowerInfo ilegendaryPowerInfo_0;

	[CompilerGenerated]
	private readonly ILegendaryGemInfo ilegendaryGemInfo_0;

	public IPlayerSkill HealthPotionSkill => iplayerSkill_0 ?? (iplayerSkill_0 = new Skill(class310_0, SnoData.Powers.GetBySno(30211u), byte.MaxValue, ActionKey.Heal));

	public IEnumerable<IPlayerSkill> CurrentSkills => class310_0.class386_0.Where((Skill class386_0) => class386_0?.CurrentSnoPower != null);

	public IEnumerable<IPlayerSkill> UsedSkills => class310_0.class386_0.Where((Skill class386_0) => class386_0 != null);

	public IEnumerable<ISnoPower> UsedPassives => class310_0.list_2;

	public IPlayerSkill[] SkillSlots => class310_0.class386_0;

	public ISnoPower[] PassiveSlots => class310_0.isnoPower_0;

	public bool SkillOverrideActive => class310_0.bool_13;

	public IEnumerable<IBuff> AllBuffs => class310_0.powerSno2buff.Values;

	public bool Frozen
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool Rooted
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool Stunned
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
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

	public IBarbarianPowerInfo UsedBarbarianPowers
	{
		[CompilerGenerated]
		get
		{
			return ibarbarianPowerInfo_0;
		}
	}

	public ICrusaderPowerInfo UsedCrusaderPowers
	{
		[CompilerGenerated]
		get
		{
			return icrusaderPowerInfo_0;
		}
	}

	public IDemonHunterPowerInfo UsedDemonHunterPowers
	{
		[CompilerGenerated]
		get
		{
			return idemonHunterPowerInfo_0;
		}
	}

	public IMonkPowerInfo UsedMonkPowers
	{
		[CompilerGenerated]
		get
		{
			return imonkPowerInfo_0;
		}
	}

	public INecromancerPowerInfo UsedNecromancerPowers
	{
		[CompilerGenerated]
		get
		{
			return inecromancerPowerInfo_0;
		}
	}

	public IWitchDoctorPowerInfo UsedWitchDoctorPowers
	{
		[CompilerGenerated]
		get
		{
			return iwitchDoctorPowerInfo_0;
		}
	}

	public IWizardPowerInfo UsedWizardPowers
	{
		[CompilerGenerated]
		get
		{
			return iwizardPowerInfo_0;
		}
	}

	public ILegendaryPowerInfo UsedLegendaryPowers
	{
		[CompilerGenerated]
		get
		{
			return ilegendaryPowerInfo_0;
		}
	}

	public ILegendaryGemInfo UsedLegendaryGems
	{
		[CompilerGenerated]
		get
		{
			return ilegendaryGemInfo_0;
		}
	}

	public PlayerPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
		ibarbarianPowerInfo_0 = new BarbarianPowerInfo(class310_1);
		icrusaderPowerInfo_0 = new CrusaderPowerInfo(class310_1);
		idemonHunterPowerInfo_0 = new DemonHunterPowerInfo(class310_1);
		imonkPowerInfo_0 = new MonkPowerInfo(class310_1);
		inecromancerPowerInfo_0 = new NecromancerPowerInfo(class310_1);
		iwitchDoctorPowerInfo_0 = new WitchDoctorPowerInfo(class310_1);
		iwizardPowerInfo_0 = new WizardPowerInfo(class310_1);
		ilegendaryPowerInfo_0 = new LegendaryPowerInfo(class310_1);
		ilegendaryGemInfo_0 = new LegendaryGemInfo(class310_1);
	}

	public IPlayerSkill GetUsedSkill(ISnoPower snoPower)
	{
		if (snoPower == null)
		{
			return null;
		}
		if (snoPower == HealthPotionSkill.SnoPower)
		{
			return HealthPotionSkill;
		}
		Skill[] class386_ = class310_0.class386_0;
		int num = 0;
		Skill @class;
		while (true)
		{
			if (num < class386_.Length)
			{
				@class = class386_[num];
				if (@class != null && @class.CurrentSnoPower == snoPower)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return @class;
	}

	IPlayerSkill IPlayerPowerInfo.GetUsedSkill(ISnoPower snoPower)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUsedSkill
		return this.GetUsedSkill(snoPower);
	}

	public IBuff GetBuff(string code)
	{
		class310_0.dictionary_1.TryGetValue(code, out var value);
		return value;
	}

	IBuff IPlayerPowerInfo.GetBuff(string code)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetBuff
		return this.GetBuff(code);
	}

	public IBuff GetBuff(uint sno)
	{
		class310_0.powerSno2buff.TryGetValue(sno, out var value);
		return value;
	}

	IBuff IPlayerPowerInfo.GetBuff(uint sno)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetBuff
		return this.GetBuff(sno);
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

	bool IPlayerPowerInfo.BuffIsActive(uint sno)
	{
		//ILSpy generated this explicit interface implementation from .override directive in BuffIsActive
		return this.BuffIsActive(sno);
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

	bool IPlayerPowerInfo.BuffIsActive(uint sno, int iconIndex)
	{
		//ILSpy generated this explicit interface implementation from .override directive in BuffIsActive
		return this.BuffIsActive(sno, iconIndex);
	}
}
