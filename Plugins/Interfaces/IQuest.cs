using System.Diagnostics;

namespace Plugins;

public interface IQuest
{
	ISnoQuest SnoQuest { get; }

	int CreatedOn { get; }

	uint QuestStepId { get; }

	ISnoQuestStep QuestStep { get; }

	QuestState State { get; }

	Stopwatch CompletedOn { get; }

	Stopwatch StartedOn { get; }

	float Progress { get; }

	int Counter { get; }

	bool IsFinished(uint stepId);
}
