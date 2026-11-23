using System;
using System.Collections.Generic;
using SNO;
using structs;


internal class QuestManager
{
	private readonly Allocator class351_0 = new Allocator(512, "rQuestAllocator");

	private r_Quest[] struct20_0;

	private readonly Dictionary<uint, Quest> class112_0 = new Dictionary<uint, Quest>();

	public readonly Dictionary<uint, Quest> Quests = new Dictionary<uint, Quest>();

	public readonly Dictionary<uint, Quest> Bounties = new Dictionary<uint, Quest>();

	internal void method_0()
	{
		Quests.Clear();
		Bounties.Clear();
		class351_0.Snapshot(CoreCollector.D3Memory.QuestManagerAddress);
		int totalElementCount = class351_0.GetTotalElementCount();
		if (totalElementCount <= 0) {
			return;
		}
		if (struct20_0 == null || struct20_0.Length != totalElementCount) {
			struct20_0 = new r_Quest[totalElementCount];
		}
		int num = 0;
		for (int i = 0; i < class351_0.RawBlocks.Count; i++) {
			r_Block r_Block2 = class351_0.RawBlocks[i];
			if (r_Block2.ElementCount > 0) {
				GameWindowManager.ReadIntoArray(r_Block2.ArrayStart, struct20_0, num, r_Block2.ElementCount);
			}
			num += r_Block2.ElementCount;
		}
		for (int j = 0; j < totalElementCount; j++) {
			method_2(ref struct20_0[j]);
		}
	}

	internal void method_1()
	{
		Quests.Clear();
		Bounties.Clear();
		class112_0.Clear();
	}

	private void method_2(ref r_Quest quest2)
	{
		uint uint_ = quest2.uint_0;
		if (uint_ == uint.MaxValue) {
			return;
		}
		SnoQuest quest = SnoData.Quests.GetQuest(uint_);
		if (quest == null) {
			return;
		}
		try {
			Quest quest3 = class112_0.GetValueOrDefault(uint_);
			if (quest3 == null) {
				quest3 = new Quest(quest);
				class112_0[uint_] = quest3;
			}
			quest3.CreatedOn = quest2.int_0;
			quest3.QuestStepId = quest2.uint_4;
			quest3.QuestStep = quest.GetStep(quest2.uint_4);
			quest3.State = (QuestState)quest2.int_1;
			quest3.Progress = quest2.float_0;
			quest3.Counter = quest2.int_2;
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

	public uint method_3(QuestState questState, uint uint_0)
	{
		Quest quest = Quests.GetValueOrDefault(uint_0);
		if (quest?.QuestStep != null && quest.State == questState) {
			return quest.QuestStepId;
		}
		return uint.MaxValue;
	}
}
