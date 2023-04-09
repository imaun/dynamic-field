using System;
using System.Collections.Generic;
using ImanN.DynamicFields;

namespace DynamicFields.UnitTests.Date;

public class DateTestField :DateField
{
    public DateTestField(DynamicFieldId<Guid> id, string name, string title, 
        bool isRequired, List<Constraint<DateOnly>> constraints) : 
        base(id, name, title, isRequired, constraints)
    {
    }
}