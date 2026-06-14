using System.Diagnostics;

namespace Plugins;

public interface IClickableActor : IActor
{
	Stopwatch FirstClicked { get; }

	Stopwatch LastClicked { get; }

	bool? ShouldBeClicked { get; set; }

	void RegisterClick();
}
