using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SharpDX;
using System.Diagnostics;

namespace Plugins.Default;

public class SkillPainter : ITransparentCollection
{
	public bool Enabled { get; set; }
	public Controller Assistant { get; set; }

	public IFont CooldownFont { get; set; }
	public IFont SkillDamageFont { get; set; }
	public IFont SkillDpsFont { get; set; }
	public IBrush[] SkillDpsBackgroundBrushesByElementalType { get; set; }
	public IFont DamageBonusFont { get; set; }
	public IFont DamageBonusEliteFont { get; set; }

	public float TextureOpacity { get; set; }
	public bool EnableSkillDpsBar { get; set; }
	public bool EnableDetailedDpsHint { get; set; }

	private readonly Stopwatch _lastTownEliteSimulation;

	public SkillPainter(Controller assistant, bool setDefaultStyle)
	{
		Enabled = true;
		Assistant = assistant;

		_lastTownEliteSimulation = Stopwatch.StartNew();

		if (setDefaultStyle) {
			CooldownFont = Assistant.Render.CreateFont("arial", 14, 255, 255, 255, 255, true, false, 255, 0, 0, 0, true);
			SkillDamageFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 200, 100, false, false, 160, 0, 0, 0, true);
			SkillDpsFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 255, 255, false, false, 160, 0, 0, 0, true);
			SkillDpsBackgroundBrushesByElementalType = new IBrush[]
			{
					Assistant.Render.CreateBrush(200, 255, 6, 0, 0),
					Assistant.Render.CreateBrush(200, 183, 57, 7, 0),
					Assistant.Render.CreateBrush(200, 0, 38, 119, 0),
					Assistant.Render.CreateBrush(200, 77, 102, 155, 0),
					Assistant.Render.CreateBrush(200, 50, 106, 21, 0),
					Assistant.Render.CreateBrush(200, 138, 0, 94, 0),
					Assistant.Render.CreateBrush(200, 190, 117, 0, 0),
			};

