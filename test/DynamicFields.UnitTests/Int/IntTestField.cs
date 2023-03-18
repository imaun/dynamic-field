using System;
using System.Collections.Generic;
using ImanN.DynamicFields;

namespace DynamicFields.UnitTests;

public class IntTestField : IntegerField
{
    public IntTestField(
        DynamicFieldId<Guid> id, string name, string title, 
        bool isRequired, List<Constraint<int>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
    
}