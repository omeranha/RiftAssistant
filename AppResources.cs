using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;

internal class AppResources
{
	private static ResourceManager resourceManager;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			resourceManager ??= new ResourceManager("AppResources", typeof(AppResources).Assembly);
			return resourceManager;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo { get; set; }

	internal static Bitmap BuffFrame => (Bitmap)ResourceManager.GetObject("BuffFrame", CultureInfo);

	internal static Bitmap DebuffFrame => (Bitmap)ResourceManager.GetObject("DebuffFrame", CultureInfo);

	internal static Bitmap SpawnDecoy => (Bitmap)ResourceManager.GetObject("itempassive_unique_ring_724_spawndecoy_x1", CultureInfo);
}
