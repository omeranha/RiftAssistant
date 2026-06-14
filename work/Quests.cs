using SNO;
using System;
using System.Collections.Generic;
using System.Globalization;
using Plugins;

namespace work;

public sealed class Quests
{
	private readonly Dictionary<uint, ISnoQuest> dictionary_0 = new Dictionary<uint, ISnoQuest>(500);

	public IEnumerable<ISnoQuest> All => dictionary_0.Values;

	public ISnoQuest GetQuest(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	internal Quests()
	{
		Type typeFromHandle = typeof(StringListSnoEnum);
		string[] array = SnoResourceHelper.GetQuests().Split('\n');
		int num = 0;
		while (num < array.Length)
		{
			string text = array[num];
			num++;
			if (text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) || string.IsNullOrEmpty(text))
			{
				continue;
			}
			if (text.EndsWith("\r"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			string[] array2 = text.Split('\t');
			string string_ = array2[0];
			uint num2 = uint.Parse(array2[1], CultureInfo.InvariantCulture);
			uint num3 = uint.Parse(array2[2], CultureInfo.InvariantCulture);
			if (!Enum.IsDefined(typeFromHandle, num3))
			{
				continue;
			}
			StringListSnoEnum snoEnum = (StringListSnoEnum)num3;
			int num4 = int.Parse(array2[3], CultureInfo.InvariantCulture);
			string stringByCode = SnoData.Strings.GetStringByCode(snoEnum, "Name");
			string stringByCode2 = SnoData.Strings.GetStringByCode(snoEnum, "Description");
			string stringByCode3 = SnoData.Strings.GetStringByCode(snoEnum, "UnassignedStepBNetTitle");
			string stringByCodeEnglish = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "Name");
			string stringByCodeEnglish2 = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "Description");
			string stringByCodeEnglish3 = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "UnassignedStepBNetTitle");
			QuestType questType = (QuestType)Enum.Parse(typeof(QuestType), array2[5], ignoreCase: true);
			QuestEventType questEventType_ = (QuestEventType)Enum.Parse(typeof(QuestEventType), array2[6], ignoreCase: true);
			int num5 = int.Parse(array2[7]);
			int int_ = int.Parse(array2[8]);
			BountyAct bountyAct_ = BountyAct.None;
			BountyType bountyType_ = BountyType.None;
			ISnoArea isnoArea_ = null;
			if (questType == QuestType.Bounty)
			{
				array2 = array[num].Split('\t');
				num++;
				bountyAct_ = (BountyAct)Enum.Parse(typeof(BountyAct), array2[0], ignoreCase: true);
				bountyType_ = (BountyType)Enum.Parse(typeof(BountyType), array2[1], ignoreCase: true);
				isnoArea_ = SnoData.Areas.GetSnoArea(uint.Parse(array2[2], CultureInfo.InvariantCulture));
				num++;
			}
			ISnoAct snoAct = ((num4 > 0) ? SnoData.Areas.AllActs[num4 - 1] : null);
			SnoQuest snoQuest = new SnoQuest(string_, num2, snoAct, stringByCode, stringByCodeEnglish, stringByCode2, stringByCodeEnglish2, questType, questEventType_, int_, stringByCode3, stringByCodeEnglish3, bountyAct_, bountyType_, isnoArea_);
			if (snoAct != null)
			{
				if (snoQuest.Type == QuestType.MainQuest)
				{
					snoAct.MainQuests.Add(snoQuest);
				}
				else if (snoQuest.Type == QuestType.Bounty)
				{
					snoAct.Bounties.Add(snoQuest);
				}
			}
			for (int i = 0; i < num5; i++)
			{
				text = array[num];
				num++;
				if (!text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text))
				{
					array2 = text.Split('\t');
					uint uint_ = uint.Parse(array2[1]);
					string stringByCode4 = SnoData.Strings.GetStringByCode(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "Splash");
					string stringByCodeEnglish4 = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "Splash");
					string stringByCode5 = SnoData.Strings.GetStringByCode(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "BNetTitle");
					string stringByCodeEnglish5 = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "BNetTitle");
					string stringByCode6 = SnoData.Strings.GetStringByCode(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "BNetText");
					string stringByCodeEnglish6 = SnoData.Strings.GetStringByCodeEnglish(snoEnum, "Step" + uint_.ToString("D", CultureInfo.InvariantCulture) + "BNetText");
					snoQuest.method_0(new SnoQuestStep(snoQuest, uint_, stringByCode4, stringByCodeEnglish4, stringByCode5, stringByCodeEnglish5, stringByCode6, stringByCodeEnglish6));
				}
			}
			dictionary_0.Add(num2, snoQuest);
		}
	}
}
