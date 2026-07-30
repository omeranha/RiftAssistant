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

internal class PlayerCollector
{
	public Stopwatch stopwatch_0 = new();

	private Stopwatch stopwatch_1 = new();

	[CompilerGenerated]
	private readonly Player[] iplayer_0 = new Player[4];

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	public Player[] PlayerSlots
	{
		[CompilerGenerated]
		get {
			return iplayer_0;
		}
	}

	public IEnumerable<Player> PlayersInGame => PlayerSlots.Where((Player iplayer_0) => iplayer_0.IsInGame && iplayer_0.SnoArea != null && iplayer_0.BattleTagAbovePortrait != null && iplayer_0.HeroClassDefinition != null);

	public int NumberOfPlayersInGame
	{
		[CompilerGenerated]
		get {
			return int_0;
		}
		[CompilerGenerated]
		private set {
			int_0 = value;
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get {
			return bool_0;
		}
		[CompilerGenerated]
		set {
			bool_0 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get {
			return bool_1;
		}
		[CompilerGenerated]
		set {
			bool_1 = value;
		}
	}

	public PlayerCollector()
	{
		for (int i = 0; i < PlayerSlots.Length; i++) {
			PlayerSlots[i] = new Player(i);
		}
	}

	internal void method_0()
	{
		NumberOfPlayersInGame = 0;
		Player[] iPlayer_ = PlayerSlots;
		for (int i = 0; i < iPlayer_.Length; i++) {
			Player obj = (Player)iPlayer_[i];
			obj.long_6 = 0L;
			obj.ParagonTotalExp = 0L;
			obj.class362_0.ForceSet(0L);
			obj.method_59();
		}
	}

	internal unsafe bool Collect(bool force_collect_armory)
	{
		Boolean_0 = false;
		Boolean_1 = false;
		bool flag;
		if (flag = force_collect_armory || stopwatch_1.ElapsedMilliseconds >= 333) {
			stopwatch_1.Restart();
		}
		try {
			CoreCollector.LocalPlayer = PlayerSlots[CoreCollector.D3Memory.LocalPlayerIndex] as Player;
			int num = 0;
			NumberOfPlayersInGame = 0;
			bool flag2;
			if (flag2 = stopwatch_0.ElapsedMilliseconds >= 1000) {
				stopwatch_0.Restart();
			}
			int num2 = 0;
			Player player;
			while (true) {
				if (num2 < PlayerSlots.Length) {
					player = PlayerSlots[num2] as Player;
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
							if (player.Materials.Gold >= player.long_0) {
								long num4 = player.Materials.Gold - player.long_0;
								if (num4 > 0 && num4 < 100000000 && player.long_0 > 0) {
									foreach (StatTracker item in CoreCollector.Trackers) {
										item.GainedGold += num4;
									}
								}
							}
							player.long_0 = player.Materials.Gold;
						}
						NumberOfPlayersInGame++;
						if (!player.IsMe) {
							num++;
						}
						player.PortraitIndex = ((!player.IsMe) ? num : 0);
						if (string.IsNullOrEmpty(player.BattleTagAbovePortrait) || flag2) {
							UiElement @class = CoreCollector.UiElements.CreateTemporary("Root.NormalLayer.portraits.stack.party_stack.portrait_" + player.PortraitIndex.ToString("D", CultureInfo.InvariantCulture) + ".text");
							player.BattleTagAbovePortrait = @class.ReadText(Encoding.UTF8, removeColors: true);
							string battleTagAbovePortrait = player.BattleTagAbovePortrait;
							if (battleTagAbovePortrait != null && battleTagAbovePortrait.Contains("\n")) {
								player.BattleTagAbovePortrait = player.BattleTagAbovePortrait.Substring(player.BattleTagAbovePortrait.IndexOf("\n") + 1);
							}
							player.bool_8 = true;
						}
						if (!isInGame && player.IsMe) {
							CoreCollector.Class335_0.Clear(player);
						}
						for (ActionKey actionKey = ActionKey.LeftSkill; actionKey <= ActionKey.Skill4; actionKey++) {
							Skill class2 = player.class386_0[(int)actionKey];
							SnoPower snoPower = class2?.SnoPower;
							uint num5 = 0u;
							int num6 = 0;
							switch (actionKey) {
								case ActionKey.LeftSkill:
									num5 = player.RawPlayerData.struct30_0.uint_0;
									num6 = player.RawPlayerData.struct30_0.int_0;
									break;
								case ActionKey.RightSkill:
									num5 = player.RawPlayerData.struct30_1.uint_0;
									num6 = player.RawPlayerData.struct30_1.int_0;
									break;
								case ActionKey.Skill1:
									num5 = player.RawPlayerData.struct30_2.uint_0;
									num6 = player.RawPlayerData.struct30_2.int_0;
									break;
								case ActionKey.Skill2:
									num5 = player.RawPlayerData.struct30_3.uint_0;
									num6 = player.RawPlayerData.struct30_3.int_0;
									break;
								case ActionKey.Skill3:
									num5 = player.RawPlayerData.struct30_4.uint_0;
									num6 = player.RawPlayerData.struct30_4.int_0;
									break;
								case ActionKey.Skill4:
									num5 = player.RawPlayerData.struct30_5.uint_0;
									num6 = player.RawPlayerData.struct30_5.int_0;
									break;
							}
							if (num6 == -1) {
								num6 = 255;
							}
							if (snoPower == null || snoPower.Sno != num5 || class2.Rune != num6) {
								snoPower = SnoData.Powers.GetBySno(num5);
								player.class386_0[(int)actionKey] = ((snoPower == null) ? null : new Skill(player, snoPower, (byte)num6, actionKey));
							}
						}
						player.list_2.Clear();
						fixed (r_PlayerData* pData = &player.RawPlayerData) {
							uint* struct33_ = pData->struct33_0;
							for (int i = 0; i < 4; i++) {
								uint sno = struct33_[i];
								SnoPower bySno = SnoData.Powers.GetBySno(sno);
								if (player.SnoPower_0[i] != bySno) {
									player.SnoPower_0[i] = bySno;
								}
								if (bySno != null) {
									player.list_2.Add(bySno);
								}
							}
						}
						if (flag) {
							fixed (r_PlayerData* pData2 = &player.RawPlayerData) {
								(player.ArmorySets[0] as PlayerArmorySet).Name = method_2(pData2->struct28_0.struct29_0, 52);
								(player.ArmorySets[1] as PlayerArmorySet).Name = method_2(pData2->struct28_1.struct29_0, 52);
								(player.ArmorySets[2] as PlayerArmorySet).Name = method_2(pData2->struct28_2.struct29_0, 52);
								(player.ArmorySets[3] as PlayerArmorySet).Name = method_2(pData2->struct28_3.struct29_0, 52);
								(player.ArmorySets[4] as PlayerArmorySet).Name = method_2(pData2->struct28_4.struct29_0, 52);
								(player.ArmorySets[5] as PlayerArmorySet).Name = method_2(pData2->struct28_5.struct29_0, 52);
								(player.ArmorySets[6] as PlayerArmorySet).Name = method_2(pData2->struct28_6.struct29_0, 52);
								(player.ArmorySets[7] as PlayerArmorySet).Name = method_2(pData2->struct28_7.struct29_0, 52);
								(player.ArmorySets[8] as PlayerArmorySet).Name = method_2(pData2->struct28_8.struct29_0, 52);
								(player.ArmorySets[9] as PlayerArmorySet).Name = method_2(pData2->struct28_9.struct29_0, 52);
							}
							(player.ArmorySets[0] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_0;
							(player.ArmorySets[1] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_1;
							(player.ArmorySets[2] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_2;
							(player.ArmorySets[3] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_3;
							(player.ArmorySets[4] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_4;
							(player.ArmorySets[5] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_5;
							(player.ArmorySets[6] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_6;
							(player.ArmorySets[7] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_7;
							(player.ArmorySets[8] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_8;
							(player.ArmorySets[9] as PlayerArmorySet).ArmorySet = player.RawPlayerData.struct28_9;
							for (int j = 0; j < 10; j++) {
								PlayerArmorySet obj = player.ArmorySets[j] as PlayerArmorySet;
								obj.list_0.Clear();
								obj.method_1(obj.ArmorySet.struct25_0.uint_0);
								obj.method_1(obj.ArmorySet.struct25_1.uint_0);
								obj.method_1(obj.ArmorySet.struct25_2.uint_0);
								obj.method_1(obj.ArmorySet.struct25_3.uint_0);
								obj.method_1(obj.ArmorySet.struct25_4.uint_0);
								obj.method_1(obj.ArmorySet.struct25_5.uint_0);
								obj.method_1(obj.ArmorySet.struct25_6.uint_0);
								obj.method_1(obj.ArmorySet.struct25_7.uint_0);
								obj.method_1(obj.ArmorySet.struct25_8.uint_0);
								obj.method_1(obj.ArmorySet.struct25_9.uint_0);
								obj.method_1(obj.ArmorySet.struct25_10.uint_0);
								obj.method_1(obj.ArmorySet.struct25_11.uint_0);
								obj.method_1(obj.ArmorySet.struct25_12.uint_0);
							}
						}
						uint heroId2 = player.RawPlayerData.HeroId;
						if (heroId2 != 0 && heroId2 != uint.MaxValue) {
							if (heroId != heroId2) {
								player.HeroId = heroId2;
								Hero hero = (player.Hero = (player.IsMe ? CoreCollector.HeroCollector.method_0(heroId2) : null));
								if (hero != null) {
									player.HeroName = hero.Name;
									player.Int32_0 = hero.Season;
									player.HeroIsHardcore = hero.Hardcore;
									player.HeroIsMale = hero.IsMale;
									player.Boolean_1 = hero.Seasonal;
								} else {
									fixed (r_PlayerData* pData3 = &player.RawPlayerData) {
										player.HeroName = new string(pData3->struct35_0) ?? "";
									}
									player.Int32_0 = 0;
									player.HeroIsHardcore = false;
									player.HeroIsMale = true;
								}
								if (string.IsNullOrEmpty(player.HeroName)) {
									if (!player.IsMe) {
										player.method_59();
										goto IL_0f38;
									}
									return false;
								}
							}
							HeroClassDefinition heroClassByInternalIndex = SnoData.Classes.GetHeroClassByInternalIndex(player.RawPlayerData.HeroClass);
							if (heroClassByInternalIndex != null) {
								player.HeroClassDefinition = heroClassByInternalIndex;
								Custom.SetSnoAreaForPlayer(player);
								if (player.SnoArea == null && player.IsMe) {
									return false;
								}
								uint acdIdEncrypted = player.RawPlayerData.AcdIdEncrypted;
								uint actorIdEncrypted = player.RawPlayerData.ActorIdEncrypted;
								player.method_26(acdIdEncrypted);
								player.ActorId = actorIdEncrypted;
								if (!player.HasValidActor) {
									player.method_60();
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
										player.list_1.Clear();
										player.dictionary_0.Clear();
										fixed (r_PlayerData* pData5 = &player.RawPlayerData) {
											uint* struct34_2 = pData5->struct34_0;
											for (int l = 0; l < 512; l++) {
												uint num9 = struct34_2[l];
												if (num9 != uint.MaxValue) {
													SnoItem bySno2 = SnoData.Items.GetBySno(num9);
													if (bySno2 != null) {
														player.list_1.Add(bySno2);
														player.dictionary_0[bySno2.NameLocalized] = bySno2;
													}
												}
											}
										}
									}
									if (player.ParagonTotalExp > 0 && player.bool_14 && player.HasValidActor && player.FloorCoordinate.IsValid && player.bool_8 && CoreCollector.class364_0 != null && player.SnoArea != null) {
										if (player.long_6 > 0 && player.long_6 < player.ParagonTotalExp) {
											long num10 = player.ParagonTotalExp - player.long_6;
											if (num10 != 0L && player.IsMe) {
												foreach (StatTracker item2 in CoreCollector.Trackers) {
													item2.GainedExperience += num10;
												}
											}
										}
										player.long_6 = player.ParagonTotalExp;
									}
								}
							} else {
								if (player.IsMe) {
									return false;
								}
								player.method_59();
							}
						} else {
							if (player.IsMe) {
								return false;
							}
							player.method_59();
						}
					} else {
						if (player.IsMe) {
							break;
						}
						player.method_59();
					}
					goto IL_0f38;
				}
				return true;
			IL_0f38:
				num2++;
			}
			CoreCollector.Class335_0.Clear(player);
			return false;
		} catch (Exception exception_) {
			Logger.LogException(exception_.Message);
		}
		return false;
	}

	private unsafe string method_2(sbyte* pSbyte_0, int int_1)
	{
		string text = new string(pSbyte_0, 0, int_1, Encoding.UTF8);
		int num = text.IndexOf('\0');
		if (num != -1) {
			return text.Remove(num).Trim();
		}
		return text;
	}
}
