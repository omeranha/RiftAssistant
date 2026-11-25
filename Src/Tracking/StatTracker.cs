using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RiftAssistant.Tracking;

internal sealed class StatTracker : IStatTracker
{
	private const double MillisecondsPerSecond = 1000.0;
	private const double MillisecondsPerHour = 3_600_000.0;

	private readonly string persistenceKey;
	private readonly Stopwatch mainTimer = new();
	private readonly Stopwatch townTimer = new();
	private long loadedElapsedMilliseconds;
	private long loadedTownMilliseconds;

	public StatTracker(string id, bool startRunning, string title, string persistenceKey = null)
	{
		Id = id;
		Title = title;
		this.persistenceKey = persistenceKey;
		if (startRunning) StartIfStopped();
		if (persistenceKey != null) LoadFrom(persistenceKey);
	}

	public StatTracker(string id, bool startRunning, string title, IReadOnlyList<string> persistenceKeys)
	{
		Id = id;
		Title = title;
		if (startRunning) StartIfStopped();
		foreach (string key in persistenceKeys) {
			LoadFrom(key);
		}
	}

	public string Id { get; }

	public string Title { get; set; }

	public SnoArea SnoArea { get; set; }

	public bool AlwaysRunning { get; set; }

	public double GainedExperience { get; set; }

	public long GainedGold { get; set; }

	public long MonsterKill { get; set; }

	public long EliteKill { get; set; }

	public long DropAll { get; set; }

	public long DropWhite { get; set; }

	public long DropMagic { get; set; }

	public long DropRare { get; set; }

	public long DropLegendary { get; set; }

	public long DropAncient { get; set; }

	public long DropPrimalAncient { get; set; }

	public long DropGold { get; set; }

	public long DropBloodShard { get; set; }

	public long Death { get; set; }

	public double DamageDealtAll { get; set; }

	public double DamageDealtCrit { get; set; }

	public double DamageTaken { get; set; }

	public double Healing { get; set; }

	public double WalkYards { get; set; }

	public bool IsMainTimerRunning => mainTimer.IsRunning;

	public bool IsTownTimerRunning => townTimer.IsRunning;

	public long ElapsedMilliseconds => mainTimer.ElapsedMilliseconds + loadedElapsedMilliseconds;

	public long TownElapsedMilliseconds => townTimer.ElapsedMilliseconds + loadedTownMilliseconds;

	public long PlayElapsedMilliseconds => ElapsedMilliseconds - TownElapsedMilliseconds;

	public double GainedExperiencePerHourFull => ElapsedMilliseconds > 1 ? GainedExperience / ElapsedMilliseconds * MillisecondsPerHour : 0.0;

	public double GainedExperiencePerHourPlay => PerHour(GainedExperience);

	public double MonsterKillPerHour => PerHour(MonsterKill);

	public double EliteKillPerHour => PerHour(EliteKill);

	public double DropAllPerHour => PerHour(DropAll);

	public double DropWhitePerHour => PerHour(DropWhite);

	public double DropMagicPerHour => PerHour(DropMagic);

	public double DropRarePerHour => PerHour(DropRare);

	public double DropLegendaryPerHour => PerHour(DropLegendary);

	public double DropAncientPerHour => PerHour(DropAncient);

	public double DropPrimalAncientPerHour => PerHour(DropPrimalAncient);

	public double GainedGoldPerHour => PerHour(GainedGold);

	public double DropGoldPerHour => PerHour(DropGold);

	public double DropBloodShardPerHour => PerHour(DropBloodShard);

	public double DeathPerHour => PerHour(Death);

	public double DamageDealtAllPerSecond => PerSecond(DamageDealtAll);

	public double DamageDealtCritPerSecond => PerSecond(DamageDealtCrit);

	public double DamageTakenPerSecond => PerSecond(DamageTaken);

	public double HealingPerSecond => PerSecond(Healing);

	public double WalkYardsPerSecond => PerSecond(WalkYards);

	public double MonsterKillPerLegendary => MonsterKill > 0 && DropLegendary > 0 ? (double)MonsterKill / DropLegendary : 0.0;

	public double EliteKillPerLegendary => EliteKill > 0 && DropLegendary > 0 ? (double)EliteKill / DropLegendary : 0.0;

