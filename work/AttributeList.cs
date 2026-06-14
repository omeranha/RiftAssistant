using Plugins;
using SNO;

namespace work;

internal class AttributeList : IAttributeList
{
	public IAttribute Axe_Bad_Data => SnoData.Attributes.GetAttributeByIndex(0);

	public IAttribute Attribute_Timer => SnoData.Attributes.GetAttributeByIndex(1);

	public IAttribute Attribute_Pool => SnoData.Attributes.GetAttributeByIndex(2);

	public IAttribute Death_Count => SnoData.Attributes.GetAttributeByIndex(3);

	public IAttribute DualWield_Hand => SnoData.Attributes.GetAttributeByIndex(4);

	public IAttribute DualWield_Hand_Next => SnoData.Attributes.GetAttributeByIndex(5);

	public IAttribute DualWield_Hands_Swapped => SnoData.Attributes.GetAttributeByIndex(6);

	public IAttribute Respawn_Game_Time => SnoData.Attributes.GetAttributeByIndex(7);

	public IAttribute Backpack_Slots => SnoData.Attributes.GetAttributeByIndex(8);

	public IAttribute Shared_Stash_Slots => SnoData.Attributes.GetAttributeByIndex(9);

	public IAttribute Strength => SnoData.Attributes.GetAttributeByIndex(10);

	public IAttribute Dexterity => SnoData.Attributes.GetAttributeByIndex(11);

	public IAttribute Intelligence => SnoData.Attributes.GetAttributeByIndex(12);

	public IAttribute Vitality => SnoData.Attributes.GetAttributeByIndex(13);

	public IAttribute Strength_Total => SnoData.Attributes.GetAttributeByIndex(14);

	public IAttribute Dexterity_Total => SnoData.Attributes.GetAttributeByIndex(15);

	public IAttribute Intelligence_Total => SnoData.Attributes.GetAttributeByIndex(16);

	public IAttribute Vitality_Total => SnoData.Attributes.GetAttributeByIndex(17);

	public IAttribute Strength_Bonus => SnoData.Attributes.GetAttributeByIndex(18);

	public IAttribute Dexterity_Bonus => SnoData.Attributes.GetAttributeByIndex(19);

	public IAttribute Intelligence_Bonus => SnoData.Attributes.GetAttributeByIndex(20);

	public IAttribute Vitality_Bonus => SnoData.Attributes.GetAttributeByIndex(21);

	public IAttribute Strength_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(22);

	public IAttribute Dexterity_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(23);

	public IAttribute Intelligence_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(24);

	public IAttribute Vitality_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(25);

	public IAttribute Strength_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(26);

	public IAttribute Dexterity_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(27);

	public IAttribute Intelligence_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(28);

	public IAttribute Vitality_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(29);

	public IAttribute Primary_Damage_Attribute => SnoData.Attributes.GetAttributeByIndex(30);

	public IAttribute Armor => SnoData.Attributes.GetAttributeByIndex(31);

	public IAttribute Armor_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(32);

	public IAttribute Armor_Item => SnoData.Attributes.GetAttributeByIndex(33);

	public IAttribute Armor_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(34);

	public IAttribute Armor_Item_Percent => SnoData.Attributes.GetAttributeByIndex(35);

	public IAttribute Armor_Item_SubTotal => SnoData.Attributes.GetAttributeByIndex(36);

	public IAttribute Armor_Item_Total => SnoData.Attributes.GetAttributeByIndex(37);

	public IAttribute Armor_Total => SnoData.Attributes.GetAttributeByIndex(38);

	public IAttribute Experience_Granted_Hi => SnoData.Attributes.GetAttributeByIndex(39);

	public IAttribute Experience_Granted_Low => SnoData.Attributes.GetAttributeByIndex(40);

	public IAttribute Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(41);

	public IAttribute Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(42);

	public IAttribute Alt_Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(43);

	public IAttribute Alt_Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(44);

	public IAttribute Rest_Experience_Hi => SnoData.Attributes.GetAttributeByIndex(45);

	public IAttribute Rest_Experience_Lo => SnoData.Attributes.GetAttributeByIndex(46);

	public IAttribute Rest_Experience_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(47);

	public IAttribute Gold_Granted => SnoData.Attributes.GetAttributeByIndex(48);

	public IAttribute Gold => SnoData.Attributes.GetAttributeByIndex(49);

	public IAttribute Gold_Find => SnoData.Attributes.GetAttributeByIndex(50);

	public IAttribute Gold_Find_Uncapped => SnoData.Attributes.GetAttributeByIndex(51);

	public IAttribute Gold_Find_Handicap => SnoData.Attributes.GetAttributeByIndex(52);

	public IAttribute Gold_Find_Alt_Levels_Total => SnoData.Attributes.GetAttributeByIndex(53);

	public IAttribute Gold_Find_Community_Buff => SnoData.Attributes.GetAttributeByIndex(54);

	public IAttribute Gold_Find_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(55);

	public IAttribute Gold_Find_Total => SnoData.Attributes.GetAttributeByIndex(56);

	public IAttribute Level => SnoData.Attributes.GetAttributeByIndex(57);

	public IAttribute Level_Cap => SnoData.Attributes.GetAttributeByIndex(58);

	public IAttribute Alt_Level => SnoData.Attributes.GetAttributeByIndex(59);

	public IAttribute Magic_Find => SnoData.Attributes.GetAttributeByIndex(60);

	public IAttribute Magic_Find_Uncapped => SnoData.Attributes.GetAttributeByIndex(61);

	public IAttribute Magic_Find_Handicap => SnoData.Attributes.GetAttributeByIndex(62);

	public IAttribute Magic_Find_Alt_Levels_Total => SnoData.Attributes.GetAttributeByIndex(63);

	public IAttribute Magic_Find_Capped_Subtotal => SnoData.Attributes.GetAttributeByIndex(64);

	public IAttribute Magic_Find_Total => SnoData.Attributes.GetAttributeByIndex(65);

	public IAttribute Magic_And_Gold_Find_Suppressed => SnoData.Attributes.GetAttributeByIndex(66);

	public IAttribute Treasure_Find => SnoData.Attributes.GetAttributeByIndex(67);

	public IAttribute Legendary_Find_Community_Buff => SnoData.Attributes.GetAttributeByIndex(68);

	public IAttribute Resource_Cost_Reduction_Amount => SnoData.Attributes.GetAttributeByIndex(69);

	public IAttribute Resource_Cost_Reduction_Total => SnoData.Attributes.GetAttributeByIndex(70);

	public IAttribute Resource_Set_Point_Bonus => SnoData.Attributes.GetAttributeByIndex(71);

	public IAttribute Faster_Healing_Percent => SnoData.Attributes.GetAttributeByIndex(72);

	public IAttribute Spending_Resource_Heals_Percent => SnoData.Attributes.GetAttributeByIndex(73);

	public IAttribute Bonus_Healing_Received_Percent => SnoData.Attributes.GetAttributeByIndex(74);

	public IAttribute Reduced_Healing_Received_Percent => SnoData.Attributes.GetAttributeByIndex(75);

	public IAttribute Healing_Well_Restores_Resource => SnoData.Attributes.GetAttributeByIndex(76);

	public IAttribute Experience_Bonus => SnoData.Attributes.GetAttributeByIndex(77);

	public IAttribute Experience_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(78);

	public IAttribute Experience_Bonus_Percent_Handicap => SnoData.Attributes.GetAttributeByIndex(79);

	public IAttribute Experience_Bonus_Percent_Total => SnoData.Attributes.GetAttributeByIndex(80);

	public IAttribute Experience_Bonus_No_Penalty => SnoData.Attributes.GetAttributeByIndex(81);

	public IAttribute Health_Globe_Bonus_Chance => SnoData.Attributes.GetAttributeByIndex(82);

	public IAttribute Health_Globe_Bonus_Mult_Chance => SnoData.Attributes.GetAttributeByIndex(83);

	public IAttribute Powerup_Globe_Bonus_Chance => SnoData.Attributes.GetAttributeByIndex(84);

	public IAttribute Powerup_Globe_Bonus_Mult_Chance => SnoData.Attributes.GetAttributeByIndex(85);

	public IAttribute Health_Globe_Bonus_Health => SnoData.Attributes.GetAttributeByIndex(86);

	public IAttribute Increased_Health_From_Globes_Percent => SnoData.Attributes.GetAttributeByIndex(87);

	public IAttribute Increased_Health_From_Globes_Percent_Total => SnoData.Attributes.GetAttributeByIndex(88);

	public IAttribute Bonus_Health_Percent_Per_Second_From_Globes => SnoData.Attributes.GetAttributeByIndex(89);

	public IAttribute Bonus_Health_Percent_Per_Second_From_Globes_Total => SnoData.Attributes.GetAttributeByIndex(90);

	public IAttribute Mana_Gained_From_Globes_Percent => SnoData.Attributes.GetAttributeByIndex(91);

	public IAttribute Mana_Gained_From_Globes => SnoData.Attributes.GetAttributeByIndex(92);

	public IAttribute Resistance => SnoData.Attributes.GetAttributeByIndex(93);

	public IAttribute Resistance_Percent => SnoData.Attributes.GetAttributeByIndex(94);

	public IAttribute Resistance_Total => SnoData.Attributes.GetAttributeByIndex(95);

	public IAttribute Resistance_All => SnoData.Attributes.GetAttributeByIndex(96);

	public IAttribute Resistance_Percent_All => SnoData.Attributes.GetAttributeByIndex(97);

	public IAttribute Resistance_From_Intelligence => SnoData.Attributes.GetAttributeByIndex(98);

	public IAttribute Class_Damage_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(99);

	public IAttribute Skill => SnoData.Attributes.GetAttributeByIndex(100);

	public IAttribute Skill_From_Item => SnoData.Attributes.GetAttributeByIndex(101);

	public IAttribute Skill_Total => SnoData.Attributes.GetAttributeByIndex(102);

	public IAttribute TeamID => SnoData.Attributes.GetAttributeByIndex(103);

	public IAttribute Team_Override => SnoData.Attributes.GetAttributeByIndex(104);

	public IAttribute Invulnerable => SnoData.Attributes.GetAttributeByIndex(105);

	public IAttribute Loading => SnoData.Attributes.GetAttributeByIndex(106);

	public IAttribute Loading_Player_ACD => SnoData.Attributes.GetAttributeByIndex(107);

	public IAttribute Loading_Power_SNO => SnoData.Attributes.GetAttributeByIndex(108);

	public IAttribute Loading_Anim_Tag => SnoData.Attributes.GetAttributeByIndex(109);

	public IAttribute Loading_NewGame => SnoData.Attributes.GetAttributeByIndex(110);

	public IAttribute Auto_Porting_To_Save_Point => SnoData.Attributes.GetAttributeByIndex(111);

	public IAttribute No_Damage => SnoData.Attributes.GetAttributeByIndex(112);

	public IAttribute No_AutoPickup => SnoData.Attributes.GetAttributeByIndex(113);

	public IAttribute Light_Radius_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(114);

	public IAttribute Hitpoints_Cur => SnoData.Attributes.GetAttributeByIndex(115);

	public IAttribute Hitpoints_Factor_Level => SnoData.Attributes.GetAttributeByIndex(116);

	public IAttribute Hitpoints_Factor_Vitality => SnoData.Attributes.GetAttributeByIndex(117);

	public IAttribute Hitpoints_Total_From_Vitality => SnoData.Attributes.GetAttributeByIndex(118);

	public IAttribute Hitpoints_Total_From_Level => SnoData.Attributes.GetAttributeByIndex(119);

	public IAttribute Hitpoints_Granted => SnoData.Attributes.GetAttributeByIndex(120);

	public IAttribute Hitpoints_Granted_Duration => SnoData.Attributes.GetAttributeByIndex(121);

	public IAttribute Hitpoints_Max => SnoData.Attributes.GetAttributeByIndex(122);

	public IAttribute Hitpoints_Max_Bonus => SnoData.Attributes.GetAttributeByIndex(123);

	public IAttribute Hitpoints_Max_Total => SnoData.Attributes.GetAttributeByIndex(124);

	public IAttribute Hitpoints_Percent => SnoData.Attributes.GetAttributeByIndex(125);

	public IAttribute Hitpoints_Regen_Per_Second => SnoData.Attributes.GetAttributeByIndex(126);

	public IAttribute Hitpoints_Regen_Per_Second_Bonus => SnoData.Attributes.GetAttributeByIndex(127);

	public IAttribute Hitpoints_Regen_Per_Second_Bonus_From_Skills => SnoData.Attributes.GetAttributeByIndex(128);

	public IAttribute Hitpoints_Regen_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(129);

	public IAttribute Hitpoints_Regen_Per_Second_Subtotal => SnoData.Attributes.GetAttributeByIndex(130);

	public IAttribute Hitpoints_Regen_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(131);

	public IAttribute Hitpoints_Regen_Per_Second_Health_Globe => SnoData.Attributes.GetAttributeByIndex(132);

	public IAttribute Hitpoints_Regen_Per_Second_Total => SnoData.Attributes.GetAttributeByIndex(133);

	public IAttribute Hitpoints_Max_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(134);

	public IAttribute Hitpoints_Max_Percent_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(135);

	public IAttribute Hitpoints_Max_Percent_Bonus_Multiplicative => SnoData.Attributes.GetAttributeByIndex(136);

	public IAttribute Hitpoints_Healed_Target => SnoData.Attributes.GetAttributeByIndex(137);

	public IAttribute Hitpoints_Frozen => SnoData.Attributes.GetAttributeByIndex(138);

	public IAttribute Healing_Suppressed => SnoData.Attributes.GetAttributeByIndex(139);

	public IAttribute DOT_Damage_Taken_Queued => SnoData.Attributes.GetAttributeByIndex(140);

	public IAttribute DOT_Damage_Taken_Queued_Tick => SnoData.Attributes.GetAttributeByIndex(141);

	public IAttribute DOT_Damage_Taken_Queued_Player => SnoData.Attributes.GetAttributeByIndex(142);

	public IAttribute DOT_Damage_Taken_Queued_Player_Tick => SnoData.Attributes.GetAttributeByIndex(143);

	public IAttribute Healing_Received_Queued => SnoData.Attributes.GetAttributeByIndex(144);

	public IAttribute Healing_Received_Queued_Tick => SnoData.Attributes.GetAttributeByIndex(145);

	public IAttribute Staggered_Damage_Fraction => SnoData.Attributes.GetAttributeByIndex(146);

	public IAttribute Staggered_Damage_Duration => SnoData.Attributes.GetAttributeByIndex(147);

	public IAttribute Resource_Type_Primary => SnoData.Attributes.GetAttributeByIndex(148);

	public IAttribute Resource_Type_Secondary => SnoData.Attributes.GetAttributeByIndex(149);

	public IAttribute Resource_Cur => SnoData.Attributes.GetAttributeByIndex(150);

	public IAttribute Resource_Max => SnoData.Attributes.GetAttributeByIndex(151);

	public IAttribute Resource_Max_Bonus => SnoData.Attributes.GetAttributeByIndex(152);

	public IAttribute Resource_Max_Total => SnoData.Attributes.GetAttributeByIndex(153);

	public IAttribute Resource_Factor_Level => SnoData.Attributes.GetAttributeByIndex(154);

	public IAttribute Resource_Granted => SnoData.Attributes.GetAttributeByIndex(155);

	public IAttribute Resource_Granted_Duration => SnoData.Attributes.GetAttributeByIndex(156);

	public IAttribute Resource_Percent => SnoData.Attributes.GetAttributeByIndex(157);

	public IAttribute Resource_Regen_Per_Second => SnoData.Attributes.GetAttributeByIndex(158);

	public IAttribute Resource_Regen_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(159);

	public IAttribute Resource_Regen_Total => SnoData.Attributes.GetAttributeByIndex(160);

	public IAttribute Resource_Regen_Stop_Regen => SnoData.Attributes.GetAttributeByIndex(161);

	public IAttribute Resource_Max_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(162);

	public IAttribute Resource_Capacity_Used => SnoData.Attributes.GetAttributeByIndex(163);

	public IAttribute Resource_Effective_Max => SnoData.Attributes.GetAttributeByIndex(164);

	public IAttribute Resource_Regen_Percent_Per_Second => SnoData.Attributes.GetAttributeByIndex(165);

	public IAttribute Resource_Degeneration_Stop_Point => SnoData.Attributes.GetAttributeByIndex(166);

	public IAttribute Highest_Solo_Rift_Level => SnoData.Attributes.GetAttributeByIndex(167);

	public IAttribute Highest_Unlocked_Rift_Level => SnoData.Attributes.GetAttributeByIndex(168);

	public IAttribute Last_Rift_Started_Level => SnoData.Attributes.GetAttributeByIndex(169);

	public IAttribute Highest_Hero_Solo_Rift_Level => SnoData.Attributes.GetAttributeByIndex(170);

	public IAttribute Movement_Scalar => SnoData.Attributes.GetAttributeByIndex(171);

	public IAttribute Walking_Rate => SnoData.Attributes.GetAttributeByIndex(172);

	public IAttribute Running_Rate => SnoData.Attributes.GetAttributeByIndex(173);

	public IAttribute Sprinting_Rate => SnoData.Attributes.GetAttributeByIndex(174);

	public IAttribute Strafing_Rate => SnoData.Attributes.GetAttributeByIndex(175);

	public IAttribute Walking_Rate_Total => SnoData.Attributes.GetAttributeByIndex(176);

	public IAttribute Running_Rate_Total => SnoData.Attributes.GetAttributeByIndex(177);

