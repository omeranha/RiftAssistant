using System.Diagnostics;

namespace Plugins;

public interface IClickableActor
{
	Stopwatch FirstClicked { get; }

	Stopwatch LastClicked { get; }

	bool? ShouldBeClicked { get; set; }

	void RegisterClick();
}
