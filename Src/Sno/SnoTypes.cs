using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace RiftAssistant.Sno;

public sealed class AcdAttribute
{

	private readonly Dictionary<uint, string> dictionary_0;

	private readonly List<AttributeProcessor> processors = new List<AttributeProcessor>();

	private readonly Dictionary<int, int> dictionary_1 = new Dictionary<int, int>();

	public string Code { get; }

	public uint Index { get; }

	public AttributeValueType ValueType { get; }

	public IEnumerable<AttributeProcessor> Processors => processors;

	public bool OrderIndexPrimary { get; internal set; } = true;

	internal AcdAttribute(string code, uint uint_1, AttributeValueType attributeValueType, Dictionary<uint, string> dictionary_2)
	{
		Code = code;
		Index = uint_1;
		ValueType = attributeValueType;
		dictionary_0 = dictionary_2;
	}

	public uint GetId(uint modifier)
	{
		return Index | (modifier << 12);
	}

	public string GetDescription(uint modifier)
	{
		dictionary_0.TryGetValue(modifier, out var value);
		if (value == null && dictionary_0.Count > 0)
		{
			dictionary_0.TryGetValue(uint.MaxValue, out value);
		}
		return value;
	}

	public void AddProcessor(AttributeProcessor processor)
	{
		processors.Add(processor);
	}

	public int GetModLowestOrderIndex(int mod)
	{
		dictionary_1.TryGetValue(mod, out var value);
		return value;
	}

	public void SetModLowestOrderIndex(int mod, int value)
	{
		dictionary_1[mod] = value;
	}
}

public sealed class ActorShrineTypeInfo
{

	public ShrineType Type { get; }

	public SnoActor SnoActor { get; }

	internal ActorShrineTypeInfo(ShrineType shrineType, SnoActor actor)
	{
		Type = shrineType;
		SnoActor = actor;
	}
}

public sealed class AttributeProcessor
{

	public byte CompactId { get; }

	public string Code { get; }

	public AcdAttribute Attribute { get; }

	public uint Modifier { get; }

	public double? Multiplier { get; }

	public int RoundDecimals { get; }

	internal AttributeProcessor(byte compactId, string code, AcdAttribute attribute, uint maxValue, double? multiplier, int roundDecimals)
	{
		CompactId = compactId;
		Code = code;
		Attribute = attribute;
		Modifier = maxValue;
		Multiplier = multiplier;
		RoundDecimals = roundDecimals;
	}

	public double ProcessDouble(double dv)
	{
		if (Multiplier.HasValue)
		{
			dv *= Multiplier.Value;
		}
		if (Attribute.ValueType == AttributeValueType._float || Multiplier.HasValue)
		{
			switch (RoundDecimals)
			{
			case -2:
				dv = Math.Floor(dv);
				break;
			case -3:
				dv = Math.Ceiling(dv);
				break;
			default:
				dv = Math.Round(dv, RoundDecimals, MidpointRounding.AwayFromZero);
				break;
			case -1:
				break;
			}
		}
		if (Code == "bound_to_account" && dv != 0.0)
		{
			dv = 1.0;
		}
		if (Code == "vendor_bought" && dv != 0.0)
		{
			dv = 1.0;
		}
		return dv;
	}

	public int ProcessInt(int iv)
	{
		if (Attribute.ValueType == AttributeValueType._float)
		{
			throw new NotImplementedException();
		}
		if (Multiplier.HasValue)
		{
			iv = Convert.ToInt32((double)iv * Multiplier.Value);
		}
		if (Code == "bound_to_account" && iv != 0)
		{
			iv = 1;
		}
		if (Code == "vendor_bought" && iv != 0)
		{
			iv = 1;
		}
		return iv;
	}
}

internal sealed class FollowerClass
{
	public readonly string Code;

	public readonly string Name;

	public readonly ActorSnoEnum ActorSno;

	public FollowerClassEnum ClassEnum { get; }

	public FollowerClass(string code, string string_1, ActorSnoEnum actorSnoEnum, FollowerClassEnum followerClassEnum)
	{
		Code = code;
		Name = string_1;
		ActorSno = actorSnoEnum;
		ClassEnum = followerClassEnum;
	}
}

public enum FollowerClassEnum : uint
{
	Enchantress,
	Templar,
	Scoundrel
}

public enum GameBalanceType
{
	AxeBadData = -1,
	ItemTypes = 1,
	Items = 2,
	ExperienceTable = 3,
	Hirelings = 4,
	MonsterLevels = 5,
	Heroes = 7,
	AffixList = 8,
	Inventory = 9,
	MovementStyles = 10,
	Labels = 11,
	LootDistribution = 12,
	RareItemNames = 16,
	Scenery = 17,
	MonsterAffixes = 18,
	MonsterNames = 19,
	SocketedEffects = 21,
	ItemEnchantments = 23,
	HelpCodes = 24,
	ItemDropTable = 25,
	ItemLevelModifiers = 26,
	QualityClasses = 27,
	Handicaps = 28,
	ItemSalvageLevels = 29,
	Recipes = 32,
	SetItemBonuses = 33,
	EliteModifiers = 34,
	ItemTiers = 35,
	PowerFormulaTables = 36,
	ScriptedAchievementEvents = 37,
	ItemDurabilityCostsScalar = 38,
	LootRunQuestTiers = 39,
	ParagonBonuses = 40,
	MadeToOrderTypes = 42,
	MadeToOrderAffixFolders = 43,
	DevilsHandRedeemableSets = 44,
	LegacyItemConversions = 45,
	EnchantItemAffixUseCountCostScalars = 46,
	AffixGroup = 47,
	TieredLootRunLevels = 48
}

