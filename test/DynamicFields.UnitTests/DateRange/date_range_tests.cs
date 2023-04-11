using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using ImanN.DynamicFields.Exceptions;
using ImanN.DynamicFields.Types.DateRange;
using ImanN.DynamicFields.Types.DateRange.Constraints;
using Xunit;

namespace DynamicFields.UnitTests.DateRange;

public class date_range_tests
{
    [Fact]
    public void defined_date_range_with_valid_properties()
    {
        var dateRange = new DateRangeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateRange", "DateRange"
            , false, new List<Constraint<DateRangeValue>>());
        dateRange.SetValue(new DateRangeValue(System.DateTime.Today, System.DateTime.Today.AddDays(2)));
        var expectedDate = new DateRangeValue(System.DateTime.Today, System.DateTime.Today.AddDays(2));
        Assert.Equal(expectedDate.StartDate, dateRange.Value.StartDate);
        Assert.Equal(expectedDate.EndDate, dateRange.Value.EndDate);
    }

    [Fact]
    public void define_date_range_with_max_date_constraint()
    {
        var dateRange = new DateRangeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateRange", "DateRange", false
            , new List<Constraint<DateRangeValue>>()
            {
                new MaxDateRangeConstraint(new DateRangeValue(System.DateTime.Today, System.DateTime.Today.AddDays(3)))
            });
        var dateRangeError = () => dateRange.SetValue(new DateRangeValue(System.DateTime.Today, System.DateTime.Today.AddDays(4)));
        Assert.Throws<DateRangeMaxException>(dateRangeError);
    }

    [Fact]
    public void define_date_range_with_min_date_constraint()
    {
        var dateRange = new DateRangeField(new DynamicFieldId<Guid>(Guid.NewGuid()), "DateRange", "DateRange", false,
            new List<Constraint<DateRangeValue>>
            {
                new MinDateRangeConstraint(new DateRangeValue(System.DateTime.Today.AddDays(2), System.DateTime.Today.AddDays(5)))
            });
        var dateRangeError = () => dateRange.SetValue(new DateRangeValue(System.DateTime.Today, System.DateTime.Today.AddDays(20)));
        Assert.Throws<DateRangeMinException>(dateRangeError);
    }

    [Fact]
    public void define_date_range_value_with_startDate_Greater_than_EndDate()
    {
        var dateRangeException = () => new DateRangeValue(System.DateTime.Now.AddDays(3), System.DateTime.Today.AddDays(2));
        Assert.Throws<DateRangeStartDateGreaterThanEndDateException>(dateRangeException);
    }
}