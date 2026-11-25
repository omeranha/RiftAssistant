using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RiftAssistant.Input;

internal readonly record struct CapturedKey(Vk Key, char Character, bool Shift, bool Ctrl, bool Alt);

internal static partial class KeyboardCapture
{
	private const int WH_KEYBOARD_LL = 13;
	private const int WM_KEYDOWN = 0x0100;
	private const int WM_KEYUP = 0x0101;
	private const int WM_SYSKEYDOWN = 0x0104;
	private const int WM_SYSKEYUP = 0x0105;
	private const uint LLKHF_INJECTED = 0x10;
	private static readonly TimeSpan MaxDuration = TimeSpan.FromSeconds(30);
	private static readonly TimeSpan SuppressionTail = TimeSpan.FromMilliseconds(300);

	private static readonly LowLevelKeyboardProc proc = HookCallback;
	private static readonly HashSet<int> swallowedKeys = [];
	private static volatile Func<CapturedKey, bool> handler;
	private static int captureId;
	private static long startedAt;
	private static long endedAt = -1;
	private static IntPtr hookId = IntPtr.Zero;
	private static Thread hookThread;
	private static uint hookThreadId;

	public static bool IsActive => handler != null;

	// The raw input thread still reports swallowed keys, so hotkeys and plugins must ignore input during and just after a capture.
	public static bool SuppressesInput => handler != null || (endedAt >= 0 && Stopwatch.GetElapsedTime(endedAt) < SuppressionTail);

	public static void Start()
	{
		if (hookThread != null) return;

		hookThread = new Thread(() => {
			hookThreadId = NativeThread.CurrentId();
			hookId = SetHook();
			Application.Run();
			UnhookWindowsHookEx(hookId);
			hookId = IntPtr.Zero;
		}) {
			IsBackground = true,
			Name = "KeyboardCaptureThread"
		};
		hookThread.SetApartmentState(ApartmentState.STA);
		hookThread.Start();
	}

	public static void Stop()
	{
		if (hookThread == null) return;

		NativeThread.RequestQuit(hookThreadId);
		hookThread.Join(NativeThread.JoinTimeout);
		hookThread = null;
	}

	public static bool IsCurrent(int id)
	{
		return handler != null && captureId == id;
	}

	public static int Begin(Func<CapturedKey, bool> onKey)
	{
		int id = Interlocked.Increment(ref captureId);
		startedAt = Stopwatch.GetTimestamp();
		handler = onKey;
		return id;
	}

	public static void End()
	{
		if (handler == null) return;

		handler = null;
		endedAt = Stopwatch.GetTimestamp();
	}

	public static void EndIfStale()
	{
		if (handler != null && Stopwatch.GetElapsedTime(startedAt) > MaxDuration) End();
	}

	private static IntPtr SetHook()
	{
		using var process = Process.GetCurrentProcess();
		using var module = process.MainModule;
		return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(module.ModuleName), 0);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		try {
			if (nCode >= 0 && ShouldSwallow((int)wParam, Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam))) return (IntPtr)1;
		} catch (Exception ex) {
			End();
			Logger.LogException(ex.ToString());
		}

		return CallNextHookEx(hookId, nCode, wParam, lParam);
	}

	private static bool ShouldSwallow(int message, KBDLLHOOKSTRUCT data)
	{
		bool isDown = message is WM_KEYDOWN or WM_SYSKEYDOWN;
		bool isUp = message is WM_KEYUP or WM_SYSKEYUP;
		if (!isDown && !isUp) return false;

		int vk = (int)data.vkCode;
		// A swallowed press must also swallow its release, otherwise the game sees a release without a press.
		if (isUp) return swallowedKeys.Remove(vk);

		var activeHandler = handler;
		if (activeHandler == null || (data.flags & LLKHF_INJECTED) != 0) return false;

		if (Stopwatch.GetElapsedTime(startedAt) > MaxDuration) {
			End();
			return false;
		}

		swallowedKeys.Add(vk);
		if (IsModifier(vk)) return true;

		if (activeHandler(Describe(vk, data.scanCode))) End();
		return true;
	}

	private static CapturedKey Describe(int vk, uint scanCode)
	{
		bool shift = IsDown(0x10);
		bool ctrl = IsDown(0x11);
		bool alt = IsDown(0x12);
		return new CapturedKey((Vk)vk, ToCharacter(vk, scanCode, shift, ctrl, alt), shift, ctrl, alt);
	}

	private static unsafe char ToCharacter(int vk, uint scanCode, bool shift, bool ctrl, bool alt)
	{
		if (ctrl || alt) return '\0';

		var state = new byte[256];
		if (shift) state[0x10] = 0x80;
		if ((GetKeyState(0x14) & 1) != 0) state[0x14] = 1;

		char* buffer = stackalloc char[4];
		var layout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out _));
		// Flag 0x4 keeps the keyboard state untouched so dead keys do not alter the game's next character.
		int count = ToUnicodeEx((uint)vk, scanCode, state, buffer, 4, 0x4, layout);
		return count == 1 && !char.IsControl(buffer[0]) ? buffer[0] : '\0';
	}

	private static bool IsDown(int vk)
	{
		return (GetAsyncKeyState(vk) & 0x8000) != 0;
	}

	private static bool IsModifier(int vk)
	{
		return vk is 0x10 or 0x11 or 0x12 or 0xA0 or 0xA1 or 0xA2 or 0xA3 or 0xA4 or 0xA5 or 0x5B or 0x5C or 0x14;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	[StructLayout(LayoutKind.Sequential)]
	private struct KBDLLHOOKSTRUCT
	{
		public uint vkCode;
		public uint scanCode;
		public uint flags;
		public uint time;
		public IntPtr dwExtraInfo;
	}

	[LibraryImport("user32.dll", EntryPoint = "SetWindowsHookExW", SetLastError = true)]
	private static partial IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[LibraryImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool UnhookWindowsHookEx(IntPtr hhk);

	[LibraryImport("user32.dll", SetLastError = true)]
	private static partial IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	private static partial IntPtr GetModuleHandle(string lpModuleName);

	[LibraryImport("user32.dll")]
	private static partial short GetAsyncKeyState(int vKey);

	[LibraryImport("user32.dll")]
	private static partial short GetKeyState(int nVirtKey);

	[LibraryImport("user32.dll")]
	private static partial IntPtr GetForegroundWindow();

	[LibraryImport("user32.dll")]
	private static partial uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

	[LibraryImport("user32.dll")]
	private static partial IntPtr GetKeyboardLayout(uint idThread);

	[LibraryImport("user32.dll")]
	private static unsafe partial int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, char* pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);
}
