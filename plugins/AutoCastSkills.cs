using System;

namespace Plugins.Default;

[Flags]
public enum CastSlots
{
	None = 0,
	LeftSkill = 1,
	RightSkill = 2,
	Skill1 = 4,
	Skill2 = 8,
	Skill3 = 16,
	Skill4 = 32
}

// F2 toggles the casting outside greater rifts, where it is always on. The profile used is the one of the class the hero plays.
internal sealed class AutoCastSkills : BasePlugin, IBeforeRenderHandler, IKeyEventHandler
{
	private const string ProfilesGroup = "Skills to auto cast, per class";
	private const CastSlots DefaultSlots = CastSlots.Skill1 | CastSlots.Skill2 | CastSlots.Skill3 | CastSlots.Skill4;

	private static readonly (CastSlots Flag, ActionKey Key)[] Slots = [
		(CastSlots.LeftSkill, ActionKey.LeftSkill),
		(CastSlots.RightSkill, ActionKey.RightSkill),
		(CastSlots.Skill1, ActionKey.Skill1),
		(CastSlots.Skill2, ActionKey.Skill2),
		(CastSlots.Skill3, ActionKey.Skill3),
		(CastSlots.Skill4, ActionKey.Skill4)
	];

	private bool autoCastEnabled;

	[PluginSetting("Barbarian", Group = ProfilesGroup)]
	public CastSlots Barbarian { get; set; } = DefaultSlots;

	[PluginSetting("Crusader", Group = ProfilesGroup)]
	public CastSlots Crusader { get; set; } = DefaultSlots;

	[PluginSetting("Demon Hunter", Group = ProfilesGroup)]
	public CastSlots DemonHunter { get; set; } = DefaultSlots;

	[PluginSetting("Monk", Group = ProfilesGroup)]
	public CastSlots Monk { get; set; } = DefaultSlots;

	[PluginSetting("Necromancer", Group = ProfilesGroup)]
	public CastSlots Necromancer { get; set; } = DefaultSlots;

	[PluginSetting("Witch Doctor", Group = ProfilesGroup)]
	public CastSlots WitchDoctor { get; set; } = DefaultSlots;

	[PluginSetting("Wizard", Group = ProfilesGroup)]
	public CastSlots Wizard { get; set; } = DefaultSlots;

	public AutoCastSkills()
	{
		Enabled = true;
	}

	public override void Load(Controller assistant)
	{
		base.Load(assistant);
		ApplyLegacySettings(assistant.GetPluginSettings(this));
	}

	public void OnKeyEvent(InputEvent keyEvent)
	{
		if (keyEvent.Is(Vk.F2, true)) {
			autoCastEnabled = !autoCastEnabled;
		}
	}

	public void BeforeRender()
	{
		if (!autoCastEnabled && Assistant.Game.SpecialArea != SpecialArea.GreaterRift) return;

		if (!Assistant.Window.IsForeground || !Assistant.Game.IsInGame || Assistant.Game.IsLoading || Assistant.Game.IsPaused || Assistant.Render.ChatOpened.Visible) return;

		var me = Assistant.Game.LocalPlayer;
		if (me == null || !me.HasValidActor || me.IsDead || me.HeroClassDefinition == null) return;

		var profile = ProfileOf(me.HeroClassDefinition.HeroClass);
		if (profile == CastSlots.None) return;

		var skillSlots = me.Powers?.SkillSlots;
		if (skillSlots == null) return;

		foreach (var (flag, key) in Slots) {
			if ((profile & flag) == 0) continue;

			var slotIndex = (int)key;
			if ((uint)slotIndex >= (uint)skillSlots.Length) continue;

			var skill = skillSlots[slotIndex];
			if (skill == null || skill.CurrentSnoPower == null || skill.IsOnCooldown) continue;

			Assistant.Input.PressKey(skill.Keybind);
		}
	}

	private CastSlots ProfileOf(HeroClass heroClass)
	{
		return heroClass switch {
			HeroClass.Barbarian => Barbarian,
			HeroClass.Crusader => Crusader,
			HeroClass.DemonHunter => DemonHunter,
			HeroClass.Monk => Monk,
			HeroClass.Necromancer => Necromancer,
			HeroClass.WitchDoctor => WitchDoctor,
			HeroClass.Wizard => Wizard,
			_ => CastSlots.None
		};
	}

	// Before profiles existed, one checkbox per skill slot applied to every class. They become the starting profile of each class until it is changed.
	private void ApplyLegacySettings(IPluginSettings settings)
	{
		var legacy = CastSlots.None;
		foreach (var (flag, key) in Slots) {
			if (settings.GetBool("Skill." + key, (DefaultSlots & flag) != 0)) legacy |= flag;
		}

		Barbarian = Crusader = DemonHunter = Monk = Necromancer = WitchDoctor = Wizard = legacy;
	}
}
