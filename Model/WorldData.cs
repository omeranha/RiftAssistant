using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public sealed class Areas
{
	[CompilerGenerated]
	private readonly SnoAct[] isnoAct_0 = new SnoAct[5];

	private readonly Dictionary<uint, SnoArea> allAreas = new Dictionary<uint, SnoArea>(500);

	public SnoAct[] AllActs
	{
		[CompilerGenerated]
		get
		{
			return isnoAct_0;
		}
	}

	public IEnumerable<SnoArea> AllAreas => allAreas.Values;

	public SnoArea GetSnoArea(uint sno)
	{
		allAreas.TryGetValue(sno, out var value);
		return value;
	}

	internal Areas()
	{
		using (DataReader dataReader = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "acts.bin"))))
		{
			while (dataReader.Stream.Position < dataReader.Stream.Length)
			{
				uint uint_ = dataReader.ReadUInt32();
				int num = dataReader.ReadPackedInt32();
				int num2 = dataReader.ReadPackedInt32();
				SnoAct snoAct = new SnoAct(uint_, num);
				AllActs[num - 1] = snoAct;
				for (int i = 0; i < num2; i++)
				{
					uint uint_2 = dataReader.ReadUInt32();
					uint uint_3 = dataReader.ReadUInt32();
					snoAct.Waypoints.Add(new SnoActWaypoint(uint_2, uint_3));
				}
			}
		}
		string[] array = SnoResourceHelper.GetLevelAreas().Split('\n');
		foreach (string text in array)
		{
			if (text.StartsWith("//", ignoreCase: false, CultureInfo.InvariantCulture) || string.IsNullOrEmpty(text))
			{
				continue;
			}
			string[] array2 = text.Split('\t');
			uint num3 = uint.Parse(array2[0], CultureInfo.InvariantCulture);
			int int_ = int.Parse(array2[1]);
			string text2 = array2[2];
			string text3 = SnoData.Strings.GetStringByCode(StringListSnoEnum._levelareanames, text2);
			string string_ = SnoData.Strings.GetStringByCodeEnglish(StringListSnoEnum._levelareanames, text2);
			if (text3 != null)
			{
				if (text2 == "A4_dun_Hell_Portal_01" || text2 == "A4_dun_Hell_Portal_02")
				{
					text3 = SnoData.Strings.GetStringByCode(text2 + "_OpenWorld");
					string_ = SnoData.Strings.GetStringByCodeEnglish(text2 + "_OpenWorld");
				}
				if (text2.StartsWith("X1_LR_Level_"))
				{
					text3 = text2.Replace("X1_LR_Level_", "Rift Level ");
					string_ = text2.Replace("X1_LR_Level_", "Rift Level ");
				}
			}
			AreaType areaType_ = (AreaType)Enum.Parse(typeof(AreaType), array2[3], ignoreCase: true);
			bool bool_ = array2[4] == "true";
			string string_2 = array2[5];
			bool bool_2 = array2[6] == "true";
			uint uint_4 = uint.Parse(array2[7], CultureInfo.InvariantCulture);
			SnoArea value = new SnoArea(num3, text2.ToLower(CultureInfo.InvariantCulture), int_, text3, string_, areaType_, bool_, string_2, bool_2, uint_4);
			allAreas.Add(num3, value);
		}
	}
}

public static class Custom
{
	internal sealed class UnknownSnoArea : SnoArea
	{
		private readonly uint _id;

		internal UnknownSnoArea(uint id = uint.MaxValue) : base(id, string.Empty, 0, "!! Missing area name !!", "!! Missing area name !!", AreaType.Normal, false, string.Empty, false, 0)
		{
			_id = id;
		}

		public override bool Equals(object obj) => obj is UnknownSnoArea other && _id == other._id;

		public override int GetHashCode() => _id.GetHashCode();
	}

	internal static readonly SnoArea dummy_snoarea_unknown;

