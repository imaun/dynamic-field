using System;
using System.Collections.Generic;
using ImanN.DynamicFields;

namespace DynamicFields.UnitTests;

public class BooleanTestField : BooleanField
{
    
    public BooleanTestField(
        DynamicFieldId<Guid> id, string name, string title, 
        bool isRequired, List<Constraint<bool>> constraints
        ) : base(id, name, title, isRequired, constraints)
    {
    }
}