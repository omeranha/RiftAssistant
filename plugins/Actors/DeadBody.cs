using System.Linq;

namespace Plugins.Default;

public class DeadBody : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public DeadBody()
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
				Radius = 2f,
				ShapePainter = new RectangleShapePainter(Assistant),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var actors = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.SnoActor.Kind == ActorKind.DeadBody);
		foreach (var actor in actors) {
			Decorator.Paint(layer, actor, actor.FloorCoordinate, null);
		}
	}
}
