# Plugin API

Plugins are `.cs` files in the `plugins` folder next to the executable. The plugin sources are distributed with releases and are not part of the repository. They are compiled with Roslyn at startup (cached by source hash) and can be reloaded at runtime. A compile error is logged to `logs/exceptions.txt` in `%LOCALAPPDATA%\RiftAssistant`. Settings files such as `settings/settings.json` live in that folder too.

Differences from the original TurboHUD plugin API are listed at the end.

## Writing a plugin

```csharp
namespace Plugins.Default;

public class ExamplePlugin : BasePlugin, IInGameTopPainter
{
	public ExamplePlugin()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);
	}

	public void PaintTopInGame(ClipState clipState)
	{
	}
}
```

`BasePlugin` (in `plugins/BasePlugin`) implements `IPlugin`, exposes `Assistant` (the `Controller`), `Enabled`, `Order` and `ValueToString`.

## Controller (`Assistant`)

| Member | Purpose |
|---|---|
| `Game` | Game state: `Me`, `Items`, `Actors`, `Monsters`, areas, quests |
| `Render` | UI elements, fonts, brushes, screenshots (`ScreenshotToFile`) |
| `Texture`, `Sno`, `SceneReveal`, `Tracker`, `Inventory` | As in the original |
| `Window` | Game window offset, size and foreground state |
| `Stat` | Performance counters (see below) |
| `Sound` | Speech, sound files and in-game volume (see below) |
| `Input` | Simulated mouse and keyboard input (see below) |
| `BattleTag`, `AccountHeroes`, `AllPlugins` | Account and plugin lists |
| `GetPlugin<T>()`, `RunOnPlugin<T>()`, `TogglePlugin<T>()` | Plugin lookup and toggling |

### `Assistant.Stat`

- `RenderPerfCounter`: `LastValue` is milliseconds of render time per second, `LastCount` is frames per second. Render time is measured up to `Present`, so vsync wait is excluded.
- `MemoryReadPerfCounter`: `LastValue` is game memory read calls per second.
- `MonsterHitpointDecreasePerfCounter`: `LastValue` is monster hitpoints removed per second.
- `GetPluginCounters(plugin)`: time spent in each handler of a plugin, keyed by handler interface name. Used by `DebugPlugin`.

### `Assistant.Sound`

- `Speak(text)`, `StopSpeak()`, `IsSpeakEnabled`, `LastSpeak` (a `Stopwatch`; `TimerTest(ms)` is an extension method with the original semantics: true when never started or when `ms` elapsed).
- `LoadSoundPlayer(fileName)`: loads a `.wav` from the `sounds` folder, or returns `null`.
- `IsIngameSoundEnabled`, `IngameMasterVolume`, `IngameEffectsVolume`: read from the game's sound settings.
- `VolumeMode`, `VolumeMultiplier`, `ConstantVolume`: the Windows wave volume follows the game volume (same as the original). `VolumeMode.Constant` pins it.

### `Assistant.Input`

`IsKeyDown(Vk)`, `GetMousePosition()`, `SetMousePosition(x, y)`, `Click(Vk button, bool hold = false)`, `PressKey(Vk, bool release = true)`, `ReleaseKey(Vk)`. These use `SendInput`. A click is sent as one atomic down and up pair.

## Handler interfaces

Original handlers keep their names. Differences:

- `IKeyEventHandler.OnKeyEvent(InputEvent)` and `InputEventHandler.OnInputEvent(InputEvent)` receive the `InputEvent` struct: `Key` (`Vk`), `Down`, modifier flags, `Is(Vk, bool down)`.
- `IMouseClickBlocker.MouseClickShouldBeBlocked(MouseButtons, x, y)`: return true to swallow a click. `x` and `y` are relative to the game window. A blocked press also blocks its release. The handler runs on the mouse hook thread and must return quickly.
- `IItemKeepDecisionHandler.CalculateItemKeepDecision(Item, ItemKeepDecision previous)`: adjust the item filter result. Handlers are chained in plugin order.

## Plugin settings

A public `bool`, `int`, `string` or enum property with a getter and a setter becomes a setting when it has `[PluginSetting("Label")]`. After `Load()` the saved value replaces the property's value, and the plugin gets a collapsible button in the settings menu, under the **Plugins settings** heading and titled with the plugin name (`InventoryAndStashPlugin` becomes `Inventory And Stash`), where the value can be changed. Changes apply to the running plugin at once and are saved to `settings/plugin_settings.json` half a second later, keyed by the plugin class name and the property name. For `int` properties `Min`, `Max` and `Step` (default 0, 100 and 1) set the stepper range, and a saved value outside it is clamped.

```csharp
[PluginSetting("Mark items to keep")]
public bool LooksGoodDisplayEnabled { get; set; }

[PluginSetting("Opacity (%)", Min = 10, Max = 100, Step = 10)]
public int Opacity { get; set; } = 80;
```

