using Plugins;
using SNO;

public class HeadStone(uint uint_8, uint uint_9, SnoActor SnoActor_1, uint uint_10, Player iplayer_1) : Actor(uint_8, uint_9, SnoActor_1)
{
	public uint PlayerActorAnnId { get; set; } = uint_10;

	public Player Player { get; set; } = iplayer_1;
}
