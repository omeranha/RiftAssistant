using System.Linq;

namespace Plugins.Default;

public class Oculus : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public Oculus()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 128, 255, 0, -2),
				Radius = 10.0f,
			},
			new GroundLabelDecorator(Assistant) {
				CountDownFrom = 7,
				TextFont = Assistant.Render.CreateFont("Arial", 11, 255, 96, 255, 96, true, false, 128, 0, 0, 0, true),
			},
			new GroundTimerDecorator(Assistant) {
				CountDownFrom = 7,
				BackgroundBrushEmpty = Assistant.Render.CreateBrush(128, 0, 0, 0, 0),
				BackgroundBrushFill = Assistant.Render.CreateBrush(200, 0, 192, 0, 0),
				Radius = 30,
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (Assistant.Game.IsInTown)
			return;

		var actors = Assistant.Game.Actors.Where(x => x.SnoActor.Sno == ActorSnoEnum._generic_proxy && x.GetAttributeValueAsInt(Assistant.Sno.Attributes.Power_Buff_1_Visual_Effect_None, Assistant.Sno.SnoPowers.OculusRing.Sno) == 1);
		foreach (var actor in actors) {
			Decorator.Paint(layer, actor, actor.FloorCoordinate, null);
		}
	}
}
