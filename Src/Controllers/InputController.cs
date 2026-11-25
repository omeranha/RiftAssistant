using System.Drawing;
using System.Runtime.InteropServices;

namespace RiftAssistant.Controllers;

public partial class InputController
{
	private const uint InputMouse = 0;
	private const uint InputKeyboard = 1;
	private const uint KeyEventKeyUp = 0x0002;
	private const uint MouseLeftDown = 0x0002;
	private const uint MouseLeftUp = 0x0004;
	private const uint MouseRightDown = 0x0008;
	private const uint MouseRightUp = 0x0010;
	private const uint MouseMiddleDown = 0x0020;
	private const uint MouseMiddleUp = 0x0040;

	public bool IsKeyDown(Vk key)
	{
		return (GetAsyncKeyState((int)key) & 0x8000) != 0;
	}

	public Point GetMousePosition()
	{
		GetCursorPos(out var point);
		return new Point(point.X, point.Y);
	}

	public void SetMousePosition(int x, int y)
	{
		SetCursorPos(x, y);
	}

	public void Click(Vk button, bool hold = false)
	{
		var (down, up) = button switch {
			Vk.LBUTTON => (MouseLeftDown, MouseLeftUp),
			Vk.RBUTTON => (MouseRightDown, MouseRightUp),
			Vk.MBUTTON => (MouseMiddleDown, MouseMiddleUp),
			_ => (0u, 0u)
		};

		if (down == 0) return;

		if (hold) {
			Send(MouseEvent(down));
		} else {
			Send(MouseEvent(down), MouseEvent(up));
		}
	}

	public void PressKey(Vk key, bool release = true)
	{
		if (key is Vk.LBUTTON or Vk.RBUTTON or Vk.MBUTTON) {
			Click(key);
			return;
		}

		if (release) {
			Send(KeyEvent(key, false), KeyEvent(key, true));
		} else {
			Send(KeyEvent(key, false));
		}
	}

	public void ReleaseKey(Vk key)
	{
		Send(KeyEvent(key, true));
	}

	private static Input MouseEvent(uint flags)
	{
		return new Input { Type = InputMouse, Data = new InputData { Mouse = new MouseInput { Flags = flags } } };
	}

	private static Input KeyEvent(Vk key, bool up)
	{
		return new Input { Type = InputKeyboard, Data = new InputData { Keyboard = new KeyboardInput { VirtualKey = (ushort)key, Flags = up ? KeyEventKeyUp : 0 } } };
	}

	private static void Send(params Input[] inputs)
	{
		SendInput((uint)inputs.Length, inputs, Marshal.SizeOf<Input>());
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct Input
	{
		public uint Type;
		public InputData Data;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct InputData
	{
		[FieldOffset(0)]
		public MouseInput Mouse;

		[FieldOffset(0)]
		public KeyboardInput Keyboard;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct MouseInput
	{
		public int X;
		public int Y;
		public uint Data;
		public uint Flags;
		public uint Time;
		public nint ExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct KeyboardInput
	{
		public ushort VirtualKey;
		public ushort ScanCode;
		public uint Flags;
		public uint Time;
		public nint ExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct NativePoint
	{
		public int X;
		public int Y;
	}

	[LibraryImport("user32.dll")]
	private static partial uint SendInput(uint inputCount, Input[] inputs, int size);

	[LibraryImport("user32.dll")]
	private static partial short GetAsyncKeyState(int key);

	[LibraryImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool GetCursorPos(out NativePoint point);

	[LibraryImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool SetCursorPos(int x, int y);
}