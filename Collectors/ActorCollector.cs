using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using structs;
using Plugins;
using SNO;


namespace collectors;

internal class ActorCollector
{
	private readonly Class112<uint, Actor> class112_0 = new Class112<uint, Actor>(1000);

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
	private int int_0;

	private Stopwatch stopwatch_1 = new();

	public FollowerClass followerClass_0;

	public List<Monster> list_0 = new List<Monster>();

	public List<Monster> list_1 = new List<Monster>();

	public List<MonsterPack> list_2 = new List<MonsterPack>();

	public List<Actor> list_3 = new List<Actor>(1000);

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private MonsterPriority monsterPriority_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private readonly Class112<SkillEffectType, List<SkillEffect>> class112_1 = new Class112<SkillEffectType, List<SkillEffect>>();

	[CompilerGenerated]
	private readonly Class112<uint, Portal> class112_2 = new Class112<uint, Portal>();

	[CompilerGenerated]
	private readonly List<Shrine> list_4 = new List<Shrine>();

	[CompilerGenerated]
	private readonly List<HeadStone> list_5 = new List<HeadStone>();

	[CompilerGenerated]
	private readonly List<IClickableActor> list_6 = new List<IClickableActor>();

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
	private int int_3;

	[CompilerGenerated]
	private r_Actor[] struct6_0;

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

