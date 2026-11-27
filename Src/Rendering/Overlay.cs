#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Numerics;
using SharpGen.Runtime;
using Vortice;
using Vortice.Direct2D1;
using Vortice.Direct3D;
using Vortice.Direct3D11;
using Vortice.DirectWrite;
using Vortice.DXGI;
using Vortice.Mathematics;

using MapMode = RiftAssistant.Model.MapMode;

namespace RiftAssistant.Rendering;

internal class Overlay
{
	private float statusX;

	private float statusY;

	private static readonly Color4 Transparent = new(0f, 0f, 0f, 0f);

	private Matrix3x2 matrix3x2_0;

	public ID3D11Device device;

	public IDXGISwapChain swapChain;

	public IDXGISurface? surface;

	internal ID2D1RenderTarget? renderTarget;

	public SwapChainDescription swapChainDescription;

	public RenderTargetProperties renderTargetProperties;

	private ID2D1Layer? clipLayer;

	private int lastPaintGate = -1;

	public static Overlay Instance { get; private set; }

	internal readonly PerSecCounter RenderCounter = new();

	public readonly Form Frm;

	public readonly ID2D1Factory direct2DFactory;

	public readonly IDWriteFactory directWriteFactory;

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

	public RenderFont renderFont;

	public RenderFont renderFont3;

	public RenderFont renderFont4;

	public RenderFont renderFont5;

	public RenderFont renderFont6;

	public RenderFont renderFont7;

	public RenderFont font4;

	public RenderFont font3;

	public RenderFont renderFont10;

	public RenderFont renderFont11;

	public RenderFont StatusMessage;

	public RenderFont renderFont13;

	public RenderFont renderFont14;

	public RenderFont renderFont15;


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

	private bool statTrackerEnabled;

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
		Matrix3x2 transform = renderTarget.Transform;
		Matrix3x2 matrix3x = Matrix3x2.CreateRotation(-(float)Math.PI / 4f);
		Matrix3x2 matrix3x2 = Matrix3x2.CreateTranslation(mapCenterX, mapCenterY);
		matrix3x2_0 = transform * matrix3x * matrix3x2;
		renderTarget.Transform = matrix3x2_0;
		try {
			mapRenderer.RenderMap();
		} catch (Exception exception_) {
			Logger.LogException(exception_.ToString());
		}
		renderTarget.Transform = transform;
		try {
			PaintWorld_Map?.Invoke(this, EventArgs.Empty);
		} catch (Exception exception) {
			Logger.LogException(exception.ToString());
		}
		if (ActiveMapMode == MapMode.Minimap) {
			if (Core.Controller.SceneReveal.MinimapClip) {
				PushClip(0f, 0f, mapCenterX - mapSize / 2f, GameWindowManager.Window.Size.Height);
				renderTarget.Clear(Transparent);
				renderTarget.PopAxisAlignedClip();
				PushClip(mapCenterX - mapSize / 2f, 0f, (float)GameWindowManager.Window.Size.Width - (mapCenterX - mapSize / 2f), mapCenterY - mapSize / 2f);
				renderTarget.Clear(Transparent);
				renderTarget.PopAxisAlignedClip();
				PushClip(mapCenterX - mapSize / 2f, mapCenterY + mapSize / 2f, (float)GameWindowManager.Window.Size.Width - (mapCenterX - mapSize / 2f), (float)GameWindowManager.Window.Size.Height - (mapCenterY + mapSize / 2f));
				renderTarget.Clear(Transparent);
				renderTarget.PopAxisAlignedClip();
			}
			PushClip(mapCenterX + mapSize / 2f, mapCenterY - mapSize / 2f, (float)GameWindowManager.Window.Size.Width - (mapCenterX + mapSize / 2f), mapSize);
			renderTarget.Clear(Transparent);
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
		surface = swapChain.GetBuffer<IDXGISurface>(0);
		renderTarget = direct2DFactory.CreateDxgiSurfaceRenderTarget(surface, renderTargetProperties);
		renderTarget.AntialiasMode = AntialiasMode.PerPrimitive;
		renderTarget.TextAntialiasMode = Vortice.Direct2D1.TextAntialiasMode.Grayscale;
	}

	private void form_0_SizeChanged(object? sender, EventArgs e)
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

	private void PushClip(float x, float y, float width, float height)
	{
		renderTarget.PushAxisAlignedClip(new RawRectF(x, y, x + width, y + height), AntialiasMode.PerPrimitive);
	}