	public IAttribute Last_Running_Rate => SnoData.Attributes.GetAttributeByIndex(178);

	public IAttribute Sprinting_Rate_Total => SnoData.Attributes.GetAttributeByIndex(179);

	public IAttribute Strafing_Rate_Total => SnoData.Attributes.GetAttributeByIndex(180);

	public IAttribute Movement_Bonus_Total => SnoData.Attributes.GetAttributeByIndex(181);

	public IAttribute Movement_Scalar_Subtotal => SnoData.Attributes.GetAttributeByIndex(182);

	public IAttribute Movement_Scalar_Capped_Total => SnoData.Attributes.GetAttributeByIndex(183);

	public IAttribute Movement_Scalar_Uncapped_Bonus => SnoData.Attributes.GetAttributeByIndex(184);

	public IAttribute Movement_Scalar_Total => SnoData.Attributes.GetAttributeByIndex(185);

	public IAttribute Movement_Bonus_Run_Speed => SnoData.Attributes.GetAttributeByIndex(186);

	public IAttribute Movement_Scalar_Cap => SnoData.Attributes.GetAttributeByIndex(187);

	public IAttribute Casting_Speed => SnoData.Attributes.GetAttributeByIndex(188);

	public IAttribute Casting_Speed_Bonus => SnoData.Attributes.GetAttributeByIndex(189);

	public IAttribute Casting_Speed_Total => SnoData.Attributes.GetAttributeByIndex(190);

	public IAttribute Always_Hits => SnoData.Attributes.GetAttributeByIndex(191);

	public IAttribute Hit_Chance => SnoData.Attributes.GetAttributeByIndex(192);

	public IAttribute Knockback_Attack_Scalar => SnoData.Attributes.GetAttributeByIndex(193);

	public IAttribute Attacks_Per_Second_Item => SnoData.Attributes.GetAttributeByIndex(194);

	public IAttribute Attacks_Per_Second_Item_Percent => SnoData.Attributes.GetAttributeByIndex(195);

	public IAttribute Attacks_Per_Second_Item_Subtotal => SnoData.Attributes.GetAttributeByIndex(196);

	public IAttribute Attacks_Per_Second_Item_Bonus => SnoData.Attributes.GetAttributeByIndex(197);

	public IAttribute Attacks_Per_Second_Item_Total => SnoData.Attributes.GetAttributeByIndex(198);

	public IAttribute Attacks_Per_Second => SnoData.Attributes.GetAttributeByIndex(199);

	public IAttribute Attacks_Per_Second_Bonus => SnoData.Attributes.GetAttributeByIndex(200);

	public IAttribute Attacks_Per_Second_Total => SnoData.Attributes.GetAttributeByIndex(201);

	public IAttribute Attacks_Per_Second_Percent_Cap => SnoData.Attributes.GetAttributeByIndex(202);

	public IAttribute Attacks_Per_Second_Percent => SnoData.Attributes.GetAttributeByIndex(203);

	public IAttribute Attacks_Per_Second_Percent_Uncapped => SnoData.Attributes.GetAttributeByIndex(204);

	public IAttribute Attacks_Per_Second_Percent_Reduction => SnoData.Attributes.GetAttributeByIndex(205);

	public IAttribute Attacks_Per_Second_Percent_Subtotal => SnoData.Attributes.GetAttributeByIndex(206);

	public IAttribute AI_Cooldown_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(207);

	public IAttribute Power_Cooldown_Min_Time => SnoData.Attributes.GetAttributeByIndex(208);

	public IAttribute Power_Cooldown_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(209);

	public IAttribute Power_Cooldown_Reduction_Percent_All => SnoData.Attributes.GetAttributeByIndex(210);

	public IAttribute Power_Cooldown_Reduction_Percent_All_Capped => SnoData.Attributes.GetAttributeByIndex(211);

	public IAttribute Damage_Delta => SnoData.Attributes.GetAttributeByIndex(212);

	public IAttribute Damage_Delta_Total => SnoData.Attributes.GetAttributeByIndex(213);

	public IAttribute Damage_Min => SnoData.Attributes.GetAttributeByIndex(214);

	public IAttribute Damage_Bonus_Min => SnoData.Attributes.GetAttributeByIndex(215);

	public IAttribute Damage_Min_Total => SnoData.Attributes.GetAttributeByIndex(216);

	public IAttribute Damage_Delta_Total_All => SnoData.Attributes.GetAttributeByIndex(217);

	public IAttribute Damage_Min_Total_All => SnoData.Attributes.GetAttributeByIndex(218);

	public IAttribute Damage_Average_Total_All => SnoData.Attributes.GetAttributeByIndex(219);

	public IAttribute Damage_Min_Subtotal => SnoData.Attributes.GetAttributeByIndex(220);

	public IAttribute Damage_Percent_All_From_Skills => SnoData.Attributes.GetAttributeByIndex(221);

	public IAttribute Damage_Weapon_Delta => SnoData.Attributes.GetAttributeByIndex(222);

	public IAttribute Damage_Weapon_Delta_SubTotal => SnoData.Attributes.GetAttributeByIndex(223);

	public IAttribute Damage_Weapon_Max => SnoData.Attributes.GetAttributeByIndex(224);

	public IAttribute Damage_Weapon_Max_Total => SnoData.Attributes.GetAttributeByIndex(225);

	public IAttribute Damage_Weapon_Max_Total_All => SnoData.Attributes.GetAttributeByIndex(226);

	public IAttribute Damage_Weapon_Delta_Total => SnoData.Attributes.GetAttributeByIndex(227);

	public IAttribute Damage_Weapon_Delta_Total_All => SnoData.Attributes.GetAttributeByIndex(228);

	public IAttribute Damage_Weapon_Bonus_Delta => SnoData.Attributes.GetAttributeByIndex(229);

	public IAttribute Damage_Weapon_Bonus_Delta_X1 => SnoData.Attributes.GetAttributeByIndex(230);

	public IAttribute Damage_Weapon_Min => SnoData.Attributes.GetAttributeByIndex(231);

	public IAttribute Damage_Weapon_Min_Total => SnoData.Attributes.GetAttributeByIndex(232);

	public IAttribute Damage_Weapon_Min_Total_All => SnoData.Attributes.GetAttributeByIndex(233);

	public IAttribute Damage_Weapon_Average => SnoData.Attributes.GetAttributeByIndex(234);

	public IAttribute Damage_Weapon_Average_Total => SnoData.Attributes.GetAttributeByIndex(235);

	public IAttribute Damage_Weapon_Average_Total_All => SnoData.Attributes.GetAttributeByIndex(236);

	public IAttribute Damage_Weapon_Bonus_Min => SnoData.Attributes.GetAttributeByIndex(237);

	public IAttribute Damage_Weapon_Bonus_Min_X1 => SnoData.Attributes.GetAttributeByIndex(238);

	public IAttribute Damage_Weapon_Bonus_Flat => SnoData.Attributes.GetAttributeByIndex(239);

	public IAttribute Damage_Weapon_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(240);

	public IAttribute Damage_Weapon_Percent_All => SnoData.Attributes.GetAttributeByIndex(241);

	public IAttribute Damage_Weapon_Percent_Total => SnoData.Attributes.GetAttributeByIndex(242);

	public IAttribute Damage_Type_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(243);

	public IAttribute Damage_Dealt_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(244);

	public IAttribute Damage_Percent_Bonus_Barbarian => SnoData.Attributes.GetAttributeByIndex(245);

	public IAttribute Damage_Percent_Bonus_Crusader => SnoData.Attributes.GetAttributeByIndex(246);

	public IAttribute Damage_Percent_Bonus_Demonhunter => SnoData.Attributes.GetAttributeByIndex(247);

	public IAttribute Damage_Percent_Bonus_Monk => SnoData.Attributes.GetAttributeByIndex(248);

	public IAttribute Damage_Percent_Bonus_Necromancer => SnoData.Attributes.GetAttributeByIndex(249);

	public IAttribute Damage_Percent_Bonus_Witchdoctor => SnoData.Attributes.GetAttributeByIndex(250);

	public IAttribute Damage_Percent_Bonus_Wizard => SnoData.Attributes.GetAttributeByIndex(251);

	public IAttribute Crit_Percent_Base => SnoData.Attributes.GetAttributeByIndex(252);

	public IAttribute Crit_Percent_Bonus_Capped => SnoData.Attributes.GetAttributeByIndex(253);

	public IAttribute Crit_Percent_Bonus_Uncapped => SnoData.Attributes.GetAttributeByIndex(254);

	public IAttribute Crit_Percent_Bonus_Hide_From_DPS => SnoData.Attributes.GetAttributeByIndex(255);

	public IAttribute Crit_Percent_Cap => SnoData.Attributes.GetAttributeByIndex(256);

	public IAttribute Crit_Damage_Cap => SnoData.Attributes.GetAttributeByIndex(257);

	public IAttribute Crit_Damage_Percent => SnoData.Attributes.GetAttributeByIndex(258);

	public IAttribute Crit_Damage_Percent_Uncapped => SnoData.Attributes.GetAttributeByIndex(259);

	public IAttribute Crit_Effect_Time => SnoData.Attributes.GetAttributeByIndex(260);

	public IAttribute Pierce_Chance => SnoData.Attributes.GetAttributeByIndex(261);

	public IAttribute Damage_Absorb_Percent => SnoData.Attributes.GetAttributeByIndex(262);

	public IAttribute Damage_Reduction_Total => SnoData.Attributes.GetAttributeByIndex(263);

	public IAttribute Damage_Reduction_Current => SnoData.Attributes.GetAttributeByIndex(264);

	public IAttribute Damage_Reduction_Last_Tick => SnoData.Attributes.GetAttributeByIndex(265);

	public IAttribute Block_Chance => SnoData.Attributes.GetAttributeByIndex(266);

	public IAttribute Block_Chance_Sub_Total => SnoData.Attributes.GetAttributeByIndex(267);

	public IAttribute Block_Chance_Bonus_Item => SnoData.Attributes.GetAttributeByIndex(268);

	public IAttribute Block_Chance_Item => SnoData.Attributes.GetAttributeByIndex(269);

	public IAttribute Block_Chance_Item_Total => SnoData.Attributes.GetAttributeByIndex(270);

	public IAttribute Block_Chance_Uncapped_Bonus => SnoData.Attributes.GetAttributeByIndex(271);

	public IAttribute Block_Chance_Capped_Total => SnoData.Attributes.GetAttributeByIndex(272);

	public IAttribute Block_Amount => SnoData.Attributes.GetAttributeByIndex(273);

	public IAttribute Block_Amount_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(274);

	public IAttribute Block_Amount_Total_Min => SnoData.Attributes.GetAttributeByIndex(275);

	public IAttribute Block_Amount_Total_Max => SnoData.Attributes.GetAttributeByIndex(276);

	public IAttribute Block_Amount_Item_Min => SnoData.Attributes.GetAttributeByIndex(277);

	public IAttribute Block_Amount_Item_Delta => SnoData.Attributes.GetAttributeByIndex(278);

	public IAttribute Block_Amount_Item_Bonus => SnoData.Attributes.GetAttributeByIndex(279);

	public IAttribute Dodge_Chance_Bonus => SnoData.Attributes.GetAttributeByIndex(280);

	public IAttribute Dodge_Chance_Bonus_Melee => SnoData.Attributes.GetAttributeByIndex(281);

	public IAttribute Dodge_Chance_Bonus_Ranged => SnoData.Attributes.GetAttributeByIndex(282);

	public IAttribute Dodge_Chance_Bonus_Additive => SnoData.Attributes.GetAttributeByIndex(283);

	public IAttribute Dodge_Chance_Bonus_Hide_From_Toughness => SnoData.Attributes.GetAttributeByIndex(284);

	public IAttribute Cannot_Dodge => SnoData.Attributes.GetAttributeByIndex(285);

	public IAttribute Get_Hit_Current => SnoData.Attributes.GetAttributeByIndex(286);

	public IAttribute Get_Hit_Max_Base => SnoData.Attributes.GetAttributeByIndex(287);

	public IAttribute Get_Hit_Max_Per_Level => SnoData.Attributes.GetAttributeByIndex(288);

	public IAttribute Get_Hit_Max => SnoData.Attributes.GetAttributeByIndex(289);

	public IAttribute Get_Hit_Recovery_Base => SnoData.Attributes.GetAttributeByIndex(290);

	public IAttribute Get_Hit_Recovery_Per_Level => SnoData.Attributes.GetAttributeByIndex(291);

	public IAttribute Get_Hit_Recovery => SnoData.Attributes.GetAttributeByIndex(292);

	public IAttribute Get_Hit_Damage => SnoData.Attributes.GetAttributeByIndex(293);

	public IAttribute Get_Hit_Damage_Scalar => SnoData.Attributes.GetAttributeByIndex(294);

	public IAttribute Last_Damage_MainActor => SnoData.Attributes.GetAttributeByIndex(295);

	public IAttribute Last_ACD_Attacked => SnoData.Attributes.GetAttributeByIndex(296);

	public IAttribute Ignores_Critical_Hits => SnoData.Attributes.GetAttributeByIndex(297);

	public IAttribute Immunity => SnoData.Attributes.GetAttributeByIndex(298);

	public IAttribute Untargetable => SnoData.Attributes.GetAttributeByIndex(299);

	public IAttribute Immobolize => SnoData.Attributes.GetAttributeByIndex(300);

	public IAttribute Immune_To_Knockback => SnoData.Attributes.GetAttributeByIndex(301);

	public IAttribute Power_Immobilize => SnoData.Attributes.GetAttributeByIndex(302);

	public IAttribute Stun_Chance => SnoData.Attributes.GetAttributeByIndex(303);

	public IAttribute Stun_Length => SnoData.Attributes.GetAttributeByIndex(304);

	public IAttribute Stun_Recovery => SnoData.Attributes.GetAttributeByIndex(305);

	public IAttribute Stun_Recovery_Speed => SnoData.Attributes.GetAttributeByIndex(306);

	public IAttribute Stunned => SnoData.Attributes.GetAttributeByIndex(307);

	public IAttribute Stun_Immune => SnoData.Attributes.GetAttributeByIndex(308);

	public IAttribute Poison_Length_Reduction => SnoData.Attributes.GetAttributeByIndex(309);

	public IAttribute Bleeding => SnoData.Attributes.GetAttributeByIndex(310);

	public IAttribute Bleed_Duration => SnoData.Attributes.GetAttributeByIndex(311);

	public IAttribute Chilled => SnoData.Attributes.GetAttributeByIndex(312);

	public IAttribute Freeze_Length_Reduction => SnoData.Attributes.GetAttributeByIndex(313);

	public IAttribute Freeze_Immune => SnoData.Attributes.GetAttributeByIndex(314);

	public IAttribute Chill_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(315);

	public IAttribute Freeze_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(316);

	public IAttribute Stun_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(317);

	public IAttribute Immobilize_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(318);

	public IAttribute Fear_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(319);

	public IAttribute Blind_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(320);

	public IAttribute Charm_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(321);

	public IAttribute Slow_Duration_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(322);

	public IAttribute Webbed => SnoData.Attributes.GetAttributeByIndex(323);

	public IAttribute Slow => SnoData.Attributes.GetAttributeByIndex(324);

	public IAttribute FireAura => SnoData.Attributes.GetAttributeByIndex(325);

	public IAttribute LightningAura => SnoData.Attributes.GetAttributeByIndex(326);

	public IAttribute ColdAura => SnoData.Attributes.GetAttributeByIndex(327);

	public IAttribute PoisonAura => SnoData.Attributes.GetAttributeByIndex(328);

	public IAttribute Blind => SnoData.Attributes.GetAttributeByIndex(329);

	public IAttribute Enraged => SnoData.Attributes.GetAttributeByIndex(330);

	public IAttribute Slowdown_Immune => SnoData.Attributes.GetAttributeByIndex(331);

	public IAttribute Gethit_Immune => SnoData.Attributes.GetAttributeByIndex(332);

	public IAttribute AttackSpeed_Reduction_Immune => SnoData.Attributes.GetAttributeByIndex(333);

	public IAttribute Suffocation_Per_Second => SnoData.Attributes.GetAttributeByIndex(334);

	public IAttribute Suffocation_Unit_Value => SnoData.Attributes.GetAttributeByIndex(335);

	public IAttribute Thorns_Percent => SnoData.Attributes.GetAttributeByIndex(336);

	public IAttribute Thorns_Percent_All => SnoData.Attributes.GetAttributeByIndex(337);

	public IAttribute Thorns_Percent_Total => SnoData.Attributes.GetAttributeByIndex(338);

	public IAttribute Thorns_Fixed => SnoData.Attributes.GetAttributeByIndex(339);

	public IAttribute Thorns_Fixed_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(340);

	public IAttribute Thorns_Fixed_Total => SnoData.Attributes.GetAttributeByIndex(341);

	public IAttribute Thorns_AOE_Radius => SnoData.Attributes.GetAttributeByIndex(342);

	public IAttribute Thorns_Has_Damage_Type => SnoData.Attributes.GetAttributeByIndex(343);

	public IAttribute On_First_Hit_Thorns_Percent => SnoData.Attributes.GetAttributeByIndex(344);

	public IAttribute Steal_Health_Percent => SnoData.Attributes.GetAttributeByIndex(345);

	public IAttribute Steal_Mana_Percent => SnoData.Attributes.GetAttributeByIndex(346);

	public IAttribute Resource_On_Hit => SnoData.Attributes.GetAttributeByIndex(347);

