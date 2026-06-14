using Plugins;
using SNO;

internal class Marker(string id, uint worldId, ISnoQuest snoQuest, ISnoActor snoActor, IWorldCoordinate worldCoordinate, uint textureSno, int textureFrameIndex) : IMarker
{
	private readonly string id = id;
	private ISnoActor snoActor = snoActor;
	private readonly ISnoQuest snoQuest = snoQuest;
	private readonly uint worldId = worldId;
	private readonly IWorldCoordinate worldCoordinate = worldCoordinate;
	private uint textureSno = textureSno;
	private int textureFrameIndex = textureFrameIndex;
	private bool isPylon;
	private bool isShrine;
	private bool isPoolOfReflection;
	private bool isHealingWell;
	private bool isUsed;

	public string Id {
		get {
			return id;
		}
	}

	public ISnoActor SnoActor
	{
		get {
			return snoActor;
		}
		set {
			snoActor = value;
		}
	}

	public ISnoQuest SnoQuest
	{
		get {
			return snoQuest;
		}
	}

	public uint WorldId
	{
		get {
			return worldId;
		}
	}

	public IWorldCoordinate FloorCoordinate
	{
		get {
			return worldCoordinate;
		}
	}

	public uint TextureSno
	{
		get {
			return textureSno;
		}
		set {
			textureSno = value;
		}
	}

	public int TextureFrameIndex
	{
		get {
			return textureFrameIndex;
		}
		set {
			textureFrameIndex = value;
		}
	}

	public bool IsPylon
	{
		get {
			return isPylon;
		}
		set {
			isPylon = value;
		}
	}

	public bool IsShrine
	{
		get {
			return isShrine;
		}
		set {
			isShrine = value;
		}
	}

	public bool IsPoolOfReflection
	{
		get {
			return isPoolOfReflection;
		}
		set {
			isPoolOfReflection = value;
		}
	}

	public bool IsHealingWell
	{
		get {
			return isHealingWell;
		}
		set {
			isHealingWell = value;
		}
	}

	public bool IsUsed
	{
		get {
			return isUsed;
		}
		set {
			isUsed = value;
		}
	}

	public string Name =>
	SnoActor?.NameLocalized
	?? SnoData.Monsters.GetMonster(SnoActor?.Sno ?? 0)?.NameLocalized
	?? SnoQuest?.NameLocalized;
}
