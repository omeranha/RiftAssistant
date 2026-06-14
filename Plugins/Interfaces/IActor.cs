namespace Plugins;

public interface IActor
{
	ISnoActor SnoActor { get; }

	GizmoType GizmoType { get; }

	uint AcdId { get; }

	uint AnnId { get; }

	IWorldCoordinate FloorCoordinate { get; }

	IWorldCoordinate CollisionCoordinate { get; }

	float RadiusScaled { get; }

	float RadiusBottom { get; }

	uint WorldId { get; }

	uint WorldSno { get; }

	ISnoWorld SnoWorld { get; }

	IScene Scene { get; }

	IScreenCoordinate ScreenCoordinate { get; }

	bool IsOnScreen { get; }

	double CentralXyDistanceToMe { get; }

	double NormalizedXyDistanceToMe { get; }

	double ZDistanceToMeAbsolute { get; }

	bool IsSelected { get; }

	float Hitpoints { get; }

	uint SummonerId { get; }

	uint SummonerAcdDynamicId { get; }

	bool Untargetable { get; }

	bool IsClickable { get; }

	bool IsDisabled { get; }

	bool IsOperated { get; }

	bool DisplayOnOverlay { get; }

	uint Amount { get; }

	int CreatedAtInGameTick { get; }

	double GetAttributeValue(IAttribute attribute, uint modifier, double defaultValue = -1.0);

	int GetAttributeValueAsInt(IAttribute attribute, uint modifier, int defaultValue = int.MaxValue);

	uint GetAttributeValueAsUInt(IAttribute attribute, uint modifier, uint defaultValue = uint.MaxValue);
}
