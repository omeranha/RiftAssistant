namespace Plugins.Default;

// range for "Strength in Numbers" buff in multiplayer games
public class MultiplayerExperienceRange : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public MultiplayerExperienceRange()
	{
		Enabled = false;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(7, 255, 255, 255, 0),
				ShapePainter = new CircleShapePainter(Assistant),
				Radius = 200,
			}
		);
	}

	public void PaintWorld(WorldLayer layer)
	{
		if (Assistant.Game.IsInTown)
			return;
		if (Assistant.Render.UiHidden)
			return;
		if (Assistant.Game.NumberOfPlayersInGame <= 1)
			return;

		Decorator.Paint(layer, null, Assistant.Game.LocalPlayer.FloorCoordinate, null);
	}
}
