#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using structs;
using Plugins;
using SNO;


namespace collectors;

internal class MarkerCollector
{
	private readonly Map class357_0 = new Map(512);

	private readonly Map class357_1 = new Map(512);

	private readonly Allocator class351_0 = new Allocator(2048, "IconAllocator");

	private readonly AllocationCache<r_MarkerEntry> class352_0 = new AllocationCache<r_MarkerEntry>(Constants.MarkerEntry_SizeOf);

	private readonly AllocationCache<r_MarkerEntry> class352_1 = new AllocationCache<r_MarkerEntry>(Constants.MarkerEntry_SizeOf);

	private readonly AllocationCache<r_Trickle> trickleReader = new AllocationCache<r_Trickle>(Constants.Trickle_SizeOf);

	private readonly Class112<string, Banner> class112_0 = new Class112<string, Banner>();

	private readonly Class112<string, Marker> class112_1 = new Class112<string, Marker>();

	private readonly Class112<string, Marker> class112_2 = new Class112<string, Marker>();

	private readonly Class112<string, Marker> class112_3 = new Class112<string, Marker>();

	private readonly Class112<string, Marker> class112_4 = new Class112<string, Marker>();

	public List<Marker> list_0 = new List<Marker>();

	private readonly List<Marker> list_1 = new List<Marker>();

	public List<Banner> list_2 = new List<Banner>();

	public WorldCoordinate iworldCoordinate_0;

	public readonly WorldCoordinate iworldCoordinate_1 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate iworldCoordinate_2 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate iworldCoordinate_3 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate iworldCoordinate_4 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate iworldCoordinate_5 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate iworldCoordinate_6 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public WorldCoordinate iworldCoordinate_7;

	public WorldCoordinate iworldCoordinate_8;

	private r_MinimapIcon[] struct19_0 = new r_MinimapIcon[256];

	private AreaContainer class66_0 = new AreaContainer();