	public IAttribute Resource_On_Hit_Bonus_Pct => SnoData.Attributes.GetAttributeByIndex(348);

	public IAttribute Resource_On_Hit_Bonus => SnoData.Attributes.GetAttributeByIndex(349);

	public IAttribute Resource_On_Kill => SnoData.Attributes.GetAttributeByIndex(350);

	public IAttribute Resource_On_Crit => SnoData.Attributes.GetAttributeByIndex(351);

	public IAttribute Hitpoints_On_Hit => SnoData.Attributes.GetAttributeByIndex(352);

	public IAttribute Hitpoints_On_Kill => SnoData.Attributes.GetAttributeByIndex(353);

	public IAttribute Hitpoints_On_Kill_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(354);

	public IAttribute Hitpoints_On_Kill_Total => SnoData.Attributes.GetAttributeByIndex(355);

	public IAttribute Damage_To_Mana => SnoData.Attributes.GetAttributeByIndex(356);

	public IAttribute Last_Proc_Time => SnoData.Attributes.GetAttributeByIndex(357);

	public IAttribute Damage_Power_Delta => SnoData.Attributes.GetAttributeByIndex(358);

	public IAttribute Damage_Power_Min => SnoData.Attributes.GetAttributeByIndex(359);

	public IAttribute Rope_Overlay => SnoData.Attributes.GetAttributeByIndex(360);

	public IAttribute General_Cooldown => SnoData.Attributes.GetAttributeByIndex(361);

	public IAttribute Power_Cooldown => SnoData.Attributes.GetAttributeByIndex(362);

	public IAttribute Power_Cooldown_Start => SnoData.Attributes.GetAttributeByIndex(363);

	public IAttribute Proc_Cooldown => SnoData.Attributes.GetAttributeByIndex(364);

	public IAttribute Emote_Cooldown => SnoData.Attributes.GetAttributeByIndex(365);

	public IAttribute Projectile_Speed => SnoData.Attributes.GetAttributeByIndex(366);

	public IAttribute Projectile_Speed_Increase_Percent => SnoData.Attributes.GetAttributeByIndex(367);

	public IAttribute DestroyWhenPathBlocked => SnoData.Attributes.GetAttributeByIndex(368);

	public IAttribute Skill_Toggled_State => SnoData.Attributes.GetAttributeByIndex(369);

	public IAttribute Skill_Charges => SnoData.Attributes.GetAttributeByIndex(370);

	public IAttribute Next_Charge_Gained_time => SnoData.Attributes.GetAttributeByIndex(371);

	public IAttribute Recharge_Start_Time => SnoData.Attributes.GetAttributeByIndex(372);

	public IAttribute Act => SnoData.Attributes.GetAttributeByIndex(373);

	public IAttribute Difficulty => SnoData.Attributes.GetAttributeByIndex(374);

	public IAttribute Last_Damage_Amount => SnoData.Attributes.GetAttributeByIndex(375);

	public IAttribute In_Knockback => SnoData.Attributes.GetAttributeByIndex(376);

	public IAttribute Amplify_Damage_Type_Percent => SnoData.Attributes.GetAttributeByIndex(377);

	public IAttribute Amplify_Damage_Skill_Percent => SnoData.Attributes.GetAttributeByIndex(378);

	public IAttribute Amplify_Damage_Percent => SnoData.Attributes.GetAttributeByIndex(379);

	public IAttribute Durability_Cur => SnoData.Attributes.GetAttributeByIndex(380);

	public IAttribute Durability_Max => SnoData.Attributes.GetAttributeByIndex(381);

	public IAttribute Durability_Last_Damage => SnoData.Attributes.GetAttributeByIndex(382);

	public IAttribute Item_Quality_Level => SnoData.Attributes.GetAttributeByIndex(383);

	public IAttribute Item_Quality_Level_Identified => SnoData.Attributes.GetAttributeByIndex(384);

	public IAttribute Item_Cost_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(385);

	public IAttribute Item_Equipped => SnoData.Attributes.GetAttributeByIndex(386);

	public IAttribute Ping => SnoData.Attributes.GetAttributeByIndex(387);

	public IAttribute Requirement => SnoData.Attributes.GetAttributeByIndex(388);

	public IAttribute Requirements_Ease_Percent => SnoData.Attributes.GetAttributeByIndex(389);

	public IAttribute Requirement_When_Equipped => SnoData.Attributes.GetAttributeByIndex(390);

	public IAttribute Sockets => SnoData.Attributes.GetAttributeByIndex(391);

	public IAttribute Sockets_Filled => SnoData.Attributes.GetAttributeByIndex(392);

	public IAttribute Stats_All_Bonus => SnoData.Attributes.GetAttributeByIndex(393);

	public IAttribute Item_Bound_To_ACD => SnoData.Attributes.GetAttributeByIndex(394);

	public IAttribute Item_Locked_To_ACD => SnoData.Attributes.GetAttributeByIndex(395);

	public IAttribute Item_Binding_Level_Override => SnoData.Attributes.GetAttributeByIndex(396);

	public IAttribute Item_LegendaryItem_Level_Override => SnoData.Attributes.GetAttributeByIndex(397);

	public IAttribute Item_Targeted_Player_Class => SnoData.Attributes.GetAttributeByIndex(398);

	public IAttribute Item_Targeted_Hireling_Class => SnoData.Attributes.GetAttributeByIndex(399);

	public IAttribute ItemStackQuantityHi => SnoData.Attributes.GetAttributeByIndex(400);

	public IAttribute ItemStackQuantityLo => SnoData.Attributes.GetAttributeByIndex(401);

	public IAttribute Run_Speed_Granted => SnoData.Attributes.GetAttributeByIndex(402);

	public IAttribute Run_Speed_Duration => SnoData.Attributes.GetAttributeByIndex(403);

	public IAttribute IdentifyCost => SnoData.Attributes.GetAttributeByIndex(404);

	public IAttribute Seed => SnoData.Attributes.GetAttributeByIndex(405);

	public IAttribute IsCrafted => SnoData.Attributes.GetAttributeByIndex(406);

	public IAttribute IsVendorBought => SnoData.Attributes.GetAttributeByIndex(407);

	public IAttribute DyeType => SnoData.Attributes.GetAttributeByIndex(408);

	public IAttribute Loot_2_0_Drop => SnoData.Attributes.GetAttributeByIndex(409);

	public IAttribute Post_2_1_2_Drop => SnoData.Attributes.GetAttributeByIndex(410);

	public IAttribute Post_2_5_0_Drop => SnoData.Attributes.GetAttributeByIndex(412);

	public IAttribute Ancient_Rank => SnoData.Attributes.GetAttributeByIndex(413);

	public IAttribute Unidentified => SnoData.Attributes.GetAttributeByIndex(414);

	public IAttribute RemoveLevelReq => SnoData.Attributes.GetAttributeByIndex(415);

	public IAttribute ConsumableAddSockets => SnoData.Attributes.GetAttributeByIndex(416);

	public IAttribute AddSocketsType_Weapon => SnoData.Attributes.GetAttributeByIndex(417);

	public IAttribute AddSocketsType_Offhand => SnoData.Attributes.GetAttributeByIndex(418);

	public IAttribute AddSocketsType_Legs => SnoData.Attributes.GetAttributeByIndex(419);

	public IAttribute AddSocketsType_Chest => SnoData.Attributes.GetAttributeByIndex(420);

	public IAttribute AddSocketsType_Helm => SnoData.Attributes.GetAttributeByIndex(421);

	public IAttribute AddSocketsType_Jewelry => SnoData.Attributes.GetAttributeByIndex(422);

	public IAttribute EnchantedAffixOld => SnoData.Attributes.GetAttributeByIndex(423);

	public IAttribute EnchantedAffixNew => SnoData.Attributes.GetAttributeByIndex(424);

	public IAttribute EnchantedAffixSeed => SnoData.Attributes.GetAttributeByIndex(425);

	public IAttribute EnchantedAffixCount => SnoData.Attributes.GetAttributeByIndex(426);

	public IAttribute TransmogGBID => SnoData.Attributes.GetAttributeByIndex(427);

	public IAttribute TransmogGBIDTempOverride => SnoData.Attributes.GetAttributeByIndex(428);

	public IAttribute HighlySalvageable => SnoData.Attributes.GetAttributeByIndex(429);

	public IAttribute ItemUnlockTimeHi => SnoData.Attributes.GetAttributeByIndex(430);

	public IAttribute ItemUnlockTimeLo => SnoData.Attributes.GetAttributeByIndex(431);

	public IAttribute CubeEnchantedGemRank => SnoData.Attributes.GetAttributeByIndex(432);

	public IAttribute CubeEnchantedGemType => SnoData.Attributes.GetAttributeByIndex(433);

	public IAttribute Cube_Enchanted_Strength_Item => SnoData.Attributes.GetAttributeByIndex(434);

	public IAttribute Cube_Enchanted_Dexterity_Item => SnoData.Attributes.GetAttributeByIndex(435);

	public IAttribute Cube_Enchanted_Intelligence_Item => SnoData.Attributes.GetAttributeByIndex(436);

	public IAttribute Cube_Enchanted_Vitality_Item => SnoData.Attributes.GetAttributeByIndex(437);

	public IAttribute Always_Plays_GetHit => SnoData.Attributes.GetAttributeByIndex(438);

	public IAttribute Hidden => SnoData.Attributes.GetAttributeByIndex(439);

	public IAttribute Alpha_For_Other_Players => SnoData.Attributes.GetAttributeByIndex(440);

	public IAttribute AlphaAttachments => SnoData.Attributes.GetAttributeByIndex(441);

	public IAttribute RActor_Fade_Group => SnoData.Attributes.GetAttributeByIndex(442);

	public IAttribute QuestRange => SnoData.Attributes.GetAttributeByIndex(443);

	public IAttribute Attack_Cooldown_Min => SnoData.Attributes.GetAttributeByIndex(444);

	public IAttribute Attack_Cooldown_Delta => SnoData.Attributes.GetAttributeByIndex(445);

	public IAttribute InitialCooldownMinTotal => SnoData.Attributes.GetAttributeByIndex(446);

	public IAttribute InitialCooldownDeltaTotal => SnoData.Attributes.GetAttributeByIndex(447);

	public IAttribute Attack_Cooldown_Min_Total => SnoData.Attributes.GetAttributeByIndex(448);

	public IAttribute Attack_Cooldown_Delta_Total => SnoData.Attributes.GetAttributeByIndex(449);

	public IAttribute Closing_Cooldown_Min_Total => SnoData.Attributes.GetAttributeByIndex(450);

	public IAttribute Closing_Cooldown_Delta_Total => SnoData.Attributes.GetAttributeByIndex(451);

	public IAttribute Quest_Monster => SnoData.Attributes.GetAttributeByIndex(452);

	public IAttribute Quest_MonsterEffect => SnoData.Attributes.GetAttributeByIndex(453);

	public IAttribute Treasure_Class => SnoData.Attributes.GetAttributeByIndex(454);

	public IAttribute Removes_Body_On_Death => SnoData.Attributes.GetAttributeByIndex(455);

	public IAttribute InitialCooldownMin => SnoData.Attributes.GetAttributeByIndex(456);

	public IAttribute InitialCooldownDelta => SnoData.Attributes.GetAttributeByIndex(457);

	public IAttribute Knockback_Weight => SnoData.Attributes.GetAttributeByIndex(458);

	public IAttribute UntargetableByPets => SnoData.Attributes.GetAttributeByIndex(459);

	public IAttribute Damage_State_Current => SnoData.Attributes.GetAttributeByIndex(460);

	public IAttribute Damage_State_Max => SnoData.Attributes.GetAttributeByIndex(461);

	public IAttribute Is_Player_Decoy => SnoData.Attributes.GetAttributeByIndex(462);

	public IAttribute Custom_Target_Weight => SnoData.Attributes.GetAttributeByIndex(463);

	public IAttribute Gizmo_State => SnoData.Attributes.GetAttributeByIndex(464);

	public IAttribute Gizmo_Charges => SnoData.Attributes.GetAttributeByIndex(465);

	public IAttribute Chest_Open => SnoData.Attributes.GetAttributeByIndex(466);

	public IAttribute Door_Locked => SnoData.Attributes.GetAttributeByIndex(467);

	public IAttribute Door_Timer => SnoData.Attributes.GetAttributeByIndex(468);

	public IAttribute Gizmo_Disabled_By_Script => SnoData.Attributes.GetAttributeByIndex(469);

	public IAttribute Gizmo_Operator_ACDID => SnoData.Attributes.GetAttributeByIndex(470);

	public IAttribute Triggering_Count => SnoData.Attributes.GetAttributeByIndex(471);

	public IAttribute Gizmo_Operation_Radius_Override => SnoData.Attributes.GetAttributeByIndex(472);

	public IAttribute Gate_Position => SnoData.Attributes.GetAttributeByIndex(473);

	public IAttribute Gate_Velocity => SnoData.Attributes.GetAttributeByIndex(474);

	public IAttribute Gizmo_Has_Been_Operated => SnoData.Attributes.GetAttributeByIndex(475);

	public IAttribute Banner_Usable => SnoData.Attributes.GetAttributeByIndex(476);

	public IAttribute Banner_Player_In_Combat => SnoData.Attributes.GetAttributeByIndex(477);

	public IAttribute Pet_Owner => SnoData.Attributes.GetAttributeByIndex(478);

	public IAttribute Pet_Creator => SnoData.Attributes.GetAttributeByIndex(479);

	public IAttribute Pet_Type => SnoData.Attributes.GetAttributeByIndex(480);

	public IAttribute DropsNoLoot => SnoData.Attributes.GetAttributeByIndex(481);

	public IAttribute GrantsNoXP => SnoData.Attributes.GetAttributeByIndex(482);

	public IAttribute Hireling_Class => SnoData.Attributes.GetAttributeByIndex(483);

	public IAttribute Summoned_By_SNO => SnoData.Attributes.GetAttributeByIndex(484);

	public IAttribute Pet_Proc_Scalar => SnoData.Attributes.GetAttributeByIndex(485);

	public IAttribute Pet_Cannot_Be_Dismissed => SnoData.Attributes.GetAttributeByIndex(486);

	public IAttribute Is_NPC => SnoData.Attributes.GetAttributeByIndex(487);

	public IAttribute NPC_Is_Operatable => SnoData.Attributes.GetAttributeByIndex(488);

	public IAttribute NPC_Is_Escorting => SnoData.Attributes.GetAttributeByIndex(489);

	public IAttribute NPC_Has_Interact_Options => SnoData.Attributes.GetAttributeByIndex(490);

	public IAttribute Conversation_Icon => SnoData.Attributes.GetAttributeByIndex(491);

	public IAttribute Conversation_Icon_Override => SnoData.Attributes.GetAttributeByIndex(492);

	public IAttribute Callout_Cooldown => SnoData.Attributes.GetAttributeByIndex(493);

	public IAttribute Banter_Cooldown => SnoData.Attributes.GetAttributeByIndex(494);

	public IAttribute Conversation_Heard_Count => SnoData.Attributes.GetAttributeByIndex(495);

	public IAttribute Last_Tick_Shop_Entered => SnoData.Attributes.GetAttributeByIndex(496);

	public IAttribute Is_Helper => SnoData.Attributes.GetAttributeByIndex(497);

	public IAttribute Axe => SnoData.Attributes.GetAttributeByIndex(498);

	public IAttribute Axe2H => SnoData.Attributes.GetAttributeByIndex(499);

	public IAttribute ThrowingAxe => SnoData.Attributes.GetAttributeByIndex(500);

	public IAttribute AxeAny => SnoData.Attributes.GetAttributeByIndex(501);

	public IAttribute Bow => SnoData.Attributes.GetAttributeByIndex(502);

	public IAttribute Crossbow => SnoData.Attributes.GetAttributeByIndex(503);

	public IAttribute BowAny => SnoData.Attributes.GetAttributeByIndex(504);

	public IAttribute Club => SnoData.Attributes.GetAttributeByIndex(505);

	public IAttribute Club2H => SnoData.Attributes.GetAttributeByIndex(506);

	public IAttribute ClubAny => SnoData.Attributes.GetAttributeByIndex(507);

	public IAttribute Dagger => SnoData.Attributes.GetAttributeByIndex(508);

	public IAttribute Mace => SnoData.Attributes.GetAttributeByIndex(509);

	public IAttribute Mace2H => SnoData.Attributes.GetAttributeByIndex(510);

	public IAttribute MaceAny => SnoData.Attributes.GetAttributeByIndex(511);

	public IAttribute Sword => SnoData.Attributes.GetAttributeByIndex(512);

	public IAttribute Sword2H => SnoData.Attributes.GetAttributeByIndex(513);

	public IAttribute SwordAny => SnoData.Attributes.GetAttributeByIndex(514);

	public IAttribute Polearm => SnoData.Attributes.GetAttributeByIndex(515);

	public IAttribute Spear => SnoData.Attributes.GetAttributeByIndex(516);

	public IAttribute Wand => SnoData.Attributes.GetAttributeByIndex(517);

	public IAttribute ColdStaff => SnoData.Attributes.GetAttributeByIndex(518);

	public IAttribute FireStaff => SnoData.Attributes.GetAttributeByIndex(519);

	public IAttribute LightningStaff => SnoData.Attributes.GetAttributeByIndex(520);

	public IAttribute PoisonStaff => SnoData.Attributes.GetAttributeByIndex(521);

