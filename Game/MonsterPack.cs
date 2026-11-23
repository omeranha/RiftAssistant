using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SNO;

public class MonsterPack
{
	[CompilerGenerated]
	private bool isFullChampionPack;

	[CompilerGenerated]
	private SnoMonster leadSnoMonster;

	[CompilerGenerated]
	private SnoMonster minionSnoMonster;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private List<SnoMonsterAffix> affixSnoList;

	[CompilerGenerated]
	private readonly Dictionary<double, Monster> monstersAlive = new Dictionary<double, Monster>();

	[CompilerGenerated]
	private readonly Dictionary<double, Monster> monstersKilled = new Dictionary<double, Monster>();

	[CompilerGenerated]
	private readonly Dictionary<double, Monster> monstersUnknown = new Dictionary<double, Monster>();

	public Stopwatch LastActive { get; } = new Stopwatch();

	public bool IsFullChampionPack
	{
		[CompilerGenerated]
		get
		{
			return isFullChampionPack;
		}
		[CompilerGenerated]
		set
		{
			isFullChampionPack = value;
		}
	}

	public SnoMonster LeadSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return leadSnoMonster;
		}
		[CompilerGenerated]
		set
		{
			leadSnoMonster = value;
		}
	}

	public IEnumerable<SnoMonsterAffix> AffixSnoList => AffixSnoList2;

	public IEnumerable<Monster> MonstersAlive => MonstersAlive2.Values;

	public IEnumerable<Monster> MonstersKilled => MonstersKilled2.Values;

	public IEnumerable<Monster> MonstersUnknown => MonstersUnknown2.Values;

	public SnoMonster MinionSnoMonster
	{
		[CompilerGenerated]
		get
		{
			return minionSnoMonster;
		}
		[CompilerGenerated]
		set
		{
			minionSnoMonster = value;
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

	public List<SnoMonsterAffix> AffixSnoList2
	{
		[CompilerGenerated]
		get
		{
			return affixSnoList;
		}
		[CompilerGenerated]
		set
		{
			affixSnoList = value;
		}
	}

	public Dictionary<double, Monster> MonstersAlive2
	{
		[CompilerGenerated]
		get
		{
			return monstersAlive;
		}
	}

	public Dictionary<double, Monster> MonstersKilled2
	{
		[CompilerGenerated]
		get
		{
			return monstersKilled;
		}
	}

	public Dictionary<double, Monster> MonstersUnknown2
	{
		[CompilerGenerated]
		get
		{
			return monstersUnknown;
		}
	}
}
