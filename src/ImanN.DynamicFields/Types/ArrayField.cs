using System;
using System.Collections;
using System.Collections.Generic;

namespace ImanN.DynamicFields;

public class ArrayField<TValue> : DynamicField<Guid, ArrayFieldValue<TValue>>
{
    
    public ArrayField(
        DynamicFieldId<Guid> id, string name, 
        string title, bool isRequired, 
        List<Constraint< ArrayFieldValue<TValue>>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
    
    
}


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
}