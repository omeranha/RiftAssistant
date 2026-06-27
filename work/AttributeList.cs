using Plugins;
using SNO;

namespace work;

public class AttributeList
{
	public AcdAttribute Axe_Bad_Data => SnoData.Attributes.GetAttributeByIndex(0);

	public AcdAttribute Attribute_Timer => SnoData.Attributes.GetAttributeByIndex(1);

	public AcdAttribute Attribute_Pool => SnoData.Attributes.GetAttributeByIndex(2);

	public AcdAttribute Death_Count => SnoData.Attributes.GetAttributeByIndex(3);

	public AcdAttribute DualWield_Hand => SnoData.Attributes.GetAttributeByIndex(4);

	public AcdAttribute DualWield_Hand_Next => SnoData.Attributes.GetAttributeByIndex(5);

	public AcdAttribute DualWield_Hands_Swapped => SnoData.Attributes.GetAttributeByIndex(6);

	public AcdAttribute Respawn_Game_Time => SnoData.Attributes.GetAttributeByIndex(7);

	public AcdAttribute Backpack_Slots => SnoData.Attributes.GetAttributeByIndex(8);

	public AcdAttribute Shared_Stash_Slots => SnoData.Attributes.GetAttributeByIndex(9);

	public AcdAttribute Strength => SnoData.Attributes.GetAttributeByIndex(10);

	public AcdAttribute Dexterity => SnoData.Attributes.GetAttributeByIndex(11);

	public AcdAttribute Intelligence => SnoData.Attributes.GetAttributeByIndex(12);

	public AcdAttribute Vitality => SnoData.Attributes.GetAttributeByIndex(13);

	public AcdAttribute Strength_Total => SnoData.Attributes.GetAttributeByIndex(14);

	public AcdAttribute Dexterity_Total => SnoData.Attributes.GetAttributeByIndex(15);

	public AcdAttribute Intelligence_Total => SnoData.Attributes.GetAttributeByIndex(16);

	public AcdAttribute Vitality_Total => SnoData.Attributes.GetAttributeByIndex(17);

	public AcdAttribute Strength_Bonus => SnoData.Attributes.GetAttributeByIndex(18);

	public AcdAttribute Dexterity_Bonus => SnoData.Attributes.GetAttributeByIndex(19);

	public AcdAttribute Intelligence_Bonus => SnoData.Attributes.GetAttributeByIndex(20);

	public AcdAttribute Vitality_Bonus => SnoData.Attributes.GetAttributeByIndex(21);

	public AcdAttribute Strength_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(22);

	public AcdAttribute Dexterity_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(23);

	public AcdAttribute Intelligence_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(24);

	public AcdAttribute Vitality_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(25);

	public AcdAttribute Strength_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(26);

	public AcdAttribute Dexterity_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(27);

	public AcdAttribute Intelligence_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(28);

	public AcdAttribute Vitality_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(29);

	public AcdAttribute Primary_Damage_Attribute => SnoData.Attributes.GetAttributeByIndex(30);

	public AcdAttribute Armor => SnoData.Attributes.GetAttributeByIndex(31);

	public AcdAttribute Armor_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(32);

	public AcdAttribute Armor_Item => SnoData.Attributes.GetAttributeByIndex(33);

	public AcdAttribute Armor_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(34);

	public AcdAttribute Armor_Item_Percent => SnoData.Attributes.GetAttributeByIndex(35);

	public AcdAttribute Armor_Item_SubTotal => SnoData.Attributes.GetAttributeByIndex(36);

	public AcdAttribute Armor_Item_Total => SnoData.Attributes.GetAttributeByIndex(37);

	public AcdAttribute Armor_Total => SnoData.Attributes.GetAttributeByIndex(38);

	public AcdAttribute Experience_Granted_Hi => SnoData.Attributes.GetAttributeByIndex(39);

	public AcdAttribute Experience_Granted_Low => SnoData.Attributes.GetAttributeByIndex(40);

	public AcdAttribute Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(41);

	public AcdAttribute Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(42);

	public AcdAttribute Alt_Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(43);

	public AcdAttribute Alt_Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(44);

	public AcdAttribute Rest_Experience_Hi => SnoData.Attributes.GetAttributeByIndex(45);

	public AcdAttribute Rest_Experience_Lo => SnoData.Attributes.GetAttributeByIndex(46);

	public AcdAttribute Rest_Experience_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(47);

	public AcdAttribute Gold_Granted => SnoData.Attributes.GetAttributeByIndex(48);

	public AcdAttribute Gold => SnoData.Attributes.GetAttributeByIndex(49);

	public AcdAttribute Gold_Find => SnoData.Attributes.GetAttributeByIndex(50);

	public AcdAttribute Gold_Find_Uncapped => SnoData.Attributes.GetAttributeByIndex(51);

	public AcdAttribute Gold_Find_Handicap => SnoData.Attributes.GetAttributeByIndex(52);

	public AcdAttribute Gold_Find_Alt_Levels_Total => SnoData.Attributes.GetAttributeByIndex(53);

	public AcdAttribute Gold_Find_Community_Buff => SnoData.Attributes.GetAttributeByIndex(54);

	public AcdAttribute Gold_Find_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(55);

	public AcdAttribute Gold_Find_Total => SnoData.Attributes.GetAttributeByIndex(56);

	public AcdAttribute Level => SnoData.Attributes.GetAttributeByIndex(57);

	public AcdAttribute Level_Cap => SnoData.Attributes.GetAttributeByIndex(58);

	public AcdAttribute Alt_Level => SnoData.Attributes.GetAttributeByIndex(59);

	public AcdAttribute Magic_Find => SnoData.Attributes.GetAttributeByIndex(60);

	public AcdAttribute Magic_Find_Uncapped => SnoData.Attributes.GetAttributeByIndex(61);

	public AcdAttribute Magic_Find_Handicap => SnoData.Attributes.GetAttributeByIndex(62);

	public AcdAttribute Magic_Find_Alt_Levels_Total => SnoData.Attributes.GetAttributeByIndex(63);

	public AcdAttribute Magic_Find_Capped_Subtotal => SnoData.Attributes.GetAttributeByIndex(64);

	public AcdAttribute Magic_Find_Total => SnoData.Attributes.GetAttributeByIndex(65);

	public AcdAttribute Magic_And_Gold_Find_Suppressed => SnoData.Attributes.GetAttributeByIndex(66);

	public AcdAttribute Treasure_Find => SnoData.Attributes.GetAttributeByIndex(67);

	public AcdAttribute Legendary_Find_Community_Buff => SnoData.Attributes.GetAttributeByIndex(68);

	public AcdAttribute Resource_Cost_Reduction_Amount => SnoData.Attributes.GetAttributeByIndex(69);

	public AcdAttribute Resource_Cost_Reduction_Total => SnoData.Attributes.GetAttributeByIndex(70);

	public AcdAttribute Resource_Set_Point_Bonus => SnoData.Attributes.GetAttributeByIndex(71);

	public AcdAttribute Faster_Healing_Percent => SnoData.Attributes.GetAttributeByIndex(72);

	public AcdAttribute Spending_Resource_Heals_Percent => SnoData.Attributes.GetAttributeByIndex(73);

	public AcdAttribute Bonus_Healing_Received_Percent => SnoData.Attributes.GetAttributeByIndex(74);

	public AcdAttribute Reduced_Healing_Received_Percent => SnoData.Attributes.GetAttributeByIndex(75);

	public AcdAttribute Healing_Well_Restores_Resource => SnoData.Attributes.GetAttributeByIndex(76);

	public AcdAttribute Experience_Bonus => SnoData.Attributes.GetAttributeByIndex(77);

	public AcdAttribute Experience_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(78);

	public AcdAttribute Experience_Bonus_Percent_Handicap => SnoData.Attributes.GetAttributeByIndex(79);

	public AcdAttribute Experience_Bonus_Percent_Total => SnoData.Attributes.GetAttributeByIndex(80);

	public AcdAttribute Experience_Bonus_No_Penalty => SnoData.Attributes.GetAttributeByIndex(81);

	public AcdAttribute Health_Globe_Bonus_Chance => SnoData.Attributes.GetAttributeByIndex(82);

	public AcdAttribute Health_Globe_Bonus_Mult_Chance => SnoData.Attributes.GetAttributeByIndex(83);

	public AcdAttribute Powerup_Globe_Bonus_Chance => SnoData.Attributes.GetAttributeByIndex(84);

	public AcdAttribute Powerup_Globe_Bonus_Mult_Chance => SnoData.Attributes.GetAttributeByIndex(85);

	public AcdAttribute Health_Globe_Bonus_Health => SnoData.Attributes.GetAttributeByIndex(86);

	public AcdAttribute Increased_Health_From_Globes_Percent => SnoData.Attributes.GetAttributeByIndex(87);

	public AcdAttribute Increased_Health_From_Globes_Percent_Total => SnoData.Attributes.GetAttributeByIndex(88);

	public AcdAttribute Bonus_Health_Percent_Per_Second_From_Globes => SnoData.Attributes.GetAttributeByIndex(89);

	public AcdAttribute Bonus_Health_Percent_Per_Second_From_Globes_Total => SnoData.Attributes.GetAttributeByIndex(90);

	public AcdAttribute Mana_Gained_From_Globes_Percent => SnoData.Attributes.GetAttributeByIndex(91);

	public AcdAttribute Mana_Gained_From_Globes => SnoData.Attributes.GetAttributeByIndex(92);

	public AcdAttribute Resistance => SnoData.Attributes.GetAttributeByIndex(93);

	public AcdAttribute Resistance_Percent => SnoData.Attributes.GetAttributeByIndex(94);

	public AcdAttribute Resistance_Total => SnoData.Attributes.GetAttributeByIndex(95);

	public AcdAttribute Resistance_All => SnoData.Attributes.GetAttributeByIndex(96);

	public AcdAttribute Resistance_Percent_All => SnoData.Attributes.GetAttributeByIndex(97);

	public AcdAttribute Resistance_From_Intelligence => SnoData.Attributes.GetAttributeByIndex(98);

	public AcdAttribute Class_Damage_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(99);

	public AcdAttribute Skill => SnoData.Attributes.GetAttributeByIndex(100);

	public AcdAttribute Skill_From_Item => SnoData.Attributes.GetAttributeByIndex(101);

	public AcdAttribute Skill_Total => SnoData.Attributes.GetAttributeByIndex(102);

	public AcdAttribute TeamID => SnoData.Attributes.GetAttributeByIndex(103);

	public AcdAttribute Team_Override => SnoData.Attributes.GetAttributeByIndex(104);

	public AcdAttribute Invulnerable => SnoData.Attributes.GetAttributeByIndex(105);

	public AcdAttribute Loading => SnoData.Attributes.GetAttributeByIndex(106);

	public AcdAttribute Loading_Player_ACD => SnoData.Attributes.GetAttributeByIndex(107);

	public AcdAttribute Loading_Power_SNO => SnoData.Attributes.GetAttributeByIndex(108);

	public AcdAttribute Loading_Anim_Tag => SnoData.Attributes.GetAttributeByIndex(109);

	public AcdAttribute Loading_NewGame => SnoData.Attributes.GetAttributeByIndex(110);

	public AcdAttribute Auto_Porting_To_Save_Point => SnoData.Attributes.GetAttributeByIndex(111);

	public AcdAttribute No_Damage => SnoData.Attributes.GetAttributeByIndex(112);

	public AcdAttribute No_AutoPickup => SnoData.Attributes.GetAttributeByIndex(113);

	public AcdAttribute Light_Radius_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(114);

	public AcdAttribute Hitpoints_Cur => SnoData.Attributes.GetAttributeByIndex(115);

	public AcdAttribute Hitpoints_Factor_Level => SnoData.Attributes.GetAttributeByIndex(116);

	public AcdAttribute Hitpoints_Factor_Vitality => SnoData.Attributes.GetAttributeByIndex(117);

	public AcdAttribute Hitpoints_Total_From_Vitality => SnoData.Attributes.GetAttributeByIndex(118);

	public AcdAttribute Hitpoints_Total_From_Level => SnoData.Attributes.GetAttributeByIndex(119);

	public AcdAttribute Hitpoints_Granted => SnoData.Attributes.GetAttributeByIndex(120);

	public AcdAttribute Hitpoints_Granted_Duration => SnoData.Attributes.GetAttributeByIndex(121);

	public AcdAttribute Hitpoints_Max => SnoData.Attributes.GetAttributeByIndex(122);

	public AcdAttribute Hitpoints_Max_Bonus => SnoData.Attributes.GetAttributeByIndex(123);

	public AcdAttribute Hitpoints_Max_Total => SnoData.Attributes.GetAttributeByIndex(124);

	public AcdAttribute Hitpoints_Percent => SnoData.Attributes.GetAttributeByIndex(125);

	public AcdAttribute Hitpoints_Regen_Per_Second => SnoData.Attributes.GetAttributeByIndex(126);

	public AcdAttribute Hitpoints_Regen_Per_Second_Bonus => SnoData.Attributes.GetAttributeByIndex(127);

	public AcdAttribute Hitpoints_Regen_Per_Second_Bonus_From_Skills => SnoData.Attributes.GetAttributeByIndex(128);

	public AcdAttribute Hitpoints_Regen_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(129);

	public AcdAttribute Hitpoints_Regen_Per_Second_Subtotal => SnoData.Attributes.GetAttributeByIndex(130);

	public AcdAttribute Hitpoints_Regen_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(131);

	public AcdAttribute Hitpoints_Regen_Per_Second_Health_Globe => SnoData.Attributes.GetAttributeByIndex(132);

	public AcdAttribute Hitpoints_Regen_Per_Second_Total => SnoData.Attributes.GetAttributeByIndex(133);

	public AcdAttribute Hitpoints_Max_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(134);

	public AcdAttribute Hitpoints_Max_Percent_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(135);

	public AcdAttribute Hitpoints_Max_Percent_Bonus_Multiplicative => SnoData.Attributes.GetAttributeByIndex(136);

	public AcdAttribute Hitpoints_Healed_Target => SnoData.Attributes.GetAttributeByIndex(137);

	public AcdAttribute Hitpoints_Frozen => SnoData.Attributes.GetAttributeByIndex(138);

	public AcdAttribute Healing_Suppressed => SnoData.Attributes.GetAttributeByIndex(139);

	public AcdAttribute DOT_Damage_Taken_Queued => SnoData.Attributes.GetAttributeByIndex(140);

	public AcdAttribute DOT_Damage_Taken_Queued_Tick => SnoData.Attributes.GetAttributeByIndex(141);

	public AcdAttribute DOT_Damage_Taken_Queued_Player => SnoData.Attributes.GetAttributeByIndex(142);

	public AcdAttribute DOT_Damage_Taken_Queued_Player_Tick => SnoData.Attributes.GetAttributeByIndex(143);

	public AcdAttribute Healing_Received_Queued => SnoData.Attributes.GetAttributeByIndex(144);

	public AcdAttribute Healing_Received_Queued_Tick => SnoData.Attributes.GetAttributeByIndex(145);

	public AcdAttribute Staggered_Damage_Fraction => SnoData.Attributes.GetAttributeByIndex(146);

	public AcdAttribute Staggered_Damage_Duration => SnoData.Attributes.GetAttributeByIndex(147);

	public AcdAttribute Resource_Type_Primary => SnoData.Attributes.GetAttributeByIndex(148);

	public AcdAttribute Resource_Type_Secondary => SnoData.Attributes.GetAttributeByIndex(149);

	public AcdAttribute Resource_Cur => SnoData.Attributes.GetAttributeByIndex(150);

	public AcdAttribute Resource_Max => SnoData.Attributes.GetAttributeByIndex(151);

	public AcdAttribute Resource_Max_Bonus => SnoData.Attributes.GetAttributeByIndex(152);

	public AcdAttribute Resource_Max_Total => SnoData.Attributes.GetAttributeByIndex(153);

	public AcdAttribute Resource_Factor_Level => SnoData.Attributes.GetAttributeByIndex(154);

	public AcdAttribute Resource_Granted => SnoData.Attributes.GetAttributeByIndex(155);

	public AcdAttribute Resource_Granted_Duration => SnoData.Attributes.GetAttributeByIndex(156);

	public AcdAttribute Resource_Percent => SnoData.Attributes.GetAttributeByIndex(157);

	public AcdAttribute Resource_Regen_Per_Second => SnoData.Attributes.GetAttributeByIndex(158);

	public AcdAttribute Resource_Regen_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(159);

	public AcdAttribute Resource_Regen_Total => SnoData.Attributes.GetAttributeByIndex(160);

	public AcdAttribute Resource_Regen_Stop_Regen => SnoData.Attributes.GetAttributeByIndex(161);

	public AcdAttribute Resource_Max_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(162);

	public AcdAttribute Resource_Capacity_Used => SnoData.Attributes.GetAttributeByIndex(163);

	public AcdAttribute Resource_Effective_Max => SnoData.Attributes.GetAttributeByIndex(164);

	public AcdAttribute Resource_Regen_Percent_Per_Second => SnoData.Attributes.GetAttributeByIndex(165);

	public AcdAttribute Resource_Degeneration_Stop_Point => SnoData.Attributes.GetAttributeByIndex(166);

	public AcdAttribute Highest_Solo_Rift_Level => SnoData.Attributes.GetAttributeByIndex(167);

	public AcdAttribute Highest_Unlocked_Rift_Level => SnoData.Attributes.GetAttributeByIndex(168);

	public AcdAttribute Last_Rift_Started_Level => SnoData.Attributes.GetAttributeByIndex(169);

	public AcdAttribute Highest_Hero_Solo_Rift_Level => SnoData.Attributes.GetAttributeByIndex(170);

	public AcdAttribute Movement_Scalar => SnoData.Attributes.GetAttributeByIndex(171);

	public AcdAttribute Walking_Rate => SnoData.Attributes.GetAttributeByIndex(172);

	public AcdAttribute Running_Rate => SnoData.Attributes.GetAttributeByIndex(173);

	public AcdAttribute Sprinting_Rate => SnoData.Attributes.GetAttributeByIndex(174);

