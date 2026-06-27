using System.Diagnostics;
using Plugins;
using SNO;

public class MapObject : Actor, IClickableActor
{
	public Stopwatch FirstClicked {  get; set; }

	public Stopwatch LastClicked { get; set; }

	public bool? ShouldBeClicked { get; set; }

	public MapObject(uint uint_7, uint uint_8, SnoActor SnoActor_1) : base(uint_7, uint_8, SnoActor_1)
	{
		IsClickable = true;
	}

	public void RegisterClick()
	{
		FirstClicked.Start();
		LastClicked.Restart();
	}
}
