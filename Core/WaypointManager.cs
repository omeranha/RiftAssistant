using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using SNO;
using work;

internal class WaypointManager
{
	public Dictionary<ulong, IWaypoint> MapWaypoints { get; internal set; } = new(80);

	private r_Waypoint[] waypoints;
	private readonly Stopwatch stopwatch = new();
	private int delay;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref r_Waypoint lpBuffer, int nSize, int lpNumberOfBytesRead);

	internal void Clear()
	{
		MapWaypoints.Clear();
		delay = 0;
	}

	internal void Update()
	{
		if (delay != 0 && stopwatch.ElapsedMilliseconds < delay) {
			return;
		}

		stopwatch.Restart();
		var dictionary = new Dictionary<ulong, IWaypoint>(MapWaypoints.Count);
		long num = MR.Instance.ReadAddress(CoreCollector.D3Memory.WaypointManagerAddress);
		int num2 = MR.Instance.ReadInt32_x64(CoreCollector.D3Memory.WaypointManagerAddress + 8);
		if (num2 > 0 && num2 < 1000) {
			if (waypoints == null || waypoints.Length != num2) {
				waypoints = new r_Waypoint[num2];
			}

			ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)num, ref waypoints[0], r_Waypoint.int_2 * num2, 0);
			for (int i = 0; i < num2; i++) {
				ref r_Waypoint r_Waypoint2 = ref waypoints[i];
				uint uint_ = r_Waypoint2.uint_1;

				if (uint_ == 0 || uint_ == uint.MaxValue) continue;

				uint num3 = (uint_ << 10) + r_Waypoint2.uint_0;
				if (!MapWaypoints.TryGetValue(num3, out var value) || value == null) {
					ISnoArea snoArea = SnoData.Areas.GetSnoArea(uint_);
					if (snoArea == null) continue;

					value = new Waypoint(snoArea, (BountyAct)r_Waypoint2.uint_0, new PointF(r_Waypoint2.int_0, r_Waypoint2.int_1));
				}
				dictionary[num3] = value;
			}

			delay = dictionary.Count == MapWaypoints.Count ? 250 : 0;
			MapWaypoints = dictionary;
		} else {
			Clear();
		}
	}
}