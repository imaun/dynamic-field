using System;
using ImanN.DynamicFields;
using Xunit;

namespace DynamicFields.UnitTests;

public class text_tests
{

    [Theory]
    [InlineData("MyTextField")]
    public void text_field_can_be_defined_with_valid_properties(string text)
    {
        var field = TextField.Create(Guid.NewGuid(), text);
        Assert.Equal(text, field.Value);
    }

    
    [Theory]
    [InlineData("Iman", 10)]
    [InlineData("This is a test", 12)]
    [InlineData("Another test", 5)]
    public void text_field_with_max_constraint(string text, int maxLen)
    {
        var field = TextField.Create(Guid.NewGuid());
        var max_constraint = TextMaxLenConstraint.Create(maxLen);
        field.AddConstraint(max_constraint);
        bool is_valid = text.Length <= maxLen;
        if (is_valid)
        {
            field.SetValue(text);
            Assert.Equal(text, field.Value);
        }
        else
            Assert.Throws<TextMaxLenException>(() => field.SetValue(text));
    }

    [Theory]
    [InlineData("Iman", 5)]
    [InlineData("Here is the text", 10)]
    [InlineData("Here is another test", 50)]
    public void text_field_with_min_constraint(string text, int minLen)
    {
        var field = TextField.Create(Guid.NewGuid());
        var min_constraint = TextMinLenConstraint.Create(minLen);
        field.AddConstraint(min_constraint);
        bool is_valid = text.Length >= minLen;
        if (is_valid)
        {
            field.SetValue(text);
            Assert.Equal(text, field.Value);
        }
        else
        {
            Assert.Throws<TextMinLenException>(() => field.SetValue(text));
        }
    }
}