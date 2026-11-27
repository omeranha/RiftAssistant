using System;
using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Engine;

internal enum ItemFilterStatUnit
{
	Number,
	Percent
}

internal enum ItemFilterStatCategory
{
	Primary,
	Offense,
	Defense,
	Resource,
	Utility
}

internal sealed record ItemFilterStatInfo(string Code, string Label, ItemFilterStatCategory Category, ItemFilterStatUnit Unit, double Step, double DefaultMin, bool HasRoll = true)
{
	public bool IsPercent => Unit == ItemFilterStatUnit.Percent;

	public string Suffix => IsPercent ? "%" : "";
}

internal static class ItemFilterStats
{
	public const double MaxValue = 1_000_000;
	public const double MaxRoll = 150;
	public const double RollStep = 5;
	public const double DefaultRoll = 80;

	private const ItemFilterStatUnit Number = ItemFilterStatUnit.Number;
	private const ItemFilterStatUnit Percent = ItemFilterStatUnit.Percent;
	private const ItemFilterStatCategory Primary = ItemFilterStatCategory.Primary;
	private const ItemFilterStatCategory Offense = ItemFilterStatCategory.Offense;
	private const ItemFilterStatCategory Defense = ItemFilterStatCategory.Defense;
	private const ItemFilterStatCategory Resource = ItemFilterStatCategory.Resource;
	private const ItemFilterStatCategory Utility = ItemFilterStatCategory.Utility;

	public static readonly IReadOnlyList<ItemFilterStatInfo> All = [
		new("main_stat", "Main stat (Str/Dex/Int)", Primary, Number, 25, 700),
		new("vita", "Vitality", Primary, Number, 25, 700),
		new("str", "Strength", Primary, Number, 25, 700),
		new("dex", "Dexterity", Primary, Number, 25, 700),
		new("int", "Intelligence", Primary, Number, 25, 700),

		new("crit", "Critical hit chance", Offense, Percent, 0.5, 6),
		new("critdmg", "Critical hit damage", Offense, Percent, 5, 50),
		new("ias", "Attack speed", Offense, Percent, 1, 6),
		new("as_extr", "Attack speed (weapon)", Offense, Percent, 1, 6),
		new("skilldmg", "Skill damage", Offense, Percent, 1, 15),
		new("areadmg", "Area damage", Offense, Percent, 1, 12),
		new("dmg_pbonus", "Weapon damage", Offense, Percent, 1, 10),
		new("elitedam", "Damage against elites", Offense, Percent, 1, 10),
		new("sdmg_any", "Elemental damage (any element)", Offense, Percent, 1, 15),
		new("sdmg_ph", "Physical skill damage", Offense, Percent, 1, 15),
		new("sdmg_f", "Fire skill damage", Offense, Percent, 1, 15),
		new("sdmg_l", "Lightning skill damage", Offense, Percent, 1, 15),
		new("sdmg_c", "Cold skill damage", Offense, Percent, 1, 15),
		new("sdmg_p", "Poison skill damage", Offense, Percent, 1, 15),
		new("sdmg_a", "Arcane skill damage", Offense, Percent, 1, 15),
		new("sdmg_h", "Holy skill damage", Offense, Percent, 1, 15),

		new("allres", "All resistances", Defense, Number, 5, 90),
		new("ph_res", "Physical resistance", Defense, Number, 5, 90),
		new("f_res", "Fire resistance", Defense, Number, 5, 90),
		new("l_res", "Lightning resistance", Defense, Number, 5, 90),
		new("c_res", "Cold resistance", Defense, Number, 5, 90),
		new("p_res", "Poison resistance", Defense, Number, 5, 90),
		new("a_res", "Arcane resistance", Defense, Number, 5, 90),
		new("life", "Maximum life", Defense, Percent, 1, 14),
		new("elitedamred", "Damage from elites reduction", Defense, Percent, 1, 15),
		new("ccred", "Crowd control reduction", Defense, Percent, 1, 12),
		new("thorns", "Thorns", Defense, Number, 250, 5000),
		new("hpglobe", "Health globe healing", Defense, Number, 1000, 20000),
		new("hpreg", "Life per second", Defense, Number, 250, 7000),
		new("loh", "Life on hit", Defense, Number, 500, 5000),
		new("lok", "Life on kill", Defense, Number, 250, 2000),
		new("lsteal", "Life steal", Defense, Percent, 0.5, 3),

		new("rescostred", "Resource cost reduction", Resource, Percent, 1, 7),
		new("max_mana", "Maximum mana", Resource, Number, 5, 100),
		new("max_ap", "Maximum arcane power", Resource, Number, 1, 10),
		new("max_fury", "Maximum fury", Resource, Number, 1, 10),
		new("max_spirit", "Maximum spirit", Resource, Number, 1, 10),
		new("max_hatred", "Maximum hatred", Resource, Number, 1, 10),
		new("max_disc", "Maximum discipline", Resource, Number, 1, 10),
		new("max_wrath", "Maximum wrath", Resource, Number, 1, 10),
		new("reg_mana", "Mana regeneration", Resource, Number, 0.5, 1),
		new("reg_ap", "Arcane power regeneration", Resource, Number, 0.5, 1),
		new("reg_fury", "Fury regeneration", Resource, Number, 0.5, 1),
		new("reg_spirit", "Spirit regeneration", Resource, Number, 0.5, 1),
		new("reg_hatred", "Hatred regeneration", Resource, Number, 0.5, 1),
		new("reg_disc", "Discipline regeneration", Resource, Number, 0.5, 1),
		new("reg_wrath", "Wrath regeneration", Resource, Number, 0.5, 1),

		new("cdred", "Cooldown reduction", Utility, Percent, 1, 7),
		new("mf", "Magic find", Utility, Percent, 1, 20),
		new("gf", "Gold find", Utility, Percent, 1, 20),
		new("pickup", "Pickup radius", Utility, Number, 1, 10),
		new("move", "Movement speed", Utility, Percent, 1, 12),
		new("lvlreqred", "Level requirement reduction", Utility, Number, 1, 5),
		new("sock", "Sockets", Utility, Number, 1, 1, false)
	];

