using System;
using System.Collections.Generic;
using System.Threading;

namespace Plugins.Default;

public class CooldownSoundPlayer : BasePlugin, ISkillCooldownHandler
{
	public bool EnableOnlyWhenIngameSoundIsEnabled { get; set; } = true;
	public Dictionary<SnoPower, CoolDownRule> CoolDownRules { get; } = new Dictionary<SnoPower, CoolDownRule>();

	public CooldownSoundPlayer()
	{
		Enabled = true;
	}

	public void RemoveRule(SnoPower snoPower)
	{
		if (!CoolDownRules.ContainsKey(snoPower))
			return;

		var rule = CoolDownRules[snoPower];
		rule.DisposeSoundPlayer();

		CoolDownRules.Remove(snoPower);
	}

	public void AddRule(SnoPower snoPower, string fileName)
	{
		var soundPlayer = Assistant.Sound.LoadSoundPlayer(fileName);
		if (soundPlayer == null) {
			return;
		}

		var rule = new CoolDownRule(snoPower, soundPlayer);
		CoolDownRules.Add(snoPower, rule);
	}

	public void OnCooldown(Skill playerSkill, bool expired)
	{
		if (!expired)
			return;
		if (playerSkill.Player != Assistant.Game.LocalPlayer)
			return;
		if (EnableOnlyWhenIngameSoundIsEnabled && !Assistant.Sound.IsIngameSoundEnabled)
			return;

		if (!CoolDownRules.TryGetValue(playerSkill.CurrentSnoPower, out var rule))
			return;
		if (rule == null)
			return;

		ThreadPool.QueueUserWorkItem(state => {
			try {
				rule.SoundPlayer.PlaySync();
			} catch (Exception) {
			}
		});
	}
}