	public AcdAttribute Strafing_Rate => SnoData.Attributes.GetAttributeByIndex(175);

	public AcdAttribute Walking_Rate_Total => SnoData.Attributes.GetAttributeByIndex(176);

	public AcdAttribute Running_Rate_Total => SnoData.Attributes.GetAttributeByIndex(177);

	public AcdAttribute Last_Running_Rate => SnoData.Attributes.GetAttributeByIndex(178);

	public AcdAttribute Sprinting_Rate_Total => SnoData.Attributes.GetAttributeByIndex(179);

	public AcdAttribute Strafing_Rate_Total => SnoData.Attributes.GetAttributeByIndex(180);

	public AcdAttribute Movement_Bonus_Total => SnoData.Attributes.GetAttributeByIndex(181);

	public AcdAttribute Movement_Scalar_Subtotal => SnoData.Attributes.GetAttributeByIndex(182);

	public AcdAttribute Movement_Scalar_Capped_Total => SnoData.Attributes.GetAttributeByIndex(183);

	public AcdAttribute Movement_Scalar_Uncapped_Bonus => SnoData.Attributes.GetAttributeByIndex(184);

	public AcdAttribute Movement_Scalar_Total => SnoData.Attributes.GetAttributeByIndex(185);

	public AcdAttribute Movement_Bonus_Run_Speed => SnoData.Attributes.GetAttributeByIndex(186);

	public AcdAttribute Movement_Scalar_Cap => SnoData.Attributes.GetAttributeByIndex(187);

	public AcdAttribute Casting_Speed => SnoData.Attributes.GetAttributeByIndex(188);

	public AcdAttribute Casting_Speed_Bonus => SnoData.Attributes.GetAttributeByIndex(189);

	public AcdAttribute Casting_Speed_Total => SnoData.Attributes.GetAttributeByIndex(190);

	public AcdAttribute Always_Hits => SnoData.Attributes.GetAttributeByIndex(191);

	public AcdAttribute Hit_Chance => SnoData.Attributes.GetAttributeByIndex(192);

	public AcdAttribute Knockback_Attack_Scalar => SnoData.Attributes.GetAttributeByIndex(193);

	public AcdAttribute Attacks_Per_Second_Item => SnoData.Attributes.GetAttributeByIndex(194);

	public AcdAttribute Attacks_Per_Second_Item_Percent => SnoData.Attributes.GetAttributeByIndex(195);

	public AcdAttribute Attacks_Per_Second_Item_Subtotal => SnoData.Attributes.GetAttributeByIndex(196);

	public AcdAttribute Attacks_Per_Second_Item_Bonus => SnoData.Attributes.GetAttributeByIndex(197);

	public AcdAttribute Attacks_Per_Second_Item_Total => SnoData.Attributes.GetAttributeByIndex(198);

	public AcdAttribute Attacks_Per_Second => SnoData.Attributes.GetAttributeByIndex(199);

	public AcdAttribute Attacks_Per_Second_Bonus => SnoData.Attributes.GetAttributeByIndex(200);

	public AcdAttribute Attacks_Per_Second_Total => SnoData.Attributes.GetAttributeByIndex(201);

	public AcdAttribute Attacks_Per_Second_Percent_Cap => SnoData.Attributes.GetAttributeByIndex(202);

	public AcdAttribute Attacks_Per_Second_Percent => SnoData.Attributes.GetAttributeByIndex(203);

	public AcdAttribute Attacks_Per_Second_Percent_Uncapped => SnoData.Attributes.GetAttributeByIndex(204);

	public AcdAttribute Attacks_Per_Second_Percent_Reduction => SnoData.Attributes.GetAttributeByIndex(205);

	public AcdAttribute Attacks_Per_Second_Percent_Subtotal => SnoData.Attributes.GetAttributeByIndex(206);

	public AcdAttribute AI_Cooldown_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(207);

	public AcdAttribute Power_Cooldown_Min_Time => SnoData.Attributes.GetAttributeByIndex(208);

	public AcdAttribute Power_Cooldown_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(209);

	public AcdAttribute Power_Cooldown_Reduction_Percent_All => SnoData.Attributes.GetAttributeByIndex(210);

	public AcdAttribute Power_Cooldown_Reduction_Percent_All_Capped => SnoData.Attributes.GetAttributeByIndex(211);

	public AcdAttribute Damage_Delta => SnoData.Attributes.GetAttributeByIndex(212);

	public AcdAttribute Damage_Delta_Total => SnoData.Attributes.GetAttributeByIndex(213);

	public AcdAttribute Damage_Min => SnoData.Attributes.GetAttributeByIndex(214);

	public AcdAttribute Damage_Bonus_Min => SnoData.Attributes.GetAttributeByIndex(215);

	public AcdAttribute Damage_Min_Total => SnoData.Attributes.GetAttributeByIndex(216);

	public AcdAttribute Damage_Delta_Total_All => SnoData.Attributes.GetAttributeByIndex(217);

	public AcdAttribute Damage_Min_Total_All => SnoData.Attributes.GetAttributeByIndex(218);

	public AcdAttribute Damage_Average_Total_All => SnoData.Attributes.GetAttributeByIndex(219);

	public AcdAttribute Damage_Min_Subtotal => SnoData.Attributes.GetAttributeByIndex(220);

	public AcdAttribute Damage_Percent_All_From_Skills => SnoData.Attributes.GetAttributeByIndex(221);

	public AcdAttribute Damage_Weapon_Delta => SnoData.Attributes.GetAttributeByIndex(222);

	public AcdAttribute Damage_Weapon_Delta_SubTotal => SnoData.Attributes.GetAttributeByIndex(223);

	public AcdAttribute Damage_Weapon_Max => SnoData.Attributes.GetAttributeByIndex(224);

	public AcdAttribute Damage_Weapon_Max_Total => SnoData.Attributes.GetAttributeByIndex(225);

	public AcdAttribute Damage_Weapon_Max_Total_All => SnoData.Attributes.GetAttributeByIndex(226);

	public AcdAttribute Damage_Weapon_Delta_Total => SnoData.Attributes.GetAttributeByIndex(227);

	public AcdAttribute Damage_Weapon_Delta_Total_All => SnoData.Attributes.GetAttributeByIndex(228);

	public AcdAttribute Damage_Weapon_Bonus_Delta => SnoData.Attributes.GetAttributeByIndex(229);

	public AcdAttribute Damage_Weapon_Bonus_Delta_X1 => SnoData.Attributes.GetAttributeByIndex(230);

	public AcdAttribute Damage_Weapon_Min => SnoData.Attributes.GetAttributeByIndex(231);

	public AcdAttribute Damage_Weapon_Min_Total => SnoData.Attributes.GetAttributeByIndex(232);

	public AcdAttribute Damage_Weapon_Min_Total_All => SnoData.Attributes.GetAttributeByIndex(233);

	public AcdAttribute Damage_Weapon_Average => SnoData.Attributes.GetAttributeByIndex(234);

	public AcdAttribute Damage_Weapon_Average_Total => SnoData.Attributes.GetAttributeByIndex(235);

	public AcdAttribute Damage_Weapon_Average_Total_All => SnoData.Attributes.GetAttributeByIndex(236);

	public AcdAttribute Damage_Weapon_Bonus_Min => SnoData.Attributes.GetAttributeByIndex(237);

	public AcdAttribute Damage_Weapon_Bonus_Min_X1 => SnoData.Attributes.GetAttributeByIndex(238);

	public AcdAttribute Damage_Weapon_Bonus_Flat => SnoData.Attributes.GetAttributeByIndex(239);

	public AcdAttribute Damage_Weapon_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(240);

	public AcdAttribute Damage_Weapon_Percent_All => SnoData.Attributes.GetAttributeByIndex(241);

	public AcdAttribute Damage_Weapon_Percent_Total => SnoData.Attributes.GetAttributeByIndex(242);

	public AcdAttribute Damage_Type_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(243);

	public AcdAttribute Damage_Dealt_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(244);

	public AcdAttribute Damage_Percent_Bonus_Barbarian => SnoData.Attributes.GetAttributeByIndex(245);

	public AcdAttribute Damage_Percent_Bonus_Crusader => SnoData.Attributes.GetAttributeByIndex(246);

	public AcdAttribute Damage_Percent_Bonus_Demonhunter => SnoData.Attributes.GetAttributeByIndex(247);

	public AcdAttribute Damage_Percent_Bonus_Monk => SnoData.Attributes.GetAttributeByIndex(248);

	public AcdAttribute Damage_Percent_Bonus_Necromancer => SnoData.Attributes.GetAttributeByIndex(249);

	public AcdAttribute Damage_Percent_Bonus_Witchdoctor => SnoData.Attributes.GetAttributeByIndex(250);

	public AcdAttribute Damage_Percent_Bonus_Wizard => SnoData.Attributes.GetAttributeByIndex(251);

	public AcdAttribute Crit_Percent_Base => SnoData.Attributes.GetAttributeByIndex(252);

	public AcdAttribute Crit_Percent_Bonus_Capped => SnoData.Attributes.GetAttributeByIndex(253);

	public AcdAttribute Crit_Percent_Bonus_Uncapped => SnoData.Attributes.GetAttributeByIndex(254);

	public AcdAttribute Crit_Percent_Bonus_Hide_From_DPS => SnoData.Attributes.GetAttributeByIndex(255);

	public AcdAttribute Crit_Percent_Cap => SnoData.Attributes.GetAttributeByIndex(256);

	public AcdAttribute Crit_Damage_Cap => SnoData.Attributes.GetAttributeByIndex(257);

	public AcdAttribute Crit_Damage_Percent => SnoData.Attributes.GetAttributeByIndex(258);

	public AcdAttribute Crit_Damage_Percent_Uncapped => SnoData.Attributes.GetAttributeByIndex(259);

	public AcdAttribute Crit_Effect_Time => SnoData.Attributes.GetAttributeByIndex(260);

	public AcdAttribute Pierce_Chance => SnoData.Attributes.GetAttributeByIndex(261);

	public AcdAttribute Damage_Absorb_Percent => SnoData.Attributes.GetAttributeByIndex(262);

	public AcdAttribute Damage_Reduction_Total => SnoData.Attributes.GetAttributeByIndex(263);

	public AcdAttribute Damage_Reduction_Current => SnoData.Attributes.GetAttributeByIndex(264);

	public AcdAttribute Damage_Reduction_Last_Tick => SnoData.Attributes.GetAttributeByIndex(265);

	public AcdAttribute Block_Chance => SnoData.Attributes.GetAttributeByIndex(266);

	public AcdAttribute Block_Chance_Sub_Total => SnoData.Attributes.GetAttributeByIndex(267);

	public AcdAttribute Block_Chance_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(268);

	public AcdAttribute Block_Chance_Item => SnoData.Attributes.GetAttributeByIndex(269);

	public AcdAttribute Block_Chance_Item_Total => SnoData.Attributes.GetAttributeByIndex(270);

	public AcdAttribute Block_Chance_Uncapped_Bonus => SnoData.Attributes.GetAttributeByIndex(271);

	public AcdAttribute Block_Chance_Capped_Total => SnoData.Attributes.GetAttributeByIndex(272);

	public AcdAttribute Block_Amount => SnoData.Attributes.GetAttributeByIndex(273);

	public AcdAttribute Block_Amount_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(274);

	public AcdAttribute Block_Amount_Total_Min => SnoData.Attributes.GetAttributeByIndex(275);

	public AcdAttribute Block_Amount_Total_Max => SnoData.Attributes.GetAttributeByIndex(276);

	public AcdAttribute Block_Amount_Item_Min => SnoData.Attributes.GetAttributeByIndex(277);

	public AcdAttribute Block_Amount_Item_Delta => SnoData.Attributes.GetAttributeByIndex(278);

	public AcdAttribute Block_Amount_Item_Bonus => SnoData.Attributes.GetAttributeByIndex(279);

	public AcdAttribute Dodge_Chance_Bonus => SnoData.Attributes.GetAttributeByIndex(280);

	public AcdAttribute Dodge_Chance_Bonus_Melee => SnoData.Attributes.GetAttributeByIndex(281);

	public AcdAttribute Dodge_Chance_Bonus_Ranged => SnoData.Attributes.GetAttributeByIndex(282);

	public AcdAttribute Dodge_Chance_Bonus_Additive => SnoData.Attributes.GetAttributeByIndex(283);

	public AcdAttribute Dodge_Chance_Bonus_Hide_From_Toughness => SnoData.Attributes.GetAttributeByIndex(284);

	public AcdAttribute Cannot_Dodge => SnoData.Attributes.GetAttributeByIndex(285);

	public AcdAttribute Get_Hit_Current => SnoData.Attributes.GetAttributeByIndex(286);

	public AcdAttribute Get_Hit_Max_Base => SnoData.Attributes.GetAttributeByIndex(287);

	public AcdAttribute Get_Hit_Max_Per_Level => SnoData.Attributes.GetAttributeByIndex(288);

	public AcdAttribute Get_Hit_Max => SnoData.Attributes.GetAttributeByIndex(289);

	public AcdAttribute Get_Hit_Recovery_Base => SnoData.Attributes.GetAttributeByIndex(290);

	public AcdAttribute Get_Hit_Recovery_Per_Level => SnoData.Attributes.GetAttributeByIndex(291);

	public AcdAttribute Get_Hit_Recovery => SnoData.Attributes.GetAttributeByIndex(292);

	public AcdAttribute Get_Hit_Damage => SnoData.Attributes.GetAttributeByIndex(293);

	public AcdAttribute Get_Hit_Damage_Scalar => SnoData.Attributes.GetAttributeByIndex(294);

	public AcdAttribute Last_Damage_MainActor => SnoData.Attributes.GetAttributeByIndex(295);

	public AcdAttribute Last_ACD_Attacked => SnoData.Attributes.GetAttributeByIndex(296);

	public AcdAttribute Ignores_Critical_Hits => SnoData.Attributes.GetAttributeByIndex(297);

	public AcdAttribute Immunity => SnoData.Attributes.GetAttributeByIndex(298);

	public AcdAttribute Untargetable => SnoData.Attributes.GetAttributeByIndex(299);

	public AcdAttribute Immobolize => SnoData.Attributes.GetAttributeByIndex(300);

	public AcdAttribute Immune_To_Knockback => SnoData.Attributes.GetAttributeByIndex(301);

	public AcdAttribute Power_Immobilize => SnoData.Attributes.GetAttributeByIndex(302);

	public AcdAttribute Stun_Chance => SnoData.Attributes.GetAttributeByIndex(303);

	public AcdAttribute Stun_Length => SnoData.Attributes.GetAttributeByIndex(304);

	public AcdAttribute Stun_Recovery => SnoData.Attributes.GetAttributeByIndex(305);

	public AcdAttribute Stun_Recovery_Speed => SnoData.Attributes.GetAttributeByIndex(306);

	public AcdAttribute Stunned => SnoData.Attributes.GetAttributeByIndex(307);

	public AcdAttribute Stun_Immune => SnoData.Attributes.GetAttributeByIndex(308);

	public AcdAttribute Poison_Length_Reduction => SnoData.Attributes.GetAttributeByIndex(309);

	public AcdAttribute Bleeding => SnoData.Attributes.GetAttributeByIndex(310);

	public AcdAttribute Bleed_Duration => SnoData.Attributes.GetAttributeByIndex(311);

	public AcdAttribute Chilled => SnoData.Attributes.GetAttributeByIndex(312);

	public AcdAttribute Freeze_Length_Reduction => SnoData.Attributes.GetAttributeByIndex(313);

	public AcdAttribute Freeze_Immune => SnoData.Attributes.GetAttributeByIndex(314);

	public AcdAttribute Chill_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(315);

	public AcdAttribute Freeze_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(316);

	public AcdAttribute Stun_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(317);

	public AcdAttribute Immobilize_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(318);

	public AcdAttribute Fear_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(319);

	public AcdAttribute Blind_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(320);

	public AcdAttribute Charm_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(321);

	public AcdAttribute Slow_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(322);

	public AcdAttribute Webbed => SnoData.Attributes.GetAttributeByIndex(323);

	public AcdAttribute Slow => SnoData.Attributes.GetAttributeByIndex(324);

	public AcdAttribute FireAura => SnoData.Attributes.GetAttributeByIndex(325);

	public AcdAttribute LightningAura => SnoData.Attributes.GetAttributeByIndex(326);

	public AcdAttribute ColdAura => SnoData.Attributes.GetAttributeByIndex(327);

	public AcdAttribute PoisonAura => SnoData.Attributes.GetAttributeByIndex(328);

	public AcdAttribute Blind => SnoData.Attributes.GetAttributeByIndex(329);

	public AcdAttribute Enraged => SnoData.Attributes.GetAttributeByIndex(330);

	public AcdAttribute Slowdown_Immune => SnoData.Attributes.GetAttributeByIndex(331);

	public AcdAttribute Gethit_Immune => SnoData.Attributes.GetAttributeByIndex(332);

	public AcdAttribute AttackSpeed_Reduction_Immune => SnoData.Attributes.GetAttributeByIndex(333);

	public AcdAttribute Suffocation_Per_Second => SnoData.Attributes.GetAttributeByIndex(334);

	public AcdAttribute Suffocation_Unit_Value => SnoData.Attributes.GetAttributeByIndex(335);

	public AcdAttribute Thorns_Percent => SnoData.Attributes.GetAttributeByIndex(336);

	public AcdAttribute Thorns_Percent_All => SnoData.Attributes.GetAttributeByIndex(337);

	public AcdAttribute Thorns_Percent_Total => SnoData.Attributes.GetAttributeByIndex(338);

	public AcdAttribute Thorns_Fixed => SnoData.Attributes.GetAttributeByIndex(339);

	public AcdAttribute Thorns_Fixed_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(340);

	public AcdAttribute Thorns_Fixed_Total => SnoData.Attributes.GetAttributeByIndex(341);

	public AcdAttribute Thorns_AOE_Radius => SnoData.Attributes.GetAttributeByIndex(342);

	public AcdAttribute Thorns_Has_Damage_Type => SnoData.Attributes.GetAttributeByIndex(343);

