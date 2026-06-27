using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using Plugins;
using SNO;
using work;

public readonly record struct SceneKey(float X, float Y);

internal class SceneMapRenderer
{
	private readonly SolidBrush exitBrush;

	private readonly SolidBrush entranceBrush;

	private readonly Font debugFont;

	private readonly System.Drawing.Brush whiteBrush;

	private float scaleFactor = 1f;

	private uint lastSnoWorldId;

	private string lastAreaGroupInfo;

	private float boundsMinX;

	private float boundsMinY;

	private float boundsMaxX;

	private float boundsMaxY;

	private int maxBitmapSize = -1;

	private SharpDX.Direct2D1.Bitmap[,] mapTextureChunks;

	private uint lastWorldId = uint.MaxValue;

	private float lastRenderMinX;

	private float lastRenderMaxX;

	private float lastRenderMinY;

	private float lastRenderMaxY;

	private readonly HashSet<SceneKey> renderedSceneCache = [];

	private MapMode currentMapMode;

	public SceneMapRenderer()
	{
		exitBrush = new SolidBrush(System.Drawing.Color.FromArgb(255, 255, 120, 120));
		entranceBrush = new SolidBrush(System.Drawing.Color.FromArgb(255, 120, 255, 120));
		debugFont = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
		whiteBrush = new SolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
	}

	public void DisposeTextures()
	{
		var textures = mapTextureChunks;
		if (textures == null) return;

		int width = textures.GetLength(0);
		int height = textures.GetLength(1);
		for (int y = 0; y < height; y++) {
			for (int x = 0; x < width; x++) {
				textures[x, y]?.Dispose();
			}
		}
		mapTextureChunks = null;
	}

	private bool CalculateMapBounds(out float minX, out float maxX, out float minY, out float maxY)
	{
		IEnumerable<Scene> activeScenes = CoreCollector.SceneCollector.method_0(CoreCollector.LocalPlayer.WorldId);
		SnoArea currentArea = CoreCollector.LocalPlayer.SnoArea;
		bool mapUpdated = false;

		minX = float.MaxValue;
		maxX = float.MinValue;
		minY = float.MaxValue;
		maxY = float.MinValue;

		if (CoreCollector.LocalPlayer.SnoWorld is SnoWorld snoWorld) {
			if (lastWorldId != snoWorld.Sno || lastAreaGroupInfo != currentArea.AreaGroupInWorld) {
				boundsMinX = float.MaxValue;
				boundsMaxX = float.MinValue;
				boundsMinY = float.MaxValue;
				boundsMaxY = float.MinValue;

				for (int i = 0; i < snoWorld.SceneInfos.Count; i++) {
					SnoWorldSceneInfo sceneInfo = snoWorld.SceneInfos[i];
					if (!(currentArea.AreaGroupInWorld != sceneInfo.SnoArea.AreaGroupInWorld) && !sceneInfo.SnoArea.IsRandom) {
						if (sceneInfo.PosX < boundsMinX) boundsMinX = sceneInfo.PosX;
						if (sceneInfo.PosY < boundsMinY) boundsMinY = sceneInfo.PosY;
						if (sceneInfo.MaxX > boundsMaxX) boundsMaxX = sceneInfo.MaxX;
						if (sceneInfo.MaxY > boundsMaxY) boundsMaxY = sceneInfo.MaxY;
						mapUpdated = true;
					}
				}
				if (mapUpdated) {
					lastWorldId = snoWorld.Sno;
					lastAreaGroupInfo = currentArea.AreaGroupInWorld;
				}
			}
			minX = boundsMinX;
			maxX = boundsMaxX;
			minY = boundsMinY;
			maxY = boundsMaxY;
		}

		if (activeScenes != null) {
			foreach (Scene scene in activeScenes) {
				if (scene.SnoArea == null || !(scene.SnoArea.AreaGroupInWorld != currentArea.AreaGroupInWorld)) {
					if (scene.PosX < minX) minX = scene.PosX;
					if (scene.PosY < minY) minY = scene.PosY;
					if (scene.MaxX > maxX) maxX = scene.MaxX;
					if (scene.MaxY > maxY) maxY = scene.MaxY;
					mapUpdated = true;
				}
			}
		}

		minX -= 240f;
		maxX += 240f;
		minY -= 240f;
		maxY += 240f;

		return mapUpdated;
	}

