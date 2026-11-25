using System;
using System.Collections.Generic;

namespace RiftAssistant.Model;

public class Actor
{
	internal List<r_AttributeEntry> attributeEntries = new List<r_AttributeEntry>();

	private readonly ScreenCoordinate ScreenCoordinate0;

	private bool bool_0;

	public int CreatedAtInGameTick { get; set; }

	public GizmoType GizmoType { get; set; } = GizmoType.Invalid;

	public uint WorldId { get; set; }

	public uint WorldSno { get; set; }

	public SnoWorld SnoWorld { get; set; }

	public Scene Scene { get; set; }

	public uint AcdId { get; private set; }

	public uint AnnId { get; set; }

	public SnoActor SnoActor { get; set; }

	public WorldCoordinate CollisionCoordinate { get; }

	public WorldCoordinate FloorCoordinate { get; }

	public float RadiusScaled { get; set; }

	public float RadiusBottom { get; set; }

	public bool IsOnScreen { get; private set; }

	public double CentralXyDistanceToMe { get; private set; }

	public double NormalizedXyDistanceToMe { get; private set; }

	public double ZDistanceToMeAbsolute { get; private set; }

	public float Hitpoints { get; set; }

	public bool IsSelected { get; set; }

	public uint SummonerId { get; set; }

	public uint SummonerAcdDynamicId { get; set; }

	public bool Boolean_0 { get; set; }

	public bool Untargetable { get; set; }

	public bool IsClickable { get; set; }

	public bool IsDisabled { get; set; }

	public bool IsOperated { get; set; }

	public uint Amount { get; set; }

	public bool DisplayOnOverlay
	{
		get
		{
			if (!IsDisabled)
			{
				return !IsOperated;
			}
			return false;
		}
	}

	public ScreenCoordinate ScreenCoordinate
	{
		get
		{
			if (!bool_0)
			{
				CollisionCoordinate.SetScreenCoordinate(ScreenCoordinate0, raw: true);
			}
			return ScreenCoordinate0;
		}
	}

	public Actor(uint acdid, uint annId2, SnoActor snoActor2)
	{
		AcdId = acdid;
		AnnId = annId2;
		SnoActor = snoActor2;
		CollisionCoordinate = Window.CreateWorldCoordinate(0f, 0f, 0f);
		FloorCoordinate = Window.CreateWorldCoordinate(0f, 0f, 0f);
		ScreenCoordinate0 = Window.CreateScreenCoordinate(0f, 0f);
	}

	public void SetPosition(float positionX, float positionY, float positionZ)
	{
		CollisionCoordinate.Set(positionX, positionY, positionZ);
		FloorCoordinate.Set(positionX, positionY, positionZ);
		if (positionX == 0f && positionY == 0f && positionZ == 0f)
		{
			IsOnScreen = false;
			CentralXyDistanceToMe = 0.0;
			NormalizedXyDistanceToMe = 0.0;
			ZDistanceToMeAbsolute = 0.0;
		}
		else
		{
			UpdateDistances();
		}
	}

	public void UpdateDistances()
	{
		bool_0 = false;
		CentralXyDistanceToMe = FloorCoordinate.XYDistanceTo(Window.Center);
		NormalizedXyDistanceToMe = CentralXyDistanceToMe - (double)RadiusBottom;
		ZDistanceToMeAbsolute = Math.Abs(Window.Center.Z - FloorCoordinate.Z);
		IsOnScreen = CollisionCoordinate.IsOnScreen() || FloorCoordinate.IsOnScreen();
	}

	public override string ToString()
	{
		if (SnoActor == null)
		{
			return "<unknown>";
		}
		return SnoActor.Code;
	}

	public void SetAcdId(uint acdId)
	{
		AcdId = acdId;
	}

	public double GetAttributeValue(AcdAttribute attribute, uint modifier, double defaultValue = -1.0)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in attributeEntries)
		{
			if (item.uint_0 == id)
			{
				return (attribute.ValueType == AttributeValueType._int) ? ((float)item.quantity) : item.float_0;
			}
		}
		return defaultValue;
	}

	public int GetAttributeValueAsInt(AcdAttribute attribute, uint modifier, int defaultValue = int.MaxValue)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in attributeEntries)
		{
			if (item.uint_0 == id)
			{
				return item.quantity;
			}
		}
		return defaultValue;
	}

	public uint GetAttributeValueAsUInt(AcdAttribute attribute, uint modifier, uint defaultValue = uint.MaxValue)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in attributeEntries)
		{
			if (item.uint_0 == id)
			{
				return (uint)item.quantity;
			}
		}
		return defaultValue;
	}
}
