using System.Linq;

namespace Plugins.Default;

public class ClickableChestGizmo : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }
	public bool PaintOnlyWhenHarringtonWaistguardIsActive { get; set; } = true;

	public ClickableChestGizmo()
	{
		Enabled = false;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 230, 200, 230, 1),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 6.0f,
				ShapePainter = new CrossShapePainter(Assistant),
			},
			new GroundShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(192, 230, 200, 230, 2),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 2.0f,
				ShapePainter = WorldStarShapePainter.NewCross(Assistant),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (PaintOnlyWhenHarringtonWaistguardIsActive && !Assistant.Game.LocalPlayer.Powers.BuffIsActive(318881, 0))
			return;

		var actors = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.GizmoType == GizmoType.Chest);
		foreach (var actor in actors) {
			Decorator.Paint(layer, actor, actor.FloorCoordinate, null);
		}
	}
}
