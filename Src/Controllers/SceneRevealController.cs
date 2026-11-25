using System.Drawing;

namespace RiftAssistant.Controllers;

public class SceneRevealController
{

	private float mapOpacity;

	private float minimapOpacity;

	public bool MinimapEnabled { get; set; }

	public bool MapEnabled { get; set; }

	public float MapOpacity
	{
		get
		{
			return mapOpacity;
		}
		set
		{
			mapOpacity = value / 255f;
		}
	}

	public float MinimapOpacity
	{
		get
		{
			return minimapOpacity;
		}
		set
		{
			minimapOpacity = value / 255f;
		}
	}

	public bool MinimapClip { get; set; }

	public SolidBrush BrushKnown { get; set; }

	public Brush BrushUnknown { get; set; }

	public bool DisplaySceneBorder { get; set; }

	public Pen SceneBorderPen { get; set; }

	public SceneRevealController()
	{
		MinimapEnabled = true;
		MapEnabled = true;
		MapOpacity = 100f;
		MinimapOpacity = 50f;
		MinimapClip = true;
		BrushKnown = new SolidBrush(Color.FromArgb(64, 180, 180, 250));
		BrushUnknown = new SolidBrush(Color.FromArgb(64, 255, 0, 0));
		DisplaySceneBorder = false;
		SceneBorderPen = new Pen(Color.FromArgb(255, 255, 255, 0));
	}
}
