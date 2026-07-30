using System;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using SNO;


internal class QuestManager
{
	private readonly Allocator class351_0 = new Allocator(512, "rQuestAllocator");

	private r_Quest[] struct20_0;

	private readonly Class112<uint, Quest> class112_0 = new Class112<uint, Quest>();

	public readonly Class112<uint, Quest> class112_1 = new Class112<uint, Quest>();

	public readonly Class112<uint, Quest> class112_2 = new Class112<uint, Quest>();

	internal void method_0()
	{
		class112_1.Clear();
		class112_2.Clear();
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
		class112_1.Clear();
		class112_2.Clear();
		class112_0.Clear();
	}

	private void method_2(ref r_Quest struct20_1)
	{
		uint uint_ = struct20_1.uint_0;
		if (uint_ == uint.MaxValue) {
			return;
		}
		SnoQuest quest = SnoData.Quests.GetQuest(uint_);
		if (quest == null) {
			return;
		}
		try {
			Quest @class = class112_0[uint_];
			if (@class == null) {
				@class = new Quest(quest);
				class112_0.Set(uint_, @class);
			}
			@class.CreatedOn = struct20_1.int_0;
			@class.QuestStepId = struct20_1.uint_4;
			@class.QuestStep = quest.GetStep(struct20_1.uint_4);
			@class.State = (QuestState)struct20_1.int_1;
			@class.Progress = struct20_1.float_0;
			@class.Counter = struct20_1.int_2;
			switch (@class.State) {
				case QuestState.none:
					@class.CompletedOn.Reset();
					@class.StartedOn.Reset();
					break;
				case QuestState.started:
					@class.CompletedOn.Reset();
					@class.StartedOn.Start();
					break;
				case QuestState.completed:
					@class.CompletedOn.Start();
					break;
			}
			class112_1.Set(uint_, @class);
			if (quest.Type == QuestType.Bounty) {
				class112_2.Set(uint_, @class);
			}
		} catch (Exception) {
		}
	}

	public uint method_3(QuestState questState_0, uint uint_0)
	{
		Quest quest = class112_1[uint_0];
		if (quest?.QuestStep != null && quest.State == questState_0) {
			return quest.QuestStepId;
		}
		return uint.MaxValue;
	}
}
