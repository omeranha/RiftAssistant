using System;
using System.Collections.Generic;

namespace RiftAssistant.Collectors;

internal partial class ActorCollector
{
	private static void ReadMonsterAffixes(r_ACD acd, Monster monster)
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

	private Actor CreateActor(uint acdid, uint annId, SnoActor snoActor, GizmoType gizmoType, uint uint_2)
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
					int num = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_a, 30680u);
					int num2 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_b, 30680u);
					int num3 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_c, 30680u);
					int num4 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_d, 30680u);
					int num5 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_e, 30680u);
					if (num == -1 && num2 == -1 && num3 == -1 && num4 == -1 && num5 == -1) {
						return null;
					}
				}
				if (skillEffectRule.Type == SkillEffectType.meteor) {
					int num6 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_a, 69190u);
					int num7 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_b, 69190u);
					int num8 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_c, 69190u);
					int num9 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_d, 69190u);
					int num10 = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__rune_e, 69190u);
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
				uint value = Convert.ToUInt32(CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gold, 1048575u, 0.0));
				return new Actor(acdid, annId, snoActor) {
					Amount = value
				};
			}
			if (snoActor.Kind == ActorKind.QuestActivate) {
				return new MapObject(acdid, annId, snoActor) {
					SummonerId = CoreCollector.ACDCollector.ReadUIntAttribute(SnoData.Attributes.Map.Attribute__summoner_id, 1048575u, 0u)
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
								uint uint_3 = CoreCollector.ACDCollector.ReadUIntAttribute(SnoData.Attributes.Map.Attribute__headstone_player_ann, 1048575u, 0u);
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

	private bool TrackSpecialActor(Actor actor)
	{
		if (actor.SnoActor.Sno == ActorSnoEnum._p1_lr_tieredrift_nephalem) {
			CoreCollector.ACDCollector.ReadAnimation(out var animSnoEnum_, out var _);
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
		if ((actor.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep || actor.SnoActor.Sno == ActorSnoEnum._monsteraffix_arcaneenchanted_petsweep_reverse) && CoreCollector.ACDCollector.ReadAnimSno() == AnimSnoEnum._arcaneenchanteddummy_death) {
			return false;
		}
		if (actor is SkillEffect skillEffect) {
			List<SkillEffect> list = SkillEffectsByType.GetValueOrDefault(skillEffect.SkillEffectRule.Type);
			if (list == null) {
				list = new List<SkillEffect>();
				SkillEffectsByType[skillEffect.SkillEffectRule.Type] = list;
			}
			list.Add(skillEffect);
			return true;
		}
		if (actor is Portal portal) {
			PortalsByAnnId[portal.AnnId] = portal;
			portal.ActorAvailable = true;
			portal.ActorLastAvailable.Restart();
			return true;
		}
		if (actor is Shrine shrine) {
			shrine.IsDisabled = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0;
			shrine.IsOperated = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			CoreCollector.MarkerCollector.UpdateShrineMarker(shrine);
			Shrines.Add(shrine);
			return true;
		}
		if (actor.SnoActor.Kind == ActorKind.CursedEvent) {
			actor.IsOperated = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0.0) == 1.0;
			if (actor.IsOperated && actor.SnoActor.Sno == ActorSnoEnum._a1dun_leor_chest_rare_garrach && CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0) {
				actor.IsOperated = true;
			}
			return true;
		}
		if (actor is MonsterObstacle) {
			if (actor.Hitpoints > 0f) {
				actor.IsDisabled = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0;
				actor.IsOperated = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0;
				if (!actor.IsDisabled && !actor.IsOperated) {
					return true;
				}
				return false;
			}
			actor.Hitpoints = 0f;
			return false;
		}
		if (actor is Door) {
			actor.IsDisabled = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0 || actor.Untargetable;
			actor.IsOperated = CoreCollector.ACDCollector.ReadIntAttribute(SnoData.Attributes.Map.Attribute__Gizmo_State, 1048575u, 0) == 1;
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
			townBanner.Usable = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Banner_Usable, 1048575u, 0.0) == 1.0;
		}
		if (actor is HeadStone) {
			HeadStone item = actor as HeadStone;
			HeadStones.Add(item);
			return true;
		}
		if (actor.SnoActor.Kind == ActorKind.QuestActivate) {
			actor.IsDisabled = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0 || actor.Untargetable;
			actor.IsOperated = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
			return true;
		}
		if (actor.IsClickable) {
			actor.IsDisabled = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Deleted_On_Server, 1048575u, 0.0) == 1.0 || actor.Boolean_0;
			actor.IsOperated = CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Gizmo_Has_Been_Operated, 1048575u, 0.0) == 1.0 || CoreCollector.ACDCollector.ReadDoubleAttribute(SnoData.Attributes.Map.Attribute__Chest_Open, 1048575u, 0.0) == 1.0;
		}
		return true;
	}

	internal static void EnsureSceneContext(Actor player, uint sWorldIDEncrypted, uint sSceneIDEncrypted)
	{
		if (player.WorldId != sWorldIDEncrypted || player.WorldSno == 0 || player.Scene == null || player.Scene.NavMeshId != sSceneIDEncrypted) {
			UpdateSceneContext(player, sWorldIDEncrypted, sSceneIDEncrypted);
		}
	}

	internal static void UpdateSceneContext(Actor player, uint worldId, uint sSceneIDEncrypted)
	{
		player.WorldId = worldId;
		player.WorldSno = CoreCollector.SceneCollector.GetWorldSno(player.WorldId);
		player.SnoWorld = SnoData.Worlds.GetWorld(player.WorldSno);
		player.Scene = CoreCollector.SceneCollector.GetScene(player.WorldId, sSceneIDEncrypted);
	}
}
