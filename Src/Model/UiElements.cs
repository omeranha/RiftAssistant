using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace RiftAssistant.Model;

internal partial class UiElements
{
	public UiElement QuestNameValue = null!;

	public UiElement DifficultyTextValue = null!;

	public UiElement PlayGameButton = null!;

	public UiElement ChangeQuestButton = null!;

	public UiElement SwitchHero = null!;

	public UiElement PortraitText = null!;

	public UiElement BattleNetGameSettingsMainLayoutRootOverlayContainer = null!;

	public UiElement[] StashTabs = new UiElement[5];

	public UiElement[] StashPages = new UiElement[4];

	public UiElement StashMainUiElement = null!;

	public UiElement ButtonStash = null!;

	public UiElement InventoryMainUiElement = null!;

	public UiElement InventorySidePaneContainer = null!;

	public UiElement InventoryItemsUiElement = null!;

	public UiElement CharacterDetailsContainer = null!;

	public UiElement FollowerMainUiElement = null!;

	public UiElement InspectMainPage = null!;

	public UiElement EquipmentManagerMainPage = null!;

	public UiElement Details = null!;

	public UiElement InventoryButtonHead = null!;

	public UiElement InventoryButtonShoulders = null!;

	public UiElement InventoryButtonNeck = null!;

	public UiElement InventoryButtonHands = null!;

	public UiElement InventoryButtonBracers = null!;

	public UiElement InventoryButtonTorso = null!;

	public UiElement InventoryButtonWaist = null!;

	public UiElement InventoryButtonLegs = null!;

	public UiElement InventoryButtonFeet = null!;

	public UiElement InventoryButtonFingerLeft = null!;

	public UiElement InventoryButtonFingerRight = null!;

	public UiElement InventoryButtonArmLeft = null!;

	public UiElement InventoryButtonArmRight = null!;

	public UiElement HirelingSlotHead = null!;

	public UiElement HirelingSlotShoulders = null!;

	public UiElement HirelingSlotNeck = null!;

	public UiElement HirelingSlotHands = null!;

	public UiElement HirelingSlotBracers = null!;

	public UiElement HirelingSlotTorso = null!;

	public UiElement HirelingSlotWaist = null!;

	public UiElement HirelingSlotLegs = null!;

	public UiElement HirelingSlotFeet = null!;

	public UiElement HirelingSlotRightFinger = null!;

	public UiElement HirelingSlotLeftFinger = null!;

	public UiElement HirelingSlotMainhand = null!;

	public UiElement HirelingSlotOffhand = null!;

	public UiElement HirelingSlotSpecial = null!;

	public UiElement VendorDialogMainPagePanel = null!;

	public UiElement ShopDialogMainPagePanel = null!;

	public UiElement GoldText = null!;

	public UiElement KanaisRecipesMain = null!;

	public UiElement KanaisCollection = null!;

	public UiElement SkillPaneMainLayoutRoot = null!;

	public UiElement SkillsList = null!;

	public UiElement PassiveSkillSelect = null!;

	public UiElement ActiveSkillSelect = null!;

	public UiElement ParagonPointSelect = null!;

	public UiElement GamemenuBkgrnd = null!;

	public UiElement ConversationDialogMain = null!;

	public UiElement Clock = null!;

	public UiElement ListTitle = null!;

	public UiElement SubmitButton = null!;

	public UiElement LoadScreenText = null!;

	public UiElement Cutscene = null!;

	public UiElement ScriptedSequence = null!;

	public UiElement InGameBottomHudUiElement = null!;

	public UiElement GameWindowHudOverlayClassic = null!;

	public UiElement GameProgressBarHealthBall = null!;

	public UiElement GameProgressBarManaBall = null!;

	public UiElement Item2Stack = null!;

	public UiElement TopWrapperStack = null!;

	public UiElement FrameInstruction = null!;

	public UiElement Item1Stack = null!;

	public UiElement ChatMessagelist = null!;

	public UiElement Item3Stack = null!;

