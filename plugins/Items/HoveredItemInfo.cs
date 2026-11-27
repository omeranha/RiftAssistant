using System.Globalization;
using System.Diagnostics;

namespace Plugins.Default;

public class HoveredItemInfo : BasePlugin, IInGameTopPainter
{
	public IFont ItemLevelFont { get; set; }
	public TopLabelDecorator LegendaryNameDecorator { get; set; }
	public TopLabelDecorator SetNameDecorator { get; set; }
	public bool CanCubedEnabled { get; set; }
	private Stopwatch _watch = new();

	public HoveredItemInfo()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		ItemLevelFont = Assistant.Render.CreateFont("Arial", 7, 255, 154, 105, 24, true, false, 128, 0, 0, 0, true);

		LegendaryNameDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 10, 235, 235, 110, 0, false, false, true),
			TextFunc = () => Assistant.Inventory.HoveredItem.FullNameLocalized,
		};

		SetNameDecorator = new TopLabelDecorator(Assistant) {
			BackgroundBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, 0),
			BorderBrush = Assistant.Render.CreateBrush(255, 0, 0, 0, -1),
			TextFont = Assistant.Render.CreateFont("Arial", 10, 255, 50, 220, 50, false, false, true),
			TextFunc = () => Assistant.Inventory.HoveredItem.FullNameLocalized,
		};

		_watch = Stopwatch.StartNew();
	}

	public void PaintTopInGame(ClipState clipState)
	{
		if (clipState != ClipState.AfterClip)
			return;

		var item = Assistant.Inventory.HoveredItem;
		if (item == null)
			return;

		var uicMain = Assistant.Inventory.GetHoveredItemMainUiElement();
		var uicTop = Assistant.Inventory.GetHoveredItemTopUiElement();

		if (item.Unidentified) {
			var decorator = (item.SetSno != uint.MaxValue) ? SetNameDecorator : LegendaryNameDecorator;

			decorator.Paint(uicTop.Rectangle.Left, uicTop.Rectangle.Top, uicTop.Rectangle.Width, uicTop.Rectangle.Height * 0.7f, HorizontalAlign.Center);
		}

		var iLevelText = "i" + item.SnoItem.Level.ToString("D", CultureInfo.InvariantCulture);
		var iLevelLayout = ItemLevelFont.GetTextLayout(iLevelText);
		ItemLevelFont.DrawText(iLevelLayout, uicTop.Rectangle.Left - (Assistant.Window.Size.Height * 0.0166f), uicTop.Rectangle.Top + (((Assistant.Window.Size.Height * 0.022f) - iLevelLayout.Metrics.Height) / 2));

		var inKanaiCube = Assistant.Game.LocalPlayer.IsCubed(item.SnoItem);
		var canKanaiCube = !inKanaiCube && item.SnoItem.CanKanaiCube;

		if (inKanaiCube || canKanaiCube) {
			var cubeTexture = Assistant.Texture.KanaiCubeTexture;
			var h = cubeTexture.Height * 1.35f / 1200.0f * Assistant.Window.Size.Height;
			var rh = h;
			if (canKanaiCube && CanCubedEnabled) {
				var mod = _watch.ElapsedMilliseconds % 1000;
				var ratio = 0.8f + (1.2f / 1000.0f * (mod < 500 ? mod : 1000 - mod));
				rh *= ratio;
			}

			var x = uicMain.Rectangle.Right - (h * 0.75f) - ((rh - h) / 2);
			var y = uicTop.Rectangle.Top - (h * 0.5f) - ((rh - h) / 2);
			cubeTexture.Draw(x, y, rh, rh, 1);
		}
	}
}
