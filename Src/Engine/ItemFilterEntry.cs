using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal enum ItemFilterDecision
{
	Keep,
	Sell
}

internal enum ItemFilterMeasure
{
	Roll,
	Value
}

internal sealed class ItemFilterFile
{
	public List<ItemFilterEntry> Filters { get; set; } = [];
}

internal sealed class ItemFilterEntry
{
	public string Item { get; set; } = "";
	public bool Enabled { get; set; } = true;
	public ItemFilterDecision Decision { get; set; } = ItemFilterDecision.Keep;
	public bool AncientOnly { get; set; }
	public List<ItemFilterStatEntry> Stats { get; set; } = [];
}

internal sealed class ItemFilterStatEntry
{
	public string Stat { get; set; } = "";
	// Roll is the default so files saved before this property existed keep their meaning.
	public ItemFilterMeasure Measure { get; set; } = ItemFilterMeasure.Roll;
	public double Min { get; set; }
}