	public UiElement chatOpened = null!;

	public UiElement FriendsListContent = null!;

	public UiElement GroupsListContent = null!;

	public UiElement GuildFinderMainLayoutRootOverlayContainer = null!;

	public UiElement BattleNetLeaderboardMainLayoutRootOverlayContainer = null!;

	public UiElement BattleNetSeasonJourneyMainLayoutRootOverlayContainer = null!;

	public UiElement BattleNetStoreMainLayoutRootOverlayContainer = null!;

	public UiElement FrameBackground = null!;

	public UiElement PrimaryFrameButtonExit = null!;

	public UiElement DialogSendRealIdRequest = null!;

	public UiElement MapDialogMainPage = null!;

	public UiElement MinimapUiElement = null!;

	public UiElement WorldMapUiElement = null!;

	public UiElement Instructions = null!;

	public UiElement ActMapUiElement = null!;

	public UiElement GameOptionsMainLayoutRootOverlayContainer = null!;

	public UiElement ParagonLevelUpSplashTextUiElement = null!;

	public UiElement QuestrewardDialog = null!;

	public UiElement QuestrewardDialogButtonExit = null!;

	public UiElement BountyRewardMainLayoutRoot = null!;

	public UiElement TieredRiftRewardMainLayoutRoot = null!;

	public UiElement EventtextRegionTitle = null!;

	public UiElement[] uiElements = null!;

	public UiElement ItemsListContent = null!;

	public UiElement durabilityIndicator = null!;

	public UiElement buttonReviveAtCorpse = null!;

	public UiElement buttonReviveAtCheckpoint = null!;

	public UiElement buttonReviveInTown = null!;

	public UiElement ButtonAcceptResurrection = null!;

	public UiElement BossEnterMainStackWrapperAccept = null!;

	public UiElement BossJoinPartyMainStackWrapperAccept = null!;

	public UiElement RiftJoinPartyMainStackWrapperAccept = null!;

	public UiElement DlgNewParagonButton = null!;

	public UiElement Tab1 = null!;

	public UiElement Bonus0PointsSpent = null!;

	public UiElement Bonus1PointsSpent = null!;

	public UiElement Bonus0IncreaseStat = null!;

	public UiElement Bonus1IncreaseStat = null!;

	public UiElement PointsAvailable1 = null!;

	public UiElement AcceptParagonPointsButton = null!;

	public UiElement closeButton = null!;

	public UiElement inGameTeleportToPlayer = null!;

	public UiElement acceptButton = null!;

	public UiElement confirmationMessage = null!;

	public UiElement confirmationOk = null!;

	public UiElement confirmationCancel = null!;

	public UiElement upgradeButton = null!;

	public UiElement nephalemRiftButton = null!;

	public UiElement greaterRiftButton = null!;

	public UiElement RiftTierLevelCombo = null!;

	public UiElement Arrow = null!;

	public UiElement PartyOkButton = null!;

	public UiElement Localmap = null!;

	public UiElement BuffIconWrapper = null!;

	public UiElement BuffBarExtendedBuffsUiElement = null!;

	public UiElement craftButton = null!;

	public UiElement craftarmorDialogCraftButton = null!;

	public UiElement craftweaponsDialogCraftButton = null!;

	public UiElement salvageButton = null!;

	public UiElement salvageTabButton = null!;

	public UiElement salvageNormal = null!;

	public UiElement salvageMagic = null!;

	public UiElement salvageRare = null!;

	public UiElement upgradeButton1 = null!;

	public UiElement class341_138 = null!;

	public UiElement Subdlg = null!;

	public UiElement buttonOk = null!;

	public UiElement overlayContainer = null!;

	public UiElement selectQuestButton = null!;

	public UiElement GamePotion = null!;

	public UiElement[] uiElements144 = new UiElement[6];

	public UiElement[] uiElements145 = new UiElement[4];

	public UiElement[] uiElements146 = new UiElement[4];

	public UiElement[] uiElements147 = new UiElement[4];

