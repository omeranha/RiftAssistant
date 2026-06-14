using Plugins;

internal class Banner(uint id, uint worldId, IWorldCoordinate worldCoordinate) : IBanner
{
	private readonly uint id = id;
	private readonly uint worldId = worldId;
	private readonly IWorldCoordinate worldCoordinate = worldCoordinate;

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

	public IWorldCoordinate FloorCoordinate
	{
		get
		{
			return worldCoordinate;
		}
	}
}