	internal void Collect()
	{
		method_1(bool_0: false);
		if (CoreCollector.DAF.LevelAreaAddress == 0L) {
			Logger.Info("[ERROR] force daf scan due to missing LevelAreaAddress");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return;
		}
		class66_0 = GameWindowManager.Read<AreaContainer>(CoreCollector.DAF.LevelAreaAddress);
		class357_0.method_0(class66_0.PrimaryAreaPtr);
		class357_1.method_0(class66_0.SecondaryAreaPtr);
		if (class357_0.class351_0.RawAllocator.ElementSize != 88) {
			Logger.Info("[ERROR] marker struct size mismatch: " + class357_0.class351_0.RawAllocator.ElementSize);
			return;
		}
		if (class357_0.class351_0.RawAllocator.GoodFood != CoreCollector.Magic_600DF00D) {
			Logger.Info("[ERROR] force daf scan due to invalid MarkerMapA");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return;
		}
		class352_0.Snapshot(class357_0.class351_0);
		class352_1.Snapshot(class357_1.class351_0);
		iworldCoordinate_0 = null;
		foreach (r_MarkerEntry item in class352_0.GetItems()) {
			if (item.uint_0 == uint.MaxValue || item.struct17_0.struct37_0.WorldId != CoreCollector.LocalPlayer.WorldId) {
				continue;
			}
			string[] array = new string[7];
			int num = 0;
			array[num] = item.struct17_0.struct37_0.WorldId.ToString("D", CultureInfo.InvariantCulture);
			array[1] = "|";
			int num2 = 2;
			array[num2] = item.struct17_0.struct37_0.X.ToString("F0", CultureInfo.InvariantCulture);
			array[3] = "|";
			int num3 = 4;
			array[num3] = item.struct17_0.struct37_0.Y.ToString("F0", CultureInfo.InvariantCulture);
			array[5] = "|";
			int num4 = 6;
			array[num4] = item.struct17_0.struct37_0.Z.ToString("F0", CultureInfo.InvariantCulture);
			string text = string.Concat(array);
			if (item.struct17_0.uint_3 == uint.MaxValue && item.struct17_0.uint_2 == uint.MaxValue) {
				continue;
			}
			if (item.struct17_0.uint_3 != uint.MaxValue) {
				Quest quest = CoreCollector.Class376_0.class112_1[item.struct17_0.uint_3];
				if (quest != null && quest.State == QuestState.completed) {
					continue;
				}
			}
			Marker @class = class112_1[text];
			if (@class == null) {
				SnoQuest isnoQuest_ = ((item.struct17_0.uint_3 != uint.MaxValue) ? SnoData.Quests.GetQuest(item.struct17_0.uint_3) : null);
				SnoActor SnoActor_ = ((item.struct17_0.uint_2 != uint.MaxValue) ? SnoData.Actors.GetActor((ActorSnoEnum)item.struct17_0.uint_2) : null);
				@class = new Marker(text, item.struct17_0.struct37_0.WorldId, isnoQuest_, SnoActor_, Window.CreateWorldCoordinate(item.struct17_0.struct37_0.X, item.struct17_0.struct37_0.Y, item.struct17_0.struct37_0.Z), item.struct17_0.struct15_0.TextureSno, item.struct17_0.struct15_0.FrameIndex);
				class112_1.Set(text, @class);
			} else {
				@class.FloorCoordinate.Set(item.struct17_0.struct37_0.X, item.struct17_0.struct37_0.Y, item.struct17_0.struct37_0.Z);
			}
			list_0.Add(@class);
		}
		foreach (r_MarkerEntry item2 in class352_1.GetItems()) {
			if (item2.uint_0 == uint.MaxValue || item2.struct17_0.struct37_0.WorldId != CoreCollector.LocalPlayer.WorldId) {
				continue;
			}
			string[] array2 = new string[7];
			int num5 = 0;
			array2[num5] = item2.struct17_0.struct37_0.WorldId.ToString("D", CultureInfo.InvariantCulture);
			array2[1] = "|";
			int num6 = 2;
			array2[num6] = item2.struct17_0.struct37_0.X.ToString("F0", CultureInfo.InvariantCulture);
			array2[3] = "|";
			int num7 = 4;
			array2[num7] = item2.struct17_0.struct37_0.Y.ToString("F0", CultureInfo.InvariantCulture);
			array2[5] = "|";
			int num8 = 6;
			array2[num8] = item2.struct17_0.struct37_0.Z.ToString("F0", CultureInfo.InvariantCulture);
			string text2 = string.Concat(array2);
			if (item2.struct17_0.struct15_0.TextureSno != 275968 && item2.struct17_0.struct15_0.TextureSno != 404424) {
				if (item2.struct17_0.struct15_0.TextureSno != 451493 && item2.struct17_0.struct15_0.TextureSno != 455279 && item2.struct17_0.struct15_0.TextureSno != 451494 && item2.struct17_0.struct15_0.TextureSno != 455278 && item2.struct17_0.struct15_0.TextureSno != 451503 && item2.struct17_0.struct15_0.TextureSno != 455277 && item2.struct17_0.struct15_0.TextureSno != 451504 && item2.struct17_0.struct15_0.TextureSno != 455280 && item2.struct17_0.struct15_0.TextureSno != 451508 && item2.struct17_0.struct15_0.TextureSno != 455276 && item2.struct17_0.struct15_0.TextureSno != 218235 && item2.struct17_0.struct15_0.TextureSno != 226820) {
					if (item2.struct17_0.uint_3 == uint.MaxValue && item2.struct17_0.uint_2 == uint.MaxValue) {
						continue;
					}
					if (item2.struct17_0.uint_3 != uint.MaxValue) {
						Quest quest2 = CoreCollector.Class376_0.class112_1[item2.struct17_0.uint_3];
						if (quest2 != null && quest2.State == QuestState.completed) {
							continue;
						}
					}
					Marker class2 = class112_1[text2];
					if (class2 == null) {
						SnoQuest isnoQuest_2 = ((item2.struct17_0.uint_3 != uint.MaxValue) ? SnoData.Quests.GetQuest(item2.struct17_0.uint_3) : null);
						SnoActor SnoActor_2 = ((item2.struct17_0.uint_2 != uint.MaxValue) ? SnoData.Actors.GetActor((ActorSnoEnum)item2.struct17_0.uint_2) : null);
						class2 = new Marker(text2, item2.struct17_0.struct37_0.WorldId, isnoQuest_2, SnoActor_2, Window.CreateWorldCoordinate(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z), item2.struct17_0.struct15_0.TextureSno, item2.struct17_0.struct15_0.FrameIndex);
						class112_1.Set(text2, class2);
					} else {
						class2.FloorCoordinate.Set(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z);
					}
					list_0.Add(class2);
					if (class2.SnoActor == null) {
						continue;
					}
					if (class2.SnoActor.Code.StartsWith("x1_lr_boss", ignoreCase: true, CultureInfo.InvariantCulture)) {
						iworldCoordinate_0 = class2.FloorCoordinate;
					} else if (CoreCollector.LocalPlayer.SnoArea != null && (class2.SnoActor.Sno == ActorSnoEnum._dunedervish_b_unique_uber || class2.SnoActor.Sno == ActorSnoEnum._goatmutant_ranged_a_unique_uber || class2.SnoActor.Sno == ActorSnoEnum._morluspellcaster_a_unique_uber || class2.SnoActor.Sno == ActorSnoEnum._terrordemon_a_unique_uber)) {
						if (CoreCollector.ActorCollector.IWorldCoordinate_0 == null) {
							CoreCollector.ActorCollector.IWorldCoordinate_0 = Window.CreateWorldCoordinate(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z);
						} else {
							CoreCollector.ActorCollector.IWorldCoordinate_0.Set(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z);
						}
						CoreCollector.ActorCollector.Int32_2 = CoreCollector.LocalPlayer.SnoArea.Act;
					}
					continue;
				}
				SnoActor SnoActor_3 = null;
				bool value = false;
				bool value2 = false;
				bool? flag = null;
				switch (item2.struct17_0.struct15_0.TextureSno) {
					case 226820u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._shrine_global);
						value2 = true;
						break;
					case 218235u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._shrine_global);
						value2 = true;
						break;
					case 451494u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_damage);
						value = true;
						flag = false;
						break;
					case 451493u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_invulnerable);
						value = true;
						flag = false;
						break;
					case 451504u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_run_speed);
						value = true;
						flag = false;
						break;
					case 451503u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_electrified);
						value = true;
						flag = false;
						break;
					case 455276u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_infinite_casting);
						value = true;
						flag = true;
						break;
					case 455277u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_electrified);
						value = true;
						flag = true;
						break;
					case 455278u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_damage);
						value = true;
						flag = true;
						break;
					case 455279u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_invulnerable);
						value = true;
						flag = true;
						break;
					case 455280u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_run_speed);
						value = true;
						flag = true;
						break;
					case 451508u:
						SnoActor_3 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_infinite_casting);
						value = true;
						flag = false;
						break;
				}
				Marker class3 = class112_1[text2];
				if (class3 == null) {
					class3 = new Marker(text2, item2.struct17_0.struct37_0.WorldId, null, SnoActor_3, Window.CreateWorldCoordinate(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z), item2.struct17_0.struct15_0.TextureSno, item2.struct17_0.struct15_0.FrameIndex);
					class112_1.Set(text2, class3);
				} else {
					class3.FloorCoordinate.Set(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z);
					class3.TextureSno = item2.struct17_0.struct15_0.TextureSno;
					class3.TextureFrameIndex = item2.struct17_0.struct15_0.FrameIndex;
				}
				class3.IsPylon = value;
				class3.IsShrine = value2;
				if (flag.HasValue) {
					class3.IsUsed = flag.Value;
				}
				list_0.Add(class3);
			} else {
				Marker class4 = class112_3[text2];
				if (class4 == null) {
					class4 = new Marker(text2, item2.struct17_0.struct37_0.WorldId, null, null, Window.CreateWorldCoordinate(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z), item2.struct17_0.struct15_0.TextureSno, item2.struct17_0.struct15_0.FrameIndex);
					class112_3.Set(text2, class4);
				} else {
					class4.FloorCoordinate.Set(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y, item2.struct17_0.struct37_0.Z);
				}
				list_1.Add(class4);
				float num9 = CoreCollector.LocalPlayer.FloorCoordinate.XYDistanceTo(item2.struct17_0.struct37_0.X, item2.struct17_0.struct37_0.Y);
				if (CoreCollector.ItemCollector.iworldCoordinate_0 == null || CoreCollector.ItemCollector.double_0 > (double)num9) {
					CoreCollector.ItemCollector.iworldCoordinate_0 = class4.FloorCoordinate;
					CoreCollector.ItemCollector.double_0 = num9;
					CoreCollector.ItemCollector.double_1 = CoreCollector.LocalPlayer.FloorCoordinate.ZDiffTo(class4.FloorCoordinate);
				}
			}
		}
		long num10 = GameWindowManager.Read<long>(CoreCollector.DAF.TrickleManagerAddress + AddressList.long_14);
		long address = GameWindowManager.Read<long>(num10 + AddressList.long_15);
		class351_0.Snapshot(address);
		if (class351_0.RawAllocator.ElementSize != Constants.Trickle_SizeOf) {
			Trace.WriteLine("icon struct size mismatch!");
			return;
		}
		trickleReader.Snapshot(class351_0);
		iworldCoordinate_1.Set(0f, 0f, 0f);
		iworldCoordinate_2.Set(0f, 0f, 0f);
		iworldCoordinate_3.Set(0f, 0f, 0f);
		iworldCoordinate_4.Set(0f, 0f, 0f);
		iworldCoordinate_5.Set(0f, 0f, 0f);
		iworldCoordinate_6.Set(0f, 0f, 0f);
		iworldCoordinate_7 = null;
		iworldCoordinate_8 = null;
		foreach (r_Trickle item3 in trickleReader.GetItems()) {
			if (item3.AnnId == uint.MaxValue) {
				continue;
			}
			if (item3.WorldPlace.WorldId == CoreCollector.LocalPlayer.WorldId) {
				string[] array3 = new string[7];
				int num11 = 0;
				array3[num11] = item3.WorldPlace.WorldId.ToString("D", CultureInfo.InvariantCulture);
				array3[1] = "|";
				int num12 = 2;
				array3[num12] = item3.WorldPlace.X.ToString("F0", CultureInfo.InvariantCulture);
				array3[3] = "|";
				int num13 = 4;
				array3[num13] = item3.WorldPlace.Y.ToString("F0", CultureInfo.InvariantCulture);
				array3[5] = "|";
				int num14 = 6;
				array3[num14] = item3.WorldPlace.Z.ToString("F0", CultureInfo.InvariantCulture);
				string text3 = string.Concat(array3);
				if (item3.StringListSno == 61539) {
					SnoMonster monsterByStringId = SnoData.Monsters.GetMonsterByStringId(item3.StringLabelHandle);
					if (monsterByStringId != null && monsterByStringId.SnoActor.Code.StartsWith("x1_lr_boss", ignoreCase: true, CultureInfo.InvariantCulture)) {
						Marker class5 = class112_2[text3];
						if (class5 == null) {
							class5 = new Marker(text3, item3.WorldPlace.WorldId, null, monsterByStringId.SnoActor, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex);
							class112_2.Set(text3, class5);
						} else {
							class5.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						}
						list_0.Add(class5);
						if (iworldCoordinate_8 == null || class5.FloorCoordinate.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate) < iworldCoordinate_8.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate)) {
							if (iworldCoordinate_8 == null) {
								iworldCoordinate_8 = Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							} else {
								iworldCoordinate_8.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							}
						}
					}
				}
				if (item3.LevelAreaSno == (CoreCollector.LocalPlayer.SnoArea?.Sno ?? 0)) {
					switch (item3.StringLabelHandle) {
						case 1044782191u:
							iworldCoordinate_2.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 969248284u:
							iworldCoordinate_6.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 12492805u:
							iworldCoordinate_4.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 3587944101u:
							iworldCoordinate_1.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 1840484281u:
							iworldCoordinate_3.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 1562485905u:
							iworldCoordinate_5.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
					}
				}
				ActorSnoEnum actorSno = (ActorSnoEnum)item3.ActorSno;
				if (actorSno == ActorSnoEnum._poolofreflection || actorSno == ActorSnoEnum._healthwell_global || actorSno == ActorSnoEnum._a4_heaven_healthwell_global) {
					Marker class6 = class112_4[text3];
					if (class6 == null) {
						SnoActor actor = SnoData.Actors.GetActor(actorSno);
						class6 = new Marker(text3, item3.WorldPlace.WorldId, null, actor, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex) {
							IsPoolOfReflection = (actorSno == ActorSnoEnum._poolofreflection),
							IsHealingWell = (actorSno == ActorSnoEnum._healthwell_global || actorSno == ActorSnoEnum._a4_heaven_healthwell_global)
						};
						class112_4.Set(text3, class6);
					} else {
						class6.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						class6.TextureSno = item3.ImageTextureFrame.TextureSno;
						class6.TextureFrameIndex = item3.ImageTextureFrame.FrameIndex;
					}
					class6.IsUsed = item3.ImageTextureFrame.TextureSno == 384218;
				}
				if (item3.ImageTextureFrame.TextureSno == 207630) {
					Marker class7 = class112_2[text3];
					if (class7 == null) {
						class7 = new Marker(text3, item3.WorldPlace.WorldId, null, null, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex);
						class112_2.Set(text3, class7);
					} else {
						class7.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
					}
					list_0.Add(class7);
					if (iworldCoordinate_7 == null || class7.FloorCoordinate.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate) < iworldCoordinate_7.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate)) {
						if (iworldCoordinate_7 == null) {
							iworldCoordinate_7 = Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						} else {
							iworldCoordinate_7.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						}
					}
				}
			}
			if (item3.WorldPlace.WorldId == CoreCollector.LocalPlayer.WorldId && item3.TrickleFlags == 33) {
				string[] array4 = new string[7];
				int num15 = 0;
				array4[num15] = item3.WorldPlace.WorldId.ToString("D", CultureInfo.InvariantCulture);
				array4[1] = "|";
				int num16 = 2;
				array4[num16] = item3.WorldPlace.X.ToString("F0", CultureInfo.InvariantCulture);
				array4[3] = "|";
				int num17 = 4;
				array4[num17] = item3.WorldPlace.Y.ToString("F0", CultureInfo.InvariantCulture);
				array4[5] = "|";
				int num18 = 6;
				array4[num18] = item3.WorldPlace.Z.ToString("F0", CultureInfo.InvariantCulture);
				string gparam_ = string.Concat(array4);
				Banner class8 = class112_0[gparam_];
				if (class8 == null) {
					class8 = new Banner(item3.AnnId, item3.WorldPlace.WorldId, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z));
					class112_0.Set(gparam_, class8);
				}
				list_2.Add(class8);
			}
		}
		list_0.AddRange(class112_4.IEnumerable_0.Where((Marker Marker_0) => Marker_0.WorldId == CoreCollector.LocalPlayer.WorldId));
		if (CoreCollector.UiElements.class341_85.Visible) {
			long num19 = CoreCollector.UiElements.class341_85.long_0 + 3252;
			struct19_0 = GameWindowManager.ReadArray<r_MinimapIcon>(num19, struct19_0.Length);

			int count = CoreCollector.ActorCollector.list_1.Count;
			for (int num20 = 0; num20 < struct19_0.Length; num20++) {
				uint uint_ = struct19_0[num20].uint_0;
				if (uint_ == uint.MaxValue) {
					continue;
				}
				for (int num21 = 0; num21 < count; num21++) {
					Monster monster = CoreCollector.ActorCollector.list_1[num21];
					if (monster.AcdId == uint_) {
						(monster as Monster).IsQuestMonster = true;
						break;
					}
				}
			}
		}
		Player[] iPlayer_ = CoreCollector.PlayerCollector.PlayerSlots;
		foreach (Player player in iPlayer_) {
			if (player.IsInGame && !player.HasValidActor) {
				TrySetPlayerPositionFromTrickle(player as Player);
			}
		}
	}

	internal void method_1(bool bool_0)
	{
		list_0.Clear();
		list_1.Clear();
		list_2.Clear();
		if (bool_0) {
			class112_3.Clear();
			class112_1.Clear();
			class112_2.Clear();
			class112_0.Clear();
			class112_4.Clear();
		}
	}

	internal bool TrySetPlayerPositionFromTrickle(Player player)
	{
		foreach (r_Trickle item in trickleReader.GetItems()) {
			if (item.PlayerIndex == player.Index && item.WorldPlace.WorldId == CoreCollector.LocalPlayer.WorldId && item.TrickleInfoType == 3) {
				player.CollisionCoordinate.Set(item.WorldPlace.X, item.WorldPlace.Y, item.WorldPlace.Z);
				player.FloorCoordinate.Set(item.WorldPlace.X, item.WorldPlace.Y, item.WorldPlace.Z);
				ActorCollector.smethod_2(player, item.WorldPlace.WorldId, 0u);
				player.method_25();
				player.CoordinateKnown = true;
				if (!player.IsMe && player.SnoArea != null && CoreCollector.LocalPlayer.SnoArea != null) {
					player.SnoArea = CoreCollector.LocalPlayer.SnoArea;
				}
			}
		}
		return false;
	}

	internal void method_3(Shrine shrine)
	{
		foreach (Marker item in class112_1.IEnumerable_0) {
			if (item.IsShrine && item.FloorCoordinate.XYDistanceTo(shrine.FloorCoordinate) < 5f) {
				item.IsUsed = shrine.IsOperated;
				item.SnoActor = shrine.SnoActor;
				break;
			}
		}
	}
}
