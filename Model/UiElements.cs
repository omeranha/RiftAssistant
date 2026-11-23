using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace RiftAssistant.Model;

internal partial class UiElements
{
	public UiElement QuestNameValue;

	public UiElement DifficultyTextValue;

	public UiElement PlayGameButton;

	public UiElement ChangeQuestButton;

	public UiElement SwitchHero;

	public UiElement PortraitText;

	public UiElement BattleNetGameSettingsMainLayoutRootOverlayContainer;

	public UiElement[] StashTabs = new UiElement[5];

	public UiElement[] StashPages = new UiElement[4];

	public UiElement StashMainUiElement;

	public UiElement ButtonStash;

	public UiElement InventoryMainUiElement;

	public UiElement InventorySidePaneContainer;

	public UiElement InventoryItemsUiElement;

	public UiElement CharacterDetailsContainer;

	public UiElement FollowerMainUiElement;

	public UiElement InspectMainPage;

	public UiElement EquipmentManagerMainPage;

	public UiElement Details;

	public UiElement InventoryButtonHead;

	public UiElement InventoryButtonShoulders;

	public UiElement InventoryButtonNeck;

	public UiElement InventoryButtonHands;

	public UiElement InventoryButtonBracers;

	public UiElement InventoryButtonTorso;

	public UiElement InventoryButtonWaist;

	public UiElement InventoryButtonLegs;

	public UiElement InventoryButtonFeet;

	public UiElement InventoryButtonFingerLeft;

	public UiElement InventoryButtonFingerRight;

	public UiElement InventoryButtonArmLeft;

	public UiElement InventoryButtonArmRight;

	public UiElement HirelingSlotHead;

	public UiElement HirelingSlotShoulders;

	public UiElement HirelingSlotNeck;

	public UiElement HirelingSlotHands;

	public UiElement HirelingSlotBracers;

	public UiElement HirelingSlotTorso;

	public UiElement HirelingSlotWaist;

	public UiElement HirelingSlotLegs;

	public UiElement HirelingSlotFeet;

	public UiElement HirelingSlotRightFinger;

	public UiElement HirelingSlotLeftFinger;

	public UiElement HirelingSlotMainhand;

	public UiElement HirelingSlotOffhand;

	public UiElement HirelingSlotSpecial;

	public UiElement VendorDialogMainPagePanel;

	public UiElement ShopDialogMainPagePanel;

	public UiElement GoldText;

	public UiElement KanaisRecipesMain;

	public UiElement KanaisCollection;

	public UiElement SkillPaneMainLayoutRoot;

	public UiElement SkillsList;

	public UiElement PassiveSkillSelect;

	public UiElement ActiveSkillSelect;

	public UiElement ParagonPointSelect;

	public UiElement GamemenuBkgrnd;

	public UiElement ConversationDialogMain;

	public UiElement Clock;

	public UiElement ListTitle;

	public UiElement SubmitButton;

	public UiElement LoadScreenText;

	public UiElement Cutscene;

	public UiElement ScriptedSequence;

	public UiElement InGameBottomHudUiElement;

	public UiElement GameWindowHudOverlayClassic;

	public UiElement GameProgressBarHealthBall;

	public UiElement GameProgressBarManaBall;

	public UiElement Item2Stack;

	public UiElement TopWrapperStack;

	public UiElement FrameInstruction;

	public UiElement Item1Stack;

	public UiElement ChatMessagelist;

	public UiElement Item3Stack;

	public UiElement chatOpened;

	public UiElement FriendsListContent;

	public UiElement GroupsListContent;

	public UiElement GuildFinderMainLayoutRootOverlayContainer;

	public UiElement BattleNetLeaderboardMainLayoutRootOverlayContainer;

	public UiElement BattleNetSeasonJourneyMainLayoutRootOverlayContainer;

	public UiElement BattleNetStoreMainLayoutRootOverlayContainer;

	public UiElement FrameBackground;

	public UiElement PrimaryFrameButtonExit;

	public UiElement DialogSendRealIdRequest;

