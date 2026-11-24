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

## Configuration

All files are created with defaults on first run, next to the executable.

| File | Purpose |
| --- | --- |
| `settings/settings.json` | Language, overlay options, FPS, batched memory reads, inventory lock area |
| `settings/hotkeys.json` | Hotkey bindings |
| `settings/item_filter_sc.json` | Softcore item filter rules |
| `settings/item_filter_hc.json` | Hardcore item filter rules |
| `plugins/` | Plugin sources, loaded at startup |
| `logs/` | `info.txt` and `exceptions.txt`, cleared on each start |

The item filter files are checked once per second and reloaded when they change. A file with errors is logged and the previous rules stay active. Deleting a file restores the defaults. The rule format is described in [config/item_filter_readme.txt](config/item_filter_readme.txt).

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
