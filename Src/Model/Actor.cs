using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RiftAssistant.Model;

public class Actor
{
	internal List<r_AttributeEntry> list_0 = new List<r_AttributeEntry>();

	[CompilerGenerated]
	private int createdAtInGameTick;

	[CompilerGenerated]
	private GizmoType gizmoType = GizmoType.Invalid;

	[CompilerGenerated]
	private uint worldId;

	[CompilerGenerated]
	private uint worldSno;

	[CompilerGenerated]
	private SnoWorld isnoWorld_0;

	[CompilerGenerated]
	private Scene iscene_0;

	[CompilerGenerated]
	private uint acdId;

	[CompilerGenerated]
	private uint annId;

	[CompilerGenerated]
	private SnoActor snoActor;

	[CompilerGenerated]
	private readonly WorldCoordinate iworldCoordinate_0;

	[CompilerGenerated]
	private readonly WorldCoordinate iworldCoordinate_1;

	[CompilerGenerated]
	private float radiusScaled;

	[CompilerGenerated]
	private float radiusBottom;

	private readonly ScreenCoordinate ScreenCoordinate_0;

	private bool bool_0;

	[CompilerGenerated]
	private bool isOnScreen;

	[CompilerGenerated]
	private double centralXyDistanceToMe;

	[CompilerGenerated]
	private double normalizedXyDistanceToMe;

	[CompilerGenerated]
	private double zDistanceToMeAbsolute;

	[CompilerGenerated]
	private float hitpoints;

	[CompilerGenerated]
	private bool isSelected;

	[CompilerGenerated]
	private uint summonerId;

	[CompilerGenerated]
	private uint summonerAcdDynamicId;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool untargetable;

	[CompilerGenerated]
	private bool isClickable;

	[CompilerGenerated]
	private bool isDisabled;

	[CompilerGenerated]
	private bool isOperated;

	[CompilerGenerated]
	private uint amount;

	public int CreatedAtInGameTick
	{
		[CompilerGenerated]
		get
		{
			return createdAtInGameTick;
		}
		[CompilerGenerated]
		set
		{
			createdAtInGameTick = value;
		}
	}

	public GizmoType GizmoType
	{
		[CompilerGenerated]
		get
		{
			return gizmoType;
		}
		[CompilerGenerated]
		set
		{
			gizmoType = value;
		}
	}

	public uint WorldId
	{
		[CompilerGenerated]
		get
		{
			return worldId;
		}
		[CompilerGenerated]
		set
		{
			worldId = value;
		}
	}

	public uint WorldSno
	{
		[CompilerGenerated]
		get
		{
			return worldSno;
		}
		[CompilerGenerated]
		set
		{
			worldSno = value;
		}
	}

	public SnoWorld SnoWorld
	{
		[CompilerGenerated]
		get
		{
			return isnoWorld_0;
		}
		[CompilerGenerated]
		set
		{
			isnoWorld_0 = value;
		}
	}

	public Scene Scene
	{
		[CompilerGenerated]
		get
		{
			return iscene_0;
		}
		[CompilerGenerated]
		set
		{
			iscene_0 = value;
		}
	}

	public uint AcdId
	{
		[CompilerGenerated]
		get
		{
			return acdId;
		}
		[CompilerGenerated]
		private set
		{
			acdId = value;
		}
	}

	public uint AnnId
	{
		[CompilerGenerated]
		get
		{
			return annId;
		}
		[CompilerGenerated]
		set
		{
			annId = value;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return snoActor;
		}
		[CompilerGenerated]
		set
		{
			snoActor = value;
		}
	}

	public WorldCoordinate CollisionCoordinate
	{
		[CompilerGenerated]
		get
		{
			return iworldCoordinate_0;
		}
	}

	public WorldCoordinate FloorCoordinate
	{
		[CompilerGenerated]
		get
		{
			return iworldCoordinate_1;
		}
	}

	public float RadiusScaled
	{
		[CompilerGenerated]
		get
		{
			return radiusScaled;
		}
		[CompilerGenerated]
		set
		{
			radiusScaled = value;
		}
	}

	public float RadiusBottom
	{
		[CompilerGenerated]
		get
		{
			return radiusBottom;
		}
		[CompilerGenerated]
		set
		{
			radiusBottom = value;
		}
	}

