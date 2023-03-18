using System;
using System.Collections.Generic;
using System.Data;
using ImanN.DynamicFields;
using ImanN.DynamicFields.Exceptions;
using Xunit;

namespace DynamicFields.UnitTests;


public class int_tests
{

    [Theory]
    [InlineData(10, 12)]
    [InlineData(1, 50)]
    [InlineData(-6, -1)]
    public void should_throw_exception_if_max_constraint_violated(int max_constraint, int value)
    {
        var constraints = new List<Constraint<int>>
        {
            new MaxIntegerConstraint(max_constraint)
        };
        
        var field = new IntTestField(
            new DynamicFieldId<Guid>(Guid.NewGuid()), 
            "minINt", "min int", false, constraints);
        
        Assert.Throws<MaxIntegerException>(() => field.SetValue(value));
    }

    [Theory]
    [InlineData(20, 500000, 1, "min")]
    [InlineData(200, 300, 318, "max")]
    [InlineData(-10, 0, -11, "min")]
    public void should_throw_exception_if_min_or_max_constraints_violated(
        int min, int max, int value, string mode)
    {
        var constraints = new List<Constraint<int>>
        {
            new MinIntegerConstraint(min),
            new MaxIntegerConstraint(max)
        };

        var field = new IntTestField(
            new DynamicFieldId<Guid>(Guid.NewGuid()),
            "MyInt", "MyInt", true, constraints);

        if (mode == "min")
            Assert.Throws<MinIntegerException>(() => field.SetValue(value));
        else
            Assert.Throws<MaxIntegerException>(() => field.SetValue(value));
        
        // Assert.Throws<DynamicFieldConstraintViolationException>(() => field.SetValue(value));
    }
}