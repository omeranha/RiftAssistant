using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace RiftAssistant.Collectors;

internal class HeroCollector
{
	[CompilerGenerated]
	private EventHandler onHeroesCollected;

	[CompilerGenerated]
	private Hero ihero_0;

	public const int season_number_dontuse = -1;

	[CompilerGenerated]
	private int int_1;

	private readonly r_Hero[] buffer = new r_Hero[1];

	private readonly Dictionary<uint, Hero> heroList = new Dictionary<uint, Hero>();

	public EventHandler OnHeroesCollected
	{
		[CompilerGenerated]
		get
		{
			return onHeroesCollected;
		}
		[CompilerGenerated]
		set
		{
			onHeroesCollected = value;
		}
	}

	public Hero IHero_0
	{
		[CompilerGenerated]
		get
		{
			return ihero_0;
		}
		[CompilerGenerated]
		private set
		{
			ihero_0 = value;
		}
	}

	internal int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	public IEnumerable<Hero> HeroList => heroList.Values;

	public Hero GetHero(uint heroId2)
	{
		heroList.TryGetValue(heroId2, out var value);
		return value;
	}

	internal void Collect()
	{
		long int64_ = CoreCollector.DAF.BattleNetClientAddress;
		long num = GameWindowManager.Read<long>(int64_ + 312);
		long num2 = GameWindowManager.Read<long>(int64_ + 320);
		long long_ = GameWindowManager.Read<long>(int64_ + 336) + 136;
		uint num3 = GameWindowManager.Read<uint>(num2 + 200);
		if (num3 == 0)
		{
			heroList.Clear();
			Int32_0 = 0;
			IHero_0 = null;
			return;
		}
		int num4 = GameWindowManager.Read<int>(num + 104);
		long num5 = GameWindowManager.Read<long>(num + 96);
		int num6 = GameWindowManager.Read<int>(num + 88);
		Int32_0 = GameWindowManager.Read<int>(long_);
		if (num4 > 0)
		{
			for (int i = 0; i < num6; i++)
			{
				long num7 = GameWindowManager.Read<long>(num5 + i * 8);
				int num8 = 0;
				while (num7 != 0L && num8 < 1000)
				{
					num8++;
					buffer[0] = GameWindowManager.Read<r_Hero>(num7);
					ReadHero(ref buffer[0]);
					num7 = buffer[0].long_0;
				}
			}
		}
		else
		{
			heroList.Clear();
		}
		try
		{
			OnHeroesCollected?.Invoke(this, EventArgs.Empty);
		}
		catch (Exception exception_)
		{
			Logger.LogException(exception_.ToString());
		}
		heroList.TryGetValue(num3, out var value);
		IHero_0 = value;
	}

	internal void ClearHeroes()
	{
		heroList.Clear();
	}

	private void ReadHero(ref r_Hero hero2)
	{
		uint uint_ = hero2.uint_0;
		if (uint_ == uint.MaxValue)
		{
			return;
		}
		try
		{
			Hero hero = GetHero(uint_) as Hero;
			if (hero == null)
			{
				string text = GameWindowManager.ReadString(hero2.long_3, 64, Encoding.UTF8, true);
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				string string_ = GameWindowManager.ReadString(hero2.long_2, 64, Encoding.UTF8, true);
				bool bool_ = (hero2.int_3 & 1) == 1;
				bool bool_2 = (hero2.int_3 & 2) == 0;
				bool bool_3 = hero2.season > 0 && hero2.season == Constants.CurrentSeasonNumber;
				hero = new Hero(uint_, text, string_, hero2.uint_1, hero2.long_4, bool_, bool_2, hero2.season, bool_3, hero2.ulong_1, hero2.ulong_2);
				heroList.Add(uint_, hero);
			}
			hero.PlayedSeconds = hero2.int_4;
			hero.Flags = hero2.int_3;
			hero.Level = hero2.int_0;
			hero.ParagonLevel = hero2.int_1;
			if (hero.LastPlayed != hero2.long_5)
			{
				hero.LastPlayed = hero2.long_5;
				hero.LastPlayedDT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(hero2.long_5 / 1000).ToLocalTime();
			}
			hero.QuestStep = SnoData.Quests.GetQuest(hero2.uint_2)?.GetStep(hero2.uint_3);
		}
		catch (Exception)
		{
		}
	}

}
