using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoActor
{
	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_0;

	[CompilerGenerated]
	private readonly ActorKind actorKind_0;

	[CompilerGenerated]
	private readonly ActorType actorType_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private uint[] uint_0;

	public ActorSnoEnum Sno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_0;
		}
	}

	public ActorKind Kind
	{
		[CompilerGenerated]
		get
		{
			return actorKind_0;
		}
	}

	public ActorType Type
	{
		[CompilerGenerated]
		get
		{
			return actorType_0;
		}
	}

	public bool IsStatic
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
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

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public uint[] TextureMap
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
		[CompilerGenerated]
		set
		{
			uint_0 = value;
		}
	}

	internal SnoActor(ActorSnoEnum actorSnoEnum_1, ActorType actorType_1, ActorKind actorKind_1, bool bool_1, string string_3, string string_4, string string_5)
	{
		actorSnoEnum_0 = actorSnoEnum_1;
		actorKind_0 = actorKind_1;
		actorType_0 = actorType_1;
		bool_0 = bool_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
	}
}
