namespace ImanN.DynamicFields;


public class TextMinLenConstraint : Constraint<string>
{
    private readonly int _min;

    public TextMinLenConstraint(int min)
    {
        _min = min;
    }

    public static TextMinLenConstraint Create(int min)
    {
        return new TextMinLenConstraint(min);
    }

    public override string Name => "Text.MinLen";
    
    public override bool IsSatisfiedBy(string value)
    {
        return value.Length < _min;
    }

    public override void Validate(string value)
    {
        if (value.Length < _min) throw new TextMinLenException(_min);
    }
}