using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace RiftAssistant.Collectors;

internal partial class ActorCollector
{
	private readonly Dictionary<uint, Actor> actorsByAcdId = new Dictionary<uint, Actor>(1000);

	public Stopwatch stopwatch = new();

	private Stopwatch stopwatch1 = new();

	public FollowerClass CurrentFollower;

	public List<Monster> Monsters = new List<Monster>();

	public List<Monster> AliveMonsters = new List<Monster>();

	public List<MonsterPack> MonsterPacks = new List<MonsterPack>();

	internal readonly PerSecCounter MonsterHitpointDecrease = new();

	public List<Actor> AllActors = new List<Actor>(1000);

	public Monster IMonster_0 { get; private set; }

	public Monster IMonster_1 { get; private set; }

	public Actor IActor_0 { get; private set; }

	public EventHandler EventHandler_0 { get; set; }

	public EventHandler<Monster> onMonsterKilled { get; set; }

	public EventHandler<Portal> OnPortalFound { get; set; }

	public bool[] Boolean_0 { get; } = new bool[5];

	public int Act { get; internal set; }

	public int Int32_1 { get; private set; }

	public bool IsEliteNearby { get; private set; }

	public bool IsEliteOnScreen { get; private set; }

	public MonsterPriority MonsterPriority_0 { get; private set; }

	public bool IsGoblinOnScreen { get; private set; }

	public Dictionary<SkillEffectType, List<SkillEffect>> SkillEffectsByType { get; } = new Dictionary<SkillEffectType, List<SkillEffect>>();

	public Dictionary<uint, Portal> PortalsByAnnId { get; } = new Dictionary<uint, Portal>();

	public List<Shrine> Shrines { get; } = new List<Shrine>();

	public List<HeadStone> HeadStones { get; } = new List<HeadStone>();

	public List<IClickableActor> Doors { get; } = new List<IClickableActor>();

	public TownBanner[] TownBanners { get; } = new TownBanner[4];

	public Actor IActor_1 { get; private set; }

	public Actor IActor_2 { get; private set; }

	public Actor IActor_3 { get; private set; }

	public WorldCoordinate IWorldCoordinate_0 { get; internal set; }

	public int Act2 { get; internal set; }

	internal r_Actor[] BufferActors { get; private set; }

	internal void ClearActors()
	{
		actorsByAcdId.Clear();
	}

	internal void ClearMonsters()
	{
		Monsters.Clear();
		AliveMonsters.Clear();
	}

	internal void ResetCollections(bool bool_4)
	{
		AllActors.Clear();
		Monsters.Clear();
		AliveMonsters.Clear();
		foreach (List<SkillEffect> item in SkillEffectsByType.Values) {
			item.Clear();
		}
		if (bool_4) {
			PortalsByAnnId.Clear();
		}
		Shrines.Clear();
		Doors.Clear();
		HeadStones.Clear();
		for (int i = 0; i < TownBanners.Length; i++) {
			TownBanners[i] = null;
		}
		CurrentFollower = null;
		IActor_1 = null;
		IActor_3 = null;
		IActor_2 = null;
	}

