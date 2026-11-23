using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace SNO;

public sealed class AcdAttribute
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly AttributeValueType attributeValueType_0;

	[CompilerGenerated]
	private bool bool_0 = true;

	private readonly Dictionary<uint, string> dictionary_0;

	private readonly List<AttributeProcessor> list_0 = new List<AttributeProcessor>();

	private readonly Dictionary<int, int> dictionary_1 = new Dictionary<int, int>();

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public uint Index
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public AttributeValueType ValueType
	{
		[CompilerGenerated]
		get
		{
			return attributeValueType_0;
		}
	}

	public IEnumerable<AttributeProcessor> Processors => list_0;

	public bool OrderIndexPrimary
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		internal set
		{
			bool_0 = value;
		}
	}

	internal AcdAttribute(string string_1, uint uint_1, AttributeValueType attributeValueType_1, Dictionary<uint, string> dictionary_2)
	{
		string_0 = string_1;
		uint_0 = uint_1;
		attributeValueType_0 = attributeValueType_1;
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
		list_0.Add(processor);
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
	[CompilerGenerated]
	private readonly ShrineType shrineType_0;

	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

	public ShrineType Type
	{
		[CompilerGenerated]
		get
		{
			return shrineType_0;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
	}

	internal ActorShrineTypeInfo(ShrineType shrineType_1, SnoActor SnoActor_1)
	{
		shrineType_0 = shrineType_1;
		SnoActor_0 = SnoActor_1;
	}
}

public sealed class AttributeProcessor
{
	[CompilerGenerated]
	private readonly byte byte_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly AcdAttribute iattribute_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly double? nullable_0;

	[CompilerGenerated]
	private readonly int int_0;

	public byte CompactId
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public AcdAttribute Attribute
	{
		[CompilerGenerated]
		get
		{
			return iattribute_0;
		}
	}

	public uint Modifier
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public double? Multiplier
	{
		[CompilerGenerated]
		get
		{
			return nullable_0;
		}
	}

	public int RoundDecimals
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	internal AttributeProcessor(byte byte_1, string string_1, AcdAttribute iattribute_1, uint uint_1, double? nullable_1, int int_1)
	{
		byte_0 = byte_1;
		string_0 = string_1;
		iattribute_0 = iattribute_1;
		uint_0 = uint_1;
		nullable_0 = nullable_1;
		int_0 = int_1;
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

public sealed class FollowerClass
{
	public readonly string Code;

	public readonly string Name;

	public readonly ActorSnoEnum ActorSno;

	[CompilerGenerated]
	private readonly FollowerClassEnum followerClassEnum_0;

	public FollowerClassEnum ClassEnum
	{
		[CompilerGenerated]
		get
		{
			return followerClassEnum_0;
		}
	}

	public FollowerClass(string string_0, string string_1, ActorSnoEnum actorSnoEnum_0, FollowerClassEnum followerClassEnum_1)
	{
		Code = string_0;
		Name = string_1;
		ActorSno = actorSnoEnum_0;
		followerClassEnum_0 = followerClassEnum_1;
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
	[CompilerGenerated]
	private readonly HeroClass heroClass_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_0;

	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_1;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	public HeroClass HeroClass
	{
		[CompilerGenerated]
		get
		{
			return heroClass_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string FullCode
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public ActorSnoEnum MaleActorSno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_0;
		}
	}

	public ActorSnoEnum FemaleActorSno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_1;
		}
	}

	public bool IsRanged
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public string PrimaryResourceName
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string SecondaryResourceName
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	internal HeroClassDefinition(HeroClass heroClass_1, string string_5, string string_6, string string_7, bool bool_1, ActorSnoEnum actorSnoEnum_2, ActorSnoEnum actorSnoEnum_3, string string_8, string string_9)
	{
		heroClass_0 = heroClass_1;
		string_0 = string_5;
		string_1 = string_6;
		string_2 = string_7;
		bool_0 = bool_1;
		actorSnoEnum_0 = actorSnoEnum_2;
		actorSnoEnum_1 = actorSnoEnum_3;
		string_3 = string_8;
		string_4 = string_9;
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
	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly float float_2;

	[CompilerGenerated]
	private readonly float float_3;

	public float MinX
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float MinY
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
	}

	public float MaxX
	{
		[CompilerGenerated]
		get
		{
			return float_2;
		}
	}

	public float MaxY
	{
		[CompilerGenerated]
		get
		{
			return float_3;
		}
	}

	internal NavCell(float float_4, float float_5, float float_6, float float_7)
	{
		float_0 = float_4;
		float_1 = float_5;
		float_2 = float_6;
		float_3 = float_7;
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
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private WorldCoordinate iworldCoordinate_0;

	public string Hint
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		[CompilerGenerated]
		get
		{
			return iworldCoordinate_0;
		}
		[CompilerGenerated]
		set
		{
			iworldCoordinate_0 = value;
		}
	}

	public SceneHint(string string_1)
	{
		string_0 = string_1;
	}
}

public sealed class SkillEffectRule
{
	[CompilerGenerated]
	private readonly SkillEffectType skillEffectType_0;

	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

	[CompilerGenerated]
	private readonly float float_0;

	public SkillEffectType Type
	{
		[CompilerGenerated]
		get
		{
			return skillEffectType_0;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
	}

	public float Radius
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	internal SkillEffectRule(SkillEffectType skillEffectType_1, SnoActor SnoActor_1, float float_1)
	{
		skillEffectType_0 = skillEffectType_1;
		SnoActor_0 = SnoActor_1;
		float_0 = float_1;
	}
}

public class SnoAct
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly List<SnoQuest> list_0 = new List<SnoQuest>();

	[CompilerGenerated]
	private readonly List<SnoQuest> list_1 = new List<SnoQuest>();

	[CompilerGenerated]
	private readonly List<SnoActWaypoint> list_2 = new List<SnoActWaypoint>();

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public List<SnoQuest> MainQuests
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public List<SnoQuest> Bounties
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
	}

	public List<SnoActWaypoint> Waypoints
	{
		[CompilerGenerated]
		get
		{
			return list_2;
		}
	}

	internal SnoAct(uint uint_1, int int_1)
	{
		uint_0 = uint_1;
		int_0 = int_1;
	}
}

public sealed class SnoActor
{
	[CompilerGenerated]
	private readonly ActorSnoEnum actorSnoEnum_0;

	[CompilerGenerated]
	private readonly ActorKind actorKind_0;

	[CompilerGenerated]
	private readonly ActorType actorType_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private uint[] uint_0;

	public ActorSnoEnum Sno
	{
		[CompilerGenerated]
		get
		{
			return actorSnoEnum_0;
		}
	}

	public ActorKind Kind
	{
		[CompilerGenerated]
		get
		{
			return actorKind_0;
		}
	}

	public ActorType Type
	{
		[CompilerGenerated]
		get
		{
			return actorType_0;
		}
	}

	public bool IsStatic
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public uint[] TextureMap
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
		[CompilerGenerated]
		set
		{
			uint_0 = value;
		}
	}

	internal SnoActor(ActorSnoEnum actorSnoEnum_1, ActorType actorType_1, ActorKind actorKind_1, bool bool_1, string string_3, string string_4, string string_5)
	{
		actorSnoEnum_0 = actorSnoEnum_1;
		actorKind_0 = actorKind_1;
		actorType_0 = actorType_1;
		bool_0 = bool_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
	}
}