public sealed class HeroClassDefinition
{

	public HeroClass HeroClass { get; }

	public string Code { get; }

	public string FullCode { get; }

	public string Name { get; }

	public ActorSnoEnum MaleActorSno { get; }

	public ActorSnoEnum FemaleActorSno { get; }

	public bool IsRanged { get; }

	public string PrimaryResourceName { get; }

	public string SecondaryResourceName { get; }

	internal HeroClassDefinition(HeroClass heroClass2, string code, string fullCode, string stringByCode, bool isRanged, ActorSnoEnum actorSnoEnum, ActorSnoEnum actorSnoEnum2, string primaryResourceName, string secondaryResourceName)
	{
		HeroClass = heroClass2;
		Code = code;
		FullCode = fullCode;
		Name = stringByCode;
		IsRanged = isRanged;
		MaleActorSno = actorSnoEnum;
		FemaleActorSno = actorSnoEnum2;
		PrimaryResourceName = primaryResourceName;
		SecondaryResourceName = secondaryResourceName;
	}
}

public enum Modifier
{
	shift = 1,
	ctrl = 2,
	alt = 4
}

public enum KeyBinding
{
	hkUnknown = -1,
	hkESCAPE = 0,
	hk1 = 1,
	hk2 = 2,
	hk3 = 3,
	hk4 = 4,
	hk5 = 5,
	hk6 = 6,
	hk7 = 7,
	hk8 = 8,
	hk9 = 9,
	hk0 = 10,
	hkMINUS = 11,
	hkEQUALS = 12,
	hkBACK = 13,
	hkTAB = 14,
	hkQ = 15,
	hkW = 16,
	hkE = 17,
	hkR = 18,
	hkT = 19,
	hkY = 20,
	hkU = 21,
	hkI = 22,
	hkO = 23,
	hkP = 24,
	hkLBRACKET = 25,
	hkRBRACKET = 26,
	hkRETURN = 27,
	hkLCONTROL = 28,
	hkA = 29,
	hkS = 30,
	hkD = 31,
	hkF = 32,
	hkG = 33,
	hkH = 34,
	hkJ = 35,
	hkK = 36,
	hkL = 37,
	hkSEMICOLON = 38,
	hkAPOSTROPHE = 39,
	hkGRAVE = 40,
	hkLSHIFT = 41,
	hkBACKSLASH = 42,
	hkZ = 43,
	hkX = 44,
	hkC = 45,
	hkV = 46,
	hkB = 47,
	hkN = 48,
	hkM = 49,
	hkCOMMA = 50,
	hkPERIOD = 51,
	hkSLASH = 52,
	hkRSHIFT = 53,
	hkMULTIPLY = 54,
	hkLMENU = 55,
	hkSPACE = 56,
	hkCAPITAL = 57,
	hkF1 = 58,
	hkF2 = 59,
	hkF3 = 60,
	hkF4 = 61,
	hkF5 = 62,
	hkF6 = 63,
	hkF7 = 64,
	hkF8 = 65,
	hkF9 = 66,
	hkF10 = 67,
	hkNUMLOCK = 68,
	hkSCROLL = 69,
	hkNUMPAD7 = 70,
	hkNUMPAD8 = 71,
	hkNUMPAD9 = 72,
	hkSUBTRACT = 73,
	hkNUMPAD4 = 74,
	hkNUMPAD5 = 75,
	hkNUMPAD6 = 76,
	hkADD = 77,
	hkNUMPAD1 = 78,
	hkNUMPAD2 = 79,
	hkNUMPAD3 = 80,
	hkNUMPAD0 = 81,
	hkDECIMAL = 82,
	hkOEM_102 = 83,
	hkF11 = 84,
	hkF12 = 85,
	hkF13 = 86,
	hkF14 = 87,
	hkF15 = 88,
	hkKANA = 89,
	hkABNT_C1 = 90,
	hkCONVERT = 91,
	hkNOCONVERT = 92,
	hkYEN = 93,
	hkABNT_C2 = 94,
	hkNUMPADEQUALS = 95,
	hkPREVTRACK = 96,
	hkAT = 97,
	hkCOLON = 98,
	hkUNDERLINE = 99,
	hkKANJI = 100,
	hkSTOP = 101,
	hkAX = 102,
	hkUNLABELED = 103,
	hkNEXTTRACK = 104,
	hkNUMPADENTER = 105,
	hkRCONTROL = 106,
	hkMUTE = 107,
	hkCALCULATOR = 108,
	hkPLAYPAUSE = 109,
	hkMEDIASTOP = 110,
	hkVOLUMEDOWN = 111,
	hkVOLUMEUP = 112,
	hkWEBHOME = 113,
	hkNUMPADCOMMA = 114,
	hkDIVIDE = 115,
	hkSYSRQ = 116,
	hkRMENU = 117,
	hkPAUSE = 118,
	hkHOME = 119,
	hkUP = 120,
	hkPRIOR = 121,
	hkLEFT = 122,
	hkRIGHT = 123,
	hkEND = 124,
	hkDOWN = 125,
	hkNEXT = 126,
	hkINSERT = 127,
	hkDELETE = 128,
	hkLWIN = 129,
	hkRWIN = 130,
	hkAPPS = 131,
	hkPower = 132,
	hkSLEEP = 133,
	hkWAKE = 134,
	hkWEBSEARCH = 135,
	hkWEBFAVORITES = 136,
	hkWEBREFRESH = 137,
	hkWEBSTOP = 138,
	hkWEBFORWARD = 139,
	hkWEBBACK = 140,
	hkMYCOMPUTER = 141,
	hkMAIL = 142,
	hkMEDIASELECT = 143,
	hkMouse1 = 144,
	hkMouse2 = 145,
	hkMouse3 = 146,
	hkMouse4 = 147,
	hkMouse5 = 148,
	hkMWheelUp = 149,
	hkMWheelDown = 150,
	hkOEM_8 = 155
}

