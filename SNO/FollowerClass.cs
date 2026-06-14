using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class FollowerClass
{
	public readonly string Code;

	public readonly string Name;

	public readonly ActorSnoEnum ActorSno;

	[CompilerGenerated]
	private readonly FollowerClassEnum followerClassEnum_0;

	public FollowerClassEnum ClassEnum
	{
		[CompilerGenerated]
		get
		{
			return followerClassEnum_0;
		}
	}

	public FollowerClass(string string_0, string string_1, ActorSnoEnum actorSnoEnum_0, FollowerClassEnum followerClassEnum_1)
	{
		Code = string_0;
		Name = string_1;
		ActorSno = actorSnoEnum_0;
		followerClassEnum_0 = followerClassEnum_1;
	}
}
