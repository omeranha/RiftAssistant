using System.Collections.Generic;
using System.Linq;

namespace Plugins.Default;

public class AlivePlayerNames : BasePlugin, IInGameWorldPainter
{
	public Dictionary<HeroClass, WorldDecoratorCollection> DecoratorByClass { get; set; } = new Dictionary<HeroClass, WorldDecoratorCollection>();
	public float NameOffsetZ { get; set; } = 8.0f;

	public AlivePlayerNames()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		var groundLabelBackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, 0);

		DecoratorByClass.Add(HeroClass.Barbarian, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 200, 255, 60, 60, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(200, 250, 10, 10, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 200, 255, 60, 60, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.Crusader, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 240, 0, 200, 250, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(240, 0, 200, 250, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 240, 0, 200, 250, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.DemonHunter, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 255, 180, 180, 255, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 200, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 255, 180, 180, 255, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.Monk, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 245, 170, 0, 255, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(245, 120, 0, 200, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 245, 170, 0, 255, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.Necromancer, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 255, 175, 238, 238, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(255, 175, 238, 238, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 255, 175, 238, 238, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.WitchDoctor, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 155, 0, 155, 125, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(155, 0, 155, 125, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 155, 0, 155, 125, false, false, 128, 0, 0, 0, true),
			}
			));

		DecoratorByClass.Add(HeroClass.Wizard, new WorldDecoratorCollection(
			new MapLabelDecorator(Assistant) {
				LabelFont = Assistant.Render.CreateFont("Arial", 6f, 255, 250, 50, 180, false, false, 128, 0, 0, 0, true),
				Up = true,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = groundLabelBackgroundBrush,
				BorderBrush = Assistant.Render.CreateBrush(255, 250, 50, 180, 1),
				TextFont = Assistant.Render.CreateFont("Arial", 6f, 255, 250, 50, 180, false, false, 128, 0, 0, 0, true),
			}
			));
	}

	public void PaintWorld(WorldLayer layer)
	{
		var alivePlayers = Assistant.Game.Players
			.Where(player => !player.IsMe && player.CoordinateKnown && !player.IsDeadSafeCheck);

		foreach (var player in alivePlayers) {
			if (!DecoratorByClass.TryGetValue(player.HeroClassDefinition.HeroClass, out var decorator))
				continue;

			var coord = NameOffsetZ != 0
				? player.FloorCoordinate.Offset(0, 0, NameOffsetZ)
				: player.FloorCoordinate;

			var text = player.BattleTagAbovePortrait;

			decorator.Paint(layer, null, coord, text);
		}
	}
}
