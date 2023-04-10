namespace ImanN.DynamicFields;

public class MinIntegerConstraint : Constraint<int>
{
    

    public MinIntegerConstraint(int min)
    {
        Value = min;
    }
    
    public override string Name => "Int.Min";
    
    public override bool IsSatisfiedBy(int value)
    {
        return value > Value;
    }

    public override void Validate(int value)
    {
        if (!IsSatisfiedBy(value)) throw new MinIntegerException(Value);
    }
}