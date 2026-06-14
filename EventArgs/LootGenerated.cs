using System;
using Plugins;

internal class LootGenerated : EventArgs
{
	public IItem item;

	public bool gambled;
}
