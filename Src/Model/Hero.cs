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

	public Hero(uint uint_1, string string_2, string battleTag, uint uint_2, long long_1, bool hardcore, bool isMale, int season2, bool seasonal, ulong accountIdHi, ulong accountIdLo)
	{
		Id = uint_1;
		Name = string_2;
		BattleTag = battleTag;
		ClassDefinition = SnoData.Classes.GetHeroClassByInternalIndex(uint_2);
		CreatedDT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(long_1 / 1000).ToLocalTime();
		Hardcore = hardcore;
		IsMale = isMale;
		Season = season2;
		Seasonal = seasonal;
		AccountIdHi = accountIdHi;
		AccountIdLo = accountIdLo;
	}
}
