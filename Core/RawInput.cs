using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;


internal static unsafe class RawInput
{
	private const int WM_INPUT = 0x00FF;

	private const uint RID_INPUT = 0x10000003;

	private const int RIM_TYPEMOUSE = 0;
	private const int RIM_TYPEKEYBOARD = 1;

	private const int RIDEV_INPUTSINK = 0x00000100;

	private const ushort RI_MOUSE_LEFT_BUTTON_DOWN = 0x0001;
	private const ushort RI_MOUSE_LEFT_BUTTON_UP = 0x0002;

	private const ushort RI_MOUSE_RIGHT_BUTTON_DOWN = 0x0004;
	private const ushort RI_MOUSE_RIGHT_BUTTON_UP = 0x0008;

	private const ushort RI_MOUSE_MIDDLE_BUTTON_DOWN = 0x0010;
	private const ushort RI_MOUSE_MIDDLE_BUTTON_UP = 0x0020;

	private const ushort RI_MOUSE_BUTTON_4_DOWN = 0x0040;
	private const ushort RI_MOUSE_BUTTON_4_UP = 0x0080;

	private const ushort RI_MOUSE_BUTTON_5_DOWN = 0x0100;
	private const ushort RI_MOUSE_BUTTON_5_UP = 0x0200;

	private const int WM_KEYDOWN = 0x0100;
	private const int WM_KEYUP = 0x0101;
	private const int WM_SYSKEYDOWN = 0x0104;
	private const int WM_SYSKEYUP = 0x0105;

	public static event Action<InputEvent> KeyboardEvent;
	public static event Action<InputEvent> MouseEvent;

	private static Thread thread;
	private static uint threadId;
	private static IntPtr hwnd;

	public static void Start()
	{
		if (thread != null) return;

		thread = new Thread(MessageLoop) {
			IsBackground = true,
			Name = "RawInputThread"
		};

		thread.Start();
	}

	private static void MessageLoop()
	{
		threadId = GetCurrentThreadId();

		WNDCLASSEX wc = new() {
			cbSize = (uint)Marshal.SizeOf<WNDCLASSEX>(),
			lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_wndProc),
			lpszClassName = "RawInputWindow"
		};

		RegisterClassEx(ref wc);
		hwnd = CreateWindowEx(0, wc.lpszClassName, "", 0, 0, 0, 0, 0, HWND_MESSAGE, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		RegisterRawDevices(hwnd);
		while (GetMessage(out MSG msg, IntPtr.Zero, 0, 0) != 0) {
			TranslateMessage(ref msg);
			DispatchMessage(ref msg);
		}
	}

	private static void RegisterRawDevices(IntPtr hwnd)
	{
		RAWINPUTDEVICE* devices = stackalloc RAWINPUTDEVICE[2];

		devices[0] = new RAWINPUTDEVICE {
			usUsagePage = 0x01,
			usUsage = 0x06,
			dwFlags = RIDEV_INPUTSINK,
			hwndTarget = hwnd
		};

		devices[1] = new RAWINPUTDEVICE {
			usUsagePage = 0x01,
			usUsage = 0x02,
			dwFlags = RIDEV_INPUTSINK,
			hwndTarget = hwnd
		};

		RegisterRawInputDevices(devices, 2, (uint)sizeof(RAWINPUTDEVICE));
	}

	private static readonly WndProc _wndProc = WndProcImpl;

	private static IntPtr WndProcImpl(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam) 
	{
		if (msg == WM_INPUT) ProcessRawInput(lParam);

		return DefWindowProc(hwnd, msg, wParam, lParam);
	}

