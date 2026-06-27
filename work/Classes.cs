using SNO;
using System.Collections.Generic;
using Plugins;

namespace work;

public sealed class Classes
{
	public readonly Dictionary<uint, HeroClassDefinition> HeroClassesByIDX = new Dictionary<uint, HeroClassDefinition>();

	public readonly HeroClassDefinition ClassWizard;

	public readonly HeroClassDefinition ClassDemonHunter;

	public readonly HeroClassDefinition ClassBarbarian;

	public readonly HeroClassDefinition ClassWitchDoctor;

	public readonly HeroClassDefinition ClassMonk;

	public readonly HeroClassDefinition ClassCrusader;

	public readonly HeroClassDefinition ClassNecromancer;

	public readonly FollowerClass FollowerTemplar;

	public readonly FollowerClass FollowerScoundrel;

	public readonly FollowerClass FollowerEnchantress;

	private readonly Dictionary<ActorSnoEnum, FollowerClass> dictionary_0 = new Dictionary<ActorSnoEnum, FollowerClass>();

	private readonly Dictionary<ActorSnoEnum, HeroClassDefinition> dictionary_1 = new Dictionary<ActorSnoEnum, HeroClassDefinition>();

	public HeroClassDefinition GetHeroClassBySno(ActorSnoEnum sno)
	{
		dictionary_1.TryGetValue(sno, out var value);
		return value;
	}

	public HeroClassDefinition GetHeroClassByInternalIndex(uint index)
	{
		HeroClassesByIDX.TryGetValue(index, out var value);
		return value;
	}

	public FollowerClass GetFollowerClass(ActorSnoEnum sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	internal Classes()
	{
		ClassWizard = method_0(HeroClass.Wizard, "wizard", "Wizard", bool_0: true, ActorSnoEnum._wizard_male, ActorSnoEnum._wizard_female, "arcane", null);
		ClassDemonHunter = method_0(HeroClass.DemonHunter, "demonhunter", "DemonHunter", bool_0: true, ActorSnoEnum._demonhunter_male, ActorSnoEnum._demonhunter_female, "hatred", "discipline");
		ClassBarbarian = method_0(HeroClass.Barbarian, "barbarian", "Barbarian", bool_0: false, ActorSnoEnum._barbarian_male, ActorSnoEnum._barbarian_female, "fury", null);
		ClassWitchDoctor = method_0(HeroClass.WitchDoctor, "witchdoctor", "WitchDoctor", bool_0: true, ActorSnoEnum._witchdoctor_male, ActorSnoEnum._witchdoctor_female, "mana", null);
		ClassMonk = method_0(HeroClass.Monk, "monk", "Monk", bool_0: false, ActorSnoEnum._monk_male, ActorSnoEnum._monk_female, "spirit", null);
		ClassCrusader = method_0(HeroClass.Crusader, "crusader", "Crusader", bool_0: false, ActorSnoEnum._x1_crusader_male, ActorSnoEnum._x1_crusader_female, "wrath", null);
		ClassNecromancer = method_0(HeroClass.Necromancer, "necromancer", "Necromancer", bool_0: true, ActorSnoEnum._p6_necro_male, ActorSnoEnum._p6_necro_female, "essence", null);
		HeroClassesByIDX.Add(0u, ClassDemonHunter);
		HeroClassesByIDX.Add(1u, ClassBarbarian);
		HeroClassesByIDX.Add(2u, ClassWizard);
		HeroClassesByIDX.Add(3u, ClassWitchDoctor);
		HeroClassesByIDX.Add(4u, ClassMonk);
		HeroClassesByIDX.Add(5u, ClassCrusader);
		HeroClassesByIDX.Add(6u, ClassNecromancer);
		FollowerTemplar = method_1("templar", "Templar", ActorSnoEnum._hireling_templar, FollowerClassEnum.Templar);
		FollowerScoundrel = method_1("scoundrel", "Scoundrel", ActorSnoEnum._hireling_scoundrel, FollowerClassEnum.Scoundrel);
		FollowerEnchantress = method_1("enchantress", "Enchantress", ActorSnoEnum._hireling_enchantress, FollowerClassEnum.Enchantress);
	}

	private HeroClassDefinition method_0(HeroClass heroClass_0, string string_0, string string_1, bool bool_0, ActorSnoEnum actorSnoEnum_0, ActorSnoEnum actorSnoEnum_1, string string_2, string string_3)
	{
		string stringByCode = SnoData.Strings.GetStringByCode(StringListSnoEnum._bnet_classes, string_1);
		HeroClassDefinition heroClassDefinition = new HeroClassDefinition(heroClass_0, string_0, string_1, stringByCode, bool_0, actorSnoEnum_0, actorSnoEnum_1, string_2, string_3);
		dictionary_1.Add(actorSnoEnum_0, heroClassDefinition);
		dictionary_1.Add(actorSnoEnum_1, heroClassDefinition);
		return heroClassDefinition;
	}

	private FollowerClass method_1(string string_0, string string_1, ActorSnoEnum actorSnoEnum_0, FollowerClassEnum followerClassEnum_0)
	{
		FollowerClass followerClass = new FollowerClass(string_0, string_1, actorSnoEnum_0, followerClassEnum_0);
		dictionary_0.Add(actorSnoEnum_0, followerClass);
		return followerClass;
	}
}
