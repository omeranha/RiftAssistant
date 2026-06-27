using System;
using System.Collections.Generic;
using Plugins;
using work;

public class Controller
{
	private readonly TextureController textureController = new TextureController();

	private readonly RenderController renderController = new RenderController();

	private readonly SceneRevealController sceneRevealController = new SceneRevealController();

	private readonly InventoryController inventoryController = new InventoryController();

	private readonly QueueController queueController = new QueueController();

	private readonly GameController gameController;

	private readonly SnoController snoController = new SnoController();

	private readonly TrackerController trackerController = new TrackerController();

	public TextureController Texture => textureController;

	public RenderController Render => renderController;

	public SceneRevealController SceneReveal => sceneRevealController;

	public InventoryController Inventory => inventoryController;

	public QueueController Queue => queueController;

	public DiabloWindow Window => GameWindowManager.Window;

	public GameController Game => gameController;

	public SnoController Sno => snoController;

	public TrackerController Tracker => trackerController;

	public string BattleTag => CoreCollector.BattleTag;

	public IEnumerable<Hero> AccountHeroes => CoreCollector.HeroCollector.HeroList;

	public IEnumerable<IPlugin> AllPlugins => Core.PluginHandler.Plugins;

	public SettingsMenu SettingsMenu => Core.SettingsMenu;

	public Controller()
	{
		gameController = new GameController();
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
