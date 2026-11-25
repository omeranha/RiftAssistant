using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace RiftAssistant.Collectors;

internal class SceneCollector
{
	private readonly Dictionary<uint, Dictionary<uint, Scene>> scenesByKeysByKey = new Dictionary<uint, Dictionary<uint, Scene>>();

	private readonly Dictionary<uint, uint> dictionary_1 = new Dictionary<uint, uint>();

	public List<SceneHint> SceneHints = new List<SceneHint>();

	private readonly Allocator allocator = new Allocator(8192, "SceneRevealInfoAllocator");

	private readonly AllocationCache<r_SceneRevealInfo> class352_0 = new AllocationCache<r_SceneRevealInfo>(88);

	internal r_Scene[] Buffer_Scenes { get; private set; } = null!;

	internal r_World[] Buffer_Worlds { get; private set; } = null!;

	public IEnumerable<Scene> GetScenes(uint worldId)
	{
		if (scenesByKeysByKey.TryGetValue(worldId, out var value))
		{
			return value.Values;
		}
		return Enumerable.Empty<Scene>();
	}

	public Scene? GetScene(uint worldId, uint sSceneIDEncrypted)
	{
		if (scenesByKeysByKey.TryGetValue(worldId, out var value) && value.TryGetValue(sSceneIDEncrypted, out var value2))
		{
			return value2;
		}
		return null;
	}

	public uint GetWorldSno(uint worldId)
	{
		if (dictionary_1.TryGetValue(worldId, out var value))
		{
			return value;
		}
		return 0u;
	}

