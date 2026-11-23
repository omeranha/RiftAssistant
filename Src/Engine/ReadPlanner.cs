using System.Collections.Generic;

namespace RiftAssistant.Engine;

internal readonly record struct ReadSpan(long Start, int Length, int[] Items);

internal static class ReadPlanner
{
	public const int DefaultMaxGap = 4096;
	public const int DefaultMaxSpan = 256 * 1024;

	public static List<ReadSpan> Plan(IReadOnlyList<long> addresses, int itemSize, int maxGap = DefaultMaxGap, int maxSpan = DefaultMaxSpan)
	{
		var order = new List<int>(addresses.Count);
		for (int i = 0; i < addresses.Count; i++) {
			if (addresses[i] != 0) order.Add(i);
		}

		order.Sort((a, b) => addresses[a].CompareTo(addresses[b]));

		var spans = new List<ReadSpan>();
		var items = new List<int>();
		long spanStart = 0;
		long spanEnd = 0;

		foreach (int index in order) {
			long start = addresses[index];
			long end = start + itemSize;
			bool startsNewSpan = items.Count == 0 || start - spanEnd > maxGap || end - spanStart > maxSpan;
			if (startsNewSpan) {
				if (items.Count > 0) spans.Add(new ReadSpan(spanStart, (int)(spanEnd - spanStart), items.ToArray()));
				items.Clear();
				spanStart = start;
				spanEnd = end;
			} else if (end > spanEnd) {
				spanEnd = end;
			}

			items.Add(index);
		}

		if (items.Count > 0) spans.Add(new ReadSpan(spanStart, (int)(spanEnd - spanStart), items.ToArray()));
		return spans;
	}
}