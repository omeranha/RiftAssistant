namespace Plugins.Default;

public abstract class BasePlugin : IPlugin
{
	public Controller Assistant { get; private set; }

	public bool Enabled { get; set; }

	public int Order { get; set; }

	public void Load()
	{
		Load(Core.Controller);
	}

	public virtual void Load(Controller assistant)
	{
		Assistant = assistant;
	}

	public static string ValueToString(long value, ValueFormat format)
	{
		return Formatting.ValueToString(value, format);
	}

	public static string ValueToString(double value, ValueFormat format)
	{
		return Formatting.ValueToString(value, format);
	}
}
