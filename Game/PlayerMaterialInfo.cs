using structs;
using Plugins;

namespace work;

public class PlayerMaterialInfo
{
	public Player Class310_0 { get; }

	public long Gold => Class310_0.RawPlayerData.Gold;

	public long BloodShard => Class310_0.RawPlayerData.Bloodshards;

	public long BNetStore => Class310_0.RawPlayerData.BNetStoreCurrency;

	public long ReusableParts => Class310_0.RawPlayerData.ReusableParts;

	public long ArcaneDust => Class310_0.RawPlayerData.ArcaneDust;

	public long VeiledCrystal => Class310_0.RawPlayerData.VeiledCrystal;

	public long DeathsBreath => Class310_0.RawPlayerData.DeathBreaths;

	public long ForgottenSoul => Class310_0.RawPlayerData.ForgottenSoul;

	public long KhanduranRune => Class310_0.RawPlayerData.KhanduranRune;

	public long CaldeumNightShade => Class310_0.RawPlayerData.CaldeumNightShade;

	public long ArreatWarTapestry => Class310_0.RawPlayerData.ArreatWarTapestry;

	public long CorruptedAngelFlesh => Class310_0.RawPlayerData.CorruptedAngelFlesh;

	public long WestmarchHolyWater => Class310_0.RawPlayerData.WestmarchHolyWater;

	public long HeartOfFright => Class310_0.RawPlayerData.HeartOfFright;

	public long VialOfPutridness => Class310_0.RawPlayerData.VialOfPutridness;

	public long IdolOfTerror => Class310_0.RawPlayerData.IdolOfTerror;

	public long LeoricsRegret => Class310_0.RawPlayerData.LeoricsSignet;

	public long GreaterRiftKeystone => Class310_0.RawPlayerData.GreaterRiftKeystones;

	public unsafe long PrimordialAshes
	{
		get
		{
			fixed (r_PlayerData* rawPlayerData = &Class310_0.RawPlayerData)
			{
				byte* ptr = (byte*)rawPlayerData;
				ptr += Constants.PlayerData_PrimordialAshes_Offset;
				return *(long*)ptr;
			}
		}
	}

	public PlayerMaterialInfo(Player class310_1)
	{
		Class310_0 = class310_1;
	}
}