	private static readonly Dictionary<string, ItemFilterStatInfo> ByCode = All.ToDictionary(stat => stat.Code, StringComparer.OrdinalIgnoreCase);

	public static ItemFilterStatInfo? Find(string code)
	{
		return ByCode.GetValueOrDefault(code ?? "");
	}

	public static string LabelOf(string code)
	{
		return Find(code)?.Label ?? code;
	}

	public static bool UsesRoll(ItemFilterStatEntry entry, ItemFilterStatInfo info)
	{
		return entry.Measure == ItemFilterMeasure.Roll && info.HasRoll;
	}

	public static string Describe(ItemFilterStatEntry entry)
	{
		var info = Find(entry.Stat);
		if (info == null) return $">= {entry.Min:0.##}";

		return UsesRoll(entry, info) ? $"{entry.Min:0.##}% roll" : $">= {entry.Min:0.##}{info.Suffix}";
	}

	public static ItemFilterStatEntry Create(ItemFilterStatInfo info)
	{
		return new ItemFilterStatEntry { Stat = info.Code, Measure = ItemFilterMeasure.Value, Min = info.DefaultMin };
	}

	public static ItemFilterStatEntry Change(ItemFilterStatEntry entry, double min)
	{
		var info = Find(entry.Stat);
		bool roll = info != null && UsesRoll(entry, info);
		return new ItemFilterStatEntry { Stat = entry.Stat, Measure = entry.Measure, Min = Math.Clamp(min, 0, roll ? MaxRoll : MaxValue) };
	}

	public static ItemFilterStatEntry Step(ItemFilterStatEntry entry, int direction)
	{
		var info = Find(entry.Stat);
		double step = info == null || UsesRoll(entry, info) ? RollStep : info.Step;
		return Change(entry, Math.Round(entry.Min + direction * step, 6));
	}

	public static ItemFilterStatEntry SwitchMeasure(ItemFilterStatEntry entry)
	{
		var info = Find(entry.Stat);
		if (info == null || !info.HasRoll) return entry;

		return entry.Measure == ItemFilterMeasure.Roll
			? new ItemFilterStatEntry { Stat = entry.Stat, Measure = ItemFilterMeasure.Value, Min = info.DefaultMin }
			: new ItemFilterStatEntry { Stat = entry.Stat, Measure = ItemFilterMeasure.Roll, Min = DefaultRoll };
	}
}
