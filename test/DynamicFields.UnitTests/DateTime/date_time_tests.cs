using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using Xunit;

namespace DynamicFields.UnitTests.DateTime;

public class date_time_tests
{
    [Fact]
    public void defined_date_time_with_valid_properties()
    {
        var dateTimeField = new DateTimeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateTime",
            "DateTime", false, new List<Constraint<System.DateTime>>());
        dateTimeField.SetValue(new System.DateTime(2022,10,10));
        var expectedDateTime = new System.DateTime(2022,10,10);
        Assert.Equal(expectedDateTime,dateTimeField.Value);
    }
}