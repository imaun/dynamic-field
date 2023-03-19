using System;
using ImanN.DynamicFields;
using Xunit;

namespace DynamicFields.UnitTests;

public class bool_tests
{

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void bool_field_can_be_defined(bool value)
    {
        var field = new BooleanTestField(
            new DynamicFieldId<Guid>(Guid.NewGuid()),
            "Bool", "Bool", true, null);

        field.FalseCaption = "ناردست";
        field.TrueCaption = "درست";
        field.SetValue(value);
        Assert.True(field.Value == value);
    }

    
    [Theory]
    [InlineData("Active?", "فعال؟", "بله", "خیر", "Yes", "No", true)]
    [InlineData("Active?", "فعال؟", "بله", "خیر", "Yes", "No", false)]
    public void bool_field_with_caption_can_be_defined(
        string name, string title,
        string trueCap, string falseCap, 
        string trueCapSlug, string falseCapSlug, bool value)
    {
        var field = BooleanField
            .Create()
            .WithName(name)
            .WithTitle(title)
            .WithCaption(trueCap, falseCap)
            .WithCaptionSlug(trueCapSlug, falseCapSlug)
            .IsRequired()
            .WithValue(value);
            
        Assert.Equal(field.Name, name);
        Assert.Equal(field.Title, title);
        Assert.Equal(field.TrueCaption, trueCap);
        Assert.Equal(field.FalseCaption, falseCap);
        Assert.Equal(field.TrueCaptionSlug, trueCapSlug);
        Assert.Equal(field.FalseCaptionSlug, falseCapSlug);
        Assert.Equal(field.Value, value);
    }
}