	public IAttribute StaffAny => SnoData.Attributes.GetAttributeByIndex(522);

	public IAttribute Weapon1H => SnoData.Attributes.GetAttributeByIndex(523);

	public IAttribute Weapon2H => SnoData.Attributes.GetAttributeByIndex(524);

	public IAttribute WeaponMelee => SnoData.Attributes.GetAttributeByIndex(525);

	public IAttribute WeaponRanged => SnoData.Attributes.GetAttributeByIndex(526);

	public IAttribute Quiver => SnoData.Attributes.GetAttributeByIndex(527);

	public IAttribute Reincarnation_Buff => SnoData.Attributes.GetAttributeByIndex(528);

	public IAttribute Dead_Body_AnimTag => SnoData.Attributes.GetAttributeByIndex(529);

	public IAttribute Spawned_by_ACDID => SnoData.Attributes.GetAttributeByIndex(530);

	public IAttribute Summoned_By_ACDID => SnoData.Attributes.GetAttributeByIndex(531);

	public IAttribute Summoner_ID => SnoData.Attributes.GetAttributeByIndex(532);

	public IAttribute Banner_ACDID => SnoData.Attributes.GetAttributeByIndex(533);

	public IAttribute Breakable_Shield_HP => SnoData.Attributes.GetAttributeByIndex(534);

	public IAttribute Current_WeaponClass => SnoData.Attributes.GetAttributeByIndex(535);

	public IAttribute Weapons_Sheathed => SnoData.Attributes.GetAttributeByIndex(536);

	public IAttribute Held_In_OffHand => SnoData.Attributes.GetAttributeByIndex(537);

	public IAttribute Attacks_Per_Second_Item_MainHand => SnoData.Attributes.GetAttributeByIndex(538);

	public IAttribute Attacks_Per_Second_Item_OffHand => SnoData.Attributes.GetAttributeByIndex(539);

	public IAttribute Attacks_Per_Second_Item_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(540);

	public IAttribute Attacks_Per_Second_Item_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(541);

	public IAttribute Damage_Weapon_Min_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(542);

	public IAttribute Damage_Weapon_Min_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(543);

	public IAttribute Damage_Weapon_Delta_Total_MainHand => SnoData.Attributes.GetAttributeByIndex(544);

	public IAttribute Damage_Weapon_Delta_Total_OffHand => SnoData.Attributes.GetAttributeByIndex(545);

	public IAttribute Attacks_Per_Second_Item_CurrentHand => SnoData.Attributes.GetAttributeByIndex(546);

	public IAttribute Damage_Weapon_Min_Total_CurrentHand => SnoData.Attributes.GetAttributeByIndex(547);

	public IAttribute Damage_Weapon_Delta_Total_CurrentHand => SnoData.Attributes.GetAttributeByIndex(548);

	public IAttribute Has_Special_Death_AnimTag => SnoData.Attributes.GetAttributeByIndex(549);

	public IAttribute Death_Type_Override => SnoData.Attributes.GetAttributeByIndex(550);

	public IAttribute In_Combat => SnoData.Attributes.GetAttributeByIndex(551);

	public IAttribute In_Combat_Next_Tick_Check => SnoData.Attributes.GetAttributeByIndex(552);

	public IAttribute In_Conversation => SnoData.Attributes.GetAttributeByIndex(553);

	public IAttribute Last_Tick_Potion_Used => SnoData.Attributes.GetAttributeByIndex(554);

	public IAttribute Potion_Dilution_Percent => SnoData.Attributes.GetAttributeByIndex(555);

	public IAttribute Out_Of_Combat_Health_Regen_Percent => SnoData.Attributes.GetAttributeByIndex(556);

	public IAttribute Out_Of_Combat_Mana_Regen_Percent => SnoData.Attributes.GetAttributeByIndex(557);

	public IAttribute Potion_Dilution_Duration => SnoData.Attributes.GetAttributeByIndex(558);

	public IAttribute Potion_Dilution_Scalar => SnoData.Attributes.GetAttributeByIndex(559);

	public IAttribute Feared => SnoData.Attributes.GetAttributeByIndex(560);

	public IAttribute Fear_Immune => SnoData.Attributes.GetAttributeByIndex(561);

	public IAttribute Last_Damage_ACD => SnoData.Attributes.GetAttributeByIndex(562);

	public IAttribute Attached_To_ACD => SnoData.Attributes.GetAttributeByIndex(563);

	public IAttribute Attachment_ACD => SnoData.Attributes.GetAttributeByIndex(564);

	public IAttribute Normal_Attack_Replacement_Power_SNO => SnoData.Attributes.GetAttributeByIndex(565);

	public IAttribute Damage_Type_Override => SnoData.Attributes.GetAttributeByIndex(566);

	public IAttribute Minion_Count_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(567);

	public IAttribute Expensive_Proc_Count => SnoData.Attributes.GetAttributeByIndex(568);

	public IAttribute Post_260A_Legendary_Gem_Cap => SnoData.Attributes.GetAttributeByIndex(569);

	public IAttribute Pet_Dont_Kill_When_Entering_Rifts => SnoData.Attributes.GetAttributeByIndex(570);

	public IAttribute Champion_Clone_Next_Tick => SnoData.Attributes.GetAttributeByIndex(571);

	public IAttribute Champion_Clone_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(572);

	public IAttribute Champion_Clone_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(573);

	public IAttribute Champion_Clone_Hitpoint_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(574);

	public IAttribute Champion_Clone_Damage_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(575);

	public IAttribute Champion_Ghostly_Next_Tick => SnoData.Attributes.GetAttributeByIndex(576);

	public IAttribute Champion_Ghostly_Inactive_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(577);

	public IAttribute Champion_Ghostly_Inactive_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(578);

	public IAttribute Champion_Ghostly_Active_Time_Min_In_Seconds => SnoData.Attributes.GetAttributeByIndex(579);

	public IAttribute Champion_Ghostly_Active_Time_Delta_In_Seconds => SnoData.Attributes.GetAttributeByIndex(580);

	public IAttribute Champion_Ghostly_Saved_Dodge_Chance => SnoData.Attributes.GetAttributeByIndex(581);

	public IAttribute Champion_Ghostly => SnoData.Attributes.GetAttributeByIndex(582);

	public IAttribute Base_Element => SnoData.Attributes.GetAttributeByIndex(583);

	public IAttribute Projectile_Amount_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(584);

	public IAttribute Projectile_Reflect_Chance => SnoData.Attributes.GetAttributeByIndex(585);

	public IAttribute Projectile_Reflect_Forced_Target => SnoData.Attributes.GetAttributeByIndex(586);

	public IAttribute Projectile_Reflect_Damage_Scalar => SnoData.Attributes.GetAttributeByIndex(587);

	public IAttribute Projectile_Reflect_Has_Damage_Cap => SnoData.Attributes.GetAttributeByIndex(588);

	public IAttribute Projectile_Reflect_Damage_Cap_Remaining => SnoData.Attributes.GetAttributeByIndex(589);

	public IAttribute Attack_Fear_Chance => SnoData.Attributes.GetAttributeByIndex(590);

	public IAttribute Attack_Fear_Time_Min => SnoData.Attributes.GetAttributeByIndex(591);

	public IAttribute Attack_Fear_Time_Delta => SnoData.Attributes.GetAttributeByIndex(592);

	public IAttribute Buff_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(593);

	public IAttribute Buff_Icon_Start_Tick0 => SnoData.Attributes.GetAttributeByIndex(594);

	public IAttribute Buff_Icon_Start_Tick1 => SnoData.Attributes.GetAttributeByIndex(595);

	public IAttribute Buff_Icon_Start_Tick2 => SnoData.Attributes.GetAttributeByIndex(596);

	public IAttribute Buff_Icon_Start_Tick3 => SnoData.Attributes.GetAttributeByIndex(597);

	public IAttribute Buff_Icon_Start_Tick4 => SnoData.Attributes.GetAttributeByIndex(598);

	public IAttribute Buff_Icon_Start_Tick5 => SnoData.Attributes.GetAttributeByIndex(599);

	public IAttribute Buff_Icon_Start_Tick6 => SnoData.Attributes.GetAttributeByIndex(600);

	public IAttribute Buff_Icon_Start_Tick7 => SnoData.Attributes.GetAttributeByIndex(601);

	public IAttribute Buff_Icon_Start_Tick8 => SnoData.Attributes.GetAttributeByIndex(602);

	public IAttribute Buff_Icon_Start_Tick9 => SnoData.Attributes.GetAttributeByIndex(603);

	public IAttribute Buff_Icon_Start_Tick10 => SnoData.Attributes.GetAttributeByIndex(604);

	public IAttribute Buff_Icon_Start_Tick11 => SnoData.Attributes.GetAttributeByIndex(605);

	public IAttribute Buff_Icon_Start_Tick12 => SnoData.Attributes.GetAttributeByIndex(606);

	public IAttribute Buff_Icon_Start_Tick13 => SnoData.Attributes.GetAttributeByIndex(607);

	public IAttribute Buff_Icon_Start_Tick14 => SnoData.Attributes.GetAttributeByIndex(608);

	public IAttribute Buff_Icon_Start_Tick15 => SnoData.Attributes.GetAttributeByIndex(609);

	public IAttribute Buff_Icon_Start_Tick16 => SnoData.Attributes.GetAttributeByIndex(610);

	public IAttribute Buff_Icon_Start_Tick17 => SnoData.Attributes.GetAttributeByIndex(611);

	public IAttribute Buff_Icon_Start_Tick18 => SnoData.Attributes.GetAttributeByIndex(612);

	public IAttribute Buff_Icon_Start_Tick19 => SnoData.Attributes.GetAttributeByIndex(613);

	public IAttribute Buff_Icon_Start_Tick20 => SnoData.Attributes.GetAttributeByIndex(614);

	public IAttribute Buff_Icon_Start_Tick21 => SnoData.Attributes.GetAttributeByIndex(615);

	public IAttribute Buff_Icon_Start_Tick22 => SnoData.Attributes.GetAttributeByIndex(616);

	public IAttribute Buff_Icon_Start_Tick23 => SnoData.Attributes.GetAttributeByIndex(617);

	public IAttribute Buff_Icon_Start_Tick24 => SnoData.Attributes.GetAttributeByIndex(618);

	public IAttribute Buff_Icon_Start_Tick25 => SnoData.Attributes.GetAttributeByIndex(619);

	public IAttribute Buff_Icon_Start_Tick26 => SnoData.Attributes.GetAttributeByIndex(620);

	public IAttribute Buff_Icon_Start_Tick27 => SnoData.Attributes.GetAttributeByIndex(621);

	public IAttribute Buff_Icon_Start_Tick28 => SnoData.Attributes.GetAttributeByIndex(622);

	public IAttribute Buff_Icon_Start_Tick29 => SnoData.Attributes.GetAttributeByIndex(623);

	public IAttribute Buff_Icon_Start_Tick30 => SnoData.Attributes.GetAttributeByIndex(624);

	public IAttribute Buff_Icon_Start_Tick31 => SnoData.Attributes.GetAttributeByIndex(625);

	public IAttribute Buff_Icon_End_Tick0 => SnoData.Attributes.GetAttributeByIndex(626);

	public IAttribute Buff_Icon_End_Tick1 => SnoData.Attributes.GetAttributeByIndex(627);

	public IAttribute Buff_Icon_End_Tick2 => SnoData.Attributes.GetAttributeByIndex(628);

	public IAttribute Buff_Icon_End_Tick3 => SnoData.Attributes.GetAttributeByIndex(629);

	public IAttribute Buff_Icon_End_Tick4 => SnoData.Attributes.GetAttributeByIndex(630);

	public IAttribute Buff_Icon_End_Tick5 => SnoData.Attributes.GetAttributeByIndex(631);

	public IAttribute Buff_Icon_End_Tick6 => SnoData.Attributes.GetAttributeByIndex(632);

	public IAttribute Buff_Icon_End_Tick7 => SnoData.Attributes.GetAttributeByIndex(633);

	public IAttribute Buff_Icon_End_Tick8 => SnoData.Attributes.GetAttributeByIndex(634);

	public IAttribute Buff_Icon_End_Tick9 => SnoData.Attributes.GetAttributeByIndex(635);

	public IAttribute Buff_Icon_End_Tick10 => SnoData.Attributes.GetAttributeByIndex(636);

	public IAttribute Buff_Icon_End_Tick11 => SnoData.Attributes.GetAttributeByIndex(637);

	public IAttribute Buff_Icon_End_Tick12 => SnoData.Attributes.GetAttributeByIndex(638);

	public IAttribute Buff_Icon_End_Tick13 => SnoData.Attributes.GetAttributeByIndex(639);

	public IAttribute Buff_Icon_End_Tick14 => SnoData.Attributes.GetAttributeByIndex(640);

	public IAttribute Buff_Icon_End_Tick15 => SnoData.Attributes.GetAttributeByIndex(641);

	public IAttribute Buff_Icon_End_Tick16 => SnoData.Attributes.GetAttributeByIndex(642);

	public IAttribute Buff_Icon_End_Tick17 => SnoData.Attributes.GetAttributeByIndex(643);

	public IAttribute Buff_Icon_End_Tick18 => SnoData.Attributes.GetAttributeByIndex(644);

	public IAttribute Buff_Icon_End_Tick19 => SnoData.Attributes.GetAttributeByIndex(645);

	public IAttribute Buff_Icon_End_Tick20 => SnoData.Attributes.GetAttributeByIndex(646);

	public IAttribute Buff_Icon_End_Tick21 => SnoData.Attributes.GetAttributeByIndex(647);

	public IAttribute Buff_Icon_End_Tick22 => SnoData.Attributes.GetAttributeByIndex(648);

	public IAttribute Buff_Icon_End_Tick23 => SnoData.Attributes.GetAttributeByIndex(649);

	public IAttribute Buff_Icon_End_Tick24 => SnoData.Attributes.GetAttributeByIndex(650);

	public IAttribute Buff_Icon_End_Tick25 => SnoData.Attributes.GetAttributeByIndex(651);

	public IAttribute Buff_Icon_End_Tick26 => SnoData.Attributes.GetAttributeByIndex(652);

	public IAttribute Buff_Icon_End_Tick27 => SnoData.Attributes.GetAttributeByIndex(653);

	public IAttribute Buff_Icon_End_Tick28 => SnoData.Attributes.GetAttributeByIndex(654);

	public IAttribute Buff_Icon_End_Tick29 => SnoData.Attributes.GetAttributeByIndex(655);

	public IAttribute Buff_Icon_End_Tick30 => SnoData.Attributes.GetAttributeByIndex(656);

	public IAttribute Buff_Icon_End_Tick31 => SnoData.Attributes.GetAttributeByIndex(657);

	public IAttribute Could_Have_Ragdolled => SnoData.Attributes.GetAttributeByIndex(658);

	public IAttribute Ambient_Damage_Effect_Last_Time => SnoData.Attributes.GetAttributeByIndex(659);

	public IAttribute Scale_Bonus => SnoData.Attributes.GetAttributeByIndex(660);

	public IAttribute Scale_Bonus_Is_Immediate => SnoData.Attributes.GetAttributeByIndex(661);

	public IAttribute Deleted_On_Server => SnoData.Attributes.GetAttributeByIndex(662);

	public IAttribute Scripted_Fade_Time => SnoData.Attributes.GetAttributeByIndex(663);

	public IAttribute Does_No_Damage => SnoData.Attributes.GetAttributeByIndex(664);

	public IAttribute Does_Fake_Damage => SnoData.Attributes.GetAttributeByIndex(665);

	public IAttribute SlowTime_Debuff => SnoData.Attributes.GetAttributeByIndex(666);

	public IAttribute Blocks_Projectiles => SnoData.Attributes.GetAttributeByIndex(667);

	public IAttribute Frozen => SnoData.Attributes.GetAttributeByIndex(668);

	public IAttribute Freeze_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(669);

	public IAttribute Shatter_Chance => SnoData.Attributes.GetAttributeByIndex(670);

	public IAttribute DualWield_BothAttack_Chance => SnoData.Attributes.GetAttributeByIndex(671);

	public IAttribute Summon_Expiration_Tick => SnoData.Attributes.GetAttributeByIndex(672);

	public IAttribute Summon_Count => SnoData.Attributes.GetAttributeByIndex(673);

	public IAttribute Uninterruptible => SnoData.Attributes.GetAttributeByIndex(674);

	public IAttribute QueueDeath => SnoData.Attributes.GetAttributeByIndex(675);

	public IAttribute CantStartDisplayedPowers => SnoData.Attributes.GetAttributeByIndex(676);

	public IAttribute GizmosIgnoreCantStartDisplayedPowers => SnoData.Attributes.GetAttributeByIndex(677);

	public IAttribute Wizard_Slowtime_Proxy_ACD => SnoData.Attributes.GetAttributeByIndex(678);

	public IAttribute DPS => SnoData.Attributes.GetAttributeByIndex(679);

	public IAttribute Resurrection_Power => SnoData.Attributes.GetAttributeByIndex(680);

	public IAttribute Freeze_Damage => SnoData.Attributes.GetAttributeByIndex(681);

	public IAttribute Freeze_Capacity => SnoData.Attributes.GetAttributeByIndex(682);

	public IAttribute Thaw_Rate => SnoData.Attributes.GetAttributeByIndex(683);

	public IAttribute Chilled_Dur_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(684);

	public IAttribute DOT_DPS => SnoData.Attributes.GetAttributeByIndex(685);

	public IAttribute DamageCap_Percent => SnoData.Attributes.GetAttributeByIndex(686);