	internal bool Collect()
	{
		int num = CoreCollector.D3Memory.SceneContainer.MaxIndex + 1;
		if (Buffer_Scenes == null || Buffer_Scenes.Length != num)
		{
			Buffer_Scenes = new r_Scene[num];
		}
		if (num > 0)
		{
			Buffer_Scenes = GameWindowManager.ReadArray<r_Scene>(CoreCollector.D3Memory.SceneContainer.DataAddress, num);

		}
		num = CoreCollector.D3Memory.WorldContainer.MaxIndex + 1;
		if (Buffer_Worlds == null || Buffer_Worlds.Length != num)
		{
			Buffer_Worlds = new r_World[num];
		}
		if (num > 0)
		{
			Buffer_Worlds = GameWindowManager.ReadArray<r_World>(CoreCollector.D3Memory.WorldContainer.DataAddress, num);
		}
		for (int i = 0; i < Buffer_Worlds.Length; i++)
		{
			uint sWorldID = Buffer_Worlds[i].SWorldID;
			if (sWorldID != uint.MaxValue)
			{
				dictionary_1[sWorldID] = Buffer_Worlds[i].WorldSno;
			}
		}
		for (int j = 0; j < Buffer_Scenes.Length; j++)
		{
			r_Scene r_Scene2 = Buffer_Scenes[j];
			if (r_Scene2.Id == uint.MaxValue || r_Scene2.LevelAreaSNO == uint.MaxValue)
			{
				continue;
			}
			SnoArea? snoArea = SnoData.Areas.GetSnoArea(r_Scene2.LevelAreaSNO);
			if (snoArea == null)
			{
				continue;
			}
			if (scenesByKeysByKey.TryGetValue(r_Scene2.SWorldID, out var value) && value != null)
			{
				if (value.TryGetValue(r_Scene2.SSceneID, out var value2) && value2 != null)
				{
					if (value2.PosX == r_Scene2.mesh_min_x && value2.PosY == r_Scene2.mesh_min_y && value2.SnoScene.Sno == r_Scene2.SceneSno && value2.Z == r_Scene2.mesh_max_z)
					{
						if (value2.SnoArea == null)
						{
							value.Remove(r_Scene2.SSceneID);
							value2 = null;
						}
					}
					else
					{
						value.Remove(r_Scene2.SSceneID);
						value2 = null;
					}
				}
				if (value2 != null)
				{
					continue;
				}
			}
			else
			{
				value = new Dictionary<uint, Scene>();
				scenesByKeysByKey.Add(r_Scene2.SWorldID, value);
			}
			SnoScene? scene = SnoData.Scenes.GetScene(r_Scene2.SceneSno);
			if (scene != null)
			{
				uint uint_ = GetWorldSno(r_Scene2.SWorldID);
				Scene value3 = new Scene(scene, snoArea, uint_, r_Scene2.SSceneID, r_Scene2.Id, r_Scene2.mesh_min_x, r_Scene2.mesh_min_y, r_Scene2.mesh_max_x, r_Scene2.mesh_max_y, r_Scene2.mesh_max_z);
				value.Add(r_Scene2.SSceneID, value3);
			}
		}
		if (CoreCollector.DAF.LevelAreaAddress != 0L)
		{
			long address = CoreCollector.DAF.LevelAreaAddress + 32 + 32;
			allocator.Snapshot(address);
			if (allocator.RawAllocator.ElementSize == 88)
			{
				class352_0.Snapshot(allocator);
				foreach (r_SceneRevealInfo item in class352_0.GetItems())
				{
					if (item.sSceneID == uint.MaxValue || item.uint_3 == uint.MaxValue)
					{
						continue;
					}
					if (scenesByKeysByKey.TryGetValue(item.uint_2, out var value4) && value4 != null)
					{
						if (value4.TryGetValue(item.sSceneID, out var value5) && value5 != null && (value5.PosX != item.meshMinX || value5.PosY != item.meshMinY || value5.SnoScene.Sno != item.sno))
						{
							value4.Remove(item.sSceneID);
							value5 = null;
						}
						if (value5 != null)
						{
							continue;
						}
					}
					else
					{
						value4 = new Dictionary<uint, Scene>();
						scenesByKeysByKey.Add(item.uint_2, value4);
					}
					SnoScene? scene2 = SnoData.Scenes.GetScene(item.sno);
					if (scene2 != null)
					{
						uint worldSno = GetWorldSno(item.uint_2);
						Scene value6 = new Scene(scene2, null, worldSno, item.sSceneID, 0u, item.meshMinX, item.meshMinY, item.meshMaxX, item.meshMaxY, 0f);
						value4.Add(item.sSceneID, value6);
					}
				}
			}
		}
		return true;
	}

	public void Clear()
	{
		scenesByKeysByKey.Clear();
		dictionary_1.Clear();
	}

	internal void GenerateSceneHints()
	{
		SceneHints.Clear();
		if (CoreCollector.LocalPlayer?.SnoArea == null || CoreCollector.LocalPlayer.SnoArea.Code.StartsWith("x1_lr_level_", ignoreCase: false, CultureInfo.InvariantCulture))
		{
			return;
		}
		foreach (Scene item in GetScenes(CoreCollector.LocalPlayer.WorldId))
		{
			if (item.SnoScene.Hint == null)
			{
				continue;
			}
			bool flag = false;
			foreach (Portal item2 in CoreCollector.ActorCollector.PortalsByAnnId.Values)
			{
				if (item2.Scene != null && (item2.Scene.SnoScene == item.SnoScene || (item2.Scene.PosX <= item.PosX && item2.Scene.PosY <= item.PosY && item2.Scene.W >= item.W && item2.Scene.H >= item.H)))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				float num = item.PosX + item.W / 2f;
				float num2 = item.PosY + item.H / 2f;
				if (item.SnoScene.Hint.FloorCoordinate == null)
				{
					(item.SnoScene.Hint as SceneHint).FloorCoordinate = Window.CreateWorldCoordinate(num, num2, 0f);
				}
				else
				{
					item.SnoScene.Hint.FloorCoordinate.Set(num, num2, 0f);
				}
				SceneHints.Add(item.SnoScene.Hint);
			}
		}
	}
}
