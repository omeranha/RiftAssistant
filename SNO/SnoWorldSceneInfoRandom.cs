using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoWorldSceneInfoRandom : SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly List<SnoScene> list_0 = new List<SnoScene>();

	public List<SnoScene> SnoScenes
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	internal SnoWorldSceneInfoRandom(float float_6, float float_7, float float_8, float float_9, SnoArea isnoArea_1)
		: base(float_6, float_7, float_8, float_9, isnoArea_1)
	{
	}
}
