using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;

public class MonsterPack
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private SnoMonster SnoMonster_0;

	[CompilerGenerated]
	private SnoMonster SnoMonster_1;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private List<SnoMonsterAffix> list_0;

	[CompilerGenerated]
	private readonly Class112<double, Monster> class112_0 = new Class112<double, Monster>();

	[CompilerGenerated]
	private readonly Class112<double, Monster> class112_1 = new Class112<double, Monster>();

	[CompilerGenerated]
	private readonly Class112<double, Monster> class112_2 = new Class112<double, Monster>();

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

	public SnoMonster LeadSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return SnoMonster_0;
		}
		[CompilerGenerated]
		set
		{
			SnoMonster_0 = value;
		}
	}

	public IEnumerable<SnoMonsterAffix> AffixSnoList => List_0;

	public IEnumerable<Monster> MonstersAlive => Class112_0.IEnumerable_0;

	public IEnumerable<Monster> MonstersKilled => Class112_1.IEnumerable_0;

	public IEnumerable<Monster> MonstersUnknown => Class112_2.IEnumerable_0;

	public SnoMonster MinionSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return SnoMonster_1;
		}
		[CompilerGenerated]
		set
		{
			SnoMonster_1 = value;
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

	public List<SnoMonsterAffix> List_0
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

	public Class112<double, Monster> Class112_0
	{
		[CompilerGenerated]
		get
		{
			return class112_0;
		}
	}

	public Class112<double, Monster> Class112_1
	{
		[CompilerGenerated]
		get
		{
			return class112_1;
		}
	}

	public Class112<double, Monster> Class112_2
	{
		[CompilerGenerated]
		get
		{
			return class112_2;
		}
	}
}
