namespace work;

public static class Constants
{
	public static readonly int PlayerData_SizeOf;

	public static readonly int ACD_SizeOf;

	public static readonly int Actor_SizeOf;

	public static readonly int PlayerData_AreaSno_Offset;

	public static readonly int PlayerData_ACDID_Offset;

	public static readonly int PlayerData_HeroId_Offset;

	public static readonly int PlayerData_ActorId_Offset;

	public static readonly int FastAttribGroup_SizeOf;

	public static readonly int CurrentSeasonNumber;

	public static readonly int Trickle_SizeOf;

	public static readonly int MarkerEntry_SizeOf;

	public static readonly int Hero_SizeOf;

	public static readonly int PlayerData_PrimordialAshes_Offset;

	public static readonly int LevelArea_AreaSno_Offset;

	public static readonly int PlayerData_HostAreaSno_Offset;

	static Constants()
	{
		CurrentSeasonNumber = 34;
		LevelArea_AreaSno_Offset = 124;
		FastAttribGroup_SizeOf = 4840;
		PlayerData_AreaSno_Offset = 54912;
		PlayerData_HostAreaSno_Offset = 54916;
		PlayerData_ACDID_Offset = 4;
		PlayerData_ActorId_Offset = 8;
		PlayerData_HeroId_Offset = 45576;
		PlayerData_SizeOf = 59376;
		ACD_SizeOf = 960;
		Actor_SizeOf = 1272;
		Trickle_SizeOf = 128;
		MarkerEntry_SizeOf = 88;
		Hero_SizeOf = 392;
		PlayerData_PrimordialAshes_Offset = 40744;
	}
}
