using System.Collections.Generic;

namespace Plugins;

public interface ISnoController
{
	IAttributeList Attributes { get; }

	ISnoPowerList SnoPowers { get; }

	IEnumerable<ISnoPower> AllSnoPower { get; }

	ISnoQuestList SnoQuests { get; }

	IEnumerable<ISnoQuest> AllSnoQuest { get; }

	ISnoItemList SnoItems { get; }

	ISnoPower GetSnoPower(uint sno);

	ISnoQuest GetSnoQuest(uint sno);

	long TotalParagonExperienceRequired(uint paragonLevel);
}
