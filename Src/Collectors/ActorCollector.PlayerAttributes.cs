using System;
using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Collectors;

internal partial class ActorCollector
{
	private unsafe void CollectPlayerAttributes(Player player)
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
		player.ResetStats();
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
						SetBuffTimeLeft(player, num13, num14, 9, ref bool_);
						break;
					case "Gold_PickUp_Radius":
						player.Stats.PickupRange = (float)Math.Floor(5.5f + num15);
						break;
					case "Buff_Icon_End_Tick8":
						SetBuffTimeLeft(player, num13, num14, 8, ref bool_);
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
						SetBuffIconCount(player, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_Count31":
						SetBuffIconCount(player, num13, num14, 31, ref bool_);
						break;
					case "Highest_Solo_Rift_Level":
						player.HighestSoloRiftLevel = num14;
						break;
					case "Buff_Icon_Count19":
						SetBuffIconCount(player, num13, num14, 19, ref bool_);
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
						SetBuffIconCount(player, num13, num14, 18, ref bool_);
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
						SetBuffIconCount(player, num13, num14, 12, ref bool_);
						break;
					case "Buff_Icon_Count13":
						SetBuffIconCount(player, num13, num14, 13, ref bool_);
						break;
					case "Dexterity_Total":
						player.Stats.Dexterity = (float)Math.Floor(num15);
						break;
					case "Hitpoints_On_Kill":
						player.Defense.LifeOnKill = (float)Math.Floor(num15);
						break;
					case "Buff_Icon_Count11":
						SetBuffIconCount(player, num13, num14, 11, ref bool_);
						break;
					case "Buff_Icon_Count28":
						SetBuffIconCount(player, num13, num14, 28, ref bool_);
						break;
					case "Buff_Icon_Count26":
						SetBuffIconCount(player, num13, num14, 26, ref bool_);
						break;
					case "Buff_Icon_Count10":
						SetBuffIconCount(player, num13, num14, 10, ref bool_);
						break;
					case "Buff_Icon_Count29":
						SetBuffIconCount(player, num13, num14, 29, ref bool_);
						break;
					case "Buff_Icon_Count16":
						SetBuffIconCount(player, num13, num14, 16, ref bool_);
						break;
					case "Buff_Icon_Count27":
						SetBuffIconCount(player, num13, num14, 27, ref bool_);
						break;
					case "Buff_Icon_Count17":
						SetBuffIconCount(player, num13, num14, 17, ref bool_);
						break;
					case "Buff_Icon_Count25":
						SetBuffIconCount(player, num13, num14, 25, ref bool_);
						break;
					case "Buff_Icon_Count15":
						SetBuffIconCount(player, num13, num14, 15, ref bool_);
						break;
					case "Buff_Icon_Count24":
						SetBuffIconCount(player, num13, num14, 24, ref bool_);
						break;
					case "Buff_Icon_Count22":
						SetBuffIconCount(player, num13, num14, 22, ref bool_);
						break;
					case "Buff_Icon_Count14":
						SetBuffIconCount(player, num13, num14, 14, ref bool_);
						break;
					case "Experience_Bonus_No_Penalty":
						player.Stats.ExpOnKillNoPenalty = (float)Math.Round(num15, 0);
						break;
					case "Buff_Icon_Count21":
						SetBuffIconCount(player, num13, num14, 21, ref bool_);
						break;
					case "Buff_Icon_Count20":
						SetBuffIconCount(player, num13, num14, 20, ref bool_);
						break;
					case "Buff_Icon_Count23":
						SetBuffIconCount(player, num13, num14, 23, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 19, ref bool_);
						break;

					case "Damage_Percent_All_From_Skills":
						player.Offense.WeaponDamageIncreasedBySkills = num15;
						break;

					case "Buff_Icon_Start_Tick18":
						SetBuffTimeElapsed(player, num13, num14, 18, ref bool_);
						break;

					case "Buff_Icon_Start_Tick10":
						SetBuffTimeElapsed(player, num13, num14, 10, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 11, ref bool_);
						break;

					case "Buff_Icon_Count8":
						SetBuffIconCount(player, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick13":
						SetBuffTimeElapsed(player, num13, num14, 13, ref bool_);
						break;

					case "Buff_Icon_Start_Tick12":
						SetBuffTimeElapsed(player, num13, num14, 12, ref bool_);
						break;

					case "Buff_Icon_Start_Tick15":
						SetBuffTimeElapsed(player, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_Count9":
						SetBuffIconCount(player, num13, num14, 9, ref bool_);
						break;

					case "Buff_Icon_Start_Tick14":
						SetBuffTimeElapsed(player, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_Start_Tick16":
						SetBuffTimeElapsed(player, num13, num14, 16, ref bool_);
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
						SetBuffIconCount(player, num13, num14, 0, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 17, ref bool_);
						break;

					case "Buff_Icon_Count2":
						SetBuffIconCount(player, num13, num14, 2, ref bool_);
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
						SetBuffIconCount(player, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Count5":
						SetBuffIconCount(player, num13, num14, 5, ref bool_);
						break;

					case "Buff_Icon_Count4":
						SetBuffIconCount(player, num13, num14, 4, ref bool_);
						break;

					case "Buff_Icon_Count3":
						SetBuffIconCount(player, num13, num14, 3, ref bool_);
						break;

					case "Rest_Experience_Bonus_Percent":
						player.BonusPoolPercent = num15 * 100f;
						break;

					case "Buff_Icon_Count7":
						SetBuffIconCount(player, num13, num14, 7, ref bool_);
						break;

					case "Buff_Icon_Count6":
						SetBuffIconCount(player, num13, num14, 6, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 9, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 8, ref bool_);
						break;

					case "Buff_Icon_Start_Tick3":
						SetBuffTimeElapsed(player, num13, num14, 3, ref bool_);
						break;

					case "Buff_Icon_Start_Tick0":
						SetBuffTimeElapsed(player, num13, num14, 0, ref bool_);
						break;

					case "Buff_Icon_Start_Tick1":
						SetBuffTimeElapsed(player, num13, num14, 1, ref bool_);
						break;

					case "Buff_Icon_Start_Tick5":
						SetBuffTimeElapsed(player, num13, num14, 5, ref bool_);
						break;

					case "Movement_Scalar_Total":
						player.Stats.MoveSpeed = (float)Math.Round((num15 - 1f) * 100f, 1);
						break;

					case "Buff_Icon_Start_Tick2":
						SetBuffTimeElapsed(player, num13, num14, 2, ref bool_);
						break;

					case "Experience_Next_Hi":
						break;

					case "Buff_Icon_Start_Tick4":
						SetBuffTimeElapsed(player, num13, num14, 4, ref bool_);
						break;

					case "Thorns_Fixed":
						player.Defense.Thorns = (float)Math.Round(num15, 0);
						break;

					case "Buff_Icon_Start_Tick6":
						SetBuffTimeElapsed(player, num13, num14, 6, ref bool_);
						break;

					case "Buff_Icon_Start_Tick7":
						SetBuffTimeElapsed(player, num13, num14, 7, ref bool_);
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
						SetBuffTimeLeft(player, num13, num14, 22, ref bool_);
						break;

					case "Buff_Icon_End_Tick21":
						SetBuffTimeLeft(player, num13, num14, 21, ref bool_);
						break;

					case "Buff_Icon_End_Tick20":
						SetBuffTimeLeft(player, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_End_Tick24":
						SetBuffTimeLeft(player, num13, num14, 24, ref bool_);
						break;

					case "Damage_Percent_Reduction_From_Melee":
						player.Defense.DRMelee = num15;
						break;

					case "Buff_Icon_End_Tick23":
						SetBuffTimeLeft(player, num13, num14, 23, ref bool_);
						break;

					case "Buff_Icon_End_Tick26":
						SetBuffTimeLeft(player, num13, num14, 26, ref bool_);
						break;

					case "Buff_Icon_End_Tick31":
						SetBuffTimeLeft(player, num13, num14, 31, ref bool_);
						break;

					case "Buff_Icon_End_Tick25":
						SetBuffTimeLeft(player, num13, num14, 25, ref bool_);
						break;

					case "Buff_Icon_End_Tick27":
						SetBuffTimeLeft(player, num13, num14, 27, ref bool_);
						break;

					case "Magic_Find_Total":
						player.Stats.MagicFind = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_End_Tick30":
						SetBuffTimeLeft(player, num13, num14, 30, ref bool_);
						break;

					case "Buff_Icon_End_Tick19":
						SetBuffTimeLeft(player, num13, num14, 19, ref bool_);
						break;

					case "Buff_Icon_End_Tick29":
						SetBuffTimeLeft(player, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_End_Tick28":
						SetBuffTimeLeft(player, num13, num14, 28, ref bool_);
						break;

					case "Buff_Icon_End_Tick18":
						SetBuffTimeLeft(player, num13, num14, 18, ref bool_);
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
						SetBuffTimeLeft(player, num13, num14, 11, ref bool_);
						break;

					case "Damage_Weapon_Delta_Total_OffHand":
						if (num13 == 0) {
							player.Offense.WeaponDamageAddPhysicalOffHand = num15;
						} else {
							player.Offense.WeaponDamageAddElementalOffHand += num15;
						}
						break;

					case "Buff_Icon_End_Tick13":
						SetBuffTimeLeft(player, num13, num14, 13, ref bool_);
						break;

					case "Experience_Bonus_Percent_Total":
						player.Stats.ExperiencePercentBonus = num15;
						break;

					case "Buff_Icon_End_Tick10":
						SetBuffTimeLeft(player, num13, num14, 10, ref bool_);
						break;

					case "Buff_Icon_End_Tick14":
						SetBuffTimeLeft(player, num13, num14, 14, ref bool_);
						break;

					case "Buff_Icon_End_Tick15":
						SetBuffTimeLeft(player, num13, num14, 15, ref bool_);
						break;

					case "Buff_Icon_End_Tick12":
						SetBuffTimeLeft(player, num13, num14, 12, ref bool_);
						break;

					case "Damage_Shield_Amount":
						player.Defense.CurShield = num15;
						break;

					case "Attacks_Per_Second_Item_Total_MainHand":
						player.Offense.WeaponSpeedMainHand = num15;
						break;

					case "Buff_Icon_End_Tick17":
						SetBuffTimeLeft(player, num13, num14, 17, ref bool_);
						break;

					case "Shared_Stash_Slots":
						player.Int32_2 = num14;
						break;

					case "Skill_Charges":
						player.class112_0[num13] = num14;
						break;

					case "Buff_Icon_End_Tick16":
						SetBuffTimeLeft(player, num13, num14, 16, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 20, ref bool_);
						break;

					case "Buff_Icon_Start_Tick21":
						SetBuffTimeElapsed(player, num13, num14, 21, ref bool_);
						break;

					case "Experience_Bonus_Percent_Super_Scalar_Total":
						num9 = num15;
						break;

					case "Buff_Icon_Start_Tick23":
						SetBuffTimeElapsed(player, num13, num14, 23, ref bool_);
						break;

					case "In_Tiered_Loot_Run_Level":
						player.InGreaterRiftRank = (uint)(num14 + 1);
						break;

					case "Intelligence_Total":
						player.Stats.Intelligence = (float)Math.Floor(num15);
						break;

					case "Buff_Icon_Start_Tick25":
						SetBuffTimeElapsed(player, num13, num14, 25, ref bool_);
						break;

					case "Damage_Reduction_Total":
						player.Defense.DamageReduction = (float)Math.Round(num15 * 100f, 0);
						break;

					case "Buff_Icon_Start_Tick22":
						SetBuffTimeElapsed(player, num13, num14, 22, ref bool_);
						break;

					case "IsRooted":
						player.Powers.Rooted = num14 == 1;
						break;

					case "Buff_Icon_Start_Tick27":
						SetBuffTimeElapsed(player, num13, num14, 27, ref bool_);
						break;

					case "Buff_Icon_Start_Tick24":
						SetBuffTimeElapsed(player, num13, num14, 24, ref bool_);
						break;

					case "Class_Damage_Reduction_Percent":
						player.Defense.DRClass = num15;
						break;

					case "Buff_Icon_Start_Tick29":
						SetBuffTimeElapsed(player, num13, num14, 29, ref bool_);
						break;

					case "Buff_Icon_Start_Tick26":
						SetBuffTimeElapsed(player, num13, num14, 26, ref bool_);
						break;

					case "Corpse_Resurrection_Disabled":
						player.bool_17 = num14 == 1;
						break;

					case "Hitpoints_Regen_Per_Second_Total":
						player.Defense.LifeRegen = num15;
						break;

					case "Buff_Icon_Start_Tick28":
						SetBuffTimeElapsed(player, num13, num14, 28, ref bool_);
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
						SetBuffTimeElapsed(player, num13, num14, 31, ref bool_);
						break;
					case "Buff_Icon_End_Tick2":
						SetBuffTimeLeft(player, num13, num14, 2, ref bool_);
						break;
					case "Buff_Icon_Start_Tick30":
						SetBuffTimeElapsed(player, num13, num14, 30, ref bool_);
						break;
					case "Buff_Icon_End_Tick1":
						SetBuffTimeLeft(player, num13, num14, 1, ref bool_);
						break;
					case "Buff_Icon_End_Tick0":
						SetBuffTimeLeft(player, num13, num14, 0, ref bool_);
						break;
					case "Buff_Icon_End_Tick3":
						SetBuffTimeLeft(player, num13, num14, 3, ref bool_);
						break;
					case "Buff_Icon_End_Tick7":
						SetBuffTimeLeft(player, num13, num14, 7, ref bool_);
						break;
					case "Buff_Icon_End_Tick6":
						SetBuffTimeLeft(player, num13, num14, 6, ref bool_);
						break;
					case "Item_Power_Passive":
						player.class112_1[num13] = num15;
						break;
					case "Attacks_Per_Second_Bonus":
						player.Offense.AttackSpeedBonus = num15;
						break;
					case "Buff_Icon_End_Tick5":
						SetBuffTimeLeft(player, num13, num14, 5, ref bool_);
						break;
					case "Buff_Icon_End_Tick4":
						SetBuffTimeLeft(player, num13, num14, 4, ref bool_);
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
					Logger.LogException(exception_.ToString());
				}
			}
		}
		for (int num29 = 0; num29 < player.list_3.Count; num29++) {
			Skill playerSkill = player.list_3[num29];
			if (!playerSkill.IsOnCooldown && playerSkill.CurrentSnoPower != null) {
				try {
					CoreCollector.OnTrueCooldown?.Invoke(player, playerSkill);
				} catch (Exception exception) {
					Logger.LogException(exception.ToString());
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

	internal static void SetBuffIconCount(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
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

	internal static void SetBuffTimeElapsed(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
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

	internal static void SetBuffTimeLeft(Player player, uint uint_0, int int_4, int int_5, ref bool bool_4)
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