public enum MonsterType : uint
{
	Undead = 0u,
	Demon = 1u,
	Beast = 2u,
	Human = 3u,
	Breakable = 4u,
	Scenery = 5u,
	Ally = 6u,
	Team = 7u,
	Helper = 8u,
	Unknown = uint.MaxValue
}

public sealed class NavCell
{

	public float MinX { get; }

	public float MinY { get; }

	public float MaxX { get; }

	public float MaxY { get; }

	internal NavCell(float minX, float minY, float maxX, float maxY)
	{
		MinX = minX;
		MinY = minY;
		MaxX = maxX;
		MaxY = maxY;
	}
}

[Flags]
public enum NavCellFlags : ushort
{
	None = 0,
	AllowWalk = 1,
	AllowFlier = 2,
	AllowSpider = 4,
	LevelAreaBit0 = 8,
	LevelAreaBit1 = 0x10,
	NoNavMeshIntersected = 0x20,
	NoSpawn = 0x40,
	Special0 = 0x80,
	Special1 = 0x100,
	SymbolNotFound = 0x200,
	AllowProjectile = 0x400,
	AllowGhost = 0x800,
	RoundedCorner0 = 0x1000,
	RoundedCorner1 = 0x2000,
	RoundedCorner2 = 0x4000,
	RoundedCorner3 = 0x8000
}

public class SceneHint
{

	public string Hint { get; }

	public WorldCoordinate FloorCoordinate { get; set; }

	public SceneHint(string hint)
	{
		Hint = hint;
	}
}

internal sealed class SkillEffectRule
{

	public SkillEffectType Type { get; }

	public SnoActor SnoActor { get; }

	public float Radius { get; }

	internal SkillEffectRule(SkillEffectType skillEffectType, SnoActor actor, float radius)
	{
		Type = skillEffectType;
		SnoActor = actor;
		Radius = radius;
	}
}

public class SnoAct
{

	public uint Sno { get; }

	public int Index { get; }

	public List<SnoQuest> MainQuests { get; } = new List<SnoQuest>();

	public List<SnoQuest> Bounties { get; } = new List<SnoQuest>();

	public List<SnoActWaypoint> Waypoints { get; } = new List<SnoActWaypoint>();

	internal SnoAct(uint sno, int int_1)
	{
		Sno = sno;
		Index = int_1;
	}
}

public sealed class SnoActor
{

	public ActorSnoEnum Sno { get; }

	public ActorKind Kind { get; }

	public ActorType Type { get; }

	public bool IsStatic { get; }

	public string Code { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public uint[] TextureMap { get; set; }

	internal SnoActor(ActorSnoEnum actorSnoEnum, ActorType invalid, ActorKind none, bool isStatic, string code, string stringByCode, string stringByCodeEnglish)
	{
		Sno = actorSnoEnum;
		Kind = none;
		Type = invalid;
		IsStatic = isStatic;
		Code = code;
		NameLocalized = stringByCode;
		NameEnglish = stringByCodeEnglish;
	}
}

public sealed class SnoActWaypoint
{
	public uint WorldSno;

	public uint AreaSno;

	internal SnoActWaypoint(uint worldSno, uint areaSno)
	{
		WorldSno = worldSno;
		AreaSno = areaSno;
	}
}

public class SnoArea
{

	public uint Sno { get; }

