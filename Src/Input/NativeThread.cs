using System;
using System.Runtime.InteropServices;

namespace RiftAssistant.Input;

internal static partial class NativeThread
{
	private const uint WM_QUIT = 0x0012;

	public static readonly TimeSpan JoinTimeout = TimeSpan.FromMilliseconds(500);

	[LibraryImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
	public static partial uint CurrentId();

	[LibraryImport("user32.dll", EntryPoint = "PostThreadMessageW", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool PostThreadMessage(uint threadId, uint message, nuint wParam, nint lParam);

	public static void RequestQuit(uint threadId)
	{
		PostThreadMessage(threadId, WM_QUIT, 0, 0);
	}
}
