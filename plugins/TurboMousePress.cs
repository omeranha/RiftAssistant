namespace Plugins.Default;

internal class TurboMousePress : BasePlugin, IKeyEventHandler, IBeforeRenderHandler
{
	private bool holdMB2;

	private long nextMB1PressAtMs;
	private long nextMB2PressAtMs;
	private const long TURBO_DELAY_MS = 50;

	public TurboMousePress()
	{
		Enabled = true;
	}

	public void OnKeyEvent(InputEvent keyEvent)
	{
		if (keyEvent.Is(Vk.OEM_3, true)) {
			holdMB2 = !holdMB2;
			Assistant.Input.Click(Vk.RBUTTON, holdMB2);
		}
	}

	public void BeforeRender()
	{
		if (!Assistant.Window.IsForeground) return;

		var now = Assistant.Game.CurrentRealTimeMilliseconds;

		if (Assistant.Input.IsKeyDown(Vk.XBUTTON1) && now >= nextMB1PressAtMs) {
			Assistant.Input.Click(Vk.LBUTTON);
			nextMB1PressAtMs = now + TURBO_DELAY_MS;
		}

		if (Assistant.Input.IsKeyDown(Vk.F5) && now >= nextMB2PressAtMs) {
			Assistant.Input.Click(Vk.RBUTTON);
			nextMB2PressAtMs = now + TURBO_DELAY_MS;
		}
	}
}
