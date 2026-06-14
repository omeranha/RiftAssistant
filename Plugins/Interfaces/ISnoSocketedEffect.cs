namespace Plugins;

public interface ISnoSocketedEffect
{
	ISnoItemMod[] Mods { get; }

	ISnoItemType SnoItemType { get; }
}