	public string Code { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public AreaType Type { get; }

	public bool IsRandom { get; }

	public bool IsTown { get; }

	public int Act { get; }

	public string AreaGroupInWorld { get; } = "";

	public SnoWorld SnoWorld { get; set; }

	public uint HostAreaSno { get; }

	public SnoArea HostSnoArea => null;

	internal SnoArea(uint sno, string code, int act, string nameLocalized, string nameEnglish, AreaType areaType, bool isRandom, string areaGroupInWorld, bool isTown, uint hostAreaSno)
	{
		Sno = sno;
		Code = code;
		Act = act;
		NameLocalized = nameLocalized;
		NameEnglish = nameEnglish;
		Type = areaType;
		IsRandom = isRandom;
		AreaGroupInWorld = areaGroupInWorld;
		IsTown = isTown;
		HostAreaSno = hostAreaSno;
	}
}

public enum SNOGroupID
{
	Actor = 1,
	Adventure = 2,
	AmbientSound = 5,
	Anim = 6,
	Anim2D = 7,
	AnimSet = 8,
	Appearance = 9,
	Hero = 10,
	Cloth = 11,
	Conversation = 12,
	ConversationList = 13,
	EffectGroup = 14,
	Encounter = 15,
	Explosion = 17,
	FlagSet = 18,
	Font = 19,
	GameBalance = 20,
	Globals = 21,
	LevelArea = 22,
	Light = 23,
	MarkerSet = 24,
	Monster = 25,
	Observer = 26,
	Particle = 27,
	Physics = 28,
	Power = 29,
	Quest = 31,
	Rope = 32,
	Scene = 33,
	SceneGroup = 34,
	ShaderMap = 36,
	Shaders = 37,
	Shakes = 38,
	SkillKit = 39,
	Sound = 40,
	SoundBank = 41,
	StringList = 42,
	Surface = 43,
	Textures = 44,
	Trail = 45,
	UI = 46,
	Weather = 47,
	Worlds = 48,
	Recipe = 49,
	Condition = 51,
	TreasureClass = 52,
	Account = 53,
	TimedEvent = 55,
	Act = 56,
	Material = 57,
	QuestRange = 58,
	Lore = 59,
	Reverb = 60,
	PhysMesh = 61,
	Music = 62,
	Tutorial = 63,
	BossEncounter = 64,
	Accolade = 66,
	AnimTree = 67,
	Vibrations = 68
}

public class SnoItemAffix
{

	public uint Id { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public uint BaseAffixId { get; }

	public SnoItemAffixGroup SnoAffixGroup1 { get; }

	public SnoItemAffixGroup SnoAffixGroup2 { get; }

	public SnoItemMod[] Mods { get; set; }

	public HeroClass HeroClass { get; }

	public bool Minor { get; set; }

	internal SnoItemAffix(uint uint_2, string stringByCode2, string stringByCodeEnglish2, uint baseAffixId, SnoItemAffixGroup snoItemAffixGroup, SnoItemAffixGroup snoItemAffixGroup3, HeroClass heroClass2, bool minor)
	{
		Id = uint_2;
		NameLocalized = stringByCode2;
		NameEnglish = stringByCodeEnglish2;
		BaseAffixId = baseAffixId;
		SnoAffixGroup1 = snoItemAffixGroup;
		SnoAffixGroup2 = snoItemAffixGroup3;
		HeroClass = heroClass2;
		Minor = minor;
	}

	public override string ToString()
	{
		string nameLocalized2 = NameLocalized;
		SnoItemMod[] mods = Mods;
		foreach (SnoItemMod snoItemMod in mods)
		{
			nameLocalized2 = nameLocalized2 + " & " + snoItemMod.ToString();
		}
		return nameLocalized2;
	}
}

public class SnoItemAffixGroup
{

	private readonly List<SnoItemAffix> affixes = new List<SnoItemAffix>();

	public uint Id { get; }

	public IEnumerable<SnoItemAffix> Affixes => affixes;

	internal SnoItemAffixGroup(uint uint_1)
	{
		Id = uint_1;
	}

	public override string ToString()
	{
		return Id + " (" + affixes[0].Mods[0].Attribute.Code + ")";
	}

	public void AddAffix(SnoItemAffix affix)
	{
		affixes.Add(affix);
	}
}

public class SnoItemAffixGroupLink
{

	public SnoItemAffixGroup Group { get; }

	public int Level { get; }

	public int Flag { get; }

	internal SnoItemAffixGroupLink(SnoItemAffixGroup isnoItemAffixGroup_1, int level, int int_3)
	{
		Group = isnoItemAffixGroup_1;
		Level = level;
		Flag = int_3;
	}

	public override string ToString()
	{
		return Group.ToString() + " / " + Level.ToString("D", CultureInfo.InvariantCulture) + " / " + Flag.ToString("D", CultureInfo.InvariantCulture);
	}
}

public class SnoItemMod
{

	public AcdAttribute Attribute { get; }

	public uint Modifier { get; }

	public float Min { get; }

	public float Max { get; }

