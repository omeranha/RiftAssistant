using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace RiftAssistant.Memory;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct AreaContainer
{
	[FieldOffset(8)]
	public long PrimaryAreaPtr;

	[FieldOffset(16)]
	public long SecondaryAreaPtr;

	public const int Size = 2432;

	public const int HeaderSize = 24;
}

internal class ChatChanged : EventArgs
{
	public string Current;

	public string Previous;
}

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
internal struct SoundSettings
{
	[FieldOffset(0)]
	public float MasterVolume;

	[FieldOffset(4)]
	public float EffectsVolume;

	[FieldOffset(48)]
	public bool Muted;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct FrameRateSettings
{
	[FieldOffset(0)]
	public bool ForegroundLimitEnabled;

	[FieldOffset(4)]
	public bool BackgroundLimitEnabled;

	public static int Size = 8;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct HashNode
{
	[FieldOffset(0)]
	public long Next;

	[FieldOffset(8)]
	public ulong Key;

	[FieldOffset(8)]
	public int KeyLow;

	[FieldOffset(12)]
	public int KeyHigh;

	[FieldOffset(16)]
	public long Value;

	public const int Size = 24;
}

public readonly struct InputEvent
{
	public readonly Vk Key;
	public readonly bool Down;
	public readonly bool Shift;
	public readonly bool Ctrl;
	public readonly bool Alt;

	public InputEvent(Vk key, bool down)
	{
		Key = key;
		Down = down;
	}

	public InputEvent(Vk key, bool down, bool shift, bool ctrl, bool alt)
	{
		Key = key;
		Down = down;
		Shift = shift;
		Ctrl = ctrl;
		Alt = alt;
	}

	public bool Is(Vk key, bool down)
	{
		return Key == key && Down == down;
	}

	public bool Is(Vk key, bool down, bool shift, bool ctrl, bool alt)
	{
		return Key == key && Down == down && Shift == shift && Ctrl == ctrl && Alt == alt;
	}
}

internal class ItemLocationChanged : EventArgs
{
	public Item Item;

	public ItemLocation From;

	public ItemLocation To;
}

internal class LootGenerated : EventArgs
{
	public Item item;

	public bool gambled;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Allocator
{
	[FieldOffset(0)]
	public int ElementSize;

	[FieldOffset(4)]
	public int Limit;

	[FieldOffset(8)]
	public int LinkedListCount;

	[FieldOffset(16)]
	public long LinkedListFirstNodePtr;

	[FieldOffset(24)]
	public int Flags;

	public const int ofs_GoodFood = 40;

	[FieldOffset(40)]
	public uint GoodFood;

	public const int Size = 48;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_Block
{
	[FieldOffset(0)]
	public long NextNodePtr;

	[FieldOffset(8)]
	public long ArrayStart;

	[FieldOffset(24)]
	public int Limit;

	[FieldOffset(28)]
	public int ElementSize;

	[FieldOffset(32)]
	public int ElementCount;

	[FieldOffset(44)]
	public int FreeCount;

	[FieldOffset(56)]
	public long PtrFreeSpaceBitmap;

	[FieldOffset(68)]
	public int GoodFood;

	public const int Size = 72;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_LocalHeap
{
	[FieldOffset(8)]
	public long FirstNodeAddress;

	[FieldOffset(16)]
	public uint TotalSize;

	[FieldOffset(32)]
	public uint NodeCount;

	[FieldOffset(104)]
	public long LastNodeAddress;

	public const int Size = 112;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct r_MemoryManager
{
	[FieldOffset(80)]
	public int IsInitialized;
	
	[FieldOffset(88)]
	public long PtrLocalHeap;
	
	[FieldOffset(100)]
	public int Unknown1;

	public const int Size = 104;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct RECT
{
	public int Left;
	public int Top;
	public int Right;
	public int Bottom;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct UiElementData
{
	[FieldOffset(24)]
	public ulong Flags;

	[FieldOffset(48)]
	public ulong Id;

	[FieldOffset(1136)]
	public long ChildEntries;

	[FieldOffset(1144)]
	public int ChildCount;

	[FieldOffset(1176)]
	public float Left;

	[FieldOffset(1180)]
	public float Top;

	[FieldOffset(1184)]
	public float Right;

	[FieldOffset(1188)]
	public float Bottom;

	[FieldOffset(1220)]
	public uint State;

	[FieldOffset(1224)]
	public int Index;

	[FieldOffset(2656)]
	public long UnknownPtr1;

	[FieldOffset(2688)]
	public long UnknownPtr2;
}

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct VideoSettings
{
	[FieldOffset(0)]
	public bool bool_0;

	[FieldOffset(4)]
	public int int_0;

	[FieldOffset(8)]
	public int int_1;

	[FieldOffset(12)]
	public int int_2;

	[FieldOffset(16)]
	public WindowMode windowMode_0;

	[FieldOffset(20)]
	public int int_3;

	[FieldOffset(24)]
	public int int_4;

	[FieldOffset(28)]
	public int int_5;

	[FieldOffset(32)]
	public int int_6;

	[FieldOffset(36)]
	public int int_7;

	[FieldOffset(40)]
	public int int_8;

	[FieldOffset(44)]
	public int int_9;

	[FieldOffset(48)]
	public int int_10;

	[FieldOffset(52)]
	public int int_11;

	[FieldOffset(56)]
	public int int_12;

	[FieldOffset(60)]
	public int int_13;

	[FieldOffset(64)]
	public float float_0;

	[FieldOffset(68)]
	public int int_14;

	[FieldOffset(72)]
	public int int_15;

	[FieldOffset(76)]
	public int int_16;

	[FieldOffset(80)]
	public bool bool_1;

	[FieldOffset(84)]
	public bool bool_2;

	[FieldOffset(88)]
	public bool bool_3;

	[FieldOffset(92)]
	public bool bool_4;

	[FieldOffset(96)]
	public bool bool_5;

	[FieldOffset(100)]
	public bool bool_6;

	[FieldOffset(104)]
	public int int_17;

	[FieldOffset(108)]
	public int int_18;

	[FieldOffset(112)]
	public bool bool_7;

	[FieldOffset(116)]
	public int MaxForegroundFps;

	[FieldOffset(120)]
	public bool bool_8;

	[FieldOffset(124)]
	public int MaxBackgroundFps;

	[FieldOffset(128)]
	public int int_21;

	[FieldOffset(132)]
	public bool bool_9;

	[FieldOffset(136)]
	public bool bool_10;

	[FieldOffset(140)]
	public float float_1;

	[FieldOffset(144)]
	public int int_22;

	[FieldOffset(148)]
	public int int_23;

	[FieldOffset(152)]
	public int int_24;

	[FieldOffset(156)]
	public float float_2;

	public const int Size = 160;
}

public struct WINDOWPLACEMENT
{
	public int length;
	public int flags;
	public int showCmd;
	public Point minPosition;
	public Point maxPosition;
	public Rectangle normalPosition;
}
