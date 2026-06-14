using System.Collections.Generic;
using System.Linq;
using structs;
using Plugins;
using SNO;

internal class PlayerArmorySet(Player class310_1, int int_1) : IPlayerArmorySet
{
	public r_ArmorySet ArmorySet { get; set; }

	public IPlayer Player { get; set; } = class310_1;

	public int Index { get; set; } = int_1;

	public string Name { get; set; }

	public uint PotionAnnId => ArmorySet.struct26_0.uint_0;

	public List<uint> list_0 = new List<uint>();

	public ISnoItem PotionSno => SnoData.Items.GetBySno(ArmorySet.struct26_0.uint_1);

	public ISnoItem CubeSnoItem1 => SnoData.Items.GetBySno(ArmorySet.uint_4);

	public ISnoItem CubeSnoItem2 => SnoData.Items.GetBySno(ArmorySet.uint_5);

	public ISnoItem CubeSnoItem3 => SnoData.Items.GetBySno(ArmorySet.uint_6);

	public ISnoItem CubeSnoItem4 => SnoData.Items.GetBySno(ArmorySet.uint_7);

	public ISnoPower LeftSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_0.uint_0);

	public byte LeftSkillRune => (byte)ArmorySet.struct27_0.uint_1;

	public ISnoPower RightSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_1.uint_0);

	public byte RightSkillRune => (byte)ArmorySet.struct27_1.uint_1;

	public ISnoPower Skill1SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_2.uint_0);

	public byte Skill1Rune => (byte)ArmorySet.struct27_2.uint_1;

	public ISnoPower Skill2SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_3.uint_0);

	public byte Skill2Rune => (byte)ArmorySet.struct27_3.uint_1;

	public ISnoPower Skill3SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_4.uint_0);

	public byte Skill3Rune => (byte)ArmorySet.struct27_4.uint_1;

	public ISnoPower Skill4SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_5.uint_0);

	public byte Skill4Rune => (byte)ArmorySet.struct27_5.uint_1;

	public ISnoPower PassiveSnoPower1 => SnoData.Powers.GetBySno(ArmorySet.uint_0);

	public ISnoPower PassiveSnoPower2 => SnoData.Powers.GetBySno(ArmorySet.uint_1);

	public ISnoPower PassiveSnoPower3 => SnoData.Powers.GetBySno(ArmorySet.uint_2);

	public ISnoPower PassiveSnoPower4 => SnoData.Powers.GetBySno(ArmorySet.uint_3);

	public IEnumerable<uint> ItemAnnIds => list_0;

	public bool ContainsItem(IItem item)
	{
		return list_0.Any((uint uint_0) => item.AnnId == uint_0);
	}

	public void method_1(uint uint_0)
	{
		if (uint_0 != uint.MaxValue)
		{
			list_0.Add(uint_0);
		}
	}
}
