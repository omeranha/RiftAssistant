using Plugins;
using work;

internal class TextureController : ITextureController
{
	public ITexture EmptySocketTexture => GetTexture("GemSocket32");

	public ITexture UnidTexture => GetTexture("ItemStatus_Unidentified");

	public ITexture KanaiCubeTexture => GetTexture("Marker_KanaisCube");

	public ITexture ButtonTextureGray => GetTexture(3253023435u);

	public ITexture ButtonTextureBlue => GetTexture(3834792285u);

	public ITexture ButtonTextureOrange => GetTexture(1227300027u);

	public ITexture BackgroundTextureOrange => GetTexture(2823360744u);

	public ITexture BackgroundTextureGreen => GetTexture(64720473u);

	public ITexture BackgroundTextureYellow => GetTexture(2135735351u);

	public ITexture BackgroundTextureBlue => GetTexture(1753848494u);

	public ITexture Button2TextureGray => GetTexture(1889271890u);

	public ITexture Button2TextureOrange => GetTexture(1780664260u);

	public ITexture Button2TextureBrown => GetTexture(2825893160u);

	public ITexture BuffFrameTexture => GetTexture("buff_frame");

	public ITexture DebuffFrameTexture => GetTexture("debuff_frame");

	public ITexture InventorySlotTexture => GetTexture("InventoryGrid_Slot");

	public ITexture InventoryLegendaryBackgroundSmall => GetTexture("Quality_Small_Inventory_Legendary");

	public ITexture InventoryLegendaryBackgroundLarge => GetTexture("Quality_Large_Inventory_Legendary");

	public ITexture InventorySetBackgroundSmall => GetTexture("Quality_Small_Inventory_Set");

	public ITexture InventorySetBackgroundLarge => GetTexture("Quality_Large_Inventory_Set");

	public ITexture GetItemBackgroundTexture(IItem item)
	{
		switch ((ItemCraftQuality)((item.SnoItem.CraftQuality == ItemCraftQuality.None) ? ((int)item.Quality) : ((int)item.SnoItem.CraftQuality)))
		{
		case ItemCraftQuality.Magic4:
		case ItemCraftQuality.Magic5:
		case ItemCraftQuality.Magic6:
			return GetTexture((item.SnoItem.ItemHeight == 2) ? "Quality_Large_Inventory_Magic" : "Quality_Small_Inventory_Magic");
		case ItemCraftQuality.Rare4:
		case ItemCraftQuality.Rare5:
		case ItemCraftQuality.Rare6:
			return GetTexture((item.SnoItem.ItemHeight == 2) ? "Quality_Large_Inventory_Rare" : "Quality_Small_Inventory_Rare");
		default:
			return null;
		case ItemCraftQuality.Legendary:
		case ItemCraftQuality.Set:
			if (item.SnoItem.SetItemBonusesSno != uint.MaxValue)
			{
				return GetTexture((item.SnoItem.ItemHeight == 2) ? "Quality_Large_Inventory_Set" : "Quality_Small_Inventory_Set");
			}
			return GetTexture((item.SnoItem.ItemHeight == 2) ? "Quality_Large_Inventory_Legendary" : "Quality_Small_Inventory_Legendary");
		}
	}

	public ITexture GetTexture(string name)
	{
		return TextureManager.GetTextureByName(name);
	}

	public ITexture GetTexture(uint id)
	{
		return TextureManager.GetTextureById(id);
	}

	public ITexture GetTexture(uint textureSno, int frameIndex)
	{
		return TextureManager.GetTextureById(textureSno);
	}

	public ITexture GetItemTexture(ISnoItem snoItem)
	{
		return TextureManager.GetItemTexture(snoItem, CoreCollector.LocalPlayer?.HeroClassDefinition?.HeroClass ?? HeroClass.Wizard, CoreCollector.LocalPlayer?.HeroIsMale ?? true);
	}
}
