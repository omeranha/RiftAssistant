using System.Drawing;

namespace Plugins;

public interface ISceneRevealController
{
	bool MinimapEnabled { get; set; }

	bool MapEnabled { get; set; }

	float MapOpacity { get; set; }

	float MinimapOpacity { get; set; }

	bool MinimapClip { get; set; }

	SolidBrush BrushKnown { get; set; }

	Brush BrushUnknown { get; set; }

	bool DisplaySceneBorder { get; set; }

	Pen SceneBorderPen { get; set; }
}
