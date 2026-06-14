using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;
using work;

internal class SnoController : ISnoController
{
	[CompilerGenerated]
	private readonly ISnoPowerList isnoPowerList_0 = new SnoPowerList();

	[CompilerGenerated]
	private readonly ISnoQuestList isnoQuestList_0 = new SnoQuestList();

	[CompilerGenerated]
	private readonly ISnoItemList isnoItemList_0 = new SnoItemList();

	public IAttributeList Attributes => new AttributeList();

	public ISnoPowerList SnoPowers
	{
		[CompilerGenerated]
		get
		{
			return isnoPowerList_0;
		}
	}

	public IEnumerable<ISnoPower> AllSnoPower => SnoData.Powers.All;

	public ISnoQuestList SnoQuests
	{
		[CompilerGenerated]
		get
		{
			return isnoQuestList_0;
		}
	}

	public IEnumerable<ISnoQuest> AllSnoQuest => SnoData.Quests.All;

	public ISnoItemList SnoItems
	{
		[CompilerGenerated]
		get
		{
			return isnoItemList_0;
		}
	}

	public ISnoPower GetSnoPower(uint sno)
	{
		return SnoData.Powers.GetBySno(sno);
	}

	ISnoPower ISnoController.GetSnoPower(uint sno)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSnoPower
		return this.GetSnoPower(sno);
	}

	public ISnoQuest GetSnoQuest(uint sno)
	{
		return SnoData.Quests.GetQuest(sno);
	}

	ISnoQuest ISnoController.GetSnoQuest(uint sno)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetSnoQuest
		return this.GetSnoQuest(sno);
	}

	public long TotalParagonExperienceRequired(uint paragonLevel)
	{
		return SnoData.Experience.ParagonTableTotal[paragonLevel];
	}

	long ISnoController.TotalParagonExperienceRequired(uint paragonLevel)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TotalParagonExperienceRequired
		return this.TotalParagonExperienceRequired(paragonLevel);
	}
}
