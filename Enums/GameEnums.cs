using System;

public enum AcdAnimationState
{
	Invalid = -1,
	NotAnimating,
	Idle,
	Running,
	Transform,
	Spawn,
	Gizmo,
	TakingDamage,
	Casting,
	Attacking,
	Cutscene,
	Channeling,
	Dead,
	FloatConversation,
	CastingPortal
}

public enum ActionKey
{
	LeftSkill = 0,
	RightSkill = 1,
	Skill1 = 2,
	Skill2 = 3,
	Skill3 = 4,
	Skill4 = 5,
	Heal = 100,
	Move = 200,
	TownPortal = 300,
	Inventory = 400,
	Close = 500,
	Social = 600,
	WaypointMap = 700,
	Map = 800,
	SkillsWindow = 900,
	ParagonWindow = 1000,
	Unknown = int.MaxValue
}

public enum ActorKind
{
	None = 0,
	Banner = 1,
	Portal = 2,
	Stash = 3,
	Waypoint = 4,
	Chest = 5,
	ChestNormal = 6,
	Skill = 7,
	Shrine = 8,
	Avoid = 9,
	Follower = 10,
	BookOfCain = 12,
	Gold = 13,
	HealthGlobe = 14,
	Player = 15,
	Obstacle = 16,
	DeadBody = 17,
	WeaponRack = 18,
	ArmorRack = 19,
	CursedEvent = 20,
	PowerGlobe = 21,
	NoWalk = 22,
	RiftOrb = 23,
	QuestActivate = 24,
	KanaiCube = 25
}

public enum ActorRarity
{
	Normal = 0,
	Champion = 1,
	Rare = 2,
	RareMinion = 3,
	Unique = 4,
	Hireling = 5,
	Boss = 7
}

public enum ActorType
{
	Invalid,
	Monster,
	Gizmo,
	ClientEffect,
	ServerProp,
	Enviroment,
	Critter,
	Player,
	Item,
	AxeSymbol,
	Projectile,
	CustomBrain
}

public enum Alignment
{
	Left,
	Right,
	Center
}

public enum AreaType
{
	Normal,
	PvP,
	Disabled
}

public enum AttributeValueType
{
	_float,
	_int
}

public enum BountyAct
{
	None = -1,
	A1 = 0,
	A2 = 100,
	A3 = 200,
	A4 = 300,
	A5 = 400,
	OpenWorld = 3000,
	Test = 1000
}

public enum BountyType
{
	None = -1,
	KillUnique,
	KillBoss,
	CompleteEvent,
	ClearDungeon,
	SpecialEvent
}

public enum ClipState
{
	BeforeClip,
	Inventory,
	AfterClip
}

internal enum Enum0
{
	TRICKLE_FLAG_DEAD_BIT,
	TRICKLE_FLAG_OBSERVER_BIT,
	TRICKLE_FLAG_NOT_ON_MAP,
	TRICKLE_FLAG_HIDDEN,
	TRICKLE_FLAG_BECOMES_ARROW,
	TRICKLE_FLAG_RESPECTS_FOW,
	TRICKLE_FLAG_PVP_PLAYER_REVEALED_ON_MAP,
	TRICKLE_FLAG_GHOSTED_BIT,
	TRICKLE_FLAG_HUNTER,
	TRICKLE_FLAG_LOOT_RUN_BOSS,
	TRICKLE_FLAG_COUNT
}

internal enum Enum1
{
	TRICKLE_ACTION_NONE,
	TRICKLE_ACTION_BUSY,
	TRICKLE_ACTION_TOWN_PORTAL,
	TRICKLE_ACTION_BOUNTY,
	TRICKLE_ACTION_DUNGEON_FINDER,
	TRICKLE_ACTION_IN_TOWN,
	TRICKLE_ACTION_IN_BOSS_FIGHT,
	TRICKLE_ACTION_IN_COMBAT
}

