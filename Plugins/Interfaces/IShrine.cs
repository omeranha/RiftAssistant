namespace Plugins;

public interface IShrine : IClickableActor, IActor
{
	ShrineType Type { get; }

	bool IsShrine { get; }

	bool IsPylon { get; }

	bool IsHealingWell { get; }

	bool IsPoolOfReflection { get; }
}
