using System.Collections.Generic;
using SharpDX.Direct2D1;

namespace Plugins;

public interface IRenderController
{
	bool IsRenderEnabled { get; set; }

	bool UiHidden { get; }

	IUiElement InGameBottomHudUiElement { get; }

	IUiElement MonsterHpBarUiElement { get; }

	IUiElement MinimapUiElement { get; }

	IUiElement NephalemRiftBarUiElement { get; }

	IUiElement GreaterRiftBarUiElement { get; }

	IUiElement ChallengeRiftBarUiElement { get; }

	IUiElement ChallengeRiftAheadPanelUiElement { get; }

	IUiElement ParagonLevelUpSplashTextUiElement { get; }

	IUiElement BuffBarExtendedBuffsUiElement { get; }

	IEnumerable<IUiElement> BuffBarUiElements { get; }

	IUiElement WorldMapUiElement { get; }

	IUiElement ActMapUiElement { get; }

	IUiElement SalvageTabButton { get; }

	IUiElement SalvageButton { get; }

	IUiElement SalvageNormal { get; }

	IUiElement SalvageMagic { get; }

	IUiElement SalvageRare { get; }

	IUiElement ChatOpened { get; }

	float MinimapScale { get; }

	IBrush CreateBrush(int a, int r, int g, int b, float strokeWidth, DashStyle dash = DashStyle.Solid, CapStyle startCap = CapStyle.Flat, CapStyle endCap = CapStyle.Flat);

	IFont CreateFont(string fontFamily, float size, int a, int r, int g, int b, bool bold, bool italic, bool standardShadow);

	IFont CreateFont(string fontFamily, float size, int a, int r, int g, int b, bool bold, bool italic, int shadowA, int shadowR, int shadowG, int shadowB, bool shadowIsHeavy);

	IUiElement GetUiElement(string path);

	IUiElement RegisterUiElement(string path, IUiElement collectOnlyWhenThisIsVisible, IUiElement collectOnlyWhenThisIsInvisible, float inflateXby = 0f, float inflateYby = 0f);

	IUiElement GetPlayerSkillUiElement(ActionKey key);

	PathGeometry CreateGeometry();

	void GetMinimapCoordinates(float x, float y, out float mapX, out float mapY);

	void SetHint(string text, string specialLocation = null);

	void TurnOnAliasing();

	void TurnOffAliasing();

	bool IsConfirmationDialogVisible();

	void ScreenshotToFile(string filePath);
}
