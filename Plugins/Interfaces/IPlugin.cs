namespace Plugins;

public interface IPlugin
{
	bool Enabled { get; set; }

	int Order { get; set; }

	void Load();
}
