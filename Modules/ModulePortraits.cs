using Plugins;
using work;

internal class ModulePortraits : Module
{
	public ModulePortraits() : base(true)
	{
		bool_1 = false;
	}

	public void method_1()
	{
		bool bool_ = Core.Controller.Game.Me.SnoArea != null && Overlay.Instance.mapMode_0 != MapMode.Map && CoreCollector.D3Memory.IsUiHidden;
		if (!vmethod_0(bool_)) {
			return;
		}
		int num = 0;
		foreach (Player item in CoreCollector.PlayerCollector.PlayersInGame) {
			if (!item.IsMe) {
				num++;
			}
			int num2 = ((!item.IsMe) ? num : 0);
			UiElement @class = CoreCollector.UiElements.class341_145[num2];
			Texture itexture_ = TextureManager.GetTextureById(@class.TextureSno);
			UiElement class2 = CoreCollector.UiElements.class341_146[num2];
			Texture itexture_2 = TextureManager.GetTextureById(class2.TextureSno);
			UiElement class3 = CoreCollector.UiElements.class341_147[num2];
			Texture itexture_3 = TextureManager.GetTextureById(class3.TextureSno);
			float num3 = (float)GameWindowManager.Window.Size.Height * 0.0085f;
			method_2(num3 * 1.85f + (float)GameWindowManager.Window.Size.Height * 0.12f * (float)num2, num3, itexture_, itexture_2, itexture_3);
		}
	}

	private void method_2(float float_1, float float_2, Texture itexture_0, Texture itexture_1, Texture itexture_2)
	{
		float num = (float)GameWindowManager.Window.Size.Height * 0.143f;
		float num2 = itexture_0.Width / itexture_0.Height * num;
		float num3 = num * 0.75f;
		float num4 = itexture_2.Width / itexture_2.Height * num3;
		itexture_2.Draw(float_1 + (num2 - num4) * 0.5f, float_2 + (num - num3) * 0.9f, num4, num3);
		float num5 = num * 0.3f;
		float num6 = itexture_1.Width / itexture_1.Height * num5;
		itexture_1.Draw(float_1 + (num2 - num6) * 0.52f, float_2 + (num - num5) * 0.49f, num6, num5);
		itexture_0.Draw(float_1, float_2, num2, num);
	}
}
