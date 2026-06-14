using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Plugins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using work;

internal class PluginHandler
{
	private readonly IController controller;
	private AssemblyLoadContext loadContext;
	private WeakReference loadContextReference;
	private readonly Lock pluginLock = new();
	private readonly MetadataReference[] references;

	public readonly List<IPlugin> Plugins = [];
	public bool Reloading { get; private set; } = false;
	public bool Reloaded { get; private set; } = false;
	public bool Errored { get; private set; } = false;

	internal PluginHandler(IController controller)
	{
		this.controller = controller;
		references = [.. AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
			.Select(a => a.Location).Distinct(StringComparer.OrdinalIgnoreCase).Where(File.Exists).Select(path => MetadataReference.CreateFromFile(path))];

		var overlay = Overlay.Instance;
		overlay.PaintWorld_Ground += (_, _) => Dispatch<IInGameWorldPainter>(h => h.PaintWorld(WorldLayer.Ground));
		overlay.PaintWorld_Map += (_, _) => Dispatch<IInGameWorldPainter>(h => h.PaintWorld(WorldLayer.Map));
		overlay.PaintTop_BeforeClip += (_, _) => Dispatch<IInGameTopPainter>(h => h.PaintTopInGame(ClipState.BeforeClip));
		overlay.PaintTop_Inventory += (_, _) => Dispatch<IInGameTopPainter>(h => h.PaintTopInGame(ClipState.Inventory));
		overlay.PaintTop_AfterClip += (_, _) => Dispatch<IInGameTopPainter>(h => h.PaintTopInGame(ClipState.AfterClip));
		overlay.BeforeRender += (_, _) => Dispatch<IBeforeRenderHandler>(h => h.BeforeRender());

		CoreCollector.OnNewArea += (_, _) => Dispatch<INewAreaHandler>(h => h.OnNewArea(true, CoreCollector.LocalPlayer.SnoArea));
		CoreCollector.OnFalseNewArea += (_, area) => Dispatch<INewAreaHandler>(h => h.OnNewArea(false, area));

		var items = CoreCollector.ItemCollector;
		items.OnItemIdentified += (_, item) => Dispatch<IItemIdentifiedHandler>(h => h.OnItemIdentified(item));
		items.OnItemLocationChanged += (_, e) => Dispatch<IItemLocationChangedHandler>(h => h.OnItemLocationChanged(e.iitem_0, e.itemLocation_0, e.itemLocation_1));
		items.OnLootGenerated += (_, e) => Dispatch<ILootGeneratedHandler>(h => h.OnLootGenerated(e.item, e.gambled));
		items.OnItemPicked += (_, e) => Dispatch<IItemPickedHandler>(h => h.OnItemPicked(e.iitem_0));

		var actors = CoreCollector.ActorCollector;
		actors.onMonsterKilled += (_, monster) => Dispatch<IMonsterKilledHandler>(h => h.OnMonsterKilled(monster));
		actors.OnPortalFound += (_, portal) => Dispatch<IPortalFoundHandler>(h => h.OnPortalFound(portal));
		CoreCollector.OnCooldown += (_, skill) => Dispatch<ISkillCooldownHandler>(h => h.OnCooldown(skill, false));
		CoreCollector.OnTrueCooldown += (_, skill) => Dispatch<ISkillCooldownHandler>(h => h.OnCooldown(skill, true));
		CoreCollector.UiElements.ChatChanged += (_, e) => Dispatch<IChatLineChangedHandler>(h => h.OnChatLineChanged(e.string_0, e.string_1));
	}

	internal void LoadPlugins(bool reloading = false)
	{
		var pluginDir = Path.Combine(Program.AppDir, "plugins");
		if (!Directory.Exists(pluginDir)) return;

		Errored = false;
		Reloaded = false;
		Reloading = false;
		lock (pluginLock) {
			if (reloading) {
				Reloading = true;
				Core.SettingsMenu.MenuOptions.Clear();
			}

			UnloadPlugins();

			var pluginFiles = Directory.GetFiles(pluginDir, "*.cs", SearchOption.AllDirectories);
			var success = CompilePlugins(pluginFiles);
			if (!success) {
				Errored = true;
				return;
			}
			if (reloading) {
				Task.Run(async () => {
					Errored = false;
					Reloading = false;
					Reloaded = true;
					await Task.Delay(2000);
					Reloaded = false;
				});
			}
		}
	}

	private void Dispatch<T>(Action<T> action)
	{
		List<T> handlers;
		lock (pluginLock) {
			handlers = [.. GetPlugins<T>()];
		}

		foreach (var handler in handlers) {
			action(handler);
		}
	}

	internal IEnumerable<T> GetPlugins<T>()
	{
		return Plugins.Where(p => p.Enabled).OfType<T>();
	}

	public void DispatchKeyEvent(IKeyEvent keyEvent)
	{
		if (!GameWindowManager.Window.IsForeground) return;

		List<IKeyEventHandler> handlers;
		lock (pluginLock) {
			handlers = [.. Plugins.Where(p => p.Enabled).OfType<IKeyEventHandler>()];
		}

		foreach (var handler in handlers) {
			handler.OnKeyEvent(keyEvent);
		}
	}

