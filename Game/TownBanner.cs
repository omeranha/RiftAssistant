using Plugins;
using SNO;

public class TownBanner : Actor
{
	public int Index { get; set; }

	public bool Usable { get; set; }

	public TownBanner(uint uint_7, uint uint_8, SnoActor SnoActor_1) : base(uint_7, uint_8, SnoActor_1)
	{
		switch (SnoActor_1.Sno)
		{
		case ActorSnoEnum._banner_player_1:
		case ActorSnoEnum._banner_player_1_act2:
		case ActorSnoEnum._banner_player_1_act5:
			Index = 0;
			break;
		case ActorSnoEnum._banner_player_2:
		case ActorSnoEnum._banner_player_2_act2:
		case ActorSnoEnum._banner_player_2_act5:
			Index = 1;
			break;
		case ActorSnoEnum._banner_player_3:
		case ActorSnoEnum._banner_player_3_act2:
		case ActorSnoEnum._banner_player_3_act5:
			Index = 2;
			break;
		case ActorSnoEnum._banner_player_4:
		case ActorSnoEnum._banner_player_4_act2:
		case ActorSnoEnum._banner_player_4_act5:
			Index = 3;
			break;
		}
	}
}
