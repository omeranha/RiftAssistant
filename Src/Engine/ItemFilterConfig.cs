using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal enum ItemFilterDecision
{
	Keep,
	Sell
}

internal sealed class ItemFilterConfig
{
	public Dictionary<string, string> Definitions { get; set; } = [];
	public List<ItemFilterRuleConfig> Rules { get; set; } = [];
}

internal sealed class ItemFilterRuleConfig
{
	public string Comment { get; set; }
	public string Group { get; set; } = "all";
	public ItemFilterDecision Decision { get; set; } = ItemFilterDecision.Keep;
	public bool Enabled { get; set; } = true;
	public List<string> Conditions { get; set; } = [];
}
