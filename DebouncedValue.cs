using System.Diagnostics;

internal class DebouncedValue<T>(T gparam_2, int int_1 = 1000)
{
	private T currentValue = gparam_2;

	private T pendingValue;

	private Stopwatch stopwatch_0;

	public int DelayMs { get; set; } = int_1;

	public T Value
	{
		get {
			return GetValue();
		}
		set {
			SetValue(value);
		}
	}

	private T GetValue()
	{
		Stopwatch stopwatch = stopwatch_0;
		if (stopwatch != null && IsRunning(stopwatch) && GetElapsedMilliseconds(stopwatch_0) >= DelayMs) {
			currentValue = pendingValue;
			StopTimer(stopwatch_0);
		}
		return currentValue;
	}

	private void SetValue(T gparam_2)
	{
		if (!pendingValue.Equals(gparam_2)) {
			if (stopwatch_0 == null) {
				stopwatch_0 = StartNewTimer();
			} else {
				RestartTimer(stopwatch_0);
			}
			pendingValue = gparam_2;
		}
	}

	public void ForceSet(T gparam_2)
	{
		currentValue = gparam_2;
		pendingValue = gparam_2;
		Stopwatch stopwatch = stopwatch_0;
		if (stopwatch != null) {
			StopTimer(stopwatch);
		}
	}

	static bool IsRunning(Stopwatch stopwatch_1)
	{
		return stopwatch_1.IsRunning;
	}

	static long GetElapsedMilliseconds(Stopwatch stopwatch_1)
	{
		return stopwatch_1.ElapsedMilliseconds;
	}

	static void StopTimer(Stopwatch stopwatch_1)
	{
		stopwatch_1.Stop();
	}

	static Stopwatch StartNewTimer()
	{
		return Stopwatch.StartNew();
	}

	static void RestartTimer(Stopwatch stopwatch_1)
	{
		stopwatch_1.Restart();
	}
}
