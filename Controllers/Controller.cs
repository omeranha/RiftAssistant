using System;
using System.Collections.Generic;
using Plugins;
using work;

internal class Controller : IController
{
	private readonly ITextureController textureController = new TextureController();

	private readonly IRenderController renderController = new RenderController();

	private readonly ISceneRevealController sceneRevealController = new SceneRevealController();

	private readonly IInventoryController inventoryController = new InventoryController();

	private readonly IQueueController queueController = new QueueController();

	private readonly IGameController gameController;

	private readonly ISnoController snoController = new SnoController();

	private readonly ITrackerController trackerController = new TrackerController();

	public ITextureController Texture => textureController;

	public IRenderController Render => renderController;

	public ISceneRevealController SceneReveal => sceneRevealController;

	public IInventoryController Inventory => inventoryController;

	public IQueueController Queue => queueController;

	public IWindow Window => GameWindowManager.Window;

	public IGameController Game => gameController;

	public ISnoController Sno => snoController;

	public ITrackerController Tracker => trackerController;

	public string BattleTag => CoreCollector.BattleTag;

	public IEnumerable<IHero> AccountHeroes => CoreCollector.HeroCollector.HeroList;

	public IEnumerable<IPlugin> AllPlugins => Core.PluginHandler.Plugins;

	public SettingsMenu SettingsMenu => Core.SettingsMenu;

	public Controller()
	{
		gameController = new GameController(this);
	}

	public T GetPlugin<T>() where T : class, IPlugin
	{
		return Core.PluginHandler.GetPlugin<T>();
	}

	public void RunOnPlugin<T>(Action<T> action) where T : class, IPlugin
	{
		T val = Core.PluginHandler.GetPlugin<T>();
		if (val != null) {
			action(val);
		}
	}

	public void TogglePlugin<T>(bool enabled) where T : class, IPlugin
	{
		T val = Core.PluginHandler.GetPlugin<T>();
		if (val != null) {
			val.Enabled = enabled;
		}
	}
}