	public UiElement MapDialogMainPage;

	public UiElement MinimapUiElement;

	public UiElement WorldMapUiElement;

	public UiElement Instructions;

	public UiElement ActMapUiElement;

	public UiElement GameOptionsMainLayoutRootOverlayContainer;

	public UiElement ParagonLevelUpSplashTextUiElement;

	public UiElement QuestrewardDialog;

	public UiElement QuestrewardDialogButtonExit;

	public UiElement BountyRewardMainLayoutRoot;

	public UiElement TieredRiftRewardMainLayoutRoot;

	public UiElement EventtextRegionTitle;

	public UiElement[] class341_96;

	public UiElement ItemsListContent;

	public UiElement class341_98;

	public UiElement class341_99;

	public UiElement class341_100;

	public UiElement class341_101;

	public UiElement ButtonAcceptResurrection;

	public UiElement BossEnterMainStackWrapperAccept;

	public UiElement BossJoinPartyMainStackWrapperAccept;

	public UiElement RiftJoinPartyMainStackWrapperAccept;

	public UiElement DlgNewParagonButton;

	public UiElement Tab1;

	public UiElement Bonus0PointsSpent;

	public UiElement Bonus1PointsSpent;

	public UiElement Bonus0IncreaseStat;

	public UiElement Bonus1IncreaseStat;

	public UiElement PointsAvailable1;

	public UiElement AcceptParagonPointsButton;

	public UiElement class341_114;

	public UiElement class341_115;

	public UiElement class341_116;

	public UiElement confirmationMessage;

	public UiElement confirmationOk;

	public UiElement confirmationCancel;

	public UiElement class341_120;

	public UiElement class341_121;

	public UiElement class341_122;

	public UiElement RiftTierLevelCombo;

	public UiElement Arrow;

	public UiElement PartyOkButton;

	public UiElement Localmap;

	public UiElement BuffIconWrapper;

	public UiElement BuffBarExtendedBuffsUiElement;

	public UiElement class341_129;

	public UiElement class341_130;

	public UiElement class341_131;

	public UiElement salvageButton;

	public UiElement salvageTabButton;

	public UiElement salvageNormal;

	public UiElement salvageMagic;

	public UiElement salvageRare;

	public UiElement class341_137;

	public UiElement class341_138;

	public UiElement Subdlg;

	public UiElement class341_140;

	public UiElement class341_141;

	public UiElement class341_142;

	public UiElement GamePotion;

	public UiElement[] class341_144 = new UiElement[6];

	public UiElement[] class341_145 = new UiElement[4];

	public UiElement[] class341_146 = new UiElement[4];

	public UiElement[] class341_147 = new UiElement[4];

	public UiElement BattleNetProfileMainLayoutRootOverlayContainer;

	public UiElement PlayerContextMenu;

	public UiElement InGamePortraitTooltip2;

	public UiElement TradeDialogMainPage;

	public UiElement TradeGoldAmountMine;

	public UiElement TradeGoldAmountOther;

	public UiElement DropDownContent;

	public UiElement Stackpanel;

	public UiElement BattleNetAchievementsMainLayoutRootOverlayContainer;

	public UiElement LatencyMeter;

	public UiElement Skill2Stack;

	public UiElement Banner2;

	public UiElement BattleNetProfileBannerCustomizationMainLayoutRootOverlayContainer;

	public UiElement InGamePetContextMenu;

	public UiElement Tooltip2;

	public UiElement HirelingDetailsContainer;

	public UiElement RiftDialogMainPage;

	public UiElement QuestloreDialogPanel;

	public UiElement RactorTag0;

	public UiElement InviteToPartyNotification;

	public UiElement LorePlayerDlgBackground;

	public UiElement LoreNotifyDlg;

	public UiElement JoinRequestNotification;

	public UiElement LeaveGameWindow;

	public UiElement NephalemRiftBarUiElement;

	public UiElement GreaterRiftBarUiElement;

	public UiElement ChallengeRiftBarUiElement;

	public UiElement ChallengeRiftAheadPanelUiElement;

