using System;
using System.Collections.Generic;
using System.IO;
using Plugins;

public sealed class Strings
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
		using (DataReader @class = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "strings_" + Language + ".bin"))))
		{
			while (@class.Stream.Position < @class.Stream.Length)
			{
				uint key = @class.method_8();
				@class.method_1();
				int num = @class.method_7();
				List<string> list = new List<string>();
				Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				dictionary_6.Add(key, list);
				dictionary_4.Add((StringListSnoEnum)key, dictionary);
				dictionary_2.Add((StringListSnoEnum)key, dictionary2);
				for (int i = 0; i < num; i++)
				{
					uint key2 = @class.method_8();
					string key3 = string.Intern(@class.method_1());
					string text = string.Intern(@class.method_1());
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
			using DataReader class2 = new DataReader(byte_);
			while (class2.Stream.Position < class2.Stream.Length)
			{
				uint key4 = class2.method_8();
				class2.method_1();
				int num2 = class2.method_7();
				List<string> list2 = new List<string>();
				Dictionary<uint, string> dictionary3 = new Dictionary<uint, string>();
				Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
				dictionary_5.Add((StringListSnoEnum)key4, dictionary3);
				dictionary_3.Add((StringListSnoEnum)key4, dictionary4);
				for (int j = 0; j < num2; j++)
				{
					uint key5 = class2.method_8();
					string key6 = string.Intern(class2.method_1());
					string text2 = string.Intern(class2.method_1());
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
