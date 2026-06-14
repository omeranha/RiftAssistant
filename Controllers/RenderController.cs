using Plugins;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D11;
using SharpDX.WIC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using work;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

internal class RenderController : IRenderController
{
	private bool isRenderEnabled = true;

	private readonly List<RenderBrush> brushes = [];

	public bool IsRenderEnabled
	{
		get {
			return isRenderEnabled;
		}
		set {
			isRenderEnabled = value;
		}
	}

	public IUiElement InGameBottomHudUiElement => CoreCollector.UiElements.class341_64;

	public IUiElement MonsterHpBarUiElement
	{
		get {
			if (CoreCollector.UiElements.class341_179.Visible) {
				return CoreCollector.UiElements.class341_179;
			}
			if (CoreCollector.UiElements.class341_180.Visible) {
				return CoreCollector.UiElements.class341_180;
			}
			if (CoreCollector.UiElements.class341_183.Visible) {
				return CoreCollector.UiElements.class341_183;
			}
			if (CoreCollector.UiElements.class341_182.Visible) {
				return CoreCollector.UiElements.class341_182;
			}
			if (CoreCollector.UiElements.class341_181.Visible) {
				return CoreCollector.UiElements.class341_181;
			}
			return null;
		}
	}

	public IUiElement MinimapUiElement => CoreCollector.UiElements.class341_85;

	public IUiElement NephalemRiftBarUiElement => CoreCollector.UiElements.class341_172;

	public IUiElement GreaterRiftBarUiElement => CoreCollector.UiElements.class341_173;

	public IUiElement ChallengeRiftBarUiElement => CoreCollector.UiElements.class341_174;

	public IUiElement ChallengeRiftAheadPanelUiElement => CoreCollector.UiElements.class341_175;

	public IUiElement ParagonLevelUpSplashTextUiElement => CoreCollector.UiElements.class341_90;

	public IUiElement BuffBarExtendedBuffsUiElement => CoreCollector.UiElements.class341_128;

	public IEnumerable<IUiElement> BuffBarUiElements
	{
		get {
			string string_ = "Root.NormalLayer.buffs_backgroundScreen.buff_icon_wrapper.buff ";
			List<string> list = new List<string>(30);
			CoreCollector.UiElements.class341_127.method_3(string_, list);
			for (int i = 0; i < list.Count; i++) {
				string string_2 = list[i];
				yield return CoreCollector.UiElements.CreateTemporary(string_2);
			}
		}
	}

	public IUiElement WorldMapUiElement => CoreCollector.UiElements.class341_86;

	public IUiElement ActMapUiElement => CoreCollector.UiElements.class341_88;

	public IUiElement SalvageTabButton => CoreCollector.UiElements.salvageTabButton;

	public IUiElement SalvageButton => CoreCollector.UiElements.salvageButton;

	public IUiElement SalvageNormal => CoreCollector.UiElements.salvageNormal;

	public IUiElement SalvageMagic => CoreCollector.UiElements.salvageMagic;

	public IUiElement SalvageRare => CoreCollector.UiElements.salvageRare;

	public IUiElement ChatOpened => CoreCollector.UiElements.chatOpened;

	public bool UiHidden => CoreCollector.D3Memory.IsUiHidden;

	public float MinimapScale => Overlay.Instance.float_3;

	public IBrush CreateBrush(int a, int r, int g, int b, float strokeWidth, DashStyle dash = DashStyle.Solid, CapStyle startCap = CapStyle.Flat, CapStyle endCap = CapStyle.Flat)
	{
		RenderBrush @class = new RenderBrush(a, r, g, b, strokeWidth, dash, startCap, endCap);
		brushes.Add(@class);
		return @class;
	}

	public IFont CreateFont(string fontFamily, float size, int a, int r, int g, int b, bool bold, bool italic, bool standardShadow)
	{
		return new RenderFont(a, r, g, b, fontFamily, bold, italic, size, Alignment.Left, false, standardShadow);
	}

	public IFont CreateFont(string fontFamily, float size, int a, int r, int g, int b, bool bold, bool italic, int shadowA, int shadowR, int shadowG, int shadowB, bool shadowIsHeavy)
	{
		RenderFont transparent = new RenderFont(a, r, g, b, fontFamily, bold, italic, size, Alignment.Left, false, false);
		transparent.SetShadowBrush(shadowA, shadowR, shadowG, shadowB, shadowIsHeavy);
		return transparent;
	}

