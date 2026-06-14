using System.Globalization;
using SharpDX;
using Plugins;
using SNO;
using work;

internal class ModuleConditionEvaluator
{
	private readonly bool onlyInTown;

	private readonly bool onlyOutTown;

	private readonly bool onlyAtMaxLevel;

	private readonly bool onlyIdle;

	private RectangleF? mouseNearRect;

	private RectangleF? mouseFarRect;

	private readonly ISnoPower[] requiredBuffPowers;

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
			requiredBuffPowers = new ISnoPower[buffsArray.Length];
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

		string mouseNearStr = conditions.MouseNear;
		if (mouseNearStr != null) {
			string[] rectData = mouseNearStr.Split(',');
			if (rectData.Length == 4 &&
				float.TryParse(rectData[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var x) &&
				float.TryParse(rectData[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var y) &&
				float.TryParse(rectData[2], NumberStyles.Any, CultureInfo.InvariantCulture, out var width) &&
				float.TryParse(rectData[3], NumberStyles.Any, CultureInfo.InvariantCulture, out var height)) {
				mouseNearRect = new RectangleF(x, y, width, height);
			}
		}

		string mouseFarStr = conditions.MouseFar;
		if (mouseFarStr != null) {
			string[] rectData = mouseFarStr.Split(',');
			if (rectData.Length == 4 &&
				float.TryParse(rectData[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var x) &&
				float.TryParse(rectData[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var y) &&
				float.TryParse(rectData[2], NumberStyles.Any, CultureInfo.InvariantCulture, out var width) &&
				float.TryParse(rectData[3], NumberStyles.Any, CultureInfo.InvariantCulture, out var height)) {
				mouseFarRect = new RectangleF(x, y, width, height);
			}
		}
	}

	public bool UpdateVisibilityAndOpacity(Module module, bool isParentVisible)
	{
		bool shouldBeVisible = EvaluateVisibility(module, isParentVisible);

		if (module.itransparent_0 != null) {
			if (!shouldBeVisible) {
				if (module.float_0 >= 1f) {
					module.long_0 = CoreCollector.CurrentRealTimeTicks + (module.int_1 - 1) * 10000;
				}
			} else if (module.float_0 <= 0f) {
				module.long_0 = CoreCollector.CurrentRealTimeTicks + (module.int_0 - 1) * 10000;
			}

			if (!shouldBeVisible) {
				if (!(module.float_0 <= 0f) && module.bool_1) {
					module.float_0 = (float)(module.long_0 - CoreCollector.CurrentRealTimeTicks) / 10000f / (float)module.int_1;
					for (int i = 0; i < module.itransparent_0.Length; i++) {
						module.itransparent_0[i].Opacity = module.float_0;
					}
					return true;
				}
				module.float_0 = 0f;
				return false;
			}

			if (module.float_0 >= 1f && !module.bool_2) {
				module.float_0 = 1f;
				for (int j = 0; j < module.itransparent_0.Length; j++) {
					module.itransparent_0[j].Opacity = module.float_0;
				}
				return true;
			}

			module.float_0 = ((module.long_0 > CoreCollector.CurrentRealTimeTicks) ? (1f - (float)(module.long_0 - CoreCollector.CurrentRealTimeTicks) / 10000f / (float)module.int_0) : 1f);
			for (int k = 0; k < module.itransparent_0.Length; k++) {
				module.itransparent_0[k].Opacity = module.float_0;
			}
		}

		return shouldBeVisible;
	}

	internal bool EvaluateVisibility(Module class205_0, bool isParentVisible)
	{
		if (!class205_0.Show || !isParentVisible) {
			return false;
		}
		if (class205_0.string_1 != null && (Overlay.Instance.class112_0.Contains(class205_0.string_1) || class205_0.bool_3)) {
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
				ISnoPower snoPower = requiredBuffPowers[i];
				IBuff buff = CoreCollector.LocalPlayer.Powers.GetBuff(snoPower.Sno);
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
