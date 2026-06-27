using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DirectWrite;
using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;
using Plugins;

namespace work;

internal class Overlay
{
	private float statusX;

	private float statusY;

	private Matrix3x2 matrix3x2_0;

	public SharpDX.Direct3D11.Device device_0;

	public SwapChain swapChain_0;

	public Surface surface_0;

	internal RenderTarget renderTarget;

	public SwapChainDescription swapChainDescription_0;

	public RenderTargetProperties renderTargetProperties_0;

	private Layer layer_0;

	public static Overlay Instance;

	private readonly Controller controller;

	public readonly Form Frm;

	public readonly SharpDX.Direct2D1.Factory factory_0;

	public readonly SharpDX.DirectWrite.Factory factory_1;

	public OverlayDisplayState State = OverlayDisplayState.Normal;

	private Stopwatch stopwatch_0 = new();

	public Plugins.MapMode mapMode_0;

	public float float_2;

	public float float_3;

	public float float_4;

	public float float_5;

	public float float_6;

	public float float_7;

	public float float_8;

	public EventHandler PaintTop_BeforeClip;

	public EventHandler PaintTop_AfterClip;

	public EventHandler PaintTop_Inventory;

	public EventHandler PaintWorld_Ground;

	public EventHandler PaintWorld_Map;

	public EventHandler BeforeRender;

	public RenderFont font1;

	public RenderFont font2;

	public RenderFont class221_2;

	public RenderFont class221_3;

	public RenderFont class221_4;

	public RenderFont class221_5;

	public RenderFont class221_6;

	public RenderFont class221_7;

	public RenderFont font4;

	public RenderFont font3;

	public RenderFont class221_10;

	public RenderFont class221_11;

	public RenderFont StatusMessage;

	public RenderFont class221_13;

	public RenderFont class221_14;

	public RenderFont class221_15;

	public readonly Class91 class93_0;

	public readonly List<UiElement> list_0 = [];

	public SceneMapRenderer class204_0 = new();

	internal ModulePlayerInfo class213_0;

	internal ModulePortraitPlayerStats class212_0;

	internal ModulePortraits class206_0;

	public ModuleStatTracker ModuleStatTracker;

	internal ModuleCursorHint class208_0;
	internal ModuleLobbyHeroes class209_0;

	public Class112<string, string> class112_0 = new Class112<string, string>();

	internal readonly List<Module> modules = [];

	public void ResetStatusDrawPosition()
	{
		statusX = 3f;
		statusY = GameWindowManager.Window.Size.Height;
	}

	public void DrawStatus(string text, RenderFont font, bool spacing = true)
	{
		TextLayout textLayout = font.GetTextLayout(text);
		float num = GameWindowManager.Window.Size.Height - Convert.ToInt32(Math.Round(textLayout.Metrics.Height));
		if (num <= statusY) {
			statusY = num;
		}
		font.DrawText(textLayout, statusX, num);
		statusX += textLayout.Metrics.Width + (spacing ? (textLayout.Metrics.Height / 5f) : 1f);
	}

