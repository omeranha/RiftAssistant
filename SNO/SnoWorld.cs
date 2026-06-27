using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoWorld
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly List<SnoArea> list_0 = new List<SnoArea>();

	public List<SnoWorldSceneInfo> SceneInfos = new List<SnoWorldSceneInfo>();

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public List<SnoArea> SnoAreas
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	internal SnoWorld(uint uint_1)
	{
		uint_0 = uint_1;
	}
}
