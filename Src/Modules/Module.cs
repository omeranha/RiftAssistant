using System;

namespace RiftAssistant.Modules;

internal abstract class Module : IDisposable
{
	public bool Show = true;

	public readonly ModuleConditionEvaluator moduleConditionEvaluator;

	public float opacity;

	public ITransparent[] transparents;

	public bool bool_1 = true;

	public bool bool_2 = true;

	public long long_0;

	public int int_0 = 130;

	public int int_1 = 130;


	public bool bool_3 = true;

	protected Module(bool enabled, Conditions conditions = null)
	{
		Overlay.Instance.modules.Add(this);
		Show = enabled;
		moduleConditionEvaluator = new ModuleConditionEvaluator(conditions);
	}

	public virtual void Dispose()
	{
		Overlay.Instance.modules.Remove(this);
	}

	protected void SetTransparentComponents(params ITransparent[] backgroundBrush)
	{
		int num = 0;
		for (int i = 0; i < backgroundBrush.Length; i++) {
			if (backgroundBrush[i] != null) {
				num++;
			}
		}
		transparents = new ITransparent[num];
		num = 0;
		for (int j = 0; j < backgroundBrush.Length; j++) {
			if (backgroundBrush[j] != null) {
				transparents[num] = backgroundBrush[j];
				num++;
			}
		}
	}

	public virtual bool vmethod_0(bool bool_4)
	{
		return moduleConditionEvaluator.UpdateVisibilityAndOpacity(this, bool_4);
	}
}