	public AcdAttribute On_First_Hit_Thorns_Percent => SnoData.Attributes.GetAttributeByIndex(344);

	public AcdAttribute Steal_Health_Percent => SnoData.Attributes.GetAttributeByIndex(345);

	public AcdAttribute Steal_Mana_Percent => SnoData.Attributes.GetAttributeByIndex(346);

	public AcdAttribute Resource_On_Hit => SnoData.Attributes.GetAttributeByIndex(347);

	public AcdAttribute Resource_On_Hit_Bonus_Pct => SnoData.Attributes.GetAttributeByIndex(348);

	public AcdAttribute Resource_On_Hit_Bonus => SnoData.Attributes.GetAttributeByIndex(349);

	public AcdAttribute Resource_On_Kill => SnoData.Attributes.GetAttributeByIndex(350);

	public AcdAttribute Resource_On_Crit => SnoData.Attributes.GetAttributeByIndex(351);

	public AcdAttribute Hitpoints_On_Hit => SnoData.Attributes.GetAttributeByIndex(352);

	public AcdAttribute Hitpoints_On_Kill => SnoData.Attributes.GetAttributeByIndex(353);

	public AcdAttribute Hitpoints_On_Kill_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(354);

	public AcdAttribute Hitpoints_On_Kill_Total => SnoData.Attributes.GetAttributeByIndex(355);

	public AcdAttribute Damage_To_Mana => SnoData.Attributes.GetAttributeByIndex(356);

	public AcdAttribute Last_Proc_Time => SnoData.Attributes.GetAttributeByIndex(357);

	public AcdAttribute Damage_Power_Delta => SnoData.Attributes.GetAttributeByIndex(358);

	public AcdAttribute Damage_Power_Min => SnoData.Attributes.GetAttributeByIndex(359);

	public AcdAttribute Rope_Overlay => SnoData.Attributes.GetAttributeByIndex(360);

	public AcdAttribute General_Cooldown => SnoData.Attributes.GetAttributeByIndex(361);

	public AcdAttribute Power_Cooldown => SnoData.Attributes.GetAttributeByIndex(362);

	public AcdAttribute Power_Cooldown_Start => SnoData.Attributes.GetAttributeByIndex(363);

	public AcdAttribute Proc_Cooldown => SnoData.Attributes.GetAttributeByIndex(364);

	public AcdAttribute Emote_Cooldown => SnoData.Attributes.GetAttributeByIndex(365);

	public AcdAttribute Projectile_Speed => SnoData.Attributes.GetAttributeByIndex(366);

	public AcdAttribute Projectile_Speed_Increase_Percent => SnoData.Attributes.GetAttributeByIndex(367);

	public AcdAttribute DestroyWhenPathBlocked => SnoData.Attributes.GetAttributeByIndex(368);

	public AcdAttribute Skill_Toggled_State => SnoData.Attributes.GetAttributeByIndex(369);

	public AcdAttribute Skill_Charges => SnoData.Attributes.GetAttributeByIndex(370);

	public AcdAttribute Next_Charge_Gained_time => SnoData.Attributes.GetAttributeByIndex(371);

	public AcdAttribute Recharge_Start_Time => SnoData.Attributes.GetAttributeByIndex(372);

	public AcdAttribute Act => SnoData.Attributes.GetAttributeByIndex(373);

	public AcdAttribute Difficulty => SnoData.Attributes.GetAttributeByIndex(374);

	public AcdAttribute Last_Damage_Amount => SnoData.Attributes.GetAttributeByIndex(375);

	public AcdAttribute In_Knockback => SnoData.Attributes.GetAttributeByIndex(376);

	public AcdAttribute Amplify_Damage_Type_Percent => SnoData.Attributes.GetAttributeByIndex(377);

	public AcdAttribute Amplify_Damage_Skill_Percent => SnoData.Attributes.GetAttributeByIndex(378);

	public AcdAttribute Amplify_Damage_Percent => SnoData.Attributes.GetAttributeByIndex(379);

	public AcdAttribute Durability_Cur => SnoData.Attributes.GetAttributeByIndex(380);

	public AcdAttribute Durability_Max => SnoData.Attributes.GetAttributeByIndex(381);

	public AcdAttribute Durability_Last_Damage => SnoData.Attributes.GetAttributeByIndex(382);

	public AcdAttribute Item_Quality_Level => SnoData.Attributes.GetAttributeByIndex(383);

	public AcdAttribute Item_Quality_Level_Identified => SnoData.Attributes.GetAttributeByIndex(384);

	public AcdAttribute Item_Cost_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(385);

	public AcdAttribute Item_Equipped => SnoData.Attributes.GetAttributeByIndex(386);

	public AcdAttribute Ping => SnoData.Attributes.GetAttributeByIndex(387);

	public AcdAttribute Requirement => SnoData.Attributes.GetAttributeByIndex(388);

	public AcdAttribute Requirements_Ease_Percent => SnoData.Attributes.GetAttributeByIndex(389);

	public AcdAttribute Requirement_When_Equipped => SnoData.Attributes.GetAttributeByIndex(390);

	public AcdAttribute Sockets => SnoData.Attributes.GetAttributeByIndex(391);

	public AcdAttribute Sockets_Filled => SnoData.Attributes.GetAttributeByIndex(392);

	public AcdAttribute Stats_All_Bonus => SnoData.Attributes.GetAttributeByIndex(393);

	public AcdAttribute Item_Bound_To_ACD => SnoData.Attributes.GetAttributeByIndex(394);

	public AcdAttribute Item_Locked_To_ACD => SnoData.Attributes.GetAttributeByIndex(395);

	public AcdAttribute Item_Binding_Level_Override => SnoData.Attributes.GetAttributeByIndex(396);

	public AcdAttribute Item_LegendaryItem_Level_Override => SnoData.Attributes.GetAttributeByIndex(397);

	public AcdAttribute Item_Targeted_Player_Class => SnoData.Attributes.GetAttributeByIndex(398);

	public AcdAttribute Item_Targeted_Hireling_Class => SnoData.Attributes.GetAttributeByIndex(399);

	public AcdAttribute ItemStackQuantityHi => SnoData.Attributes.GetAttributeByIndex(400);

	public AcdAttribute ItemStackQuantityLo => SnoData.Attributes.GetAttributeByIndex(401);

	public AcdAttribute Run_Speed_Granted => SnoData.Attributes.GetAttributeByIndex(402);

	public AcdAttribute Run_Speed_Duration => SnoData.Attributes.GetAttributeByIndex(403);

	public AcdAttribute IdentifyCost => SnoData.Attributes.GetAttributeByIndex(404);

	public AcdAttribute Seed => SnoData.Attributes.GetAttributeByIndex(405);

	public AcdAttribute IsCrafted => SnoData.Attributes.GetAttributeByIndex(406);

	public AcdAttribute IsVendorBought => SnoData.Attributes.GetAttributeByIndex(407);

	public AcdAttribute DyeType => SnoData.Attributes.GetAttributeByIndex(408);

	public AcdAttribute Loot_2_0_Drop => SnoData.Attributes.GetAttributeByIndex(409);

	public AcdAttribute Post_2_1_2_Drop => SnoData.Attributes.GetAttributeByIndex(410);

	public AcdAttribute Post_2_5_0_Drop => SnoData.Attributes.GetAttributeByIndex(412);

	public AcdAttribute Ancient_Rank => SnoData.Attributes.GetAttributeByIndex(413);

	public AcdAttribute Unidentified => SnoData.Attributes.GetAttributeByIndex(414);

	public AcdAttribute RemoveLevelReq => SnoData.Attributes.GetAttributeByIndex(415);

	public AcdAttribute ConsumableAddSockets => SnoData.Attributes.GetAttributeByIndex(416);

	public AcdAttribute AddSocketsType_Weapon => SnoData.Attributes.GetAttributeByIndex(417);

	public AcdAttribute AddSocketsType_Offhand => SnoData.Attributes.GetAttributeByIndex(418);

	public AcdAttribute AddSocketsType_Legs => SnoData.Attributes.GetAttributeByIndex(419);

	public AcdAttribute AddSocketsType_Chest => SnoData.Attributes.GetAttributeByIndex(420);

	public AcdAttribute AddSocketsType_Helm => SnoData.Attributes.GetAttributeByIndex(421);

	public AcdAttribute AddSocketsType_Jewelry => SnoData.Attributes.GetAttributeByIndex(422);

	public AcdAttribute EnchantedAffixOld => SnoData.Attributes.GetAttributeByIndex(423);

	public AcdAttribute EnchantedAffixNew => SnoData.Attributes.GetAttributeByIndex(424);

	public AcdAttribute EnchantedAffixSeed => SnoData.Attributes.GetAttributeByIndex(425);

	public AcdAttribute EnchantedAffixCount => SnoData.Attributes.GetAttributeByIndex(426);

	public AcdAttribute TransmogGBID => SnoData.Attributes.GetAttributeByIndex(427);

	public AcdAttribute TransmogGBIDTempOverride => SnoData.Attributes.GetAttributeByIndex(428);

	public AcdAttribute HighlySalvageable => SnoData.Attributes.GetAttributeByIndex(429);

	public AcdAttribute ItemUnlockTimeHi => SnoData.Attributes.GetAttributeByIndex(430);

	public AcdAttribute ItemUnlockTimeLo => SnoData.Attributes.GetAttributeByIndex(431);

	public AcdAttribute CubeEnchantedGemRank => SnoData.Attributes.GetAttributeByIndex(432);

	public AcdAttribute CubeEnchantedGemType => SnoData.Attributes.GetAttributeByIndex(433);

	public AcdAttribute Cube_Enchanted_Strength_Item => SnoData.Attributes.GetAttributeByIndex(434);

	public AcdAttribute Cube_Enchanted_Dexterity_Item => SnoData.Attributes.GetAttributeByIndex(435);

	public AcdAttribute Cube_Enchanted_Intelligence_Item => SnoData.Attributes.GetAttributeByIndex(436);

	public AcdAttribute Cube_Enchanted_Vitality_Item => SnoData.Attributes.GetAttributeByIndex(437);

	public AcdAttribute Always_Plays_GetHit => SnoData.Attributes.GetAttributeByIndex(438);

	public AcdAttribute Hidden => SnoData.Attributes.GetAttributeByIndex(439);

	public AcdAttribute Alpha_For_Other_Players => SnoData.Attributes.GetAttributeByIndex(440);

	public AcdAttribute AlphaAttachments => SnoData.Attributes.GetAttributeByIndex(441);

	public AcdAttribute RActor_Fade_Group => SnoData.Attributes.GetAttributeByIndex(442);

	public AcdAttribute QuestRange => SnoData.Attributes.GetAttributeByIndex(443);

	public AcdAttribute Attack_Cooldown_Min => SnoData.Attributes.GetAttributeByIndex(444);

	public AcdAttribute Attack_Cooldown_Delta => SnoData.Attributes.GetAttributeByIndex(445);

	public AcdAttribute InitialCooldownMinTotal => SnoData.Attributes.GetAttributeByIndex(446);

	public AcdAttribute InitialCooldownDeltaTotal => SnoData.Attributes.GetAttributeByIndex(447);

	public AcdAttribute Attack_Cooldown_Min_Total => SnoData.Attributes.GetAttributeByIndex(448);

	public AcdAttribute Attack_Cooldown_Delta_Total => SnoData.Attributes.GetAttributeByIndex(449);

	public AcdAttribute Closing_Cooldown_Min_Total => SnoData.Attributes.GetAttributeByIndex(450);

	public AcdAttribute Closing_Cooldown_Delta_Total => SnoData.Attributes.GetAttributeByIndex(451);

	public AcdAttribute Quest_Monster => SnoData.Attributes.GetAttributeByIndex(452);

	public AcdAttribute Quest_MonsterEffect => SnoData.Attributes.GetAttributeByIndex(453);

	public AcdAttribute Treasure_Class => SnoData.Attributes.GetAttributeByIndex(454);

	public AcdAttribute Removes_Body_On_Death => SnoData.Attributes.GetAttributeByIndex(455);

	public AcdAttribute InitialCooldownMin => SnoData.Attributes.GetAttributeByIndex(456);

	public AcdAttribute InitialCooldownDelta => SnoData.Attributes.GetAttributeByIndex(457);

	public AcdAttribute Knockback_Weight => SnoData.Attributes.GetAttributeByIndex(458);

	public AcdAttribute UntargetableByPets => SnoData.Attributes.GetAttributeByIndex(459);

	public AcdAttribute Damage_State_Current => SnoData.Attributes.GetAttributeByIndex(460);

	public AcdAttribute Damage_State_Max => SnoData.Attributes.GetAttributeByIndex(461);

	public AcdAttribute Is_Player_Decoy => SnoData.Attributes.GetAttributeByIndex(462);

	public AcdAttribute Custom_Target_Weight => SnoData.Attributes.GetAttributeByIndex(463);

	public AcdAttribute Gizmo_State => SnoData.Attributes.GetAttributeByIndex(464);

	public AcdAttribute Gizmo_Charges => SnoData.Attributes.GetAttributeByIndex(465);

	public AcdAttribute Chest_Open => SnoData.Attributes.GetAttributeByIndex(466);

	public AcdAttribute Door_Locked => SnoData.Attributes.GetAttributeByIndex(467);

	public AcdAttribute Door_Timer => SnoData.Attributes.GetAttributeByIndex(468);

	public AcdAttribute Gizmo_Disabled_By_Script => SnoData.Attributes.GetAttributeByIndex(469);

	public AcdAttribute Gizmo_Operator_ACDID => SnoData.Attributes.GetAttributeByIndex(470);

	public AcdAttribute Triggering_Count => SnoData.Attributes.GetAttributeByIndex(471);

	public AcdAttribute Gizmo_Operation_Radius_Override => SnoData.Attributes.GetAttributeByIndex(472);

	public AcdAttribute Gate_Position => SnoData.Attributes.GetAttributeByIndex(473);

	public AcdAttribute Gate_Velocity => SnoData.Attributes.GetAttributeByIndex(474);

	public AcdAttribute Gizmo_Has_Been_Operated => SnoData.Attributes.GetAttributeByIndex(475);

	public AcdAttribute Banner_Usable => SnoData.Attributes.GetAttributeByIndex(476);

	public AcdAttribute Banner_Player_In_Combat => SnoData.Attributes.GetAttributeByIndex(477);

	public AcdAttribute Pet_Owner => SnoData.Attributes.GetAttributeByIndex(478);

	public AcdAttribute Pet_Creator => SnoData.Attributes.GetAttributeByIndex(479);

	public AcdAttribute Pet_Type => SnoData.Attributes.GetAttributeByIndex(480);

	public AcdAttribute DropsNoLoot => SnoData.Attributes.GetAttributeByIndex(481);

	public AcdAttribute GrantsNoXP => SnoData.Attributes.GetAttributeByIndex(482);

	public AcdAttribute Hireling_Class => SnoData.Attributes.GetAttributeByIndex(483);

	public AcdAttribute Summoned_By_SNO => SnoData.Attributes.GetAttributeByIndex(484);

	public AcdAttribute Pet_Proc_Scalar => SnoData.Attributes.GetAttributeByIndex(485);

	public AcdAttribute Pet_Cannot_Be_Dismissed => SnoData.Attributes.GetAttributeByIndex(486);

	public AcdAttribute Is_NPC => SnoData.Attributes.GetAttributeByIndex(487);

	public AcdAttribute NPC_Is_Operatable => SnoData.Attributes.GetAttributeByIndex(488);

	public AcdAttribute NPC_Is_Escorting => SnoData.Attributes.GetAttributeByIndex(489);

	public AcdAttribute NPC_Has_Interact_Options => SnoData.Attributes.GetAttributeByIndex(490);

	public AcdAttribute Conversation_Icon => SnoData.Attributes.GetAttributeByIndex(491);

	public AcdAttribute Conversation_Icon_Override => SnoData.Attributes.GetAttributeByIndex(492);

	public AcdAttribute Callout_Cooldown => SnoData.Attributes.GetAttributeByIndex(493);

	public AcdAttribute Banter_Cooldown => SnoData.Attributes.GetAttributeByIndex(494);

	public AcdAttribute Conversation_Heard_Count => SnoData.Attributes.GetAttributeByIndex(495);

	public AcdAttribute Last_Tick_Shop_Entered => SnoData.Attributes.GetAttributeByIndex(496);

	public AcdAttribute Is_Helper => SnoData.Attributes.GetAttributeByIndex(497);

	public AcdAttribute Axe => SnoData.Attributes.GetAttributeByIndex(498);

	public AcdAttribute Axe2H => SnoData.Attributes.GetAttributeByIndex(499);

	public AcdAttribute ThrowingAxe => SnoData.Attributes.GetAttributeByIndex(500);

	public AcdAttribute AxeAny => SnoData.Attributes.GetAttributeByIndex(501);

	public AcdAttribute Bow => SnoData.Attributes.GetAttributeByIndex(502);

	public AcdAttribute Crossbow => SnoData.Attributes.GetAttributeByIndex(503);

	public AcdAttribute BowAny => SnoData.Attributes.GetAttributeByIndex(504);

	public AcdAttribute Club => SnoData.Attributes.GetAttributeByIndex(505);

	public AcdAttribute Club2H => SnoData.Attributes.GetAttributeByIndex(506);

	public AcdAttribute ClubAny => SnoData.Attributes.GetAttributeByIndex(507);

	public AcdAttribute Dagger => SnoData.Attributes.GetAttributeByIndex(508);

	public AcdAttribute Mace => SnoData.Attributes.GetAttributeByIndex(509);

	public AcdAttribute Mace2H => SnoData.Attributes.GetAttributeByIndex(510);

	public AcdAttribute MaceAny => SnoData.Attributes.GetAttributeByIndex(511);

	public AcdAttribute Sword => SnoData.Attributes.GetAttributeByIndex(512);

	public AcdAttribute Sword2H => SnoData.Attributes.GetAttributeByIndex(513);

	public AcdAttribute SwordAny => SnoData.Attributes.GetAttributeByIndex(514);

	public AcdAttribute Polearm => SnoData.Attributes.GetAttributeByIndex(515);

