using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoSocketedEffect : ISnoSocketedEffect
{
	[CompilerGenerated]
	private readonly ISnoItemType isnoItemType_0;

	[CompilerGenerated]
	private readonly ISnoItemMod[] isnoItemMod_0;

	public ISnoItemType SnoItemType
	{
		[CompilerGenerated]
		get
		{
			return isnoItemType_0;
		}
	}

	public ISnoItemMod[] Mods
	{
		[CompilerGenerated]
		get
		{
			return isnoItemMod_0;
		}
	}

	internal SnoSocketedEffect(ISnoItemType isnoItemType_1, ISnoItemMod[] isnoItemMod_1)
	{
		isnoItemType_0 = isnoItemType_1;
		isnoItemMod_0 = isnoItemMod_1;
	}
}
