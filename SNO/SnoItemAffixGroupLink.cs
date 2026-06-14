using System.Globalization;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoItemAffixGroupLink : ISnoItemAffixGroupLink
{
	[CompilerGenerated]
	private readonly ISnoItemAffixGroup isnoItemAffixGroup_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly int int_1;

	public ISnoItemAffixGroup Group
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_0;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public int Flag
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	internal SnoItemAffixGroupLink(ISnoItemAffixGroup isnoItemAffixGroup_1, int int_2, int int_3)
	{
		isnoItemAffixGroup_0 = isnoItemAffixGroup_1;
		int_0 = int_2;
		int_1 = int_3;
	}

	public override string ToString()
	{
		return Group.ToString() + " / " + Level.ToString("D", CultureInfo.InvariantCulture) + " / " + Flag.ToString("D", CultureInfo.InvariantCulture);
	}
}
