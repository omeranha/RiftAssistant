using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RiftAssistant;

internal static class Program
{
	public static readonly string? AppDir = Path.GetDirectoryName(Environment.ProcessPath);
	public static readonly string UserDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RiftAssistant");
	public static readonly string SettingsFolder = Path.Combine(UserDataFolder, "settings");
	public static readonly string LogFolder = Path.Combine(UserDataFolder, "logs");
	public static readonly string StatTrackerFolder = Path.Combine(UserDataFolder, "stat_tracker");
	public static readonly string ScreenshotFolder = Path.Combine(UserDataFolder, "screenshots");
	public static readonly string CacheFolder = Path.Combine(UserDataFolder, "cache");

	private static readonly TimeSpan TrayJoinTimeout = TimeSpan.FromMilliseconds(500);

	private static Thread trayThread = null!;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Directory.SetCurrentDirectory(AppContext.BaseDirectory);
		Directory.CreateDirectory(LogFolder);
		try {
			LegacyUserData.Migrate();
			File.Delete(Path.Combine(LogFolder, "info.txt"));
			File.Delete(Path.Combine(LogFolder, "exceptions.txt"));

			StartupChecks.Run();
			StartTray();
			Core.Init();
			Core.MainLoop();
			Core.Shutdown();
			trayThread?.Join(TrayJoinTimeout);
		} catch (StartupException ex) {
			Logger.LogException(ex.ToString());
			MessageBox.Show($"{ex.Message}\n\nLogs: {LogFolder}", "RiftAssistant cannot start", MessageBoxButtons.OK, MessageBoxIcon.Error);
		} catch (Exception ex) {
			Logger.LogException(ex.ToString());
			MessageBox.Show($"RiftAssistant stopped because of an unexpected error:\n\n{ex.GetType().Name}: {ex.Message}\n\nThe full details are in:\n{Path.Combine(LogFolder, "exceptions.txt")}", "RiftAssistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private static void StartTray()
	{
		trayThread = new Thread(() => {
			Application.EnableVisualStyles();
			TrayIconManager.Initialize();
			Application.Run();
			TrayIconManager.Dispose();
		});

		trayThread.SetApartmentState(ApartmentState.STA);
		trayThread.IsBackground = true;
		trayThread.Start();
	}
}
