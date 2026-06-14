using structs;
using Plugins;
using SNO;

namespace work;

public static class Custom
{
	internal sealed class UnknownSnoArea : ISnoArea
	{
		private readonly uint _id;

		public uint Sno => uint.MaxValue;

		public string Code => string.Empty;

		public string NameLocalized => "!! Missing area name !!";

		public string NameEnglish => NameLocalized;

		public AreaType Type => AreaType.Normal;

		public bool IsRandom => false;

		public bool IsTown => false;

		public int Act => 0;

		public string AreaGroupInWorld => string.Empty;

		public ISnoWorld SnoWorld => null;

		public uint HostAreaSno => 0u;

		public ISnoArea HostSnoArea => null;

		internal UnknownSnoArea(uint id = uint.MaxValue)
		{
			_id = id;
		}

		public override bool Equals(object obj)
		{
			if (obj is UnknownSnoArea unknownSnoArea)
			{
				return _id == unknownSnoArea._id;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

	internal static readonly ISnoArea dummy_snoarea_unknown;

	internal static uint GetAreaSno(Player player)
	{
		uint num = player.RawPlayerData.AreaSnoEncrypted;
		if (num == uint.MaxValue && player.IsMe)
		{
			long int64_ = CoreCollector.DAF.LevelAreaAddress;
			if (int64_ != 0L)
			{
				num = MR.Instance.ReadUInt(int64_ + Constants.LevelArea_AreaSno_Offset);
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
				num = MR.Instance.ReadUInt(int64_ + Constants.LevelArea_AreaSno_Offset);
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
