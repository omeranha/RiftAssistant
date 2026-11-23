using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace RiftAssistant.Model;

internal sealed class Actors
{
	internal readonly Dictionary<ActorSnoEnum, SnoActor> dictionary_0 = new Dictionary<ActorSnoEnum, SnoActor>(5000);

	private readonly Dictionary<ActorSnoEnum, SkillEffectRule> dictionary_1 = new Dictionary<ActorSnoEnum, SkillEffectRule>();

	private readonly Dictionary<ActorSnoEnum, ActorShrineTypeInfo> dictionary_2 = new Dictionary<ActorSnoEnum, ActorShrineTypeInfo>();

	public SnoActor GetActor(ActorSnoEnum sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	public SkillEffectRule GetSkillEffectRule(ActorSnoEnum sno)
	{
		dictionary_1.TryGetValue(sno, out var value);
		return value;
	}

	public ActorShrineTypeInfo GetActorShrineTypeInfo(ActorSnoEnum sno)
	{
		dictionary_2.TryGetValue(sno, out var value);
		return value;
	}

	internal Actors()
	{
		string[] array = SnoResourceHelper.GetActors().Split('\n');
		foreach (string text in array)
		{
			if (!text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text))
			{
				string[] array2 = text.Trim('\r').Split('\t');
				ActorSnoEnum actorSnoEnum = (ActorSnoEnum)uint.Parse(array2[0], CultureInfo.InvariantCulture);
				string text2 = string.Intern(array2[1]);
				ActorKind actorKind_ = (ActorKind)Enum.Parse(typeof(ActorKind), array2[2], ignoreCase: true);
				bool bool_ = array2[3] == "static";
				ActorType actorType_ = ((array2.Length > 4) ? ((ActorType)Enum.Parse(typeof(ActorType), array2[4], ignoreCase: true)) : ActorType.Invalid);
				string stringByCode = SnoData.Strings.GetStringByCode(text2);
				string stringByCodeEnglish = SnoData.Strings.GetStringByCodeEnglish(text2);
				dictionary_0.Add(actorSnoEnum, new SnoActor(actorSnoEnum, actorType_, actorKind_, bool_, text2, stringByCode, stringByCodeEnglish));
			}
		}
		using (DataReader dataReader = new(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_actor_inventory_index.bin"))))
		{
			while (dataReader.Stream.Position < dataReader.Stream.Length)
			{
				ActorSnoEnum sno = (ActorSnoEnum)dataReader.ReadUInt32();
				SnoActor actor = GetActor(sno);
				int num = dataReader.ReadPackedInt32();
				uint[] array3 = new uint[num];
				for (int j = 0; j < num; j++)
				{
					array3[j] = dataReader.ReadUInt32();
				}
				if (actor != null)
				{
					actor.TextureMap = array3;
				}
			}
		}
		AddSkillEffectRule(SkillEffectType.meteor, ActorSnoEnum._temp_wizard_meteor_pending_rune, 10f);
		AddSkillEffectRule(SkillEffectType.meteor, ActorSnoEnum._temp_wizard_meteor_impact_frost_rune, 10f);
		AddSkillEffectRule(SkillEffectType.meteor, ActorSnoEnum._temp_wizard_meteor_afterburn_longer, 10f);
		AddSkillEffectRule(SkillEffectType.meteor, ActorSnoEnum._wizard_meteor_afterburn_cost, 10f);
		AddSkillEffectRule(SkillEffectType.meteor, ActorSnoEnum._wizard_meteor_impact_adddamage, 10f);
		AddSkillEffectRule(SkillEffectType.wicked_wind, ActorSnoEnum._x1_wizard_tornado_stationary, 5f);
		AddSkillEffectRule(SkillEffectType.blizzard, ActorSnoEnum._wizard_blizzard_addtime, 12f);
		AddSkillEffectRule(SkillEffectType.blizzard, ActorSnoEnum._wizard_blizzard_addsize, 22f);
		AddSkillEffectRule(SkillEffectType.blizzard, ActorSnoEnum._wizard_blizzard_reducecost, 12f);
		AddSkillEffectRule(SkillEffectType.blizzard, ActorSnoEnum._wizard_blizzard_addfreeze, 12f);
		AddSkillEffectRule(SkillEffectType.acid_cloud, ActorSnoEnum._wd_acidcloudrune_splash, 24f);
		AddSkillEffectRule(SkillEffectType.gargantuan, ActorSnoEnum._wd_gargantuan_cleave, 8f);
		AddSkillEffectRule(SkillEffectType.gargantuan, ActorSnoEnum._wd_gargantuan_slam, 8f);
		AddSkillEffectRule(SkillEffectType.gargantuan, ActorSnoEnum._wd_gargantuan_poison, 8f);
		AddSkillEffectRule(SkillEffectType.gargantuan, ActorSnoEnum._wd_gargantuan_cooldown, 8f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedogrune_fire, 12f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedogrune_healthglobe, 12f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedogrune_healthlink, 12f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedogrune_lifesteal, 12f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedogrune_poison, 12f);
		AddSkillEffectRule(SkillEffectType.zombiedog, ActorSnoEnum._wd_zombiedog, 12f);
		AddSkillEffectRule(SkillEffectType.elite_wall, ActorSnoEnum._monsteraffix_waller_model, 10f);
		AddSkillEffectRule(SkillEffectType.spike_trap, ActorSnoEnum._demonhunter_spiketraprune_chainlightning_proxy, 10f);
		AddSkillEffectRule(SkillEffectType.spike_trap, ActorSnoEnum._demonhunter_spiketraprune_damage_proxy, 10f);
		AddSkillEffectRule(SkillEffectType.spike_trap, ActorSnoEnum._demonhunter_spiketraprune_multitrap_proxy, 10f);
		AddSkillEffectRule(SkillEffectType.spike_trap, ActorSnoEnum._demonhunter_spiketrap_proxy, 10f);
		AddSkillEffectRule(SkillEffectType.hydra, ActorSnoEnum._wizard_hydrahead_arcane_1, 10f);
		AddSkillEffectRule(SkillEffectType.hydra, ActorSnoEnum._wizard_hydrahead_lightning_2, 10f);
		AddSkillEffectRule(SkillEffectType.hydra, ActorSnoEnum._wizard_hydrahead_fire2_1, 10f);
		AddSkillEffectRule(SkillEffectType.hydra, ActorSnoEnum._wizard_hydrahead_frost_2, 10f);
		AddSkillEffectRule(SkillEffectType.hydra, ActorSnoEnum._wizard_hydrahead_big, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_melee_a, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_doublestack_shaman_a, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_ranged_a, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_melee_itempassive, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_shaman_a, 10f);
		AddSkillEffectRule(SkillEffectType.fetish, ActorSnoEnum._fetish_skeleton_a, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry_addsmissiles, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry_addsduration, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry_tether, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry_addsheals, 10f);
		AddSkillEffectRule(SkillEffectType.sentry, ActorSnoEnum._dh_sentry_addsshield, 10f);
		AddSkillEffectRule(SkillEffectType.cota, ActorSnoEnum._barbarian_calloftheancients_1, 10f);
		AddSkillEffectRule(SkillEffectType.cota, ActorSnoEnum._barbarian_calloftheancients_2, 10f);
		AddSkillEffectRule(SkillEffectType.cota, ActorSnoEnum._barbarian_calloftheancients_3, 10f);
		AddShrineType(ShrineType.BlessedShrine, ActorSnoEnum._shrine_global_blessed);
		AddShrineType(ShrineType.EnlightenedShrine, ActorSnoEnum._shrine_global_enlightened);
		AddShrineType(ShrineType.FortuneShrine, ActorSnoEnum._shrine_global_fortune);
		AddShrineType(ShrineType.FrenziedShrine, ActorSnoEnum._shrine_global_frenzied);
		AddShrineType(ShrineType.EmpoweredShrine, ActorSnoEnum._shrine_global_reloaded);
		AddShrineType(ShrineType.FleetingShrine, ActorSnoEnum._shrine_global_hoarder);
		AddShrineType(ShrineType.BlessedShrine, ActorSnoEnum._a4_heaven_shrine_global_blessed);
		AddShrineType(ShrineType.EnlightenedShrine, ActorSnoEnum._a4_heaven_shrine_global_enlightened);
		AddShrineType(ShrineType.FortuneShrine, ActorSnoEnum._a4_heaven_shrine_global_fortune);
		AddShrineType(ShrineType.FrenziedShrine, ActorSnoEnum._a4_heaven_shrine_global_frenzied);
		AddShrineType(ShrineType.EmpoweredShrine, ActorSnoEnum._a4_heaven_shrine_global_reloaded);
		AddShrineType(ShrineType.FleetingShrine, ActorSnoEnum._a4_heaven_shrine_global_hoarder);
		AddShrineType(ShrineType.BlessedShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_blessed);
		AddShrineType(ShrineType.EnlightenedShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_enlightened);
		AddShrineType(ShrineType.FortuneShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_fortune);
		AddShrineType(ShrineType.FrenziedShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_frenzied);
		AddShrineType(ShrineType.EmpoweredShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_reloaded);
		AddShrineType(ShrineType.FleetingShrine, ActorSnoEnum._a4_heaven_shrine_global_demoncorrupted_hoarder);
		AddShrineType(ShrineType.BlessedShrine, ActorSnoEnum._a4dun_garden_purification_well_blessed);
		AddShrineType(ShrineType.EnlightenedShrine, ActorSnoEnum._a4dun_garden_purification_well_enlightened);
		AddShrineType(ShrineType.FortuneShrine, ActorSnoEnum._a4dun_garden_purification_well_fortune);
		AddShrineType(ShrineType.FrenziedShrine, ActorSnoEnum._a4dun_garden_purification_well_frenzied);
		AddShrineType(ShrineType.EmpoweredShrine, ActorSnoEnum._a4dun_garden_purification_well_reloaded);
		AddShrineType(ShrineType.FleetingShrine, ActorSnoEnum._a4dun_garden_purification_well_hoarder);
		AddShrineType(ShrineType.BlessedShrine, ActorSnoEnum._p43_ad_shrine_global_blessed);
		AddShrineType(ShrineType.EnlightenedShrine, ActorSnoEnum._p43_ad_shrine_global_enlightened);
		AddShrineType(ShrineType.FrenziedShrine, ActorSnoEnum._p43_ad_shrine_global_frenzied);
		AddShrineType(ShrineType.EmpoweredShrine, ActorSnoEnum._p43_ad_shrine_global_reloaded);
		AddShrineType(ShrineType.FleetingShrine, ActorSnoEnum._p43_ad_shrine_global_hoarder);
		AddShrineType(ShrineType.BanditShrine, ActorSnoEnum._p43_ad_shrine_treasuregoblin);
		AddShrineType(ShrineType.PowerPylon, ActorSnoEnum._x1_lr_shrine_damage);
		AddShrineType(ShrineType.ConduitPylon, ActorSnoEnum._x1_lr_shrine_electrified);
		AddShrineType(ShrineType.ConduitPylon, ActorSnoEnum._x1_lr_shrine_electrified_tieredrift);
		AddShrineType(ShrineType.ChannelingPylon, ActorSnoEnum._x1_lr_shrine_infinite_casting);
		AddShrineType(ShrineType.ShieldPylon, ActorSnoEnum._x1_lr_shrine_invulnerable);
		AddShrineType(ShrineType.SpeedPylon, ActorSnoEnum._x1_lr_shrine_run_speed);
		AddShrineType(ShrineType.PoolOfReflection, ActorSnoEnum._poolofreflection);
		AddShrineType(ShrineType.BanditShrine, ActorSnoEnum._shrine_treasuregoblin);
		AddShrineType(ShrineType.BanditShrine, ActorSnoEnum._a4_heaven_shrine_treasuregoblin);
		AddShrineType(ShrineType.HealingWell, ActorSnoEnum._a1dun_leor_bloodwell_a);
		AddShrineType(ShrineType.HealingWell, ActorSnoEnum._a4dun_diablo_arena_health_well);
		AddShrineType(ShrineType.HealingWell, ActorSnoEnum._a4_heaven_healthwell_global);
		AddShrineType(ShrineType.HealingWell, ActorSnoEnum._caout_healthwell);
		AddShrineType(ShrineType.HealingWell, ActorSnoEnum._healthwell_global);
	}

	private void AddSkillEffectRule(SkillEffectType skillEffectType, ActorSnoEnum actorSnoEnum, float float_0)
	{
		SkillEffectRule value = new SkillEffectRule(skillEffectType, GetActor(actorSnoEnum), float_0);
		dictionary_1.Add(actorSnoEnum, value);
	}

	private void AddShrineType(ShrineType shrineType, ActorSnoEnum actorSnoEnum)
	{
		ActorShrineTypeInfo value = new ActorShrineTypeInfo(shrineType, GetActor(actorSnoEnum));
		dictionary_2.Add(actorSnoEnum, value);
	}
}
