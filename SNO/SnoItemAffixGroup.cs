using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoItemAffixGroup
{
	[CompilerGenerated]
	private readonly uint uint_0;

	private readonly List<SnoItemAffix> list_0 = new List<SnoItemAffix>();

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public IEnumerable<SnoItemAffix> Affixes => list_0;

	internal SnoItemAffixGroup(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public override string ToString()
	{
		return Id + " (" + list_0[0].Mods[0].Attribute.Code + ")";
	}

	public void AddAffix(SnoItemAffix affix)
	{
		list_0.Add(affix);
	}
}