	public void Reset()
	{
		loadedElapsedMilliseconds = 0;
		loadedTownMilliseconds = 0;
		mainTimer.Reset();
		townTimer.Reset();
		GainedExperience = 0.0;
		GainedGold = 0;
		MonsterKill = 0;
		EliteKill = 0;
		DropAll = 0;
		DropWhite = 0;
		DropMagic = 0;
		DropRare = 0;
		DropLegendary = 0;
		DropAncient = 0;
		DropPrimalAncient = 0;
		DropGold = 0;
		DropBloodShard = 0;
		Death = 0;
		DamageDealtAll = 0.0;
		DamageDealtCrit = 0.0;
		DamageTaken = 0.0;
		Healing = 0.0;
		WalkYards = 0.0;
	}

	public void Save()
	{
		if (persistenceKey == null) return;

		StatTrackerStorage.Write(StatTrackerStorage.PathFor(Id, persistenceKey), ToSnapshot());
	}

	public string FormatTownTime(ValueFormat valueFormat = ValueFormat.LongTime) => FormatTime(TownElapsedMilliseconds, valueFormat);

	public string FormatPlayTime(ValueFormat valueFormat = ValueFormat.LongTime) => FormatTime(PlayElapsedMilliseconds, valueFormat);

	internal void StartIfStopped()
	{
		if (!mainTimer.IsRunning) mainTimer.Start();
	}

	internal void Stop()
	{
		if (AlwaysRunning) return;

		mainTimer.Stop();
		townTimer.Stop();
	}

	internal void UpdateTownState(bool isInTown)
	{
		if (AlwaysRunning) return;

		if (isInTown) {
			if (!townTimer.IsRunning) townTimer.Start();
		} else {
			townTimer.Stop();
		}
	}

	internal StatTrackerSnapshot ToSnapshot()
	{
		return new StatTrackerSnapshot {
			AreaSno = SnoArea?.Sno ?? 0,
			ElapsedMilliseconds = ElapsedMilliseconds,
			TownMilliseconds = TownElapsedMilliseconds,
			Experience = GainedExperience,
			Gold = GainedGold,
			MonsterKill = MonsterKill,
			EliteKill = EliteKill,
			DropAll = DropAll,
			DropWhite = DropWhite,
			DropMagic = DropMagic,
			DropRare = DropRare,
			DropLegendary = DropLegendary,
			DropAncient = DropAncient,
			DropPrimalAncient = DropPrimalAncient,
			DropGold = DropGold,
			DropBloodShard = DropBloodShard,
			Death = Death,
			DamageDealtAll = DamageDealtAll,
			DamageDealtCrit = DamageDealtCrit,
			DamageTaken = DamageTaken,
			Healing = Healing,
			WalkYards = WalkYards
		};
	}

	internal void Add(StatTrackerSnapshot data)
	{
		if (data.AreaSno != 0 && SnoData.Areas != null) SnoArea = SnoData.Areas.GetSnoArea(data.AreaSno);

		loadedElapsedMilliseconds += data.ElapsedMilliseconds;
		loadedTownMilliseconds += data.TownMilliseconds;
		GainedExperience += data.Experience;
		GainedGold += data.Gold;
		MonsterKill += data.MonsterKill;
		EliteKill += data.EliteKill;
		DropAll += data.DropAll;
		DropWhite += data.DropWhite;
		DropMagic += data.DropMagic;
		DropRare += data.DropRare;
		DropLegendary += data.DropLegendary;
		DropAncient += data.DropAncient;
		DropPrimalAncient += data.DropPrimalAncient;
		DropGold += data.DropGold;
		DropBloodShard += data.DropBloodShard;
		Death += data.Death;
		DamageDealtAll += data.DamageDealtAll;
		DamageDealtCrit += data.DamageDealtCrit;
		DamageTaken += data.DamageTaken;
		Healing += data.Healing;
		WalkYards += data.WalkYards;
	}

	private void LoadFrom(string key)
	{
		var data = StatTrackerStorage.Read(StatTrackerStorage.PathFor(Id, key));
		if (data != null) Add(data);
	}

	private double PerHour(double value)
	{
		long playTime = PlayElapsedMilliseconds;
		return playTime > 1 ? value / playTime * MillisecondsPerHour : 0.0;
	}

	private double PerSecond(double value)
	{
		long playTime = PlayElapsedMilliseconds;
		return playTime > 1 ? value / playTime * MillisecondsPerSecond : 0.0;
	}

	private static string FormatTime(long milliseconds, ValueFormat valueFormat)
	{
		if (milliseconds < 1000) milliseconds = 0;
		return Formatting.ValueToString(milliseconds * TimeSpan.TicksPerMillisecond, valueFormat);
	}
}