	public int Int32_0
	{
		[CompilerGenerated]
		get {
			return int_0;
		}
		[CompilerGenerated]
		internal set {
			int_0 = value;
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

	public bool Boolean_1
	{
		[CompilerGenerated]
		get {
			return bool_1;
		}
		[CompilerGenerated]
		private set {
			bool_1 = value;
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get {
			return bool_2;
		}
		[CompilerGenerated]
		private set {
			bool_2 = value;
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

	public bool Boolean_3
	{
		[CompilerGenerated]
		get {
			return bool_3;
		}
		[CompilerGenerated]
		private set {
			bool_3 = value;
		}
	}

	public Class112<SkillEffectType, List<SkillEffect>> Class112_0
	{
		[CompilerGenerated]
		get {
			return class112_1;
		}
	}

	public Class112<uint, Portal> Class112_1
	{
		[CompilerGenerated]
		get {
			return class112_2;
		}
	}

	public List<Shrine> List_0
	{
		[CompilerGenerated]
		get {
			return list_4;
		}
	}

	public List<HeadStone> List_1
	{
		[CompilerGenerated]
		get {
			return list_5;
		}
	}

	public List<IClickableActor> List_2
	{
		[CompilerGenerated]
		get {
			return list_6;
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

	public int Int32_2
	{
		[CompilerGenerated]
		get {
			return int_3;
		}
		[CompilerGenerated]
		internal set {
			int_3 = value;
		}
	}

	internal r_Actor[] BufferActors
	{
		[CompilerGenerated]
		get {
			return struct6_0;
		}
		[CompilerGenerated]
		private set {
			struct6_0 = value;
		}
	}

	internal void method_0()
	{
		class112_0.Clear();
	}

	internal void method_1()
	{
		list_0.Clear();
		list_1.Clear();
	}

	internal void method_2(bool bool_4)
	{
		list_3.Clear();
		list_0.Clear();
		list_1.Clear();
		foreach (List<SkillEffect> item in Class112_0.IEnumerable_0) {
			item.Clear();
		}
		if (bool_4) {
			Class112_1.Clear();
		}
		List_0.Clear();
		List_2.Clear();
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
		Boolean_1 = false;
		Boolean_2 = false;
		MonsterPriority_0 = MonsterPriority.none;
		Boolean_3 = false;
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
		foreach (Portal item in Class112_1.IEnumerable_0) {
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
					Actor actor = class112_0[actorId];
					if (actor == null || !(actor is Monster { CurHealth: > 0.0 } @class)) {
						continue;
					}
					@class.CurHealth = 0.0;
					foreach (StatTracker item2 in CoreCollector.Trackers) {
						item2.MonsterKill++;
					}
					if (@class.IsElite) {
						foreach (StatTracker item3 in CoreCollector.Trackers) {
							item3.EliteKill++;
						}
					}
					if (@class.Pack != null) {
						(@class.Pack as MonsterPack)?.Class112_2.Remove(@class.MaxHealth);
						(@class.Pack as MonsterPack)?.Class112_0.Remove(@class.MaxHealth);
						(@class.Pack as MonsterPack)?.Class112_1.Set(@class.MaxHealth, @class);
					}
					if (CoreCollector.LocalPlayer.SnoArea != null) {
						SnoMonster snoMonster = @class.SnoMonster;
						if (snoMonster != null && snoMonster.Priority == MonsterPriority.keywarden) {
							stopwatch_0.Restart();
							Int32_0 = CoreCollector.LocalPlayer.SnoArea.Act;
							Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
						}
					}
					try {
						onMonsterKilled?.Invoke(this, @class);
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
				Actor actor2 = class112_0[gparam_];
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
				Monster class2 = null;
				SnoMonster snoMonster2 = null;
				if (actor2 == null) {
					snoMonster2 = SnoData.Monsters.GetMonster(actorSnoEnum);
					if (snoMonster2 != null) {
						flag2 = snoMonster2.Priority != MonsterPriority.none;
					}
				} else if (flag2 = actor2 is Monster && !(actor2 is MonsterObstacle)) {
					class2 = actor2 as Monster;
					snoMonster2 = class2.SnoMonster;
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
						actor2 = method_4(gizmoType_0: (GizmoType)struct7_.GizmoType, uint_0: acdid, uint_1: annId, SnoActor_0: snoActor, uint_2: num10) ?? new Actor(acdid, annId, snoActor);
						actor2.CreatedAtInGameTick = ptr->CreationTick;
						class112_0.Set(gparam_, actor2);
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
				bool flag4 = flag || class2 == null;
				if (class2 != null && (class2.IsElite || class2.SnoMonster.Priority >= MonsterPriority.keywarden)) {
					flag4 = true;
				}
				double value = (flag4 ? CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Hitpoints_Max_Total, 1048575u, 0.0) : class2.MaxHealth);
				double num11 = (flag4 ? CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Hitpoints_Cur, 1048575u, 1.0) : class2.CurHealth);
				if (num11 < 0.3) {
					if (class2 != null && class2.CurHealth > 0.0) {
						num5 += class2.CurHealth;
						class2.CurHealth = 0.0;
						foreach (StatTracker item5 in CoreCollector.Trackers) {
							item5.MonsterKill++;
						}
						if (class2.IsElite) {
							foreach (StatTracker item6 in CoreCollector.Trackers) {
								item6.EliteKill++;
							}
						}
						if (CoreCollector.LocalPlayer.SnoArea != null) {
							SnoMonster snoMonster3 = class2.SnoMonster;
							if (snoMonster3 != null && snoMonster3.Priority == MonsterPriority.keywarden) {
								stopwatch_0.Restart();
								Int32_0 = CoreCollector.LocalPlayer.SnoArea.Act;
								Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
							}
						}
						try {
							onMonsterKilled?.Invoke(this, class2);
						} catch (Exception exception_2) {
							Logger.LogException(exception_2.Message);
						}
					}
					if (class2 != null) {
						list_0.Add(class2);
					}
					continue;
				}
				ActorRarity actorRarity = (ActorRarity)struct7_.ActorRarity;
				if (class2 == null) {
					class2 = new Monster(acdid, annId, snoMonster2.SnoActor, snoMonster2) {
						SummonerAcdDynamicId = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__summoned_by_acdid, 1048575u, 0u)
					};
					class112_0.Set(gparam_, class2);
				}
				class2.Rarity = actorRarity;
				class2.IsElite = snoMonster2.IsUnique || actorRarity != ActorRarity.Normal;
				class2.IsSelected = ptr->IsSelected != uint.MaxValue;
				if (class2.IsSelected) {
					IActor_0 = class2;
				}
				smethod_0(struct7_, class2);
				class2.list_0.Clear();
				CoreCollector.ACDCollector.method_12(class2.list_0);
				if (num11 < class2.CurHealth) {
					num5 += class2.CurHealth - num11;
				}
				class2.MaxHealth = value;
				class2.CurHealth = num11;
				class2.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
				class2.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
				sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
				sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
				smethod_1(class2, sWorldID_Encrypted, sSceneID_Encrypted);
				class2.RadiusScaled = struct7_.CollisionRadius;
				class2.RadiusBottom = ptr->BottomRadius;
				class2.CreatedAtInGameTick = ptr->CreationTick;
				class2.method_25();
				if (snoMonster2.Priority == MonsterPriority.keywarden && CoreCollector.LocalPlayer.SnoArea != null) {
					IWorldCoordinate_0 = class2.FloorCoordinate;
					Int32_2 = CoreCollector.LocalPlayer.SnoArea.Act;
				}
				if (acdid == CoreCollector.D3Memory.SelectedActor1_AcdId) {
					IMonster_0 = class2;
				}
				if (acdid == CoreCollector.D3Memory.SelectedActor2_AcdId) {
					IMonster_1 = class2;
				}
				if (flag4) {
					class2.Illusion = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, 264185u, 0.0) != 0.0;
					class2.Frozen = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Frozen, 1048575u, 0.0) == 1.0;
					class2.Chilled = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Chilled, 1048575u, 0.0) == 1.0;
					class2.Slow = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Slow, 1048575u, 0.0) == 1.0;
					class2.Stunned = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Stunned, 1048575u, 0.0) == 1.0;
					class2.Untargetable = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Untargetable, 1048575u, 0.0) == 1.0;
					class2.Invulnerable = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Invulnerable, 1048575u, 0.0) == 1.0;
					class2.Burrowed = class2.Untargetable || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Burrowed, 1048575u, 0.0) == 1.0;
					class2.Stealthed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Stealthed, 1048575u, 0.0) == 1.0;
					class2.Blind = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Blind, 1048575u, 0.0) == 1.0;
					class2.Bleeding = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Bleeding, 1048575u, 0.0) == 1.0;
					class2.Hidden = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Hidden, 1048575u, 0.0) == 1.0;
					class2.Invisible = class2.Burrowed || class2.Stealthed || class2.Hidden;
					class2.Palmed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0;
					class2.Haunted = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0;
					class2.MarkedForDeath = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0;
					class2.Locust = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0;
					class2.Piranhas = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_3_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_5_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_6_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_1_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0;
					class2.Cursed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_DecrepifyPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_LeechPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_FrailtyPassiveEffect.Sno, 0.0) == 1.0;
					class2.Strongarmed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.StrongarmBracers.Sno, 0.0) == 1.0;
					class2.Phoenixed = CoreCollector.ACDCollector.method_8(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Generic_ItemPassiveUniqueRing733x1.Sno, 0.0) == 1.0;
					class2.DotDpsApplied = CoreCollector.ACDCollector.method_7(CoreCollector.Controller.Sno.Attributes.DOT_DPS, 1048575u);
					if (class2.SnoMonster.Priority >= MonsterPriority.keywarden || class2.IsElite) {
						CoreCollector.ACDCollector.method_3(out var animSnoEnum_2, out var acdAnimationState_2);
						class2.Animation = animSnoEnum_2;
						class2.AnimationState = acdAnimationState_2;
					}
				}
				if (class2.IsElite) {
					Boolean_1 = true;
				}
				if (class2.IsOnScreen && Math.Abs(CoreCollector.LocalPlayer.FloorCoordinate.Z - class2.FloorCoordinate.Z) <= 16f) {
					if (class2.IsElite) {
						Boolean_2 = true;
					}
					if (class2.SnoMonster.Priority > MonsterPriority_0) {
						MonsterPriority_0 = class2.SnoMonster.Priority;
					}
					if (class2.SnoMonster.Priority == MonsterPriority.goblin) {
						Boolean_3 = true;
					}
				}
				list_3.Add(class2);
				if (flag3) {
					list_0.Add(class2);
					list_1.Add(class2);
					class2.Attackable = class2.IsOnScreen && !class2.Untargetable && !class2.Invisible;
					if (class2.IsOnScreen && !class2.Untargetable && !class2.Invisible) {
						Int32_1++;
					}
				} else {
					class2.Attackable = false;
				}
			end_IL_019d:;
			}
		}
		if (num6 > 30) {
			Logger.Info("[ERROR] force daf scan due to problem with actor's acd");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return false;
		}
		foreach (MonsterPack item7 in list_2) {
			foreach (Monster item8 in item7.Class112_0.IEnumerable_0) {
				item7.Class112_2.Set(item8.MaxHealth, item8);
			}
			item7.Class112_0.Clear();
		}
		list_0.Sort((Monster imonster_0, Monster imonster_1) => -((int)imonster_0.Rarity).CompareTo((int)imonster_1.Rarity));
		foreach (Monster Monster_0 in list_0) {
			if (Monster_0.Pack != null) {
				(Monster_0.Pack as MonsterPack)?.Class112_2.Remove(Monster_0.MaxHealth);
				if (Monster_0.CurHealth > 0.0) {
					(Monster_0.Pack as MonsterPack).Class112_0[Monster_0.MaxHealth] = Monster_0;
				} else {
					(Monster_0.Pack as MonsterPack).Class112_1[Monster_0.MaxHealth] = Monster_0;
				}
			} else {
				if (Monster_0.AffixSnoList == null) {
					continue;
				}
				if (Monster_0.Rarity != ActorRarity.Champion && Monster_0.Rarity != ActorRarity.Rare) {
					if (Monster_0.Rarity != ActorRarity.RareMinion) {
						continue;
					}
					if (Monster_0.SummonerAcdDynamicId != 0) {
						continue;
					}
					string string_0 = string.Concat(Monster_0.AffixSnoList.Select((SnoMonsterAffix SnoMonsterAffix_0) => SnoMonsterAffix_0.NameLocalized));
					MonsterPack monsterPack2 = list_2.Find((MonsterPack imonsterPack_0) => (imonsterPack_0 as MonsterPack)?.String_1 == string_0 && imonsterPack_0.MinionSnoMonster == Monster_0.SnoMonster) as MonsterPack;
					if (monsterPack2 == null) {
						foreach (MonsterPack item9 in list_2) {
							bool flag5 = true;
							foreach (SnoMonsterAffix item10 in Monster_0.AffixSnoList) {
								if (!item9.List_0.Contains(item10)) {
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
						monsterPack2.MinionSnoMonster = Monster_0.SnoMonster;
					}
					monsterPack2.Class112_2.Remove(Monster_0.MaxHealth);
					if (Monster_0.CurHealth > 0.0) {
						monsterPack2.Class112_0[Monster_0.MaxHealth] = Monster_0;
					} else {
						monsterPack2.Class112_1[Monster_0.MaxHealth] = Monster_0;
					}
					monsterPack2.LastActive.Restart();
					Monster_0.Pack = monsterPack2;
				} else {
					string string_1 = string.Concat(Monster_0.AffixSnoList.Select((SnoMonsterAffix SnoMonsterAffix_0) => SnoMonsterAffix_0.NameLocalized));
					MonsterPack monsterPack4 = list_2.Find((MonsterPack imonsterPack_0) => (imonsterPack_0 as MonsterPack)?.String_0 == string_1 && imonsterPack_0.LeadSnoMonster == Monster_0.SnoMonster) as MonsterPack;
					if (monsterPack4 == null) {
						monsterPack4 = new MonsterPack {
							List_0 = Monster_0.AffixSnoList.ToList(),
							String_0 = string_1,
							IsFullChampionPack = (Monster_0.Rarity == ActorRarity.Champion),
							LeadSnoMonster = Monster_0.SnoMonster
						};
						list_2.Add(monsterPack4);
					}
					monsterPack4.Class112_2.Remove(Monster_0.MaxHealth);
					if (Monster_0.CurHealth > 0.0) {
						monsterPack4.Class112_0[Monster_0.MaxHealth] = Monster_0;
					} else {
						monsterPack4.Class112_1[Monster_0.MaxHealth] = Monster_0;
					}
					monsterPack4.LastActive.Restart();
					Monster_0.Pack = monsterPack4;
				}
			}
		}
		for (int num12 = list_2.Count - 1; num12 >= 0; num12--) {
			MonsterPack monsterPack5 = list_2[num12] as MonsterPack;
			if (monsterPack5.LastActive.ElapsedMilliseconds >= 60000 && monsterPack5.Class112_0.Int32_0 <= 0) {
				list_2.RemoveAt(num12);
			}
		}
		foreach (Actor item11 in list_3.Where((Actor iactor_0) => iactor_0.SnoActor.Kind == ActorKind.QuestActivate && iactor_0.SummonerId != 0)) {
			foreach (Monster item12 in list_1) {
				if (item12.SummonerAcdDynamicId == item11.SummonerId) {
					(item12 as Monster).IsQuestMonster = true;
				}
			}
		}
		try {
			EventHandler_0?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception_3) {
			Logger.LogException(exception_3.Message);
		}
		return true;
	}

	private static void smethod_0(r_ACD struct7_0, Monster Monster_0)
	{
		List<SnoMonsterAffix> list = Monster_0.AffixSnoList;
		list?.Clear();
		SnoMonsterAffix monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_0);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_1);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_2);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_3);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_4);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_5);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_6);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		monsterAffix = SnoData.Monsters.GetMonsterAffix(struct7_0.monster_affix_id_7);
		if (monsterAffix != null) {
			(list ?? (list = new List<SnoMonsterAffix>())).Add(monsterAffix);
		}
		if (list != null) {
			list.Sort((SnoMonsterAffix SnoMonsterAffix_0, SnoMonsterAffix SnoMonsterAffix_1) => SnoMonsterAffix_0.NameLocalized.CompareTo(SnoMonsterAffix_1.NameLocalized));
			Monster_0.AffixSnoList = list;
		}
	}

	private Actor method_4(uint uint_0, uint uint_1, SnoActor SnoActor_0, GizmoType gizmoType_0, uint uint_2)
	{
		if (SnoActor_0.Sno != ActorSnoEnum._a3dun_keep_bridge_switch && SnoActor_0.Sno != ActorSnoEnum._x1_westm_bridge && SnoActor_0.Sno != ActorSnoEnum._a3dun_keep_bridge_switch_b) {
			if (SnoActor_0.Sno == ActorSnoEnum._a3dun_keep_bridge) {
				return null;
			}
			if (SnoActor_0.Sno == ActorSnoEnum._caout_target_dummy) {
				return null;
			}
			if (SnoActor_0.Sno == ActorSnoEnum._trdun_crypt_skeleton_king_throne_parts) {
				return null;
			}
			SkillEffectRule skillEffectRule = SnoData.Actors.GetSkillEffectRule(SnoActor_0.Sno);
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
				return new SkillEffect(uint_0, uint_1, SnoActor_0, skillEffectRule);
			}
			ActorShrineTypeInfo actorShrineTypeInfo = SnoData.Actors.GetActorShrineTypeInfo(SnoActor_0.Sno);
			if (actorShrineTypeInfo != null) {
				return new Shrine(uint_0, uint_1, actorShrineTypeInfo);
			}
			if (SnoActor_0.Kind == ActorKind.Gold) {
				uint value = Convert.ToUInt32(CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gold, 1048575u, 0.0));
				return new Actor(uint_0, uint_1, SnoActor_0) {
					Amount = value
				};
			}
			if (SnoActor_0.Kind == ActorKind.QuestActivate) {
				return new MapObject(uint_0, uint_1, SnoActor_0) {
					SummonerId = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__summoner_id, 1048575u, 0u)
				};
			}
			if (SnoActor_0.Kind == ActorKind.HealthGlobe) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.PowerGlobe) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.RiftOrb) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.Stash) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.KanaiCube) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.Waypoint) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind == ActorKind.BookOfCain) {
				return new Actor(uint_0, uint_1, SnoActor_0);
			}
			if (SnoActor_0.Kind != ActorKind.Portal && gizmoType_0 != GizmoType.Portal) {
				if (SnoActor_0.Kind == ActorKind.Chest) {
					return new MapObject(uint_0, uint_1, SnoActor_0);
				}
				if (SnoActor_0.Kind == ActorKind.CursedEvent) {
					return new MapObject(uint_0, uint_1, SnoActor_0);
				}
				if (SnoActor_0.Kind == ActorKind.ChestNormal) {
					return new MapObject(uint_0, uint_1, SnoActor_0);
				}
				if (SnoActor_0.Kind != ActorKind.Obstacle && gizmoType_0 != GizmoType.BreakableDoor && gizmoType_0 != GizmoType.BreakableChest) {
					if (SnoActor_0.Kind == ActorKind.ArmorRack) {
						return new MapObject(uint_0, uint_1, SnoActor_0);
					}
					if (SnoActor_0.Kind == ActorKind.WeaponRack) {
						return new MapObject(uint_0, uint_1, SnoActor_0);
					}
					switch (gizmoType_0) {
						case GizmoType.Door:
							return new Door(uint_0, uint_1, SnoActor_0);
						case GizmoType.Headstone: {
								uint uint_3 = CoreCollector.ACDCollector.method_10(SnoData.Attributes.Map.Attribute__headstone_player_ann, 1048575u, 0u);
								Player iplayer_ = Array.Find(CoreCollector.PlayerCollector.PlayerSlots, (Player player) => player.IsInGame && player.AnnId == uint_3);
								return new HeadStone(uint_0, uint_1, SnoActor_0, uint_3, iplayer_);
							}
						default:
							if (SnoActor_0.Kind == ActorKind.DeadBody) {
								return new MapObject(uint_0, uint_1, SnoActor_0);
							}
							if (SnoActor_0.Kind == ActorKind.Banner) {
								return new TownBanner(uint_0, uint_1, SnoActor_0);
							}
							if (SnoActor_0.Kind == ActorKind.NoWalk) {
								return new Actor(uint_0, uint_1, SnoActor_0);
							}
							return gizmoType_0 switch {
								GizmoType.Chest => new MapObject(uint_0, uint_1, SnoActor_0),
								GizmoType.LoreChest => new MapObject(uint_0, uint_1, SnoActor_0),
								_ => null,
							};
					}
				}
				return new MonsterObstacle(uint_0, uint_1, SnoActor_0);
			}
			SnoArea snoArea = null;
			long ptr_portal_info = CoreCollector.ACDCollector.Buffer_ACDs[CoreCollector.ACDCollector.AcdIndexCur].ptr_portal_info;
			uint uint_4 = 0u;
			if (ptr_portal_info != 0L) {
				uint_4 = GameWindowManager.Read<uint>(ptr_portal_info);
				uint sno = GameWindowManager.Read<uint>(ptr_portal_info + 8);
				snoArea = SnoData.Areas.GetSnoArea(sno);
			}
			Portal @class = new(uint_0, uint_1, SnoActor_0, snoArea, uint_4);
			if (snoArea != null) {
				try {
					OnPortalFound?.Invoke(this, @class);
				} catch (Exception exception_) {
					Logger.LogException(exception_.Message);
				}
			}
			return @class;
		}
		return new Door(uint_0, uint_1, SnoActor_0);
	}

	private bool method_5(Actor class299_0)
	{
		if (class299_0.SnoActor.Sno == ActorSnoEnum._p1_lr_tieredrift_nephalem) {
			CoreCollector.ACDCollector.method_3(out var animSnoEnum_, out var _);
			if (animSnoEnum_ == AnimSnoEnum._p1_omninpc_female_lr_tieredrift_nephalem_idle_01) {
				IActor_1 = class299_0;
			}
		}
		if (class299_0.SnoActor.Sno == ActorSnoEnum._tyrael_heaven) {
			IActor_2 = class299_0;
		}
		if (class299_0.SnoActor.Sno == ActorSnoEnum._x1_openworld_lootrunobelisk_b) {
			IActor_3 = class299_0;
		}
		if ((class299_0.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep || class299_0.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep_reverse) && CoreCollector.ACDCollector.method_4() == AnimSnoEnum._arcaneenchanteddummy_death) {
			return false;
		}
		if (class299_0 is SkillEffect @class) {
			List<SkillEffect> list = Class112_0[@class.SkillEffectRule.Type];
			if (list == null) {
				list = new List<SkillEffect>();
				Class112_0.Set(@class.SkillEffectRule.Type, list);
			}
			list.Add(@class);
			return true;
		}
		if (class299_0 is Portal class2) {
			Class112_1[class2.AnnId] = class2;
			class2.ActorAvailable = true;
			class2.ActorLastAvailable.Restart();
			return true;
		}
		if (class299_0 is Shrine class3) {
			class3.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || class299_0.Boolean_0;
			class3.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			CoreCollector.Class412_0.method_3(class3);
			List_0.Add(class3);
			return true;
		}
		if (class299_0.SnoActor.Kind == ActorKind.CursedEvent) {
			class299_0.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			if (class299_0.IsOperated && class299_0.SnoActor.Sno == ActorSnoEnum._a1dun_leor_chest_rare_garrach && CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0) {
				class299_0.IsOperated = true;
			}
			return true;
		}
		if (class299_0 is MonsterObstacle) {
			if (class299_0.Hitpoints > 0f) {
				class299_0.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0;
				class299_0.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0;
				if (!class299_0.IsDisabled && !class299_0.IsOperated) {
					return true;
				}
				return false;
			}
			class299_0.Hitpoints = 0f;
			return false;
		}
		if (class299_0 is Door) {
			class299_0.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || class299_0.Boolean_0 || class299_0.Untargetable;
			class299_0.IsOperated = CoreCollector.ACDCollector.method_9(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0) == 1;
			if (class299_0.SnoActor.Sno == ActorSnoEnum._a1dunleor_interactive_door_locked_a || class299_0.SnoActor.Sno == ActorSnoEnum._a1dunleor_interactive_door_locked_b || class299_0.SnoActor.Sno == ActorSnoEnum._caout_stingingwinds_arena_bridge || class299_0.SnoActor.Sno == ActorSnoEnum._a4dun_spire_sigil_door_fate || class299_0.SnoActor.Sno == ActorSnoEnum._a1dun_leor_spike_trapdoor || class299_0.SnoActor.Sno == ActorSnoEnum._catapult_a3dunkeep_warmachines_snow_firing) {
				class299_0.IsDisabled = true;
			}
			if (!class299_0.IsDisabled && !class299_0.IsOperated) {
				List_2.Add(class299_0 as IClickableActor);
			}
			return true;
		}
		if (class299_0 is TownBanner) {
			TownBanner class4 = class299_0 as TownBanner;
			ITownBanner_0[class4.Index] = class4;
			class4.Usable = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Banner_Usable, 1048575u, 0.0) == 1.0;
		}
		if (class299_0 is HeadStone) {
			HeadStone item = class299_0 as HeadStone;
			List_1.Add(item);
			return true;
		}
		if (class299_0.SnoActor.Kind == ActorKind.QuestActivate) {
			class299_0.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || class299_0.Boolean_0 || class299_0.Untargetable;
			class299_0.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
			return true;
		}
		if (class299_0.IsClickable) {
			class299_0.IsDisabled = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || class299_0.Boolean_0;
			class299_0.IsOperated = CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.method_8(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
		}
		return true;
	}

	internal static void smethod_1(Actor class299_0, uint uint_0, uint uint_1)
	{
		if (class299_0.WorldId != uint_0 || class299_0.WorldSno == 0 || class299_0.Scene == null || class299_0.Scene.NavMeshId != uint_1) {
			smethod_2(class299_0, uint_0, uint_1);
		}
	}

	internal static void smethod_2(Actor class299_0, uint uint_0, uint uint_1)
	{
		class299_0.WorldId = uint_0;
		class299_0.WorldSno = CoreCollector.SceneCollector.method_2(class299_0.WorldId);
		class299_0.SnoWorld = SnoData.Worlds.GetWorld(class299_0.WorldSno);
		class299_0.Scene = CoreCollector.SceneCollector.method_1(class299_0.WorldId, uint_1);
	}

	public Actor method_6(ActorSnoEnum actorSnoEnum_0)
	{
		Actor actor = null;
		foreach (Actor item in list_3.Where((Actor iactor_0) => iactor_0.SnoActor.Sno == actorSnoEnum_0)) {
			if (actor == null || item.CentralXyDistanceToMe < actor.CentralXyDistanceToMe) {
				actor = item;
			}
		}
		return actor;
	}

	private unsafe void method_7(Player class310_0)
	{
		if (CoreCollector.IsLoading) {
			return;
		}
		List<Skill> list = class310_0.class386_0.Where((Skill class5) => class5 != null).Concat(new Skill[1] { class310_0.Powers.HealthPotionSkill as Skill }).ToList();
		class310_0.list_3.Clear();
		foreach (Skill item2 in list) {
			if (item2.IsOnCooldown) {
				class310_0.list_3.Add(item2);
			}
			item2.IsOnCooldown = false;
			item2.CooldownStartTick = 0;
			item2.CooldownFinishTick = 0;
		}
		foreach (Buff value in class310_0.powerSno2buff.Values) {
			(value as Buff).Active = false;
		}
		class310_0.ParagonPointsAvailableTotal = 0;
		Array.Clear(class310_0.ParagonPointsAvailable, 0, class310_0.ParagonPointsAvailable.Length);
		class310_0.int_13 = 0;
		class310_0.bool_17 = false;
		class310_0.method_58();
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
		class310_0.bool_13 = false;
		bool flag2 = false;
		int count = class310_0.list_0.Count;
		for (int num11 = 0; num11 < count; num11++) {
			r_AttributeEntry r_AttributeEntry2 = class310_0.list_0[num11];
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
						smethod_7(class310_0, num13, num14, 9, ref bool_);
						break;
					case "Gold_PickUp_Radius":
						class310_0.Stats.PickupRange = (float)Math.Floor(5.5f + num15);
						break;
					case "Buff_Icon_End_Tick8":
						smethod_7(class310_0, num13, num14, 8, ref bool_);
						break;
					case "Strength_Total":
						class310_0.Stats.Strength = (float)Math.Floor(num15);
						break;
					case "Damage_Dealt_Percent_Bonus":
						class310_0.Offense.ElementalDamageBonus[num13] = num15;
						if (num15 > class310_0.Offense.HighestElementalDamageBonus) {
							class310_0.Offense.HighestElementalDamageBonus = num15;
						}
						break;
					case "Health_Globe_Bonus_Health":
						class310_0.Defense.GlobeBonusHealth = (float)Math.Round(num15, 0);
						break;
					case "Alt_Experience_Next_Hi":
						num5 = (uint)num14;
						break;
					case "Rest_Experience_Lo":
						num8 = (uint)num14;
						break;
					case "Highest_Hero_Solo_Rift_Level":
						class310_0.HighestHeroSoloRiftLevel = num14;
						break;
					case "Gold_Find_Total":
						class310_0.Stats.GoldFind = (float)Math.Round(num15 * 100f, 0);
						break;
					case "Skill_Override_Active":
						class310_0.bool_13 = num14 == 1;
						break;
					case "Damage_Percent_Reduction_From_Elites":
						class310_0.Defense.DRElite = num15;
						break;
					case "Buff_Icon_Count30":
						smethod_3(class310_0, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_Count31":
						smethod_3(class310_0, num13, num14, 31, ref bool_);
						break;
					case "Highest_Solo_Rift_Level":
						class310_0.HighestSoloRiftLevel = num14;
						break;
					case "Buff_Icon_Count19":
						smethod_3(class310_0, num13, num14, 19, ref bool_);
						break;
					case "Looping_Animation_Start_Time":
						class310_0.LoopingAnimationStartTick = num14;
						break;
					case "Armor_Total":
						class310_0.Defense.Armor = (float)Math.Floor(num15);
						break;
					case "Resource_Cost_Reduction_Percent_Total":
						class310_0.float_5[num13] = num15;
						break;
					case "Buff_Icon_Count18":
						smethod_3(class310_0, num13, num14, 18, ref bool_);
						break;
					case "Resistance_Total":
						switch (num13) {
							case 0u:
								class310_0.Defense.ResPhysical = num15;
								break;
							case 1u:
								class310_0.Defense.ResFire = num15;
								break;
							case 2u:
								class310_0.Defense.ResLightning = num15;
								break;
							case 3u:
								class310_0.Defense.ResCold = num15;
								break;
							case 4u:
								class310_0.Defense.ResPoison = num15;
								break;
							case 5u:
								class310_0.Defense.ResArcane = num15;
								break;
						}
						if (num13 <= 5 && (class310_0.Defense.ResLowest == 0f || num15 < class310_0.Defense.ResLowest)) {
							class310_0.Defense.ResLowest = num15;
						}
						break;
					case "Paragon_Bonus":
						class310_0.class112_2[num13] = num14;
						break;
					case "CrowdControl_Reduction":
						class310_0.Defense.CCReduction = (float)Math.Round(num15 * 100f, 0);
						break;
					case "Damage_Bonus_Min":
						num3 = num15;
						break;
					case "Buff_Icon_Count12":
						smethod_3(class310_0, num13, num14, 12, ref bool_);
						break;
					case "Buff_Icon_Count13":
						smethod_3(class310_0, num13, num14, 13, ref bool_);
						break;
					case "Dexterity_Total":
						class310_0.Stats.Dexterity = (float)Math.Floor(num15);
						break;
					case "Hitpoints_On_Kill":
						class310_0.Defense.LifeOnKill = (float)Math.Floor(num15);
						break;
					case "Buff_Icon_Count11":
						smethod_3(class310_0, num13, num14, 11, ref bool_);
						break;
					case "Buff_Icon_Count28":
						smethod_3(class310_0, num13, num14, 28, ref bool_);
						break;
					case "Buff_Icon_Count26":
						smethod_3(class310_0, num13, num14, 26, ref bool_);
						break;
					case "Buff_Icon_Count10":
						smethod_3(class310_0, num13, num14, 10, ref bool_);
						break;
					case "Buff_Icon_Count29":
						smethod_3(class310_0, num13, num14, 29, ref bool_);
						break;
					case "Buff_Icon_Count16":
						smethod_3(class310_0, num13, num14, 16, ref bool_);
						break;
					case "Buff_Icon_Count27":
						smethod_3(class310_0, num13, num14, 27, ref bool_);
						break;
					case "Buff_Icon_Count17":
						smethod_3(class310_0, num13, num14, 17, ref bool_);
						break;
					case "Buff_Icon_Count25":
						smethod_3(class310_0, num13, num14, 25, ref bool_);
						break;
					case "Buff_Icon_Count15":
						smethod_3(class310_0, num13, num14, 15, ref bool_);
						break;
					case "Buff_Icon_Count24":
						smethod_3(class310_0, num13, num14, 24, ref bool_);
						break;
					case "Buff_Icon_Count22":
						smethod_3(class310_0, num13, num14, 22, ref bool_);
						break;
					case "Buff_Icon_Count14":
						smethod_3(class310_0, num13, num14, 14, ref bool_);
						break;
					case "Experience_Bonus_No_Penalty":
						class310_0.Stats.ExpOnKillNoPenalty = (float)Math.Round(num15, 0);
						break;
					case "Buff_Icon_Count21":
						smethod_3(class310_0, num13, num14, 21, ref bool_);
						break;
					case "Buff_Icon_Count20":
						smethod_3(class310_0, num13, num14, 20, ref bool_);
						break;
					case "Buff_Icon_Count23":
						smethod_3(class310_0, num13, num14, 23, ref bool_);
						break;
					case "Vitality_Total":
						class310_0.Stats.Vitality = (float)Math.Floor(num15);
						break;
					case "Hitpoints_Max_Total":
						if (num15 >= 0f && class310_0.Defense.HealthMax != num15) {
							class310_0.Defense.HealthMax = num15;
						}
						break;
					case "Hitpoints_Cur":
						if (num15 >= 0f) {
							class310_0.Defense.HealthCur = num15;
						}
						break;
					case "Damage_Percent_Bonus_Vs_Elites":
						class310_0.Offense.BonusToElitesBase = num15;
						break;
					case "DualWield_Hand_Next":
						class310_0.Offense.MainHandIsActive = num14 == 1;
						break;
					case "Level":
						class310_0.CurrentLevelNormal = (uint)num14;
						break;
					case "Damage_Weapon_Delta_Total_MainHand":
						if (num13 == 0) {
							class310_0.Offense.WeaponDamageAddPhysicalMainHand = num15;
						} else {
							class310_0.Offense.WeaponDamageAddElementalMainHand += num15;
						}
						break;
					case "Crit_Damage_Percent":
						class310_0.Offense.CritDamage += (float)Math.Round(num15 * 100f, 0);
						break;
					case "In_Combat":
						class310_0.InCombat = num14 == 1;
						break;
					case "Death_Count":
						num10 = num14;
						break;
					case "Hitpoints_Max_Percent_Bonus_Item":
						class310_0.Defense.LifeBonus = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Alt_Level":
						class310_0.CurrentLevelParagon = (uint)num14;
						flag2 = true;
						break;

					case "Power_Cooldown_Start":
						if (num14 > 0) {
							SnoPower bySno3 = SnoData.Powers.GetBySno(num13);

							if (bySno3 != null && class310_0.Powers.GetUsedSkill(bySno3) is Skill class3) {
								class3.CooldownStartTick = num14;
							}
						}
						break;

					case "Looping_Animation_End_Time":
						class310_0.LoopingAnimationEndTick = num14;
						break;

					case "Corpse_Resurrection_Charges":
						class310_0.int_13 = num14;
						break;

					case "Power_Damage_Percent_Bonus":
						class310_0.dictionary_5[num13] = num15;
						break;

					case "Attacks_Per_Second_Percent_Subtotal":
						class310_0.Offense.AttackSpeedPercent = num15 - 1f;
						break;

					case "Resource_Cost_Reduction_Percent_All":
						class310_0.Stats.ResourceCostReduction = num15;
						break;

					case "Buff_Icon_Start_Tick19":
						smethod_6(class310_0, num13, num14, 19, ref bool_);
						break;

					case "Damage_Percent_All_From_Skills":
						class310_0.Offense.WeaponDamageIncreasedBySkills = num15;
						break;

					case "Buff_Icon_Start_Tick18":
						smethod_6(class310_0, num13, num14, 18, ref bool_);
						break;

					case "Buff_Icon_Start_Tick10":
						smethod_6(class310_0, num13, num14, 10, ref bool_);
						break;

					case "Damage_Percent_Reduction_From_Ranged":
						class310_0.Defense.DRRanged = num15;
						break;

					case "Summoner_ID":
						class310_0.SummonerId = (uint)num14;
						break;

					case "Damage_Min":
						class310_0.Offense.DamageMin = num15;
						break;

					case "Movement_Scalar_Uncapped_Bonus":
						class310_0.Stats.MoveSpeedBonus = (float)Math.Round((num15 - 1f) * 100f, 1);
						break;

					case "Buff_Icon_Start_Tick11":
						smethod_6(class310_0, num13, num14, 11, ref bool_);
						break;

					case "Buff_Icon_Count8":
						smethod_3(class310_0, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick13":
						smethod_6(class310_0, num13, num14, 13, ref bool_);
						break;

					case "Buff_Icon_Start_Tick12":
						smethod_6(class310_0, num13, num14, 12, ref bool_);
						break;

					case "Buff_Icon_Start_Tick15":
						smethod_6(class310_0, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_Count9":
						smethod_3(class310_0, num13, num14, 9, ref bool_);
						break;

					case "Buff_Icon_Start_Tick14":
						smethod_6(class310_0, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_Start_Tick16":
						smethod_6(class310_0, num13, num14, 16, ref bool_);
						break;

					case "Attacks_Per_Second_Item_Total_OffHand":
						class310_0.Offense.WeaponSpeedOffHand = num15;
						break;

					case "Skill_Override":
						if (num13 <= 5) {
							Skill class2 = class310_0.class386_0[num13];

							if (class2 != null) {
								class2.OverrideSnoPower = ((num14 != -1)
									? SnoData.Powers.GetBySno((uint)num14)
									: null);
							}
						}
						break;

					case "Buff_Icon_Count0":
						smethod_3(class310_0, num13, num14, 0, ref bool_);
						break;
					case "Resource_Regen_Total":
						num15 = (float)Math.Round(num15, 2);
						switch (num13) {
							case 0u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									class310_0.Stats.ResourceRegMana = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 1u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									class310_0.Stats.ResourceRegArcane = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 2u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									class310_0.Stats.ResourceRegFury = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 3u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									class310_0.Stats.ResourceRegSpirit = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 5u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceRegHatred = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 6u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceRegDiscipline = num15;
									class310_0.Stats.ResourceRegSec = num15;
								}
								break;
							case 7u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									class310_0.Stats.ResourceRegWrath = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 8u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									class310_0.Stats.ResourceRegEssence = num15;
									class310_0.Stats.ResourceRegPri = num15;
								}
								break;
							case 4u:
								break;
						}
						break;
					case "Buff_Icon_Start_Tick17":
						smethod_6(class310_0, num13, num14, 17, ref bool_);
						break;

					case "Buff_Icon_Count2":
						smethod_3(class310_0, num13, num14, 2, ref bool_);
						break;

					case "Skill_From_Item":
						if (num14 == 1) {
							SnoPower bySno2 = SnoData.Powers.GetBySno(num13);

							if (bySno2 != null) {
								class310_0.list_2.Add(bySno2);
							}
						}
						break;

					case "Buff_Icon_Count1":
						smethod_3(class310_0, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Count5":
						smethod_3(class310_0, num13, num14, 5, ref bool_);
						break;

					case "Buff_Icon_Count4":
						smethod_3(class310_0, num13, num14, 4, ref bool_);
						break;

					case "Buff_Icon_Count3":
						smethod_3(class310_0, num13, num14, 3, ref bool_);
						break;

					case "Rest_Experience_Bonus_Percent":
						class310_0.BonusPoolPercent = num15 * 100f;
						break;

					case "Buff_Icon_Count7":
						smethod_3(class310_0, num13, num14, 7, ref bool_);
						break;

					case "Buff_Icon_Count6":
						smethod_3(class310_0, num13, num14, 6, ref bool_);
						break;

					case "Crit_Percent_Bonus_Capped":
						num2 = num15;
						break;

					case "Experience_Next_Lo":
						break;

					case "Paragon_Bonus_Points_Available":
						if (num13 < 4) {
							class310_0.ParagonPointsAvailable[num13] = num14;
							class310_0.ParagonPointsAvailableTotal += num14;
						}
						break;

					case "Buff_Icon_Start_Tick9":
						smethod_6(class310_0, num13, num14, 9, ref bool_);
						break;

					case "Stunned":
						class310_0.Powers.Stunned = num14 == 1;
						break;

					case "Damage_Weapon_Min_Total_MainHand":
						if (num13 == 0) {
							class310_0.Offense.WeaponDamageMinPhysicalMainHand += num15;
						} else {
							class310_0.Offense.WeaponDamageMinElementalMainHand += num15;
						}
						break;

					case "Damage_Percent_Reduction_From_Type":
						if (num13 <= 5) {
							class310_0.Defense.DamageReductionFromType[num13] = num15;
						}
						break;

					case "Frozen":
						class310_0.Powers.Frozen = num14 == 1;
						break;

					case "Buff_Icon_Start_Tick8":
						smethod_6(class310_0, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick3":
						smethod_6(class310_0, num13, num14, 3, ref bool_);
						break;

					case "Buff_Icon_Start_Tick0":
						smethod_6(class310_0, num13, num14, 0, ref bool_);
						break;

					case "Buff_Icon_Start_Tick1":
						smethod_6(class310_0, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Start_Tick5":
						smethod_6(class310_0, num13, num14, 5, ref bool_);
						break;

					case "Movement_Scalar_Total":
						class310_0.Stats.MoveSpeed = (float)Math.Round((num15 - 1f) * 100f, 1);
						break;

					case "Buff_Icon_Start_Tick2":
						smethod_6(class310_0, num13, num14, 2, ref bool_);
						break;

					case "Experience_Next_Hi":
						break;

					case "Buff_Icon_Start_Tick4":
						smethod_6(class310_0, num13, num14, 4, ref bool_);
						break;

					case "Thorns_Fixed":
						class310_0.Defense.Thorns = (float)Math.Round(num15, 0);
						break;

					case "Buff_Icon_Start_Tick6":
						smethod_6(class310_0, num13, num14, 6, ref bool_);
						break;

					case "Buff_Icon_Start_Tick7":
						smethod_6(class310_0, num13, num14, 7, ref bool_);
						break;

					case "Crit_Percent_Bonus_Uncapped":
						num = num15;
						break;

					case "Level_Cap":
						class310_0.CurrentLevelNormalCap = (uint)num14;
						break;

					case "Damage_Shield":
						flag = num14 == 1;
						break;
					case "Resource_Cur":
						switch (num13) {
							case 0u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									class310_0.Stats.ResourceCurMana = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 1u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									class310_0.Stats.ResourceCurArcane = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 2u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									class310_0.Stats.ResourceCurFury = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 3u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									class310_0.Stats.ResourceCurSpirit = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 5u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceCurHatred = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 6u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceCurDiscipline = num15;
									class310_0.Stats.ResourceCurSec = num15;
								}
								break;
							case 7u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									class310_0.Stats.ResourceCurWrath = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 8u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									class310_0.Stats.ResourceCurEssence = num15;
									class310_0.Stats.ResourceCurPri = num15;
								}
								break;
							case 4u:
								break;
						}
						break;
					case "Buff_Icon_End_Tick22":
						smethod_7(class310_0, num13, num14, 22, ref bool_);
						break;

					case "Buff_Icon_End_Tick21":
						smethod_7(class310_0, num13, num14, 21, ref bool_);
						break;

					case "Buff_Icon_End_Tick20":
						smethod_7(class310_0, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_End_Tick24":
						smethod_7(class310_0, num13, num14, 24, ref bool_);
						break;

					case "Damage_Percent_Reduction_From_Melee":
						class310_0.Defense.DRMelee = num15;
						break;

					case "Buff_Icon_End_Tick23":
						smethod_7(class310_0, num13, num14, 23, ref bool_);
						break;

					case "Buff_Icon_End_Tick26":
						smethod_7(class310_0, num13, num14, 26, ref bool_);
						break;

					case "Buff_Icon_End_Tick31":
						smethod_7(class310_0, num13, num14, 31, ref bool_);
						break;

					case "Buff_Icon_End_Tick25":
						smethod_7(class310_0, num13, num14, 25, ref bool_);
						break;

					case "Buff_Icon_End_Tick27":
						smethod_7(class310_0, num13, num14, 27, ref bool_);
						break;

					case "Magic_Find_Total":
						class310_0.Stats.MagicFind = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_End_Tick30":
						smethod_7(class310_0, num13, num14, 30, ref bool_);
						break;

					case "Buff_Icon_End_Tick19":
						smethod_7(class310_0, num13, num14, 19, ref bool_);
						break;

					case "Buff_Icon_End_Tick29":
						smethod_7(class310_0, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_End_Tick28":
						smethod_7(class310_0, num13, num14, 28, ref bool_);
						break;

					case "Buff_Icon_End_Tick18":
						smethod_7(class310_0, num13, num14, 18, ref bool_);
						break;

					case "Damage_Type_Cost_Reduction_Percent":
						class310_0.float_4[num13] = num15;
						break;

					case "Backpack_Slots":
						class310_0.InventorySpaceTotal = num14;
						break;

					case "Participating_In_Tiered_Loot_Run":
						class310_0.InGreaterRift = num14 == 1;
						break;

					case "Damage_Weapon_Min_Total_OffHand":
						if (num13 == 0) {
							class310_0.Offense.WeaponDamageMinPhysicalOffHand += num15;
						} else {
							class310_0.Offense.WeaponDamageMinElementalOffHand += num15;
						}
						break;

					case "Experience_Bonus":
						class310_0.Stats.ExpOnKill = (float)Math.Round(num15, 0);
						break;

					case "Crit_Percent_Base":
						class310_0.Offense.CritBase = num15;
						break;

					case "Buff_Icon_End_Tick11":
						smethod_7(class310_0, num13, num14, 11, ref bool_);
						break;

					case "Damage_Weapon_Delta_Total_OffHand":
						if (num13 == 0) {
							class310_0.Offense.WeaponDamageAddPhysicalOffHand = num15;
						} else {
							class310_0.Offense.WeaponDamageAddElementalOffHand += num15;
						}
						break;

					case "Buff_Icon_End_Tick13":
						smethod_7(class310_0, num13, num14, 13, ref bool_);
						break;

					case "Experience_Bonus_Percent_Total":
						class310_0.Stats.ExperiencePercentBonus = num15;
						break;

					case "Buff_Icon_End_Tick10":
						smethod_7(class310_0, num13, num14, 10, ref bool_);
						break;

					case "Buff_Icon_End_Tick14":
						smethod_7(class310_0, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_End_Tick15":
						smethod_7(class310_0, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_End_Tick12":
						smethod_7(class310_0, num13, num14, 12, ref bool_);
						break;

					case "Damage_Shield_Amount":
						class310_0.Defense.CurShield = num15;
						break;

					case "Attacks_Per_Second_Item_Total_MainHand":
						class310_0.Offense.WeaponSpeedMainHand = num15;
						break;

					case "Buff_Icon_End_Tick17":
						smethod_7(class310_0, num13, num14, 17, ref bool_);
						break;

					case "Shared_Stash_Slots":
						class310_0.Int32_2 = num14;
						break;

					case "Skill_Charges":
						class310_0.class112_0[num13] = num14;
						break;

					case "Buff_Icon_End_Tick16":
						smethod_7(class310_0, num13, num14, 16, ref bool_);
						break;

					case "Hitpoints_On_Hit":
						class310_0.Defense.LifeOnHit = (float)Math.Floor(num15);
						break;

					case "Power_Cooldown_Reduction_Percent_All":
						if (num13 == 1048575) {
							class310_0.Stats.CooldownReduction = num15;
						} else {
							class310_0.dictionary_4[num13] = num14;
						}
						break;

					case "Damage_Delta":
						num4 = num15;
						break;

					case "Buff_Icon_Start_Tick20":
						smethod_6(class310_0, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_Start_Tick21":
						smethod_6(class310_0, num13, num14, 21, ref bool_);
						break;

					case "Experience_Bonus_Percent_Super_Scalar_Total":
						num9 = num15;
						break;

					case "Buff_Icon_Start_Tick23":
						smethod_6(class310_0, num13, num14, 23, ref bool_);
						break;

					case "In_Tiered_Loot_Run_Level":
						class310_0.InGreaterRiftRank = (uint)(num14 + 1);
						break;

					case "Intelligence_Total":
						class310_0.Stats.Intelligence = (float)Math.Floor(num15);
						break;

					case "Buff_Icon_Start_Tick25":
						smethod_6(class310_0, num13, num14, 25, ref bool_);
						break;

					case "Damage_Reduction_Total":
						class310_0.Defense.DamageReduction = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_Start_Tick22":
						smethod_6(class310_0, num13, num14, 22, ref bool_);
						break;

					case "IsRooted":
						class310_0.Powers.Rooted = num14 == 1;
						break;

					case "Buff_Icon_Start_Tick27":
						smethod_6(class310_0, num13, num14, 27, ref bool_);
						break;

					case "Buff_Icon_Start_Tick24":
						smethod_6(class310_0, num13, num14, 24, ref bool_);
						break;

					case "Class_Damage_Reduction_Percent":
						class310_0.Defense.DRClass = num15;
						break;

					case "Buff_Icon_Start_Tick29":
						smethod_6(class310_0, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_Start_Tick26":
						smethod_6(class310_0, num13, num14, 26, ref bool_);
						break;

					case "Corpse_Resurrection_Disabled":
						class310_0.bool_17 = num14 == 1;
						break;

					case "Hitpoints_Regen_Per_Second_Total":
						class310_0.Defense.LifeRegen = num15;
						break;

					case "Buff_Icon_Start_Tick28":
						smethod_6(class310_0, num13, num14, 28, ref bool_);
						break;

					case "Rest_Experience_Hi":
						num7 = (uint)num14;
						break;

					case "Power_Resource_Reduction":
						class310_0.dictionary_3[num13] = num14;
						break;

					case "Splash_Damage_Effect_Percent":
						class310_0.Offense.AreaDamageBonus = (float)Math.Round(num15 * 100f, 1);
						break;

					case "Power_Cooldown":
						if (num14 > 0) {
							SnoPower bySno = SnoData.Powers.GetBySno(num13);

							if (bySno != null && class310_0.Powers.GetUsedSkill(bySno) is Skill @class) {
								@class.CooldownFinishTick = num14;
							}
						}
						break;
					case "Resource_Max_Total":
						switch (num13) {
							case 0u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor) {
									class310_0.Stats.ResourceMaxMana = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 1u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWizard) {
									class310_0.Stats.ResourceMaxArcane = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 2u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassBarbarian) {
									class310_0.Stats.ResourceMaxFury = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 3u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassMonk) {
									class310_0.Stats.ResourceMaxSpirit = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 5u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceMaxHatred = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 6u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
									class310_0.Stats.ResourceMaxDiscipline = num15;
									class310_0.Stats.ResourceMaxSec = num15;
								}
								break;
							case 7u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
									class310_0.Stats.ResourceMaxWrath = num15;
									class310_0.Stats.ResourceMaxPri = num15;
								}
								break;
							case 8u:
								if (class310_0.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
									class310_0.Stats.ResourceMaxEssence = num15;
									class310_0.Stats.ResourceMaxPri = num15;
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
						smethod_6(class310_0, num13, num14, 31, ref bool_);
						break;
					case "Buff_Icon_End_Tick2":
						smethod_7(class310_0, num13, num14, 2, ref bool_);
						break;
					case "Buff_Icon_Start_Tick30":
						smethod_6(class310_0, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_End_Tick1":
						smethod_7(class310_0, num13, num14, 1, ref bool_);
						break;
					case "Buff_Icon_End_Tick0":
						smethod_7(class310_0, num13, num14, 0, ref bool_);
						break;
					case "Buff_Icon_End_Tick3":
						smethod_7(class310_0, num13, num14, 3, ref bool_);
						break;
					case "Buff_Icon_End_Tick7":
						smethod_7(class310_0, num13, num14, 7, ref bool_);
						break;
					case "Buff_Icon_End_Tick6":
						smethod_7(class310_0, num13, num14, 6, ref bool_);
						break;
					case "Item_Power_Passive":
						class310_0.class112_1[num13] = num15;
						break;
					case "Attacks_Per_Second_Bonus":
						class310_0.Offense.AttackSpeedBonus = num15;
						break;
					case "Buff_Icon_End_Tick5":
						smethod_7(class310_0, num13, num14, 5, ref bool_);
						break;
					case "Buff_Icon_End_Tick4":
						smethod_7(class310_0, num13, num14, 4, ref bool_);
						break;
				}
			} catch {
			}
		}
		if (!flag) {
			class310_0.Defense.CurShield = 0f;
		}
		if (!class310_0.bool_13) {
			Skill[] class386_ = class310_0.class386_0;
			foreach (Skill class4 in class386_) {
				if (class4 != null) {
					class4.OverrideSnoPower = null;
				}
			}
		}
		if (class310_0.HeroClassDefinition == SnoData.Classes.ClassBarbarian || class310_0.HeroClassDefinition == SnoData.Classes.ClassCrusader) {
			class310_0.Stats.MainStat = class310_0.Stats.Strength;
		}
		if (class310_0.HeroClassDefinition == SnoData.Classes.ClassMonk || class310_0.HeroClassDefinition == SnoData.Classes.ClassDemonHunter) {
			class310_0.Stats.MainStat = class310_0.Stats.Dexterity;
		}
		if (class310_0.HeroClassDefinition == SnoData.Classes.ClassWitchDoctor || class310_0.HeroClassDefinition == SnoData.Classes.ClassWizard || class310_0.HeroClassDefinition == SnoData.Classes.ClassNecromancer) {
			class310_0.Stats.MainStat = class310_0.Stats.Intelligence;
		}
		if (class310_0.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_PierceTheVeil.Sno)) {
			class310_0.Stats.ResourceCostReduction = 1f - 1.3f * (1f - class310_0.Stats.ResourceCostReduction);
		}
		if (class310_0.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_BloodRitual.Sno)) {
			class310_0.Stats.ResourceCostReduction = 1f - 0.8f * (1f - class310_0.Stats.ResourceCostReduction);
		}
		Buff buff = class310_0.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Necromancer_Devour.Sno);
		if (buff != null && buff.Active && buff != null && buff.IconCounts[2] > 0) {
			class310_0.Stats.ResourceCostReduction = 1f - (1f - (float)buff.IconCounts[2] * 0.02f) * (1f - class310_0.Stats.ResourceCostReduction);
		}
		if (class310_0.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.Necromancer_LandOfTheDead.Sno, 3)) {
			class310_0.Stats.ResourceCostReduction = 1f;
		}
		if (class310_0.Defense.HealthCur == 0f && !class310_0.IsDead) {
			class310_0.LastDied.Restart();
		}
		class310_0.IsDead = class310_0.Defense.HealthCur == 0f;
		if (class310_0.IsDead) {
			CoreCollector.PlayerCollector.Boolean_0 = true;
			if (!class310_0.IsMe) {
				CoreCollector.PlayerCollector.Boolean_1 = true;
			}
		}
		if (num10 != class310_0.Int32_1) {
			if (class310_0.Defense.HealthCur <= 0f && num10 > class310_0.Int32_1 && class310_0.IsMe) {
				num10++;
				foreach (StatTracker item3 in CoreCollector.Trackers) {
					item3.Death++;
				}
			}
			class310_0.Int32_1 = num10;
		}
		class310_0.Defense.HealthPct = ((!(class310_0.Defense.HealthMax > 0f) || class310_0.Defense.HealthCur <= 0f) ? 0f : (class310_0.Defense.HealthCur / class310_0.Defense.HealthMax * 100f));
		class310_0.Offense.DamageMax = class310_0.Offense.DamageMin + num4;
		class310_0.Offense.DamageMin += num3;
		class310_0.Stats.ResourcePctArcane = ((!(class310_0.Stats.ResourceMaxArcane > 0f) || class310_0.Stats.ResourceCurArcane <= 0f) ? 0f : (class310_0.Stats.ResourceCurArcane / class310_0.Stats.ResourceMaxArcane * 100f));
		class310_0.Stats.ResourcePctSpirit = ((!(class310_0.Stats.ResourceMaxSpirit > 0f) || class310_0.Stats.ResourceCurSpirit <= 0f) ? 0f : (class310_0.Stats.ResourceCurSpirit / class310_0.Stats.ResourceMaxSpirit * 100f));
		class310_0.Stats.ResourcePctDiscipline = ((!(class310_0.Stats.ResourceMaxDiscipline > 0f) || class310_0.Stats.ResourceCurDiscipline <= 0f) ? 0f : (class310_0.Stats.ResourceCurDiscipline / class310_0.Stats.ResourceMaxDiscipline * 100f));
		class310_0.Stats.ResourcePctFury = ((!(class310_0.Stats.ResourceMaxFury > 0f) || class310_0.Stats.ResourceCurFury <= 0f) ? 0f : (class310_0.Stats.ResourceCurFury / class310_0.Stats.ResourceMaxFury * 100f));
		class310_0.Stats.ResourcePctHatred = ((!(class310_0.Stats.ResourceMaxHatred > 0f) || class310_0.Stats.ResourceCurHatred <= 0f) ? 0f : (class310_0.Stats.ResourceCurHatred / class310_0.Stats.ResourceMaxHatred * 100f));
		class310_0.Stats.ResourcePctMana = ((!(class310_0.Stats.ResourceMaxMana > 0f) || class310_0.Stats.ResourceCurMana <= 0f) ? 0f : (class310_0.Stats.ResourceCurMana / class310_0.Stats.ResourceMaxMana * 100f));
		class310_0.Stats.ResourcePctWrath = ((!(class310_0.Stats.ResourceMaxWrath > 0f) || class310_0.Stats.ResourceCurWrath <= 0f) ? 0f : (class310_0.Stats.ResourceCurWrath / class310_0.Stats.ResourceMaxWrath * 100f));
		class310_0.Stats.ResourcePctEssence = ((!(class310_0.Stats.ResourceMaxEssence > 0f) || class310_0.Stats.ResourceCurEssence <= 0f) ? 0f : (class310_0.Stats.ResourceCurEssence / class310_0.Stats.ResourceMaxEssence * 100f));
		class310_0.Stats.ResourcePctPri = ((!(class310_0.Stats.ResourceMaxPri > 0f) || class310_0.Stats.ResourceCurPri <= 0f) ? 0f : (class310_0.Stats.ResourceCurPri / class310_0.Stats.ResourceMaxPri * 100f));
		class310_0.Stats.ResourcePctSec = ((!(class310_0.Stats.ResourceMaxSec > 0f) || class310_0.Stats.ResourceCurSec <= 0f) ? 0f : (class310_0.Stats.ResourceCurSec / class310_0.Stats.ResourceMaxSec * 100f));
		class310_0.Offense.CriticalHitChance = (class310_0.Offense.CritBase + num + num2) * 100f;
		if (class310_0.Offense.WeaponDamageMinPhysicalOffHand == 0f && class310_0.Offense.WeaponDamageMinElementalOffHand == 0f) {
			class310_0.Offense.WeaponSpeedOffHand = 0f;
		}
		class310_0.Offense.AttackSpeedMainHand = (class310_0.Offense.WeaponSpeedMainHand + class310_0.Offense.AttackSpeedBonus) * (1f + class310_0.Offense.AttackSpeedPercent);
		if (class310_0.Offense.WeaponSpeedOffHand > 0f) {
			class310_0.Offense.AttackSpeedOffHand = (class310_0.Offense.WeaponSpeedOffHand + class310_0.Offense.AttackSpeedBonus) * (1f + class310_0.Offense.AttackSpeedPercent);
			class310_0.Offense.AttackSpeed = (class310_0.Offense.MainHandIsActive ? class310_0.Offense.AttackSpeedMainHand : class310_0.Offense.AttackSpeedOffHand);
		} else {
			class310_0.Offense.AttackSpeed = class310_0.Offense.AttackSpeedMainHand;
		}
		bool flag3 = class310_0.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.TaskerandTheo.Sno);
		class310_0.Offense.AttackSpeedPets = (flag3 ? (class310_0.Offense.AttackSpeed * (1f + class310_0.class112_1[318731u])) : class310_0.Offense.AttackSpeed);
		class310_0.Defense.ResAverage = (class310_0.Defense.ResPhysical + class310_0.Defense.ResFire + class310_0.Defense.ResLightning + class310_0.Defense.ResCold + class310_0.Defense.ResPoison + class310_0.Defense.ResArcane) / 6f;
		class310_0.Defense.AverageDamageReductionFromType = 0f;
		for (int num17 = 0; num17 < class310_0.Defense.DamageReductionFromType.Length; num17++) {
			class310_0.Defense.AverageDamageReductionFromType += class310_0.Defense.DamageReductionFromType[num17];
		}
		class310_0.Defense.AverageDamageReductionFromType /= class310_0.Defense.DamageReductionFromType.Length;
		float num18 = class310_0.CurrentLevelNormal;
		class310_0.Defense.drArmor = ((class310_0.Defense.Armor > 0f) ? (class310_0.Defense.Armor / (class310_0.Defense.Armor + num18 * 50f)) : 0f);
		class310_0.Defense.drResist = ((class310_0.Defense.ResAverage > 0f) ? (class310_0.Defense.ResAverage / (class310_0.Defense.ResAverage + num18 * 5f)) : 0f);
		float num19 = (1f - class310_0.Defense.drArmor) * (1f - class310_0.Defense.drResist) * (1f - class310_0.Defense.DRClass) * (1f - class310_0.Defense.DRElite);
		if (class310_0.Defense.AverageDamageReductionFromType > 0f) {
			num19 *= 1f - class310_0.Defense.AverageDamageReductionFromType;
		}
		if (class310_0.list_2.Any((SnoPower SnoPower_0) => SnoPower_0.Sno == 217968)) {
			num19 *= 0.85f;
		}
		Skill epiphany = class310_0.Powers.UsedMonkPowers.Epiphany;
		if (epiphany != null && epiphany.BuffIsActive && epiphany.Rune == 0) {
			num19 *= 0.5f;
		}
		Buff buff2 = class310_0.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_ShrineDesecratedBlessed.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.75f;
		}
		buff2 = class310_0.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Generic_ShrinePowerBlessed.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.75f;
		}
		buff2 = class310_0.Powers.GetBuff(Core.Controller.Sno.SnoPowers.SpiritGuards.Sno);
		if (buff2 != null && buff2.IconCounts[1] >= 1) {
			num19 *= 0.6f;
		}
		buff2 = class310_0.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Barbarian_IgnorePain.Sno);
		if (buff2 != null && buff2.Active) {
			num19 *= 0.5f;
		}
		buff2 = class310_0.Powers.GetBuff("P4_ItemPassive_Unique_Ring_014");
		if (buff2 != null && buff2.Active) {
			int num20 = 0;
			foreach (Item item4 in CoreCollector.ItemCollector.Items.Values) {
				if (item4.Location >= ItemLocation.Head && item4.Location <= ItemLocation.Neck && item4.AncientRank > 0) {
					num20++;
				}
			}
			if (num20 > 0) {
				float item = num20;
				class310_0.Offense.PlainDamageBonuses.Add((buff2.SnoPower, item));
			}
		}
		Skill callOfTheAncients = CoreCollector.LocalPlayer.Powers.UsedBarbarianPowers.CallOfTheAncients;
		if (callOfTheAncients != null && callOfTheAncients.BuffIsActive && callOfTheAncients.Rune == 4) {
			num19 *= 0.5f;
		}
		class310_0.Defense.drCombined = 1f - num19;
		float num21 = ((class310_0.Defense.drCombined != 1f) ? (class310_0.Defense.HealthMax / (1f - class310_0.Defense.drCombined)) : 0f);
		class310_0.Defense.EhpCur = ((class310_0.Defense.drCombined != 1f) ? (class310_0.Defense.HealthCur / (1f - class310_0.Defense.drCombined)) : 0f);
		if (class310_0.Defense.EhpMax != num21) {
			class310_0.Defense.EhpMax = num21;
		}
		class310_0.Stats.ExperiencePercentBonus *= 100f;
		if (num9 > 0f) {
			class310_0.Stats.ExperiencePercentBonus *= num9;
		}
		if (class310_0.CurrentLevelParagon + 1 >= SnoData.Experience.ParagonTableTotal.Length) {
			class310_0.CurrentLevelParagon = 0u;
		}
		class310_0.bool_14 = class310_0.CurrentLevelNormal != 0;
		if (CoreCollector.LocalPlayer.SnoArea != null && flag2 && class310_0.bool_14) {
			if (class310_0.CurrentLevelNormal != class310_0.CurrentLevelNormalCap || num5 == uint.MaxValue || !num6.HasValue) {
				goto IL_3e56;
			}
			if (num5 <= 0) {
				long? num22 = num6;
				if (!(num22 > 0L)) {
					goto IL_3e56;
				}
			}
			long num24 = SnoData.Experience.ParagonTableTotal[class310_0.CurrentLevelParagon];
			long num25 = SnoData.Experience.ParagonExpLevel[class310_0.CurrentLevelParagon + 1];
			long num26 = (num5 << 32) + num6.Value;
			long num27 = num25 - num26;
			long num28 = num24 + num27;
			if (num27 >= 0 && num25 >= 0) {
				class310_0.class362_0.Value = num28;
				if (class310_0.class362_0.Value == num28 && class310_0.ParagonTotalExp != num28) {
					class310_0.long_1 = num24;
					class310_0.ParagonExpToNextLevel = num25;
					class310_0.ParagonExpInThisLevel = num27;
					class310_0.ParagonTotalExp = num28;
					class310_0.CurrentLevelParagonDouble = (double)class310_0.CurrentLevelParagon + ((num25 > 0) ? ((double)num27 / (double)num25) : 0.0);
				}
			}
		}
		goto IL_3e9a;
	IL_3e56:
		class310_0.long_1 = 0L;
		class310_0.ParagonExpToNextLevel = 0L;
		class310_0.ParagonExpInThisLevel = 0L;
		class310_0.long_6 = 0L;
		class310_0.ParagonTotalExp = 0L;
		class310_0.class362_0.ForceSet(0L);
		class310_0.CurrentLevelParagonDouble = 0.0;
		goto IL_3e9a;
	IL_3e9a:
		class310_0.BonusPoolRemaining = (long)(((ulong)num7 << 32) + num8);
		foreach (Skill item5 in list) {
			item5.IsOnCooldown = item5.CooldownStartTick > 0 && item5.CooldownStartTick <= CoreCollector.D3Memory.GameTick && item5.CooldownFinishTick > CoreCollector.D3Memory.GameTick;
			if (item5.IsOnCooldown && !class310_0.list_3.Contains(item5) && item5.CurrentSnoPower != null) {
				try {
					CoreCollector.OnCooldown?.Invoke(class310_0, item5);
				} catch (Exception exception_) {
					Logger.LogException(exception_.Message);
				}
			}
		}
		for (int num29 = 0; num29 < class310_0.list_3.Count; num29++) {
			Skill playerSkill = class310_0.list_3[num29];
			if (!playerSkill.IsOnCooldown && playerSkill.CurrentSnoPower != null) {
				try {
					CoreCollector.OnTrueCooldown?.Invoke(class310_0, playerSkill);
				} catch (Exception exception_2) {
					Logger.LogException(exception_2.Message);
				}
			}
		}
		float num30 = class310_0.Offense.WeaponDamageMinPhysicalMainHand + class310_0.Offense.WeaponDamageAddPhysicalMainHand / 2f;
		float num31 = class310_0.Offense.WeaponDamageMinElementalMainHand + class310_0.Offense.WeaponDamageAddElementalMainHand / 2f;
		class310_0.Offense.WeaponBaseDamageMinAmainHand = class310_0.Offense.WeaponDamageMinPhysicalMainHand + class310_0.Offense.WeaponDamageMinElementalMainHand;
		class310_0.Offense.WeaponBaseDamageMaxAmainHand = class310_0.Offense.WeaponDamageMinPhysicalMainHand + class310_0.Offense.WeaponDamageAddPhysicalMainHand + class310_0.Offense.WeaponDamageMinElementalMainHand + class310_0.Offense.WeaponDamageAddElementalMainHand;
		class310_0.Offense.WeaponBaseDamageMinBmainHand = class310_0.Offense.WeaponDamageMinPhysicalMainHand + class310_0.Offense.DamageMin + class310_0.Offense.WeaponDamageMinElementalMainHand;
		class310_0.Offense.WeaponBaseDamageMaxBmainHand = class310_0.Offense.WeaponDamageMinPhysicalMainHand + class310_0.Offense.WeaponDamageAddPhysicalMainHand + class310_0.Offense.DamageMax + class310_0.Offense.WeaponDamageMinElementalMainHand + class310_0.Offense.WeaponDamageAddElementalMainHand;
		float num32 = class310_0.Offense.WeaponDamageMinPhysicalOffHand + class310_0.Offense.WeaponDamageAddPhysicalOffHand / 2f;
		float num33 = class310_0.Offense.WeaponDamageMinElementalOffHand + class310_0.Offense.WeaponDamageAddElementalOffHand / 2f;
		class310_0.Offense.WeaponBaseDamageMinAoffHand = class310_0.Offense.WeaponDamageMinPhysicalOffHand + class310_0.Offense.WeaponDamageMinElementalOffHand;
		class310_0.Offense.WeaponBaseDamageMaxAoffHand = class310_0.Offense.WeaponDamageMinPhysicalOffHand + class310_0.Offense.WeaponDamageAddPhysicalOffHand + class310_0.Offense.WeaponDamageMinElementalOffHand + class310_0.Offense.WeaponDamageAddElementalOffHand;
		class310_0.Offense.WeaponBaseDamageMinBoffHand = class310_0.Offense.WeaponDamageMinPhysicalOffHand + class310_0.Offense.DamageMin + class310_0.Offense.WeaponDamageMinElementalOffHand;
		class310_0.Offense.WeaponBaseDamageMaxBoffHand = class310_0.Offense.WeaponDamageMinPhysicalOffHand + class310_0.Offense.WeaponDamageAddPhysicalOffHand + class310_0.Offense.DamageMax + class310_0.Offense.WeaponDamageMinElementalOffHand + class310_0.Offense.WeaponDamageAddElementalOffHand;
		float num34 = (num30 + (class310_0.Offense.DamageMin + class310_0.Offense.DamageMax) / 2f + num31) * (1f + class310_0.Offense.CriticalHitChance / 100f * class310_0.Offense.CritDamage / 100f) * (1f + class310_0.Stats.MainStat / 100f) * (1f + class310_0.Offense.WeaponDamageIncreasedBySkills);
		class310_0.Offense.WeaponDamageMainHand = (float)Math.Round(num34, 2, MidpointRounding.ToEven);
		class310_0.Offense.SheetDpsMainHand = num34 * class310_0.Offense.AttackSpeedMainHand;
		if (class310_0.Offense.AttackSpeedOffHand > 0f) {
			float num35 = (num32 + (class310_0.Offense.DamageMin + class310_0.Offense.DamageMax) / 2f + num33) * (1f + class310_0.Offense.CriticalHitChance / 100f * class310_0.Offense.CritDamage / 100f) * (1f + class310_0.Stats.MainStat / 100f) * (1f + class310_0.Offense.WeaponDamageIncreasedBySkills);
			class310_0.Offense.WeaponDamageSecondHand = (float)Math.Round(num35, 2, MidpointRounding.ToEven);
			class310_0.Offense.SheetDpsOffHand = num35 * class310_0.Offense.AttackSpeedOffHand;
			class310_0.Offense.SheetDps = (num34 + num35) / 2f * (class310_0.Offense.AttackSpeedMainHand + class310_0.Offense.AttackSpeedOffHand) / 2f;
		} else {
			class310_0.Offense.SheetDps = class310_0.Offense.SheetDpsMainHand;
		}
		class310_0.float_6 = class310_0.Defense.LifeOnHit * class310_0.Offense.AttackSpeed + class310_0.Defense.LifeRegen;
	}

	internal static void smethod_3(Player class310_0, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		Buff buff = class310_0.Powers.GetBuff(uint_0) as Buff;
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(class310_0, bySno);
			class310_0.powerSno2buff.Add(uint_0, buff);
			class310_0.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.IconCounts[int_5] = int_4;
		if (int_4 > 0) {
			buff.Active = true;
			buff.FirstActive.Start();
			buff.LastActive.Restart();
		}
	}

	internal static void smethod_6(Player class310_0, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		double num = ((int_4 > 0) ? ((double)(CoreCollector.D3Memory.GameTick - int_4) / 60.0) : 0.0);
		Buff buff = class310_0.Powers.GetBuff(uint_0);
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(class310_0, bySno);
			class310_0.powerSno2buff.Add(uint_0, buff);
			class310_0.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.TimeElapsedSeconds[int_5] = num;
	}

	internal static void smethod_7(Player class310_0, uint uint_0, int int_4, int int_5, ref bool bool_4)
	{
		double num = ((int_4 > 0) ? ((double)(int_4 - CoreCollector.D3Memory.GameTick) / 60.0) : 0.0);
		Buff buff = class310_0.Powers.GetBuff(uint_0);
		if (buff == null) {
			SnoPower bySno = SnoData.Powers.GetBySno(uint_0);
			if (bySno == null) {
				return;
			}
			buff = new Buff(class310_0, bySno);
			class310_0.powerSno2buff.Add(uint_0, buff);
			class310_0.dictionary_1[bySno.Code] = buff;
			bool_4 = true;
		}
		buff.TimeLeftSeconds[int_5] = num;
	}
}
