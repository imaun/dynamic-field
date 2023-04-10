using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using ImanN.DynamicFields.Types.DateRange;
using Xunit;

namespace DynamicFields.UnitTests.DateRange;

public class date_range_tests
{
    [Fact]
    public void defined_date_range_with_valid_properties()
    {
        var dateRange = new DateRangeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateRange", "DateRange"
            , false, new List<Constraint<DateRangeValue>>());
        dateRange.SetValue(new DateRangeValue(DateTime.Today, DateTime.Today.AddDays(2)));
        var expectedDate = new DateRangeValue(DateTime.Today, DateTime.Today.AddDays(2));
        Assert.Equal(expectedDate.StartDate,dateRange.Value.StartDate);
        Assert.Equal(expectedDate.EndDate,dateRange.Value.EndDate);
    }
}