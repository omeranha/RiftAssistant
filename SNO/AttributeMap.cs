

namespace SNO;

public sealed class AttributeMap
{
	public AcdAttribute Attribute__Hitpoints_Cur;

	public AcdAttribute Attribute__Hitpoints_Max_Total;

	public AcdAttribute Attribute__ItemStackQuantityLo;

	public AcdAttribute Attribute__ItemStackQuantityHi;

	public AcdAttribute Attribute__JewelRank;

	public AcdAttribute Attribute__Gold;

	public AcdAttribute Attribute__Untargetable;

	public AcdAttribute Attribute__Burrowed;

	public AcdAttribute Attribute__Invulnerable;

	public AcdAttribute Attribute__Stealthed;

	public AcdAttribute Attribute__Hidden;

	public AcdAttribute Attribute__Frozen;

	public AcdAttribute Attribute__Chilled;

	public AcdAttribute Attribute__Slow;

	public AcdAttribute Attribute__Stunned;

	public AcdAttribute Attribute__Blind;

	public AcdAttribute Attribute__Bleeding;

	public AcdAttribute Attribute__Chest_Open;

	public AcdAttribute Attribute__Gizmo_Has_Been_Operated;

	public AcdAttribute Attribute__gizmo_disabled_by_script;

	public AcdAttribute Attribute__Gizmo_State;

	public AcdAttribute Attribute__Deleted_On_Server;

	public AcdAttribute Attribute__Banner_Usable;

	public AcdAttribute Attribute__Is_NPC;

	public AcdAttribute Attribute__NPC_Is_Operatable;

	public AcdAttribute Attribute__TeamID;

	public AcdAttribute Attribute__Pet_Type;

	public AcdAttribute Attribute__power_buff_0_visual_effect_a;

	public AcdAttribute Attribute__power_buff_0_visual_effect_b;

	public AcdAttribute Attribute__power_buff_0_visual_effect_c;

	public AcdAttribute Attribute__power_buff_0_visual_effect_d;

	public AcdAttribute Attribute__power_buff_0_visual_effect_e;

	public AcdAttribute Attribute__power_buff_0_visual_effect_none;

	public AcdAttribute Attribute__power_buff_1_visual_effect_none;

	public AcdAttribute Attribute__power_buff_2_visual_effect_none;

	public AcdAttribute Attribute__power_buff_2_visual_effect_a;

	public AcdAttribute Attribute__power_buff_3_visual_effect_none;

	public AcdAttribute Attribute__power_buff_3_visual_effect_b;

	public AcdAttribute Attribute__power_buff_4_visual_effect_c;

	public AcdAttribute Attribute__power_buff_4_visual_effect_none;

	public AcdAttribute Attribute__power_buff_5_visual_effect_d;

	public AcdAttribute Attribute__power_buff_6_visual_effect_e;

	public AcdAttribute Attribute__summoned_by_acdid;

	public AcdAttribute Attribute__summoner_id;

	public AcdAttribute Attribute__rune_a;

	public AcdAttribute Attribute__rune_b;

	public AcdAttribute Attribute__rune_c;

	public AcdAttribute Attribute__rune_d;

	public AcdAttribute Attribute__rune_e;

	public AcdAttribute Attribute__dot_dps;

	public AcdAttribute Attribute__headstone_player_ann;

	public AcdAttribute Attribute__Set_Item_Discount;

