using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace structs;

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
