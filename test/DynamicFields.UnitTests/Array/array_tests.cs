using System;
using System.Collections.Generic;
using ImanN.DynamicFields;
using Xunit;

namespace DynamicFields.UnitTests.Array;

public class array_tests
{

    [Fact]
    public void array_field_can_be_defined_with_valid_properties()
    {
        var arr = new IntArrayTestFiled(
            new DynamicFieldId<Guid>(Guid.NewGuid()),
            "Array", "Array", false, new List<Constraint<ArrayFieldValue<int>>>());
        
        arr.Value.Add(10);
        arr.Value.Add(11);
        arr.Value.Add(12);
        arr.Value.Add(13);
        arr.Value.Add(14);
        arr.Value.Add(15);
        
        Assert.True(arr.Value.Contains(10));
        Assert.Equal(6, arr.Value.Count);
    }
    
}