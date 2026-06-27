using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using structs;
using Plugins;
using work;
using SNO;

public class Actor
{
	internal List<r_AttributeEntry> list_0 = new List<r_AttributeEntry>();

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private GizmoType gizmoType_0 = GizmoType.Invalid;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private uint uint_1;

	[CompilerGenerated]
	private SnoWorld isnoWorld_0;

	[CompilerGenerated]
	private Scene iscene_0;

	[CompilerGenerated]
	private uint uint_2;

	[CompilerGenerated]
	private uint uint_3;

	[CompilerGenerated]
	private SnoActor SnoActor_0;

	[CompilerGenerated]
	private readonly WorldCoordinate iworldCoordinate_0;

	[CompilerGenerated]
	private readonly WorldCoordinate iworldCoordinate_1;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private float float_1;

	private readonly ScreenCoordinate ScreenCoordinate_0;

	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private double double_0;

	[CompilerGenerated]
	private double double_1;

	[CompilerGenerated]
	private double double_2;

	[CompilerGenerated]
	private float float_2;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private uint uint_4;

	[CompilerGenerated]
	private uint uint_5;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private bool bool_7;

	[CompilerGenerated]
	private uint uint_6;

	public int CreatedAtInGameTick
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public GizmoType GizmoType
	{
		[CompilerGenerated]
		get
		{
			return gizmoType_0;
		}
		[CompilerGenerated]
		set
		{
			gizmoType_0 = value;
		}
	}

	public uint WorldId
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
		[CompilerGenerated]
		set
		{
			uint_0 = value;
		}
	}

	public uint WorldSno
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
		[CompilerGenerated]
		set
		{
			uint_1 = value;
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
			return uint_2;
		}
		[CompilerGenerated]
		private set
		{
			uint_2 = value;
		}
	}

	public uint AnnId
	{
		[CompilerGenerated]
		get
		{
			return uint_3;
		}
		[CompilerGenerated]
		set
		{
			uint_3 = value;
		}
	}

	public SnoActor SnoActor
	{
		[CompilerGenerated]
		get
		{
			return SnoActor_0;
		}
		[CompilerGenerated]
		set
		{
			SnoActor_0 = value;
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
			return float_0;
		}
		[CompilerGenerated]
		set
		{
			float_0 = value;
		}
	}

	public float RadiusBottom
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
		[CompilerGenerated]
		set
		{
			float_1 = value;
		}
	}

	public bool IsOnScreen
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		private set
		{
			bool_1 = value;
		}
	}

	public double CentralXyDistanceToMe
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
		[CompilerGenerated]
		private set
		{
			double_0 = value;
		}
	}

	public double NormalizedXyDistanceToMe
	{
		[CompilerGenerated]
		get
		{
			return double_1;
		}
		[CompilerGenerated]
		private set
		{
			double_1 = value;
		}
	}

	public double ZDistanceToMeAbsolute
	{
		[CompilerGenerated]
		get
		{
			return double_2;
		}
		[CompilerGenerated]
		private set
		{
			double_2 = value;
		}
	}

	public float Hitpoints
	{
		[CompilerGenerated]
		get
		{
			return float_2;
		}
		[CompilerGenerated]
		set
		{
			float_2 = value;
		}
	}

	public bool IsSelected
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public uint SummonerId
	{
		[CompilerGenerated]
		get
		{
			return uint_4;
		}
		[CompilerGenerated]
		set
		{
			uint_4 = value;
		}
	}

	public uint SummonerAcdDynamicId
	{
		[CompilerGenerated]
		get
		{
			return uint_5;
		}
		[CompilerGenerated]
		set
		{
			uint_5 = value;
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
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public bool IsClickable
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public bool IsDisabled
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public bool IsOperated
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
		[CompilerGenerated]
		set
		{
			bool_7 = value;
		}
	}

	public uint Amount
	{
		[CompilerGenerated]
		get
		{
			return uint_6;
		}
		[CompilerGenerated]
		set
		{
			uint_6 = value;
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

	public Actor(uint uint_7, uint uint_8, SnoActor SnoActor_1)
	{
		AcdId = uint_7;
		AnnId = uint_8;
		SnoActor = SnoActor_1;
		iworldCoordinate_0 = GameWindowManager.Window.CreateWorldCoordinate(0f, 0f, 0f);
		iworldCoordinate_1 = GameWindowManager.Window.CreateWorldCoordinate(0f, 0f, 0f);
		ScreenCoordinate_0 = GameWindowManager.Window.CreateScreenCoordinate(0f, 0f);
	}

	public void method_24(float float_3, float float_4, float float_5)
	{
		CollisionCoordinate.Set(float_3, float_4, float_5);
		FloorCoordinate.Set(float_3, float_4, float_5);
		if (float_3 == 0f && float_4 == 0f && float_5 == 0f)
		{
			IsOnScreen = false;
			CentralXyDistanceToMe = 0.0;
			NormalizedXyDistanceToMe = 0.0;
			ZDistanceToMeAbsolute = 0.0;
		}
		else
		{
			method_25();
		}
	}

	public void method_25()
	{
		bool_0 = false;
		CentralXyDistanceToMe = FloorCoordinate.XYDistanceTo(GameWindowManager.Window.Center);
		NormalizedXyDistanceToMe = CentralXyDistanceToMe - (double)RadiusBottom;
		ZDistanceToMeAbsolute = Math.Abs(GameWindowManager.Window.Center.Z - FloorCoordinate.Z);
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

	public void method_26(uint uint_7)
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
