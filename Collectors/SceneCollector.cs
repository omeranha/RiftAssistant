using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using SNO;
using work;

namespace collectors;

internal class SceneCollector
{
	private readonly Dictionary<uint, Dictionary<uint, IScene>> dictionary_0 = new Dictionary<uint, Dictionary<uint, IScene>>();

	private readonly Dictionary<uint, uint> dictionary_1 = new Dictionary<uint, uint>();

	public List<ISceneHint> list_0 = new List<ISceneHint>();

	private readonly Allocator class351_0 = new Allocator(8192, "SceneRevealInfoAllocator");

	private readonly AllocationCache<r_SceneRevealInfo> class352_0 = new AllocationCache<r_SceneRevealInfo>(ReadProcessMemory_1, 88);

	internal r_Scene[] Buffer_Scenes { get; private set; }

	internal r_World[] Buffer_Worlds { get; private set; }

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_Scene struct22_1, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	private static extern bool ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, ref r_SceneRevealInfo struct21_0, int int_0, int int_1);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	private static extern bool ReadProcessMemory_2(IntPtr intptr_0, IntPtr intptr_1, ref r_World struct38_1, int int_0, int int_1);

	public IEnumerable<IScene> method_0(uint uint_0)
	{
		if (dictionary_0.TryGetValue(uint_0, out var value))
		{
			return value.Values;
		}
		return Enumerable.Empty<IScene>();
	}

	public IScene method_1(uint uint_0, uint uint_1)
	{
		if (dictionary_0.TryGetValue(uint_0, out var value) && value.TryGetValue(uint_1, out var value2))
		{
			return value2;
		}
		return null;
	}

	public uint method_2(uint uint_0)
	{
		if (dictionary_1.TryGetValue(uint_0, out var value))
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
			ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)CoreCollector.D3Memory.SceneContainer.DataAddress, ref Buffer_Scenes[0], 1976 * num, 0);
		}
		num = CoreCollector.D3Memory.WorldContainer.MaxIndex + 1;
		if (Buffer_Worlds == null || Buffer_Worlds.Length != num)
		{
			Buffer_Worlds = new r_World[num];
		}
		if (num > 0)
		{
			ReadProcessMemory_2(MR.Instance.ProcessHandle, (IntPtr)CoreCollector.D3Memory.WorldContainer.DataAddress, ref Buffer_Worlds[0], 152 * num, 0);
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
			ISnoArea snoArea = SnoData.Areas.GetSnoArea(r_Scene2.LevelAreaSNO);
			if (snoArea == null)
			{
				continue;
			}
			if (dictionary_0.TryGetValue(r_Scene2.SWorldID, out var value) && value != null)
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
				value = new Dictionary<uint, IScene>();
				dictionary_0.Add(r_Scene2.SWorldID, value);
			}
			ISnoScene scene = SnoData.Scenes.GetScene(r_Scene2.SceneSno);
			if (scene != null)
			{
				uint uint_ = method_2(r_Scene2.SWorldID);
				IScene value3 = new Scene(scene, snoArea, uint_, r_Scene2.SSceneID, r_Scene2.Id, r_Scene2.mesh_min_x, r_Scene2.mesh_min_y, r_Scene2.mesh_max_x, r_Scene2.mesh_max_y, r_Scene2.mesh_max_z);
				value.Add(r_Scene2.SSceneID, value3);
			}
		}
		if (CoreCollector.DAF.LevelAreaAddress != 0L)
		{
			long address = CoreCollector.DAF.LevelAreaAddress + 32 + 32;
			class351_0.Snapshot(address);
			if (class351_0.RawAllocator.ElementSize == 88)
			{
				class352_0.Snapshot(class351_0);
				foreach (r_SceneRevealInfo item in class352_0.GetItems())
				{
					if (item.uint_1 == uint.MaxValue || item.uint_3 == uint.MaxValue)
					{
						continue;
					}
					if (dictionary_0.TryGetValue(item.uint_2, out var value4) && value4 != null)
					{
						if (value4.TryGetValue(item.uint_1, out var value5) && value5 != null && (value5.PosX != item.float_0 || value5.PosY != item.float_1 || value5.SnoScene.Sno != item.uint_0))
						{
							value4.Remove(item.uint_1);
							value5 = null;
						}
						if (value5 != null)
						{
							continue;
						}
					}
					else
					{
						value4 = new Dictionary<uint, IScene>();
						dictionary_0.Add(item.uint_2, value4);
					}
					ISnoScene scene2 = SnoData.Scenes.GetScene(item.uint_0);
					if (scene2 != null)
					{
						uint uint_2 = method_2(item.uint_2);
						IScene value6 = new Scene(scene2, null, uint_2, item.uint_1, 0u, item.float_0, item.float_1, item.float_2, item.float_3, 0f);
						value4.Add(item.uint_1, value6);
					}
				}
			}
		}
		return true;
	}

	public void method_4()
	{
		dictionary_0.Clear();
		dictionary_1.Clear();
	}

	internal void GenerateSceneHints()
	{
		list_0.Clear();
		if (CoreCollector.LocalPlayer?.SnoArea == null || CoreCollector.LocalPlayer.SnoArea.Code.StartsWith("x1_lr_level_", ignoreCase: false, CultureInfo.InvariantCulture))
		{
			return;
		}
		foreach (IScene item in method_0(CoreCollector.LocalPlayer.WorldId))
		{
			if (item.SnoScene.Hint == null)
			{
				continue;
			}
			bool flag = false;
			foreach (IPortal item2 in CoreCollector.ActorCollector.Class112_1.IEnumerable_0)
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
					(item.SnoScene.Hint as SceneHint).FloorCoordinate = GameWindowManager.Window.CreateWorldCoordinate(num, num2, 0f);
				}
				else
				{
					item.SnoScene.Hint.FloorCoordinate.Set(num, num2, 0f);
				}
				list_0.Add(item.SnoScene.Hint);
			}
		}
	}
}