internal enum Enum10
{
	none,
	time_total,
	time_town,
	time_play,
	time_total_noseconds,
	time_town_noseconds,
	time_play_noseconds,
	exp,
	exp_per_hour,
	kill_all,
	kill_all_per_hour,
	kill_all_per_legendary,
	kill_elite,
	kill_elite_per_hour,
	kill_elite_per_legendary,
	items_all,
	items_all_per_hour,
	items_white,
	items_white_per_hour,
	items_magic,
	items_magic_per_hour,
	items_rare,
	items_rare_per_hour,
	items_legendary,
	items_legendary_per_hour,
	items_ancient,
	items_ancient_per_hour,
	items_blood_shard,
	items_blood_shard_per_hour,
	gold_pickup,
	gold_pickup_per_hour,
	gold_drop,
	gold_drop_per_hour,
	death,
	death_per_hour,
	damage_dealt_all,
	damage_dealt_all_per_sec,
	damage_dealt_crit,
	damage_dealt_crit_per_sec,
	damage_taken,
	damage_taken_per_sec,
	healing,
	healing_per_sec
}

internal enum Enum12
{
	STATUS_BUFFER_OVERFLOW = -2147483643,
	STATUS_INFO_LENGTH_MISMATCH = -1073741820,
	STATUS_SUCCESS = 0
}

internal enum Enum13
{
	SystemBasicInformation = 0,
	SystemPerformanceInformation = 2,
	SystemTimeOfDayInformation = 3,
	SystemProcessInformation = 5,
	SystemProcessorPerformanceInformation = 8,
	SystemHandleInformation = 16,
	SystemInterruptInformation = 23,
	SystemExceptionInformation = 33,
	SystemRegistryQuotaInformation = 37,
	SystemLookasideInformation = 45
}

internal enum Enum14
{
	ObjectBasicInformation,
	ObjectNameInformation,
	ObjectTypeInformation,
	ObjectAllTypesInformation,
	ObjectHandleInformation
}

[Flags]
internal enum Enum15
{
	PROCESS_DUP_HANDLE = 0x40
}

[Flags]
internal enum Enum16
{
	DUPLICATE_CLOSE_SOURCE = 1,
	DUPLICATE_SAME_ACCESS = 2
}

internal enum Enum19
{
	Keep,
	DefinitelyBad
}

internal enum Enum2
{
	TRICKLE_INFO_INVALID,
	TRICKLE_INFO_LOCAL_PLAYER,
	TRICKLE_INFO_MY_PET,
	TRICKLE_INFO_FRIENDLY_PLAYER,
	TRICKLE_INFO_FRIENDLY_PLAYER_PET,
	TRICKLE_INFO_FOLLOWER_PET,
	TRICKLE_INFO_HOSTILE_PLAYER,
	TRICKLE_INFO_HOSTILE_PLAYER_PET,
	TRICKLE_INFO_NPC,
	TRICKLE_INFO_FRIENDLY_MONSTER,
	TRICKLE_INFO_HOSTILE_MONSTER,
	TRICKLE_INFO_GIZMO,
	TRICKLE_INFO_PVP_FRIENDLY,
	TRICKLE_INFO_PVP_HOSTILE,
	TRICKLE_INFO_PVP_NEUTRAL,
	TRICKLE_INFO_NUM_TYPES
}

internal enum Enum20 : uint
{
	None,
	Total,
	Trial
}

internal enum Enum3
{
	DealtNonCrit = 0,
	DealtUnknown = 1,
	DealtCrit = 2,
	TakenNonCrit = 3,
	TakenUnknown = 4,
	TakenCrit = 5,
	Dodge7 = 7,
	Block8 = 8,
	Heal10 = 10,
	Absorbed11 = 11,
	CcStun13 = 13,
	CcFreeze15 = 15,
	CcTaunt18 = 18,
	CcSlow19 = 19,
	BrokeRoot24 = 24,
	CcResist27 = 27,
	Unknown28 = 28
}

internal enum Enum9
{
	none,
	current_area_currentrun,
	current_run,
	current_session,
	current_session_abs,
	account_total,
	account_yesterday,
	account_today,
	hero_total,
	hero_yesterday,
	hero_today,
	current_area_total,
	account_total_curdiff,
	account_yesterday_curdiff,
	account_today_curdiff,
	hero_total_curdiff,
	hero_yesterday_curdiff,
	hero_today_curdiff,
	current_area_total_curdiff
}

