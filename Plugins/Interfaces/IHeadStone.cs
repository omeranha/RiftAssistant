namespace Plugins;

public interface IHeadStone : IActor
{
	uint PlayerActorAnnId { get; }

	IPlayer Player { get; }
}
