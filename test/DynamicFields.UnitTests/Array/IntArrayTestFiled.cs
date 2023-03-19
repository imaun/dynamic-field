using System;
using System.Collections.Generic;
using ImanN.DynamicFields;

namespace DynamicFields.UnitTests.Array;

public class IntArrayTestFiled : ArrayField<int>
{
    
    public IntArrayTestFiled(
        DynamicFieldId<Guid> id, string name, string title, 
        bool isRequired, List<Constraint<ArrayFieldValue<int>>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
}