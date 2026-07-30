using structs;
using SNO;

public static class Custom
{
	internal sealed class UnknownSnoArea : SnoArea
	{
		private readonly uint _id;

		internal UnknownSnoArea(uint id = uint.MaxValue) : base(id, string.Empty, 0, "!! Missing area name !!", "!! Missing area name !!", AreaType.Normal, false, string.Empty, false, 0)
		{
			_id = id;
		}

		public override bool Equals(object obj) => obj is UnknownSnoArea other && _id == other._id;

		public override int GetHashCode() => _id.GetHashCode();
	}

	internal static readonly SnoArea dummy_snoarea_unknown;

	internal static uint GetAreaSno(Player player)
	{
		uint num = player.RawPlayerData.AreaSnoEncrypted;
		if (num == uint.MaxValue && player.IsMe)
		{
			long int64_ = CoreCollector.DAF.LevelAreaAddress;
			if (int64_ != 0L)
			{
				num = GameWindowManager.Read<uint>(int64_ + Constants.LevelArea_AreaSno_Offset);
			}
		}
		return num;
	}

	internal unsafe static void SetSnoAreaForPlayer(Player player)
	{
		uint num = player.RawPlayerData.AreaSnoEncrypted;
		if (num != uint.MaxValue)
		{
			player.SnoArea = SnoData.Areas.GetSnoArea(num);
			return;
		}
		if (player.IsMe)
		{
			long int64_ = CoreCollector.DAF.LevelAreaAddress;
			if (int64_ != 0L)
			{
				num = GameWindowManager.Read<uint>(int64_ + Constants.LevelArea_AreaSno_Offset);
			}
			player.SnoArea = SnoData.Areas.GetSnoArea(num);
			return;
		}
		fixed (r_PlayerData* rawPlayerData = &player.RawPlayerData)
		{
			byte* ptr = (byte*)rawPlayerData;
			ptr += Constants.PlayerData_HostAreaSno_Offset;
			num = *(uint*)ptr;
		}
		if (SnoData.Areas.GetSnoArea(num) != null)
		{
			player.SnoArea = dummy_snoarea_unknown;
		}
		else
		{
			player.SnoArea = null;
		}
	}

	static Custom()
	{
		dummy_snoarea_unknown = new UnknownSnoArea();
	}
}
