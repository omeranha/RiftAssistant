namespace Plugins;

public interface IHeroClassDefinition
{
	HeroClass HeroClass { get; }

	string Code { get; }

	string FullCode { get; }

	string Name { get; }

	ActorSnoEnum MaleActorSno { get; }

	ActorSnoEnum FemaleActorSno { get; }

	bool IsRanged { get; }

	string PrimaryResourceName { get; }

	string SecondaryResourceName { get; }
}
