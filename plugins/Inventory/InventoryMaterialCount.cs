namespace Plugins.Default;

public class InventoryMaterialCount : BasePlugin, IInGameTopPainter
{
	public IFont MaterialCountFont { get; set; }

	private SnoItem[] _materialItems, _legendaryMaterials, _otherStuff;
	private const float BarHeightRatio = 31f / 589f;
	private IBrush _backgroundBrush;

	public InventoryMaterialCount()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		_materialItems = new SnoItem[] { Assistant.Inventory.GetSnoItem(3931359676), Assistant.Inventory.GetSnoItem(2709165134), Assistant.Inventory.GetSnoItem(3689019703), Assistant.Inventory.GetSnoItem(2087837753), Assistant.Inventory.GetSnoItem(2073430088) };
		_legendaryMaterials = new SnoItem[] { Assistant.Inventory.GetSnoItem(1948629088), Assistant.Inventory.GetSnoItem(1948629089), Assistant.Inventory.GetSnoItem(1948629090), Assistant.Inventory.GetSnoItem(1948629091), Assistant.Inventory.GetSnoItem(1948629092) };
		_otherStuff = new SnoItem[] { Assistant.Inventory.GetSnoItem(1054965529), Assistant.Inventory.GetSnoItem(2788723894), Assistant.Inventory.GetSnoItem(2622355732), Assistant.Inventory.GetSnoItem(1458185494), Assistant.Inventory.GetSnoItem(2835237830) };

		MaterialCountFont = Assistant.Render.CreateFont("Arial", 8, 255, 255, 255, 255, false, false, false);

		_backgroundBrush = Assistant.Render.CreateBrush(190, 12, 10, 8, 0);
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (!Enabled)
			return;
		if (clipState != ClipState.Inventory)
			return;
		if (Assistant.Game.LocalPlayer.CurrentLevelNormalCap != 70)
			return;

		var uiInv = Assistant.Inventory.InventoryMainUiElement;
		if (!uiInv.Visible)
			return;

		var y = uiInv.Rectangle.Top + (uiInv.Rectangle.Height * 0.825f);
		y += DrawItemBar(_materialItems, y);
		y += DrawItemBar(_legendaryMaterials, y);
		DrawItemBar(_otherStuff, y);
	}

	private float DrawItemBar(SnoItem[] itemsToDisplay, float barY)
	{
		var uiInv = Assistant.Inventory.InventoryMainUiElement;

		var rect = new System.Drawing.RectangleF(uiInv.Rectangle.Left - 1, barY, uiInv.Rectangle.Width + 2, uiInv.Rectangle.Width * BarHeightRatio);
		_backgroundBrush.DrawRectangle(rect.X, rect.Y, rect.Width, rect.Height);

		var itemCountList = new long[itemsToDisplay.Length];
		for (var j = 0; j < itemsToDisplay.Length; j++) {
			itemCountList[j] = GetItemCount(itemsToDisplay[j]);
		}

		var w = rect.Width / (itemsToDisplay.Length + 1);
		var h = rect.Height * 0.85f;
		var y = rect.Top + ((rect.Height - h) / 2);
		for (var i = 0; i < itemsToDisplay.Length; i++) {
			var snoItem = itemsToDisplay[i];
			var texture = Assistant.Texture.GetItemTexture(snoItem);
			if (texture != null) {
				var x = (w / 2) + rect.Left + (i * w);
				texture.Draw(x + w - h, y, h, h, 1);
				var layout = MaterialCountFont.GetTextLayout(ValueToString(itemCountList[i], ValueFormat.NormalNumberNoDecimal));
				MaterialCountFont.DrawText(layout, x + w - (h * 1.2f) - layout.Metrics.Width, y + ((h - layout.Metrics.Height) / 2));

				if (Assistant.Window.CursorInsideRect(x + w - (h * 1.2f) - layout.Metrics.Width, y, (h * 1.2f) + layout.Metrics.Width, h)) {
					Assistant.Render.SetHint(snoItem.NameLocalized);
				}
			}
		}

		return rect.Height;
	}

	private long GetItemCount(SnoItem snoItem)
	{
		switch (snoItem.Sno) {
			case 3931359676:
				return Assistant.Game.LocalPlayer.Materials.ReusableParts;
			case 2709165134:
				return Assistant.Game.LocalPlayer.Materials.ArcaneDust;
			case 3689019703:
				return Assistant.Game.LocalPlayer.Materials.VeiledCrystal;
			case 2087837753:
				return Assistant.Game.LocalPlayer.Materials.DeathsBreath;
			case 2073430088:
				return Assistant.Game.LocalPlayer.Materials.ForgottenSoul;
			case 1948629088:
				return Assistant.Game.LocalPlayer.Materials.KhanduranRune;
			case 1948629089:
				return Assistant.Game.LocalPlayer.Materials.CaldeumNightShade;
			case 1948629090:
				return Assistant.Game.LocalPlayer.Materials.ArreatWarTapestry;
			case 1948629091:
				return Assistant.Game.LocalPlayer.Materials.CorruptedAngelFlesh;
			case 1948629092:
				return Assistant.Game.LocalPlayer.Materials.WestmarchHolyWater;
			case 1102953247:
				return Assistant.Game.LocalPlayer.Materials.LeoricsRegret;
			case 2029265596:
				return Assistant.Game.LocalPlayer.Materials.VialOfPutridness;
			case 2670343450:
				return Assistant.Game.LocalPlayer.Materials.IdolOfTerror;
			case 3336787100:
				return Assistant.Game.LocalPlayer.Materials.HeartOfFright;
			case 2835237830:
				return Assistant.Game.LocalPlayer.Materials.GreaterRiftKeystone;
		}

		var count = 0;
		foreach (var item in Assistant.Inventory.ItemsInStash) {
			if (item.SnoItem == snoItem)
				count += (int)item.Quantity;
		}

		foreach (var item in Assistant.Inventory.ItemsInInventory) {
			if (item.SnoItem == snoItem)
				count += (int)item.Quantity;
		}

		return count;
	}
}