	public IUiElement GetUiElement(string path)
	{
		IUiElement uiElement = null;
		switch (path) {
			case "*portrait-p3":
				uiElement = CoreCollector.UiElements.class341_145[3];
				break;
			case "*portrait-p2":
				uiElement = CoreCollector.UiElements.class341_145[2];
				break;
			case "*portrait-p1":
				uiElement = CoreCollector.UiElements.class341_145[1];
				break;
			case "*portrait-p0":
				uiElement = CoreCollector.UiElements.class341_145[0];
				break;
			case "*portrait-bottom": {
					uiElement = CoreCollector.UiElements.class341_145[0];
					for (int i = 0; i < CoreCollector.UiElements.class341_145.Length && CoreCollector.UiElements.class341_145[i].Visible; i++) {
						uiElement = CoreCollector.UiElements.class341_145[i];
					}
					break;
				}
		}
		if (uiElement == null) {
			CoreCollector.UiElements.All.TryGetValue(path, out var value);
			uiElement = value;
			if (uiElement != null && !uiElement.Visible && uiElement.ReplacementWhenNotVisible != null) {
				uiElement = uiElement.ReplacementWhenNotVisible;
			}
		}
		return uiElement;
	}

	public IUiElement RegisterUiElement(string path, IUiElement collectOnlyWhenThisIsVisible, IUiElement collectOnlyWhenThisIsInvisible, float inflateXby = 0f, float inflateYby = 0f)
	{
		return CoreCollector.UiElements.Register(path, collectOnlyWhenThisIsVisible, collectOnlyWhenThisIsInvisible, inflateXby, inflateYby);
	}

	public IUiElement GetPlayerSkillUiElement(ActionKey key)
	{
		if (key == ActionKey.Heal) {
			return CoreCollector.UiElements.class341_143;
		}
		if (key >= ActionKey.LeftSkill && (int)key < CoreCollector.UiElements.class341_144.Length) {
			return CoreCollector.UiElements.class341_144[(int)key];
		}
		return null;
	}

	public PathGeometry CreateGeometry()
	{
		return new PathGeometry(Overlay.Instance.factory_0);
	}

	public void GetMinimapCoordinates(float x, float y, out float mapX, out float mapY)
	{
		Overlay.Instance.method_4(x, y, bool_0: true, out mapX, out mapY);
	}

	public bool IsConfirmationDialogVisible()
	{
		return CoreCollector.UiElements.confirmationOk.Visible;
	}

	public void SetHint(string text, string specialLocation = null)
	{
		Overlay.Instance.class208_0?.SetHint(text, specialLocation);
	}

	public void TurnOnAliasing()
	{
		Overlay.Instance.renderTarget.AntialiasMode = AntialiasMode.Aliased;
	}

	public void TurnOffAliasing()
	{
		Overlay.Instance.renderTarget.AntialiasMode = AntialiasMode.PerPrimitive;
	}

	public void ScreenshotToFile(string filePath)
	{
		IntPtr windowDC = IntPtr.Zero;
		IntPtr memDC = IntPtr.Zero;
		IntPtr hBitmap = IntPtr.Zero;
		IntPtr oldBitmap = IntPtr.Zero;
		var handle = GameWindowManager.Window.Handle;

		try {
			windowDC = Win32.User32.GetWindowDC(handle);

			Win32.RECT rect = default;
			Win32.User32.GetWindowRect(handle, ref rect);

			int width = rect.Right - rect.Left;
			int height = rect.Bottom - rect.Top;

			memDC = Win32.ScreenCapture.CreateCompatibleDC(windowDC);
			hBitmap = Win32.ScreenCapture.CreateCompatibleBitmap(windowDC, width, height);

			oldBitmap = Win32.ScreenCapture.SelectObject(memDC, hBitmap);
			Win32.ScreenCapture.BitBlt(memDC, 0, 0, width, height, windowDC, 0, 0, 0x00CC0020); // SRCCOPY
			using System.Drawing.Bitmap bitmap = System.Drawing.Image.FromHbitmap(hBitmap);
			Directory.CreateDirectory(Path.Combine(Program.AppDir, "screenshots"));
			var path = Path.Combine(Program.AppDir, "screenshots", filePath);
			bitmap.Save(path, ImageFormat.Png);
		} finally {
			if (oldBitmap != IntPtr.Zero)
				Win32.ScreenCapture.SelectObject(memDC, oldBitmap);

			if (hBitmap != IntPtr.Zero)
				Win32.ScreenCapture.DeleteObject(hBitmap);

			if (memDC != IntPtr.Zero)
				Win32.ScreenCapture.DeleteDC(memDC);

			if (windowDC != IntPtr.Zero)
				Win32.User32.ReleaseDC(handle, windowDC);
		}
	}
}
