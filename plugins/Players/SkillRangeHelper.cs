namespace Plugins.Default;

public class SkillRangeHelper : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection[] DecoratorsByElementalType { get; set; }

	public SkillRangeHelper()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		DecoratorsByElementalType = new WorldDecoratorCollection[] {
            // physical
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 235, 6, 0, -3), }
			),
            // fire
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 183, 57, 7, -3), }
			),
            // lightning
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 0, 68, 149, -3), }
			),
            // cold
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 77, 102, 155, -3), }
			),
            // poison
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 70, 126, 41, -3), }
			),
            // arcane
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 158, 20, 114, -3), }
			),
            // holy
            new WorldDecoratorCollection(
				new GroundCircleDecorator(Assistant) { Brush = Assistant.Render.CreateBrush(132, 190, 117, 0, -3), }
			)
			};
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (!Assistant.Game.IsInTown)
			return;
		if (Assistant.Render.UiHidden)
			return;
		if ((Assistant.Game.MapMode == MapMode.WaypointMap) || (Assistant.Game.MapMode == MapMode.ActMap) || (Assistant.Game.MapMode == MapMode.Map))
			return;

		Skill hoveredSkill = null;
		foreach (var skill in Assistant.Game.LocalPlayer.Powers.CurrentSkills) {
			var ui = Assistant.Render.GetPlayerSkillUiElement(skill.Key);
			if (Assistant.Window.CursorInsideRect(ui.Rectangle.X, ui.Rectangle.Y, ui.Rectangle.Width, ui.Rectangle.Height)) {
				hoveredSkill = skill;
				break;
			}
		}

		if (hoveredSkill == null)
			return;

		var range = Assistant.Game.LocalPlayer.GetPowerTagValue(hoveredSkill.CurrentSnoPower, 329808);
		if (range <= 0)
			return;

		var elementalType = hoveredSkill.ElementalType;
		if (elementalType < 0)
			return;

		var currentDecorator = DecoratorsByElementalType[elementalType];
		foreach (var subDecorator in currentDecorator.GetDecorators<GroundCircleDecorator>()) {
			subDecorator.Radius = range;
		}

		currentDecorator.Paint(layer, null, Assistant.Game.LocalPlayer.FloorCoordinate, null);
	}
}
