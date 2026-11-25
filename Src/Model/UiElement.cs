using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace RiftAssistant.Model;

public class UiElement
{
	public long long_0;

	public readonly ulong ulong_0;

	internal readonly int int_0;

	internal UiElement iuiElement_0;

	internal UiElement iuiElement_1;

	public int Bucket = -1;

	public bool bool_0;

	public RectangleF rectangle;

	public float PaddingX;

	public float PaddingY;

	internal UiElementData Class75_0 { get; set; } = new UiElementData();

	public string Path { get; }

	public bool Visible { get; set; }

	public RectangleF Rectangle => rectangle;

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

	public float MinimapOffsetX => GameWindowManager.Read<float>(long_0 + 3216);

	public float MinimapOffsetY => GameWindowManager.Read<float>(long_0 + 3220);

	public uint LegendaryGemAcdId => GameWindowManager.Read<uint>(long_0 + 3944);

	public uint AcdId => GameWindowManager.Read<uint>(long_0 + 3248);

	public UiElement ReplacementWhenNotVisible { get; internal set; }

	public UiElement(string path2, UiElement iuiElement_3 = null, UiElement iuiElement_4 = null)
	{
		Path = path2;
		ulong_0 = HashPath(path2.ToLower(CultureInfo.InvariantCulture));
		int_0 = (int)ulong_0;
		rectangle = default(RectangleF);
		iuiElement_0 = iuiElement_3;
		iuiElement_1 = iuiElement_4;
	}

	private static ulong HashPath(string string_1)
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
			string text = GameWindowManager.ReadString(Class75_0.UnknownPtr1, 256, encoding ?? Encoding.ASCII, false);
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

	public void Refresh()
	{
		CoreCollector.UiElements.Resolve(this);
	}

	public unsafe void CollectChildPaths(string string_1, List<string> list_0)
	{
		if (Class75_0.ChildCount <= 0 || Class75_0.ChildCount >= 10000) {
			return;
		}
		r_UIID[] array = new r_UIID[Class75_0.ChildCount];
		array = GameWindowManager.ReadArray<r_UIID>(Class75_0.ChildEntries, Class75_0.ChildCount);
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

	internal int GetChildCount()
	{
		return Class75_0.ChildCount;
	}

	internal long ReadChildDataAddress(int index)
	{
		return GameWindowManager.Read<long>(Class75_0.ChildEntries + 536 * index + 520);
	}

	public List<(string Text, int Top, int Bottom)> GetChildTextMetrics(Encoding encoding = null)
	{
		var list = new List<(string Text, int Top, int Bottom)>();
		for (int i = 0; i < Class75_0.ChildCount; i++) {
			long address = GameWindowManager.Read<long>(Class75_0.ChildEntries + 536 * i + 520);
			var uiData = GameWindowManager.Read<UiElementData>(address);
			if (uiData.UnknownPtr1 == 0L) {
				continue;
			}

			float windowHeightScale = (float)GameWindowManager.Window.Size.Height / 1200f;
			float topF = Math.Min(2.1474836E+09f, Math.Max(-2.1474836E+09f, uiData.Top * windowHeightScale));
			float bottomF = Math.Min(2.1474836E+09f, Math.Max(-2.1474836E+09f, (uiData.Bottom - 1f) * windowHeightScale));
			string text = GameWindowManager.ReadString(uiData.UnknownPtr1, 256, encoding ?? Encoding.ASCII, true);
			list.Add((text, Convert.ToInt32(topF), Convert.ToInt32(bottomF)));
		}
		return list;
	}

	public bool CoordinateInsideRectangle(int x, int y)
	{
		if ((float)x >= Rectangle.Left && (float)y >= Rectangle.Top && (float)x < Rectangle.Left + rectangle.Width) {
			return (float)y < Rectangle.Top + rectangle.Height;
		}
		return false;
	}
}
