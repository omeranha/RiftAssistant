using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using work;

internal static class Program
{
	public static string AppDir = Path.GetDirectoryName(Environment.ProcessPath);
	public static readonly string SettingsFolder = Path.Combine(AppDir, "settings");
	public static readonly string LogFolder = Path.Combine(AppDir, "logs");

	private static Thread inputThread;
	private static Thread trayThread;
	private static Thread collectThread;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Directory.CreateDirectory(LogFolder);
		try {
			File.Delete(Path.Combine(LogFolder, "info.txt"));
			File.Delete(Path.Combine(LogFolder, "exceptions.txt"));

			inputThread = new Thread(Core.InputLoop) { IsBackground = true };
			inputThread.Start();

			Core.Init();
			collectThread = new Thread(Core.CollectLoop) { IsBackground = true };
			collectThread.Start();
			Core.MainLoop();
		} catch (Exception ex) {
			Logger.LogException(ex.Message);
			MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
