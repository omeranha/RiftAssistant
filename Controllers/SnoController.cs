using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;


public class SnoController
{
	[CompilerGenerated]
	private readonly SnoPowerList SnoPowerList_0 = new SnoPowerList();

	[CompilerGenerated]
	private readonly SnoQuestList isnoQuestList_0 = new SnoQuestList();

	[CompilerGenerated]
	private readonly SnoItemList isnoItemList_0 = new SnoItemList();

	public AttributeList Attributes => new AttributeList();

	public SnoPowerList SnoPowers
	{
		[CompilerGenerated]
		get
		{
			return SnoPowerList_0;
		}
	}

	public IEnumerable<SnoPower> AllSnoPower => SnoData.Powers.All;

	public SnoQuestList SnoQuests
	{
		[CompilerGenerated]
		get
		{
			return isnoQuestList_0;
		}
	}

	public IEnumerable<SnoQuest> AllSnoQuest => SnoData.Quests.All;

	public SnoItemList SnoItems
	{
		[CompilerGenerated]
		get
		{
			return isnoItemList_0;
		}
	}

	public SnoPower GetSnoPower(uint sno)
	{
		return SnoData.Powers.GetBySno(sno);
	}

	public SnoQuest GetSnoQuest(uint sno)
	{
		return SnoData.Quests.GetQuest(sno);
	}

	public long TotalParagonExperienceRequired(uint paragonLevel)
	{
		return SnoData.Experience.ParagonTableTotal[paragonLevel];
	}
}