	public IAttribute Item_Time_Sold => SnoData.Attributes.GetAttributeByIndex(687);

	public IAttribute Forced_Hireling_Power => SnoData.Attributes.GetAttributeByIndex(688);

	public IAttribute IsRooted => SnoData.Attributes.GetAttributeByIndex(689);

	public IAttribute RootTargetACD => SnoData.Attributes.GetAttributeByIndex(690);

	public IAttribute RootAutoDecayPerSecond => SnoData.Attributes.GetAttributeByIndex(691);

	public IAttribute RootUnitValue => SnoData.Attributes.GetAttributeByIndex(692);

	public IAttribute RootTotalTicks => SnoData.Attributes.GetAttributeByIndex(693);

	public IAttribute Hide_Affixes => SnoData.Attributes.GetAttributeByIndex(694);

	public IAttribute Rune_A => SnoData.Attributes.GetAttributeByIndex(695);

	public IAttribute Rune_B => SnoData.Attributes.GetAttributeByIndex(696);

	public IAttribute Rune_C => SnoData.Attributes.GetAttributeByIndex(697);

	public IAttribute Rune_D => SnoData.Attributes.GetAttributeByIndex(698);

	public IAttribute Rune_E => SnoData.Attributes.GetAttributeByIndex(699);

	public IAttribute Resistance_Stun => SnoData.Attributes.GetAttributeByIndex(700);

	public IAttribute Resistance_Stun_Total => SnoData.Attributes.GetAttributeByIndex(701);

	public IAttribute Resistance_Root => SnoData.Attributes.GetAttributeByIndex(702);

	public IAttribute Resistance_Root_Total => SnoData.Attributes.GetAttributeByIndex(703);

	public IAttribute Resistance_Freeze => SnoData.Attributes.GetAttributeByIndex(704);

	public IAttribute Resistance_Freeze_Total => SnoData.Attributes.GetAttributeByIndex(705);

	public IAttribute Resistance_StunRootFreeze => SnoData.Attributes.GetAttributeByIndex(706);

	public IAttribute CrowdControl_Reduction => SnoData.Attributes.GetAttributeByIndex(707);

	public IAttribute Displays_Team_Effect => SnoData.Attributes.GetAttributeByIndex(708);

	public IAttribute Cannot_Be_Added_To_AI_Target_List => SnoData.Attributes.GetAttributeByIndex(709);

	public IAttribute SkillKit => SnoData.Attributes.GetAttributeByIndex(710);

	public IAttribute Immune_To_Charm => SnoData.Attributes.GetAttributeByIndex(711);

	public IAttribute Immune_To_Blind => SnoData.Attributes.GetAttributeByIndex(712);

	public IAttribute Damage_Shield => SnoData.Attributes.GetAttributeByIndex(713);

	public IAttribute Damage_Shield_Amount => SnoData.Attributes.GetAttributeByIndex(714);

	public IAttribute Guard_Object_ACDID => SnoData.Attributes.GetAttributeByIndex(715);

	public IAttribute Follow_Target_ACDID => SnoData.Attributes.GetAttributeByIndex(716);

	public IAttribute Follow_Target_Type => SnoData.Attributes.GetAttributeByIndex(717);

	public IAttribute Forced_Enemy_ACDID => SnoData.Attributes.GetAttributeByIndex(718);

	public IAttribute NPC_Talk_Target_ANN => SnoData.Attributes.GetAttributeByIndex(719);

	public IAttribute NPC_Conv_Target_ANN => SnoData.Attributes.GetAttributeByIndex(720);

	public IAttribute Script_Target_ACDID => SnoData.Attributes.GetAttributeByIndex(721);

	public IAttribute Look_Target_Server_ANN => SnoData.Attributes.GetAttributeByIndex(722);

	public IAttribute Look_Target_Broadcast_Intensity => SnoData.Attributes.GetAttributeByIndex(723);

	public IAttribute Look_Target_Broadcast_Radius => SnoData.Attributes.GetAttributeByIndex(724);

	public IAttribute Stealthed => SnoData.Attributes.GetAttributeByIndex(725);

	public IAttribute GemQuality => SnoData.Attributes.GetAttributeByIndex(726);

	public IAttribute Gem_Attributes_Multiplier => SnoData.Attributes.GetAttributeByIndex(727);

	public IAttribute ItemBuffIcon => SnoData.Attributes.GetAttributeByIndex(728);

	public IAttribute ScrollDuration => SnoData.Attributes.GetAttributeByIndex(729);

	public IAttribute Gizmo_Actor_SNO_To_Spawn => SnoData.Attributes.GetAttributeByIndex(730);

	public IAttribute Gizmo_Actor_To_Spawn_Scale => SnoData.Attributes.GetAttributeByIndex(731);

	public IAttribute Death_Replacement_Power_SNO => SnoData.Attributes.GetAttributeByIndex(732);

	public IAttribute Attachment_Handled_By_Client => SnoData.Attributes.GetAttributeByIndex(733);

	public IAttribute AI_In_Special_State => SnoData.Attributes.GetAttributeByIndex(734);

	public IAttribute AI_Used_Scripted_Spawn_Anim => SnoData.Attributes.GetAttributeByIndex(735);

	public IAttribute AI_Spawned_By_Inactive_Marker => SnoData.Attributes.GetAttributeByIndex(736);

	public IAttribute Headstone_Player_ANN => SnoData.Attributes.GetAttributeByIndex(737);

	public IAttribute Resource_Cost_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(738);

	public IAttribute Resource_Cost_Reduction_Percent_Total => SnoData.Attributes.GetAttributeByIndex(739);

	public IAttribute Resource_Cost_Reduction_Percent_All => SnoData.Attributes.GetAttributeByIndex(740);

	public IAttribute Damage_Type_Cost_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(741);

	public IAttribute Resistance_Penetration => SnoData.Attributes.GetAttributeByIndex(742);

	public IAttribute Resistance_Penetration_Total => SnoData.Attributes.GetAttributeByIndex(743);

	public IAttribute Resistance_Penetration_All => SnoData.Attributes.GetAttributeByIndex(744);

	public IAttribute Resistance_Penetration_Percent_All => SnoData.Attributes.GetAttributeByIndex(745);

	public IAttribute Fury_Effect_Level => SnoData.Attributes.GetAttributeByIndex(746);

	public IAttribute Health_Potion_Bonus_Heal_Percent => SnoData.Attributes.GetAttributeByIndex(747);

	public IAttribute Health_Potion_Affects_Allies_Percent => SnoData.Attributes.GetAttributeByIndex(748);

	public IAttribute Free_Cast => SnoData.Attributes.GetAttributeByIndex(749);

	public IAttribute Free_Cast_All => SnoData.Attributes.GetAttributeByIndex(750);

	public IAttribute Health_Cost_Discount => SnoData.Attributes.GetAttributeByIndex(751);

	public IAttribute Health_Cost_Scalar => SnoData.Attributes.GetAttributeByIndex(752);

	public IAttribute Frailty_Health_Threshold => SnoData.Attributes.GetAttributeByIndex(753);

	public IAttribute Frailty_Next_Application_Tick => SnoData.Attributes.GetAttributeByIndex(754);

	public IAttribute Movement_Scalar_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(755);

	public IAttribute Movement_Scalar_Reduction_Resistance => SnoData.Attributes.GetAttributeByIndex(756);

	public IAttribute Damage_Absorb_Percent_All => SnoData.Attributes.GetAttributeByIndex(757);

	public IAttribute World_Seed => SnoData.Attributes.GetAttributeByIndex(758);

	public IAttribute Kill_Count_Record => SnoData.Attributes.GetAttributeByIndex(759);

	public IAttribute Object_Destruction_Record => SnoData.Attributes.GetAttributeByIndex(760);

	public IAttribute Single_Attack_Record => SnoData.Attributes.GetAttributeByIndex(761);

	public IAttribute Environment_Attack_Record => SnoData.Attributes.GetAttributeByIndex(762);

	public IAttribute Nephalem_Glory_Duration_Record => SnoData.Attributes.GetAttributeByIndex(763);

	public IAttribute Root_Immune => SnoData.Attributes.GetAttributeByIndex(764);

	public IAttribute Monster_Play_Get_Hit_Bonus => SnoData.Attributes.GetAttributeByIndex(765);

	public IAttribute Stored_Contact_Frame => SnoData.Attributes.GetAttributeByIndex(766);

	public IAttribute Buff_Icon_Count0 => SnoData.Attributes.GetAttributeByIndex(767);

	public IAttribute Buff_Icon_Count1 => SnoData.Attributes.GetAttributeByIndex(768);

	public IAttribute Buff_Icon_Count2 => SnoData.Attributes.GetAttributeByIndex(769);

	public IAttribute Buff_Icon_Count3 => SnoData.Attributes.GetAttributeByIndex(770);

	public IAttribute Buff_Icon_Count4 => SnoData.Attributes.GetAttributeByIndex(771);

	public IAttribute Buff_Icon_Count5 => SnoData.Attributes.GetAttributeByIndex(772);

	public IAttribute Buff_Icon_Count6 => SnoData.Attributes.GetAttributeByIndex(773);

	public IAttribute Buff_Icon_Count7 => SnoData.Attributes.GetAttributeByIndex(774);

	public IAttribute Buff_Icon_Count8 => SnoData.Attributes.GetAttributeByIndex(775);

	public IAttribute Buff_Icon_Count9 => SnoData.Attributes.GetAttributeByIndex(776);

	public IAttribute Buff_Icon_Count10 => SnoData.Attributes.GetAttributeByIndex(777);

	public IAttribute Buff_Icon_Count11 => SnoData.Attributes.GetAttributeByIndex(778);

	public IAttribute Buff_Icon_Count12 => SnoData.Attributes.GetAttributeByIndex(779);

	public IAttribute Buff_Icon_Count13 => SnoData.Attributes.GetAttributeByIndex(780);

	public IAttribute Buff_Icon_Count14 => SnoData.Attributes.GetAttributeByIndex(781);

	public IAttribute Buff_Icon_Count15 => SnoData.Attributes.GetAttributeByIndex(782);

	public IAttribute Buff_Icon_Count16 => SnoData.Attributes.GetAttributeByIndex(783);

	public IAttribute Buff_Icon_Count17 => SnoData.Attributes.GetAttributeByIndex(784);

	public IAttribute Buff_Icon_Count18 => SnoData.Attributes.GetAttributeByIndex(785);

	public IAttribute Buff_Icon_Count19 => SnoData.Attributes.GetAttributeByIndex(786);

	public IAttribute Buff_Icon_Count20 => SnoData.Attributes.GetAttributeByIndex(787);

	public IAttribute Buff_Icon_Count21 => SnoData.Attributes.GetAttributeByIndex(788);

	public IAttribute Buff_Icon_Count22 => SnoData.Attributes.GetAttributeByIndex(789);

	public IAttribute Buff_Icon_Count23 => SnoData.Attributes.GetAttributeByIndex(790);

	public IAttribute Buff_Icon_Count24 => SnoData.Attributes.GetAttributeByIndex(791);

	public IAttribute Buff_Icon_Count25 => SnoData.Attributes.GetAttributeByIndex(792);

	public IAttribute Buff_Icon_Count26 => SnoData.Attributes.GetAttributeByIndex(793);

	public IAttribute Buff_Icon_Count27 => SnoData.Attributes.GetAttributeByIndex(794);

	public IAttribute Buff_Icon_Count28 => SnoData.Attributes.GetAttributeByIndex(795);

	public IAttribute Buff_Icon_Count29 => SnoData.Attributes.GetAttributeByIndex(796);

	public IAttribute Buff_Icon_Count30 => SnoData.Attributes.GetAttributeByIndex(797);

	public IAttribute Buff_Icon_Count31 => SnoData.Attributes.GetAttributeByIndex(798);

	public IAttribute Observer => SnoData.Attributes.GetAttributeByIndex(799);

	public IAttribute Resurrect_As_Observer => SnoData.Attributes.GetAttributeByIndex(800);

	public IAttribute Combo_Level => SnoData.Attributes.GetAttributeByIndex(801);

	public IAttribute Combo_Time_Last_Move => SnoData.Attributes.GetAttributeByIndex(802);

	public IAttribute Burrowed => SnoData.Attributes.GetAttributeByIndex(803);

	public IAttribute Death_Replacement_Effect_Group_SNO => SnoData.Attributes.GetAttributeByIndex(804);

	public IAttribute Checkpoint_Resurrection_Allowed_Game_Time => SnoData.Attributes.GetAttributeByIndex(805);

	public IAttribute Checkpoint_Resurrection_Forced_Game_Time => SnoData.Attributes.GetAttributeByIndex(806);

	public IAttribute Corpse_Resurrection_Allowed_Game_Time => SnoData.Attributes.GetAttributeByIndex(807);

	public IAttribute Corpse_Resurrection_Charges => SnoData.Attributes.GetAttributeByIndex(808);

	public IAttribute Corpse_Resurrection_Disabled => SnoData.Attributes.GetAttributeByIndex(809);

	public IAttribute Controlling_TimedEvent_SNO => SnoData.Attributes.GetAttributeByIndex(810);

	public IAttribute Casting_Speed_Percent => SnoData.Attributes.GetAttributeByIndex(811);

	public IAttribute Using_Bossbar => SnoData.Attributes.GetAttributeByIndex(812);

	public IAttribute Power_Buff_0_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(813);

	public IAttribute Power_Buff_1_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(814);

	public IAttribute Power_Buff_2_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(815);

	public IAttribute Power_Buff_3_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(816);

	public IAttribute Power_Buff_4_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(817);

	public IAttribute Power_Buff_5_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(818);

	public IAttribute Power_Buff_6_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(819);

	public IAttribute Power_Buff_7_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(820);

	public IAttribute Power_Buff_8_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(821);

	public IAttribute Power_Buff_9_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(822);

	public IAttribute Power_Buff_10_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(823);

	public IAttribute Power_Buff_11_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(824);

	public IAttribute Power_Buff_12_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(825);

	public IAttribute Power_Buff_13_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(826);

	public IAttribute Power_Buff_14_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(827);

	public IAttribute Power_Buff_15_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(828);

	public IAttribute Power_Buff_16_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(829);

	public IAttribute Power_Buff_17_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(830);

	public IAttribute Power_Buff_18_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(831);

	public IAttribute Power_Buff_19_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(832);

	public IAttribute Power_Buff_20_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(833);

	public IAttribute Power_Buff_21_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(834);

	public IAttribute Power_Buff_22_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(835);

	public IAttribute Power_Buff_23_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(836);

	public IAttribute Power_Buff_24_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(837);

	public IAttribute Power_Buff_25_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(838);

	public IAttribute Power_Buff_26_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(839);

	public IAttribute Power_Buff_27_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(840);

	public IAttribute Power_Buff_28_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(841);

	public IAttribute Power_Buff_29_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(842);

	public IAttribute Power_Buff_30_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(843);

	public IAttribute Power_Buff_31_Visual_Effect => SnoData.Attributes.GetAttributeByIndex(844);

	public IAttribute StoreSNO => SnoData.Attributes.GetAttributeByIndex(845);

	public IAttribute Busy => SnoData.Attributes.GetAttributeByIndex(846);

	public IAttribute Afk => SnoData.Attributes.GetAttributeByIndex(847);

	public IAttribute LorePlaying => SnoData.Attributes.GetAttributeByIndex(848);

	public IAttribute LastActionTimestamp => SnoData.Attributes.GetAttributeByIndex(849);

	public IAttribute PortalNextTime => SnoData.Attributes.GetAttributeByIndex(850);

	public IAttribute Repair_Discount_Percent => SnoData.Attributes.GetAttributeByIndex(851);

	public IAttribute Resource_Degeneration_Prevented => SnoData.Attributes.GetAttributeByIndex(852);

	public IAttribute Operatable => SnoData.Attributes.GetAttributeByIndex(853);

	public IAttribute Has_Look_Override => SnoData.Attributes.GetAttributeByIndex(854);

	public IAttribute Spawner_Concurrent_Count_ID => SnoData.Attributes.GetAttributeByIndex(855);

	public IAttribute Disabled => SnoData.Attributes.GetAttributeByIndex(856);

	public IAttribute Skill_Override => SnoData.Attributes.GetAttributeByIndex(857);

	public IAttribute Skill_Override_Active => SnoData.Attributes.GetAttributeByIndex(858);

	public IAttribute Skill_Override_Ended => SnoData.Attributes.GetAttributeByIndex(859);

	public IAttribute Skill_Override_Ended_Active => SnoData.Attributes.GetAttributeByIndex(860);

	public IAttribute Is_Power_Proxy => SnoData.Attributes.GetAttributeByIndex(861);

	public IAttribute Force_No_Death_Animation => SnoData.Attributes.GetAttributeByIndex(862);

	public IAttribute Player_WeaponClass_Anim_Override => SnoData.Attributes.GetAttributeByIndex(863);

	public IAttribute Operatable_Story_Gizmo => SnoData.Attributes.GetAttributeByIndex(864);

	public IAttribute Power_Buff_0_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(865);

	public IAttribute Power_Buff_0_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(866);

	public IAttribute Power_Buff_0_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(867);

	public IAttribute Power_Buff_0_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(868);

	public IAttribute Power_Buff_0_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(869);

	public IAttribute Power_Buff_0_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(870);

	public IAttribute Power_Buff_1_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(871);

	public IAttribute Power_Buff_1_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(872);

	public IAttribute Power_Buff_1_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(873);

