namespace work;

internal static class AddressList
{
	public static readonly long SelectedActOnMap;

	public static readonly long HotkeysAddress;

	public static readonly long PtrMemoryManager;

	public static readonly long PowerTagMapListAddress;

	public static readonly long AttributeListAddress;

	public static readonly long AttributeOrdersPri;

	public static readonly long AttributeOrdersSec;

	public static readonly long UiIsHiddenFlagAddress;

	public static readonly long long_8;

	public static readonly long long_9;

	public static readonly long long_10;

	public static readonly long long_11;

	public static readonly long ScreenSettingsAddress;

	public static readonly long long_13;

	public static readonly long long_14;

	public static readonly long long_15;

	static AddressList()
	{
		SelectedActOnMap = 23539052L;
		HotkeysAddress = 21435760L;
		PtrMemoryManager = 21421320L;
		PowerTagMapListAddress = 0L;
		AttributeListAddress = 0L;
		AttributeOrdersPri = 0L;
		AttributeOrdersSec = 0L;
		UiIsHiddenFlagAddress = 24072844L;
		long_8 = HotkeysAddress - Class73.Size - VideoSettings.Size;
		long_9 = HotkeysAddress - Class73.Size;
		long_10 = HotkeysAddress + 1152;
		long_11 = HotkeysAddress + 1152 + Class71.Size;
		ScreenSettingsAddress = HotkeysAddress + 1152 + Class71.Size + Class72.Size;
		long_13 = 0L;
		long_14 = 8L;
		long_15 = 24L;
	}
}
