using System;
using Plugins;
using SNO;


public class Skill
{
	private readonly Player player;

	public Player Player => player;

	public SnoPower SnoPower { get; set; }

	public byte Rune { get; set; }

	public ActionKey Key { get; set; }

	public SnoPower OverrideSnoPower { get; set; }

	public SnoPower CurrentSnoPower
	{
		get {
			if (player.bool_13 && this != player.Powers.HealthPotionSkill) {
				return OverrideSnoPower;
			}
			return SnoPower;
		}
	}

	public string RuneNameLocalized
	{
		get {
			if (Rune != byte.MaxValue) {
				return SnoPower.RuneNamesLocalized[Rune];
			}
			return SnoData.Strings.GetStringById(StringListSnoEnum._skillpane, 101573322u);
		}
	}

	public string RuneNameEnglish
	{
		get {
			if (Rune != byte.MaxValue) {
				return SnoPower.RuneNamesEnglish[Rune];
			}
			return SnoData.Strings.GetStringByIdEnglish(StringListSnoEnum._skillpane, 101573322u);
		}
	}

	public bool IsOnCooldown { get; set; }

	public int CooldownFinishTick { get; set; }

	public int CooldownStartTick { get; set; }

	public int ElementalType { get; set; }

	public int WeaponDamageMultiplier
	{
		get {
			if (SnoPower.WeaponDamageMultipliersByRune == null) {
				return 0;
			}
			int num = ((Rune != byte.MaxValue) ? (Rune + 1) : 0);
			return SnoPower.WeaponDamageMultipliersByRune[num];
		}
	}

	public float DotSeconds
	{
		get {
			if (SnoPower.DotSecondsByRune == null) {
				return 0f;
			}
			int num = ((Rune != byte.MaxValue) ? (Rune + 1) : 0);
			return SnoPower.DotSecondsByRune[num];
		}
	}

	public float DamageBonus
	{
		get {
			player.dictionary_5.TryGetValue(SnoPower.Sno, out var value);
			if (SnoPower.SynergyPower != null && player.dictionary_5.TryGetValue(SnoPower.Sno, out var value2)) {
				return value + value2;
			}
			return value;
		}
	}

	public float ElementalDamageBonus => player.Offense.ElementalDamageBonus[ElementalType];

	public bool BuffIsActive => player.Powers.GetBuff(SnoPower.Sno)?.Active ?? false;

	public Buff Buff => player.Powers.GetBuff(SnoPower.Sno);

	public int Charges
	{
		get {
			player.class112_0.TryGetValue(SnoPower.Sno, out var gparam_);
			return gparam_;
		}
	}

	public float ResourceCost
	{
		get {
			if (SnoPower.ResourceCostsByRune == null) {
				return 0f;
			}
			int num = ((Rune != byte.MaxValue) ? (Rune + 1) : 0);
			return SnoPower.ResourceCostsByRune[num];
		}
	}

	public Vk Keybind { get; set; } = Vk.None;

	public Skill(Player player, SnoPower snoPower, byte rune, ActionKey actionKey)
	{
		this.player = player;
		this.SnoPower = snoPower;
		this.Rune = rune;
		this.Key = actionKey;
		if (SnoPower.ElementalDamageTypesByRune != null) {
			int num = ((Rune != byte.MaxValue) ? (Rune + 1) : 0);
			this.ElementalType = SnoPower.ElementalDamageTypesByRune[num];
		}

		if (this.Key is >= ActionKey.Skill1 and <= ActionKey.Skill4) {
			int keybindIndex = this.Key switch {
				ActionKey.Skill1 => 34,
				ActionKey.Skill2 => 35,
				ActionKey.Skill3 => 36,
				_ => 37
			};

			var keybind = CoreCollector.GameSettingsManager.Keybinds[keybindIndex].Primary.Key;
			Keybind = GameSettingsManager.ToVk(keybind);
		} else if (this.Key == ActionKey.LeftSkill) {
			Keybind = Vk.LBUTTON;
		} else if (this.Key == ActionKey.RightSkill) {
			Keybind = Vk.RBUTTON;
		}
	}

	public float GetResourceRequirement()
	{
		float resourceCost = ResourceCost;
		if (resourceCost != -1f) {
			return GetResourceRequirement(resourceCost);
		}
		return -1f;
	}

	public float GetResourceRequirement(float baseRequirement)
	{
		baseRequirement = Math.Abs(baseRequirement);
		if ((SnoPower.Sno == 375088 || SnoPower.Sno == 375049 || SnoPower.Sno == 373143 || SnoPower.Sno == 375082) && Player.Powers.UsedMonkPowers.ChantOfResonance != null) {
			baseRequirement *= 0.5f;
		}
		float num = 0f;
		float num2 = 0f;
		int elementalType = ElementalType;
		if (elementalType != -1) {
			num = player.float_4[elementalType];
			num2 = player.float_5[elementalType];
		}
		float num3 = 0f;
		if (Player.Powers.BuffIsActive(74499u, 3)) {
			num3 += 3f;
		}
		float num4 = 0f;
		if (SnoPower.Sno == 353492 && Player.Powers.BuffIsActive(318885u)) {
			num4 = 1f - 0.6f * (1f - num4);
		}
		if (Player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_PierceTheVeil.Sno)) {
			num4 = 1f - 1.3f * (1f - num4);
		}
		if (Player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.WitchDoctor_Passive_BloodRitual.Sno)) {
			num4 = 1f - 0.8f * (1f - num4);
		}
		Buff buff = Player.Powers.GetBuff(Core.Controller.Sno.SnoPowers.Necromancer_Devour.Sno);
		if (buff != null && buff.Active && buff != null && buff.IconCounts[2] > 0) {
			num4 = 1f - (1f - (float)buff.IconCounts[2] * 0.02f) * (1f - num4);
		}
		if (Player.Powers.BuffIsActive(Core.Controller.Sno.SnoPowers.Necromancer_LandOfTheDead.Sno, 3)) {
			num4 = 1f;
		}
		player.dictionary_3.TryGetValue(SnoPower.Sno, out var value);
		return baseRequirement * (1f - num) * (1f - num2) * (1f - num4) - (float)value - num3;
	}

	public float CalculateCooldown(float baseCooldown)
	{
		player.dictionary_4.TryGetValue(SnoPower.Sno, out var value);
		return baseCooldown * (1f - player.Stats.CooldownReduction) - (float)value;
	}
}
