using System.Drawing;

namespace Plugins;

public interface IWaypoint
{
	ISnoArea TargetSnoArea { get; }

	BountyAct BountyAct { get; }

	PointF CoordinateOnMapUiElement { get; }
}
