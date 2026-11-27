using System.Collections.Generic;
using System.Windows.Forms;

namespace Plugins.Default;

// Example: Assistant.GetPlugin<UiElementClickBlocker>().Add(Assistant.Render.RegisterUiElement("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Slot1.LayoutRoot.SwitchHero", null, null));
public class UiElementClickBlocker : BasePlugin, IMouseClickBlocker
{
	private readonly List<UiElement> _elements = new List<UiElement>();

	public UiElementClickBlocker()
	{
		Enabled = true;
	}

	public void Add(UiElement element)
	{
		lock (_elements) {
			_elements.Add(element);
		}
	}

	public void Remove(UiElement element)
	{
		lock (_elements) {
			_elements.Remove(element);
		}
	}

	public bool MouseClickShouldBeBlocked(MouseButtons button, int x, int y)
	{
		lock (_elements) {
			foreach (var element in _elements) {
				if (element.Visible && element.CoordinateInsideRectangle(x, y))
					return true;
			}
		}

		return false;
	}
}
