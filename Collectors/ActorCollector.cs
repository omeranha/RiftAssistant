using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Plugins;
using SNO;
using structs;


namespace collectors;

internal class ActorCollector
{
	private readonly Dictionary<uint, Actor> class112_0 = new Dictionary<uint, Actor>(1000);

	[CompilerGenerated]
	private Monster imonster_0;

	[CompilerGenerated]
	private Monster imonster_1;

	[CompilerGenerated]
	private Actor iactor_0;

	[CompilerGenerated]
	private readonly bool[] bool_0 = new bool[5];

	public Stopwatch stopwatch_0 = new();

	[CompilerGenerated]
	private int act;

	private Stopwatch stopwatch_1 = new();

	public FollowerClass followerClass_0;

	public List<Monster> Monsters = new List<Monster>();

	public List<Monster> AliveMonsters = new List<Monster>();

	public List<MonsterPack> MonsterPacks = new List<MonsterPack>();

	internal readonly PerSecCounter MonsterHitpointDecrease = new();

	public List<Actor> list_3 = new List<Actor>(1000);

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private bool isEliteNearby;

	[CompilerGenerated]
	private bool isEliteOnScreen;

	[CompilerGenerated]
	private MonsterPriority monsterPriority_0;

	[CompilerGenerated]
	private bool isGoblinOnScreen;

	[CompilerGenerated]
	private readonly Dictionary<SkillEffectType, List<SkillEffect>> class112_1 = new Dictionary<SkillEffectType, List<SkillEffect>>();

	[CompilerGenerated]
	private readonly Dictionary<uint, Portal> class112_2 = new Dictionary<uint, Portal>();

	[CompilerGenerated]
	private readonly List<Shrine> shrines = new List<Shrine>();

	[CompilerGenerated]
	private readonly List<HeadStone> list_5 = new List<HeadStone>();

	[CompilerGenerated]
	private readonly List<IClickableActor> doors = new List<IClickableActor>();

	[CompilerGenerated]
	private readonly TownBanner[] itownBanner_0 = new TownBanner[4];

	[CompilerGenerated]
	private Actor iactor_1;

	[CompilerGenerated]
	private Actor iactor_2;

	[CompilerGenerated]
	private Actor iactor_3;

	[CompilerGenerated]
	private WorldCoordinate iworldCoordinate_0;

	[CompilerGenerated]
	private int act2;

	[CompilerGenerated]
	private r_Actor[] bufferActors;

	public Monster IMonster_0
	{
		[CompilerGenerated]
		get {
			return imonster_0;
		}
		[CompilerGenerated]
		private set {
			imonster_0 = value;
		}
	}

	public Monster IMonster_1
	{
		[CompilerGenerated]
		get {
			return imonster_1;
		}
		[CompilerGenerated]
		private set {
			imonster_1 = value;
		}
	}

	public Actor IActor_0
	{
		[CompilerGenerated]
		get {
			return iactor_0;
		}
		[CompilerGenerated]
		private set {
			iactor_0 = value;
		}
	}

	public EventHandler EventHandler_0 { get; set; }

	public EventHandler<Monster> onMonsterKilled { get; set; }

	public EventHandler<Portal> OnPortalFound { get; set; }

	public bool[] Boolean_0
	{
		[CompilerGenerated]
		get {
			return bool_0;
		}
	}

