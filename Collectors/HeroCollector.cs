using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using structs;
using Plugins;
using SNO;
using work;

namespace collectors;

internal class HeroCollector
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private Hero ihero_0;

	public const int season_number_dontuse = -1;

	[CompilerGenerated]
	private int int_1;

	private readonly r_Hero[] buffer = new r_Hero[1];

	private readonly Dictionary<uint, Hero> dictionary_0 = new Dictionary<uint, Hero>();

	public EventHandler OnHeroesCollected
	{
		[CompilerGenerated]
		get
		{
			return eventHandler_0;
		}
		[CompilerGenerated]
		set
		{
			eventHandler_0 = value;
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

	public IEnumerable<Hero> HeroList => dictionary_0.Values;

	public Hero method_0(uint uint_0)
	{
		dictionary_0.TryGetValue(uint_0, out var value);
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
			dictionary_0.Clear();
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
					method_3(ref buffer[0]);
					num7 = buffer[0].long_0;
				}
			}
		}
		else
		{
			dictionary_0.Clear();
		}
		try
		{
			OnHeroesCollected?.Invoke(this, EventArgs.Empty);
		}
		catch (Exception exception_)
		{
			Logger.LogException(exception_.Message);
		}
		dictionary_0.TryGetValue(num3, out var value);
		IHero_0 = value;
	}

	internal void method_2()
	{
		dictionary_0.Clear();
	}

	private void method_3(ref r_Hero struct14_1)
	{
		uint uint_ = struct14_1.uint_0;
		if (uint_ == uint.MaxValue)
		{
			return;
		}
		try
		{
			Hero hero = method_0(uint_) as Hero;
			if (hero == null)
			{
				string text = GameWindowManager.ReadString(struct14_1.long_3, 64, Encoding.UTF8, true);
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				string string_ = GameWindowManager.ReadString(struct14_1.long_2, 64, Encoding.UTF8, true);
				bool bool_ = (struct14_1.int_3 & 1) == 1;
				bool bool_2 = (struct14_1.int_3 & 2) == 0;
				bool bool_3 = struct14_1.season > 0 && struct14_1.season == Constants.CurrentSeasonNumber;
				hero = new Hero(uint_, text, string_, struct14_1.uint_1, struct14_1.long_4, bool_, bool_2, struct14_1.season, bool_3, struct14_1.ulong_1, struct14_1.ulong_2);
				dictionary_0.Add(uint_, hero);
			}
			hero.PlayedSeconds = struct14_1.int_4;
			hero.Flags = struct14_1.int_3;
			hero.Level = struct14_1.int_0;
			hero.ParagonLevel = struct14_1.int_1;
			if (hero.LastPlayed != struct14_1.long_5)
			{
				hero.LastPlayed = struct14_1.long_5;
				hero.LastPlayedDT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(struct14_1.long_5 / 1000).ToLocalTime();
			}
			hero.QuestStep = SnoData.Quests.GetQuest(struct14_1.uint_2)?.GetStep(struct14_1.uint_3);
		}
		catch (Exception)
		{
		}
	}

	public Hero method_4()
	{
		Player localPlayer = CoreCollector.LocalPlayer;
		object obj;
		if (localPlayer == null)
		{
			obj = null;
		}
		else
		{
			obj = localPlayer.Hero;
			if (obj != null)
			{
				goto IL_0053;
			}
		}
		obj = IHero_0 ?? dictionary_0.Values.OrderByDescending((Hero ihero_0) => ihero_0.LastPlayed).FirstOrDefault();
		goto IL_0053;
		IL_0053:
		return (Hero)obj;
	}
}
