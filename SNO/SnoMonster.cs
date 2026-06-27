using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoMonster
{
	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly MonsterPriority monsterPriority_0;

	[CompilerGenerated]
	private readonly float float_0;

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
	}

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
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

	public bool IsUnique
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public MonsterPriority Priority
	{
		[CompilerGenerated]
		get
		{
			return monsterPriority_0;
		}
	}

	public float RiftProgression
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	internal SnoMonster(SnoActor snoActor_0, uint uint_1, string string_3, string string_4, string string_5, MonsterPriority monsterPriority_1, bool bool_1, float float_1)
	{
		SnoActor_0 = snoActor_0;
		uint_0 = uint_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
		monsterPriority_0 = monsterPriority_1;
		bool_0 = bool_1;
		float_0 = float_1;
	}
}
