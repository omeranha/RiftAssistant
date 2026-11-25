using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RiftAssistant;

public static class Logger
{
	private static readonly TimeSpan RepeatSummaryInterval = TimeSpan.FromSeconds(5);
	private static readonly object RepeatLock = new();
	private const int MaxTrackedMessages = 200;
	private static readonly Dictionary<string, RepeatState> RepeatStates = [];

	public static int ExceptionCount { get; private set; }

	private sealed class RepeatState
	{
		public int Suppressed;
		public long LastWrite;
	}

	public static void Info(string text)
	{
		try {
			string path = Path.Combine(Program.LogFolder, "info.txt");
			File.AppendAllText(path, $"{DateTime.Now:MM.dd.yyyy HH:mm:ss} - {text}{Environment.NewLine}");
		} catch (Exception e) {
			MessageBox.Show($"Failed to write info log file:\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	public static void LogException(string message)
	{
		ExceptionCount++;
		try {
			string path = Path.Combine(Program.LogFolder, "exceptions.txt");
			string? line = ReduceRepeats(message);
			if (line != null) File.AppendAllText(path, line);
			Overlay.Instance?.DrawStatus($"{ExceptionCount} Exception(s)", Overlay.Instance.StatusMessage);
		} catch (Exception e) {
			MessageBox.Show($"Failed to write exception log file.\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	// The collectors and plugin painters can fail on every frame, so a message that was already written is summarized instead of written again.
	private static string? ReduceRepeats(string message)
	{
		lock (RepeatLock) {
			if (RepeatStates.Count >= MaxTrackedMessages) RepeatStates.Clear();

			string stamp = $"{DateTime.Now:MM.dd.yyyy HH:mm:ss}";
			if (!RepeatStates.TryGetValue(message, out var state)) {
				RepeatStates[message] = new RepeatState { LastWrite = Stopwatch.GetTimestamp() };
				return $"{stamp} - {message}{Environment.NewLine}";
			}

			state.Suppressed++;
			if (Stopwatch.GetElapsedTime(state.LastWrite) < RepeatSummaryInterval) return null;

			string firstLine = message.Split('\n')[0].TrimEnd('\r');
			string summary = $"{stamp} - (repeated {state.Suppressed} more times: {firstLine}){Environment.NewLine}";
			state.Suppressed = 0;
			state.LastWrite = Stopwatch.GetTimestamp();
			return summary;
		}
	}
	public static void LogParagonLevel()
	{
		try {
			string path = Path.Combine(Program.LogFolder, "paragon.txt");
			string line = $"{DateTime.Now:yyyy.MM.dd HH:mm:ss} - {Core.Controller.BattleTag} with {Core.Controller.Game.Me.HeroName} reached paragon level {Core.Controller.Game.Me.CurrentLevelParagon}";
			File.AppendAllText(path, line + Environment.NewLine);
		} catch (Exception e) {
			MessageBox.Show($"Failed to write paragon log file.\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}