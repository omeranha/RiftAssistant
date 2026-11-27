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
		foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(property => property.MetadataToken)) {
			var attribute = property.GetCustomAttribute<PluginSettingAttribute>();
			if (attribute == null || !property.CanRead || !property.CanWrite || !IsSupported(property.PropertyType)) continue;

			settings.Add((property, attribute));
		}

		if (settings.Count == 0) return;

		var store = PluginSettingsStore.For(type.Name);
		foreach (var (property, attribute) in settings) {
			Restore(plugin, property, attribute, store);
		}

		var components = new List<IUIComponent>();
		string? group = null;
		foreach (var (property, attribute) in settings) {
			if (!string.IsNullOrEmpty(attribute.Group) && attribute.Group != group) components.Add(new MenuHeading(attribute.Group));
			group = attribute.Group;
			components.Add(CreateComponent(plugin, property, attribute, store));
		}

		Core.SettingsMenu.AddSection(DisplayName(type.Name), components);
	}

	internal static string DisplayName(string typeName)
	{
		string name = typeName.EndsWith("Plugin", StringComparison.Ordinal) && typeName.Length > "Plugin".Length ? typeName[..^"Plugin".Length] : typeName;
		return SplitWords(name);
	}

	private static string SplitWords(string name)
	{
		return Regex.Replace(name, @"(?<=[a-z0-9])(?=[A-Z])", " ");
	}

	private static bool IsSupported(Type type)
	{
		return type == typeof(bool) || type == typeof(int) || type == typeof(string) || type.IsEnum;
	}

	private static bool IsFlags(Type type)
	{
		return type.IsEnum && type.IsDefined(typeof(FlagsAttribute), false);
	}

	private static long AllFlags(Type type)
	{
		return Enum.GetValues(type).Cast<object>().Aggregate(0L, (mask, value) => mask | Convert.ToInt64(value));
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
			} else if (Enum.TryParse(property.PropertyType, store.GetString(property.Name, current!.ToString()!), true, out var parsed) && IsValidEnumValue(property.PropertyType, parsed!)) {
				property.SetValue(plugin, parsed);
			}
		} catch (Exception ex) {
			Logger.LogException($"[plugin settings] could not restore {plugin.GetType().Name}.{property.Name}: {ex.Message}");
		}
	}

	private static bool IsValidEnumValue(Type type, object value)
	{
		return IsFlags(type) ? (Convert.ToInt64(value) & ~AllFlags(type)) == 0 : Enum.IsDefined(type, value);
	}

	private static IUIComponent CreateComponent(IPlugin plugin, PropertyInfo property, PluginSettingAttribute attribute, IPluginSettings store)
	{
		string key = property.Name;
		if (property.PropertyType == typeof(bool)) {
			return new SettingToggleRow(attribute.Label, () => (bool)property.GetValue(plugin)!, value => Apply(plugin, property, value, () => store.Set(key, value)));
		}

		if (property.PropertyType == typeof(int)) {
			return new SettingStepperRow(attribute.Label, () => (int)property.GetValue(plugin)!, value => Apply(plugin, property, value, () => store.Set(key, value)), attribute.Min, attribute.Max, attribute.Step);
		}

		if (property.PropertyType == typeof(string)) {
			return new SettingTextRow(attribute.Label, () => (string?)property.GetValue(plugin) ?? "", value => Apply(plugin, property, value, () => store.Set(key, value)));
		}

		if (IsFlags(property.PropertyType)) return CreateFlagsComponent(plugin, property, attribute, store);

		var names = Enum.GetNames(property.PropertyType);
		return new SettingChoiceRow(attribute.Label, () => property.GetValue(plugin)!.ToString()!, value => Apply(plugin, property, Enum.Parse(property.PropertyType, value, true), () => store.Set(key, value)), () => names);
	}

	private static IUIComponent CreateFlagsComponent(IPlugin plugin, PropertyInfo property, PluginSettingAttribute attribute, IPluginSettings store)
	{
		var type = property.PropertyType;
		var members = Enum.GetNames(type).Select(name => (Name: name, Value: Convert.ToInt64(Enum.Parse(type, name)))).Where(member => member.Value != 0).ToArray();
		var labels = members.Select(member => SplitWords(member.Name)).ToArray();
		bool IsOn(int index) => (Convert.ToInt64(property.GetValue(plugin)) & members[index].Value) == members[index].Value;
		void Toggle(int index, bool on)
		{
			long current = Convert.ToInt64(property.GetValue(plugin));
			var value = Enum.ToObject(type, on ? current | members[index].Value : current & ~members[index].Value);
			Apply(plugin, property, value, () => store.Set(property.Name, value.ToString()!));
		}

		return new SettingFlagsRow(attribute.Label, labels, IsOn, Toggle);
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
