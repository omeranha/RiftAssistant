using System.Drawing;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Controllers;

public class SceneRevealController
{
	[CompilerGenerated]
	private bool minimapEnabled;

	[CompilerGenerated]
	private bool mapEnabled;

	private float mapOpacity;

	private float minimapOpacity;

	[CompilerGenerated]
	private bool minimapClip;

	[CompilerGenerated]
	private SolidBrush brushKnown;

	[CompilerGenerated]
	private Brush brushUnknown;

	[CompilerGenerated]
	private bool displaySceneBorder;

	[CompilerGenerated]
	private Pen sceneBorderPen;

	public bool MinimapEnabled
	{
		[CompilerGenerated]
		get
		{
			return minimapEnabled;
		}
		[CompilerGenerated]
		set
		{
			minimapEnabled = value;
		}
	}

	public bool MapEnabled
	{
		[CompilerGenerated]
		get
		{
			return mapEnabled;
		}
		[CompilerGenerated]
		set
		{
			mapEnabled = value;
		}
	}

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

	public bool MinimapClip
	{
		[CompilerGenerated]
		get
		{
			return minimapClip;
		}
		[CompilerGenerated]
		set
		{
			minimapClip = value;
		}
	}

	public SolidBrush BrushKnown
	{
		[CompilerGenerated]
		get
		{
			return brushKnown;
		}
		[CompilerGenerated]
		set
		{
			brushKnown = value;
		}
	}

	public Brush BrushUnknown
	{
		[CompilerGenerated]
		get
		{
			return brushUnknown;
		}
		[CompilerGenerated]
		set
		{
			brushUnknown = value;
		}
	}

	public bool DisplaySceneBorder
	{
		[CompilerGenerated]
		get
		{
			return displaySceneBorder;
		}
		[CompilerGenerated]
		set
		{
			displaySceneBorder = value;
		}
	}

	public Pen SceneBorderPen
	{
		[CompilerGenerated]
		get
		{
			return sceneBorderPen;
		}
		[CompilerGenerated]
		set
		{
			sceneBorderPen = value;
		}
	}

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
