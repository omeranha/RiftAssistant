using SharpDX;
using System.Collections.Generic;

namespace Plugins;

public interface IUIComponent
{
	RectangleF Bounds { get; set; }

	void Draw(int menuX, int menuY);
	bool HandleInput(int mouseX, int mouseY, bool isMouseClicked);
}

public interface IMenuOption
{
	string Name { get; }

	IReadOnlyList<IUIComponent> GetComponents();
}