	public AcdAttribute Spear => SnoData.Attributes.GetAttributeByIndex(516);

	public AcdAttribute Wand => SnoData.Attributes.GetAttributeByIndex(517);

	public AcdAttribute ColdStaff => SnoData.Attributes.GetAttributeByIndex(518);

	public AcdAttribute FireStaff => SnoData.Attributes.GetAttributeByIndex(519);

	public AcdAttribute LightningStaff => SnoData.Attributes.GetAttributeByIndex(520);

	public AcdAttribute PoisonStaff => SnoData.Attributes.GetAttributeByIndex(521);

	public AcdAttribute StaffAny => SnoData.Attributes.GetAttributeByIndex(522);

	public AcdAttribute Weapon1H => SnoData.Attributes.GetAttributeByIndex(523);

	public AcdAttribute Weapon2H => SnoData.Attributes.GetAttributeByIndex(524);

	public AcdAttribute WeaponMelee => SnoData.Attributes.GetAttributeByIndex(525);

	public AcdAttribute WeaponRanged => SnoData.Attributes.GetAttributeByIndex(526);

	public AcdAttribute Quiver => SnoData.Attributes.GetAttributeByIndex(527);

	public AcdAttribute Reincarnation_Buff => SnoData.Attributes.GetAttributeByIndex(528);

	public AcdAttribute Dead_Body_AnimTag => SnoData.Attributes.GetAttributeByIndex(529);

	public AcdAttribute Spawned_by_ACDID => SnoData.Attributes.GetAttributeByIndex(530);

	public AcdAttribute Summoned_By_ACDID => SnoData.Attributes.GetAttributeByIndex(531);

	public AcdAttribute Summoner_ID => SnoData.Attributes.GetAttributeByIndex(532);

	public AcdAttribute Banner_ACDID => SnoData.Attributes.GetAttributeByIndex(533);

	public AcdAttribute Breakable_Shield_HP => SnoData.Attributes.GetAttributeByIndex(534);

	public AcdAttribute Current_WeaponClass => SnoData.Attributes.GetAttributeByIndex(535);

	public AcdAttribute Weapons_Sheathed => SnoData.Attributes.GetAttributeByIndex(536);

	public AcdAttribute Held_In_OffHand => SnoData.Attributes.GetAttributeByIndex(537);

	public AcdAttribute Attacks_Per_Second_Item_MainHand => SnoData.Attributes.GetAttributeByIndex(538);

	public AcdAttribute Attacks_Per_Second_Item_OffHand => SnoData.Attributes.GetAttributeByIndex(539);

	public AcdAttribute Attacks_Per_Second_Item_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(540);

	public AcdAttribute Attacks_Per_Second_Item_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(541);

	public AcdAttribute Damage_Weapon_Min_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(542);

	public AcdAttribute Damage_Weapon_Min_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(543);

	public AcdAttribute Damage_Weapon_Delta_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(544);

	public AcdAttribute Damage_Weapon_Delta_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(545);

	public AcdAttribute Attacks_Per_Second_Item_CurrentHand => SnoData.Attributes.GetAttributeByIndex(546);

	public AcdAttribute Damage_Weapon_Min_Total_CurrentHand => SnoData.Attributes.GetAttributeByIndex(547);

	public AcdAttribute Damage_Weapon_Delta_Total_CurrentHand => SnoData.Attributes.GetAttributeByIndex(548);

	public AcdAttribute Has_Special_Death_AnimTag => SnoData.Attributes.GetAttributeByIndex(549);

	public AcdAttribute Death_Type_Override => SnoData.Attributes.GetAttributeByIndex(550);

	public AcdAttribute In_Combat => SnoData.Attributes.GetAttributeByIndex(551);

	public AcdAttribute In_Combat_Next_Tick_Check => SnoData.Attributes.GetAttributeByIndex(552);

	public AcdAttribute In_Conversation => SnoData.Attributes.GetAttributeByIndex(553);

	public AcdAttribute Last_Tick_Potion_Used => SnoData.Attributes.GetAttributeByIndex(554);

	public AcdAttribute Potion_Dilution_Percent => SnoData.Attributes.GetAttributeByIndex(555);

	public AcdAttribute Out_Of_Combat_Health_Regen_Percent => SnoData.Attributes.GetAttributeByIndex(556);

	public AcdAttribute Out_Of_Combat_Mana_Regen_Percent => SnoData.Attributes.GetAttributeByIndex(557);

	public AcdAttribute Potion_Dilution_Duration => SnoData.Attributes.GetAttributeByIndex(558);

	public AcdAttribute Potion_Dilution_Scalar => SnoData.Attributes.GetAttributeByIndex(559);

	public AcdAttribute Feared => SnoData.Attributes.GetAttributeByIndex(560);

	public AcdAttribute Fear_Immune => SnoData.Attributes.GetAttributeByIndex(561);

	public AcdAttribute Last_Damage_ACD => SnoData.Attributes.GetAttributeByIndex(562);

	public AcdAttribute Attached_To_ACD => SnoData.Attributes.GetAttributeByIndex(563);

	public AcdAttribute Attachment_ACD => SnoData.Attributes.GetAttributeByIndex(564);

	public AcdAttribute Normal_Attack_Replacement_Power_SNO => SnoData.Attributes.GetAttributeByIndex(565);

	public AcdAttribute Damage_Type_Override => SnoData.Attributes.GetAttributeByIndex(566);

	public AcdAttribute Minion_Count_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(567);

	public AcdAttribute Expensive_Proc_Count => SnoData.Attributes.GetAttributeByIndex(568);

	public AcdAttribute Post_260A_Legendary_Gem_Cap => SnoData.Attributes.GetAttributeByIndex(569);

	public AcdAttribute Pet_Dont_Kill_When_Entering_Rifts => SnoData.Attributes.GetAttributeByIndex(570);

	public AcdAttribute Champion_Clone_Next_Tick => SnoData.Attributes.GetAttributeByIndex(571);

	public AcdAttribute Champion_Clone_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(572);

	public AcdAttribute Champion_Clone_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(573);

	public AcdAttribute Champion_Clone_Hitpoint_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(574);

	public AcdAttribute Champion_Clone_Damage_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(575);

	public AcdAttribute Champion_Ghostly_Next_Tick => SnoData.Attributes.GetAttributeByIndex(576);

	public AcdAttribute Champion_Ghostly_Inactive_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(577);

	public AcdAttribute Champion_Ghostly_Inactive_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(578);

	public AcdAttribute Champion_Ghostly_Active_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(579);

	public AcdAttribute Champion_Ghostly_Active_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(580);

	public AcdAttribute Champion_Ghostly_Saved_Dodge_Chance => SnoData.Attributes.GetAttributeByIndex(581);

	public AcdAttribute Champion_Ghostly => SnoData.Attributes.GetAttributeByIndex(582);

	public AcdAttribute Base_Element => SnoData.Attributes.GetAttributeByIndex(583);

	public AcdAttribute Projectile_Amount_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(584);

	public AcdAttribute Projectile_Reflect_Chance => SnoData.Attributes.GetAttributeByIndex(585);

	public AcdAttribute Projectile_Reflect_Forced_Target => SnoData.Attributes.GetAttributeByIndex(586);

	public AcdAttribute Projectile_Reflect_Damage_Scalar => SnoData.Attributes.GetAttributeByIndex(587);

	public AcdAttribute Projectile_Reflect_Has_Damage_Cap => SnoData.Attributes.GetAttributeByIndex(588);

	public AcdAttribute Projectile_Reflect_Damage_Cap_Remaining => SnoData.Attributes.GetAttributeByIndex(589);

	public AcdAttribute Attack_Fear_Chance => SnoData.Attributes.GetAttributeByIndex(590);

	public AcdAttribute Attack_Fear_Time_Min => SnoData.Attributes.GetAttributeByIndex(591);

	public AcdAttribute Attack_Fear_Time_Delta => SnoData.Attributes.GetAttributeByIndex(592);

	public AcdAttribute Buff_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(593);

	public AcdAttribute Buff_Icon_Start_Tick0 => SnoData.Attributes.GetAttributeByIndex(594);

	public AcdAttribute Buff_Icon_Start_Tick1 => SnoData.Attributes.GetAttributeByIndex(595);

	public AcdAttribute Buff_Icon_Start_Tick2 => SnoData.Attributes.GetAttributeByIndex(596);

	public AcdAttribute Buff_Icon_Start_Tick3 => SnoData.Attributes.GetAttributeByIndex(597);

	public AcdAttribute Buff_Icon_Start_Tick4 => SnoData.Attributes.GetAttributeByIndex(598);

	public AcdAttribute Buff_Icon_Start_Tick5 => SnoData.Attributes.GetAttributeByIndex(599);

	public AcdAttribute Buff_Icon_Start_Tick6 => SnoData.Attributes.GetAttributeByIndex(600);

	public AcdAttribute Buff_Icon_Start_Tick7 => SnoData.Attributes.GetAttributeByIndex(601);

	public AcdAttribute Buff_Icon_Start_Tick8 => SnoData.Attributes.GetAttributeByIndex(602);

	public AcdAttribute Buff_Icon_Start_Tick9 => SnoData.Attributes.GetAttributeByIndex(603);

	public AcdAttribute Buff_Icon_Start_Tick10 => SnoData.Attributes.GetAttributeByIndex(604);

	public AcdAttribute Buff_Icon_Start_Tick11 => SnoData.Attributes.GetAttributeByIndex(605);

	public AcdAttribute Buff_Icon_Start_Tick12 => SnoData.Attributes.GetAttributeByIndex(606);

	public AcdAttribute Buff_Icon_Start_Tick13 => SnoData.Attributes.GetAttributeByIndex(607);

	public AcdAttribute Buff_Icon_Start_Tick14 => SnoData.Attributes.GetAttributeByIndex(608);

	public AcdAttribute Buff_Icon_Start_Tick15 => SnoData.Attributes.GetAttributeByIndex(609);

	public AcdAttribute Buff_Icon_Start_Tick16 => SnoData.Attributes.GetAttributeByIndex(610);

	public AcdAttribute Buff_Icon_Start_Tick17 => SnoData.Attributes.GetAttributeByIndex(611);

	public AcdAttribute Buff_Icon_Start_Tick18 => SnoData.Attributes.GetAttributeByIndex(612);

	public AcdAttribute Buff_Icon_Start_Tick19 => SnoData.Attributes.GetAttributeByIndex(613);

	public AcdAttribute Buff_Icon_Start_Tick20 => SnoData.Attributes.GetAttributeByIndex(614);

	public AcdAttribute Buff_Icon_Start_Tick21 => SnoData.Attributes.GetAttributeByIndex(615);

	public AcdAttribute Buff_Icon_Start_Tick22 => SnoData.Attributes.GetAttributeByIndex(616);

	public AcdAttribute Buff_Icon_Start_Tick23 => SnoData.Attributes.GetAttributeByIndex(617);

	public AcdAttribute Buff_Icon_Start_Tick24 => SnoData.Attributes.GetAttributeByIndex(618);

	public AcdAttribute Buff_Icon_Start_Tick25 => SnoData.Attributes.GetAttributeByIndex(619);

	public AcdAttribute Buff_Icon_Start_Tick26 => SnoData.Attributes.GetAttributeByIndex(620);

	public AcdAttribute Buff_Icon_Start_Tick27 => SnoData.Attributes.GetAttributeByIndex(621);

	public AcdAttribute Buff_Icon_Start_Tick28 => SnoData.Attributes.GetAttributeByIndex(622);

	public AcdAttribute Buff_Icon_Start_Tick29 => SnoData.Attributes.GetAttributeByIndex(623);

	public AcdAttribute Buff_Icon_Start_Tick30 => SnoData.Attributes.GetAttributeByIndex(624);

	public AcdAttribute Buff_Icon_Start_Tick31 => SnoData.Attributes.GetAttributeByIndex(625);

	public AcdAttribute Buff_Icon_End_Tick0 => SnoData.Attributes.GetAttributeByIndex(626);

	public AcdAttribute Buff_Icon_End_Tick1 => SnoData.Attributes.GetAttributeByIndex(627);

	public AcdAttribute Buff_Icon_End_Tick2 => SnoData.Attributes.GetAttributeByIndex(628);

	public AcdAttribute Buff_Icon_End_Tick3 => SnoData.Attributes.GetAttributeByIndex(629);

	public AcdAttribute Buff_Icon_End_Tick4 => SnoData.Attributes.GetAttributeByIndex(630);

	public AcdAttribute Buff_Icon_End_Tick5 => SnoData.Attributes.GetAttributeByIndex(631);

	public AcdAttribute Buff_Icon_End_Tick6 => SnoData.Attributes.GetAttributeByIndex(632);

	public AcdAttribute Buff_Icon_End_Tick7 => SnoData.Attributes.GetAttributeByIndex(633);

	public AcdAttribute Buff_Icon_End_Tick8 => SnoData.Attributes.GetAttributeByIndex(634);

	public AcdAttribute Buff_Icon_End_Tick9 => SnoData.Attributes.GetAttributeByIndex(635);

	public AcdAttribute Buff_Icon_End_Tick10 => SnoData.Attributes.GetAttributeByIndex(636);

	public AcdAttribute Buff_Icon_End_Tick11 => SnoData.Attributes.GetAttributeByIndex(637);

	public AcdAttribute Buff_Icon_End_Tick12 => SnoData.Attributes.GetAttributeByIndex(638);

	public AcdAttribute Buff_Icon_End_Tick13 => SnoData.Attributes.GetAttributeByIndex(639);

	public AcdAttribute Buff_Icon_End_Tick14 => SnoData.Attributes.GetAttributeByIndex(640);

	public AcdAttribute Buff_Icon_End_Tick15 => SnoData.Attributes.GetAttributeByIndex(641);

	public AcdAttribute Buff_Icon_End_Tick16 => SnoData.Attributes.GetAttributeByIndex(642);

	public AcdAttribute Buff_Icon_End_Tick17 => SnoData.Attributes.GetAttributeByIndex(643);

	public AcdAttribute Buff_Icon_End_Tick18 => SnoData.Attributes.GetAttributeByIndex(644);

	public AcdAttribute Buff_Icon_End_Tick19 => SnoData.Attributes.GetAttributeByIndex(645);

	public AcdAttribute Buff_Icon_End_Tick20 => SnoData.Attributes.GetAttributeByIndex(646);

	public AcdAttribute Buff_Icon_End_Tick21 => SnoData.Attributes.GetAttributeByIndex(647);

	public AcdAttribute Buff_Icon_End_Tick22 => SnoData.Attributes.GetAttributeByIndex(648);

	public AcdAttribute Buff_Icon_End_Tick23 => SnoData.Attributes.GetAttributeByIndex(649);

	public AcdAttribute Buff_Icon_End_Tick24 => SnoData.Attributes.GetAttributeByIndex(650);

	public AcdAttribute Buff_Icon_End_Tick25 => SnoData.Attributes.GetAttributeByIndex(651);

	public AcdAttribute Buff_Icon_End_Tick26 => SnoData.Attributes.GetAttributeByIndex(652);

	public AcdAttribute Buff_Icon_End_Tick27 => SnoData.Attributes.GetAttributeByIndex(653);

	public AcdAttribute Buff_Icon_End_Tick28 => SnoData.Attributes.GetAttributeByIndex(654);

	public AcdAttribute Buff_Icon_End_Tick29 => SnoData.Attributes.GetAttributeByIndex(655);

	public AcdAttribute Buff_Icon_End_Tick30 => SnoData.Attributes.GetAttributeByIndex(656);

	public AcdAttribute Buff_Icon_End_Tick31 => SnoData.Attributes.GetAttributeByIndex(657);

	public AcdAttribute Could_Have_Ragdolled => SnoData.Attributes.GetAttributeByIndex(658);

	public AcdAttribute Ambient_Damage_Effect_Last_Time => SnoData.Attributes.GetAttributeByIndex(659);

	public AcdAttribute Scale_Bonus => SnoData.Attributes.GetAttributeByIndex(660);

	public AcdAttribute Scale_Bonus_Is_Immediate => SnoData.Attributes.GetAttributeByIndex(661);

	public AcdAttribute Deleted_On_Server => SnoData.Attributes.GetAttributeByIndex(662);

	public AcdAttribute Scripted_Fade_Time => SnoData.Attributes.GetAttributeByIndex(663);

	public AcdAttribute Does_No_Damage => SnoData.Attributes.GetAttributeByIndex(664);

	public AcdAttribute Does_Fake_Damage => SnoData.Attributes.GetAttributeByIndex(665);

	public AcdAttribute SlowTime_Debuff => SnoData.Attributes.GetAttributeByIndex(666);

	public AcdAttribute Blocks_Projectiles => SnoData.Attributes.GetAttributeByIndex(667);

	public AcdAttribute Frozen => SnoData.Attributes.GetAttributeByIndex(668);

	public AcdAttribute Freeze_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(669);

	public AcdAttribute Shatter_Chance => SnoData.Attributes.GetAttributeByIndex(670);

	public AcdAttribute DualWield_BothAttack_Chance => SnoData.Attributes.GetAttributeByIndex(671);

	public AcdAttribute Summon_Expiration_Tick => SnoData.Attributes.GetAttributeByIndex(672);

	public AcdAttribute Summon_Count => SnoData.Attributes.GetAttributeByIndex(673);

	public AcdAttribute Uninterruptible => SnoData.Attributes.GetAttributeByIndex(674);

	public AcdAttribute QueueDeath => SnoData.Attributes.GetAttributeByIndex(675);

	public AcdAttribute CantStartDisplayedPowers => SnoData.Attributes.GetAttributeByIndex(676);

	public AcdAttribute GizmosIgnoreCantStartDisplayedPowers => SnoData.Attributes.GetAttributeByIndex(677);

	public AcdAttribute Wizard_Slowtime_Proxy_ACD => SnoData.Attributes.GetAttributeByIndex(678);

	public AcdAttribute DPS => SnoData.Attributes.GetAttributeByIndex(679);

	public AcdAttribute Resurrection_Power => SnoData.Attributes.GetAttributeByIndex(680);

