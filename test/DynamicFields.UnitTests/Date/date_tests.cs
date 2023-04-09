using System;
using System.Collections.Generic;
using System.Linq;
using ImanN.DynamicFields;
using ImanN.DynamicFields.Exceptions;
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
        Assert.Equal(expectedDate,date.Value);
    }


    [Fact]
    public void date_field_can_not_be_defined_with_value_more_than_max_date_constraint()
    {
        var date = new DateField(new DynamicFieldId<Guid>(Guid.NewGuid()),"Date","Date",false,
        new List<Constraint<DateOnly>>()
        {
            new MaxDateConstraint(new DateOnly(2023,03,03))
        });
        date.Set(2024,1,1);
        var  a = date.Constraints.First();
        Assert.False(a.IsSatisfiedBy(date.Value));
        Assert.Throws<MaxDateException>(()=>a.Validate(date.Value));
    }
    
    [Fact]
    public void date_field_can_not_be_defined_with_value_more_than_min_date_constraint()
    {
        var date = new DateField(new DynamicFieldId<Guid>(Guid.NewGuid()),"Date","Date",false,
            new List<Constraint<DateOnly>>()
            {
                new MinDateConstraint(new DateOnly(2023,03,03))
            });
        date.Set(2022,1,1);
        var a = date.Constraints.First();
        Assert.False(date.Constraints.First().IsSatisfiedBy(date.Value));
        Assert.Throws<MinDateException>(()=>a.Validate(date.Value));
    }
    
    
}