public sealed class SnoActWaypoint
{
	public uint WorldSno;

	public uint AreaSno;

	internal SnoActWaypoint(uint uint_0, uint uint_1)
	{
		WorldSno = uint_0;
		AreaSno = uint_1;
	}
}

public class SnoArea
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly AreaType areaType_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_3 = "";

	[CompilerGenerated]
	private SnoWorld isnoWorld_0;

	[CompilerGenerated]
	private readonly uint uint_1;

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public AreaType Type
	{
		[CompilerGenerated]
		get
		{
			return areaType_0;
		}
	}

	public bool IsRandom
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public bool IsTown
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	public int Act
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string AreaGroupInWorld
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public SnoWorld SnoWorld
	{
		[CompilerGenerated]
		get
		{
			return isnoWorld_0;
		}
		[CompilerGenerated]
		set
		{
			isnoWorld_0 = value;
		}
	}

	public uint HostAreaSno
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
	}

	public SnoArea HostSnoArea => null;

	internal SnoArea(uint uint_2, string string_4, int int_1, string string_5, string string_6, AreaType areaType_1, bool bool_2, string string_7, bool bool_3, uint uint_3)
	{
		uint_0 = uint_2;
		string_0 = string_4;
		int_0 = int_1;
		string_1 = string_5;
		string_2 = string_6;
		areaType_0 = areaType_1;
		bool_0 = bool_2;
		string_3 = string_7;
		bool_1 = bool_3;
		uint_1 = uint_3;
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
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly uint uint_1;

	[CompilerGenerated]
	private readonly SnoItemAffixGroup isnoItemAffixGroup_0;

	[CompilerGenerated]
	private readonly SnoItemAffixGroup isnoItemAffixGroup_1;

	[CompilerGenerated]
	private SnoItemMod[] isnoItemMod_0;

	[CompilerGenerated]
	private readonly HeroClass heroClass_0;

	[CompilerGenerated]
	private bool bool_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public uint BaseAffixId
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
	}

	public SnoItemAffixGroup SnoAffixGroup1
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_0;
		}
	}

	public SnoItemAffixGroup SnoAffixGroup2
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_1;
		}
	}

	public SnoItemMod[] Mods
	{
		[CompilerGenerated]
		get
		{
			return isnoItemMod_0;
		}
		[CompilerGenerated]
		set
		{
			isnoItemMod_0 = value;
		}
	}

	public HeroClass HeroClass
	{
		[CompilerGenerated]
		get
		{
			return heroClass_0;
		}
	}

	public bool Minor
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	internal SnoItemAffix(uint uint_2, string string_2, string string_3, uint uint_3, SnoItemAffixGroup isnoItemAffixGroup_2, SnoItemAffixGroup isnoItemAffixGroup_3, HeroClass heroClass_1, bool bool_1)
	{
		uint_0 = uint_2;
		string_0 = string_2;
		string_1 = string_3;
		uint_1 = uint_3;
		isnoItemAffixGroup_0 = isnoItemAffixGroup_2;
		isnoItemAffixGroup_1 = isnoItemAffixGroup_3;
		heroClass_0 = heroClass_1;
		Minor = bool_1;
	}

	public override string ToString()
	{
		string text = NameLocalized;
		SnoItemMod[] mods = Mods;
		foreach (SnoItemMod snoItemMod in mods)
		{
			text = text + " & " + snoItemMod.ToString();
		}
		return text;
	}
}

