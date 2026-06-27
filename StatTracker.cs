using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using work;
using Plugins;
using SNO;
using System.Diagnostics;

public class StatTracker
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private SnoArea isnoArea_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private double double_0;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private long long_2;

	[CompilerGenerated]
	private long long_3;

	[CompilerGenerated]
	private long long_4;

	[CompilerGenerated]
	private long long_5;

	[CompilerGenerated]
	private long long_6;

	[CompilerGenerated]
	private long long_7;

	[CompilerGenerated]
	private long long_8;

	[CompilerGenerated]
	private long long_9;

	[CompilerGenerated]
	private long long_10;

	[CompilerGenerated]
	private long long_11;

	[CompilerGenerated]
	private long long_12;

	[CompilerGenerated]
	private double double_1;

	[CompilerGenerated]
	private double double_2;

	[CompilerGenerated]
	private double double_3;

	[CompilerGenerated]
	private double double_4;

	[CompilerGenerated]
	private double double_5;

	private readonly string string_2;

	private readonly Stopwatch stopwatch_0 = new Stopwatch();

	private readonly Stopwatch stopwatch_1 = new Stopwatch();

	private long long_13;

	private long long_14;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public SnoArea SnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
		[CompilerGenerated]
		set
		{
			isnoArea_0 = value;
		}
	}

	public bool AlwaysRunning
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public double GainedExperience
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
		[CompilerGenerated]
		set
		{
			double_0 = value;
		}
	}

	public long GainedGold
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

	public long MonsterKill
	{
		[CompilerGenerated]
		get
		{
			return long_1;
		}
		[CompilerGenerated]
		set
		{
			long_1 = value;
		}
	}

	public long EliteKill
	{
		[CompilerGenerated]
		get
		{
			return long_2;
		}
		[CompilerGenerated]
		set
		{
			long_2 = value;
		}
	}

	public long DropAll
	{
		[CompilerGenerated]
		get
		{
			return long_3;
		}
		[CompilerGenerated]
		set
		{
			long_3 = value;
		}
	}

	public long DropWhite
	{
		[CompilerGenerated]
		get
		{
			return long_4;
		}
		[CompilerGenerated]
		set
		{
			long_4 = value;
		}
	}

	public long DropMagic
	{
		[CompilerGenerated]
		get
		{
			return long_5;
		}
		[CompilerGenerated]
		set
		{
			long_5 = value;
		}
	}

	public long DropRare
	{
		[CompilerGenerated]
		get
		{
			return long_6;
		}
		[CompilerGenerated]
		set
		{
			long_6 = value;
		}
	}

	public long DropLegendary
	{
		[CompilerGenerated]
		get
		{
			return long_7;
		}
		[CompilerGenerated]
		set
		{
			long_7 = value;
		}
	}

	public long DropAncient
	{
		[CompilerGenerated]
		get
		{
			return long_8;
		}
		[CompilerGenerated]
		set
		{
			long_8 = value;
		}
	}

	public long DropPrimalAncient
	{
		[CompilerGenerated]
		get
		{
			return long_9;
		}
		[CompilerGenerated]
		set
		{
			long_9 = value;
		}
	}

	public long DropGold
	{
		[CompilerGenerated]
		get
		{
			return long_10;
		}
		[CompilerGenerated]
		set
		{
			long_10 = value;
		}
	}

	public long DropBloodShard
	{
		[CompilerGenerated]
		get
		{
			return long_11;
		}
		[CompilerGenerated]
		set
		{
			long_11 = value;
		}
	}

	public long Death
	{
		[CompilerGenerated]
		get
		{
			return long_12;
		}
		[CompilerGenerated]
		set
		{
			long_12 = value;
		}
	}

	public double DamageDealtAll
	{
		[CompilerGenerated]
		get
		{
			return double_1;
		}
		[CompilerGenerated]
		set
		{
			double_1 = value;
		}
	}

	public double DamageDealtCrit
	{
		[CompilerGenerated]
		get
		{
			return double_2;
		}
		[CompilerGenerated]
		set
		{
			double_2 = value;
		}
	}

	public double DamageTaken
	{
		[CompilerGenerated]
		get
		{
			return double_3;
		}
		[CompilerGenerated]
		set
		{
			double_3 = value;
		}
	}

	public double Healing
	{
		[CompilerGenerated]
		get
		{
			return double_4;
		}
		[CompilerGenerated]
		set
		{
			double_4 = value;
		}
	}

	public double WalkYards
	{
		[CompilerGenerated]
		get
		{
			return double_5;
		}
		[CompilerGenerated]
		set
		{
			double_5 = value;
		}
	}

	public bool IsMainTimerRunning => stopwatch_0.IsRunning;

	public bool IsTownTimerRunning => stopwatch_1.IsRunning;

	public long ElapsedMilliseconds => stopwatch_0.ElapsedMilliseconds + long_13;

	public long TownElapsedMilliseconds => stopwatch_1.ElapsedMilliseconds + long_14;

	public long PlayElapsedMilliseconds => ElapsedMilliseconds - TownElapsedMilliseconds;

	public double GainedExperiencePerHourFull
	{
		get
		{
			if (ElapsedMilliseconds > 1)
			{
				return GainedExperience / (double)ElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double GainedExperiencePerHourPlay
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return GainedExperience / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double MonsterKillPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)MonsterKill / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double EliteKillPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)EliteKill / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropAllPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropAll / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropWhitePerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropWhite / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropMagicPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropMagic / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropRarePerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropRare / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropLegendaryPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropLegendary / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropAncientPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropAncient / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropPrimalAncientPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropPrimalAncient / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double GainedGoldPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)GainedGold / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropGoldPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropGold / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DropBloodShardPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)DropBloodShard / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DeathPerHour
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return (double)Death / (double)PlayElapsedMilliseconds * 1000.0 * 60.0 * 60.0;
			}
			return 0.0;
		}
	}

	public double DamageDealtAllPerSecond
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return DamageDealtAll / (double)PlayElapsedMilliseconds * 1000.0;
			}
			return 0.0;
		}
	}

	public double DamageDealtCritPerSecond
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return DamageDealtCrit / (double)PlayElapsedMilliseconds * 1000.0;
			}
			return 0.0;
		}
	}

	public double DamageTakenPerSecond
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return DamageTaken / (double)PlayElapsedMilliseconds * 1000.0;
			}
			return 0.0;
		}
	}

	public double HealingPerSecond
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return Healing / (double)PlayElapsedMilliseconds * 1000.0;
			}
			return 0.0;
		}
	}

	public double Double_0
	{
		get
		{
			if (PlayElapsedMilliseconds > 1)
			{
				return WalkYards / (double)PlayElapsedMilliseconds * 1000.0;
			}
			return 0.0;
		}
	}

	public double MonsterKillPerLegendary
	{
		get
		{
			if (MonsterKill > 0 && DropLegendary > 0)
			{
				return (double)MonsterKill / (double)DropLegendary;
			}
			return 0.0;
		}
	}

	public double EliteKillPerLegendary
	{
		get
		{
			if (EliteKill > 0 && DropLegendary > 0)
			{
				return (double)EliteKill / (double)DropLegendary;
			}
			return 0.0;
		}
	}

	public StatTracker(string string_3, bool bool_1, string string_4, string string_5)
	{
		string_0 = string_3;
		string_2 = string_5;
		Title = string_4;
		if (bool_1)
		{
			method_28();
		}
		if (string_2 != null)
		{
			string text = Path.Combine(Program.AppDir, "stat_tracker");
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, string_3 + "_" + string_2 + ".xml");
			if (File.Exists(text2))
			{
				method_23(text2);
			}
		}
	}

	public StatTracker(string string_3, bool bool_1, string string_4, List<string> list_0)
	{
		string_0 = string_3;
		Title = string_4;
		string_2 = null;
		if (bool_1)
		{
			method_28();
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			string text = Path.Combine(Program.AppDir, "stat_tracker");
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, string_3 + "_" + list_0[i] + ".xml");
			if (File.Exists(text2))
			{
				method_23(text2);
			}
		}
	}

	public void method_22()
	{
		long_13 = 0L;
		long_14 = 0L;
		stopwatch_0.Reset();
		stopwatch_1.Reset();
		GainedExperience = 0.0;
		GainedGold = 0L;
		MonsterKill = 0L;
		EliteKill = 0L;
		DropAll = 0L;
		DropWhite = 0L;
		DropMagic = 0L;
		DropRare = 0L;
		DropLegendary = 0L;
		DropAncient = 0L;
		DropPrimalAncient = 0L;
		DropGold = 0L;
		DropBloodShard = 0L;
		Death = 0L;
		DamageDealtAll = 0.0;
		DamageDealtCrit = 0.0;
		DamageTaken = 0.0;
		Healing = 0.0;
	}

	private void method_23(string string_3)
	{
		/*
		try
		{
			Class96 @class = new Class96();
			@class.method_69(string_3);
			if (@class.method_39("area.sno") != 0)
			{
				SnoArea = SnoData.Areas.GetSnoArea(@class.method_39("area.sno"));
			}
			long_13 += @class.method_40("time.msec");
			long_14 += @class.method_40("time.msec_town");
			GainedExperience += @class.method_40("data.exp");
			GainedGold += @class.method_40("data.gold");
			MonsterKill += @class.method_40("data.kill_total");
			EliteKill += @class.method_40("data.kill_elite");
			DropAll += @class.method_40("data.drop_all");
			DropWhite += @class.method_40("data.drop_white");
			DropMagic += @class.method_40("data.drop_magic");
			DropRare += @class.method_40("data.drop_rare");
			DropLegendary += @class.method_40("data.drop_legendary");
			DropAncient += @class.method_40("data.drop_ancient");
			DropPrimalAncient += @class.method_40("data.drop_primal_ancient");
			DropGold += @class.method_40("data.drop_gold");
			DropBloodShard += @class.method_40("data.drop_blood_shard");
			Death += @class.method_40("data.death");
			DamageDealtAll += @class.method_40("data.damage_dealt_all");
			DamageDealtCrit += @class.method_40("data.damage_dealt_crit");
			DamageTaken += @class.method_40("data.damage_taken");
			Healing += @class.method_40("data.healing");
		}
		catch (Exception exception_)
		{
			Logger.LogException(exception_.Message);
		}
		*/
	}

	public void method_24()
	{
		if (string_2 != null)
		{
			/*
			string text = Path.Combine(Program.AppDir, "stat_tracker");
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, Id + "_" + string_2 + ".xml");
			Class96 @class = new Class96();
			if (SnoArea != null)
			{
				@class.method_24("area.sno", SnoArea.Sno);
			}
			@class.method_25("time.msec", long_13 + iwatch_0.ElapsedMilliseconds);
			@class.method_25("time.msec_town", long_14 + iwatch_1.ElapsedMilliseconds);
			@class.method_23("data.exp", GainedExperience);
			@class.method_25("data.gold", GainedGold);
			@class.method_25("data.kill_total", MonsterKill);
			@class.method_25("data.kill_elite", EliteKill);
			@class.method_25("data.drop_all", DropAll);
			@class.method_25("data.drop_white", DropWhite);
			@class.method_25("data.drop_magic", DropMagic);
			@class.method_25("data.drop_rare", DropRare);
			@class.method_25("data.drop_legendary", DropLegendary);
			@class.method_25("data.drop_ancient", DropAncient);
			@class.method_25("data.drop_primal_ancient", DropPrimalAncient);
			@class.method_25("data.drop_blood_shard", DropBloodShard);
			@class.method_25("data.drop_gold", DropGold);
			@class.method_25("data.death", Death);
			@class.method_23("data.damage_dealt_all", DamageDealtAll);
			@class.method_23("data.damage_dealt_crit", DamageDealtCrit);
			@class.method_23("data.damage_taken", DamageTaken);
			@class.method_23("data.healing", Healing);
			@class.method_63(text2);
			*/
		}
	}

	public string method_25(ValueFormat valueFormat_0 = ValueFormat.LongTime)
	{
		long num = ElapsedMilliseconds;
		if (num < 1000)
		{
			num = 0L;
		}
		return Formatting.VtoS(num * 10000, valueFormat_0);
	}

	public string method_26(ValueFormat valueFormat_0 = ValueFormat.LongTime)
	{
		long num = TownElapsedMilliseconds;
		if (num < 1000)
		{
			num = 0L;
		}
		return Formatting.VtoS(num * 10000, valueFormat_0);
	}

	public string method_27(ValueFormat valueFormat_0 = ValueFormat.LongTime)
	{
		long num = PlayElapsedMilliseconds;
		if (num < 1000)
		{
			num = 0L;
		}
		return Formatting.VtoS(num * 10000, valueFormat_0);
	}

	internal void method_28()
	{
		if (!stopwatch_0.IsRunning)
		{
			stopwatch_0.Start();
		}
	}

	internal void Stop()
	{
		if (!AlwaysRunning)
		{
			stopwatch_0.Stop();
			stopwatch_1.Stop();
		}
	}

	internal void method_30(bool bool_1)
	{
		if (AlwaysRunning)
		{
			return;
		}
		if (bool_1)
		{
			if (!stopwatch_1.IsRunning)
			{
				stopwatch_1.Start();
			}
		}
		else
		{
			stopwatch_1.Stop();
		}
	}
}
