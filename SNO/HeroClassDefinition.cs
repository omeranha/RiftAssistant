using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class HeroClassDefinition
{
	[CompilerGenerated]
	private readonly HeroClass heroClass_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_0;

	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_1;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	public HeroClass HeroClass
	{
		[CompilerGenerated]
		get
		{
			return heroClass_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string FullCode
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public ActorSnoEnum MaleActorSno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_0;
		}
	}

	public ActorSnoEnum FemaleActorSno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_1;
		}
	}

	public bool IsRanged
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public string PrimaryResourceName
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string SecondaryResourceName
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	internal HeroClassDefinition(HeroClass heroClass_1, string string_5, string string_6, string string_7, bool bool_1, ActorSnoEnum actorSnoEnum_2, ActorSnoEnum actorSnoEnum_3, string string_8, string string_9)
	{
		heroClass_0 = heroClass_1;
		string_0 = string_5;
		string_1 = string_6;
		string_2 = string_7;
		bool_0 = bool_1;
		actorSnoEnum_0 = actorSnoEnum_2;
		actorSnoEnum_1 = actorSnoEnum_3;
		string_3 = string_8;
		string_4 = string_9;
	}
}
