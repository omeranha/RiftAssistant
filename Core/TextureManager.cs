using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using SNO;


internal static class TextureManager
{
	private static readonly Dictionary<long, SharpDX.Direct2D1.Bitmap> atlasPositionToBitmap = [];

	private static readonly Dictionary<uint, Texture> textureIdToTexture = [];

	private static readonly Dictionary<uint, string> sceneSnoToMinimapPath = [];

	private static readonly Dictionary<uint, SharpDX.Direct2D1.Bitmap> sceneSnoToMinimapBitmap = [];

	private static readonly Dictionary<uint, long> sceneSnoToLastAccessTicks = [];

	public static Texture GetItemTexture(SnoItem snoItem)
	{
		return GetItemTexture(snoItem, HeroClass.Wizard, isFemale: true);
	}

	public static Texture GetItemTexture(SnoItem snoItem, HeroClass heroClass, bool isFemale)
	{
		uint[] textureMap = snoItem.SnoActor.TextureMap;
		if (textureMap == null) {
			return null;
		}

		uint num = textureMap[(int)heroClass * 2 + ((!isFemale) ? 1 : 0)];
		if (num == 0) {
			num = textureMap[(int)heroClass * 2];
		}
		if (num == 0) {
			for (int i = 0; i < textureMap.Length; i++) {
				num = textureMap[i];
				if (num != 0) {
					break;
				}
			}
		}
		if (num != 0) {
			return GetTextureById(num);
		}
		return null;
	}

	public static Texture GetTextureByName(string textureName)
	{
		return GetTextureById(smethod_0(textureName, bool_0: false));
	}

	public static uint smethod_0(string textureName, bool bool_0)
	{
		uint num = 0u;
		byte[] bytes = Encoding.ASCII.GetBytes(bool_0 ? textureName.ToLower() : textureName);
		foreach (byte b in bytes) {
			num = num * 33 + b;
		}
		return num;
	}

	public static Texture GetTextureById(uint textureId)
	{
		if (textureIdToTexture.TryGetValue(textureId, out Texture atlasTex) && atlasTex != null) {
			return atlasTex;
		}

		switch (textureId) {
			case 2078949389u: {
					Bitmap buffFrame = AppResources.BuffFrame;
					Texture texture = new(new Lazy<SharpDX.Direct2D1.Bitmap>(() => Overlay.Instance.method_10(buffFrame, bool_0: true)), 0, 0, buffFrame.Width, buffFrame.Height);
					textureIdToTexture[textureId] = texture;
					return texture;
				}
			case 948845718u: {
					Bitmap debuffFrame = AppResources.DebuffFrame;
					Texture texture2 = new(new Lazy<SharpDX.Direct2D1.Bitmap>(() => Overlay.Instance.method_10(debuffFrame, bool_0: true)), 0, 0, debuffFrame.Width, debuffFrame.Height);
					textureIdToTexture[textureId] = texture2;
					return texture2;
				}
			default: {
					TextureIndexEntry? textureIndexEntry = SnoData.GetTextureIndexEntry(textureId);
					if (!textureIndexEntry.HasValue) {
						textureIdToTexture[textureId] = null;
						return null;
					}
					atlasTex = new Texture(new Lazy<SharpDX.Direct2D1.Bitmap>(delegate {
						if (!atlasPositionToBitmap.TryGetValue(textureIndexEntry.Value.AtlasPosition, out SharpDX.Direct2D1.Bitmap bitmap) || bitmap == null) {
							Bitmap bitmap2 = (Bitmap)Image.FromStream(new MemoryStream(ResourceData.ReadBlob(textureIndexEntry.Value.AtlasPosition)));
							bitmap = Overlay.Instance.method_10(bitmap2);
							atlasPositionToBitmap[textureIndexEntry.Value.AtlasPosition] = bitmap;
						}
						return bitmap;
					}), textureIndexEntry.Value.X, textureIndexEntry.Value.Y, textureIndexEntry.Value.W, textureIndexEntry.Value.H);
					textureIdToTexture[textureId] = atlasTex;
					return atlasTex;
				}
		}
	}

	public static Texture GetTextureBySnoAndAnim(uint snoId, int animState)
	{
		if (animState < 0) {
			animState = 0;
		}
		TextureIndexEntry? textureIndexEntryBySnoIdWithAnimState = SnoData.GetTextureIndexEntryBySnoIdWithAnimState(((ulong)snoId << 32) + (uint)animState);
		if (!textureIndexEntryBySnoIdWithAnimState.HasValue) {
			return null;
		}
		return GetTextureById(textureIndexEntryBySnoIdWithAnimState.Value.Id);
	}

	public static SharpDX.Direct2D1.Bitmap GetSceneMinimapBitmap(SnoScene scene)
	{
		string text = sceneSnoToMinimapPath[scene.Sno];
		if (string.IsNullOrEmpty(text)) {
			return null;
		}
		if (text == null) {
			text = "mmap\\mmap_" + scene.Code.ToLower(CultureInfo.InvariantCulture) + ".png";
			if (!File.Exists(text)) {
				sceneSnoToMinimapPath.Add(scene.Sno, "");
				return null;
			}
			sceneSnoToMinimapPath[scene.Sno] = text;
			Bitmap bitmap = new(text);
			bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
			SharpDX.Direct2D1.Bitmap gparam_ = Overlay.Instance.method_10(bitmap);
			sceneSnoToMinimapBitmap[scene.Sno] = gparam_;
		}
		sceneSnoToLastAccessTicks[scene.Sno] = CoreCollector.CurrentRealTimeTicks;
		return sceneSnoToMinimapBitmap[scene.Sno];
	}

	public static void CleanupCaches(long maxAgeTicks)
	{
		List<uint> list = [];
		foreach (KeyValuePair<uint, SharpDX.Direct2D1.Bitmap> item in (IEnumerable<KeyValuePair<uint, SharpDX.Direct2D1.Bitmap>>)sceneSnoToMinimapBitmap) {
			long num = sceneSnoToLastAccessTicks[item.Key];
			if (maxAgeTicks == -1 || maxAgeTicks - num > 200000000) {
				item.Value.Dispose();
				list.Add(item.Key);
			}
		}
		foreach (uint item2 in list) {
			sceneSnoToMinimapBitmap.Remove(item2);
			sceneSnoToMinimapPath.Remove(item2);
		}
	}
}
