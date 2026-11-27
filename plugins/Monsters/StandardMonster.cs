namespace Plugins.Default;

public class StandardMonster : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection TrashDecorator { get; set; }
	public WorldDecoratorCollection InvisibleDecorator { get; set; }
	public WorldDecoratorCollection EliteChampionDecorator { get; set; }
	public WorldDecoratorCollection EliteMinionDecorator { get; set; }
	public WorldDecoratorCollection EliteLeaderDecorator { get; set; }
	public WorldDecoratorCollection EliteUniqueDecorator { get; set; }
	public WorldDecoratorCollection KeywardenDecorator { get; set; }
	public WorldDecoratorCollection BossDecorator { get; set; }

	public bool HideOnIllusions { get; set; } = true;

	public StandardMonster()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		var shadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1);

		TrashDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(128, 200, 200, 200, 0),
				ShadowBrush = shadowBrush,
				ShapePainter = new CircleShapePainter(Assistant),
				Radius = 2,
			}
			);

		var invisibleGroundBrush = Assistant.Render.CreateBrush(128, 255, 170, 255, 3, SharpDX.Direct2D1.DashStyle.Dash);
		InvisibleDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = invisibleGroundBrush,
				Radius = -1,
			},
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(128, 255, 170, 255, 0),
				ShadowBrush = shadowBrush,
				Radius = 2,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);

		EliteChampionDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 64, 128, 255, 0),
				ShadowBrush = shadowBrush,
				Radius = 10,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);

		EliteMinionDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 192, 92, 20, 0),
				ShadowBrush = shadowBrush,
				Radius = 8,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);

		EliteLeaderDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 255, 148, 20, 0),
				ShadowBrush = shadowBrush,
				Radius = 10,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);

		EliteUniqueDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 255, 140, 255, 0),
				ShadowBrush = shadowBrush,
				Radius = 10,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);

		KeywardenDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 255, 255, 255, 0),
				Radius = 6.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			},
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 170, 0, 255, 0),
				ShadowBrush = shadowBrush,
				Radius = 6.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 170, 0, 255, 0),
				BorderBrush = Assistant.Render.CreateBrush(192, 255, 255, 255, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 255, 255, 255, true, false, false)
			}
			);

		BossDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 255, 96, 0, 0),
				ShadowBrush = shadowBrush,
				Radius = 10.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var inRift = Assistant.Game.SpecialArea == SpecialArea.Rift || Assistant.Game.SpecialArea == SpecialArea.GreaterRift;

		var monsters = Assistant.Game.AliveMonsters;
		foreach (var monster in monsters) {
			if (HideOnIllusions && (monster.SummonerAcdDynamicId != 0) && (monster.Rarity == ActorRarity.RareMinion))
				continue;

			if (!inRift && !monster.Invisible && !monster.IsElite && (monster.SnoMonster.Priority != MonsterPriority.goblin) && (monster.SnoMonster.Priority != MonsterPriority.boss) && (monster.SnoMonster.Priority != MonsterPriority.keywarden)) {
				TrashDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.Invisible) {
				InvisibleDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.Rarity == ActorRarity.Champion) {
				EliteChampionDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.Rarity == ActorRarity.RareMinion) {
				EliteMinionDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.Rarity == ActorRarity.Rare) {
				EliteLeaderDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if ((monster.Rarity == ActorRarity.Unique) && (monster.SnoMonster.Priority < MonsterPriority.keywarden)) {
				EliteUniqueDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.SnoMonster.Priority == MonsterPriority.keywarden) {
				KeywardenDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}

			if (monster.SnoMonster.Priority == MonsterPriority.boss) {
				BossDecorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}
		}
	}
}