public class SnoItemAffixGroup
{
	[CompilerGenerated]
	private readonly uint uint_0;

	private readonly List<SnoItemAffix> list_0 = new List<SnoItemAffix>();

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public IEnumerable<SnoItemAffix> Affixes => list_0;

	internal SnoItemAffixGroup(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public override string ToString()
	{
		return Id + " (" + list_0[0].Mods[0].Attribute.Code + ")";
	}

	public void AddAffix(SnoItemAffix affix)
	{
		list_0.Add(affix);
	}
}

public class SnoItemAffixGroupLink
{
	[CompilerGenerated]
	private readonly SnoItemAffixGroup isnoItemAffixGroup_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly int int_1;

	public SnoItemAffixGroup Group
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffixGroup_0;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public int Flag
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	internal SnoItemAffixGroupLink(SnoItemAffixGroup isnoItemAffixGroup_1, int int_2, int int_3)
	{
		isnoItemAffixGroup_0 = isnoItemAffixGroup_1;
		int_0 = int_2;
		int_1 = int_3;
	}

	public override string ToString()
	{
		return Group.ToString() + " / " + Level.ToString("D", CultureInfo.InvariantCulture) + " / " + Flag.ToString("D", CultureInfo.InvariantCulture);
	}
}

public class SnoItemMod
{
	[CompilerGenerated]
	private readonly AcdAttribute iattribute_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly SnoItemAffix isnoItemAffix_0;

	public AcdAttribute Attribute
	{
		[CompilerGenerated]
		get
		{
			return iattribute_0;
		}
	}

	public uint Modifier
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public float Min
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float Max
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
	}

	public SnoItemAffix Affix
	{
		[CompilerGenerated]
		get
		{
			return isnoItemAffix_0;
		}
	}

