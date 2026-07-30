namespace Plugins;

public interface IPlugin
{
	bool Enabled { get; set; }

	void Load();
}
