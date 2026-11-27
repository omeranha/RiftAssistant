using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RiftAssistant.Rendering;

internal sealed class ItemFilterMenu : MenuWindow
{
	private static readonly TimeSpan DeleteConfirmWindow = TimeSpan.FromSeconds(4);
	private static readonly string[] KindLabels = ["All", "Legendary", "Set"];
	private static readonly string[] CategoryLabels = ["All", "Main", "Offense", "Defense", "Resource", "Utility"];

	private enum View
	{
		List,
		Edit,
		ItemPicker,
		StatPicker
	}

	private readonly MenuSearchBox searchBox;

	private int storeVersion = -1;
	private View view = View.List;
	private ItemFilterEntry? editing;
	private ItemFilterStatEntry? replacingStat;
	private string query = "";
	private ItemCatalogKind kind = ItemCatalogKind.All;
	private int categoryTab;
	private ItemFilterEntry? deleteArmed;
	private long deleteArmedAt;

	public ItemFilterMenu() : base(380, 0, 0, 400)
	{
		searchBox = new MenuSearchBox("Search", () => query, value => {
			query = value;
			ScrollToTop();
		});
	}

	protected override string Title => view switch {
		View.Edit => "Edit filter",
		View.ItemPicker => "Choose an item",
		View.StatPicker => "Choose a stat",
		_ => "Item filter"
	};

	protected override bool CanGoBack => view != View.List;

	protected override bool NeedsRebuild => storeVersion != ItemFilterStore.Version;

	protected override void OnVisibleChanged(bool isVisible)
	{
		if (!isVisible) return;

		view = View.List;
		editing = null;
	}

	protected override void OnBack()
	{
		KeyboardCapture.End();
		switch (view) {
			case View.ItemPicker when editing is { Item.Length: 0 }:
				ItemFilterStore.Remove(editing);
				editing = null;
				view = View.List;
				break;
			case View.ItemPicker or View.StatPicker:
				view = View.Edit;
				break;
			default:
				editing = null;
				view = View.List;
				break;
		}

		ScrollToTop();
	}

	protected override void BuildPinned(List<IUIComponent> rows)
	{
		storeVersion = ItemFilterStore.Version;
		if (view is View.Edit && (editing == null || !ItemFilterStore.Snapshot.Contains(editing))) view = View.List;
		if (view is View.StatPicker && editing == null) view = View.List;

		switch (view) {
			case View.List:
				rows.Add(new MenuHint(ItemFilterStore.Count == 0 ? "No filters yet. A filter marks matching items as keep or sell." : "Checked from top to bottom. The first match wins."));
				rows.Add(new MenuActionButton(() => "+ Add filter", AddFilter, MenuColor.Positive));
				break;
			case View.Edit:
				rows.Add(new FilterTitleRow(editing!, () => OpenItemPicker(editing!)));
				break;
			case View.ItemPicker:
				rows.Add(new MenuTabRow(KindLabels, () => (int)kind, index => {
					kind = (ItemCatalogKind)index;
					ScrollToTop();
				}));
				rows.Add(searchBox);
				break;
			case View.StatPicker:
				rows.Add(new MenuTabRow(CategoryLabels, () => categoryTab, index => {
					categoryTab = index;
					ScrollToTop();
				}));
				rows.Add(searchBox);
				break;
		}
	}

	protected override void BuildContent(List<IUIComponent> rows)
	{
		switch (view) {
			case View.Edit:
				BuildEdit(rows, editing!);
				break;
			case View.ItemPicker:
				BuildItemPicker(rows);
				break;
			case View.StatPicker:
				BuildStatPicker(rows, editing!);
				break;
			default:
				BuildList(rows);
				break;
		}
	}

	private void BuildList(List<IUIComponent> rows)
	{
		foreach (var entry in ItemFilterStore.Snapshot) {
			var current = entry;
			rows.Add(new FilterListRow(current, () => OpenEditor(current), () => SetEnabled(current), () => ItemFilterStore.Move(current, -1), () => ItemFilterStore.Move(current, 1)));
		}
	}

	private void BuildEdit(List<IUIComponent> rows, ItemFilterEntry entry)
	{
		rows.Add(new FilterDecisionRow(() => entry.Decision, decision => {
			entry.Decision = decision;
			ItemFilterStore.Touch();
		}));
		rows.Add(new SettingToggleRow("Ancient or primal only", () => entry.AncientOnly, value => {
			entry.AncientOnly = value;
			ItemFilterStore.Touch();
		}));
		rows.Add(new SettingToggleRow("Enabled", () => entry.Enabled, value => {
			entry.Enabled = value;
			ItemFilterStore.Touch();
		}));

		rows.Add(new MenuHeading("Stats (all must match)"));
		if (entry.Stats.Count == 0) rows.Add(new MenuHint("No stats: any item with this name matches."));
		foreach (var stat in entry.Stats) {
			var current = stat;
			rows.Add(new FilterStatRow(current, () => OpenStatPicker(entry, current), direction => ReplaceStat(entry, current, ItemFilterStats.Step(current, direction)), () => ReplaceStat(entry, current, ItemFilterStats.SwitchMeasure(current)),
				value => ReplaceStat(entry, current, ItemFilterStats.Change(current, value)), () => RemoveStat(entry, current)));
		}

		rows.Add(new MenuActionButton(() => "+ Add stat", () => OpenStatPicker(entry, null), MenuColor.Positive));
		rows.Add(new MenuHint("Click the unit tag to switch between the item's value"));
		rows.Add(new MenuHint("and its roll (percent of the affix range)."));
		rows.Add(new MenuHint("Click a number to type it, Enter confirms."));
		rows.Add(new MenuActionButton(() => deleteArmed == entry && IsDeleteArmed() ? "Click again to delete this filter" : "Delete filter", () => Delete(entry), MenuColor.Negative));
	}

