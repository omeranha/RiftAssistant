#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;


namespace RiftAssistant.Collectors;

internal class PlayerCollector
{
	public Stopwatch stopwatch = new();

	private Stopwatch stopwatch1 = new();

	public Player[] PlayerSlots { get; } = new Player[4];

	public IEnumerable<Player> PlayersInGame => PlayerSlots.Where((Player player) => player.IsInGame && player.SnoArea != null && player.BattleTagAbovePortrait != null && player.HeroClassDefinition != null);

	public int NumberOfPlayersInGame { get; private set; }

	public bool Boolean_0 { get; set; }

	public bool Boolean_1 { get; set; }

	public PlayerCollector()
	{
		for (int i = 0; i < PlayerSlots.Length; i++) {
			PlayerSlots[i] = new Player(i);
		}
	}

	internal void ResetPlayers()
	{
		NumberOfPlayersInGame = 0;
		Player[] iPlayer_ = PlayerSlots;
		for (int i = 0; i < iPlayer_.Length; i++) {
			Player player = (Player)iPlayer_[i];
			player.ParagonTotalExp2 = 0L;
			player.ParagonTotalExp = 0L;
			player.class362_0.ForceSet(0L);
			player.ResetHero();
		}
	}

	internal unsafe bool Collect(bool force_collect_armory)
	{
		Boolean_0 = false;
		Boolean_1 = false;
		bool flag;
		if (flag = force_collect_armory || stopwatch1.ElapsedMilliseconds >= 333) {
			stopwatch1.Restart();
		}
		try {
			CoreCollector.LocalPlayer = PlayerSlots[CoreCollector.D3Memory.LocalPlayerIndex] as Player;
			int num = 0;
			NumberOfPlayersInGame = 0;
			bool flag2;
			if (flag2 = stopwatch.ElapsedMilliseconds >= 1000) {
				stopwatch.Restart();
			}
			for (int num2 = 0; num2 < PlayerSlots.Length; num2++) {
				Player player = PlayerSlots[num2] as Player;
				long num3 = CoreCollector.DAF.PlayerDataManagerAddress + D3Memory.Offset_PlayerDataManager_Elements + num2 * Constants.PlayerData_SizeOf;
				bool isInGame = player.IsInGame;
				uint heroId = player.HeroId;
				player.RawPlayerData = GameWindowManager.Read<r_PlayerData>(num3, size: Constants.PlayerData_SizeOf);
				player.CoordinateKnown = false;
				if (player.IsInGame) {
					player.Defense.HealthPct = player.RawPlayerData.LifePercentage * 100f;
					if (player.RawPlayerData.LifePercentage == 0f && !player.IsDead) {
						player.LastDied.Restart();
					}
					player.IsDead = player.RawPlayerData.LifePercentage == 0f;
					if (player.IsDead) {
						CoreCollector.PlayerCollector.Boolean_0 = true;
						if (!player.IsMe) {
							CoreCollector.PlayerCollector.Boolean_1 = true;
						}
					}
					if (player.Materials.Gold > 1) {
						if (player.Materials.Gold >= player.Gold) {
							long num4 = player.Materials.Gold - player.Gold;
							if (num4 > 0 && num4 < 100000000 && player.Gold > 0) {
								foreach (StatTracker item in CoreCollector.Trackers) {
									item.GainedGold += num4;
								}
							}
						}
						player.Gold = player.Materials.Gold;
					}
					NumberOfPlayersInGame++;
					if (!player.IsMe) {
						num++;
					}
					player.PortraitIndex = ((!player.IsMe) ? num : 0);
					if (string.IsNullOrEmpty(player.BattleTagAbovePortrait) || flag2) {
						UiElement temporary = CoreCollector.UiElements.CreateTemporary("Root.NormalLayer.portraits.stack.party_stack.portrait_" + player.PortraitIndex.ToString("D", CultureInfo.InvariantCulture) + ".text");
						player.BattleTagAbovePortrait = temporary.ReadText(Encoding.UTF8, removeColors: true);
						string? battleTagAbovePortrait = player.BattleTagAbovePortrait;
						if (battleTagAbovePortrait != null && battleTagAbovePortrait.Contains("\n")) {
							player.BattleTagAbovePortrait = player.BattleTagAbovePortrait.Substring(player.BattleTagAbovePortrait.IndexOf("\n") + 1);
						}
						player.bool_8 = true;
					}
					if (!isInGame && player.IsMe) {
						CoreCollector.FloatingNumberManager.Clear(player);
					}
					for (ActionKey actionKey = ActionKey.LeftSkill; actionKey <= ActionKey.Skill4; actionKey++) {
						Skill skill = player.SkillSlots[(int)actionKey];
						SnoPower? snoPower = skill?.SnoPower;
						uint num5 = 0u;
						int num6 = 0;
						switch (actionKey) {
							case ActionKey.LeftSkill:
								num5 = player.RawPlayerData.activeSkillSavedData.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData.int_0;
								break;
							case ActionKey.RightSkill:
								num5 = player.RawPlayerData.activeSkillSavedData1.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData1.int_0;
								break;
							case ActionKey.Skill1:
								num5 = player.RawPlayerData.activeSkillSavedData2.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData2.int_0;
								break;
							case ActionKey.Skill2:
								num5 = player.RawPlayerData.activeSkillSavedData3.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData3.int_0;
								break;
							case ActionKey.Skill3:
								num5 = player.RawPlayerData.activeSkillSavedData4.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData4.int_0;
								break;
							case ActionKey.Skill4:
								num5 = player.RawPlayerData.activeSkillSavedData5.uint_0;
								num6 = player.RawPlayerData.activeSkillSavedData5.int_0;
								break;
						}
						if (num6 == -1) {
							num6 = 255;
						}
						if (snoPower == null || snoPower.Sno != num5 || skill.Rune != num6) {
							snoPower = SnoData.Powers.GetBySno(num5);
							player.SkillSlots[(int)actionKey] = ((snoPower == null) ? null : new Skill(player, snoPower, (byte)num6, actionKey));
						}
					}
					player.UsedPassives.Clear();
					fixed (r_PlayerData* pData = &player.RawPlayerData) {
						uint* struct33_ = pData->struct33_0;
						for (int i = 0; i < 4; i++) {
							uint sno = struct33_[i];
							SnoPower? bySno = SnoData.Powers.GetBySno(sno);
							if (player.SnoPowers0[i] != bySno) {
								player.SnoPowers0[i] = bySno;
							}
							if (bySno != null) {
								player.UsedPassives.Add(bySno);
							}
						}
					}
					if (flag) {
						fixed (r_PlayerData* pData2 = &player.RawPlayerData) {
							(player.ArmorySets[0] as PlayerArmorySet).Name = DecodeString(pData2->armorySet.struct29_0, 52);
							(player.ArmorySets[1] as PlayerArmorySet).Name = DecodeString(pData2->armorySet1.struct29_0, 52);
							(player.ArmorySets[2] as PlayerArmorySet).Name = DecodeString(pData2->armorySet2.struct29_0, 52);
							(player.ArmorySets[3] as PlayerArmorySet).Name = DecodeString(pData2->armorySet3.struct29_0, 52);
							(player.ArmorySets[4] as PlayerArmorySet).Name = DecodeString(pData2->armorySet4.struct29_0, 52);
							(player.ArmorySets[5] as PlayerArmorySet).Name = DecodeString(pData2->armorySet5.struct29_0, 52);
							(player.ArmorySets[6] as PlayerArmorySet).Name = DecodeString(pData2->armorySet6.struct29_0, 52);
							(player.ArmorySets[7] as PlayerArmorySet).Name = DecodeString(pData2->armorySet7.struct29_0, 52);
							(player.ArmorySets[8] as PlayerArmorySet).Name = DecodeString(pData2->armorySet8.struct29_0, 52);
							(player.ArmorySets[9] as PlayerArmorySet).Name = DecodeString(pData2->armorySet9.struct29_0, 52);
						}
						(player.ArmorySets[0] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet;
						(player.ArmorySets[1] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet1;
						(player.ArmorySets[2] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet2;
						(player.ArmorySets[3] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet3;
						(player.ArmorySets[4] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet4;
						(player.ArmorySets[5] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet5;
						(player.ArmorySets[6] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet6;
						(player.ArmorySets[7] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet7;
						(player.ArmorySets[8] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet8;
						(player.ArmorySets[9] as PlayerArmorySet).ArmorySet = player.RawPlayerData.armorySet9;
						for (int j = 0; j < 10; j++) {
							PlayerArmorySet playerArmorySet = player.ArmorySets[j] as PlayerArmorySet;
							playerArmorySet.itemAnnIds.Clear();
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem1.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem2.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem3.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem4.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem5.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem6.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem7.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem8.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem9.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem10.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem11.uint_0);
							playerArmorySet.AddItemAnnId(playerArmorySet.ArmorySet.armoryItem12.uint_0);
						}
					}
					uint heroId2 = player.RawPlayerData.HeroId;
					if (heroId2 != 0 && heroId2 != uint.MaxValue) {
						if (heroId != heroId2) {
							player.HeroId = heroId2;
							Hero? hero = (player.Hero = (player.IsMe ? CoreCollector.HeroCollector.GetHero(heroId2) : null));
							if (hero != null) {
								player.HeroName = hero.Name;
								player.Season = hero.Season;
								player.HeroIsHardcore = hero.Hardcore;
								player.HeroIsMale = hero.IsMale;
								player.Seasonal = hero.Seasonal;
							} else {
								fixed (r_PlayerData* pData3 = &player.RawPlayerData) {
									player.HeroName = new string(pData3->struct35_0) ?? "";
								}
								player.Season = 0;
								player.HeroIsHardcore = false;
								player.HeroIsMale = true;
							}
							if (string.IsNullOrEmpty(player.HeroName)) {
								if (!player.IsMe) {
									player.ResetHero();
									continue;
								}
								return false;
							}
						}
						HeroClassDefinition? heroClassByInternalIndex = SnoData.Classes.GetHeroClassByInternalIndex(player.RawPlayerData.HeroClass);
						if (heroClassByInternalIndex != null) {
							player.HeroClassDefinition = heroClassByInternalIndex;
							Custom.SetSnoAreaForPlayer(player);
							if (player.SnoArea == null && player.IsMe) {
								return false;
							}
							uint acdIdEncrypted = player.RawPlayerData.AcdIdEncrypted;
							uint actorIdEncrypted = player.RawPlayerData.ActorIdEncrypted;
							player.SetAcdId(acdIdEncrypted);
							player.ActorId = actorIdEncrypted;
							if (!player.HasValidActor) {
								player.ResetActor();
								if (player.IsMe) {
									return false;
								}
							} else {
								uint usedKanaiItemSno = player.RawPlayerData.UsedKanaiItemSno1;
								if (player.CubeSnoItem1 == null || player.CubeSnoItem1.Sno != usedKanaiItemSno) {
									player.CubeSnoItem1 = ((usedKanaiItemSno == uint.MaxValue) ? null : SnoData.Items.GetBySno(usedKanaiItemSno));
								}
								usedKanaiItemSno = player.RawPlayerData.UsedKanaiItemSno2;
								if (player.CubeSnoItem2 == null || player.CubeSnoItem2.Sno != usedKanaiItemSno) {
									player.CubeSnoItem2 = ((usedKanaiItemSno == uint.MaxValue) ? null : SnoData.Items.GetBySno(usedKanaiItemSno));
								}
								usedKanaiItemSno = player.RawPlayerData.UsedKanaiItemSno3;
								if (player.CubeSnoItem3 == null || player.CubeSnoItem3.Sno != usedKanaiItemSno) {
									player.CubeSnoItem3 = ((usedKanaiItemSno == uint.MaxValue) ? null : SnoData.Items.GetBySno(usedKanaiItemSno));
								}
								usedKanaiItemSno = player.RawPlayerData.UsedKanaiItemSno4;
								if (player.CubeSnoItem4 == null || player.CubeSnoItem4.Sno != usedKanaiItemSno) {
									player.CubeSnoItem4 = ((usedKanaiItemSno == uint.MaxValue) ? null : SnoData.Items.GetBySno(usedKanaiItemSno));
								}
								ulong num7 = 0uL;
								fixed (r_PlayerData* pData4 = &player.RawPlayerData) {
									uint* struct34_ = pData4->struct34_0;
									for (int k = 0; k < 512; k++) {
										uint num8 = struct34_[k];
										num7 += num8;
									}
								}
								if (num7 != player.ulong_0) {
									player.ulong_0 = num7;
									player.cubedItems.Clear();
									player.snoItemsByKey.Clear();
									fixed (r_PlayerData* pData5 = &player.RawPlayerData) {
										uint* struct34_2 = pData5->struct34_0;
										for (int l = 0; l < 512; l++) {
											uint num9 = struct34_2[l];
											if (num9 != uint.MaxValue) {
												SnoItem? bySno2 = SnoData.Items.GetBySno(num9);
												if (bySno2 != null) {
													player.cubedItems.Add(bySno2);
													player.snoItemsByKey[bySno2.NameLocalized] = bySno2;
												}
											}
										}
									}
								}
								if (player.ParagonTotalExp > 0 && player.bool_14 && player.HasValidActor && player.FloorCoordinate.IsValid && player.bool_8 && CoreCollector.RunTracker != null && player.SnoArea != null) {
									if (player.ParagonTotalExp2 > 0 && player.ParagonTotalExp2 < player.ParagonTotalExp) {
										long num10 = player.ParagonTotalExp - player.ParagonTotalExp2;
										if (num10 != 0L && player.IsMe) {
											foreach (StatTracker item2 in CoreCollector.Trackers) {
												item2.GainedExperience += num10;
											}
										}
									}
									player.ParagonTotalExp2 = player.ParagonTotalExp;
								}
							}
						} else {
							if (player.IsMe) {
								return false;
							}
							player.ResetHero();
						}
					} else {
						if (player.IsMe) {
							return false;
						}
						player.ResetHero();
					}
				} else {
					if (player.IsMe) {
						CoreCollector.FloatingNumberManager.Clear(player);
						return false;
					}
					player.ResetHero();
				}
			}
			return true;
		} catch (Exception exception_) {
			Logger.LogException(exception_.ToString());
		}
		return false;
	}

	private unsafe string DecodeString(sbyte* pSbyte_0, int int_1)
	{
		string text = new string(pSbyte_0, 0, int_1, Encoding.UTF8);
		int num = text.IndexOf('\0');
		if (num != -1) {
			return text.Remove(num).Trim();
		}
		return text;
	}
}
