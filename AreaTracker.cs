using System;
using System.Globalization;
using Plugins;
using work;

internal class AreaTracker
{
	public readonly RunTracker Run;

	public readonly ISnoArea SnoArea;

	public readonly DateTime StartTime;

	public readonly int StartGameTick;

	public readonly StatTracker AreaStats;

	public readonly StatTracker AreaTotalStats;

	public readonly StatTracker AreaTotalDifficultyStats;

	public uint EndLevelNormal;

	public uint EndLevelParagon;

	public long EndParagonExp;

	public string AreaNameLocalized;

	internal AreaTracker(RunTracker runTracker, ISnoArea snoArea, string areaNameLocalized, string areaSnoString)
	{
		Run = runTracker;
		AreaNameLocalized = areaNameLocalized;
		SnoArea = snoArea;
		StartTime = DateTime.Now;
		StartGameTick = CoreCollector.D3Memory.GameTick;

		AreaStats = new StatTracker(CoreCollector.LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), true, "AREA", (string)null);
		AreaTotalStats = new StatTracker(CoreCollector.LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "AREA TOTAL", "areatotal_" + areaSnoString) {
			SnoArea = snoArea
		};
		AreaTotalDifficultyStats = new StatTracker(CoreCollector.LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), bool_1: true, "AREA TOTAL", "areatotal_" + runTracker.GameDifficulty.ToString() + "_" + areaSnoString) {
			SnoArea = snoArea
		};
	}

	internal void RecordExitStats()
	{
		EndLevelNormal = CoreCollector.LocalPlayer.CurrentLevelNormal;
		EndLevelParagon = CoreCollector.LocalPlayer.CurrentLevelParagon;
		EndParagonExp = CoreCollector.LocalPlayer.ParagonTotalExp;
	}
}
