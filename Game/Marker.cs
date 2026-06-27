using Plugins;
using SNO;
using work;

public class Marker(string id, uint worldId, SnoQuest snoQuest, SnoActor snoActor, WorldCoordinate worldCoordinate, uint textureSno, int textureFrameIndex)
{
	private readonly string id = id;
	private SnoActor snoActor = snoActor;
	private readonly SnoQuest snoQuest = snoQuest;
	private readonly uint worldId = worldId;
	private readonly WorldCoordinate worldCoordinate = worldCoordinate;
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

	public SnoActor SnoActor
	{
		get {
			return snoActor;
		}
		set {
			snoActor = value;
		}
	}

	public SnoQuest SnoQuest
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

	public WorldCoordinate FloorCoordinate
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