	private void BuildItemPicker(List<IUIComponent> rows)
	{
		var matches = ItemCatalog.Search(query, kind);
		var target = editing;
		if (matches.Count == 0) rows.Add(new MenuHint("Nothing matches."));
		foreach (var match in matches) {
			var current = match;
			rows.Add(new ItemChoiceRow(current, () => ChooseItem(target, current)));
		}
	}

	private void BuildStatPicker(List<IUIComponent> rows, ItemFilterEntry entry)
	{
		var used = entry.Stats.Where(stat => stat != replacingStat).Select(stat => stat.Stat).ToHashSet(StringComparer.OrdinalIgnoreCase);
		var words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		var matches = ItemFilterStats.All.Where(info => (categoryTab == 0 || (int)info.Category == categoryTab - 1) && !used.Contains(info.Code) && words.All(word => StatSearchText(info).Contains(word, StringComparison.OrdinalIgnoreCase))).ToList();
		if (matches.Count == 0) rows.Add(new MenuHint("Nothing matches."));
		foreach (var match in matches) {
			var current = match;
			rows.Add(new StatChoiceRow(current, () => ChooseStat(entry, current)));
		}
	}

	private static string StatSearchText(ItemFilterStatInfo info)
	{
		return $"{info.Label} {info.Code} {(info.IsPercent ? "percent %" : "number flat")} {info.Category}";
	}

	private void AddFilter()
	{
		OpenItemPicker(ItemFilterStore.Add());
	}

	private void OpenEditor(ItemFilterEntry entry)
	{
		editing = entry;
		view = View.Edit;
		ScrollToTop();
	}

	private void SetEnabled(ItemFilterEntry entry)
	{
		entry.Enabled = !entry.Enabled;
		ItemFilterStore.Touch();
	}

	private void OpenItemPicker(ItemFilterEntry entry)
	{
		editing = entry;
		view = View.ItemPicker;
		query = "";
		ScrollToTop();
		searchBox.StartEditing();
	}

	private void OpenStatPicker(ItemFilterEntry entry, ItemFilterStatEntry? replaces)
	{
		editing = entry;
		replacingStat = replaces;
		view = View.StatPicker;
		query = "";
		categoryTab = 0;
		ScrollToTop();
		searchBox.StartEditing();
	}

	private void ChooseItem(ItemFilterEntry? entry, ItemCatalogEntry choice)
	{
		KeyboardCapture.End();
		if (entry != null) {
			entry.Item = choice.Name;
			ItemFilterStore.Touch();
		}

		view = View.Edit;
		ScrollToTop();
	}

	private void ChooseStat(ItemFilterEntry entry, ItemFilterStatInfo info)
	{
		KeyboardCapture.End();
		var created = ItemFilterStats.Create(info);
		// The evaluator reads Stats from another thread, so the list is replaced instead of changed in place.
		entry.Stats = replacingStat == null ? [.. entry.Stats, created] : [.. entry.Stats.Select(stat => stat == replacingStat ? created : stat)];
		replacingStat = null;
		ItemFilterStore.Touch();
		view = View.Edit;
		ScrollToTop();
	}

	private static void ReplaceStat(ItemFilterEntry entry, ItemFilterStatEntry old, ItemFilterStatEntry replacement)
	{
		entry.Stats = [.. entry.Stats.Select(stat => stat == old ? replacement : stat)];
		ItemFilterStore.Touch();
	}

	private static void RemoveStat(ItemFilterEntry entry, ItemFilterStatEntry stat)
	{
		entry.Stats = [.. entry.Stats.Where(current => current != stat)];
		ItemFilterStore.Touch();
	}

	private void Delete(ItemFilterEntry entry)
	{
		if (deleteArmed == entry && IsDeleteArmed()) {
			deleteArmed = null;
			editing = null;
			view = View.List;
			ItemFilterStore.Remove(entry);
			ScrollToTop();
			return;
		}

		deleteArmed = entry;
		deleteArmedAt = Stopwatch.GetTimestamp();
	}

	private bool IsDeleteArmed()
	{
		return deleteArmed != null && Stopwatch.GetElapsedTime(deleteArmedAt) < DeleteConfirmWindow;
	}
}