	public AcdAttribute Freeze_Damage => SnoData.Attributes.GetAttributeByIndex(681);

	public AcdAttribute Freeze_Capacity => SnoData.Attributes.GetAttributeByIndex(682);

	public AcdAttribute Thaw_Rate => SnoData.Attributes.GetAttributeByIndex(683);

	public AcdAttribute Chilled_Dur_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(684);

	public AcdAttribute DOT_DPS => SnoData.Attributes.GetAttributeByIndex(685);

	public AcdAttribute DamageCap_Percent => SnoData.Attributes.GetAttributeByIndex(686);

	public AcdAttribute Item_Time_Sold => SnoData.Attributes.GetAttributeByIndex(687);

	public AcdAttribute Forced_Hireling_Power => SnoData.Attributes.GetAttributeByIndex(688);

	public AcdAttribute IsRooted => SnoData.Attributes.GetAttributeByIndex(689);

	public AcdAttribute RootTargetACD => SnoData.Attributes.GetAttributeByIndex(690);

	public AcdAttribute RootAutoDecayPerSecond => SnoData.Attributes.GetAttributeByIndex(691);

	public AcdAttribute RootUnitValue => SnoData.Attributes.GetAttributeByIndex(692);

	public AcdAttribute RootTotalTicks => SnoData.Attributes.GetAttributeByIndex(693);

	public AcdAttribute Hide_Affixes => SnoData.Attributes.GetAttributeByIndex(694);

	public AcdAttribute Rune_A => SnoData.Attributes.GetAttributeByIndex(695);

	public AcdAttribute Rune_B => SnoData.Attributes.GetAttributeByIndex(696);

	public AcdAttribute Rune_C => SnoData.Attributes.GetAttributeByIndex(697);

	public AcdAttribute Rune_D => SnoData.Attributes.GetAttributeByIndex(698);

	public AcdAttribute Rune_E => SnoData.Attributes.GetAttributeByIndex(699);

	public AcdAttribute Resistance_Stun => SnoData.Attributes.GetAttributeByIndex(700);

	public AcdAttribute Resistance_Stun_Total => SnoData.Attributes.GetAttributeByIndex(701);

	public AcdAttribute Resistance_Root => SnoData.Attributes.GetAttributeByIndex(702);

	public AcdAttribute Resistance_Root_Total => SnoData.Attributes.GetAttributeByIndex(703);

	public AcdAttribute Resistance_Freeze => SnoData.Attributes.GetAttributeByIndex(704);

	public AcdAttribute Resistance_Freeze_Total => SnoData.Attributes.GetAttributeByIndex(705);

	public AcdAttribute Resistance_StunRootFreeze => SnoData.Attributes.GetAttributeByIndex(706);

	public AcdAttribute CrowdControl_Reduction => SnoData.Attributes.GetAttributeByIndex(707);

	public AcdAttribute Displays_Team_Effect => SnoData.Attributes.GetAttributeByIndex(708);

	public AcdAttribute Cannot_Be_Added_To_AI_Target_List => SnoData.Attributes.GetAttributeByIndex(709);

	public AcdAttribute SkillKit => SnoData.Attributes.GetAttributeByIndex(710);

	public AcdAttribute Immune_To_Charm => SnoData.Attributes.GetAttributeByIndex(711);

	public AcdAttribute Immune_To_Blind => SnoData.Attributes.GetAttributeByIndex(712);

	public AcdAttribute Damage_Shield => SnoData.Attributes.GetAttributeByIndex(713);

	public AcdAttribute Damage_Shield_Amount => SnoData.Attributes.GetAttributeByIndex(714);

	public AcdAttribute Guard_Object_ACDID => SnoData.Attributes.GetAttributeByIndex(715);

	public AcdAttribute Follow_Target_ACDID => SnoData.Attributes.GetAttributeByIndex(716);

	public AcdAttribute Follow_Target_Type => SnoData.Attributes.GetAttributeByIndex(717);

	public AcdAttribute Forced_Enemy_ACDID => SnoData.Attributes.GetAttributeByIndex(718);

	public AcdAttribute NPC_Talk_Target_ANN => SnoData.Attributes.GetAttributeByIndex(719);

	public AcdAttribute NPC_Conv_Target_ANN => SnoData.Attributes.GetAttributeByIndex(720);

	public AcdAttribute Script_Target_ACDID => SnoData.Attributes.GetAttributeByIndex(721);

	public AcdAttribute Look_Target_Server_ANN => SnoData.Attributes.GetAttributeByIndex(722);

	public AcdAttribute Look_Target_Broadcast_Intensity => SnoData.Attributes.GetAttributeByIndex(723);

	public AcdAttribute Look_Target_Broadcast_Radius => SnoData.Attributes.GetAttributeByIndex(724);

	public AcdAttribute Stealthed => SnoData.Attributes.GetAttributeByIndex(725);

	public AcdAttribute GemQuality => SnoData.Attributes.GetAttributeByIndex(726);

	public AcdAttribute Gem_Attributes_Multiplier => SnoData.Attributes.GetAttributeByIndex(727);

	public AcdAttribute ItemBuffIcon => SnoData.Attributes.GetAttributeByIndex(728);

	public AcdAttribute ScrollDuration => SnoData.Attributes.GetAttributeByIndex(729);

	public AcdAttribute Gizmo_Actor_SNO_To_Spawn => SnoData.Attributes.GetAttributeByIndex(730);

	public AcdAttribute Gizmo_Actor_To_Spawn_Scale => SnoData.Attributes.GetAttributeByIndex(731);

	public AcdAttribute Death_Replacement_Power_SNO => SnoData.Attributes.GetAttributeByIndex(732);

	public AcdAttribute Attachment_Handled_By_Client => SnoData.Attributes.GetAttributeByIndex(733);

	public AcdAttribute AI_In_Special_State => SnoData.Attributes.GetAttributeByIndex(734);

	public AcdAttribute AI_Used_Scripted_Spawn_Anim => SnoData.Attributes.GetAttributeByIndex(735);

	public AcdAttribute AI_Spawned_By_Inactive_Marker => SnoData.Attributes.GetAttributeByIndex(736);

	public AcdAttribute Headstone_Player_ANN => SnoData.Attributes.GetAttributeByIndex(737);

	public AcdAttribute Resource_Cost_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(738);

	public AcdAttribute Resource_Cost_Reduction_Percent_Total => SnoData.Attributes.GetAttributeByIndex(739);

	public AcdAttribute Resource_Cost_Reduction_Percent_All => SnoData.Attributes.GetAttributeByIndex(740);

	public AcdAttribute Damage_Type_Cost_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(741);

	public AcdAttribute Resistance_Penetration => SnoData.Attributes.GetAttributeByIndex(742);

	public AcdAttribute Resistance_Penetration_Total => SnoData.Attributes.GetAttributeByIndex(743);

	public AcdAttribute Resistance_Penetration_All => SnoData.Attributes.GetAttributeByIndex(744);

	public AcdAttribute Resistance_Penetration_Percent_All => SnoData.Attributes.GetAttributeByIndex(745);

	public AcdAttribute Fury_Effect_Level => SnoData.Attributes.GetAttributeByIndex(746);

	public AcdAttribute Health_Potion_Bonus_Heal_Percent => SnoData.Attributes.GetAttributeByIndex(747);

	public AcdAttribute Health_Potion_Affects_Allies_Percent => SnoData.Attributes.GetAttributeByIndex(748);

	public AcdAttribute Free_Cast => SnoData.Attributes.GetAttributeByIndex(749);

	public AcdAttribute Free_Cast_All => SnoData.Attributes.GetAttributeByIndex(750);

	public AcdAttribute Health_Cost_Discount => SnoData.Attributes.GetAttributeByIndex(751);

	public AcdAttribute Health_Cost_Scalar => SnoData.Attributes.GetAttributeByIndex(752);

	public AcdAttribute Frailty_Health_Threshold => SnoData.Attributes.GetAttributeByIndex(753);

	public AcdAttribute Frailty_Next_Application_Tick => SnoData.Attributes.GetAttributeByIndex(754);

	public AcdAttribute Movement_Scalar_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(755);

	public AcdAttribute Movement_Scalar_Reduction_Resistance => SnoData.Attributes.GetAttributeByIndex(756);

	public AcdAttribute Damage_Absorb_Percent_All => SnoData.Attributes.GetAttributeByIndex(757);

	public AcdAttribute World_Seed => SnoData.Attributes.GetAttributeByIndex(758);

	public AcdAttribute Kill_Count_Record => SnoData.Attributes.GetAttributeByIndex(759);

	public AcdAttribute Object_Destruction_Record => SnoData.Attributes.GetAttributeByIndex(760);

	public AcdAttribute Single_Attack_Record => SnoData.Attributes.GetAttributeByIndex(761);

	public AcdAttribute Environment_Attack_Record => SnoData.Attributes.GetAttributeByIndex(762);

	public AcdAttribute Nephalem_Glory_Duration_Record => SnoData.Attributes.GetAttributeByIndex(763);

	public AcdAttribute Root_Immune => SnoData.Attributes.GetAttributeByIndex(764);

	public AcdAttribute Monster_Play_Get_Hit_Bonus => SnoData.Attributes.GetAttributeByIndex(765);

	public AcdAttribute Stored_Contact_Frame => SnoData.Attributes.GetAttributeByIndex(766);

	public AcdAttribute Buff_Icon_Count0 => SnoData.Attributes.GetAttributeByIndex(767);

	public AcdAttribute Buff_Icon_Count1 => SnoData.Attributes.GetAttributeByIndex(768);

	public AcdAttribute Buff_Icon_Count2 => SnoData.Attributes.GetAttributeByIndex(769);

	public AcdAttribute Buff_Icon_Count3 => SnoData.Attributes.GetAttributeByIndex(770);

	public AcdAttribute Buff_Icon_Count4 => SnoData.Attributes.GetAttributeByIndex(771);

	public AcdAttribute Buff_Icon_Count5 => SnoData.Attributes.GetAttributeByIndex(772);

	public AcdAttribute Buff_Icon_Count6 => SnoData.Attributes.GetAttributeByIndex(773);

	public AcdAttribute Buff_Icon_Count7 => SnoData.Attributes.GetAttributeByIndex(774);

	public AcdAttribute Buff_Icon_Count8 => SnoData.Attributes.GetAttributeByIndex(775);

	public AcdAttribute Buff_Icon_Count9 => SnoData.Attributes.GetAttributeByIndex(776);

	public AcdAttribute Buff_Icon_Count10 => SnoData.Attributes.GetAttributeByIndex(777);

	public AcdAttribute Buff_Icon_Count11 => SnoData.Attributes.GetAttributeByIndex(778);

	public AcdAttribute Buff_Icon_Count12 => SnoData.Attributes.GetAttributeByIndex(779);

	public AcdAttribute Buff_Icon_Count13 => SnoData.Attributes.GetAttributeByIndex(780);

	public AcdAttribute Buff_Icon_Count14 => SnoData.Attributes.GetAttributeByIndex(781);

	public AcdAttribute Buff_Icon_Count15 => SnoData.Attributes.GetAttributeByIndex(782);

	public AcdAttribute Buff_Icon_Count16 => SnoData.Attributes.GetAttributeByIndex(783);

	public AcdAttribute Buff_Icon_Count17 => SnoData.Attributes.GetAttributeByIndex(784);

	public AcdAttribute Buff_Icon_Count18 => SnoData.Attributes.GetAttributeByIndex(785);

	public AcdAttribute Buff_Icon_Count19 => SnoData.Attributes.GetAttributeByIndex(786);

	public AcdAttribute Buff_Icon_Count20 => SnoData.Attributes.GetAttributeByIndex(787);

	public AcdAttribute Buff_Icon_Count21 => SnoData.Attributes.GetAttributeByIndex(788);

	public AcdAttribute Buff_Icon_Count22 => SnoData.Attributes.GetAttributeByIndex(789);

	public AcdAttribute Buff_Icon_Count23 => SnoData.Attributes.GetAttributeByIndex(790);

	public AcdAttribute Buff_Icon_Count24 => SnoData.Attributes.GetAttributeByIndex(791);

	public AcdAttribute Buff_Icon_Count25 => SnoData.Attributes.GetAttributeByIndex(792);

	public AcdAttribute Buff_Icon_Count26 => SnoData.Attributes.GetAttributeByIndex(793);

	public AcdAttribute Buff_Icon_Count27 => SnoData.Attributes.GetAttributeByIndex(794);

	public AcdAttribute Buff_Icon_Count28 => SnoData.Attributes.GetAttributeByIndex(795);

	public AcdAttribute Buff_Icon_Count29 => SnoData.Attributes.GetAttributeByIndex(796);

	public AcdAttribute Buff_Icon_Count30 => SnoData.Attributes.GetAttributeByIndex(797);

	public AcdAttribute Buff_Icon_Count31 => SnoData.Attributes.GetAttributeByIndex(798);

	public AcdAttribute Observer => SnoData.Attributes.GetAttributeByIndex(799);

	public AcdAttribute Resurrect_As_Observer => SnoData.Attributes.GetAttributeByIndex(800);

	public AcdAttribute Combo_Level => SnoData.Attributes.GetAttributeByIndex(801);

	public AcdAttribute Combo_Time_Last_Move => SnoData.Attributes.GetAttributeByIndex(802);

	public AcdAttribute Burrowed => SnoData.Attributes.GetAttributeByIndex(803);

	public AcdAttribute Death_Replacement_Effect_Group_SNO => SnoData.Attributes.GetAttributeByIndex(804);

	public AcdAttribute Checkpoint_Resurrection_Allowed_Game_Time => SnoData.Attributes.GetAttributeByIndex(805);

	public AcdAttribute Checkpoint_Resurrection_Forced_Game_Time => SnoData.Attributes.GetAttributeByIndex(806);

	public AcdAttribute Corpse_Resurrection_Allowed_Game_Time => SnoData.Attributes.GetAttributeByIndex(807);

	public AcdAttribute Corpse_Resurrection_Charges => SnoData.Attributes.GetAttributeByIndex(808);

	public AcdAttribute Corpse_Resurrection_Disabled => SnoData.Attributes.GetAttributeByIndex(809);

	public AcdAttribute Controlling_TimedEvent_SNO => SnoData.Attributes.GetAttributeByIndex(810);

	public AcdAttribute Casting_Speed_Percent => SnoData.Attributes.GetAttributeByIndex(811);

	public AcdAttribute Using_Bossbar => SnoData.Attributes.GetAttributeByIndex(812);

	public AcdAttribute Power_Buff_0_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(813);

	public AcdAttribute Power_Buff_1_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(814);

	public AcdAttribute Power_Buff_2_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(815);

	public AcdAttribute Power_Buff_3_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(816);

	public AcdAttribute Power_Buff_4_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(817);

	public AcdAttribute Power_Buff_5_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(818);

	public AcdAttribute Power_Buff_6_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(819);

	public AcdAttribute Power_Buff_7_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(820);

	public AcdAttribute Power_Buff_8_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(821);

	public AcdAttribute Power_Buff_9_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(822);

	public AcdAttribute Power_Buff_10_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(823);

	public AcdAttribute Power_Buff_11_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(824);

	public AcdAttribute Power_Buff_12_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(825);

	public AcdAttribute Power_Buff_13_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(826);

	public AcdAttribute Power_Buff_14_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(827);

	public AcdAttribute Power_Buff_15_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(828);

	public AcdAttribute Power_Buff_16_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(829);

	public AcdAttribute Power_Buff_17_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(830);

	public AcdAttribute Power_Buff_18_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(831);

	public AcdAttribute Power_Buff_19_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(832);

	public AcdAttribute Power_Buff_20_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(833);

	public AcdAttribute Power_Buff_21_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(834);

	public AcdAttribute Power_Buff_22_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(835);

	public AcdAttribute Power_Buff_23_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(836);

	public AcdAttribute Power_Buff_24_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(837);

	public AcdAttribute Power_Buff_25_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(838);

	public AcdAttribute Power_Buff_26_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(839);

	public AcdAttribute Power_Buff_27_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(840);

	public AcdAttribute Power_Buff_28_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(841);

	public AcdAttribute Power_Buff_29_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(842);

	public AcdAttribute Power_Buff_30_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(843);

	public AcdAttribute Power_Buff_31_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(844);

	public AcdAttribute StoreSNO => SnoData.Attributes.GetAttributeByIndex(845);

	public AcdAttribute Busy => SnoData.Attributes.GetAttributeByIndex(846);

	public AcdAttribute Afk => SnoData.Attributes.GetAttributeByIndex(847);

	public AcdAttribute LorePlaying => SnoData.Attributes.GetAttributeByIndex(848);

	public AcdAttribute LastActionTimestamp => SnoData.Attributes.GetAttributeByIndex(849);

	public AcdAttribute PortalNextTime => SnoData.Attributes.GetAttributeByIndex(850);

	public AcdAttribute Repair_Discount_Percent => SnoData.Attributes.GetAttributeByIndex(851);

	public AcdAttribute Resource_Degeneration_Prevented => SnoData.Attributes.GetAttributeByIndex(852);

	public AcdAttribute Operatable => SnoData.Attributes.GetAttributeByIndex(853);

	public AcdAttribute Has_Look_Override => SnoData.Attributes.GetAttributeByIndex(854);

	public AcdAttribute Spawner_Concurrent_Count_ID => SnoData.Attributes.GetAttributeByIndex(855);

	public AcdAttribute Disabled => SnoData.Attributes.GetAttributeByIndex(856);

	public AcdAttribute Skill_Override => SnoData.Attributes.GetAttributeByIndex(857);

	public AcdAttribute Skill_Override_Active => SnoData.Attributes.GetAttributeByIndex(858);

	public AcdAttribute Skill_Override_Ended => SnoData.Attributes.GetAttributeByIndex(859);

	public AcdAttribute Skill_Override_Ended_Active => SnoData.Attributes.GetAttributeByIndex(860);

	public AcdAttribute Is_Power_Proxy => SnoData.Attributes.GetAttributeByIndex(861);

	public AcdAttribute Force_No_Death_Animation => SnoData.Attributes.GetAttributeByIndex(862);