	public UiElement BattleNetProfileMainLayoutRootOverlayContainer = null!;

	public UiElement PlayerContextMenu = null!;

	public UiElement InGamePortraitTooltip2 = null!;

	public UiElement TradeDialogMainPage = null!;

	public UiElement TradeGoldAmountMine = null!;

	public UiElement TradeGoldAmountOther = null!;

	public UiElement DropDownContent = null!;

	public UiElement Stackpanel = null!;

	public UiElement BattleNetAchievementsMainLayoutRootOverlayContainer = null!;

	public UiElement LatencyMeter = null!;

	public UiElement Skill2Stack = null!;

	public UiElement Banner2 = null!;

	public UiElement BattleNetProfileBannerCustomizationMainLayoutRootOverlayContainer = null!;

	public UiElement InGamePetContextMenu = null!;

	public UiElement Tooltip2 = null!;

	public UiElement HirelingDetailsContainer = null!;

	public UiElement RiftDialogMainPage = null!;

	public UiElement QuestloreDialogPanel = null!;

	public UiElement RactorTag0 = null!;

	public UiElement InviteToPartyNotification = null!;

	public UiElement LorePlayerDlgBackground = null!;

	public UiElement LoreNotifyDlg = null!;

	public UiElement JoinRequestNotification = null!;

	public UiElement LeaveGameWindow = null!;

	public UiElement NephalemRiftBarUiElement = null!;

	public UiElement GreaterRiftBarUiElement = null!;

	public UiElement ChallengeRiftBarUiElement = null!;

	public UiElement ChallengeRiftAheadPanelUiElement = null!;

	public UiElement GameTextLine0 = null!;

	public UiElement EventtextRegion = null!;

	public UiElement GuildMainLayoutRootOverlayContainer = null!;

	public UiElement HpBarNormalProgressbar = null!;

	public UiElement HpBarBountyProgressbar = null!;

	public UiElement HpBarMinionProgressbar = null!;

	public UiElement HpBarPlayerProgressbar = null!;

	public UiElement HpBarSpecialProgressbar = null!;

	private const int MaxUiElements = 32768;
	private const int MaxChainDepth = 1000;

	private readonly Dictionary<string, UiElement> all = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> rootElements = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> conditionalElements = new(StringComparer.Ordinal);

	private HashNode nodeBuffer = new();

	private Stopwatch refreshTimer = new();

	private int bucketCount;
	private int uiHash;
	private long[] buckets = null!;

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
	private static bool IsVisible(UiElement? element)
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
		if (!IsVisible(element.uiElement0) || !IsVisible(element.uiElement1)) {
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
				CoreCollector.ClearGameServerContext();
				break;
		}
	}

	internal List<UiElement> EnumerateUi()
	{
		var result = new List<UiElement>();
		for (int i = 0; i < bucketCount; i++) {
			long current = buckets[i];
			int depth = 0;
			while (current != 0 && depth++ < 100) {
				var node = GameWindowManager.Read<HashNode>(current);
				string path = GameWindowManager.ReadString(node.Value + 56, 512, Encoding.ASCII, true);
				result.Add(CreateTemporary(path));
				current = node.Next;
			}
		}

		return result;
	}

	public UiElement Register(string path, UiElement? requiredVisible = null, UiElement? requiredHidden = null, float paddingX = 0f, float paddingY = 0f) {
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

		if (element.uiElement0 == null && element.uiElement1 == null) {
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
			element.Bucket = ComputeBucket(element.hash, uiHash);

		if ((uint)element.Bucket >= bucketCount)
			return;

		long current = buckets[element.Bucket];
		int depth = 0;

		while (current != 0 && depth++ < MaxChainDepth) {
			nodeBuffer = GameWindowManager.Read<HashNode>(current);
			if (nodeBuffer.Key == element.hashPath) {
				element.long_0 = nodeBuffer.Value;
				element.Class75_0 = GameWindowManager.Read<UiElementData>(element.long_0);

				if (element.Class75_0.Id == element.hashPath) {
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
