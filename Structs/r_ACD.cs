using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ACD
{
	[FieldOffset(0)]
	public uint AcdId;

	[FieldOffset(136)]
	public uint AnnId;

	[FieldOffset(144)]
	public uint ActorSnoEncrypted;

	[FieldOffset(176)]
	public int GameBalanceType;

	[FieldOffset(180)]
	public uint GBID;

	[FieldOffset(184)]
	public int ActorRarity;

	[FieldOffset(216)]
	public float PositionX;

	[FieldOffset(220)]
	public float PositionY;

	[FieldOffset(224)]
	public float PositionZ;

	[FieldOffset(280)]
	public uint SWorldID_Encrypted;

	[FieldOffset(284)]
	public uint SSceneID_Encrypted;

	[FieldOffset(288)]
	public uint SocketHostAcdId;

	[FieldOffset(292)]
	public int ItemLocation;

	[FieldOffset(296)]
	public int ItemSlotX;

	[FieldOffset(300)]
	public int ItemSlotY;

	[FieldOffset(304)]
	public short FastAttribGroupID;

	[FieldOffset(344)]
	public long affix_list_ptr;

	[FieldOffset(400)]
	public int Unidentified;

	[FieldOffset(424)]
	public int rare_item_prefix_or_suffix;

	[FieldOffset(428)]
	public uint rare_item_stringlist_id;

	[FieldOffset(432)]
	public int rare_item_stringlist_index;

	[FieldOffset(436)]
	public int rare_item_otherlist_index;

	[FieldOffset(440)]
	public int GizmoType;

	[FieldOffset(448)]
	public float HitPoints;

	[FieldOffset(484)]
	public uint monster_affix_id_0;

	[FieldOffset(488)]
	public uint monster_affix_id_1;

	[FieldOffset(492)]
	public uint monster_affix_id_2;

	[FieldOffset(496)]
	public uint monster_affix_id_3;

	[FieldOffset(500)]
	public uint monster_affix_id_4;

	[FieldOffset(504)]
	public uint monster_affix_id_5;

	[FieldOffset(508)]
	public uint monster_affix_id_6;

	[FieldOffset(512)]
	public uint monster_affix_id_7;

	[FieldOffset(656)]
	public long ptr_animation_info;

	[FieldOffset(664)]
	public long ptr_portal_info;

	[FieldOffset(724)]
	public int CollisionFlags;

	[FieldOffset(752)]
	public float CollisionRadius;

	[FieldOffset(956)]
	public int dummy;
}
