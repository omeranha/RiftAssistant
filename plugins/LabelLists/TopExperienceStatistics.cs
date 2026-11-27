using System;
using System.Collections.Generic;
using System.Globalization;

namespace Plugins.Default;

public class TopExperienceStatistics : BasePlugin, IInGameTopPainter
{
	public HorizontalTopLabelList LabelList { get; private set; }

	public TopExperienceStatistics()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		var expandedHintFont = Assistant.Render.CreateFont("Arial", 6, 255, 200, 200, 200, false, false, true);

		LabelList = new HorizontalTopLabelList(assistant) {
			LeftFunc = () => (Assistant.Window.Size.Width / 2) - (Assistant.Window.Size.Height * 0.08f),
			TopFunc = () => Assistant.Window.Size.Height * 0.001f,
			WidthFunc = () => Assistant.Window.Size.Height * 0.08f,
			HeightFunc = () => Assistant.Window.Size.Height * 0.018f,
		};

		var currentLevelDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 57, 137, 205, true, false, true),
			BackgroundTexture1 = Assistant.Texture.Button2TextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 0.5f,
			TextFunc = () => (Assistant.Game.LocalPlayer.CurrentLevelNormal < Assistant.Game.LocalPlayer.CurrentLevelNormalCap) ? Assistant.Game.LocalPlayer.CurrentLevelNormal.ToString("0") : "p" + Assistant.Game.LocalPlayer.CurrentLevelParagonDouble.ToString("0.##", CultureInfo.InvariantCulture),
			ExpandDownLabels = new List<TopLabelDecorator>(),
		};

		foreach (var levelIncrement in new uint[] { 1, 2, 5, 10, 20, 50, 100, 250, 500, 1000 }) {
			currentLevelDecorator.ExpandDownLabels.Add(
				new TopLabelDecorator(Assistant) {
					TextFont = Assistant.Render.CreateFont("Arial", 6, 180, 255, 255, 255, true, false, true),
					ExpandedHintFont = expandedHintFont,
					ExpandedHintWidthMultiplier = 2,
					BackgroundTexture1 = Assistant.Texture.Button2TextureOrange,
					BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
					BackgroundTextureOpacity1 = 1.0f,
					BackgroundTextureOpacity2 = 0.5f,
					HideBackgroundWhenTextIsEmpty = true,
					TextFunc = () => Assistant.Game.LocalPlayer.CurrentLevelNormal >= Assistant.Game.LocalPlayer.CurrentLevelNormalCap ? ("p" + (Assistant.Game.LocalPlayer.CurrentLevelParagon + levelIncrement).ToString("D", CultureInfo.InvariantCulture)) : null,
					HintFunc = () => ExpToParagonLevel(Assistant.Game.LocalPlayer.CurrentLevelParagon + levelIncrement) + " = " + TimeToParagonLevel(Assistant.Game.LocalPlayer.CurrentLevelParagon + levelIncrement, false),
				});
		}

		LabelList.LabelDecorators.Add(currentLevelDecorator);

		LabelList.LabelDecorators.Add(new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("Arial", 6, 255, 57, 137, 205, true, false, true),
			BackgroundTexture1 = Assistant.Texture.Button2TextureOrange,
			BackgroundTexture2 = Assistant.Texture.BackgroundTextureBlue,
			BackgroundTextureOpacity1 = 1.0f,
			BackgroundTextureOpacity2 = 0.5f,
			TextFunc = () => ValueToString(Assistant.Game.CurrentHeroToday.GainedExperiencePerHourPlay, ValueFormat.ShortNumber) + "/h",
		});
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.BeforeClip)
			return;

		LabelList.Paint();
	}

	public string ExpToParagonLevel(uint paragonLevel)
	{
		if (paragonLevel > Assistant.Game.LocalPlayer.CurrentLevelParagon) {
			var xpRequired = Assistant.Sno.TotalParagonExperienceRequired(paragonLevel);
			var xpRemaining = xpRequired - Assistant.Game.LocalPlayer.ParagonTotalExp;
			return ValueToString(xpRemaining, ValueFormat.LongNumber);
		}

		return null;
	}

	public string TimeToParagonLevel(uint paragonLevel, bool includetext)
	{
		var tracker = Assistant.Game.CurrentHeroToday;
		if (tracker != null) {
			if (paragonLevel > Assistant.Game.LocalPlayer.CurrentLevelParagon) {
				var text = includetext ? "p" + paragonLevel.ToString("D", CultureInfo.InvariantCulture) + ": " : "";
				var xph = tracker.GainedExperiencePerHourPlay;
				if (xph > 0) {
					var xpRequired = Assistant.Sno.TotalParagonExperienceRequired(paragonLevel);
					var xpRemaining = xpRequired - Assistant.Game.LocalPlayer.ParagonTotalExp;
					var hours = xpRemaining / xph;
					var ticks = Convert.ToInt64(Math.Ceiling(hours * 60.0d * 60.0d * 1000.0d * TimeSpan.TicksPerMillisecond));
					text += ValueToString(ticks, ValueFormat.LongTimeNoSeconds);
				} else {
					text += "-";
				}

				return text;
			}
		}

		return null;
	}
}
