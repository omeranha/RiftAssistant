namespace Plugins.Default;

public class Portals : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public Portals()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapTextureDecorator(Assistant) {
				Texture = Assistant.Texture.GetTexture(448992, 0),
				Radius = 1f,
			},
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 200, 255, 255, 0, false, false, 128, 0, 0, 0, true),
				RadiusOffset = 6.0f,
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		foreach (var portal in Assistant.Game.Portals) {
			if (portal.TargetArea == null || portal.TargetArea.Code.StartsWith("p76_nesting"))
				continue;
			if (portal.Scene == null || portal.Scene.SnoArea == null || portal.Scene.SnoArea.IsTown || portal.Scene.SnoArea.Code.StartsWith("_P76_Nesting"))
				continue;

			Decorator.Paint(layer, null, portal.FloorCoordinate, portal.TargetArea.NameLocalized ?? "unknown portal");
		}
	}
}
