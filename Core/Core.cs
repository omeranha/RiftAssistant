using Plugins;
using SNO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using work;

public static class Core
{
	private static float OverlayFrameInterval => 1000f / Settings.OverlayFps;

	public static Settings Settings = new();

	public static IReadOnlyList<Hotkey> HotkeyList;

	internal static PluginHandler PluginHandler;

	public static Controller Controller { get; private set; }

	public static SettingsMenu SettingsMenu { get; set; }

	public static PluginListMenu PluginListMenu { get; set; }

	private static bool running = true;

	public static void Init()
	{
		MouseBlocker.Start();

		Settings = SettingsManager.Load();
		HotkeyList = Hotkeys.Load();
		SnoData.Load();

		Controller = new Controller();
		CoreCollector.Controller = Controller;
		new Overlay(Controller);

		CoreCollector.ItemCollector.OnLootGenerated += ProcessLoot;

		CoreCollector.OnNewArea += (_, _) => {
			Overlay.Instance.class204_0.ResetRenderer();
			Overlay.Instance.ModuleStatTracker.Show = false;
		};

		CoreCollector.EventHandler_5 += (_, _) => {
			Overlay.Instance.class204_0.ResetRenderer();
		};

		Application.ThreadException += (_, e) => {
			if (e.Exception != null) {
				Logger.LogException(e.Exception.Message);
			}
		};
		AppDomain.CurrentDomain.UnhandledException += (_, e) => {
			if (e.ExceptionObject is Exception ex) {
				Logger.LogException(ex.Message);
			}
		};

		GameWindowManager.Window.WindowTitle = Settings.DiabloWindowTitle;
		CoreCollector.ClearAllCaches();
		Overlay.Instance.RecreateSharedFonts();
		Overlay.Instance.InitializeModulesFromConfig(Settings);

		SettingsMenu = new(Settings);
		PluginHandler = new PluginHandler(Controller);
		PluginHandler.LoadPlugins();
		PluginListMenu = new PluginListMenu();
		PluginListMenu.Reload();
		CoreCollector.Update();
	}

	private static void ProcessLoot(object sender, LootGenerated e)
	{
		if (e.item.SnoItem.Kind == ItemKind.goldcoin) {
			uint amount = e.item.Amount;
			string item = e.item.FloorCoordinate.ToStringCompactPrecise() + "/" + amount.ToString("D", CultureInfo.InvariantCulture);
			if (!CoreCollector.class364_0.TrackedStrings.Contains(item)) {
				foreach (StatTracker item2 in CoreCollector.Trackers) {
					item2.DropGold += amount;
				}
				CoreCollector.class364_0.TrackedStrings.Add(item);
			}
		}
		if ((e.item.SnoItem.Kind != ItemKind.loot && e.item.SnoItem.Kind != ItemKind.uberstuff && e.item.SnoItem.Kind != ItemKind.gem && e.item.SnoItem.Kind != ItemKind.craft) || CoreCollector.class364_0.TrackedLongs.Contains(e.item.Seed)) {
			return;
		}
		foreach (StatTracker item3 in CoreCollector.Trackers) {
			item3.DropAll++;
		}
		if ((int)e.item.Quality >= 0 && (int)e.item.Quality <= 2) {
			foreach (StatTracker item4 in CoreCollector.Trackers) {
				item4.DropWhite++;
			}
		} else if ((int)e.item.Quality >= 3 && (int)e.item.Quality <= 5) {
			foreach (StatTracker item5 in CoreCollector.Trackers) {
				item5.DropMagic++;
			}
		} else if ((int)e.item.Quality >= 6 && (int)e.item.Quality <= 8) {
			foreach (StatTracker item6 in CoreCollector.Trackers) {
				item6.DropRare++;
			}
		}
		if (e.item.Unidentified && e.item.Quality == ItemQuality.Legendary) {
			foreach (StatTracker item7 in CoreCollector.Trackers) {
				item7.DropLegendary++;
			}
			int ancientRank = e.item.AncientRank;
			if (ancientRank > 0) {
				foreach (StatTracker item8 in CoreCollector.Trackers) {
					item8.DropAncient++;
				}
				if (ancientRank > 1) {
					foreach (StatTracker item9 in CoreCollector.Trackers) {
						item9.DropPrimalAncient++;
					}
				}
			}
		}
		if (e.item.SnoItem.Sno == 2603730171u) {
			foreach (StatTracker item10 in CoreCollector.Trackers) {
				item10.DropBloodShard += (uint)Math.Max(0L, e.item.Quantity);
			}
		}
		CoreCollector.class364_0.TrackedLongs.Add(e.item.Seed);
	}

