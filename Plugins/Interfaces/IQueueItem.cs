using System;

namespace Plugins;

public interface IQueueItem
{
	DateTime QueuedOn { get; }

	TimeSpan LifeTime { get; }
}
