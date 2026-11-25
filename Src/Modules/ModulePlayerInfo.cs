#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;
using System.Globalization;
using SharpDX;
using SharpDX.Direct2D1;

namespace RiftAssistant.Modules;

internal class ModulePlayerInfo : Module
{
	private readonly Dictionary<string, Vector2[]> pointCache = [];

	private readonly Dictionary<string, Geometry> geometryCache = [];

	private readonly RenderBrush healthFill = new(255, 255, 50, 50, 5);

	private readonly RenderBrush barBackground = new(128, 32, 32, 32, 5);

	private readonly RenderBrush arcaneFill = new(200, 100, 0, 205, 5);

	private readonly RenderBrush disciplineFill = new(200, 0, 0, 255, 5);

	private readonly RenderBrush hatredFill = new(200, 255, 0, 0, 5);

	private readonly RenderBrush furyFill = new(200, 255, 170, 0, 5);

	private readonly RenderBrush manaFill = new(200, 0, 0, 255, 5);

	private readonly RenderBrush spiritFill = new(200, 255, 255, 200, 5);

	private readonly RenderBrush essenceFill = new(200, 175, 238, 238, 5);

	private readonly RenderBrush wrathFill = new(200, 255, 255, 225, 5);

	private readonly RenderBrush cooldownFill = new(255, 160, 80, 44, 5);

	private bool showHealthBar;

	private bool showResourcesBar;

	private bool showCooldowns;

	private bool showSkillIcons;

	private bool fadeSkillIcons;

	public ModulePlayerInfo(Settings settings) : base(true)
	{
		showHealthBar = settings.Overlay.ShowHealthBar;
		showResourcesBar = settings.Overlay.ShowResourcesBar;
		showCooldowns = settings.Overlay.SkillCooldowns.Enabled;
		showSkillIcons = settings.Overlay.SkillCooldowns.ShowSkillIcon;
		fadeSkillIcons = settings.Overlay.SkillCooldowns.EnableFade;
		SetTransparentComponents(healthFill, arcaneFill, disciplineFill, hatredFill, furyFill, manaFill, spiritFill, barBackground, cooldownFill);
	}

	public override void Dispose()
	{
		Overlay.Instance.DisposeRenders(barBackground, arcaneFill, disciplineFill, hatredFill, furyFill, manaFill, spiritFill, healthFill, cooldownFill);
		pointCache.Clear();
		foreach (Geometry item in geometryCache.Values) {
			item.Dispose();
		}
		geometryCache.Clear();
		base.Dispose();
	}

