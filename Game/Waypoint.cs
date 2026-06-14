using System.Drawing;
using Plugins;

internal class Waypoint(ISnoArea snoArea, BountyAct bountyAct, PointF pointF) : IWaypoint
{
	private ISnoArea snoArea = snoArea;

	private BountyAct bountyAct = bountyAct;

	private PointF pointF = pointF;

	public ISnoArea TargetSnoArea
	{
		get
		{
			return snoArea;
		}
		set
		{
			snoArea = value;
		}
	}

	public BountyAct BountyAct
	{
		get
		{
			return bountyAct;
		}
		set
		{
			bountyAct = value;
		}
	}

	public PointF CoordinateOnMapUiElement
	{
		get
		{
			return pointF;
		}
		set
		{
			pointF = value;
		}
	}
}
