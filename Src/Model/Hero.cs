using System;

namespace RiftAssistant.Model;

public class Hero
{

	public uint Id { get; }

	public string Name { get; }

	public string BattleTag { get; }

	public HeroClassDefinition ClassDefinition { get; }

	public ulong AccountIdHi { get; }

	public ulong AccountIdLo { get; }

	public int Flags { get; set; }

	public int Level { get; set; }

	public int ParagonLevel { get; set; }

	public int PlayedSeconds { get; set; }

	public bool Hardcore { get; }

	public bool IsMale { get; }

	public int Season { get; }

	public bool Seasonal { get; }

	public DateTime CreatedDT { get; }

	public long LastPlayed { get; set; }

	public DateTime LastPlayedDT { get; set; } = DateTime.MinValue;

	public SnoQuestStep QuestStep { get; set; }

	public Hero(uint uint_1, string string_2, string string_3, uint uint_2, long long_1, bool bool_3, bool bool_4, int season2, bool bool_5, ulong ulong_2, ulong ulong_3)
	{
		Id = uint_1;
		Name = string_2;
		BattleTag = string_3;
		ClassDefinition = SnoData.Classes.GetHeroClassByInternalIndex(uint_2);
		CreatedDT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(long_1 / 1000).ToLocalTime();
		Hardcore = bool_3;
		IsMale = bool_4;
		Season = season2;
		Seasonal = bool_5;
		AccountIdHi = ulong_2;
		AccountIdLo = ulong_3;
	}
}
