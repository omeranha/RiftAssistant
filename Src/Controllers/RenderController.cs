using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using SharpDX.Direct2D1;

namespace RiftAssistant.Controllers;

public partial class RenderController
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

	public UiElement InGameBottomHudUiElement => CoreCollector.UiElements.InGameBottomHudUiElement;

	public UiElement MonsterHpBarUiElement
	{
		get {
			if (CoreCollector.UiElements.HpBarNormalProgressbar.Visible) {
				return CoreCollector.UiElements.HpBarNormalProgressbar;
			}
			if (CoreCollector.UiElements.HpBarBountyProgressbar.Visible) {
				return CoreCollector.UiElements.HpBarBountyProgressbar;
			}
			if (CoreCollector.UiElements.HpBarSpecialProgressbar.Visible) {
				return CoreCollector.UiElements.HpBarSpecialProgressbar;
			}
			if (CoreCollector.UiElements.HpBarPlayerProgressbar.Visible) {
				return CoreCollector.UiElements.HpBarPlayerProgressbar;
			}
			if (CoreCollector.UiElements.HpBarMinionProgressbar.Visible) {
				return CoreCollector.UiElements.HpBarMinionProgressbar;
			}
			return null;
		}
	}

	public UiElement MinimapUiElement => CoreCollector.UiElements.MinimapUiElement;

	public UiElement NephalemRiftBarUiElement => CoreCollector.UiElements.NephalemRiftBarUiElement;

	public UiElement GreaterRiftBarUiElement => CoreCollector.UiElements.GreaterRiftBarUiElement;

	public UiElement ChallengeRiftBarUiElement => CoreCollector.UiElements.ChallengeRiftBarUiElement;

	public UiElement ChallengeRiftAheadPanelUiElement => CoreCollector.UiElements.ChallengeRiftAheadPanelUiElement;

	public UiElement ParagonLevelUpSplashTextUiElement => CoreCollector.UiElements.ParagonLevelUpSplashTextUiElement;

	public UiElement BuffBarExtendedBuffsUiElement => CoreCollector.UiElements.BuffBarExtendedBuffsUiElement;

	public IEnumerable<UiElement> BuffBarUiElements
	{
		get {
			string string_ = "Root.NormalLayer.buffs_backgroundScreen.buff_icon_wrapper.buff ";
			List<string> list = new List<string>(30);
			CoreCollector.UiElements.BuffIconWrapper.CollectChildPaths(string_, list);
			for (int i = 0; i < list.Count; i++) {
				string string_2 = list[i];
				yield return CoreCollector.UiElements.CreateTemporary(string_2);
			}
		}
	}

	public UiElement WorldMapUiElement => CoreCollector.UiElements.WorldMapUiElement;

	public UiElement ActMapUiElement => CoreCollector.UiElements.ActMapUiElement;

	public UiElement SalvageTabButton => CoreCollector.UiElements.salvageTabButton;

	public UiElement SalvageButton => CoreCollector.UiElements.salvageButton;

	public UiElement SalvageNormal => CoreCollector.UiElements.salvageNormal;

	public UiElement SalvageMagic => CoreCollector.UiElements.salvageMagic;

	public UiElement SalvageRare => CoreCollector.UiElements.salvageRare;

	public UiElement ChatOpened => CoreCollector.UiElements.chatOpened;

	public bool UiHidden => CoreCollector.D3Memory.IsUiHidden;

	public float MinimapScale => Overlay.Instance.MinimapScale;

	public IBrush CreateBrush(int a, int r, int g, int b, float strokeWidth, DashStyle dash = DashStyle.Solid, CapStyle startCap = CapStyle.Flat, CapStyle endCap = CapStyle.Flat)
	{
		RenderBrush renderBrush = new RenderBrush(a, r, g, b, strokeWidth, dash, startCap, endCap);
		brushes.Add(renderBrush);
		return renderBrush;
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

	public UiElement GetUiElement(string path)
	{
		UiElement uiElement = null;
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

	public UiElement RegisterUiElement(string path, UiElement collectOnlyWhenThisIsVisible, UiElement collectOnlyWhenThisIsInvisible, float inflateXby = 0f, float inflateYby = 0f)
	{
		return CoreCollector.UiElements.Register(path, collectOnlyWhenThisIsVisible, collectOnlyWhenThisIsInvisible, inflateXby, inflateYby);
	}

	public UiElement GetPlayerSkillUiElement(ActionKey key)
	{
		if (key == ActionKey.Heal) {
			return CoreCollector.UiElements.GamePotion;
		}
		if (key >= ActionKey.LeftSkill && (int)key < CoreCollector.UiElements.class341_144.Length) {
			return CoreCollector.UiElements.class341_144[(int)key];
		}
		return null;
	}

	public PathGeometry CreateGeometry()
	{
		return new PathGeometry(Overlay.Instance.direct2DFactory);
	}

	public void GetMinimapCoordinates(float x, float y, out float mapX, out float mapY)
	{
		Overlay.Instance.ToMinimapCoordinates(x, y, bool_0: true, out mapX, out mapY);
	}

	public bool IsConfirmationDialogVisible()
	{
		return CoreCollector.UiElements.confirmationOk.Visible;
	}

	public void SetHint(string text, string specialLocation = null)
	{
		Overlay.Instance.cursorHintModule?.SetHint(text, specialLocation);
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
			windowDC = GetWindowDC(handle);

			RECT rect = default;
			GetWindowRect(handle, ref rect);

			int width = rect.Right - rect.Left;
			int height = rect.Bottom - rect.Top;

			memDC = CreateCompatibleDC(windowDC);
			hBitmap = CreateCompatibleBitmap(windowDC, width, height);

			oldBitmap = SelectObject(memDC, hBitmap);
			BitBlt(memDC, 0, 0, width, height, windowDC, 0, 0, 0x00CC0020); // SRCCOPY
			using System.Drawing.Bitmap bitmap = System.Drawing.Image.FromHbitmap(hBitmap);
			Directory.CreateDirectory(Program.ScreenshotFolder);
			var path = Path.Combine(Program.ScreenshotFolder, filePath);
			bitmap.Save(path, ImageFormat.Png);
		} finally {
			if (oldBitmap != IntPtr.Zero)
				SelectObject(memDC, oldBitmap);

			if (hBitmap != IntPtr.Zero)
				DeleteObject(hBitmap);

			if (memDC != IntPtr.Zero)
				DeleteDC(memDC);

			if (windowDC != IntPtr.Zero)
				ReleaseDC(handle, windowDC);
		}
	}

	[LibraryImport("user32.dll")]
	private static partial IntPtr GetWindowRect(IntPtr handle, ref RECT rect);

	[LibraryImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool BitBlt(IntPtr memDC, int int_2, int int_3, int width, int height, IntPtr windowDC, int int_6, int int_7, int int_8);

	[LibraryImport("gdi32.dll")]
	private static partial IntPtr CreateCompatibleBitmap(IntPtr windowDC, int width, int height);

	[LibraryImport("gdi32.dll")]
	private static partial IntPtr CreateCompatibleDC(IntPtr windowDC);

	[LibraryImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool DeleteDC(IntPtr memDC);

	[LibraryImport("user32.dll")]
	private static partial IntPtr GetWindowDC(IntPtr handle);

	[LibraryImport("user32.dll")]
	private static partial IntPtr ReleaseDC(IntPtr handle, IntPtr windowDC);

	[LibraryImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static partial bool DeleteObject(IntPtr hBitmap);

	[LibraryImport("gdi32.dll")]
	private static partial IntPtr SelectObject(IntPtr memDC, IntPtr intptr_1);
}
