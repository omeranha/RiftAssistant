using System.Linq;

namespace Plugins.Default;

public class Rack : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public Rack()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 64, 255, 64, 1),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				Radius = 4.0f,
				ShapePainter = new CircleShapePainter(Assistant),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (Assistant.Game.IsInTown)
			return;

		var weaponRacks = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.SnoActor.Kind == ActorKind.WeaponRack);
		foreach (var actor in weaponRacks) {
			Decorator.Paint(layer, actor, actor.FloorCoordinate, null);
		}

		var armorRacks = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.SnoActor.Kind == ActorKind.ArmorRack);
		foreach (var actor in armorRacks) {
			Decorator.Paint(layer, actor, actor.FloorCoordinate, null);
		}
	}
}
