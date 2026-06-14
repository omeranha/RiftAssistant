using System;

namespace SNO;

[Flags]
public enum NavCellFlags : ushort
{
	None = 0,
	AllowWalk = 1,
	AllowFlier = 2,
	AllowSpider = 4,
	LevelAreaBit0 = 8,
	LevelAreaBit1 = 0x10,
	NoNavMeshIntersected = 0x20,
	NoSpawn = 0x40,
	Special0 = 0x80,
	Special1 = 0x100,
	SymbolNotFound = 0x200,
	AllowProjectile = 0x400,
	AllowGhost = 0x800,
	RoundedCorner0 = 0x1000,
	RoundedCorner1 = 0x2000,
	RoundedCorner2 = 0x4000,
	RoundedCorner3 = 0x8000
}