	public int Act
	{
		[CompilerGenerated]
		get {
			return act;
		}
		[CompilerGenerated]
		internal set {
			act = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get {
			return int_2;
		}
		[CompilerGenerated]
		private set {
			int_2 = value;
		}
	}

	public bool IsEliteNearby
	{
		[CompilerGenerated]
		get {
			return isEliteNearby;
		}
		[CompilerGenerated]
		private set {
			isEliteNearby = value;
		}
	}

	public bool IsEliteOnScreen
	{
		[CompilerGenerated]
		get {
			return isEliteOnScreen;
		}
		[CompilerGenerated]
		private set {
			isEliteOnScreen = value;
		}
	}

	public MonsterPriority MonsterPriority_0
	{
		[CompilerGenerated]
		get {
			return monsterPriority_0;
		}
		[CompilerGenerated]
		private set {
			monsterPriority_0 = value;
		}
	}

	public bool IsGoblinOnScreen
	{
		[CompilerGenerated]
		get {
			return isGoblinOnScreen;
		}
		[CompilerGenerated]
		private set {
			isGoblinOnScreen = value;
		}
	}

	public Dictionary<SkillEffectType, List<SkillEffect>> Class112_0
	{
		[CompilerGenerated]
		get {
			return class112_1;
		}
	}

	public Dictionary<uint, Portal> Class112_1
	{
		[CompilerGenerated]
		get {
			return class112_2;
		}
	}

	public List<Shrine> Shrines
	{
		[CompilerGenerated]
		get {
			return shrines;
		}
	}

	public List<HeadStone> List_1
	{
		[CompilerGenerated]
		get {
			return list_5;
		}
	}

	public List<IClickableActor> Doors
	{
		[CompilerGenerated]
		get {
			return doors;
		}
	}

	public TownBanner[] ITownBanner_0
	{
		[CompilerGenerated]
		get {
			return itownBanner_0;
		}
	}

	public Actor IActor_1
	{
		[CompilerGenerated]
		get {
			return iactor_1;
		}
		[CompilerGenerated]
		private set {
			iactor_1 = value;
		}
	}

	public Actor IActor_2
	{
		[CompilerGenerated]
		get {
			return iactor_2;
		}
		[CompilerGenerated]
		private set {
			iactor_2 = value;
		}
	}

	public Actor IActor_3
	{
		[CompilerGenerated]
		get {
			return iactor_3;
		}
		[CompilerGenerated]
		private set {
			iactor_3 = value;
		}
	}

	public WorldCoordinate IWorldCoordinate_0
	{
		[CompilerGenerated]
		get {
			return iworldCoordinate_0;
		}
		[CompilerGenerated]
		internal set {
			iworldCoordinate_0 = value;
		}
	}

	public int Act2
	{
		[CompilerGenerated]
		get {
			return act2;
		}
		[CompilerGenerated]
		internal set {
			act2 = value;
		}
	}

	internal r_Actor[] BufferActors
	{
		[CompilerGenerated]
		get {
			return bufferActors;
		}
		[CompilerGenerated]
		private set {
			bufferActors = value;
		}
	}

	internal void method_0()
	{
		class112_0.Clear();
	}

	internal void method_1()
	{
		Monsters.Clear();
		AliveMonsters.Clear();
	}

	internal void method_2(bool bool_4)
	{
		list_3.Clear();
		Monsters.Clear();
		AliveMonsters.Clear();
		foreach (List<SkillEffect> item in Class112_0.Values) {
			item.Clear();
		}
		if (bool_4) {
			Class112_1.Clear();
		}
		Shrines.Clear();
		Doors.Clear();
		List_1.Clear();
		for (int i = 0; i < ITownBanner_0.Length; i++) {
			ITownBanner_0[i] = null;
		}
		followerClass_0 = null;
		IActor_1 = null;
		IActor_3 = null;
		IActor_2 = null;
	}

	internal unsafe bool Collect()
	{
		bool flag = stopwatch_1.Elapsed.TotalMilliseconds >= 100.0;
		if (flag) {
			stopwatch_1.Restart();
		}
		method_2(bool_4: false);
		Int32_1 = 0;
		IsEliteNearby = false;
		IsEliteOnScreen = false;
		MonsterPriority_0 = MonsterPriority.none;
		IsGoblinOnScreen = false;
		int num = CoreCollector.D3Memory.ActorContainer.MaxIndex + 1;
		if (BufferActors == null || BufferActors.Length <= CoreCollector.D3Memory.ActorContainer.MaxIndex) {
			BufferActors = new r_Actor[num];
		}
		int num2 = 0;
		for (int i = 0; i < CoreCollector.D3Memory.ActorContainer.BlockCount; i++) {
			long num3 = CoreCollector.D3Memory.ActorContainer.BlockPointers[i];
			int num4 = Math.Min(CoreCollector.D3Memory.ActorContainer.BlocksItemCapacity, num);
			BufferActors = GameWindowManager.ReadArray<r_Actor>(num3, num4);
			num -= num4;
			num2 += num4;
		}
		foreach (Portal item in Class112_1.Values) {
			item.ActorAvailable = false;
		}
		IMonster_0 = null;
		IMonster_1 = null;
		IActor_0 = null;
		double num5 = 0.0;
		int num6 = 0;
		for (int j = 0; j <= CoreCollector.D3Memory.ActorContainer.MaxIndex; j++) {
			fixed (r_Actor* ptr = &BufferActors[j]) {
				uint actorId = ptr->ActorId;
				if (actorId == uint.MaxValue) {
					continue;
				}
				uint acdid = ptr->AcdIdEncrypted;
				if (acdid == uint.MaxValue) {
					Actor actor = class112_0.GetValueOrDefault(actorId);
					if (actor == null || !(actor is Monster { CurHealth: > 0.0 } monster)) {
						continue;
					}
					monster.CurHealth = 0.0;
					foreach (StatTracker item2 in CoreCollector.Trackers) {
						item2.MonsterKill++;
					}
					if (monster.IsElite) {
						foreach (StatTracker item3 in CoreCollector.Trackers) {
							item3.EliteKill++;
						}
					}
					if (monster.Pack != null) {
						if (monster.Pack is MonsterPack previousPack) {
							previousPack.MonstersUnknown2.Remove(monster.MaxHealth);
							previousPack.MonstersAlive2.Remove(monster.MaxHealth);
							previousPack.MonstersKilled2[monster.MaxHealth] = monster;
						}
					}
					if (CoreCollector.LocalPlayer.SnoArea != null) {
						SnoMonster snoMonster = monster.SnoMonster;
						if (snoMonster != null && snoMonster.Priority == MonsterPriority.keywarden) {
							stopwatch_0.Restart();
							Act = CoreCollector.LocalPlayer.SnoArea.Act;
							Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
						}
					}
					try {
						onMonsterKilled?.Invoke(this, monster);
					} catch (Exception exception_) {
						Logger.LogException(exception_.Message);
					}
					continue;
				}
				if (!CoreCollector.ACDCollector.SetIndexFromAcdId(acdid)) {
					num6++;
					continue;
				}
				r_ACD struct7_ = CoreCollector.ACDCollector.Buffer_ACDs[CoreCollector.ACDCollector.AcdIndexCur];
				uint gparam_ = actorId;
				uint actorSnoEncrypted = struct7_.ActorSnoEncrypted;
				if (actorSnoEncrypted == uint.MaxValue) {
					continue;
				}
				ActorSnoEnum actorSnoEnum = (ActorSnoEnum)actorSnoEncrypted;
				uint annId = struct7_.AnnId;
				if (annId == uint.MaxValue) {
					continue;
				}
				Actor actor2 = class112_0.GetValueOrDefault(gparam_);
				SnoActor snoActor;
				if (actor2 == null) {
					snoActor = SnoData.Actors.GetActor(actorSnoEnum);
					if (snoActor != null) {
						goto IL_04b0;
					}
					continue;
				}
				if (actor2.AcdId != acdid) {
					actor2.method_26(acdid);
				}
				snoActor = actor2.SnoActor;
				if (snoActor.Sno == actorSnoEnum) {
					goto IL_04b0;
				}
				actor2 = null;
				class112_0.Remove(gparam_);
				snoActor = SnoData.Actors.GetActor(actorSnoEnum);
				if (snoActor != null) {
					goto IL_04b0;
				}
				goto end_IL_019d;
			IL_04b0:
				if (!CoreCollector.ACDCollector.method_5()) {
					continue;
				}
				if (snoActor.Kind == ActorKind.Follower) {
					if (actorSnoEnum == SnoData.Classes.FollowerEnchantress.ActorSno) {
						followerClass_0 = SnoData.Classes.FollowerEnchantress;
					}
					if (actorSnoEnum == SnoData.Classes.FollowerScoundrel.ActorSno) {
						followerClass_0 = SnoData.Classes.FollowerScoundrel;
					}
					if (actorSnoEnum == SnoData.Classes.FollowerTemplar.ActorSno) {
						followerClass_0 = SnoData.Classes.FollowerTemplar;
					}
				}
				uint sSceneID_Encrypted;
				uint sWorldID_Encrypted;
				if (snoActor.Kind == ActorKind.Player) {
					if (!(Array.Find(CoreCollector.PlayerCollector.PlayerSlots, (Player iplayer_0) => iplayer_0.AcdId == acdid) is Player player)) {
						continue;
					}
					player.list_0.Clear();
					CoreCollector.ACDCollector.method_12(player.list_0);
					if (player.AcdId == uint.MaxValue) {
						player.method_60();
						break;
					}
					player.AnnId = struct7_.AnnId;
					player.CoordinateKnown = true;
					CoreCollector.ACDCollector.method_3(out var animSnoEnum_, out var acdAnimationState_);
					player.Animation = animSnoEnum_;
					player.AnimationState = acdAnimationState_;
					player.SnoActor = snoActor;
					player.IsSelected = ptr->IsSelected != uint.MaxValue;
					if (player.IsSelected) {
						IActor_0 = player;
					}
					sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
					sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
					if (player.IsMe && player.FloorCoordinate.IsValid && player.WorldId == sWorldID_Encrypted && !player.IsInTown && acdAnimationState_ != AcdAnimationState.Invalid) {
						float num7 = player.FloorCoordinate.XYZDistanceTo(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
						if (num7 > 0f && num7 < 60f) {
							foreach (StatTracker item4 in CoreCollector.Trackers) {
								item4.WalkYards += num7;
							}
						}
					}
					player.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
					player.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
					smethod_1(player, sWorldID_Encrypted, sSceneID_Encrypted);
					player.RadiusScaled = struct7_.CollisionRadius;
					player.RadiusBottom = ptr->BottomRadius;
					player.method_25();
					method_7(player);
					list_3.Add(player);
					class112_0.Remove(gparam_);
					continue;
				}
				bool flag2 = false;
				Monster monster2 = null;
				SnoMonster snoMonster2 = null;
				if (actor2 == null) {
					snoMonster2 = SnoData.Monsters.GetMonster(actorSnoEnum);
					if (snoMonster2 != null) {
						flag2 = snoMonster2.Priority != MonsterPriority.none;
					}
				} else if (flag2 = actor2 is Monster && !(actor2 is MonsterObstacle)) {
					monster2 = actor2 as Monster;
					snoMonster2 = monster2.SnoMonster;
				}
				bool flag3 = true;
				if (flag2 && snoActor.Sno != ActorSnoEnum._x1_adria_boss && snoActor.Sno != ActorSnoEnum._x1_templarnpc_camp_bounty) {
					if (CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__Is_NPC, 1048575u, 0) == 1) {
						flag3 = false;
					}
					if (CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__Pet_Type, 1048575u) > 0) {
						flag3 = false;
					}
					int num8 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__TeamID, 1048575u);
					if (num8 == 2 || num8 == 1) {
						flag3 = false;
					}
				}
				if (!flag2) {
					bool num9 = actor2 == null || !(actor2?.SnoActor.IsStatic ?? false);
					uint num10 = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__summoned_by_acdid, 1048575u, 0u);
					if (actor2 == null) {
						actor2 = method_4(gizmoType: (GizmoType)struct7_.GizmoType, acdid: acdid, annId: annId, snoActor: snoActor, uint_2: num10) ?? new Actor(acdid, annId, snoActor);
						actor2.CreatedAtInGameTick = ptr->CreationTick;
						class112_0[gparam_] = actor2;
					}
					actor2.GizmoType = (GizmoType)struct7_.GizmoType;
					actor2.SummonerAcdDynamicId = num10;
					actor2.Untargetable = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Untargetable, 1048575u, 0.0) == 1.0;
					actor2.Boolean_0 = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__gizmo_disabled_by_script, 1048575u, 0.0) == 1.0;
					actor2.list_0.Clear();
					CoreCollector.ACDCollector.method_12(actor2.list_0);
					if (num9) {
						actor2.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
						actor2.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
						sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
						sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
						smethod_1(actor2, sWorldID_Encrypted, sSceneID_Encrypted);
						actor2.RadiusScaled = struct7_.CollisionRadius;
						actor2.RadiusBottom = ptr->BottomRadius;
					}
					actor2.method_25();
					actor2.Hitpoints = struct7_.HitPoints;
					actor2.IsSelected = ptr->IsSelected != uint.MaxValue;
					if (actor2.IsSelected) {
						IActor_0 = actor2;
					}
					if (method_5(actor2)) {
						list_3.Add(actor2);
					}
					continue;
				}
				bool flag4 = flag || monster2 == null;
				if (monster2 != null && (monster2.IsElite || monster2.SnoMonster.Priority >= MonsterPriority.keywarden)) {
					flag4 = true;
				}
				double value = (flag4 ? CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Hitpoints_Max_Total, 1048575u, 0.0) : monster2.MaxHealth);
				double num11 = (flag4 ? CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Hitpoints_Cur, 1048575u, 1.0) : monster2.CurHealth);
				if (num11 < 0.3) {
					if (monster2 != null && monster2.CurHealth > 0.0) {
						num5 += monster2.CurHealth;
						monster2.CurHealth = 0.0;
						foreach (StatTracker item5 in CoreCollector.Trackers) {
							item5.MonsterKill++;
						}
						if (monster2.IsElite) {
							foreach (StatTracker item6 in CoreCollector.Trackers) {
								item6.EliteKill++;
							}
						}
						if (CoreCollector.LocalPlayer.SnoArea != null) {
							SnoMonster snoMonster3 = monster2.SnoMonster;
							if (snoMonster3 != null && snoMonster3.Priority == MonsterPriority.keywarden) {
								stopwatch_0.Restart();
								Act = CoreCollector.LocalPlayer.SnoArea.Act;
								Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
							}
						}
						try {
							onMonsterKilled?.Invoke(this, monster2);
						} catch (Exception exception) {
							Logger.LogException(exception.Message);
						}
					}
					if (monster2 != null) {
						Monsters.Add(monster2);
					}
					continue;
				}
				ActorRarity actorRarity = (ActorRarity)struct7_.ActorRarity;
				if (monster2 == null) {
					monster2 = new Monster(acdid, annId, snoMonster2.SnoActor, snoMonster2) {
						SummonerAcdDynamicId = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__summoned_by_acdid, 1048575u, 0u)
					};
					class112_0[gparam_] = monster2;
				}
				monster2.Rarity = actorRarity;
				monster2.IsElite = snoMonster2.IsUnique || actorRarity != ActorRarity.Normal;
				monster2.IsSelected = ptr->IsSelected != uint.MaxValue;
				if (monster2.IsSelected) {
					IActor_0 = monster2;
				}
				smethod_0(struct7_, monster2);
				monster2.list_0.Clear();
				CoreCollector.ACDCollector.method_12(monster2.list_0);
				if (num11 < monster2.CurHealth) {
					num5 += monster2.CurHealth - num11;
				}
				monster2.MaxHealth = value;
				monster2.CurHealth = num11;
				monster2.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
				monster2.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
				sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
				sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
				smethod_1(monster2, sWorldID_Encrypted, sSceneID_Encrypted);
				monster2.RadiusScaled = struct7_.CollisionRadius;
				monster2.RadiusBottom = ptr->BottomRadius;
				monster2.CreatedAtInGameTick = ptr->CreationTick;
				monster2.method_25();
				if (snoMonster2.Priority == MonsterPriority.keywarden && CoreCollector.LocalPlayer.SnoArea != null) {
					IWorldCoordinate_0 = monster2.FloorCoordinate;
					Act2 = CoreCollector.LocalPlayer.SnoArea.Act;
				}
				if (acdid == CoreCollector.D3Memory.SelectedActor1_AcdId) {
					IMonster_0 = monster2;
				}
				if (acdid == CoreCollector.D3Memory.SelectedActor2_AcdId) {
					IMonster_1 = monster2;
				}
				if (flag4) {
					monster2.Illusion = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, 264185u, 0.0) != 0.0;
					monster2.Frozen = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Frozen, 1048575u, 0.0) == 1.0;
					monster2.Chilled = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Chilled, 1048575u, 0.0) == 1.0;
					monster2.Slow = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Slow, 1048575u, 0.0) == 1.0;
					monster2.Stunned = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Stunned, 1048575u, 0.0) == 1.0;
					monster2.Untargetable = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Untargetable, 1048575u, 0.0) == 1.0;
					monster2.Invulnerable = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Invulnerable, 1048575u, 0.0) == 1.0;
					monster2.Burrowed = monster2.Untargetable || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Burrowed, 1048575u, 0.0) == 1.0;
					monster2.Stealthed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Stealthed, 1048575u, 0.0) == 1.0;
					monster2.Blind = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Blind, 1048575u, 0.0) == 1.0;
					monster2.Bleeding = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Bleeding, 1048575u, 0.0) == 1.0;
					monster2.Hidden = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Hidden, 1048575u, 0.0) == 1.0;
					monster2.Invisible = monster2.Burrowed || monster2.Stealthed || monster2.Hidden;
					monster2.Palmed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0;
					monster2.Haunted = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0;
					monster2.MarkedForDeath = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0;
					monster2.Locust = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0;
					monster2.Piranhas = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_3_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_5_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_6_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_1_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0;
					monster2.Cursed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_DecrepifyPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_LeechPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_FrailtyPassiveEffect.Sno, 0.0) == 1.0;
					monster2.Strongarmed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.StrongarmBracers.Sno, 0.0) == 1.0;
					monster2.Phoenixed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Generic_ItemPassiveUniqueRing733x1.Sno, 0.0) == 1.0;
					monster2.DotDpsApplied = CoreCollector.ACDCollector.method_7(CoreCollector.Controller.Sno.Attributes.DOT_DPS, 1048575u);
					if (monster2.SnoMonster.Priority >= MonsterPriority.keywarden || monster2.IsElite) {
						CoreCollector.ACDCollector.method_3(out var animSnoEnum, out var acdAnimationState);
						monster2.Animation = animSnoEnum;
						monster2.AnimationState = acdAnimationState;
					}
				}
				if (monster2.IsElite) {
					IsEliteNearby = true;
				}
				if (monster2.IsOnScreen && Math.Abs(CoreCollector.LocalPlayer.FloorCoordinate.Z - monster2.FloorCoordinate.Z) <= 16f) {
					if (monster2.IsElite) {
						IsEliteOnScreen = true;
					}
					if (monster2.SnoMonster.Priority > MonsterPriority_0) {
						MonsterPriority_0 = monster2.SnoMonster.Priority;
					}
					if (monster2.SnoMonster.Priority == MonsterPriority.goblin) {
						IsGoblinOnScreen = true;
					}
				}
				list_3.Add(monster2);
				if (flag3) {
					Monsters.Add(monster2);
					AliveMonsters.Add(monster2);
					monster2.Attackable = monster2.IsOnScreen && !monster2.Untargetable && !monster2.Invisible;
					if (monster2.IsOnScreen && !monster2.Untargetable && !monster2.Invisible) {
						Int32_1++;
					}
				} else {
					monster2.Attackable = false;
				}
			end_IL_019d:;
			}
		}
		if (num6 > 30) {
			Logger.Info("[ERROR] force daf scan due to problem with actor's acd");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return false;
		}
		foreach (MonsterPack item7 in MonsterPacks) {
			foreach (Monster item8 in item7.MonstersAlive2.Values) {
				item7.MonstersUnknown2[item8.MaxHealth] = item8;
			}
			item7.MonstersAlive2.Clear();
		}
		Monsters.Sort((Monster imonster_0, Monster imonster_1) => -((int)imonster_0.Rarity).CompareTo((int)imonster_1.Rarity));
		foreach (Monster monster3 in Monsters) {
			if (monster3.Pack != null) {
				(monster3.Pack as MonsterPack)?.MonstersUnknown2.Remove(monster3.MaxHealth);
				if (monster3.CurHealth > 0.0) {
					(monster3.Pack as MonsterPack).MonstersAlive2[monster3.MaxHealth] = monster3;
				} else {
					(monster3.Pack as MonsterPack).MonstersKilled2[monster3.MaxHealth] = monster3;
				}
			} else {
				if (monster3.AffixSnoList == null) {
					continue;
				}
				if (monster3.Rarity != ActorRarity.Champion && monster3.Rarity != ActorRarity.Rare) {
					if (monster3.Rarity != ActorRarity.RareMinion) {
						continue;
					}
					if (monster3.SummonerAcdDynamicId != 0) {
						continue;
					}
					string string_0 = string.Concat(monster3.AffixSnoList.Select((SnoMonsterAffix snoMonsterAffix) => snoMonsterAffix.NameLocalized));
					MonsterPack monsterPack2 = MonsterPacks.Find((MonsterPack imonsterPack_0) => (imonsterPack_0 as MonsterPack)?.String_1 == string_0 && imonsterPack_0.MinionSnoMonster == monster3.SnoMonster) as MonsterPack;
					if (monsterPack2 == null) {
						foreach (MonsterPack item9 in MonsterPacks) {
							bool flag5 = true;
							foreach (SnoMonsterAffix item10 in monster3.AffixSnoList) {
								if (!item9.AffixSnoList2.Contains(item10)) {
									flag5 = false;
									break;
								}
							}
							if (flag5 && (monsterPack2 == null || item9.LastActive.ElapsedMilliseconds < monsterPack2.LastActive.ElapsedMilliseconds)) {
								monsterPack2 = item9;
								break;
							}
						}
						if (monsterPack2 == null) {
							continue;
						}
						monsterPack2.String_1 = string_0;
						monsterPack2.MinionSnoMonster = monster3.SnoMonster;
					}
					monsterPack2.MonstersUnknown2.Remove(monster3.MaxHealth);
					if (monster3.CurHealth > 0.0) {
						monsterPack2.MonstersAlive2[monster3.MaxHealth] = monster3;
					} else {
						monsterPack2.MonstersKilled2[monster3.MaxHealth] = monster3;
					}
					monsterPack2.LastActive.Restart();
					monster3.Pack = monsterPack2;
				} else {
					string string_1 = string.Concat(monster3.AffixSnoList.Select((SnoMonsterAffix snoMonsterAffix) => snoMonsterAffix.NameLocalized));
					MonsterPack monsterPack4 = MonsterPacks.Find((MonsterPack imonsterPack_0) => (imonsterPack_0 as MonsterPack)?.String_0 == string_1 && imonsterPack_0.LeadSnoMonster == monster3.SnoMonster) as MonsterPack;
					if (monsterPack4 == null) {
						monsterPack4 = new MonsterPack {
							AffixSnoList2 = monster3.AffixSnoList.ToList(),
							String_0 = string_1,
							IsFullChampionPack = (monster3.Rarity == ActorRarity.Champion),
							LeadSnoMonster = monster3.SnoMonster
						};
						MonsterPacks.Add(monsterPack4);
					}
					monsterPack4.MonstersUnknown2.Remove(monster3.MaxHealth);
					if (monster3.CurHealth > 0.0) {
						monsterPack4.MonstersAlive2[monster3.MaxHealth] = monster3;
					} else {
						monsterPack4.MonstersKilled2[monster3.MaxHealth] = monster3;
					}
					monsterPack4.LastActive.Restart();
					monster3.Pack = monsterPack4;
				}
			}
		}
		for (int num12 = MonsterPacks.Count - 1; num12 >= 0; num12--) {
			MonsterPack monsterPack5 = MonsterPacks[num12] as MonsterPack;
			if (monsterPack5.LastActive.ElapsedMilliseconds >= 60000 && monsterPack5.MonstersAlive2.Count <= 0) {
				MonsterPacks.RemoveAt(num12);
			}
		}
		MonsterHitpointDecrease.Add(num5);
		foreach (Actor item11 in list_3.Where((Actor iactor_0) => iactor_0.SnoActor.Kind == ActorKind.QuestActivate && iactor_0.SummonerId != 0)) {
			foreach (Monster item12 in AliveMonsters) {
				if (item12.SummonerAcdDynamicId == item11.SummonerId) {
					(item12 as Monster).IsQuestMonster = true;
				}
			}
		}
		try {
			EventHandler_0?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception2) {
			Logger.LogException(exception2.Message);
		}
		return true;
	}

	private static void smethod_0(r_ACD acd, Monster monster)
	{
		List<SnoMonsterAffix> affixSnoList = monster.AffixSnoList;
		affixSnoList?.Clear();
		SnoMonsterAffix monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_0);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_1);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_2);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_3);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_4);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_5);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_6);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(acd.monster_affix_id_7);
		if (monsterAffix != null) {
			(affixSnoList ?? (affixSnoList = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		if (affixSnoList != null) {
			affixSnoList.Sort((SnoMonsterAffix snoMonsterAffix, SnoMonsterAffix snoMonsterAffix2) => snoMonsterAffix.NameLocalized.CompareTo(snoMonsterAffix2.NameLocalized));
			monster.AffixSnoList = affixSnoList;
		}
	}

	private Actor method_4(uint acdid, uint annId, SnoActor snoActor, GizmoType gizmoType, uint uint_2)
	{
		if (snoActor.Sno != ActorSnoEnum._a3dun_keep_bridge_switch && snoActor.Sno != ActorSnoEnum._x1_westm_bridge && snoActor.Sno != ActorSnoEnum._a3dun_keep_bridge_switch_b) {
			if (snoActor.Sno == ActorSnoEnum._a3dun_keep_bridge) {
				return null;
			}
			if (snoActor.Sno == ActorSnoEnum._caout_target_dummy) {
				return null;
			}
			if (snoActor.Sno == ActorSnoEnum._trdun_crypt_skeleton_king_throne_parts) {
				return null;
			}
			SkillEffectRule skillEffectRule = SnoData.Actors.GetSkillEffectRule(snoActor.Sno);
			if (skillEffectRule != null) {
				if ((skillEffectRule.Type == SkillEffectType.fetish || skillEffectRule.Type == SkillEffectType.zombiedog || skillEffectRule.Type == SkillEffectType.gargantuan || skillEffectRule.Type == SkillEffectType.sentry || skillEffectRule.Type == SkillEffectType.hydra) && uint_2 != CoreCollector.LocalPlayer.SummonerId) {
					return null;
				}
				if (skillEffectRule.Type == SkillEffectType.blizzard) {
					int num = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_a, 30680u);
					int num2 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_b, 30680u);
					int num3 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_c, 30680u);
					int num4 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_d, 30680u);
					int num5 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_e, 30680u);
					if (num == -1 && num2 == -1 && num3 == -1 && num4 == -1 && num5 == -1) {
						return null;
					}
				}
				if (skillEffectRule.Type == SkillEffectType.meteor) {
					int num6 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_a, 69190u);
					int num7 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_b, 69190u);
					int num8 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_c, 69190u);
					int num9 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_d, 69190u);
					int num10 = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__rune_e, 69190u);
					if (num6 == -1 && num7 == -1 && num8 == -1 && num9 == -1 && num10 == -1) {
						return null;
					}
				}
				return new SkillEffect(acdid, annId, snoActor, skillEffectRule);
			}
			ActorShrineTypeInfo actorShrineTypeInfo = SnoData.Actors.GetActorShrineTypeInfo(snoActor.Sno);
			if (actorShrineTypeInfo != null) {
				return new Shrine(acdid, annId, actorShrineTypeInfo);
			}
			if (snoActor.Kind == ActorKind.Gold) {
				uint value = Convert.ToUInt32(CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gold, 1048575u, 0.0));
				return new Actor(acdid, annId, snoActor) {
					Amount = value
				};
			}
			if (snoActor.Kind == ActorKind.QuestActivate) {
				return new MapObject(acdid, annId, snoActor) {
					SummonerId = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__summoner_id, 1048575u, 0u)
				};
			}
			if (snoActor.Kind == ActorKind.HealthGlobe) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.PowerGlobe) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.RiftOrb) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.Stash) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.KanaiCube) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.Waypoint) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind == ActorKind.BookOfCain) {
				return new Actor(acdid, annId, snoActor);
			}
			if (snoActor.Kind != ActorKind.Portal && gizmoType != GizmoType.Portal) {
				if (snoActor.Kind == ActorKind.Chest) {
					return new MapObject(acdid, annId, snoActor);
				}
				if (snoActor.Kind == ActorKind.CursedEvent) {
					return new MapObject(acdid, annId, snoActor);
				}
				if (snoActor.Kind == ActorKind.ChestNormal) {
					return new MapObject(acdid, annId, snoActor);
				}
				if (snoActor.Kind != ActorKind.Obstacle && gizmoType != GizmoType.BreakableDoor && gizmoType != GizmoType.BreakableChest) {
					if (snoActor.Kind == ActorKind.ArmorRack) {
						return new MapObject(acdid, annId, snoActor);
					}
					if (snoActor.Kind == ActorKind.WeaponRack) {
						return new MapObject(acdid, annId, snoActor);
					}
					switch (gizmoType) {
						case GizmoType.Door:
							return new Door(acdid, annId, snoActor);
						case GizmoType.Headstone: {
								uint uint_3 = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__headstone_player_ann, 1048575u, 0u);
								Player iplayer_ = Array.Find(CoreCollector.PlayerCollector.PlayerSlots, (Player player) => player.IsInGame && player.AnnId == uint_3);
								return new HeadStone(acdid, annId, snoActor, uint_3, iplayer_);
							}
						default:
							if (snoActor.Kind == ActorKind.DeadBody) {
								return new MapObject(acdid, annId, snoActor);
							}
							if (snoActor.Kind == ActorKind.Banner) {
								return new TownBanner(acdid, annId, snoActor);
							}
							if (snoActor.Kind == ActorKind.NoWalk) {
								return new Actor(acdid, annId, snoActor);
							}
							return gizmoType switch {
								GizmoType.Chest => new MapObject(acdid, annId, snoActor),
								GizmoType.LoreChest => new MapObject(acdid, annId, snoActor),
								_ => null,
							};
					}
				}
				return new MonsterObstacle(acdid, annId, snoActor);
			}
			SnoArea snoArea = null;
			long ptr_portal_info = CoreCollector.ACDCollector.Buffer_ACDs[CoreCollector.ACDCollector.AcdIndexCur].ptr_portal_info;
			uint uint_4 = 0u;
			if (ptr_portal_info != 0L) {
				uint_4 = GameWindowManager.Read<uint>(ptr_portal_info);
				uint sno = GameWindowManager.Read<uint>(ptr_portal_info + 8);
				snoArea = SnoData.Areas.GetSnoArea(sno);
			}
			Portal portal = new(acdid, annId, snoActor, snoArea, uint_4);
			if (snoArea != null) {
				try {
					OnPortalFound?.Invoke(this, portal);
				} catch (Exception exception_) {
					Logger.LogException(exception_.Message);
				}
			}
			return portal;
		}
		return new Door(acdid, annId, snoActor);
	}

	private bool method_5(Actor actor)
	{
		if (actor.SnoActor.Sno == ActorSnoEnum._p1_lr_tieredrift_nephalem) {
			CoreCollector.ACDCollector.method_3(out var animSnoEnum_, out var _);
			if (animSnoEnum_ == AnimSnoEnum._p1_omninpc_female_lr_tieredrift_nephalem_idle_01) {
				IActor_1 = actor;
			}
		}
		if (actor.SnoActor.Sno == ActorSnoEnum._tyrael_heaven) {
			IActor_2 = actor;
		}
		if (actor.SnoActor.Sno == ActorSnoEnum._x1_openworld_lootrunobelisk_b) {
			IActor_3 = actor;
		}
		if ((actor.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep || actor.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep_reverse) && CoreCollector.ACDCollector.method_4() == AnimSnoEnum._arcaneenchanteddummy_death) {
			return false;
		}
		if (actor is SkillEffect skillEffect) {
			List<SkillEffect> list = Class112_0.GetValueOrDefault(skillEffect.SkillEffectRule.Type);
			if (list == null) {
				list = new List<SkillEffect>();
				Class112_0[skillEffect.SkillEffectRule.Type] = list;
			}
			list.Add(skillEffect);
			return true;
		}
		if (actor is Portal portal) {
			Class112_1[portal.AnnId] = portal;
			portal.ActorAvailable = true;
			portal.ActorLastAvailable.Restart();
			return true;
		}
		if (actor is Shrine shrine) {
			shrine.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0;
			shrine.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			CoreCollector.Class412_0.method_3(shrine);
			Shrines.Add(shrine);
			return true;
		}
		if (actor.SnoActor.Kind == ActorKind.CursedEvent) {
			actor.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			if (actor.IsOperated && actor.SnoActor.Sno == ActorSnoEnum._a1dun_leor_chest_rare_garrach && CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0) {
				actor.IsOperated = true;
			}
			return true;
		}
		if (actor is MonsterObstacle) {
			if (actor.Hitpoints > 0f) {
				actor.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0;
				actor.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0;
				if (!actor.IsDisabled && !actor.IsOperated) {
					return true;
				}
				return false;
			}
			actor.Hitpoints = 0f;
			return false;
		}
		if (actor is Door) {
			actor.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0 || actor.Untargetable;
			actor.IsOperated = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0) == 1;
			if (actor.SnoActor.Sno == ActorSnoEnum._a1dunleor_interactive_door_locked_a || actor.SnoActor.Sno == ActorSnoEnum._a1dunleor_interactive_door_locked_b || actor.SnoActor.Sno == ActorSnoEnum._caout_stingingwinds_arena_bridge || actor.SnoActor.Sno == ActorSnoEnum._a4dun_spire_sigil_door_fate || actor.SnoActor.Sno == ActorSnoEnum._a1dun_leor_spike_trapdoor || actor.SnoActor.Sno == ActorSnoEnum._catapult_a3dunkeep_warmachines_snow_firing) {
				actor.IsDisabled = true;
			}
			if (!actor.IsDisabled && !actor.IsOperated) {
				Doors.Add(actor as IClickableActor);
			}
			return true;
		}
		if (actor is TownBanner) {
			TownBanner townBanner = actor as TownBanner;
			ITownBanner_0[townBanner.Index] = townBanner;
			townBanner.Usable = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Banner_Usable, 1048575u, 0.0) == 1.0;
		}
		if (actor is HeadStone) {
			HeadStone item = actor as HeadStone;
			List_1.Add(item);
			return true;
		}
		if (actor.SnoActor.Kind == ActorKind.QuestActivate) {
			actor.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0 || actor.Untargetable;
			actor.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
			return true;
		}
		if (actor.IsClickable) {
			actor.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0;
			actor.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
		}
		return true;
	}

	internal static void smethod_1(Actor player, uint sWorldIDEncrypted, uint sSceneIDEncrypted)
	{
		if (player.WorldId != sWorldIDEncrypted || player.WorldSno == 0 || player.Scene == null || player.Scene.NavMeshId != sSceneIDEncrypted) {
			smethod_2(player, sWorldIDEncrypted, sSceneIDEncrypted);
		}
	}

	internal static void smethod_2(Actor player, uint worldId, uint sSceneIDEncrypted)
	{
		player.WorldId = worldId;
		player.WorldSno = CoreCollector.SceneCollector.method_2(player.WorldId);
		player.SnoWorld = SnoData.Worlds.GetWorld(player.WorldSno);
		player.Scene = CoreCollector.SceneCollector.method_1(player.WorldId, sSceneIDEncrypted);
	}

	public Actor method_6(ActorSnoEnum actorSnoEnum)
	{
		Actor actor = null;
		foreach (Actor item in list_3.Where((Actor iactor_0) => iactor_0.SnoActor.Sno == actorSnoEnum)) {
			if (actor == null || item.CentralXyDistanceToMe < actor.CentralXyDistanceToMe) {
				actor = item;
			}
		}
		return actor;
	}

	private unsafe void method_7(Player player)
	{
		if (CoreCollector.IsLoading) {
			return;
		}
		List<Skill> list = player.SkillSlots.Where((Skill skill) => skill != null).Concat(new Skill[1] { player.Powers.HealthPotionSkill as Skill }).ToList();
		player.list_3.Clear();
		foreach (Skill item2 in list) {
			if (item2.IsOnCooldown) {
				player.list_3.Add(item2);
			}
			item2.IsOnCooldown = false;
			item2.CooldownStartTick = 0;
			item2.CooldownFinishTick = 0;
		}
		foreach (Buff value in player.powerSno2buff.Values) {
			(value as Buff).Active = false;
		}
		player.ParagonPointsAvailableTotal = 0;
		Array.Clear(player.ParagonPointsAvailable, 0, player.ParagonPointsAvailable.Length);
		player.int_13 = 0;
		player.bool_17 = false;
		player.method_58();
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		long num5 = 0L;
		long? num6 = null;
		uint num7 = 0u;
		uint num8 = 0u;
		bool flag = false;
		float num9 = 0f;
		bool bool_ = false;
		int num10 = 0;
		player.SkillOverrideActive = false;
		bool flag2 = false;
		int count = player.list_0.Count;
		for (int num11 = 0; num11 < count; num11++) {
			r_AttributeEntry r_AttributeEntry2 = player.list_0[num11];
			try {
				int num12 = (int)(r_AttributeEntry2.uint_0 & 0xFFF);
				if (num12 <= 0 || num12 >= SnoData.Attributes.ByIndex.Count) {
					continue;
				}
				uint num13 = r_AttributeEntry2.uint_0 >> 12;
				AcdAttribute acdAttribute = SnoData.Attributes.ByIndex[num12];
				int num14 = r_AttributeEntry2.int_0;
				float num15 = ((acdAttribute.ValueType == AttributeValueType._float) ? (*(float*)(&num14)) : ((float)num14));
				if (float.IsNaN(num15)) {
					num15 = 0f;
				}
				switch (acdAttribute.Code) {
					case "Buff_Icon_End_Tick9":
						smethod_7(player, num13, num14, 9, ref bool_);
						break;
					case "Gold_PickUp_Radius":
						player.Stats.PickupRange = (float)Math.Floor(5.5f + num15);
						break;
					case "Buff_Icon_End_Tick8":
						smethod_7(player, num13, num14, 8, ref bool_);
						break;
					case "Strength_Total":
						player.Stats.Strength = (float)Math.Floor(num15);
						break;
					case "Damage_Dealt_Percent_Bonus":
						player.Offense.ElementalDamageBonus[num13] = num15;
						if (num15 > player.Offense.HighestElementalDamageBonus) {
							player.Offense.HighestElementalDamageBonus = num15;
						}
						break;
					case "Health_Globe_Bonus_Health":
						player.Defense.GlobeBonusHealth = (float)Math.Round(num15, 0);
						break;
					case "Alt_Experience_Next_Hi":
						num5 = (uint)num14;
						break;
					case "Rest_Experience_Lo":
						num8 = (uint)num14;
						break;
					case "Highest_Hero_Solo_Rift_Level":
						player.HighestHeroSoloRiftLevel = num14;
						break;
					case "Gold_Find_Total":
						player.Stats.GoldFind = (float)Math.Round(num15 * 100f, 0);
						break;
					case "Skill_Override_Active":
						player.SkillOverrideActive = num14 == 1;
						break;
					case "Damage_Percent_Reduction_From_Elites":
						player.Defense.DRElite = num15;
						break;
					case "Buff_Icon_Count30":
						smethod_3(player, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_Count31":
						smethod_3(player, num13, num14, 31, ref bool_);
						break;
					case "Highest_Solo_Rift_Level":
						player.HighestSoloRiftLevel = num14;
						break;
					case "Buff_Icon_Count19":
						smethod_3(player, num13, num14, 19, ref bool_);
						break;
					case "Looping_Animation_Start_Time":
						player.LoopingAnimationStartTick = num14;
						break;
					case "Armor_Total":
						player.Defense.Armor = (float)Math.Floor(num15);
						break;
					case "Resource_Cost_Reduction_Percent_Total":
						player.float_5[num13] = num15;
						break;
					case "Buff_Icon_Count18":
						smethod_3(player, num13, num14, 18, ref bool_);
						break;
					case "Resistance_Total":
						switch (num13) {
							case 0u:
								player.Defense.ResPhysical = num15;
								break;
							case 1u:
								player.Defense.ResFire = num15;
								break;
							case 2u:
								player.Defense.ResLightning = num15;
								break;
							case 3u:
								player.Defense.ResCold = num15;
								break;
							case 4u:
								player.Defense.ResPoison = num15;
								break;
							case 5u:
								player.Defense.ResArcane = num15;
								break;
						}
						if (num13 <= 5 && (player.Defense.ResLowest == 0f || num15 < player.Defense.ResLowest)) {
							player.Defense.ResLowest = num15;
						}
						break;
					case "Paragon_Bonus":
						player.class112_2[num13] = num14;
						break;
					case "CrowdControl_Reduction":
						player.Defense.CCReduction = (float)Math.Round(num15 * 100f, 0);
						break;
					case "Damage_Bonus_Min":
						num3 = num15;
						break;
					case "Buff_Icon_Count12":
						smethod_3(player, num13, num14, 12, ref bool_);
						break;
					case "Buff_Icon_Count13":
						smethod_3(player, num13, num14, 13, ref bool_);
						break;
					case "Dexterity_Total":
						player.Stats.Dexterity = (float)Math.Floor(num15);
						break;
					case "Hitpoints_On_Kill":
						player.Defense.LifeOnKill = (float)Math.Floor(num15);
						break;
					case "Buff_Icon_Count11":
						smethod_3(player, num13, num14, 11, ref bool_);
						break;
					case "Buff_Icon_Count28":
						smethod_3(player, num13, num14, 28, ref bool_);
						break;
					case "Buff_Icon_Count26":
						smethod_3(player, num13, num14, 26, ref bool_);
						break;
					case "Buff_Icon_Count10":
						smethod_3(player, num13, num14, 10, ref bool_);
						break;
					case "Buff_Icon_Count29":
						smethod_3(player, num13, num14, 29, ref bool_);
						break;
					case "Buff_Icon_Count16":
						smethod_3(player, num13, num14, 16, ref bool_);
						break;
					case "Buff_Icon_Count27":
						smethod_3(player, num13, num14, 27, ref bool_);
						break;
					case "Buff_Icon_Count17":
						smethod_3(player, num13, num14, 17, ref bool_);
						break;
					case "Buff_Icon_Count25":
						smethod_3(player, num13, num14, 25, ref bool_);
						break;
					case "Buff_Icon_Count15":
						smethod_3(player, num13, num14, 15, ref bool_);
						break;
					case "Buff_Icon_Count24":
						smethod_3(player, num13, num14, 24, ref bool_);
						break;
					case "Buff_Icon_Count22":
						smethod_3(player, num13, num14, 22, ref bool_);
						break;
					case "Buff_Icon_Count14":
						smethod_3(player, num13, num14, 14, ref bool_);
						break;
					case "Experience_Bonus_No_Penalty":
						player.Stats.ExpOnKillNoPenalty = (float)Math.Round(num15, 0);
						break;
					case "Buff_Icon_Count21":
						smethod_3(player, num13, num14, 21, ref bool_);
						break;
					case "Buff_Icon_Count20":
						smethod_3(player, num13, num14, 20, ref bool_);
						break;
					case "Buff_Icon_Count23":
						smethod_3(player, num13, num14, 23, ref bool_);
						break;
					case "Vitality_Total":
						player.Stats.Vitality = (float)Math.Floor(num15);
						break;
					case "Hitpoints_Max_Total":
						if (num15 >= 0f && player.Defense.HealthMax != num15) {
							player.Defense.HealthMax = num15;
						}
						break;
					case "Hitpoints_Cur":
						if (num15 >= 0f) {
							player.Defense.HealthCur = num15;
						}
						break;
					case "Damage_Percent_Bonus_Vs_Elites":
						player.Offense.BonusToElitesBase = num15;
						break;
					case "DualWield_Hand_Next":
						player.Offense.MainHandIsActive = num14 == 1;
						break;
					case "Level":
						player.CurrentLevelNormal = (uint)num14;
						break;
					case "Damage_Weapon_Delta_Total_MainHand":
						if (num13 == 0) {
							player.Offense.WeaponDamageAddPhysicalMainHand = num15;
						} else {
							player.Offense.WeaponDamageAddElementalMainHand += num15;
						}
						break;
					case "Crit_Damage_Percent":
						player.Offense.CritDamage += (float)Math.Round(num15 * 100f, 0);
						break;
					case "In_Combat":
						player.InCombat = num14 == 1;
						break;
					case "Death_Count":
						num10 = num14;
						break;
					case "Hitpoints_Max_Percent_Bonus_Item":
						player.Defense.LifeBonus = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Alt_Level":
						player.CurrentLevelParagon = (uint)num14;
						flag2 = true;
						break;

					case "Power_Cooldown_Start":
						if (num14 > 0) {
							SnoPower bySno3 = SnoData.Powers.GetBySno(num13);

							if (bySno3 != null && player.Powers.GetUsedSkill(bySno3) is Skill skill) {
								skill.CooldownStartTick = num14;
							}
						}
						break;

					case "Looping_Animation_End_Time":
						player.LoopingAnimationEndTick = num14;
						break;

					case "Corpse_Resurrection_Charges":
						player.int_13 = num14;
						break;

					case "Power_Damage_Percent_Bonus":
						player.dictionary_5[num13] = num15;
						break;

					case "Attacks_Per_Second_Percent_Subtotal":
						player.Offense.AttackSpeedPercent = num15 - 1f;
						break;

					case "Resource_Cost_Reduction_Percent_All":
						player.Stats.ResourceCostReduction = num15;
						break;

					case "Buff_Icon_Start_Tick19":
						smethod_6(player, num13, num14, 19, ref bool_);
						break;

					case "Damage_Percent_All_From_Skills":
						player.Offense.WeaponDamageIncreasedBySkills = num15;
						break;

					case "Buff_Icon_Start_Tick18":
						smethod_6(player, num13, num14, 18, ref bool_);
						break;

					case "Buff_Icon_Start_Tick10":
						smethod_6(player, num13, num14, 10, ref bool_);
						break;

					case "Damage_Percent_Reduction_From_Ranged":
						player.Defense.DRRanged = num15;
						break;

					case "Summoner_ID":
						player.SummonerId = (uint)num14;
						break;

					case "Damage_Min":
						player.Offense.DamageMin = num15;
						break;

					case "Movement_Scalar_Uncapped_Bonus":
						player.Stats.MoveSpeedBonus = (float)Math.Round((num15 - 1f) * 100f, 1);
						break;

					case "Buff_Icon_Start_Tick11":
						smethod_6(player, num13, num14, 11, ref bool_);
						break;

					case "Buff_Icon_Count8":
						smethod_3(player, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick13":
						smethod_6(player, num13, num14, 13, ref bool_);
						break;

					case "Buff_Icon_Start_Tick12":
						smethod_6(player, num13, num14, 12, ref bool_);
						break;

					case "Buff_Icon_Start_Tick15":
						smethod_6(player, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_Count9":
						smethod_3(player, num13, num14, 9, ref bool_);
						break;

					case "Buff_Icon_Start_Tick14":
						smethod_6(player, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_Start_Tick16":
						smethod_6(player, num13, num14, 16, ref bool_);
						break;

					case "Attacks_Per_Second_Item_Total_OffHand":
						player.Offense.WeaponSpeedOffHand = num15;
						break;

					case "Skill_Override":
						if (num13 <= 5) {
							Skill skill2 = player.SkillSlots[num13];

							if (skill2 != null) {
								skill2.OverrideSnoPower = ((num14 != -1)
									? SnoData.Powers.GetBySno((uint)num14)
									: null);
							}
						}
						break;

					case "Buff_Icon_Count0":
						smethod_3(player, num13, num14, 0, ref bool_);
						break;
					case "Resource_Regen_Total":
						num15 = (float)Math.Round(num15, 2);
						switch (num13) {
							case 0u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									player.Stats.ResourceRegMana = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 1u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									player.Stats.ResourceRegArcane = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 2u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									player.Stats.ResourceRegFury = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 3u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									player.Stats.ResourceRegSpirit = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 5u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceRegHatred = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 6u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceRegDiscipline = num15;
									player.Stats.ResourceRegSec = num15;
								}
								break;
							case 7u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									player.Stats.ResourceRegWrath = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 8u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									player.Stats.ResourceRegEssence = num15;
									player.Stats.ResourceRegPri = num15;
								}
								break;
							case 4u:
								break;
						}
						break;
					case "Buff_Icon_Start_Tick17":
						smethod_6(player, num13, num14, 17, ref bool_);
						break;

					case "Buff_Icon_Count2":
						smethod_3(player, num13, num14, 2, ref bool_);
						break;

					case "Skill_From_Item":
						if (num14 == 1) {
							SnoPower bySno2 = SnoData.Powers.GetBySno(num13);

							if (bySno2 != null) {
								player.UsedPassives.Add(bySno2);
							}
						}
						break;

					case "Buff_Icon_Count1":
						smethod_3(player, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Count5":
						smethod_3(player, num13, num14, 5, ref bool_);
						break;

					case "Buff_Icon_Count4":
						smethod_3(player, num13, num14, 4, ref bool_);
						break;

					case "Buff_Icon_Count3":
						smethod_3(player, num13, num14, 3, ref bool_);
						break;

					case "Rest_Experience_Bonus_Percent":
						player.BonusPoolPercent = num15 * 100f;
						break;

					case "Buff_Icon_Count7":
						smethod_3(player, num13, num14, 7, ref bool_);
						break;

					case "Buff_Icon_Count6":
						smethod_3(player, num13, num14, 6, ref bool_);
						break;

					case "Crit_Percent_Bonus_Capped":
						num2 = num15;
						break;

					case "Experience_Next_Lo":
						break;

					case "Paragon_Bonus_Points_Available":
						if (num13 < 4) {
							player.ParagonPointsAvailable[num13] = num14;
							player.ParagonPointsAvailableTotal += num14;
						}
						break;

					case "Buff_Icon_Start_Tick9":
						smethod_6(player, num13, num14, 9, ref bool_);
						break;

					case "Stunned":
						player.Powers.Stunned = num14 == 1;
						break;

					case "Damage_Weapon_Min_Total_MainHand":
						if (num13 == 0) {
							player.Offense.WeaponDamageMinPhysicalMainHand += num15;
						} else {
							player.Offense.WeaponDamageMinElementalMainHand += num15;
						}
						break;

					case "Damage_Percent_Reduction_From_Type":
						if (num13 <= 5) {
							player.Defense.DamageReductionFromType[num13] = num15;
						}
						break;

					case "Frozen":
						player.Powers.Frozen = num14 == 1;
						break;

					case "Buff_Icon_Start_Tick8":
						smethod_6(player, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick3":
						smethod_6(player, num13, num14, 3, ref bool_);
						break;

					case "Buff_Icon_Start_Tick0":
						smethod_6(player, num13, num14, 0, ref bool_);
						break;

					case "Buff_Icon_Start_Tick1":
						smethod_6(player, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Start_Tick5":
						smethod_6(player, num13, num14, 5, ref bool_);
						break;

					case "Movement_Scalar_Total":
						player.Stats.MoveSpeed = (float)Math.Round((num15 - 1f) * 100f, 1);
						break;

					case "Buff_Icon_Start_Tick2":
						smethod_6(player, num13, num14, 2, ref bool_);
						break;

					case "Experience_Next_Hi":
						break;

					case "Buff_Icon_Start_Tick4":
						smethod_6(player, num13, num14, 4, ref bool_);
						break;

					case "Thorns_Fixed":
						player.Defense.Thorns = (float)Math.Round(num15, 0);
						break;

					case "Buff_Icon_Start_Tick6":
						smethod_6(player, num13, num14, 6, ref bool_);
						break;

					case "Buff_Icon_Start_Tick7":
						smethod_6(player, num13, num14, 7, ref bool_);
						break;

					case "Crit_Percent_Bonus_Uncapped":
						num = num15;
						break;

					case "Level_Cap":
						player.CurrentLevelNormalCap = (uint)num14;
						break;

					case "Damage_Shield":
						flag = num14 == 1;
						break;
					case "Resource_Cur":
						switch (num13) {
							case 0u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									player.Stats.ResourceCurMana = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 1u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									player.Stats.ResourceCurArcane = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 2u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									player.Stats.ResourceCurFury = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 3u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									player.Stats.ResourceCurSpirit = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 5u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceCurHatred = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 6u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceCurDiscipline = num15;
									player.Stats.ResourceCurSec = num15;
								}
								break;
							case 7u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									player.Stats.ResourceCurWrath = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 8u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									player.Stats.ResourceCurEssence = num15;
									player.Stats.ResourceCurPri = num15;
								}
								break;
							case 4u:
								break;
						}
						break;
					case "Buff_Icon_End_Tick22":
						smethod_7(player, num13, num14, 22, ref bool_);
						break;

					case "Buff_Icon_End_Tick21":
						smethod_7(player, num13, num14, 21, ref bool_);
						break;

					case "Buff_Icon_End_Tick20":
						smethod_7(player, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_End_Tick24":
						smethod_7(player, num13, num14, 24, ref bool_);
						break;

					case "Damage_Percent_Reduction_From_Melee":
						player.Defense.DRMelee = num15;
						break;

					case "Buff_Icon_End_Tick23":
						smethod_7(player, num13, num14, 23, ref bool_);
						break;

					case "Buff_Icon_End_Tick26":
						smethod_7(player, num13, num14, 26, ref bool_);
						break;

					case "Buff_Icon_End_Tick31":
						smethod_7(player, num13, num14, 31, ref bool_);
						break;

					case "Buff_Icon_End_Tick25":
						smethod_7(player, num13, num14, 25, ref bool_);
						break;

					case "Buff_Icon_End_Tick27":
						smethod_7(player, num13, num14, 27, ref bool_);
						break;

					case "Magic_Find_Total":
						player.Stats.MagicFind = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_End_Tick30":
						smethod_7(player, num13, num14, 30, ref bool_);
						break;

					case "Buff_Icon_End_Tick19":
						smethod_7(player, num13, num14, 19, ref bool_);
						break;

					case "Buff_Icon_End_Tick29":
						smethod_7(player, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_End_Tick28":
						smethod_7(player, num13, num14, 28, ref bool_);
						break;

					case "Buff_Icon_End_Tick18":
						smethod_7(player, num13, num14, 18, ref bool_);
						break;

					case "Damage_Type_Cost_Reduction_Percent":
						player.float_4[num13] = num15;
						break;

					case "Backpack_Slots":
						player.InventorySpaceTotal = num14;
						break;

					case "Participating_In_Tiered_Loot_Run":
						player.InGreaterRift = num14 == 1;
						break;

					case "Damage_Weapon_Min_Total_OffHand":
						if (num13 == 0) {
							player.Offense.WeaponDamageMinPhysicalOffHand += num15;
						} else {
							player.Offense.WeaponDamageMinElementalOffHand += num15;
						}
						break;

					case "Experience_Bonus":
						player.Stats.ExpOnKill = (float)Math.Round(num15, 0);
						break;

					case "Crit_Percent_Base":
						player.Offense.CritBase = num15;
						break;

					case "Buff_Icon_End_Tick11":
						smethod_7(player, num13, num14, 11, ref bool_);
						break;

					case "Damage_Weapon_Delta_Total_OffHand":
						if (num13 == 0) {
							player.Offense.WeaponDamageAddPhysicalOffHand = num15;
						} else {
							player.Offense.WeaponDamageAddElementalOffHand += num15;
						}
						break;

					case "Buff_Icon_End_Tick13":
						smethod_7(player, num13, num14, 13, ref bool_);
						break;

					case "Experience_Bonus_Percent_Total":
						player.Stats.ExperiencePercentBonus = num15;
						break;

					case "Buff_Icon_End_Tick10":
						smethod_7(player, num13, num14, 10, ref bool_);
						break;

					case "Buff_Icon_End_Tick14":
						smethod_7(player, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_End_Tick15":
						smethod_7(player, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_End_Tick12":
						smethod_7(player, num13, num14, 12, ref bool_);
						break;

					case "Damage_Shield_Amount":
						player.Defense.CurShield = num15;
						break;

					case "Attacks_Per_Second_Item_Total_MainHand":
						player.Offense.WeaponSpeedMainHand = num15;
						break;

					case "Buff_Icon_End_Tick17":
						smethod_7(player, num13, num14, 17, ref bool_);
						break;

					case "Shared_Stash_Slots":
						player.Int32_2 = num14;
						break;

					case "Skill_Charges":
						player.class112_0[num13] = num14;
						break;

					case "Buff_Icon_End_Tick16":
						smethod_7(player, num13, num14, 16, ref bool_);
						break;

					case "Hitpoints_On_Hit":
						player.Defense.LifeOnHit = (float)Math.Floor(num15);
						break;

					case "Power_Cooldown_Reduction_Percent_All":
						if (num13 == 1048575) {
							player.Stats.CooldownReduction = num15;
						} else {
							player.dictionary_4[num13] = num14;
						}
						break;

					case "Damage_Delta":
						num4 = num15;
						break;

					case "Buff_Icon_Start_Tick20":
						smethod_6(player, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_Start_Tick21":
						smethod_6(player, num13, num14, 21, ref bool_);
						break;

					case "Experience_Bonus_Percent_Super_Scalar_Total":
						num9 = num15;
						break;

					case "Buff_Icon_Start_Tick23":
						smethod_6(player, num13, num14, 23, ref bool_);
						break;

					case "In_Tiered_Loot_Run_Level":
						player.InGreaterRiftRank = (uint)(num14 + 1);
						break;

					case "Intelligence_Total":
						player.Stats.Intelligence = (float)Math.Floor(num15);
						break;

					case "Buff_Icon_Start_Tick25":
						smethod_6(player, num13, num14, 25, ref bool_);
						break;

					case "Damage_Reduction_Total":
						player.Defense.DamageReduction = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_Start_Tick22":
						smethod_6(player, num13, num14, 22, ref bool_);
						break;

					case "IsRooted":
						player.Powers.Rooted = num14 == 1;
						break;

					case "Buff_Icon_Start_Tick27":
						smethod_6(player, num13, num14, 27, ref bool_);
						break;

					case "Buff_Icon_Start_Tick24":
						smethod_6(player, num13, num14, 24, ref bool_);
						break;

					case "Class_Damage_Reduction_Percent":
						player.Defense.DRClass = num15;
						break;

					case "Buff_Icon_Start_Tick29":
						smethod_6(player, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_Start_Tick26":
						smethod_6(player, num13, num14, 26, ref bool_);
						break;

					case "Corpse_Resurrection_Disabled":
						player.bool_17 = num14 == 1;
						break;

					case "Hitpoints_Regen_Per_Second_Total":
						player.Defense.LifeRegen = num15;
						break;

					case "Buff_Icon_Start_Tick28":
						smethod_6(player, num13, num14, 28, ref bool_);
						break;

					case "Rest_Experience_Hi":
						num7 = (uint)num14;
						break;

					case "Power_Resource_Reduction":
						player.dictionary_3[num13] = num14;
						break;

					case "Splash_Damage_Effect_Percent":
						player.Offense.AreaDamageBonus = (float)Math.Round(num15 * 100f, 1);
						break;

					case "Power_Cooldown":
						if (num14 > 0) {
							SnoPower bySno = SnoData.Powers.GetBySno(num13);

							if (bySno != null && player.Powers.GetUsedSkill(bySno) is Skill skill3) {
								skill3.CooldownFinishTick = num14;
							}
						}
						break;
					case "Resource_Max_Total":
						switch (num13) {
							case 0u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									player.Stats.ResourceMaxMana = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 1u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									player.Stats.ResourceMaxArcane = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 2u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									player.Stats.ResourceMaxFury = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 3u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									player.Stats.ResourceMaxSpirit = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 5u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceMaxHatred = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 6u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									player.Stats.ResourceMaxDiscipline = num15;
									player.Stats.ResourceMaxSec = num15;
								}
								break;
							case 7u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									player.Stats.ResourceMaxWrath = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 8u:
								if (player.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									player.Stats.ResourceMaxEssence = num15;
									player.Stats.ResourceMaxPri = num15;
								}
								break;
							case 4u:
								break;
						}
						break;
					case "Alt_Experience_Next_Lo":
						num6 = (uint)num14;
						break;
					case "Buff_Icon_Start_Tick31":
						smethod_6(player, num13, num14, 31, ref bool_);
						break;
					case "Buff_Icon_End_Tick2":
						smethod_7(player, num13, num14, 2, ref bool_);
						break;
					case "Buff_Icon_Start_Tick30":
						smethod_6(player, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_End_Tick1":
						smethod_7(player, num13, num14, 1, ref bool_);
						break;
					case "Buff_Icon_End_Tick0":
						smethod_7(player, num13, num14, 0, ref bool_);
						break;
					case "Buff_Icon_End_Tick3":
						smethod_7(player, num13, num14, 3, ref bool_);
						break;
					case "Buff_Icon_End_Tick7":
						smethod_7(player, num13, num14, 7, ref bool_);
						break;
					case "Buff_Icon_End_Tick6":
						smethod_7(player, num13, num14, 6, ref bool_);
						break;
					case "Item_Power_Passive":
						player.class112_1[num13] = num15;
						break;
					case "Attacks_Per_Second_Bonus":
						player.Offense.AttackSpeedBonus = num15;
						break;
					case "Buff_Icon_End_Tick5":
						smethod_7(player, num13, num14, 5, ref bool_);
						break;
					case "Buff_Icon_End_Tick4":
						smethod_7(player, num13, num14, 4, ref bool_);
						break;
				}
			} catch {
			}
		}
		if (!flag) {
			player.Defense.CurShield = 0f;
		}
		if (!player.SkillOverrideActive) {
			Skill[] class386_ = player.SkillSlots;
			foreach (Skill skill4 in class386_) {
				if (skill4 != null) {
					skill4.OverrideSnoPower = null;
				}
			}
		}
		if (player.HeroClassDefinition == SnoData.Classes.ClassBarbarian || player.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
			player.Stats.MainStat = player.Stats.Strength;
		}
		if (player.HeroClassDefinition == SnoData.Classes.ClassMonk || player.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
			player.Stats.MainStat = player.Stats.Dexterity;
		}
		if (player.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor || player.HeroClassDefinition == SnoData.Classes.ClassWizard || player.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
			player.Stats.MainStat = player.Stats.Intelligence;
		}
		if (player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_PierceTheVeil.Sno)) {
			player.Stats.ResourceCostReduction = 1f - 1.3f * (1f - player.Stats.ResourceCostReduction);
		}
		if (player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_BloodRitual.Sno)) {
			player.Stats.ResourceCostReduction = 1f - 0.8f * (1f - player.Stats.ResourceCostReduction);
		}
		Buff buff = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Necromancer_Devour.Sno);
		if (buff != null && buff.Active && buff != null && buff.IconCounts[2] > 0) {
			player.Stats.ResourceCostReduction = 1f - (1f - (float)buff.IconCounts[2] * 0.02f) * (1f - player.Stats.ResourceCostReduction);
		}
		if (player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.Necromancer_LandOfTheDead.Sno, 3)) {
			player.Stats.ResourceCostReduction = 1f;
		}
		if (player.Defense.HealthCur == 0f && !player.IsDead) {
			player.LastDied.Restart();
		}
		player.IsDead = player.Defense.HealthCur == 0f;
		if (player.IsDead) {
			CoreCollector.PlayerCollector.Boolean_0 = true;
			if (!player.IsMe) {
				CoreCollector.PlayerCollector.Boolean_1 = true;
			}
		}
		if (num10 != player.Int32_1) {
			if (player.Defense.HealthCur <= 0f && num10 > player.Int32_1 && player.IsMe) {
				num10++;
				foreach (StatTracker item3 in CoreCollector.Trackers) {
					item3.Death++;
				}
			}
			player.Int32_1 = num10;
		}
		player.Defense.HealthPct = ((!(player.Defense.HealthMax > 0f) || player.Defense.HealthCur <= 0f) ? 0f : (player.Defense.HealthCur / player.Defense.HealthMax * 100f));
		player.Offense.DamageMax = player.Offense.DamageMin + num4;
		player.Offense.DamageMin += num3;
		player.Stats.ResourcePctArcane = ((!(player.Stats.ResourceMaxArcane > 0f) || player.Stats.ResourceCurArcane <= 0f) ? 0f : (player.Stats.ResourceCurArcane / player.Stats.ResourceMaxArcane * 100f));
		player.Stats.ResourcePctSpirit = ((!(player.Stats.ResourceMaxSpirit > 0f) || player.Stats.ResourceCurSpirit <= 0f) ? 0f : (player.Stats.ResourceCurSpirit / player.Stats.ResourceMaxSpirit * 100f));
		player.Stats.ResourcePctDiscipline = ((!(player.Stats.ResourceMaxDiscipline > 0f) || player.Stats.ResourceCurDiscipline <= 0f) ? 0f : (player.Stats.ResourceCurDiscipline / player.Stats.ResourceMaxDiscipline * 100f));
		player.Stats.ResourcePctFury = ((!(player.Stats.ResourceMaxFury > 0f) || player.Stats.ResourceCurFury <= 0f) ? 0f : (player.Stats.ResourceCurFury / player.Stats.ResourceMaxFury * 100f));
		player.Stats.ResourcePctHatred = ((!(player.Stats.ResourceMaxHatred > 0f) || player.Stats.ResourceCurHatred <= 0f) ? 0f : (player.Stats.ResourceCurHatred / player.Stats.ResourceMaxHatred * 100f));
		player.Stats.ResourcePctMana = ((!(player.Stats.ResourceMaxMana > 0f) || player.Stats.ResourceCurMana <= 0f) ? 0f : (player.Stats.ResourceCurMana / player.Stats.ResourceMaxMana * 100f));
		player.Stats.ResourcePctWrath = ((!(player.Stats.ResourceMaxWrath > 0f) || player.Stats.ResourceCurWrath <= 0f) ? 0f : (player.Stats.ResourceCurWrath / player.Stats.ResourceMaxWrath * 100f));
		player.Stats.ResourcePctEssence = ((!(player.Stats.ResourceMaxEssence > 0f) || player.Stats.ResourceCurEssence <= 0f) ? 0f : (player.Stats.ResourceCurEssence / player.Stats.ResourceMaxEssence * 100f));
		player.Stats.ResourcePctPri = ((!(player.Stats.ResourceMaxPri > 0f) || player.Stats.ResourceCurPri <= 0f) ? 0f : (player.Stats.ResourceCurPri / player.Stats.ResourceMaxPri * 100f));
		player.Stats.ResourcePctSec = ((!(player.Stats.ResourceMaxSec > 0f) || player.Stats.ResourceCurSec <= 0f) ? 0f : (player.Stats.ResourceCurSec / player.Stats.ResourceMaxSec * 100f));
		player.Offense.CriticalHitChance = (player.Offense.CritBase + num + num2) * 100f;
		if (player.Offense.WeaponDamageMinPhysicalOffHand == 0f && player.Offense.WeaponDamageMinElementalOffHand == 0f) {
			player.Offense.WeaponSpeedOffHand = 0f;
		}
		player.Offense.AttackSpeedMainHand = (player.Offense.WeaponSpeedMainHand + player.Offense.AttackSpeedBonus) * (1f + player.Offense.AttackSpeedPercent);
		if (player.Offense.WeaponSpeedOffHand > 0f) {
			player.Offense.AttackSpeedOffHand = (player.Offense.WeaponSpeedOffHand + player.Offense.AttackSpeedBonus) * (1f + player.Offense.AttackSpeedPercent);
			player.Offense.AttackSpeed = (player.Offense.MainHandIsActive ? player.Offense.AttackSpeedMainHand : player.Offense.AttackSpeedOffHand);
		} else {
			player.Offense.AttackSpeed = player.Offense.AttackSpeedMainHand;
		}
		bool flag3 = player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.TaskerandTheo.Sno);
		player.Offense.AttackSpeedPets = (flag3 ? (player.Offense.AttackSpeed * (1f + player.class112_1.GetValueOrDefault(318731u))) : player.Offense.AttackSpeed);
		player.Defense.ResAverage = (player.Defense.ResPhysical + player.Defense.ResFire + player.Defense.ResLightning + player.Defense.ResCold + player.Defense.ResPoison + player.Defense.ResArcane) / 6f;
		player.Defense.AverageDamageReductionFromType = 0f;
		for (int num17 = 0; num17 < player.Defense.DamageReductionFromType.Length; num17++) {
			player.Defense.AverageDamageReductionFromType += player.Defense.DamageReductionFromType[num17];
		}
		player.Defense.AverageDamageReductionFromType /= player.Defense.DamageReductionFromType.Length;
		float currentLevelNormal = player.CurrentLevelNormal;
		player.Defense.drArmor = ((player.Defense.Armor > 0f) ? (player.Defense.Armor / (player.Defense.Armor + currentLevelNormal * 50f)) : 0f);
		player.Defense.drResist = ((player.Defense.ResAverage > 0f) ? (player.Defense.ResAverage / (player.Defense.ResAverage + currentLevelNormal * 5f)) : 0f);
		float num19 = (1f - player.Defense.drArmor) * (1f - player.Defense.drResist) * (1f - player.Defense.DRClass) * (1f - player.Defense.DRElite);
		if (player.Defense.AverageDamageReductionFromType > 0f) {
			num19 *= 1f - player.Defense.AverageDamageReductionFromType;
		}
		if (player.UsedPassives.Any((SnoPower snoPower) => snoPower.Sno == 217968)) {
			num19 *= 0.85f;
		}
		Skill epiphany = player.Powers.UsedMonkPowers.Epiphany;
		if (epiphany != null && epiphany.BuffIsActive && epiphany.Rune == 0) {
			num19 *= 0.5f;
		}
		Buff buff2 = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_ShrineDesecratedBlessed.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.75f;
		}
		buff2 = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_ShrinePowerBlessed.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.75f;
		}
		buff2 = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.SpiritGuards.Sno);
		if (buff2 != null && buff2.IconCounts[1] >= 1) {
			num19 *= 0.6f;
		}
		buff2 = player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Barbarian_IgnorePain.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.5f;
		}
		buff2 = player.Powers.GetBuff("P4_ItemPassive_Unique_Ring_014");
		if (buff2 != null && buff2.Active) {
			int num20 = 0;
			foreach (Item item4 in CoreCollector.ItemCollector.Items.Values) {
				if (item4.Location >= ItemLocation.Head && item4.Location <= ItemLocation.Neck && item4.AncientRank > 0) {
					num20++;
				}
			}
			if (num20 > 0) {
				float item = num20;
				player.Offense.PlainDamageBonuses.Add((buff2.SnoPower, item));
			}
		}
		Skill callOfTheAncients = CoreCollector.LocalPlayer.Powers.UsedBarbarianPowers.CallOfTheAncients;
		if (callOfTheAncients != null && callOfTheAncients.BuffIsActive && callOfTheAncients.Rune == 4) {
			num19 *= 0.5f;
		}
		player.Defense.drCombined = 1f - num19;
		float num21 = ((player.Defense.drCombined != 1f) ? (player.Defense.HealthMax / (1f - player.Defense.drCombined)) : 0f);
		player.Defense.EhpCur = ((player.Defense.drCombined != 1f) ? (player.Defense.HealthCur / (1f - player.Defense.drCombined)) : 0f);
		if (player.Defense.EhpMax != num21) {
			player.Defense.EhpMax = num21;
		}
		player.Stats.ExperiencePercentBonus *= 100f;
		if (num9 > 0f) {
			player.Stats.ExperiencePercentBonus *= num9;
		}
		if (player.CurrentLevelParagon + 1 >= SnoData.Experience.ParagonTableTotal.Length) {
			player.CurrentLevelParagon = 0u;
		}
		player.bool_14 = player.CurrentLevelNormal != 0;
		if (CoreCollector.LocalPlayer.SnoArea != null && flag2 && player.bool_14) {
			if (player.CurrentLevelNormal != player.CurrentLevelNormalCap || num5 == uint.MaxValue || !num6.HasValue) {
				goto IL_3e56;
			}
			if (num5 <= 0) {
				long? num22 = num6;
				if (!(num22 > 0L)) {
					goto IL_3e56;
				}
			}
			long num24 = SnoData.Experience.ParagonTableTotal[player.CurrentLevelParagon];
			long num25 = SnoData.Experience.ParagonExpLevel[player.CurrentLevelParagon + 1];
			long num26 = (num5 << 32) + num6.Value;
			long num27 = num25 - num26;
			long num28 = num24 + num27;
			if (num27 >= 0 && num25 >= 0) {
				player.class362_0.Value = num28;
				if (player.class362_0.Value == num28 && player.ParagonTotalExp != num28) {
					player.long_1 = num24;
					player.ParagonExpToNextLevel = num25;
					player.ParagonExpInThisLevel = num27;
					player.ParagonTotalExp = num28;
					player.CurrentLevelParagonDouble = (double)player.CurrentLevelParagon + ((num25 > 0) ? ((double)num27 / (double)num25) : 0.0);
				}
			}
		}
		goto IL_3e9a;
	IL_3e56:
		player.long_1 = 0L;
		player.ParagonExpToNextLevel = 0L;
		player.ParagonExpInThisLevel = 0L;
		player.ParagonTotalExp2 = 0L;
		player.ParagonTotalExp = 0L;
		player.class362_0.ForceSet(0L);
		player.CurrentLevelParagonDouble = 0.0;
		goto IL_3e9a;
	IL_3e9a:
		player.BonusPoolRemaining = (long)(((ulong)num7 << 32) + num8);
		foreach (Skill item5 in list) {
			item5.IsOnCooldown = item5.CooldownStartTick > 0 && item5.CooldownStartTick <= CoreCollector.D3Memory.GameTick && item5.CooldownFinishTick > CoreCollector.D3Memory.GameTick;
			if (item5.IsOnCooldown && !player.list_3.Contains(item5) && item5.CurrentSnoPower != null) {
				try {
					CoreCollector.OnCooldown?.Invoke(player, item5);
				} catch (Exception exception_) {
					Logger.LogException(exception_.Message);
				}
			}
		}
		for (int num29 = 0; num29 < player.list_3.Count; num29++) {
			Skill playerSkill = player.list_3[num29];
			if (!playerSkill.IsOnCooldown && playerSkill.CurrentSnoPower != null) {
				try {
					CoreCollector.OnTrueCooldown?.Invoke(player, playerSkill);
				} catch (Exception exception) {
					Logger.LogException(exception.Message);
				}
			}
		}
		float num30 = player.Offense.WeaponDamageMinPhysicalMainHand + player.Offense.WeaponDamageAddPhysicalMainHand / 2f;
		float num31 = player.Offense.WeaponDamageMinElementalMainHand + player.Offense.WeaponDamageAddElementalMainHand / 2f;
		player.Offense.WeaponBaseDamageMinAmainHand = player.Offense.WeaponDamageMinPhysicalMainHand + player.Offense.WeaponDamageMinElementalMainHand;
		player.Offense.WeaponBaseDamageMaxAmainHand = player.Offense.WeaponDamageMinPhysicalMainHand + player.Offense.WeaponDamageAddPhysicalMainHand + player.Offense.WeaponDamageMinElementalMainHand + player.Offense.WeaponDamageAddElementalMainHand;
		player.Offense.WeaponBaseDamageMinBmainHand = player.Offense.WeaponDamageMinPhysicalMainHand + player.Offense.DamageMin + player.Offense.WeaponDamageMinElementalMainHand;
		player.Offense.WeaponBaseDamageMaxBmainHand = player.Offense.WeaponDamageMinPhysicalMainHand + player.Offense.WeaponDamageAddPhysicalMainHand + player.Offense.DamageMax + player.Offense.WeaponDamageMinElementalMainHand + player.Offense.WeaponDamageAddElementalMainHand;
		float num32 = player.Offense.WeaponDamageMinPhysicalOffHand + player.Offense.WeaponDamageAddPhysicalOffHand / 2f;
		float num33 = player.Offense.WeaponDamageMinElementalOffHand + player.Offense.WeaponDamageAddElementalOffHand / 2f;
		player.Offense.WeaponBaseDamageMinAoffHand = player.Offense.WeaponDamageMinPhysicalOffHand + player.Offense.WeaponDamageMinElementalOffHand;
		player.Offense.WeaponBaseDamageMaxAoffHand = player.Offense.WeaponDamageMinPhysicalOffHand + player.Offense.WeaponDamageAddPhysicalOffHand + player.Offense.WeaponDamageMinElementalOffHand + player.Offense.WeaponDamageAddElementalOffHand;
		player.Offense.WeaponBaseDamageMinBoffHand = player.Offense.WeaponDamageMinPhysicalOffHand + player.Offense.DamageMin + player.Offense.WeaponDamageMinElementalOffHand;
		player.Offense.WeaponBaseDamageMaxBoffHand = player.Offense.WeaponDamageMinPhysicalOffHand + player.Offense.WeaponDamageAddPhysicalOffHand + player.Offense.DamageMax + player.Offense.WeaponDamageMinElementalOffHand + player.Offense.WeaponDamageAddElementalOffHand;
		float num34 = (num30 + (player.Offense.DamageMin + player.Offense.DamageMax) / 2f + num31) * (1f + player.Offense.CriticalHitChance / 100f * player.Offense.CritDamage / 100f) * (1f + player.Stats.MainStat / 100f) * (1f + player.Offense.WeaponDamageIncreasedBySkills);
		player.Offense.WeaponDamageMainHand = (float)Math.Round(num34, 2, MidpointRounding.ToEven);
		player.Offense.SheetDpsMainHand = num34 * player.Offense.AttackSpeedMainHand;
		if (player.Offense.AttackSpeedOffHand > 0f) {
			float num35 = (num32 + (player.Offense.DamageMin + player.Offense.DamageMax) / 2f + num33) * (1f + player.Offense.CriticalHitChance / 100f * player.Offense.CritDamage / 100f) * (1f + player.Stats.MainStat / 100f) * (1f + player.Offense.WeaponDamageIncreasedBySkills);
			player.Offense.WeaponDamageSecondHand = (float)Math.Round(num35, 2, MidpointRounding.ToEven);
			player.Offense.SheetDpsOffHand = num35 * player.Offense.AttackSpeedOffHand;
			player.Offense.SheetDps = (num34 + num35) / 2f * (player.Offense.AttackSpeedMainHand + player.Offense.AttackSpeedOffHand) / 2f;
		} else {
			player.Offense.SheetDps = player.Offense.SheetDpsMainHand;
		}
		player.float_6 = player.Defense.LifeOnHit * player.Offense.AttackSpeed + player.Defense.LifeRegen;
	}

	internal static void smethod_3(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		Buff buff = player.Powers.GetBuff(uint_0) as Buff;
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(player, bySno);
			player.powerSno2buff.Add(uint_0, buff);
			player.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.IconCounts[int_5] = int_4;
		if (int_4 > 0) {
			buff.Active = true;
			buff.FirstActive.Start();
			buff.LastActive.Restart();
		}
	}

	internal static void smethod_6(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		double num = ((int_4 > 0) ? ((double)(CoreCollector.D3Memory.GameTick - int_4) / 60.0) : 0.0);
		Buff buff = player.Powers.GetBuff(uint_0);
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(player, bySno);
			player.powerSno2buff.Add(uint_0, buff);
			player.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.TimeElapsedSeconds[int_5] = num;
	}

	internal static void smethod_7(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		double num = ((int_4 > 0) ? ((double)(int_4 - CoreCollector.D3Memory.GameTick) / 60.0) : 0.0);
		Buff buff = player.Powers.GetBuff(uint_0);
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(player, bySno);
			player.powerSno2buff.Add(uint_0, buff);
			player.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.TimeLeftSeconds[int_5] = num;
	}
}
