using System.Collections.Generic;

namespace Plugins;

public interface ISnoQuest
{
	string Code { get; }

	uint Sno { get; }

	string NameLocalized { get; }

	string NameEnglish { get; }

	string DescriptionLocalized { get; }

	string DescriptionEnglish { get; }

	ISnoAct SnoAct { get; }

	QuestType Type { get; }

	QuestEventType EventType { get; }

	int UnassignedStepId { get; }

	string UnassignedStepBnetTitleLocalized { get; }

	string UnassignedStepBnetTitleEnglish { get; }

	BountyAct BountyAct { get; }

	BountyType BountyType { get; }

	ISnoArea BountySnoArea { get; }

	IEnumerable<ISnoQuestStep> Steps { get; }

	ISnoQuestStep GetStep(uint stepId);
}
