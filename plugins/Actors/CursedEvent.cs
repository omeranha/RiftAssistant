using System.Linq;

namespace Plugins.Default;

public class CursedEvent : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public CursedEvent()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 255, 64, 64, 2),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 8.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 255, 64, 64, 0),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 255, 255, 255, false, false, false),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var actors = Assistant.Game.Actors.Where(x => x.SnoActor.Kind == ActorKind.CursedEvent && !x.IsDisabled && !x.IsOperated);
		foreach (var actor in actors) {
			Decorator.ToggleDecorators<GroundLabelDecorator>(!actor.IsOnScreen);

			Decorator.Paint(layer, actor, actor.FloorCoordinate, actor.SnoActor.NameLocalized);
		}
	}
}