public enum GameDifficulty
{
	unknown = -1,
	n,
	h,
	e,
	m,
	t1,
	t2,
	t3,
	t4,
	t5,
	t6,
	t7,
	t8,
	t9,
	t10,
	t11,
	t12,
	t13,
	t14,
	t15,
	t16
}

public enum GizmoType
{
	Invalid = -1,
	Door = 0,
	Chest = 1,
	Portal = 2,
	Waypoint = 4,
	Item = 5,
	Checkpoint = 7,
	Sign = 8,
	HealingWell = 9,
	PowerUp = 10,
	TownPortal = 11,
	HearthPortal = 12,
	Headstone = 18,
	PortalDestination = 20,
	BreakableChest = 23,
	SharedStash = 25,
	Spawner = 28,
	PageOfFatePortal = 33,
	Trigger = 44,
	SecretPortal = 47,
	DestroyableObject = 48,
	BreakableDoor = 56,
	Switch = 57,
	PressurePlate = 58,
	Gate = 59,
	DestroySelfWhenNear = 60,
	ActTransitionObject = 62,
	ReformingDestroyableObject = 63,
	Banner = 64,
	LoreChest = 65,
	BossPortal = 66,
	PlacedLoot = 67,
	SavePoint = 68,
	ReturnPointPortal = 69,
	DungeonPortal = 70,
	IdentifyAll = 71,
	ReturnPortal = 75,
	RecreateGameWithParty = 76,
	Mailbox = 77,
	LootRunSwitch = 78,
	PoolOfReflection = 79
}

public enum HeroClass : uint
{
	DemonHunter = 0u,
	Barbarian = 1u,
	Wizard = 2u,
	WitchDoctor = 3u,
	Monk = 4u,
	Crusader = 5u,
	Necromancer = 6u,
	None = uint.MaxValue
}

public enum ItemCraftQuality : byte
{
	Inferior = 0,
	Normal = 1,
	Superior = 2,
	Magic4 = 3,
	Magic5 = 4,
	Magic6 = 5,
	Rare4 = 6,
	Rare5 = 7,
	Rare6 = 8,
	Legendary = 9,
	Special = 10,
	Set = 11,
	None = byte.MaxValue
}

public enum ItemKind
{
	loot,
	potion,
	healthglobe,
	powerglobe,
	rift_orb,
	uberstuff,
	gem,
	craft,
	goldcoin,
	book
}

public enum ItemLocation
{
	Floor = -1,
	Inventory = 0,
	Head = 1,
	Torso = 2,
	RightHand = 3,
	LeftHand = 4,
	Hands = 5,
	Waist = 6,
	Feet = 7,
	Shoulders = 8,
	Legs = 9,
	Bracers = 10,
	LeftRing = 11,
	RightRing = 12,
	Neck = 13,
	MerchantBuyback = 14,
	Stash = 15,
	Gold = 16,
	MerchantAvaibleItemsForPurchase = 17,
	Merchant = 18,
	PtrVendor = 19,
	InSocket = 20,
	PetRightHand = 21,
	PetLeftHand = 22,
	PetSpecial = 23,
	PetNeck = 24,
	PetRightRing = 25,
	PetLeftRing = 26,
	PetHead = 27,
	PetTorso = 28,
	PetHands = 29,
	PetWaist = 30,
	PetFeet = 31,
	PetShoulders = 32,
	PetLegs = 33,
	PetBracers = 34,
	VendorToken = 1000
}

public enum ItemQuality : byte
{
	Inferior,
	Normal,
	Superior,
	Magic4,
	Magic5,
	Magic6,
	Rare4,
	Rare5,
	Rare6,
	Legendary
}

public enum MapMode
{
	Minimap,
	Map,
	PermaMap,
	WaypointMap,
	ActMap
}