	internal static uint GetAreaSno(Player player)
	{
		uint areaSnoEncrypted = player.RawPlayerData.AreaSnoEncrypted;
		if (areaSnoEncrypted == uint.MaxValue && player.IsMe)
		{
			long int64_ = CoreCollector.DAF.LevelAreaAddress;
			if (int64_ != 0L)
			{
				areaSnoEncrypted = GameWindowManager.Read<uint>(int64_ + Constants.LevelArea_AreaSno_Offset);
			}
		}
		return areaSnoEncrypted;
	}

	internal unsafe static void SetSnoAreaForPlayer(Player player)
	{
		uint areaSnoEncrypted = player.RawPlayerData.AreaSnoEncrypted;
		if (areaSnoEncrypted != uint.MaxValue)
		{
			player.SnoArea = SnoData.Areas.GetSnoArea(areaSnoEncrypted);
			return;
		}
		if (player.IsMe)
		{
			long int64_ = CoreCollector.DAF.LevelAreaAddress;
			if (int64_ != 0L)
			{
				areaSnoEncrypted = GameWindowManager.Read<uint>(int64_ + Constants.LevelArea_AreaSno_Offset);
			}
			player.SnoArea = SnoData.Areas.GetSnoArea(areaSnoEncrypted);
			return;
		}
		fixed (r_PlayerData* rawPlayerData = &player.RawPlayerData)
		{
			byte* ptr = (byte*)rawPlayerData;
			ptr += Constants.PlayerData_HostAreaSno_Offset;
			areaSnoEncrypted = *(uint*)ptr;
		}
		if (SnoData.Areas.GetSnoArea(areaSnoEncrypted) != null)
		{
			player.SnoArea = dummy_snoarea_unknown;
		}
		else
		{
			player.SnoArea = null;
		}
	}

	static Custom()
	{
		dummy_snoarea_unknown = new UnknownSnoArea();
	}
}

internal class Map
{
	public readonly int int_0;

	[CompilerGenerated]
	private long long_0;

	private long long_1;

	internal long[] long_2;

	private int mask;

	public bool bool_0;

	[CompilerGenerated]
	private int maxIndex;

	private r_Map[] struct16_0 = new r_Map[1];

	public readonly Allocator class351_0;

	public long Int64_0
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		private set
		{
			long_0 = value;
		}
	}

	public int MaxIndex
	{
		[CompilerGenerated]
		get
		{
			return maxIndex;
		}
		[CompilerGenerated]
		private set
		{
			maxIndex = value;
		}
	}

	public Map(int int_3, bool bool_1 = true)
	{
		int_0 = int_3;
		if (bool_1)
		{
			class351_0 = new Allocator(int_3, "EntryAllocator");
		}
	}

	public void SetAddress(long long_3)
	{
		Int64_0 = long_3;
		bool_0 = long_3 != 0;
		long_1 = long_3 + 28;
		if (bool_0)
		{
			struct16_0[0] = GameWindowManager.Read<r_Map>(long_3);
			MaxIndex = struct16_0[0].MaxIndex;
			mask = struct16_0[0].Mask;
			if (MaxIndex < -1 || MaxIndex > int_0)
			{
				MaxIndex = int_0;
			}
		}
		else
		{
			MaxIndex = -1;
		}
		if (class351_0 != null)
		{
			class351_0.Snapshot(struct16_0[0].PtrBucketAllocator);
			return;
		}
		if (long_2 == null || long_2.Length < MaxIndex + 1 || MaxIndex == 0)
		{
			long_2 = new long[MaxIndex + 1];
		}
		if (MaxIndex > -1)
		{
			long_2 = GameWindowManager.ReadArray<long>(long_1, MaxIndex + 1);
		}
	}

	public long GetBucketAddress(uint uint_0)
	{
		uint num = uint_0 ^ (uint_0 >> 12);
		int num2 = (int)(mask & num);
		if (long_2 != null && num2 > 0 && num2 <= MaxIndex)
		{
			return long_2[num2];
		}
		return GameWindowManager.Read<long>(long_1 + num2 * 8);
	}
}

