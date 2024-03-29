namespace ImanN.DynamicFields;

public class ArrayFieldValue<TValue>
{
    private Dictionary<int, TValue> _values = new();
    private int _lastIndex = 0;

    public ArrayFieldValue()
    {
    }

    public ArrayFieldValue(IReadOnlyCollection<TValue> values)
    {
        if (values is null) throw new ArgumentNullException(nameof(values));
        Add(values);
    }
    
    
    public TValue this[int index] => _values[index];

    public void RemoveAll()
    {
        _values.Clear();
        _lastIndex = 0;
    }
    
    public void Add(IReadOnlyCollection<TValue> values)
    {
        foreach (var v in values) Add(v);
    }

    public void Add(TValue value)
    {
        if (value is null) throw new ArgumentNullException(nameof(value));
        
        _values.Add(_lastIndex, value);
        _lastIndex++;
    }

    public void AddRange(IEnumerable<TValue> items)
    {
        foreach(var item in items) Add(item);
    }

    public bool Contains(TValue value)
    {
        if (value is null) throw new ArgumentNullException(nameof(value));

        return _values.ContainsValue(value);
    }

    public int Count => _values.Count;

    public IList<TValue> ToList()
    {
        return _values.Select(_ => _.Value).ToList();
    }

    public TValue[] ToArray()
    {
        return _values.Select(_ => _.Value).ToArray();
    }
}
