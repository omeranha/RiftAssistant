using System.ComponentModel;
using System.Globalization;
using System.Resources;

internal class GameResources
{
	private static ResourceManager manager;
	private static CultureInfo cultureInfo;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get {
			manager ??= new ResourceManager("GameResources", typeof(GameResources).Assembly);
			return manager;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo
	{
		get {
			return cultureInfo;
		}
		set {
			cultureInfo = value;
		}
	}

	internal static string Actor => ResourceManager.GetString("actor", cultureInfo);
	internal static string GamebalanceItems => ResourceManager.GetString("gamebalance_items", cultureInfo);
	internal static string GamebalanceKanai => ResourceManager.GetString("gamebalance_kanai", cultureInfo);
	internal static string Levelarea => ResourceManager.GetString("levelarea", cultureInfo);
	internal static string Monster => ResourceManager.GetString("monster", cultureInfo);
	internal static string PowerRuneIconOverrides => ResourceManager.GetString("power_rune_icon_overrides", cultureInfo);
	internal static string PowerStats => ResourceManager.GetString("power_stats", cultureInfo);
	internal static string Quest => ResourceManager.GetString("quest", cultureInfo);
	internal static string SceneHints => ResourceManager.GetString("scene_hints", cultureInfo);
	internal static string Worlds => ResourceManager.GetString("worlds", cultureInfo);

	internal GameResources() { }
}

