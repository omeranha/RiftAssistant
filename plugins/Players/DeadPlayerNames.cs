using System.Linq;

namespace Plugins.Default;

public class DeadPlayerNames : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }

	public DeadPlayerNames()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 7f, 255, 255, 100, 100, true, false, 0, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, 0),
				BorderBrush = Assistant.Render.CreateBrush(200, 255, 100, 100, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 7f, 255, 255, 100, 100, true, false, 0, 0, 0, 0, true),
			}
			);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var deadPlayers = Assistant.Game.Players
			.Where(player => !player.IsMe && player.CoordinateKnown && player.IsDeadSafeCheck);

		foreach (var player in deadPlayers) {
			Decorator.Paint(layer, player, player.FloorCoordinate, player.BattleTagAbovePortrait);
		}
	}
}
