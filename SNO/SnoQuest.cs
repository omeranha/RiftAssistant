using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoQuest : ISnoQuest
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	[CompilerGenerated]
	private readonly ISnoAct isnoAct_0;

	[CompilerGenerated]
	private readonly QuestType questType_0;

	[CompilerGenerated]
	private readonly QuestEventType questEventType_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_5;

	[CompilerGenerated]
	private readonly string string_6;

	[CompilerGenerated]
	private readonly BountyAct bountyAct_0;

	[CompilerGenerated]
	private readonly BountyType bountyType_0;

	[CompilerGenerated]
	private readonly ISnoArea isnoArea_0;

	private readonly Dictionary<uint, ISnoQuestStep> dictionary_0 = new Dictionary<uint, ISnoQuestStep>();

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string DescriptionLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string DescriptionEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	public ISnoAct SnoAct
	{
		[CompilerGenerated]
		get
		{
			return isnoAct_0;
		}
	}

	public QuestType Type
	{
		[CompilerGenerated]
		get
		{
			return questType_0;
		}
	}

	public QuestEventType EventType
	{
		[CompilerGenerated]
		get
		{
			return questEventType_0;
		}
	}

	public int UnassignedStepId
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string UnassignedStepBnetTitleLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
	}

	public string UnassignedStepBnetTitleEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
	}

	public BountyAct BountyAct
	{
		[CompilerGenerated]
		get
		{
			return bountyAct_0;
		}
	}

	public BountyType BountyType
	{
		[CompilerGenerated]
		get
		{
			return bountyType_0;
		}
	}

	public ISnoArea BountySnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
	}

	public IEnumerable<ISnoQuestStep> Steps => dictionary_0.Values;

	public ISnoQuestStep GetStep(uint stepId)
	{
		dictionary_0.TryGetValue(stepId, out var value);
		return value;
	}

	ISnoQuestStep ISnoQuest.GetStep(uint stepId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetStep
		return this.GetStep(stepId);
	}

	internal SnoQuest(string string_7, uint uint_1, ISnoAct isnoAct_1, string string_8, string string_9, string string_10, string string_11, QuestType questType_1, QuestEventType questEventType_1, int int_1, string string_12, string string_13, BountyAct bountyAct_1, BountyType bountyType_1, ISnoArea isnoArea_1)
	{
		string_0 = string_7;
		uint_0 = uint_1;
		isnoAct_0 = isnoAct_1;
		string_1 = string_8;
		string_2 = string_9;
		string_3 = string_10;
		string_4 = string_11;
		bountyAct_0 = bountyAct_1;
		bountyType_0 = bountyType_1;
		isnoArea_0 = isnoArea_1;
		questType_0 = questType_1;
		questEventType_0 = questEventType_1;
		int_0 = int_1;
		string_5 = string_12;
		string_6 = string_13;
	}

	internal void method_0(ISnoQuestStep isnoQuestStep_0)
	{
		dictionary_0.Add(isnoQuestStep_0.Id, isnoQuestStep_0);
	}
}
