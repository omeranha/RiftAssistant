using System.Collections.Generic;
using System.IO;


namespace RiftAssistant.Sno;

internal static class SnoData
{
	public static readonly Dictionary<uint, string> GeneralTagMapEntries = [];

	public static readonly uint[] GeneralTagMapEntriesScriptFormulas = new uint[100];

	private static readonly Dictionary<uint, TextureIndexEntry> textureIndexEntriesByKey = [];

	private static readonly Dictionary<ulong, TextureIndexEntry> textureIndexEntriesByKey1 = [];

	public static Strings Strings { get; private set; }

	public static Attributes Attributes { get; private set; }

	public static Areas Areas { get; private set; }

	public static Actors Actors { get; private set; }

	public static Monsters Monsters { get; private set; }

	public static Classes Classes { get; private set; }

	public static Powers Powers { get; private set; }

	public static Items Items { get; private set; }

	public static Experience Experience { get; private set; }

	public static Worlds Worlds { get; private set; }

	public static Quests Quests { get; private set; }

	public static Scenes Scenes { get; private set; }

	public static TextureIndexEntry? GetTextureIndexEntry(uint key)
	{
		if (textureIndexEntriesByKey.TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public static TextureIndexEntry? GetTextureIndexEntryBySnoIdWithAnimState(ulong key)
	{
		if (textureIndexEntriesByKey1.TryGetValue(key, out var value))
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
			textureIndexEntriesByKey.TryAdd(num, value);
			textureIndexEntriesByKey1.Add(key, value);
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

	internal static string ReplaceNewlines(string stringByCode, string newValue = "<br>")
	{
		return stringByCode?.Replace("\n", newValue);
	}

}
