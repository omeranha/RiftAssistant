using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Plugins;
using SNO;
using work;

internal class RunTracker
{
	public readonly DateTime StartTime;

	public readonly int StartGameTick;

	public readonly List<AreaTracker> VisitedAreas = [];

	public AreaTracker CurrentArea;

	public readonly GameDifficulty GameDifficulty;

	public readonly int HeroCollectorValue;

	public readonly string GameServerIp;

	public readonly StatTracker RunStatTracker;

	public readonly HashSet<string> TrackedStrings = [];

	public readonly HashSet<long> TrackedLongs = [];

	public readonly bool IsHardcore;

	public readonly uint HeroId;

	public readonly int PlayerValue;

	public readonly HeroClass HeroClass;

	public readonly bool IsChallengeRift;

	public readonly StringBuilder LogBuilder = new();

	internal RunTracker(SnoArea initialArea)
	{
		StartTime = DateTime.Now;
		StartGameTick = CoreCollector.D3Memory.GameTick;
		HeroCollectorValue = CoreCollector.HeroCollector.Int32_0;
		GameServerIp = CoreCollector.GameServerIP;
		RunStatTracker = new StatTracker(CoreCollector.LocalPlayer.HeroId.ToString("D", CultureInfo.InvariantCulture), true, "RUN", (string)null);
		IsHardcore = CoreCollector.LocalPlayer.HeroIsHardcore;
		HeroId = CoreCollector.LocalPlayer.HeroId;
		PlayerValue = ((CoreCollector.LocalPlayer as Player).Boolean_1 ? (CoreCollector.LocalPlayer as Player).Int32_0 : 0);
		HeroClass = CoreCollector.LocalPlayer.HeroClassDefinition.HeroClass;
		GameDifficulty = CoreCollector.gameDifficulty_0;
		IsChallengeRift = CoreCollector.D3Memory.GameState_Value_IsChallengeRiftGame;
		UpdateCurrentArea(initialArea);
	}

	internal void UpdateCurrentArea(SnoArea isnoArea_0)
	{
		if (CurrentArea != null) {
			CurrentArea.AreaStats.Stop();
			CurrentArea.RecordExitStats();
		}
		AreaTracker @class = null;
		for (int i = 0; i < VisitedAreas.Count; i++) {
			if (VisitedAreas[i].SnoArea.NameLocalized == isnoArea_0.NameLocalized) {
				@class = VisitedAreas[i];
				break;
			}
		}
		if (@class == null) {
			@class = new AreaTracker(this, isnoArea_0, isnoArea_0.NameLocalized, isnoArea_0.Sno.ToString("D", CultureInfo.InvariantCulture));
			VisitedAreas.Add(@class);
		}
		CurrentArea = @class;
	}
}
