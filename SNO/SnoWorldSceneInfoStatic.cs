using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoWorldSceneInfoStatic : SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly SnoScene isnoScene_0;

	public SnoScene SnoScene
	{
		[CompilerGenerated]
		get
		{
			return isnoScene_0;
		}
	}

	internal SnoWorldSceneInfoStatic(float float_6, float float_7, float float_8, float float_9, SnoArea isnoArea_1, SnoScene isnoScene_1)
		: base(float_6, float_7, float_8, float_9, isnoArea_1)
	{
		isnoScene_0 = isnoScene_1;
	}
}
