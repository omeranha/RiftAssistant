using System.Linq;

namespace Plugins.Default;

public class Globe : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection PowerGlobeDecorator { get; set; }
	public WorldDecoratorCollection RiftOrbDecorator { get; set; }

	public Globe()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		PowerGlobeDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 240, 240, 120, 0),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 6.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 240, 240, 120, 0),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 0, 0, 0, false, false, false),
			}
			);

		RiftOrbDecorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 240, 120, 240, 0),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 6.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 240, 120, 240, 0),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 0, 0, 0, false, false, false),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var actors = Assistant.Game.Actors.Where(x => x.SnoActor.Kind == ActorKind.PowerGlobe);
		foreach (var actor in actors) {
			PowerGlobeDecorator.ToggleDecorators<GroundLabelDecorator>(!actor.IsOnScreen); // do not display ground labels when the actor is on the screen
			PowerGlobeDecorator.Paint(layer, actor, actor.FloorCoordinate, "power globe");
		}

		actors = Assistant.Game.Actors.Where(x => x.SnoActor.Kind == ActorKind.RiftOrb);
		foreach (var actor in actors) {
			RiftOrbDecorator.ToggleDecorators<GroundLabelDecorator>(!actor.IsOnScreen); // do not display ground labels when the actor is on the screen
			RiftOrbDecorator.Paint(layer, actor, actor.FloorCoordinate, "rift orb");
		}
	}
}
