using System.Runtime.CompilerServices;
using Plugins;

namespace SNO;

public class SnoQuestStep : ISnoQuestStep
{
	[CompilerGenerated]
	private readonly ISnoQuest isnoQuest_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	[CompilerGenerated]
	private readonly string string_5;

	public ISnoQuest SnoQuest
	{
		[CompilerGenerated]
		get
		{
			return isnoQuest_0;
		}
	}

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string SplashLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string SplashEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string BnetTitleLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string BnetTitleEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string BnetTextLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	public string BnetTextEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
	}

	internal SnoQuestStep(ISnoQuest isnoQuest_1, uint uint_1, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11)
	{
		isnoQuest_0 = isnoQuest_1;
		uint_0 = uint_1;
		string_0 = string_6;
		string_1 = string_7;
		string_2 = string_8;
		string_3 = string_9;
		string_4 = string_10;
		string_5 = string_11;
	}
}
