using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using work;

public record struct CombatNumberEvent(long Id, double Value);

internal class FloatingNumberManager
{
	public AllocationCache<r_FloatingNumber> FloatingNumberCache { get; } = new(ReadProcessMemory, 112);

	private readonly Class112<string, CombatNumberEvent> eventCache = [];
	private readonly HashSet<string> ignoredEvents = [];

	private readonly Class112<int, List<CombatNumberEvent>> damageDealtEvents = [];

	private readonly Class112<int, List<CombatNumberEvent>> damageTakenEvents = [];

	private readonly Class112<int, List<CombatNumberEvent>> healingEvents = [];

	private int lastGameTick;
	private int lastDamageTick;
	private int totalCombatTicks;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_FloatingNumber struct13_0, int int_3, int int_4);

	internal void Clear(Player player)
	{
		eventCache.Clear();
		damageDealtEvents.Clear();
		damageTakenEvents.Clear();
		healingEvents.Clear();

		lastGameTick = 0;
		lastDamageTick = 0;
		totalCombatTicks = 0;

		player.Damage.TotalDamage = 0.0;
		player.Damage.RunDps = 0.0;
		player.Damage.CurrentDps = 0.0;
		player.Damage.MaximumDps = 0.0;
		player.Defense.CurrentDamageTakenPerSecond = 0.0;
		player.Defense.CurrentHealingPerSecond = 0.0;
	}

	internal void Update(Player player)
	{
		if (CoreCollector.D3Memory.FloatingNumberAllocator.RawAllocator.ElementSize != 112) {
			Logger.LogException("Unexpected structure size for r_FloatingNumber. Expected 112 bytes.");
			return;
		}

		FloatingNumberCache.Snapshot(CoreCollector.D3Memory.FloatingNumberAllocator);
		bool isFirstTick = eventCache.Int32_0 == 0 && ignoredEvents.Count == 0;

		IBuff conduitBuff = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_PagesBuffElectrified.Sno);
		bool hasPylon = conduitBuff != null && conduitBuff.LastActive.ElapsedMilliseconds <= 3000;
		if (!hasPylon) {
			IBuff riftConduit = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_PagesBuffElectrifiedTieredRift.Sno);
			hasPylon = riftConduit != null && riftConduit.LastActive.ElapsedMilliseconds <= 3000;
		}

		if (lastGameTick != 0 && lastGameTick == CoreCollector.D3Memory.GameTick) {
			return;
		}

		lastGameTick = CoreCollector.D3Memory.GameTick;
		List<CombatNumberEvent> damageList = damageDealtEvents.TryGetValue(CoreCollector.D3Memory.GameTick, out var dmgList) ? dmgList : null;
		List<CombatNumberEvent> damageTakenList = damageTakenEvents.TryGetValue(CoreCollector.D3Memory.GameTick, out var dmgTakenList) ? dmgTakenList : null;
		List<CombatNumberEvent> healingList = healingEvents.TryGetValue(CoreCollector.D3Memory.GameTick, out var healList) ? healList : null;
		bool hasNewDamage = false;
		foreach (r_FloatingNumber item in FloatingNumberCache.GetItems()) {
			if (item.int_0 == 0) continue;

			int id = item.int_1;
			float value = item.float_3;
			Enum3 type = item.enum3_0;
			string eventKey = id.ToString("D", CultureInfo.InvariantCulture) + value.ToString("F2", CultureInfo.InvariantCulture) + (int)type;
			if (eventCache.Contains(eventKey) || ignoredEvents.Contains(eventKey)) {
				continue;
			}

			uint actorId = item.uint_1;
			if (actorId != player.ActorId) {
				if (CoreCollector.PlayerCollector.PlayersInGame.Any(p => p.ActorId == actorId)) {
					ignoredEvents.Add(eventKey);
					continue;
				}

				if (type == Enum3.DealtNonCrit || type == Enum3.DealtUnknown || type == Enum3.DealtCrit || type == Enum3.Unknown28) {
					CombatNumberEvent dmgEvent = new(id, value);
					eventCache [eventKey] = dmgEvent;

					if (isFirstTick || hasPylon) continue;

					foreach (StatTracker tracker in CoreCollector.Trackers) {
						tracker.DamageDealtAll += value;
						if (type == Enum3.DealtCrit || type == Enum3.Unknown28) {
							tracker.DamageDealtCrit += value;
						}
					}

					if (damageList == null) {
						damageList = new();
						damageDealtEvents[CoreCollector.D3Memory.GameTick] = damageList;
					}

					damageList.Add(dmgEvent);
					player.Damage.TotalDamage += value;
					hasNewDamage = true;
					continue;
				}
			} else {
				if (type == Enum3.TakenCrit || type == Enum3.TakenNonCrit || type == Enum3.TakenUnknown) {
					CombatNumberEvent takenEvent = new(id, value);
					eventCache [eventKey] = takenEvent;

					foreach (StatTracker tracker in CoreCollector.Trackers) {
						tracker.DamageTaken += value;
					}

					if (damageTakenList == null) {
						damageTakenList = new();
						damageTakenEvents[CoreCollector.D3Memory.GameTick] = damageTakenList;
					}

					damageTakenList.Add(takenEvent);
					continue;
				}

				if (type == Enum3.Heal10) {
					CombatNumberEvent healEvent = new(id, value);
					eventCache [eventKey] = healEvent;

					foreach (StatTracker tracker in CoreCollector.Trackers) {
						tracker.Healing += value;
					}

					if (healingList == null) {
						healingList = [];
						healingEvents[CoreCollector.D3Memory.GameTick] = healingList;
					}

					healingList.Add(healEvent);
					continue;
				}
			}

			ignoredEvents.Add(eventKey);
		}

		if (hasNewDamage) {
			int ticksSinceLast = CoreCollector.D3Memory.GameTick - lastDamageTick;
			if (ticksSinceLast > 0) {
				totalCombatTicks += (ticksSinceLast >= 60) ? 60 : ticksSinceLast;
			}
			lastDamageTick = CoreCollector.D3Memory.GameTick;
		}

		int targetTick = CoreCollector.D3Memory.GameTick - 60;

		double currentDps = damageDealtEvents.Where(kvp => kvp.Key >= targetTick).SelectMany(kvp => kvp.Value).Sum(e => e.Value);
		if (currentDps == 0.0 && damageDealtEvents.Int32_0 > 0) {
			damageDealtEvents.Clear();
		}
		player.Damage.RunDps = (totalCombatTicks <= 2) ? 0.0 : (player.Damage.TotalDamage * 60.0 / Math.Max(1, totalCombatTicks));
		player.Damage.CurrentDps = currentDps;
		if (player.Damage.CurrentDps > player.Damage.MaximumDps) {
			player.Damage.MaximumDps = player.Damage.CurrentDps;
		}

		double currentDamageTaken = damageTakenEvents.Where(kvp => kvp.Key >= targetTick).SelectMany(kvp => kvp.Value).Sum(e => e.Value);
		if (currentDamageTaken == 0.0 && damageTakenEvents.Int32_0 > 0) {
			damageTakenEvents.Clear();
		}
		player.Defense.CurrentDamageTakenPerSecond = currentDamageTaken;

		double currentHealing = healingEvents.Where(kvp => kvp.Key >= targetTick).SelectMany(kvp => kvp.Value).Sum(e => e.Value);
		if (currentHealing == 0.0 && healingEvents.Int32_0 > 0) {
			healingEvents.Clear();
		}
		player.Defense.CurrentHealingPerSecond = currentHealing;
	}
}
