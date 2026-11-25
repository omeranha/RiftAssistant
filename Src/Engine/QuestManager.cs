using System;
using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal class QuestManager
{
	private readonly Allocator allocator = new Allocator(512, "rQuestAllocator");

	private r_Quest[] quests = null!;

	private readonly Dictionary<uint, Quest> questsByKey = new Dictionary<uint, Quest>();

	public readonly Dictionary<uint, Quest> Quests = new Dictionary<uint, Quest>();

	public readonly Dictionary<uint, Quest> Bounties = new Dictionary<uint, Quest>();

	internal void Refresh()
	{
		Quests.Clear();
		Bounties.Clear();
		allocator.Snapshot(CoreCollector.D3Memory.QuestManagerAddress);
		int totalElementCount = allocator.GetTotalElementCount();
		if (totalElementCount <= 0) {
			return;
		}
		if (quests == null || quests.Length != totalElementCount) {
			quests = new r_Quest[totalElementCount];
		}
		int num = 0;
		for (int i = 0; i < allocator.RawBlocks.Count; i++) {
			r_Block r_Block2 = allocator.RawBlocks[i];
			if (r_Block2.ElementCount > 0) {
				GameWindowManager.ReadIntoArray(r_Block2.ArrayStart, quests, num, r_Block2.ElementCount);
			}
			num += r_Block2.ElementCount;
		}
		for (int j = 0; j < totalElementCount; j++) {
			ReadQuest(ref quests[j]);
		}
	}

	internal void Clear()
	{
		Quests.Clear();
		Bounties.Clear();
		questsByKey.Clear();
	}

	private void ReadQuest(ref r_Quest quest2)
	{
		uint uint_ = quest2.uint_0;
		if (uint_ == uint.MaxValue) {
			return;
		}
		SnoQuest? quest = SnoData.Quests.GetQuest(uint_);
		if (quest == null) {
			return;
		}
		try {
			Quest? quest3 = questsByKey.GetValueOrDefault(uint_);
			if (quest3 == null) {
				quest3 = new Quest(quest);
				questsByKey[uint_] = quest3;
			}
			quest3.CreatedOn = quest2.createdOn;
			quest3.QuestStepId = quest2.questStepId;
			quest3.QuestStep = quest.GetStep(quest2.questStepId);
			quest3.State = (QuestState)quest2.int_1;
			quest3.Progress = quest2.progress;
			quest3.Counter = quest2.counter;
			switch (quest3.State) {
				case QuestState.none:
					quest3.CompletedOn.Reset();
					quest3.StartedOn.Reset();
					break;
				case QuestState.started:
					quest3.CompletedOn.Reset();
					quest3.StartedOn.Start();
					break;
				case QuestState.completed:
					quest3.CompletedOn.Start();
					break;
			}
			Quests[uint_] = quest3;
			if (quest.Type == QuestType.Bounty) {
				Bounties[uint_] = quest3;
			}
		} catch (Exception) {
		}
	}

}
