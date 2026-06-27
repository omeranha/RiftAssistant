using SNO;
using work;

public readonly record struct InputBind(KeyBinding Key, Modifier Modifier);

internal class GameSettingsManager
{
	public bool IsForegroundFpsEnabled;

	public bool IsBackgroundFpsEnabled;

	public bool IsFullscreen;

	public WindowMode WindowMode;

	private FrameRateSettings frameRateSettings = new();

	private Class71 class71_0 = new();

	private VideoSettings videoSettings = new();

	private Class72 class72_0 = new();

	private Class73 class73_0 = new();

	public (InputBind Primary, InputBind Secondary)[] Keybinds = new (InputBind, InputBind)[75];

	internal void Refresh()
	{
		var hotkeys = new int[300];
		hotkeys = GameWindowManager.ReadArray<int>(AddressList.HotkeysAddress, hotkeys.Length, true);
		for (int i = 0; i < hotkeys.Length - 3; i += 4) {
			var key1 = new InputBind((KeyBinding)hotkeys[i], (Modifier)hotkeys[i + 1]);
			var key2 = new InputBind((KeyBinding)hotkeys[i + 2], (Modifier)hotkeys[i + 3]);
			Keybinds[i / 4] = (key1, key2);
		}
		frameRateSettings = GameWindowManager.Read<FrameRateSettings>(AddressList.ScreenSettingsAddress, true);
		IsForegroundFpsEnabled = frameRateSettings.ForegroundLimitEnabled;
		IsBackgroundFpsEnabled = frameRateSettings.BackgroundLimitEnabled;

		class71_0 = GameWindowManager.Read<Class71>(AddressList.long_10, true);

		videoSettings = GameWindowManager.Read<VideoSettings>(AddressList.long_8, true);
		IsFullscreen = videoSettings.bool_1;
		WindowMode = ((videoSettings.int_12 == 0) ? WindowMode.Windowed : videoSettings.windowMode_0);

		class72_0 = GameWindowManager.Read<Class72>(AddressList.long_11, true);

		class73_0 = GameWindowManager.Read<Class73>(AddressList.long_9, true);
	}

