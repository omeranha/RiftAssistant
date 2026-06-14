using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace work;

public static class Win32
{
	[StructLayout(LayoutKind.Sequential)]
	public class Class173
	{
		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct48
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;
	}

	public static class ScreenCapture
	{
		public struct Struct49
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public short short_0;

			public short short_1;

			public int int_3;

			public int int_4;

			public int int_5;

			public int int_6;

			public int int_7;

			public int int_8;

			public int int_9;
		}

		public const int int_0 = 13369376;

		public const byte byte_0 = 0;

		public const byte byte_1 = 1;

		public const int int_1 = 2;

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr intptr_0, int int_2, int int_3, int int_4, int int_5, IntPtr intptr_1, int int_6, int int_7, int int_8);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_2, int int_3);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateDIBSection(IntPtr intptr_0, [In] ref Struct49 struct49_0, uint uint_0, out IntPtr intptr_1, IntPtr intptr_2, uint uint_1);
	}

	public static class User32
	{
		public struct Struct50
		{
			public uint uint_0;

			public IntPtr intptr_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;
		}

		public delegate int Delegate4(int code, IntPtr wParam, IntPtr lParam);

		[StructLayout(LayoutKind.Sequential)]
		public class Class176
		{
			public Class173 class173_0;

			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public IntPtr intptr_0;
		}

		public struct Struct51
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		public enum Enum6
		{
			WM_MOUSEMOVE = 512,
			WM_LBUTTONDOWN = 513,
			WM_LBUTTONUP = 514,
			WM_LBUTTONDBLCLK = 515,
			WM_RBUTTONDOWN = 516,
			WM_RBUTTONUP = 517,
			WM_MBUTTONDOWN = 519,
			WM_MBUTTONUP = 520,
			WM_MOUSEWHEEL = 522
		}

		public enum Enum7
		{
			WM_KEYDOWN = 256,
			WM_KEYUP = 257,
			WM_SYSKEYDOWN = 260,
			WM_SYSKEYUP = 261
		}

		public struct WINDOWPLACEMENT
		{
			public int length;

			public int flags;

			public int showCmd;

			public Point minPosition;

			public Point maxPosition;

			public Rectangle normalPosition;
		}

		public const int int_0 = 524288;

		public const int int_1 = 32;

		public const int int_2 = 8;

		public const int int_3 = 128;

		public const int int_4 = 13;

		public const int int_5 = 2;

		public const int int_6 = 1;

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr intptr_0);

		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr intptr_0, ref RECT rect);

		[DllImport("user32.dll")]
		public static extern bool ClientToScreen(IntPtr intptr_0, ref Point point_0);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlashWindowEx(ref Struct50 struct50_0);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string string_0, string string_1);

		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr intptr_0);

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr intptr_0, int int_7, int int_8);

		[DllImport("user32.dll")]
		public static extern int GetWindowLong(IntPtr intptr_0, int int_7);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr intptr_0, out RECT rect);

		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RegisterHotKey(IntPtr intptr_0, int int_7, uint uint_0, uint uint_1);

		[DllImport("user32.dll")]
		public static extern bool SetLayeredWindowAttributes(IntPtr intptr_0, uint uint_0, byte byte_0, uint uint_1);

		[DllImport("user32.dll")]
		public static extern int DrawText(IntPtr intptr_0, string string_0, int int_7, ref RECT rect, uint uint_0);

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool UpdateLayeredWindow(IntPtr intptr_0, IntPtr intptr_1, ref Point point_0, ref Size size_0, IntPtr intptr_2, ref Point point_1, int int_7, ref Struct48 struct48_0, int int_8);

		[DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
		public static extern bool SetLayeredWindowAttributes_1(IntPtr intptr_0, int int_7, byte byte_0, int int_8);

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr intptr_0);

		[DllImport("user32.dll")]
		public static extern short GetKeyState(int int_7);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern short GetAsyncKeyState(int int_7);

		[DllImport("user32.dll")]
		public static extern bool SetCursorPos(int int_7, int int_8);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern int SetWindowsHookEx(int int_7, Delegate4 delegate4_0, IntPtr intptr_0, int int_8);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool UnhookWindowsHookEx(int int_7);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern int CallNextHookEx(int int_7, int int_8, IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowTextLength(IntPtr intptr_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_7);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowPlacement(IntPtr intptr_0, ref WINDOWPLACEMENT struct52_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_7);
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MEMORY_BASIC_INFORMATION
	{
		public IntPtr BaseAddress;
		public IntPtr AllocationBase;
		public uint AllocationProtect;
		public IntPtr RegionSize;
		public uint State;
		public uint Protect;
		public uint Type;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SYSTEM_INFO
	{
		public ushort ProcessorArchitecture;
		public ushort Reserved;

		public uint PageSize;
		public IntPtr MinimumApplicationAddress;
		public IntPtr MaximumApplicationAddress;
		public IntPtr ActiveProcessorMask;

		public uint NumberOfProcessors;
		public uint ProcessorType;
		public uint AllocationGranularity;

		public ushort ProcessorLevel;
		public ushort ProcessorRevision;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern void ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, ref byte byte_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemory_2(IntPtr intptr_0, IntPtr intptr_1, ref int int_0, int int_1, int int_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern void WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref int int_0, int int_1, int int_2);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	public static extern void WriteProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemory_3(IntPtr intptr_0, IntPtr intptr_1, ref long long_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	public static extern void WriteProcessMemory_2(IntPtr intptr_0, IntPtr intptr_1, ref long long_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	public static extern void WriteProcessMemory_3(IntPtr intptr_0, IntPtr intptr_1, ref ulong ulong_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemoryUInt(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemory_5(IntPtr intptr_0, IntPtr intptr_1, ref ulong ulong_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern void ReadProcessMemory_6(IntPtr intptr_0, IntPtr intptr_1, ref float float_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern bool ReadProcessMemory_7(IntPtr intptr_0, IntPtr intptr_1, [Out][MarshalAs(UnmanagedType.AsAny)] object object_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern bool ReadProcessMemory_8(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public unsafe static extern bool ReadProcessMemory_9(IntPtr intptr_0, IntPtr intptr_1, void* pVoid_0, int int_0, IntPtr intptr_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll")]
	public static extern bool SetConsoleMode(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll")]
	public static extern bool GetConsoleMode(IntPtr intptr_0, out int int_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetStdHandle(int int_0);

	public static string GetWindowTitle(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(User32.GetWindowTextLength(intptr_0) + 1);
		User32.GetWindowText(intptr_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public static string GetWindowClassName(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(100);
		User32.GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll")]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out MEMORY_BASIC_INFORMATION struct53_0, uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern void GetSystemInfo(ref SYSTEM_INFO struct54_0);

	private const int INPUT_MOUSE = 0;
	private const int INPUT_KEYBOARD = 1;

	private const uint KEYEVENTF_KEYUP = 0x0002;

	private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
	private const uint MOUSEEVENTF_LEFTUP = 0x0004;
	private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
	private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
	private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
	private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

	[StructLayout(LayoutKind.Sequential)]
	private struct INPUT
	{
		public int type;
		public INPUTUNION U;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct INPUTUNION
	{
		[FieldOffset(0)] public MOUSEINPUT mi;
		[FieldOffset(0)] public KEYBDINPUT ki;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct MOUSEINPUT
	{
		public int dx;
		public int dy;
		public uint mouseData;
		public uint dwFlags;
		public uint time;
		public nint dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct KEYBDINPUT
	{
		public ushort wVk;
		public ushort wScan;
		public uint dwFlags;
		public uint time;
		public nint dwExtraInfo;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetAsyncKeyState(int vKey);

	public static bool IsKeyDown(Vk vk) => (GetAsyncKeyState((int)vk) & 0x8000) != 0;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

	private static void Send(INPUT input)
	{
		var inputs = new[] { input };
		_ = SendInput(1, inputs, Marshal.SizeOf<INPUT>());
	}

	private static void SendKey(Vk vk, bool up = false) => Send(new INPUT {
		type = INPUT_KEYBOARD,
		U = new INPUTUNION { ki = new KEYBDINPUT { wVk = (ushort)vk, dwFlags = up ? KEYEVENTF_KEYUP : 0 } }
	});

	private static void SendMouse(uint mouseFlag) => Send(new INPUT {
		type = INPUT_MOUSE,
		U = new INPUTUNION { mi = new MOUSEINPUT { dwFlags = mouseFlag } }
	});

	public static void PressKey(Vk vk, bool release = true)
	{
		if (vk == Vk.LBUTTON || vk == Vk.RBUTTON || vk == Vk.MBUTTON) {
			MouseClick(vk);
			return;
		}

		SendKey(vk);
		if (release) {
			SendKey(vk, true);
		}
	}

	public static void ReleaseKey(Vk vk) => SendKey(vk, true);

	public static void MouseClick(Vk button, bool hold = false)
	{
		uint upFlag;
		uint downFlag;
		switch (button) {
			case Vk.LBUTTON:
				downFlag = MOUSEEVENTF_LEFTDOWN;
				upFlag = MOUSEEVENTF_LEFTUP;
				break;
			case Vk.RBUTTON:
				downFlag = MOUSEEVENTF_RIGHTDOWN;
				upFlag = MOUSEEVENTF_RIGHTUP;
				break;
			case Vk.MBUTTON:
				downFlag = MOUSEEVENTF_MIDDLEDOWN;
				upFlag = MOUSEEVENTF_MIDDLEUP;
				break;
			default:
				return;
		}
		SendMouse(downFlag);

		if (hold) return;

		SendMouse(upFlag);
	}

	public static void SetMousePos(int x, int y)
	{
		User32.SetCursorPos(x, y);
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(out int X, out int Y);

	public static void GetMousePos(out int X, out int Y) => GetCursorPos(out X, out Y);
}
