using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace RiftAssistant.Model;

internal partial class UiElements
{
	private const int MaxChatLength = 8192;

	private const int MaxChatScanEntries = 32;

	private const int ChatPollIntervalMs = 100;

	private const int ChatLineBufferSize = 1024;

	private string? lastChat;

	private readonly Stopwatch chatPollTimer = Stopwatch.StartNew();

	private byte[] chatLineBuffer = new byte[ChatLineBufferSize];

	private byte[] lastChatLineBuffer = new byte[ChatLineBufferSize];

	private bool hasLastChatLine;

	private static readonly long ChatTextPointerOffset = (long)Marshal.OffsetOf<UiElementData>(nameof(UiElementData.UnknownPtr1));

	public EventHandler<ChatChanged> ChatChanged = null!;

	private void ProcessChat(bool force)
	{
		if (ChatChanged == null) return;
		if (!force && chatPollTimer.ElapsedMilliseconds < ChatPollIntervalMs) return;

		chatPollTimer.Restart();

		string? current = ReadChat(true);
		if (current == lastChat) return;

		ChatChanged?.Invoke(this, new ChatChanged {
			Current = current,
			Previous = lastChat
		});
		lastChat = current;
	}

	public string? ReadChat(bool stripFormatting)
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

	private static string? SanitizeChat(string text, bool stripFormatting)
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
}
