using System.Collections.Generic;

namespace Plugins.Default;

public class DangerousMonster : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection Decorator { get; set; }
	private readonly HashSet<string> _names = new HashSet<string>() { "Wood Wraith", "Highland Walker", "The Old Man", "Fallen Lunatic", "Deranged Fallen", "Fallen Maniac", "Frenzied Lunatic", "Herald of Pestilence", "Terror Demon", "Demented Fallen", "Savage Beast", "Tusked Bogan", "Punisher", "Anarch", "Corrupted Angel", "Winged Assassin", "Exarch" };

	public DangerousMonster()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		Decorator = new WorldDecoratorCollection(
			new MapShapeDecorator(Assistant) {
				Brush = Assistant.Render.CreateBrush(180, 255, 50, 50, 0),
				ShadowBrush = Assistant.Render.CreateBrush(96, 0, 0, 0, 1),
				ShapePainter = new CircleShapePainter(Assistant),
				Radius = 2,
			},
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 200, 50, 50, 0),
				TextFont = Assistant.Render.CreateFont("Arial", 6.5f, 255, 255, 255, 255, false, false, false),
			}
			);
	}

	public void AddNames(params string[] names)
	{
		foreach (var name in names) {
			_names.Add(name);
		}
	}

	public void RemoveName(string name)
	{
		if (_names.Contains(name))
			_names.Remove(name);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var monsters = Assistant.Game.AliveMonsters;
		foreach (var monster in monsters) {
			if (_names.Contains(monster.SnoMonster.NameEnglish) || _names.Contains(monster.SnoMonster.NameLocalized)) {
				Decorator.Paint(layer, monster, monster.FloorCoordinate, monster.SnoMonster.NameLocalized);
			}
		}
	}
}
