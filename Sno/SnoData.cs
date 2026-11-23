using System.Collections.Generic;
using System.IO;


namespace RiftAssistant.Sno;

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
		LoadResourceIndex();
		LoadPowerTagMap();
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

	private static void LoadResourceIndex()
	{
		using DataReader dataReader = new(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "resource_index.bin")));
		while (dataReader.Stream.Position < dataReader.Stream.Length) {
			ulong key = dataReader.ReadUInt64();
			uint num = dataReader.ReadUInt32();
			int num2 = dataReader.ReadPackedInt32();
			int x = dataReader.ReadPackedInt32();
			int y = dataReader.ReadPackedInt32();
			int w = dataReader.ReadPackedInt32();
			int h = dataReader.ReadPackedInt32();
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

	private static void LoadPowerTagMap()
	{
		using DataReader dataReader = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "tagmap_powers.bin")));
		while (dataReader.Stream.Position < dataReader.Stream.Length) {
			uint num = dataReader.ReadUInt32();
			string text = dataReader.ReadString();
			if (GeneralTagMapEntries.TryAdd(num, text)) {
				if (text.StartsWith("TAG_POWER_SCRIPT_FORMULA_")) {
					int num2 = int.Parse(text.Replace("TAG_POWER_SCRIPT_FORMULA_", ""));
					GeneralTagMapEntriesScriptFormulas[num2] = num;
				}
			}
		}
	}

	internal static string ReplaceNewlines(string stringByCode, string string_1 = "<br>")
	{
		return stringByCode?.Replace("\n", string_1);
	}

}
