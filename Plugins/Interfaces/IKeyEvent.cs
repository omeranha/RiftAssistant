namespace Plugins;

public interface IKeyEvent
{
	bool Down { get; }

	Vk Key { get; }

	bool Shift { get; }

	bool Ctrl { get; }

	bool Alt { get; }

	public bool Is(Vk key, bool down)
	{
		return Key == key && Down == down;
	}

	public bool Is(Vk key, bool down, bool shift, bool ctrl, bool alt)
	{
		return Key == key && Down == down && Shift == shift && Ctrl == ctrl && Alt == alt;
	}
}