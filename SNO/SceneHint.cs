using System.Runtime.CompilerServices;
using Plugins;
using work;

namespace SNO;

public class SceneHint
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private WorldCoordinate iworldCoordinate_0;

	public string Hint
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		[CompilerGenerated]
		get
		{
			return iworldCoordinate_0;
		}
		[CompilerGenerated]
		set
		{
			iworldCoordinate_0 = value;
		}
	}

	public SceneHint(string string_1)
	{
		string_0 = string_1;
	}
}
