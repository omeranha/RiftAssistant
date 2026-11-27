# RiftAssistant

A Diablo 3 (Diablo III) overlay for Windows. It reads the game's memory, draws on top of the game window with Direct2D, and runs plugins that you can edit and reload while the game is running.

## Features

* Overlay panels: lobby heroes, player info, portrait stats (real, run and total DPS, EHP), skill cooldowns, health and resource bars, cursor hints and a session stat tracker
* Plugin system: `.cs` files compiled with Roslyn at startup and reloadable at runtime, see [Src/PluginApi/PLUGIN_API.md](Src/PluginApi/PLUGIN_API.md)
* Item filter: filters made in their own menu (an item, optional stat minimums, and an optional ancient requirement) that mark items as keep or sell
* In-game settings menu and a tray icon with reload and exit
* Configurable hotkeys

## Requirements

* Windows, x64
* [.NET 10 SDK](https://dotnet.microsoft.com/download) to build
* Administrator rights. The executable asks for elevation through its manifest.
* The game data files in a `data` folder next to the executable. They are not part of this repository and come with the release zip.

## Releases

A release has two zips:

* The main zip holds the executable, the `data` folder (with the English strings) and `plugins`. Unzip it anywhere and run `RiftAssistant.exe`.
* The language pack zip holds the other `strings_<code>.bin` files. Copy the ones you want into the `data` folder, then set `Language` in `settings/settings.json`.

## Build and run

```
dotnet build rift_assistant.sln
dotnet publish rift_assistant.sln
```

Publishing produces a single-file executable. RiftAssistant looks for the game window titled `Diablo III`, which you can change with `DiabloWindowTitle` in `settings.json`.

## Default hotkeys

| Key | Action |
| --- | --- |
| `F12` | Open the settings menu |
| `F10` | Toggle the stat tracker |
| `F9` | Hide the overlay |
| `Ctrl+Alt+R` | Reset the session |
| `Ctrl+End` | Exit |

Hotkeys are stored in `settings/hotkeys.json` and can be changed in the settings menu.

## Settings menu

Press `F12`, or click the **Settings** button in the bottom-right corner of the game window, to open the settings menu. The button can be turned off under **Overlay**. The menu has a list of pages on the left and the settings of the chosen page on the right. Pages with many settings scroll with the mouse wheel or the scroll bar. Every change is applied immediately and saved to `settings/settings.json` half a second later. If you edit `settings.json` by hand while the program runs, the overlay and the menu pick the change up within a second.

* **General**: the language (applied after a restart), the game window title, the performance options, and the buttons to open the settings folder or reset all settings (click twice to confirm). Click the title box, type, then press `Enter` to apply or `Esc` to cancel. Keys typed in the box do not reach the game.
* **Overlay**: the overlay panels, the skill cooldowns and the portrait stats (including the Settings button).
* **Stat tracker**: the window and its columns.
* **Inventory lock**: the protected inventory area. Click a number to type it.
* **Hotkeys**: click a hotkey, then press the new key combination. Esc cancels, and a combination that another hotkey already uses is rejected. **Reset hotkeys** restores the defaults.
* **Plugin settings**: one entry per plugin that has settings, click it to open it.

The **Item filter** and **Plugins** entries at the bottom of the list open their own windows next to the settings, one at a time. The **Plugins** window lists every loaded plugin with a search box and All, On and Off tabs, turns each plugin on or off, and reloads the plugins.

Filters for the item filter have their own window.

* **+ Add filter** opens a search over the legendary and set items. Items show their icon, and their names are orange for legendary items and green for set items. The tabs narrow the search to legendary or set items.
* Click a filter to edit it. Its result is **Keep** (green) or **Sell** (red), and it can require an ancient or primal item.
* **+ Add stat** lists the stats by category. Each stat shows its unit: **number** for flat values such as Vitality, resistances or Life on hit, and **%** for percent values such as critical hit chance or cooldown reduction. The minimum is in that unit and matches what the item shows, so 9 on a percent stat means 9%. Use - and + or click the value to type it.
* The unit tag next to a stat switches it to **roll %**, which compares against the affix's possible roll range instead (100% is a perfect roll and an ancient item can exceed it). Sockets can only be counted.
* The on/off switch turns a filter off without deleting it, and the ^ and v buttons change the order. Filters are checked from top to bottom and the first match marks the item as looks good (keep) or sell.

Items are matched by their English name, so the game language does not matter. Nothing is set up by default. Filters are saved half a second after each change.

## Configuration

Your settings and data live in `%LOCALAPPDATA%\RiftAssistant`, so replacing the program folder with a new release keeps them. The files are created with defaults on first run. On the first run with an empty `%LOCALAPPDATA%\RiftAssistant`, an existing `settings`, `stat_tracker` or `screenshots` folder next to the executable is copied there once.

| Path in `%LOCALAPPDATA%\RiftAssistant` | Purpose |
| --- | --- |
| `settings/settings.json` | Language, overlay options, FPS, batched memory reads, inventory lock area |
| `settings/hotkeys.json` | Hotkey bindings |
| `settings/plugins_states.json` | Which plugins are enabled (the **Plugins** window in the settings menu) |
| `settings/plugin_settings.json` | Values of plugin settings, such as `bool`, `int` or `string` |
| `settings/item_filters.json` | Filters made in the item filter menu |
| `stat_tracker/` | Stat tracker totals (account, hero, today and per area) as JSON, saved every minute, on zone changes, at midnight and on exit |
| `screenshots/` | Screenshots taken by plugins |
| `cache/` | Compiled plugin cache |
| `logs/` | `info.txt` and `exceptions.txt`, cleared on each start |

The plugin sources are in the `plugins` folder of the repository. A build copies them next to the executable, where they are loaded at startup. `plugins/Plugins.csproj` gives the editor completion for the plugin API; see `Src/PluginApi/PLUGIN_API.md`.

Changes to `settings.json` are picked up within a second while the program runs. A `settings.json` with errors is logged and the previous values stay active. A `item_filters.json` that cannot be read is kept as `item_filters.json.invalid` and the filters start empty.

Plugins are reloaded from the tray menu or the **Plugins** window.

### Language

Set `Language` in `settings/settings.json` and restart. The supported codes are `deDE`, `enUS`, `esES`, `esMX`, `frFR`, `itIT`, `koKR`, `plPL`, `ptBR`, `ptPT`, `ruRU`, `zhCN` and `zhTW`. The matching `data/strings_<code>.bin` must exist, and `strings_enUS.bin` is always required. An unknown code or a missing file falls back to `enUS` and is written to `logs/info.txt`.

## Project layout

* `Src`: the application source
  * `App`: entry point, settings, logging and resources
  * `Engine`: game memory reading, the main loop and the item filter
  * `Memory`: raw structures read from the game
  * `Collectors`: turn raw memory into game objects each frame
  * `Model`: game objects, UI elements and enums
  * `Sno`: game data tables, `Generated`: large generated lookup tables
  * `Rendering` and `Modules`: the Direct2D overlay and its built-in panels
  * `Input`: raw input, mouse blocking and hotkeys
  * `Tracking`: session and run statistics
  * `Controllers`: the API that plugins see (`Controller`)
  * `PluginApi`: the interfaces plugins implement, the host that compiles and runs the plugins, and the API doc

## Disclaimer

This project is based on the latest free release of TurboHUD and was created by independently decompiling the publicly distributed binaries.

Large portions of the original infrastructure including authentication, licensing, telemetry, anti-tampering, and other non-essential components have been removed, rewritten, or modernized to keep the project lightweight and focused on its core functionality.

Due to its decompiled origins, some parts of the codebase may still contain legacy naming, decompiler artifacts, and code that has yet to be refactored.

This project is not affiliated with Blizzard Entertainment or the original TurboHUD project. Diablo and all related trademarks are the property of their respective owners.

Use any third-party tooling at your own risk.

## License

Provided for educational, research, preservation, and software modernization purposes.