	internal unsafe bool Collect()
	{
		bool flag = stopwatch1.Elapsed.TotalMilliseconds >= 100.0;
		if (flag) {
			stopwatch1.Restart();
		}
		ResetCollections(bool_4: false);
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
		foreach (Portal item in PortalsByAnnId.Values) {
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
					Actor actor = actorsByAcdId.GetValueOrDefault(actorId);
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
							stopwatch.Restart();
							Act = CoreCollector.LocalPlayer.SnoArea.Act;
							Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
						}
					}
					try {
						onMonsterKilled?.Invoke(this, monster);
					} catch (Exception exception_) {
						Logger.LogException(exception_.ToString());
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
				Actor actor2 = actorsByAcdId.GetValueOrDefault(gparam_);
				SnoActor snoActor;
				if (actor2 == null) {
					snoActor = SnoData.Actors.GetActor(actorSnoEnum);
					if (snoActor == null) {
						continue;
					}
				} else {
					if (actor2.AcdId != acdid) {
						actor2.SetAcdId(acdid);
					}
					snoActor = actor2.SnoActor;
					if (snoActor.Sno != actorSnoEnum) {
						actor2 = null;
						actorsByAcdId.Remove(gparam_);
						snoActor = SnoData.Actors.GetActor(actorSnoEnum);
						if (snoActor == null) {
							continue;
						}
					}
				}
				if (!CoreCollector.ACDCollector.EnsureAttributeMap()) {
					continue;
				}
				if (snoActor.Kind == ActorKind.Follower) {
					if (actorSnoEnum == SnoData.Classes.FollowerEnchantress.ActorSno) {
						CurrentFollower = SnoData.Classes.FollowerEnchantress;
					}
					if (actorSnoEnum == SnoData.Classes.FollowerScoundrel.ActorSno) {
						CurrentFollower = SnoData.Classes.FollowerScoundrel;
					}
					if (actorSnoEnum == SnoData.Classes.FollowerTemplar.ActorSno) {
						CurrentFollower = SnoData.Classes.FollowerTemplar;
					}
				}
				uint sSceneID_Encrypted;
				uint sWorldID_Encrypted;
				if (snoActor.Kind == ActorKind.Player) {
					if (!(Array.Find(CoreCollector.PlayerCollector.PlayerSlots, (Player player0) => player0.AcdId == acdid) is Player player)) {
						continue;
					}
					player.attributeEntries.Clear();
					CoreCollector.ACDCollector.ReadAttributeEntries(player.attributeEntries);
					if (player.AcdId == uint.MaxValue) {
						player.ResetActor();
						break;
					}
					player.AnnId = struct7_.AnnId;
					player.CoordinateKnown = true;
					CoreCollector.ACDCollector.ReadAnimation(out var animSnoEnum_, out var acdAnimationState_);
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
					EnsureSceneContext(player, sWorldID_Encrypted, sSceneID_Encrypted);
					player.RadiusScaled = struct7_.CollisionRadius;
					player.RadiusBottom = ptr->BottomRadius;
					player.UpdateDistances();
					CollectPlayerAttributes(player);
					AllActors.Add(player);
					actorsByAcdId.Remove(gparam_);
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
					if (CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__Is_NPC, 1048575u, 0) == 1) {
						flag3 = false;
					}
					if (CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__Pet_Type, 1048575u) > 0) {
						flag3 = false;
					}
					int num8 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__TeamID, 1048575u);
					if (num8 == 2 || num8 == 1) {
						flag3 = false;
					}
				}
				if (!flag2) {
					bool num9 = actor2 == null || !(actor2?.SnoActor.IsStatic ?? false);
					uint num10 = CoreCollector.ACDCollector.ReadUIntAttribute(SnoData.Attributes.Map.Attribute__summoned_by_acdid, 1048575u, 0u);
					if (actor2 == null) {
						actor2 = CreateActor(gizmoType: (GizmoType)struct7_.GizmoType, acdid: acdid, annId: annId, snoActor: snoActor, uint_2: num10) ?? new Actor(acdid, annId, snoActor);
						actor2.CreatedAtInGameTick = ptr->CreationTick;
						actorsByAcdId[gparam_] = actor2;
					}
					actor2.GizmoType = (GizmoType)struct7_.GizmoType;
					actor2.SummonerAcdDynamicId = num10;
					actor2.Untargetable = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Untargetable, 1048575u, 0.0) == 1.0;
					actor2.Boolean_0 = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__gizmo_disabled_by_script, 1048575u, 0.0) == 1.0;
					actor2.attributeEntries.Clear();
					CoreCollector.ACDCollector.ReadAttributeEntries(actor2.attributeEntries);
					if (num9) {
						actor2.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
						actor2.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
						sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
						sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
						EnsureSceneContext(actor2, sWorldID_Encrypted, sSceneID_Encrypted);
						actor2.RadiusScaled = struct7_.CollisionRadius;
						actor2.RadiusBottom = ptr->BottomRadius;
					}
					actor2.UpdateDistances();
					actor2.Hitpoints = struct7_.HitPoints;
					actor2.IsSelected = ptr->IsSelected != uint.MaxValue;
					if (actor2.IsSelected) {
						IActor_0 = actor2;
					}
					if (TrackSpecialActor(actor2)) {
						AllActors.Add(actor2);
					}
					continue;
				}
				bool flag4 = flag || monster2 == null;
				if (monster2 != null && (monster2.IsElite || monster2.SnoMonster.Priority >= MonsterPriority.keywarden)) {
					flag4 = true;
				}
				double value = (flag4 ? CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Hitpoints_Max_Total, 1048575u, 0.0) : monster2.MaxHealth);
				double num11 = (flag4 ? CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Hitpoints_Cur, 1048575u, 1.0) : monster2.CurHealth);
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
								stopwatch.Restart();
								Act = CoreCollector.LocalPlayer.SnoArea.Act;
								Boolean_0[CoreCollector.LocalPlayer.SnoArea.Act - 1] = true;
							}
						}
						try {
							onMonsterKilled?.Invoke(this, monster2);
						} catch (Exception exception) {
							Logger.LogException(exception.ToString());
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
						SummonerAcdDynamicId = CoreCollector.ACDCollector.ReadUIntAttribute(SnoData.Attributes.Map.Attribute__summoned_by_acdid, 1048575u, 0u)
					};
					actorsByAcdId[gparam_] = monster2;
				}
				monster2.Rarity = actorRarity;
				monster2.IsElite = snoMonster2.IsUnique || actorRarity != ActorRarity.Normal;
				monster2.IsSelected = ptr->IsSelected != uint.MaxValue;
				if (monster2.IsSelected) {
					IActor_0 = monster2;
				}
				ReadMonsterAffixes(struct7_, monster2);
				monster2.attributeEntries.Clear();
				CoreCollector.ACDCollector.ReadAttributeEntries(monster2.attributeEntries);
				if (num11 < monster2.CurHealth) {
					num5 += monster2.CurHealth - num11;
				}
				monster2.MaxHealth = value;
				monster2.CurHealth = num11;
				monster2.CollisionCoordinate.Set(ptr->CollisionX, ptr->CollisionY, ptr->CollisionZ);
				monster2.FloorCoordinate.Set(ptr->BottomX, ptr->BottomY, ptr->BottomZ);
				sSceneID_Encrypted = struct7_.SSceneID_Encrypted;
				sWorldID_Encrypted = struct7_.SWorldID_Encrypted;
				EnsureSceneContext(monster2, sWorldID_Encrypted, sSceneID_Encrypted);
				monster2.RadiusScaled = struct7_.CollisionRadius;
				monster2.RadiusBottom = ptr->BottomRadius;
				monster2.CreatedAtInGameTick = ptr->CreationTick;
				monster2.UpdateDistances();
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
					monster2.Illusion = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, 264185u, 0.0) != 0.0;
					monster2.Frozen = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Frozen, 1048575u, 0.0) == 1.0;
					monster2.Chilled = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Chilled, 1048575u, 0.0) == 1.0;
					monster2.Slow = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Slow, 1048575u, 0.0) == 1.0;
					monster2.Stunned = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Stunned, 1048575u, 0.0) == 1.0;
					monster2.Untargetable = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Untargetable, 1048575u, 0.0) == 1.0;
					monster2.Invulnerable = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Invulnerable, 1048575u, 0.0) == 1.0;
					monster2.Burrowed = monster2.Untargetable || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Burrowed, 1048575u, 0.0) == 1.0;
					monster2.Stealthed = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Stealthed, 1048575u, 0.0) == 1.0;
					monster2.Blind = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Blind, 1048575u, 0.0) == 1.0;
					monster2.Bleeding = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Bleeding, 1048575u, 0.0) == 1.0;
					monster2.Hidden = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Hidden, 1048575u, 0.0) == 1.0;
					monster2.Invisible = monster2.Burrowed || monster2.Stealthed || monster2.Hidden;
					monster2.Palmed = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Monk_ExplodingPalm.Sno, 0.0) == 1.0;
					monster2.Haunted = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Haunt.Sno, 0.0) == 1.0;
					monster2.MarkedForDeath = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.DemonHunter_MarkedForDeath.Sno, 0.0) == 1.0;
					monster2.Locust = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_0_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_LocustSwarm.Sno, 0.0) == 1.0;
					monster2.Piranhas = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_A, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_3_Visual_Effect_B, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_C, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_5_Visual_Effect_D, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_6_Visual_Effect_E, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_1_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.WitchDoctor_Piranhas.Sno, 0.0) == 1.0;
					monster2.Cursed = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_DecrepifyPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_LeechPassiveEffect.Sno, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Necromancer_Passive_FrailtyPassiveEffect.Sno, 0.0) == 1.0;
					monster2.Strongarmed = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_2_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.StrongarmBracers.Sno, 0.0) == 1.0;
					monster2.Phoenixed = CoreCollector.ACDCollector.ReadDoubleAttribute(CoreCollector.Controller.Sno.Attributes.Power_Buff_4_Visual_Effect_None, CoreCollector.Controller.Sno.SnoPowers.Generic_ItemPassiveUniqueRing733x1.Sno, 0.0) == 1.0;
					monster2.DotDpsApplied = CoreCollector.ACDCollector.ReadFloatAttribute(CoreCollector.Controller.Sno.Attributes.DOT_DPS, 1048575u);
					if (monster2.SnoMonster.Priority >= MonsterPriority.keywarden || monster2.IsElite) {
						CoreCollector.ACDCollector.ReadAnimation(out var animSnoEnum, out var acdAnimationState);
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
				AllActors.Add(monster2);
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
		Monsters.Sort((Monster monster0, Monster monster1) => -((int)monster0.Rarity).CompareTo((int)monster1.Rarity));
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
					string concat = string.Concat(monster3.AffixSnoList.Select((SnoMonsterAffix snoMonsterAffix) => snoMonsterAffix.NameLocalized));
					MonsterPack monsterPack2 = MonsterPacks.Find((MonsterPack monsterPack) => (monsterPack as MonsterPack)?.String_1 == concat && monsterPack.MinionSnoMonster == monster3.SnoMonster) as MonsterPack;
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
						monsterPack2.String_1 = concat;
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
					MonsterPack monsterPack4 = MonsterPacks.Find((MonsterPack monsterPack0) => (monsterPack0 as MonsterPack)?.String_0 == string_1 && monsterPack0.LeadSnoMonster == monster3.SnoMonster) as MonsterPack;
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
		foreach (Actor item11 in AllActors.Where((Actor actor0) => actor0.SnoActor.Kind == ActorKind.QuestActivate && actor0.SummonerId != 0)) {
			foreach (Monster item12 in AliveMonsters) {
				if (item12.SummonerAcdDynamicId == item11.SummonerId) {
					(item12 as Monster).IsQuestMonster = true;
				}
			}
		}
		try {
			EventHandler_0?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception2) {
			Logger.LogException(exception2.ToString());
		}
		return true;
	}
}
