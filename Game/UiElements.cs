using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Plugins;
using work;

internal class UiElements
{
	public UiElement class341_0;

	public UiElement class341_1;

	public UiElement class341_2;

	public UiElement class341_3;

	public UiElement class341_4;

	public UiElement class341_5;

	public UiElement class341_6;

	public UiElement[] class341_7 = new UiElement[5];

	public UiElement[] class341_8 = new UiElement[4];

	public UiElement class341_9;

	public UiElement class341_10;

	public UiElement class341_11;

	public UiElement class341_12;

	public UiElement class341_13;

	public UiElement class341_14;

	public UiElement class341_15;

	public UiElement class341_16;

	public UiElement class341_17;

	public UiElement class341_18;

	public UiElement class341_19;

	public UiElement class341_20;

	public UiElement class341_21;

	public UiElement class341_22;

	public UiElement class341_23;

	public UiElement class341_24;

	public UiElement class341_25;

	public UiElement class341_26;

	public UiElement class341_27;

	public UiElement class341_28;

	public UiElement class341_29;

	public UiElement class341_30;

	public UiElement class341_31;

	public UiElement class341_32;

	public UiElement class341_33;

	public UiElement class341_34;

	public UiElement class341_35;

	public UiElement class341_36;

	public UiElement class341_37;

	public UiElement class341_38;

	public UiElement class341_39;

	public UiElement class341_40;

	public UiElement class341_41;

	public UiElement class341_42;

	public UiElement class341_43;

	public UiElement class341_44;

	public UiElement class341_45;

	public UiElement class341_46;

	public UiElement class341_47;

	public UiElement class341_48;

	public UiElement class341_49;

	public UiElement class341_50;

	public UiElement class341_51;

	public UiElement class341_52;

	public UiElement class341_53;

	public UiElement class341_54;

	public UiElement class341_55;

	public UiElement class341_56;

	public UiElement class341_57;

	public UiElement class341_58;

	public UiElement class341_59;

	public UiElement class341_60;

	public UiElement class341_61;

	public UiElement class341_62;

	public UiElement class341_63;

	public UiElement class341_64;

	public UiElement class341_65;

	public UiElement class341_66;

	public UiElement class341_67;

	public UiElement class341_68;

	public UiElement class341_69;

	public UiElement class341_70;

	public UiElement class341_71;

	public UiElement class341_72;

	public UiElement class341_73;

	public UiElement chatOpened;

	public UiElement class341_75;

	public UiElement class341_76;

	public UiElement class341_77;

	public UiElement class341_78;

	public UiElement class341_79;

	public UiElement class341_80;

	public UiElement class341_81;

	public UiElement class341_82;

	public UiElement class341_83;

	public UiElement class341_84;

	public UiElement class341_85;

	public UiElement class341_86;

	public UiElement class341_87;

	public UiElement class341_88;

	public UiElement class341_89;

	public UiElement class341_90;

	public UiElement class341_91;

	public UiElement class341_92;

	public UiElement class341_93;

	public UiElement class341_94;

	public UiElement class341_95;

	public UiElement[] class341_96;

	public UiElement class341_97;

	public UiElement class341_98;

	public UiElement class341_99;

	public UiElement class341_100;

	public UiElement class341_101;

	public UiElement class341_102;

	public UiElement class341_103;

	public UiElement class341_104;

	public UiElement class341_105;

	public UiElement class341_106;

	public UiElement class341_107;

	public UiElement class341_108;

	public UiElement class341_109;

	public UiElement class341_110;

	public UiElement class341_111;

	public UiElement class341_112;

	public UiElement class341_113;

	public UiElement class341_114;

	public UiElement class341_115;

	public UiElement class341_116;

	public UiElement confirmationMessage;

	public UiElement confirmationOk;

	public UiElement confirmationCancel;

	public UiElement class341_120;

	public UiElement class341_121;

	public UiElement class341_122;

	public UiElement class341_123;

	public UiElement class341_124;

	public UiElement class341_125;

	public UiElement class341_126;

	public UiElement class341_127;

	public UiElement class341_128;

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

	public UiElement class341_139;

	public UiElement class341_140;

	public UiElement class341_141;