	public SnoItemAffix Affix { get; }

	internal SnoItemMod(AcdAttribute attribute, uint modifier, float float_2, float float_3, SnoItemAffix affix)
	{
		Attribute = attribute;
		Modifier = modifier;
		Min = float_2;
		Max = float_3;
		Affix = affix;
	}

	public override string ToString()
	{
		return Attribute.Code + " / " + Modifier + " = [" + Min.ToString("F", CultureInfo.InvariantCulture) + "] - [" + Max.ToString("F", CultureInfo.InvariantCulture) + "]";
	}
}

public sealed class SnoItemType
{

	public uint Id { get; }

	public string Code { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public SnoItemType ParentSnoType { get; set; }

	internal SnoItemType(uint uint_1, string code, string stringByCode, string stringByCodeEnglish, SnoItemType snoItemType)
	{
		Id = uint_1;
		Code = code;
		NameLocalized = stringByCode;
		NameEnglish = stringByCodeEnglish;
		ParentSnoType = snoItemType;
	}

	public override string ToString()
	{
		return Code;
	}
}

public sealed class SnoMonster
{

	public SnoActor SnoActor { get; }

	public uint Sno { get; }

	public string Code { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public bool IsUnique { get; }

	public MonsterPriority Priority { get; }

	public float RiftProgression { get; }

	internal SnoMonster(SnoActor snoActor2, uint sno, string code, string stringById, string stringByIdEnglish, MonsterPriority monsterPriority, bool isUnique, float riftProgression)
	{
		SnoActor = snoActor2;
		Sno = sno;
		Code = code;
		NameLocalized = stringById;
		NameEnglish = stringByIdEnglish;
		Priority = monsterPriority;
		IsUnique = isUnique;
		RiftProgression = riftProgression;
	}
}

public sealed class SnoMonsterAffix
{

	public uint Id { get; }

	public MonsterAffix Affix { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	internal SnoMonsterAffix(uint uint_1, MonsterAffix monsterAffix, string stringByCode, string stringByCodeEnglish)
	{
		Id = uint_1;
		Affix = monsterAffix;
		NameLocalized = stringByCode ?? monsterAffix.ToString();
		NameEnglish = stringByCodeEnglish ?? monsterAffix.ToString();
	}

	public override string ToString()
	{
		return NameLocalized;
	}
}

public sealed class SnoQuest
{

	private readonly Dictionary<uint, SnoQuestStep> steps = [];

	public string Code { get; }

	public uint Sno { get; }

	public string NameLocalized { get; }

	public string NameEnglish { get; }

	public string DescriptionLocalized { get; }

	public string DescriptionEnglish { get; }

	public SnoAct SnoAct { get; }

	public QuestType Type { get; }

	public QuestEventType EventType { get; }

	public int UnassignedStepId { get; }

	public string UnassignedStepBnetTitleLocalized { get; }

	public string UnassignedStepBnetTitleEnglish { get; }

	public BountyAct BountyAct { get; }

	public BountyType BountyType { get; }

	public SnoArea BountySnoArea { get; }

	public IEnumerable<SnoQuestStep> Steps => steps.Values;

	public SnoQuestStep GetStep(uint stepId)
	{
		steps.TryGetValue(stepId, out var value);
		return value;
	}

	internal SnoQuest(string code, uint sno, SnoAct snoAct, string stringByCode, string stringByCodeEnglish, string stringByCode2, string stringByCodeEnglish2, QuestType questType, QuestEventType questEventType, int unassignedStepId, string stringByCode3, string stringByCodeEnglish3, BountyAct bountyAct2, BountyType bountyType2, SnoArea bountySnoArea)
	{
		Code = code;
		Sno = sno;
		SnoAct = snoAct;
		NameLocalized = stringByCode;
		NameEnglish = stringByCodeEnglish;
		DescriptionLocalized = stringByCode2;
		DescriptionEnglish = stringByCodeEnglish2;
		BountyAct = bountyAct2;
		BountyType = bountyType2;
		BountySnoArea = bountySnoArea;
		Type = questType;
		EventType = questEventType;
		UnassignedStepId = unassignedStepId;
		UnassignedStepBnetTitleLocalized = stringByCode3;
		UnassignedStepBnetTitleEnglish = stringByCodeEnglish3;
	}

	internal void AddStep(SnoQuestStep snoQuestStep)
	{
		steps.Add(snoQuestStep.Id, snoQuestStep);
	}
}

public class SnoQuestStep
{

	public SnoQuest SnoQuest { get; }

	public uint Id { get; }

	public string SplashLocalized { get; }

	public string SplashEnglish { get; }

	public string BnetTitleLocalized { get; }

	public string BnetTitleEnglish { get; }

	public string BnetTextLocalized { get; }

	public string BnetTextEnglish { get; }

