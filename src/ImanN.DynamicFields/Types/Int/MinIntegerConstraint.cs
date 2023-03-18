namespace ImanN.DynamicFields;

public class MinIntegerConstraint : Constraint<int>
{
    private readonly int _min;

    public MinIntegerConstraint(int min)
    {
        _min = min;
    }
    
    public override string Name => "Int.Min";
    
    public override bool IsSatisfiedBy(int value)
    {
        return value > _min;
    }

    public override void Validate(int value)
    {
        if (value < _min) throw new MinIntegerException(_min);
    }
}