	private bool CompilePlugins(string[] pluginFiles)
	{
		var pluginsDir = Path.Combine(Program.AppDir, "plugins");
		var combinedSource = new StringBuilder();
		try {
			var sources = pluginFiles.Select(file => new {
				Path = file,
				Source = File.ReadAllText(file)
			}).ToList();

			foreach (var source in sources) {
				combinedSource.Append(source.Source);
			}

			combinedSource.Append(typeof(IPlugin).Assembly.ManifestModule.ModuleVersionId);
			combinedSource.Append(typeof(IController).Assembly.ManifestModule.ModuleVersionId);

			if (sources.Count == 0) return false;

			var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(combinedSource.ToString()));
			var hash = Convert.ToHexString(bytes).ToLowerInvariant();
			string outputPath = Path.Combine(Program.AppDir, $"compiled_plugins_{hash}.dll");
			foreach (var file in Directory.GetFiles(Program.AppDir, "compiled_plugins_*")) {
				if (file == outputPath) continue;

				try {
					File.Delete(file);
				} catch {
				}
			}

			var stopwatch = Stopwatch.StartNew();
			Assembly assembly = null;

			loadContext = new AssemblyLoadContext("PluginContext", isCollectible: true);
			loadContextReference = new WeakReference(loadContext);
			bool cacheExists = File.Exists(outputPath);
			if (cacheExists) {
				try {
					using var fs = new FileStream(outputPath, FileMode.Open, FileAccess.Read);
					assembly = loadContext.LoadFromStream(fs);
					Logger.Info($"plugins loaded from cache in {stopwatch.ElapsedMilliseconds} ms");
				} catch {
					cacheExists = false;
				}
			}

			if (!cacheExists) {
				var syntaxTrees = sources.Select(source => CSharpSyntaxTree.ParseText(source.Source, new CSharpParseOptions(LanguageVersion.Preview), source.Path)).ToList();

				var compilation = CSharpCompilation.Create(
					Path.GetFileNameWithoutExtension(outputPath),
					syntaxTrees,
					references,
					new CSharpCompilationOptions(
						OutputKind.DynamicallyLinkedLibrary)
						.WithOptimizationLevel(OptimizationLevel.Release)
						.WithAllowUnsafe(true)
				);

				using var peStream = new MemoryStream();
				var result = compilation.Emit(peStream);
				if (!result.Success) {
					Logger.Info($"plugins compilation failed after {stopwatch.ElapsedMilliseconds} ms");
					foreach (var diagnostic in result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error)) {
						var location = diagnostic.Location.GetLineSpan();
						string file = Path.GetFileName(location.Path);
						int line = location.StartLinePosition.Line + 1;
						int column = location.StartLinePosition.Character + 1;
						Logger.LogException($"[Plugin: {file}] {diagnostic.Id}: {diagnostic.GetMessage()} (line {line}, col {column})");
					}

					MessageBox.Show("Plugin compilation failed.\nCheck logs for details.", "Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				File.WriteAllBytes(outputPath, peStream.ToArray());
				Logger.Info($"plugins compiled in {stopwatch.ElapsedMilliseconds} ms");

				peStream.Position = 0;
				assembly = loadContext.LoadFromStream(peStream);
			}

			foreach (var type in assembly.GetTypes()) {
				if (!type.IsClass) continue;

				var plugin = CreateAndLoadPlugin(type);
				if (plugin != null) {
					Plugins.Add(plugin);
				}
			}
			Logger.Info($"{Plugins.Count} plugins loaded");
			return true;
		} catch (Exception ex) {
			Logger.LogException(ex.Message);
			MessageBox.Show($"An error occurred while loading plugins.\n{ex.Message}", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Core.Exit();
			return false;
		}
	}

	private IPlugin CreateAndLoadPlugin(Type type)
	{
		if (!typeof(IPlugin).IsAssignableFrom(type) || type.IsAbstract) return null;

		IPlugin plugin;
		var name = type.FullName;
		try {
			plugin = Activator.CreateInstance(type) as IPlugin;
			if (plugin == null) return null;
		} catch (Exception ex) {
			Logger.Info($"[ERROR] instantiating plugin {name} {ex.Message}");
			Logger.LogException(ex.Message);
			return null;
		}

		try {
			plugin.Load(controller);
			return plugin;
		} catch (Exception ex) {
			Logger.Info($"[ERROR] loading plugin {name} {ex.Message}");
			Logger.LogException($"[Plugin: {name}] {ex.Message}");
			return null;
		}
	}

	private void UnloadPlugins()
	{
		Plugins.Clear();

		if (loadContext == null) return;

		loadContext.Unload();
		loadContext = null;
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();

		Logger.Info($"PluginContext unloaded: {!loadContextReference?.IsAlive}");
	}

	public T GetPlugin<T>() where T : IPlugin
	{
		lock (pluginLock) {
			foreach (IPlugin item in Plugins) {
				if (item is T t) {
					return t;
				}
			}
		}
		return default;
	}
}
