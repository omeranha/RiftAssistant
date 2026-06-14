using Plugins;

public readonly struct InputEvent : IKeyEvent
{
	public readonly Vk Key;
	public readonly bool Down;
	public readonly bool Shift;
	public readonly bool Ctrl;
	public readonly bool Alt;

	Vk IKeyEvent.Key => Key;
	bool IKeyEvent.Down => Down;
	bool IKeyEvent.Shift => Shift;
	bool IKeyEvent.Ctrl => Ctrl;
	bool IKeyEvent.Alt => Alt;

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
}
