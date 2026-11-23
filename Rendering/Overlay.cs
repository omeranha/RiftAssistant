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

	public SharpDX.Direct3D11.Device device;

	public SwapChain swapChain;

	public Surface surface;

	internal RenderTarget renderTarget;

	public SwapChainDescription swapChainDescription;

	public RenderTargetProperties renderTargetProperties;

	private Layer clipLayer;

	public static Overlay Instance;

	internal readonly PerSecCounter RenderCounter = new();

	private readonly Controller controller;

	public readonly Form Frm;

	public readonly SharpDX.Direct2D1.Factory direct2DFactory;

	public readonly SharpDX.DirectWrite.Factory directWriteFactory;

	public OverlayDisplayState State = OverlayDisplayState.Normal;

	private Stopwatch fontCleanupTimer = new();

	public MapMode ActiveMapMode;

	public float mapSize;

	public float MinimapScale;

	public float mapHalfSize;

	public float mapCenterX;

	public float mapCenterY;

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


	public readonly List<UiElement> clipElements = [];

	public SceneMapRenderer mapRenderer = new();

	internal ModulePlayerInfo playerInfoModule;

	internal ModulePortraitPlayerStats portraitPlayerStatsModule;

	internal ModulePortraits portraitsModule;

	public ModuleStatTracker ModuleStatTracker;

	internal ModuleCursorHint cursorHintModule;
	internal ModuleLobbyHeroes lobbyHeroesModule;

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
		Matrix3x2 matrix3x2 = Matrix3x2.Translation(mapCenterX, mapCenterY);
		matrix3x2_0 = transform * matrix3x * matrix3x2;
		renderTarget.Transform = matrix3x2_0;
		try {
			mapRenderer.RenderMap();
		} catch (Exception exception_) {
			Logger.LogException(exception_.Message);
		}
		renderTarget.Transform = transform;
		try {
			PaintWorld_Map?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception) {
			Logger.LogException(exception.Message);
		}
		if (ActiveMapMode == MapMode.Minimap) {
			if (Core.Controller.SceneReveal.MinimapClip) {
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(0f, 0f, mapCenterX - mapSize / 2f, GameWindowManager.Window.Size.Height), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(mapCenterX - mapSize / 2f, 0f, (float)GameWindowManager.Window.Size.Width - (mapCenterX - mapSize / 2f), mapCenterY - mapSize / 2f), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
				renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(mapCenterX - mapSize / 2f, mapCenterY + mapSize / 2f, (float)GameWindowManager.Window.Size.Width - (mapCenterX - mapSize / 2f), (float)GameWindowManager.Window.Size.Height - (mapCenterY + mapSize / 2f)), AntialiasMode.PerPrimitive);
				renderTarget.Clear(SharpDX.Color.Transparent);
				renderTarget.PopAxisAlignedClip();
			}
			renderTarget.PushAxisAlignedClip(new SharpDX.RectangleF(mapCenterX + mapSize / 2f, mapCenterY - mapSize / 2f, (float)GameWindowManager.Window.Size.Width - (mapCenterX + mapSize / 2f), mapSize), AntialiasMode.PerPrimitive);
			renderTarget.Clear(SharpDX.Color.Transparent);
			renderTarget.PopAxisAlignedClip();
		}
	}

	public void ToMinimapCoordinates(float float_9, float statusY0, bool bool_0, out float statusY1, out float statusY2)
	{
		statusY1 = (MinimapOffsetX + CoreCollector.LocalPlayer.FloorCoordinate.X - float_9) * mapSize / 350f;
		statusY2 = (0f - (MinimapOffsetY + CoreCollector.LocalPlayer.FloorCoordinate.Y - statusY0)) * mapSize / 350f;
		if (bool_0) {
			float num = statusY1 * matrix3x2_0.M11 + statusY2 * matrix3x2_0.M21 + matrix3x2_0.M31;
			float num2 = statusY1 * matrix3x2_0.M12 + statusY2 * matrix3x2_0.M22 + matrix3x2_0.M32;
			statusY1 = num;
			statusY2 = num2;
		}
	}

	private void CreateRenderTarget()
	{
		surface = Surface.FromSwapChain(swapChain, 0);
		renderTarget = new RenderTarget(direct2DFactory, surface, renderTargetProperties) {
			AntialiasMode = AntialiasMode.PerPrimitive,
			TextAntialiasMode = SharpDX.Direct2D1.TextAntialiasMode.Grayscale
		};
	}

	private void form_0_SizeChanged(object sender, EventArgs e)
	{
		DisposeRenderTargets();
		swapChain.ResizeBuffers(swapChainDescription.BufferCount, 0, 0, Format.Unknown, SwapChainFlags.None);
		CreateRenderTarget();
		DisposeModules();
	}

	private void DisposeModules()
	{
		RenderFont.CleanupCache(true);
		foreach (Module item in modules.ToArray()) {
			item.Dispose();
		}
		mapRenderer.DisposeTextures();
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
		clipLayer = layer;
	}

	public void EndClip()
	{
		renderTarget.PopLayer();
		clipLayer.Dispose();
		clipLayer = null;
	}

	public void method_9(params UiElement[] inventoryMainUiElement)
	{
		if (CoreCollector.D3Memory.IsUiHidden) {
			return;
		}
		for (int i = 0; i < clipElements.Count; i++) {
			UiElement uiElement = clipElements[i];
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
		direct2DFactory = new SharpDX.Direct2D1.Factory();
		directWriteFactory = new SharpDX.DirectWrite.Factory();
		swapChainDescription = new SwapChainDescription {
			BufferCount = 2,
			ModeDescription = new ModeDescription(0, 0, new Rational(60, 1), Format.R8G8B8A8_UNorm),
			IsWindowed = true,
			OutputHandle = Frm.Handle,
			SampleDescription = new SampleDescription(1, 0),
			SwapEffect = SwapEffect.Discard,
			Usage = Usage.RenderTargetOutput,
			Flags = SwapChainFlags.None
		};
		renderTargetProperties = new RenderTargetProperties {
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
		SharpDX.Direct3D11.Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.BgraSupport, new SharpDX.Direct3D.FeatureLevel[1] { featureLevel }, swapChainDescription, out device, out swapChain);
		CreateRenderTarget();
		method_12();
	}

	private void method_12()
	{
		clipElements.Add(CoreCollector.UiElements.InventoryMainUiElement);
		clipElements.Add(CoreCollector.UiElements.InventorySidePaneContainer);
		clipElements.Add(CoreCollector.UiElements.CharacterDetailsContainer);
		clipElements.Add(CoreCollector.UiElements.StashMainUiElement);
		clipElements.Add(CoreCollector.UiElements.EquipmentManagerMainPage);
		clipElements.Add(CoreCollector.UiElements.Details);
		clipElements.Add(CoreCollector.UiElements.VendorDialogMainPagePanel);
		clipElements.Add(CoreCollector.UiElements.ShopDialogMainPagePanel);
		clipElements.Add(CoreCollector.UiElements.Item2Stack);
		clipElements.Add(CoreCollector.UiElements.Item3Stack);
		clipElements.Add(CoreCollector.UiElements.SkillsList);
		clipElements.Add(CoreCollector.UiElements.ActiveSkillSelect);
		clipElements.Add(CoreCollector.UiElements.PassiveSkillSelect);
		clipElements.Add(CoreCollector.UiElements.GamemenuBkgrnd);
		clipElements.Add(CoreCollector.UiElements.FriendsListContent);
		clipElements.Add(CoreCollector.UiElements.GroupsListContent);
		clipElements.Add(CoreCollector.UiElements.RiftDialogMainPage);
		clipElements.Add(CoreCollector.UiElements.BattleNetGameSettingsMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.FollowerMainUiElement);
		clipElements.Add(CoreCollector.UiElements.InspectMainPage);
		clipElements.Add(CoreCollector.UiElements.MapDialogMainPage);
		clipElements.Add(CoreCollector.UiElements.WorldMapUiElement);
		clipElements.Add(CoreCollector.UiElements.ActMapUiElement);
		clipElements.Add(CoreCollector.UiElements.Instructions);
		clipElements.Add(CoreCollector.UiElements.BattleNetProfileMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.ConversationDialogMain);
		clipElements.Add(CoreCollector.UiElements.Item1Stack);
		clipElements.Add(CoreCollector.UiElements.TradeDialogMainPage);
		clipElements.Add(CoreCollector.UiElements.InGamePortraitTooltip2);
		clipElements.Add(CoreCollector.UiElements.PlayerContextMenu);
		clipElements.Add(CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.BattleNetLeaderboardMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.BattleNetSeasonJourneyMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.GameOptionsMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.BattleNetStoreMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.FrameBackground);
		clipElements.Add(CoreCollector.UiElements.DialogSendRealIdRequest);
		clipElements.Add(CoreCollector.UiElements.Banner2);
		clipElements.Add(CoreCollector.UiElements.Skill2Stack);
		clipElements.Add(CoreCollector.UiElements.BattleNetProfileBannerCustomizationMainLayoutRootOverlayContainer);
		clipElements.Add(CoreCollector.UiElements.InGamePetContextMenu);
		clipElements.Add(CoreCollector.UiElements.ParagonPointSelect);
		clipElements.Add(CoreCollector.UiElements.Tooltip2);
		clipElements.Add(CoreCollector.UiElements.HirelingDetailsContainer);
		clipElements.Add(CoreCollector.UiElements.QuestloreDialogPanel);
		clipElements.Add(CoreCollector.UiElements.RactorTag0);
		clipElements.Add(CoreCollector.UiElements.Subdlg);
		clipElements.Add(CoreCollector.UiElements.InviteToPartyNotification);
		clipElements.Add(CoreCollector.UiElements.JoinRequestNotification);
		clipElements.Add(CoreCollector.UiElements.LorePlayerDlgBackground);
		clipElements.Add(CoreCollector.UiElements.LoreNotifyDlg);
		clipElements.Add(CoreCollector.UiElements.LeaveGameWindow);
		clipElements.Add(CoreCollector.UiElements.GuildMainLayoutRootOverlayContainer);
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
		cursorHintModule = new ModuleCursorHint();
		playerInfoModule = new ModulePlayerInfo(settings);

		portraitPlayerStatsModule = new ModulePortraitPlayerStats(settings);
		portraitsModule = new ModulePortraits();

		var statTracker = settings.Overlay.StatTracker;
		ModuleStatTracker = new ModuleStatTracker(statTracker);

		lobbyHeroesModule = new ModuleLobbyHeroes(settings);
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
			ActiveMapMode = (CoreCollector.UiElements.MapDialogMainPage.Visible ? MapMode.Map : (CoreCollector.UiElements.WorldMapUiElement.Visible ? (CoreCollector.UiElements.ActMapUiElement.Visible ? MapMode.ActMap : MapMode.WaypointMap) : MapMode.Minimap));
			MinimapScale = (float)GameWindowManager.Window.Size.Height / 1200f;
			if (ActiveMapMode == MapMode.PermaMap) {
				MinimapScale *= 0.5f;
			}
			mapSize = 350f * MinimapScale;
			switch (ActiveMapMode) {
				case MapMode.Minimap:
					mapCenterX = (float)(GameWindowManager.Window.Size.Width - 1) - 27f * MinimapScale - mapSize / 2f;
					mapCenterY = 54f * MinimapScale + mapSize / 2f;
					MinimapOffsetX = 0f;
					MinimapOffsetY = 0f;
					break;
				case MapMode.Map:
					mapCenterX = GameWindowManager.Window.Size.Width / 2;
					mapCenterY = GameWindowManager.Window.Size.Height / 2;
					MinimapOffsetX = CoreCollector.UiElements.Localmap.MinimapOffsetX;
					MinimapOffsetY = CoreCollector.UiElements.Localmap.MinimapOffsetY;
					break;
				case MapMode.PermaMap:
					mapCenterX = GameWindowManager.Window.Size.Width / 2;
					mapCenterY = (float)GameWindowManager.Window.Size.Height * 0.47f;
					MinimapOffsetX = 0f;
					MinimapOffsetY = 0f;
					break;
			}
			mapHalfSize = mapSize / 2f;
			RenderCounter.StartMeasure();
			renderTarget.BeginDraw();
			renderTarget.Clear(SharpDX.Color.Transparent);
			cursorHintModule.SetHint(null, null);
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
					portraitPlayerStatsModule.Update();
					portraitsModule.Update();
					playerInfoModule.Draw(CoreCollector.LocalPlayer);
					PaintTop_BeforeClip?.Invoke(this, EventArgs.Empty);
					method_9(CoreCollector.UiElements.MapDialogMainPage);
					if ((CoreCollector.UiElements.InventoryMainUiElement.Visible || CoreCollector.UiElements.FollowerMainUiElement.Visible) && !CoreCollector.UiElements.GamemenuBkgrnd.Visible && !CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible && !CoreCollector.UiElements.MapDialogMainPage.Visible && !CoreCollector.UiElements.BattleNetProfileMainLayoutRootOverlayContainer.Visible && !CoreCollector.D3Memory.IsUiHidden && CoreCollector.LocalPlayer != null) {
						PaintTop_Inventory?.Invoke(this, EventArgs.Empty);
						method_9(CoreCollector.UiElements.InventoryMainUiElement, CoreCollector.UiElements.StashMainUiElement, CoreCollector.UiElements.VendorDialogMainPagePanel, CoreCollector.UiElements.FollowerMainUiElement);
					}
					PaintTop_AfterClip?.Invoke(this, EventArgs.Empty);
				}
				lobbyHeroesModule?.Update();
				ModuleStatTracker?.Draw();
				Core.SettingsMenu.Draw();
				cursorHintModule?.Draw();
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
			swapChain.Present(1, PresentFlags.None);
			if (fontCleanupTimer.ElapsedMilliseconds >= 1000) {
				fontCleanupTimer.Restart();
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
		DisposeRenders(clipLayer);
		clipLayer = null;
		DisposeRenders(renderTarget);
		renderTarget = null;
		DisposeRenders(surface);
		surface = null;
	}
}
