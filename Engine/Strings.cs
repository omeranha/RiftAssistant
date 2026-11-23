using System.Collections.Generic;
using System.IO;

namespace RiftAssistant.Engine;

internal sealed class Strings
{
	public readonly string Language;

	private readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	private readonly Dictionary<string, string> dictionary_1;

	private readonly Dictionary<StringListSnoEnum, Dictionary<string, string>> dictionary_2 = new Dictionary<StringListSnoEnum, Dictionary<string, string>>();

	private readonly Dictionary<StringListSnoEnum, Dictionary<string, string>> dictionary_3;

	private readonly Dictionary<StringListSnoEnum, Dictionary<uint, string>> dictionary_4 = new Dictionary<StringListSnoEnum, Dictionary<uint, string>>();

	private readonly Dictionary<StringListSnoEnum, Dictionary<uint, string>> dictionary_5;

	private readonly Dictionary<uint, List<string>> dictionary_6 = new Dictionary<uint, List<string>>();

	public string GetStringByCode(string code)
	{
		dictionary_0.TryGetValue(code, out var value);
		return value;
	}

	public string GetStringByCodeEnglish(string code)
	{
		dictionary_1.TryGetValue(code, out var value);
		return value;
	}

	public string GetStringByCode(StringListSnoEnum snoEnum, string code)
	{
		if (!dictionary_2.TryGetValue(snoEnum, out var value))
		{
			return string.Empty;
		}
		value.TryGetValue(code, out var value2);
		return value2;
	}

	public string GetStringByCodeEnglish(StringListSnoEnum snoEnum, string code)
	{
		if (!dictionary_3.TryGetValue(snoEnum, out var value))
		{
			return string.Empty;
		}
		value.TryGetValue(code, out var value2);
		return value2;
	}

	public string GetStringById(StringListSnoEnum snoEnum, uint id)
	{
		if (!dictionary_4.TryGetValue(snoEnum, out var value))
		{
			return string.Empty;
		}
		value.TryGetValue(id, out var value2);
		return value2;
	}

	public string GetStringByIdEnglish(StringListSnoEnum snoEnum, uint id)
	{
		if (!dictionary_5.TryGetValue(snoEnum, out var value))
		{
			return string.Empty;
		}
		value.TryGetValue(id, out var value2);
		return value2;
	}

	public string GetStringByIndex(uint snoEnum, int index)
	{
		if (index < 0 || !dictionary_6.TryGetValue(snoEnum, out var value))
		{
			return string.Empty;
		}
		if (index >= value.Count)
		{
			return string.Empty;
		}
		return value[index];
	}

	internal Strings()
	{
		Language = LoadLanguage();
		using (DataReader dataReader = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "strings_" + Language + ".bin"))))
		{
			while (dataReader.Stream.Position < dataReader.Stream.Length)
			{
				uint key = dataReader.ReadUInt32();
				dataReader.ReadString();
				int num = dataReader.ReadInt32();
				List<string> list = new List<string>();
				Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				dictionary_6.Add(key, list);
				dictionary_4.Add((StringListSnoEnum)key, dictionary);
				dictionary_2.Add((StringListSnoEnum)key, dictionary2);
				for (int i = 0; i < num; i++)
				{
					uint key2 = dataReader.ReadUInt32();
					string key3 = string.Intern(dataReader.ReadString());
					string text = string.Intern(dataReader.ReadString());
					list.Add(text);
					dictionary.Add(key2, text);
					dictionary2.Add(key3, text);
					dictionary_0[key3] = text;
				}
			}
		}
		if (Language != "enUS")
		{
			byte[] byte_ = File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "strings_enUS.bin"));
			dictionary_3 = new Dictionary<StringListSnoEnum, Dictionary<string, string>>();
			dictionary_5 = new Dictionary<StringListSnoEnum, Dictionary<uint, string>>();
			dictionary_1 = new Dictionary<string, string>();
			using DataReader dataReader2 = new DataReader(byte_);
			while (dataReader2.Stream.Position < dataReader2.Stream.Length)
			{
				uint key4 = dataReader2.ReadUInt32();
				dataReader2.ReadString();
				int num2 = dataReader2.ReadInt32();
				List<string> list2 = new List<string>();
				Dictionary<uint, string> dictionary3 = new Dictionary<uint, string>();
				Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
				dictionary_5.Add((StringListSnoEnum)key4, dictionary3);
				dictionary_3.Add((StringListSnoEnum)key4, dictionary4);
				for (int j = 0; j < num2; j++)
				{
					uint key5 = dataReader2.ReadUInt32();
					string key6 = string.Intern(dataReader2.ReadString());
					string text2 = string.Intern(dataReader2.ReadString());
					list2.Add(text2);
					dictionary3.Add(key5, text2);
					dictionary4.Add(key6, text2);
					dictionary_1[key6] = text2;
				}
			}
			return;
		}
		dictionary_1 = dictionary_0;
		dictionary_5 = dictionary_4;
		dictionary_3 = dictionary_2;
	}

	public static string LoadLanguage()
	{
		string result = "enUS";
		string path = Path.Combine(Program.AppDir, "data", "selected_language.txt");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (!string.IsNullOrWhiteSpace(text) && !text.StartsWith("//") && File.Exists(Path.Combine(Program.AppDir, "data", "strings_" + text + ".bin")))
				{
					result = text;
					break;
				}
			}
		}
		return result;
	}
}
