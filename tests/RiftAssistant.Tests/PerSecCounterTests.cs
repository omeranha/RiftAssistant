using System.Threading;
using RiftAssistant.Controllers;
using Xunit;

namespace RiftAssistant.Tests;

public class PerSecCounterTests
{
	[Fact]
	public void ReportsNothingBeforeTheFirstWindowCloses()
	{
		var counter = new PerSecCounter(10_000);
		counter.Add(5);
		counter.Add(5);

		Assert.Equal(0, counter.LastCount);
		Assert.Equal(0, counter.LastValue);
	}

	[Fact]
	public void ReportsRatesPerSecondAfterTheWindowCloses()
	{
		var counter = new PerSecCounter(50);
		counter.Add(10);
		counter.Add(10);
		Thread.Sleep(80);
		counter.Add(10);

		Assert.InRange(counter.LastCount, 1, 100);
		Assert.True(counter.LastValue > counter.LastCount);
	}
}
