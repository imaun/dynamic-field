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


public class ArrayFieldValue<TValue> : List<TValue>
{
    
}