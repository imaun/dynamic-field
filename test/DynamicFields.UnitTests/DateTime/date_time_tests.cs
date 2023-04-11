using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using ImanN.DynamicFields.Constraints;
using ImanN.DynamicFields.Exceptions;
using Xunit;

namespace DynamicFields.UnitTests.DateTime;

public class date_time_tests
{
    [Fact]
    public void defined_date_time_with_valid_properties()
    {
        var dateTimeField = new DateTimeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateTime",
            "DateTime", false, new List<Constraint<System.DateTime>>());
        dateTimeField.SetValue(new System.DateTime(2022, 10, 10));
        var expectedDateTime = new System.DateTime(2022, 10, 10);
        Assert.Equal(expectedDateTime, dateTimeField.Value);
    }

    [Fact]
    public void defined_date_time_with_max_date_time_constraint()
    {
        var dateTimeField = new DateTimeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateTime",
            "DateTime", false, new List<Constraint<System.DateTime>>
            {
                new MaxDateTimeConstraint(new System.DateTime(2024, 01, 01))
            });
        var dateTimeException = () => dateTimeField.SetValue(new System.DateTime(2025, 10, 10));
        Assert.Throws<MaxDateTimeException>(dateTimeException);
    }
}