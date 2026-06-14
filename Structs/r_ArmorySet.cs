using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_ArmorySet
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
