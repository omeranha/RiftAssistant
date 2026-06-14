using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using structs;
using Plugins;
using SNO;
using work;

namespace collectors;

internal class ACDCollector
{
	[CompilerGenerated]
	private readonly Map class357_0 = new Map(2048, bool_1: false);

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private readonly AllocationCache<r_AttributeEntry> class352_0 = new AllocationCache<r_AttributeEntry>(ReadProcessMemory, 16);

	public int AcdIndexCur;

	[CompilerGenerated]
	private r_ACD[] struct7_0;

	private bool attributeMapUpdated;

	internal Map AttributeMap
	{
		[CompilerGenerated]
		get
		{
			return class357_0;
		}
	}

	internal int AttributeMapFlags
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	internal AllocationCache<r_AttributeEntry> AttributeAllocationCache
	{
		[CompilerGenerated]
		get
		{
			return class352_0;
		}
	}

	internal r_ACD[] Buffer_ACDs
	{
		[CompilerGenerated]
		get
		{
			return struct7_0;
		}
		[CompilerGenerated]
		private set
		{
			struct7_0 = value;
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref r_AttributeEntry struct8_0, int int_2, int int_3);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	internal static extern bool ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, ref r_ACD struct7_1, int int_2, int int_3);

	internal void Collect()
	{
		int num = CoreCollector.D3Memory.ACDContainer.MaxIndex + 1;
		if (Buffer_ACDs == null || Buffer_ACDs.Length <= CoreCollector.D3Memory.ACDContainer.MaxIndex)
		{
			Buffer_ACDs = new r_ACD[num];
		}
		int num2 = 0;
		for (int i = 0; i < CoreCollector.D3Memory.ACDContainer.BlockCount; i++)
		{
			long num3 = CoreCollector.D3Memory.ACDContainer.BlockPointers[i];
			int num4 = Math.Min(CoreCollector.D3Memory.ACDContainer.BlocksItemCapacity, num);
			ReadProcessMemory_1(MR.Instance.ProcessHandle, (IntPtr)num3, ref Buffer_ACDs[num2], Constants.ACD_SizeOf * num4, 0);
			num -= num4;
			num2 += num4;
		}
		AttributeAllocationCache.Snapshot(CoreCollector.D3Memory.AttribAllocator);
	}

	internal bool SetIndex(int index)
	{
		attributeMapUpdated = false;
		if (index > CoreCollector.D3Memory.ACDContainer.MaxIndex)
		{
			return false;
		}
		AcdIndexCur = index;
		return true;
	}

	public bool SetIndexFromAcdId(uint acdId)
	{
		attributeMapUpdated = false;
		AcdIndexCur = (int)(acdId & 0xFFFF);
		return AcdIndexCur <= CoreCollector.D3Memory.ACDContainer.MaxIndex;
	}

	public void method_3(out AnimSnoEnum animSnoEnum_0, out AcdAnimationState acdAnimationState_0)
	{
		long ptr_animation_info = Buffer_ACDs[AcdIndexCur].ptr_animation_info;
		animSnoEnum_0 = (AnimSnoEnum)MR.Instance.ReadInt32_x64(ptr_animation_info + 4);
		acdAnimationState_0 = (AcdAnimationState)MR.Instance.ReadInt32_x64(ptr_animation_info + 216);
	}

	public AnimSnoEnum method_4()
	{
		long ptr_animation_info = Buffer_ACDs[AcdIndexCur].ptr_animation_info;
		return (AnimSnoEnum)MR.Instance.ReadInt32_x64(ptr_animation_info + 4);
	}

	public bool method_5()
	{
		if (!attributeMapUpdated)
		{
			return method_6();
		}
		return true;
	}

