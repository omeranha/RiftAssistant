using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using structs;
using work;

internal class Container
{
	private readonly r_Container[] buffer = new r_Container[1];

	[CompilerGenerated]
	private short short_0;

	public readonly short _maxAllowedIndex;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private long long_0;

	public short MaxIndex
	{
		[CompilerGenerated]
		get
		{
			return short_0;
		}
		[CompilerGenerated]
		private set
		{
			short_0 = value;
		}
	}

	public bool IsValid
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public long DataAddress
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		private set
		{
			long_0 = value;
		}
	}

	public Container(short short_2)
	{
		_maxAllowedIndex = short_2;
	}

	public void Snapshot(long long_1)
	{
		buffer[0] = GameWindowManager.Read<r_Container>(long_1);
		DataAddress = buffer[0].DataAddress;
		MaxIndex = (short)buffer[0].MaxIndex;
		if (MaxIndex == short.MaxValue)
		{
			MaxIndex = -1;
		}
		if (MaxIndex > _maxAllowedIndex)
		{
			MaxIndex = _maxAllowedIndex;
		}
		int capacity = buffer[0].Capacity;
		if (DataAddress > 0 && capacity > 0)
		{
			IsValid = true;
		}
		else
		{
			IsValid = false;
		}
	}
}
