public readonly struct InputEvent
{
	public readonly Vk Key;
	public readonly bool Down;
	public readonly bool Shift;
	public readonly bool Ctrl;
	public readonly bool Alt;

	public InputEvent(Vk key, bool down)
	{
		Key = key;
		Down = down;
	}

	public InputEvent(Vk key, bool down, bool shift, bool ctrl, bool alt)
	{
		Key = key;
		Down = down;
		Shift = shift;
		Ctrl = ctrl;
		Alt = alt;
	}

	public bool Is(Vk key, bool down)
	{
		return Key == key && Down == down;
	}

	public bool Is(Vk key, bool down, bool shift, bool ctrl, bool alt)
	{
		return Key == key && Down == down && Shift == shift && Ctrl == ctrl && Alt == alt;
	}
}
