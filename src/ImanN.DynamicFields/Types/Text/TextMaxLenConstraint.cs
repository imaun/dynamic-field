namespace ImanN.DynamicFields;


public class TextMaxLenConstraint : Constraint<string>
{
    private readonly int _max;

    public TextMaxLenConstraint(int max)
    {
        _max = max;
    }

    public override string Name => "Text.MaxLen";
    
    public override bool IsSatisfiedBy(string value)
    {
        return value.Length > _max;
    }

    public override void Validate(string value)
    {
        if (value.Length > _max) throw new TextMaxLenException(_max);
    }
}