	private static void ProcessRawInput(IntPtr hRawInput)
	{
		if (!GameWindowManager.Window.IsForeground) return;

		uint size = 0;
		GetRawInputData(hRawInput, RID_INPUT, IntPtr.Zero, ref size, (uint)sizeof(RAWINPUTHEADER));

		byte* buffer = stackalloc byte[(int)size];
		if (GetRawInputData(hRawInput, RID_INPUT, (IntPtr)buffer, ref size, (uint)sizeof(RAWINPUTHEADER)) != size) return;

		RAWINPUT* raw = (RAWINPUT*)buffer;
		switch (raw->header.dwType) {
			case RIM_TYPEKEYBOARD:
				ProcessKeyboard(raw);
				break;

			case RIM_TYPEMOUSE:
				ProcessMouse(raw);
				break;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void ProcessKeyboard(RAWINPUT* raw)
	{
		var k = raw->data.keyboard;
		int vk = NormalizeVk(k.VKey, k.Flags);
		bool down = k.Message == WM_KEYDOWN || k.Message == WM_SYSKEYDOWN;
		bool shift = IsKeyDown(Vk.LSHIFT) || IsKeyDown(Vk.RSHIFT);
		bool ctrl = IsKeyDown(Vk.LCONTROL) || IsKeyDown(Vk.RCONTROL);
		bool alt = IsKeyDown(Vk.LMENU) || IsKeyDown(Vk.RMENU);
		KeyboardEvent?.Invoke(new InputEvent((Vk)vk, down, shift, ctrl, alt));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int NormalizeVk(int vk, ushort flags)
	{
		if (vk == 16) return (flags & 0x02) != 0 ? (int)Vk.RSHIFT : (int)Vk.LSHIFT;
		if (vk == 17) return (flags & 0x02) != 0 ? (int)Vk.RCONTROL : (int)Vk.LCONTROL;
		if (vk == 18) return (flags & 0x02) != 0 ? (int)Vk.RMENU : (int)Vk.LMENU;
		return vk;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void ProcessMouse(RAWINPUT* raw)
	{
		ref var m = ref raw->data.mouse;
		ushort f = m.usButtonFlags;

		if ((f & RI_MOUSE_LEFT_BUTTON_DOWN) != 0) MouseEvent?.Invoke(new InputEvent(Vk.LBUTTON, true));

		if ((f & RI_MOUSE_LEFT_BUTTON_UP) != 0) MouseEvent?.Invoke(new InputEvent(Vk.LBUTTON, false));

		if ((f & RI_MOUSE_RIGHT_BUTTON_DOWN) != 0) MouseEvent?.Invoke(new InputEvent(Vk.RBUTTON, true));

		if ((f & RI_MOUSE_RIGHT_BUTTON_UP) != 0) MouseEvent?.Invoke(new InputEvent(Vk.RBUTTON, false));
	}

	private static readonly IntPtr HWND_MESSAGE = new(-3);

	private delegate IntPtr WndProc(IntPtr hwnd,uint msg,IntPtr wParam,IntPtr lParam);

	[StructLayout(LayoutKind.Sequential)]
	private struct WNDCLASSEX
	{
		public uint cbSize;
		public uint style;
		public IntPtr lpfnWndProc;
		public int cbClsExtra;
		public int cbWndExtra;
		public IntPtr hInstance;
		public IntPtr hIcon;
		public IntPtr hCursor;
		public IntPtr hbrBackground;
		public string lpszMenuName;
		public string lpszClassName;
		public IntPtr hIconSm;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct MSG
	{
		public IntPtr hwnd;
		public uint message;
		public nuint wParam;
		public nint lParam;
		public uint time;
		public POINT pt;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct POINT
	{
		public int X;
		public int Y;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct RAWINPUTDEVICE
	{
		public ushort usUsagePage;
		public ushort usUsage;
		public int dwFlags;
		public IntPtr hwndTarget;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct RAWINPUTHEADER
	{
		public uint dwType;
		public uint dwSize;
		public IntPtr hDevice;
		public IntPtr wParam;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct RAWINPUT
	{
		public RAWINPUTHEADER header;
		public RAWINPUTUNION data;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct RAWINPUTUNION
	{
		[FieldOffset(0)]
		public RAWMOUSE mouse;

		[FieldOffset(0)]
		public RAWKEYBOARD keyboard;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct RAWMOUSE
	{
		[FieldOffset(0)]
		public ushort usFlags;

		[FieldOffset(4)]
		public uint ulButtons;

		[FieldOffset(4)]
		public ushort usButtonFlags;

		[FieldOffset(6)]
		public ushort usButtonData;

		[FieldOffset(8)]
		public uint ulRawButtons;

		[FieldOffset(12)]
		public int lLastX;

		[FieldOffset(16)]
		public int lLastY;

		[FieldOffset(20)]
		public uint ulExtraInformation;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct RAWKEYBOARD
	{
		public ushort MakeCode;
		public ushort Flags;
		public ushort Reserved;
		public ushort VKey;
		public uint Message;
		public uint ExtraInformation;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern ushort RegisterClassEx(ref WNDCLASSEX lpwcx);

	[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
	private static extern IntPtr CreateWindowEx(int exStyle, string className, string windowName, int style, int x, int y, int width, int height, IntPtr parent, IntPtr menu, IntPtr instance, IntPtr param);

	[DllImport("user32.dll")]
	private static extern bool RegisterRawInputDevices(RAWINPUTDEVICE* devices, uint numDevices, uint size);

	[DllImport("user32.dll")]
	private static extern uint GetRawInputData(IntPtr hRawInput, uint command, IntPtr data, ref uint size, uint headerSize);

	[DllImport("user32.dll")]
	private static extern sbyte GetMessage(out MSG msg, IntPtr hwnd, uint min, uint max);

	[DllImport("user32.dll")]
	private static extern bool TranslateMessage(ref MSG msg);

	[DllImport("user32.dll")]
	private static extern IntPtr DispatchMessage(ref MSG msg);

	[DllImport("user32.dll")]
	private static extern IntPtr DefWindowProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll")]
	private static extern uint GetCurrentThreadId();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetAsyncKeyState(int vKey);

	private static bool IsKeyDown(Vk vk) => (GetAsyncKeyState((int)vk) & 0x8000) != 0;
}