	public bool IsOnScreen
	{
		[CompilerGenerated]
		get
		{
			return isOnScreen;
		}
		[CompilerGenerated]
		private set
		{
			isOnScreen = value;
		}
	}

	public double CentralXyDistanceToMe
	{
		[CompilerGenerated]
		get
		{
			return centralXyDistanceToMe;
		}
		[CompilerGenerated]
		private set
		{
			centralXyDistanceToMe = value;
		}
	}

	public double NormalizedXyDistanceToMe
	{
		[CompilerGenerated]
		get
		{
			return normalizedXyDistanceToMe;
		}
		[CompilerGenerated]
		private set
		{
			normalizedXyDistanceToMe = value;
		}
	}

	public double ZDistanceToMeAbsolute
	{
		[CompilerGenerated]
		get
		{
			return zDistanceToMeAbsolute;
		}
		[CompilerGenerated]
		private set
		{
			zDistanceToMeAbsolute = value;
		}
	}

	public float Hitpoints
	{
		[CompilerGenerated]
		get
		{
			return hitpoints;
		}
		[CompilerGenerated]
		set
		{
			hitpoints = value;
		}
	}

	public bool IsSelected
	{
		[CompilerGenerated]
		get
		{
			return isSelected;
		}
		[CompilerGenerated]
		set
		{
			isSelected = value;
		}
	}

	public uint SummonerId
	{
		[CompilerGenerated]
		get
		{
			return summonerId;
		}
		[CompilerGenerated]
		set
		{
			summonerId = value;
		}
	}

	public uint SummonerAcdDynamicId
	{
		[CompilerGenerated]
		get
		{
			return summonerAcdDynamicId;
		}
		[CompilerGenerated]
		set
		{
			summonerAcdDynamicId = value;
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool Untargetable
	{
		[CompilerGenerated]
		get
		{
			return untargetable;
		}
		[CompilerGenerated]
		set
		{
			untargetable = value;
		}
	}

	public bool IsClickable
	{
		[CompilerGenerated]
		get
		{
			return isClickable;
		}
		[CompilerGenerated]
		set
		{
			isClickable = value;
		}
	}

	public bool IsDisabled
	{
		[CompilerGenerated]
		get
		{
			return isDisabled;
		}
		[CompilerGenerated]
		set
		{
			isDisabled = value;
		}
	}

	public bool IsOperated
	{
		[CompilerGenerated]
		get
		{
			return isOperated;
		}
		[CompilerGenerated]
		set
		{
			isOperated = value;
		}
	}

	public uint Amount
	{
		[CompilerGenerated]
		get
		{
			return amount;
		}
		[CompilerGenerated]
		set
		{
			amount = value;
		}
	}

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
				CollisionCoordinate.SetScreenCoordinate(ScreenCoordinate_0, raw: true);
			}
			return ScreenCoordinate_0;
		}
	}

	public Actor(uint acdid, uint annId2, SnoActor snoActor2)
	{
		AcdId = acdid;
		AnnId = annId2;
		SnoActor = snoActor2;
		iworldCoordinate_0 = Window.CreateWorldCoordinate(0f, 0f, 0f);
		iworldCoordinate_1 = Window.CreateWorldCoordinate(0f, 0f, 0f);
		ScreenCoordinate_0 = Window.CreateScreenCoordinate(0f, 0f);
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

	public void SetAcdId(uint uint_7)
	{
		AcdId = uint_7;
	}

	public double GetAttributeValue(AcdAttribute attribute, uint modifier, double defaultValue = -1.0)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in list_0)
		{
			if (item.uint_0 == id)
			{
				return (attribute.ValueType == AttributeValueType._int) ? ((float)item.int_0) : item.float_0;
			}
		}
		return defaultValue;
	}

	public int GetAttributeValueAsInt(AcdAttribute attribute, uint modifier, int defaultValue = int.MaxValue)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in list_0)
		{
			if (item.uint_0 == id)
			{
				return item.int_0;
			}
		}
		return defaultValue;
	}

	public uint GetAttributeValueAsUInt(AcdAttribute attribute, uint modifier, uint defaultValue = uint.MaxValue)
	{
		uint id = attribute.GetId(modifier);
		foreach (r_AttributeEntry item in list_0)
		{
			if (item.uint_0 == id)
			{
				return (uint)item.int_0;
			}
		}
		return defaultValue;
	}
}
