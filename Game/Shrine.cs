using Plugins;
using SNO;

public class Shrine : MapObject, IClickableActor
{
	public ShrineType Type { get; set; }

	public bool IsShrine
	{
		get {
			if (Type != ShrineType.BanditShrine && Type != ShrineType.BlessedShrine && Type != ShrineType.EmpoweredShrine && Type != ShrineType.EnlightenedShrine && Type != ShrineType.FleetingShrine && Type != ShrineType.FortuneShrine) {
				return Type == ShrineType.FrenziedShrine;
			}
			return true;
		}
	}

	public bool IsPylon
	{
		get {
			if (Type != ShrineType.ChannelingPylon && Type != ShrineType.ConduitPylon && Type != ShrineType.PowerPylon && Type != ShrineType.ShieldPylon) {
				return Type == ShrineType.SpeedPylon;
			}
			return true;
		}
	}

	public bool IsHealingWell => Type == ShrineType.HealingWell;

	public bool IsPoolOfReflection => Type == ShrineType.PoolOfReflection;

	public Shrine(uint uint_7, uint uint_8, ActorShrineTypeInfo actorShrineTypeInfo_0) : base(uint_7, uint_8, actorShrineTypeInfo_0.SnoActor)
	{
		Type = actorShrineTypeInfo_0.Type;
	}
}
