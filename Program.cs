using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

internal static class Program
{
	public static string AppDir = Path.GetDirectoryName(Environment.ProcessPath);
	public static readonly string SettingsFolder = Path.Combine(AppDir, "settings");
	public static readonly string LogFolder = Path.Combine(AppDir, "logs");

	private static Thread trayThread;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Directory.SetCurrentDirectory(AppContext.BaseDirectory);
		Directory.CreateDirectory(LogFolder);
		try {
			File.Delete(Path.Combine(LogFolder, "info.txt"));
			File.Delete(Path.Combine(LogFolder, "exceptions.txt"));

			StartTray();
			Core.Init();
			Core.MainLoop();
		} catch (Exception ex) {
			Logger.LogException(ex.Message);
			MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
