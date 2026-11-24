# RiftAssistant

A Diablo III overlay for Windows. It reads the game's memory, draws on top of the game window with Direct2D, and runs plugins that you can edit and reload while the game is running.

## Features

* Overlay panels: lobby heroes, player info, portrait stats (real, run and total DPS, EHP), skill cooldowns, health and resource bars, cursor hints and a session stat tracker
* Plugin system: `.cs` files compiled with Roslyn at startup and reloadable at runtime, see [Src/PluginApi/PLUGIN_API.md](Src/PluginApi/PLUGIN_API.md)
* Item filter: JSON rules that mark each item as keep or sell, editable while the program runs
* In-game settings menu and a tray icon with reload and exit
* Configurable hotkeys

## Requirements

* Windows, x64
* [.NET 10 SDK](https://dotnet.microsoft.com/download) to build
* Administrator rights. The executable asks for elevation through its manifest.
* The game data files in a `data` folder next to the executable. They are not part of this repository and come with the release zip.

## Releases

A release has two zips:

* The main zip holds the executable, the `data` folder (with the English strings), `plugins` and `config`. Unzip it anywhere and run `RiftAssistant.exe`.
* The language pack zip holds the other `strings_<code>.bin` files. Copy the ones you want into the `data` folder, then set `Language` in `settings/settings.json`.

## Build and run

```
dotnet build rift_assistant.sln
dotnet publish rift_assistant.sln
```

The debug build is written to `bin/Debug/net10.0-windows/win-x64`. Publishing produces a single-file executable. RiftAssistant looks for the game window titled `Diablo III`, which you can change with `DiabloWindowTitle` in `settings.json`.

## Default hotkeys

| Key | Action |
| --- | --- |
| `F12` | Open the settings menu |
| `F10` | Toggle the stat tracker |
| `F9` | Hide the overlay |
| `Ctrl+Alt+R` | Reset the session |
| `Ctrl+End` | Exit |

Hotkeys are stored in `settings/hotkeys.json`.

## Settings menu

Press `F12` to open the settings menu. Click a section to expand it, one section at a time. Every change is applied immediately and saved to `settings/settings.json` half a second later. If you edit `settings.json` by hand while the program runs, the overlay and the menu pick the change up within a second.

* **General**: the language (applied after a restart) and the game window title. Click the title box, type, then press `Enter` to apply or `Esc` to cancel. Keys typed in the box do not reach the game.
* **Performance**, **Overlay**, **Skill cooldowns**, **Portrait stats**, **Stat tracker** and **Stat tracker columns**: the overlay options.
* **Inventory lock**: the protected inventory area.
* **Files**: open the settings folder, or reset all settings (click twice to confirm).

The item filter rules are edited in their JSON files, because they are too long for the overlay. They reload while the program runs.

## Configuration

Your settings and data live in `%LOCALAPPDATA%\RiftAssistant`, so replacing the program folder with a new release keeps them. The files are created with defaults on first run. On the first run with an empty `%LOCALAPPDATA%\RiftAssistant`, an existing `settings`, `stat_tracker` or `screenshots` folder next to the executable is copied there once.

| Path in `%LOCALAPPDATA%\RiftAssistant` | Purpose |
| --- | --- |
| `settings/settings.json` | Language, overlay options, FPS, batched memory reads, inventory lock area |
| `settings/hotkeys.json` | Hotkey bindings |
| `settings/item_filter_sc.json` | Softcore item filter rules |
| `settings/item_filter_hc.json` | Hardcore item filter rules |
| `stat_tracker/` | Saved stat tracker sessions |
| `screenshots/` | Screenshots taken by plugins |
| `cache/` | Compiled plugin cache |
| `logs/` | `info.txt` and `exceptions.txt`, cleared on each start |

The plugin sources are in the `plugins` folder next to the executable and are loaded at startup.

Changes to `settings.json` and to the item filter files are picked up within a second while the program runs. A `settings.json` or item filter file with errors is logged and the previous values stay active. Deleting an item filter file restores the defaults. The rule format is described in [config/item_filter_readme.txt](config/item_filter_readme.txt).

Plugins are reloaded from the tray menu or the settings menu.

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
* `plugins`: the plugin sources. They are distributed with releases and are not tracked in git.
* `config`: the default item filter rules (embedded in the executable) and the item filter rule format notes

## Disclaimer

This project is based on the latest free release of TurboHUD and was created by independently decompiling the publicly distributed binaries.

Large portions of the original infrastructure including authentication, licensing, telemetry, anti-tampering, and other non-essential components have been removed, rewritten, or modernized to keep the project lightweight and focused on its core functionality.

Due to its decompiled origins, some parts of the codebase may still contain legacy naming, decompiler artifacts, and code that has yet to be refactored.

This project is not affiliated with Blizzard Entertainment or the original TurboHUD project. Diablo and all related trademarks are the property of their respective owners.

Use any third-party tooling at your own risk.

## License

Provided for educational, research, preservation, and software modernization purposes.
