using System;
using System.Globalization;

namespace Plugins.Default;

public class ParagonCapture : BasePlugin, IBeforeRenderHandler
{
	public int DelayBetweenFrames { get; set; } = 200;

	private DateTime lastLevelUpTimestamp;

	public ParagonCapture()
	{
		Enabled = true;
	}

	public void BeforeRender()
	{
		if (!Assistant.Game.IsInGame) return;

		bool captureActive = Assistant.Render.ParagonLevelUpSplashTextUiElement.Visible && !string.IsNullOrEmpty(Assistant.BattleTag);
		if (!captureActive) {
			return;
		}

		var now = DateTime.Now;
		if (now - lastLevelUpTimestamp < TimeSpan.FromMinutes(2)) return;

		lastLevelUpTimestamp = now;
		Logger.LogParagonLevel();
		var me = Assistant.Game.LocalPlayer;
		var timestamp = now.ToString("MM-dd-yyyy-HH-mm-ss", CultureInfo.InvariantCulture);
		string fileName = $"{Assistant.BattleTag}_{me.CurrentLevelParagon:D}_{timestamp}.png";
		Assistant.Render.ScreenshotToFile(fileName);
	}
}
