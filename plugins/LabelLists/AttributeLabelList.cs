using System.Collections.Generic;
using System.Globalization;

namespace Plugins.Default;

public class AttributeLabelList : BasePlugin, IInGameTopPainter
{
	public HorizontalTopLabelList LabelList { get; private set; }

	public AttributeLabelList()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		var expandedHintFont = Assistant.Render.CreateFont("Arial", 7, 255, 200, 200, 200, false, false, true);
		var expandedHintWidthMultiplier = 3;

		LabelList = new HorizontalTopLabelList(assistant) {
			LeftFunc = () => {
				var ui = Assistant.Render.InGameBottomHudUiElement;
				return ui.Rectangle.Left + (ui.Rectangle.Width * 0.267f);
			},
			TopFunc = () => {
				var ui = Assistant.Render.InGameBottomHudUiElement;
				return ui.Rectangle.Top + (ui.Rectangle.Height * 0.318f);
			},
			WidthFunc = () => {
				var ui = Assistant.Render.InGameBottomHudUiElement;
				return Assistant.Window.Size.Height * 0.0621f;
			},
			HeightFunc = () => {
				var ui = Assistant.Render.InGameBottomHudUiElement;
				return Assistant.Window.Size.Height * 0.025f;
			}
		};

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
			BackgroundTextureOpacity2 = 0.75f,
			TextFunc = () => ValueToString(Assistant.Game.LocalPlayer.Defense.EhpCur, ValueFormat.ShortNumber),
			HintFunc = () => "EHP current",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
			ExpandedHintFont = expandedHintFont,
			ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
			BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
			BackgroundTextureOpacity2 = 0.70f,
			TextFunc = () => ValueToString(Assistant.Game.LocalPlayer.Defense.EhpMax, ValueFormat.ShortNumber),
			HintFunc = () => "EHP max",
			ExpandUpLabels = new List<TopLabelDecorator>()
			{
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
						BackgroundTextureOpacity2 = 1.0f,
						TextFunc = () => (Assistant.Game.LocalPlayer.Defense.drCombined * 100).ToString("F1", CultureInfo.InvariantCulture),
						HintFunc = () => "damage reduction",
					},
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
						BackgroundTextureOpacity2 = 1.0f,
						TextFunc = () => Assistant.Game.LocalPlayer.Defense.Armor.ToString("#,0", CultureInfo.InvariantCulture),
						HintFunc = () => "armor",
					},
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureGray,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
						BackgroundTextureOpacity2 = 1.0f,
						TextFunc = () => Assistant.Game.LocalPlayer.Defense.ResAverage.ToString("F0", CultureInfo.InvariantCulture),
						HintFunc = () => "average resist",
					},
				}
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, true, false, true),
			ExpandedHintFont = expandedHintFont,
			ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureOrange,
			BackgroundTextureOpacity2 = 0.5f,
			TextFunc = () => ValueToString(Assistant.Game.LocalPlayer.Offense.SheetDps, ValueFormat.ShortNumber),
			HintFunc = () => "sheet DPS",
			ExpandUpLabels = new List<TopLabelDecorator>()
			{
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, false, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureYellow,
						BackgroundTextureOpacity2 = 0.75f,
						TextFunc = () => ValueToString(Assistant.Game.LocalPlayer.Offense.MainHandIsActive ? Assistant.Game.LocalPlayer.Offense.WeaponDamageMainHand : Assistant.Game.LocalPlayer.Offense.WeaponDamageSecondHand, ValueFormat.ShortNumber),
						HintFunc = () => "weapon damage",
					},
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, false, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureYellow,
						BackgroundTextureOpacity2 = 0.75f,
						TextFunc = () => Assistant.Game.LocalPlayer.Offense.AttackSpeed.ToString("F2", CultureInfo.InvariantCulture) + "/s",
						HintFunc = () => "attack speed",
					},
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, false, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureYellow,
						BackgroundTextureOpacity2 = 0.75f,
						TextFunc = () => Assistant.Game.LocalPlayer.Offense.CriticalHitChance.ToString("F1", CultureInfo.InvariantCulture) + "%",
						HintFunc = () => "critical hit chance",
					},
					new TopLabelDecorator(Assistant)
					{
						TextFont = Assistant.Render.CreateFont("Arial", 7, 180, 255, 255, 255, false, false, true),
						ExpandedHintFont = expandedHintFont,
						ExpandedHintWidthMultiplier = expandedHintWidthMultiplier,
						BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
						BackgroundTexture2 = Assistant.Texture.BackgroundTextureYellow,
						BackgroundTextureOpacity2 = 0.75f,
						TextFunc = () => Assistant.Game.LocalPlayer.Offense.CritDamage.ToString("F0", CultureInfo.InvariantCulture) + "%",
						HintFunc = () => "critical hit damage",
					}
				}
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 255, 255, 255, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
			BackgroundTextureOpacity2 = 0.3f,
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.AttackSpeed.ToString("F2", CultureInfo.InvariantCulture) + "/s",
			HintFunc = () => "attack speed",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 255, 255, 255, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
			BackgroundTextureOpacity2 = 0.3f,
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.CriticalHitChance.ToString("F1", CultureInfo.InvariantCulture) + "%",
			HintFunc = () => "critical hit chance",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 255, 255, 255, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureGreen,
			BackgroundTextureOpacity2 = 0.3f,
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.CritDamage.ToString("F0", CultureInfo.InvariantCulture) + "%",
			HintFunc = () => "critical hit damage",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 200, 200, 255, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity2 = 0.75f,
			TextFunc = () => Assistant.Game.LocalPlayer.Offense.AreaDamageBonus.ToString("F0", CultureInfo.InvariantCulture) + "%",
			HintFunc = () => "area damage bonus %",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 200, 200, 255, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureBlue,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity2 = 0.75f,
			TextFunc = () => (Assistant.Game.LocalPlayer.Stats.CooldownReduction * 100).ToString("F0", CultureInfo.InvariantCulture) + "%",
			HintFunc = () => "cooldown reduction %",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 255, 200, 200, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureBlue,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity2 = 0.75f,
			TextFunc = () => (Assistant.Game.LocalPlayer.Stats.ResourceCostReduction * 100).ToString("F0", CultureInfo.InvariantCulture) + "%",
			HintFunc = () => "resource cost reduction",
		});

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 7, 120, 255, 200, 200, false, false, true),
			BackgroundTexture1 = Assistant.Texture.ButtonTextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity2 = 0.75f,
			TextFunc = () => ValueToString(Assistant.Game.ExperiencePerHourToday, ValueFormat.ShortNumber) + "/h",
			HintFunc = () => "experience per hour today",
		});
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.BeforeClip)
			return;
		if ((Assistant.Game.MapMode == MapMode.WaypointMap) || (Assistant.Game.MapMode == MapMode.ActMap) || (Assistant.Game.MapMode == MapMode.Map))
			return;

		LabelList.Paint();
	}
}
