namespace Plugins.Default;

public class Banners : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public Banners()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 200, 0, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(192, 255, 255, 255, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 255, 255, 255, true, false, false),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var banners = Assistant.Game.Banners;
		foreach (var banner in banners) {
			var onScreen = banner.FloorCoordinate.IsOnScreen();
			Decorator.ToggleDecorators<GroundLabelDecorator>(!onScreen);

			Decorator.Paint(layer, null, banner.FloorCoordinate, "BANNER");
		}
	}
}
