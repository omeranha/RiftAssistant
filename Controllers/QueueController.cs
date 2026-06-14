using System;
using System.Collections.Generic;
using Plugins;

internal class QueueController : IQueueController
{
	private readonly List<IQueueItem> list_0 = [];

	private void Refresh()
	{
		if (list_0.Count == 0) {
			return;
		}
		DateTime now = DateTime.Now;
		int num = 0;
		while (num < list_0.Count) {
			IQueueItem queueItem = list_0[num];
			if (queueItem.QueuedOn.Add(queueItem.LifeTime) < now) {
				list_0.RemoveAt(num);
			} else {
				num++;
			}
		}
	}

	public void AddItem(IQueueItem item)
	{
		list_0.Add(item);
	}

	public IEnumerable<T> GetItems<T>() where T : IQueueItem
	{
		if (list_0.Count <= 0) {
			yield break;
		}
		Refresh();
		DateTime now = DateTime.Now;
		foreach (IQueueItem item in list_0) {
			if (item is T val && item.QueuedOn.Add(item.LifeTime) >= now) {
				yield return val;
			}
		}
	}
}