	internal SnoItemMod(AcdAttribute iattribute_1, uint uint_1, float float_2, float float_3, SnoItemAffix isnoItemAffix_1)
	{
		iattribute_0 = iattribute_1;
		uint_0 = uint_1;
		float_0 = float_2;
		float_1 = float_3;
		isnoItemAffix_0 = isnoItemAffix_1;
	}

	public override string ToString()
	{
		return Attribute.Code + " / " + Modifier + " = [" + Min.ToString("F", CultureInfo.InvariantCulture) + "] - [" + Max.ToString("F", CultureInfo.InvariantCulture) + "]";
	}
}

public sealed class SnoItemType
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private SnoItemType SnoItemType_0;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public SnoItemType ParentSnoType
	{
		[CompilerGenerated]
		get
		{
			return SnoItemType_0;
		}
		[CompilerGenerated]
		set
		{
			SnoItemType_0 = value;
		}
	}

	internal SnoItemType(uint uint_1, string string_3, string string_4, string string_5, SnoItemType SnoItemType_1)
	{
		uint_0 = uint_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
		ParentSnoType = SnoItemType_1;
	}

	public override string ToString()
	{
		return Code;
	}
}

public sealed class SnoMonster
{
	[CompilerGenerated]
	private readonly SnoActor SnoActor_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly MonsterPriority monsterPriority_0;

	[CompilerGenerated]
	private readonly float float_0;

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
	}

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public bool IsUnique
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public MonsterPriority Priority
	{
		[CompilerGenerated]
		get
		{
			return monsterPriority_0;
		}
	}

	public float RiftProgression
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	internal SnoMonster(SnoActor snoActor_0, uint uint_1, string string_3, string string_4, string string_5, MonsterPriority monsterPriority_1, bool bool_1, float float_1)
	{
		SnoActor_0 = snoActor_0;
		uint_0 = uint_1;
		string_0 = string_3;
		string_1 = string_4;
		string_2 = string_5;
		monsterPriority_0 = monsterPriority_1;
		bool_0 = bool_1;
		float_0 = float_1;
	}
}

public sealed class SnoMonsterAffix
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly MonsterAffix monsterAffix_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public MonsterAffix Affix
	{
		[CompilerGenerated]
		get
		{
			return monsterAffix_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	internal SnoMonsterAffix(uint uint_1, MonsterAffix monsterAffix_1, string string_2, string string_3)
	{
		uint_0 = uint_1;
		monsterAffix_0 = monsterAffix_1;
		string_0 = string_2 ?? monsterAffix_1.ToString();
		string_1 = string_3 ?? monsterAffix_1.ToString();
	}

	public override string ToString()
	{
		return NameLocalized;
	}
}

public sealed class SnoQuest
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	[CompilerGenerated]
	private readonly SnoAct isnoAct_0;

	[CompilerGenerated]
	private readonly QuestType questType_0;

	[CompilerGenerated]
	private readonly QuestEventType questEventType_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_5;

	[CompilerGenerated]
	private readonly string string_6;

	[CompilerGenerated]
	private readonly BountyAct bountyAct_0;

	[CompilerGenerated]
	private readonly BountyType bountyType_0;

	[CompilerGenerated]
	private readonly SnoArea isnoArea_0;

	private readonly Dictionary<uint, SnoQuestStep> dictionary_0 = [];

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string NameLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string NameEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string DescriptionLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string DescriptionEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	public SnoAct SnoAct
	{
		[CompilerGenerated]
		get
		{
			return isnoAct_0;
		}
	}

	public QuestType Type
	{
		[CompilerGenerated]
		get
		{
			return questType_0;
		}
	}

	public QuestEventType EventType
	{
		[CompilerGenerated]
		get
		{
			return questEventType_0;
		}
	}

	public int UnassignedStepId
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public string UnassignedStepBnetTitleLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
	}

	public string UnassignedStepBnetTitleEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
	}

	public BountyAct BountyAct
	{
		[CompilerGenerated]
		get
		{
			return bountyAct_0;
		}
	}

	public BountyType BountyType
	{
		[CompilerGenerated]
		get
		{
			return bountyType_0;
		}
	}

	public SnoArea BountySnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
	}

	public IEnumerable<SnoQuestStep> Steps => dictionary_0.Values;

	public SnoQuestStep GetStep(uint stepId)
	{
		dictionary_0.TryGetValue(stepId, out var value);
		return value;
	}

	internal SnoQuest(string string_7, uint uint_1, SnoAct isnoAct_1, string string_8, string string_9, string string_10, string string_11, QuestType questType_1, QuestEventType questEventType_1, int int_1, string string_12, string string_13, BountyAct bountyAct_1, BountyType bountyType_1, SnoArea isnoArea_1)
	{
		string_0 = string_7;
		uint_0 = uint_1;
		isnoAct_0 = isnoAct_1;
		string_1 = string_8;
		string_2 = string_9;
		string_3 = string_10;
		string_4 = string_11;
		bountyAct_0 = bountyAct_1;
		bountyType_0 = bountyType_1;
		isnoArea_0 = isnoArea_1;
		questType_0 = questType_1;
		questEventType_0 = questEventType_1;
		int_0 = int_1;
		string_5 = string_12;
		string_6 = string_13;
	}

	internal void method_0(SnoQuestStep isnoQuestStep_0)
	{
		dictionary_0.Add(isnoQuestStep_0.Id, isnoQuestStep_0);
	}
}