	public static Vk ToVk(KeyBinding keyBinding)
	{
		return keyBinding switch {
			KeyBinding.hkESCAPE => Vk.ESCAPE,
			KeyBinding.hk1 => Vk.D1,
			KeyBinding.hk2 => Vk.D2,
			KeyBinding.hk3 => Vk.D3,
			KeyBinding.hk4 => Vk.D4,
			KeyBinding.hk5 => Vk.D5,
			KeyBinding.hk6 => Vk.D6,
			KeyBinding.hk7 => Vk.D7,
			KeyBinding.hk8 => Vk.D8,
			KeyBinding.hk9 => Vk.D9,
			KeyBinding.hk0 => Vk.D0,
			KeyBinding.hkMINUS => Vk.OEM_MINUS,
			KeyBinding.hkEQUALS => Vk.OEM_PLUS,
			KeyBinding.hkBACK => Vk.BACK,
			KeyBinding.hkTAB => Vk.TAB,
			KeyBinding.hkQ => Vk.Q,
			KeyBinding.hkW => Vk.W,
			KeyBinding.hkE => Vk.E,
			KeyBinding.hkR => Vk.R,
			KeyBinding.hkT => Vk.T,
			KeyBinding.hkY => Vk.Y,
			KeyBinding.hkU => Vk.U,
			KeyBinding.hkI => Vk.I,
			KeyBinding.hkO => Vk.O,
			KeyBinding.hkP => Vk.P,
			KeyBinding.hkLBRACKET => Vk.OEM_4,
			KeyBinding.hkRBRACKET => Vk.OEM_6,
			KeyBinding.hkRETURN => Vk.RETURN,
			KeyBinding.hkLCONTROL => Vk.LCONTROL,
			KeyBinding.hkA => Vk.A,
			KeyBinding.hkS => Vk.S,
			KeyBinding.hkD => Vk.D,
			KeyBinding.hkF => Vk.F,
			KeyBinding.hkG => Vk.G,
			KeyBinding.hkH => Vk.H,
			KeyBinding.hkJ => Vk.J,
			KeyBinding.hkK => Vk.K,
			KeyBinding.hkL => Vk.L,
			KeyBinding.hkSEMICOLON => Vk.OEM_1,
			KeyBinding.hkAPOSTROPHE => Vk.OEM_7,
			KeyBinding.hkGRAVE => Vk.OEM_3,
			KeyBinding.hkLSHIFT => Vk.LSHIFT,
			KeyBinding.hkBACKSLASH => Vk.OEM_5,
			KeyBinding.hkZ => Vk.Z,
			KeyBinding.hkX => Vk.X,
			KeyBinding.hkC => Vk.C,
			KeyBinding.hkV => Vk.V,
			KeyBinding.hkB => Vk.B,
			KeyBinding.hkN => Vk.N,
			KeyBinding.hkM => Vk.M,
			KeyBinding.hkCOMMA => Vk.OEM_COMMA,
			KeyBinding.hkPERIOD => Vk.OEM_PERIOD,
			KeyBinding.hkSLASH => Vk.OEM_2,
			KeyBinding.hkRSHIFT => Vk.RSHIFT,
			KeyBinding.hkMULTIPLY => Vk.MULTIPLY,
			KeyBinding.hkLMENU => Vk.LMENU,
			KeyBinding.hkSPACE => Vk.SPACE,
			KeyBinding.hkCAPITAL => Vk.CAPITAL,
			KeyBinding.hkF1 => Vk.F1,
			KeyBinding.hkF2 => Vk.F2,
			KeyBinding.hkF3 => Vk.F3,
			KeyBinding.hkF4 => Vk.F4,
			KeyBinding.hkF5 => Vk.F5,
			KeyBinding.hkF6 => Vk.F6,
			KeyBinding.hkF7 => Vk.F7,
			KeyBinding.hkF8 => Vk.F8,
			KeyBinding.hkF9 => Vk.F9,
			KeyBinding.hkF10 => Vk.F10,
			KeyBinding.hkNUMLOCK => Vk.NUMLOCK,
			KeyBinding.hkSCROLL => Vk.SCROLL,
			KeyBinding.hkNUMPAD7 => Vk.NUMPAD7,
			KeyBinding.hkNUMPAD8 => Vk.NUMPAD8,
			KeyBinding.hkNUMPAD9 => Vk.NUMPAD9,
			KeyBinding.hkSUBTRACT => Vk.SUBTRACT,
			KeyBinding.hkNUMPAD4 => Vk.NUMPAD4,
			KeyBinding.hkNUMPAD5 => Vk.NUMPAD5,
			KeyBinding.hkNUMPAD6 => Vk.NUMPAD6,
			KeyBinding.hkADD => Vk.ADD,
			KeyBinding.hkNUMPAD1 => Vk.NUMPAD1,
			KeyBinding.hkNUMPAD2 => Vk.NUMPAD2,
			KeyBinding.hkNUMPAD3 => Vk.NUMPAD3,
			KeyBinding.hkNUMPAD0 => Vk.NUMPAD0,
			KeyBinding.hkDECIMAL => Vk.DECIMAL,
			KeyBinding.hkF11 => Vk.F11,
			KeyBinding.hkF12 => Vk.F12,
			KeyBinding.hkF13 => Vk.F13,
			KeyBinding.hkF14 => Vk.F14,
			KeyBinding.hkF15 => Vk.F15,
			KeyBinding.hkNUMPADENTER => Vk.RETURN,
			KeyBinding.hkRCONTROL => Vk.RCONTROL,
			KeyBinding.hkMUTE => Vk.VOLUME_MUTE,
			KeyBinding.hkPLAYPAUSE => Vk.MEDIA_PLAY_PAUSE,
			KeyBinding.hkMEDIASTOP => Vk.MEDIA_STOP,
			KeyBinding.hkVOLUMEDOWN => Vk.VOLUME_DOWN,
			KeyBinding.hkVOLUMEUP => Vk.VOLUME_UP,
			KeyBinding.hkDIVIDE => Vk.DIVIDE,
			KeyBinding.hkRMENU => Vk.RMENU,
			KeyBinding.hkPAUSE => Vk.PAUSE,
			KeyBinding.hkHOME => Vk.HOME,
			KeyBinding.hkUP => Vk.UP,
			KeyBinding.hkPRIOR => Vk.PRIOR,
			KeyBinding.hkLEFT => Vk.LEFT,
			KeyBinding.hkRIGHT => Vk.RIGHT,
			KeyBinding.hkEND => Vk.END,
			KeyBinding.hkDOWN => Vk.DOWN,
			KeyBinding.hkNEXT => Vk.NEXT,
			KeyBinding.hkINSERT => Vk.INSERT,
			KeyBinding.hkDELETE => Vk.DELETE,
			KeyBinding.hkLWIN => Vk.LWIN,
			KeyBinding.hkRWIN => Vk.RWIN,
			KeyBinding.hkAPPS => Vk.APPS,
			KeyBinding.hkWEBBACK => Vk.BROWSER_BACK,
			KeyBinding.hkWEBFORWARD => Vk.BROWSER_FORWARD,
			KeyBinding.hkMouse1 => Vk.LBUTTON,
			KeyBinding.hkMouse2 => Vk.RBUTTON,
			KeyBinding.hkMouse3 => Vk.MBUTTON,
			KeyBinding.hkMouse4 => Vk.XBUTTON1,
			KeyBinding.hkMouse5 => Vk.XBUTTON2,
			_ => Vk.None
		};
	}
}