using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public sealed class SnoMonsterAffix : ISnoMonsterAffix
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly MonsterAffix monsterAffix_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public MonsterAffix Affix
	{
		[CompilerGenerated]
		get
		{
			return monsterAffix_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	internal SnoMonsterAffix(uint uint_1, MonsterAffix monsterAffix_1, string string_2, string string_3)
	{
		uint_0 = uint_1;
		monsterAffix_0 = monsterAffix_1;
		string_0 = string_2 ?? monsterAffix_1.ToString();
		string_1 = string_3 ?? monsterAffix_1.ToString();
	}

	public override string ToString()
	{
		return NameLocalized;
	}
}
