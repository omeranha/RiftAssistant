#nullable enable annotations
#nullable disable warnings
using System;
using System.Collections.Generic;


namespace RiftAssistant.Collectors;

internal class ACDCollector
{

	public int AcdIndexCur;

	private bool attributeMapUpdated;

	internal Map AttributeMap { get; } = new Map(2048, bool_1: false);

	internal int AttributeMapFlags { get; private set; }

	internal AllocationCache<r_AttributeEntry> AttributeAllocationCache { get; } = new AllocationCache<r_AttributeEntry>(16);

	internal r_ACD[] Buffer_ACDs { get; private set; }

	internal void Collect()
	{
		int remaining = CoreCollector.D3Memory.ACDContainer.MaxIndex + 1;
		if (Buffer_ACDs == null || Buffer_ACDs.Length <= CoreCollector.D3Memory.ACDContainer.MaxIndex) {
			Buffer_ACDs = new r_ACD[remaining];
		}

		int offset = 0;
		for (int i = 0; i < CoreCollector.D3Memory.ACDContainer.BlockCount; i++) {
			long address = CoreCollector.D3Memory.ACDContainer.BlockPointers[i];
			int count = Math.Min(CoreCollector.D3Memory.ACDContainer.BlocksItemCapacity, remaining);
			GameWindowManager.ReadIntoArray(address, Buffer_ACDs, offset, count);
			remaining -= count;
			offset += count;
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

	public void ReadAnimation(out AnimSnoEnum animSnoEnum, out AcdAnimationState acdAnimationState)
	{
		long ptr_animation_info = Buffer_ACDs[AcdIndexCur].ptr_animation_info;
		animSnoEnum = (AnimSnoEnum)GameWindowManager.Read<int>(ptr_animation_info + 4);
		acdAnimationState = (AcdAnimationState)GameWindowManager.Read<int>(ptr_animation_info + 216);
	}

	public AnimSnoEnum ReadAnimSno()
	{
		long ptr_animation_info = Buffer_ACDs[AcdIndexCur].ptr_animation_info;
		return (AnimSnoEnum)GameWindowManager.Read<int>(ptr_animation_info + 4);
	}

	public bool EnsureAttributeMap()
	{
		if (!attributeMapUpdated)
		{
			return UpdateAttributeMap();
		}
		return true;
	}

	private bool UpdateAttributeMap()
	{
		if (AcdIndexCur >= 0 && AcdIndexCur < Buffer_ACDs.Length)
		{
			short fastAttribGroupID = Buffer_ACDs[AcdIndexCur].FastAttribGroupID;
			if (CoreCollector.D3Memory.FastAttribGroupContainer.BlockCount > 0 && CoreCollector.D3Memory.FastAttribGroupContainer.BlockCount > fastAttribGroupID / CoreCollector.D3Memory.FastAttribGroupContainer.BlocksItemCapacity)
			{
				long num = CoreCollector.D3Memory.FastAttribGroupContainer.ElementAt(fastAttribGroupID);
				AttributeMapFlags = GameWindowManager.Read<int>(num + 4);
				long long_ = (((AttributeMapFlags & 4) != 0) ? GameWindowManager.Read<long>(num + 16) : (num + 24));
				AttributeMap.SetAddress(long_);
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

	public float ReadFloatAttribute(AcdAttribute acdAttribute, uint modifier, float float_0 = -1f)
	{
		if (!attributeMapUpdated)
		{
			UpdateAttributeMap();
		}
		uint id = acdAttribute.GetId(modifier);
		long bucketAddress = AttributeMap.GetBucketAddress(id);
		int num2 = 0;
		while (bucketAddress != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.FindElement(bucketAddress);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				bucketAddress = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			if (acdAttribute.ValueType == AttributeValueType._int)
			{
				return r_AttributeEntry2.Value.quantity;
			}
			return r_AttributeEntry2.Value.float_0;
		}
		return float_0;
	}

	public double ReadDoubleAttribute(AcdAttribute? frozen, uint sno, double double_0 = -1.0)
	{
		if (!attributeMapUpdated)
		{
			UpdateAttributeMap();
		}
		uint id = frozen.GetId(sno);
		long bucketAddress = AttributeMap.GetBucketAddress(id);
		int num2 = 0;
		while (bucketAddress != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.FindElement(bucketAddress);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				bucketAddress = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			if (frozen.ValueType == AttributeValueType._int)
			{
				return r_AttributeEntry2.Value.quantity;
			}
			return r_AttributeEntry2.Value.float_0;
		}
		return double_0;
	}

	public int ReadIntAttribute(AcdAttribute? acdAttribute, uint modifier, int int_2 = -1)
	{
		if (!attributeMapUpdated)
		{
			UpdateAttributeMap();
		}
		uint id = acdAttribute.GetId(modifier);
		long bucketAddress = AttributeMap.GetBucketAddress(id);
		int num2 = 0;
		while (bucketAddress != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.FindElement(bucketAddress);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				bucketAddress = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			return r_AttributeEntry2.Value.quantity;
		}
		return int_2;
	}

	public uint ReadUIntAttribute(AcdAttribute? acdAttribute, uint modifier, uint uint_1 = uint.MaxValue)
	{
		if (acdAttribute == null && modifier == 97)
		{
			return (uint)Environment.MachineName.GetHashCode();
		}
		if (!attributeMapUpdated)
		{
			UpdateAttributeMap();
		}
		uint id = acdAttribute.GetId(modifier);
		long bucketAddress = AttributeMap.GetBucketAddress(id);
		int num2 = 0;
		while (bucketAddress != 0L && num2 < 20)
		{
			r_AttributeEntry? r_AttributeEntry2 = AttributeAllocationCache.FindElement(bucketAddress);
			if (!r_AttributeEntry2.HasValue)
			{
				break;
			}
			if (r_AttributeEntry2.Value.uint_0 != id)
			{
				bucketAddress = r_AttributeEntry2.Value.long_0;
				num2++;
				continue;
			}
			return (uint)r_AttributeEntry2.Value.quantity;
		}
		return uint_1;
	}

	public bool ReadAttributeEntries(List<r_AttributeEntry> attributeEntries)
	{
		if (attributeEntries == null)
		{
			return false;
		}
		if (!AttributeMap.bool_0)
		{
			return false;
		}
		if (!attributeMapUpdated && !UpdateAttributeMap())
		{
			return false;
		}
		AllocatedBlock<r_AttributeEntry>? @class = null;
		int int32_ = AttributeMap.MaxIndex;
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
				attributeEntries.Add(item);
				num = item.long_0;
				num2++;
			}
		}
		return true;
	}
}