			DamageBonusFont = Assistant.Render.CreateFont("Arial", 7, 255, 200, 200, 200, false, false, 160, 0, 0, 0, true);
			DamageBonusEliteFont = Assistant.Render.CreateFont("Arial", 7, 255, 255, 160, 160, false, false, 160, 0, 0, 0, true);
		}
	}

	public void Paint(Skill skill, RectangleF rect)
	{
		if (skill == null)
			return;

		if (TextureOpacity > 0) {
			var texture = Assistant.Texture.GetTexture(skill.CurrentSnoPower.NormalIconTextureId);
			texture?.Draw(rect.X, rect.Y, rect.Width, rect.Height, TextureOpacity);
		}

		if (skill.IsOnCooldown) {
			var remainingSeconds = (skill.CooldownFinishTick - Assistant.Game.CurrentGameTick) / 60.0d;
			var text = remainingSeconds > 1.0f
				? remainingSeconds.ToString("F0", CultureInfo.InvariantCulture)
				: remainingSeconds.ToString("F1", CultureInfo.InvariantCulture);

			var textLayout = CooldownFont.GetTextLayout(text);
			var x = rect.X + ((rect.Width - (float)Math.Ceiling(textLayout.Metrics.Width)) / 2);
			var y = rect.Y + ((rect.Height - textLayout.Metrics.Height) / 2);

			CooldownFont.DrawText(textLayout, x, y);
		}

		if (!EnableSkillDpsBar || skill.CurrentSnoPower.ElementalDamageTypesByRune == null)
			return;

		var elite = Assistant.Game.IsEliteOnScreen || Assistant.Game.IsGoblinOnScreen;
		if (Assistant.Game.IsInTown) {
			if (_lastTownEliteSimulation.ElapsedMilliseconds >= 3000) {
				elite = true;
				if (_lastTownEliteSimulation.ElapsedMilliseconds >= 6000) {
					_lastTownEliteSimulation.Restart();
				}
			}
		}

		var elementalType = skill.ElementalType;
		if (elementalType == -1)
			return;

		var resourceCost = skill.ResourceCost;
		var weaponDamageMultiplier = skill.WeaponDamageMultiplier;
		if (weaponDamageMultiplier != -1) {
			var dotSeconds = skill.DotSeconds;

			var skillBonus = 1 + skill.DamageBonus;
			var elementalBonus = 1 + skill.ElementalDamageBonus;
			var eliteBonus = 1 + (elite ? Assistant.Game.LocalPlayer.Offense.BonusToElites : 0);

			var skillBonusTotal = skillBonus * elementalBonus * eliteBonus;

			double plainBonusTotal = 1;
			foreach (var bonus in Assistant.Game.LocalPlayer.Offense.PlainDamageBonuses) {
				plainBonusTotal *= 1 + bonus.Item2;
			}

			var weaponDamage = Assistant.Game.LocalPlayer.Offense.MainHandIsActive ? Assistant.Game.LocalPlayer.Offense.WeaponDamageMainHand : Assistant.Game.LocalPlayer.Offense.WeaponDamageSecondHand;
			var attackSpeed = Assistant.Game.LocalPlayer.Offense.MainHandIsActive ? Assistant.Game.LocalPlayer.Offense.AttackSpeedMainHand : Assistant.Game.LocalPlayer.Offense.AttackSpeedOffHand;

			var skillDamage = weaponDamage * (weaponDamageMultiplier / 100.0f) * skillBonusTotal * plainBonusTotal;
			var skillDps = skillDamage;
			if (dotSeconds > 0)
				skillDps /= dotSeconds;
			else
				skillDps *= attackSpeed;

			var textLayout = SkillDamageFont.GetTextLayout(BasePlugin.ValueToString(skillDamage, ValueFormat.LongNumber));
			SkillDamageFont.DrawText(textLayout, rect.Left, rect.Bottom - textLayout.Metrics.Height + 1);

			var rHeight = rect.Height * 0.33f;
			var rTop = rect.Bottom + (rHeight * 0.1f);

			SkillDpsBackgroundBrushesByElementalType[elementalType].DrawRectangle(rect.Left, rTop, rect.Width, rHeight);

			textLayout = SkillDpsFont.GetTextLayout(BasePlugin.ValueToString(skillDps, ValueFormat.LongNumber));
			SkillDpsFont.DrawText(textLayout, rect.Left + ((rect.Width - textLayout.Metrics.Width) / 2), rTop + ((rHeight - textLayout.Metrics.Height) / 2));

			if (skillBonusTotal > 1) {
				var bonusFont = elite ? DamageBonusEliteFont : DamageBonusFont;
				textLayout = bonusFont.GetTextLayout("+" + ((skillBonusTotal * 100) - 100).ToString("F0") + "%");
				bonusFont.DrawText(textLayout, rect.Left, rect.Top - 1);
			}

			if (EnableDetailedDpsHint && Assistant.Window.CursorInsideRect(rect.Left, rect.Top, rect.Width, rect.Height)) {
				var plainBonusText = "";
				var plainBonuses = Assistant.Game.LocalPlayer.Offense.PlainDamageBonuses.ToList();
				if (plainBonuses.Count > 0) {
					plainBonusText = "\nPLAIN BONUSES: +" + ((plainBonusTotal * 100) - 100).ToString("F0", CultureInfo.InvariantCulture) + "%\n";
					foreach (var bonus in plainBonuses) {
						plainBonusText += "\t" + (bonus.Item2 * 100).ToString("F0", CultureInfo.InvariantCulture) + "% " + bonus.Item1.Icons[0].TitleLocalized + "\n";
					}
				}

				var hint =
					"WEAPON DAMAGE: " + BasePlugin.ValueToString(weaponDamage, ValueFormat.LongNumber) + " (" + (Assistant.Game.LocalPlayer.Offense.MainHandIsActive ? "left" : "right") + " hand)\n" +
					(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ?
					"\t" + ((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinAmainHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxAmainHand / 2)).ToString("F0", CultureInfo.InvariantCulture) + " (" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinAmainHand.ToString("F0", CultureInfo.InvariantCulture) + "-" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxAmainHand.ToString("F0", CultureInfo.InvariantCulture) + ")\n" :
					"\t" + ((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinAoffHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxAoffHand / 2)).ToString("F0", CultureInfo.InvariantCulture) + " (" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinAoffHand.ToString("F0", CultureInfo.InvariantCulture) + "-" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxAoffHand.ToString("F0", CultureInfo.InvariantCulture) + ")\n") +
					(((Assistant.Game.LocalPlayer.Offense.DamageMin > 0) || (Assistant.Game.LocalPlayer.Offense.DamageMax > 0)) ?
					((Assistant.Game.LocalPlayer.Offense.DamageMin > 0) || (Assistant.Game.LocalPlayer.Offense.DamageMax > 0) ? "\t+ damage from armor: " + Assistant.Game.LocalPlayer.Offense.DamageMin.ToString("F0", CultureInfo.InvariantCulture) + "-" + Assistant.Game.LocalPlayer.Offense.DamageMax.ToString("F0", CultureInfo.InvariantCulture) + "\n" : "") +
					(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ?
					"\t= " + ((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand / 2)).ToString("F0", CultureInfo.InvariantCulture) + " (" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand.ToString("F0", CultureInfo.InvariantCulture) + "-" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand.ToString("F0", CultureInfo.InvariantCulture) + ")\n" :
					"\t= " + ((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand / 2)).ToString("F0", CultureInfo.InvariantCulture) + " (" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand.ToString("F0", CultureInfo.InvariantCulture) + "-" + Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand.ToString("F0", CultureInfo.InvariantCulture) + ")\n")
					: "") +
					"\tincreased by main stat: " +
					(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ?
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + ")\n" :
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)), ValueFormat.LongNumber) + ")\n") +
					"\tincreased by crit: " +
					(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ?
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + ")\n" :
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)), ValueFormat.LongNumber) + ")\n") +
					((Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills > 0) ?
					"\tincreased by skills: " +
					(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ?
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBmainHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + ")\n" :
					"" + BasePlugin.ValueToString(((Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand / 2) + (Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand / 2)) * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + " (" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMinBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + "-" + BasePlugin.ValueToString(Assistant.Game.LocalPlayer.Offense.WeaponBaseDamageMaxBoffHand * (1 + (Assistant.Game.LocalPlayer.Stats.MainStat / 100)) * (1 + (Assistant.Game.LocalPlayer.Offense.CriticalHitChance / 100 * Assistant.Game.LocalPlayer.Offense.CritDamage / 100)) * (1 + Assistant.Game.LocalPlayer.Offense.WeaponDamageIncreasedBySkills), ValueFormat.LongNumber) + ")\n")
					: "") +
					"\nTOTAL BONUS: +" + ((skillBonusTotal * 100) - 100).ToString("F0", CultureInfo.InvariantCulture) + "%\n" +
					"\t" + (skill.ElementalDamageBonus * 100).ToString("F0", CultureInfo.InvariantCulture) + "% elemental\n" +
					"\t" + (skill.DamageBonus * 100).ToString("F0", CultureInfo.InvariantCulture) + "% skill\n" +
					(elite ? "\t" + (Assistant.Game.LocalPlayer.Offense.BonusToElites * 100).ToString("F0", CultureInfo.InvariantCulture) + "% elite\n" : "") +
					plainBonusText +
					"\n'" + skill.CurrentSnoPower.NameLocalized + "' / '" + skill.RuneNameLocalized + "' does " + weaponDamageMultiplier.ToString("F0", CultureInfo.InvariantCulture) + "% weapon damage" + (dotSeconds > 0 ? " over " + dotSeconds.ToString("F1", CultureInfo.InvariantCulture) + " seconds" : "") + "\n" +
					"\tDMG: " + BasePlugin.ValueToString(skillDamage, ValueFormat.LongNumber) + " (= " + BasePlugin.ValueToString(weaponDamage, ValueFormat.LongNumber) + " * " + weaponDamageMultiplier.ToString("F0", CultureInfo.InvariantCulture) + "% + " + ((skillBonusTotal * 100) - 100).ToString("F0", CultureInfo.InvariantCulture) + "% + " + ((plainBonusTotal * 100) - 100).ToString("F0", CultureInfo.InvariantCulture) + "%)\n" +
					"\tDPS: " + BasePlugin.ValueToString(skillDps, ValueFormat.LongNumber) + " (= " + BasePlugin.ValueToString(skillDamage, ValueFormat.LongNumber) + (dotSeconds > 0 ? " / " + dotSeconds.ToString("F1", CultureInfo.InvariantCulture) + " seconds" : " * " + attackSpeed.ToString("F2", CultureInfo.InvariantCulture) + " attack/s") + ")" +
					((resourceCost != -1) ? "\n\nResource cost\n\tdefault: " + BasePlugin.ValueToString(Math.Abs(resourceCost), ValueFormat.NormalNumberNoDecimal) + " " + (resourceCost > 0 ? Assistant.Game.LocalPlayer.HeroClassDefinition.PrimaryResourceName : Assistant.Game.LocalPlayer.HeroClassDefinition.SecondaryResourceName) + "\n\treal: " + BasePlugin.ValueToString(skill.GetResourceRequirement(), ValueFormat.NormalNumber) + " " + (resourceCost > 0 ? Assistant.Game.LocalPlayer.HeroClassDefinition.PrimaryResourceName : Assistant.Game.LocalPlayer.HeroClassDefinition.SecondaryResourceName) : "");
				Assistant.Render.SetHint(hint, "tooltip-bottom-right");
			}
		} else if (resourceCost != -1) {
			if (Assistant.Window.CursorInsideRect(rect.Left, rect.Top, rect.Width, rect.Height)) {
				Assistant.Render.SetHint("Resource cost\n\tdefault: " + BasePlugin.ValueToString(Math.Abs(resourceCost), ValueFormat.NormalNumberNoDecimal) + " " + (resourceCost > 0 ? Assistant.Game.LocalPlayer.HeroClassDefinition.PrimaryResourceName : Assistant.Game.LocalPlayer.HeroClassDefinition.SecondaryResourceName) + "\n\treal: " + BasePlugin.ValueToString(skill.GetResourceRequirement(), ValueFormat.NormalNumber) + " " + (resourceCost > 0 ? Assistant.Game.LocalPlayer.HeroClassDefinition.PrimaryResourceName : Assistant.Game.LocalPlayer.HeroClassDefinition.SecondaryResourceName), "tooltip-bottom-right");
			}
		}
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return CooldownFont;
		yield return SkillDamageFont;
		yield return SkillDpsFont;
		foreach (var brush in SkillDpsBackgroundBrushesByElementalType)
			yield return brush;
		yield return DamageBonusFont;
		yield return DamageBonusEliteFont;
	}
}
