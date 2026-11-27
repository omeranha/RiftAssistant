using System.Diagnostics;
using System;
using System.Globalization;
using System.Linq;

namespace Plugins.Default;

public class InventoryAndStash : BasePlugin, IInGameTopPainter
{
	public IBrush ShadowBrush { get; set; }
	public IFont HoradricCacheFont { get; set; }
	public IBrush KeepBrush { get; set; }
	public IBrush ForceSellBrush { get; set; }
	public IBrush DarkenBrush { get; set; }
	public IFont QuantityFont { get; set; }
	public IBrush InventoryLockBorderBrush { get; set; }

	[PluginSetting("Mark items to keep (green)")]
	public bool LooksGoodDisplayEnabled { get; set; }

	[PluginSetting("Darken items not to keep")]
	public bool NotGoodDisplayEnabled { get; set; } = false;

	[PluginSetting("Mark items to sell (red X)")]
	public bool DefinitelyBadDisplayEnabled { get; set; }

	public bool HoradricCacheEnabled { get; set; } = true;
	public bool CanCubedEnabled { get; set; } = true;

	public bool AncientRankEnabled { get; set; } = true;
	public IFont AncientRankFont { get; set; }
	public IFont PrimalRankFont { get; set; }

	public bool CaldesannRankEnabled { get; set; } = true;

	public bool SocketedLegendaryGemRankEnabled { get; set; } = true;
	public IFont SocketedLegendaryGemRankFont { get; set; }

	private Stopwatch _watch;

	public InventoryAndStash()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		ShadowBrush = Assistant.Render.CreateBrush(175, 0, 0, 0, -1.6f);
		HoradricCacheFont = Assistant.Render.CreateFont("tahoma", 8, 255, 255, 255, 255, false, false, false);
		HoradricCacheFont.SetShadowBrush(128, 0, 0, 0, true);
		KeepBrush = Assistant.Render.CreateBrush(255, 128, 255, 84, -1.6f);
		ForceSellBrush = Assistant.Render.CreateBrush(255, 255, 0, 0, -1.6f);
		DarkenBrush = Assistant.Render.CreateBrush(178, 38, 38, 38, 0);

		AncientRankFont = Assistant.Render.CreateFont("arial", 7, 255, 0, 0, 0, true, false, 220, 227, 153, 25, true);
		PrimalRankFont = Assistant.Render.CreateFont("arial", 7, 255, 0, 0, 0, true, false, 180, 255, 64, 64, true);

		SocketedLegendaryGemRankFont = Assistant.Render.CreateFont("arial", 7, 255, 0, 0, 0, true, false, false);
		SocketedLegendaryGemRankFont.SetShadowBrush(128, 240, 240, 64, true);

		QuantityFont = Assistant.Render.CreateFont("tahoma", 8, 255, 200, 200, 200, false, false, false);
		QuantityFont.SetShadowBrush(128, 0, 0, 0, true);

		InventoryLockBorderBrush = Assistant.Render.CreateBrush(100, 0, 150, 200, -1.6f);

