using SNO;
using System.Collections.Generic;
using System.Globalization;

public sealed class Worlds
{
	private readonly Dictionary<uint, SnoWorld> dictionary_0 = new Dictionary<uint, SnoWorld>(500);

	public SnoWorld GetWorld(uint sno)
	{
		dictionary_0.TryGetValue(sno, out var value);
		return value;
	}

	internal Worlds()
	{
		string[] array = SnoResourceHelper.GetWorlds().Split('\n');
		int num = 0;
		while (num < array.Length)
		{
			string text = array[num];
			num++;
			if (text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) || string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array2 = text.Split('\t');
			uint num2 = uint.Parse(array2[0], CultureInfo.InvariantCulture);
			SnoWorld snoWorld = new SnoWorld(num2);
			dictionary_0.Add(num2, snoWorld);
			for (int i = 1; i < array2.Length; i++)
			{
				uint sno = uint.Parse(array2[i], CultureInfo.InvariantCulture);
				SnoArea snoArea = SnoData.Areas.GetSnoArea(sno);
				snoWorld.SnoAreas.Add(snoArea);
				(snoArea as SnoArea).SnoWorld = snoWorld;
			}
			text = array[num];
			num++;
			int num3 = int.Parse(text, CultureInfo.InvariantCulture);
			for (int j = 0; j < num3; j++)
			{
				text = array[num];
				num++;
				if (text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture))
				{
					text = array[num];
					num++;
				}
				array2 = text.Split('\t');
				float float_ = float.Parse(array2[0], CultureInfo.InvariantCulture);
				float float_2 = float.Parse(array2[1], CultureInfo.InvariantCulture);
				float float_3 = float.Parse(array2[2], CultureInfo.InvariantCulture);
				float float_4 = float.Parse(array2[3], CultureInfo.InvariantCulture);
				uint sno2 = uint.Parse(array2[4], CultureInfo.InvariantCulture);
				SnoArea snoArea2 = SnoData.Areas.GetSnoArea(sno2);
				if (array2.Length == 6)
				{
					uint sno3 = uint.Parse(array2[5], CultureInfo.InvariantCulture);
					SnoScene scene = SnoData.Scenes.GetScene(sno3);
					SnoWorldSceneInfoStatic item = new SnoWorldSceneInfoStatic(float_, float_2, float_3, float_4, snoArea2, scene);
					snoWorld.SceneInfos.Add(item);
					continue;
				}
				SnoWorldSceneInfoRandom snoWorldSceneInfoRandom = new SnoWorldSceneInfoRandom(float_, float_2, float_3, float_4, snoArea2);
				snoWorld.SceneInfos.Add(snoWorldSceneInfoRandom);
				for (int k = 5; k < array2.Length; k++)
				{
					uint sno4 = uint.Parse(array2[k], CultureInfo.InvariantCulture);
					SnoScene scene2 = SnoData.Scenes.GetScene(sno4);
					snoWorldSceneInfoRandom.SnoScenes.Add(scene2);
				}
			}
		}
	}
}
