using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RiftAssistant.Model;

internal class UiElements
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
	private const int MaxChatLength = 8192;
	private const int MaxChatScanEntries = 32;
	private const int ChatPollIntervalMs = 100;
	private const int ChatLineBufferSize = 1024;

	private readonly Dictionary<string, UiElement> all = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> rootElements = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> conditionalElements = new(StringComparer.Ordinal);

	private HashNode nodeBuffer = new();

	private Stopwatch refreshTimer = new();

	private int bucketCount;
	private int uiHash;
	private long[] buckets;
	private string lastChat;
	private readonly Stopwatch chatPollTimer = Stopwatch.StartNew();
	private byte[] chatLineBuffer = new byte[ChatLineBufferSize];
	private byte[] lastChatLineBuffer = new byte[ChatLineBufferSize];
	private bool hasLastChatLine;
	private static readonly long ChatTextPointerOffset = (long)Marshal.OffsetOf<UiElementData>(nameof(UiElementData.UnknownPtr1));

	public EventHandler<ChatChanged> ChatChanged;

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

		foreach (var element in rootElements.Values) {
			element.Refresh();
		}

		foreach (var element in conditionalElements.Values) {
			RefreshConditional(element);
		}

		HandleDisconnectPopup();
		ProcessChat(force);
		if (SubmitButton.Visible) {
			CoreCollector.BattleTag = null;
			CoreCollector.HeroCollector.method_2();
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

	private void ProcessChat(bool force)
	{
		if (ChatChanged == null) return;
		if (!force && chatPollTimer.ElapsedMilliseconds < ChatPollIntervalMs) return;

		chatPollTimer.Restart();

		string current = ReadChat(true);
		if (current == lastChat) return;

		ChatChanged?.Invoke(this, new ChatChanged {
			Current = current,
			Previous = lastChat
		});
		lastChat = current;
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

	public string ReadChat(bool stripFormatting)
	{
		if (bucketCount == 0 || !ChatMessagelist.Visible) {
			hasLastChatLine = false;
			return null;
		}

		long textAddress = FindFirstChatTextAddress();
		if (textAddress == 0) {
			hasLastChatLine = false;
			return null;
		}

		if (!GameWindowManager.ReadIntoArray(textAddress, chatLineBuffer, 0, ChatLineBufferSize)) return lastChat;

		if (hasLastChatLine && chatLineBuffer.AsSpan().SequenceEqual(lastChatLineBuffer)) return lastChat;

		(chatLineBuffer, lastChatLineBuffer) = (lastChatLineBuffer, chatLineBuffer);
		hasLastChatLine = true;

		var raw = lastChatLineBuffer.AsSpan();
		int terminator = raw[1..].IndexOf((byte)0);
		int length = terminator < 0 ? raw.Length : terminator + 1;
		return SanitizeChat(Encoding.UTF8.GetString(raw[..length]), stripFormatting);
	}

	private long FindFirstChatTextAddress()
	{
		int childCount = ChatMessagelist.GetChildCount();
		if ((uint)childCount > MaxChatLength) return 0;

		int count = Math.Min(childCount, MaxChatScanEntries);

		for (int i = 0; i < count; i++) {
			long dataAddress = ChatMessagelist.ReadChildDataAddress(i);
			if (dataAddress == 0) continue;

			long textAddress = GameWindowManager.Read<long>(dataAddress + ChatTextPointerOffset);
			if (textAddress != 0) return textAddress;
		}

		return 0;
	}
	private static string SanitizeChat(string text, bool stripFormatting)
	{
		if (string.IsNullOrEmpty(text))	return null;

		if (text[0] == '\0')
			text = "{" + text[1..];

		int end = text.StartsWith("\0c", StringComparison.Ordinal)
			? text.IndexOf('\0', 2)
			: text.IndexOf('\0');

		if (end >= 0)
			text = text[..end].Trim();

		if (text == "{" || !text.StartsWith("{c:", StringComparison.Ordinal))
			return null;

		if (!stripFormatting)
			return text;

		text = text.Replace("{/c}", "", StringComparison.Ordinal);

		text = RemoveTags(text, "{c:");
		text = RemoveTags(text, "{icon:");

		return text;
	}

	private static string RemoveTags(string text, string tag)
	{
		while (true) {
			int start = text.IndexOf(tag, StringComparison.Ordinal);

			if (start < 0)
				return text;

			int end = text.IndexOf('}', start);

			if (end < 0)
				return text;

			text = text.Remove(start, end - start + 1);
		}
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
					element.bool_0 = true;
					element.Visible = (element.Class75_0.Flags & 4) != 0;

					if (element.Visible &&
						!TryBuildRectangle(
							element.Class75_0,
							ref element.rectangle,
							element.PaddingX,
							element.PaddingY)) {
						element.Visible = false;
					}

					return;
				}
			}

			current = nodeBuffer.Next;
		}

		Hide(element);
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

	internal void SetupUiElements()
	{
		InGameBottomHudUiElement = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_window_hud_overlay");
		VendorDialogMainPagePanel = Register("Root.NormalLayer.vendor_dialog_mainPage.panel", InGameBottomHudUiElement);
		QuestNameValue = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.CurrentQuestContainer.QuestNameValue");
		DifficultyTextValue = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.CurrentQuestContainer.DifficultyTextValue");
		PlayGameButton = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Menu.PlayGameButton", QuestNameValue);
		ChangeQuestButton = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Menu.ChangeQuestButton", QuestNameValue);
		SwitchHero = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Slot1.LayoutRoot.SwitchHero", QuestNameValue);
		PortraitText = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Slot1.LayoutRoot.Portrait.text", QuestNameValue);
		InviteToPartyNotification = Register("Root.TopLayer.BattleNetNotifications_main.Invite To Party Notification");
		JoinRequestNotification = Register("Root.TopLayer.BattleNetNotifications_main.Join request Notification");
		LeaveGameWindow = Register("Root.TopLayer.BattleNetNotifications_main.LayoutRoot.LeaveGameWindow", InGameBottomHudUiElement);
		GameOptionsMainLayoutRootOverlayContainer = Register("Root.NormalLayer.GameOptions_main.LayoutRoot.OverlayContainer");
		ParagonLevelUpSplashTextUiElement = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.altLevelUp_splash.text");
		NephalemRiftBarUiElement = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.rift_container.rift_progress_bar", InGameBottomHudUiElement);
		GreaterRiftBarUiElement = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.greater_rift_container.rift_progress_bar", InGameBottomHudUiElement);
		ChallengeRiftBarUiElement = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.challenge_rift_container.rift_progress_bar", InGameBottomHudUiElement);
		ChallengeRiftAheadPanelUiElement = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.challenge_rift_container.challenge_sprint_time.challengeRift_sprintFrame", InGameBottomHudUiElement);
		GameTextLine0 = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.game_text_line0");
		EventtextRegion = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region");
		class341_96 = new UiElement[59];
		class341_96[0] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item0.Item", VendorDialogMainPagePanel);
		class341_96[1] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item1.Item", VendorDialogMainPagePanel);
		class341_96[2] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item2.Item", VendorDialogMainPagePanel);
		class341_96[3] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item3.Item", VendorDialogMainPagePanel);
		class341_96[4] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item4.Item", VendorDialogMainPagePanel);
		class341_96[6] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item6.Item", VendorDialogMainPagePanel);
		class341_96[7] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item7.Item", VendorDialogMainPagePanel);
		class341_96[8] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item8.Item", VendorDialogMainPagePanel);
		class341_96[9] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item9.Item", VendorDialogMainPagePanel);
		class341_96[10] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item10.Item", VendorDialogMainPagePanel);
		class341_96[12] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item12.Item", VendorDialogMainPagePanel);
		class341_96[13] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item13.Item", VendorDialogMainPagePanel);
		class341_96[14] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item14.Item", VendorDialogMainPagePanel);
		class341_96[15] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item15.Item", VendorDialogMainPagePanel);
		class341_96[16] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item16.Item", VendorDialogMainPagePanel);
		class341_96[18] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item18.Item", VendorDialogMainPagePanel);
		class341_96[19] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item19.Item", VendorDialogMainPagePanel);
		class341_96[20] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item20.Item", VendorDialogMainPagePanel);
		class341_96[21] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item21.Item", VendorDialogMainPagePanel);
		class341_96[22] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item22.Item", VendorDialogMainPagePanel);
		class341_96[24] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item24.Item", VendorDialogMainPagePanel);
		class341_96[25] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item25.Item", VendorDialogMainPagePanel);
		class341_96[26] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item26.Item", VendorDialogMainPagePanel);
		class341_96[27] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item27.Item", VendorDialogMainPagePanel);
		class341_96[28] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item28.Item", VendorDialogMainPagePanel);
		class341_96[30] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item30.Item", VendorDialogMainPagePanel);
		class341_96[31] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item31.Item", VendorDialogMainPagePanel);
		class341_96[32] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item32.Item", VendorDialogMainPagePanel);
		class341_96[33] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item33.Item", VendorDialogMainPagePanel);
		class341_96[34] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item34.Item", VendorDialogMainPagePanel);
		class341_96[36] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item36.Item", VendorDialogMainPagePanel);
		class341_96[37] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item37.Item", VendorDialogMainPagePanel);
		class341_96[38] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item38.Item", VendorDialogMainPagePanel);
		class341_96[39] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item39.Item", VendorDialogMainPagePanel);
		class341_96[40] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item40.Item", VendorDialogMainPagePanel);
		class341_96[42] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item42.Item", VendorDialogMainPagePanel);
		class341_96[43] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item43.Item", VendorDialogMainPagePanel);
		class341_96[44] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item44.Item", VendorDialogMainPagePanel);
		class341_96[45] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item45.Item", VendorDialogMainPagePanel);
		class341_96[46] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item46.Item", VendorDialogMainPagePanel);
		class341_96[48] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item48.Item", VendorDialogMainPagePanel);
		class341_96[49] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item49.Item", VendorDialogMainPagePanel);
		class341_96[50] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item50.Item", VendorDialogMainPagePanel);
		class341_96[51] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item51.Item", VendorDialogMainPagePanel);
		class341_96[52] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item52.Item", VendorDialogMainPagePanel);
		class341_96[54] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item54.Item", VendorDialogMainPagePanel);
		class341_96[55] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item55.Item", VendorDialogMainPagePanel);
		class341_96[56] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item56.Item", VendorDialogMainPagePanel);
		class341_96[57] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item57.Item", VendorDialogMainPagePanel);
		class341_96[58] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item58.Item", VendorDialogMainPagePanel);
		ItemsListContent = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content", VendorDialogMainPagePanel);
		BattleNetGameSettingsMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetGameSettings_main.LayoutRoot.OverlayContainer", QuestNameValue);
		LoadScreenText = Register("Root.TopLayer.LoadScreenText");
		GameWindowHudOverlayClassic = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_window_hud_overlay_classic");
		InGameBottomHudUiElement.ReplacementWhenNotVisible = GameWindowHudOverlayClassic;
		GameWindowHudOverlayClassic.ReplacementWhenNotVisible = InGameBottomHudUiElement;
		GameProgressBarHealthBall = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_healthBall");
		GameProgressBarManaBall = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_manaBall");
		StashMainUiElement = Register("Root.NormalLayer.stash_dialog_mainPage.panel", InGameBottomHudUiElement);
		ButtonStash = Register("Root.NormalLayer.stash_dialog_mainPage.button_stash", StashMainUiElement);
		for (int i = 0; i < StashTabs.Length; i++) {
			StashTabs[i] = Register("Root.NormalLayer.stash_dialog_mainPage.tab_" + (i + 1).ToString("D", CultureInfo.InvariantCulture), StashMainUiElement);
		}
		for (int j = 0; j < StashPages.Length; j++) {
			StashPages[j] = Register("Root.NormalLayer.stash_dialog_mainPage.TabPageButtons.stash_pages.page_" + (j + 1).ToString("D", CultureInfo.InvariantCulture), StashMainUiElement);
		}
		EquipmentManagerMainPage = Register("Root.NormalLayer.equipmentManager_mainPage", InGameBottomHudUiElement);
		Details = Register("Root.NormalLayer.equipmentManager_mainPage.details", InGameBottomHudUiElement);
		class341_129 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.gemcombine_dialog.craft_button", VendorDialogMainPagePanel);
		class341_130 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.craftarmor_dialog.craft_button", VendorDialogMainPagePanel);
		class341_131 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.craftweapons_dialog.craft_button", VendorDialogMainPagePanel);
		salvageButton = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_button", VendorDialogMainPagePanel);
		salvageTabButton = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_button", VendorDialogMainPagePanel);
		salvageNormal = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_normal_button", VendorDialogMainPagePanel);
		salvageMagic = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_magic_button", VendorDialogMainPagePanel);
		salvageRare = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_rare_button", VendorDialogMainPagePanel);
		class341_137 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.rewardChoicePane.Container.upgrade_button1", InGameBottomHudUiElement);
		class341_138 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.rewardChoicePane.Container.Continue", InGameBottomHudUiElement);
		Subdlg = Register("Root.TopLayer.confirmation.subdlg");
		class341_140 = new UiElement("Root.TopLayer.confirmation.subdlg.stack.wrap.button_ok");
		class341_141 = new UiElement("Root.NormalLayer.BattleNetQuestSelection_main.LayoutRoot.OverlayContainer", QuestNameValue);
		class341_142 = new UiElement("Root.NormalLayer.BattleNetQuestSelection_main.LayoutRoot.OverlayContainer.SelectQuestButton", QuestNameValue);
		SubmitButton = Register("Root.NormalLayer.BattleNetLogin_main.LayoutRoot.LoginContainer.SubmitButton");
		BattleNetAchievementsMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetAchievements_main.LayoutRoot.OverlayContainer");
		LatencyMeter = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.latency_meter");
		LorePlayerDlgBackground = Register("Root.NormalLayer.lore_player_dlg.background", InGameBottomHudUiElement);
		LoreNotifyDlg = Register("Root.NormalLayer.lore_notify_dlg", InGameBottomHudUiElement);
		EventtextRegionTitle = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.title", InGameBottomHudUiElement);
		DropDownContent = Register("Root.TopLayer.DropDown._content");
		Stackpanel = Register("Root.TopLayer.DropDown._content._stackpanel", DropDownContent);
		Item1Stack = Register("Root.TopLayer.item 1.stack");
		InventoryMainUiElement = Register("Root.NormalLayer.inventory_dialog_mainPage", InGameBottomHudUiElement);
		InventorySidePaneContainer = Register("Root.NormalLayer.inventory_side_pane_container", InGameBottomHudUiElement);
		InventoryItemsUiElement = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_backpack", InventoryMainUiElement);
		InventoryButtonHead = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_head", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonShoulders = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_shoulders", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonNeck = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_neck", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonBracers = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_bracers", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonTorso = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_torso", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonHands = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_hands", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonWaist = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_waist", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonLegs = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_legs", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonFeet = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_feet", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonFingerLeft = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_fingerLeft", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonFingerRight = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_fingerRight", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonArmLeft = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_armLeft", InventoryMainUiElement, null, 1f, 1f);
		InventoryButtonArmRight = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_armRight", InventoryMainUiElement, null, 1f, 1f);
		HirelingSlotHead = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_head", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotShoulders = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_shoulders", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotNeck = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_neck", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotBracers = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_bracers", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotTorso = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_torso", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotHands = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_hands", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotWaist = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_waist", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotLegs = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_legs", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotFeet = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_feet", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotLeftFinger = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_left_finger", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotRightFinger = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_right_finger", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotMainhand = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_mainhand", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotOffhand = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_offhand", FollowerMainUiElement, null, 1f, 1f);
		HirelingSlotSpecial = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_special", FollowerMainUiElement, null, 1f, 1f);
		CharacterDetailsContainer = Register("Root.NormalLayer.character_details_container", InGameBottomHudUiElement);
		FollowerMainUiElement = Register("Root.NormalLayer.hireling_dialog_mainPage", InGameBottomHudUiElement);
		HirelingDetailsContainer = Register("Root.NormalLayer.hireling_details_container", FollowerMainUiElement);
		RiftDialogMainPage = Register("Root.NormalLayer.rift_dialog_mainPage");
		KanaisRecipesMain = Register("Root.NormalLayer.Kanais_Recipes_main", VendorDialogMainPagePanel);
		KanaisCollection = Register("Root.NormalLayer.Kanais_Collection", VendorDialogMainPagePanel);
		Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.ActList");
		InspectMainPage = Register("Root.NormalLayer.inspect_mainPage", InGameBottomHudUiElement);
		ShopDialogMainPagePanel = Register("Root.NormalLayer.shop_dialog_mainPage.panel", InGameBottomHudUiElement);
		GoldText = Register("Root.NormalLayer.shop_dialog_mainPage.gold_text", ShopDialogMainPagePanel);
		SkillPaneMainLayoutRoot = Register("Root.NormalLayer.SkillPane_main.LayoutRoot", InGameBottomHudUiElement);
		SkillsList = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.SkillsList", SkillPaneMainLayoutRoot);
		PassiveSkillSelect = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.PassiveSkillSelect", SkillPaneMainLayoutRoot);
		ActiveSkillSelect = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.ActiveSkillSelect", SkillPaneMainLayoutRoot);
		GamemenuBkgrnd = Register("Root.NormalLayer.gamemenu_dialog.gamemenu_bkgrnd");
		ConversationDialogMain = Register("Root.NormalLayer.conversation_dialog_main");
		Clock = Register("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper.BoostsDifficultyStackPanel.clock", InGameBottomHudUiElement);
		ListTitle = Register("Root.TopLayer.BattleNetModalNotifications_main.ModalNotification.Content.List.Title");
		Cutscene = Register("Root.TopLayer.cutscene");
		ScriptedSequence = Register("Root.TopLayer.scripted_sequence");
		Item2Stack = Register("Root.TopLayer.item 2.stack");
		TopWrapperStack = Register("Root.TopLayer.item 2.stack.top_wrapper.stack", Item2Stack);
		FrameInstruction = Register("Root.TopLayer.item 2.stack.frame_instruction", Item2Stack);
		Item3Stack = Register("Root.TopLayer.item 3.stack");
		ChatMessagelist = Register("Root.NormalLayer.chatoutput_dialog_backgroundScreen.chat_content.MessageListContainer.chat_messagelist");
		chatOpened = Register("Root.NormalLayer.chatentry_dialog_backgroundScreen.chatentry_content.chat_editline");
		ParagonPointSelect = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect", InGameBottomHudUiElement);
		MapDialogMainPage = Register("Root.NormalLayer.map_dialog_mainPage");
		MinimapUiElement = Register("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.minimap_pve_main");
		Localmap = Register("Root.NormalLayer.map_dialog_mainPage.localmap", MapDialogMainPage);
		WorldMapUiElement = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer");
		Instructions = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.instructions");
		ActMapUiElement = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.WorldMap", WorldMapUiElement);
		FriendsListContent = Register("Root.NormalLayer.BattleNetFriendsList_main.LayoutRoot.OverlayContainer.FriendsListContent");
		GroupsListContent = Register("Root.NormalLayer.GroupList_main.LayoutRoot.OverlayContainer.GroupsListContent");
		GuildFinderMainLayoutRootOverlayContainer = Register("Root.NormalLayer.GuildFinder_main.LayoutRoot.OverlayContainer");
		BattleNetLeaderboardMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetLeaderboard_main.LayoutRoot.OverlayContainer");
		BattleNetSeasonJourneyMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetSeasonJourney_main.LayoutRoot.OverlayContainer");
		BattleNetStoreMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetStore_main.LayoutRoot.OverlayContainer");
		FrameBackground = Register("Root.NormalLayer.GreaterRifts_VictoryScreen.LayoutRoot.frame_background", InGameBottomHudUiElement);
		PrimaryFrameButtonExit = Register("Root.NormalLayer.GreaterRifts_VictoryScreen.LayoutRoot.Primary_Frame.button_exit", FrameBackground);
		DialogSendRealIdRequest = Register("Root.TopLayer.BattleNetSocialDialogs_main.LayoutRoot.DialogSendRealIdRequest");
		BuffIconWrapper = Register("Root.NormalLayer.buffs_backgroundScreen.buff_icon_wrapper", InGameBottomHudUiElement);
		BuffBarExtendedBuffsUiElement = Register("Root.NormalLayer.buffs_backgroundScreen.ExtendedBuffHolderTemplate.ExtendedBuff.FirstBuff", InGameBottomHudUiElement);
		HpBarNormalProgressbar = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_normal.progressbar", InGameBottomHudUiElement);
		HpBarBountyProgressbar = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_bounty.progressbar", InGameBottomHudUiElement);
		HpBarMinionProgressbar = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_minion.progressbar", InGameBottomHudUiElement);
		HpBarPlayerProgressbar = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_player.progressbar", InGameBottomHudUiElement);
		HpBarSpecialProgressbar = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_special.progressbar", InGameBottomHudUiElement);
		GamePotion = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_potion", InGameBottomHudUiElement);
		class341_144[0] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_activeSkillLeft", InGameBottomHudUiElement);
		class341_144[1] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_activeSkillRight", InGameBottomHudUiElement);
		class341_144[2] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_1", InGameBottomHudUiElement);
		class341_144[3] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_2", InGameBottomHudUiElement);
		class341_144[4] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_3", InGameBottomHudUiElement);
		class341_144[5] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_4", InGameBottomHudUiElement);
		class341_145[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.Frame", InGameBottomHudUiElement);
		class341_145[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.Frame", InGameBottomHudUiElement);
		class341_145[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.Frame", InGameBottomHudUiElement);
		class341_145[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.Frame", InGameBottomHudUiElement);
		class341_146[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.icon", InGameBottomHudUiElement);
		class341_146[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.icon", InGameBottomHudUiElement);
		class341_146[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.icon", InGameBottomHudUiElement);
		class341_146[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.icon", InGameBottomHudUiElement);
		class341_147[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.Background", InGameBottomHudUiElement);
		class341_147[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.Background", InGameBottomHudUiElement);
		class341_147[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.Background", InGameBottomHudUiElement);
		class341_147[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.Background", InGameBottomHudUiElement);
		BattleNetProfileMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetProfile_main.LayoutRoot.OverlayContainer");
		PlayerContextMenu = Register("Root.TopLayer.ContextMenus.PlayerContextMenu", InGameBottomHudUiElement);
		InGamePortraitTooltip2 = Register("Root.TopLayer.in game portrait tooltip 2");
		TradeDialogMainPage = Register("Root.NormalLayer.trade_dialog_mainPage", InGameBottomHudUiElement);
		TradeGoldAmountOther = Register("Root.NormalLayer.trade_dialog_mainPage.trade_gold_amount_other", TradeDialogMainPage);
		TradeGoldAmountMine = Register("Root.NormalLayer.trade_dialog_mainPage.trade_gold_amount_mine", TradeDialogMainPage);
		Skill2Stack = Register("Root.TopLayer.skill 2.stack");
		Banner2 = Register("Root.TopLayer.banner 2", InGameBottomHudUiElement);
		BattleNetProfileBannerCustomizationMainLayoutRootOverlayContainer = Register("Root.NormalLayer.BattleNetProfileBannerCustomization_main.LayoutRoot.OverlayContainer");
		InGamePetContextMenu = Register("Root.TopLayer.ContextMenus.InGamePetContextMenu", InGameBottomHudUiElement);
		Tooltip2 = Register("Root.TopLayer.tooltip_dialog_background.tooltip_2");
		RactorTag0 = Register("Root.NormalLayer.game_dialog_main.RActorTag0", InGameBottomHudUiElement);
		QuestrewardDialog = Register("Root.NormalLayer.questreward_dialog", InGameBottomHudUiElement);
		QuestrewardDialogButtonExit = Register("Root.NormalLayer.questreward_dialog.button_exit", QuestrewardDialog);
		BountyRewardMainLayoutRoot = Register("Root.NormalLayer.BountyReward_main.LayoutRoot", InGameBottomHudUiElement);
		TieredRiftRewardMainLayoutRoot = Register("Root.NormalLayer.TieredRiftReward_main.LayoutRoot", InGameBottomHudUiElement);
		QuestloreDialogPanel = Register("Root.NormalLayer.questlore_dialog.panel", InGameBottomHudUiElement);
		GuildMainLayoutRootOverlayContainer = Register("Root.NormalLayer.Guild_main.LayoutRoot.OverlayContainer", InGameBottomHudUiElement);
		class341_98 = new UiElement("Root.NormalLayer.DurabilityIndicator", InGameBottomHudUiElement);
		class341_99 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_at_corpse", InGameBottomHudUiElement);
		class341_100 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_at_checkpoint", InGameBottomHudUiElement);
		class341_101 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_in_town", InGameBottomHudUiElement);
		ButtonAcceptResurrection = Register("Root.NormalLayer.deathmenu_dialog.dialog_main.button_accept_resurrection", InGameBottomHudUiElement);
		DlgNewParagonButton = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.dlg_new_paragon.button", InGameBottomHudUiElement);
		Tab1 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.tab_1", ParagonPointSelect);
		PointsAvailable1 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Points_Available_1", ParagonPointSelect);
		Bonus0PointsSpent = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus0.PointsSpent", ParagonPointSelect);
		Bonus0IncreaseStat = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus0.IncreaseStat", ParagonPointSelect);
		Bonus1PointsSpent = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus1.PointsSpent", ParagonPointSelect);
		Bonus1IncreaseStat = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus1.IncreaseStat", ParagonPointSelect);
		AcceptParagonPointsButton = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.AcceptParagonPointsButton", ParagonPointSelect);
		BossEnterMainStackWrapperAccept = Register("Root.NormalLayer.boss_enter_main.stack.wrapper.Accept", InGameBottomHudUiElement);
		BossJoinPartyMainStackWrapperAccept = Register("Root.NormalLayer.boss_join_party_main.stack.wrapper.Accept", InGameBottomHudUiElement);
		class341_114 = new UiElement("Root.NormalLayer.BattleNetWhatsNew_main.LayoutRoot.OverlayContainer.PageHeader.CloseButton");
		class341_115 = new UiElement("Root.TopLayer.ContextMenus.PlayerContextMenu.PlayerContextMenuContent.PlayerContextMenuList.InGameTeleportToPlayer", InGameBottomHudUiElement);
		class341_116 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.accept_Button", InGameBottomHudUiElement);
		confirmationMessage = Register("Root.TopLayer.confirmation.subdlg.stack.message", InGameBottomHudUiElement);
		confirmationCancel = Register("Root.TopLayer.confirmation.subdlg.stack.wrap.button_cancel", confirmationMessage);
		confirmationOk = Register("Root.TopLayer.confirmation.subdlg.stack.wrap.button_ok", confirmationMessage);
		RiftJoinPartyMainStackWrapperAccept = Register("Root.NormalLayer.rift_join_party_main.stack.wrapper.Accept", InGameBottomHudUiElement);
		class341_120 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.upgrade_button", InGameBottomHudUiElement);
		class341_121 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftRadioButtons.NephalemRiftButton", RiftDialogMainPage);
		class341_122 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftRadioButtons.GreaterRiftButton", RiftDialogMainPage);
		RiftTierLevelCombo = Register("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftTierLevelCombo", RiftDialogMainPage);
		Arrow = Register("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftTierLevelCombo.arrow", RiftDialogMainPage);
		PartyOkButton = Register("Root.TopLayer.BattleNetNotifications_main.Invite To Party Notification.PartyOkButton", InviteToPartyNotification);
	}
}
