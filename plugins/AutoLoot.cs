using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Plugins.Default;

internal class AutoLoot : BasePlugin, IKeyEventHandler, IItemPickedHandler
{
	private const int PickupTimeoutMs = 1500;

	private volatile Item itemToPick;
	private int running;

	public AutoLoot()
	{
		Enabled = true;
	}

	public void OnKeyEvent(InputEvent keyEvent)
	{
		if (!keyEvent.Is(Vk.F3, true)) return;
		if (Interlocked.Exchange(ref running, 1) == 1) return;

		var me = Assistant.Game.LocalPlayer.FloorCoordinate;
		var items = Assistant.Game.Items.Where(item => item.Location == ItemLocation.Floor).OrderBy(item => item.FloorCoordinate.XYDistanceTo(me)).ToList();
		var windowOffset = Assistant.Window.Offset;
		var windowSize = Assistant.Window.Size;
		Task.Run(async () => {
			try {
				await PickUpAsync(items, windowOffset, windowSize);
			} finally {
				Interlocked.Exchange(ref running, 0);
			}
		});
	}

	void IItemPickedHandler.OnItemPicked(Item item)
	{
		if (item != null && item == itemToPick) itemToPick = null;
	}

	private async Task PickUpAsync(List<Item> items, Point windowOffset, Size windowSize)
	{
		var originalPosition = Assistant.Input.GetMousePosition();
		try {
			foreach (var item in items) {
				if (item == null) continue;

				var pos = item.FloorCoordinate.ToScreenCoordinate();
				if (!float.IsFinite(pos.X) || !float.IsFinite(pos.Y)) continue;

				int screenX = windowOffset.X + (int)Math.Round(pos.X);
				int screenY = windowOffset.Y + (int)Math.Round(pos.Y);
				if (screenX < windowOffset.X || screenX > windowOffset.X + windowSize.Width) continue;
				if (screenY < windowOffset.Y || screenY > windowOffset.Y + windowSize.Height) continue;

				itemToPick = item;
				Assistant.Input.SetMousePosition(screenX, screenY);
				await Task.Delay(50);
				Assistant.Input.Click(Vk.LBUTTON);

				for (int waited = 0; itemToPick != null && waited < PickupTimeoutMs; waited += 50) {
					await Task.Delay(50);
				}

				itemToPick = null;
			}
		} finally {
			Assistant.Input.SetMousePosition(originalPosition.X, originalPosition.Y);
		}
	}
}