A plugin that builds its own menu components can show them in its own collapsible button with `Assistant.SettingsMenu.AddSection(name, components)`, and read and write values itself with `Assistant.GetPluginSettings(this)`, which returns an `IPluginSettings` (`GetBool`, `GetInt`, `GetString` with a default, and `Set`). `AutoCastSkills` uses it for its skill checkboxes. Which plugins are enabled is stored separately in `settings/plugins_states.json` and is changed with the **Show Plugins** list in the settings menu.

## Item keep decision

`Item.KeepDecision` is `LooksGood`, `Irrelevant` or `DefinitelyBad`. It is computed once when an item is first seen and again when it gets identified.

1. Unidentified items and the Demonic Trebuchet key are `LooksGood`.
2. Otherwise the first matching rule in `settings/item_filter_sc.json` (softcore) or `settings/item_filter_hc.json` (hardcore) decides. A missing file is created from the defaults built into the executable. The file format is described in `config/item_filter_readme.txt`.
3. No matching rule gives `Irrelevant`.
4. `IItemKeepDecisionHandler` plugins adjust the result.

Item filter files are reloaded together with the plugins and also when they change on disk while the program runs (checked once per second), and every item is re-evaluated. Known limitation: the `cubed` and `can_cubed` conditions are not supported and never match.

## Inventory lock

`Settings.InventoryLock` in `settings/settings.json` (`LeftColumn`, `TopRow`, `RightColumn`, `BottomRow`, all `-1` when unused) defines a protected inventory area. `Assistant.Inventory.InventoryLockArea` returns it as a `Rectangle` and `Item.IsInventoryLocked` is true for items that overlap it.

## Stat trackers

`Assistant.Tracker` (`Session`, `CurrentAccountToday`, ...) and `Assistant.Game` (`CurrentHeroToday`, `CurrentHeroTotalOnCurrentDifficulty`, ...) return `IStatTracker`, as in the original API. The interface is read-only: counters, times, and the per-hour and per-second rates. Plugins cannot change, reset or save a tracker, and the tracker class itself is internal. The values are stored in `stat_tracker/` and the "today" trackers start fresh at midnight.

## Differences from the original API

| Original | Now |
|---|---|
| `Turbo.Plugins`, `Turbo.Plugins.Default`, `Turbo.SNO` namespaces | `Plugins`, `Plugins.Default`; the SNO types live in `RiftAssistant.Sno` |
| `IController`, `IItem`, `IActor`, `IMonster`, `IPlayer`, `IPlayerSkill`, `IWorldCoordinate`, `ITexture`, `IUiElement`, `ISno*` | The concrete classes `Controller`, `Item`, `Actor`, `Monster`, `Player`, `Skill`, `WorldCoordinate`, `Texture`, `UiElement`, `Sno*` |
| `IKeyEvent`, `Assistant.Input.CreateKeyEvent(...)` with DirectInput keys | `InputEvent` with `Vk` keys: `keyEvent.Is(Vk.F6, true)` |
| `IWatch`, `Assistant.Time.CreateWatch()` | `System.Diagnostics.Stopwatch` |
| `IPlugin.PerformanceCounters` | `Assistant.Stat.GetPluginCounters(plugin)` |
| `Assistant.Window.GroundRectangle`, `Assistant.Window.CreateWorldCoordinate(...)` | Static: `Window.GroundRectangle`, `Window.CreateWorldCoordinate(...)` |
| `Assistant.MyBattleTag` | `Assistant.BattleTag` |
| `Assistant.TextLog`, `Assistant.Time` | `Logger` (global) and `DateTime` |
| `Assistant.Render.CaptureScreenToFile(folder, name)` | `Assistant.Render.ScreenshotToFile(name)` |
| `IPlugin.Load(IController)` | `IPlugin.Load()`; `BasePlugin` forwards to `Load(Controller)` |
| `BasePlugin.ValueToString` implementation in plugins | Delegates to `Formatting.ValueToString` |

## Porting an original plugin

1. Replace the namespaces and interface types using the table above.
2. Remove `using Turbo.SNO;` and similar lines. Plugin compilation imports every `RiftAssistant.*` namespace and `Plugins` globally, so no using directives are needed for the game types.
3. Replace `IWatch` with `Stopwatch` and DirectInput keys with `Vk`.
4. Compile. Every remaining error is an API gap listed in this document or a real gap to report.

## Plugin set status

All plugin sources from TurboHUD 1.4.3.0 (`Default` and `Enhanced`) compile against this API, apart from two that were rewritten for the new input and logging model: `BountyTablePlugin` (Vk-based key handling) and `ParagonCapturePlugin` (`Logger` and `ScreenshotToFile`).

## Public API surface

Plugins are compiled against the public types of the application assembly. Only types a plugin can reach (the game model, the SNO data types, enums, the controllers and the interfaces in `Plugins`) are public; everything else is internal.