	public UiElement GameTextLine0;

	public UiElement EventtextRegion;

	public UiElement GuildMainLayoutRootOverlayContainer;

	public UiElement HpBarNormalProgressbar;

	public UiElement HpBarBountyProgressbar;

	public UiElement HpBarMinionProgressbar;

	public UiElement HpBarPlayerProgressbar;

	public UiElement HpBarSpecialProgressbar;

	private const int MaxUiElements = 32768;
	private const int MaxChainDepth = 1000;

	private readonly Dictionary<string, UiElement> all = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> rootElements = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> conditionalElements = new(StringComparer.Ordinal);

	private HashNode nodeBuffer = new();

	private Stopwatch refreshTimer = new();

	private int bucketCount;
	private int uiHash;
	private long[] buckets;

	public int RefreshIntervalMs { get; set; }

	public Dictionary<string, UiElement> All => all;

	public Dictionary<string, UiElement> RootElements => rootElements;

	public Dictionary<string, UiElement> ConditionalElements => conditionalElements;

	internal void Refresh(bool force)
	{
		if (!force && RefreshIntervalMs > 0 && refreshTimer.ElapsedMilliseconds < RefreshIntervalMs) return;

		long uiManager = GameWindowManager.Read<long>(CoreCollector.D3Memory.UIManagerAddress);
		long bucketTable = uiManager + 16;
		long bucketPtr = GameWindowManager.Read<long>(bucketTable);
		bucketCount = GameWindowManager.Read<int>(bucketTable + 8);
		if ((uint)bucketCount is 0 or >= MaxUiElements) return;

		refreshTimer.Restart();

		if (buckets == null || buckets.Length != bucketCount) buckets = new long[bucketCount];

		uiHash = GameWindowManager.Read<int>(uiManager);
		buckets = GameWindowManager.ReadArray<long>(bucketPtr, bucketCount);

		RefreshRootElements();
		RefreshConditionalElements();

		HandleDisconnectPopup();
		ProcessChat(force);
		if (SubmitButton.Visible) {
			CoreCollector.BattleTag = null;
			CoreCollector.HeroCollector.ClearHeroes();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsVisible(UiElement element)
	{
		if (element == null) return true;

		if (element.Visible) return true;

		var replacement = element.ReplacementWhenNotVisible;
		return replacement != null && replacement.Visible;
	}

	private static void Hide(UiElement element)
	{
		element.bool_0 = false;
		element.Visible = false;
	}

	private static void RefreshConditional(UiElement element)
	{
		if (!IsVisible(element.iuiElement_0) || !IsVisible(element.iuiElement_1)) {
			Hide(element);
			return;
		}

		element.Refresh();
	}

	private void HandleDisconnectPopup()
	{
		if (!ListTitle.Visible) return;

		switch (ListTitle.ReadText()) {
			case "NETWORK DISCONNECT":
			case "ERROR":
			case "LOST CONNECTION":
				CoreCollector.ClearGameServerContext("disconnect notification");
				break;
		}
	}

	internal List<UiElement> EnumerateUi()
	{
		var result = new List<UiElement>();
		var node = new HashNode();
		for (int i = 0; i < bucketCount; i++) {
			long current = buckets[i];
			int depth = 0;
			while (current != 0 && depth++ < 100) {
				node = GameWindowManager.Read<HashNode>(current);
				string path = GameWindowManager.ReadString(node.Value + 56, 512, Encoding.ASCII, true);
				result.Add(CreateTemporary(path));
				current = node.Next;
			}
		}

		return result;
	}

	public UiElement Register(string path, UiElement requiredVisible = null, UiElement requiredHidden = null, float paddingX = 0f, float paddingY = 0f) {
		if (all.TryGetValue(path, out var existing)) return existing;

		var element = new UiElement(path, requiredVisible, requiredHidden) {
			PaddingX = paddingX,
			PaddingY = paddingY
		};

		Add(element);
		return element;
	}

	public UiElement CreateTemporary(string path)
	{
		var element = new UiElement(path);
		element.Refresh();
		return element;
	}

	public void Add(UiElement element)
	{
		all.Add(element.Path, element);

		if (element.iuiElement_0 == null && element.iuiElement_1 == null) {
			rootElements.Add(element.Path, element);
		} else {
			conditionalElements.Add(element.Path, element);
		}
	}

	public void Remove(UiElement element)
	{
		all.Remove(element.Path);
		rootElements.Remove(element.Path);
		conditionalElements.Remove(element.Path);
	}

	public int GetSelectedStashPage()
	{
		for (int i = 0; i < StashPages.Length; i++) {
			var tab = StashPages[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState == 14) {
				return i;
			}
		}

		return 0;
	}

	public int GetActiveStashTab()
	{
		if (!StashMainUiElement.Visible) return -1;

		for (int i = 0; i < StashTabs.Length; i++) {
			var tab = StashTabs[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState % 3 == 1) {
				return i;
			}
		}

		return -1;
	}

	public int GetInactiveStashTab()
	{
		if (!StashMainUiElement.Visible)
			return -1;

		for (int i = 0; i < StashTabs.Length; i++) {
			var tab = StashTabs[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState % 3 == 0) {
				return i;
			}
		}

		return -1;
	}

	public void Resolve(UiElement element)
	{
		if (bucketCount <= 0 || uiHash <= 0)
			return;

		if ((uint)element.Bucket >= bucketCount)
			element.Bucket = ComputeBucket(element.int_0, uiHash);

		if ((uint)element.Bucket >= bucketCount)
			return;

		long current = buckets[element.Bucket];
		int depth = 0;

		while (current != 0 && depth++ < MaxChainDepth) {
			nodeBuffer = GameWindowManager.Read<HashNode>(current);
			if (nodeBuffer.Key == element.ulong_0) {
				element.long_0 = nodeBuffer.Value;
				element.Class75_0 = GameWindowManager.Read<UiElementData>(element.long_0);

				if (element.Class75_0.Id == element.ulong_0) {
					ApplyResolved(element);
					return;
				}
			}

			current = nodeBuffer.Next;
		}

		Hide(element);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ApplyResolved(UiElement element)
	{
		element.bool_0 = true;
		element.Visible = (element.Class75_0.Flags & 4) != 0;

		if (element.Visible && !TryBuildRectangle(element.Class75_0, ref element.rectangle, element.PaddingX, element.PaddingY)) {
			element.Visible = false;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ComputeBucket(int hash, int uiHash)
	{
		byte b0 = (byte)hash;
		byte b1 = (byte)(hash >> 8);
		byte b2 = (byte)(hash >> 16);
		byte b3 = (byte)(hash >> 24);

		return (int)(uiHash &
			(uint)(
				16777619 *
				(b3 ^
				(16777619 *
				(b2 ^
				(16777619 *
				(b1 ^
				(16777619 *
				(b0 ^ -2128831035)))))))));
	}

	internal bool TryBuildRectangle(
		UiElementData data,
		ref RectangleF rect,
		float paddingX = 0f,
		float paddingY = 0f)
	{
		try {
			if (float.IsNaN(data.Left) ||
				float.IsNaN(data.Top) ||
				float.IsNaN(data.Right) ||
				float.IsNaN(data.Bottom)) {
				rect = default;
				return false;
			}

			float scale = GameWindowManager.Window.HeightUiRatio;
			float offset = GameWindowManager.Window.WidescreenOffset;

			float left = (data.Left + offset) * scale;
			float right = (data.Right + offset) * scale;
			float top = data.Top * scale;
			float bottom = data.Bottom * scale;

			if (!float.IsFinite(left) ||
				!float.IsFinite(right) ||
				!float.IsFinite(top) ||
				!float.IsFinite(bottom)) {
				rect = default;
				return false;
			}

			rect.X = left - paddingX;
			rect.Y = top - paddingY;
			rect.Width = right - left + (paddingX * 2f);
			rect.Height = bottom - top + (paddingY * 2f);

			return true;
		} catch {
			rect = default;
			return false;
		}
	}
}
