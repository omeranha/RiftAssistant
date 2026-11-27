using System;

namespace Plugins;

[AttributeUsage(AttributeTargets.Property)]
public sealed class PluginSettingAttribute(string label) : Attribute
{
	public string Label { get; } = label;

	public int Min { get; set; }

	public int Max { get; set; } = 100;

	public int Step { get; set; } = 1;

	public string? Group { get; set; }
}

public interface IPluginSettings
{
	bool GetBool(string key, bool defaultValue);

	int GetInt(string key, int defaultValue);

	string GetString(string key, string defaultValue);

	void Set(string key, bool value);

	void Set(string key, int value);

	void Set(string key, string value);
}
