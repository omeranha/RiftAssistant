using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using structs;
using Plugins;
using work;

internal class UiElement : IUiElement
{
	public long long_0;

	public readonly ulong ulong_0;

	internal readonly int int_0;

	internal IUiElement iuiElement_0;

	internal IUiElement iuiElement_1;

	public int int_1 = -1;

	public bool bool_0;

	public RectangleF rectangleF_0;

	public float float_0;

	public float float_1;

	[CompilerGenerated]
	private readonly UiElementData class75_0 = new UiElementData();

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private IUiElement iuiElement_2;

	internal UiElementData Class75_0
	{
		[CompilerGenerated]
		get {
			return class75_0;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get {
			return string_0;
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get {
			return bool_1;
		}
		[CompilerGenerated]
		set {
			bool_1 = value;
		}
	}

	public RectangleF Rectangle => rectangleF_0;

	public int AnimState
	{
		get {
			if (!bool_0) {
				return 0;
			}
			return Class75_0.Index;
		}
	}

	public uint TextureSno
	{
		get {
			if (!bool_0) {
				return 0u;
			}
			return Class75_0.State;
		}
	}

	public float MinimapOffsetX => MR.Instance.ReadFloat(long_0 + 3216);

	public float MinimapOffsetY => MR.Instance.ReadFloat(long_0 + 3220);

	public uint LegendaryGemAcdId => MR.Instance.ReadUInt(long_0 + 3944);

	public uint AcdId => MR.Instance.ReadUInt(long_0 + 3248);

	public IUiElement ReplacementWhenNotVisible
	{
		[CompilerGenerated]
		get {
			return iuiElement_2;
		}
		[CompilerGenerated]
		internal set {
			iuiElement_2 = value;
		}
	}

	public UiElement(string string_1, IUiElement iuiElement_3 = null, IUiElement iuiElement_4 = null)
	{
		string_0 = string_1;
		ulong_0 = smethod_0(string_1.ToLower(CultureInfo.InvariantCulture));
		int_0 = (int)ulong_0;
		rectangleF_0 = default(RectangleF);
		iuiElement_0 = iuiElement_3;
		iuiElement_1 = iuiElement_4;
	}

	private static ulong smethod_0(string string_1)
	{
		ulong num = 14695981039346656037uL;
		for (int i = 0; i < string_1.Length; i++) {
			num ^= (byte)string_1[i];
			num *= 1099511628211L;
		}
		return num;
	}

	public string ReadText(Encoding encoding = null, bool removeColors = false)
	{
		if (Class75_0.UnknownPtr1 != 0L) {
			string text = MR.Instance.ReadString(Class75_0.UnknownPtr1, 256, encoding ?? Encoding.ASCII, bool_0: false);
			if (text.Length > 1 && text.StartsWith("\0c", ignoreCase: false, CultureInfo.InvariantCulture)) {
				int num = text.IndexOf('\0', 2);
				if (num > -1) {
					text = text.Remove(num).Trim();
				}
			} else {
				int num2 = text.IndexOf('\0');
				if (num2 > -1) {
					text = text.Remove(num2).Trim();
				}
			}
			if (removeColors) {
				text = text.Replace("{/c}", "");
				while (true) {
					int num3 = text.IndexOf("{c:");
					if (num3 == -1) {
						break;
					}
					int num4 = text.IndexOf("}", num3);
					if (num4 == -1) {
						break;
					}
					text = text.Remove(num3, num4 - num3 + 1);
				}
			}
			return text;
		}
		return null;
	}

	public string method_2(Encoding encoding_0 = null)
	{
		if (Class75_0.UnknownPtr2 != 0L) {
			long num = MR.Instance.ReadAddress(Class75_0.UnknownPtr2 + 2656);
			if (num != 0L) {
				return MR.Instance.ReadString(num, 256, encoding_0 ?? Encoding.ASCII, bool_0: true);
			}
		}
		return null;
	}

	public void Refresh()
	{
		CoreCollector.UiElements.Resolve(this);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_UIID struct23_0, int int_2, int int_3);

	public unsafe void method_3(string string_1, List<string> list_0)
	{
		if (Class75_0.ChildCount <= 0 || Class75_0.ChildCount >= 10000) {
			return;
		}
		r_UIID[] array = new r_UIID[Class75_0.ChildCount];
		ReadProcessMemory(MR.Instance.ProcessHandle, (IntPtr)Class75_0.ChildEntries, ref array[0], 536 * Class75_0.ChildCount, 0);
		for (int i = 0; i < Class75_0.ChildCount; i++) {
			fixed (r_UIID* pUiid = &array[i]) {
				sbyte* pName = pUiid->struct24_0;
				string text = new string(pName);
				if (text.StartsWith(string_1)) {
					list_0.Add(text);
				}
			}
		}
	}

	internal int method_4()
	{
		return Class75_0.ChildCount;
	}

	internal string method_5(int int_2, UiElementData class75_1)
	{
		long num = MR.Instance.ReadAddress(Class75_0.ChildEntries + 536 * int_2 + 520);
		MR.Instance.method_32(num, class75_1);
		return MR.Instance.ReadString(Class75_0.ChildEntries + 536 * int_2 + 8, 512, Encoding.ASCII, bool_0: true);
	}

	internal UiElementData method_6(string string_1, string string_2, out string string_3, Encoding encoding_0 = null)
	{
		int num = 0;
		string text;
		while (true) {
			if (num < Class75_0.ChildCount) {
				text = MR.Instance.ReadString(Class75_0.ChildEntries + 536 * num + 8, 512, encoding_0 ?? Encoding.ASCII, bool_0: true);
				if ((string_1 == null || text.StartsWith(string_1, StringComparison.InvariantCultureIgnoreCase)) && (string_2 == null || text.EndsWith(string_2, StringComparison.InvariantCultureIgnoreCase))) {
					break;
				}
				num++;
				continue;
			}
			string_3 = null;
			return null;
		}
		long num2 = MR.Instance.ReadAddress(Class75_0.ChildEntries + 536 * num + 520);
		UiElementData @class = new UiElementData();
		MR.Instance.method_32(num2, @class);
		string_3 = text;
		return @class;
	}

	public List<(string Text, int Top, int Bottom)> GetChildTextMetrics(Encoding encoding = null)
	{
		var list = new List<(string Text, int Top, int Bottom)>();
		UiElementData uiData = new();
		for (int i = 0; i < Class75_0.ChildCount; i++) {
			long address = MR.Instance.ReadAddress(Class75_0.ChildEntries + 536 * i + 520);
			MR.Instance.method_32(address, uiData);

			if (uiData.UnknownPtr1 == 0L) {
				continue;
			}

			float windowHeightScale = (float)GameWindowManager.Window.Size.Height / 1200f;
			float topF = Math.Min(2.1474836E+09f, Math.Max(-2.1474836E+09f, uiData.Top * windowHeightScale));
			float bottomF = Math.Min(2.1474836E+09f, Math.Max(-2.1474836E+09f, (uiData.Bottom - 1f) * windowHeightScale));
			string text = MR.Instance.ReadString(uiData.UnknownPtr1, 256, encoding ?? Encoding.ASCII, bool_0: true);
			list.Add((text, Convert.ToInt32(topF), Convert.ToInt32(bottomF)));
		}
		return list;
	}

	public bool CoordinateInsideRectangle(int x, int y)
	{
		if ((float)x >= Rectangle.Left && (float)y >= Rectangle.Top && (float)x < Rectangle.Left + rectangleF_0.Width) {
			return (float)y < Rectangle.Top + rectangleF_0.Height;
		}
		return false;
	}
}
