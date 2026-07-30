using System;
using System.IO;
using System.Windows.Forms;


public static class Logger
{
	public static int ExceptionCount { get; private set; }

	public static void Info(string text)
	{
		try {
			string path = Path.Combine(Program.LogFolder, "info.txt");
			File.AppendAllText(path, $"{DateTime.Now:MM.dd.yyyy HH:mm:ss} - {text}{Environment.NewLine}");
		} catch (Exception e) {
			MessageBox.Show($"Failed to write info log file:\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	public static void LogException(string text)
	{
		ExceptionCount++;
		try {
			string path = Path.Combine(Program.LogFolder, "exceptions.txt");
			File.AppendAllText(path, $"{DateTime.Now:MM.dd.yyyy HH:mm:ss} - {text}{Environment.NewLine}");
			Overlay.Instance?.DrawStatus($"{ExceptionCount} Exception(s)", Overlay.Instance.StatusMessage);
		} catch (Exception e) {
			MessageBox.Show($"Failed to write exception log file.\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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