	private void DrawScene(float offsetX, float offsetY, float width, float height, SnoScene scene, Graphics graphics)
	{
		float zoom = GetScaledZoomFactor();

		if (scene == null) {
			graphics.FillRectangle(Core.Controller.SceneReveal.BrushUnknown, (offsetX - width) * zoom, offsetY * zoom, width * zoom, height * zoom);
			return;
		}

		var brush = Core.Controller.SceneReveal.BrushKnown;
		string code = scene.Code;
		if (code != null && (CoreCollector.specialArea_0 == SpecialArea.Rift || CoreCollector.specialArea_0 == SpecialArea.GreaterRift)) {
			if (code.Contains("entrance")) {
				brush = entranceBrush;
			} else if (code.Contains("exit")) {
				brush = exitBrush;
			}
		}

		scene.LoadNavCells();
		foreach (var cell in scene.NavCells) {
			graphics.FillRectangle(brush, (offsetX - cell.MaxX) * zoom, (offsetY + cell.MinY) * zoom, (cell.MaxX - cell.MinX) * zoom, (cell.MaxY - cell.MinY) * zoom);
		}

		if (Core.Controller.SceneReveal.DisplaySceneBorder) {
			graphics.DrawRectangle(Core.Controller.SceneReveal.SceneBorderPen, (offsetX - width) * zoom, offsetY * zoom, width * zoom, height * zoom);
		}
	}

	private float GetScaledZoomFactor()
	{
		return Overlay.Instance.float_3 * scaleFactor;
	}

