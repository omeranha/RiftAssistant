using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Tracking;

public class StatTracker
{
	[CompilerGenerated]
	private readonly string id;

	[CompilerGenerated]
	private string title;

	[CompilerGenerated]
	private SnoArea isnoArea_0;

	[CompilerGenerated]
	private bool alwaysRunning;

	[CompilerGenerated]
	private double gainedExperience;

	[CompilerGenerated]
	private long gainedGold;

	[CompilerGenerated]
	private long monsterKill;

	[CompilerGenerated]
	private long eliteKill;

	[CompilerGenerated]
	private long dropAll;

	[CompilerGenerated]
	private long dropWhite;

	[CompilerGenerated]
	private long dropMagic;

	[CompilerGenerated]
	private long dropRare;

	[CompilerGenerated]
	private long dropLegendary;

	[CompilerGenerated]
	private long dropAncient;

	[CompilerGenerated]
	private long dropPrimalAncient;

	[CompilerGenerated]
	private long dropGold;

	[CompilerGenerated]
	private long dropBloodShard;

	[CompilerGenerated]
	private long death;

	[CompilerGenerated]
	private double damageDealtAll;

	[CompilerGenerated]
	private double damageDealtCrit;

	[CompilerGenerated]
	private double damageTaken;

	[CompilerGenerated]
	private double healing;

	[CompilerGenerated]
	private double walkYards;

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
			return id;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return title;
		}
		[CompilerGenerated]
		set
		{
			title = value;
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
			return alwaysRunning;
		}
		[CompilerGenerated]
		set
		{
			alwaysRunning = value;
		}
	}

	public double GainedExperience
	{
		[CompilerGenerated]
		get
		{
			return gainedExperience;
		}
		[CompilerGenerated]
		set
		{
			gainedExperience = value;
		}
	}

	public long GainedGold
	{
		[CompilerGenerated]
		get
		{
			return gainedGold;
		}
		[CompilerGenerated]
		set
		{
			gainedGold = value;
		}
	}

	public long MonsterKill
	{
		[CompilerGenerated]
		get
		{
			return monsterKill;
		}
		[CompilerGenerated]
		set
		{
			monsterKill = value;
		}
	}

	public long EliteKill
	{
		[CompilerGenerated]
		get
		{
			return eliteKill;
		}
		[CompilerGenerated]
		set
		{
			eliteKill = value;
		}
	}

	public long DropAll
	{
		[CompilerGenerated]
		get
		{
			return dropAll;
		}
		[CompilerGenerated]
		set
		{
			dropAll = value;
		}
	}

	public long DropWhite
	{
		[CompilerGenerated]
		get
		{
			return dropWhite;
		}
		[CompilerGenerated]
		set
		{
			dropWhite = value;
		}
	}

	public long DropMagic
	{
		[CompilerGenerated]
		get
		{
			return dropMagic;
		}
		[CompilerGenerated]
		set
		{
			dropMagic = value;
		}
	}

	public long DropRare
	{
		[CompilerGenerated]
		get
		{
			return dropRare;
		}
		[CompilerGenerated]
		set
		{
			dropRare = value;
		}
	}

	public long DropLegendary
	{
		[CompilerGenerated]
		get
		{
			return dropLegendary;
		}
		[CompilerGenerated]
		set
		{
			dropLegendary = value;
		}
	}

	public long DropAncient
	{
		[CompilerGenerated]
		get
		{
			return dropAncient;
		}
		[CompilerGenerated]
		set
		{
			dropAncient = value;
		}
	}

	public long DropPrimalAncient
	{
		[CompilerGenerated]
		get
		{
			return dropPrimalAncient;
		}
		[CompilerGenerated]
		set
		{
			dropPrimalAncient = value;
		}
	}

	public long DropGold
	{
		[CompilerGenerated]
		get
		{
			return dropGold;
		}
		[CompilerGenerated]
		set
		{
			dropGold = value;
		}
	}

	public long DropBloodShard
	{
		[CompilerGenerated]
		get
		{
			return dropBloodShard;
		}
		[CompilerGenerated]
		set
		{
			dropBloodShard = value;
		}
	}

	public long Death
	{
		[CompilerGenerated]
		get
		{
			return death;
		}
		[CompilerGenerated]
		set
		{
			death = value;
		}
	}

	public double DamageDealtAll
	{
		[CompilerGenerated]
		get
		{
			return damageDealtAll;
		}
		[CompilerGenerated]
		set
		{
			damageDealtAll = value;
		}
	}

	public double DamageDealtCrit
	{
		[CompilerGenerated]
		get
		{
			return damageDealtCrit;
		}
		[CompilerGenerated]
		set
		{
			damageDealtCrit = value;
		}
	}

	public double DamageTaken
	{
		[CompilerGenerated]
		get
		{
			return damageTaken;
		}
		[CompilerGenerated]
		set
		{
			damageTaken = value;
		}
	}

	public double Healing
	{
		[CompilerGenerated]
		get
		{
			return healing;
		}
		[CompilerGenerated]
		set
		{
			healing = value;
		}
	}

	public double WalkYards
	{
		[CompilerGenerated]
		get
		{
			return walkYards;
		}
		[CompilerGenerated]
		set
		{
			walkYards = value;
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

	public StatTracker(string battleTag, bool bool_1, string string_4, string string_5)
	{
		id = battleTag;
		string_2 = string_5;
		Title = string_4;
		if (bool_1)
		{
			StartIfStopped();
		}
		if (string_2 != null)
		{
			string text = Path.Combine(Program.AppDir, "stat_tracker");
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, battleTag + "_" + string_2 + ".xml");
			if (File.Exists(text2))
			{
				LoadFromFile(text2);
			}
		}
	}

	public StatTracker(string battleTag, bool bool_1, string string_4, List<string> list_0)
	{
		id = battleTag;
		Title = string_4;
		string_2 = null;
		if (bool_1)
		{
			StartIfStopped();
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			string text = Path.Combine(Program.AppDir, "stat_tracker");
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, battleTag + "_" + list_0[i] + ".xml");
			if (File.Exists(text2))
			{
				LoadFromFile(text2);
			}
		}
	}

	public void Reset()
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

	private void LoadFromFile(string string_3)
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

	public void Save()
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

	public string FormatTownTime(ValueFormat valueFormat = ValueFormat.LongTime)
	{
		long townElapsedMilliseconds = TownElapsedMilliseconds;
		if (townElapsedMilliseconds < 1000)
		{
			townElapsedMilliseconds = 0L;
		}
		return Formatting.ValueToString(townElapsedMilliseconds * 10000, valueFormat);
	}

	public string FormatPlayTime(ValueFormat valueFormat = ValueFormat.LongTime)
	{
		long playElapsedMilliseconds = PlayElapsedMilliseconds;
		if (playElapsedMilliseconds < 1000)
		{
			playElapsedMilliseconds = 0L;
		}
		return Formatting.ValueToString(playElapsedMilliseconds * 10000, valueFormat);
	}

	internal void StartIfStopped()
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

	internal void UpdateTownState(bool isInTown)
	{
		if (AlwaysRunning)
		{
			return;
		}
		if (isInTown)
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
