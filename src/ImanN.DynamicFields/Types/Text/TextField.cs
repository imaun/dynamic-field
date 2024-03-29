namespace ImanN.DynamicFields;

public class TextField : DynamicField<Guid, string>
{

    public static TextField Create()
    {
        return new TextField { Id = DynamicFieldId<Guid>.Create(Guid.NewGuid()) };
    }

    public static TextField Create(Guid id)
    {
        return new TextField { Id = DynamicFieldId<Guid>.Create(id) };
    }

    public static TextField Create(Guid id, string value)
    {
        var field = new TextField { Id = DynamicFieldId<Guid>.Create(id) };
        field.SetValue(value);
        return field;
    }

    public TextField WithName(string name)
    {
        Name = name;
        return this;
    }

    public TextField WithTitle(string title)
    {
        Title = title;
        return this;
    }

    public TextField WithValue(string value)
    {
        SetValue(value);
        return this;
    }
    
}