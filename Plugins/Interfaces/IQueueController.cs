using System.Collections.Generic;

namespace Plugins;

public interface IQueueController
{
	void AddItem(IQueueItem item);

	IEnumerable<T> GetItems<T>() where T : IQueueItem;
}
