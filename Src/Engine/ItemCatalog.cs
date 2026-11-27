using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RiftAssistant.Engine;

internal enum ItemCatalogKind
{
	All,
	Legendary,
	Set
}

internal sealed record ItemCatalogEntry(string Name, string TypeName, bool IsSet, SnoItem Item);

internal static partial class ItemCatalog
{
	private static List<ItemCatalogEntry>? entries;
	private static Dictionary<string, ItemCatalogEntry>? byName;

	[GeneratedRegex(@"(^|_)(Unique|Set)_", RegexOptions.IgnoreCase)]
	private static partial Regex LegendaryCode();

	public static IReadOnlyList<ItemCatalogEntry> Entries => entries ??= Build();

	internal static void Reset()
	{
		entries = null;
		byName = null;
	}

	public static ItemCatalogEntry? Find(string name)
	{
		_ = Entries;
		return byName!.GetValueOrDefault(name ?? "");
	}

	public static List<ItemCatalogEntry> Search(string query, ItemCatalogKind kind)
	{
		var source = Entries.Where(entry => kind == ItemCatalogKind.All || entry.IsSet == (kind == ItemCatalogKind.Set));
		var words = (query ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
		var matches = source.Where(entry => words.All(word => entry.Name.Contains(word, StringComparison.OrdinalIgnoreCase) || entry.TypeName.Contains(word, StringComparison.OrdinalIgnoreCase)));
		return [.. matches.OrderByDescending(entry => words.Length > 0 && entry.Name.StartsWith(words[0], StringComparison.OrdinalIgnoreCase)).ThenBy(entry => entry.Name, StringComparer.OrdinalIgnoreCase)];
	}

	private static List<ItemCatalogEntry> Build()
	{
		var result = new Dictionary<string, ItemCatalogEntry>(StringComparer.OrdinalIgnoreCase);
		foreach (var item in SnoData.Items.All) {
			if (item.Kind != ItemKind.loot || string.IsNullOrWhiteSpace(item.NameEnglish) || !LegendaryCode().IsMatch(item.Code)) continue;

			string typeName = item.SnoItemType?.NameEnglish ?? item.MainGroupCode;
			result.TryAdd(item.NameEnglish, new ItemCatalogEntry(item.NameEnglish, typeName, item.SetItemBonusesSno != uint.MaxValue, item));
		}

		byName = result;
		return [.. result.Values.OrderBy(entry => entry.Name, StringComparer.OrdinalIgnoreCase)];
	}
}