	private bool method_6()
	{
		if (AcdIndexCur >= 0 && AcdIndexCur < Buffer_ACDs.Length)
		{
			short fastAttribGroupID = Buffer_ACDs[AcdIndexCur].FastAttribGroupID;
			if (CoreCollector.D3Memory.FastAttribGroupContainer.BlockCount > 0 && CoreCollector.D3Memory.FastAttribGroupContainer.BlockCount > fastAttribGroupID / CoreCollector.D3Memory.FastAttribGroupContainer.BlocksItemCapacity)
			{
				long num = CoreCollector.D3Memory.FastAttribGroupContainer.ElementAt(fastAttribGroupID);
				AttributeMapFlags = MR.Instance.ReadInt32_x64(num + 4);
				long long_ = (((AttributeMapFlags & 4) != 0) ? MR.Instance.ReadAddress(num + 16) : (num + 24));
				AttributeMap.method_0(long_);
				if (AttributeMap.bool_0)
				{
					attributeMapUpdated = true;
				}
				return AttributeMap.bool_0;
			}
			AttributeMap.bool_0 = false;
			return false;
		}
		return false;
	}

	public float method_7(IAttribute iattribute_0, uint uint_0, float float_0 = -1f)
	{
		if (!attributeMapUpdated)
		{
			method_6();
		}
		uint id = iattribute_0.GetId(uint_0);
		long num = AttributeMap.method_1(id);
		int num2 = 0;
		while (num != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.method_1(num);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				num = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			if (iattribute_0.ValueType == AttributeValueType._int)
			{
				return r_AttributeEntry2.Value.int_0;
			}
			return r_AttributeEntry2.Value.float_0;
		}
		return float_0;
	}

	public double method_8(IAttribute iattribute_0, uint uint_0, double double_0 = -1.0)
	{
		if (!attributeMapUpdated)
		{
			method_6();
		}
		uint id = iattribute_0.GetId(uint_0);
		long num = AttributeMap.method_1(id);
		int num2 = 0;
		while (num != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.method_1(num);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				num = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			if (iattribute_0.ValueType == AttributeValueType._int)
			{
				return r_AttributeEntry2.Value.int_0;
			}
			return r_AttributeEntry2.Value.float_0;
		}
		return double_0;
	}

	public int method_9(AcdAttribute acdAttribute_0, uint uint_0, int int_2 = -1)
	{
		if (!attributeMapUpdated)
		{
			method_6();
		}
		uint id = acdAttribute_0.GetId(uint_0);
		long num = AttributeMap.method_1(id);
		int num2 = 0;
		while (num != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.method_1(num);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				num = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			return r_AttributeEntry2.Value.int_0;
		}
		return int_2;
	}

	public uint method_10(AcdAttribute acdAttribute_0, uint uint_0, uint uint_1 = uint.MaxValue)
	{
		if (acdAttribute_0 == null && uint_0 == 97)
		{
			return (uint)Environment.MachineName.GetHashCode();
		}
		if (!attributeMapUpdated)
		{
			method_6();
		}
		uint id = acdAttribute_0.GetId(uint_0);
		long num = AttributeMap.method_1(id);
		int num2 = 0;
		while (num != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.method_1(num);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				num = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			return (uint)r_AttributeEntry2.Value.int_0;
		}
		return uint_1;
	}

	public bool method_12(List<r_AttributeEntry> list_0)
	{
		if (list_0 == null)
		{
			return false;
		}
		if (!AttributeMap.bool_0)
		{
			return false;
		}
		if (!attributeMapUpdated && !method_6())
		{
			return false;
		}
		AllocatedBlock<r_AttributeEntry> @class = null;
		int int32_ = AttributeMap.Int32_0;
		for (int i = 0; i <= int32_; i++)
		{
			long num = AttributeMap.long_2[i];
			int num2 = 0;
			while (num != 0L && num - 1 != uint.MaxValue && num2 < 20)
			{
				bool flag = true;
				if (@class == null || num < @class.StartAddress || num > @class.LastElementAddress)
				{
					flag = false;
					for (int j = 0; j < AttributeAllocationCache.int_1; j++)
					{
						@class = AttributeAllocationCache.class354_0[j];
						if (num >= @class.StartAddress && num <= @class.LastElementAddress)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					break;
				}
				long num3 = (num - @class.StartAddress) / 16;
				if (@class.IsAllocated((int)num3))
				{
					break;
				}
				r_AttributeEntry item = @class.Elements[num3];
				list_0.Add(item);
				num = item.long_0;
				num2++;
			}
		}
		return true;
	}
}
