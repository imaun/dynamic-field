using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using Xunit;

namespace DynamicFields.UnitTests.Date;

public class date_tests
{
    [Fact]

    public void date_field_can_be_defined_with_valid_properties()
    {
        var date = new DateTestField(new DynamicFieldId<Guid>(Guid.NewGuid()),
            "Date", "Date", false, new List<Constraint<DateOnly>>());

        date.Set(2022, 10, 10);
        var expectedDate = new DateOnly(2022, 10, 10);
        Assert.Equal(date.Value,expectedDate);


    }
}