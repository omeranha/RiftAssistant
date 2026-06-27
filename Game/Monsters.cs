using SNO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

public sealed class Monsters
{
	[CompilerGenerated]
	private readonly SnoMonster SnoMonster_0;

	private readonly Dictionary<uint, SnoMonsterAffix> dictionary_0 = new Dictionary<uint, SnoMonsterAffix>(100);

	private readonly Dictionary<ActorSnoEnum, SnoMonster> dictionary_1 = new Dictionary<ActorSnoEnum, SnoMonster>(3000);

	private readonly Dictionary<uint, SnoMonster> dictionary_2 = new Dictionary<uint, SnoMonster>(3000);

	public SnoMonster SnoMonsterObstacle
	{
		[CompilerGenerated]
		get
		{
			return SnoMonster_0;
		}
	}

	public SnoMonster GetMonster(ActorSnoEnum sno)
	{
		dictionary_1.TryGetValue(sno, out var value);
		return value;
	}

	public SnoMonsterAffix GetMonsterAffix(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	public SnoMonster GetMonsterByStringId(uint stringId)
	{
		dictionary_2.TryGetValue(stringId, out var value);
		return value;
	}

	internal Monsters()
	{
		byte[] byte_ = File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "gamebalance_monster_affixes.bin"));
		HashSet<uint> hashSet = new HashSet<uint> { 484610u, 484627u, 484628u, 484629u, 484630u, 484631u, 484632u };
		using (DataReader @class = new DataReader(byte_))
		{
			while (@class.Stream.Position < @class.Stream.Length)
			{
				uint num = @class.method_8();
				string code = @class.method_1();
				string stringByCode = SnoData.Strings.GetStringByCode(StringListSnoEnum._monsteraffixnames, code);
				string stringByCodeEnglish = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._monsteraffixnames, code);
				if (Enum.IsDefined(typeof(MonsterAffix), num))
				{
					dictionary_0.Add(num, new SnoMonsterAffix(num, (MonsterAffix)num, stringByCode, stringByCodeEnglish));
				}
			}
		}
		string[] array = SnoResourceHelper.GetMonsters().Split('\n');
		foreach (string text in array)
		{
			if (!text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text))
			{
				string[] array2 = text.Split('\t');
				ActorSnoEnum actorSnoEnum = (ActorSnoEnum)uint.Parse(array2[0], CultureInfo.InvariantCulture);
				uint num2 = uint.Parse(array2[1], CultureInfo.InvariantCulture);
				uint num3 = uint.Parse(array2[2], CultureInfo.InvariantCulture);
				string text2 = array2[3];
				MonsterPriority monsterPriority = (MonsterPriority)Enum.Parse(typeof(MonsterPriority), array2[4], ignoreCase: true);
				float float_ = float.Parse(array2[5], CultureInfo.InvariantCulture);
				string stringById = SnoData.Strings.GetStringById(StringListSnoEnum._monsters, num3);
				string stringByIdEnglish = SnoData.Strings.GetStringByIdEnglish(StringListSnoEnum._monsters, num3);
				if (num3 == 0 && hashSet.Contains(num2))
				{
					stringById = SnoData.Strings.GetStringById(StringListSnoEnum._monsters, 3553387842u);
					stringByIdEnglish = SnoData.Strings.GetStringByIdEnglish(StringListSnoEnum._monsters, 3553387842u);
				}
				SnoActor snoActor = SnoData.Actors.GetActor(actorSnoEnum);
				if (snoActor == null)
				{
					snoActor = new SnoActor(actorSnoEnum, ActorType.Invalid, ActorKind.None, bool_1: false, "dummyactor-" + text2, "dummyactor-" + text2, "dummyactor-" + text2);
					SnoData.Actors.dictionary_0.Add(actorSnoEnum, snoActor);
				}
				bool bool_ = text2.IndexOf("unique", StringComparison.InvariantCultureIgnoreCase) > -1 || monsterPriority == MonsterPriority.boss || monsterPriority == MonsterPriority.keywarden;
				SnoMonster value = new SnoMonster(snoActor, num2, text2, stringById, stringByIdEnglish, monsterPriority, bool_, float_);
				dictionary_1.Add(actorSnoEnum, value);
				dictionary_2[num3] = value;
			}
		}
		SnoActor snoActor_ = new SnoActor((ActorSnoEnum)0u, ActorType.Invalid, ActorKind.None, bool_1: false, "dummyactor-monster-obstacle", "dummyactor-monster-obstacle", "dummyactor-monster-obstacle");
		SnoMonster_0 = new SnoMonster(snoActor_, 0u, "obstacle", "obstacle", "obstacle", MonsterPriority.low, bool_1: false, 0f);
	}
}