	public UiElement class341_142;

	public UiElement class341_143;

	public UiElement[] class341_144 = new UiElement[6];

	public UiElement[] class341_145 = new UiElement[4];

	public UiElement[] class341_146 = new UiElement[4];

	public UiElement[] class341_147 = new UiElement[4];

	public UiElement class341_148;

	public UiElement class341_149;

	public UiElement class341_150;

	public UiElement class341_151;

	public UiElement class341_152;

	public UiElement class341_153;

	public UiElement class341_154;

	public UiElement class341_155;

	public UiElement class341_156;

	public UiElement class341_157;

	public UiElement class341_158;

	public UiElement class341_159;

	public UiElement class341_160;

	public UiElement class341_161;

	public UiElement class341_162;

	public UiElement class341_163;

	public UiElement class341_164;

	public UiElement class341_165;

	public UiElement class341_166;

	public UiElement class341_167;

	public UiElement class341_168;

	public UiElement class341_169;

	public UiElement class341_170;

	public UiElement class341_171;

	public UiElement class341_172;

	public UiElement class341_173;

	public UiElement class341_174;

	public UiElement class341_175;

	public UiElement class341_176;

	public UiElement class341_177;

	public UiElement class341_178;

	public UiElement class341_179;

	public UiElement class341_180;

	public UiElement class341_181;

	public UiElement class341_182;

	public UiElement class341_183;

	private const int MaxUiElements = 32768;
	private const int MaxChainDepth = 1000;
	private const int MaxChatLength = 8192;

	private readonly Dictionary<string, UiElement> all = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> rootElements = new(StringComparer.Ordinal);
	private readonly Dictionary<string, UiElement> conditionalElements = new(StringComparer.Ordinal);

	private HashNode nodeBuffer = new();

	private Stopwatch refreshTimer = new();

	private int bucketCount;
	private int uiHash;
	private long[] buckets;
	private string lastChat;

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
		//ProcessChat(force);
		if (class341_60.Visible) {
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
		if (!class341_59.Visible) return;

		switch (class341_59.ReadText()) {
			case "NETWORK DISCONNECT":
			case "ERROR":
			case "LOST CONNECTION":
				CoreCollector.ClearGameServerContext("disconnect notification");
				break;
		}
	}

	private void ProcessChat(bool stripFormatting)
	{
		string current = ReadChat(stripFormatting);
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
			float_0 = paddingX,
			float_1 = paddingY
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
		for (int i = 0; i < class341_8.Length; i++) {
			var tab = class341_8[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState == 14) {
				return i;
			}
		}

		return 0;
	}

	public int GetActiveStashTab()
	{
		if (!class341_9.Visible) return -1;

		for (int i = 0; i < class341_7.Length; i++) {
			var tab = class341_7[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState % 3 == 1) {
				return i;
			}
		}

		return -1;
	}

	public int GetInactiveStashTab()
	{
		if (!class341_9.Visible)
			return -1;

		for (int i = 0; i < class341_7.Length; i++) {
			var tab = class341_7[i];

			tab.Refresh();

			if (tab.Visible && tab.AnimState % 3 == 0) {
				return i;
			}
		}

		return -1;
	}