	public void BeginClip(float opacity = 1f)
	{
		var size = GameWindowManager.Window.Size;
		var layer = renderTarget.CreateLayer(new Size(size.Width, size.Height));
		var layerParameters = new LayerParameters {
			ContentBounds = new RawRectF(0f, 0f, size.Width, size.Height),
			Opacity = opacity
		};
		renderTarget.PushLayer(layerParameters, layer);
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
			PushClip(uiElement.rectangle.Left, uiElement.rectangle.Top, uiElement.rectangle.Width, height);
			renderTarget.Clear(Transparent);
			renderTarget.PopAxisAlignedClip();
		}
	}

	public ID2D1Bitmap ToDirect2DBitmap(System.Drawing.Bitmap? bitmap, bool bool_0 = false)
	{
		if (bool_0) {
			bitmap.MakeTransparent(System.Drawing.Color.Black);
		}
		BitmapData bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
		var bitmapProperties = new BitmapProperties(new Vortice.DCommon.PixelFormat(Format.B8G8R8A8_UNorm, Vortice.DCommon.AlphaMode.Premultiplied));
		var result = renderTarget.CreateBitmap(new SizeI(bitmap.Width, bitmap.Height), bitmapData.Scan0, (uint)bitmapData.Stride, bitmapProperties);
		bitmap.UnlockBits(bitmapData);
		return result;
	}

	public void DisposeRenders(params IDisposable[]? barBackground)
	{
		for (int i = 0; i < barBackground.Length; i++) {
			barBackground[i]?.Dispose();
		}
	}

	public Overlay()
	{
		Instance = this;
		Frm = new FormOverlay();
		Frm.SetBounds(0, 0, 0, 0);
		Frm.SizeChanged += form_0_SizeChanged;
		direct2DFactory = D2D1.D2D1CreateFactory<ID2D1Factory>();
		directWriteFactory = DWrite.DWriteCreateFactory<IDWriteFactory>();
		swapChainDescription = new SwapChainDescription {
			BufferCount = 2,
			BufferDescription = new ModeDescription { Width = 0, Height = 0, RefreshRate = new Rational(60, 1), Format = Format.R8G8B8A8_UNorm },
			Windowed = true,
			OutputWindow = Frm.Handle,
			SampleDescription = new SampleDescription(1, 0),
			SwapEffect = SwapEffect.Discard,
			BufferUsage = Usage.RenderTargetOutput,
			Flags = SwapChainFlags.None
		};
		renderTargetProperties = new RenderTargetProperties(
			RenderTargetType.Hardware,
			new Vortice.DCommon.PixelFormat(Format.R8G8B8A8_UNorm, Vortice.DCommon.AlphaMode.Premultiplied),
			96f,
			96f,
			RenderTargetUsage.None,
			Vortice.Direct2D1.FeatureLevel.Level_10);
		var featureLevel = Vortice.Direct3D.FeatureLevel.Level_9_1;
		try {
			featureLevel = D3D11.GetSupportedFeatureLevel();
		} catch (Exception ex) {
			Logger.Info($"Error occurred while querying supported feature level: {ex.Message}");
		}
		D3D11.D3D11CreateDeviceAndSwapChain(null, DriverType.Hardware, DeviceCreationFlags.BgraSupport, [featureLevel], swapChainDescription, out swapChain, out device, out _, out var immediateContext).CheckError();
		immediateContext.Dispose();
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
		DisposeRenders(font1, font2, renderFont, renderFont3, renderFont4, renderFont7, font4, font3, renderFont5, renderFont6, renderFont10, renderFont11, StatusMessage, renderFont14, renderFont15, renderFont13);
		font1 = new RenderFont(192, 184, 164, 164, "Arial", true, false, 8f, Alignment.Left, false, true);
		font2 = new RenderFont(192, 184, 124, 0, "Arial", true, false, 8f, Alignment.Left, false, true);
		renderFont = new RenderFont(192, 160, 160, 160, "Arial", true, false, 7f, Alignment.Left, false, true);
		renderFont3 = new RenderFont(192, 100, 160, 100, "Arial", true, false, 6f, Alignment.Left, false, true);
		renderFont4 = new RenderFont(160, 255, 128, 128, "Arial", true, false, 8f, Alignment.Left, false, true);
		renderFont7 = new RenderFont(160, 255, 200, 255, "Arial", true, false, 8f, Alignment.Left, false, true);
		font4 = new RenderFont(160, 255, 64, 64, "Arial", true, false, 8f, Alignment.Left, false, true);
		font3 = new RenderFont(160, 128, 128, 128, "Arial", true, false, 8f, Alignment.Left, false, true);
		renderFont5 = new RenderFont(255, 255, 255, 0, "Arial", true, false, 7f, Alignment.Left, false, true) {
			HeavyShadow = true
		};
		renderFont6 = new RenderFont(255, 255, 100, 100, "Arial", true, false, 7f, Alignment.Left, false, true) {
			HeavyShadow = true
		};
		renderFont10 = new RenderFont(128, 255, 255, 255, "Arial", false, false, 8f, Alignment.Left, false, true);
		renderFont11 = new RenderFont(192, 64, 160, 64, "Arial", true, false, 8f, Alignment.Left, false, true);
		StatusMessage = new RenderFont(255, 255, 255, 255, "Arial", true, false, 8f, Alignment.Left, false, true);
		renderFont14 = new RenderFont(220, 192, 192, 255, "courier new", false, false, 5f, Alignment.Left, false, false);
		renderFont15 = new RenderFont(220, 192, 192, 255, "courier new", false, false, 7f, Alignment.Left, false, false);
		renderFont13 = new RenderFont(160, 150, 255, 150, "Arial", false, false, 8f, Alignment.Left, false, true);
	}

	internal void ApplySettings(Settings settings)
	{
		bool keepStatTrackerVisibility = ModuleStatTracker != null && statTrackerEnabled == settings.Overlay.StatTracker.Enabled;
		bool statTrackerVisible = ModuleStatTracker != null && ModuleStatTracker.Show;
		foreach (Module item in modules.ToArray()) {
			item.Dispose();
		}

		InitializeModulesFromConfig(settings);
		if (keepStatTrackerVisibility) ModuleStatTracker.Show = statTrackerVisible;
	}

	internal void InitializeModulesFromConfig(Settings settings)
	{
		cursorHintModule = new ModuleCursorHint();
		playerInfoModule = new ModulePlayerInfo(settings);

		portraitPlayerStatsModule = new ModulePortraitPlayerStats(settings);
		portraitsModule = new ModulePortraits();

		var statTracker = settings.Overlay.StatTracker;
		statTrackerEnabled = statTracker.Enabled;
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
			renderTarget.Clear(Transparent);
			cursorHintModule.SetHint(null, null);
			BeforeRender?.Invoke(this, EventArgs.Empty);
			if (Core.Controller.Render.IsRenderEnabled) {
				bool flag4 = CoreCollector.UiElements.Cutscene.Visible || CoreCollector.UiElements.ScriptedSequence.Visible;
				bool flag5 = Core.Controller.Game.LocalPlayer.SnoArea != null && Core.Controller.Game.LocalPlayer.SnoArea.Type != AreaType.Normal;
				bool boolean_ = CoreCollector.D3Memory.GameState_Value_IsChallengeRiftGame;
				bool num = CoreCollector.IsGameReady && CoreCollector.LocalPlayer.FloorCoordinate.IsValid;
				bool flag6 = CoreCollector.UiElements.GamemenuBkgrnd.Visible || CoreCollector.UiElements.GameOptionsMainLayoutRootOverlayContainer.Visible || CoreCollector.UiElements.BattleNetAchievementsMainLayoutRootOverlayContainer.Visible || CoreCollector.UiElements.GuildFinderMainLayoutRootOverlayContainer.Visible;
				LogPaintGate(CoreCollector.IsGameReady, num, flag4, flag5, flag6);
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
				MenuStyle.BeginFrame();
				Core.SettingsButton.Draw();
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
			renderTarget.EndDraw().CheckError();
			RenderCounter.EndMeasure();
			swapChain.Present(1, PresentFlags.None).CheckError();
			if (fontCleanupTimer.ElapsedMilliseconds >= 1000) {
				fontCleanupTimer.Restart();
				CleanupFontCache();
			}
		} catch (SharpGenException exception_) {
			Logger.LogException(exception_.ToString());
			form_0_SizeChanged(null, EventArgs.Empty);
		} catch (Exception exception) {
			Logger.LogException(exception.ToString());
			RecoverRenderTarget();
		}
		return true;
	}

	private void LogPaintGate(bool gameReady, bool playerPositionValid, bool cutscene, bool nonNormalArea, bool gameMenuOpen)
	{
		int state = (gameReady ? 1 : 0) | (playerPositionValid ? 2 : 0) | (cutscene ? 4 : 0) | (nonNormalArea ? 8 : 0) | (gameMenuOpen ? 16 : 0);
		if (state == lastPaintGate) return;

		lastPaintGate = state;
		bool painting = gameReady && playerPositionValid && !cutscene && !nonNormalArea && !gameMenuOpen;
		Logger.Info($"[overlay] plugin painting {(painting ? "on" : "off")}: gameReady={gameReady} playerPositionValid={playerPositionValid} cutscene={cutscene} nonNormalArea={nonNormalArea} gameMenuOpen={gameMenuOpen}");
	}

	private void RecoverRenderTarget()
	{
		if (clipLayer != null) {
			try {
				EndClip();
			} catch (SharpGenException) {
				clipLayer = null;
			}
		}

		try {
			renderTarget.EndDraw();
		} catch (SharpGenException) {
		}
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
