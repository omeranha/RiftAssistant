using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using work;

internal static class TrayIconManager
{
	private static NotifyIcon trayIcon;

	public static void Initialize()
	{
		Assembly assembly = Assembly.GetExecutingAssembly();
		using Stream stream = assembly.GetManifestResourceStream("RiftAssistant.rift_assistant.ico");
		trayIcon = new NotifyIcon {
			Icon = new Icon(stream),
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
			trayIcon!.Visible = false;
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
	}

	public static void Hide()
	{
		trayIcon?.Visible = false;
	}
}