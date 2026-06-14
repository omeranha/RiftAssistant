using System.Drawing;
using System.Runtime.CompilerServices;
using Plugins;

internal class SceneRevealController : ISceneRevealController
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	private float float_0;

	private float float_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private SolidBrush solidBrush_0;

	[CompilerGenerated]
	private Brush brush_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private Pen pen_0;

	public bool MinimapEnabled
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

	public bool MapEnabled
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public float MapOpacity
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value / 255f;
		}
	}

	public float MinimapOpacity
	{
		get
		{
			return float_1;
		}
		set
		{
			float_1 = value / 255f;
		}
	}

	public bool MinimapClip
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public SolidBrush BrushKnown
	{
		[CompilerGenerated]
		get
		{
			return solidBrush_0;
		}
		[CompilerGenerated]
		set
		{
			solidBrush_0 = value;
		}
	}

	public Brush BrushUnknown
	{
		[CompilerGenerated]
		get
		{
			return brush_0;
		}
		[CompilerGenerated]
		set
		{
			brush_0 = value;
		}
	}

	public bool DisplaySceneBorder
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public Pen SceneBorderPen
	{
		[CompilerGenerated]
		get
		{
			return pen_0;
		}
		[CompilerGenerated]
		set
		{
			pen_0 = value;
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
