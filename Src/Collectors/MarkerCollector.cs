#define TRACE
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;


namespace RiftAssistant.Collectors;

internal class MarkerCollector
{
	private readonly Map primaryMarkerMap = new Map(512);

	private readonly Map secondaryMarkerMap = new Map(512);

	private readonly Allocator trickleAllocator = new Allocator(2048, "IconAllocator");

	private readonly AllocationCache<r_MarkerEntry> primaryMarkerEntries = new AllocationCache<r_MarkerEntry>(Constants.MarkerEntry_SizeOf);

	private readonly AllocationCache<r_MarkerEntry> secondaryMarkerEntries = new AllocationCache<r_MarkerEntry>(Constants.MarkerEntry_SizeOf);

	private readonly AllocationCache<r_Trickle> trickleReader = new AllocationCache<r_Trickle>(Constants.Trickle_SizeOf);

	private readonly Dictionary<string, Banner> bannersByKey = new Dictionary<string, Banner>();

	private readonly Dictionary<string, Marker> markersByKey = new Dictionary<string, Marker>();

	private readonly Dictionary<string, Marker> markersByKey2 = new Dictionary<string, Marker>();

	private readonly Dictionary<string, Marker> markersByKey3 = new Dictionary<string, Marker>();

	private readonly Dictionary<string, Marker> markersByKey4 = new Dictionary<string, Marker>();

	public List<Marker> Markers = new List<Marker>();

	private readonly List<Marker> markers = new List<Marker>();

	public List<Banner> Banners = new List<Banner>();

	public WorldCoordinate? floorCoordinate;

	public readonly WorldCoordinate worldCoordinate = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate worldCoordinate2 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate worldCoordinate3 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate worldCoordinate4 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate worldCoordinate5 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public readonly WorldCoordinate worldCoordinate6 = Window.CreateWorldCoordinate(0f, 0f, 0f);

	public WorldCoordinate? worldCoordinate7;

	public WorldCoordinate? worldCoordinate8;

	private r_MinimapIcon[] minimapIcons = new r_MinimapIcon[256];

	private AreaContainer areaContainer = new AreaContainer();

