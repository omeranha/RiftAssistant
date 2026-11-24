using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RiftAssistant.Engine;

public static class Core
{
	private static float OverlayFrameInterval => 1000f / Settings.OverlayFps;

	public static Settings Settings => SettingsManager.Current;

	public static IReadOnlyList<Hotkey> HotkeyList { get; private set; }

	public static Controller Controller { get; private set; }

	public static SettingsMenu SettingsMenu { get; set; }

	public static PluginListMenu PluginListMenu { get; set; }

	internal static PluginHandler PluginHandler;

	private static bool running = true;

	public static void Init()
	{
		RawInput.Start();
		RawInput.MouseEvent += e => PluginHandler.DispatchKeyEvent(e);
		RawInput.KeyboardEvent += OnKeyboardEvent;
		MouseBlocker.Start();
		KeyboardCapture.Start();
		SettingsManager.Load();
		HotkeyList = Hotkeys.Load();
		SnoData.Load();
		ItemFilter.Load();

		Controller = new Controller();
		CoreCollector.Controller = Controller;
		new Overlay(Controller);

		CoreCollector.ItemCollector.OnLootGenerated += ProcessLoot;

		CoreCollector.OnNewArea += (_, _) => {
			Overlay.Instance.mapRenderer.ResetRenderer();
			Overlay.Instance.ModuleStatTracker.Show = false;
		};

		CoreCollector.GameStateReset += (_, _) => {
			Overlay.Instance.mapRenderer.ResetRenderer();
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

		SettingsManager.Changed += ApplySettings;
		GameWindowManager.Window.WindowTitle = Settings.DiabloWindowTitle;
		CoreCollector.ClearAllCaches();
		Overlay.Instance.RecreateSharedFonts();
		Overlay.Instance.InitializeModulesFromConfig(Settings);

		SettingsMenu = new(Settings);
		SettingsMenuOptions.Register(SettingsMenu);
		PluginHandler = new PluginHandler();
		PluginHandler.LoadPlugins();
		PluginListMenu = new PluginListMenu();
		PluginListMenu.Reload();
		CoreCollector.Update();
	}

	private static void ApplySettings()
	{
		GameWindowManager.Window.WindowTitle = Settings.DiabloWindowTitle;
		Overlay.Instance.ApplySettings(Settings);
	}

	private static void ProcessLoot(object sender, LootGenerated e)
	{
		if (e.item.SnoItem.Kind == ItemKind.goldcoin) {
			uint amount = e.item.Amount;
			string item = e.item.FloorCoordinate.ToStringCompactPrecise() + "/" + amount.ToString("D", CultureInfo.InvariantCulture);
			if (!CoreCollector.RunTracker.TrackedStrings.Contains(item)) {
				foreach (StatTracker item2 in CoreCollector.Trackers) {
					item2.DropGold += amount;
				}

				CoreCollector.RunTracker.TrackedStrings.Add(item);
			}
		}

		if ((e.item.SnoItem.Kind != ItemKind.loot && e.item.SnoItem.Kind != ItemKind.uberstuff && e.item.SnoItem.Kind != ItemKind.gem && e.item.SnoItem.Kind != ItemKind.craft) || CoreCollector.RunTracker.TrackedLongs.Contains(e.item.Seed)) {
			return;
		}

		foreach (StatTracker item3 in CoreCollector.Trackers) {
			item3.DropAll++;
		}

		if ((int)e.item.Quality >= 0 && (int)e.item.Quality <= 2) {
			foreach (StatTracker item4 in CoreCollector.Trackers) {
				item4.DropWhite++;
			}
		}
		else if ((int)e.item.Quality >= 3 && (int)e.item.Quality <= 5) {
			foreach (StatTracker item5 in CoreCollector.Trackers) {
				item5.DropMagic++;
			}
		}
		else if ((int)e.item.Quality >= 6 && (int)e.item.Quality <= 8) {
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

		CoreCollector.RunTracker.TrackedLongs.Add(e.item.Seed);
	}

	private static void OnKeyboardEvent(InputEvent e)
	{
		if (KeyboardCapture.SuppressesInput) return;

		PluginHandler?.DispatchKeyEvent(new InputEvent(e.Key, e.Down, e.Shift, e.Ctrl, e.Alt));

		if (!e.Down) return;
		foreach (var hotkey in HotkeyList) {
			if (hotkey.Key != e.Key || e.Key == Vk.None) continue;

			bool requiresShift = hotkey.Modifiers.Contains("shift");
			bool requiresCtrl = hotkey.Modifiers.Contains("ctrl");
			bool requiresAlt = hotkey.Modifiers.Contains("alt");

			if (requiresShift != e.Shift || requiresCtrl != e.Ctrl || requiresAlt != e.Alt) continue;

			switch (hotkey.Name) {
				case "statTracker":
					Overlay.Instance.ModuleStatTracker.Show = !Overlay.Instance.ModuleStatTracker.Show;
					break;
				case "resetSession":
					if (CoreCollector.Session != null && Overlay.Instance.ModuleStatTracker.Show) {
						CoreCollector.Session.Reset();
						CoreCollector.SessionAlwaysRunning.Reset();
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

	public static void MainLoop()
	{
		while (running) {
			SettingsManager.Tick();
			if (!GameWindowManager.Update()) {
				Thread.Sleep((int)OverlayFrameInterval);
				continue;
			}

			CoreCollector.Update();
			ItemFilter.ReloadIfChanged();
			Overlay overlay = Overlay.Instance;
			bool visible = GameWindowManager.Window.IsForeground && overlay.State != OverlayDisplayState.Hidden;
			if (overlay.Frm.Visible != visible) {
				overlay.Frm.Visible = visible;
			}

			if (visible) {
				overlay.Update();
			}

			Thread.Sleep((int)OverlayFrameInterval);
		}
	}

	internal static void Clear()
	{
		GameWindowManager.Window.Handle = IntPtr.Zero;
		foreach (StatTracker item in CoreCollector.Trackers) {
			item.Save();
		}

		CoreCollector.ResetGameState();
	}

	internal static void Exit()
	{
		running = false;
		SettingsManager.Flush();
		Clear();
		TrayIconManager.Hide();
		Application.ExitThread();
		TrayIconManager.Dispose();
		Environment.Exit(0);
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