public enum MonsterAffix : uint
{
	Fast = 3775118u,
	Molten = 106438735u,
	Mortar = 106654229u,
	Horde = 127452338u,
	Illusionist = 394214687u,
	Vampiric = 395423867u,
	Vortex = 458872904u,
	Waller = 481181063u,
	Wormhole = 1156956365u,
	Avenger = 1165197192u,
	HealthLink = 1799201764u,
	FrozenPulse = 1886876669u,
	Orbiter = 1905614711u,
	Poison = 1929212066u,
	Knockback = 2206426855u,
	Electrified = 2542537664u,
	Arcane = 2625377780u,
	ExtraHealth = 2782485594u,
	MissileDampening = 2882216553u,
	Reflect = 2920375063u,
	Plagued = 2961013602u,
	Nightmarish = 3049048382u,
	Shielding = 3569101591u,
	Teleporter = 3787260902u,
	Juggernaut = 3830498332u,
	FireChains = 3855260060u,
	Frozen = 4131130388u,
	Desecrator = 4172983340u,
	Thunderstorm = 4244410831u,
	Jailer = 4267280439u,
	Enervating = 547833824u,
	Necrotic = 3527404023u
}

public enum MonsterPriority
{
	none,
	low,
	normal,
	high,
	goblin,
	keywarden,
	boss
}

internal enum OverlayDisplayState
{
	Hidden,
	Normal
}

public enum PowerResourceCostType
{
	primary,
	secondary,
	hitpoint
}

public enum QuestEventType
{
	None = -1,
	TimedDungeon,
	WaveFight,
	Horde,
	Zapper,
	GoblinHunt
}

public enum QuestState
{
	none,
	started,
	completed
}

public enum QuestType
{
	MainQuest = 0,
	Event = 2,
	Challenge = 4,
	Bounty = 5,
	Unknown1 = 7,
	Unknown2 = 8,
	Unknown3 = 9
}

public enum ShrineType
{
	BlessedShrine,
	EnlightenedShrine,
	FortuneShrine,
	FrenziedShrine,
	EmpoweredShrine,
	FleetingShrine,
	PowerPylon,
	ConduitPylon,
	ChannelingPylon,
	ShieldPylon,
	SpeedPylon,
	PoolOfReflection,
	BanditShrine,
	HealingWell
}

public enum SkillEffectType
{
	meteor,
	wicked_wind,
	blizzard,
	acid_cloud,
	gargantuan,
	zombiedog,
	elite_wall,
	spike_trap,
	hydra,
	fetish,
	sentry,
	cota
}

public enum SpecialArea
{
	None,
	Rift,
	GreaterRift,
	UberPortals,
	UberFight,
	PvP,
	ChallengeRiftHub,
	ChallengeRift
}

public enum ValueFormat
{
	NormalNumber,
	NormalNumberNoDecimal,
	LongNumber,
	ShortNumber,
	AlwaysK,
	AlwaysKNoDecimal,
	AlwaysM,
	AlwaysMNoDecimal,
	LongTime,
	LongTimeNoSeconds
}

public enum Vk : int
{
	None = 0x00,
	// Mouse
	LBUTTON = 0x01,
	RBUTTON = 0x02,
	CANCEL = 0x03,
	MBUTTON = 0x04,
	XBUTTON1 = 0x05,
	XBUTTON2 = 0x06,

	// Control
	BACK = 0x08,
	TAB = 0x09,
	CLEAR = 0x0C,
	RETURN = 0x0D,

	SHIFT = 0x10,
	CONTROL = 0x11,
	MENU = 0x12, // ALT

	PAUSE = 0x13,
	CAPITAL = 0x14, // CAPS LOCK

	ESCAPE = 0x1B,
	SPACE = 0x20,

	PRIOR = 0x21, // PAGE UP
	NEXT = 0x22, // PAGE DOWN
	END = 0x23,
	HOME = 0x24,

	LEFT = 0x25,
	UP = 0x26,
	RIGHT = 0x27,
	DOWN = 0x28,

	SELECT = 0x29,
	PRINT = 0x2A,
	EXECUTE = 0x2B,
	SNAPSHOT = 0x2C, // PRINT SCREEN

	INSERT = 0x2D,
	DELETE = 0x2E,
	HELP = 0x2F,

