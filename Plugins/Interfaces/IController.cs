using System;
using System.Collections.Generic;
using work;

namespace Plugins;

public interface IController
{
	ITextureController Texture { get; }

	IRenderController Render { get; }

	ISceneRevealController SceneReveal { get; }

	IInventoryController Inventory { get; }

	IQueueController Queue { get; }

	IWindow Window { get; }

	IGameController Game { get; }

	ISnoController Sno { get; }

	ITrackerController Tracker { get; }

	string BattleTag { get; }

	SettingsMenu SettingsMenu { get; }

	IEnumerable<IHero> AccountHeroes { get; }

	IEnumerable<IPlugin> AllPlugins { get; }

	T GetPlugin<T>() where T : class, IPlugin;

	void RunOnPlugin<T>(Action<T> action) where T : class, IPlugin;

	void TogglePlugin<T>(bool enabled) where T : class, IPlugin;
}
