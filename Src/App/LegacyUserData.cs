using System;
using System.IO;

namespace RiftAssistant;

internal static class LegacyUserData
{
	public static void Migrate()
	{
		CopyOnce("settings", Program.SettingsFolder);
		CopyOnce("stat_tracker", Program.StatTrackerFolder);
		CopyOnce("screenshots", Program.ScreenshotFolder);
		DeleteCompiledPluginCache();
	}

	private static void CopyOnce(string legacyName, string target)
	{
		string legacy = Path.Combine(Program.AppDir, legacyName);
		if (!Directory.Exists(legacy) || Directory.Exists(target)) return;

		string staging = target + ".migrating";
		try {
			if (Directory.Exists(staging)) Directory.Delete(staging, true);
			CopyDirectory(legacy, staging);
			Directory.Move(staging, target);
			Logger.Info($"Copied {legacy} to {target}");
		} catch (Exception ex) {
			Logger.LogException($"Could not copy {legacy} to {target}: {ex.Message}");
		}
	}

	private static void CopyDirectory(string source, string destination)
	{
		Directory.CreateDirectory(destination);
		foreach (string file in Directory.GetFiles(source)) {
			File.Copy(file, Path.Combine(destination, Path.GetFileName(file)));
		}

		foreach (string directory in Directory.GetDirectories(source)) {
			CopyDirectory(directory, Path.Combine(destination, Path.GetFileName(directory)));
		}
	}

	private static void DeleteCompiledPluginCache()
	{
		foreach (string file in Directory.GetFiles(Program.AppDir, "compiled_plugins_*")) {
			try {
				File.Delete(file);
			} catch (IOException) {
			}
		}
	}
}