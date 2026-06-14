using System.Collections.Generic;

namespace Plugins;

public interface ITransparentCollection
{
	IEnumerable<ITransparent> GetTransparents();
}