	public void Draw(Player localPlayer)
	{
		bool flag = Overlay.Instance.ActiveMapMode != MapMode.Map;
		if (!vmethod_0(flag)) {
			return;
		}
		float num = 1f;
		if (showHealthBar) {
			DrawArcBar(localPlayer, localPlayer.RadiusScaled * 1.4f * num + 0.6f, 100, 180f, 0f, bool_9: false, healthFill, barBackground, localPlayer.Defense.HealthMax, localPlayer.Defense.HealthCur);
		}
		if (showCooldowns) {
			int num2 = Convert.ToInt32(Math.Round(2f / 75f * (float)GameWindowManager.Window.Size.Height));
			for (int i = 0; i < 6; i++) {
				int num3 = ((i <= 3) ? (i + 2) : (i - 4));
				Skill playerSkill = localPlayer.Powers.SkillSlots[num3];
				if (playerSkill == null || !playerSkill.IsOnCooldown) {
					continue;
				}
				float num4 = (float)(playerSkill.CooldownFinishTick - playerSkill.CooldownStartTick) / 60f;
				float num5 = (float)(playerSkill.CooldownFinishTick - CoreCollector.D3Memory.GameTick) / 60f;
				float num6 = localPlayer.RadiusScaled * num + 2.3f;
				int num7 = 20;
				float num8 = (float)(-77 + i * 30) / 360f;
				if (playerSkill.SnoPower.NormalIconTextureId == 0) {
					continue;
				}
				Texture? texture = TextureManager.GetTextureById(playerSkill.SnoPower.NormalIconTextureId);
				if (showSkillIcons && texture != null) {
					float num9 = num6 * (float)Math.Cos((double)((float)(num7 / 100 * ((i >= 3) ? 100 : 0) - 135 + (360 - num7) / 2) + 360f * num8) * Math.PI / 180.0);
					float num10 = num6 * (float)Math.Sin((double)((float)(num7 / 100 * ((i >= 3) ? 100 : 0) - 135 + (360 - num7) / 2) + 360f * num8) * Math.PI / 180.0);
					GameWindowManager.Window.WorldToScreenCoordinate(localPlayer.FloorCoordinate.X + num9, localPlayer.FloorCoordinate.Y + num10, localPlayer.FloorCoordinate.Z, out var screenX, out var screenY);
					RectangleF rectangle = new RectangleF((i < 3) ? (screenX - (float)num2) : screenX, screenY, num2, num2);
					float num11 = 1f;
					if (fadeSkillIcons) {
						num11 = 1f - 0.85f / num4 * num5;
					}
					texture.Draw(rectangle, opacity * num11);
					Core.Controller.Texture.BuffFrameTexture.Draw(rectangle, opacity * num11);
				}
				DrawArcBar(localPlayer, num6, 100, num7, num8, bool_9: false, cooldownFill, barBackground, num4, num5);
			}
		}
		if (showResourcesBar) {
			float float_ = localPlayer.RadiusScaled * num + 0.6f;
			if (localPlayer?.HeroClassDefinition == null) return;

			switch (localPlayer.HeroClassDefinition.HeroClass) {
				case HeroClass.DemonHunter:
					DrawArcBar(localPlayer, float_, 50, 90f, -11f / 72f, bool_9: false, hatredFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					DrawArcBar(localPlayer, float_, 50, 90f, 11f / 72f, bool_9: true, disciplineFill, barBackground, localPlayer.Stats.ResourceMaxSec, localPlayer.Stats.ResourceCurSec);
					break;
				case HeroClass.Barbarian:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, furyFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
				case HeroClass.Wizard:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, arcaneFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
				case HeroClass.WitchDoctor:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, manaFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
				case HeroClass.Monk:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, spiritFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
				case HeroClass.Crusader:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, wrathFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
				case HeroClass.Necromancer:
					DrawArcBar(localPlayer, float_, 100, 180f, 0f, bool_9: false, essenceFill, barBackground, localPlayer.Stats.ResourceMaxPri, localPlayer.Stats.ResourceCurPri);
					break;
			}
		}
	}

	private Geometry GetArcGeometry(Player player, float float_1, int int_2, float float_2, float float_3, bool bool_9, int int_3, bool bool_10)
	{
		string gparam_ = float_1.ToString(CultureInfo.InvariantCulture) + "_" + int_2.ToString(CultureInfo.InvariantCulture) + "_" + float_2.ToString(CultureInfo.InvariantCulture) + "_" + float_3.ToString(CultureInfo.InvariantCulture) + "_" + bool_9.ToString(CultureInfo.InvariantCulture) + "_" + int_3.ToString(CultureInfo.InvariantCulture) + "\t" + bool_10.ToString(CultureInfo.InvariantCulture);
		geometryCache.TryGetValue(gparam_, out var geometry);
		if (geometry != null) {
			return geometry;
		}
		string gparam_2 = float_1.ToString(CultureInfo.InvariantCulture) + "_" + int_2.ToString(CultureInfo.InvariantCulture) + "_" + float_2.ToString(CultureInfo.InvariantCulture) + "_" + float_3.ToString(CultureInfo.InvariantCulture);
		pointCache.TryGetValue(gparam_2, out var array);
		if (array == null) {
			array = new Vector2[int_2 + 1];
			for (int i = 0; i <= int_2; i++) {
				float num = float_1 * (float)Math.Cos((double)(float_2 / (float)int_2 * (float)i - 135f + (360f - float_2) / 2f + 360f * float_3) * Math.PI / 180.0);
				float num2 = float_1 * (float)Math.Sin((double)(float_2 / (float)int_2 * (float)i - 135f + (360f - float_2) / 2f + 360f * float_3) * Math.PI / 180.0);
				GameWindowManager.Window.WorldToScreenCoordinate(player.FloorCoordinate.X + num, player.FloorCoordinate.Y + num2, player.FloorCoordinate.Z, out var screenX, out var screenY);
				array[i] = new Vector2(screenX, screenY);
			}
			pointCache[gparam_2] = array;
		}
		PathGeometry pathGeometry = new PathGeometry(Overlay.Instance.direct2DFactory);
		using (GeometrySink geometrySink = pathGeometry.Open()) {
			if (bool_10) {
				for (int j = int_3; j <= int_2; j++) {
					int num3 = ((!bool_9) ? j : (int_2 - j));
					Vector2 vector = array[num3];
					if (j > int_3) {
						geometrySink.AddLine(vector);
					} else {
						geometrySink.BeginFigure(vector, FigureBegin.Hollow);
					}
				}
			} else {
				for (int num4 = int_3; num4 >= 0; num4--) {
					int num5 = ((!bool_9) ? num4 : (int_2 - num4));
					Vector2 vector2 = array[num5];
					if (num4 < int_3) {
						geometrySink.AddLine(vector2);
					} else {
						geometrySink.BeginFigure(vector2, FigureBegin.Hollow);
					}
				}
			}
			geometrySink.EndFigure(FigureEnd.Open);
			geometrySink.Close();
		}
		geometryCache[gparam_] = pathGeometry;
		return pathGeometry;
	}

	private void DrawArcBar(Player player, float float_1, int int_2, float float_2, float float_3, bool bool_9, RenderBrush renderBrush, RenderBrush barBackground2, float resourceMaxPri, float resourceCurPri)
	{
		if (resourceMaxPri <= 0f || int_2 <= 1) {
			return;
		}
		try {
			int num = ((resourceCurPri > 0f) ? Convert.ToInt32(Math.Max(0.0, Math.Min(2147483647.0, Math.Min(int_2, Math.Floor(resourceCurPri / resourceMaxPri * (float)int_2))))) : 0);
			if (num < int_2 - 1) {
				Geometry geometry = GetArcGeometry(player, float_1, int_2, float_2, float_3, bool_9, num, bool_10: true);
				barBackground2.DrawGeometry(geometry);
			}
			if (num > 0) {
				Geometry geometry2 = GetArcGeometry(player, float_1, int_2, float_2, float_3, bool_9, num, bool_10: false);
				renderBrush.DrawGeometry(geometry2);
			}
		} catch (Exception e) {
			Logger.LogException(e.ToString());
		}
	}
}
