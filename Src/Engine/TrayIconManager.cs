using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RiftAssistant.Engine;

internal static class TrayIconManager
{
	private static NotifyIcon trayIcon;
	private static Control dispatcher;

	public static void Initialize()
	{
		dispatcher = new Control();
		_ = dispatcher.Handle;
		Assembly assembly = Assembly.GetExecutingAssembly();
		using Stream stream = assembly.GetManifestResourceStream("RiftAssistant.rift_assistant.ico");
		trayIcon = new NotifyIcon {
			Icon = AppResources.Icon,
			Text = "Rift Assistant",
			Visible = true,
			ContextMenuStrip = CreateMenu()
		};
	}

	private static ContextMenuStrip CreateMenu()
	{
		var menu = new ContextMenuStrip();

		menu.Items.Add("Reload Plugins", null, (_, _) => {
			Core.PluginHandler.LoadPlugins(true);
			Core.PluginListMenu.Reload();
		});

		menu.Items.Add("Exit", null, (_, _) => {
			trayIcon.Visible = false;
			Core.Exit();
		});

		return menu;
	}

	public static void Dispose()
	{
		if (trayIcon == null) {
			return;
		}

		trayIcon.Visible = false;
		trayIcon.Dispose();
		dispatcher?.Dispose();
	}

	public static void Close()
	{
		Control target = dispatcher;
		if (target == null || !target.IsHandleCreated) {
			return;
		}

		target.BeginInvoke(() => {
			trayIcon.Visible = false;
			Application.ExitThread();
		});
	}
}