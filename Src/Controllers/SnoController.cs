using System.Collections.Generic;

namespace RiftAssistant.Controllers;

public class SnoController
{

	public AttributeList Attributes => new AttributeList();

	public SnoPowerList SnoPowers { get; } = new SnoPowerList();

	public IEnumerable<SnoPower> AllSnoPower => SnoData.Powers.All;

	public SnoQuestList SnoQuests { get; } = new SnoQuestList();

	public IEnumerable<SnoQuest> AllSnoQuest => SnoData.Quests.All;

	public SnoItemList SnoItems { get; } = new SnoItemList();

	public SnoPower? GetSnoPower(uint sno)
	{
		return SnoData.Powers.GetBySno(sno);
	}

	public SnoQuest? GetSnoQuest(uint sno)
	{
		return SnoData.Quests.GetQuest(sno);
	}

	public long TotalParagonExperienceRequired(uint paragonLevel)
	{
		return SnoData.Experience.ParagonTableTotal[paragonLevel];
	}
}
