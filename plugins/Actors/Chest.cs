using System.Linq;

namespace Plugins.Default;

public class Chest : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection LoreChestDecorator { get; set; }
	public WorldDecoratorCollection NormalChestDecorator { get; set; }
	public WorldDecoratorCollection ResplendentChestDecorator { get; set; }

	public Chest()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		LoreChestDecorator = new WorldDecoratorCollection(
			new GroundCircleDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(255, 0, 255, 0, -2),
				Radius = 1.2f,
			}
			);

		NormalChestDecorator = new WorldDecoratorCollection(
			new MapTextureDecorator(Assistant) {
				Texture = Assistant.Texture.GetTexture(503639160),
				Radius = 1f,
			}
			);

		ResplendentChestDecorator = new WorldDecoratorCollection(
			new MapTextureDecorator(Assistant) {
				Texture = Assistant.Texture.GetTexture(3627160803),
				Radius = 1f,
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (Assistant.Game.IsInTown)
			return;

		var loreChests = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.GizmoType == GizmoType.LoreChest);
		foreach (var actor in loreChests) {
			LoreChestDecorator.Paint(layer, actor, actor.FloorCoordinate, actor.SnoActor.NameLocalized);
		}

		var normalChests = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.SnoActor.Kind == ActorKind.ChestNormal);
		foreach (var actor in normalChests) {
			NormalChestDecorator.Paint(layer, actor, actor.FloorCoordinate, actor.SnoActor.NameLocalized);
		}

		var resplendentChests = Assistant.Game.Actors.Where(x => !x.IsDisabled && !x.IsOperated && x.SnoActor.Kind == ActorKind.Chest);
		foreach (var actor in resplendentChests) {
			ResplendentChestDecorator.Paint(layer, actor, actor.FloorCoordinate, actor.SnoActor.NameLocalized);
		}
	}
}