	internal AttributeMap(Attributes attributes_0)
	{
		Attribute__power_buff_0_visual_effect_a = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_A");
		Attribute__power_buff_0_visual_effect_b = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_B");
		Attribute__power_buff_0_visual_effect_c = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_C");
		Attribute__power_buff_0_visual_effect_d = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_D");
		Attribute__power_buff_0_visual_effect_e = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_E");
		Attribute__power_buff_0_visual_effect_none = attributes_0.GetAttributeByCode("Power_Buff_0_Visual_Effect_None");
		Attribute__power_buff_1_visual_effect_none = attributes_0.GetAttributeByCode("Power_Buff_1_Visual_Effect_None");
		Attribute__power_buff_2_visual_effect_none = attributes_0.GetAttributeByCode("Power_Buff_2_Visual_Effect_None");
		Attribute__power_buff_2_visual_effect_a = attributes_0.GetAttributeByCode("Power_Buff_2_Visual_Effect_A");
		Attribute__power_buff_3_visual_effect_none = attributes_0.GetAttributeByCode("Power_Buff_3_Visual_Effect_None");
		Attribute__power_buff_3_visual_effect_b = attributes_0.GetAttributeByCode("Power_Buff_3_Visual_Effect_B");
		Attribute__power_buff_4_visual_effect_c = attributes_0.GetAttributeByCode("Power_Buff_4_Visual_Effect_C");
		Attribute__power_buff_4_visual_effect_none = attributes_0.GetAttributeByCode("Power_Buff_4_Visual_Effect_None");
		Attribute__power_buff_5_visual_effect_d = attributes_0.GetAttributeByCode("Power_Buff_5_Visual_Effect_D");
		Attribute__power_buff_6_visual_effect_e = attributes_0.GetAttributeByCode("Power_Buff_6_Visual_Effect_E");
		Attribute__Hitpoints_Cur = attributes_0.GetAttributeByCode("Hitpoints_Cur");
		Attribute__Hitpoints_Max_Total = attributes_0.GetAttributeByCode("Hitpoints_Max_Total");
		Attribute__ItemStackQuantityLo = attributes_0.GetAttributeByCode("ItemStackQuantityLo");
		Attribute__ItemStackQuantityHi = attributes_0.GetAttributeByCode("ItemStackQuantityHi");
		Attribute__JewelRank = attributes_0.GetAttributeByCode("Jewel_Rank");
		Attribute__Gold = attributes_0.GetAttributeByCode("Gold");
		Attribute__Untargetable = attributes_0.GetAttributeByCode("Untargetable");
		Attribute__Burrowed = attributes_0.GetAttributeByCode("Burrowed");
		Attribute__Invulnerable = attributes_0.GetAttributeByCode("Invulnerable");
		Attribute__Stealthed = attributes_0.GetAttributeByCode("Stealthed");
		Attribute__Hidden = attributes_0.GetAttributeByCode("Hidden");
		Attribute__Frozen = attributes_0.GetAttributeByCode("Frozen");
		Attribute__Chilled = attributes_0.GetAttributeByCode("Chilled");
		Attribute__Slow = attributes_0.GetAttributeByCode("Slow");
		Attribute__Stunned = attributes_0.GetAttributeByCode("Stunned");
		Attribute__Blind = attributes_0.GetAttributeByCode("Blind");
		Attribute__Bleeding = attributes_0.GetAttributeByCode("Bleeding");
		Attribute__Chest_Open = attributes_0.GetAttributeByCode("Chest_Open");
		Attribute__Gizmo_Has_Been_Operated = attributes_0.GetAttributeByCode("Gizmo_Has_Been_Operated");
		Attribute__gizmo_disabled_by_script = attributes_0.GetAttributeByCode("Gizmo_Disabled_By_Script");
		Attribute__Gizmo_State = attributes_0.GetAttributeByCode("Gizmo_State");
		Attribute__Deleted_On_Server = attributes_0.GetAttributeByCode("Deleted_On_Server");
		Attribute__Banner_Usable = attributes_0.GetAttributeByCode("Banner_Usable");
		Attribute__Is_NPC = attributes_0.GetAttributeByCode("Is_NPC");
		Attribute__NPC_Is_Operatable = attributes_0.GetAttributeByCode("NPC_Is_Operatable");
		Attribute__TeamID = attributes_0.GetAttributeByCode("TeamID");
		Attribute__Pet_Type = attributes_0.GetAttributeByCode("Pet_Type");
		Attribute__summoned_by_acdid = attributes_0.GetAttributeByCode("Summoned_By_ACDID");
		Attribute__summoner_id = attributes_0.GetAttributeByCode("Summoner_ID");
		Attribute__rune_a = attributes_0.GetAttributeByCode("Rune_A");
		Attribute__rune_b = attributes_0.GetAttributeByCode("Rune_B");
		Attribute__rune_c = attributes_0.GetAttributeByCode("Rune_C");
		Attribute__rune_d = attributes_0.GetAttributeByCode("Rune_D");
		Attribute__rune_e = attributes_0.GetAttributeByCode("Rune_E");
		Attribute__dot_dps = attributes_0.GetAttributeByCode("DOT_DPS");
		Attribute__headstone_player_ann = attributes_0.GetAttributeByCode("Headstone_Player_ANN");
		Attribute__Set_Item_Discount = attributes_0.GetAttributeByCode("Attribute_Set_Item_Discount");
	}
}
