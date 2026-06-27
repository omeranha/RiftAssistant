using System.Collections;
using System.Collections.Generic;

public class Class112<T, U> : IEnumerable<KeyValuePair<T, U>>, IEnumerable
{
	private readonly Dictionary<T, U> dictionary_0;

	public int Int32_0 => dictionary_0.Count;

	public IEnumerable<U> IEnumerable_0 => dictionary_0.Values;

	public U this[T gparam_0]
	{
		get
		{
			dictionary_0.TryGetValue(gparam_0, out var value);
			return value;
		}
		set
		{
			dictionary_0[gparam_0] = value;
		}
	}

	public Class112()
	{
		dictionary_0 = new Dictionary<T, U>();
	}

	public Class112(int int_0)
	{
		dictionary_0 = new Dictionary<T, U>(int_0);
	}

	public void Set(T gparam_0, U gparam_1)
	{
		dictionary_0[gparam_0] = gparam_1;
	}

	public void Clear()
	{
		dictionary_0.Clear();
	}

	public bool Contains(T gparam_0)
	{
		return dictionary_0.ContainsKey(gparam_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return dictionary_0.GetEnumerator();
	}

	IEnumerator<KeyValuePair<T, U>> IEnumerable<KeyValuePair<T, U>>.GetEnumerator()
	{
		return dictionary_0.GetEnumerator();
	}

	public bool Remove(T gparam_0)
	{
		return dictionary_0.Remove(gparam_0);
	}

	public bool TryGetValue(T gparam_0, out U gparam_1)
	{
		return dictionary_0.TryGetValue(gparam_0, out gparam_1);
	}
}
