using System.Collections.Generic;
using System.Linq;

namespace Plugins.Default;

public class EliteMonsterAffix : BasePlugin, IInGameWorldPainter
{
	public WorldDecoratorCollection WeakDecorator { get; set; }
	public Dictionary<MonsterAffix, WorldDecoratorCollection> AffixDecorators { get; set; }
	public Dictionary<MonsterAffix, string> CustomAffixNames { get; set; } = new Dictionary<MonsterAffix, string>();

	public bool HideOnIllusions { get; set; } = true;

	public EliteMonsterAffix()
	{
		Enabled = true;
		Order = 20000;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		WeakDecorator = new WorldDecoratorCollection(
			new GroundLabelDecorator(Assistant) {
				BackgroundBrush = Assistant.Render.CreateBrush(255, 50, 50, 50, 0),
				BorderBrush = Assistant.Render.CreateBrush(128, 0, 0, 0, 2),
				TextFont = Assistant.Render.CreateFont("Arial", 5f, 200, 220, 120, 0, false, false, false)
			}
			);

		var importantBorderBrush = Assistant.Render.CreateBrush(128, 0, 0, 0, 2);
		var importantLabelFont = Assistant.Render.CreateFont("Arial", 6f, 255, 255, 255, 255, true, false, false);

		AffixDecorators = new Dictionary<MonsterAffix, WorldDecoratorCollection>
		{
				{
					MonsterAffix.Arcane,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 120, 0, 120, 0),
				}
				)
				},
				{
					MonsterAffix.Desecrator,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 170, 50, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Electrified,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 40, 40, 240, 0),
				}
				)
				},
				{
					MonsterAffix.Frozen,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 120, 0),
				}
				)
				},
				{
					MonsterAffix.FrozenPulse,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 120, 0),
				}
				)
				},
				{
					MonsterAffix.Jailer,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 120, 0, 120, 0),
				}
				)
				},
				{
					MonsterAffix.Juggernaut,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 200, 0, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Molten,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 170, 50, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Mortar,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 170, 50, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Orbiter,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 40, 40, 240, 0),
				}
				)
				},
				{
					MonsterAffix.Plagued,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 120, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Poison,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 120, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Reflect,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 120, 50, 0, 0),
				}
				)
				},
				{
					MonsterAffix.Thunderstorm,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 40, 40, 240, 0),
				}
				)
				},
				{
					MonsterAffix.Waller,
					new WorldDecoratorCollection(
				new GroundLabelDecorator(Assistant)
				{
					BorderBrush = importantBorderBrush,
					TextFont = importantLabelFont,
					BackgroundBrush = Assistant.Render.CreateBrush(255, 50, 50, 50, 0),
				}
				)
				},

				{ MonsterAffix.ExtraHealth, WeakDecorator },
				{ MonsterAffix.HealthLink, WeakDecorator },
				{ MonsterAffix.Fast, WeakDecorator },
				{ MonsterAffix.FireChains, WeakDecorator },
				{ MonsterAffix.Knockback, WeakDecorator },
				{ MonsterAffix.Nightmarish, WeakDecorator },
				{ MonsterAffix.Illusionist, WeakDecorator },
				{ MonsterAffix.Shielding, WeakDecorator },
				{ MonsterAffix.Teleporter, WeakDecorator },
				{ MonsterAffix.Vampiric, WeakDecorator },
				{ MonsterAffix.Vortex, WeakDecorator },
				{ MonsterAffix.Wormhole, WeakDecorator },
				{ MonsterAffix.Avenger, WeakDecorator },
				{ MonsterAffix.Horde, WeakDecorator },
				{ MonsterAffix.MissileDampening, WeakDecorator }
			};
	}

	public void PaintWorld(WorldLayer layer)
	{
		var monsters = Assistant.Game.AliveMonsters;
		if (monsters == null || !monsters.Any()) return;

		foreach (var monster in monsters.Where(x => x.IsElite)) {
			if (monster == null || monster.AffixSnoList == null || !monster.AffixSnoList.Any()) continue;

			if (HideOnIllusions) {
				if (monster.Illusion)
					continue;
			}

			foreach (var snoMonsterAffix in monster.AffixSnoList) {
				if (!AffixDecorators.TryGetValue(snoMonsterAffix.Affix, out var decorator))
					continue;

				var affixName = CustomAffixNames.ContainsKey(snoMonsterAffix.Affix) ? CustomAffixNames[snoMonsterAffix.Affix] : snoMonsterAffix.NameLocalized;

				decorator.Paint(layer, monster, monster.FloorCoordinate, affixName);
			}
		}
	}
}
