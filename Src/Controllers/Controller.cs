using System;
using System.Collections.Generic;

namespace RiftAssistant.Controllers;

public class Controller
{
	private readonly TextureController textureController = new TextureController();

	private readonly RenderController renderController = new RenderController();

	private readonly SceneRevealController sceneRevealController = new SceneRevealController();

	private readonly InventoryController inventoryController = new InventoryController();

	private readonly GameController gameController;

	private readonly SnoController snoController = new SnoController();

	private readonly TrackerController trackerController = new TrackerController();

	private readonly StatController statController = new StatController();

	private readonly SoundController soundController = new SoundController();

	private readonly InputController inputController = new InputController();

	public TextureController Texture => textureController;

	public RenderController Render => renderController;

	public SceneRevealController SceneReveal => sceneRevealController;

	public InventoryController Inventory => inventoryController;

	public Window Window => GameWindowManager.Window;

	public GameController Game => gameController;

	public SnoController Sno => snoController;

	public TrackerController Tracker => trackerController;

	public StatController Stat => statController;

	public SoundController Sound => soundController;

	public InputController Input => inputController;

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