	public void method_3()
	{
		RawMatrix3x2 transform = renderTarget.Transform;
		Matrix3x2 matrix3x = Matrix3x2.Rotation(-(float)Math.PI / 4f);
		Matrix3x2 matrix3x2 = Matrix3x2.Translation(float_5, float_6);
		matrix3x2_0 = transform * matrix3x * matrix3x2;
		renderTarget.Transform = matrix3x2_0;
		try {
			class204_0.RenderMap();
		} catch (Exception exception_) {
			Logger.LogException(exception_.Message);
		}
		renderTarget.Transform = transform;
		try {
			PaintWorld_Map?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception_2) {
			Logger.LogException(exception_2.Message);
		}
		if (mapMode_0 == Plugins.MapMode.Minimap) {
			if (Core.Controller.SceneReveal.MinimapClip) {
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(0f, 0f, float_5 - float_2 / 2f, GameWindowManager.Window.Size.Height), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(float_5 - float_2 / 2f, 0f, (float)GameWindowManager.Window.Size.Width - (float_5 - float_2 / 2f), float_6 - float_2 / 2f), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(float_5 - float_2 / 2f, float_6 + float_2 / 2f, (float)GameWindowManager.Window.Size.Width - (float_5 - float_2 / 2f), (float)GameWindowManager.Window.Size.Height - (float_6 + float_2 / 2f)), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
			}
			renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(float_5 + float_2 / 2f, float_6 - float_2 / 2f, (float)GameWindowManager.Window.Size.Width - (float_5 + float_2 / 2f), float_2), AntialiasMode.PerPrimitive);
			renderTarget.Clear(SharpDX.Color.Transparent);
			renderTarget.PopAxisAlignedClip();
		}
	}

	public void method_4(float float_9, float statusY0, bool bool_0, out float statusY1, out float statusY2)
	{
		statusY1 = (float_7 + CoreCollector.LocalPlayer.FloorCoordinate.X - float_9) * float_2 / 350f;
		statusY2 = (0f - (float_8 + CoreCollector.LocalPlayer.FloorCoordinate.Y - statusY0)) * float_2 / 350f;
		if (bool_0) {
			float num = statusY1 * matrix3x2_0.M11 + statusY2 * matrix3x2_0.M21 + matrix3x2_0.M31;
			float num2 = statusY1 * matrix3x2_0.M12 + statusY2 * matrix3x2_0.M22 + matrix3x2_0.M32;
			statusY1 = num;
			statusY2 = num2;
		}
	}

	private void method_5()
	{
		surface_0 = Surface.FromSwapChain(swapChain_0, 0);
		renderTarget = new RenderTarget(factory_0, surface_0, renderTargetProperties_0) {
			AntialiasMode = AntialiasMode.PerPrimitive,
			TextAntialiasMode = SharpDX.Direct2D1.TextAntialiasMode.Grayscale
		};
	}

	private void form_0_SizeChanged(object sender, EventArgs e)
	{
		method_19();
		swapChain_0.ResizeBuffers(swapChainDescription_0.BufferCount, 0, 0, Format.Unknown, SwapChainFlags.None);
		method_5();
		method_6();
	}

	private void method_6()
	{
		RenderFont.CleanupCache(true);
		foreach (Module item in modules.ToArray()) {
			item.Dispose();
		}
		class204_0.DisposeTextures();
		if (Core.Settings != null) {
			RecreateSharedFonts();
			InitializeModulesFromConfig(Core.Settings);
		}
	}

	public void method_7(float float_9 = 1f)
	{
		Layer layer = new Layer(renderTarget, new Size2F(GameWindowManager.Window.Size.Width, GameWindowManager.Window.Size.Height));
		LayerParameters layerParameters = new LayerParameters {
			ContentBounds = new SharpDX.RectangleF(0f, 0f, GameWindowManager.Window.Size.Width, GameWindowManager.Window.Size.Height),
			Opacity = float_9
		};
		renderTarget.PushLayer(ref layerParameters, layer);
		layer_0 = layer;
	}

	public void method_8()
	{
		renderTarget.PopLayer();
		layer_0.Dispose();
		layer_0 = null;
	}

	public void method_9(params UiElement[] class341_0)
	{
		if (CoreCollector.D3Memory.IsUiHidden) {
			return;
		}
		for (int i = 0; i < list_0.Count; i++) {
			UiElement @class = list_0[i];
			if (@class == null || !@class.Visible) {
				continue;
			}
			if (class341_0 != null) {
				bool flag = false;
				for (int j = 0; j < class341_0.Length; j++) {
					if (class341_0[j] == @class) {
						flag = true;
						break;
					}
				}
				if (flag) {
					continue;
				}
			}
			float height = @class.rectangleF_0.Height;
			if (@class == CoreCollector.UiElements.class341_11 || @class == CoreCollector.UiElements.class341_9 || @class == CoreCollector.UiElements.class341_15 || @class == CoreCollector.UiElements.class341_47 || @class == CoreCollector.UiElements.class341_46) {
				height = CoreCollector.UiElements.class341_64.rectangleF_0.Top;
			}
			renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(@class.rectangleF_0.Left, @class.rectangleF_0.Top, @class.rectangleF_0.Width, height), AntialiasMode.PerPrimitive);
			renderTarget.Clear(SharpDX.Color.Transparent);
			renderTarget.PopAxisAlignedClip();
		}
	}

	public SharpDX.Direct2D1.Bitmap method_10(System.Drawing.Bitmap bitmap_0, bool bool_0 = false)
	{
		if (bool_0) {
			bitmap_0.MakeTransparent(System.Drawing.Color.Black);
		}
		BitmapData bitmapData = bitmap_0.LockBits(new System.Drawing.Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
		using DataStream dataStream = new DataStream(bitmapData.Scan0, bitmapData.Stride * bitmapData.Height, canRead: true, canWrite: false);
		BitmapProperties bitmapProperties = new BitmapProperties {
			PixelFormat = new SharpDX.Direct2D1.PixelFormat(Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied)
		};
		SharpDX.Direct2D1.Bitmap result = new SharpDX.Direct2D1.Bitmap(renderTarget, new Size2(bitmap_0.Width, bitmap_0.Height), dataStream, bitmapData.Stride, bitmapProperties);
		bitmap_0.UnlockBits(bitmapData);
		return result;
	}

	public void DisposeRenders(params IDisposable[] idisposable_0)
	{
		for (int i = 0; i < idisposable_0.Length; i++) {
			idisposable_0[i]?.Dispose();
		}
	}

	public Overlay(Controller controller)
	{
		this.controller = controller;
		Instance = this;
		Frm = new FormOverlay();
		Frm.SetBounds(0, 0, 0, 0);
		Frm.SizeChanged += form_0_SizeChanged;
		factory_0 = new SharpDX.Direct2D1.Factory();
		factory_1 = new SharpDX.DirectWrite.Factory();
		RawInput.Start();
		swapChainDescription_0 = new SwapChainDescription {
			BufferCount = 2,
			ModeDescription = new ModeDescription(0, 0, new Rational(60, 1), Format.R8G8B8A8_UNorm),
			IsWindowed = true,
			OutputHandle = Frm.Handle,
			SampleDescription = new SampleDescription(1, 0),
			SwapEffect = SwapEffect.Discard,
			Usage = Usage.RenderTargetOutput,
			Flags = SwapChainFlags.None
		};
		renderTargetProperties_0 = new RenderTargetProperties {
			DpiX = 96f,
			DpiY = 96f,
			MinLevel = SharpDX.Direct2D1.FeatureLevel.Level_10,
			PixelFormat = new SharpDX.Direct2D1.PixelFormat(Format.R8G8B8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied),
			Type = RenderTargetType.Hardware,
			Usage = RenderTargetUsage.None
		};
		SharpDX.Direct3D.FeatureLevel featureLevel = SharpDX.Direct3D.FeatureLevel.Level_9_1;
		try {
			featureLevel = SharpDX.Direct3D11.Device.GetSupportedFeatureLevel();
		} catch (Exception ex) {
			Logger.Info($"Error occurred while querying supported feature level: {ex.Message}");
		}
		SharpDX.Direct3D11.Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.BgraSupport, new SharpDX.Direct3D.FeatureLevel[1] { featureLevel }, swapChainDescription_0, out device_0, out swapChain_0);
		method_5();
		FileStream stream_ = new FileStream(Path.Combine(Program.AppDir, "data", "resource_data.bin"), FileMode.Open, FileAccess.Read, FileShare.Read);
		class93_0 = new Class91(stream_);
		method_12();
	}

	private void method_12()
	{
		list_0.Add(CoreCollector.UiElements.class341_11);
		list_0.Add(CoreCollector.UiElements.class341_12);
		list_0.Add(CoreCollector.UiElements.class341_14);
		list_0.Add(CoreCollector.UiElements.class341_9);
		list_0.Add(CoreCollector.UiElements.class341_17);
		list_0.Add(CoreCollector.UiElements.class341_18);
		list_0.Add(CoreCollector.UiElements.class341_46);
		list_0.Add(CoreCollector.UiElements.class341_47);
		list_0.Add(CoreCollector.UiElements.class341_68);
		list_0.Add(CoreCollector.UiElements.class341_73);
		list_0.Add(CoreCollector.UiElements.class341_52);
		list_0.Add(CoreCollector.UiElements.class341_54);
		list_0.Add(CoreCollector.UiElements.class341_53);
		list_0.Add(CoreCollector.UiElements.class341_56);
		list_0.Add(CoreCollector.UiElements.class341_75);
		list_0.Add(CoreCollector.UiElements.class341_76);
		list_0.Add(CoreCollector.UiElements.class341_164);
		list_0.Add(CoreCollector.UiElements.class341_6);
		list_0.Add(CoreCollector.UiElements.class341_15);
		list_0.Add(CoreCollector.UiElements.class341_16);
		list_0.Add(CoreCollector.UiElements.class341_84);
		list_0.Add(CoreCollector.UiElements.class341_86);
		list_0.Add(CoreCollector.UiElements.class341_88);
		list_0.Add(CoreCollector.UiElements.class341_87);
		list_0.Add(CoreCollector.UiElements.class341_148);
		list_0.Add(CoreCollector.UiElements.class341_57);
		list_0.Add(CoreCollector.UiElements.class341_71);
		list_0.Add(CoreCollector.UiElements.class341_151);
		list_0.Add(CoreCollector.UiElements.class341_150);
		list_0.Add(CoreCollector.UiElements.class341_149);
		list_0.Add(CoreCollector.UiElements.class341_156);
		list_0.Add(CoreCollector.UiElements.class341_77);
		list_0.Add(CoreCollector.UiElements.class341_78);
		list_0.Add(CoreCollector.UiElements.class341_79);
		list_0.Add(CoreCollector.UiElements.class341_89);
		list_0.Add(CoreCollector.UiElements.class341_80);
		list_0.Add(CoreCollector.UiElements.class341_81);
		list_0.Add(CoreCollector.UiElements.class341_83);
		list_0.Add(CoreCollector.UiElements.class341_159);
		list_0.Add(CoreCollector.UiElements.class341_158);
		list_0.Add(CoreCollector.UiElements.class341_160);
		list_0.Add(CoreCollector.UiElements.class341_161);
		list_0.Add(CoreCollector.UiElements.class341_55);
		list_0.Add(CoreCollector.UiElements.class341_162);
		list_0.Add(CoreCollector.UiElements.class341_163);
		list_0.Add(CoreCollector.UiElements.class341_165);
		list_0.Add(CoreCollector.UiElements.class341_166);
		list_0.Add(CoreCollector.UiElements.class341_139);
		list_0.Add(CoreCollector.UiElements.class341_167);
		list_0.Add(CoreCollector.UiElements.class341_170);
		list_0.Add(CoreCollector.UiElements.class341_168);
		list_0.Add(CoreCollector.UiElements.class341_169);
		list_0.Add(CoreCollector.UiElements.class341_171);
		list_0.Add(CoreCollector.UiElements.class341_178);
	}

	internal void RecreateSharedFonts()
	{
		DisposeRenders(font1, font2, class221_2, class221_3, class221_4, class221_7, font4, font3, class221_5, class221_6, class221_10, class221_11, StatusMessage, class221_14, class221_15, class221_13);
		font1 = new RenderFont(192, 184, 164, 164, "Arial", true, false, 8f, Alignment.Left, false, true);
		font2 = new RenderFont(192, 184, 124, 0, "Arial", true, false, 8f, Alignment.Left, false, true);
		class221_2 = new RenderFont(192, 160, 160, 160, "Arial", true, false, 7f, Alignment.Left, false, true);
		class221_3 = new RenderFont(192, 100, 160, 100, "Arial", true, false, 6f, Alignment.Left, false, true);
		class221_4 = new RenderFont(160, 255, 128, 128, "Arial", true, false, 8f, Alignment.Left, false, true);
		class221_7 = new RenderFont(160, 255, 200, 255, "Arial", true, false, 8f, Alignment.Left, false, true);
		font4 = new RenderFont(160, 255, 64, 64, "Arial", true, false, 8f, Alignment.Left, false, true);
		font3 = new RenderFont(160, 128, 128, 128, "Arial", true, false, 8f, Alignment.Left, false, true);
		class221_5 = new RenderFont(255, 255, 255, 0, "Arial", true, false, 7f, Alignment.Left, false, true) {
			HeavyShadow = true
		};
		class221_6 = new RenderFont(255, 255, 100, 100, "Arial", true, false, 7f, Alignment.Left, false, true) {
			HeavyShadow = true
		};
		class221_10 = new RenderFont(128, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, true);
		class221_11 = new RenderFont(192, 64, 160, 64, "Arial", true, false, 8f, Alignment.Left, false, true);
		StatusMessage = new RenderFont(255, 255, 255, 255, "Arial", true, false, 8f, Alignment.Left, false, true);
		class221_14 = new RenderFont(220, 192, 192, 255, "courier new", false, false, 5f, Alignment.Left, false, false);
		class221_15 = new RenderFont(220, 192, 192, 255, "courier new", false, false, 7f, Alignment.Left, false, false);
		class221_13 = new RenderFont(160, 150, 255, 150, "Arial", false, false, 8f, Alignment.Left, false, true);
	}

	internal void InitializeModulesFromConfig(Settings settings)
	{
		class208_0 = new ModuleCursorHint();
		class213_0 = new ModulePlayerInfo(settings);

		class212_0 = new ModulePortraitPlayerStats(settings.Overlay.PortraitPlayerStats);
		class206_0 = new ModulePortraits();

		var @class3 = settings.Overlay.StatTracker;
		ModuleStatTracker = new ModuleStatTracker(@class3);

		class209_0 = new ModuleLobbyHeroes(settings.Overlay.EnableLobbyHeroes);
	}

	internal bool Update()
	{
		bool flag = false;
		if (Frm != null && (Frm.Left != GameWindowManager.Window.Offset.X || Frm.Top != GameWindowManager.Window.Offset.Y || Frm.Width != GameWindowManager.Window.Size.Width || Frm.Height != GameWindowManager.Window.Size.Height)) {
			Frm.SetBounds(GameWindowManager.Window.Offset.X, GameWindowManager.Window.Offset.Y, GameWindowManager.Window.Size.Width, GameWindowManager.Window.Size.Height);
			flag = true;
		}
		if (flag) {
			return false;
		}
		try {
			mapMode_0 = (CoreCollector.UiElements.class341_84.Visible ? Plugins.MapMode.Map : (CoreCollector.UiElements.class341_86.Visible ? (CoreCollector.UiElements.class341_88.Visible ? Plugins.MapMode.ActMap : Plugins.MapMode.WaypointMap) : Plugins.MapMode.Minimap));
			float_3 = (float)GameWindowManager.Window.Size.Height / 1200f;
			if (mapMode_0 == Plugins.MapMode.PermaMap) {
				float_3 *= 0.5f;
			}
			float_2 = 350f * float_3;
			switch (mapMode_0) {
				case Plugins.MapMode.Minimap:
					float_5 = (float)(GameWindowManager.Window.Size.Width - 1) - 27f * float_3 - float_2 / 2f;
					float_6 = 54f * float_3 + float_2 / 2f;
					float_7 = 0f;
					float_8 = 0f;
					break;
				case Plugins.MapMode.Map:
					float_5 = GameWindowManager.Window.Size.Width / 2;
					float_6 = GameWindowManager.Window.Size.Height / 2;
					float_7 = CoreCollector.UiElements.class341_126.MinimapOffsetX;
					float_8 = CoreCollector.UiElements.class341_126.MinimapOffsetY;
					break;
				case Plugins.MapMode.PermaMap:
					float_5 = GameWindowManager.Window.Size.Width / 2;
					float_6 = (float)GameWindowManager.Window.Size.Height * 0.47f;
					float_7 = 0f;
					float_8 = 0f;
					break;
			}
			float_4 = float_2 / 2f;
			renderTarget.BeginDraw();
			renderTarget.Clear(SharpDX.Color.Transparent);
			class208_0.SetHint(null, null);
			BeforeRender?.Invoke(this, EventArgs.Empty);
			if (Core.Controller.Render.IsRenderEnabled) {
				bool flag4 = CoreCollector.UiElements.class341_62.Visible || CoreCollector.UiElements.class341_63.Visible;
				bool flag5 = Core.Controller.Game.Me.SnoArea != null && Core.Controller.Game.Me.SnoArea.Type != AreaType.Normal;
				bool boolean_ = CoreCollector.D3Memory.GameState_Value_IsChallengeRiftGame;
				bool num = CoreCollector.IsGameReady && CoreCollector.LocalPlayer.FloorCoordinate.IsValid;
				bool flag6 = CoreCollector.UiElements.class341_56.Visible || CoreCollector.UiElements.class341_89.Visible || CoreCollector.UiElements.class341_156.Visible || CoreCollector.UiElements.class341_77.Visible;
				if (num && !flag4 && !flag5 && !flag6) {
					if (!CoreCollector.UiElements.class341_11.Visible && !boolean_) {
						method_7();
						method_3();
						method_8();
					}
					if (!boolean_) {
						PaintWorld_Ground?.Invoke(this, EventArgs.Empty);
					}
					class212_0.method_1();
					class206_0.method_1();
					class213_0.Draw(CoreCollector.LocalPlayer);
					PaintTop_BeforeClip?.Invoke(this, EventArgs.Empty);
					method_9(CoreCollector.UiElements.class341_84);
					if ((CoreCollector.UiElements.class341_11.Visible || CoreCollector.UiElements.class341_15.Visible) && !CoreCollector.UiElements.class341_56.Visible && !CoreCollector.UiElements.class341_156.Visible && !CoreCollector.UiElements.class341_77.Visible && !CoreCollector.UiElements.class341_84.Visible && !CoreCollector.UiElements.class341_148.Visible && !CoreCollector.D3Memory.IsUiHidden && CoreCollector.LocalPlayer != null) {
						PaintTop_Inventory?.Invoke(this, EventArgs.Empty);
						method_9(CoreCollector.UiElements.class341_11, CoreCollector.UiElements.class341_9, CoreCollector.UiElements.class341_46, CoreCollector.UiElements.class341_15);
					}
					PaintTop_AfterClip?.Invoke(this, EventArgs.Empty);
				}
				class209_0?.method_1();
				ModuleStatTracker?.Draw();
				Core.SettingsMenu.Draw();
				class208_0?.Draw();
				if (Core.PluginHandler.Reloading) {
					Instance.DrawStatus("Reloading plugins", Instance.StatusMessage);
				} else if (Core.PluginHandler.Reloaded) {
					Instance.DrawStatus("Reloaded plugins", Instance.StatusMessage);
				} else if (Core.PluginHandler.Errored) {
					Instance.DrawStatus("Error reloading plugins, check logs for details", Instance.StatusMessage);
				}
				ResetStatusDrawPosition();
			}
			renderTarget.EndDraw();
			swapChain_0.Present(1, PresentFlags.None);
			if (stopwatch_0.ElapsedMilliseconds >= 1000) {
				stopwatch_0.Restart();
				method_18();
			}
		} catch (SharpDXException exception_) {
			Logger.LogException(exception_.Message);
			form_0_SizeChanged(null, EventArgs.Empty);
		} catch (Exception exception_2) {
			Logger.LogException(exception_2.Message);
		}
		return true;
	}

	private void method_18()
	{
		RenderFont.CleanupCache(false);
	}

	void method_19()
	{
		DisposeRenders(layer_0);
		layer_0 = null;
		DisposeRenders(renderTarget);
		renderTarget = null;
		DisposeRenders(surface_0);
		surface_0 = null;
	}
}