	public AcdAttribute Player_WeaponClass_Anim_Override => SnoData.Attributes.GetAttributeByIndex(863);

	public AcdAttribute Operatable_Story_Gizmo => SnoData.Attributes.GetAttributeByIndex(864);

	public AcdAttribute Power_Buff_0_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(865);

	public AcdAttribute Power_Buff_0_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(866);

	public AcdAttribute Power_Buff_0_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(867);

	public AcdAttribute Power_Buff_0_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(868);

	public AcdAttribute Power_Buff_0_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(869);

	public AcdAttribute Power_Buff_0_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(870);

	public AcdAttribute Power_Buff_1_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(871);

	public AcdAttribute Power_Buff_1_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(872);

	public AcdAttribute Power_Buff_1_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(873);

	public AcdAttribute Power_Buff_1_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(874);

	public AcdAttribute Power_Buff_1_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(875);

	public AcdAttribute Power_Buff_1_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(876);

	public AcdAttribute Power_Buff_2_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(877);

	public AcdAttribute Power_Buff_2_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(878);

	public AcdAttribute Power_Buff_2_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(879);

	public AcdAttribute Power_Buff_2_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(880);

	public AcdAttribute Power_Buff_2_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(881);

	public AcdAttribute Power_Buff_2_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(882);

	public AcdAttribute Power_Buff_3_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(883);

	public AcdAttribute Power_Buff_3_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(884);

	public AcdAttribute Power_Buff_3_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(885);

	public AcdAttribute Power_Buff_3_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(886);

	public AcdAttribute Power_Buff_3_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(887);

	public AcdAttribute Power_Buff_3_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(888);

	public AcdAttribute Power_Buff_4_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(889);

	public AcdAttribute Power_Buff_4_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(890);

	public AcdAttribute Power_Buff_4_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(891);

	public AcdAttribute Power_Buff_4_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(892);

	public AcdAttribute Power_Buff_4_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(893);

	public AcdAttribute Power_Buff_4_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(894);

	public AcdAttribute Power_Buff_5_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(895);

	public AcdAttribute Power_Buff_5_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(896);

	public AcdAttribute Power_Buff_5_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(897);

	public AcdAttribute Power_Buff_5_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(898);

	public AcdAttribute Power_Buff_5_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(899);

	public AcdAttribute Power_Buff_5_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(900);

	public AcdAttribute Power_Buff_6_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(901);

	public AcdAttribute Power_Buff_6_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(902);

	public AcdAttribute Power_Buff_6_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(903);

	public AcdAttribute Power_Buff_6_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(904);

	public AcdAttribute Power_Buff_6_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(905);

	public AcdAttribute Power_Buff_6_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(906);

	public AcdAttribute Power_Buff_7_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(907);

	public AcdAttribute Power_Buff_7_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(908);

	public AcdAttribute Power_Buff_7_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(909);

	public AcdAttribute Power_Buff_7_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(910);

	public AcdAttribute Power_Buff_7_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(911);

	public AcdAttribute Power_Buff_7_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(912);

	public AcdAttribute Power_Buff_8_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(913);

	public AcdAttribute Power_Buff_8_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(914);

	public AcdAttribute Power_Buff_8_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(915);

	public AcdAttribute Power_Buff_8_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(916);

	public AcdAttribute Power_Buff_8_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(917);

	public AcdAttribute Power_Buff_8_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(918);

	public AcdAttribute Power_Buff_9_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(919);

	public AcdAttribute Power_Buff_9_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(920);

	public AcdAttribute Power_Buff_9_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(921);

	public AcdAttribute Power_Buff_9_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(922);

	public AcdAttribute Power_Buff_9_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(923);

	public AcdAttribute Power_Buff_9_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(924);

	public AcdAttribute Power_Buff_10_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(925);

	public AcdAttribute Power_Buff_10_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(926);

	public AcdAttribute Power_Buff_10_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(927);

	public AcdAttribute Power_Buff_10_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(928);

	public AcdAttribute Power_Buff_10_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(929);

	public AcdAttribute Power_Buff_10_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(930);

	public AcdAttribute Power_Buff_11_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(931);

	public AcdAttribute Power_Buff_11_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(932);

	public AcdAttribute Power_Buff_11_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(933);

	public AcdAttribute Power_Buff_11_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(934);

	public AcdAttribute Power_Buff_11_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(935);

	public AcdAttribute Power_Buff_11_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(936);

	public AcdAttribute Power_Buff_12_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(937);

	public AcdAttribute Power_Buff_12_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(938);

	public AcdAttribute Power_Buff_12_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(939);

	public AcdAttribute Power_Buff_12_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(940);

	public AcdAttribute Power_Buff_12_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(941);

	public AcdAttribute Power_Buff_12_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(942);

	public AcdAttribute Power_Buff_13_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(943);

	public AcdAttribute Power_Buff_13_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(944);

	public AcdAttribute Power_Buff_13_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(945);

	public AcdAttribute Power_Buff_13_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(946);

	public AcdAttribute Power_Buff_13_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(947);

	public AcdAttribute Power_Buff_13_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(948);

	public AcdAttribute Power_Buff_14_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(949);

	public AcdAttribute Power_Buff_14_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(950);

	public AcdAttribute Power_Buff_14_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(951);

	public AcdAttribute Power_Buff_14_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(952);

	public AcdAttribute Power_Buff_14_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(953);

	public AcdAttribute Power_Buff_14_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(954);

	public AcdAttribute Power_Buff_15_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(955);

	public AcdAttribute Power_Buff_15_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(956);

	public AcdAttribute Power_Buff_15_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(957);

	public AcdAttribute Power_Buff_15_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(958);

	public AcdAttribute Power_Buff_15_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(959);

	public AcdAttribute Power_Buff_15_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(960);

	public AcdAttribute Power_Buff_16_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(961);

	public AcdAttribute Power_Buff_16_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(962);

	public AcdAttribute Power_Buff_16_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(963);

	public AcdAttribute Power_Buff_16_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(964);

	public AcdAttribute Power_Buff_16_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(965);

	public AcdAttribute Power_Buff_16_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(966);

	public AcdAttribute Power_Buff_17_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(967);

	public AcdAttribute Power_Buff_17_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(968);

	public AcdAttribute Power_Buff_17_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(969);

	public AcdAttribute Power_Buff_17_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(970);

	public AcdAttribute Power_Buff_17_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(971);

	public AcdAttribute Power_Buff_17_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(972);

	public AcdAttribute Power_Buff_18_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(973);

	public AcdAttribute Power_Buff_18_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(974);

	public AcdAttribute Power_Buff_18_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(975);

	public AcdAttribute Power_Buff_18_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(976);

	public AcdAttribute Power_Buff_18_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(977);

	public AcdAttribute Power_Buff_18_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(978);

	public AcdAttribute Power_Buff_19_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(979);

	public AcdAttribute Power_Buff_19_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(980);

	public AcdAttribute Power_Buff_19_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(981);

	public AcdAttribute Power_Buff_19_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(982);

	public AcdAttribute Power_Buff_19_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(983);

	public AcdAttribute Power_Buff_19_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(984);

	public AcdAttribute Power_Buff_20_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(985);

	public AcdAttribute Power_Buff_20_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(986);

	public AcdAttribute Power_Buff_20_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(987);

	public AcdAttribute Power_Buff_20_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(988);

	public AcdAttribute Power_Buff_20_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(989);

	public AcdAttribute Power_Buff_20_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(990);

	public AcdAttribute Power_Buff_21_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(991);

	public AcdAttribute Power_Buff_21_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(992);

	public AcdAttribute Power_Buff_21_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(993);

	public AcdAttribute Power_Buff_21_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(994);

	public AcdAttribute Power_Buff_21_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(995);

	public AcdAttribute Power_Buff_21_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(996);

	public AcdAttribute Power_Buff_22_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(997);

	public AcdAttribute Power_Buff_22_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(998);

	public AcdAttribute Power_Buff_22_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(999);

