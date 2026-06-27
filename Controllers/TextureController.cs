using Plugins;
using SNO;
using work;

public class TextureController
{
	public Texture EmptySocketTexture => GetTexture("GemSocket32");

	public Texture UnidTexture => GetTexture("ItemStatus_Unidentified");

	public Texture KanaiCubeTexture => GetTexture("Marker_KanaisCube");

	public Texture ButtonTextureGray => GetTexture(3253023435u);

	public Texture ButtonTextureBlue => GetTexture(3834792285u);

	public Texture ButtonTextureOrange => GetTexture(1227300027u);

	public Texture BackgroundTextureOrange => GetTexture(2823360744u);

	public Texture BackgroundTextureGreen => GetTexture(64720473u);

	public Texture BackgroundTextureYellow => GetTexture(2135735351u);

	public Texture BackgroundTextureBlue => GetTexture(1753848494u);

	public Texture Button2TextureGray => GetTexture(1889271890u);

	public Texture Button2TextureOrange => GetTexture(1780664260u);

	public Texture Button2TextureBrown => GetTexture(2825893160u);

	public Texture BuffFrameTexture => GetTexture("buff_frame");

	public Texture DebuffFrameTexture => GetTexture("debuff_frame");

	public Texture InventorySlotTexture => GetTexture("InventoryGrid_Slot");

	public Texture InventoryLegendaryBackgroundSmall => GetTexture("Quality_Small_Inventory_Legendary");

	public Texture InventoryLegendaryBackgroundLarge => GetTexture("Quality_Large_Inventory_Legendary");

	public Texture InventorySetBackgroundSmall => GetTexture("Quality_Small_Inventory_Set");

	public Texture InventorySetBackgroundLarge => GetTexture("Quality_Large_Inventory_Set");

	public Texture GetItemBackgroundTexture(Item item)
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

	public Texture GetTexture(string name)
	{
		return TextureManager.GetTextureByName(name);
	}

	public Texture GetTexture(uint id)
	{
		return TextureManager.GetTextureById(id);
	}

	public Texture GetTexture(uint textureSno, int frameIndex)
	{
		return TextureManager.GetTextureById(textureSno);
	}

	public Texture GetItemTexture(SnoItem snoItem)
	{
		return TextureManager.GetItemTexture(snoItem, CoreCollector.LocalPlayer?.HeroClassDefinition?.HeroClass ?? HeroClass.Wizard, CoreCollector.LocalPlayer?.HeroIsMale ?? true);
	}
}
