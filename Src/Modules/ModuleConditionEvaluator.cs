namespace RiftAssistant.Modules;

internal class ModuleConditionEvaluator
{
	private readonly bool onlyInTown;

	private readonly bool onlyOutTown;

	private readonly bool onlyAtMaxLevel;

	private readonly bool onlyIdle;

	private readonly SnoPower[] requiredBuffPowers;

	private readonly int[] requiredBuffStacks;

	public ModuleConditionEvaluator(Conditions conditions)
	{
		if (conditions == null || !conditions.Enabled) {
			return;
		}

		onlyInTown = conditions.OnlyInTown;
		onlyOutTown = conditions.OnlyOutTown;
		onlyAtMaxLevel = conditions.OnlyAtMaxLevel;
		onlyIdle = conditions.OnlyIdle;

		string activeBuffsStr = conditions.ActiveBuffs;
		if (activeBuffsStr != null) {
			string[] buffsArray = activeBuffsStr.Split(',');
			requiredBuffPowers = new SnoPower[buffsArray.Length];
			requiredBuffStacks = new int[buffsArray.Length];

			for (int i = 0; i < buffsArray.Length; i++) {
				string[] buffData = buffsArray[i].Split('/');
				if (!uint.TryParse(buffData[0].Trim(), out var snoId)) {
					continue;
				}

				requiredBuffPowers[i] = SnoData.Powers.GetBySno(snoId);
				if (buffData.Length > 1) {
					if (!int.TryParse(buffData[1].Trim(), out requiredBuffStacks[i])) {
						requiredBuffStacks[i] = -1;
					}
				} else {
					requiredBuffStacks[i] = -1;
				}
			}
		}
	}

	public bool UpdateVisibilityAndOpacity(Module module, bool isParentVisible)
	{
		bool shouldBeVisible = EvaluateVisibility(module, isParentVisible);

		if (module.transparents != null) {
			if (!shouldBeVisible) {
				if (module.opacity >= 1f) {
					module.long_0 = CoreCollector.CurrentRealTimeTicks + (module.int_1 - 1) * 10000;
				}
			} else if (module.opacity <= 0f) {
				module.long_0 = CoreCollector.CurrentRealTimeTicks + (module.int_0 - 1) * 10000;
			}

			if (!shouldBeVisible) {
				if (!(module.opacity <= 0f) && module.bool_1) {
					module.opacity = (float)(module.long_0 - CoreCollector.CurrentRealTimeTicks) / 10000f / (float)module.int_1;
					for (int i = 0; i < module.transparents.Length; i++) {
						module.transparents[i].Opacity = module.opacity;
					}
					return true;
				}
				module.opacity = 0f;
				return false;
			}

			if (module.opacity >= 1f && !module.bool_2) {
				module.opacity = 1f;
				for (int j = 0; j < module.transparents.Length; j++) {
					module.transparents[j].Opacity = module.opacity;
				}
				return true;
			}

			module.opacity = ((module.long_0 > CoreCollector.CurrentRealTimeTicks) ? (1f - (float)(module.long_0 - CoreCollector.CurrentRealTimeTicks) / 10000f / (float)module.int_0) : 1f);
			for (int k = 0; k < module.transparents.Length; k++) {
				module.transparents[k].Opacity = module.opacity;
			}
		}

		return shouldBeVisible;
	}

	internal bool EvaluateVisibility(Module module, bool isParentVisible)
	{
		if (!module.Show || !isParentVisible) {
			return false;
		}
		if ((onlyInTown && !CoreCollector.IsInTown) || (onlyOutTown && CoreCollector.IsInTown)) {
			return false;
		}
		if (onlyAtMaxLevel && CoreCollector.LocalPlayer.CurrentLevelNormal < CoreCollector.LocalPlayer.CurrentLevelNormalCap) {
			return false;
		}
		if (onlyIdle && CoreCollector.IsGameReady && CoreCollector.LocalPlayer.AnimationState != AcdAnimationState.Idle) {
			return false;
		}
		if (requiredBuffPowers != null) {
			bool flag = false;
			for (int i = 0; i < requiredBuffPowers.Length; i++) {
				SnoPower snoPower = requiredBuffPowers[i];
				Buff buff = CoreCollector.LocalPlayer.Powers.GetBuff(snoPower.Sno);
				if (buff != null && buff.Active) {
					int num = requiredBuffStacks[i];
					if (num == -1 || buff.IconCounts[num] >= 1) {
						flag = true;
						break;
					}
				}
			}
			if (!flag) {
				return false;
			}
		}
		return true;
	}
}