	internal void Collect()
	{
		ClearMarkers(bool_0: false);
		if (CoreCollector.DAF.LevelAreaAddress == 0L) {
			Logger.Info("[ERROR] force daf scan due to missing LevelAreaAddress");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return;
		}
		areaContainer = GameWindowManager.Read<AreaContainer>(CoreCollector.DAF.LevelAreaAddress);
		primaryMarkerMap.SetAddress(areaContainer.PrimaryAreaPtr);
		secondaryMarkerMap.SetAddress(areaContainer.SecondaryAreaPtr);
		if (primaryMarkerMap.allocator.RawAllocator.ElementSize != 88) {
			Logger.Info("[ERROR] marker struct size mismatch: " + primaryMarkerMap.allocator.RawAllocator.ElementSize);
			return;
		}
		if (primaryMarkerMap.allocator.RawAllocator.GoodFood != CoreCollector.Magic_600DF00D) {
			Logger.Info("[ERROR] force daf scan due to invalid MarkerMapA");
			CoreCollector.DAF.ClearObjectManagerAddr();
			return;
		}
		primaryMarkerEntries.Snapshot(primaryMarkerMap.allocator);
		secondaryMarkerEntries.Snapshot(secondaryMarkerMap.allocator);
		floorCoordinate = null;
		foreach (r_MarkerEntry item in primaryMarkerEntries.GetItems()) {
			if (item.uint_0 == uint.MaxValue || item.marker0.worldPlace.WorldId != CoreCollector.LocalPlayer.WorldId) {
				continue;
			}
			string[] array = new string[7];
			int num = 0;
			array[num] = item.marker0.worldPlace.WorldId.ToString("D", CultureInfo.InvariantCulture);
			array[1] = "|";
			int num2 = 2;
			array[num2] = item.marker0.worldPlace.X.ToString("F0", CultureInfo.InvariantCulture);
			array[3] = "|";
			int num3 = 4;
			array[num3] = item.marker0.worldPlace.Y.ToString("F0", CultureInfo.InvariantCulture);
			array[5] = "|";
			int num4 = 6;
			array[num4] = item.marker0.worldPlace.Z.ToString("F0", CultureInfo.InvariantCulture);
			string text = string.Concat(array);
			if (item.marker0.sno == uint.MaxValue && item.marker0.uint_2 == uint.MaxValue) {
				continue;
			}
			if (item.marker0.sno != uint.MaxValue) {
				Quest? quest = CoreCollector.QuestManager.Quests.GetValueOrDefault(item.marker0.sno);
				if (quest != null && quest.State == QuestState.completed) {
					continue;
				}
			}
			Marker? marker = markersByKey.GetValueOrDefault(text);
			if (marker == null) {
				SnoQuest? isnoQuest_ = ((item.marker0.sno != uint.MaxValue) ? SnoData.Quests.GetQuest(item.marker0.sno) : null);
				SnoActor? SnoActor_ = ((item.marker0.uint_2 != uint.MaxValue) ? SnoData.Actors.GetActor((ActorSnoEnum)item.marker0.uint_2) : null);
				marker = new Marker(text, item.marker0.worldPlace.WorldId, isnoQuest_, SnoActor_, Window.CreateWorldCoordinate(item.marker0.worldPlace.X, item.marker0.worldPlace.Y, item.marker0.worldPlace.Z), item.marker0.texture.TextureSno, item.marker0.texture.FrameIndex);
				markersByKey[text] = marker;
			} else {
				marker.FloorCoordinate.Set(item.marker0.worldPlace.X, item.marker0.worldPlace.Y, item.marker0.worldPlace.Z);
			}
			Markers.Add(marker);
		}
		foreach (r_MarkerEntry item2 in secondaryMarkerEntries.GetItems()) {
			if (item2.uint_0 == uint.MaxValue || item2.marker0.worldPlace.WorldId != CoreCollector.LocalPlayer.WorldId) {
				continue;
			}
			string[] array2 = new string[7];
			int num5 = 0;
			array2[num5] = item2.marker0.worldPlace.WorldId.ToString("D", CultureInfo.InvariantCulture);
			array2[1] = "|";
			int num6 = 2;
			array2[num6] = item2.marker0.worldPlace.X.ToString("F0", CultureInfo.InvariantCulture);
			array2[3] = "|";
			int num7 = 4;
			array2[num7] = item2.marker0.worldPlace.Y.ToString("F0", CultureInfo.InvariantCulture);
			array2[5] = "|";
			int num8 = 6;
			array2[num8] = item2.marker0.worldPlace.Z.ToString("F0", CultureInfo.InvariantCulture);
			string text2 = string.Concat(array2);
			if (item2.marker0.texture.TextureSno != 275968 && item2.marker0.texture.TextureSno != 404424) {
				if (item2.marker0.texture.TextureSno != 451493 && item2.marker0.texture.TextureSno != 455279 && item2.marker0.texture.TextureSno != 451494 && item2.marker0.texture.TextureSno != 455278 && item2.marker0.texture.TextureSno != 451503 && item2.marker0.texture.TextureSno != 455277 && item2.marker0.texture.TextureSno != 451504 && item2.marker0.texture.TextureSno != 455280 && item2.marker0.texture.TextureSno != 451508 && item2.marker0.texture.TextureSno != 455276 && item2.marker0.texture.TextureSno != 218235 && item2.marker0.texture.TextureSno != 226820) {
					if (item2.marker0.sno == uint.MaxValue && item2.marker0.uint_2 == uint.MaxValue) {
						continue;
					}
					if (item2.marker0.sno != uint.MaxValue) {
						Quest? quest2 = CoreCollector.QuestManager.Quests.GetValueOrDefault(item2.marker0.sno);
						if (quest2 != null && quest2.State == QuestState.completed) {
							continue;
						}
					}
					Marker? marker2 = markersByKey.GetValueOrDefault(text2);
					if (marker2 == null) {
						SnoQuest? snoQuest = ((item2.marker0.sno != uint.MaxValue) ? SnoData.Quests.GetQuest(item2.marker0.sno) : null);
						SnoActor? snoActor = ((item2.marker0.uint_2 != uint.MaxValue) ? SnoData.Actors.GetActor((ActorSnoEnum)item2.marker0.uint_2) : null);
						marker2 = new Marker(text2, item2.marker0.worldPlace.WorldId, snoQuest, snoActor, Window.CreateWorldCoordinate(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z), item2.marker0.texture.TextureSno, item2.marker0.texture.FrameIndex);
						markersByKey[text2] = marker2;
					} else {
						marker2.FloorCoordinate.Set(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z);
					}
					Markers.Add(marker2);
					if (marker2.SnoActor == null) {
						continue;
					}
					if (marker2.SnoActor.Code.StartsWith("x1_lr_boss", ignoreCase: true, CultureInfo.InvariantCulture)) {
						floorCoordinate = marker2.FloorCoordinate;
					} else if (CoreCollector.LocalPlayer.SnoArea != null && (marker2.SnoActor.Sno == ActorSnoEnum._dunedervish_b_unique_uber || marker2.SnoActor.Sno == ActorSnoEnum._goatmutant_ranged_a_unique_uber || marker2.SnoActor.Sno == ActorSnoEnum._morluspellcaster_a_unique_uber || marker2.SnoActor.Sno == ActorSnoEnum._terrordemon_a_unique_uber)) {
						if (CoreCollector.ActorCollector.IWorldCoordinate_0 == null) {
							CoreCollector.ActorCollector.IWorldCoordinate_0 = Window.CreateWorldCoordinate(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z);
						} else {
							CoreCollector.ActorCollector.IWorldCoordinate_0.Set(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z);
						}
						CoreCollector.ActorCollector.Act2 = CoreCollector.LocalPlayer.SnoArea.Act;
					}
					continue;
				}
				SnoActor? actor2 = null;
				bool value = false;
				bool value2 = false;
				bool? flag = null;
				switch (item2.marker0.texture.TextureSno) {
					case 226820u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._shrine_global);
						value2 = true;
						break;
					case 218235u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._shrine_global);
						value2 = true;
						break;
					case 451494u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_damage);
						value = true;
						flag = false;
						break;
					case 451493u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_invulnerable);
						value = true;
						flag = false;
						break;
					case 451504u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_run_speed);
						value = true;
						flag = false;
						break;
					case 451503u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_electrified);
						value = true;
						flag = false;
						break;
					case 455276u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_infinite_casting);
						value = true;
						flag = true;
						break;
					case 455277u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_electrified);
						value = true;
						flag = true;
						break;
					case 455278u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_damage);
						value = true;
						flag = true;
						break;
					case 455279u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_invulnerable);
						value = true;
						flag = true;
						break;
					case 455280u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_run_speed);
						value = true;
						flag = true;
						break;
					case 451508u:
						actor2 = SnoData.Actors.GetActor(ActorSnoEnum._x1_lr_shrine_infinite_casting);
						value = true;
						flag = false;
						break;
				}
				Marker? marker3 = markersByKey.GetValueOrDefault(text2);
				if (marker3 == null) {
					marker3 = new Marker(text2, item2.marker0.worldPlace.WorldId, null, actor2, Window.CreateWorldCoordinate(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z), item2.marker0.texture.TextureSno, item2.marker0.texture.FrameIndex);
					markersByKey[text2] = marker3;
				} else {
					marker3.FloorCoordinate.Set(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z);
					marker3.TextureSno = item2.marker0.texture.TextureSno;
					marker3.TextureFrameIndex = item2.marker0.texture.FrameIndex;
				}
				marker3.IsPylon = value;
				marker3.IsShrine = value2;
				if (flag.HasValue) {
					marker3.IsUsed = flag.Value;
				}
				Markers.Add(marker3);
			} else {
				Marker? marker4 = markersByKey3.GetValueOrDefault(text2);
				if (marker4 == null) {
					marker4 = new Marker(text2, item2.marker0.worldPlace.WorldId, null, null, Window.CreateWorldCoordinate(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z), item2.marker0.texture.TextureSno, item2.marker0.texture.FrameIndex);
					markersByKey3[text2] = marker4;
				} else {
					marker4.FloorCoordinate.Set(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y, item2.marker0.worldPlace.Z);
				}
				markers.Add(marker4);
				float num9 = CoreCollector.LocalPlayer.FloorCoordinate.XYDistanceTo(item2.marker0.worldPlace.X, item2.marker0.worldPlace.Y);
				if (CoreCollector.ItemCollector.floorCoordinate == null || CoreCollector.ItemCollector.CentralXyDistanceToMe > (double)num9) {
					CoreCollector.ItemCollector.floorCoordinate = marker4.FloorCoordinate;
					CoreCollector.ItemCollector.CentralXyDistanceToMe = num9;
					CoreCollector.ItemCollector.ZDistanceToMeAbsolute = CoreCollector.LocalPlayer.FloorCoordinate.ZDiffTo(marker4.FloorCoordinate);
				}
			}
		}
		long num10 = GameWindowManager.Read<long>(CoreCollector.DAF.TrickleManagerAddress + AddressList.Offset_Trickle_Ptr8);
		long address = GameWindowManager.Read<long>(num10 + AddressList.Offset_Trickle_Ptr24);
		trickleAllocator.Snapshot(address);
		if (trickleAllocator.RawAllocator.ElementSize != Constants.Trickle_SizeOf) {
			Trace.WriteLine("icon struct size mismatch!");
			return;
		}
		trickleReader.Snapshot(trickleAllocator);
		worldCoordinate.Set(0f, 0f, 0f);
		worldCoordinate2.Set(0f, 0f, 0f);
		worldCoordinate3.Set(0f, 0f, 0f);
		worldCoordinate4.Set(0f, 0f, 0f);
		worldCoordinate5.Set(0f, 0f, 0f);
		worldCoordinate6.Set(0f, 0f, 0f);
		worldCoordinate7 = null;
		worldCoordinate8 = null;
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
					SnoMonster? monsterByStringId = SnoData.Monsters.GetMonsterByStringId(item3.StringLabelHandle);
					if (monsterByStringId != null && monsterByStringId.SnoActor.Code.StartsWith("x1_lr_boss", ignoreCase: true, CultureInfo.InvariantCulture)) {
						Marker? marker5 = markersByKey2.GetValueOrDefault(text3);
						if (marker5 == null) {
							marker5 = new Marker(text3, item3.WorldPlace.WorldId, null, monsterByStringId.SnoActor, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex);
							markersByKey2[text3] = marker5;
						} else {
							marker5.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						}
						Markers.Add(marker5);
						if (worldCoordinate8 == null || marker5.FloorCoordinate.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate) < worldCoordinate8.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate)) {
							if (worldCoordinate8 == null) {
								worldCoordinate8 = Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							} else {
								worldCoordinate8.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							}
						}
					}
				}
				if (item3.LevelAreaSno == (CoreCollector.LocalPlayer.SnoArea?.Sno ?? 0)) {
					switch (item3.StringLabelHandle) {
						case 1044782191u:
							worldCoordinate2.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 969248284u:
							worldCoordinate6.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 12492805u:
							worldCoordinate4.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 3587944101u:
							worldCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 1840484281u:
							worldCoordinate3.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
						case 1562485905u:
							worldCoordinate5.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
							break;
					}
				}
				ActorSnoEnum actorSno = (ActorSnoEnum)item3.ActorSno;
				if (actorSno == ActorSnoEnum._poolofreflection || actorSno == ActorSnoEnum._healthwell_global || actorSno == ActorSnoEnum._a4_heaven_healthwell_global) {
					Marker? marker6 = markersByKey4.GetValueOrDefault(text3);
					if (marker6 == null) {
						SnoActor? actor = SnoData.Actors.GetActor(actorSno);
						marker6 = new Marker(text3, item3.WorldPlace.WorldId, null, actor, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex) {
							IsPoolOfReflection = (actorSno == ActorSnoEnum._poolofreflection),
							IsHealingWell = (actorSno == ActorSnoEnum._healthwell_global || actorSno == ActorSnoEnum._a4_heaven_healthwell_global)
						};
						markersByKey4[text3] = marker6;
					} else {
						marker6.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						marker6.TextureSno = item3.ImageTextureFrame.TextureSno;
						marker6.TextureFrameIndex = item3.ImageTextureFrame.FrameIndex;
					}
					marker6.IsUsed = item3.ImageTextureFrame.TextureSno == 384218;
				}
				if (item3.ImageTextureFrame.TextureSno == 207630) {
					Marker? marker7 = markersByKey2.GetValueOrDefault(text3);
					if (marker7 == null) {
						marker7 = new Marker(text3, item3.WorldPlace.WorldId, null, null, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z), item3.ImageTextureFrame.TextureSno, item3.ImageTextureFrame.FrameIndex);
						markersByKey2[text3] = marker7;
					} else {
						marker7.FloorCoordinate.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
					}
					Markers.Add(marker7);
					if (worldCoordinate7 == null || marker7.FloorCoordinate.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate) < worldCoordinate7.XYDistanceTo(CoreCollector.LocalPlayer.FloorCoordinate)) {
						if (worldCoordinate7 == null) {
							worldCoordinate7 = Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
						} else {
							worldCoordinate7.Set(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z);
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
				Banner? banner = bannersByKey.GetValueOrDefault(gparam_);
				if (banner == null) {
					banner = new Banner(item3.AnnId, item3.WorldPlace.WorldId, Window.CreateWorldCoordinate(item3.WorldPlace.X, item3.WorldPlace.Y, item3.WorldPlace.Z));
					bannersByKey[gparam_] = banner;
				}
				Banners.Add(banner);
			}
		}
		Markers.AddRange(markersByKey4.Values.Where((Marker marker) => marker.WorldId == CoreCollector.LocalPlayer.WorldId));
		if (CoreCollector.UiElements.MinimapUiElement.Visible) {
			long num19 = CoreCollector.UiElements.MinimapUiElement.long_0 + 3252;
			minimapIcons = GameWindowManager.ReadArray<r_MinimapIcon>(num19, minimapIcons.Length);

			int count = CoreCollector.ActorCollector.AliveMonsters.Count;
			for (int num20 = 0; num20 < minimapIcons.Length; num20++) {
				uint uint_ = minimapIcons[num20].uint_0;
				if (uint_ == uint.MaxValue) {
					continue;
				}
				for (int num21 = 0; num21 < count; num21++) {
					Monster monster = CoreCollector.ActorCollector.AliveMonsters[num21];
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

	internal void ClearMarkers(bool bool_0)
	{
		Markers.Clear();
		markers.Clear();
		Banners.Clear();
		if (bool_0) {
			markersByKey3.Clear();
			markersByKey.Clear();
			markersByKey2.Clear();
			bannersByKey.Clear();
			markersByKey4.Clear();
		}
	}

	internal bool TrySetPlayerPositionFromTrickle(Player player)
	{
		foreach (r_Trickle item in trickleReader.GetItems()) {
			if (item.PlayerIndex == player.Index && item.WorldPlace.WorldId == CoreCollector.LocalPlayer.WorldId && item.TrickleInfoType == 3) {
				player.CollisionCoordinate.Set(item.WorldPlace.X, item.WorldPlace.Y, item.WorldPlace.Z);
				player.FloorCoordinate.Set(item.WorldPlace.X, item.WorldPlace.Y, item.WorldPlace.Z);
				ActorCollector.UpdateSceneContext(player, item.WorldPlace.WorldId, 0u);
				player.UpdateDistances();
				player.CoordinateKnown = true;
				if (!player.IsMe && player.SnoArea != null && CoreCollector.LocalPlayer.SnoArea != null) {
					player.SnoArea = CoreCollector.LocalPlayer.SnoArea;
				}
			}
		}
		return false;
	}

	internal void UpdateShrineMarker(Shrine shrine)
	{
		foreach (Marker item in markersByKey.Values) {
			if (item.IsShrine && item.FloorCoordinate.XYDistanceTo(shrine.FloorCoordinate) < 5f) {
				item.IsUsed = shrine.IsOperated;
				item.SnoActor = shrine.SnoActor;
				break;
			}
		}
	}
}
