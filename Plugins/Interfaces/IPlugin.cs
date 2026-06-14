using System.Collections.Generic;

namespace Plugins;

public interface IPlugin
{
	IController Hud { get; }

	bool Enabled { get; set; }

	int Order { get; set; }

	void Load(IController hud);
}
