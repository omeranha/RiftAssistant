using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoSocketedEffect
{
	[CompilerGenerated]
	private readonly SnoItemType SnoItemType_0;

	[CompilerGenerated]
	private readonly SnoItemMod[] isnoItemMod_0;

	public SnoItemType SnoItemType
	{
		[CompilerGenerated]
		get
		{
			return SnoItemType_0;
		}
	}

	public SnoItemMod[] Mods
	{
		[CompilerGenerated]
		get
		{
			return isnoItemMod_0;
		}
	}

	internal SnoSocketedEffect(SnoItemType SnoItemType_1, SnoItemMod[] isnoItemMod_1)
	{
		SnoItemType_0 = SnoItemType_1;
		isnoItemMod_0 = isnoItemMod_1;
	}
}
