using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace RiftAssistant.Engine;

internal static partial class GameWindowManager
{
	public static readonly Window Window = new();
	public static Process Process { get; private set; }
	public static IntPtr ProcessHandle { get; private set; } = IntPtr.Zero;
	public static IntPtr MainModuleHandle { get; private set; } = IntPtr.Zero;

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

		ScreenPoint clientPoint = default;
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

	private static long readCalls;

	public static long TakeReadCalls()
	{
		return Interlocked.Exchange(ref readCalls, 0);
	}

	public static unsafe void ReadMany<T>(IReadOnlyList<long> addresses, T[] results) where T : unmanaged
	{
		int size = sizeof(T);
		foreach (var span in ReadPlanner.Plan(addresses, size)) {
			byte[] buffer = ArrayPool<byte>.Shared.Rent(span.Length);
			try {
				bool success;
				fixed (byte* pointer = buffer) {
					success = ReadProcessMemory(ProcessHandle, checked((IntPtr)span.Start), pointer, span.Length, out _);
				}

				Interlocked.Increment(ref readCalls);
				if (success) {
					foreach (int item in span.Items) {
						results[item] = MemoryMarshal.Read<T>(buffer.AsSpan((int)(addresses[item] - span.Start), size));
					}
				} else {
					foreach (int item in span.Items) {
						results[item] = Read<T>(addresses[item]);
					}
				}
			} finally {
				ArrayPool<byte>.Shared.Return(buffer);
			}
		}
	}

	public static unsafe T Read<T>(long address, bool relative = false, int size = 0) where T : unmanaged
	{
		Interlocked.Increment(ref readCalls);
		T value = default;
		ReadProcessMemory(ProcessHandle, checked((IntPtr)(relative ? address + MainModuleHandle : address)), &value, size == 0 ? sizeof(T) : size, out _);
		return value;
	}

	public static unsafe byte[] ReadBytes(long address, int size)
	{
		Interlocked.Increment(ref readCalls);
		byte[] buffer = new byte[size];
		fixed (byte* ptr = buffer) {
			ReadProcessMemory(ProcessHandle, checked((IntPtr)address), ptr, size, out _);
		}
		return buffer;
	}

	public static unsafe T[] ReadArray<T>(long address, int count, bool relative = false) where T : unmanaged
	{
		Interlocked.Increment(ref readCalls);
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

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static unsafe partial bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, void* lpBuffer, int nSize, out IntPtr lpNumberOfBytesRead);

	[LibraryImport("kernel32.dll")]
	private static partial IntPtr OpenProcess(uint processAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int processId);

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool CloseHandle(IntPtr handle);

	[LibraryImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool GetClientRect(IntPtr handle, out RECT rect);

	[LibraryImport("user32.dll")]
	private static partial IntPtr GetForegroundWindow();

	[LibraryImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool ClientToScreen(IntPtr hwnd, ref ScreenPoint point);

	[StructLayout(LayoutKind.Sequential)]
	private struct ScreenPoint
	{
		public int X;
		public int Y;
	}

	[LibraryImport("user32.dll", EntryPoint = "FindWindowW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	private static partial IntPtr FindWindow(string className, string windowName);

	[LibraryImport("user32.dll", SetLastError = true)]
	private static partial IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[LibraryImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool IsWindow(IntPtr hWnd);
}
