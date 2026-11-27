namespace Plugins.Default;

public class SceneHints : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public SceneHints()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 200, 255, 200, 0, false, false, 128, 0, 0, 0, true),
				RadiusOffset = 0,
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var sceneHints = Assistant.Game.SceneHints;
		foreach (var sceneHint in sceneHints) {
			Decorator.ToggleDecorators<GroundLabelDecorator>(!sceneHint.FloorCoordinate.IsOnScreen()); // do not display ground labels when the actor is on the screen
			Decorator.Paint(layer, null, sceneHint.FloorCoordinate, sceneHint.Hint);
		}
	}
}