	public string ReadChat(bool stripFormatting)
	{
		if (bucketCount == 0 || !class341_72.Visible) return null;

		int count = class341_72.method_4();
		if ((uint)count > MaxChatLength) return null;

		var entry = new UiElementData();
		for (int i = 0; i < count; i++) {
			class341_72.method_5(i, entry);

			if (entry.UnknownPtr1 == 0) continue;

			string text = GameWindowManager.ReadString(entry.UnknownPtr1, 1024, Encoding.UTF8, false);
			return SanitizeChat(text, stripFormatting);
		}

		return null;
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

		if ((uint)element.int_1 >= bucketCount)
			element.int_1 = ComputeBucket(element.int_0, uiHash);

		if ((uint)element.int_1 >= bucketCount)
			return;

		long current = buckets[element.int_1];
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
							ref element.rectangleF_0,
							element.float_0,
							element.float_1)) {
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
		class341_64 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_window_hud_overlay");
		class341_46 = Register("Root.NormalLayer.vendor_dialog_mainPage.panel", class341_64);
		class341_0 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.CurrentQuestContainer.QuestNameValue");
		class341_1 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.CurrentQuestContainer.DifficultyTextValue");
		class341_2 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Menu.PlayGameButton", class341_0);
		class341_3 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Menu.ChangeQuestButton", class341_0);
		class341_4 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Slot1.LayoutRoot.SwitchHero", class341_0);
		class341_5 = Register("Root.NormalLayer.BattleNetCampaign_main.LayoutRoot.Slot1.LayoutRoot.Portrait.text", class341_0);
		class341_167 = Register("Root.TopLayer.BattleNetNotifications_main.Invite To Party Notification");
		class341_170 = Register("Root.TopLayer.BattleNetNotifications_main.Join request Notification");
		class341_171 = Register("Root.TopLayer.BattleNetNotifications_main.LayoutRoot.LeaveGameWindow", class341_64);
		class341_89 = Register("Root.NormalLayer.GameOptions_main.LayoutRoot.OverlayContainer");
		class341_90 = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.altLevelUp_splash.text");
		class341_172 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.rift_container.rift_progress_bar", class341_64);
		class341_173 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.greater_rift_container.rift_progress_bar", class341_64);
		class341_174 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.challenge_rift_container.rift_progress_bar", class341_64);
		class341_175 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.stackpanel.rift_wrapper.challenge_rift_container.challenge_sprint_time.challengeRift_sprintFrame", class341_64);
		class341_176 = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.game_text_line0");
		class341_177 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region");
		class341_96 = new UiElement[59];
		class341_96[0] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item0.Item", class341_46);
		class341_96[1] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item1.Item", class341_46);
		class341_96[2] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item2.Item", class341_46);
		class341_96[3] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item3.Item", class341_46);
		class341_96[4] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow0._item4.Item", class341_46);
		class341_96[6] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item6.Item", class341_46);
		class341_96[7] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item7.Item", class341_46);
		class341_96[8] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item8.Item", class341_46);
		class341_96[9] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item9.Item", class341_46);
		class341_96[10] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow1._item10.Item", class341_46);
		class341_96[12] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item12.Item", class341_46);
		class341_96[13] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item13.Item", class341_46);
		class341_96[14] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item14.Item", class341_46);
		class341_96[15] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item15.Item", class341_46);
		class341_96[16] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow2._item16.Item", class341_46);
		class341_96[18] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item18.Item", class341_46);
		class341_96[19] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item19.Item", class341_46);
		class341_96[20] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item20.Item", class341_46);
		class341_96[21] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item21.Item", class341_46);
		class341_96[22] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow3._item22.Item", class341_46);
		class341_96[24] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item24.Item", class341_46);
		class341_96[25] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item25.Item", class341_46);
		class341_96[26] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item26.Item", class341_46);
		class341_96[27] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item27.Item", class341_46);
		class341_96[28] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow4._item28.Item", class341_46);
		class341_96[30] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item30.Item", class341_46);
		class341_96[31] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item31.Item", class341_46);
		class341_96[32] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item32.Item", class341_46);
		class341_96[33] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item33.Item", class341_46);
		class341_96[34] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow5._item34.Item", class341_46);
		class341_96[36] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item36.Item", class341_46);
		class341_96[37] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item37.Item", class341_46);
		class341_96[38] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item38.Item", class341_46);
		class341_96[39] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item39.Item", class341_46);
		class341_96[40] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow6._item40.Item", class341_46);
		class341_96[42] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item42.Item", class341_46);
		class341_96[43] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item43.Item", class341_46);
		class341_96[44] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item44.Item", class341_46);
		class341_96[45] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item45.Item", class341_46);
		class341_96[46] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow7._item46.Item", class341_46);
		class341_96[48] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item48.Item", class341_46);
		class341_96[49] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item49.Item", class341_46);
		class341_96[50] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item50.Item", class341_46);
		class341_96[51] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item51.Item", class341_46);
		class341_96[52] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow8._item52.Item", class341_46);
		class341_96[54] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item54.Item", class341_46);
		class341_96[55] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item55.Item", class341_46);
		class341_96[56] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item56.Item", class341_46);
		class341_96[57] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item57.Item", class341_46);
		class341_96[58] = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content._stackpanel._tilerow9._item58.Item", class341_46);
		class341_97 = Register("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.items_list._content", class341_46);
		class341_6 = Register("Root.NormalLayer.BattleNetGameSettings_main.LayoutRoot.OverlayContainer", class341_0);
		class341_61 = Register("Root.TopLayer.LoadScreenText");
		class341_65 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_window_hud_overlay_classic");
		class341_64.ReplacementWhenNotVisible = class341_65;
		class341_65.ReplacementWhenNotVisible = class341_64;
		class341_66 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_healthBall");
		class341_67 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_progressBar_manaBall");
		class341_9 = Register("Root.NormalLayer.stash_dialog_mainPage.panel", class341_64);
		class341_10 = Register("Root.NormalLayer.stash_dialog_mainPage.button_stash", class341_9);
		for (int i = 0; i < class341_7.Length; i++) {
			class341_7[i] = Register("Root.NormalLayer.stash_dialog_mainPage.tab_" + (i + 1).ToString("D", CultureInfo.InvariantCulture), class341_9);
		}
		for (int j = 0; j < class341_8.Length; j++) {
			class341_8[j] = Register("Root.NormalLayer.stash_dialog_mainPage.TabPageButtons.stash_pages.page_" + (j + 1).ToString("D", CultureInfo.InvariantCulture), class341_9);
		}
		class341_17 = Register("Root.NormalLayer.equipmentManager_mainPage", class341_64);
		class341_18 = Register("Root.NormalLayer.equipmentManager_mainPage.details", class341_64);
		class341_129 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.gemcombine_dialog.craft_button", class341_46);
		class341_130 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.craftarmor_dialog.craft_button", class341_46);
		class341_131 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.craftweapons_dialog.craft_button", class341_46);
		salvageButton = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_button", class341_46);
		salvageTabButton = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_button", class341_46);
		salvageNormal = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_normal_button", class341_46);
		salvageMagic = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_magic_button", class341_46);
		salvageRare = Register("Root.NormalLayer.vendor_dialog_mainPage.salvage_dialog.salvage_all_wrapper.salvage_rare_button", class341_46);
		class341_137 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.rewardChoicePane.Container.upgrade_button1", class341_64);
		class341_138 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.rewardChoicePane.Container.Continue", class341_64);
		class341_139 = Register("Root.TopLayer.confirmation.subdlg");
		class341_140 = new UiElement("Root.TopLayer.confirmation.subdlg.stack.wrap.button_ok");
		class341_141 = new UiElement("Root.NormalLayer.BattleNetQuestSelection_main.LayoutRoot.OverlayContainer", class341_0);
		class341_142 = new UiElement("Root.NormalLayer.BattleNetQuestSelection_main.LayoutRoot.OverlayContainer.SelectQuestButton", class341_0);
		class341_60 = Register("Root.NormalLayer.BattleNetLogin_main.LayoutRoot.LoginContainer.SubmitButton");
		class341_156 = Register("Root.NormalLayer.BattleNetAchievements_main.LayoutRoot.OverlayContainer");
		class341_157 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.latency_meter");
		class341_168 = Register("Root.NormalLayer.lore_player_dlg.background", class341_64);
		class341_169 = Register("Root.NormalLayer.lore_notify_dlg", class341_64);
		class341_95 = Register("Root.NormalLayer.eventtext_bkgrnd.eventtext_region.title", class341_64);
		class341_154 = Register("Root.TopLayer.DropDown._content");
		class341_155 = Register("Root.TopLayer.DropDown._content._stackpanel", class341_154);
		class341_71 = Register("Root.TopLayer.item 1.stack");
		class341_11 = Register("Root.NormalLayer.inventory_dialog_mainPage", class341_64);
		class341_12 = Register("Root.NormalLayer.inventory_side_pane_container", class341_64);
		class341_13 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_backpack", class341_11);
		class341_19 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_head", class341_11, null, 1f, 1f);
		class341_20 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_shoulders", class341_11, null, 1f, 1f);
		class341_21 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_neck", class341_11, null, 1f, 1f);
		class341_23 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_bracers", class341_11, null, 1f, 1f);
		class341_24 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_torso", class341_11, null, 1f, 1f);
		class341_22 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_hands", class341_11, null, 1f, 1f);
		class341_25 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_waist", class341_11, null, 1f, 1f);
		class341_26 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_legs", class341_11, null, 1f, 1f);
		class341_27 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_feet", class341_11, null, 1f, 1f);
		class341_28 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_fingerLeft", class341_11, null, 1f, 1f);
		class341_29 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_fingerRight", class341_11, null, 1f, 1f);
		class341_30 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_armLeft", class341_11, null, 1f, 1f);
		class341_31 = Register("Root.NormalLayer.inventory_dialog_mainPage.inventory_button_armRight", class341_11, null, 1f, 1f);
		class341_32 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_head", class341_15, null, 1f, 1f);
		class341_33 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_shoulders", class341_15, null, 1f, 1f);
		class341_34 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_neck", class341_15, null, 1f, 1f);
		class341_36 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_bracers", class341_15, null, 1f, 1f);
		class341_37 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_torso", class341_15, null, 1f, 1f);
		class341_35 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_hands", class341_15, null, 1f, 1f);
		class341_38 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_waist", class341_15, null, 1f, 1f);
		class341_39 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_legs", class341_15, null, 1f, 1f);
		class341_40 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_feet", class341_15, null, 1f, 1f);
		class341_42 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_left_finger", class341_15, null, 1f, 1f);
		class341_41 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_right_finger", class341_15, null, 1f, 1f);
		class341_43 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_mainhand", class341_15, null, 1f, 1f);
		class341_44 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_offhand", class341_15, null, 1f, 1f);
		class341_45 = Register("Root.NormalLayer.hireling_dialog_mainPage.hireling_slot_special", class341_15, null, 1f, 1f);
		class341_14 = Register("Root.NormalLayer.character_details_container", class341_64);
		class341_15 = Register("Root.NormalLayer.hireling_dialog_mainPage", class341_64);
		class341_163 = Register("Root.NormalLayer.hireling_details_container", class341_15);
		class341_164 = Register("Root.NormalLayer.rift_dialog_mainPage");
		class341_49 = Register("Root.NormalLayer.Kanais_Recipes_main", class341_46);
		class341_50 = Register("Root.NormalLayer.Kanais_Collection", class341_46);
		Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.ActList");
		class341_16 = Register("Root.NormalLayer.inspect_mainPage", class341_64);
		class341_47 = Register("Root.NormalLayer.shop_dialog_mainPage.panel", class341_64);
		class341_48 = Register("Root.NormalLayer.shop_dialog_mainPage.gold_text", class341_47);
		class341_51 = Register("Root.NormalLayer.SkillPane_main.LayoutRoot", class341_64);
		class341_52 = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.SkillsList", class341_51);
		class341_53 = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.PassiveSkillSelect", class341_51);
		class341_54 = Register("Root.NormalLayer.SkillPane_main.LayoutRoot.ActiveSkillSelect", class341_51);
		class341_56 = Register("Root.NormalLayer.gamemenu_dialog.gamemenu_bkgrnd");
		class341_57 = Register("Root.NormalLayer.conversation_dialog_main");
		class341_58 = Register("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.BoostWrapper.BoostsDifficultyStackPanel.clock", class341_64);
		class341_59 = Register("Root.TopLayer.BattleNetModalNotifications_main.ModalNotification.Content.List.Title");
		class341_62 = Register("Root.TopLayer.cutscene");
		class341_63 = Register("Root.TopLayer.scripted_sequence");
		class341_68 = Register("Root.TopLayer.item 2.stack");
		class341_69 = Register("Root.TopLayer.item 2.stack.top_wrapper.stack", class341_68);
		class341_70 = Register("Root.TopLayer.item 2.stack.frame_instruction", class341_68);
		class341_73 = Register("Root.TopLayer.item 3.stack");
		class341_72 = Register("Root.NormalLayer.chatoutput_dialog_backgroundScreen.chat_content.MessageListContainer.chat_messagelist");
		chatOpened = Register("Root.NormalLayer.chatentry_dialog_backgroundScreen.chatentry_content.chat_editline");
		class341_55 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect", class341_64);
		class341_84 = Register("Root.NormalLayer.map_dialog_mainPage");
		class341_85 = Register("Root.NormalLayer.minimap_dialog_backgroundScreen.minimap_dialog_pve.minimap_pve_main");
		class341_126 = Register("Root.NormalLayer.map_dialog_mainPage.localmap", class341_84);
		class341_86 = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer");
		class341_87 = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.instructions");
		class341_88 = Register("Root.NormalLayer.WaypointMap_main.LayoutRoot.OverlayContainer.WorldMap", class341_86);
		class341_75 = Register("Root.NormalLayer.BattleNetFriendsList_main.LayoutRoot.OverlayContainer.FriendsListContent");
		class341_76 = Register("Root.NormalLayer.GroupList_main.LayoutRoot.OverlayContainer.GroupsListContent");
		class341_77 = Register("Root.NormalLayer.GuildFinder_main.LayoutRoot.OverlayContainer");
		class341_78 = Register("Root.NormalLayer.BattleNetLeaderboard_main.LayoutRoot.OverlayContainer");
		class341_79 = Register("Root.NormalLayer.BattleNetSeasonJourney_main.LayoutRoot.OverlayContainer");
		class341_80 = Register("Root.NormalLayer.BattleNetStore_main.LayoutRoot.OverlayContainer");
		class341_81 = Register("Root.NormalLayer.GreaterRifts_VictoryScreen.LayoutRoot.frame_background", class341_64);
		class341_82 = Register("Root.NormalLayer.GreaterRifts_VictoryScreen.LayoutRoot.Primary_Frame.button_exit", class341_81);
		class341_83 = Register("Root.TopLayer.BattleNetSocialDialogs_main.LayoutRoot.DialogSendRealIdRequest");
		class341_127 = Register("Root.NormalLayer.buffs_backgroundScreen.buff_icon_wrapper", class341_64);
		class341_128 = Register("Root.NormalLayer.buffs_backgroundScreen.ExtendedBuffHolderTemplate.ExtendedBuff.FirstBuff", class341_64);
		class341_179 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_normal.progressbar", class341_64);
		class341_180 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_bounty.progressbar", class341_64);
		class341_181 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_minion.progressbar", class341_64);
		class341_182 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_player.progressbar", class341_64);
		class341_183 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.hp_bar_special.progressbar", class341_64);
		class341_143 = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_potion", class341_64);
		class341_144[0] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_activeSkillLeft", class341_64);
		class341_144[1] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_activeSkillRight", class341_64);
		class341_144[2] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_1", class341_64);
		class341_144[3] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_2", class341_64);
		class341_144[4] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_3", class341_64);
		class341_144[5] = Register("Root.NormalLayer.game_dialog_backgroundScreenPC.game_skill_hotbar_4", class341_64);
		class341_145[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.Frame", class341_64);
		class341_145[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.Frame", class341_64);
		class341_145[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.Frame", class341_64);
		class341_145[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.Frame", class341_64);
		class341_146[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.icon", class341_64);
		class341_146[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.icon", class341_64);
		class341_146[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.icon", class341_64);
		class341_146[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.icon", class341_64);
		class341_147[0] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_0.Background", class341_64);
		class341_147[1] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_1.Background", class341_64);
		class341_147[2] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_2.Background", class341_64);
		class341_147[3] = Register("Root.NormalLayer.portraits.stack.party_stack.portrait_3.Background", class341_64);
		class341_148 = Register("Root.NormalLayer.BattleNetProfile_main.LayoutRoot.OverlayContainer");
		class341_149 = Register("Root.TopLayer.ContextMenus.PlayerContextMenu", class341_64);
		class341_150 = Register("Root.TopLayer.in game portrait tooltip 2");
		class341_151 = Register("Root.NormalLayer.trade_dialog_mainPage", class341_64);
		class341_153 = Register("Root.NormalLayer.trade_dialog_mainPage.trade_gold_amount_other", class341_151);
		class341_152 = Register("Root.NormalLayer.trade_dialog_mainPage.trade_gold_amount_mine", class341_151);
		class341_158 = Register("Root.TopLayer.skill 2.stack");
		class341_159 = Register("Root.TopLayer.banner 2", class341_64);
		class341_160 = Register("Root.NormalLayer.BattleNetProfileBannerCustomization_main.LayoutRoot.OverlayContainer");
		class341_161 = Register("Root.TopLayer.ContextMenus.InGamePetContextMenu", class341_64);
		class341_162 = Register("Root.TopLayer.tooltip_dialog_background.tooltip_2");
		class341_166 = Register("Root.NormalLayer.game_dialog_main.RActorTag0", class341_64);
		class341_91 = Register("Root.NormalLayer.questreward_dialog", class341_64);
		class341_92 = Register("Root.NormalLayer.questreward_dialog.button_exit", class341_91);
		class341_93 = Register("Root.NormalLayer.BountyReward_main.LayoutRoot", class341_64);
		class341_94 = Register("Root.NormalLayer.TieredRiftReward_main.LayoutRoot", class341_64);
		class341_165 = Register("Root.NormalLayer.questlore_dialog.panel", class341_64);
		class341_178 = Register("Root.NormalLayer.Guild_main.LayoutRoot.OverlayContainer", class341_64);
		class341_98 = new UiElement("Root.NormalLayer.DurabilityIndicator", class341_64);
		class341_99 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_at_corpse", class341_64);
		class341_100 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_at_checkpoint", class341_64);
		class341_101 = new UiElement("Root.NormalLayer.deathmenu_dialog.dialog_main.button_revive_in_town", class341_64);
		class341_102 = Register("Root.NormalLayer.deathmenu_dialog.dialog_main.button_accept_resurrection", class341_64);
		class341_106 = Register("Root.NormalLayer.game_notify_dialog_backgroundScreen.dlg_new_paragon.button", class341_64);
		class341_107 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.tab_1", class341_55);
		class341_112 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Points_Available_1", class341_55);
		class341_108 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus0.PointsSpent", class341_55);
		class341_110 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus0.IncreaseStat", class341_55);
		class341_109 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus1.PointsSpent", class341_55);
		class341_111 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.Bonuses.bonus1.IncreaseStat", class341_55);
		class341_113 = Register("Root.NormalLayer.Paragon_main.LayoutRoot.ParagonPointSelect.AcceptParagonPointsButton", class341_55);
		class341_103 = Register("Root.NormalLayer.boss_enter_main.stack.wrapper.Accept", class341_64);
		class341_104 = Register("Root.NormalLayer.boss_join_party_main.stack.wrapper.Accept", class341_64);
		class341_114 = new UiElement("Root.NormalLayer.BattleNetWhatsNew_main.LayoutRoot.OverlayContainer.PageHeader.CloseButton");
		class341_115 = new UiElement("Root.TopLayer.ContextMenus.PlayerContextMenu.PlayerContextMenuContent.PlayerContextMenuList.InGameTeleportToPlayer", class341_64);
		class341_116 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.accept_Button", class341_64);
		confirmationMessage = Register("Root.TopLayer.confirmation.subdlg.stack.message", class341_64);
		confirmationCancel = Register("Root.TopLayer.confirmation.subdlg.stack.wrap.button_cancel", confirmationMessage);
		confirmationOk = Register("Root.TopLayer.confirmation.subdlg.stack.wrap.button_ok", confirmationMessage);
		class341_105 = Register("Root.NormalLayer.rift_join_party_main.stack.wrapper.Accept", class341_64);
		class341_120 = new UiElement("Root.NormalLayer.vendor_dialog_mainPage.riftReward_dialog.LayoutRoot.gemUpgradePane.upgrade_button", class341_64);
		class341_121 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftRadioButtons.NephalemRiftButton", class341_164);
		class341_122 = new UiElement("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftRadioButtons.GreaterRiftButton", class341_164);
		class341_123 = Register("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftTierLevelCombo", class341_164);
		class341_124 = Register("Root.NormalLayer.rift_dialog_mainPage.LayoutRoot.RiftTierLevelCombo.arrow", class341_164);
		class341_125 = Register("Root.TopLayer.BattleNetNotifications_main.Invite To Party Notification.PartyOkButton", class341_167);
	}
}
