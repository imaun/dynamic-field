using System.Reflection.Metadata.Ecma335;

namespace ImanN.DynamicFields;

public class BooleanField : DynamicField<Guid, bool>
{
    public BooleanField(
        DynamicFieldId<Guid> id, 
        string name, 
        string title, 
        bool isRequired, 
        List<Constraint<bool>> constraints) : base(id, name, title, isRequired, constraints)
    {
    }

    protected BooleanField(DynamicFieldId<Guid> id) : base(id)
    {
    }

    protected BooleanField(): base()
    {
        Id = DynamicFieldId<Guid>.Create(Guid.NewGuid());
    }

    public string TrueCaption { get; set; }
    public string FalseCaption { get; set; }
    public string TrueCaptionSlug { get; set; }
    public string FalseCaptionSlug { get; set; }

    public static BooleanField Create()
    {
        return new BooleanField();
    }

    public static BooleanField Create(Guid id)
    {
        return new BooleanField(DynamicFieldId<Guid>.Create(id));
    }

    public BooleanField IsRequired(bool required = true)
    {
        Required = required;
        return this;
    }

    public BooleanField WithTitle(string title)
    {
        Title = title;
        return this;
    }

    public BooleanField WithName(string name)
    {
        Name = name;
        return this;
    }

    public BooleanField WithValue(bool value)
    {
        Value = value;
        return this;
    }

    public BooleanField WithCaption(string trueCaption, string falseCaption)
    {
        TrueCaption = trueCaption;
        FalseCaption = falseCaption;
        return this;
    }

    public BooleanField WithCaptionSlug(string trueCaptionSlug, string falseCaptionSlug)
    {
        TrueCaptionSlug = trueCaptionSlug;
        FalseCaptionSlug = falseCaptionSlug;
        return this;
    }
}