using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoItemAffixGroup : ISnoItemAffixGroup
{
	[CompilerGenerated]
	private readonly uint uint_0;

	private readonly List<ISnoItemAffix> list_0 = new List<ISnoItemAffix>();

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public IEnumerable<ISnoItemAffix> Affixes => list_0;

	internal SnoItemAffixGroup(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public override string ToString()
	{
		return Id + " (" + list_0[0].Mods[0].Attribute.Code + ")";
	}

	string ISnoItemAffixGroup.ToString()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ToString
		return this.ToString();
	}

	public void AddAffix(ISnoItemAffix affix)
	{
		list_0.Add(affix);
	}

	void ISnoItemAffixGroup.AddAffix(ISnoItemAffix affix)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AddAffix
		this.AddAffix(affix);
	}
}
