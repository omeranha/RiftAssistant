using System;
using System.Diagnostics;

namespace RiftAssistant.Tracking;

internal static class StatTrackerAutosave
{
	private static readonly TimeSpan Interval = TimeSpan.FromSeconds(60);
	private static long lastSave = Stopwatch.GetTimestamp();

	public static void Tick()
	{
		if (Stopwatch.GetElapsedTime(lastSave) < Interval) return;

		lastSave = Stopwatch.GetTimestamp();
		foreach (var tracker in CoreCollector.Trackers) {
			tracker.Save();
		}
	}
}