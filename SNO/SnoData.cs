using System;
using System.Collections.Generic;
using System.IO;
using work;

namespace SNO;

public static class SnoData
{
	public static readonly Dictionary<uint, string> GeneralTagMapEntries = [];

	public static readonly uint[] GeneralTagMapEntriesScriptFormulas = new uint[100];

	private static readonly Dictionary<uint, TextureIndexEntry> dictionary_0 = [];

	private static readonly Dictionary<ulong, TextureIndexEntry> dictionary_1 = [];

	public static Strings Strings;

	public static Attributes Attributes;

	public static Areas Areas;

	public static Actors Actors;

	public static Monsters Monsters;

	public static Classes Classes;

	public static Powers Powers;

	public static Items Items;

	public static Experience Experience;

	public static Worlds Worlds;

	public static Quests Quests;

	public static Scenes Scenes;

	public static TextureIndexEntry? GetTextureIndexEntry(uint key)
	{
		if (dictionary_0.TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public static TextureIndexEntry? GetTextureIndexEntryBySnoIdWithAnimState(ulong key)
	{
		if (dictionary_1.TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public static void Load()
	{
		smethod_0();
		smethod_1();
		Strings = new Strings();
		Classes = new Classes();
		Powers = new Powers();
		Attributes = new Attributes();
		Actors = new Actors();
		Monsters = new Monsters();
		Items = new Items();
		Areas = new Areas();
		Quests = new Quests();
		Scenes = new Scenes();
		Worlds = new Worlds();
		Experience = new Experience();

	}

	private static void smethod_0()
	{
		using DataReader @class = new(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "resource_index.bin")));
		while (@class.Stream.Position < @class.Stream.Length) {
			ulong key = @class.method_10();
			uint num = @class.method_8();
			int num2 = @class.method_11();
			int x = @class.method_11();
			int y = @class.method_11();
			int w = @class.method_11();
			int h = @class.method_11();
			TextureIndexEntry value = new() {
				Id = num,
				AtlasPosition = num2,
				X = x,
				Y = y,
				W = w,
				H = h
			};
			dictionary_0.TryAdd(num, value);
			dictionary_1.Add(key, value);
		}
	}

	private static void smethod_1()
	{
		using DataReader @class = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "tagmap_powers.bin")));
		while (@class.Stream.Position < @class.Stream.Length) {
			uint num = @class.method_8();
			string text = @class.method_1();
			if (GeneralTagMapEntries.TryAdd(num, text)) {
				if (text.StartsWith("TAG_POWER_SCRIPT_FORMULA_")) {
					int num2 = int.Parse(text.Replace("TAG_POWER_SCRIPT_FORMULA_", ""));
					GeneralTagMapEntriesScriptFormulas[num2] = num;
				}
			}
		}
	}

	internal static string smethod_2(string string_0, string string_1 = "<br>")
	{
		return string_0?.Replace("\n", string_1);
	}

	internal static string smethod_3(string string_0, string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		while (true)
		{
			int num = string_0.IndexOf("{" + string_1 + "}");
			if (num == -1)
			{
				return string_0;
			}
			int num2 = string_0.IndexOf("{/" + string_1 + "}", num + 1);
			if (num2 == -1)
			{
				break;
			}
			string_0 = string_0.Substring(0, num) + string_2 + string_0.Substring(num2 + 3 + string_1.Length);
		}
		return string_0;
	}

	internal static string smethod_4(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		while (true)
		{
			int num = string_0.LastIndexOf("{c_");
			if (num == -1)
			{
				break;
			}
			int num2 = string_0.IndexOf("{/c", num + 1);
			if (num2 == -1)
			{
				break;
			}
			int num3 = string_0.IndexOf("}", num2 + 1);
			if (num3 == -1)
			{
				break;
			}
			string_0 = string_0.Remove(num, num3 - num + 1);
		}
		return string_0;
	}

	internal static string smethod_5(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		while (true)
		{
			int num = string_0.IndexOf("[");
			if (num == -1)
			{
				return string_0;
			}
			int num2 = string_0.IndexOf("]", num + 1);
			if (num2 == -1)
			{
				break;
			}
			string_0 = string_0.Substring(0, num) + string_1 + string_0.Substring(num2 + 1);
		}
		return string_0;
	}
}