	internal SnoQuestStep(SnoQuest snoQuest, uint uint_1, string stringByCode4, string stringByCodeEnglish4, string stringByCode5, string stringByCodeEnglish5, string stringByCode6, string stringByCodeEnglish6)
	{
		SnoQuest = snoQuest;
		Id = uint_1;
		SplashLocalized = stringByCode4;
		SplashEnglish = stringByCodeEnglish4;
		BnetTitleLocalized = stringByCode5;
		BnetTitleEnglish = stringByCodeEnglish5;
		BnetTextLocalized = stringByCode6;
		BnetTextEnglish = stringByCodeEnglish6;
	}
}

internal static class SnoResourceHelper
{
	public static string GetWorlds()
	{
		return GameResources.Worlds;
	}

	public static string GetPowerStats()
	{
		return GameResources.PowerStats;
	}

	public static string GetPowerRuneIconOverrides()
	{
		return GameResources.PowerRuneIconOverrides;
	}

	public static string GetSceneHints()
	{
		return GameResources.SceneHints;
	}

	public static string GetQuests()
	{
		return GameResources.Quest;
	}

	public static string GetMonsters()
	{
		return GameResources.Monster;
	}

	public static string GetLevelAreas()
	{
		return GameResources.Levelarea;
	}

	public static string GetItems()
	{
		return GameResources.GamebalanceItems;
	}

	public static string GetKanaiItems()
	{
		return GameResources.GamebalanceKanai;
	}

	public static string GetActors()
	{
		return GameResources.Actor;
	}
}

public class SnoScene
{

	public readonly int NavCellBinPosition;

	public readonly int NavCellSavedCount;

	public readonly int NavSquareW;

	public readonly int NavSquareH;

	public readonly int NavSquareSavedCount;

	public readonly int NavSquareBinPosition;

	public NavCell[] NavCells;

	public float[,] NavSquares;

	private static Stream fileStream;

	private static Stream fileStream2;

	public uint Sno { get; }

	public string Code { get; }

	public SceneHint Hint { get; set; }

