using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;

namespace Plugins;

public interface IBeforeRenderHandler : IPlugin
{
	void BeforeRender();
}

public interface IBrush : ITransparent
{
	float StrokeWidth { get; set; }

	StrokeStyle StrokeStyle { get; }

	float ScaledStrokeWidth { get; }

	void DrawEllipse(float x1, float y1, float r1, float r2, float strokeWidthCorrection = 0f);

	void DrawLine(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f);

	void DrawLineGridFit(float x1, float y1, float x2, float y2, float strokeWidthCorrection = 0f);

	void DrawLineWorld(float x1, float y1, float z1, float x2, float y2, float z2, float strokeWidthCorrection = 0f);

	void DrawLineWorld(WorldCoordinate wc1, WorldCoordinate wc2, float strokeWidthCorrection = 0f);

	void DrawRectangle(System.Drawing.RectangleF rectangle);

	void DrawRectangle(SharpDX.RectangleF rectangle);

	void DrawRectangle(float x, float y, float w, float h);

	void DrawRectangleGridFit(float x, float y, float w, float h);

	void DrawWorldEllipse(float radius, int sectionCount, WorldCoordinate coordinate);

	void DrawWorldEllipse(float radius, int sectionCount, float x, float y, float z);

	void DrawWorldPlus(float radius, float x, float y, float z);

	void DrawGeometry(Geometry geometry);
}

public interface IChatLineChangedHandler : IPlugin
{
	void OnChatLineChanged(string currentLine, string previousLine);
}

public interface IClickableActor
{
	Stopwatch FirstClicked { get; }

	Stopwatch LastClicked { get; }

	bool? ShouldBeClicked { get; set; }

	void RegisterClick();
}

public interface IFont : ITransparent
{
	int MaxHeight { get; set; }

	int MaxWidth { get; set; }

	bool WordWrap { get; set; }

	bool HeavyShadow { get; set; }

	void DrawText(string text, ScreenCoordinate coordinate, bool enableLayoutCache = true);

	void DrawText(string text, float x, float y, bool enableLayoutCache = true);

	TextLayout GetTextLayout(string text);

	TextLayout GetTextLayoutManualDispose(string text);

	void DrawText(TextLayout textLayout, float x, float y);

	void DrawText(TextLayout textLayout, ScreenCoordinate coordinate);

	void SetMaxSize(int maxWidth, int maxHeight);

	void SetShadowBrush(int a, int r, int g, int b, bool heavy);
}

public interface IInGameTopPainter : IPlugin
{
	void PaintTopInGame(ClipState clipState);
}

public interface IInGameWorldPainter : IPlugin
{
	void PaintWorld(WorldLayer layer);
}

public interface IItemIdentifiedHandler : IPlugin
{
	void OnItemIdentified(Item item);
}

public interface IItemLocationChangedHandler : IPlugin
{
	void OnItemLocationChanged(Item item, ItemLocation from, ItemLocation to);
}

public interface IItemPickedHandler : IPlugin
{
	void OnItemPicked(Item item);
}

public interface InputEventHandler : IPlugin
{
	void OnInputEvent(InputEvent inputEventEvent);
}

public interface ILootGeneratedHandler : IPlugin
{
	void OnLootGenerated(Item item, bool gambled);
}

public interface IUIComponent
{
	RectangleF Bounds { get; set; }

	void Draw(int menuX, int menuY);
	bool HandleInput(int mouseX, int mouseY, bool isMouseClicked);
}

public interface IMenuOption
{
	string Name { get; }

	IReadOnlyList<IUIComponent> GetComponents();
}

public interface IMonsterKilledHandler : IPlugin
{
	void OnMonsterKilled(Monster monster);
}

public interface IMouseClickHandler : IPlugin
{
	bool MouseDown(Vk button);

	bool MouseUp(Vk button);
}

public interface INewAreaHandler : IPlugin
{
	void OnNewArea(bool newGame, SnoArea area);
}

public interface IKeyEventHandler : IPlugin
{
	void OnKeyEvent(InputEvent keyEvent);
}

public interface IPlugin
{
	bool Enabled { get; set; }

	void Load();
}

public interface IPortalFoundHandler : IPlugin
{
	void OnPortalFound(Portal portal);
}

public interface ISkillCooldownHandler : IPlugin
{
	void OnCooldown(Skill playerSkill, bool expired);
}

public interface ITransparent
{
	float Opacity { get; set; }
}

public interface ITransparentCollection
{
	IEnumerable<ITransparent> GetTransparents();
}

public interface IPerfCounter
{
	double LastCount { get; }

	double LastValue { get; }
}

public interface IMouseClickBlocker : IPlugin
{
	bool MouseClickShouldBeBlocked(MouseButtons button, int x, int y);
}

public interface IItemKeepDecisionHandler : IPlugin
{
	ItemKeepDecision CalculateItemKeepDecision(Item item, ItemKeepDecision previousDecision);
}

public static class StopwatchExtensions
{
	public static bool TimerTest(this Stopwatch watch, long milliseconds)
	{
		if (milliseconds == 0 || (!watch.IsRunning && watch.ElapsedTicks == 0)) return true;

		return watch.ElapsedMilliseconds >= milliseconds;
	}
}

public interface IStatTrackerCore
{
	double GainedExperience { get; }
	long GainedGold { get; }
	long MonsterKill { get; }
	long EliteKill { get; }
	long DropAll { get; }
	long DropWhite { get; }
	long DropMagic { get; }
	long DropRare { get; }
	long DropLegendary { get; }
	long DropAncient { get; }
	long DropPrimalAncient { get; }
	long DropGold { get; }
	long DropBloodShard { get; }
	long Death { get; }
	double DamageDealtAll { get; }
	double DamageDealtCrit { get; }
	double DamageTaken { get; }
	double Healing { get; }
	double WalkYards { get; }
	long ElapsedMilliseconds { get; }
	long TownElapsedMilliseconds { get; }
	long PlayElapsedMilliseconds { get; }
	double GainedExperiencePerHourFull { get; }
	double GainedExperiencePerHourPlay { get; }
	double GainedGoldPerHour { get; }
	double MonsterKillPerHour { get; }
	double EliteKillPerHour { get; }
	double DropAllPerHour { get; }
	double DropWhitePerHour { get; }
	double DropMagicPerHour { get; }
	double DropRarePerHour { get; }
	double DropLegendaryPerHour { get; }
	double DropAncientPerHour { get; }
	double DropPrimalAncientPerHour { get; }
	double DropGoldPerHour { get; }
	double DropBloodShardPerHour { get; }
	double DeathPerHour { get; }
	double DamageDealtAllPerSecond { get; }
	double DamageDealtCritPerSecond { get; }
	double DamageTakenPerSecond { get; }
	double HealingPerSecond { get; }
	double MonsterKillPerLegendary { get; }
	double EliteKillPerLegendary { get; }
}

public interface IStatTracker : IStatTrackerCore
{
	string Id { get; }
	string Title { get; }
	SnoArea SnoArea { get; }
	bool AlwaysRunning { get; }
	bool IsMainTimerRunning { get; }
	bool IsTownTimerRunning { get; }
}