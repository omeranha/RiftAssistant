using System;

namespace Plugins.Default;

public class StandardPingRadiusTransformator : IRadiusTransformator
{
	public Controller Assistant { get; }

	public int PingSpeed { get; set; }
	public float RadiusMinimumMultiplier { get; set; }
	public float RadiusMaximumMultiplier { get; set; }

	public StandardPingRadiusTransformator(Controller assistant, int pingSpeed, float radiusMinimumMultiplier = 0.5f, float radiusMaximumMultiplier = 1.0f)
	{
		Assistant = assistant;
		PingSpeed = pingSpeed;
		RadiusMinimumMultiplier = radiusMinimumMultiplier;
		RadiusMaximumMultiplier = radiusMaximumMultiplier;
	}

	public float TransformRadius(float radius)
	{
		if (PingSpeed <= 0)
			return radius;

		var msec = Assistant.Game.CurrentRealTimeMilliseconds;
		return Math.Floor((double)msec / PingSpeed) % 2 == 1
			? radius * (RadiusMinimumMultiplier + ((RadiusMaximumMultiplier - RadiusMinimumMultiplier) * (msec % PingSpeed) / PingSpeed))
			: radius * (RadiusMaximumMultiplier - ((RadiusMaximumMultiplier - RadiusMinimumMultiplier) * (msec % PingSpeed) / PingSpeed));
	}
}
