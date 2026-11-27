using System;
using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal static class ItemRoll
{
	private static readonly string[] MainStatCodes = ["str", "dex", "int"];

	// Percent of the affix roll range: (value - min) / (max - min) * 100. Ancient items can exceed 100.
	public static bool TryGetPercent(Item item, string statCode, out double percent)
	{
		percent = 0;
		if (item.Affixes == null || item.Affixes.Length == 0) return false;

		if (string.Equals(statCode, "main_stat", StringComparison.OrdinalIgnoreCase)) {
			bool found = false;
			foreach (string code in MainStatCodes) {
				if (!TryGetPercent(item, code, out double candidate)) continue;

				if (!found || candidate > percent) percent = candidate;
				found = true;
			}

			return found;
		}

		var processor = SnoData.Attributes.GetAttributeProcessor(statCode);
		if (processor?.Attribute == null) return false;

		double total = 0;
		double min = 0;
		double max = 0;
		bool matched = false;
		foreach (var stat in item.StatList2.Values) {
			if (stat.Processor != null || stat.Attribute == null || stat.Attribute.Code != processor.Attribute.Code) continue;
			if (processor.Modifier != uint.MaxValue && stat.Modifier != processor.Modifier) continue;

			total += stat.DoubleValue;
			foreach (var affix in item.Affixes) {
				if (affix.Mods == null) continue;

				foreach (var mod in affix.Mods) {
					if (mod.Attribute?.Code != stat.Attribute.Code || mod.Modifier != stat.Modifier || mod.Max <= mod.Min) continue;

					min += mod.Min;
					max += mod.Max;
					matched = true;
				}
			}
		}

		if (!matched) return false;

		percent = (total - min) / (max - min) * 100.0;
		return true;
	}
}
