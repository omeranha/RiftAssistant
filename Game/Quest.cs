using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;

public class Quest(SnoQuest isnoQuest_1)
{
	private readonly Stopwatch iwatch_2 = new();

	public SnoQuest SnoQuest { get; set; } = isnoQuest_1;

	public int CreatedOn { get; set; }

	public uint QuestStepId { get; set; }

	public SnoQuestStep QuestStep { get; set; }

	public QuestState State { get; set; }

	public Stopwatch CompletedOn { get; } = new Stopwatch();

	public Stopwatch StartedOn { get; } = new Stopwatch();

	public float Progress { get; set; }

	public int Counter { get; set; }

	public override string ToString()
	{
		return SnoQuest.NameLocalized + " (" + SnoQuest.Type.ToString() + ")" + ((QuestStep != null) ? (", step#" + QuestStep.Id) : null) + ", " + State;
	}

	public bool IsFinished(uint stepId)
	{
		bool flag = false;
		if (stepId != uint.MaxValue) {
			if (QuestStep != null && QuestStep.Id != stepId) {
				flag = true;
			}
		} else if (State == QuestState.completed) {
			flag = true;
		}
		if (flag) {
			iwatch_2.Start();
			if (iwatch_2.ElapsedMilliseconds > 2000) {
				return true;
			}
		}
		return false;
	}
}
