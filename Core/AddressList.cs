internal static class AddressList
{
	public const long SelectedActOnMap = 23539052L;
	public const long HotkeysAddress = 21435760L;
	public const long PtrMemoryManager = 21421320L;
	public const long UiIsHiddenFlagAddress = 24072844L;

	// The settings blocks around the hotkeys block have fixed sizes: 80 before it, 104 and 48 after the 1152 byte hotkeys block.
	public const long VideoSettingsAddress = HotkeysAddress - 80 - VideoSettings.Size;
	public const long ScreenSettingsAddress = HotkeysAddress + 1152 + 104 + 48;

	public const long Offset_Trickle_Block0 = 0L;
	public const long Offset_Trickle_Ptr8 = 8L;
	public const long Offset_Trickle_Ptr24 = 24L;
}
