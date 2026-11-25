#nullable enable annotations
#nullable disable warnings
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace RiftAssistant.Model;

public class Banner(uint id, uint worldId, WorldCoordinate worldCoordinate)
{
	private readonly uint id = id;
	private readonly uint worldId = worldId;
	private readonly WorldCoordinate worldCoordinate = worldCoordinate;

	public uint Id
	{
		get
		{
			return id;
		}
	}

	public uint WorldId
	{
		get
		{
			return worldId;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		get
		{
			return worldCoordinate;
		}
	}
}

internal class Door(uint acdid, uint annId2, SnoActor snoActor2) : MapObject(acdid, annId2, snoActor2)
{
}

public class HeadStone(uint acdid, uint annId3, SnoActor? actor, uint annId2, Player? player) : Actor(acdid, annId3, actor)
{
	public uint PlayerActorAnnId { get; set; } = annId2;

	public Player Player { get; set; } = player;
}

public class MapObject : Actor, IClickableActor
{
	public Stopwatch FirstClicked {  get; set; }

	public Stopwatch LastClicked { get; set; }

	public bool? ShouldBeClicked { get; set; }

	public MapObject(uint acdid, uint annId2, SnoActor snoActor2) : base(acdid, annId2, snoActor2)
	{
		IsClickable = true;
	}

	public void RegisterClick()
	{
		FirstClicked.Start();
		LastClicked.Restart();
	}
}

public class Marker(string id, uint worldId, SnoQuest? snoQuest, SnoActor? snoActor, WorldCoordinate worldCoordinate, uint textureSno, int textureFrameIndex)
{
	private readonly string id = id;
	private SnoActor? snoActor = snoActor;
	private readonly SnoQuest? snoQuest = snoQuest;
	private readonly uint worldId = worldId;
	private readonly WorldCoordinate worldCoordinate = worldCoordinate;
	private uint textureSno = textureSno;
	private int textureFrameIndex = textureFrameIndex;
	private bool isPylon;
	private bool isShrine;
	private bool isPoolOfReflection;
	private bool isHealingWell;
	private bool isUsed;

	public string Id {
		get {
			return id;
		}
	}

	public SnoActor? SnoActor
	{
		get {
			return snoActor;
		}
		set {
			snoActor = value;
		}
	}

	public SnoQuest? SnoQuest
	{
		get {
			return snoQuest;
		}
	}

	public uint WorldId
	{
		get {
			return worldId;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		get {
			return worldCoordinate;
		}
	}

	public uint TextureSno
	{
		get {
			return textureSno;
		}
		set {
			textureSno = value;
		}
	}

	public int TextureFrameIndex
	{
		get {
			return textureFrameIndex;
		}
		set {
			textureFrameIndex = value;
		}
	}

	public bool IsPylon
	{
		get {
			return isPylon;
		}
		set {
			isPylon = value;
		}
	}

	public bool IsShrine
	{
		get {
			return isShrine;
		}
		set {
			isShrine = value;
		}
	}

	public bool IsPoolOfReflection
	{
		get {
			return isPoolOfReflection;
		}
		set {
			isPoolOfReflection = value;
		}
	}

	public bool IsHealingWell
	{
		get {
			return isHealingWell;
		}
		set {
			isHealingWell = value;
		}
	}

	public bool IsUsed
	{
		get {
			return isUsed;
		}
		set {
			isUsed = value;
		}
	}

	public string? Name =>
	SnoActor?.NameLocalized
	?? SnoData.Monsters.GetMonster(SnoActor?.Sno ?? 0)?.NameLocalized
	?? SnoQuest?.NameLocalized;
}

public class Monster(uint acdid, uint annId2, SnoActor snoActor2, SnoMonster snoMonster2) : Actor(acdid, annId2, snoActor2)
{
	public SnoMonster SnoMonster { get; set; } = snoMonster2;

	public Stopwatch LastSpeak { get; set; }

	public uint UInt32_0 => SnoMonster?.Sno ?? 0;

	public MonsterPack Pack { get; set; }

	public double MaxHealth { get; set; }

	public bool IsElite { get; set; }

	public double CurHealth { get; set; }

	public bool Frozen { get; set; }

	public bool Chilled { get; set; }

	public bool Slow { get; set; }

	public bool Stunned { get; set; }

	public bool Burrowed { get; set; }

	public bool Invulnerable { get; set; }

	public bool Hidden { get; set; }

	public bool Stealthed { get; set; }

	public bool Invisible { get; set; }

	public bool Blind { get; set; }

	public bool Bleeding { get; set; }

	public ActorRarity Rarity { get; set; }

	public AnimSnoEnum Animation { get; set; }

	public AcdAnimationState AnimationState { get; set; }

	public float DotDpsApplied { get; set; }

	public bool Illusion { get; set; }

	public bool Palmed { get; set; }

	public bool Haunted { get; set; }

	public bool MarkedForDeath { get; set; }

	public bool Locust { get; set; }

	public bool Strongarmed { get; set; }

	public bool Phoenixed { get; set; }

	public bool Piranhas { get; set; }

	public bool Cursed { get; set; }

	public bool IsQuestMonster { get; set; }

	public bool Attackable { get; set; }

	public bool IsAlive => CurHealth >= 0.30000001192092896;

	public List<SnoMonsterAffix> AffixSnoList {  get; set; }
}

internal class MonsterObstacle : Monster
{
	public MonsterObstacle(uint acdid, uint annId2, SnoActor snoActor2) : base(acdid, annId2, snoActor2, SnoData.Monsters.SnoMonsterObstacle)
	{
		base.MaxHealth = 1.0;
	}
}

public class Portal(uint acdid, uint annId, SnoActor snoActor2, SnoArea? snoArea, uint uint_10) : Actor(acdid, annId, snoActor2)
{
	public SnoArea TargetArea { get; set; } = snoArea;

	public uint TargetWorldId { get; set; } = uint_10;

	public bool ActorAvailable { get; set; }

	public Stopwatch ActorLastAvailable { get; set; } = new();
}

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

	public Shrine(uint acdid, uint annId2, ActorShrineTypeInfo actorShrineTypeInfo) : base(acdid, annId2, actorShrineTypeInfo.SnoActor)
	{
		Type = actorShrineTypeInfo.Type;
	}
}

internal class SkillEffect(uint acdid, uint annId2, SnoActor snoActor2, SkillEffectRule skillEffectRule) : Actor(acdid, annId2, snoActor2)
{
	public SkillEffectRule SkillEffectRule { get; } = skillEffectRule;
}

internal class TownBanner : Actor
{
	public int Index { get; set; }

	public bool Usable { get; set; }

	public TownBanner(uint acdid, uint annId2, SnoActor snoActor2) : base(acdid, annId2, snoActor2)
	{
		switch (snoActor2.Sno)
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

public class Waypoint(SnoArea snoArea, BountyAct bountyAct, PointF pointF)
{
	private SnoArea snoArea = snoArea;

	private BountyAct bountyAct = bountyAct;

	private PointF pointF = pointF;

	public SnoArea TargetSnoArea
	{
		get
		{
			return snoArea;
		}
		set
		{
			snoArea = value;
		}
	}

	public BountyAct BountyAct
	{
		get
		{
			return bountyAct;
		}
		set
		{
			bountyAct = value;
		}
	}

	public PointF CoordinateOnMapUiElement
	{
		get
		{
			return pointF;
		}
		set
		{
			pointF = value;
		}
	}
}
