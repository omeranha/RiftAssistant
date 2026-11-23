using System.Runtime.CompilerServices;
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

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ActiveSkillSavedData
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public int int_0;

	[FieldOffset(8)]
	public int int_1;

	[FieldOffset(12)]
	public int int_2;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Actor
{
	[FieldOffset(0)]
	public uint ActorId;

	[FieldOffset(136)]
	public uint AcdIdEncrypted;

	[FieldOffset(192)]
	public float CollisionX;

	[FieldOffset(196)]
	public float CollisionY;

	[FieldOffset(200)]
	public float CollisionZ;

	[FieldOffset(204)]
	public float CollisionRadius;

	[FieldOffset(208)]
	public float BottomX;

	[FieldOffset(212)]
	public float BottomY;

	[FieldOffset(216)]
	public float BottomZ;

	[FieldOffset(224)]
	public float BottomRadius;

	[FieldOffset(740)]
	public uint IsSelected;

	[FieldOffset(1172)]
	public int CreationTick;

	[FieldOffset(1268)]
	public int dummy;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct r_ArmoryItem
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(16)]
	public uint uint_1;

	[FieldOffset(20)]
	public uint uint_2;

	[FieldOffset(24)]
	public uint uint_3;

	[FieldOffset(28)]
	public int int_0;

	[FieldOffset(32)]
	public int int_1;

	[FieldOffset(36)]
	public int int_2;

	public const int int_3 = 48;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct r_ArmoryPotion
{
	[FieldOffset(0)]
	public uint PotionAnnId;

	[FieldOffset(16)]
	public uint uint_1;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct r_ArmorySet
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct29
	{
		public sbyte sbyte_0;
	}

	[FieldOffset(0)]
	public r_ArmoryItem struct25_0;

	[FieldOffset(48)]
	public r_ArmoryItem struct25_1;

	[FieldOffset(96)]
	public r_ArmoryItem struct25_2;

	[FieldOffset(144)]
	public r_ArmoryItem struct25_3;

	[FieldOffset(192)]
	public r_ArmoryItem struct25_4;

	[FieldOffset(240)]
	public r_ArmoryItem struct25_5;

	[FieldOffset(288)]
	public r_ArmoryItem struct25_6;

	[FieldOffset(336)]
	public r_ArmoryItem struct25_7;

	[FieldOffset(384)]
	public r_ArmoryItem struct25_8;

	[FieldOffset(432)]
	public r_ArmoryItem struct25_9;

	[FieldOffset(480)]
	public r_ArmoryItem struct25_10;

	[FieldOffset(528)]
	public r_ArmoryItem struct25_11;

	[FieldOffset(576)]
	public r_ArmoryItem struct25_12;

	[FieldOffset(624)]
	public r_ArmoryPotion struct26_0;

	[FieldOffset(648)]
	public r_ArmorySkill struct27_0;

	[FieldOffset(656)]
	public r_ArmorySkill struct27_1;

	[FieldOffset(664)]
	public r_ArmorySkill struct27_2;

	[FieldOffset(672)]
	public r_ArmorySkill struct27_3;

	[FieldOffset(680)]
	public r_ArmorySkill struct27_4;

	[FieldOffset(688)]
	public r_ArmorySkill struct27_5;

	[FieldOffset(696)]
	public uint uint_0;

	[FieldOffset(700)]
	public uint uint_1;

	[FieldOffset(704)]
	public uint uint_2;

	[FieldOffset(708)]
	public uint uint_3;

	[FieldOffset(712)]
	public uint uint_4;

	[FieldOffset(716)]
	public uint uint_5;

	[FieldOffset(720)]
	public uint uint_6;

	[FieldOffset(724)]
	public uint uint_7;

	[FieldOffset(728)]
	public unsafe fixed sbyte struct29_0[1];
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct r_ArmorySkill
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public uint uint_1;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_AttributeEntry
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public uint uint_0;

	[FieldOffset(12)]
	public int int_0;

	[FieldOffset(12)]
	public float float_0;

	public const int int_1 = 16;

	public static readonly r_AttributeEntry struct8_0;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Container
{
	public const int int_0 = 256;

	[FieldOffset(256)]
	public int Capacity;

	[FieldOffset(264)]
	public int MaxIndex;

	public const int int_3 = 288;

	[FieldOffset(288)]
	public long DataAddress;

	public const int int_4 = 304;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_CurrencyData
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(8)]
	public long long_0;

	[FieldOffset(16)]
	public int int_0;

	[FieldOffset(20)]
	public int int_1;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ExpandableContainer
{
	public const int int_0 = 0;

	public const int int_1 = 255;

	public const int int_2 = 256;

	[FieldOffset(256)]
	public int Capacity;

	[FieldOffset(264)]
	public int MaxIndex;

	public const int int_5 = 288;

	[FieldOffset(288)]
	public long _Allocator_PtrItems;

	public const int int_6 = 296;

	[FieldOffset(296)]
	public int _Allocator_BlockAllocations;

	public const int int_8 = 328;

	[FieldOffset(328)]
	public uint _Allocator_GoodFood;

	[FieldOffset(360)]
	public int Bits;

	public const int Size = 364;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_FastAttribGroup
{
	public const int int_0 = 0;

	public const int int_1 = 4;

	public const int int_2 = 16;

	public const int int_3 = 24;

	public const int int_4 = 4840;

	[FieldOffset(4836)]
	public int int_5;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_FloatingNumber
{
	[FieldOffset(0)]
	public Enum3 enum3_0;

	[FieldOffset(8)]
	public float float_0;

	[FieldOffset(12)]
	public float float_1;

	[FieldOffset(16)]
	public float float_2;

	[FieldOffset(20)]
	public uint uint_0;

	[FieldOffset(60)]
	public int int_0;

	[FieldOffset(64)]
	public int int_1;

	[FieldOffset(88)]
	public uint uint_1;

	[FieldOffset(92)]
	public float float_3;

	[FieldOffset(96)]
	public long long_0;

	[FieldOffset(104)]
	public long long_1;

	public const int int_2 = 112;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Hero
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public long long_1;

	[FieldOffset(16)]
	public ulong ulong_0;

	[FieldOffset(180)]
	public ulong ulong_1;

	[FieldOffset(184)]
	public ulong ulong_2;

	[FieldOffset(200)]
	public long long_2;

	[FieldOffset(216)]
	public uint uint_0;

	[FieldOffset(232)]
	public long long_3;

	[FieldOffset(256)]
	public uint uint_1;

	[FieldOffset(264)]
	public int int_0;

	[FieldOffset(268)]
	public int int_1;

	[FieldOffset(292)]
	public int season;

	[FieldOffset(336)]
	public int int_3;

	[FieldOffset(360)]
	public uint uint_2;

	[FieldOffset(364)]
	public uint uint_3;

	[FieldOffset(368)]
	public int int_4;

	[FieldOffset(376)]
	public long long_4;

	[FieldOffset(384)]
	public long long_5;

	public const int SizeOf = 392;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Map
{
	[FieldOffset(0)]
	public int Mask;

	public const int Offset_PtrBucketAllocator = 8;

	[FieldOffset(8)]
	public long PtrBucketAllocator;

	[FieldOffset(24)]
	public int MaxIndex;

	public const int Offset_Buckets = 28;

	public const int Size = 32;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Marker
{
	[FieldOffset(0)]
	public r_WorldPlace struct37_0;

	[FieldOffset(16)]
	public r_Texture struct15_0;

	[FieldOffset(24)]
	public uint uint_0;

	[FieldOffset(28)]
	public uint uint_1;

	[FieldOffset(32)]
	public uint uint_2;

	[FieldOffset(36)]
	public uint uint_3;

	[FieldOffset(72)]
	public uint uint_4;

	[FieldOffset(72)]
	public float float_0;

	[FieldOffset(72)]
	public int int_0;

	public const int int_1 = 76;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MarkerEntry
{
	[FieldOffset(0)]
	public long long_0;

	[FieldOffset(8)]
	public uint uint_0;

	[FieldOffset(12)]
	public r_Marker struct17_0;

	public const int int_0 = 88;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MinimapIcon
{
	[FieldOffset(256)]
	public float float_0;

	[FieldOffset(260)]
	public float float_1;

	[FieldOffset(264)]
	public uint uint_0;

	[FieldOffset(268)]
	public uint uint_1;

	[FieldOffset(272)]
	public uint uint_2;

	public const int Size = 276;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_PlayerData
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct FixedBuffer_Passives
	{
		public uint uint_0;
	}

	[StructLayout(LayoutKind.Sequential, Size = 2048)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct FixedBuffer_CubedItemSnoArray
	{
		public uint uint_0;
	}

	[StructLayout(LayoutKind.Sequential, Size = 13)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct FixedBuffer_HeroName
	{
		public sbyte sbyte_0;
	}

	[FieldOffset(4)]
	public uint AcdIdEncrypted;

	[FieldOffset(8)]
	public uint ActorIdEncrypted;

	[FieldOffset(60)]
	public int IsInGameFlag;

	[FieldOffset(4940)]
	public r_ActiveSkillSavedData struct30_0;

	[FieldOffset(4956)]
	public r_ActiveSkillSavedData struct30_1;

	[FieldOffset(4972)]
	public r_ActiveSkillSavedData struct30_2;

	[FieldOffset(4988)]
	public r_ActiveSkillSavedData struct30_3;

	[FieldOffset(5004)]
	public r_ActiveSkillSavedData struct30_4;

	[FieldOffset(5020)]
	public r_ActiveSkillSavedData struct30_5;

	[FieldOffset(5036)]
	public unsafe fixed uint struct33_0[4];

	[FieldOffset(5052)]
	public uint UsedKanaiItemSno1;

	[FieldOffset(5056)]
	public uint UsedKanaiItemSno2;

	[FieldOffset(5060)]
	public uint UsedKanaiItemSno3;

	[FieldOffset(5064)]
	public uint UsedKanaiItemSno4;

	[FieldOffset(38176)]
	public unsafe fixed uint struct34_0[512];

	[FieldOffset(40240)]
	public long Gold;

	[FieldOffset(40264)]
	public long Bloodshards;

	[FieldOffset(40288)]
	public long BNetStoreCurrency;

	[FieldOffset(40312)]
	public long ReusableParts;

	[FieldOffset(40336)]
	public long ArcaneDust;

	[FieldOffset(40360)]
	public long VeiledCrystal;

	[FieldOffset(40384)]
	public long DeathBreaths;

	[FieldOffset(40408)]
	public long ForgottenSoul;

	[FieldOffset(40432)]
	public long KhanduranRune;

	[FieldOffset(40456)]
	public long CaldeumNightShade;

	[FieldOffset(40480)]
	public long ArreatWarTapestry;

	[FieldOffset(40504)]
	public long CorruptedAngelFlesh;

	[FieldOffset(40528)]
	public long WestmarchHolyWater;

	[FieldOffset(40552)]
	public long HeartOfFright;

	[FieldOffset(40576)]
	public long VialOfPutridness;

	[FieldOffset(40600)]
	public long IdolOfTerror;

	[FieldOffset(40624)]
	public long LeoricsSignet;

	[FieldOffset(40648)]
	public long Eye;

	[FieldOffset(40672)]
	public long SpineCord;

	[FieldOffset(40696)]
	public long Tooth;

	[FieldOffset(40720)]
	public long GreaterRiftKeystones;

	[FieldOffset(45576)]
	public uint HeroId;

	[FieldOffset(45584)]
	public unsafe fixed sbyte struct35_0[13];

	[FieldOffset(46984)]
	public r_ArmorySet struct28_0;

	[FieldOffset(47776)]
	public r_ArmorySet struct28_1;

	[FieldOffset(48568)]
	public r_ArmorySet struct28_2;

	[FieldOffset(49360)]
	public r_ArmorySet struct28_3;

	[FieldOffset(50152)]
	public r_ArmorySet struct28_4;

	[FieldOffset(50944)]
	public r_ArmorySet struct28_5;

	[FieldOffset(51736)]
	public r_ArmorySet struct28_6;

	[FieldOffset(52528)]
	public r_ArmorySet struct28_7;

	[FieldOffset(53320)]
	public r_ArmorySet struct28_8;

	[FieldOffset(54112)]
	public r_ArmorySet struct28_9;

	[FieldOffset(54908)]
	public float LifePercentage;

	[FieldOffset(54912)]
	public uint AreaSnoEncrypted;

	[FieldOffset(54912)]
	public uint AreaSnoUnknownEncrypted_depreciated;

	[FieldOffset(54920)]
	public uint HeroClass;

	[FieldOffset(59372)]
	public int dummy;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Quest
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public int int_0;

	[FieldOffset(8)]
	public uint uint_1;

	[FieldOffset(12)]
	public uint uint_2;

	[FieldOffset(16)]
	public uint uint_3;

	[FieldOffset(20)]
	public float float_0;

	[FieldOffset(24)]
	public int int_1;

	[FieldOffset(28)]
	public uint uint_4;

	[FieldOffset(32)]
	public uint uint_5;

	[FieldOffset(36)]
	public uint uint_6;

	[FieldOffset(40)]
	public int int_2;

	[FieldOffset(44)]
	public uint uint_7;

	[FieldOffset(48)]
	public uint uint_8;

	[FieldOffset(52)]
	public uint uint_9;

	[FieldOffset(56)]
	public uint uint_10;

	[FieldOffset(60)]
	public uint uint_11;

	[FieldOffset(64)]
	public uint uint_12;

	[FieldOffset(68)]
	public uint uint_13;

	[FieldOffset(72)]
	public uint uint_14;

	[FieldOffset(76)]
	public uint uint_15;

	[FieldOffset(80)]
	public uint uint_16;

	[FieldOffset(84)]
	public uint uint_17;

	[FieldOffset(88)]
	public uint uint_18;

	[FieldOffset(92)]
	public uint uint_19;

	[FieldOffset(96)]
	public uint uint_20;

	[FieldOffset(100)]
	public uint uint_21;

	[FieldOffset(104)]
	public uint uint_22;

	[FieldOffset(108)]
	public uint uint_23;

	[FieldOffset(112)]
	public uint uint_24;

	[FieldOffset(116)]
	public uint uint_25;

	[FieldOffset(120)]
	public uint uint_26;

	[FieldOffset(124)]
	public uint uint_27;

	[FieldOffset(128)]
	public uint uint_28;

	[FieldOffset(132)]
	public uint uint_29;

	[FieldOffset(136)]
	public uint uint_30;

	[FieldOffset(140)]
	public uint uint_31;

	[FieldOffset(144)]
	public uint uint_32;

	[FieldOffset(148)]
	public uint uint_33;

	[FieldOffset(152)]
	public uint uint_34;

	[FieldOffset(156)]
	public uint uint_35;

	[FieldOffset(160)]
	public uint uint_36;

	[FieldOffset(164)]
	public uint uint_37;

	[FieldOffset(168)]
	public uint uint_38;

	[FieldOffset(172)]
	public uint uint_39;

	public const int Size = 376;

	[FieldOffset(372)]
	public int int_4;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Scene
{
	[FieldOffset(0)]
	public uint Id;

	[FieldOffset(8)]
	public uint SSceneID;

	[FieldOffset(12)]
	public uint SWorldID;

	[FieldOffset(28)]
	public uint LevelAreaSNO;

	[FieldOffset(68)]
	public uint MusicSno;

	[FieldOffset(72)]
	public uint AmbientSno;

	[FieldOffset(76)]
	public uint ReverbSno;

	[FieldOffset(80)]
	public uint WeatherSno;

	[FieldOffset(160)]
	public int SquareCountX;

	[FieldOffset(164)]
	public int SquareCountY;

	[FieldOffset(236)]
	public uint SceneSno;

	[FieldOffset(256)]
	public float mesh_min_x;

	[FieldOffset(260)]
	public float mesh_min_y;

	[FieldOffset(264)]
	public float mesh_min_z;

	[FieldOffset(376)]
	public float mesh_max_x;

	[FieldOffset(380)]
	public float mesh_max_y;

	[FieldOffset(392)]
	public float mesh_max_z;

	public const int Size = 1976;

	[FieldOffset(1972)]
	public int dummy;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_SceneRevealInfo
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(4)]
	public uint uint_1;

	[FieldOffset(8)]
	public uint uint_2;

	[FieldOffset(12)]
	public uint uint_3;

	[FieldOffset(16)]
	public float float_0;

	[FieldOffset(20)]
	public float float_1;

	[FieldOffset(24)]
	public float float_2;

	[FieldOffset(28)]
	public float float_3;

	[FieldOffset(32)]
	public uint uint_4;

	[FieldOffset(36)]
	public long long_0;

	[FieldOffset(72)]
	public long long_1;

	[FieldOffset(80)]
	public long long_2;

	public const int int_0 = 88;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Texture
{
	[FieldOffset(0)]
	public uint TextureSno;

	[FieldOffset(4)]
	public int FrameIndex;

	public const int int_1 = 8;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Trickle
{
	[FieldOffset(0)]
	public uint AnnId;

	[FieldOffset(4)]
	public uint ActorSno;

	[FieldOffset(8)]
	public r_WorldPlace WorldPlace;

	[FieldOffset(24)]
	public uint PlayerIndex;

	[FieldOffset(28)]
	public uint LevelAreaSno;

	[FieldOffset(32)]
	public float HealthPercent;

	[FieldOffset(36)]
	public uint TrickleInfoType;

	[FieldOffset(40)]
	public uint TrickleFlags;

	[FieldOffset(44)]
	public r_Texture ImageTextureFrame;

	[FieldOffset(52)]
	public uint StringListSno;

	[FieldOffset(56)]
	public uint StringLabelHandle;

	public const int int_0 = 128;

	[FieldOffset(124)]
	public int dummy;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_UIID
{
	[StructLayout(LayoutKind.Sequential, Size = 512)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct24
	{
		public sbyte sbyte_0;
	}

	[FieldOffset(0)]
	public ulong ulong_0;

	[FieldOffset(8)]
	public unsafe fixed sbyte struct24_0[512];

	[FieldOffset(520)]
	public long long_0;

	[FieldOffset(528)]
	public long long_1;

	public const int Size = 536;

	public const int int_1 = 520;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Waypoint
{
	[FieldOffset(0)]
	public uint uint_0;

	[FieldOffset(12)]
	public uint uint_1;

	[FieldOffset(36)]
	public int int_0;

	[FieldOffset(40)]
	public int int_1;

	public static int Size = 44;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_World
{
	[FieldOffset(8)]
	public uint WorldSno;

	[FieldOffset(16)]
	public uint SWorldID;

	public const int Size = 152;

	[FieldOffset(148)]
	public int dummy;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_WorldPlace
{
	[FieldOffset(0)]
	public float X;

	[FieldOffset(4)]
	public float Y;

	[FieldOffset(8)]
	public float Z;

	[FieldOffset(12)]
	public uint WorldId;

	public const int int_0 = 16;
}