	public IAttribute Power_Buff_1_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(874);

	public IAttribute Power_Buff_1_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(875);

	public IAttribute Power_Buff_1_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(876);

	public IAttribute Power_Buff_2_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(877);

	public IAttribute Power_Buff_2_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(878);

	public IAttribute Power_Buff_2_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(879);

	public IAttribute Power_Buff_2_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(880);

	public IAttribute Power_Buff_2_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(881);

	public IAttribute Power_Buff_2_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(882);

	public IAttribute Power_Buff_3_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(883);

	public IAttribute Power_Buff_3_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(884);

	public IAttribute Power_Buff_3_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(885);

	public IAttribute Power_Buff_3_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(886);

	public IAttribute Power_Buff_3_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(887);

	public IAttribute Power_Buff_3_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(888);

	public IAttribute Power_Buff_4_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(889);

	public IAttribute Power_Buff_4_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(890);

	public IAttribute Power_Buff_4_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(891);

	public IAttribute Power_Buff_4_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(892);

	public IAttribute Power_Buff_4_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(893);

	public IAttribute Power_Buff_4_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(894);

	public IAttribute Power_Buff_5_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(895);

	public IAttribute Power_Buff_5_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(896);

	public IAttribute Power_Buff_5_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(897);

	public IAttribute Power_Buff_5_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(898);

	public IAttribute Power_Buff_5_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(899);

	public IAttribute Power_Buff_5_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(900);

	public IAttribute Power_Buff_6_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(901);

	public IAttribute Power_Buff_6_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(902);

	public IAttribute Power_Buff_6_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(903);

	public IAttribute Power_Buff_6_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(904);

	public IAttribute Power_Buff_6_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(905);

	public IAttribute Power_Buff_6_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(906);

	public IAttribute Power_Buff_7_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(907);

	public IAttribute Power_Buff_7_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(908);

	public IAttribute Power_Buff_7_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(909);

	public IAttribute Power_Buff_7_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(910);

	public IAttribute Power_Buff_7_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(911);

	public IAttribute Power_Buff_7_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(912);

	public IAttribute Power_Buff_8_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(913);

	public IAttribute Power_Buff_8_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(914);

	public IAttribute Power_Buff_8_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(915);

	public IAttribute Power_Buff_8_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(916);

	public IAttribute Power_Buff_8_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(917);

	public IAttribute Power_Buff_8_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(918);

	public IAttribute Power_Buff_9_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(919);

	public IAttribute Power_Buff_9_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(920);

	public IAttribute Power_Buff_9_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(921);

	public IAttribute Power_Buff_9_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(922);

	public IAttribute Power_Buff_9_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(923);

	public IAttribute Power_Buff_9_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(924);

	public IAttribute Power_Buff_10_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(925);

	public IAttribute Power_Buff_10_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(926);

	public IAttribute Power_Buff_10_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(927);

	public IAttribute Power_Buff_10_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(928);

	public IAttribute Power_Buff_10_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(929);

	public IAttribute Power_Buff_10_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(930);

	public IAttribute Power_Buff_11_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(931);

	public IAttribute Power_Buff_11_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(932);

	public IAttribute Power_Buff_11_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(933);

	public IAttribute Power_Buff_11_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(934);

	public IAttribute Power_Buff_11_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(935);

	public IAttribute Power_Buff_11_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(936);

	public IAttribute Power_Buff_12_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(937);

	public IAttribute Power_Buff_12_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(938);

	public IAttribute Power_Buff_12_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(939);

	public IAttribute Power_Buff_12_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(940);

	public IAttribute Power_Buff_12_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(941);

	public IAttribute Power_Buff_12_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(942);

	public IAttribute Power_Buff_13_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(943);

	public IAttribute Power_Buff_13_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(944);

	public IAttribute Power_Buff_13_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(945);

	public IAttribute Power_Buff_13_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(946);

	public IAttribute Power_Buff_13_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(947);

	public IAttribute Power_Buff_13_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(948);

	public IAttribute Power_Buff_14_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(949);

	public IAttribute Power_Buff_14_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(950);

	public IAttribute Power_Buff_14_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(951);

	public IAttribute Power_Buff_14_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(952);

	public IAttribute Power_Buff_14_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(953);

	public IAttribute Power_Buff_14_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(954);

	public IAttribute Power_Buff_15_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(955);

	public IAttribute Power_Buff_15_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(956);

	public IAttribute Power_Buff_15_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(957);

	public IAttribute Power_Buff_15_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(958);

	public IAttribute Power_Buff_15_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(959);

	public IAttribute Power_Buff_15_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(960);

	public IAttribute Power_Buff_16_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(961);

	public IAttribute Power_Buff_16_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(962);

	public IAttribute Power_Buff_16_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(963);

	public IAttribute Power_Buff_16_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(964);

	public IAttribute Power_Buff_16_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(965);

	public IAttribute Power_Buff_16_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(966);

	public IAttribute Power_Buff_17_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(967);

	public IAttribute Power_Buff_17_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(968);

	public IAttribute Power_Buff_17_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(969);

	public IAttribute Power_Buff_17_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(970);

	public IAttribute Power_Buff_17_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(971);

	public IAttribute Power_Buff_17_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(972);

	public IAttribute Power_Buff_18_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(973);

	public IAttribute Power_Buff_18_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(974);

	public IAttribute Power_Buff_18_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(975);

	public IAttribute Power_Buff_18_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(976);

	public IAttribute Power_Buff_18_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(977);

	public IAttribute Power_Buff_18_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(978);

	public IAttribute Power_Buff_19_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(979);

	public IAttribute Power_Buff_19_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(980);

	public IAttribute Power_Buff_19_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(981);

	public IAttribute Power_Buff_19_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(982);

	public IAttribute Power_Buff_19_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(983);

	public IAttribute Power_Buff_19_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(984);

	public IAttribute Power_Buff_20_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(985);

	public IAttribute Power_Buff_20_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(986);

	public IAttribute Power_Buff_20_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(987);

	public IAttribute Power_Buff_20_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(988);

	public IAttribute Power_Buff_20_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(989);

	public IAttribute Power_Buff_20_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(990);

	public IAttribute Power_Buff_21_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(991);

	public IAttribute Power_Buff_21_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(992);

	public IAttribute Power_Buff_21_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(993);

	public IAttribute Power_Buff_21_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(994);

	public IAttribute Power_Buff_21_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(995);

	public IAttribute Power_Buff_21_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(996);

	public IAttribute Power_Buff_22_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(997);

	public IAttribute Power_Buff_22_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(998);

	public IAttribute Power_Buff_22_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(999);