	private void GenerateMapTextures(float minX, float maxX, float minY, float maxY)
	{
		float currentZoom = GetScaledZoomFactor();
		if (mapTextureChunks != null) {
			DisposeTextures();
		}

		IEnumerable<Scene> activeScenes = CoreCollector.SceneCollector.method_0(CoreCollector.LocalPlayer.WorldId);
		SnoArea currentArea = CoreCollector.LocalPlayer.SnoArea;

		int bitmapWidth = Convert.ToInt32((maxX - minX) * currentZoom);
		int bitmapHeight = Convert.ToInt32((maxY - minY) * currentZoom);
		renderedSceneCache.Clear();

		try {
			using System.Drawing.Bitmap giantMapBitmap = new System.Drawing.Bitmap(bitmapWidth, bitmapHeight);
			using (Graphics graphics = Graphics.FromImage(giantMapBitmap)) {
				if (!CoreCollector.IsInTown) {
					foreach (Scene scene in activeScenes) {
						if (scene.SnoArea == null || !(scene.SnoArea.AreaGroupInWorld != currentArea.AreaGroupInWorld)) {
							float offsetX = maxX - scene.PosX;
							float offsetY = scene.PosY - minY;
							renderedSceneCache.Add(new SceneKey(offsetX, offsetY));
							DrawScene(offsetX, offsetY, scene.W, scene.H, scene.SnoScene as SnoScene, graphics);
						}
					}
				}

				if (CoreCollector.LocalPlayer.SnoWorld is SnoWorld snoWorld && !CoreCollector.IsInTown) {
					for (int k = 0; k < snoWorld.SceneInfos.Count; k++) {
						SnoWorldSceneInfo sceneInfo = snoWorld.SceneInfos[k];
						if (sceneInfo.SnoArea.IsRandom || currentArea.AreaGroupInWorld != sceneInfo.SnoArea.AreaGroupInWorld) {
							continue;
						}

						float offsetX = maxX - sceneInfo.PosX;
						float offsetY = sceneInfo.PosY - minY;
						SceneKey cacheKey = new(offsetX, offsetY);

						if (!renderedSceneCache.Contains(cacheKey)) {
							if (sceneInfo is SnoWorldSceneInfoStatic) {
								SnoScene snoScene = (sceneInfo as SnoWorldSceneInfoStatic).SnoScene;
								DrawScene(offsetX, offsetY, sceneInfo.W, sceneInfo.H, snoScene as SnoScene, graphics);
								renderedSceneCache.Add(cacheKey);
							} else if (Overlay.Instance.mapMode_0 != MapMode.PermaMap) {
								DrawScene(offsetX, offsetY, sceneInfo.W, sceneInfo.H, null, graphics);
							}
						}
					}
				}
			}

			lastWorldId = CoreCollector.LocalPlayer.WorldId;
			lastRenderMinX = minX;
			lastRenderMaxX = maxX;
			lastRenderMinY = minY;
			lastRenderMaxY = maxY;

			if (maxBitmapSize == -1) {
				maxBitmapSize = Overlay.Instance.renderTarget.MaximumBitmapSize;
				int fallbackSize = 1024;
				if (maxBitmapSize < 1024) {
					Logger.LogException("Direct2D warning: MaximumBitmapSize=" + maxBitmapSize.ToString("D", CultureInfo.InvariantCulture) + ", automatically increasing the texture size to " + fallbackSize.ToString("D", CultureInfo.InvariantCulture));
					maxBitmapSize = fallbackSize;
				}
			}

			int chunksX = Convert.ToInt32(Math.Ceiling((double)giantMapBitmap.Width / (double)maxBitmapSize));
			int chunksY = Convert.ToInt32(Math.Ceiling((double)giantMapBitmap.Height / (double)maxBitmapSize));

			try {
				mapTextureChunks = new SharpDX.Direct2D1.Bitmap[chunksX, chunksY];
				if (chunksX <= 1 && chunksY <= 1) {
					mapTextureChunks[0, 0] = Overlay.Instance.method_10(giantMapBitmap);
				} else {
					for (int y = 0; y < chunksY; y++) {
						for (int x = 0; x < chunksX; x++) {
							int cropX = x * maxBitmapSize;
							int cropY = y * maxBitmapSize;
							int cropWidth = Math.Min(giantMapBitmap.Width - x * maxBitmapSize, maxBitmapSize);
							int cropHeight = Math.Min(giantMapBitmap.Height - y * maxBitmapSize, maxBitmapSize);

							using System.Drawing.Bitmap textureChunk = giantMapBitmap.Clone(new System.Drawing.Rectangle(cropX, cropY, cropWidth, cropHeight), System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
							mapTextureChunks[x, y] = Overlay.Instance.method_10(textureChunk);
						}
					}
				}
			} catch (OutOfMemoryException) {
				MessageBox.Show("Not enough memory to draw the overlay. Please make sure enough virtual memory is enabled in Windows settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Core.Exit();
				Application.Exit();
				Environment.Exit(0);
			} catch (Exception ex) {
				Logger.LogException(ex.Message);
			}
		} catch (Exception ex) {
			Logger.LogException(ex.Message);
		}
		currentMapMode = Overlay.Instance.mapMode_0;
	}

	public bool SetupRequiredMapValidations(float activeMaxX, float activeMinY)
	{
		if (CoreCollector.IsInTown) return true;

		var area = CoreCollector.LocalPlayer.SnoArea;
		foreach (var scene in CoreCollector.SceneCollector.method_0(CoreCollector.LocalPlayer.WorldId)) {
			if (scene.SnoArea != null && scene.SnoArea.AreaGroupInWorld != area.AreaGroupInWorld) {
				continue;
			}

			var key = new SceneKey(activeMaxX - scene.PosX, scene.PosY - activeMinY);
			if (!renderedSceneCache.Contains(key)) {
				return false;
			}
		}

		return true;
	}

	public void RenderMap()
	{
		var overlay = Overlay.Instance;
		if (CoreCollector.IsLoading || (overlay.mapMode_0 != MapMode.Minimap && overlay.mapMode_0 != MapMode.Map) || !CalculateMapBounds(out var minX, out var maxX, out var minY, out var maxY)) {
			return;
		}

		var renderTarget = overlay.renderTarget;
		var player = CoreCollector.LocalPlayer;
		float playerX = player.FloorCoordinate.X;
		float playerY = player.FloorCoordinate.Y;
		scaleFactor = 1f;
		float sizeMb = ((maxX - minX) * (maxY - minY)) / (1024f * 1024f);
		while (sizeMb * scaleFactor * scaleFactor >= 24f) {
			scaleFactor *= 0.5f;
		}

		bool isCacheValid = mapTextureChunks != null && minX == lastRenderMinX && maxX == lastRenderMaxX && minY == lastRenderMinY && maxY == lastRenderMaxY && lastWorldId == CoreCollector.LocalPlayer.WorldId;
		if (isCacheValid) {
			isCacheValid = SetupRequiredMapValidations(maxX, minY);
		}

		if (currentMapMode == MapMode.PermaMap && overlay.mapMode_0 != MapMode.PermaMap) {
			isCacheValid = false;
		}
		if (currentMapMode != MapMode.PermaMap && overlay.mapMode_0 == MapMode.PermaMap) {
			isCacheValid = false;
		}

		if (!isCacheValid) {
			GenerateMapTextures(minX, maxX, minY, maxY);
		}
		if (mapTextureChunks == null) {
			return;
		}

		float mapOpacity = 1f;
		if (Overlay.Instance.mapMode_0 == MapMode.Minimap) {
			if (!Core.Controller.SceneReveal.MinimapEnabled) {
				return;
			}
		} else if (!Core.Controller.SceneReveal.MapEnabled) {
			return;
		}

		mapOpacity = mapOpacity * ((overlay.mapMode_0 == MapMode.Map) ? Core.Controller.SceneReveal.MapOpacity : Core.Controller.SceneReveal.MinimapOpacity);
		Matrix3x2 priorTransform = renderTarget.Transform;
		Matrix3x2 isoRotationInfo = Matrix3x2.Rotation(-(float)Math.PI / 4f);
		Matrix3x2 panTranslation = Matrix3x2.Translation(overlay.float_5, overlay.float_6);

		for (int y = 0; y < mapTextureChunks.GetLength(1); y++) {
			for (int x = 0; x < mapTextureChunks.GetLength(0); x++) {
				float currentZoom = GetScaledZoomFactor();
				if (scaleFactor == 1f) {
					Matrix3x2 blockTranslation = Matrix3x2.Translation((playerX - maxX + overlay.float_7) * currentZoom + (float)(x * maxBitmapSize), (0f - (playerY - minY + overlay.float_8)) * currentZoom + (float)(y * maxBitmapSize));
					renderTarget.Transform = blockTranslation * isoRotationInfo * panTranslation;
					renderTarget.DrawBitmap(mapTextureChunks[x, y], mapOpacity, BitmapInterpolationMode.Linear);
				} else {
					Matrix3x2 blockTranslation = Matrix3x2.Translation((playerX - maxX + overlay.float_7) * currentZoom + (float)(x * maxBitmapSize), (0f - (playerY - minY + overlay.float_8)) * currentZoom + (float)(y * maxBitmapSize));
					Matrix3x2 resolutionScale = Matrix3x2.Scaling(1f / scaleFactor);
					renderTarget.Transform = blockTranslation * isoRotationInfo * resolutionScale * panTranslation;
					renderTarget.DrawBitmap(mapTextureChunks[x, y], mapOpacity, BitmapInterpolationMode.Linear);
				}
			}
		}
		renderTarget.Transform = priorTransform;
	}

	public void ResetRenderer()
	{
		lastWorldId = uint.MaxValue;
		DisposeTextures();
	}
}