using Plugins;

internal class HeadStone(uint uint_8, uint uint_9, ISnoActor isnoActor_1, uint uint_10, IPlayer iplayer_1) : Actor(uint_8, uint_9, isnoActor_1), IActor, IHeadStone
{
	public uint PlayerActorAnnId { get; set; } = uint_10;

	public IPlayer Player { get; set; } = iplayer_1;
}
