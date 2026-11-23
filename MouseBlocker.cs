using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


public static class MouseBlocker
{
	private const int WH_MOUSE_LL = 14;
	private const int WM_LBUTTONDOWN = 0x0201;
	private const int WM_LBUTTONUP = 0x0202;
	private const int WM_RBUTTONDOWN = 0x0204;
	private const int WM_RBUTTONUP = 0x0205;
	private const int WM_MBUTTONDOWN = 0x0207;
	private const int WM_MBUTTONUP = 0x0208;

	private static readonly ConcurrentDictionary<MouseButtons, bool> blockedButtons = new();

	private static LowLevelMouseProc _proc = HookCallback;
	private static IntPtr _hookID = IntPtr.Zero;
	private static Thread _hookThread;

	public static void Start()
	{
		if (_hookThread != null) return;
		_hookThread = new Thread(() => {
			_hookID = SetHook(_proc);
			Application.Run();
			UnhookWindowsHookEx(_hookID);
		}) {
			IsBackground = true,
			Name = "MouseBlockerThread"
		};
		_hookThread.SetApartmentState(ApartmentState.STA);
		_hookThread.Start();
	}

	public static void Stop()
	{
		if (_hookID != IntPtr.Zero) {
			UnhookWindowsHookEx(_hookID);
			_hookID = IntPtr.Zero;
		}
	}

	private static IntPtr SetHook(LowLevelMouseProc proc)
	{
		using (Process curProcess = Process.GetCurrentProcess())
		using (ProcessModule curModule = curProcess.MainModule) {
			return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
		}
	}

	private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		if (nCode >= 0 && TryGetButton((int)wParam, out var button, out bool isDown) && ShouldBlock(lParam, button, isDown)) {
			return (IntPtr)1;
		}

		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	private static bool TryGetButton(int message, out MouseButtons button, out bool isDown)
	{
		(button, isDown) = message switch {
			WM_LBUTTONDOWN => (MouseButtons.Left, true),
			WM_LBUTTONUP => (MouseButtons.Left, false),
			WM_RBUTTONDOWN => (MouseButtons.Right, true),
			WM_RBUTTONUP => (MouseButtons.Right, false),
			WM_MBUTTONDOWN => (MouseButtons.Middle, true),
			WM_MBUTTONUP => (MouseButtons.Middle, false),
			_ => (MouseButtons.None, false)
		};

		return button != MouseButtons.None;
	}

	private static bool ShouldBlock(IntPtr lParam, MouseButtons button, bool isDown)
	{
		// A blocked press must also swallow its release, otherwise the game sees a release without a press.
		if (!isDown) return blockedButtons.TryRemove(button, out _);

		if (Overlay.Instance == null || GameWindowManager.Window.Handle == IntPtr.Zero || Overlay.Instance.State == OverlayDisplayState.Hidden || !GameWindowManager.Window.IsForeground) return false;

		var point = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam).pt;
		bool blocked = button == MouseButtons.Left && Core.SettingsMenu != null && Core.SettingsMenu.ShowMenu && Core.SettingsMenu.HandleInput(point.x, point.y, true);

		if (!blocked) {
			var window = GameWindowManager.Window;
			int x = point.x - window.Offset.X;
			int y = point.y - window.Offset.Y;
			blocked = x >= 0 && y >= 0 && x < window.Size.Width && y < window.Size.Height && Core.PluginHandler != null && Core.PluginHandler.ShouldBlockMouse(button, x, y);
		}

		if (blocked) blockedButtons[button] = true;
		return blocked;
	}
	[StructLayout(LayoutKind.Sequential)]
	private struct POINT { public int x; public int y; }

	[StructLayout(LayoutKind.Sequential)]
	private struct MSLLHOOKSTRUCT
	{
		public POINT pt;
		public uint mouseData;
		public uint flags;
		public uint time;
		public IntPtr dwExtraInfo;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);
}
