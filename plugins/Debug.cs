using System;
using System.Globalization;
using System.Linq;

namespace Plugins.Default;

public class Debug : BasePlugin, IInGameTopPainter
{
	public IFont PluginPerfFont { get; set; }
	public TopLabelDecorator RenderTimeDecorator { get; set; }
	public TopLabelDecorator MemoryUsageDecorator { get; set; }
	public TopLabelDecorator MemoryReadsDecorator { get; set; }
	public bool PluginPerformanceCountersEnabled { get; set; } = false;

	public Debug()
	{
		Enabled = false;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		RenderTimeDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("courier new", 6, 255, 0, 255, 0, true, false, false),
			TextFunc = () => Assistant.Stat.RenderPerfCounter.LastValue.ToString("F0") + " (" + Assistant.Stat.RenderPerfCounter.LastCount.ToString("F0") + " FPS)",
		};

		MemoryUsageDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("courier new", 6, 255, 255, 50, 50, true, false, false),
			TextFunc = () => (GC.GetTotalMemory(false) / 1024.0 / 1024.0).ToString("F0") + " MB",
		};

		MemoryReadsDecorator = new TopLabelDecorator(Assistant) {
			TextFont = Assistant.Render.CreateFont("courier new", 6, 255, 255, 200, 50, true, false, false),
			TextFunc = () => Assistant.Stat.MemoryReadPerfCounter.LastValue.ToString("F0") + " reads/s",
		};

		PluginPerfFont = Assistant.Render.CreateFont("tahoma", 6, 255, 255, 255, 255, false, false, false);
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.AfterClip)
			return;

		RenderTimeDecorator.Paint(Assistant.Window.Size.Width * 0.92f, Assistant.Window.Size.Height * 0.0000f, Assistant.Window.Size.Width * 0.08f, Assistant.Window.Size.Height * 0.01f, HorizontalAlign.Right);
		MemoryUsageDecorator.Paint(Assistant.Window.Size.Width * 0.84f, Assistant.Window.Size.Height * 0.0000f, Assistant.Window.Size.Width * 0.08f, Assistant.Window.Size.Height * 0.01f, HorizontalAlign.Right);

		MemoryReadsDecorator.Paint(Assistant.Window.Size.Width * 0.74f, Assistant.Window.Size.Height * 0.0000f, Assistant.Window.Size.Width * 0.10f, Assistant.Window.Size.Height * 0.01f, HorizontalAlign.Right);

		if (PluginPerformanceCountersEnabled) {
			PaintPluginPerformanceCounters();
		}
	}

	private void PaintPluginPerformanceCounters()
	{
		var startXcoord = Assistant.Game.LocalPlayer.PortraitUiElement.Rectangle.Right + (Assistant.Game.LocalPlayer.PortraitUiElement.Rectangle.Width * 0.3f);
		var yCoord = Assistant.Game.LocalPlayer.PortraitUiElement.Rectangle.Top;
		var nameColumnWidth = Assistant.Game.LocalPlayer.PortraitUiElement.Rectangle.Width * 4;
		var perfColumnWidth = Assistant.Game.LocalPlayer.PortraitUiElement.Rectangle.Width * 3;

		var plugins = Assistant.AllPlugins.Where(p => p.Enabled);

		var pluginNameText = "PLUGIN NAME";
		using (var pluginNameLayout = PluginPerfFont.GetTextLayoutManualDispose(pluginNameText)) {
			PluginPerfFont.DrawText(pluginNameLayout, startXcoord, yCoord);

			var text = "ACTION =  CPU_TIME/SEC (CALLS/SEC)";
			using (var layout = PluginPerfFont.GetTextLayoutManualDispose(text)) {
				PluginPerfFont.DrawText(layout, startXcoord + nameColumnWidth, yCoord);
			}

			yCoord += pluginNameLayout.Metrics.Height;
		}

		foreach (var plugin in plugins) {
			var counters = Assistant.Stat.GetPluginCounters(plugin).Where(x => x.Value.LastCount > 0);
			if (!counters.Any())
				continue;

			pluginNameText = plugin.GetType().FullName;
			using (var pluginNameLayout = PluginPerfFont.GetTextLayoutManualDispose(pluginNameText)) {
				PluginPerfFont.DrawText(pluginNameLayout, startXcoord, yCoord);

				var xCoord = startXcoord + nameColumnWidth;

				foreach (var perf in counters) {
					var text = perf.Key + " = " + perf.Value.LastValue.ToString("F1", CultureInfo.InvariantCulture) + " (" + perf.Value.LastCount.ToString("F1", CultureInfo.InvariantCulture) + ")";
					using (var layout = PluginPerfFont.GetTextLayoutManualDispose(text)) {
						PluginPerfFont.DrawText(layout, xCoord, yCoord);
					}

					xCoord += perfColumnWidth;
				}

				yCoord += pluginNameLayout.Metrics.Height;
			}
		}
	}
}
