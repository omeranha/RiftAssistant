using System;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

internal static class GameWindowManager
{
	public static Window Window = new();
	public static Process Process;
	public static IntPtr ProcessHandle = IntPtr.Zero;
	public static IntPtr MainModuleHandle = IntPtr.Zero;

	internal static bool Update()
	{
		if (Window.Handle == IntPtr.Zero || !IsWindow(Window.Handle)) {
			Window.Handle = FindWindow("D3 Main Window Class", null);
			if (Window.Handle == IntPtr.Zero) {
				Window.Handle = FindWindow(null, Window.WindowTitle);
			}

			if (Window.Handle == IntPtr.Zero) {
				Window.Offset = Point.Empty;
				Window.IsForeground = false;
				Window.ProcessId = 0;
				return false;
			}

			GetWindowThreadProcessId(Window.Handle, out uint pid);
			Window.ProcessId = pid;
		}

		GetWindowThreadProcessId(GetForegroundWindow(), out uint fgPid);
		Window.IsForeground = fgPid == Window.ProcessId;

		Point clientPoint = default;
		ClientToScreen(Window.Handle, ref clientPoint);
		GetClientRect(Window.Handle, out RECT clientRect);

		int clientWidth = clientRect.Right - clientRect.Left;
		int clientHeight = clientRect.Bottom - clientRect.Top;
		if (clientWidth <= 0 || clientHeight <= 0) {
			if (Window.Size.Width == 0) {
				Window.Size = new Size(1280, 720);
				Window.Aspect = 1f;
			}
			return true;
		}

		bool isFullscreen = CoreCollector.GameSettingsManager.IsFullscreen;
		int width = clientWidth;
		int height = isFullscreen ? width * 9 / 16 : clientHeight;
		int offsetX = clientPoint.X;
		int offsetY = isFullscreen ? clientPoint.Y + (clientHeight - height) / 2 : clientPoint.Y;
		if (offsetX != Window.Offset.X || offsetY != Window.Offset.Y) {
			Window.Offset = new Point(offsetX, offsetY);
		}

		if (Window.Size.Width != width || Window.Size.Height != height) {
			Window.Size = new Size(width, height);
			float fWidth = width;
			float fHeight = height;
			Window.Aspect = fWidth / fHeight * (600f / 800f);
			float baseWidth = fHeight * 4f / 3f;
			float scaleHeight = 600f / fHeight;
			Window.WidescreenOffset = (fWidth - baseWidth) * scaleHeight;
			Window.HeightUiRatio = fHeight / 1200f;
		}
		return true;
	}

	public static bool OpenProcess()
	{
		Process[] processesByName = Process.GetProcessesByName("Diablo III64");
		if (processesByName != null && processesByName.Length != 0) {
			try {
				Process = processesByName[0];
				if (Process != null && !Process.HasExited) {
					ProcessHandle = OpenProcess(0x0010, false, Process.Id);
					MainModuleHandle = Process.MainModule.BaseAddress;
				}
				return true;
			} catch (Exception) {
				Process = null;
				ProcessHandle = IntPtr.Zero;
				MainModuleHandle = IntPtr.Zero;
			}
		}
		return false;
	}

	public static void CloseProcess()
	{
		if (Process != null) {
			Process = null;
			CloseHandle(ProcessHandle);
			ProcessHandle = IntPtr.Zero;
			MainModuleHandle = IntPtr.Zero;
		}
	}

	public static bool IsProcessValid()
	{
		if (Process != null && !Process.HasExited) {
			return true;
		}
		CloseProcess();
		return OpenProcess();
	}

	public static unsafe T Read<T>(long address, bool relative = false, int size = 0) where T : unmanaged
	{
		T value = default;
		ReadProcessMemory(ProcessHandle, checked((IntPtr)(relative ? address + MainModuleHandle : address)), &value, size == 0 ? sizeof(T) : size, out _);
		return value;
	}

	public static unsafe byte[] ReadBytes(long address, int size)
	{
		byte[] buffer = new byte[size];
		fixed (byte* ptr = buffer) {
			ReadProcessMemory(ProcessHandle, checked((IntPtr)address), ptr, size, out _);
		}
		return buffer;
	}

	public static unsafe T[] ReadArray<T>(long address, int count, bool relative = false) where T : unmanaged
	{
		T[] array = new T[count];
		fixed (T* ptr = array) {
			ReadProcessMemory(ProcessHandle, checked((IntPtr)(relative ? address + MainModuleHandle : address)), ptr, count * sizeof(T), out _);
		}
		return array;
	}

	public static unsafe bool ReadIntoArray<T>(long address, T[] buffer, int offset, int count) where T : unmanaged
	{
		fixed (T* ptr = &buffer[offset]) {
			return ReadProcessMemory(ProcessHandle, checked((IntPtr)address), ptr, count * sizeof(T), out _);
		}
	}

	public static string ReadString(long address, int length, Encoding encoding, bool nullTerminated = false)
	{
		byte[] bytes = ReadBytes(address, length);
		if (!nullTerminated) return encoding.GetString(bytes);

		int terminator = Array.IndexOf(bytes, (byte)0);
		return terminator >= 0 ? encoding.GetString(bytes, 0, terminator) : encoding.GetString(bytes);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern unsafe bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, void* lpBuffer, int nSize, out IntPtr lpNumberOfBytesRead);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr handle);

	[DllImport("user32.dll")]
	private static extern bool GetClientRect(IntPtr handle, out RECT rect);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern bool ClientToScreen(IntPtr hwnd, ref Point point);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string className, string windowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll")]
	private static extern bool IsWindow(IntPtr hWnd);
}
