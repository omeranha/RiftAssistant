using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;

internal class MonsterPack : IMonsterPack
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private ISnoMonster isnoMonster_0;

	[CompilerGenerated]
	private ISnoMonster isnoMonster_1;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private List<ISnoMonsterAffix> list_0;

	[CompilerGenerated]
	private readonly Class112<double, IMonster> class112_0 = new Class112<double, IMonster>();

	[CompilerGenerated]
	private readonly Class112<double, IMonster> class112_1 = new Class112<double, IMonster>();

	[CompilerGenerated]
	private readonly Class112<double, IMonster> class112_2 = new Class112<double, IMonster>();

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool IsFullChampionPack
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public ISnoMonster LeadSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return isnoMonster_0;
		}
		[CompilerGenerated]
		set
		{
			isnoMonster_0 = value;
		}
	}

	public IEnumerable<ISnoMonsterAffix> AffixSnoList => List_0;

	public IEnumerable<IMonster> MonstersAlive => Class112_0.IEnumerable_0;

	public IEnumerable<IMonster> MonstersKilled => Class112_1.IEnumerable_0;

	public IEnumerable<IMonster> MonstersUnknown => Class112_2.IEnumerable_0;

	public ISnoMonster MinionSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return isnoMonster_1;
		}
		[CompilerGenerated]
		set
		{
			isnoMonster_1 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public List<ISnoMonsterAffix> List_0
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public Class112<double, IMonster> Class112_0
	{
		[CompilerGenerated]
		get
		{
			return class112_0;
		}
	}

	public Class112<double, IMonster> Class112_1
	{
		[CompilerGenerated]
		get
		{
			return class112_1;
		}
	}

	public Class112<double, IMonster> Class112_2
	{
		[CompilerGenerated]
		get
		{
			return class112_2;
		}
	}
}
