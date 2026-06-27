using Plugins;
using work;

public class Banner(uint id, uint worldId, WorldCoordinate worldCoordinate)
{
	private readonly uint id = id;
	private readonly uint worldId = worldId;
	private readonly WorldCoordinate worldCoordinate = worldCoordinate;

	public uint Id
	{
		get
		{
			return id;
		}
	}

	public uint WorldId
	{
		get
		{
			return worldId;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		get
		{
			return worldCoordinate;
		}
	}
}
