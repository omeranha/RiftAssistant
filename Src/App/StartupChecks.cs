using System;
using System.IO;
using System.Linq;

namespace RiftAssistant;

internal sealed class StartupException(string message, Exception inner = null) : Exception(message, inner);

internal static class StartupChecks
{
	private const int MaxListedFiles = 8;

	private static readonly string[] RequiredDataFiles = [
		"actor_attribute_order_pri.bin",
		"actor_attribute_order_sec.bin",
		"actor_attributes.bin",
		"acts.bin",
		"experience_paragon.bin",
		"gamebalance_actor_inventory_index.bin",
		"gamebalance_item_affixes.bin",
		"gamebalance_item_socketed_effects.bin",
		"gamebalance_item_types.bin",
		"gamebalance_monster_affixes.bin",
		"gamebalance_power_formulas.bin",
		"power_formula_data.bin",
		"powers.bin",
		"resource_data.bin",
		"resource_index.bin",
		"scene.bin",
		"scene_cell.bin",
		"scene_square.bin",
		"strings_enUS.bin",
		"tagmap_powers.bin"
	];

	public static void Run()
	{
		string dataFolder = Path.Combine(Program.AppDir, "data");
		if (!Directory.Exists(dataFolder)) {
			throw new StartupException(
				$"The game data folder was not found.\n\nLooked for:\n{dataFolder}\n\nThe data folder is part of the release zip. Unzip the whole release into one folder and start RiftAssistant.exe from there, with the data folder next to it."
			);
		}

		var missing = RequiredDataFiles.Where(name => !File.Exists(Path.Combine(dataFolder, name))).ToList();
		if (missing.Count == 0) return;

		string listed = string.Join("\n", missing.Take(MaxListedFiles));
		string more = missing.Count > MaxListedFiles ? $"\n... and {missing.Count - MaxListedFiles} more" : "";
		throw new StartupException($"The game data folder is incomplete.\n\nFolder:\n{dataFolder}\n\nMissing files:\n{listed}{more}\n\nCopy the complete data folder from the release zip.");
	}
}
