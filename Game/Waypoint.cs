using System.Drawing;
using Plugins;
using SNO;

public class Waypoint(SnoArea snoArea, BountyAct bountyAct, PointF pointF)
{
	private SnoArea snoArea = snoArea;

	private BountyAct bountyAct = bountyAct;

	private PointF pointF = pointF;

	public SnoArea TargetSnoArea
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