public class Quest(SnoQuest isnoQuest_1)
{
	private readonly Stopwatch iwatch_2 = new();

	public SnoQuest SnoQuest { get; set; } = isnoQuest_1;

	public int CreatedOn { get; set; }

	public uint QuestStepId { get; set; }

	public SnoQuestStep QuestStep { get; set; }

	public QuestState State { get; set; }

	public Stopwatch CompletedOn { get; } = new Stopwatch();

	public Stopwatch StartedOn { get; } = new Stopwatch();

	public float Progress { get; set; }

	public int Counter { get; set; }

	public override string ToString()
	{
		return SnoQuest.NameLocalized + " (" + SnoQuest.Type.ToString() + ")" + ((QuestStep != null) ? (", step#" + QuestStep.Id) : null) + ", " + State;
	}

	public bool IsFinished(uint stepId)
	{
		bool flag = false;
		if (stepId != uint.MaxValue) {
			if (QuestStep != null && QuestStep.Id != stepId) {
				flag = true;
			}
		} else if (State == QuestState.completed) {
			flag = true;
		}
		if (flag) {
			iwatch_2.Start();
			if (iwatch_2.ElapsedMilliseconds > 2000) {
				return true;
			}
		}
		return false;
	}
}

public class Scene
{
	public SnoScene SnoScene { get; set; }

	public SnoArea SnoArea { get; set; }

	public uint WorldSno { get; set; }

	public uint NavMeshId { get; set; }

	public uint SceneId { get; set; }

	public float PosX { get; set; }

	public float PosY { get; set; }

	public float MaxX { get; set; }

	public float MaxY { get; set; }

	public float W { get; set; }

	public float H { get; set; }

	public float Z { get; set; }

	public string CalculatedPosId { get; set; }

	public uint UInt32_0 { get; set; }

	public Scene(SnoScene isnoScene_1, SnoArea isnoArea_1, uint uint_4, uint sSceneID, uint uint_6, float meshMinX, float meshMinY, float meshMaxX, float meshMaxY, float meshMaxZ)
	{
		SnoScene = isnoScene_1;
		SnoArea = isnoArea_1;
		WorldSno = uint_4;
		NavMeshId = sSceneID;
		SceneId = uint_6;
		PosX = meshMinX;
		PosY = meshMinY;
		MaxX = meshMaxX;
		MaxY = meshMaxY;
		Z = meshMaxZ;
		W = MaxX - PosX;
		H = MaxY - PosY;
		CalculatedPosId = PosX.ToString(CultureInfo.InvariantCulture) + PosY.ToString(CultureInfo.InvariantCulture);
	}
}

public sealed class Scenes
{
	private readonly Dictionary<uint, SnoScene> allScenes = new Dictionary<uint, SnoScene>(3000);

	public IEnumerable<SnoScene> AllScenes => allScenes.Values;

	public SnoScene GetScene(uint sno)
	{
		allScenes.TryGetValue(sno, out var value);
		return value;
	}

	internal Scenes()
	{
		using (DataReader dataReader = new DataReader(File.ReadAllBytes(Path.Combine(Program.AppDir, "data", "scene.bin"))))
		{
			while (dataReader.Stream.Position < dataReader.Stream.Length)
			{
				uint num = dataReader.ReadUInt32();
				int int_ = (int)dataReader.ReadPackedInt64();
				int int_2 = dataReader.ReadPackedInt32();
				int int_3 = dataReader.ReadPackedInt32();
				int int_4 = dataReader.ReadPackedInt32();
				int int_5 = dataReader.ReadPackedInt32();
				int int_6 = (int)dataReader.ReadPackedInt64();
				string string_ = dataReader.ReadString();
				SnoScene value = new SnoScene(num, int_, int_2, int_3, int_4, int_5, int_6, string_);
				allScenes.Add(num, value);
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
				SnoScene scene = GetScene(sno);
				if (scene != null)
				{
					(scene as SnoScene).Hint = new SceneHint(string_2);
				}
			}
		}
	}
}

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
