using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using SNO;


internal class WaypointManager
{
	public Dictionary<ulong, Waypoint> MapWaypoints { get; internal set; } = new(80);

	private r_Waypoint[] waypoints;
	private readonly Stopwatch stopwatch = new();
	private int delay;

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
		var dictionary = new Dictionary<ulong, Waypoint>(MapWaypoints.Count);
		long num = GameWindowManager.Read<long>(CoreCollector.D3Memory.WaypointManagerAddress);
		int num2 = GameWindowManager.Read<int>(CoreCollector.D3Memory.WaypointManagerAddress + 8);
		if (num2 > 0 && num2 < 1000) {
			if (waypoints == null || waypoints.Length != num2) {
				waypoints = new r_Waypoint[num2];
			}

			waypoints = GameWindowManager.ReadArray<r_Waypoint>(num, num2);
			for (int i = 0; i < num2; i++) {
				ref r_Waypoint r_Waypoint2 = ref waypoints[i];
				uint uint_ = r_Waypoint2.uint_1;

				if (uint_ == 0 || uint_ == uint.MaxValue) continue;

				uint num3 = (uint_ << 10) + r_Waypoint2.uint_0;
				if (!MapWaypoints.TryGetValue(num3, out var value) || value == null) {
					SnoArea snoArea = SnoData.Areas.GetSnoArea(uint_);
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