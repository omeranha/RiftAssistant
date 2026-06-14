using System.Diagnostics;
using Plugins;

internal class MapObject : Actor, IActor, IClickableActor
{
	public Stopwatch FirstClicked {  get; set; }

	public Stopwatch LastClicked { get; set; }

	public bool? ShouldBeClicked { get; set; }

	public MapObject(uint uint_7, uint uint_8, ISnoActor isnoActor_1) : base(uint_7, uint_8, isnoActor_1)
	{
		IsClickable = true;
	}

	public void RegisterClick()
	{
		FirstClicked.Start();
		LastClicked.Restart();
	}
}
