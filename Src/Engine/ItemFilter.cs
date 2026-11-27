using System;
using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal static class ItemFilter
{
	public static void Load()
	{
		ReevaluateItems();
	}

	public static void ReloadIfChanged()
	{
		ItemFilterStore.Tick();
		if (ItemFilterStore.TakeChanged()) ReevaluateItems();
	}

	public static ItemKeepDecision Evaluate(Item item)
	{
		if (item.Unidentified || item.SnoItem.SnoActor.Sno == ActorSnoEnum._demontrebuchetkey) return ItemKeepDecision.LooksGood;

		foreach (var entry in ItemFilterStore.Snapshot) {
			if (Matches(item, entry)) return entry.Decision == ItemFilterDecision.Sell ? ItemKeepDecision.DefinitelyBad : ItemKeepDecision.LooksGood;
		}

		return ItemKeepDecision.Irrelevant;
	}

	internal static bool Matches(Item item, ItemFilterEntry entry)
	{
		if (!entry.Enabled || entry.Item.Length == 0) return false;
		if (!string.Equals(item.SnoItem.NameEnglish, entry.Item, StringComparison.OrdinalIgnoreCase)) return false;
		if (entry.AncientOnly && item.AncientRank < 1) return false;

		foreach (var stat in entry.Stats) {
			var info = ItemFilterStats.Find(stat.Stat);
			if (info == null) return false;

			if (ItemFilterStats.UsesRoll(stat, info)) {
				if (!ItemRoll.TryGetPercent(item, info.Code, out double percent) || percent + 1e-9 < stat.Min) return false;
			} else {
				var value = item.StatList2.GetValueOrDefault(info.Code);
				if (value == null || value.DoubleValue + 1e-9 < stat.Min) return false;
			}
		}

		return true;
	}

	private static void ReevaluateItems()
	{
		if (CoreCollector.ItemCollector == null) return;

		foreach (var item in CoreCollector.ItemCollector.Items.Values) {
			item.KeepDecision = CoreCollector.ItemCollector.DecideKeep(item);
		}
	}
}
