namespace Plugins.Default;

public class CircularRotationTransformator : IRotationTransformator
{
	public Controller Assistant { get; }
	public int Speed { get; set; }

	public CircularRotationTransformator(Controller assistant, int speed)
	{
		Assistant = assistant;
		Speed = speed;
	}

	public float TransformRotation(float angle)
	{
		if (Speed <= 0)
			return angle;

		var msec = Assistant.Game.CurrentRealTimeMilliseconds;

		return msec / Speed % 360;
	}
}
