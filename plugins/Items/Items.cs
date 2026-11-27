using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Plugins.Default;

public class Items : BasePlugin, IInGameWorldPainter, ILootGeneratedHandler
{
	public WorldDecoratorCollection LegendaryDecorator { get; set; }
	public WorldDecoratorCollection AncientDecorator { get; set; }
	public WorldDecoratorCollection PrimalDecorator { get; set; }
	public WorldDecoratorCollection SetDecorator { get; set; }
	public WorldDecoratorCollection AncientSetDecorator { get; set; }
	public WorldDecoratorCollection PrimalSetDecorator { get; set; }
	public WorldDecoratorCollection UtilityDecorator { get; set; }
	public WorldDecoratorCollection NormalKeepDecorator { get; set; }
	public WorldDecoratorCollection MagicKeepDecorator { get; set; }
	public WorldDecoratorCollection RareKeepDecorator { get; set; }
	public WorldDecoratorCollection LegendaryKeepDecorator { get; set; }
	public WorldDecoratorCollection BookDecorator { get; set; }
	public WorldDecoratorCollection DeathsBreathDecorator { get; set; }
	public WorldDecoratorCollection InArmorySetDecorator { get; set; }

	public bool EnableCustomSpeak { get; set; }
	public Dictionary<SnoItem, string> CustomSpeakTable { get; } = new Dictionary<SnoItem, string>();

	public bool EnableSpeakLegendary { get; set; }
	public bool EnableSpeakAncient { get; set; }
	public bool EnableSpeakPrimal { get; set; }
	public bool EnableSpeakSet { get; set; }
	public bool EnableSpeakAncientSet { get; set; }
	public bool EnableSpeakPrimalSet { get; set; }

	public Items()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		CustomSpeakTable.Add(Assistant.Sno.SnoItems.x1_Diamond_10, "x");

		LegendaryDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 235, 120, 0, -2),
				Radius = 1.5f,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 0, 0, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(0, 0, 0, 0, 0),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 235, 120, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 160, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 8,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		AncientDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 140, 0, -3),
				Radius = 2.2f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 500),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 255, 140, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(160, 0, 0, 0, -1),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 0, 0, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 120, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 11,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		PrimalDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 140, 0, -3),
				Radius = 2.2f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 500),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 255, 140, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(242, 255, 0, 0, 1),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 0, 0, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 120, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 11,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		SetDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 50, 220, 50, -2),
				Radius = 1.5f,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 0, 0, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(0, 0, 0, 0, 0),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 0, 170, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 160, 255, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 8,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		AncientSetDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 85, 255, 85, -3),
				Radius = 2.2f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 500),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 50, 220, 50, 0),
				BorderBrush = Assistant.Render.CreateBrush(160, 0, 0, 0, -1),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 0, 0, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 120, 255, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 11,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		PrimalSetDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 85, 255, 85, -3),
				Radius = 2.2f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 500),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(160, 50, 220, 50, 0),
				BorderBrush = Assistant.Render.CreateBrush(242, 255, 0, 0, 1),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 0, 0, 0, true, false, false)
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 120, 255, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 11,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		UtilityDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 160, 0, -3),
				Radius = 1.5f,
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new RotatingTriangleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 160, 0, 3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 8,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		NormalKeepDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 200, 200, 200, -2),
				Radius = 1.25f,
			}
			) {
			Enabled = false
		};

		MagicKeepDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 60, 60, 255, -2),
				Radius = 1.25f,
			}
			) {
			Enabled = false
		};

		RareKeepDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 255, 0, -2),
				Radius = 1.25f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new CircleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 255, 0, 0),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 6,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			) {
			Enabled = false
		};

		LegendaryKeepDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 235, 120, 0, -2),
				Radius = 1.25f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new CircleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 160, 0, 0),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 6,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 333),
			}
			);

		BookDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 0, 255, 0, -2),
				Radius = 1.0f,
			}
			);

		DeathsBreathDecorator = new WorldDecoratorCollection(
			new MapTextureDecorator(Assistant) {
				SnoItem = Assistant.Inventory.GetSnoItem(2087837753),
				Radius = 0.6f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 500) {
					RadiusMinimumMultiplier = 0.8f,
				},
			}
			);

		InArmorySetDecorator = new WorldDecoratorCollection(
			new GroundShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 64, 64, -3),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				ShapePainter = WorldStarShapePainter.NewCross(Assistant),
				Radius = 4.5f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 400, 0.8f, 1.0f),
				RotationTransformator = new CircularRotationTransformator(Assistant, 30),
			},
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 255, 64, 64, -3),
				Radius = 4.5f,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 400, 0.8f, 1.0f),
			},
			new MapShapeDecorator(Assistant) {
				ShapePainter = new CircleShapePainter(Assistant),
				Brush = Assistant.Render.CreateBrush(255, 255, 64, 64, -1),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 14,
				RadiusTransformator = new StandardPingRadiusTransformator(Assistant, 400, 0.8f, 1.0f),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 255, 0, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
				TextFont = Assistant.Render.CreateFont("tahoma", 7, 255, 255, 255, 255, true, false, false)
			}
			);
	}

	private string GetItemName(Item item)
	{
		var name = (item.RareName != null ? item.RareName + ", " : null) + item.FullNameLocalized;

		if (item.KeepDecision == ItemKeepDecision.LooksGood) {
			name += " [!]";
		}

		return name;
	}

	public void PaintWorld(WorldLayer layer)
	{
		foreach (var item in Assistant.Game.Items) {
			if (item.Location != ItemLocation.Floor)
				continue;

			var armorySet = Array.Find(Assistant.Game.LocalPlayer.ArmorySets, set => set.ContainsItem(item));
			if (armorySet != null) {
				InArmorySetDecorator.Paint(layer, item, item.FloorCoordinate, armorySet.Name);
				continue;
			}

			string name = null;

			var legendaryDisplayed = false;
			if (item.IsLegendary && item.Unidentified && (item.SnoItem.Kind != ItemKind.craft)) {
				legendaryDisplayed = true;
				if (item.SetSno != uint.MaxValue) {
					switch (item.AncientRank) {
						case 1:
							PaintItem(AncientSetDecorator, layer, item, ref name);
							break;
						case 2:
							PaintItem(PrimalSetDecorator, layer, item, ref name);
							break;
						default:
							PaintItem(SetDecorator, layer, item, ref name);
							break;
					}
				} else {
					switch (item.AncientRank) {
						case 1:
							PaintItem(AncientDecorator, layer, item, ref name);
							break;
						case 2:
							PaintItem(PrimalDecorator, layer, item, ref name);
							break;
						default:
							PaintItem(LegendaryDecorator, layer, item, ref name);
							break;
					}
				}
			}

			if (item.SnoItem.HasGroupCode("uber") || item.SnoItem.HasGroupCode("riftkeystone")) {
				PaintItem(UtilityDecorator, layer, item, ref name);
			}

			if (item.SnoItem.Sno == 2087837753) {
				PaintItem(DeathsBreathDecorator, layer, item, ref name);
				continue;
			}

			if (item.IsNormal && (item.KeepDecision == ItemKeepDecision.LooksGood)) {
				PaintItem(NormalKeepDecorator, layer, item, ref name);
			} else if (item.IsMagic && (item.KeepDecision == ItemKeepDecision.LooksGood)) {
				PaintItem(MagicKeepDecorator, layer, item, ref name);
			} else if (item.IsRare && (item.KeepDecision == ItemKeepDecision.LooksGood)) {
				PaintItem(RareKeepDecorator, layer, item, ref name);
			} else if (item.IsLegendary && (item.KeepDecision == ItemKeepDecision.LooksGood) && !legendaryDisplayed) {
				PaintItem(LegendaryKeepDecorator, layer, item, ref name);
			}

			if (!Assistant.Game.IsInTown) {
				if (item.SnoItem.Kind == ItemKind.book) {
					PaintItem(BookDecorator, layer, item, ref name);
				}
			}
		}
	}

	private void PaintItem(WorldDecoratorCollection decorator, WorldLayer layer, Item item, ref string name)
	{
		decorator.Paint(layer, item, item.FloorCoordinate, name ??= GetItemName(item));
	}

	private void Speak(Item item, string customText = null)
	{
		var text = customText ?? item.SnoItem.NameLocalized;
		Assistant.Sound.Speak(text);
		item.LastSpeak = Stopwatch.StartNew();
	}

	public void OnLootGenerated(Item item, bool gambled)
	{
		if (item.LastSpeak != null)
			return;
		if (!Assistant.Sound.LastSpeak.TimerTest(5000))
			return;

		if (EnableCustomSpeak && CustomSpeakTable.ContainsKey(item.SnoItem)) {
			var customText = CustomSpeakTable[item.SnoItem];
			Speak(item, customText);
			return;
		}

		if (item.Quality == ItemQuality.Legendary) {
			if (item.SetSno != uint.MaxValue) {
				switch (item.AncientRank) {
					case 1:
						if (EnableSpeakAncientSet)
							Speak(item);
						break;
					case 2:
						if (EnableSpeakPrimalSet)
							Speak(item);
						break;
					default:
						if (EnableSpeakSet)
							Speak(item);
						break;
				}
			} else {
				switch (item.AncientRank) {
					case 1:
						if (EnableSpeakAncient)
							Speak(item);
						break;
					case 2:
						if (EnableSpeakPrimal)
							Speak(item);
						break;
					default:
						if (EnableSpeakLegendary)
							Speak(item);
						break;
				}
			}
		}
	}
}
