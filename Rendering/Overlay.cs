using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DirectWrite;
using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;

using MapMode = RiftAssistant.Model.MapMode;

namespace RiftAssistant.Rendering;

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

	internal readonly PerSecCounter RenderCounter = new();

	private readonly Controller controller;

	public readonly Form Frm;

	public readonly SharpDX.Direct2D1.Factory factory_0;

	public readonly SharpDX.DirectWrite.Factory factory_1;

	public OverlayDisplayState State = OverlayDisplayState.Normal;

	private Stopwatch stopwatch_0 = new();

	public MapMode mapMode_0;

	public float float_2;

	public float MinimapScale;

	public float float_4;

	public float float_5;

	public float float_6;

	public float MinimapOffsetX;

	public float MinimapOffsetY;

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


	public readonly List<UiElement> list_0 = [];

	public SceneMapRenderer class204_0 = new();

	internal ModulePlayerInfo class213_0;

	internal ModulePortraitPlayerStats class212_0;

	internal ModulePortraits class206_0;

	public ModuleStatTracker ModuleStatTracker;

	internal ModuleCursorHint class208_0;
	internal ModuleLobbyHeroes class209_0;

	public Dictionary<string, string> class112_0 = new Dictionary<string, string>();

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

	public void DrawRotatedMap()
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
		} catch (Exception exception) {
			Logger.LogException(exception.Message);
		}
		if (mapMode_0 == MapMode.Minimap) {
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

	public void ToMinimapCoordinates(float float_9, float statusY0, bool bool_0, out float statusY1, out float statusY2)
	{
		statusY1 = (MinimapOffsetX + CoreCollector.LocalPlayer.FloorCoordinate.X - float_9) * float_2 / 350f;
		statusY2 = (0f - (MinimapOffsetY + CoreCollector.LocalPlayer.FloorCoordinate.Y - statusY0)) * float_2 / 350f;
		if (bool_0) {
			float num = statusY1 * matrix3x2_0.M11 + statusY2 * matrix3x2_0.M21 + matrix3x2_0.M31;
			float num2 = statusY1 * matrix3x2_0.M12 + statusY2 * matrix3x2_0.M22 + matrix3x2_0.M32;
			statusY1 = num;
			statusY2 = num2;
		}
	}

	private void CreateRenderTarget()
	{
		surface_0 = Surface.FromSwapChain(swapChain_0, 0);
		renderTarget = new RenderTarget(factory_0, surface_0, renderTargetProperties_0) {
			AntialiasMode = AntialiasMode.PerPrimitive,
			TextAntialiasMode = SharpDX.Direct2D1.TextAntialiasMode.Grayscale
		};
	}

	private void form_0_SizeChanged(object sender, EventArgs e)
	{
		DisposeRenderTargets();
		swapChain_0.ResizeBuffers(swapChainDescription_0.BufferCount, 0, 0, Format.Unknown, SwapChainFlags.None);
		CreateRenderTarget();
		DisposeModules();
	}

	private void DisposeModules()
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

	public void BeginClip(float float_9 = 1f)
	{
		Layer layer = new Layer(renderTarget, new Size2F(GameWindowManager.Window.Size.Width, GameWindowManager.Window.Size.Height));
		LayerParameters layerParameters = new LayerParameters {
			ContentBounds = new SharpDX.RectangleF(0f, 0f, GameWindowManager.Window.Size.Width, GameWindowManager.Window.Size.Height),
			Opacity = float_9
		};
		renderTarget.PushLayer(ref layerParameters, layer);
		layer_0 = layer;
	}

	public void EndClip()
	{
		renderTarget.PopLayer();
		layer_0.Dispose();
		layer_0 = null;
	}

	public void method_9(params UiElement[] inventoryMainUiElement)
	{
		if (CoreCollector.D3Memory.IsUiHidden) {
			return;
		}
		for (int i = 0; i < list_0.Count; i++) {
			UiElement uiElement = list_0[i];
			if (uiElement == null || !uiElement.Visible) {
				continue;
			}
			if (inventoryMainUiElement != null) {
				bool flag = false;
				for (int j = 0; j < inventoryMainUiElement.Length; j++) {
					if (inventoryMainUiElement[j] == uiElement) {
						flag = true;
						break;
					}
				}
				if (flag) {
					continue;
				}
			}
			float height = uiElement.rectangle.Height;
			if (uiElement == CoreCollector.UiElements.InventoryMainUiElement || uiElement == CoreCollector.UiElements.StashMainUiElement || uiElement == CoreCollector.UiElements.FollowerMainUiElement || uiElement == CoreCollector.UiElements.ShopDialogMainPagePanel || uiElement == CoreCollector.UiElements.VendorDialogMainPagePanel) {
				height = CoreCollector.UiElements.InGameBottomHudUiElement.rectangle.Top;
			}
			renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(uiElement.rectangle.Left, uiElement.rectangle.Top, uiElement.rectangle.Width, height), AntialiasMode.PerPrimitive);
			renderTarget.Clear(SharpDX.Color.Transparent);
			renderTarget.PopAxisAlignedClip();
		}
	}

	public SharpDX.Direct2D1.Bitmap ToDirect2DBitmap(System.Drawing.Bitmap bitmap, bool bool_0 = false)
	{
		if (bool_0) {
			bitmap.MakeTransparent(System.Drawing.Color.Black);
		}
		BitmapData bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
		using DataStream dataStream = new DataStream(bitmapData.Scan0, bitmapData.Stride * bitmapData.Height, canRead: true, canWrite: false);
		BitmapProperties bitmapProperties = new BitmapProperties {
			PixelFormat = new SharpDX.Direct2D1.PixelFormat(Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied)
		};
		SharpDX.Direct2D1.Bitmap result = new SharpDX.Direct2D1.Bitmap(renderTarget, new Size2(bitmap.Width, bitmap.Height), dataStream, bitmapData.Stride, bitmapProperties);
		bitmap.UnlockBits(bitmapData);
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
		CreateRenderTarget();
		method_12();
	}

	private void method_12()
	{
		list_0.Add(CoreCollector.UiElements.InventoryMainUiElement);
		list_0.Add(CoreCollector.UiElements.InventorySidePaneContainer);
		list_0.Add(CoreCollector.UiElements.CharacterDetailsContainer);
		list_0.Add(CoreCollector.UiElements.StashMainUiElement);
		list_0.Add(CoreCollector.UiElements.EquipmentManagerMainPage);
		list_0.Add(CoreCollector.UiElements.Details);
		list_0.Add(CoreCollector.UiElements.VendorDialogMainPagePanel);
		list_0.Add(CoreCollector.UiElements.ShopDialogMainPagePanel);
		list_0.Add(CoreCollector.UiElements.Item2Stack);
		list_0.Add(CoreCollector.UiElements.Item3Stack);
		list_0.Add(CoreCollector.UiElements.SkillsList);
		list_0.Add(CoreCollector.UiElements.ActiveSkillSelect);
		list_0.Add(CoreCollector.UiElements.PassiveSkillSelect);
		list_0.Add(CoreCollector.UiElements.GamemenuBkgrnd);
		list_0.Add(CoreCollector.UiElements.FriendsListContent);
		list_0.Add(CoreCollector.UiElements.GroupsListContent);
		list_0.Add(CoreCollector.UiElements.RiftDialogMainPage);
		list_0.Add(CoreCollector.UiElements.BattleNetGameSettingsMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.FollowerMainUiElement);
		list_0.Add(CoreCollector.UiElements.InspectMainPage);
		list_0.Add(CoreCollector.UiElements.MapDialogMainPage);
		list_0.Add(CoreCollector.UiElements.WorldMapUiElement);
		list_0.Add(CoreCollector.UiElements.ActMapUiElement);
		list_0.Add(CoreCollector.UiElements.Instructions);
		list_0.Add(CoreCollector.UiElements.BattleNetProfileMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.ConversationDialogMain);
		list_0.Add(CoreCollector.UiElements.Item1Stack);
		list_0.Add(CoreCollector.UiElements.TradeDialogMainPage);
		list_0.Add(CoreCollector.UiElements.InGamePortraitTooltip2);
		list_0.Add(CoreCollector.UiElements.PlayerContextMenu);
		list_0.Add(CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.BattleNetLeaderboardMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.BattleNetSeasonJourneyMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.GameOptionsMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.BattleNetStoreMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.FrameBackground);
		list_0.Add(CoreCollector.UiElements.DialogSendRealIdRequest);
		list_0.Add(CoreCollector.UiElements.Banner2);
		list_0.Add(CoreCollector.UiElements.Skill2Stack);
		list_0.Add(CoreCollector.UiElements.BattleNetProfileBannerCustomizationMainLayoutRootOverlayContainer);
		list_0.Add(CoreCollector.UiElements.InGamePetContextMenu);
		list_0.Add(CoreCollector.UiElements.ParagonPointSelect);
		list_0.Add(CoreCollector.UiElements.Tooltip2);
		list_0.Add(CoreCollector.UiElements.HirelingDetailsContainer);
		list_0.Add(CoreCollector.UiElements.QuestloreDialogPanel);
		list_0.Add(CoreCollector.UiElements.RactorTag0);
		list_0.Add(CoreCollector.UiElements.Subdlg);
		list_0.Add(CoreCollector.UiElements.InviteToPartyNotification);
		list_0.Add(CoreCollector.UiElements.JoinRequestNotification);
		list_0.Add(CoreCollector.UiElements.LorePlayerDlgBackground);
		list_0.Add(CoreCollector.UiElements.LoreNotifyDlg);
		list_0.Add(CoreCollector.UiElements.LeaveGameWindow);
		list_0.Add(CoreCollector.UiElements.GuildMainLayoutRootOverlayContainer);
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

		class212_0 = new ModulePortraitPlayerStats(settings);
		class206_0 = new ModulePortraits();

		var statTracker = settings.Overlay.StatTracker;
		ModuleStatTracker = new ModuleStatTracker(statTracker);

		class209_0 = new ModuleLobbyHeroes(settings);
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
			mapMode_0 = (CoreCollector.UiElements.MapDialogMainPage.Visible ? MapMode.Map : (CoreCollector.UiElements.WorldMapUiElement.Visible ? (CoreCollector.UiElements.ActMapUiElement.Visible ? MapMode.ActMap : MapMode.WaypointMap) : MapMode.Minimap));
			MinimapScale = (float)GameWindowManager.Window.Size.Height / 1200f;
			if (mapMode_0 == MapMode.PermaMap) {
				MinimapScale *= 0.5f;
			}
			float_2 = 350f * MinimapScale;
			switch (mapMode_0) {
				case MapMode.Minimap:
					float_5 = (float)(GameWindowManager.Window.Size.Width - 1) - 27f * MinimapScale - float_2 / 2f;
					float_6 = 54f * MinimapScale + float_2 / 2f;
					MinimapOffsetX = 0f;
					MinimapOffsetY = 0f;
					break;
				case MapMode.Map:
					float_5 = GameWindowManager.Window.Size.Width / 2;
					float_6 = GameWindowManager.Window.Size.Height / 2;
					MinimapOffsetX = CoreCollector.UiElements.Localmap.MinimapOffsetX;
					MinimapOffsetY = CoreCollector.UiElements.Localmap.MinimapOffsetY;
					break;
				case MapMode.PermaMap:
					float_5 = GameWindowManager.Window.Size.Width / 2;
					float_6 = (float)GameWindowManager.Window.Size.Height * 0.47f;
					MinimapOffsetX = 0f;
					MinimapOffsetY = 0f;
					break;
			}
			float_4 = float_2 / 2f;
			RenderCounter.StartMeasure();
			renderTarget.BeginDraw();
			renderTarget.Clear(SharpDX.Color.Transparent);
			class208_0.SetHint(null, null);
			BeforeRender?.Invoke(this, EventArgs.Empty);
			if (Core.Controller.Render.IsRenderEnabled) {
				bool flag4 = CoreCollector.UiElements.Cutscene.Visible || CoreCollector.UiElements.ScriptedSequence.Visible;
				bool flag5 = Core.Controller.Game.Me.SnoArea != null && Core.Controller.Game.Me.SnoArea.Type != AreaType.Normal;
				bool boolean_ = CoreCollector.D3Memory.GameState_Value_IsChallengeRiftGame;
				bool num = CoreCollector.IsGameReady && CoreCollector.LocalPlayer.FloorCoordinate.IsValid;
				bool flag6 = CoreCollector.UiElements.GamemenuBkgrnd.Visible || CoreCollector.UiElements.GameOptionsMainLayoutRootOverlayContainer.Visible || CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible || CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible;
				if (num && !flag4 && !flag5 && !flag6) {
					if (!CoreCollector.UiElements.InventoryMainUiElement.Visible && !boolean_) {
						BeginClip();
						DrawRotatedMap();
						EndClip();
					}
					if (!boolean_) {
						PaintWorld_Ground?.Invoke(this, EventArgs.Empty);
					}
					class212_0.Update();
					class206_0.Update();
					class213_0.Draw(CoreCollector.LocalPlayer);
					PaintTop_BeforeClip?.Invoke(this, EventArgs.Empty);
					method_9(CoreCollector.UiElements.MapDialogMainPage);
					if ((CoreCollector.UiElements.InventoryMainUiElement.Visible || CoreCollector.UiElements.FollowerMainUiElement.Visible) && !CoreCollector.UiElements.GamemenuBkgrnd.Visible && !CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.MapDialogMainPage.Visible && !CoreCollector.UiElements.BattleNetProfileMainLayoutRootOverlayContainer.Visible && !CoreCollector.D3Memory.IsUiHidden && CoreCollector.LocalPlayer != null) {
						PaintTop_Inventory?.Invoke(this, EventArgs.Empty);
						method_9(CoreCollector.UiElements.InventoryMainUiElement, CoreCollector.UiElements.StashMainUiElement, CoreCollector.UiElements.VendorDialogMainPagePanel, CoreCollector.UiElements.FollowerMainUiElement);
					}
					PaintTop_AfterClip?.Invoke(this, EventArgs.Empty);
				}
				class209_0?.Update();
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
			RenderCounter.EndMeasure();
			swapChain_0.Present(1, PresentFlags.None);
			if (stopwatch_0.ElapsedMilliseconds >= 1000) {
				stopwatch_0.Restart();
				CleanupFontCache();
			}
		} catch (SharpDXException exception_) {
			Logger.LogException(exception_.Message);
			form_0_SizeChanged(null, EventArgs.Empty);
		} catch (Exception exception) {
			Logger.LogException(exception.Message);
		}
		return true;
	}

	private void CleanupFontCache()
	{
		RenderFont.CleanupCache(false);
	}

	void DisposeRenderTargets()
	{
		DisposeRenders(layer_0);
		layer_0 = null;
		DisposeRenders(renderTarget);
		renderTarget = null;
		DisposeRenders(surface_0);
		surface_0 = null;
	}
}
