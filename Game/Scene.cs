using System.Globalization;
using Plugins;
using SNO;

public class Scene
{
	public SnoScene SnoScene { get; set; }

	public SnoArea SnoArea { get; set; }

	public uint WorldSno { get; set; }

	public uint NavMeshId { get; set; }

	public uint SceneId { get; set; }

	public float PosX { get; set; }

	public float PosY { get; set; }

	public float MaxX { get; set; }

	public float MaxY { get; set; }

	public float W { get; set; }

	public float H { get; set; }

	public float Z { get; set; }

	public string CalculatedPosId { get; set; }

	public uint UInt32_0 { get; set; }

	public Scene(SnoScene isnoScene_1, SnoArea isnoArea_1, uint uint_4, uint uint_5, uint uint_6, float float_7, float float_8, float float_9, float float_10, float float_11)
	{
		SnoScene = isnoScene_1;
		SnoArea = isnoArea_1;
		WorldSno = uint_4;
		NavMeshId = uint_5;
		SceneId = uint_6;
		PosX = float_7;
		PosY = float_8;
		MaxX = float_9;
		MaxY = float_10;
		Z = float_11;
		W = MaxX - PosX;
		H = MaxY - PosY;
		CalculatedPosId = PosX.ToString(CultureInfo.InvariantCulture) + PosY.ToString(CultureInfo.InvariantCulture);
	}
}