		_watch = Stopwatch.StartNew();
	}

	private int stashPage, stashTab, stashTabAbs;
	private float rv;

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.Inventory)
			return;

		var stashVisible = Assistant.Inventory.StashMainUiElement.Visible;
		var inventoryVisible = Assistant.Inventory.InventoryMainUiElement.Visible;
		var followerVisible = Assistant.Inventory.FollowerMainUiElement.Visible;

		stashTab = Assistant.Inventory.SelectedStashTabIndex;
		stashPage = Assistant.Inventory.SelectedStashPageIndex;
		stashTabAbs = stashTab + (stashPage * Assistant.Inventory.MaxStashTabCountPerPage);

		rv = 32.0f / 600.0f * Assistant.Window.Size.Height;

		if (inventoryVisible && (Assistant.Inventory.InventoryLockArea.Width > 0) && (Assistant.Inventory.InventoryLockArea.Height > 0)) {
			var rect = Assistant.Inventory.GetRectInInventory(Assistant.Inventory.InventoryLockArea.X, Assistant.Inventory.InventoryLockArea.Y, Assistant.Inventory.InventoryLockArea.Width, Assistant.Inventory.InventoryLockArea.Height);
			InventoryLockBorderBrush.DrawRectangle(rect.X, rect.Y, rect.Width, rect.Height);
		}

		if (!stashVisible && !inventoryVisible && !followerVisible)
			return;

		var allItems = Assistant.Game.Items;

		if (stashVisible) {
			foreach (var item in allItems.Where(x => x.Location == ItemLocation.Stash && x.InventoryX >= 0 && x.InventoryY >= 0)) {
				var tabIndex = item.InventoryY / 10;
				if (tabIndex != stashTabAbs)
					continue;

				var rect = Assistant.Inventory.GetItemRect(item);
				if (rect == System.Drawing.RectangleF.Empty)
					continue;

				DrawItemLooksGood(item, rect);
				DrawItemSocketedLegendaryGemRank(item, rect);
				DrawItemAncientRank(item, rect);
				DrawItemHoradricCache(item, rect);
				DrawItemNotGood(item, rect);
				DrawItemCanCubed(item, rect);
			}
		}

		if (inventoryVisible) {
			foreach (var item in allItems.Where(x => x.Location == ItemLocation.Inventory && x.InventoryX >= 0 && x.InventoryY >= 0)) {
				var rect = Assistant.Inventory.GetItemRect(item);
				if (rect == System.Drawing.RectangleF.Empty)
					continue;

				DrawItemLooksGood(item, rect);
				DrawItemSocketedLegendaryGemRank(item, rect);
				DrawItemAncientRank(item, rect);
				DrawItemHoradricCache(item, rect);
				DrawItemNotGood(item, rect);
				DrawItemCanCubed(item, rect);
			}

			foreach (var item in allItems.Where(x => x.Location == ItemLocation.Head || x.Location == ItemLocation.Torso || x.Location == ItemLocation.RightHand || x.Location == ItemLocation.LeftHand
				|| x.Location == ItemLocation.Hands || x.Location == ItemLocation.Waist || x.Location == ItemLocation.Feet || x.Location == ItemLocation.Shoulders || x.Location == ItemLocation.Legs || x.Location == ItemLocation.Bracers
				 || x.Location == ItemLocation.LeftRing || x.Location == ItemLocation.RightRing || x.Location == ItemLocation.Neck)) {
				var rect = Assistant.Inventory.GetItemRect(item);
				if (rect == System.Drawing.RectangleF.Empty)
					continue;

				DrawItemSocketedLegendaryGemRank(item, rect);
				DrawItemAncientRank(item, rect);
				DrawItemHoradricCache(item, rect);
				DrawItemCanCubed(item, rect);
			}
		}

		if (followerVisible) {
			foreach (var item in allItems.Where(x => x.Location == ItemLocation.PetHead || x.Location == ItemLocation.PetTorso || x.Location == ItemLocation.PetRightHand || x.Location == ItemLocation.PetLeftHand
				|| x.Location == ItemLocation.PetHands || x.Location == ItemLocation.PetWaist || x.Location == ItemLocation.PetFeet || x.Location == ItemLocation.PetShoulders || x.Location == ItemLocation.PetLegs || x.Location == ItemLocation.PetBracers
				 || x.Location == ItemLocation.PetLeftRing || x.Location == ItemLocation.PetRightRing || x.Location == ItemLocation.PetNeck || x.Location == ItemLocation.PetSpecial)) {
				var rect = Assistant.Inventory.GetItemRect(item);
				if (rect == System.Drawing.RectangleF.Empty)
					continue;

				DrawItemSocketedLegendaryGemRank(item, rect);
				DrawItemAncientRank(item, rect);
				DrawItemHoradricCache(item, rect);
				DrawItemCanCubed(item, rect);
			}
		}
	}

	private void DrawItemLooksGood(Item item, System.Drawing.RectangleF rect)
	{
		if (!LooksGoodDisplayEnabled)
			return;

		if ((item.Location != ItemLocation.Inventory) && (item.Location != ItemLocation.Stash))
			return;

		if (!item.Unidentified && (item.KeepDecision == ItemKeepDecision.LooksGood) && !item.IsInventoryLocked) {
			if (item.Location == ItemLocation.Stash) {
				if (item.SnoItem.Kind == ItemKind.gem)
					return;
				if (item.SnoItem.Kind == ItemKind.craft)
					return;
				if (item.SnoItem.Kind == ItemKind.uberstuff)
					return;
				if (item.SnoItem.MainGroupCode == "riftkeystone")
					return;
				if (item.SnoItem.MainGroupCode == "gems_unique")
					return;
				if (item.SnoItem.MainGroupCode == "consumable")
					return;
				if (item.SnoItem.MainGroupCode == "horadriccache")
					return;
			}

			Assistant.Render.TurnOnAliasing();
			try {
				ShadowBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)) - 2, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, (float)Math.Round(rect.X + (rv / 3.0f)) + 1, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, 2);
				ShadowBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2 - 2, (float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 3.0f)) + 2 + 1, 2);
				KeepBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)) - 1, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, (float)Math.Round(rect.X + (rv / 3.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2);
				KeepBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2 - 1, (float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 3.0f)) + 2);
			} finally {
				Assistant.Render.TurnOffAliasing();
			}
		}
	}

	private void DrawItemSocketedLegendaryGemRank(Item item, System.Drawing.RectangleF rect)
	{
		if (!SocketedLegendaryGemRankEnabled)
			return;

		if (item.ItemsInSocket == null)
			return;

		var legendaryGem = Array.Find(item.ItemsInSocket, x => x.Quality == ItemQuality.Legendary && x.JewelRank > -1);
		if (legendaryGem == null)
			return;

		var jewelRank = legendaryGem.JewelRank;
		if (jewelRank > -1) {
			var text = jewelRank.ToString("D", CultureInfo.InvariantCulture);
			var layout = SocketedLegendaryGemRankFont.GetTextLayout(text);
			SocketedLegendaryGemRankFont.DrawText(layout, rect.X, rect.Y);
		}
	}

	private void DrawItemAncientRank(Item item, System.Drawing.RectangleF rect)
	{
		if (!AncientRankEnabled)
			return;

		var ancientRank = item.AncientRank;
		if (ancientRank >= 1) {
			var caldesannRank = CaldesannRankEnabled ? item.CaldesannRank : 0;

			var ancientRankText = ancientRank == 1 ? "A" : "P";
			var font = ancientRank == 1 ? AncientRankFont : PrimalRankFont;

			var text = ancientRankText + (caldesannRank > 0 ? ("+" + caldesannRank.ToString("D", CultureInfo.InvariantCulture)) : "");
			var textLayout = font.GetTextLayout(text);
			font.DrawText(textLayout, rect.Right - (rv / 15.0f) - textLayout.Metrics.Width, rect.Bottom - (rv / 35.0f) - textLayout.Metrics.Height);
		}
	}

	private void DrawItemNotGood(Item item, System.Drawing.RectangleF rect)
	{
		if (!NotGoodDisplayEnabled && !DefinitelyBadDisplayEnabled)
			return;

		if ((item.Location != ItemLocation.Inventory) && (item.Location != ItemLocation.Stash))
			return;

		var locked = item.IsInventoryLocked;
		if (!locked && !item.Unidentified && (item.KeepDecision != ItemKeepDecision.LooksGood)) {
			if (NotGoodDisplayEnabled) {
				DarkenBrush.DrawRectangle(rect.X, rect.Y, rect.Width, rect.Height);
			}

			if (DefinitelyBadDisplayEnabled && item.KeepDecision == ItemKeepDecision.DefinitelyBad) {
				Assistant.Render.TurnOnAliasing();
				try {
					ShadowBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)) - 2, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, (float)Math.Round(rect.X + (rv / 3.0f)) + 1, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, 2);
					ShadowBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2 - 2, (float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 3.0f)) + 2 + 1, 2);
					ForceSellBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)) - 1, (float)Math.Round(rect.Y + (rv / 10.0f)) + 2, (float)Math.Round(rect.X + (rv / 3.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2);
					ForceSellBrush.DrawLine((float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 10.0f)) + 2 - 1, (float)Math.Round(rect.X + (rv / 10.0f)), (float)Math.Round(rect.Y + (rv / 3.0f)) + 2);
				} finally {
					Assistant.Render.TurnOffAliasing();
				}
			}
		}
	}

	private void DrawItemCanCubed(Item item, System.Drawing.RectangleF rect)
	{
		if (!CanCubedEnabled)
			return;

		if ((item.Location != ItemLocation.Inventory) && (item.Location != ItemLocation.Stash))
			return;

		var allowCube = item.SnoItem.CanKanaiCube && !Assistant.Game.LocalPlayer.IsCubed(item.SnoItem);
		if (allowCube && !item.IsInventoryLocked) {
			var cubeTexture = Assistant.Texture.KanaiCubeTexture;
			var h = cubeTexture.Height * 0.6f / 1200.0f * Assistant.Window.Size.Height;
			var rh = h;
			var mod = _watch.ElapsedMilliseconds % 1000;
			var ratio = 0.8f + (1.2f / 1000.0f * (mod < 500 ? mod : 1000 - mod));
			rh *= ratio;

			var x = rect.Right - (h * 0.80f) - ((rh - h) / 2);
			var y = rect.Top - (h * 0.20f) - ((rh - h) / 2);
			cubeTexture.Draw(x, y, rh, rh, 1);
		}
	}

	private void DrawItemHoradricCache(Item item, System.Drawing.RectangleF rect)
	{
		if (!HoradricCacheEnabled)
			return;

		if (item.SnoItem.MainGroupCode != "horadriccache")
			return;

		var text = "";
		if (item.SnoItem.Code.Contains("A1"))
			text = "A1";
		if (item.SnoItem.Code.Contains("A2"))
			text = "A2";
		if (item.SnoItem.Code.Contains("A3"))
			text = "A3";
		if (item.SnoItem.Code.Contains("A4"))
			text = "A4";
		if (item.SnoItem.Code.Contains("A5"))
			text = "A5";
		if (item.SnoItem.Code.Contains("Act1"))
			text = "A1";
		if (item.SnoItem.Code.Contains("Act2"))
			text = "A2";
		if (item.SnoItem.Code.Contains("Act3"))
			text = "A3";
		if (item.SnoItem.Code.Contains("Act4"))
			text = "A4";
		if (item.SnoItem.Code.Contains("Act5"))
			text = "A5";
		if (item.SnoItem.Code.Contains("Hard"))
			text += ": H";
		if (item.SnoItem.Code.Contains("Expert"))
			text += ": E";
		if (item.SnoItem.Code.Contains("Master"))
			text += ": M";

		if (item.SnoItem.Code.Contains("T16"))
			text += ": T16";
		else if (item.SnoItem.Code.Contains("T15"))
			text += ": T15";
		else if (item.SnoItem.Code.Contains("T14"))
			text += ": T14";
		else if (item.SnoItem.Code.Contains("T13"))
			text += ": T13";
		else if (item.SnoItem.Code.Contains("T12"))
			text += ": T12";
		else if (item.SnoItem.Code.Contains("T11"))
			text += ": T11";
		else if (item.SnoItem.Code.Contains("T10"))
			text += ": T10";
		else if (item.SnoItem.Code.Contains("T9"))
			text += ": T9";
		else if (item.SnoItem.Code.Contains("T8"))
			text += ": T8";
		else if (item.SnoItem.Code.Contains("T7"))
			text += ": T7";
		else if (item.SnoItem.Code.Contains("T6"))
			text += ": T6";
		else if (item.SnoItem.Code.Contains("T5"))
			text += ": T5";
		else if (item.SnoItem.Code.Contains("T4"))
			text += ": T4";
		else if (item.SnoItem.Code.Contains("T3"))
			text += ": T3";
		else if (item.SnoItem.Code.Contains("T2"))
			text += ": T2";
		else if (item.SnoItem.Code.Contains("T1"))
			text += ": T1";

		if (item.SnoItem.Code.Contains("Torment16"))
			text += ": T16";
		if (item.SnoItem.Code.Contains("Torment15"))
			text += ": T15";
		if (item.SnoItem.Code.Contains("Torment14"))
			text += ": T14";
		if (item.SnoItem.Code.Contains("Torment13"))
			text += ": T13";
		else if (item.SnoItem.Code.Contains("Torment12"))
			text += ": T12";
		else if (item.SnoItem.Code.Contains("Torment11"))
			text += ": T11";
		else if (item.SnoItem.Code.Contains("Torment10"))
			text += ": T10";
		else if (item.SnoItem.Code.Contains("Torment9"))
			text += ": T9";
		else if (item.SnoItem.Code.Contains("Torment8"))
			text += ": T8";
		else if (item.SnoItem.Code.Contains("Torment7"))
			text += ": T7";
		else if (item.SnoItem.Code.Contains("Torment6"))
			text += ": T6";
		else if (item.SnoItem.Code.Contains("Torment5"))
			text += ": T5";
		else if (item.SnoItem.Code.Contains("Torment4"))
			text += ": T4";
		else if (item.SnoItem.Code.Contains("Torment3"))
			text += ": T3";
		else if (item.SnoItem.Code.Contains("Torment2"))
			text += ": T2";
		else if (item.SnoItem.Code.Contains("Torment1"))
			text += ": T1";

		if (text != null) {
			var textLayout = HoradricCacheFont.GetTextLayout(text);
			HoradricCacheFont.DrawText(textLayout, rect.Right - (rv / 20.0f) - textLayout.Metrics.Width, rect.Bottom - (rv / 70.0f) - textLayout.Metrics.Height);
		}
	}
}