	private static void ProcessInput()
	{
		if (GameWindowManager.Window.Handle == IntPtr.Zero || !GameWindowManager.Window.IsForeground) return;

		while (RawInput.mouseEvents.TryDequeue(out var e)) {
			PluginHandler?.DispatchKeyEvent(new InputEvent(e.Key, e.Down, e.Shift, e.Ctrl, e.Alt));
		}

		while (RawInput.events.TryDequeue(out var e)) {
			PluginHandler?.DispatchKeyEvent(new InputEvent(e.Key, e.Down, e.Shift, e.Ctrl, e.Alt));

			if (!e.Down) continue;

			foreach (var hotkey in HotkeyList) {
				if (hotkey.Key != e.Key || e.Key == Vk.None) continue;

				bool requiresShift = hotkey.Modifiers.Contains("shift");
				bool requiresCtrl = hotkey.Modifiers.Contains("ctrl");
				bool requiresAlt = hotkey.Modifiers.Contains("alt");

				if (requiresShift != e.Shift || requiresCtrl != e.Ctrl || requiresAlt != e.Alt) {
					continue;
				}

				switch (hotkey.Name) {
					case "statTracker":
						Overlay.Instance.ModuleStatTracker.Show = !Overlay.Instance.ModuleStatTracker.Show;
						break;
					case "resetSession":
						if (CoreCollector.class340_0 != null && Overlay.Instance.ModuleStatTracker.Show) {
							CoreCollector.class340_0.method_22();
							CoreCollector.class340_1.method_22();
						}
						break;
					case "hideOverlay":
						switch (Overlay.Instance.State) {
							case OverlayDisplayState.Normal:
								Overlay.Instance.State = OverlayDisplayState.Hidden;
								break;
							case OverlayDisplayState.Hidden:
								Overlay.Instance.State = OverlayDisplayState.Normal;
								break;
						}
						break;
					case "openSettings":
						SettingsMenu.ShowMenu = !SettingsMenu.ShowMenu;
						break;
					case "exit":
						Exit();
						break;
				}
			}
		}
	}

	public static void InputLoop()
	{
		while (running) {
			ProcessInput();
			Thread.Sleep(1);
		}
	}

	public static void MainLoop()
	{
		while (running) {
			Update();
			Thread.Sleep((int)OverlayFrameInterval);
		}
	}

	public static void CollectLoop()
	{
		while (running) {
			CoreCollector.Update();
			Thread.Sleep(50);
		}
	}

	public static void Update()
	{
		try {
			if (!GameWindowManager.Update()) {
				return;
			}

			Overlay overlay = Overlay.Instance;
			bool canRender = overlay.State != OverlayDisplayState.Hidden && GameWindowManager.Window.IsForeground;
			if (!canRender) {
				if (overlay.Frm.Visible) {
					overlay.Frm.Visible = false;
				}
				return;
			}

			if (!overlay.Update()) {
				return;
			}

			if (!overlay.Frm.Visible) {
				overlay.Frm.Visible = true;
			}
		} catch (Exception ex) {
			Logger.LogException(ex.Message);
		}
	}

	internal static void Clear()
	{
		GameWindowManager.Window.Handle = IntPtr.Zero;
		foreach (StatTracker item in CoreCollector.Trackers) {
			item.method_24();
		}
		CoreCollector.smethod_3();
	}

	internal static void Exit()
	{
		running = false;
		Clear();
		TrayIconManager.Dispose();
		Environment.Exit(0);
	}

	public static void Measure(string name, Action action)
	{
		long start = Stopwatch.GetTimestamp();

		action();

		double ms = (Stopwatch.GetTimestamp() - start) * 1000.0 / Stopwatch.Frequency;

		if (ms > 10)
			Logger.Info($"{name}: {ms:F2} ms");
	}

	public static T Measure<T>(string name, Func<T> func)
	{
		long start = Stopwatch.GetTimestamp();

		T result = func();

		double ms = (Stopwatch.GetTimestamp() - start) * 1000.0 / Stopwatch.Frequency;

		if (ms > 10) {
			Logger.Info($"{name}: {ms:F2} ms");
		}

		return result;
	}
}
