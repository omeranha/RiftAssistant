# RiftAssistant

A Diablo III overlay.

## Features

* Real-time Diablo III memory reading
* Overlay rendering system
* Plugin system

## Project layout

* `Src`: the application source
  * `App`: entry point, settings, logging and resources
  * `Engine`: game memory reading and the main loop
  * `Memory`: raw structures read from the game
  * `Collectors`: turn raw memory into game objects each frame
  * `Model`: game objects, UI elements and enums
  * `Sno`: game data tables, `Generated`: large generated lookup tables
  * `Rendering` and `Modules`: the Direct2D overlay and its built-in panels
  * `Input`: raw input, mouse blocking and hotkeys
  * `Tracking`: session and run statistics
  * `Controllers`: the API that plugins see (`Controller`)
  * `Plugins` and `PluginHost`: the plugin interfaces and the host that compiles and runs them
* `PluginScripts`: the plugin sources that ship in releases, see `docs/PLUGIN_API.md`
* `config`: pickit rule files copied next to the executable
* `docs`: documentation
* `tests`: unit tests, including a check that every plugin in PluginScripts compiles

Run the tests with `dotnet test tests/RiftAssistant.Tests`.
## Disclaimer

This project is based on the latest free release of TurboHUD and was created by independently decompiling the publicly distributed binaries.

Large portions of the original infrastructure including authentication, licensing, telemetry, anti-tampering, and other non-essential components have been removed, rewritten, or modernized to keep the project lightweight and focused on its core functionality.

Due to its decompiled origins, some parts of the codebase may still contain legacy naming, decompiler artifacts, and code that has yet to be refactored.

This project is not affiliated with Blizzard Entertainment or the original TurboHUD project. Diablo and all related trademarks are the property of their respective owners.

Use any third-party tooling at your own risk.

## License

Provided for educational, research, preservation, and software modernization purposes.
