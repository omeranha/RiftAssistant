using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Plugins.Default;

// F4 at the blacksmith: the bulk buttons clear normal, magic and rare items, then each legendary item the item filter does not keep is salvaged one by one.
internal class SalvageInventory : BasePlugin, IKeyEventHandler
{
	private int running;

	[PluginSetting("Bulk-salvage normal, magic, rare")]
	public bool UseBulkButtons { get; set; } = true;

	[PluginSetting("Salvage items no filter mentions")]
	public bool SalvageUnlistedItems { get; set; } = true;

	[PluginSetting("Include legendary items")]
	public bool SalvageLegendaries { get; set; } = true;

	public SalvageInventory()
	{
		Enabled = true;
	}

	public void OnKeyEvent(InputEvent keyEvent)
	{
		if (!keyEvent.Is(Vk.F4, true)) return;
		if (Interlocked.Exchange(ref running, 1) == 1) return;

		Task.Run(async () => {
			try {
				await SalvageAsync();
			} finally {
				Interlocked.Exchange(ref running, 0);
			}
		});
	}

	private bool IsUnwanted(Item item)
	{
		if (item.KeepDecision == ItemKeepDecision.LooksGood) return false;
		if (item.KeepDecision == ItemKeepDecision.DefinitelyBad) return true;

		return SalvageUnlistedItems;
	}

	private List<Item> FindItems()
	{
		return Assistant.Game.Items
			.Where(item => item.Location == ItemLocation.Inventory && item.InventoryX >= 0 && item.InventoryY >= 0)
			.Where(item => item.SnoItem.Kind == ItemKind.loot && !item.Unidentified && !item.IsInventoryLocked)
			.Where(item => (item.IsLegendary && SalvageLegendaries) || ((item.IsNormal || item.IsMagic || item.IsRare) && !UseBulkButtons))
			.Where(IsUnwanted)
			.OrderBy(item => item.InventoryY)
			.ThenBy(item => item.InventoryX)
			.ToList();
	}

	private async Task SalvageAsync()
	{
		var render = Assistant.Render;
		if (!render.SalvageRare.Visible) return;

		var originalPosition = Assistant.Input.GetMousePosition();
		var salvageButton = render.SalvageButton.Rectangle;
		bool salvageModeOn = false;
		try {
			if (UseBulkButtons) {
				foreach (var button in new[] { render.SalvageRare, render.SalvageMagic, render.SalvageNormal }) {
					var rectangle = button.Rectangle;
					await ClickAsync((int)rectangle.X + 10, (int)rectangle.Y + 10);
					await ConfirmAsync(false);
				}
			}

			var items = FindItems();
			if (items.Count == 0) return;

			await ClickAsync((int)salvageButton.X + 10, (int)salvageButton.Y + 10);
			salvageModeOn = true;
			await ConfirmAsync(false);

			foreach (Item item in items) {
				if (!render.SalvageRare.Visible) return;

				var rect = Assistant.Inventory.GetItemRect(item);
				if (rect == System.Drawing.RectangleF.Empty) continue;

				await ClickAsync((int)(rect.X + 10), (int)(rect.Y + 10));
				await ConfirmAsync(item.IsLegendary);
			}
		} finally {
			if (render.SalvageRare.Visible && salvageModeOn) {
				Assistant.Input.SetMousePosition((int)salvageButton.X + 10, (int)salvageButton.Y + 10);
				Assistant.Input.Click(Vk.LBUTTON);
			}

			Assistant.Input.SetMousePosition(originalPosition.X, originalPosition.Y);
		}
	}

	private async Task ClickAsync(int x, int y)
	{
		Assistant.Input.SetMousePosition(x, y);
		Assistant.Input.Click(Vk.LBUTTON);
		await Task.Delay(50);
	}

	// Only legendary items are expected to ask for confirmation. Pressing Enter without a dialog would open the chat.
	private async Task ConfirmAsync(bool expectDialog)
	{
		int waited = 0;
		while (!Assistant.Render.IsConfirmationDialogVisible()) {
			if (!expectDialog || waited >= 300) return;

			await Task.Delay(25);
			waited += 25;
		}

		Assistant.Input.PressKey(Vk.RETURN);
		await Task.Delay(25);
	}
}