	public AcdAttribute Power_Buff_22_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1000);

	public AcdAttribute Power_Buff_22_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1001);

	public AcdAttribute Power_Buff_22_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1002);

	public AcdAttribute Power_Buff_23_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1003);

	public AcdAttribute Power_Buff_23_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1004);

	public AcdAttribute Power_Buff_23_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1005);

	public AcdAttribute Power_Buff_23_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1006);

	public AcdAttribute Power_Buff_23_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1007);

	public AcdAttribute Power_Buff_23_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1008);

	public AcdAttribute Power_Buff_24_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1009);

	public AcdAttribute Power_Buff_24_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1010);

	public AcdAttribute Power_Buff_24_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1011);

	public AcdAttribute Power_Buff_24_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1012);

	public AcdAttribute Power_Buff_24_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1013);

	public AcdAttribute Power_Buff_24_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1014);

	public AcdAttribute Power_Buff_25_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1015);

	public AcdAttribute Power_Buff_25_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1016);

	public AcdAttribute Power_Buff_25_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1017);

	public AcdAttribute Power_Buff_25_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1018);

	public AcdAttribute Power_Buff_25_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1019);

	public AcdAttribute Power_Buff_25_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1020);

	public AcdAttribute Power_Buff_26_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1021);

	public AcdAttribute Power_Buff_26_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1022);

	public AcdAttribute Power_Buff_26_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1023);

	public AcdAttribute Power_Buff_26_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1024);

	public AcdAttribute Power_Buff_26_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1025);

	public AcdAttribute Power_Buff_26_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1026);

	public AcdAttribute Power_Buff_27_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1027);

	public AcdAttribute Power_Buff_27_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1028);

	public AcdAttribute Power_Buff_27_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1029);

	public AcdAttribute Power_Buff_27_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1030);

	public AcdAttribute Power_Buff_27_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1031);

	public AcdAttribute Power_Buff_27_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1032);

	public AcdAttribute Power_Buff_28_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1033);

	public AcdAttribute Power_Buff_28_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1034);

	public AcdAttribute Power_Buff_28_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1035);

	public AcdAttribute Power_Buff_28_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1036);

	public AcdAttribute Power_Buff_28_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1037);

	public AcdAttribute Power_Buff_28_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1038);

	public AcdAttribute Power_Buff_29_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1039);

	public AcdAttribute Power_Buff_29_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1040);

	public AcdAttribute Power_Buff_29_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1041);

	public AcdAttribute Power_Buff_29_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1042);

	public AcdAttribute Power_Buff_29_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1043);

	public AcdAttribute Power_Buff_29_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1044);

	public AcdAttribute Power_Buff_30_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1045);

	public AcdAttribute Power_Buff_30_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1046);

	public AcdAttribute Power_Buff_30_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1047);

	public AcdAttribute Power_Buff_30_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1048);

	public AcdAttribute Power_Buff_30_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1049);

	public AcdAttribute Power_Buff_30_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1050);

	public AcdAttribute Power_Buff_31_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1051);

	public AcdAttribute Power_Buff_31_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1052);

	public AcdAttribute Power_Buff_31_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1053);

	public AcdAttribute Power_Buff_31_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1054);

	public AcdAttribute Power_Buff_31_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1055);

	public AcdAttribute Power_Buff_31_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1056);

	public AcdAttribute Walk_Passability_Power_SNO => SnoData.Attributes.GetAttributeByIndex(1057);

	public AcdAttribute Passability_Power_SNO => SnoData.Attributes.GetAttributeByIndex(1058);

	public AcdAttribute Flippy_ID => SnoData.Attributes.GetAttributeByIndex(1059);

	public AcdAttribute Summoning_Machine_Num_Casters => SnoData.Attributes.GetAttributeByIndex(1060);

	public AcdAttribute Summoning_Machine_Spawn_Count => SnoData.Attributes.GetAttributeByIndex(1061);

	public AcdAttribute Summoning_Machine_Next_Spawn_Ticks => SnoData.Attributes.GetAttributeByIndex(1062);

	public AcdAttribute Summoning_Machine_Spawn_Team => SnoData.Attributes.GetAttributeByIndex(1063);

	public AcdAttribute Screen_Attack_Radius_Constant => SnoData.Attributes.GetAttributeByIndex(1064);

	public AcdAttribute MaxDamage_Done_Reduction_Percent1 => SnoData.Attributes.GetAttributeByIndex(1065);

	public AcdAttribute Set_Item_Count => SnoData.Attributes.GetAttributeByIndex(1066);

	public AcdAttribute Set_Bonus_Count => SnoData.Attributes.GetAttributeByIndex(1067);

	public AcdAttribute Spawner_Countdown_Percent => SnoData.Attributes.GetAttributeByIndex(1068);

	public AcdAttribute Attack_Slow => SnoData.Attributes.GetAttributeByIndex(1069);

	public AcdAttribute Power_Disabled => SnoData.Attributes.GetAttributeByIndex(1070);

	public AcdAttribute Weapon_Effect_Override => SnoData.Attributes.GetAttributeByIndex(1071);

	public AcdAttribute Debuff_Duration_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(1072);

	public AcdAttribute Uses_PvP_Power_Tags => SnoData.Attributes.GetAttributeByIndex(1073);

	public AcdAttribute Trait => SnoData.Attributes.GetAttributeByIndex(1074);

	public AcdAttribute Last_ACD_Attacked_By => SnoData.Attributes.GetAttributeByIndex(1075);

	public AcdAttribute Gold_PickUp_Radius => SnoData.Attributes.GetAttributeByIndex(1076);

	public AcdAttribute ClientOnlyEffect => SnoData.Attributes.GetAttributeByIndex(1077);

	public AcdAttribute Power_Saved_Attribute => SnoData.Attributes.GetAttributeByIndex(1078);

	public AcdAttribute Resource_Gain_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(1079);

	public AcdAttribute Looping_Animation_Start_Time => SnoData.Attributes.GetAttributeByIndex(1080);

	public AcdAttribute Looping_Animation_End_Time => SnoData.Attributes.GetAttributeByIndex(1081);

	public AcdAttribute Looping_Animation_Suppress_Item_Tooltips => SnoData.Attributes.GetAttributeByIndex(1082);

	public AcdAttribute Heal_Effect_Last_Played_Tick => SnoData.Attributes.GetAttributeByIndex(1083);

	public AcdAttribute Resource_Effect_Last_Played_tick => SnoData.Attributes.GetAttributeByIndex(1084);

	public AcdAttribute Thorns_Effect_Last_Played_tick => SnoData.Attributes.GetAttributeByIndex(1085);

	public AcdAttribute PVP_Kills => SnoData.Attributes.GetAttributeByIndex(1086);

	public AcdAttribute PVP_Deaths => SnoData.Attributes.GetAttributeByIndex(1087);

	public AcdAttribute PVP_Assists => SnoData.Attributes.GetAttributeByIndex(1088);

	public AcdAttribute PVP_Progression_Points_Gained => SnoData.Attributes.GetAttributeByIndex(1089);

	public AcdAttribute PVP_Current_Kill_Streak => SnoData.Attributes.GetAttributeByIndex(1090);

	public AcdAttribute PVP_Current_Death_Streak => SnoData.Attributes.GetAttributeByIndex(1091);

	public AcdAttribute PVP_Longest_Kill_Streak => SnoData.Attributes.GetAttributeByIndex(1092);

	public AcdAttribute PVP_Longest_Death_Streak => SnoData.Attributes.GetAttributeByIndex(1093);

	public AcdAttribute Turn_Rate_Scalar => SnoData.Attributes.GetAttributeByIndex(1094);

	public AcdAttribute Turn_Accel_Scalar => SnoData.Attributes.GetAttributeByIndex(1095);

	public AcdAttribute Turn_Deccel_Scalar => SnoData.Attributes.GetAttributeByIndex(1096);

	public AcdAttribute No_Health_Drop => SnoData.Attributes.GetAttributeByIndex(1097);

	public AcdAttribute Leader => SnoData.Attributes.GetAttributeByIndex(1098);

	public AcdAttribute IsContentRestrictedActor => SnoData.Attributes.GetAttributeByIndex(1099);

	public AcdAttribute InBossEncounter => SnoData.Attributes.GetAttributeByIndex(1100);

	public AcdAttribute God => SnoData.Attributes.GetAttributeByIndex(1101);

	public AcdAttribute AllowSkillChanges => SnoData.Attributes.GetAttributeByIndex(1102);

	public AcdAttribute MinimapActive => SnoData.Attributes.GetAttributeByIndex(1103);

	public AcdAttribute MinimapIconOverride => SnoData.Attributes.GetAttributeByIndex(1104);

	public AcdAttribute MinimapDisableArrow => SnoData.Attributes.GetAttributeByIndex(1105);

	public AcdAttribute Last_Blocked_ACD => SnoData.Attributes.GetAttributeByIndex(1106);

	public AcdAttribute Last_Blocked_Time => SnoData.Attributes.GetAttributeByIndex(1107);

	public AcdAttribute DeactivateLure => SnoData.Attributes.GetAttributeByIndex(1108);

	public AcdAttribute Weapons_Hidden => SnoData.Attributes.GetAttributeByIndex(1109);

	public AcdAttribute Main_Hand_Weapon_Hidden => SnoData.Attributes.GetAttributeByIndex(1110);

	public AcdAttribute Off_Hand_Weapon_Hidden => SnoData.Attributes.GetAttributeByIndex(1111);

	public AcdAttribute Actor_Updates_Attributes_From_Owner => SnoData.Attributes.GetAttributeByIndex(1112);

	public AcdAttribute Taunt_Target_ACD => SnoData.Attributes.GetAttributeByIndex(1113);

	public AcdAttribute Charm_Source_ACD => SnoData.Attributes.GetAttributeByIndex(1114);

	public AcdAttribute UI_Only_Percent_Damage_Increase => SnoData.Attributes.GetAttributeByIndex(1115);

	public AcdAttribute Projectile_Effect_SNO => SnoData.Attributes.GetAttributeByIndex(1116);

	public AcdAttribute On_Hit_Fear_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1117);

	public AcdAttribute On_Hit_Stun_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1118);

	public AcdAttribute On_Hit_Blind_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1119);

	public AcdAttribute On_Hit_Freeze_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1120);

	public AcdAttribute On_Hit_Chill_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1121);

	public AcdAttribute On_Hit_Slow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1122);

	public AcdAttribute On_Hit_Immobilize_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1123);

	public AcdAttribute On_Hit_Knockback_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1124);

	public AcdAttribute On_Hit_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1125);

	public AcdAttribute On_Hit_Bleed_Proc_Damage_Base => SnoData.Attributes.GetAttributeByIndex(1126);

	public AcdAttribute On_Hit_Bleed_Proc_Damage_Delta => SnoData.Attributes.GetAttributeByIndex(1127);

	public AcdAttribute Damage_Percent_Reduction_From_Ranged => SnoData.Attributes.GetAttributeByIndex(1128);

	public AcdAttribute Damage_Percent_Reduction_From_Melee => SnoData.Attributes.GetAttributeByIndex(1129);

	public AcdAttribute Damage_Percent_Reduction_Turns_Into_Heal => SnoData.Attributes.GetAttributeByIndex(1130);

	public AcdAttribute Damage_Percent_Reduction_From_Elites => SnoData.Attributes.GetAttributeByIndex(1131);

	public AcdAttribute Damage_Percent_Reduction_From_Type => SnoData.Attributes.GetAttributeByIndex(1132);

	public AcdAttribute Damage_Percent_Bonus_Vs_Monster_Type => SnoData.Attributes.GetAttributeByIndex(1133);

	public AcdAttribute Damage_Percent_Bonus_Vs_Elites => SnoData.Attributes.GetAttributeByIndex(1134);

	public AcdAttribute Item_Manipulation_Timeout => SnoData.Attributes.GetAttributeByIndex(1135);

	public AcdAttribute Picked_Up_Time => SnoData.Attributes.GetAttributeByIndex(1136);

	public AcdAttribute UnequippedTime => SnoData.Attributes.GetAttributeByIndex(1137);

	public AcdAttribute Last_ACD_Killed_Time => SnoData.Attributes.GetAttributeByIndex(1138);

	public AcdAttribute CannotDieDuring => SnoData.Attributes.GetAttributeByIndex(1139);

	public AcdAttribute Weapon_On_Hit_Fear_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1140);

	public AcdAttribute Weapon_On_Hit_Stun_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1141);

	public AcdAttribute Weapon_On_Hit_Blind_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1142);

	public AcdAttribute Weapon_On_Hit_Freeze_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1143);

	public AcdAttribute Weapon_On_Hit_Chill_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1144);

	public AcdAttribute Weapon_On_Hit_Slow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1145);

	public AcdAttribute Weapon_On_Hit_Immobilize_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1146);

	public AcdAttribute Weapon_On_Hit_Knockback_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1147);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1148);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base => SnoData.Attributes.GetAttributeByIndex(1149);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta => SnoData.Attributes.GetAttributeByIndex(1150);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1151);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage => SnoData.Attributes.GetAttributeByIndex(1152);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration => SnoData.Attributes.GetAttributeByIndex(1153);

	public AcdAttribute Weapon_On_Hit_Fear_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1154);

	public AcdAttribute Weapon_On_Hit_Fear_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1155);

	public AcdAttribute Weapon_On_Hit_Fear_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1156);

	public AcdAttribute Weapon_On_Hit_Stun_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1157);

	public AcdAttribute Weapon_On_Hit_Stun_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1158);

	public AcdAttribute Weapon_On_Hit_Stun_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1159);

	public AcdAttribute Weapon_On_Hit_Blind_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1160);

	public AcdAttribute Weapon_On_Hit_Blind_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1161);

	public AcdAttribute Weapon_On_Hit_Blind_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1162);

	public AcdAttribute Weapon_On_Hit_Freeze_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1163);

	public AcdAttribute Weapon_On_Hit_Freeze_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1164);

	public AcdAttribute Weapon_On_Hit_Freeze_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1165);

	public AcdAttribute Weapon_On_Hit_Chill_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1166);

	public AcdAttribute Weapon_On_Hit_Chill_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1167);

	public AcdAttribute Weapon_On_Hit_Chill_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1168);

	public AcdAttribute Weapon_On_Hit_Slow_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1169);

	public AcdAttribute Weapon_On_Hit_Slow_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1170);

	public AcdAttribute Weapon_On_Hit_Slow_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1171);

	public AcdAttribute Weapon_On_Hit_Immobilize_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1172);

	public AcdAttribute Weapon_On_Hit_Immobilize_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1173);

	public AcdAttribute Weapon_On_Hit_Immobilize_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1174);

	public AcdAttribute Weapon_On_Hit_Knockback_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1175);

	public AcdAttribute Weapon_On_Hit_Knockback_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1176);

	public AcdAttribute Weapon_On_Hit_Knockback_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1177);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1178);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1179);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1180);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_MainHand => SnoData.Attributes.GetAttributeByIndex(1181);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_OffHand => SnoData.Attributes.GetAttributeByIndex(1182);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1183);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_MainHand => SnoData.Attributes.GetAttributeByIndex(1184);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_OffHand => SnoData.Attributes.GetAttributeByIndex(1185);

	public AcdAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1186);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1187);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1188);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1189);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_MainHand => SnoData.Attributes.GetAttributeByIndex(1190);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_Base_OffHand => SnoData.Attributes.GetAttributeByIndex(1191);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_Base_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1192);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_MainHand => SnoData.Attributes.GetAttributeByIndex(1193);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_OffHand => SnoData.Attributes.GetAttributeByIndex(1194);

	public AcdAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1195);

	public AcdAttribute Power_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1196);

	public AcdAttribute Power_Instance_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1197);

	public AcdAttribute Power_Resource_Reduction => SnoData.Attributes.GetAttributeByIndex(1198);

	public AcdAttribute Power_Resource_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(1199);

	public AcdAttribute Power_Cooldown_Reduction => SnoData.Attributes.GetAttributeByIndex(1200);

	public AcdAttribute Power_Cooldown_Reduction_All => SnoData.Attributes.GetAttributeByIndex(1201);

	public AcdAttribute Power_Duration_Increase => SnoData.Attributes.GetAttributeByIndex(1202);

	public AcdAttribute Power_Crit_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1203);

	public AcdAttribute Weapon_Crit_Chance => SnoData.Attributes.GetAttributeByIndex(1204);

	public AcdAttribute Weapon_Crit_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1205);

	public AcdAttribute Weapon_Crit_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1206);

	public AcdAttribute Weapon_Crit_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1207);

	public AcdAttribute Strength_Item => SnoData.Attributes.GetAttributeByIndex(1208);

	public AcdAttribute Dexterity_Item => SnoData.Attributes.GetAttributeByIndex(1209);

	public AcdAttribute Intelligence_Item => SnoData.Attributes.GetAttributeByIndex(1210);

	public AcdAttribute Vitality_Item => SnoData.Attributes.GetAttributeByIndex(1211);

	public AcdAttribute Item_Level_Requirement_Reduction => SnoData.Attributes.GetAttributeByIndex(1212);

	public AcdAttribute Item_Level_Requirement_Override => SnoData.Attributes.GetAttributeByIndex(1213);

	public AcdAttribute Item_Durability_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1214);

	public AcdAttribute Item_Indestructible => SnoData.Attributes.GetAttributeByIndex(1215);

	public AcdAttribute Player_All_Items_Indestructible => SnoData.Attributes.GetAttributeByIndex(1216);

	public AcdAttribute Core_Attributes_From_Item_Bonus_Multiplier => SnoData.Attributes.GetAttributeByIndex(1217);

	public AcdAttribute Waiting_To_Accept_Resurrection => SnoData.Attributes.GetAttributeByIndex(1218);

	public AcdAttribute Ghosted => SnoData.Attributes.GetAttributeByIndex(1219);

	public AcdAttribute Special_Inventory_Has_Sold => SnoData.Attributes.GetAttributeByIndex(1220);

	public AcdAttribute Special_Inventory_Index => SnoData.Attributes.GetAttributeByIndex(1221);

	public AcdAttribute Inventory_Reroll_Time => SnoData.Attributes.GetAttributeByIndex(1222);

	public AcdAttribute Perk_Buff_Poll_Next_Time => SnoData.Attributes.GetAttributeByIndex(1223);

	public AcdAttribute Limited_Duration_Item_Poll_Next_Time => SnoData.Attributes.GetAttributeByIndex(1224);

	public AcdAttribute Power_Channel_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1225);

	public AcdAttribute Power_Buff_0_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1226);

	public AcdAttribute Power_Buff_1_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1227);

	public AcdAttribute Power_Buff_2_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1228);

	public AcdAttribute Power_Buff_3_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1229);

	public AcdAttribute Power_Buff_4_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1230);

	public AcdAttribute Power_Buff_5_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1231);

	public AcdAttribute Power_Buff_6_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1232);

	public AcdAttribute Power_Buff_7_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1233);

	public AcdAttribute Power_Buff_8_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1234);

	public AcdAttribute Power_Buff_9_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1235);

	public AcdAttribute Power_Buff_10_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1236);

	public AcdAttribute Power_Buff_11_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1237);

	public AcdAttribute Power_Buff_12_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1238);

	public AcdAttribute Power_Buff_13_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1239);

	public AcdAttribute Power_Buff_14_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1240);

	public AcdAttribute Power_Buff_15_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1241);

	public AcdAttribute Power_Buff_16_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1242);

	public AcdAttribute Power_Buff_17_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1243);

	public AcdAttribute Power_Buff_18_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1244);

	public AcdAttribute Power_Buff_19_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1245);

	public AcdAttribute Power_Buff_20_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1246);

	public AcdAttribute Power_Buff_21_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1247);

	public AcdAttribute Power_Buff_22_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1248);

	public AcdAttribute Power_Buff_23_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1249);

	public AcdAttribute Power_Buff_24_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1250);

	public AcdAttribute Power_Buff_25_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1251);

	public AcdAttribute Power_Buff_26_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1252);

	public AcdAttribute Power_Buff_27_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1253);

	public AcdAttribute Power_Buff_28_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1254);

	public AcdAttribute Power_Buff_29_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1255);

	public AcdAttribute Power_Buff_30_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1256);

	public AcdAttribute Power_Buff_31_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1257);

	public AcdAttribute Known_By_Owner => SnoData.Attributes.GetAttributeByIndex(1258);

	public AcdAttribute Never_Deactivates => SnoData.Attributes.GetAttributeByIndex(1259);

	public AcdAttribute Account_Under_Review => SnoData.Attributes.GetAttributeByIndex(1260);

	public AcdAttribute Projectile_Detonate_Time => SnoData.Attributes.GetAttributeByIndex(1261);

	public AcdAttribute Projectile_Uncapped_Lifetime => SnoData.Attributes.GetAttributeByIndex(1262);

	public AcdAttribute PageOfFate_Item => SnoData.Attributes.GetAttributeByIndex(1263);

	public AcdAttribute Accolade_0 => SnoData.Attributes.GetAttributeByIndex(1264);

	public AcdAttribute Accolade_1 => SnoData.Attributes.GetAttributeByIndex(1265);

	public AcdAttribute Accolade_2 => SnoData.Attributes.GetAttributeByIndex(1266);

	public AcdAttribute Accolade_3 => SnoData.Attributes.GetAttributeByIndex(1267);

	public AcdAttribute Accolade_4 => SnoData.Attributes.GetAttributeByIndex(1268);

	public AcdAttribute Accolade_0_Value => SnoData.Attributes.GetAttributeByIndex(1269);

	public AcdAttribute Accolade_1_Value => SnoData.Attributes.GetAttributeByIndex(1270);

	public AcdAttribute Accolade_2_Value => SnoData.Attributes.GetAttributeByIndex(1271);

	public AcdAttribute Accolade_3_Value => SnoData.Attributes.GetAttributeByIndex(1272);

	public AcdAttribute Accolade_4_Value => SnoData.Attributes.GetAttributeByIndex(1273);

	public AcdAttribute PVP_Rank => SnoData.Attributes.GetAttributeByIndex(1274);

	public AcdAttribute PVP_Tokens => SnoData.Attributes.GetAttributeByIndex(1275);

	public AcdAttribute PVP_Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(1276);

	public AcdAttribute PVP_Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(1277);

	public AcdAttribute PVP_Gold_Gained_This_Game => SnoData.Attributes.GetAttributeByIndex(1278);

	public AcdAttribute PVP_PVP_Experience_Gained_This_Game_Lo => SnoData.Attributes.GetAttributeByIndex(1279);

	public AcdAttribute PVP_PVP_Experience_Gained_This_Game_Hi => SnoData.Attributes.GetAttributeByIndex(1280);

	public AcdAttribute PVP_Normal_Experience_Gained_This_Game_Lo => SnoData.Attributes.GetAttributeByIndex(1281);

	public AcdAttribute PVP_Normal_Experience_Gained_This_Game_Hi => SnoData.Attributes.GetAttributeByIndex(1282);

	public AcdAttribute PVP_Tokens_Gained_This_Game => SnoData.Attributes.GetAttributeByIndex(1283);

	public AcdAttribute PVP_Level_Equalizer_Level => SnoData.Attributes.GetAttributeByIndex(1284);

	public AcdAttribute Is_Temporary_Lure => SnoData.Attributes.GetAttributeByIndex(1285);

	public AcdAttribute Ignore_Lure => SnoData.Attributes.GetAttributeByIndex(1286);

	public AcdAttribute Effect_Owner_ANN => SnoData.Attributes.GetAttributeByIndex(1287);

	public AcdAttribute Elite_Engaged => SnoData.Attributes.GetAttributeByIndex(1288);

	public AcdAttribute Engaged_Rare_Time => SnoData.Attributes.GetAttributeByIndex(1289);

	public AcdAttribute Engaged_Goblin_Time => SnoData.Attributes.GetAttributeByIndex(1290);

	public AcdAttribute On_Death_Accolade_0 => SnoData.Attributes.GetAttributeByIndex(1291);

	public AcdAttribute On_Death_Accolade_0_Value => SnoData.Attributes.GetAttributeByIndex(1292);

	public AcdAttribute Item_Power_Passive => SnoData.Attributes.GetAttributeByIndex(1293);

	public AcdAttribute PVP_TeamDeathmatch_Games_Played => SnoData.Attributes.GetAttributeByIndex(1294);

	public AcdAttribute Last_Health_Drop_Interval => SnoData.Attributes.GetAttributeByIndex(1295);

	public AcdAttribute CrowdControl_Resistance => SnoData.Attributes.GetAttributeByIndex(1296);

	public AcdAttribute CrowdControl_Projected_End_Time => SnoData.Attributes.GetAttributeByIndex(1297);

	public AcdAttribute Last_Continuous_Knockback_Power_ID => SnoData.Attributes.GetAttributeByIndex(1298);

	public AcdAttribute Charmed => SnoData.Attributes.GetAttributeByIndex(1299);

	public AcdAttribute Taunted => SnoData.Attributes.GetAttributeByIndex(1300);

	public AcdAttribute Dueling => SnoData.Attributes.GetAttributeByIndex(1301);

	public AcdAttribute PVP_Player_Revealed_On_Map => SnoData.Attributes.GetAttributeByIndex(1302);

	public AcdAttribute Targeted_Legendary_Chance => SnoData.Attributes.GetAttributeByIndex(1303);

	public AcdAttribute Seasonal_Legendary_Chance => SnoData.Attributes.GetAttributeByIndex(1304);

	public AcdAttribute Received_Seasonal_Legendary => SnoData.Attributes.GetAttributeByIndex(1305);

	public AcdAttribute Has_Dropped_Special_loot => SnoData.Attributes.GetAttributeByIndex(1306);

	public AcdAttribute Scroll_Buff => SnoData.Attributes.GetAttributeByIndex(1307);

	public AcdAttribute Buff_Exclusive_Type_Active => SnoData.Attributes.GetAttributeByIndex(1308);

	public AcdAttribute In_Combat_With_Player => SnoData.Attributes.GetAttributeByIndex(1309);

	public AcdAttribute Actor_Forwards_Buffs => SnoData.Attributes.GetAttributeByIndex(1310);

	public AcdAttribute Item_Marked_As_Junk => SnoData.Attributes.GetAttributeByIndex(1311);

	public AcdAttribute Allow_2H_And_Shield => SnoData.Attributes.GetAttributeByIndex(1312);

	public AcdAttribute Class_Damage_Reduction_Percent_PVP => SnoData.Attributes.GetAttributeByIndex(1313);

	public AcdAttribute Paragon_Bonus => SnoData.Attributes.GetAttributeByIndex(1314);

	public AcdAttribute Paragon_Bonus_Points_Available => SnoData.Attributes.GetAttributeByIndex(1315);

	public AcdAttribute Dungeon_Finder_Progress_Percent => SnoData.Attributes.GetAttributeByIndex(1316);

	public AcdAttribute Item_Trade_Player_High => SnoData.Attributes.GetAttributeByIndex(1317);

	public AcdAttribute Item_Trade_Player_Low => SnoData.Attributes.GetAttributeByIndex(1318);

	public AcdAttribute Item_Trade_End_Time => SnoData.Attributes.GetAttributeByIndex(1319);

	public AcdAttribute Item_Trade_Timer_ID => SnoData.Attributes.GetAttributeByIndex(1320);

	public AcdAttribute Item_Is_BOE => SnoData.Attributes.GetAttributeByIndex(1321);

	public AcdAttribute Season => SnoData.Attributes.GetAttributeByIndex(1322);

	public AcdAttribute DamageDoneTotalTrackedHi => SnoData.Attributes.GetAttributeByIndex(1323);

	public AcdAttribute DamageDoneTotalTrackedLo => SnoData.Attributes.GetAttributeByIndex(1324);

	public AcdAttribute DamageDoneTrackingStartTick => SnoData.Attributes.GetAttributeByIndex(1325);

	public AcdAttribute PowerPersistsAcrossGames => SnoData.Attributes.GetAttributeByIndex(1326);

	public AcdAttribute Experience_Bonus_Percent_IGR_Buff => SnoData.Attributes.GetAttributeByIndex(1327);

	public AcdAttribute Experience_Bonus_Percent_Anniversary_Buff => SnoData.Attributes.GetAttributeByIndex(1328);

	public AcdAttribute Experience_Bonus_Percent_Community_Buff => SnoData.Attributes.GetAttributeByIndex(1329);

	public AcdAttribute Experience_Bonus_Percent_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(1330);

	public AcdAttribute Experience_Bonus_Percent_Super_Scalar => SnoData.Attributes.GetAttributeByIndex(1331);

	public AcdAttribute Experience_Bonus_Percent_Super_Scalar_Total => SnoData.Attributes.GetAttributeByIndex(1332);

	public AcdAttribute AlwaysShowFloatingNumbers => SnoData.Attributes.GetAttributeByIndex(1333);

	public AcdAttribute Targeted_Rare_Chance => SnoData.Attributes.GetAttributeByIndex(1334);

	public AcdAttribute Supress_Thorns_Effect => SnoData.Attributes.GetAttributeByIndex(1335);

	public AcdAttribute Dynamic_Entrance_GUID => SnoData.Attributes.GetAttributeByIndex(1336);

	public AcdAttribute Bonus_Chance_To_Be_Crit_Hit => SnoData.Attributes.GetAttributeByIndex(1337);

	public AcdAttribute Bonus_Chance_To_Be_Crit_Hit_By_Actor => SnoData.Attributes.GetAttributeByIndex(1338);

	public AcdAttribute Bonus_Chance_To_Receive_Crushing_Blown => SnoData.Attributes.GetAttributeByIndex(1339);

	public AcdAttribute Force_Gripped => SnoData.Attributes.GetAttributeByIndex(1340);

	public AcdAttribute PowerBonusAttackRadius => SnoData.Attributes.GetAttributeByIndex(1341);

	public AcdAttribute Item_Store_Player_High => SnoData.Attributes.GetAttributeByIndex(1342);

	public AcdAttribute Item_Store_Player_Low => SnoData.Attributes.GetAttributeByIndex(1343);

	public AcdAttribute Power_Primary_Resource_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1344);

	public AcdAttribute Power_Secondary_Resource_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1345);

	public AcdAttribute Power_Channel_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1346);

	public AcdAttribute Rune_A_Override => SnoData.Attributes.GetAttributeByIndex(1347);

	public AcdAttribute Rune_B_Override => SnoData.Attributes.GetAttributeByIndex(1348);

	public AcdAttribute Rune_C_Override => SnoData.Attributes.GetAttributeByIndex(1349);

	public AcdAttribute Rune_D_Override => SnoData.Attributes.GetAttributeByIndex(1350);

	public AcdAttribute Rune_E_Override => SnoData.Attributes.GetAttributeByIndex(1351);

	public AcdAttribute Elemental_Effect_Amplitude_Bonus => SnoData.Attributes.GetAttributeByIndex(1352);

	public AcdAttribute Elemental_Effect_Duration_Bonus => SnoData.Attributes.GetAttributeByIndex(1353);

	public AcdAttribute Elemental_Effect_Proc_Chance_Bonus => SnoData.Attributes.GetAttributeByIndex(1354);

	public AcdAttribute Splash_Damage_Effect_Percent => SnoData.Attributes.GetAttributeByIndex(1355);

	public AcdAttribute Crushing_Blow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1356);

	public AcdAttribute Item_Equipped_But_Disabled => SnoData.Attributes.GetAttributeByIndex(1357);

	public AcdAttribute Item_Equipped_But_Disabled_Duplicate_Legendary => SnoData.Attributes.GetAttributeByIndex(1358);

	public AcdAttribute Attribute_Projectile_Pass_Through => SnoData.Attributes.GetAttributeByIndex(1359);

	public AcdAttribute Attribute_Set_Item_Discount => SnoData.Attributes.GetAttributeByIndex(1360);

	public AcdAttribute Negative_Health_Globe_Spawn_Chance => SnoData.Attributes.GetAttributeByIndex(1361);

	public AcdAttribute Override_Attached_Anim => SnoData.Attributes.GetAttributeByIndex(1362);

	public AcdAttribute Has_Infinite_Shrine_Buffs => SnoData.Attributes.GetAttributeByIndex(1363);

	public AcdAttribute Item_Legendary_Item_Base_Item => SnoData.Attributes.GetAttributeByIndex(1364);

	public AcdAttribute Targeted_Magic_Chance => SnoData.Attributes.GetAttributeByIndex(1365);

	public AcdAttribute Dont_Update_Camera_While_Attached => SnoData.Attributes.GetAttributeByIndex(1366);

	public AcdAttribute LinkedDynamicEntranceGUID => SnoData.Attributes.GetAttributeByIndex(1367);

	public AcdAttribute Boost_TC_Index => SnoData.Attributes.GetAttributeByIndex(1368);

	public AcdAttribute Boost_TC_NextTime => SnoData.Attributes.GetAttributeByIndex(1369);

	public AcdAttribute Potion_Bonus_Armor_Percent => SnoData.Attributes.GetAttributeByIndex(1370);

	public AcdAttribute Potion_Bonus_Resist_All => SnoData.Attributes.GetAttributeByIndex(1371);

	public AcdAttribute Potion_Bonus_Hitpoints_Granted => SnoData.Attributes.GetAttributeByIndex(1372);

	public AcdAttribute Potion_Bonus_Buff_Duration => SnoData.Attributes.GetAttributeByIndex(1373);

	public AcdAttribute Potion_Bonus_Life_On_Hit => SnoData.Attributes.GetAttributeByIndex(1374);

	public AcdAttribute Potion_Bonus_Life_On_Kill => SnoData.Attributes.GetAttributeByIndex(1375);

	public AcdAttribute Last_Special_Item_Time_High => SnoData.Attributes.GetAttributeByIndex(1376);

	public AcdAttribute Last_Special_Item_Time_Low => SnoData.Attributes.GetAttributeByIndex(1377);

	public AcdAttribute Item_Rest_Bonus_Pool => SnoData.Attributes.GetAttributeByIndex(1378);

	public AcdAttribute Item_Unlucky_Bonus_Secs => SnoData.Attributes.GetAttributeByIndex(1379);

	public AcdAttribute Item_Unlucky_Bonus_Allow => SnoData.Attributes.GetAttributeByIndex(1380);

	public AcdAttribute Avenger_Buildup_Secs => SnoData.Attributes.GetAttributeByIndex(1381);

	public AcdAttribute Bounty_Objective => SnoData.Attributes.GetAttributeByIndex(1382);

	public AcdAttribute Illusion => SnoData.Attributes.GetAttributeByIndex(1383);

	public AcdAttribute TornadoStraighten => SnoData.Attributes.GetAttributeByIndex(1384);

	public AcdAttribute Prevent_Evade_During => SnoData.Attributes.GetAttributeByIndex(1385);

	public AcdAttribute Damage_Bonus_From_Nephalem_Glory => SnoData.Attributes.GetAttributeByIndex(1386);

	public AcdAttribute Item_Player_Recipient => SnoData.Attributes.GetAttributeByIndex(1387);

	public AcdAttribute Heavens_Fury_Attacker => SnoData.Attributes.GetAttributeByIndex(1388);

	public AcdAttribute Item_Assigned_Hero_High => SnoData.Attributes.GetAttributeByIndex(1389);

	public AcdAttribute Item_Assigned_Hero_Low => SnoData.Attributes.GetAttributeByIndex(1390);

	public AcdAttribute Pierce_Charge => SnoData.Attributes.GetAttributeByIndex(1391);

	public AcdAttribute Upscaled_Level => SnoData.Attributes.GetAttributeByIndex(1392);

	public AcdAttribute Resurrected => SnoData.Attributes.GetAttributeByIndex(1393);

	public AcdAttribute Damage_SidekickMultiplier => SnoData.Attributes.GetAttributeByIndex(1394);

	public AcdAttribute Thorns_AOE_Radius_Next_Time => SnoData.Attributes.GetAttributeByIndex(1395);

	public AcdAttribute Movement_Destroys_Waller_Walls => SnoData.Attributes.GetAttributeByIndex(1396);

	public AcdAttribute Mail_Flag_Icon => SnoData.Attributes.GetAttributeByIndex(1397);

	public AcdAttribute Tiered_Loot_Run_Key_Level => SnoData.Attributes.GetAttributeByIndex(1398);

	public AcdAttribute In_Tiered_Loot_Run_Level => SnoData.Attributes.GetAttributeByIndex(1399);

	public AcdAttribute Is_Loot_Run_Boss => SnoData.Attributes.GetAttributeByIndex(1400);

	public AcdAttribute ForcedMove => SnoData.Attributes.GetAttributeByIndex(1401);

	public AcdAttribute Effective_Level => SnoData.Attributes.GetAttributeByIndex(1402);

	public AcdAttribute Jewel_Rank => SnoData.Attributes.GetAttributeByIndex(1403);

	public AcdAttribute Item_Console_Max_Level => SnoData.Attributes.GetAttributeByIndex(1404);

	public AcdAttribute Console_Promo_Item => SnoData.Attributes.GetAttributeByIndex(1405);

	public AcdAttribute Double_BloodShards => SnoData.Attributes.GetAttributeByIndex(1406);

	public AcdAttribute Double_BountyBags => SnoData.Attributes.GetAttributeByIndex(1407);

	public AcdAttribute Jewel_Upgrades_Used => SnoData.Attributes.GetAttributeByIndex(1408);

	public AcdAttribute Jewel_Upgrades_Max => SnoData.Attributes.GetAttributeByIndex(1409);

	public AcdAttribute Jewel_Upgrades_Bonus => SnoData.Attributes.GetAttributeByIndex(1410);

	public AcdAttribute Item_Ignores_Pickup_Radius_For_Pickup => SnoData.Attributes.GetAttributeByIndex(1411);

	public AcdAttribute Hunter => SnoData.Attributes.GetAttributeByIndex(1412);

	public AcdAttribute Participating_In_Tiered_Loot_Run => SnoData.Attributes.GetAttributeByIndex(1413);

	public AcdAttribute Tiered_Loot_Run_Reward_Choice_State => SnoData.Attributes.GetAttributeByIndex(1414);

	public AcdAttribute Tiered_Loot_Run_Reward_Receives_Key => SnoData.Attributes.GetAttributeByIndex(1415);

	public AcdAttribute CurrentCosmeticEffect => SnoData.Attributes.GetAttributeByIndex(1416);

	public AcdAttribute Bloodshard_Bonus_Percent_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(1417);

	public AcdAttribute XP_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1418);

	public AcdAttribute Gold_Find_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1419);

	public AcdAttribute Bloodshard_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1420);

	public AcdAttribute Current_Cosmetic_Pet => SnoData.Attributes.GetAttributeByIndex(1421);

	public AcdAttribute Cosmetic_Pet_Power => SnoData.Attributes.GetAttributeByIndex(1422);

	public AcdAttribute Cosmetic_Pet_Expiration => SnoData.Attributes.GetAttributeByIndex(1423);

	public AcdAttribute Cosmetic_Portrait_Frame => SnoData.Attributes.GetAttributeByIndex(1424);

	public AcdAttribute HQ_Hot_Cold_State => SnoData.Attributes.GetAttributeByIndex(1425);

	public AcdAttribute HQ_Cursed_Realm_Reagents_Collected => SnoData.Attributes.GetAttributeByIndex(1426);

	public AcdAttribute HQ_Cursed_Realm_Reagents_Dropped => SnoData.Attributes.GetAttributeByIndex(1427);

	public AcdAttribute Debug_Movement_Type => SnoData.Attributes.GetAttributeByIndex(1428);

	public AcdAttribute Tiered_Loot_Run_Death_Count => SnoData.Attributes.GetAttributeByIndex(1429);

	public AcdAttribute Tiered_Loot_Run_Corpse_Resurrection_Allowed_GameTime => SnoData.Attributes.GetAttributeByIndex(1430);

	public AcdAttribute Last_Posted_Achievement_Points => SnoData.Attributes.GetAttributeByIndex(1431);

	public AcdAttribute Cosmetic_Pet_Actor => SnoData.Attributes.GetAttributeByIndex(1432);

	public AcdAttribute Platinum_Cap_Remaining => SnoData.Attributes.GetAttributeByIndex(1433);

	public AcdAttribute Platinum_Cap_Last_Gain => SnoData.Attributes.GetAttributeByIndex(1434);

	public AcdAttribute Last_Boss_Kill_Time => SnoData.Attributes.GetAttributeByIndex(1435);

	public AcdAttribute Last_Bounty_Complete_Time => SnoData.Attributes.GetAttributeByIndex(1436);

	public AcdAttribute Last_Treasure_Goblin_Kill_Time => SnoData.Attributes.GetAttributeByIndex(1437);

	public AcdAttribute Stash_Tabs_Purchased_With_Gold => SnoData.Attributes.GetAttributeByIndex(1438);

	public AcdAttribute Stash_Tabs_Rewarded_By_Achievements => SnoData.Attributes.GetAttributeByIndex(1439);

	public AcdAttribute Skill_Button_Flash => SnoData.Attributes.GetAttributeByIndex(1440);

	public AcdAttribute Projectile_Det_Path_Reflect_Count => SnoData.Attributes.GetAttributeByIndex(1441);

	public AcdAttribute Last_Cosmetic_Pet => SnoData.Attributes.GetAttributeByIndex(1442);

	public AcdAttribute Platinum_Last_Significant_Kill => SnoData.Attributes.GetAttributeByIndex(1443);

	public AcdAttribute Power_Last_Attribute_Snapshot_Update_Time => SnoData.Attributes.GetAttributeByIndex(1444);

	public AcdAttribute Skill_Button_Active_Glow => SnoData.Attributes.GetAttributeByIndex(1445);

	public AcdAttribute Participating_In_Set_Dungeon => SnoData.Attributes.GetAttributeByIndex(1446);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1447);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus_For_Skill => SnoData.Attributes.GetAttributeByIndex(1448);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus_For_Player => SnoData.Attributes.GetAttributeByIndex(1449);

	public AcdAttribute In_Set_Dungeon_World => SnoData.Attributes.GetAttributeByIndex(1450);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus_No_Pets => SnoData.Attributes.GetAttributeByIndex(1452);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus_ochallengeAgainst_CC_Targets => SnoData.Attributes.GetAttributeByIndex(1453);

	public AcdAttribute Multiplicative_Damage_Percent_Bonus_Against_Slowed_Targets => SnoData.Attributes.GetAttributeByIndex(1454);

	public AcdAttribute Summoned_By_Autocast => SnoData.Attributes.GetAttributeByIndex(1455);

	public AcdAttribute Necromancer_Corpse_Spawn_Chance => SnoData.Attributes.GetAttributeByIndex(1456);

	public AcdAttribute Necromancer_Last_Corpse_Spawn_Check_Tick => SnoData.Attributes.GetAttributeByIndex(1457);

	public AcdAttribute Necromancer_Corpse_Owner_Player_High => SnoData.Attributes.GetAttributeByIndex(1458);

	public AcdAttribute Necromancer_Corpse_Owner_Player_Low => SnoData.Attributes.GetAttributeByIndex(1459);

	public AcdAttribute Necromancer_Corpse_Charges => SnoData.Attributes.GetAttributeByIndex(1460);

	public AcdAttribute Necromancer_Corpse_Source_Monster_SNO => SnoData.Attributes.GetAttributeByIndex(1461);

	public AcdAttribute Necromancer_Corpse_Free_Casting => SnoData.Attributes.GetAttributeByIndex(1462);

	public AcdAttribute Currencies_Discovered => SnoData.Attributes.GetAttributeByIndex(1463);

	public AcdAttribute In_Tiered_Challenge_Rift => SnoData.Attributes.GetAttributeByIndex(1464);

	public AcdAttribute Necromancer_Cursed => SnoData.Attributes.GetAttributeByIndex(1465);

	public AcdAttribute Necromancer_Curse_Count => SnoData.Attributes.GetAttributeByIndex(1466);

	public AcdAttribute Necromancer_Unique_Curse_Count => SnoData.Attributes.GetAttributeByIndex(1467);

	public AcdAttribute Eligible_For_Weekly_Challenge_Reward => SnoData.Attributes.GetAttributeByIndex(1468);

	public AcdAttribute Force_Remote_FX => SnoData.Attributes.GetAttributeByIndex(1469);

	public AcdAttribute Weekly_Challenge_Reward_Icon => SnoData.Attributes.GetAttributeByIndex(1470);

	public AcdAttribute Item_Was_Touched_By_Armory => SnoData.Attributes.GetAttributeByIndex(1471);

	public AcdAttribute Item_Was_Touched_By_Armory_Last_Game => SnoData.Attributes.GetAttributeByIndex(1472);

	public AcdAttribute Has_Nfp_Device => SnoData.Attributes.GetAttributeByIndex(1473);

	public AcdAttribute ReceivedPrimalWhenUnlocking => SnoData.Attributes.GetAttributeByIndex(1474);

	public AcdAttribute KanaiPowersunlocked => SnoData.Attributes.GetAttributeByIndex(1475);

	public AcdAttribute FourthKanaisCubeSlotunlocked => SnoData.Attributes.GetAttributeByIndex(1476);

	public AcdAttribute Etherealitemsunlocked => SnoData.Attributes.GetAttributeByIndex(1477);

	public AcdAttribute Soulshardsunlocked => SnoData.Attributes.GetAttributeByIndex(1478);

	public AcdAttribute Itemwassanctified => SnoData.Attributes.GetAttributeByIndex(1479);

	public AcdAttribute Sanctifieditemsunlocked => SnoData.Attributes.GetAttributeByIndex(1480);

	public AcdAttribute In_Swarm_Rift_World => SnoData.Attributes.GetAttributeByIndex(1451);

	public AcdAttribute HerosunlockedDarkAlchemynodes => SnoData.Attributes.GetAttributeByIndex(1481);

	public AcdAttribute DarkAlchemypowersunlocked => SnoData.Attributes.GetAttributeByIndex(1482);

	public AcdAttribute Itemwasprimalized => SnoData.Attributes.GetAttributeByIndex(1483);

	public AcdAttribute ParagonCapEnabled => SnoData.Attributes.GetAttributeByIndex(1484);
}
