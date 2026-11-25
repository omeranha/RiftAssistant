using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Plugins;

namespace RiftAssistant.PluginHost;

internal static class PluginSettingsBinder
{
	public static void Attach(IPlugin plugin)
	{
		var type = plugin.GetType();
		var settings = new List<(PropertyInfo Property, PluginSettingAttribute Attribute)>();
		foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)) {
			var attribute = property.GetCustomAttribute<PluginSettingAttribute>();
			if (attribute == null || !property.CanRead || !property.CanWrite || !IsSupported(property.PropertyType)) continue;

			settings.Add((property, attribute));
		}

		if (settings.Count == 0) return;

		var store = PluginSettingsStore.For(type.Name);
		foreach (var (property, attribute) in settings) {
			Restore(plugin, property, attribute, store);
		}

		var components = settings.Select(setting => CreateComponent(plugin, setting.Property, setting.Attribute, store)).ToList();
		SettingsMenuOptions.AddPluginSection(DisplayName(type.Name), components);
	}

	internal static string DisplayName(string typeName)
	{
		string name = typeName.EndsWith("Plugin", StringComparison.Ordinal) && typeName.Length > "Plugin".Length ? typeName[..^"Plugin".Length] : typeName;
		return Regex.Replace(name, @"(?<=[a-z0-9])(?=[A-Z])", " ");
	}

	private static bool IsSupported(Type type)
	{
		return type == typeof(bool) || type == typeof(int) || type == typeof(string) || type.IsEnum;
	}

	private static void Restore(IPlugin plugin, PropertyInfo property, PluginSettingAttribute attribute, IPluginSettings store)
	{
		try {
			var current = property.GetValue(plugin);
			if (property.PropertyType == typeof(bool)) {
				property.SetValue(plugin, store.GetBool(property.Name, (bool)current!));
			} else if (property.PropertyType == typeof(int)) {
				property.SetValue(plugin, Math.Clamp(store.GetInt(property.Name, (int)current!), attribute.Min, attribute.Max));
			} else if (property.PropertyType == typeof(string)) {
				property.SetValue(plugin, store.GetString(property.Name, (string?)current ?? ""));
			} else if (Enum.TryParse(property.PropertyType, store.GetString(property.Name, current!.ToString()!), true, out var parsed) && Enum.IsDefined(property.PropertyType, parsed!)) {
				property.SetValue(plugin, parsed);
			}
		} catch (Exception ex) {
			Logger.LogException($"[plugin settings] could not restore {plugin.GetType().Name}.{property.Name}: {ex.Message}");
		}
	}

	private static IUIComponent CreateComponent(IPlugin plugin, PropertyInfo property, PluginSettingAttribute attribute, IPluginSettings store)
	{
		string key = property.Name;
		if (property.PropertyType == typeof(bool)) {
			return new BoundCheckbox(attribute.Label, () => (bool)property.GetValue(plugin)!, value => Apply(plugin, property, value, () => store.Set(key, value)));
		}

		if (property.PropertyType == typeof(int)) {
			return new MenuStepper(attribute.Label, () => (int)property.GetValue(plugin)!, value => Apply(plugin, property, value, () => store.Set(key, value)), attribute.Min, attribute.Max, attribute.Step);
		}

		if (property.PropertyType == typeof(string)) {
			return new MenuTextBox(attribute.Label, () => (string?)property.GetValue(plugin) ?? "", value => Apply(plugin, property, value, () => store.Set(key, value)));
		}

		var names = Enum.GetNames(property.PropertyType);
		return new MenuChoice(attribute.Label, () => property.GetValue(plugin)!.ToString()!, value => Apply(plugin, property, Enum.Parse(property.PropertyType, value, true), () => store.Set(key, value)), () => names);
	}

	private static void Apply(IPlugin plugin, PropertyInfo property, object value, Action persist)
	{
		try {
			property.SetValue(plugin, value);
			persist();
		} catch (Exception ex) {
			Logger.LogException($"[plugin settings] could not change {plugin.GetType().Name}.{property.Name}: {ex.Message}");
		}
	}
}
