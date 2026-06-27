using System.Collections.Generic;
using System.Linq;
using structs;
using Plugins;
using SNO;

public class PlayerArmorySet(Player class310_1, int int_1)
{
	public r_ArmorySet ArmorySet { get; set; }

	public Player Player { get; set; } = class310_1;

	public int Index { get; set; } = int_1;

	public string Name { get; set; }

	public uint PotionAnnId => ArmorySet.struct26_0.uint_0;

	public List<uint> list_0 = new List<uint>();

	public SnoItem PotionSno => SnoData.Items.GetBySno(ArmorySet.struct26_0.uint_1);

	public SnoItem CubeSnoItem1 => SnoData.Items.GetBySno(ArmorySet.uint_4);

	public SnoItem CubeSnoItem2 => SnoData.Items.GetBySno(ArmorySet.uint_5);

	public SnoItem CubeSnoItem3 => SnoData.Items.GetBySno(ArmorySet.uint_6);

	public SnoItem CubeSnoItem4 => SnoData.Items.GetBySno(ArmorySet.uint_7);

	public SnoPower LeftSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_0.uint_0);

	public byte LeftSkillRune => (byte)ArmorySet.struct27_0.uint_1;

	public SnoPower RightSkillSnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_1.uint_0);

	public byte RightSkillRune => (byte)ArmorySet.struct27_1.uint_1;

	public SnoPower Skill1SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_2.uint_0);

	public byte Skill1Rune => (byte)ArmorySet.struct27_2.uint_1;

	public SnoPower Skill2SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_3.uint_0);

	public byte Skill2Rune => (byte)ArmorySet.struct27_3.uint_1;

	public SnoPower Skill3SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_4.uint_0);

	public byte Skill3Rune => (byte)ArmorySet.struct27_4.uint_1;

	public SnoPower Skill4SnoPower => SnoData.Powers.GetBySno(ArmorySet.struct27_5.uint_0);

	public byte Skill4Rune => (byte)ArmorySet.struct27_5.uint_1;

	public SnoPower PassiveSnoPower1 => SnoData.Powers.GetBySno(ArmorySet.uint_0);

	public SnoPower PassiveSnoPower2 => SnoData.Powers.GetBySno(ArmorySet.uint_1);

	public SnoPower PassiveSnoPower3 => SnoData.Powers.GetBySno(ArmorySet.uint_2);

	public SnoPower PassiveSnoPower4 => SnoData.Powers.GetBySno(ArmorySet.uint_3);

	public IEnumerable<uint> ItemAnnIds => list_0;

	public bool ContainsItem(Item item)
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