public class SnoQuestStep
{
	[CompilerGenerated]
	private readonly SnoQuest isnoQuest_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	[CompilerGenerated]
	private readonly string string_5;

	public SnoQuest SnoQuest
	{
		[CompilerGenerated]
		get
		{
			return isnoQuest_0;
		}
	}

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string SplashLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string SplashEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string BnetTitleLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public string BnetTitleEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public string BnetTextLocalized
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
	}

	public string BnetTextEnglish
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
	}

	internal SnoQuestStep(SnoQuest isnoQuest_1, uint uint_1, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11)
	{
		isnoQuest_0 = isnoQuest_1;
		uint_0 = uint_1;
		string_0 = string_6;
		string_1 = string_7;
		string_2 = string_8;
		string_3 = string_9;
		string_4 = string_10;
		string_5 = string_11;
	}
}

public static class SnoResourceHelper
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
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private SceneHint SceneHint_0;

	public readonly int NavCellBinPosition;

	public readonly int NavCellSavedCount;

	public readonly int NavSquareW;

	public readonly int NavSquareH;

	public readonly int NavSquareSavedCount;

	public readonly int NavSquareBinPosition;

	public NavCell[] NavCells;

	public float[,] NavSquares;

	private static Stream stream_0;

	private static Stream stream_1;

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public SceneHint Hint
	{
		[CompilerGenerated]
		get
		{
			return SceneHint_0;
		}
		[CompilerGenerated]
		set
		{
			SceneHint_0 = value;
		}
	}

	private static Stream Stream_0 => stream_0 ?? (stream_0 = new FileStream(Path.Combine(Program.AppDir, "data", "scene_cell.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	private static Stream Stream_1 => stream_1 ?? (stream_1 = new FileStream(Path.Combine(Program.AppDir, "data", "scene_square.bin"), FileMode.Open, FileAccess.Read, FileShare.Read));

	internal SnoScene(uint uint_1, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, string string_1)
	{
		uint_0 = uint_1;
		string_0 = string_1;
		NavCellBinPosition = int_0;
		NavCellSavedCount = int_1;
		NavSquareW = int_2;
		NavSquareH = int_3;
		NavSquareSavedCount = int_4;
		NavSquareBinPosition = int_5;
	}

	public void LoadNavCells()
	{
		if (NavCells == null)
		{
			NavCells = new NavCell[NavCellSavedCount];
			Stream_0.Position = NavCellBinPosition;
			DataReader @class = new DataReader(Stream_0);
			for (int i = 0; i < NavCellSavedCount; i++)
			{
				float float_ = @class.method_14();
				float float_2 = @class.method_14();
				@class.method_14();
				float float_3 = @class.method_14();
				float float_4 = @class.method_14();
				@class.method_14();
				@class.method_8();
				NavCells[i] = new NavCell(float_, float_2, float_3, float_4);
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
		DataReader @class = new DataReader(Stream_1);
		int num = 0;
		for (int i = 0; i < NavSquareSavedCount; i++)
		{
			int num2 = @class.method_11();
			byte num3 = @class.method_6();
			float num4 = float.NaN;
			if (num3 == 1)
			{
				num4 = @class.method_14();
			}
			for (int j = 0; j < num2; j++)
			{
				int num5 = num % NavSquareW;
				int num6 = num / NavSquareW;
				NavSquares[num5, num6] = num4;
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
	[CompilerGenerated]
	private readonly SnoItemType SnoItemType_0;

	[CompilerGenerated]
	private readonly SnoItemMod[] isnoItemMod_0;

	public SnoItemType SnoItemType
	{
		[CompilerGenerated]
		get
		{
			return SnoItemType_0;
		}
	}

	public SnoItemMod[] Mods
	{
		[CompilerGenerated]
		get
		{
			return isnoItemMod_0;
		}
	}

	internal SnoSocketedEffect(SnoItemType SnoItemType_1, SnoItemMod[] isnoItemMod_1)
	{
		SnoItemType_0 = SnoItemType_1;
		isnoItemMod_0 = isnoItemMod_1;
	}
}

public sealed class SnoWorld
{
	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly List<SnoArea> list_0 = new List<SnoArea>();

	public List<SnoWorldSceneInfo> SceneInfos = new List<SnoWorldSceneInfo>();

	public uint Sno
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	public List<SnoArea> SnoAreas
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	internal SnoWorld(uint uint_1)
	{
		uint_0 = uint_1;
	}
}

public class SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly float float_1;

	[CompilerGenerated]
	private readonly float float_2;

	[CompilerGenerated]
	private readonly float float_3;

	[CompilerGenerated]
	private readonly float float_4;

	[CompilerGenerated]
	private readonly float float_5;

	[CompilerGenerated]
	private readonly SnoArea isnoArea_0;

	[CompilerGenerated]
	private readonly string string_0;

	public float PosX
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	public float PosY
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
	}

	public float MaxX
	{
		[CompilerGenerated]
		get
		{
			return float_2;
		}
	}

	public float MaxY
	{
		[CompilerGenerated]
		get
		{
			return float_3;
		}
	}

	public float W
	{
		[CompilerGenerated]
		get
		{
			return float_4;
		}
	}

	public float H
	{
		[CompilerGenerated]
		get
		{
			return float_5;
		}
	}

	public SnoArea SnoArea
	{
		[CompilerGenerated]
		get
		{
			return isnoArea_0;
		}
	}

	public string CalculatedPosId
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	internal SnoWorldSceneInfo(float float_6, float float_7, float float_8, float float_9, SnoArea isnoArea_1)
	{
		float_0 = float_6;
		float_1 = float_7;
		float_2 = float_8;
		float_3 = float_9;
		float_4 = MaxX - PosX;
		float_5 = MaxY - PosY;
		isnoArea_0 = isnoArea_1;
		if (isnoArea_1.SnoWorld.Sno == 332336)
		{
			float_0 = PosX - 2580f;
			float_1 = PosY - 2280f;
		}
		string_0 = PosX.ToString(CultureInfo.InvariantCulture) + PosY.ToString(CultureInfo.InvariantCulture);
	}
}

public sealed class SnoWorldSceneInfoRandom : SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly List<SnoScene> list_0 = new List<SnoScene>();

	public List<SnoScene> SnoScenes
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	internal SnoWorldSceneInfoRandom(float float_6, float float_7, float float_8, float float_9, SnoArea isnoArea_1)
		: base(float_6, float_7, float_8, float_9, isnoArea_1)
	{
	}
}

public sealed class SnoWorldSceneInfoStatic : SnoWorldSceneInfo
{
	[CompilerGenerated]
	private readonly SnoScene isnoScene_0;

	public SnoScene SnoScene
	{
		[CompilerGenerated]
		get
		{
			return isnoScene_0;
		}
	}

	internal SnoWorldSceneInfoStatic(float float_6, float float_7, float float_8, float float_9, SnoArea isnoArea_1, SnoScene isnoScene_1)
		: base(float_6, float_7, float_8, float_9, isnoArea_1)
	{
		isnoScene_0 = isnoScene_1;
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

public struct TextureIndexEntry
{
	public uint Id;

	public long AtlasPosition;

	public int X;

	public int Y;

	public int W;

	public int H;
}