	private static Stream Stream_0 => fileStream ?? (fileStream = new FileStream(Path.Combine(Program.AppDir, "data", "scene_cell.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	private static Stream Stream_1 => fileStream2 ?? (fileStream2 = new FileStream(Path.Combine(Program.AppDir, "data", "scene_square.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	internal SnoScene(uint sno, int navCellBinPosition, int navCellSavedCount, int navSquareW, int navSquareH, int navSquareSavedCount, int navSquareBinPosition, string code)
	{
		Sno = sno;
		Code = code;
		NavCellBinPosition = navCellBinPosition;
		NavCellSavedCount = navCellSavedCount;
		NavSquareW = navSquareW;
		NavSquareH = navSquareH;
		NavSquareSavedCount = navSquareSavedCount;
		NavSquareBinPosition = navSquareBinPosition;
	}

	public void LoadNavCells()
	{
		if (NavCells == null)
		{
			NavCells = new NavCell[NavCellSavedCount];
			Stream_0.Position = NavCellBinPosition;
			DataReader dataReader = new DataReader(Stream_0);
			for (int i = 0; i < NavCellSavedCount; i++)
			{
				float float_ = dataReader.ReadSingle();
				float single = dataReader.ReadSingle();
				dataReader.ReadSingle();
				float float_3 = dataReader.ReadSingle();
				float float_4 = dataReader.ReadSingle();
				dataReader.ReadSingle();
				dataReader.ReadUInt32();
				NavCells[i] = new NavCell(float_, single, float_3, float_4);
			}
		}
	}

	public void LoadNavSquares()
	{
		if (NavSquares != null)
		{
			return;
		}
		NavSquares = new float[NavSquareW, NavSquareH];
		Stream_1.Position = NavSquareBinPosition;
		DataReader dataReader = new DataReader(Stream_1);
		int num = 0;
		for (int i = 0; i < NavSquareSavedCount; i++)
		{
			int num2 = dataReader.ReadPackedInt32();
			byte num3 = dataReader.ReadByte();
			float naN = float.NaN;
			if (num3 == 1)
			{
				naN = dataReader.ReadSingle();
			}
			for (int j = 0; j < num2; j++)
			{
				int num5 = num % NavSquareW;
				int num6 = num / NavSquareW;
				NavSquares[num5, num6] = naN;
				num++;
			}
		}
	}

	public override string ToString()
	{
		return Code;
	}
}

public class SnoSocketedEffect
{

	public SnoItemType SnoItemType { get; }

	public SnoItemMod[] Mods { get; }

	internal SnoSocketedEffect(SnoItemType snoItemType2, SnoItemMod[] mods)
	{
		SnoItemType = snoItemType2;
		Mods = mods;
	}
}

public sealed class SnoWorld
{

	public List<SnoWorldSceneInfo> SceneInfos = new List<SnoWorldSceneInfo>();

	public uint Sno { get; }

	public List<SnoArea> SnoAreas { get; } = new List<SnoArea>();

	internal SnoWorld(uint sno)
	{
		Sno = sno;
	}
}

public class SnoWorldSceneInfo
{

	public float PosX { get; }

	public float PosY { get; }

	public float MaxX { get; }

	public float MaxY { get; }

	public float W { get; }

	public float H { get; }

	public SnoArea SnoArea { get; }

	public string CalculatedPosId { get; }

	internal SnoWorldSceneInfo(float posX, float posY, float maxX, float maxY, SnoArea snoArea)
	{
		PosX = posX;
		PosY = posY;
		MaxX = maxX;
		MaxY = maxY;
		W = MaxX - PosX;
		H = MaxY - PosY;
		SnoArea = snoArea;
		if (snoArea.SnoWorld.Sno == 332336)
		{
			PosX = PosX - 2580f;
			PosY = PosY - 2280f;
		}
		CalculatedPosId = PosX.ToString(CultureInfo.InvariantCulture) + PosY.ToString(CultureInfo.InvariantCulture);
	}
}

public sealed class SnoWorldSceneInfoRandom : SnoWorldSceneInfo
{

	public List<SnoScene> SnoScenes { get; } = new List<SnoScene>();

	internal SnoWorldSceneInfoRandom(float float_6, float float_7, float float_8, float float_9, SnoArea snoArea)
		: base(float_6, float_7, float_8, float_9, snoArea)
	{
	}
}

public sealed class SnoWorldSceneInfoStatic : SnoWorldSceneInfo
{

	public SnoScene SnoScene { get; }

	internal SnoWorldSceneInfoStatic(float float_6, float float_7, float float_8, float float_9, SnoArea snoArea, SnoScene snoScene)
		: base(float_6, float_7, float_8, float_9, snoArea)
	{
		SnoScene = snoScene;
	}
}

public enum TagGroup
{
	NONE = -1,
	MISC = 0,
	IMAGE = 1,
	MARKER_CAMERA = 2,
	SHADERMAP_SHADOWS = 3,
	SPAWNER = 4,
	PROXIMITY_DETECTOR = 5,
	ACTOR_RIGIDANIM = 6,
	ACTOR_AI = 7,
	ACTOR_FOOTSTEPS = 8,
	ACTOR_HITBY = 9,
	ACTOR_ANIMATION = 10,
	ACTOR_GIZMO = 11,
	ACTOR_FLIPPY = 12,
	ACTOR_INVENTORY = 13,
	ACTOR_SPEEDS = 14,
	ACTOR_NAVMESH = 15,
	ACTOR_SHADOWS = 16,
	ACTOR_EFFECTS = 17,
	ACTOR_GET_HIT_EFFECTS = 18,
	ACTOR_CRITICAL_DEATHS = 19,
	POWER_TARGET = 20,
	POWER_SOURCE = 21,
	POWER_CONTINUOUS = 22,
	POWER_START = 23,
	POWER_APPEARANCE = 24,
	POWER_DETERMINETARGET = 25,
	POWER_UI = 26,
	POWER_TRIGGERTYPE = 27,
	POWER_TEMPLATE = 28,
	POWER_IMPLEMENTATION = 29,
	POWER_FLAGS = 30,
	POWER_ITEM_REQUIREMENTS = 31,
	POWER_UPGRADES = 32,
	POWER_PLAYER_USAGE = 33,
	POWER_ATTACK_PARAMS = 34,
	POWER_EFFECTS = 35,
	MARKER_INFO = 36,
	ACTOR_ITEM = 37,
	ACTOR_NPC = 38,
	ACTOR_BEHAVIOR = 39,
	VISUAL_INVENTORY = 40,
	WARNING_SOUNDS = 41,
	MONSTER_TEMP = 42,
	GENERIC_SCRIPT_PARAMETERS = 43,
	PORTAL = 44,
	SAVEPOINT = 45,
	AUDIOVOLUME = 46,
	WEATHERVOLUME = 47,
	DRLG_RULE = 48,
	DRLG_GROUP_RULE = 49,
	MONSTER_GENERIC_PROJECTILE = 50,
	MONSTER_GENERIC_PROJECTILE_SECONDARY = 51,
	ACTOR_MINIMAP = 52,
	MONSTER_GENERIC_PIE_SHOCKWAVE = 53,
	MONSTER_GENERIC_PIE_BREATH = 54,
	MONSTER_GENERIC_AOE_NOVA = 55,
	MONSTER_GENERIC_AOE_NOVA2 = 56,
	MONSTER_GENERIC_AOE_TARGETED = 57,
	MONSTER_GENERIC_SUMMON = 58,
	MONSTER_GENERIC_PROJECTILE2 = 59,
	MONSTER_GENERIC_SUMMON2 = 60,
	MONSTER_GENERIC_AOE_RANDOM = 61,
	MONSTER_NECROMANCER = 62,
	ANIMATION_FIRST = 63,
	ANIMATION_OTHER = 63,
	ANIMATION_DEATH = 64,
	ANIMATION_EMOTE = 65,
	ANIMATION_SCRIPTED_EVENT = 66,
	ANIMATION_IDLE = 67,
	ANIMATION_MOVEMENT = 68,
	ANIMATION_SPAWN = 69,
	ANIMATION_COMBAT = 70,
	ANIMATION_LAST = 71
}

public enum TagType
{
	FLOAT,
	HIGH_PRECISION_FLOAT,
	INT,
	ANIM,
	HIGH_PRECISION_PERCENT,
	ANGLE,
	ANGULARVELOCITY,
	ANGULARACCEL,
	TICK,
	VELOCITY,
	ACCEL,
	SHADER,
	ACTOR,
	STRINGLIST,
	SOUND,
	SOUNDBANK,
	AMBIENT_SOUND,
	POWER,
	PARTICLE,
	TEXTURE,
	EFFECTGROUP,
	MASS,
	BRAIN,
	GIZMO,
	ACTORATTRIBUTE,
	HITSOUND,
	ANIM_TAG,
	BOOL,
	GENDER,
	WORLD,
	CLOTH,
	ROPE,
	WEAPON_CLASS,
	COMPONENTSTYLE,
	COMPONENTLOOK,
	ACTOR_TOPOLOGY,
	ITEM_IMAGE,
	MAP_IMAGE,
	UI_IMAGE,
	USEITEM,
	GIZMO_LABEL,
	GAME_ERROR_LABEL,
	TEXT_PAGE_TEXT_LABEL,
	MINIMAP_NAME_LABEL,
	SET_DUNGEON_DESCRIPTION_LABEL,
	SET_DUNGEON_TITLE_LABEL,
	MONSTER,
	SNO_LEVEL_AREA,
	HARDPOINT,
	WORLD_RULE_TYPE,
	WORLD_PLACEMENT_TYPE,
	WORLD_TILE_TYPE,
	WORLD_TILE_SET,
	WORLD_TILE_FAMILY,
	WEATHER,
	VERTALPHA_FUNCTION,
	INVENTORY_TYPE,
	PASSABILTY_TYPE,
	SHAKE,
	DOOR_NUMBER,
	BEHAVIOR,
	TEXCOORD_FUNC,
	MATERIAL_FUNC,
	PS_FUNC,
	PMA_FUNC,
	VB_FMT,
	ANIM2D_SNO,
	FOCAL_POINT_EVENT_TYPE,
	FOCAL_POINT_ATTACK_TYPE,
	ENCOUNTER,
	TILT_TYPE,
	CAPTURE_ACTION,
	CAPTURE_SEARCH_METHOD,
	FADE_GROUP,
	ALIGNMENT,
	PICK_STYLE,
	SCRIPT,
	CONVERSATION,
	CONVERSATIONLIST,
	ACTORGROUP,
	STARTLOC_NAME,
	TEAM,
	PROXIMITY_SHAPE,
	AUDIOVOLUME_SHAPE,
	WEATHERVOLUME_SHAPE,
	MONSTER_RARITY,
	PORTAL_RESOLVE_METHOD,
	STRING_FORMULA,
	POWER_TEMPLATE,
	POWER_SPELLFUNC,
	POWER_SPECIALDEATH,
	POWER_BRAIN_ACTION,
	POWER_LOS_CHECK,
	GBID_ITEMTYPE,
	TREASURECLASS,
	POWER_PAYLOAD,
	PATH_NODE_TYPE,
	BUFF_STACKING_METHOD,
	APPEARANCE_FX_FUNCTION,
	AUTOASSIGNLOCATION,
	PLAYER_CLASS,
	OBSERVER,
	LIGHTING_TYPE,
	GBID_ITEM,
	LORE,
	ITEM_LABEL,
	AISTATE,
	CONDITION,
	CONDUCTOR,
	TIMEDEVENT,
	SPAWNTRIGGERTYPE,
	CRAFTERTYPE,
	CONTACT_FRAME_TYPES,
	QUESTRANGE,
	SURFACE,
	HIRELING_CLASS,
	REVERB,
	POWER_CUSTOM_TARGET_FUNC,
	MUSIC,
	DAMAGE_TYPE,
	SNO_BOSS_ENCOUNTER,
	DIFFICULTY,
	TETHER_TYPE,
	DELIVERY_MECHANISM,
	VIBRATION,
	WORLD_EDGE_TYPE,
	WORLD_SHAPE_TYPE,
	WORLD_CHOKEPOINT_TYPE,
	WORLD_CHOKEPOINT_DIR_TYPE,
	WORLD_LABEL_TYPE,
	WORLD_EXIT_DIR_TYPE,
	WORLD_SPECIAL_TILE_TYPE,
	CHARGE_STEERING_TYPES,
	SNO_QUEST,
	OPENWORLDMODE,
	ACT,
	GBID_MONSTERAFFIX,
	GENDER_ALLOW_INVALID,
	POWER_HOTBAR_EXCLUSIVE_TYPES,
	POWER_SCROLL_BUFF_EXCLUSIVE_TYPES,
	TEXTURE_FORMAT,
	NONE
}

internal struct TextureIndexEntry
{
	public uint Id;

	public long AtlasPosition;

	public int X;

	public int Y;

	public int W;

	public int H;
}
