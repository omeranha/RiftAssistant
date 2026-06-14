using SNO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Plugins;

namespace work;

public sealed class Scenes
{
	private readonly Dictionary<uint, ISnoScene> dictionary_0 = new Dictionary<uint, ISnoScene>(3000);

	public IEnumerable<ISnoScene> AllScenes => dictionary_0.Values;

	public ISnoScene GetScene(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	internal Scenes()
	{
		using (DataReader @class = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "scene.bin"))))
		{
			while (@class.Stream.Position < @class.Stream.Length)
			{
				uint num = @class.method_8();
				int int_ = (int)@class.method_12();
				int int_2 = @class.method_11();
				int int_3 = @class.method_11();
				int int_4 = @class.method_11();
				int int_5 = @class.method_11();
				int int_6 = (int)@class.method_12();
				string string_ = @class.method_1();
				SnoScene value = new SnoScene(num, int_, int_2, int_3, int_4, int_5, int_6, string_);
				dictionary_0.Add(num, value);
			}
		}
		string[] array = SnoResourceHelper.GetSceneHints().Split('\n');
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (!text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) && !string.IsNullOrEmpty(text))
			{
				if (text.EndsWith("\r"))
				{
					text = text.Substring(0, text.Length - 1);
				}
				string[] array2 = text.Split('\t');
				uint sno = uint.Parse(array2[0], CultureInfo.InvariantCulture);
				string string_2 = array2[1];
				ISnoScene scene = GetScene(sno);
				if (scene != null)
				{
					(scene as SnoScene).Hint = new SceneHint(string_2);
				}
			}
		}
	}
}
