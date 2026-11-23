using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace RiftAssistant.Controllers;

internal sealed class PerSecCounter(int windowMs = 1000) : IPerfCounter
{
	private readonly Stopwatch window = Stopwatch.StartNew();
	private double count;
	private double total;
	private long measureStart;

	public double LastCount { get; private set; }

	public double LastValue { get; private set; }

	public void Add(double value)
	{
		long elapsed = window.ElapsedMilliseconds;
		if (elapsed < windowMs) {
			count++;
			total += value;
			return;
		}

		LastCount = count > 0 ? count / elapsed * 1000.0 : 0.0;
		LastValue = count > 0 ? total / elapsed * 1000.0 : 0.0;
		count = 1;
		total = value;
		window.Restart();
	}

	public void StartMeasure()
	{
		measureStart = Stopwatch.GetTimestamp();
	}

	public double EndMeasure()
	{
		if (measureStart == 0) return 0.0;

		double milliseconds = Stopwatch.GetElapsedTime(measureStart).TotalMilliseconds;
		Add(milliseconds);
		return milliseconds;
	}
}

public class StatController
{
	private static readonly IReadOnlyDictionary<string, IPerfCounter> NoCounters = new Dictionary<string, IPerfCounter>();

	private readonly ConcurrentDictionary<IPlugin, ConcurrentDictionary<string, PerSecCounter>> pluginCounters = new();

	public IPerfCounter RenderPerfCounter => Overlay.Instance.RenderCounter;

	internal readonly PerSecCounter MemoryReads = new();

	public IPerfCounter MemoryReadPerfCounter => MemoryReads;

	public IPerfCounter MonsterHitpointDecreasePerfCounter => CoreCollector.ActorCollector.MonsterHitpointDecrease;

	public IReadOnlyDictionary<string, IPerfCounter> GetPluginCounters(IPlugin plugin)
	{
		if (!pluginCounters.TryGetValue(plugin, out var counters)) return NoCounters;

		var result = new Dictionary<string, IPerfCounter>(counters.Count);
		foreach (var pair in counters) {
			result[pair.Key] = pair.Value;
		}

		return result;
	}

	internal void Measure(IPlugin plugin, string name, long startTimestamp)
	{
		var counters = pluginCounters.GetOrAdd(plugin, static _ => new ConcurrentDictionary<string, PerSecCounter>());
		counters.GetOrAdd(name, static _ => new PerSecCounter()).Add(Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds);
	}

	internal void Clear()
	{
		pluginCounters.Clear();
	}
}