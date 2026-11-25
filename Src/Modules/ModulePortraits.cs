namespace RiftAssistant.Modules;

internal class ModulePortraits : Module
{
	public ModulePortraits() : base(true)
	{
	}

	public void Update()
	{
		bool bool_ = Core.Controller.Game.Me.SnoArea != null && Overlay.Instance.ActiveMapMode != MapMode.Map && CoreCollector.D3Memory.IsUiHidden;
		if (!vmethod_0(bool_)) {
			return;
		}
		int num = 0;
		foreach (Player item in CoreCollector.PlayerCollector.PlayersInGame) {
			if (!item.IsMe) {
				num++;
			}
			int num2 = ((!item.IsMe) ? num : 0);
			UiElement uiElement = CoreCollector.UiElements.uiElements145[num2];
			Texture itexture_ = TextureManager.GetTextureById(uiElement.TextureSno);
			UiElement uiElement2 = CoreCollector.UiElements.uiElements146[num2];
			Texture textureById = TextureManager.GetTextureById(uiElement2.TextureSno);
			UiElement uiElement3 = CoreCollector.UiElements.uiElements147[num2];
			Texture texture3 = TextureManager.GetTextureById(uiElement3.TextureSno);
			float num3 = (float)GameWindowManager.Window.Size.Height * 0.0085f;
			DrawPortrait(num3 * 1.85f + (float)GameWindowManager.Window.Size.Height * 0.12f * (float)num2, num3, itexture_, textureById, texture3);
		}
	}

	private void DrawPortrait(float float_1, float float_2, Texture texture, Texture texture1, Texture texture2)
	{
		float num = (float)GameWindowManager.Window.Size.Height * 0.143f;
		float num2 = texture.Width / texture.Height * num;
		float num3 = num * 0.75f;
		float num4 = texture2.Width / texture2.Height * num3;
		texture2.Draw(float_1 + (num2 - num4) * 0.5f, float_2 + (num - num3) * 0.9f, num4, num3);
		float num5 = num * 0.3f;
		float num6 = texture1.Width / texture1.Height * num5;
		texture1.Draw(float_1 + (num2 - num6) * 0.52f, float_2 + (num - num5) * 0.49f, num6, num5);
		texture.Draw(float_1, float_2, num2, num);
	}
}
