using System.Linq;
using RiftAssistant.Engine;
using Xunit;

namespace RiftAssistant.Tests;

public class ReadPlannerTests
{
	[Fact]
	public void AdjacentItemsShareOneSpan()
	{
		var spans = ReadPlanner.Plan([1000, 1100, 1200], 100);

		var span = Assert.Single(spans);
		Assert.Equal(1000, span.Start);
		Assert.Equal(300, span.Length);
		Assert.Equal([0, 1, 2], span.Items);
	}

	[Fact]
	public void LargeGapsSplitTheSpan()
	{
		var spans = ReadPlanner.Plan([1000, 1000 + 100_000], 100, maxGap: 4096);

		Assert.Equal(2, spans.Count);
		Assert.Equal(1000, spans[0].Start);
		Assert.Equal(101_000, spans[1].Start);
	}

	[Fact]
	public void SpanSizeIsCapped()
	{
		var spans = ReadPlanner.Plan([0x1000, 0x1100, 0x1200, 0x1300], 0x100, maxGap: 4096, maxSpan: 0x200);

		Assert.Equal(2, spans.Count);
		Assert.All(spans, span => Assert.True(span.Length <= 0x200));
	}

	[Fact]
	public void UnsortedAndDuplicateAddressesKeepTheirIndexes()
	{
		var spans = ReadPlanner.Plan([5000, 1000, 5000, 1100], 100);

		Assert.Single(spans, span => span.Start == 1000);
		var all = spans.SelectMany(span => span.Items).OrderBy(index => index).ToArray();
		Assert.Equal([0, 1, 2, 3], all);
	}

	[Fact]
	public void NullAddressesAreSkipped()
	{
		var spans = ReadPlanner.Plan([0, 2000, 0], 64);

		var span = Assert.Single(spans);
		Assert.Equal([1], span.Items);
	}

	[Fact]
	public void EveryItemFitsInsideItsSpan()
	{
		long[] addresses = [900_000, 12_345, 12_700, 13_000, 400_000, 400_050];
		foreach (var span in ReadPlanner.Plan(addresses, 120)) {
			foreach (int item in span.Items) {
				Assert.True(addresses[item] >= span.Start && addresses[item] + 120 <= span.Start + span.Length);
			}
		}
	}
}