using System;
using Plugins;
using work;

internal abstract class Module : IDisposable
{
	public bool Show = true;

	public readonly ModuleConditionEvaluator class200_0;

	public float float_0;

	public ITransparent[] itransparent_0;

	public bool bool_1 = true;

	public bool bool_2 = true;

	public long long_0;

	public int int_0 = 130;

	public int int_1 = 130;

	public string string_1;

	public bool bool_3 = true;

	protected Module(bool enabled, Conditions conditions = null)
	{
		Overlay.Instance.modules.Add(this);
		Show = enabled;
		class200_0 = new ModuleConditionEvaluator(conditions);
	}

	public virtual void Dispose()
	{
		Overlay.Instance.modules.Remove(this);
	}

	protected void method_0(params ITransparent[] itransparent_1)
	{
		int num = 0;
		for (int i = 0; i < itransparent_1.Length; i++) {
			if (itransparent_1[i] != null) {
				num++;
			}
		}
		itransparent_0 = new ITransparent[num];
		num = 0;
		for (int j = 0; j < itransparent_1.Length; j++) {
			if (itransparent_1[j] != null) {
				itransparent_0[num] = itransparent_1[j];
				num++;
			}
		}
	}

	public virtual bool vmethod_0(bool bool_4)
	{
		return class200_0.UpdateVisibilityAndOpacity(this, bool_4);
	}
}