	// Numbers
	D0 = 0x30,
	D1 = 0x31,
	D2 = 0x32,
	D3 = 0x33,
	D4 = 0x34,
	D5 = 0x35,
	D6 = 0x36,
	D7 = 0x37,
	D8 = 0x38,
	D9 = 0x39,

	// Letters
	A = 0x41,
	B = 0x42,
	C = 0x43,
	D = 0x44,
	E = 0x45,
	F = 0x46,
	G = 0x47,
	H = 0x48,
	I = 0x49,
	J = 0x4A,
	K = 0x4B,
	L = 0x4C,
	M = 0x4D,
	N = 0x4E,
	O = 0x4F,
	P = 0x50,
	Q = 0x51,
	R = 0x52,
	S = 0x53,
	T = 0x54,
	U = 0x55,
	V = 0x56,
	W = 0x57,
	X = 0x58,
	Y = 0x59,
	Z = 0x5A,

	// Windows
	LWIN = 0x5B,
	RWIN = 0x5C,
	APPS = 0x5D,

	// Numpad
	NUMPAD0 = 0x60,
	NUMPAD1 = 0x61,
	NUMPAD2 = 0x62,
	NUMPAD3 = 0x63,
	NUMPAD4 = 0x64,
	NUMPAD5 = 0x65,
	NUMPAD6 = 0x66,
	NUMPAD7 = 0x67,
	NUMPAD8 = 0x68,
	NUMPAD9 = 0x69,

	MULTIPLY = 0x6A,
	ADD = 0x6B,
	SEPARATOR = 0x6C,
	SUBTRACT = 0x6D,
	DECIMAL = 0x6E,
	DIVIDE = 0x6F,

	// Function keys
	F1 = 0x70,
	F2 = 0x71,
	F3 = 0x72,
	F4 = 0x73,
	F5 = 0x74,
	F6 = 0x75,
	F7 = 0x76,
	F8 = 0x77,
	F9 = 0x78,
	F10 = 0x79,
	F11 = 0x7A,
	F12 = 0x7B,
	F13 = 0x7C,
	F14 = 0x7D,
	F15 = 0x7E,
	F16 = 0x7F,
	F17 = 0x80,
	F18 = 0x81,
	F19 = 0x82,
	F20 = 0x83,
	F21 = 0x84,
	F22 = 0x85,
	F23 = 0x86,
	F24 = 0x87,

	// Locks
	NUMLOCK = 0x90,
	SCROLL = 0x91,

	// Left/right modifiers
	LSHIFT = 0xA0,
	RSHIFT = 0xA1,

	LCONTROL = 0xA2,
	RCONTROL = 0xA3,

	LMENU = 0xA4,
	RMENU = 0xA5,

	// Browser/media
	BROWSER_BACK = 0xA6,
	BROWSER_FORWARD = 0xA7,

	VOLUME_MUTE = 0xAD,
	VOLUME_DOWN = 0xAE,
	VOLUME_UP = 0xAF,

	MEDIA_NEXT_TRACK = 0xB0,
	MEDIA_PREV_TRACK = 0xB1,
	MEDIA_STOP = 0xB2,
	MEDIA_PLAY_PAUSE = 0xB3,

	// OEM
	OEM_1 = 0xBA,      // ;:
	OEM_PLUS = 0xBB,   // +
	OEM_COMMA = 0xBC,  // ,
	OEM_MINUS = 0xBD,  // -
	OEM_PERIOD = 0xBE, // .
	OEM_2 = 0xBF,      // /?
	OEM_3 = 0xC0,      // `~
	OEM_4 = 0xDB,      // [{
	OEM_5 = 0xDC,      // \|
	OEM_6 = 0xDD,      // ]}
	OEM_7 = 0xDE       // '"
}

public enum VolumeMode
{
	AutoMaster,
	AutoMasterAndEffects,
	Constant
}

public enum WindowMode
{
	FullScreen,
	Windowed,
	FullScreenWindowed
}

public enum WorldLayer
{
	Ground,
	Map
}

public enum ItemKeepDecision
{
	LooksGood,
	Irrelevant,
	DefinitelyBad
}
