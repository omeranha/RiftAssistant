using System.Collections.Generic;

namespace Plugins.Default;

public class PickupRange : BasePlugin, ITransparentCollection, IInGameWorldPainter
{
	public IBrush FillBrush { get; set; }
	public IBrush OutlineBrush { get; set; }
	public IFader Fader { get; set; }

	public PickupRange()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);

		FillBrush = Assistant.Render.CreateBrush(3, 255, 255, 255, 0);
		OutlineBrush = Assistant.Render.CreateBrush(12, 0, 0, 0, 3);
		Fader = new StandardFader(Assistant, this);
	}

	public void PaintWorld(WorldLayer layer)
	{
		var visible = !Assistant.Game.IsInTown && (Assistant.Game.LocalPlayer.AnimationState == AcdAnimationState.Running) && (Assistant.Game.MapMode == MapMode.Minimap);
		if (!Fader.TestVisiblity(visible))
			return;

		OutlineBrush.DrawWorldEllipse(Assistant.Game.LocalPlayer.Stats.PickupRange, -1, Assistant.Game.LocalPlayer.FloorCoordinate);
		FillBrush.DrawWorldEllipse(Assistant.Game.LocalPlayer.Stats.PickupRange, -1, Assistant.Game.LocalPlayer.FloorCoordinate);
	}

	public IEnumerable<ITransparent> GetTransparents()
	{
		yield return FillBrush;
		yield return OutlineBrush;
	}
}