	public IAttribute Power_Buff_22_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1000);

	public IAttribute Power_Buff_22_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1001);

	public IAttribute Power_Buff_22_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1002);

	public IAttribute Power_Buff_23_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1003);

	public IAttribute Power_Buff_23_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1004);

	public IAttribute Power_Buff_23_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1005);

	public IAttribute Power_Buff_23_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1006);

	public IAttribute Power_Buff_23_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1007);

	public IAttribute Power_Buff_23_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1008);

	public IAttribute Power_Buff_24_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1009);

	public IAttribute Power_Buff_24_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1010);

	public IAttribute Power_Buff_24_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1011);

	public IAttribute Power_Buff_24_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1012);

	public IAttribute Power_Buff_24_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1013);

	public IAttribute Power_Buff_24_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1014);

	public IAttribute Power_Buff_25_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1015);

	public IAttribute Power_Buff_25_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1016);

	public IAttribute Power_Buff_25_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1017);

	public IAttribute Power_Buff_25_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1018);

	public IAttribute Power_Buff_25_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1019);

	public IAttribute Power_Buff_25_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1020);

	public IAttribute Power_Buff_26_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1021);

	public IAttribute Power_Buff_26_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1022);

	public IAttribute Power_Buff_26_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1023);

	public IAttribute Power_Buff_26_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1024);

	public IAttribute Power_Buff_26_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1025);

	public IAttribute Power_Buff_26_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1026);

	public IAttribute Power_Buff_27_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1027);

	public IAttribute Power_Buff_27_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1028);

	public IAttribute Power_Buff_27_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1029);

	public IAttribute Power_Buff_27_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1030);

	public IAttribute Power_Buff_27_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1031);

	public IAttribute Power_Buff_27_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1032);

	public IAttribute Power_Buff_28_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1033);

	public IAttribute Power_Buff_28_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1034);

	public IAttribute Power_Buff_28_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1035);

	public IAttribute Power_Buff_28_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1036);

	public IAttribute Power_Buff_28_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1037);

	public IAttribute Power_Buff_28_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1038);

	public IAttribute Power_Buff_29_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1039);

	public IAttribute Power_Buff_29_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1040);

	public IAttribute Power_Buff_29_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1041);

	public IAttribute Power_Buff_29_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1042);

	public IAttribute Power_Buff_29_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1043);

	public IAttribute Power_Buff_29_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1044);

	public IAttribute Power_Buff_30_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1045);

	public IAttribute Power_Buff_30_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1046);

	public IAttribute Power_Buff_30_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1047);

	public IAttribute Power_Buff_30_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1048);

	public IAttribute Power_Buff_30_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1049);

	public IAttribute Power_Buff_30_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1050);

	public IAttribute Power_Buff_31_Visual_Effect_None => SnoData.Attributes.GetAttributeByIndex(1051);

	public IAttribute Power_Buff_31_Visual_Effect_A => SnoData.Attributes.GetAttributeByIndex(1052);

	public IAttribute Power_Buff_31_Visual_Effect_B => SnoData.Attributes.GetAttributeByIndex(1053);

	public IAttribute Power_Buff_31_Visual_Effect_C => SnoData.Attributes.GetAttributeByIndex(1054);

	public IAttribute Power_Buff_31_Visual_Effect_D => SnoData.Attributes.GetAttributeByIndex(1055);

	public IAttribute Power_Buff_31_Visual_Effect_E => SnoData.Attributes.GetAttributeByIndex(1056);

	public IAttribute Walk_Passability_Power_SNO => SnoData.Attributes.GetAttributeByIndex(1057);

	public IAttribute Passability_Power_SNO => SnoData.Attributes.GetAttributeByIndex(1058);

	public IAttribute Flippy_ID => SnoData.Attributes.GetAttributeByIndex(1059);

	public IAttribute Summoning_Machine_Num_Casters => SnoData.Attributes.GetAttributeByIndex(1060);

	public IAttribute Summoning_Machine_Spawn_Count => SnoData.Attributes.GetAttributeByIndex(1061);

	public IAttribute Summoning_Machine_Next_Spawn_Ticks => SnoData.Attributes.GetAttributeByIndex(1062);

	public IAttribute Summoning_Machine_Spawn_Team => SnoData.Attributes.GetAttributeByIndex(1063);

	public IAttribute Screen_Attack_Radius_Constant => SnoData.Attributes.GetAttributeByIndex(1064);

	public IAttribute MaxDamage_Done_Reduction_Percent1 => SnoData.Attributes.GetAttributeByIndex(1065);

	public IAttribute Set_Item_Count => SnoData.Attributes.GetAttributeByIndex(1066);

	public IAttribute Set_Bonus_Count => SnoData.Attributes.GetAttributeByIndex(1067);

	public IAttribute Spawner_Countdown_Percent => SnoData.Attributes.GetAttributeByIndex(1068);

	public IAttribute Attack_Slow => SnoData.Attributes.GetAttributeByIndex(1069);

	public IAttribute Power_Disabled => SnoData.Attributes.GetAttributeByIndex(1070);

	public IAttribute Weapon_Effect_Override => SnoData.Attributes.GetAttributeByIndex(1071);

	public IAttribute Debuff_Duration_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(1072);

	public IAttribute Uses_PvP_Power_Tags => SnoData.Attributes.GetAttributeByIndex(1073);

	public IAttribute Trait => SnoData.Attributes.GetAttributeByIndex(1074);

	public IAttribute Last_ACD_Attacked_By => SnoData.Attributes.GetAttributeByIndex(1075);

	public IAttribute Gold_PickUp_Radius => SnoData.Attributes.GetAttributeByIndex(1076);

	public IAttribute ClientOnlyEffect => SnoData.Attributes.GetAttributeByIndex(1077);

	public IAttribute Power_Saved_Attribute => SnoData.Attributes.GetAttributeByIndex(1078);

	public IAttribute Resource_Gain_Bonus_Percent => SnoData.Attributes.GetAttributeByIndex(1079);

	public IAttribute Looping_Animation_Start_Time => SnoData.Attributes.GetAttributeByIndex(1080);

	public IAttribute Looping_Animation_End_Time => SnoData.Attributes.GetAttributeByIndex(1081);

	public IAttribute Looping_Animation_Suppress_Item_Tooltips => SnoData.Attributes.GetAttributeByIndex(1082);

	public IAttribute Heal_Effect_Last_Played_Tick => SnoData.Attributes.GetAttributeByIndex(1083);

	public IAttribute Resource_Effect_Last_Played_tick => SnoData.Attributes.GetAttributeByIndex(1084);

	public IAttribute Thorns_Effect_Last_Played_tick => SnoData.Attributes.GetAttributeByIndex(1085);

	public IAttribute PVP_Kills => SnoData.Attributes.GetAttributeByIndex(1086);

	public IAttribute PVP_Deaths => SnoData.Attributes.GetAttributeByIndex(1087);

	public IAttribute PVP_Assists => SnoData.Attributes.GetAttributeByIndex(1088);

	public IAttribute PVP_Progression_Points_Gained => SnoData.Attributes.GetAttributeByIndex(1089);

	public IAttribute PVP_Current_Kill_Streak => SnoData.Attributes.GetAttributeByIndex(1090);

	public IAttribute PVP_Current_Death_Streak => SnoData.Attributes.GetAttributeByIndex(1091);

	public IAttribute PVP_Longest_Kill_Streak => SnoData.Attributes.GetAttributeByIndex(1092);

	public IAttribute PVP_Longest_Death_Streak => SnoData.Attributes.GetAttributeByIndex(1093);

	public IAttribute Turn_Rate_Scalar => SnoData.Attributes.GetAttributeByIndex(1094);

	public IAttribute Turn_Accel_Scalar => SnoData.Attributes.GetAttributeByIndex(1095);

	public IAttribute Turn_Deccel_Scalar => SnoData.Attributes.GetAttributeByIndex(1096);

	public IAttribute No_Health_Drop => SnoData.Attributes.GetAttributeByIndex(1097);

	public IAttribute Leader => SnoData.Attributes.GetAttributeByIndex(1098);

	public IAttribute IsContentRestrictedActor => SnoData.Attributes.GetAttributeByIndex(1099);

	public IAttribute InBossEncounter => SnoData.Attributes.GetAttributeByIndex(1100);

	public IAttribute God => SnoData.Attributes.GetAttributeByIndex(1101);

	public IAttribute AllowSkillChanges => SnoData.Attributes.GetAttributeByIndex(1102);

	public IAttribute MinimapActive => SnoData.Attributes.GetAttributeByIndex(1103);

	public IAttribute MinimapIconOverride => SnoData.Attributes.GetAttributeByIndex(1104);

	public IAttribute MinimapDisableArrow => SnoData.Attributes.GetAttributeByIndex(1105);

	public IAttribute Last_Blocked_ACD => SnoData.Attributes.GetAttributeByIndex(1106);

	public IAttribute Last_Blocked_Time => SnoData.Attributes.GetAttributeByIndex(1107);

	public IAttribute DeactivateLure => SnoData.Attributes.GetAttributeByIndex(1108);

	public IAttribute Weapons_Hidden => SnoData.Attributes.GetAttributeByIndex(1109);

	public IAttribute Main_Hand_Weapon_Hidden => SnoData.Attributes.GetAttributeByIndex(1110);

	public IAttribute Off_Hand_Weapon_Hidden => SnoData.Attributes.GetAttributeByIndex(1111);

	public IAttribute Actor_Updates_Attributes_From_Owner => SnoData.Attributes.GetAttributeByIndex(1112);

	public IAttribute Taunt_Target_ACD => SnoData.Attributes.GetAttributeByIndex(1113);

	public IAttribute Charm_Source_ACD => SnoData.Attributes.GetAttributeByIndex(1114);

	public IAttribute UI_Only_Percent_Damage_Increase => SnoData.Attributes.GetAttributeByIndex(1115);

	public IAttribute Projectile_Effect_SNO => SnoData.Attributes.GetAttributeByIndex(1116);

	public IAttribute On_Hit_Fear_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1117);

	public IAttribute On_Hit_Stun_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1118);

	public IAttribute On_Hit_Blind_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1119);

	public IAttribute On_Hit_Freeze_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1120);

	public IAttribute On_Hit_Chill_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1121);

	public IAttribute On_Hit_Slow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1122);

	public IAttribute On_Hit_Immobilize_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1123);

	public IAttribute On_Hit_Knockback_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1124);

	public IAttribute On_Hit_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1125);

	public IAttribute On_Hit_Bleed_Proc_Damage_Base => SnoData.Attributes.GetAttributeByIndex(1126);

	public IAttribute On_Hit_Bleed_Proc_Damage_Delta => SnoData.Attributes.GetAttributeByIndex(1127);

	public IAttribute Damage_Percent_Reduction_From_Ranged => SnoData.Attributes.GetAttributeByIndex(1128);

	public IAttribute Damage_Percent_Reduction_From_Melee => SnoData.Attributes.GetAttributeByIndex(1129);

	public IAttribute Damage_Percent_Reduction_Turns_Into_Heal => SnoData.Attributes.GetAttributeByIndex(1130);

	public IAttribute Damage_Percent_Reduction_From_Elites => SnoData.Attributes.GetAttributeByIndex(1131);

	public IAttribute Damage_Percent_Reduction_From_Type => SnoData.Attributes.GetAttributeByIndex(1132);

	public IAttribute Damage_Percent_Bonus_Vs_Monster_Type => SnoData.Attributes.GetAttributeByIndex(1133);

	public IAttribute Damage_Percent_Bonus_Vs_Elites => SnoData.Attributes.GetAttributeByIndex(1134);

	public IAttribute Item_Manipulation_Timeout => SnoData.Attributes.GetAttributeByIndex(1135);

	public IAttribute Picked_Up_Time => SnoData.Attributes.GetAttributeByIndex(1136);

	public IAttribute UnequippedTime => SnoData.Attributes.GetAttributeByIndex(1137);

	public IAttribute Last_ACD_Killed_Time => SnoData.Attributes.GetAttributeByIndex(1138);

	public IAttribute CannotDieDuring => SnoData.Attributes.GetAttributeByIndex(1139);

	public IAttribute Weapon_On_Hit_Fear_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1140);

	public IAttribute Weapon_On_Hit_Stun_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1141);

	public IAttribute Weapon_On_Hit_Blind_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1142);

	public IAttribute Weapon_On_Hit_Freeze_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1143);

	public IAttribute Weapon_On_Hit_Chill_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1144);

	public IAttribute Weapon_On_Hit_Slow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1145);

	public IAttribute Weapon_On_Hit_Immobilize_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1146);

	public IAttribute Weapon_On_Hit_Knockback_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1147);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1148);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base => SnoData.Attributes.GetAttributeByIndex(1149);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta => SnoData.Attributes.GetAttributeByIndex(1150);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1151);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage => SnoData.Attributes.GetAttributeByIndex(1152);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration => SnoData.Attributes.GetAttributeByIndex(1153);

	public IAttribute Weapon_On_Hit_Fear_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1154);

	public IAttribute Weapon_On_Hit_Fear_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1155);

	public IAttribute Weapon_On_Hit_Fear_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1156);

	public IAttribute Weapon_On_Hit_Stun_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1157);

	public IAttribute Weapon_On_Hit_Stun_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1158);

	public IAttribute Weapon_On_Hit_Stun_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1159);

	public IAttribute Weapon_On_Hit_Blind_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1160);

	public IAttribute Weapon_On_Hit_Blind_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1161);

	public IAttribute Weapon_On_Hit_Blind_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1162);

	public IAttribute Weapon_On_Hit_Freeze_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1163);

	public IAttribute Weapon_On_Hit_Freeze_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1164);

	public IAttribute Weapon_On_Hit_Freeze_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1165);

	public IAttribute Weapon_On_Hit_Chill_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1166);

	public IAttribute Weapon_On_Hit_Chill_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1167);

	public IAttribute Weapon_On_Hit_Chill_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1168);

	public IAttribute Weapon_On_Hit_Slow_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1169);

	public IAttribute Weapon_On_Hit_Slow_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1170);

	public IAttribute Weapon_On_Hit_Slow_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1171);

	public IAttribute Weapon_On_Hit_Immobilize_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1172);

	public IAttribute Weapon_On_Hit_Immobilize_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1173);

	public IAttribute Weapon_On_Hit_Immobilize_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1174);

	public IAttribute Weapon_On_Hit_Knockback_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1175);

	public IAttribute Weapon_On_Hit_Knockback_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1176);

	public IAttribute Weapon_On_Hit_Knockback_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1177);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1178);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1179);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1180);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_MainHand => SnoData.Attributes.GetAttributeByIndex(1181);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_OffHand => SnoData.Attributes.GetAttributeByIndex(1182);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Base_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1183);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_MainHand => SnoData.Attributes.GetAttributeByIndex(1184);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_OffHand => SnoData.Attributes.GetAttributeByIndex(1185);

	public IAttribute Weapon_On_Hit_Bleed_Proc_Damage_Delta_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1186);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1187);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1188);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1189);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_MainHand => SnoData.Attributes.GetAttributeByIndex(1190);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_Base_OffHand => SnoData.Attributes.GetAttributeByIndex(1191);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Damage_Base_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1192);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_MainHand => SnoData.Attributes.GetAttributeByIndex(1193);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_OffHand => SnoData.Attributes.GetAttributeByIndex(1194);

	public IAttribute Weapon_On_Hit_Percent_Bleed_Proc_Duration_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1195);

	public IAttribute Power_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1196);

	public IAttribute Power_Instance_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1197);

	public IAttribute Power_Resource_Reduction => SnoData.Attributes.GetAttributeByIndex(1198);

	public IAttribute Power_Resource_Reduction_Percent => SnoData.Attributes.GetAttributeByIndex(1199);

	public IAttribute Power_Cooldown_Reduction => SnoData.Attributes.GetAttributeByIndex(1200);

	public IAttribute Power_Cooldown_Reduction_All => SnoData.Attributes.GetAttributeByIndex(1201);

	public IAttribute Power_Duration_Increase => SnoData.Attributes.GetAttributeByIndex(1202);

	public IAttribute Power_Crit_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1203);

	public IAttribute Weapon_Crit_Chance => SnoData.Attributes.GetAttributeByIndex(1204);

	public IAttribute Weapon_Crit_Chance_MainHand => SnoData.Attributes.GetAttributeByIndex(1205);

	public IAttribute Weapon_Crit_Chance_OffHand => SnoData.Attributes.GetAttributeByIndex(1206);

	public IAttribute Weapon_Crit_Chance_CurrentHand => SnoData.Attributes.GetAttributeByIndex(1207);

	public IAttribute Strength_Item => SnoData.Attributes.GetAttributeByIndex(1208);

	public IAttribute Dexterity_Item => SnoData.Attributes.GetAttributeByIndex(1209);

	public IAttribute Intelligence_Item => SnoData.Attributes.GetAttributeByIndex(1210);

	public IAttribute Vitality_Item => SnoData.Attributes.GetAttributeByIndex(1211);

	public IAttribute Item_Level_Requirement_Reduction => SnoData.Attributes.GetAttributeByIndex(1212);

	public IAttribute Item_Level_Requirement_Override => SnoData.Attributes.GetAttributeByIndex(1213);

	public IAttribute Item_Durability_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1214);

	public IAttribute Item_Indestructible => SnoData.Attributes.GetAttributeByIndex(1215);

	public IAttribute Player_All_Items_Indestructible => SnoData.Attributes.GetAttributeByIndex(1216);

	public IAttribute Core_Attributes_From_Item_Bonus_Multiplier => SnoData.Attributes.GetAttributeByIndex(1217);

	public IAttribute Waiting_To_Accept_Resurrection => SnoData.Attributes.GetAttributeByIndex(1218);

	public IAttribute Ghosted => SnoData.Attributes.GetAttributeByIndex(1219);

	public IAttribute Special_Inventory_Has_Sold => SnoData.Attributes.GetAttributeByIndex(1220);

	public IAttribute Special_Inventory_Index => SnoData.Attributes.GetAttributeByIndex(1221);

	public IAttribute Inventory_Reroll_Time => SnoData.Attributes.GetAttributeByIndex(1222);

	public IAttribute Perk_Buff_Poll_Next_Time => SnoData.Attributes.GetAttributeByIndex(1223);

	public IAttribute Limited_Duration_Item_Poll_Next_Time => SnoData.Attributes.GetAttributeByIndex(1224);

	public IAttribute Power_Channel_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1225);

	public IAttribute Power_Buff_0_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1226);

	public IAttribute Power_Buff_1_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1227);

	public IAttribute Power_Buff_2_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1228);

	public IAttribute Power_Buff_3_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1229);

	public IAttribute Power_Buff_4_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1230);

	public IAttribute Power_Buff_5_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1231);

	public IAttribute Power_Buff_6_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1232);

	public IAttribute Power_Buff_7_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1233);

	public IAttribute Power_Buff_8_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1234);

	public IAttribute Power_Buff_9_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1235);

	public IAttribute Power_Buff_10_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1236);

	public IAttribute Power_Buff_11_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1237);

	public IAttribute Power_Buff_12_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1238);

	public IAttribute Power_Buff_13_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1239);

	public IAttribute Power_Buff_14_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1240);

	public IAttribute Power_Buff_15_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1241);

	public IAttribute Power_Buff_16_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1242);

	public IAttribute Power_Buff_17_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1243);

	public IAttribute Power_Buff_18_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1244);

	public IAttribute Power_Buff_19_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1245);

	public IAttribute Power_Buff_20_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1246);

	public IAttribute Power_Buff_21_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1247);

	public IAttribute Power_Buff_22_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1248);

	public IAttribute Power_Buff_23_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1249);

	public IAttribute Power_Buff_24_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1250);

	public IAttribute Power_Buff_25_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1251);

	public IAttribute Power_Buff_26_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1252);

	public IAttribute Power_Buff_27_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1253);

	public IAttribute Power_Buff_28_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1254);

	public IAttribute Power_Buff_29_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1255);

	public IAttribute Power_Buff_30_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1256);

	public IAttribute Power_Buff_31_Lockout_Time => SnoData.Attributes.GetAttributeByIndex(1257);

	public IAttribute Known_By_Owner => SnoData.Attributes.GetAttributeByIndex(1258);

	public IAttribute Never_Deactivates => SnoData.Attributes.GetAttributeByIndex(1259);

	public IAttribute Account_Under_Review => SnoData.Attributes.GetAttributeByIndex(1260);

	public IAttribute Projectile_Detonate_Time => SnoData.Attributes.GetAttributeByIndex(1261);

	public IAttribute Projectile_Uncapped_Lifetime => SnoData.Attributes.GetAttributeByIndex(1262);

	public IAttribute PageOfFate_Item => SnoData.Attributes.GetAttributeByIndex(1263);

	public IAttribute Accolade_0 => SnoData.Attributes.GetAttributeByIndex(1264);

	public IAttribute Accolade_1 => SnoData.Attributes.GetAttributeByIndex(1265);

	public IAttribute Accolade_2 => SnoData.Attributes.GetAttributeByIndex(1266);

	public IAttribute Accolade_3 => SnoData.Attributes.GetAttributeByIndex(1267);

	public IAttribute Accolade_4 => SnoData.Attributes.GetAttributeByIndex(1268);

	public IAttribute Accolade_0_Value => SnoData.Attributes.GetAttributeByIndex(1269);

	public IAttribute Accolade_1_Value => SnoData.Attributes.GetAttributeByIndex(1270);

	public IAttribute Accolade_2_Value => SnoData.Attributes.GetAttributeByIndex(1271);

	public IAttribute Accolade_3_Value => SnoData.Attributes.GetAttributeByIndex(1272);

	public IAttribute Accolade_4_Value => SnoData.Attributes.GetAttributeByIndex(1273);

	public IAttribute PVP_Rank => SnoData.Attributes.GetAttributeByIndex(1274);

	public IAttribute PVP_Tokens => SnoData.Attributes.GetAttributeByIndex(1275);

	public IAttribute PVP_Experience_Next_Lo => SnoData.Attributes.GetAttributeByIndex(1276);

	public IAttribute PVP_Experience_Next_Hi => SnoData.Attributes.GetAttributeByIndex(1277);

	public IAttribute PVP_Gold_Gained_This_Game => SnoData.Attributes.GetAttributeByIndex(1278);

	public IAttribute PVP_PVP_Experience_Gained_This_Game_Lo => SnoData.Attributes.GetAttributeByIndex(1279);

	public IAttribute PVP_PVP_Experience_Gained_This_Game_Hi => SnoData.Attributes.GetAttributeByIndex(1280);

	public IAttribute PVP_Normal_Experience_Gained_This_Game_Lo => SnoData.Attributes.GetAttributeByIndex(1281);

	public IAttribute PVP_Normal_Experience_Gained_This_Game_Hi => SnoData.Attributes.GetAttributeByIndex(1282);

	public IAttribute PVP_Tokens_Gained_This_Game => SnoData.Attributes.GetAttributeByIndex(1283);

	public IAttribute PVP_Level_Equalizer_Level => SnoData.Attributes.GetAttributeByIndex(1284);

	public IAttribute Is_Temporary_Lure => SnoData.Attributes.GetAttributeByIndex(1285);

	public IAttribute Ignore_Lure => SnoData.Attributes.GetAttributeByIndex(1286);

	public IAttribute Effect_Owner_ANN => SnoData.Attributes.GetAttributeByIndex(1287);

	public IAttribute Elite_Engaged => SnoData.Attributes.GetAttributeByIndex(1288);

	public IAttribute Engaged_Rare_Time => SnoData.Attributes.GetAttributeByIndex(1289);

	public IAttribute Engaged_Goblin_Time => SnoData.Attributes.GetAttributeByIndex(1290);

	public IAttribute On_Death_Accolade_0 => SnoData.Attributes.GetAttributeByIndex(1291);

	public IAttribute On_Death_Accolade_0_Value => SnoData.Attributes.GetAttributeByIndex(1292);

	public IAttribute Item_Power_Passive => SnoData.Attributes.GetAttributeByIndex(1293);

	public IAttribute PVP_TeamDeathmatch_Games_Played => SnoData.Attributes.GetAttributeByIndex(1294);

	public IAttribute Last_Health_Drop_Interval => SnoData.Attributes.GetAttributeByIndex(1295);

	public IAttribute CrowdControl_Resistance => SnoData.Attributes.GetAttributeByIndex(1296);

	public IAttribute CrowdControl_Projected_End_Time => SnoData.Attributes.GetAttributeByIndex(1297);

	public IAttribute Last_Continuous_Knockback_Power_ID => SnoData.Attributes.GetAttributeByIndex(1298);

	public IAttribute Charmed => SnoData.Attributes.GetAttributeByIndex(1299);

	public IAttribute Taunted => SnoData.Attributes.GetAttributeByIndex(1300);

	public IAttribute Dueling => SnoData.Attributes.GetAttributeByIndex(1301);

	public IAttribute PVP_Player_Revealed_On_Map => SnoData.Attributes.GetAttributeByIndex(1302);

	public IAttribute Targeted_Legendary_Chance => SnoData.Attributes.GetAttributeByIndex(1303);

	public IAttribute Seasonal_Legendary_Chance => SnoData.Attributes.GetAttributeByIndex(1304);

	public IAttribute Received_Seasonal_Legendary => SnoData.Attributes.GetAttributeByIndex(1305);

	public IAttribute Has_Dropped_Special_loot => SnoData.Attributes.GetAttributeByIndex(1306);

	public IAttribute Scroll_Buff => SnoData.Attributes.GetAttributeByIndex(1307);

	public IAttribute Buff_Exclusive_Type_Active => SnoData.Attributes.GetAttributeByIndex(1308);

	public IAttribute In_Combat_With_Player => SnoData.Attributes.GetAttributeByIndex(1309);

	public IAttribute Actor_Forwards_Buffs => SnoData.Attributes.GetAttributeByIndex(1310);

	public IAttribute Item_Marked_As_Junk => SnoData.Attributes.GetAttributeByIndex(1311);

	public IAttribute Allow_2H_And_Shield => SnoData.Attributes.GetAttributeByIndex(1312);

	public IAttribute Class_Damage_Reduction_Percent_PVP => SnoData.Attributes.GetAttributeByIndex(1313);

	public IAttribute Paragon_Bonus => SnoData.Attributes.GetAttributeByIndex(1314);

	public IAttribute Paragon_Bonus_Points_Available => SnoData.Attributes.GetAttributeByIndex(1315);

	public IAttribute Dungeon_Finder_Progress_Percent => SnoData.Attributes.GetAttributeByIndex(1316);

	public IAttribute Item_Trade_Player_High => SnoData.Attributes.GetAttributeByIndex(1317);

	public IAttribute Item_Trade_Player_Low => SnoData.Attributes.GetAttributeByIndex(1318);

	public IAttribute Item_Trade_End_Time => SnoData.Attributes.GetAttributeByIndex(1319);

	public IAttribute Item_Trade_Timer_ID => SnoData.Attributes.GetAttributeByIndex(1320);

	public IAttribute Item_Is_BOE => SnoData.Attributes.GetAttributeByIndex(1321);

	public IAttribute Season => SnoData.Attributes.GetAttributeByIndex(1322);

	public IAttribute DamageDoneTotalTrackedHi => SnoData.Attributes.GetAttributeByIndex(1323);

	public IAttribute DamageDoneTotalTrackedLo => SnoData.Attributes.GetAttributeByIndex(1324);

	public IAttribute DamageDoneTrackingStartTick => SnoData.Attributes.GetAttributeByIndex(1325);

	public IAttribute PowerPersistsAcrossGames => SnoData.Attributes.GetAttributeByIndex(1326);

	public IAttribute Experience_Bonus_Percent_IGR_Buff => SnoData.Attributes.GetAttributeByIndex(1327);

	public IAttribute Experience_Bonus_Percent_Anniversary_Buff => SnoData.Attributes.GetAttributeByIndex(1328);

	public IAttribute Experience_Bonus_Percent_Community_Buff => SnoData.Attributes.GetAttributeByIndex(1329);

	public IAttribute Experience_Bonus_Percent_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(1330);

	public IAttribute Experience_Bonus_Percent_Super_Scalar => SnoData.Attributes.GetAttributeByIndex(1331);

	public IAttribute Experience_Bonus_Percent_Super_Scalar_Total => SnoData.Attributes.GetAttributeByIndex(1332);

	public IAttribute AlwaysShowFloatingNumbers => SnoData.Attributes.GetAttributeByIndex(1333);

	public IAttribute Targeted_Rare_Chance => SnoData.Attributes.GetAttributeByIndex(1334);

	public IAttribute Supress_Thorns_Effect => SnoData.Attributes.GetAttributeByIndex(1335);

	public IAttribute Dynamic_Entrance_GUID => SnoData.Attributes.GetAttributeByIndex(1336);

	public IAttribute Bonus_Chance_To_Be_Crit_Hit => SnoData.Attributes.GetAttributeByIndex(1337);

	public IAttribute Bonus_Chance_To_Be_Crit_Hit_By_Actor => SnoData.Attributes.GetAttributeByIndex(1338);

	public IAttribute Bonus_Chance_To_Receive_Crushing_Blown => SnoData.Attributes.GetAttributeByIndex(1339);

	public IAttribute Force_Gripped => SnoData.Attributes.GetAttributeByIndex(1340);

	public IAttribute PowerBonusAttackRadius => SnoData.Attributes.GetAttributeByIndex(1341);

	public IAttribute Item_Store_Player_High => SnoData.Attributes.GetAttributeByIndex(1342);

	public IAttribute Item_Store_Player_Low => SnoData.Attributes.GetAttributeByIndex(1343);

	public IAttribute Power_Primary_Resource_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1344);

	public IAttribute Power_Secondary_Resource_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1345);

	public IAttribute Power_Channel_Cost_Override => SnoData.Attributes.GetAttributeByIndex(1346);

	public IAttribute Rune_A_Override => SnoData.Attributes.GetAttributeByIndex(1347);

	public IAttribute Rune_B_Override => SnoData.Attributes.GetAttributeByIndex(1348);

	public IAttribute Rune_C_Override => SnoData.Attributes.GetAttributeByIndex(1349);

	public IAttribute Rune_D_Override => SnoData.Attributes.GetAttributeByIndex(1350);

	public IAttribute Rune_E_Override => SnoData.Attributes.GetAttributeByIndex(1351);

	public IAttribute Elemental_Effect_Amplitude_Bonus => SnoData.Attributes.GetAttributeByIndex(1352);

	public IAttribute Elemental_Effect_Duration_Bonus => SnoData.Attributes.GetAttributeByIndex(1353);

	public IAttribute Elemental_Effect_Proc_Chance_Bonus => SnoData.Attributes.GetAttributeByIndex(1354);

	public IAttribute Splash_Damage_Effect_Percent => SnoData.Attributes.GetAttributeByIndex(1355);

	public IAttribute Crushing_Blow_Proc_Chance => SnoData.Attributes.GetAttributeByIndex(1356);

	public IAttribute Item_Equipped_But_Disabled => SnoData.Attributes.GetAttributeByIndex(1357);

	public IAttribute Item_Equipped_But_Disabled_Duplicate_Legendary => SnoData.Attributes.GetAttributeByIndex(1358);

	public IAttribute Attribute_Projectile_Pass_Through => SnoData.Attributes.GetAttributeByIndex(1359);

	public IAttribute Attribute_Set_Item_Discount => SnoData.Attributes.GetAttributeByIndex(1360);

	public IAttribute Negative_Health_Globe_Spawn_Chance => SnoData.Attributes.GetAttributeByIndex(1361);

	public IAttribute Override_Attached_Anim => SnoData.Attributes.GetAttributeByIndex(1362);

	public IAttribute Has_Infinite_Shrine_Buffs => SnoData.Attributes.GetAttributeByIndex(1363);

	public IAttribute Item_Legendary_Item_Base_Item => SnoData.Attributes.GetAttributeByIndex(1364);

	public IAttribute Targeted_Magic_Chance => SnoData.Attributes.GetAttributeByIndex(1365);

	public IAttribute Dont_Update_Camera_While_Attached => SnoData.Attributes.GetAttributeByIndex(1366);

	public IAttribute LinkedDynamicEntranceGUID => SnoData.Attributes.GetAttributeByIndex(1367);

	public IAttribute Boost_TC_Index => SnoData.Attributes.GetAttributeByIndex(1368);

	public IAttribute Boost_TC_NextTime => SnoData.Attributes.GetAttributeByIndex(1369);

	public IAttribute Potion_Bonus_Armor_Percent => SnoData.Attributes.GetAttributeByIndex(1370);

	public IAttribute Potion_Bonus_Resist_All => SnoData.Attributes.GetAttributeByIndex(1371);

	public IAttribute Potion_Bonus_Hitpoints_Granted => SnoData.Attributes.GetAttributeByIndex(1372);

	public IAttribute Potion_Bonus_Buff_Duration => SnoData.Attributes.GetAttributeByIndex(1373);

	public IAttribute Potion_Bonus_Life_On_Hit => SnoData.Attributes.GetAttributeByIndex(1374);

	public IAttribute Potion_Bonus_Life_On_Kill => SnoData.Attributes.GetAttributeByIndex(1375);

	public IAttribute Last_Special_Item_Time_High => SnoData.Attributes.GetAttributeByIndex(1376);

	public IAttribute Last_Special_Item_Time_Low => SnoData.Attributes.GetAttributeByIndex(1377);

	public IAttribute Item_Rest_Bonus_Pool => SnoData.Attributes.GetAttributeByIndex(1378);

	public IAttribute Item_Unlucky_Bonus_Secs => SnoData.Attributes.GetAttributeByIndex(1379);

	public IAttribute Item_Unlucky_Bonus_Allow => SnoData.Attributes.GetAttributeByIndex(1380);

	public IAttribute Avenger_Buildup_Secs => SnoData.Attributes.GetAttributeByIndex(1381);

	public IAttribute Bounty_Objective => SnoData.Attributes.GetAttributeByIndex(1382);

	public IAttribute Illusion => SnoData.Attributes.GetAttributeByIndex(1383);

	public IAttribute TornadoStraighten => SnoData.Attributes.GetAttributeByIndex(1384);

	public IAttribute Prevent_Evade_During => SnoData.Attributes.GetAttributeByIndex(1385);

	public IAttribute Damage_Bonus_From_Nephalem_Glory => SnoData.Attributes.GetAttributeByIndex(1386);

	public IAttribute Item_Player_Recipient => SnoData.Attributes.GetAttributeByIndex(1387);

	public IAttribute Heavens_Fury_Attacker => SnoData.Attributes.GetAttributeByIndex(1388);

	public IAttribute Item_Assigned_Hero_High => SnoData.Attributes.GetAttributeByIndex(1389);

	public IAttribute Item_Assigned_Hero_Low => SnoData.Attributes.GetAttributeByIndex(1390);

	public IAttribute Pierce_Charge => SnoData.Attributes.GetAttributeByIndex(1391);

	public IAttribute Upscaled_Level => SnoData.Attributes.GetAttributeByIndex(1392);

	public IAttribute Resurrected => SnoData.Attributes.GetAttributeByIndex(1393);

	public IAttribute Damage_SidekickMultiplier => SnoData.Attributes.GetAttributeByIndex(1394);

	public IAttribute Thorns_AOE_Radius_Next_Time => SnoData.Attributes.GetAttributeByIndex(1395);

	public IAttribute Movement_Destroys_Waller_Walls => SnoData.Attributes.GetAttributeByIndex(1396);

	public IAttribute Mail_Flag_Icon => SnoData.Attributes.GetAttributeByIndex(1397);

	public IAttribute Tiered_Loot_Run_Key_Level => SnoData.Attributes.GetAttributeByIndex(1398);

	public IAttribute In_Tiered_Loot_Run_Level => SnoData.Attributes.GetAttributeByIndex(1399);

	public IAttribute Is_Loot_Run_Boss => SnoData.Attributes.GetAttributeByIndex(1400);

	public IAttribute ForcedMove => SnoData.Attributes.GetAttributeByIndex(1401);

	public IAttribute Effective_Level => SnoData.Attributes.GetAttributeByIndex(1402);

	public IAttribute Jewel_Rank => SnoData.Attributes.GetAttributeByIndex(1403);

	public IAttribute Item_Console_Max_Level => SnoData.Attributes.GetAttributeByIndex(1404);

	public IAttribute Console_Promo_Item => SnoData.Attributes.GetAttributeByIndex(1405);

	public IAttribute Double_BloodShards => SnoData.Attributes.GetAttributeByIndex(1406);

	public IAttribute Double_BountyBags => SnoData.Attributes.GetAttributeByIndex(1407);

	public IAttribute Jewel_Upgrades_Used => SnoData.Attributes.GetAttributeByIndex(1408);

	public IAttribute Jewel_Upgrades_Max => SnoData.Attributes.GetAttributeByIndex(1409);

	public IAttribute Jewel_Upgrades_Bonus => SnoData.Attributes.GetAttributeByIndex(1410);

	public IAttribute Item_Ignores_Pickup_Radius_For_Pickup => SnoData.Attributes.GetAttributeByIndex(1411);

	public IAttribute Hunter => SnoData.Attributes.GetAttributeByIndex(1412);

	public IAttribute Participating_In_Tiered_Loot_Run => SnoData.Attributes.GetAttributeByIndex(1413);

	public IAttribute Tiered_Loot_Run_Reward_Choice_State => SnoData.Attributes.GetAttributeByIndex(1414);

	public IAttribute Tiered_Loot_Run_Reward_Receives_Key => SnoData.Attributes.GetAttributeByIndex(1415);

	public IAttribute CurrentCosmeticEffect => SnoData.Attributes.GetAttributeByIndex(1416);

	public IAttribute Bloodshard_Bonus_Percent_Potion_Buff => SnoData.Attributes.GetAttributeByIndex(1417);

	public IAttribute XP_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1418);

	public IAttribute Gold_Find_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1419);

	public IAttribute Bloodshard_Potion_Buff_Expiration => SnoData.Attributes.GetAttributeByIndex(1420);

	public IAttribute Current_Cosmetic_Pet => SnoData.Attributes.GetAttributeByIndex(1421);

	public IAttribute Cosmetic_Pet_Power => SnoData.Attributes.GetAttributeByIndex(1422);

	public IAttribute Cosmetic_Pet_Expiration => SnoData.Attributes.GetAttributeByIndex(1423);

	public IAttribute Cosmetic_Portrait_Frame => SnoData.Attributes.GetAttributeByIndex(1424);

	public IAttribute HQ_Hot_Cold_State => SnoData.Attributes.GetAttributeByIndex(1425);

	public IAttribute HQ_Cursed_Realm_Reagents_Collected => SnoData.Attributes.GetAttributeByIndex(1426);

	public IAttribute HQ_Cursed_Realm_Reagents_Dropped => SnoData.Attributes.GetAttributeByIndex(1427);

	public IAttribute Debug_Movement_Type => SnoData.Attributes.GetAttributeByIndex(1428);

	public IAttribute Tiered_Loot_Run_Death_Count => SnoData.Attributes.GetAttributeByIndex(1429);

	public IAttribute Tiered_Loot_Run_Corpse_Resurrection_Allowed_GameTime => SnoData.Attributes.GetAttributeByIndex(1430);

	public IAttribute Last_Posted_Achievement_Points => SnoData.Attributes.GetAttributeByIndex(1431);

	public IAttribute Cosmetic_Pet_Actor => SnoData.Attributes.GetAttributeByIndex(1432);

	public IAttribute Platinum_Cap_Remaining => SnoData.Attributes.GetAttributeByIndex(1433);

	public IAttribute Platinum_Cap_Last_Gain => SnoData.Attributes.GetAttributeByIndex(1434);

	public IAttribute Last_Boss_Kill_Time => SnoData.Attributes.GetAttributeByIndex(1435);

	public IAttribute Last_Bounty_Complete_Time => SnoData.Attributes.GetAttributeByIndex(1436);

	public IAttribute Last_Treasure_Goblin_Kill_Time => SnoData.Attributes.GetAttributeByIndex(1437);

	public IAttribute Stash_Tabs_Purchased_With_Gold => SnoData.Attributes.GetAttributeByIndex(1438);

	public IAttribute Stash_Tabs_Rewarded_By_Achievements => SnoData.Attributes.GetAttributeByIndex(1439);

	public IAttribute Skill_Button_Flash => SnoData.Attributes.GetAttributeByIndex(1440);

	public IAttribute Projectile_Det_Path_Reflect_Count => SnoData.Attributes.GetAttributeByIndex(1441);

	public IAttribute Last_Cosmetic_Pet => SnoData.Attributes.GetAttributeByIndex(1442);

	public IAttribute Platinum_Last_Significant_Kill => SnoData.Attributes.GetAttributeByIndex(1443);

	public IAttribute Power_Last_Attribute_Snapshot_Update_Time => SnoData.Attributes.GetAttributeByIndex(1444);

	public IAttribute Skill_Button_Active_Glow => SnoData.Attributes.GetAttributeByIndex(1445);

	public IAttribute Participating_In_Set_Dungeon => SnoData.Attributes.GetAttributeByIndex(1446);

	public IAttribute Multiplicative_Damage_Percent_Bonus => SnoData.Attributes.GetAttributeByIndex(1447);

	public IAttribute Multiplicative_Damage_Percent_Bonus_For_Skill => SnoData.Attributes.GetAttributeByIndex(1448);

	public IAttribute Multiplicative_Damage_Percent_Bonus_For_Player => SnoData.Attributes.GetAttributeByIndex(1449);

	public IAttribute In_Set_Dungeon_World => SnoData.Attributes.GetAttributeByIndex(1450);

	public IAttribute Multiplicative_Damage_Percent_Bonus_No_Pets => SnoData.Attributes.GetAttributeByIndex(1452);

	public IAttribute Multiplicative_Damage_Percent_Bonus_ochallengeAgainst_CC_Targets => SnoData.Attributes.GetAttributeByIndex(1453);

	public IAttribute Multiplicative_Damage_Percent_Bonus_Against_Slowed_Targets => SnoData.Attributes.GetAttributeByIndex(1454);

	public IAttribute Summoned_By_Autocast => SnoData.Attributes.GetAttributeByIndex(1455);

	public IAttribute Necromancer_Corpse_Spawn_Chance => SnoData.Attributes.GetAttributeByIndex(1456);

	public IAttribute Necromancer_Last_Corpse_Spawn_Check_Tick => SnoData.Attributes.GetAttributeByIndex(1457);

	public IAttribute Necromancer_Corpse_Owner_Player_High => SnoData.Attributes.GetAttributeByIndex(1458);

	public IAttribute Necromancer_Corpse_Owner_Player_Low => SnoData.Attributes.GetAttributeByIndex(1459);

	public IAttribute Necromancer_Corpse_Charges => SnoData.Attributes.GetAttributeByIndex(1460);

	public IAttribute Necromancer_Corpse_Source_Monster_SNO => SnoData.Attributes.GetAttributeByIndex(1461);

	public IAttribute Necromancer_Corpse_Free_Casting => SnoData.Attributes.GetAttributeByIndex(1462);

	public IAttribute Currencies_Discovered => SnoData.Attributes.GetAttributeByIndex(1463);

	public IAttribute In_Tiered_Challenge_Rift => SnoData.Attributes.GetAttributeByIndex(1464);

	public IAttribute Necromancer_Cursed => SnoData.Attributes.GetAttributeByIndex(1465);

	public IAttribute Necromancer_Curse_Count => SnoData.Attributes.GetAttributeByIndex(1466);

	public IAttribute Necromancer_Unique_Curse_Count => SnoData.Attributes.GetAttributeByIndex(1467);

	public IAttribute Eligible_For_Weekly_Challenge_Reward => SnoData.Attributes.GetAttributeByIndex(1468);

	public IAttribute Force_Remote_FX => SnoData.Attributes.GetAttributeByIndex(1469);

	public IAttribute Weekly_Challenge_Reward_Icon => SnoData.Attributes.GetAttributeByIndex(1470);

	public IAttribute Item_Was_Touched_By_Armory => SnoData.Attributes.GetAttributeByIndex(1471);

	public IAttribute Item_Was_Touched_By_Armory_Last_Game => SnoData.Attributes.GetAttributeByIndex(1472);

	public IAttribute Has_Nfp_Device => SnoData.Attributes.GetAttributeByIndex(1473);

	public IAttribute ReceivedPrimalWhenUnlocking => SnoData.Attributes.GetAttributeByIndex(1474);

	public IAttribute KanaiPowersunlocked => SnoData.Attributes.GetAttributeByIndex(1475);

	public IAttribute FourthKanaisCubeSlotunlocked => SnoData.Attributes.GetAttributeByIndex(1476);

	public IAttribute Etherealitemsunlocked => SnoData.Attributes.GetAttributeByIndex(1477);

	public IAttribute Soulshardsunlocked => SnoData.Attributes.GetAttributeByIndex(1478);

	public IAttribute Itemwassanctified => SnoData.Attributes.GetAttributeByIndex(1479);

	public IAttribute Sanctifieditemsunlocked => SnoData.Attributes.GetAttributeByIndex(1480);

	public IAttribute In_Swarm_Rift_World => SnoData.Attributes.GetAttributeByIndex(1451);

	public IAttribute HerosunlockedDarkAlchemynodes => SnoData.Attributes.GetAttributeByIndex(1481);

	public IAttribute DarkAlchemypowersunlocked => SnoData.Attributes.GetAttributeByIndex(1482);

	public IAttribute Itemwasprimalized => SnoData.Attributes.GetAttributeByIndex(1483);

	public IAttribute ParagonCapEnabled => SnoData.Attributes.GetAttributeByIndex(1484);
}
